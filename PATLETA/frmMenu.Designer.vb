<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CadastroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaísesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModalidadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AtletasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProvasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SobreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastroToolStripMenuItem, Me.ProvasToolStripMenuItem, Me.SobreToolStripMenuItem, Me.SairToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(288, 29)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CadastroToolStripMenuItem
        '
        Me.CadastroToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PaísesToolStripMenuItem, Me.ModalidadesToolStripMenuItem, Me.AtletasToolStripMenuItem})
        Me.CadastroToolStripMenuItem.Name = "CadastroToolStripMenuItem"
        Me.CadastroToolStripMenuItem.Size = New System.Drawing.Size(84, 25)
        Me.CadastroToolStripMenuItem.Text = "Cadastro"
        '
        'PaísesToolStripMenuItem
        '
        Me.PaísesToolStripMenuItem.Name = "PaísesToolStripMenuItem"
        Me.PaísesToolStripMenuItem.Size = New System.Drawing.Size(169, 26)
        Me.PaísesToolStripMenuItem.Text = "Países"
        '
        'ModalidadesToolStripMenuItem
        '
        Me.ModalidadesToolStripMenuItem.Name = "ModalidadesToolStripMenuItem"
        Me.ModalidadesToolStripMenuItem.Size = New System.Drawing.Size(169, 26)
        Me.ModalidadesToolStripMenuItem.Text = "Modalidades"
        '
        'AtletasToolStripMenuItem
        '
        Me.AtletasToolStripMenuItem.Name = "AtletasToolStripMenuItem"
        Me.AtletasToolStripMenuItem.Size = New System.Drawing.Size(169, 26)
        Me.AtletasToolStripMenuItem.Text = "Atletas"
        '
        'ProvasToolStripMenuItem
        '
        Me.ProvasToolStripMenuItem.Name = "ProvasToolStripMenuItem"
        Me.ProvasToolStripMenuItem.Size = New System.Drawing.Size(69, 25)
        Me.ProvasToolStripMenuItem.Text = "Provas"
        '
        'SobreToolStripMenuItem
        '
        Me.SobreToolStripMenuItem.Name = "SobreToolStripMenuItem"
        Me.SobreToolStripMenuItem.Size = New System.Drawing.Size(63, 25)
        Me.SobreToolStripMenuItem.Text = "Sobre"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(49, 25)
        Me.SairToolStripMenuItem.Text = "Sair"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(9, 62)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(267, 84)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(288, 186)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMenu"
        Me.Text = "Painel Atleta"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CadastroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProvasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SobreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PaísesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModalidadesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AtletasToolStripMenuItem As ToolStripMenuItem
End Class
