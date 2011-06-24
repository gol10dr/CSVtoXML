<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EPDMCSV2XML
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EPDMCSV2XML))
        Me.ConvertButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.VaultNameEntry = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.csvbutton = New System.Windows.Forms.Button()
        Me.csvpath = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.xmlbutton = New System.Windows.Forms.Button()
        Me.xmlpath = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.ImportType = New System.Windows.Forms.ComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.ImportMode = New System.Windows.Forms.ComboBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.ImportDate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EPOC_Label = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'ConvertButton
        '
        Me.ConvertButton.Location = New System.Drawing.Point(213, 180)
        Me.ConvertButton.Name = "ConvertButton"
        Me.ConvertButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ConvertButton.Size = New System.Drawing.Size(90, 23)
        Me.ConvertButton.TabIndex = 0
        Me.ConvertButton.Text = "Convert"
        Me.ConvertButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.VaultNameEntry)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(239, 51)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Vault Info:"
        '
        'VaultNameEntry
        '
        Me.VaultNameEntry.Location = New System.Drawing.Point(13, 19)
        Me.VaultNameEntry.Name = "VaultNameEntry"
        Me.VaultNameEntry.Size = New System.Drawing.Size(220, 20)
        Me.VaultNameEntry.TabIndex = 0
        Me.VaultNameEntry.Text = "Enter Vault Name"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.csvbutton)
        Me.GroupBox2.Controls.Add(Me.csvpath)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 66)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(239, 51)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "CSV File:"
        '
        'csvbutton
        '
        Me.csvbutton.Location = New System.Drawing.Point(207, 18)
        Me.csvbutton.Name = "csvbutton"
        Me.csvbutton.Size = New System.Drawing.Size(26, 21)
        Me.csvbutton.TabIndex = 1
        Me.csvbutton.Text = "..."
        Me.csvbutton.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.csvbutton.UseVisualStyleBackColor = True
        '
        'csvpath
        '
        Me.csvpath.Location = New System.Drawing.Point(13, 19)
        Me.csvpath.Name = "csvpath"
        Me.csvpath.Size = New System.Drawing.Size(220, 20)
        Me.csvpath.TabIndex = 0
        Me.csvpath.Text = "Select csv file..."
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.xmlbutton)
        Me.GroupBox3.Controls.Add(Me.xmlpath)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 123)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(239, 51)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "XML File Output:"
        '
        'xmlbutton
        '
        Me.xmlbutton.Location = New System.Drawing.Point(207, 18)
        Me.xmlbutton.Name = "xmlbutton"
        Me.xmlbutton.Size = New System.Drawing.Size(26, 21)
        Me.xmlbutton.TabIndex = 2
        Me.xmlbutton.Text = "..."
        Me.xmlbutton.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.xmlbutton.UseVisualStyleBackColor = True
        '
        'xmlpath
        '
        Me.xmlpath.Location = New System.Drawing.Point(13, 19)
        Me.xmlpath.Name = "xmlpath"
        Me.xmlpath.Size = New System.Drawing.Size(198, 20)
        Me.xmlpath.TabIndex = 0
        Me.xmlpath.Text = "c:\temp\"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ImportType
        '
        Me.ImportType.FormattingEnabled = True
        Me.ImportType.Items.AddRange(New Object() {"Variable Values", "List Values", "Serial Numbers", "Notifications"})
        Me.ImportType.Location = New System.Drawing.Point(6, 18)
        Me.ImportType.Name = "ImportType"
        Me.ImportType.Size = New System.Drawing.Size(220, 21)
        Me.ImportType.TabIndex = 4
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.ImportType)
        Me.GroupBox4.Location = New System.Drawing.Point(265, 9)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(233, 51)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Import Type:"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.ImportMode)
        Me.GroupBox5.Location = New System.Drawing.Point(265, 66)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(233, 51)
        Me.GroupBox5.TabIndex = 5
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Import Mode: (serial numbers only)"
        '
        'ImportMode
        '
        Me.ImportMode.FormattingEnabled = True
        Me.ImportMode.Items.AddRange(New Object() {"append", "replace"})
        Me.ImportMode.Location = New System.Drawing.Point(6, 18)
        Me.ImportMode.Name = "ImportMode"
        Me.ImportMode.Size = New System.Drawing.Size(220, 21)
        Me.ImportMode.TabIndex = 4
        Me.ImportMode.Visible = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.ImportDate)
        Me.GroupBox6.Location = New System.Drawing.Point(265, 123)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(233, 51)
        Me.GroupBox6.TabIndex = 5
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Import Date:"
        '
        'ImportDate
        '
        Me.ImportDate.Location = New System.Drawing.Point(6, 25)
        Me.ImportDate.Name = "ImportDate"
        Me.ImportDate.Size = New System.Drawing.Size(220, 20)
        Me.ImportDate.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(370, 184)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 6
        '
        'EPOC_Label
        '
        Me.EPOC_Label.AutoSize = True
        Me.EPOC_Label.Location = New System.Drawing.Point(331, 184)
        Me.EPOC_Label.Name = "EPOC_Label"
        Me.EPOC_Label.Size = New System.Drawing.Size(36, 13)
        Me.EPOC_Label.TabIndex = 7
        Me.EPOC_Label.Text = "EPOC"
        '
        'EPDMCSV2XML
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 209)
        Me.Controls.Add(Me.EPOC_Label)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ConvertButton)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EPDMCSV2XML"
        Me.Text = "EPDM CSVXML"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ConvertButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents VaultNameEntry As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents csvpath As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents xmlpath As System.Windows.Forms.TextBox
    Friend WithEvents csvbutton As System.Windows.Forms.Button
    Friend WithEvents xmlbutton As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents ImportType As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents ImportMode As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents ImportDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents EPOC_Label As System.Windows.Forms.Label

End Class
