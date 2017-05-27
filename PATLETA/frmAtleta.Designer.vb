<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAtleta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAtleta))
        Me.PATLETADataSet = New PATLETA.PATLETADataSet()
        Me.ATLETABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ATLETATableAdapter = New PATLETA.PATLETADataSetTableAdapters.ATLETATableAdapter()
        Me.TableAdapterManager = New PATLETA.PATLETADataSetTableAdapters.TableAdapterManager()
        Me.ATLETABindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.ATLETABindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        CType(Me.PATLETADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ATLETABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ATLETABindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ATLETABindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'PATLETADataSet
        '
        Me.PATLETADataSet.DataSetName = "PATLETADataSet"
        Me.PATLETADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ATLETABindingSource
        '
        Me.ATLETABindingSource.DataMember = "ATLETA"
        Me.ATLETABindingSource.DataSource = Me.PATLETADataSet
        '
        'ATLETATableAdapter
        '
        Me.ATLETATableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ATLETATableAdapter = Me.ATLETATableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.MODALIDADETableAdapter = Nothing
        Me.TableAdapterManager.PAISTableAdapter = Nothing
        Me.TableAdapterManager.PROVATableAdapter = Nothing
        Me.TableAdapterManager.Table_1TableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PATLETA.PATLETADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ATLETABindingNavigator
        '
        Me.ATLETABindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ATLETABindingNavigator.BindingSource = Me.ATLETABindingSource
        Me.ATLETABindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ATLETABindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ATLETABindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ATLETABindingNavigatorSaveItem})
        Me.ATLETABindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ATLETABindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ATLETABindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ATLETABindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ATLETABindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ATLETABindingNavigator.Name = "ATLETABindingNavigator"
        Me.ATLETABindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ATLETABindingNavigator.Size = New System.Drawing.Size(111, 25)
        Me.ATLETABindingNavigator.TabIndex = 0
        Me.ATLETABindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'ATLETABindingNavigatorSaveItem
        '
        Me.ATLETABindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ATLETABindingNavigatorSaveItem.Image = CType(resources.GetObject("ATLETABindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ATLETABindingNavigatorSaveItem.Name = "ATLETABindingNavigatorSaveItem"
        Me.ATLETABindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.ATLETABindingNavigatorSaveItem.Text = "Save Data"
        '
        'frmCadastro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.ClientSize = New System.Drawing.Size(458, 308)
        Me.Controls.Add(Me.ATLETABindingNavigator)
        Me.Name = "frmCadastro"
        Me.Text = "Cadastro"
        CType(Me.PATLETADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ATLETABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ATLETABindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ATLETABindingNavigator.ResumeLayout(False)
        Me.ATLETABindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PATLETADataSet As PATLETADataSet
    Friend WithEvents ATLETABindingSource As BindingSource
    Friend WithEvents ATLETATableAdapter As PATLETADataSetTableAdapters.ATLETATableAdapter
    Friend WithEvents TableAdapterManager As PATLETADataSetTableAdapters.TableAdapterManager
    Friend WithEvents ATLETABindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents ATLETABindingNavigatorSaveItem As ToolStripButton
End Class
