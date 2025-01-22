﻿Imports System.Data.SqlClient

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub LoadData()
        Dim connectionString As String = "Server=10.0.1.26;Port=3306;Database=propertymanagementdatabase;Uid=longlong;Pwd=Cy[ltM)yUqZ[W/Vc;"
        Dim query As String = "SELECT id, username FROM tbluser"

        Using connection As New MySql.Data.MySqlClient.MySqlConnection(connectionString)
            Dim command As New MySql.Data.MySqlClient.MySqlCommand(query, connection)
            connection.Open()
            Dim reader As MySql.Data.MySqlClient.MySqlDataReader = command.ExecuteReader()

            ListView1.Items.Clear()
            While reader.Read()
                Dim listItem As New ListViewItem(reader("id").ToString())
                listItem.SubItems.Add(reader("username").ToString())
                ListView1.Items.Add(listItem)
            End While

            reader.Close()
        End Using
    End Sub
End Class