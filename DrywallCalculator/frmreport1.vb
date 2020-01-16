Public Class frmReport1
    Public Property myCornerlist As List(Of Corner)



    Private Sub frmReport1_Load(sender As Object, e As EventArgs) Handles Me.Load
        DataGridView1.DataSource = myCornerlist
        TextBox1.Text = myCornerlist.Count
    End Sub
End Class