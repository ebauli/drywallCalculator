

Public Class Form4

    Private sql As New SQLControl
    Private tableId As Integer

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles Me.Load
        loadgrid()

    End Sub

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click

        Dim form3N As New Form3()
        form3N.projectId = txtProjectID.Text
        form3N.Show()


    End Sub

    Private Sub loadGrid()


        sql.ExecQuery("select * from PROJECT ")

        If sql.recordcount > 0 Then
            DataGridView1.DataSource = sql.sqlDS.Tables(0)
            DataGridView1.Rows(0).Selected = True
        End If
        DataGridView1.DataSource = sql.sqlDS.Tables(0)


    End Sub


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(index)


        txtProjectID.Text = selectedRow.Cells(0).Value.ToString
        txtProjectName.Text = selectedRow.Cells(1).Value.ToString
        txtProjectDescription.Text = selectedRow.Cells(2).Value.ToString



    End Sub
End Class