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
        Me.SerialNoName = New System.Windows.Forms.TextBox()
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
        Me.ConvertButton.Location = New System.Drawing.Point(284, 222)
        Me.ConvertButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ConvertButton.Name = "ConvertButton"
        Me.ConvertButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ConvertButton.Size = New System.Drawing.Size(120, 28)
        Me.ConvertButton.TabIndex = 0
        Me.ConvertButton.Text = "Convert"
        Me.ConvertButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.VaultNameEntry)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 11)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(319, 63)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Vault Info:"
        '
        'VaultNameEntry
        '
        Me.VaultNameEntry.Location = New System.Drawing.Point(17, 23)
        Me.VaultNameEntry.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.VaultNameEntry.Name = "VaultNameEntry"
        Me.VaultNameEntry.Size = New System.Drawing.Size(292, 22)
        Me.VaultNameEntry.TabIndex = 0
        Me.VaultNameEntry.Text = "Enter Vault Name"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.csvbutton)
        Me.GroupBox2.Controls.Add(Me.csvpath)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 81)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(319, 63)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "CSV File:"
        '
        'csvbutton
        '
        Me.csvbutton.Location = New System.Drawing.Point(276, 22)
        Me.csvbutton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.csvbutton.Name = "csvbutton"
        Me.csvbutton.Size = New System.Drawing.Size(35, 26)
        Me.csvbutton.TabIndex = 1
        Me.csvbutton.Text = "..."
        Me.csvbutton.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.csvbutton.UseVisualStyleBackColor = True
        '
        'csvpath
        '
        Me.csvpath.Enabled = False
        Me.csvpath.Location = New System.Drawing.Point(17, 23)
        Me.csvpath.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.csvpath.Name = "csvpath"
        Me.csvpath.Size = New System.Drawing.Size(292, 22)
        Me.csvpath.TabIndex = 0
        Me.csvpath.Text = "Select csv file..."
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.xmlbutton)
        Me.GroupBox3.Controls.Add(Me.xmlpath)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 151)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(319, 63)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "XML File Output:"
        '
        'xmlbutton
        '
        Me.xmlbutton.Location = New System.Drawing.Point(276, 22)
        Me.xmlbutton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.xmlbutton.Name = "xmlbutton"
        Me.xmlbutton.Size = New System.Drawing.Size(35, 26)
        Me.xmlbutton.TabIndex = 2
        Me.xmlbutton.Text = "..."
        Me.xmlbutton.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.xmlbutton.UseVisualStyleBackColor = True
        '
        'xmlpath
        '
        Me.xmlpath.Enabled = False
        Me.xmlpath.Location = New System.Drawing.Point(17, 23)
        Me.xmlpath.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.xmlpath.Name = "xmlpath"
        Me.xmlpath.Size = New System.Drawing.Size(263, 22)
        Me.xmlpath.TabIndex = 0
        Me.xmlpath.Text = "Select XML output path..."
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ImportType
        '
        Me.ImportType.FormattingEnabled = True
        Me.ImportType.Items.AddRange(New Object() {"Variable Values", "List Values", "Serial Numbers", "Notifications"})
        Me.ImportType.Location = New System.Drawing.Point(8, 22)
        Me.ImportType.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ImportType.Name = "ImportType"
        Me.ImportType.Size = New System.Drawing.Size(292, 24)
        Me.ImportType.TabIndex = 4
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.ImportType)
        Me.GroupBox4.Location = New System.Drawing.Point(353, 11)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox4.Size = New System.Drawing.Size(311, 63)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Import Type:"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.SerialNoName)
        Me.GroupBox5.Controls.Add(Me.ImportMode)
        Me.GroupBox5.Location = New System.Drawing.Point(353, 81)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox5.Size = New System.Drawing.Size(311, 63)
        Me.GroupBox5.TabIndex = 5
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Import Mode: (serial numbers only)"
        '
        'SerialNoName
        '
        Me.SerialNoName.AccessibleName = ""
        Me.SerialNoName.Enabled = False
        Me.SerialNoName.Location = New System.Drawing.Point(131, 21)
        Me.SerialNoName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SerialNoName.Name = "SerialNoName"
        Me.SerialNoName.Size = New System.Drawing.Size(169, 22)
        Me.SerialNoName.TabIndex = 1
        Me.SerialNoName.Text = "Enter Serial No. Name"
        '
        'ImportMode
        '
        Me.ImportMode.Enabled = False
        Me.ImportMode.FormattingEnabled = True
        Me.ImportMode.Items.AddRange(New Object() {"append", "replace"})
        Me.ImportMode.Location = New System.Drawing.Point(8, 21)
        Me.ImportMode.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ImportMode.Name = "ImportMode"
        Me.ImportMode.Size = New System.Drawing.Size(113, 24)
        Me.ImportMode.TabIndex = 4
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.ImportDate)
        Me.GroupBox6.Location = New System.Drawing.Point(353, 151)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox6.Size = New System.Drawing.Size(311, 63)
        Me.GroupBox6.TabIndex = 5
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Import Date:"
        '
        'ImportDate
        '
        Me.ImportDate.Location = New System.Drawing.Point(8, 31)
        Me.ImportDate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ImportDate.Name = "ImportDate"
        Me.ImportDate.Size = New System.Drawing.Size(292, 22)
        Me.ImportDate.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(493, 226)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 17)
        Me.Label1.TabIndex = 6
        '
        'EPOC_Label
        '
        Me.EPOC_Label.AutoSize = True
        Me.EPOC_Label.Location = New System.Drawing.Point(441, 226)
        Me.EPOC_Label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.EPOC_Label.Name = "EPOC_Label"
        Me.EPOC_Label.Size = New System.Drawing.Size(100, 17)
        Me.EPOC_Label.TabIndex = 7
        Me.EPOC_Label.Text = "EPOC Number"
        Me.EPOC_Label.Visible = False
        '
        'EPDMCSV2XML
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(680, 257)
        Me.Controls.Add(Me.EPOC_Label)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ConvertButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "EPDMCSV2XML"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EPDM CSVXML"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
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
    Friend WithEvents SerialNoName As System.Windows.Forms.TextBox

End Class
