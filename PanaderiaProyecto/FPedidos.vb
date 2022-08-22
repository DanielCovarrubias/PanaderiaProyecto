Public Class FPedidos
    Private Sub PedidosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.PedidosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PanDBDataSet)

    End Sub

    Private Sub FPedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PanDBDataSet.DetallePedido' Puede moverla o quitarla según sea necesario.
        Me.DetallePedidoTableAdapter.Fill(Me.PanDBDataSet.DetallePedido)
        'TODO: esta línea de código carga datos en la tabla 'PanDBDataSet.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.PanDBDataSet.Productos)
        'TODO: esta línea de código carga datos en la tabla 'PanDBDataSet.ConDetalleProd' Puede moverla o quitarla según sea necesario.
        Me.ConDetalleProdTableAdapter.Fill(Me.PanDBDataSet.ConDetalleProd)
        'TODO: esta línea de código carga datos en la tabla 'PanDBDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.PanDBDataSet.Usuarios)
        'TODO: esta línea de código carga datos en la tabla 'PanDBDataSet.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.PanDBDataSet.Clientes)
        'TODO: esta línea de código carga datos en la tabla 'PanDBDataSet.Pedidos' Puede moverla o quitarla según sea necesario.
        Me.PedidosTableAdapter.Fill(Me.PanDBDataSet.Pedidos)

    End Sub

    'Procedimientos de bloqueo y desbloqueo de los DataGridView'
    Private Sub Block()
        BNuevo.Enabled = False
        ConDetalleProdDataGridView.Visible = False
        'Se creó un nuevo DataGridView, con el cual poder llenar un nueva hoja de pedidos'
        DGVDetalle.Visible = True
        Panel1.Enabled = True
    End Sub

    Private Sub DBlock()
        BNuevo.Enabled = True
        ConDetalleProdDataGridView.Visible = True
        DGVDetalle.Visible = False
        Panel1.Enabled = False
    End Sub


    'Procedimiento con muchas utilidades:'
    Private Sub BNuevo_Click(sender As Object, e As EventArgs) Handles BNuevo.Click
        'Se hace que el folio sea autoincrementable'
        Dim Fol As Integer
        Me.PedidosBindingSource.MoveLast()
        Fol = Val(FolioTextBox.Text) + 1
        PedidosBindingSource.AddNew()
        FolioTextBox.Text = Fol
        'Se levanta el pedido con la fecha actual del ordenador'
        FechaDateTimePicker.Value = Now
        'Dado que sólo se levanta el pedido, el estatus por defecto es "Pendiente"'
        StatusComboBox.Text = "Pendiente"
        'Se dice que sólo los usuarios de nivel 1 pueden acceder a esta función'
        IdUsuarioPedTextBox.Text = 1 'se tiene que poner IDUSER NO SE TE OLVIDE'
        'Por defecto saldrá el 0 el total del pedido para luego agregarlos".
        TotalPiezasTextBox.Text = 0
        TotalTextBox.Text = 0
        'De manera inicial, no se tendrán obervaciones hasta que el usuario las agregue'
        ObservacionesTextBox.Text = "Ningún requisito"
        FechaDateTimePicker.Focus()
        'Verifica que se esté levantando un nuevo registro'
        NewReg = True
        Block()
    End Sub
    'Procedimiento para calcelar un pedido'
    Private Sub BCancelar_Click(sender As Object, e As EventArgs) Handles BCancelar.Click
        PedidosBindingSource.CancelEdit()
        DBlock()
        'Se verifica que se canceló el nuevo registro'
        NewReg = False
    End Sub

    'Procedimiento para calcular el total final del producto'
    'R = Renglones
    'Pie = Piezas
    'Tot = Precio total 
    ' TR = Total Renglones
    Private Sub Calcula()
        Dim R = 0, Pie = 0, Tot = 0, TR = 0
        TR = DGVDetalle.RowCount - 1
        For R = 0 To TR
            If DGVDetalle(0, R).Value <> "" Then
                Pie = Pie + DGVDetalle(1, R).Value
                Tot = Tot + DGVDetalle(4, R).Value
            End If
        Next
        TotalPiezasTextBox.Text = Pie
        TotalTextBox.Text = Tot
    End Sub

    'Calcula el resultado en caso de que se elimine un registro'
    Private Sub DGVDetalle_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles DGVDetalle.RowsRemoved
        Calcula()
    End Sub

    'Procedimiento para calcular el subtotal del pedido'
    'Se multiplica la columna 1 por la columna 3 (ese es el orden que asignamos)
    Private Sub CalSub()
        DGVDetalle.Item(4, Ren).Value = DGVDetalle.Item(1, Ren).Value * DGVDetalle.Item(3, Ren).Value
    End Sub


    'Procedimiento que une al Data Grid View (DGVDetalle) para levantar un pedido, con la base de datos
    Private Sub DGVDetalle_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DGVDetalle.CellEndEdit
        Dim CodPro

        Col = e.ColumnIndex
        Ren = e.RowIndex

        CodPro = DGVDetalle.Item(0, Ren).Value
        If CodPro <> "" Then
            'Si estamos en la consulta 0'
            If Col = 0 Then
                'Para este procedimiento, se necesita previamente realizar una consulta a la base de datos'
                Me.ProductosTableAdapter.FillByCod(Me.PanDBDataSet.Productos, CodPro)
                'Cada columna tiene una función:'
                '0 Código del producto
                '1 Cantidad del producto
                '2 Nombre del producto
                '3 Precio del producto
                '4 Subtotal
                If DescripcionTextBox.Text <> "" Then
                    DGVDetalle.Item(1, Ren).Value = 1
                    DGVDetalle.Item(2, Ren).Value = DescripcionTextBox.Text
                    DGVDetalle.Item(3, Ren).Value = PrecioTextBox.Text
                    CalSub()
                    Calcula()
                Else
                    DGVDetalle.Item(0, Ren).Value = ""
                End If
            End If
            'Si se cambia la cantidad, también se calcula el precio en todos los espacios necesarios'
            If Col = 1 Then
                CalSub()
                Calcula()
            End If
            'Si se cambia el precio se calcula el subtotal en todos los espacios necesarios'
            If Col = 3 Then
                CalSub()
                Calcula()
            End If
        Else
            'Si el usuario no selecciona algo, la tabla quedará vacía'
            DGVDetalle.Item(1, Ren).Value = ""
            DGVDetalle.Item(2, Ren).Value = ""
            DGVDetalle.Item(3, Ren).Value = ""
            DGVDetalle.Item(4, Ren).Value = ""
            Calcula()
        End If
    End Sub

    'Nos dice si el cambio fue por medio del click y no por medio del tabulador'
    Private Sub DGVDetalle_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVDetalle.CellClick
        Col = e.ColumnIndex
        Ren = e.RowIndex
    End Sub

    'Función hecha a partir de condicionales, con la que se valida si un registro se llenó correctamente o no'
    Function Completo() As Boolean
        If IdClienteTextBox.Text = "" Or TotalTextBox.Text = "0" Then
            Completo = False
            MsgBox("Registro Incompleto", vbDefaultButton2, "Comprueba el Registro")
        Else
            Completo = True
        End If
    End Function

    'Procedimiento que vincula el guardado con la base de datos por medio de un bucle for'
    'Debido a que recorre todos los renglones del Data Grid View donde se asienta el pedido'
    Private Sub GrabaDetalle()
        Dim Cod = "", Fol = FolioTextBox.Text
        Dim Can = 0, Pre = 0, SubT = 0, R = 0
        'Se le resta 2 porque inicia en 0 el conteo y además siempre se agrega un renglón más en el grid'
        For R = 0 To DGVDetalle.RowCount - 2
            Cod = DGVDetalle.Item(0, R).Value
            Can = DGVDetalle.Item(1, R).Value
            Pre = DGVDetalle.Item(3, R).Value
            SubT = DGVDetalle.Item(4, R).Value
            Me.DetallePedidoTableAdapter.NuevoDetalle(Fol, Cod, Can, Pre, SubT)
        Next
    End Sub


    'Procedimiento para grabar el pedido, se utiliza para hacerle referencia en el procedimiento de guardar'
    Private Sub GrabaPedido()
        PedidosBindingSource.EndEdit()
        PedidosTableAdapter.Update(PanDBDataSet.Pedidos)
        Me.PedidosTableAdapter.Fill(Me.PanDBDataSet.Pedidos)
    End Sub

    'Procedimiento del botón de guardar'
    Private Sub BGuardar_Click(sender As Object, e As EventArgs) Handles BGuardar.Click
        Dim Pos
        If NewReg Then
            'Se manda a calcular una vez más, porque el usuario podría haber dejado un registro en blanco
            'aunque no es necesario
            Calcula()
            'Si el procedimiento de completo se inicia, entonces, se graba el pedido en la base de datos
            'Con el procedimiento de GrabaPedido(). En otro caso, también se graba para evitar problemas
            If Completo() Then
                GrabaDetalle()
                GrabaPedido()
                Me.ConDetalleProdTableAdapter.Fill(Me.PanDBDataSet.ConDetalleProd)
                DBlock()
                'New Reg False para que esté preparado para un nuevo guardado'
                NewReg = False
            End If
        Else
            'Pos nos sirve para que no se mueva la posición del nuevo registro'
            Pos = PedidosBindingSource.Position
            GrabaPedido()
            PedidosBindingSource.Position = Pos
        End If
    End Sub

    'Procedimiento para habilitar la selección del cliente, previamente, se necesitó lo siguiente:'
    'Se necesitó conectar el combo box a la tabla de clientes de la base de datos
    'Ajustar la propiedad "ValueMenmber" para vincular los cambios con sus id
    'Y seleccionar que en el "Display" se muestren los clientes' 
    Private Sub NombreComboBox_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles NombreComboBox.SelectedIndexChanged
        IdClienteTextBox.Text = NombreComboBox.SelectedValue
    End Sub

    Private Sub BPreview_Click(sender As Object, e As EventArgs) Handles BPreview.Click
        FPedido = FolioTextBox.Text
        FPrintNota.Show()
    End Sub
End Class