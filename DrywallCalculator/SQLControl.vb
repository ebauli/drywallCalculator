Imports System.Data
Imports MySql.Data
Imports MySql.Data.MySqlClient


Public Class SQLControl

    'SQL Connection
    Private sqlCon As New MySqlConnection("server=localhost;user id=root;password=EDUARDO;database=drywall;persistsecurityinfo=True ")
    Private sqlCmd As MySqlCommand

    'SQL Data
    Public sqlDA As MySqlDataAdapter
    Public sqlDS As DataSet

    'Query Parameters 
    Public params As New List(Of MySqlParameter)

    'Query Statistics
    Public recordcount As Integer
    Public exception As String
    Public tableID As Integer

    Public Property TableIDProperty As Integer
        Get
            Return tableID
        End Get
        Set(value As Integer)

        End Set

    End Property




    Public Sub ExecCommand()
        Try
            sqlCon.Open()

            'Create SQL Commands
            sqlCmd = New MySqlCommand()



        Catch ex As Exception

        End Try


    End Sub


    Public Sub ExecQuery(query As String)
        Try
            sqlCon.Open()

            'Create SQL Commands
            sqlCmd = New MySqlCommand(query, sqlCon)

            'load parameters into sql command
            params.ForEach(Sub(x) sqlCmd.Parameters.Add(x))

            'clear parameters
            params.Clear()

            'execute command


            sqlDS = New DataSet
            sqlDA = New MySqlDataAdapter(sqlCmd)
            recordcount = sqlDA.Fill(sqlDS)
            tableID = sqlCmd.LastInsertedId()
            ' MsgBox(recordcount)
            sqlCon.Close()

        Catch ex As Exception

            exception = ex.Message

        End Try

        If sqlCon.State = ConnectionState.Open Then sqlCon.Close()

    End Sub

    Public Sub addParam(name As String, value As Object)

        Dim newParam As New MySqlParameter(name, value)
        params.Add(newParam)

    End Sub
    Public Sub clearParams()
        params.Clear()

    End Sub


End Class
