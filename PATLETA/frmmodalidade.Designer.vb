<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmodalidade
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmmodalidade))
        Me.PATLETADataSet = New PATLETA.PATLETADataSet()
        Me.MODALIDADEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MODALIDADETableAdapter = New PATLETA.PATLETADataSetTableAdapters.MODALIDADETableAdapter()
        Me.TableAdapterManager = New PATLETA.PATLETADataSetTableAdapters.TableAdapterManager()
        Me.bnvModalidade = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.btnAdicionar = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.btnExcluir = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnSalvar = New System.Windows.Forms.ToolStripButton()
        Me.btnAlterar = New System.Windows.Forms.ToolStripButton()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.btnSair = New System.Windows.Forms.ToolStripButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tbDados = New System.Windows.Forms.TabPage()
        Me.dgvModalidade = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbDetalhes = New System.Windows.Forms.TabPage()
        Me.txtModalidade = New System.Windows.Forms.TextBox()
        Me.lblModalidade = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lblID = New System.Windows.Forms.Label()
        CType(Me.PATLETADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MODALIDADEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bnvModalidade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnvModalidade.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tbDados.SuspendLayout()
        CType(Me.dgvModalidade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbDetalhes.SuspendLayout()
        Me.SuspendLayout()
        '
        'PATLETADataSet
        '
        Me.PATLETADataSet.DataSetName = "PATLETADataSet"
        Me.PATLETADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MODALIDADEBindingSource
        '
        Me.MODALIDADEBindingSource.DataMember = "MODALIDADE"
        Me.MODALIDADEBindingSource.DataSource = Me.PATLETADataSet
        '
        'MODALIDADETableAdapter
        '
        Me.MODALIDADETableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ATLETATableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.MODALIDADETableAdapter = Me.MODALIDADETableAdapter
        Me.TableAdapterManager.PAISTableAdapter = Nothing
        Me.TableAdapterManager.PROVATableAdapter = Nothing
        Me.TableAdapterManager.Table_1TableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PATLETA.PATLETADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'bnvModalidade
        '
        Me.bnvModalidade.AddNewItem = Me.btnAdicionar
        Me.bnvModalidade.BindingSource = Me.MODALIDADEBindingSource
        Me.bnvModalidade.CountItem = Me.BindingNavigatorCountItem
        Me.bnvModalidade.DeleteItem = Me.btnExcluir
        Me.bnvModalidade.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.btnAdicionar, Me.btnExcluir, Me.btnSalvar, Me.btnAlterar, Me.btnCancelar, Me.btnSair})
        Me.bnvModalidade.Location = New System.Drawing.Point(0, 0)
        Me.bnvModalidade.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.bnvModalidade.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.bnvModalidade.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.bnvModalidade.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.bnvModalidade.Name = "bnvModalidade"
        Me.bnvModalidade.PositionItem = Me.BindingNavigatorPositionItem
        Me.bnvModalidade.Size = New System.Drawing.Size(484, 25)
        Me.bnvModalidade.TabIndex = 1
        Me.bnvModalidade.Text = "BindingNavigator1"
        '
        'btnAdicionar
        '
        Me.btnAdicionar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnAdicionar.Image = CType(resources.GetObject("btnAdicionar.Image"), System.Drawing.Image)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.RightToLeftAutoMirrorImage = True
        Me.btnAdicionar.Size = New System.Drawing.Size(23, 22)
        Me.btnAdicionar.Text = "Adicionar"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'btnExcluir
        '
        Me.btnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnExcluir.Image = CType(resources.GetObject("btnExcluir.Image"), System.Drawing.Image)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.RightToLeftAutoMirrorImage = True
        Me.btnExcluir.Size = New System.Drawing.Size(23, 22)
        Me.btnExcluir.Text = "Excluir"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'btnSalvar
        '
        Me.btnSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSalvar.Image = CType(resources.GetObject("btnSalvar.Image"), System.Drawing.Image)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(23, 22)
        Me.btnSalvar.Text = "Salvar"
        '
        'btnAlterar
        '
        Me.btnAlterar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnAlterar.Image = CType(resources.GetObject("btnAlterar.Image"), System.Drawing.Image)
        Me.btnAlterar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(23, 22)
        Me.btnAlterar.Text = "Alterar"
        '
        'btnCancelar
        '
        Me.btnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(23, 22)
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnSair
        '
        Me.btnSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(23, 22)
        Me.btnSair.Text = "Sair"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tbDados)
        Me.TabControl1.Controls.Add(Me.tbDetalhes)
        Me.TabControl1.Location = New System.Drawing.Point(12, 28)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(464, 277)
        Me.TabControl1.TabIndex = 2
        '
        'tbDados
        '
        Me.tbDados.AutoScroll = True
        Me.tbDados.Controls.Add(Me.dgvModalidade)
        Me.tbDados.Location = New System.Drawing.Point(4, 22)
        Me.tbDados.Name = "tbDados"
        Me.tbDados.Padding = New System.Windows.Forms.Padding(3)
        Me.tbDados.Size = New System.Drawing.Size(456, 251)
        Me.tbDados.TabIndex = 0
        Me.tbDados.Text = "Dados"
        Me.tbDados.UseVisualStyleBackColor = True
        '
        'dgvModalidade
        '
        Me.dgvModalidade.AutoGenerateColumns = False
        Me.dgvModalidade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvModalidade.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.dgvModalidade.DataSource = Me.MODALIDADEBindingSource
        Me.dgvModalidade.Location = New System.Drawing.Point(6, 6)
        Me.dgvModalidade.Name = "dgvModalidade"
        Me.dgvModalidade.Size = New System.Drawing.Size(444, 202)
        Me.dgvModalidade.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IDMODALIDADE"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IDMODALIDADE"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NOMEMODALIDADE"
        Me.DataGridViewTextBoxColumn2.HeaderText = "NOMEMODALIDADE"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'tbDetalhes
        '
        Me.tbDetalhes.Controls.Add(Me.txtModalidade)
        Me.tbDetalhes.Controls.Add(Me.lblModalidade)
        Me.tbDetalhes.Controls.Add(Me.txtID)
        Me.tbDetalhes.Controls.Add(Me.lblID)
        Me.tbDetalhes.Location = New System.Drawing.Point(4, 22)
        Me.tbDetalhes.Name = "tbDetalhes"
        Me.tbDetalhes.Padding = New System.Windows.Forms.Padding(3)
        Me.tbDetalhes.Size = New System.Drawing.Size(456, 251)
        Me.tbDetalhes.TabIndex = 1
        Me.tbDetalhes.Text = "Detalhes"
        Me.tbDetalhes.UseVisualStyleBackColor = True
        '
        'txtModalidade
        '
        Me.txtModalidade.Location = New System.Drawing.Point(129, 113)
        Me.txtModalidade.Name = "txtModalidade"
        Me.txtModalidade.Size = New System.Drawing.Size(192, 20)
        Me.txtModalidade.TabIndex = 1
        '
        'lblModalidade
        '
        Me.lblModalidade.AutoSize = True
        Me.lblModalidade.Location = New System.Drawing.Point(48, 113)
        Me.lblModalidade.Name = "lblModalidade"
        Me.lblModalidade.Size = New System.Drawing.Size(62, 13)
        Me.lblModalidade.TabIndex = 0
        Me.lblModalidade.Text = "Modalidade"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(129, 62)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(192, 20)
        Me.txtID.TabIndex = 1
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(92, 65)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(18, 13)
        Me.lblID.TabIndex = 0
        Me.lblID.Text = "ID"
        '
        'frmmodalidade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 317)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.bnvModalidade)
        Me.Name = "frmmodalidade"
        Me.Text = "Modalidades"
        CType(Me.PATLETADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MODALIDADEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bnvModalidade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnvModalidade.ResumeLayout(False)
        Me.bnvModalidade.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.tbDados.ResumeLayout(False)
        CType(Me.dgvModalidade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbDetalhes.ResumeLayout(False)
        Me.tbDetalhes.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PATLETADataSet As PATLETADataSet
    Friend WithEvents MODALIDADEBindingSource As BindingSource
    Friend WithEvents MODALIDADETableAdapter As PATLETADataSetTableAdapters.MODALIDADETableAdapter
    Friend WithEvents TableAdapterManager As PATLETADataSetTableAdapters.TableAdapterManager
    Friend WithEvents bnvModalidade As BindingNavigator
    Friend WithEvents btnAdicionar As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents btnExcluir As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents btnSalvar As ToolStripButton
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tbDados As TabPage
    Friend WithEvents dgvModalidade As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents tbDetalhes As TabPage
    Friend WithEvents txtModalidade As TextBox
    Friend WithEvents lblModalidade As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents lblID As Label
    Friend WithEvents btnAlterar As ToolStripButton
    Friend WithEvents btnCancelar As ToolStripButton
    Friend WithEvents btnSair As ToolStripButton
End Class
