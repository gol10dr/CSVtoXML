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
        Me.Button1 = New System.Windows.Forms.Button()
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
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(87, 192)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Convert"
        Me.Button1.UseVisualStyleBackColor = True
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
        Me.GroupBox2.Location = New System.Drawing.Point(6, 72)
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
        Me.GroupBox3.Location = New System.Drawing.Point(6, 135)
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
        'EPDMCSV2XML
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(253, 227)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EPDMCSV2XML"
        Me.Text = "EPDM CSVXML"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
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

End Class
