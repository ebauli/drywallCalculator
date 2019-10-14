Public Class Form2
    Private sql As New SQLControl

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        setUpdateProject()
        Form3.Show()
        Me.Close()

    End Sub


    Private Sub setUpdateProject()
        sql.addParam("@projectName", txtProjectName.Text)
        sql.addParam("@projectDescription", txtProjectDescription.Text)
        sql.ExecQuery("INSERT INTO PROJECT (project_name , project_description) values (@projectName,@projectDescription)")
    End Sub




End Class