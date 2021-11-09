Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bClear.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles bHapus.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilData()
    End Sub

    Sub tampilData()
        konek()
        da = New OleDbDataAdapter(" SELECT * from BetaMart", koneksi)
        dt = New DataTable
        da.Fill(dt)
        dg1.DataSource = dt
        diskonek()
    End Sub


End Class
