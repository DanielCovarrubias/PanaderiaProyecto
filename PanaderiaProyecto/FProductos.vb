Public Class FProductos
    Private Sub ProductosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ProductosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PanDBDataSet)

    End Sub

    Private Sub FProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PanDBDataSet.ConPedProd' Puede moverla o quitarla según sea necesario.
        Me.ConPedProdTableAdapter.Fill(Me.PanDBDataSet.ConPedProd)
        'TODO: esta línea de código carga datos en la tabla 'PanDBDataSet.Productos' Puede moverla o quitarla según sea necesario.
        Actualiza()

    End Sub

    'Los procedimientos Block y DBlock se usan para bloquear y desbloquear ciertos textbox y el datagridview según la situación'
    Private Sub Block()
        ProductosDataGridView.Enabled = False
        BNuevo.Visible = False
        BEliminar.Visible = False
        CodigoTextBox.Enabled = True
        TxBuscar.Enabled = False
        ProductosBindingNavigator.Enabled = False
    End Sub

    Private Sub DBlock()
        ProductosDataGridView.Enabled = True
        BNuevo.Visible = True
        BEliminar.Visible = True
        CodigoTextBox.Enabled = False
        TxBuscar.Enabled = True
        ProductosBindingNavigator.Enabled = True
    End Sub

    'Procedimiento para actualizar los datos de la tabla'
    Private Sub Actualiza()
        Try
            Me.ProductosTableAdapter.Fill(Me.PanDBDataSet.Productos)
        Catch
            MsgBox("Error de Conexión")
        End Try
    End Sub

    'Procedimiento para agregar un nuevo pedido'
    Private Sub BNuevo_Click(sender As Object, e As EventArgs) Handles BNuevo.Click
        ProductosBindingSource.AddNew()
        Block()
        CodigoTextBox.Focus()
    End Sub

    'Procedimiento para eliminar un pedido'
    Private Sub BEliminar_Click(sender As Object, e As EventArgs) Handles BEliminar.Click
        Dim Borrar
        Borrar = MsgBox("¿Eliminar el registro?", vbCritical + vbYesNo + vbDefaultButton2, "Confirmar")
        If Borrar = vbYes Then
            ProductosBindingSource.RemoveCurrent()
            ProductosTableAdapter.Update(PanDBDataSet.Productos)
            Actualiza()
        End If
    End Sub

    'Valida que, no haya información vacía en los textbox antes de guardar'
    Function Completo() As Boolean
        If CodigoTextBox.Text = "" And DescripcionTextBox.Text = "" Then
            Completo = False
        Else
            Completo = True
        End If
    End Function

    'Procedimiento para guardar un pedido. Necesitamos validar que se complete la información necesaria'
    Private Sub BGuardar_Click(sender As Object, e As EventArgs) Handles BGuardar.Click
        If Completo() Then
            ProductosBindingSource.EndEdit()
            ProductosTableAdapter.Update(PanDBDataSet.Productos)
            Actualiza()
            DBlock()
        Else
            MsgBox("Registro Incompleto")
        End If
    End Sub

    'Procedimiento para cancelar un pedido'
    Private Sub BCancelar_Click(sender As Object, e As EventArgs) Handles BCancelar.Click
        ProductosBindingSource.CancelEdit()
        DBlock()
    End Sub

    Private Sub DescripcionTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DescripcionTextBox.KeyPress
        'Se valida que en la descripción sólo puedan ponerse letras'
        e.Handled = Not Char.IsLetter(e.KeyChar) And Not Char.IsSeparator(e.KeyChar)
    End Sub

    Private Sub PrecioTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PrecioTextBox.KeyPress
        'Valida que en el precio, sólo puedan ponerse números'
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar)
    End Sub

    'Procedimiento para cargar fotos del producto, según corresponda con el código asignado
    Private Sub CodigoTextBox_TextChanged(sender As Object, e As EventArgs) Handles CodigoTextBox.TextChanged
        Dim Ruta
        Ruta = "D:\SisPan\img\" & CodigoTextBox.Text & ".jpg"
        Try
            Foto.Load(Ruta)
        Catch ex As Exception
            Foto.Load("D:\SisPan\img\NoDisp.jpg")
        End Try
    End Sub

    'Procedimiento para hacer funcionar el buscador por coincidencia'
    Private Sub TxBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxBuscar.TextChanged
        If TxBuscar.Text = "" Then
            Actualiza()
        Else
            Me.ProductosTableAdapter.FillByNombre(Me.PanDBDataSet.Productos, TxBuscar.Text)
        End If
    End Sub
End Class
