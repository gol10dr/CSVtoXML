Imports System.IO
Imports System.Xml

Public Class EPDMCSV2XML
    'Select file path for csv import
    Private Sub csvbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles csvbutton.Click
        OpenFileDialog1.Title = "Select a source CSV to convert..."
        OpenFileDialog1.InitialDirectory = "C:\"

        OpenFileDialog1.ShowDialog()
    End Sub
    'Write selected path to UI
    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

        Dim strm As System.IO.Stream
        strm = OpenFileDialog1.OpenFile()
        csvpath.Text = OpenFileDialog1.FileName.ToString()
        If Not (strm Is Nothing) Then
            'insert code to read the file data
            strm.Close()
        End If
    End Sub
    'Select path for XML output
    Private Sub xmlbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xmlbutton.Click
        FolderBrowserDialog1.ShowDialog()
        xmlpath.Text = FolderBrowserDialog1.SelectedPath.ToString()
    End Sub
    Private Sub ConvertButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConvertButton.Click

        ' Determine EPOCH Date
        Dim curdate As Date = ImportDate.Text
        Dim tdate As Integer
        tdate = CInt(curdate.Subtract(CDate("1.1.1970 00:00:00")).TotalSeconds)
        EPOC_Label.Text = tdate

        ' Check to see if a vault name has been entered
        If VaultNameEntry.Text = "Enter Vault Name" Then
            MsgBox("Please enter a valid valut name before converting", MsgBoxStyle.OkOnly)
            Exit Sub
        End If

        ' Determine import type and if missing prompt
        Dim ttype As String = Nothing
        If ImportType.Text = "Variable Values" Then
            ttype = "wf_import_document_attributes"
        ElseIf ImportType.Text = "List Vaules" Then
            ttype = "import_lists"
        ElseIf ImportType.Text = "Serial Numbers" Then
            ttype = "import_serial_numbers"
        ElseIf ImportType.Text = "Notifications" Then
            ttype = "import_notifications"
        Else
            MsgBox("Please select an import type from the list", MsgBoxStyle.OkOnly)
            Exit Sub
        End If

        ' Check to see if a csv file has been selected
        If csvpath.Text = "Select csv file..." Then
            MsgBox("Please browse for a csv file before converting", MsgBoxStyle.OkOnly)
            Exit Sub
        End If

        ' Check for serial numbers type is selected
        If ttype = "import_serial_numbers" And ImportMode.Text = "" Then
            MsgBox("Please select an import mode from the list", MsgBoxStyle.OkOnly)
            Exit Sub
        End If

        ' Read into an array of strings.
        Dim source As String() = File.ReadAllLines(csvpath.Text)
        Dim importxml As XElement = _
            <xml>
                <transactions>
                    <transaction date=<%= tdate %> type=<%= ttype %> vaultname=<%= VaultNameEntry.Text %>>
                        <%= From strs In source _
                            Let fields = Split(strs, ",")
                            Where Not fields(0) = "id" Select _
                            <document aliasset="" id=<%= fields(0) %> idattribute=<%= fields(1) %> idcfgname=<%= fields(2) %> pdmweid="0">
                                <configuration name=<%= fields(3) %>>
                                    <attribute name=<%= fields(4) %> value=<%= fields(5) %>/>
                                    <attribute name=<%= fields(6) %> value=<%= fields(7) %>/>
                                    <attribute name=<%= fields(8) %> value=<%= fields(9) %>/>
                                    <attribute name=<%= fields(10) %> value=<%= fields(11) %>/>
                                    <attribute name=<%= fields(12) %> value=<%= fields(13) %>/>
                                </configuration>
                            </document> %>
                    </transaction>
                </transactions>
            </xml>
        Console.WriteLine(importxml)
        File.WriteAllText((xmlpath.Text + "\import.xml"), importxml.ToString)
        MsgBox("The file '" + csvpath.Text + "' has been converted!" + vbCrLf + "The new XML is located here: " + xmlpath.Text, MsgBoxStyle.OkOnly)
    End Sub

    Private Sub ImportType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImportType.SelectedValueChanged
        If ImportType.Text = "Serial Numbers" Then
            ImportMode.Visible = True
        Else : ImportMode.Visible = False
        End If
    End Sub

End Class