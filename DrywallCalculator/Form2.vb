Public Class Form2


    Dim projectId As Integer
    Private sql As New SQLControl
    Private tableId As Integer

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load
        Timer1.Enabled = True

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        setUpdateProject()
        Dim form3N As New Form3()
        form3N.MdiParent = frmParent
        form3N.projectId = tableId
        form3N.projectName = txtProjectName.Text
        form3N.Show()


    End Sub


    Private Sub setUpdateProject()
        sql.addParam("@projectName", txtProjectName.Text)
        sql.addParam("@projectDescription", txtProjectDescription.Text)
        sql.addParam("@dateCreated", Label5.Text)
        sql.ExecQuery("INSERT INTO PROJECT (project_name , project_description,project_dateCreated) values (@projectName,@projectDescription,@dateCreated)")
        tableId = sql.tableID
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label5.Text = Date.Now.ToString("dd-MM-yyyy hh:mm:ss")
    End Sub
End Class