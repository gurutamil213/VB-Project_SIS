<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.entrymenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.findmenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.certificatemenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.infomenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.exitmenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.entrymenu, Me.findmenu, Me.certificatemenu, Me.infomenu, Me.exitmenu})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1827, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'entrymenu
        '
        Me.entrymenu.Name = "entrymenu"
        Me.entrymenu.Size = New System.Drawing.Size(54, 24)
        Me.entrymenu.Text = "Entry"
        '
        'findmenu
        '
        Me.findmenu.Name = "findmenu"
        Me.findmenu.Size = New System.Drawing.Size(49, 24)
        Me.findmenu.Text = "Find"
        '
        'certificatemenu
        '
        Me.certificatemenu.Name = "certificatemenu"
        Me.certificatemenu.Size = New System.Drawing.Size(95, 24)
        Me.certificatemenu.Text = "Certificates"
        '
        'infomenu
        '
        Me.infomenu.Name = "infomenu"
        Me.infomenu.Size = New System.Drawing.Size(47, 24)
        Me.infomenu.Text = "info"
        '
        'exitmenu
        '
        Me.exitmenu.Name = "exitmenu"
        Me.exitmenu.Size = New System.Drawing.Size(45, 24)
        Me.exitmenu.Text = "Exit"
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1827, 882)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Dashboard"
        Me.Text = "STUDENT INFROMATION SYSTEM"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents entrymenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents findmenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents certificatemenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents infomenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents exitmenu As System.Windows.Forms.ToolStripMenuItem
End Class
