<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FProductos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim CodigoLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim TipoLabel As System.Windows.Forms.Label
        Dim PrecioLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FProductos))
        Me.ProductosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PanDBDataSet = New PanaderiaProyecto.PanDBDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CodigoTextBox = New System.Windows.Forms.TextBox()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.TipoComboBox = New System.Windows.Forms.ComboBox()
        Me.PrecioTextBox = New System.Windows.Forms.TextBox()
        Me.ProductosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BNuevo = New System.Windows.Forms.Button()
        Me.BEliminar = New System.Windows.Forms.Button()
        Me.BCancelar = New System.Windows.Forms.Button()
        Me.BGuardar = New System.Windows.Forms.Button()
        Me.Foto = New System.Windows.Forms.PictureBox()
        Me.TxBuscar = New System.Windows.Forms.TextBox()
        Me.BusquedaLabel = New System.Windows.Forms.Label()
        Me.ConPedProdBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConPedProdDataGridView = New System.Windows.Forms.DataGridView()
        Me.ProductosTableAdapter = New PanaderiaProyecto.PanDBDataSetTableAdapters.ProductosTableAdapter()
        Me.TableAdapterManager = New PanaderiaProyecto.PanDBDataSetTableAdapters.TableAdapterManager()
        Me.ConPedProdTableAdapter = New PanaderiaProyecto.PanDBDataSetTableAdapters.ConPedProdTableAdapter()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CodigoLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        TipoLabel = New System.Windows.Forms.Label()
        PrecioLabel = New System.Windows.Forms.Label()
        CType(Me.ProductosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProductosBindingNavigator.SuspendLayout()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Foto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConPedProdBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConPedProdDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CodigoLabel
        '
        CodigoLabel.AutoSize = True
        CodigoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CodigoLabel.Location = New System.Drawing.Point(393, 108)
        CodigoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CodigoLabel.Name = "CodigoLabel"
        CodigoLabel.Size = New System.Drawing.Size(70, 20)
        CodigoLabel.TabIndex = 1
        CodigoLabel.Text = "Código:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DescripcionLabel.Location = New System.Drawing.Point(393, 179)
        DescripcionLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(108, 20)
        DescripcionLabel.TabIndex = 3
        DescripcionLabel.Text = "Descripción:"
        '
        'TipoLabel
        '
        TipoLabel.AutoSize = True
        TipoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TipoLabel.Location = New System.Drawing.Point(1026, 37)
        TipoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TipoLabel.Name = "TipoLabel"
        TipoLabel.Size = New System.Drawing.Size(48, 20)
        TipoLabel.TabIndex = 5
        TipoLabel.Text = "Tipo:"
        '
        'PrecioLabel
        '
        PrecioLabel.AutoSize = True
        PrecioLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PrecioLabel.Location = New System.Drawing.Point(1026, 109)
        PrecioLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PrecioLabel.Name = "PrecioLabel"
        PrecioLabel.Size = New System.Drawing.Size(64, 20)
        PrecioLabel.TabIndex = 7
        PrecioLabel.Text = "Precio:"
        '
        'ProductosBindingNavigator
        '
        Me.ProductosBindingNavigator.AddNewItem = Nothing
        Me.ProductosBindingNavigator.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ProductosBindingNavigator.AutoSize = False
        Me.ProductosBindingNavigator.BindingSource = Me.ProductosBindingSource
        Me.ProductosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ProductosBindingNavigator.DeleteItem = Nothing
        Me.ProductosBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.ProductosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.ProductosBindingNavigator.Location = New System.Drawing.Point(0, 879)
        Me.ProductosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ProductosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ProductosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ProductosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ProductosBindingNavigator.Name = "ProductosBindingNavigator"
        Me.ProductosBindingNavigator.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ProductosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ProductosBindingNavigator.Size = New System.Drawing.Size(570, 60)
        Me.ProductosBindingNavigator.TabIndex = 0
        Me.ProductosBindingNavigator.Text = "BindingNavigator1"
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "Productos"
        Me.ProductosBindingSource.DataSource = Me.PanDBDataSet
        '
        'PanDBDataSet
        '
        Me.PanDBDataSet.DataSetName = "PanDBDataSet"
        Me.PanDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 57)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 57)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 57)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 60)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(81, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 60)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 57)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 57)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 60)
        '
        'CodigoTextBox
        '
        Me.CodigoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "Codigo", True))
        Me.CodigoTextBox.Enabled = False
        Me.CodigoTextBox.Location = New System.Drawing.Point(393, 134)
        Me.CodigoTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CodigoTextBox.MaxLength = 6
        Me.CodigoTextBox.Name = "CodigoTextBox"
        Me.CodigoTextBox.Size = New System.Drawing.Size(200, 26)
        Me.CodigoTextBox.TabIndex = 2
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "Descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(393, 204)
        Me.DescripcionTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(200, 26)
        Me.DescripcionTextBox.TabIndex = 4
        '
        'TipoComboBox
        '
        Me.TipoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "Tipo", True))
        Me.TipoComboBox.FormattingEnabled = True
        Me.TipoComboBox.Items.AddRange(New Object() {"DULCE", "BLANCO", "GOURMET", "DE CAJA"})
        Me.TipoComboBox.Location = New System.Drawing.Point(1026, 62)
        Me.TipoComboBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TipoComboBox.Name = "TipoComboBox"
        Me.TipoComboBox.Size = New System.Drawing.Size(275, 28)
        Me.TipoComboBox.TabIndex = 6
        '
        'PrecioTextBox
        '
        Me.PrecioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "Precio", True))
        Me.PrecioTextBox.Location = New System.Drawing.Point(1026, 134)
        Me.PrecioTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PrecioTextBox.Name = "PrecioTextBox"
        Me.PrecioTextBox.Size = New System.Drawing.Size(200, 26)
        Me.PrecioTextBox.TabIndex = 8
        '
        'ProductosDataGridView
        '
        Me.ProductosDataGridView.AllowUserToAddRows = False
        Me.ProductosDataGridView.AllowUserToDeleteRows = False
        Me.ProductosDataGridView.AutoGenerateColumns = False
        Me.ProductosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.ProductosDataGridView.DataSource = Me.ProductosBindingSource
        Me.ProductosDataGridView.Location = New System.Drawing.Point(76, 3)
        Me.ProductosDataGridView.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ProductosDataGridView.Name = "ProductosDataGridView"
        Me.ProductosDataGridView.ReadOnly = True
        Me.ProductosDataGridView.RowHeadersVisible = False
        Me.ProductosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ProductosDataGridView.Size = New System.Drawing.Size(252, 338)
        Me.ProductosDataGridView.TabIndex = 9
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Descripcion"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Tipo"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Tipo"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'BNuevo
        '
        Me.BNuevo.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BNuevo.BackColor = System.Drawing.Color.Lavender
        Me.BNuevo.Location = New System.Drawing.Point(382, 283)
        Me.BNuevo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BNuevo.Name = "BNuevo"
        Me.BNuevo.Size = New System.Drawing.Size(103, 41)
        Me.BNuevo.TabIndex = 10
        Me.BNuevo.Text = "Nuevo"
        Me.BNuevo.UseVisualStyleBackColor = False
        '
        'BEliminar
        '
        Me.BEliminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BEliminar.BackColor = System.Drawing.Color.Lavender
        Me.BEliminar.Location = New System.Drawing.Point(510, 283)
        Me.BEliminar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BEliminar.Name = "BEliminar"
        Me.BEliminar.Size = New System.Drawing.Size(115, 41)
        Me.BEliminar.TabIndex = 11
        Me.BEliminar.Text = "Eliminar"
        Me.BEliminar.UseVisualStyleBackColor = False
        '
        'BCancelar
        '
        Me.BCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BCancelar.BackColor = System.Drawing.Color.Lavender
        Me.BCancelar.Location = New System.Drawing.Point(792, 281)
        Me.BCancelar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Size = New System.Drawing.Size(106, 45)
        Me.BCancelar.TabIndex = 13
        Me.BCancelar.Text = "Cancelar"
        Me.BCancelar.UseVisualStyleBackColor = False
        '
        'BGuardar
        '
        Me.BGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BGuardar.BackColor = System.Drawing.Color.Lavender
        Me.BGuardar.Location = New System.Drawing.Point(643, 283)
        Me.BGuardar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BGuardar.Name = "BGuardar"
        Me.BGuardar.Size = New System.Drawing.Size(127, 41)
        Me.BGuardar.TabIndex = 12
        Me.BGuardar.Text = "Guardar"
        Me.BGuardar.UseVisualStyleBackColor = False
        '
        'Foto
        '
        Me.Foto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Foto.Location = New System.Drawing.Point(621, 37)
        Me.Foto.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Foto.Name = "Foto"
        Me.Foto.Size = New System.Drawing.Size(376, 193)
        Me.Foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Foto.TabIndex = 14
        Me.Foto.TabStop = False
        '
        'TxBuscar
        '
        Me.TxBuscar.Location = New System.Drawing.Point(388, 74)
        Me.TxBuscar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxBuscar.Multiline = True
        Me.TxBuscar.Name = "TxBuscar"
        Me.TxBuscar.Size = New System.Drawing.Size(205, 29)
        Me.TxBuscar.TabIndex = 15
        '
        'BusquedaLabel
        '
        Me.BusquedaLabel.AutoSize = True
        Me.BusquedaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BusquedaLabel.Location = New System.Drawing.Point(389, 49)
        Me.BusquedaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.BusquedaLabel.Name = "BusquedaLabel"
        Me.BusquedaLabel.Size = New System.Drawing.Size(156, 20)
        Me.BusquedaLabel.TabIndex = 16
        Me.BusquedaLabel.Text = "Busca tu producto"
        '
        'ConPedProdBindingSource
        '
        Me.ConPedProdBindingSource.DataMember = "Productos_ConPedProd"
        Me.ConPedProdBindingSource.DataSource = Me.ProductosBindingSource
        '
        'ConPedProdDataGridView
        '
        Me.ConPedProdDataGridView.AllowUserToAddRows = False
        Me.ConPedProdDataGridView.AllowUserToDeleteRows = False
        Me.ConPedProdDataGridView.AutoGenerateColumns = False
        Me.ConPedProdDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ConPedProdDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn21})
        Me.ConPedProdDataGridView.DataSource = Me.ConPedProdBindingSource
        Me.ConPedProdDataGridView.Location = New System.Drawing.Point(230, 373)
        Me.ConPedProdDataGridView.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ConPedProdDataGridView.Name = "ConPedProdDataGridView"
        Me.ConPedProdDataGridView.ReadOnly = True
        Me.ConPedProdDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ConPedProdDataGridView.Size = New System.Drawing.Size(844, 182)
        Me.ConPedProdDataGridView.TabIndex = 17
        '
        'ProductosTableAdapter
        '
        Me.ProductosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.DetallePedidoTableAdapter = Nothing
        Me.TableAdapterManager.PedidosTableAdapter = Nothing
        Me.TableAdapterManager.ProductosTableAdapter = Me.ProductosTableAdapter
        Me.TableAdapterManager.UpdateOrder = PanaderiaProyecto.PanDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        '
        'ConPedProdTableAdapter
        '
        Me.ConPedProdTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Cantidad"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "PrecioPedido"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Precio $"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Folio"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Folio"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Fecha"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Total"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "Status"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        Me.DataGridViewTextBoxColumn18.Width = 150
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn21.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        Me.DataGridViewTextBoxColumn21.Width = 150
        '
        'FProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1321, 601)
        Me.Controls.Add(Me.ConPedProdDataGridView)
        Me.Controls.Add(Me.BusquedaLabel)
        Me.Controls.Add(Me.TxBuscar)
        Me.Controls.Add(Me.Foto)
        Me.Controls.Add(Me.BCancelar)
        Me.Controls.Add(Me.BGuardar)
        Me.Controls.Add(Me.BEliminar)
        Me.Controls.Add(Me.BNuevo)
        Me.Controls.Add(Me.ProductosDataGridView)
        Me.Controls.Add(CodigoLabel)
        Me.Controls.Add(Me.CodigoTextBox)
        Me.Controls.Add(DescripcionLabel)
        Me.Controls.Add(Me.DescripcionTextBox)
        Me.Controls.Add(TipoLabel)
        Me.Controls.Add(Me.TipoComboBox)
        Me.Controls.Add(PrecioLabel)
        Me.Controls.Add(Me.PrecioTextBox)
        Me.Controls.Add(Me.ProductosBindingNavigator)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MinimizeBox = False
        Me.Name = "FProductos"
        Me.Text = "Catálogo de Productos"
        CType(Me.ProductosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProductosBindingNavigator.ResumeLayout(False)
        Me.ProductosBindingNavigator.PerformLayout()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Foto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConPedProdBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConPedProdDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanDBDataSet As PanDBDataSet
    Friend WithEvents ProductosBindingSource As BindingSource
    Friend WithEvents ProductosTableAdapter As PanDBDataSetTableAdapters.ProductosTableAdapter
    Friend WithEvents TableAdapterManager As PanDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProductosBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents CodigoTextBox As TextBox
    Friend WithEvents DescripcionTextBox As TextBox
    Friend WithEvents TipoComboBox As ComboBox
    Friend WithEvents PrecioTextBox As TextBox
    Friend WithEvents ProductosDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents BNuevo As Button
    Friend WithEvents BEliminar As Button
    Friend WithEvents BGuardar As Button
    Friend WithEvents BCancelar As Button
    Friend WithEvents Foto As PictureBox
    Friend WithEvents TxBuscar As TextBox
    Friend WithEvents BusquedaLabel As Label
    Friend WithEvents ConPedProdBindingSource As BindingSource
    Friend WithEvents ConPedProdTableAdapter As PanDBDataSetTableAdapters.ConPedProdTableAdapter
    Friend WithEvents ConPedProdDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
End Class
