Public Class Form2


    Dim projectId As Integer
    Private sql As New SQLControl

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim projectID As Integer
        Dim form3N As New Form3(projectID)
        form3N.Show()





    End Sub


    Private Sub setUpdateProject()
        sql.addParam("@projectName", txtProjectName.Text)
        sql.addParam("@projectDescription", txtProjectDescription.Text)
        sql.ExecQuery("INSERT INTO PROJECT (project_name , project_description) values (@projectName,@projectDescription)")
        projectId = sql.tableId

    End Sub




End Class