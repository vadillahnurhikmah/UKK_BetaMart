Imports System.Data.OleDb
Module MdKoneksi
    Public cmd As OleDbCommand
    Public da As OleDbDataAdapter
    Public dr As OleDbDataReader
    Public dt As DataTable
    Public ketemu As Boolean

    Public koneksi As New OleDbConnection("provider=microsoft.ace.oledb.12.0; data source=db_crud.accdb")

    Sub konek()
        Try
            koneksi.Open()
            ' MsgBox("Koneksi Berhasil")
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Koneksi Gagal")
        End Try
    End Sub

    Sub diskonek()
        koneksi.Close()
    End Sub
End Module

Public Class OleDbConnection
    Private v As String

    Public Sub New(v As String)
        Me.v = v
    End Sub

    Friend Sub Open()
        Throw New NotImplementedException()
    End Sub

    Friend Sub Close()
        Throw New NotImplementedException()
    End Sub
End Class

Public Class OleDbCommand
End Class

Public Class OleDbDataAdapter
    Public Sub New(v As String, koneksi As OleDbConnection)
    End Sub
End Class

Public Class OleDbDataReader
End Class
