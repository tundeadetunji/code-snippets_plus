<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.dropSection = New System.Windows.Forms.ComboBox()
        Me.dropGroup = New System.Windows.Forms.ComboBox()
        Me.dropSnippet = New System.Windows.Forms.ComboBox()
        Me.textSnippet = New System.Windows.Forms.TextBox()
        Me.textFileLocation = New System.Windows.Forms.TextBox()
        Me.buttonReload = New System.Windows.Forms.Button()
        Me.buttonShowFileLocation = New System.Windows.Forms.Button()
        Me.folderPaths = New System.Windows.Forms.ComboBox()
        Me.fileNames = New System.Windows.Forms.ComboBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'dropSection
        '
        Me.dropSection.FormattingEnabled = True
        Me.dropSection.Location = New System.Drawing.Point(12, 14)
        Me.dropSection.Name = "dropSection"
        Me.dropSection.Size = New System.Drawing.Size(686, 27)
        Me.dropSection.TabIndex = 0
        '
        'dropGroup
        '
        Me.dropGroup.FormattingEnabled = True
        Me.dropGroup.Location = New System.Drawing.Point(12, 47)
        Me.dropGroup.Name = "dropGroup"
        Me.dropGroup.Size = New System.Drawing.Size(686, 27)
        Me.dropGroup.TabIndex = 1
        '
        'dropSnippet
        '
        Me.dropSnippet.FormattingEnabled = True
        Me.dropSnippet.Location = New System.Drawing.Point(12, 80)
        Me.dropSnippet.Name = "dropSnippet"
        Me.dropSnippet.Size = New System.Drawing.Size(686, 27)
        Me.dropSnippet.TabIndex = 2
        '
        'textSnippet
        '
        Me.textSnippet.Location = New System.Drawing.Point(12, 113)
        Me.textSnippet.Multiline = True
        Me.textSnippet.Name = "textSnippet"
        Me.textSnippet.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.textSnippet.Size = New System.Drawing.Size(686, 208)
        Me.textSnippet.TabIndex = 3
        Me.textSnippet.WordWrap = False
        '
        'textFileLocation
        '
        Me.textFileLocation.Location = New System.Drawing.Point(12, 342)
        Me.textFileLocation.Name = "textFileLocation"
        Me.textFileLocation.Size = New System.Drawing.Size(686, 26)
        Me.textFileLocation.TabIndex = 4
        '
        'buttonReload
        '
        Me.buttonReload.FlatAppearance.BorderSize = 0
        Me.buttonReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonReload.Image = Global.SnippetsPlus.My.Resources.Resources.reload_icon_16
        Me.buttonReload.Location = New System.Drawing.Point(704, 261)
        Me.buttonReload.Name = "buttonReload"
        Me.buttonReload.Size = New System.Drawing.Size(40, 27)
        Me.buttonReload.TabIndex = 5
        Me.buttonReload.UseVisualStyleBackColor = True
        '
        'buttonShowFileLocation
        '
        Me.buttonShowFileLocation.FlatAppearance.BorderSize = 0
        Me.buttonShowFileLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonShowFileLocation.Location = New System.Drawing.Point(704, 294)
        Me.buttonShowFileLocation.Name = "buttonShowFileLocation"
        Me.buttonShowFileLocation.Size = New System.Drawing.Size(40, 27)
        Me.buttonShowFileLocation.TabIndex = 6
        Me.buttonShowFileLocation.Text = "..."
        Me.buttonShowFileLocation.UseVisualStyleBackColor = True
        '
        'folderPaths
        '
        Me.folderPaths.FormattingEnabled = True
        Me.folderPaths.Location = New System.Drawing.Point(781, 47)
        Me.folderPaths.Name = "folderPaths"
        Me.folderPaths.Size = New System.Drawing.Size(121, 27)
        Me.folderPaths.TabIndex = 7
        Me.folderPaths.TabStop = False
        '
        'fileNames
        '
        Me.fileNames.FormattingEnabled = True
        Me.fileNames.Location = New System.Drawing.Point(781, 47)
        Me.fileNames.Name = "fileNames"
        Me.fileNames.Size = New System.Drawing.Size(121, 27)
        Me.fileNames.TabIndex = 8
        Me.fileNames.TabStop = False
        '
        'Timer1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(750, 379)
        Me.Controls.Add(Me.fileNames)
        Me.Controls.Add(Me.folderPaths)
        Me.Controls.Add(Me.buttonShowFileLocation)
        Me.Controls.Add(Me.buttonReload)
        Me.Controls.Add(Me.textFileLocation)
        Me.Controls.Add(Me.textSnippet)
        Me.Controls.Add(Me.dropSnippet)
        Me.Controls.Add(Me.dropGroup)
        Me.Controls.Add(Me.dropSection)
        Me.Font = New System.Drawing.Font("DejaVu Sans Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Snippets Plus"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dropSection As ComboBox
    Friend WithEvents dropGroup As ComboBox
    Friend WithEvents dropSnippet As ComboBox
    Friend WithEvents textSnippet As TextBox
    Friend WithEvents textFileLocation As TextBox
    Friend WithEvents buttonReload As Button
    Friend WithEvents buttonShowFileLocation As Button
    Friend WithEvents folderPaths As ComboBox
    Friend WithEvents fileNames As ComboBox
    Friend WithEvents Timer1 As Timer
End Class
