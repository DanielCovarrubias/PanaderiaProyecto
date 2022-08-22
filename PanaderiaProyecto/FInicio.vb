Public Class FInicio
    Private Sub UsuariosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UsuariosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PanDBDataSet)

    End Sub

    Private Sub FInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PanDBDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.PanDBDataSet.Usuarios)

    End Sub

    'Procedimiento para comprobar que los datos de las cajas de inicio coincidan con las creadas por la base de datos'
    Private Sub BLogin_Click(sender As Object, e As EventArgs) Handles BLogin.Click
        If TxUser.Text <> "" And TxPass.Text <> "" Then
            Me.UsuariosTableAdapter.FillByApodo(Me.PanDBDataSet.Usuarios, TxUser.Text)
            If TxPass.Text = PassTextBox.Text Then
                IdUser = IdUsuarioTextBox.Text
                Nivel = NivelTextBox.Text
                TxUser.Text = "" : TxPass.Text = ""
                FMenu.Show()
            Else
                MsgBox("Los datos no son válidos. Intente de nuevo.", vbDefaultButton2, "Iniciar Sesión")
            End If
        End If
    End Sub
End Class