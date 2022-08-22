Public Class FMenu
    'El formulario de productos se abrirá en la misma pestaña'
    Private Sub CatalogosToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'Se necesita acceso de nivel 1 para ver los productos'
        If Nivel = "1" Then
            Dim MdiForm As New FPedidos
            MdiForm.MdiParent = Me
            MdiForm.Show()
        Else
            MsgBox("No tienes permiso para acceder a esta opción")
        End If
    End Sub
    'El formulario de Productos se abrirá la misma pestaña'
    Private Sub CatálogosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CatálogosToolStripMenuItem.Click
        If Nivel = "2" Then
            Dim MdiForm As New FPedidos
            MdiForm.MdiParent = Me
            MdiForm.Show()
        Else
            MsgBox("No tienes permiso para acceder a esta opción")
        End If
    End Sub

    'Procedimiento para aparecer / desaparecer el formulario de Login, dependiendo si ya iniciamos sesión o no.'
    Private Sub FMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FInicio.Visible = False
    End Sub

    Private Sub FMenu_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        FInicio.Visible = True
    End Sub


End Class