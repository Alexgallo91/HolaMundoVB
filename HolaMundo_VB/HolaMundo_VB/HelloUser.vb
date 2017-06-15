Public Class HelloUser
    Private Sub HelloUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles LabelName.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'cierra el programa
        MessageBox.Show("Gracias, " & txtName.Text & ", nos vemos!!!", "Despedida")
        Me.Close()
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged

    End Sub

    Private Sub txtName_Resize(sender As Object, e As EventArgs) Handles txtName.Resize

    End Sub

    Private Sub LabelName_RightToLeftChanged(sender As Object, e As EventArgs) Handles LabelName.RightToLeftChanged

    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        'Display a message box greeting the user
        MessageBox.Show("Hello, " & txtName.Text &
        "! Welcome to Visual Basic 2017.", "Hello User Message")
    End Sub
End Class
