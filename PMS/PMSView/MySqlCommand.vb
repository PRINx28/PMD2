Friend Class MySqlCommand
    Private query As String
    Private connection As MySqlConnection

    Public Sub New(query As String, connection As MySqlConnection)
        Me.query = query
        Me.connection = connection
    End Sub
End Class
