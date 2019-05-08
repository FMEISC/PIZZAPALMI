Imports System.Data
Imports System.Data.SqlClient
Public Class frmProductos
    Private Sub frmProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Config.IniciarConexion()

    End Sub

    Private Sub btnMateriales_Click(sender As Object, e As EventArgs) Handles btnMateriales.Click
        If txtNumProducto.Text.ToString().Trim() = "" Then
            MessageBox.Show("PRIMERO INTRODUZCA EL NUMERO DE PRODUCTO", "PIZZA", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        FrmListaMateriales.ManejodeListadeMateriales(txtNumProducto.Text.ToString(), txtNombre.Text.ToString())
        ActualizarListaMateriales()

    End Sub
    Public Sub ActualizarListaMateriales()
        Dim Comm As New SqlCommand()
        Comm.Connection = ConnSql
        Comm.CommandType = CommandType.Text
        Comm.CommandText = "Select * from ListaMateriales where NumProducto='" & txtNumProducto.Text.ToString _
           & "' Order by idArticulo"
        Dim SqlDA As SqlDataAdapter = New SqlDataAdapter(Comm)
        Dim tblArticulos As DataTable = New DataTable()
        SqlDA.Fill(tblArticulos)
        dgvArticulos.DataSource = tblArticulos

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim Comm As SqlCommand = New SqlCommand()
        Comm.Connection = ConnSql
        Comm.CommandType = CommandType.StoredProcedure
        Comm.CommandText = "INS_PRODUCTOS"
        Comm.Parameters.Add("@NumProducto", SqlDbType.NVarChar, 15).Value = txtNumProducto.Text.ToString()
        Comm.Parameters.Add("@Nombre", SqlDbType.NVarChar, 150).Value = txtNombre.Text.ToString()
        Comm.Parameters.Add("@Costo", SqlDbType.Decimal).Value = Double.Parse(txtCosto.Text.ToString())
        Comm.Parameters.Add("@Precio", SqlDbType.Decimal).Value = Double.Parse(txtPrecio.Text.ToString())
        Comm.ExecuteNonQuery()
        LimpiarPantalla()
    End Sub
    Private Sub LimpiarPantalla()
        txtNumProducto.Text = ""
        txtNombre.Text = ""
        txtCosto.Text = ""
        txtPrecio.Text = ""
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim Comm As SqlCommand = New SqlCommand()
        Comm.Connection = ConnSql
        Comm.CommandType = CommandType.StoredProcedure
        Comm.CommandText = "MODIFICAR_PRODUCTOS"
        Comm.Parameters.Add("@NumProducto", SqlDbType.NVarChar, 15).Value = txtNumProducto.Text.ToString()
        Comm.Parameters.Add("@Nombre", SqlDbType.NVarChar, 150).Value = txtNombre.Text.ToString()
        Comm.Parameters.Add("@Costo", SqlDbType.Decimal).Value = Double.Parse(txtCosto.Text.ToString())
        Comm.Parameters.Add("@Precio", SqlDbType.Decimal).Value = Double.Parse(txtPrecio.Text.ToString())
        Comm.ExecuteNonQuery()
        LimpiarPantalla()

    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Dim Comm As SqlCommand = New SqlCommand()

        Comm.Connection = ConnSql
        Comm.CommandType = CommandType.StoredProcedure
        Comm.CommandText = "BORRAR_PRODUCTOS"
        Comm.Parameters.Add("@NumProducto", SqlDbType.NVarChar, 15).Value = txtNumProducto.Text.ToString()

        Comm.ExecuteNonQuery()
        LimpiarPantalla()

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim Comm As SqlCommand = New SqlCommand()
        Comm.Connection = ConnSql
        Comm.CommandType = CommandType.Text
        Comm.CommandText = "Select * from Productos where NumProducto=@NumProducto"
        Comm.Parameters.Add("@NumProducto", SqlDbType.NVarChar, 15).Value = txtNumProducto.Text.ToString()
        Dim Dr As SqlDataReader
        Dr = Comm.ExecuteReader()
        If Dr.Read() Then
            txtNombre.Text = Dr("Nombre").ToString()
            txtCosto.Text = Dr("Costo").ToString()
            txtPrecio.Text = Dr("Precio").ToString()
        Else
            MessageBox.Show("Regitro No Encontrado", "Pizzas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            LimpiarPantalla()
        End If
        Dr.Close()
        ActualizarListaMateriales()

    End Sub

    Private Sub btnObtenerCosto_Click(sender As Object, e As EventArgs) Handles btnObtenerCosto.Click
        Dim Comm As SqlCommand = New SqlCommand()
        Comm.Connection = ConnSql
        Comm.CommandType = CommandType.Text
        Comm.CommandText = "Select dbo.CostoProducto(@NumProducto) as Costo"
        Comm.Parameters.Add("@NumProducto", SqlDbType.NVarChar, 15).Value = txtNumProducto.Text.ToString()
        Dim Dr As SqlDataReader
        Dr = Comm.ExecuteReader
        If Dr.Read() Then
            txtCosto.Text = Dr("Costo").ToString()
        End If
        Dr.Close()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class