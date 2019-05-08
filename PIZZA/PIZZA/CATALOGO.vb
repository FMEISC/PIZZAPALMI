Imports System.Data.SqlClient
Imports System.Data
Public Class CATALOGO
    Private Sub EmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadoToolStripMenuItem.Click
        EMPLEADO.Show()
        Me.Hide()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Config.IniciarConexion()
    End Sub

    Private Sub EXITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXITToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub InicioCajasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InicioCajasToolStripMenuItem.Click
        InicioCajas.Show()
        Me.Hide()
    End Sub
End Class
