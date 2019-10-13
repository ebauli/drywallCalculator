

Public Class Form4

    Private sql As New SQLControl

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles Me.Load
        getProjectName()
    End Sub

    Private Sub getProjectName()

        sql.ExecQuery("SELECT project_name FROM project")
        cbxProjectName.Items.Clear()

        'if records are found add them to combo box

        If sql.recordcount > 0 Then
            For Each r As DataRow In sql.sqlDS.Tables(0).Rows
                cbxProjectName.Items.Add(r("project_name"))

            Next
            cbxProjectName.SelectedIndex = 0


        ElseIf sql.exception <> " " Then
            'report errors
            MsgBox(sql.exception)

        End If


    End Sub

    Private Sub getprojectDescription(projectName As String)

        sql.addParam("@projectName", projectName)
        'run Query

        sql.ExecQuery("Select project_description from project where project_name = @projectName")

        'if projects are found send them to the textbox
        If sql.recordcount > 0 Then
            txtProjectDescription.Text = sql.sqlDS.Tables(0).Rows(0).Item("project_description")
        End If



    End Sub

    Private Sub cbxProjectName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxProjectName.SelectedIndexChanged
        getprojectDescription(cbxProjectName.Text)
    End Sub
End Class