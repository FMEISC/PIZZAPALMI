Imports System.Data
Imports System.Data.SqlClient
Public Class FrmListaMateriales
    Private Sub FrmListaMateriales_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim Comm As SqlCommand = New SqlCommand()
        Comm.Connection = ConnSql
        Comm.CommandType = CommandType.Text
        Comm.CommandText = "Select Nombre,IdArticulo from Articulo Order by Nombre"
        Dim SqlDa As SqlDataAdapter = New SqlDataAdapter(Comm)
        Dim tblArticulos As DataTable = New DataTable()
        SqlDa.Fill(tblArticulos)
        cmbArticuloID.ValueMember = "IdArticulo"
        cmbArticuloID.DisplayMember = "Nombre"
        cmbArticuloID.DataSource = tblArticulos

        Comm.Dispose()

    End Sub
    Public Function ManejodeListadeMateriales(ByVal vProducto As String, ByVal vNombre As String) As DialogResult
        txtNumProducto.Text = vProducto
        txtNombre.Text = vNombre
        Me.Show()
        frmProductos.ActualizarListaMateriales()
        Return btnSalir.DialogResult
    End Function

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        btnSalir.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()

    End Sub

    Private Sub cmbArticuloID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbArticuloID.SelectedIndexChanged
        txtNombreArt.Text = cmbArticuloID.SelectedValue.ToString()
        Dim Comm As SqlCommand = New SqlCommand()
        Comm.Connection = ConnSql
        Comm.CommandType = CommandType.Text
        Comm.CommandText = "Select UnidadMedida from Articulo where IdArticulo='" & cmbArticuloID.SelectedValue.ToString() & "'"
        Dim SqlDR As SqlDataReader
        SqlDR = Comm.ExecuteReader()
        If SqlDR.Read() Then
            txtUnidadMedida.Text = SqlDR("UnidadMedida").ToString()
        End If
        SqlDR.Close()
        Comm.Dispose()

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim Comm As SqlCommand = New SqlCommand()
        Comm.Connection = ConnSql
        Comm.CommandType = CommandType.Text
        Comm.CommandText = "Insert into ListaMateriales(NumProducto,IdArticulo,UnidadMedida,Cantidad) " _
          & "Values(@NumProducto,@IdArticulo,@UnidadMedida,@Cantidad) "
        Comm.Parameters.Add("@NumProducto", SqlDbType.NVarChar, 15).Value = txtNumProducto.Text.ToString()
        Comm.Parameters.Add("@IdArticulo", SqlDbType.NVarChar, 15).Value = cmbArticuloID.SelectedValue.ToString()
        Comm.Parameters.Add("@UnidadMedida", SqlDbType.NVarChar, 15).Value = txtUnidadMedida.Text.ToString()
        Comm.Parameters.Add("@Cantidad", SqlDbType.NVarChar, 15).Value = Decimal.Parse(txtCantidad.Text.ToString())
        Comm.ExecuteNonQuery()
        txtCantidad.Text = 0
        ActualizaLista()

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim Comm As SqlCommand = New SqlCommand()
        Comm.Connection = ConnSql
        Comm.CommandType = CommandType.Text
        Comm.CommandText = "Update ListaMateriales set Cantidad=@Cantidad where NumProducto=@NumProducto and " _
           & "IdArticulo=@IdArticulo "
        Comm.Parameters.Add("@NumProducto", SqlDbType.NVarChar, 15).Value = txtNumProducto.Text.ToString()
        Comm.Parameters.Add("@IDArticulo", SqlDbType.NVarChar, 15).Value = cmbArticuloID.SelectedValue.ToString()
        Comm.Parameters.Add("@Cantidad", SqlDbType.NVarChar, 15).Value = Decimal.Parse(txtCantidad.Text.ToString())
        Comm.ExecuteNonQuery()

        txtCantidad.Text = 0
        ActualizaLista()


    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Dim Comm As SqlCommand = New SqlCommand()
        Comm.Connection = ConnSql
        Comm.CommandType = CommandType.Text
        Comm.CommandText = "Delete from  ListaMateriales where NumProducto=@NumProducto and " _
           & "IDArticulo=@IDArticulo "
        Comm.Parameters.Add("@NumProducto", SqlDbType.NVarChar, 15).Value = txtNumProducto.Text.ToString()
        Comm.Parameters.Add("@IDArticulo", SqlDbType.NVarChar, 15).Value = cmbArticuloID.SelectedValue.ToString()
        Comm.Parameters.Add("@Cantidad", SqlDbType.NVarChar, 15).Value = Decimal.Parse(txtCantidad.Text.ToString())
        Comm.ExecuteNonQuery()

        txtCantidad.Text = 0
        ActualizaLista()

    End Sub
    Private Sub ActualizaLista()
        Dim Comm As SqlCommand
        Comm = New SqlCommand()
        Comm.Connection = ConnSql
        Comm.CommandType = CommandType.Text
        Comm.CommandText = "Select * from ListaMateriales where NumProducto='" & txtNumProducto.Text.ToString _
           & "' Order by idArticulo"
        Dim SqlDA As SqlDataAdapter = New SqlDataAdapter(Comm)
        Dim tblArticulos As DataTable = New DataTable()
        SqlDA.Fill(tblArticulos)
        DgvLista.DataSource = tblArticulos
    End Sub

End Class