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
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        ' Read into an array of strings.
        Dim source As String() = File.ReadAllLines(csvpath.Text)
        Dim importxml As XElement = _
            <xml>
                <transactions>
                    <transaction date="1292976000" type="wf_import_document_attributes" vaultname=<%= VaultNameEntry.Text %>>
                        <%= From strs In source _
                            Let fields = Split(strs, ",") _
                            Select _
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
        MsgBox("The file '" + csvpath.Text + "' has been converted!" + vbCrLf + "The new XML is located here: " + xmlpath.Text, MsgBoxStyle.OkOnly
               )
    End Sub

    Private Sub VaultNameEntry_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VaultNameEntry.TextChanged

    End Sub
End Class
