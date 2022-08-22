<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FPedidos
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
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim PrecioLabel As System.Windows.Forms.Label
        Dim FolioLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim IdClienteLabel As System.Windows.Forms.Label
        Dim TotalPiezasLabel As System.Windows.Forms.Label
        Dim TotalLabel As System.Windows.Forms.Label
        Dim ObservacionesLabel As System.Windows.Forms.Label
        Dim IdUsuarioPedLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Dim FolioPedidoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FPedidos))
        Me.PedidosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.PedidosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.PedidosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsuariosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PedidosTableAdapter = New PanaderiaProyecto.PanDBDataSetTableAdapters.PedidosTableAdapter()
        Me.TableAdapterManager = New PanaderiaProyecto.PanDBDataSetTableAdapters.TableAdapterManager()
        Me.ClientesTableAdapter = New PanaderiaProyecto.PanDBDataSetTableAdapters.ClientesTableAdapter()
        Me.UsuariosTableAdapter = New PanaderiaProyecto.PanDBDataSetTableAdapters.UsuariosTableAdapter()
        Me.ConDetalleProdBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConDetalleProdTableAdapter = New PanaderiaProyecto.PanDBDataSetTableAdapters.ConDetalleProdTableAdapter()
        Me.ConDetalleProdDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BNuevo = New System.Windows.Forms.Button()
        Me.BCancelar = New System.Windows.Forms.Button()
        Me.DGVDetalle = New System.Windows.Forms.DataGridView()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductosTableAdapter = New PanaderiaProyecto.PanDBDataSetTableAdapters.ProductosTableAdapter()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.PrecioTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.NombreComboBox1 = New System.Windows.Forms.ComboBox()
        Me.NombreComboBox = New System.Windows.Forms.ComboBox()
        Me.FolioTextBox = New System.Windows.Forms.TextBox()
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.IdClienteTextBox = New System.Windows.Forms.TextBox()
        Me.TotalPiezasTextBox = New System.Windows.Forms.TextBox()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.ObservacionesTextBox = New System.Windows.Forms.TextBox()
        Me.IdUsuarioPedTextBox = New System.Windows.Forms.TextBox()
        Me.StatusComboBox = New System.Windows.Forms.ComboBox()
        Me.BGuardar = New System.Windows.Forms.Button()
        Me.DetallePedidoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DetallePedidoTableAdapter = New PanaderiaProyecto.PanDBDataSetTableAdapters.DetallePedidoTableAdapter()
        Me.FolioPedidoTextBox = New System.Windows.Forms.TextBox()
        Me.BPreview = New System.Windows.Forms.Button()
        DescripcionLabel = New System.Windows.Forms.Label()
        PrecioLabel = New System.Windows.Forms.Label()
        FolioLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        IdClienteLabel = New System.Windows.Forms.Label()
        TotalPiezasLabel = New System.Windows.Forms.Label()
        TotalLabel = New System.Windows.Forms.Label()
        ObservacionesLabel = New System.Windows.Forms.Label()
        IdUsuarioPedLabel = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        FolioPedidoLabel = New System.Windows.Forms.Label()
        CType(Me.PedidosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PedidosBindingNavigator.SuspendLayout()
        CType(Me.PedidosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PedidosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuariosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConDetalleProdBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConDetalleProdDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DetallePedidoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(87, 203)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(78, 13)
        DescripcionLabel.TabIndex = 37
        DescripcionLabel.Text = "Descripcion:"
        '
        'PrecioLabel
        '
        PrecioLabel.AutoSize = True
        PrecioLabel.Location = New System.Drawing.Point(330, 199)
        PrecioLabel.Name = "PrecioLabel"
        PrecioLabel.Size = New System.Drawing.Size(47, 13)
        PrecioLabel.TabIndex = 38
        PrecioLabel.Text = "Precio:"
        '
        'FolioLabel
        '
        FolioLabel.AutoSize = True
        FolioLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FolioLabel.Location = New System.Drawing.Point(37, 23)
        FolioLabel.Name = "FolioLabel"
        FolioLabel.Size = New System.Drawing.Size(51, 18)
        FolioLabel.TabIndex = 35
        FolioLabel.Text = "Folio:"
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FechaLabel.Location = New System.Drawing.Point(173, 25)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(59, 18)
        FechaLabel.TabIndex = 37
        FechaLabel.Text = "Fecha:"
        '
        'IdClienteLabel
        '
        IdClienteLabel.AutoSize = True
        IdClienteLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdClienteLabel.Location = New System.Drawing.Point(316, 23)
        IdClienteLabel.Name = "IdClienteLabel"
        IdClienteLabel.Size = New System.Drawing.Size(65, 18)
        IdClienteLabel.TabIndex = 39
        IdClienteLabel.Text = "Cliente:"
        '
        'TotalPiezasLabel
        '
        TotalPiezasLabel.AutoSize = True
        TotalPiezasLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TotalPiezasLabel.Location = New System.Drawing.Point(258, 82)
        TotalPiezasLabel.Name = "TotalPiezasLabel"
        TotalPiezasLabel.Size = New System.Drawing.Size(64, 18)
        TotalPiezasLabel.TabIndex = 41
        TotalPiezasLabel.Text = "Piezas:"
        '
        'TotalLabel
        '
        TotalLabel.AutoSize = True
        TotalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TotalLabel.Location = New System.Drawing.Point(390, 81)
        TotalLabel.Name = "TotalLabel"
        TotalLabel.Size = New System.Drawing.Size(51, 18)
        TotalLabel.TabIndex = 43
        TotalLabel.Text = "Total:"
        '
        'ObservacionesLabel
        '
        ObservacionesLabel.AutoSize = True
        ObservacionesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ObservacionesLabel.Location = New System.Drawing.Point(34, 139)
        ObservacionesLabel.Name = "ObservacionesLabel"
        ObservacionesLabel.Size = New System.Drawing.Size(126, 18)
        ObservacionesLabel.TabIndex = 45
        ObservacionesLabel.Text = "Observaciones:"
        '
        'IdUsuarioPedLabel
        '
        IdUsuarioPedLabel.AutoSize = True
        IdUsuarioPedLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdUsuarioPedLabel.Location = New System.Drawing.Point(37, 81)
        IdUsuarioPedLabel.Name = "IdUsuarioPedLabel"
        IdUsuarioPedLabel.Size = New System.Drawing.Size(67, 18)
        IdUsuarioPedLabel.TabIndex = 49
        IdUsuarioPedLabel.Text = "Usuario"
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StatusLabel.Location = New System.Drawing.Point(631, 280)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(70, 18)
        StatusLabel.TabIndex = 49
        StatusLabel.Text = "Estatus:"
        '
        'FolioPedidoLabel
        '
        FolioPedidoLabel.AutoSize = True
        FolioPedidoLabel.Location = New System.Drawing.Point(129, 152)
        FolioPedidoLabel.Name = "FolioPedidoLabel"
        FolioPedidoLabel.Size = New System.Drawing.Size(81, 13)
        FolioPedidoLabel.TabIndex = 51
        FolioPedidoLabel.Text = "Folio Pedido:"
        '
        'PedidosBindingNavigator
        '
        Me.PedidosBindingNavigator.AddNewItem = Nothing
        Me.PedidosBindingNavigator.BindingSource = Me.PedidosBindingSource
        Me.PedidosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PedidosBindingNavigator.DeleteItem = Nothing
        Me.PedidosBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PedidosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.PedidosBindingNavigator.Location = New System.Drawing.Point(0, 431)
        Me.PedidosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PedidosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PedidosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PedidosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PedidosBindingNavigator.Name = "PedidosBindingNavigator"
        Me.PedidosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PedidosBindingNavigator.Size = New System.Drawing.Size(1144, 25)
        Me.PedidosBindingNavigator.TabIndex = 0
        Me.PedidosBindingNavigator.Text = "BindingNavigator1"
        '
        'PedidosBindingSource
        '
        Me.PedidosBindingSource.DataMember = "Pedidos"
        Me.PedidosBindingSource.DataSource = Me.PanDBDataSet
        '
        'PanDBDataSet
        '
        Me.PanDBDataSet.DataSetName = "PanDBDataSet"
        Me.PanDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
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
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'PedidosDataGridView
        '
        Me.PedidosDataGridView.AllowUserToAddRows = False
        Me.PedidosDataGridView.AllowUserToDeleteRows = False
        Me.PedidosDataGridView.AutoGenerateColumns = False
        Me.PedidosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PedidosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn7})
        Me.PedidosDataGridView.DataSource = Me.PedidosBindingSource
        Me.PedidosDataGridView.Location = New System.Drawing.Point(39, 38)
        Me.PedidosDataGridView.Name = "PedidosDataGridView"
        Me.PedidosDataGridView.ReadOnly = True
        Me.PedidosDataGridView.RowHeadersVisible = False
        Me.PedidosDataGridView.Size = New System.Drawing.Size(472, 183)
        Me.PedidosDataGridView.TabIndex = 17
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Folio"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Folio"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Fecha"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "IdCliente"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Cliente"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Status"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataSource = Me.PedidosBindingSource
        '
        'UsuariosBindingSource
        '
        Me.UsuariosBindingSource.DataSource = Me.PedidosBindingSource
        '
        'ClientesBindingSource1
        '
        Me.ClientesBindingSource1.DataMember = "Pedidos_Clientes"
        Me.ClientesBindingSource1.DataSource = Me.PedidosBindingSource
        '
        'ClientesBindingSource2
        '
        Me.ClientesBindingSource2.DataMember = "Clientes"
        Me.ClientesBindingSource2.DataSource = Me.PanDBDataSet
        '
        'UsuariosBindingSource1
        '
        Me.UsuariosBindingSource1.DataMember = "Pedidos_Usuarios"
        Me.UsuariosBindingSource1.DataSource = Me.PedidosBindingSource
        '
        'PedidosTableAdapter
        '
        Me.PedidosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.DetallePedidoTableAdapter = Nothing
        Me.TableAdapterManager.PedidosTableAdapter = Me.PedidosTableAdapter
        Me.TableAdapterManager.ProductosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PanaderiaProyecto.PanDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'UsuariosTableAdapter
        '
        Me.UsuariosTableAdapter.ClearBeforeFill = True
        '
        'ConDetalleProdBindingSource
        '
        Me.ConDetalleProdBindingSource.DataMember = "Pedidos_ConDetalleProd"
        Me.ConDetalleProdBindingSource.DataSource = Me.PedidosBindingSource
        '
        'ConDetalleProdTableAdapter
        '
        Me.ConDetalleProdTableAdapter.ClearBeforeFill = True
        '
        'ConDetalleProdDataGridView
        '
        Me.ConDetalleProdDataGridView.AllowUserToAddRows = False
        Me.ConDetalleProdDataGridView.AllowUserToDeleteRows = False
        Me.ConDetalleProdDataGridView.AutoGenerateColumns = False
        Me.ConDetalleProdDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ConDetalleProdDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.ConDetalleProdDataGridView.DataSource = Me.ConDetalleProdBindingSource
        Me.ConDetalleProdDataGridView.Location = New System.Drawing.Point(39, 251)
        Me.ConDetalleProdDataGridView.Name = "ConDetalleProdDataGridView"
        Me.ConDetalleProdDataGridView.ReadOnly = True
        Me.ConDetalleProdDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ConDetalleProdDataGridView.Size = New System.Drawing.Size(546, 150)
        Me.ConDetalleProdDataGridView.TabIndex = 34
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "FolioPedido"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Código"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Cantidad"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Descripcion"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Pan"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "PrecioPedido"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Precio $"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "SubTotal"
        Me.DataGridViewTextBoxColumn9.HeaderText = "SubTotal $"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'BNuevo
        '
        Me.BNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BNuevo.Location = New System.Drawing.Point(641, 344)
        Me.BNuevo.Name = "BNuevo"
        Me.BNuevo.Size = New System.Drawing.Size(87, 33)
        Me.BNuevo.TabIndex = 35
        Me.BNuevo.Text = "Nuevo"
        Me.BNuevo.UseVisualStyleBackColor = False
        '
        'BCancelar
        '
        Me.BCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BCancelar.Location = New System.Drawing.Point(754, 344)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Size = New System.Drawing.Size(87, 33)
        Me.BCancelar.TabIndex = 36
        Me.BCancelar.Text = "Cancelar"
        Me.BCancelar.UseVisualStyleBackColor = False
        '
        'DGVDetalle
        '
        Me.DGVDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Cantidad, Me.Pan, Me.Precio, Me.SubTotal})
        Me.DGVDetalle.Location = New System.Drawing.Point(39, 251)
        Me.DGVDetalle.Name = "DGVDetalle"
        Me.DGVDetalle.Size = New System.Drawing.Size(546, 150)
        Me.DGVDetalle.TabIndex = 37
        Me.DGVDetalle.Visible = False
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Código"
        Me.Codigo.Name = "Codigo"
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        '
        'Pan
        '
        Me.Pan.HeaderText = "Pan"
        Me.Pan.Name = "Pan"
        '
        'Precio
        '
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        '
        'SubTotal
        '
        Me.SubTotal.HeaderText = "SubTotal"
        Me.SubTotal.Name = "SubTotal"
        Me.SubTotal.ReadOnly = True
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "Productos"
        Me.ProductosBindingSource.DataSource = Me.PanDBDataSet
        '
        'ProductosTableAdapter
        '
        Me.ProductosTableAdapter.ClearBeforeFill = True
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "Descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(171, 200)
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(116, 20)
        Me.DescripcionTextBox.TabIndex = 38
        '
        'PrecioTextBox
        '
        Me.PrecioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "Precio", True))
        Me.PrecioTextBox.Location = New System.Drawing.Point(384, 196)
        Me.PrecioTextBox.Name = "PrecioTextBox"
        Me.PrecioTextBox.Size = New System.Drawing.Size(116, 20)
        Me.PrecioTextBox.TabIndex = 39
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.NombreComboBox1)
        Me.Panel1.Controls.Add(Me.NombreComboBox)
        Me.Panel1.Controls.Add(FolioLabel)
        Me.Panel1.Controls.Add(Me.FolioTextBox)
        Me.Panel1.Controls.Add(FechaLabel)
        Me.Panel1.Controls.Add(Me.FechaDateTimePicker)
        Me.Panel1.Controls.Add(IdClienteLabel)
        Me.Panel1.Controls.Add(Me.IdClienteTextBox)
        Me.Panel1.Controls.Add(TotalPiezasLabel)
        Me.Panel1.Controls.Add(Me.TotalPiezasTextBox)
        Me.Panel1.Controls.Add(TotalLabel)
        Me.Panel1.Controls.Add(Me.TotalTextBox)
        Me.Panel1.Controls.Add(ObservacionesLabel)
        Me.Panel1.Controls.Add(Me.ObservacionesTextBox)
        Me.Panel1.Controls.Add(IdUsuarioPedLabel)
        Me.Panel1.Controls.Add(Me.IdUsuarioPedTextBox)
        Me.Panel1.Enabled = False
        Me.Panel1.Location = New System.Drawing.Point(614, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(504, 246)
        Me.Panel1.TabIndex = 40
        '
        'NombreComboBox1
        '
        Me.NombreComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource1, "Nombre", True))
        Me.NombreComboBox1.FormattingEnabled = True
        Me.NombreComboBox1.Location = New System.Drawing.Point(38, 102)
        Me.NombreComboBox1.Name = "NombreComboBox1"
        Me.NombreComboBox1.Size = New System.Drawing.Size(181, 21)
        Me.NombreComboBox1.TabIndex = 52
        '
        'NombreComboBox
        '
        Me.NombreComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource1, "Nombre", True))
        Me.NombreComboBox.DataSource = Me.ClientesBindingSource2
        Me.NombreComboBox.DisplayMember = "Nombre"
        Me.NombreComboBox.FormattingEnabled = True
        Me.NombreComboBox.Location = New System.Drawing.Point(319, 47)
        Me.NombreComboBox.Name = "NombreComboBox"
        Me.NombreComboBox.Size = New System.Drawing.Size(166, 21)
        Me.NombreComboBox.TabIndex = 51
        Me.NombreComboBox.ValueMember = "IdCliente"
        '
        'FolioTextBox
        '
        Me.FolioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidosBindingSource, "Folio", True))
        Me.FolioTextBox.Enabled = False
        Me.FolioTextBox.Location = New System.Drawing.Point(40, 44)
        Me.FolioTextBox.Name = "FolioTextBox"
        Me.FolioTextBox.Size = New System.Drawing.Size(95, 20)
        Me.FolioTextBox.TabIndex = 36
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PedidosBindingSource, "Fecha", True))
        Me.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(176, 44)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(114, 20)
        Me.FechaDateTimePicker.TabIndex = 38
        '
        'IdClienteTextBox
        '
        Me.IdClienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidosBindingSource, "IdCliente", True))
        Me.IdClienteTextBox.Location = New System.Drawing.Point(347, 47)
        Me.IdClienteTextBox.Name = "IdClienteTextBox"
        Me.IdClienteTextBox.Size = New System.Drawing.Size(105, 20)
        Me.IdClienteTextBox.TabIndex = 40
        '
        'TotalPiezasTextBox
        '
        Me.TotalPiezasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidosBindingSource, "TotalPiezas", True))
        Me.TotalPiezasTextBox.Location = New System.Drawing.Point(261, 103)
        Me.TotalPiezasTextBox.Name = "TotalPiezasTextBox"
        Me.TotalPiezasTextBox.Size = New System.Drawing.Size(75, 20)
        Me.TotalPiezasTextBox.TabIndex = 42
        '
        'TotalTextBox
        '
        Me.TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidosBindingSource, "Total", True))
        Me.TotalTextBox.Location = New System.Drawing.Point(393, 103)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.Size = New System.Drawing.Size(75, 20)
        Me.TotalTextBox.TabIndex = 44
        '
        'ObservacionesTextBox
        '
        Me.ObservacionesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidosBindingSource, "Observaciones", True))
        Me.ObservacionesTextBox.Location = New System.Drawing.Point(38, 160)
        Me.ObservacionesTextBox.MaxLength = 255
        Me.ObservacionesTextBox.Multiline = True
        Me.ObservacionesTextBox.Name = "ObservacionesTextBox"
        Me.ObservacionesTextBox.Size = New System.Drawing.Size(428, 59)
        Me.ObservacionesTextBox.TabIndex = 46
        '
        'IdUsuarioPedTextBox
        '
        Me.IdUsuarioPedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidosBindingSource, "IdUsuarioPed", True))
        Me.IdUsuarioPedTextBox.Location = New System.Drawing.Point(38, 102)
        Me.IdUsuarioPedTextBox.Name = "IdUsuarioPedTextBox"
        Me.IdUsuarioPedTextBox.Size = New System.Drawing.Size(75, 20)
        Me.IdUsuarioPedTextBox.TabIndex = 50
        '
        'StatusComboBox
        '
        Me.StatusComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidosBindingSource, "Status", True))
        Me.StatusComboBox.FormattingEnabled = True
        Me.StatusComboBox.Items.AddRange(New Object() {"PENDIENTE", "ENTREGADO", "CANCELADO"})
        Me.StatusComboBox.Location = New System.Drawing.Point(707, 280)
        Me.StatusComboBox.Name = "StatusComboBox"
        Me.StatusComboBox.Size = New System.Drawing.Size(233, 21)
        Me.StatusComboBox.TabIndex = 50
        '
        'BGuardar
        '
        Me.BGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BGuardar.Location = New System.Drawing.Point(869, 344)
        Me.BGuardar.Name = "BGuardar"
        Me.BGuardar.Size = New System.Drawing.Size(75, 33)
        Me.BGuardar.TabIndex = 51
        Me.BGuardar.Text = "Guardar"
        Me.BGuardar.UseVisualStyleBackColor = False
        '
        'DetallePedidoBindingSource
        '
        Me.DetallePedidoBindingSource.DataMember = "DetallePedido"
        Me.DetallePedidoBindingSource.DataSource = Me.PanDBDataSet
        '
        'DetallePedidoTableAdapter
        '
        Me.DetallePedidoTableAdapter.ClearBeforeFill = True
        '
        'FolioPedidoTextBox
        '
        Me.FolioPedidoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetallePedidoBindingSource, "FolioPedido", True))
        Me.FolioPedidoTextBox.Location = New System.Drawing.Point(216, 149)
        Me.FolioPedidoTextBox.Name = "FolioPedidoTextBox"
        Me.FolioPedidoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FolioPedidoTextBox.TabIndex = 52
        '
        'BPreview
        '
        Me.BPreview.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BPreview.Location = New System.Drawing.Point(969, 344)
        Me.BPreview.Name = "BPreview"
        Me.BPreview.Size = New System.Drawing.Size(75, 33)
        Me.BPreview.TabIndex = 53
        Me.BPreview.Text = "Imprimir"
        Me.BPreview.UseVisualStyleBackColor = False
        '
        'FPedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1144, 456)
        Me.Controls.Add(Me.BPreview)
        Me.Controls.Add(Me.PedidosDataGridView)
        Me.Controls.Add(FolioPedidoLabel)
        Me.Controls.Add(Me.FolioPedidoTextBox)
        Me.Controls.Add(Me.BGuardar)
        Me.Controls.Add(StatusLabel)
        Me.Controls.Add(Me.StatusComboBox)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(PrecioLabel)
        Me.Controls.Add(Me.PrecioTextBox)
        Me.Controls.Add(DescripcionLabel)
        Me.Controls.Add(Me.DescripcionTextBox)
        Me.Controls.Add(Me.DGVDetalle)
        Me.Controls.Add(Me.BCancelar)
        Me.Controls.Add(Me.BNuevo)
        Me.Controls.Add(Me.ConDetalleProdDataGridView)
        Me.Controls.Add(Me.PedidosBindingNavigator)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FPedidos"
        Me.Text = "Pedidos"
        CType(Me.PedidosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PedidosBindingNavigator.ResumeLayout(False)
        Me.PedidosBindingNavigator.PerformLayout()
        CType(Me.PedidosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PedidosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuariosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConDetalleProdBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConDetalleProdDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DetallePedidoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanDBDataSet As PanDBDataSet
    Friend WithEvents PedidosBindingSource As BindingSource
    Friend WithEvents PedidosTableAdapter As PanDBDataSetTableAdapters.PedidosTableAdapter
    Friend WithEvents TableAdapterManager As PanDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PedidosBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents PedidosDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As PanDBDataSetTableAdapters.ClientesTableAdapter
    Friend WithEvents UsuariosBindingSource As BindingSource
    Friend WithEvents UsuariosTableAdapter As PanDBDataSetTableAdapters.UsuariosTableAdapter
    Friend WithEvents ClientesBindingSource1 As BindingSource
    Friend WithEvents UsuariosBindingSource1 As BindingSource
    Friend WithEvents ConDetalleProdBindingSource As BindingSource
    Friend WithEvents ConDetalleProdTableAdapter As PanDBDataSetTableAdapters.ConDetalleProdTableAdapter
    Friend WithEvents ConDetalleProdDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents BNuevo As Button
    Friend WithEvents BCancelar As Button
    Friend WithEvents ClientesBindingSource2 As BindingSource
    Friend WithEvents DGVDetalle As DataGridView
    Friend WithEvents ProductosBindingSource As BindingSource
    Friend WithEvents ProductosTableAdapter As PanDBDataSetTableAdapters.ProductosTableAdapter
    Friend WithEvents DescripcionTextBox As TextBox
    Friend WithEvents PrecioTextBox As TextBox
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Pan As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents SubTotal As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents NombreComboBox1 As ComboBox
    Friend WithEvents NombreComboBox As ComboBox
    Friend WithEvents FolioTextBox As TextBox
    Friend WithEvents FechaDateTimePicker As DateTimePicker
    Friend WithEvents IdClienteTextBox As TextBox
    Friend WithEvents TotalPiezasTextBox As TextBox
    Friend WithEvents TotalTextBox As TextBox
    Friend WithEvents ObservacionesTextBox As TextBox
    Friend WithEvents IdUsuarioPedTextBox As TextBox
    Friend WithEvents StatusComboBox As ComboBox
    Friend WithEvents BGuardar As Button
    Friend WithEvents DetallePedidoBindingSource As BindingSource
    Friend WithEvents DetallePedidoTableAdapter As PanDBDataSetTableAdapters.DetallePedidoTableAdapter
    Friend WithEvents FolioPedidoTextBox As TextBox
    Friend WithEvents BPreview As Button
End Class
