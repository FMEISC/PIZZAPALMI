Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing.Printing
Public Class EMPLEADO
    Dim verfoto As String
    Private Sub EMPLEADO_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LlenarCategoria()
    End Sub
    Public Sub LlenarCategoria()
        Dim Comm As New SqlCommand()
        Comm.Connection = ConnSql
        Comm.CommandText = "Select Id_Categoria, Nombre_Cat from Categoria Order by Nombre_Cat"
        Comm.CommandType = CommandType.Text
        Dim sqlAd As SqlDataAdapter = New SqlDataAdapter(Comm)
        Dim tblCategoria As New DataTable()
        sqlAd.Fill(tblCategoria)
        cmbCategoria.ValueMember = "Id_Categoria"
        cmbCategoria.DisplayMember = "Nombre_Cat"
        cmbCategoria.DataSource = tblCategoria

    End Sub

    Private Sub btnFoto_Click(sender As Object, e As EventArgs) Handles btnFoto.Click
        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.FileName.ToString().Trim() <> "" Then verfoto = OpenFileDialog1.FileName
        PictureBox1.Image = Image.FromFile(verfoto)

    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Dim Comm As New SqlCommand
        Comm.Connection = ConnSql
        Comm.CommandText = "Insert into Empleados (Id_Usuario, Nombre, A_Paterno, A_Materno, Direccion, Tel, E_mail, F_Nac, Rfc, F_Ingreso, Id_Categoria, Foto)" _
    & "Values (@Id_Usuario, @Nombre, @A_Paterno, @A_Materno, @Direccion, @Tel, @E_mail, @F_Nac, @Rfc, @F_Ingreso, @Id_Categoria, @Foto)"
        Comm.CommandType = CommandType.Text
        Comm.Parameters.Add("@Id_Usuario", SqlDbType.NChar, 10).Value = txtID.Text.ToString()
        Comm.Parameters.Add("@Nombre", SqlDbType.NChar, 20).Value = txtNombre.Text.ToString()
        Comm.Parameters.Add("@A_Paterno", SqlDbType.NChar, 30).Value = txtaPaterno.Text.ToString()
        Comm.Parameters.Add("@A_Materno", SqlDbType.NChar, 30).Value = txtaMaterno.Text.ToString()
        Comm.Parameters.Add("@Direccion", SqlDbType.VarChar, 50).Value = txtDireccion.Text.ToString()
        Comm.Parameters.Add("@Tel", SqlDbType.NChar, 12).Value = txtTel.Text.ToString()
        Comm.Parameters.Add("@E_mail", SqlDbType.VarChar, 50).Value = txtEmail.Text.ToString()
        Comm.Parameters.Add("@F_Nac", SqlDbType.Date).Value = dtpFnac.Text.ToString()
        Comm.Parameters.Add("@Rfc", SqlDbType.NChar, 30).Value = txtRfc.Text.ToString()
        Comm.Parameters.Add("@F_Ingreso", SqlDbType.Date).Value = dtpFingreso.Text.ToString()
        Comm.Parameters.Add("@Id_Categoria", SqlDbType.NChar, 8).Value = txtCategoria.Text.ToString()
        Comm.Parameters.Add("@Foto", SqlDbType.NVarChar, 150).Value = OpenFileDialog1.FileName.ToString().Trim

        Comm.ExecuteNonQuery()
        MessageBox.Show(" USUARIO AGREGADO CORRECTAMENTE ")

        Comm.CommandText = "Insert into Acceso (Id_Usuario, Login, Password)" _
        & "Values(@Id,@Login,@Password)"
        Comm.Parameters.Add("@Id", SqlDbType.NChar, 10).Value = txtID.Text.ToString()
        Comm.Parameters.Add("@Login", SqlDbType.NChar, 25).Value = txtLogin.Text.ToString()
        Comm.Parameters.Add("@Password", SqlDbType.NChar, 35).Value = txtPass.Text.ToString()
        Comm.ExecuteNonQuery()


    End Sub

    Private Sub cmbCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategoria.SelectedIndexChanged

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        Dim Comm As New SqlCommand()
        Comm.Connection = ConnSql
        Comm.CommandText = "Select Empleados.*, Acceso.Login, Acceso.Password from Empleados inner join Acceso" _
            & " on Empleados.Id_Usuario=Acceso.Id_Usuario where Empleados.Id_Usuario=@id"
        Comm.CommandType = CommandType.Text
        Comm.Parameters.Add("@id", SqlDbType.NChar, 10).Value = txtID.Text.ToString()
        Dim DReader As SqlDataReader = Comm.ExecuteReader
        If DReader.HasRows Then
            While DReader.Read()
                txtID.Text = DReader("Id_Usuario")
                cmbCategoria.SelectedValue = DReader("Id_Categoria")


                'LE ESTAMOS DICIENDO QUE NOS MUESTRE EL CONTENIDO QUE ESTA GUARDADO EN NUESTRA BD
                If Not DReader.IsDBNull(DReader.GetOrdinal("Foto")) Then
                    PictureBox1.Image = Image.FromFile(DReader("Foto"))
                    'SE PUEDE USAR ESTA FORMA MANDAMOS LLAMAR A LA FILA DE NUESTRA BASE DE DATOS
                    txtNombre.Text = DReader("Nombre")
                    'O DE ESTA FORMA PERO ES MEJOR LA PRIMERA PORQUE ESTA SE TIENE QUE CONVERTIR EL DATO EN OCACIONES
                    txtaPaterno.Text = DReader.GetString(2)
                    txtaMaterno.Text = DReader.GetString(3)
                    txtDireccion.Text = DReader.GetString(4)
                    txtTel.Text = DReader.GetValue(5).ToString()
                    txtEmail.Text = DReader.GetString(6)
                    dtpFnac.Text = DReader.GetValue(7).ToString
                    txtRfc.Text = DReader.GetString(8)
                    dtpFingreso.Text = DReader.GetValue(9).ToString
                    txtCategoria.Text = DReader.GetString(10)
                    txtLogin.Text = DReader("Login")
                    txtPass.Text = DReader("Password")

                Else
                    PictureBox1.Image = Nothing
                End If



            End While
            DReader.Close()

        End If




    End Sub

    'Boton para ELIMINAR 
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim Comm As New SqlCommand()
        Comm.Connection = ConnSql
        Comm.CommandText = ("Delete from Empleados where Id_Usuario=" + txtID.Text)
        Try
            Comm.ExecuteNonQuery()
            MessageBox.Show(" Usuario Eliminado Correctamente ")
        Catch ex As Exception
            MessageBox.Show("Error")
        End Try
    End Sub


    'BOTON PARA ACTUALIZAR SOLO LOS DATOS DE EMPLEADO
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim Comm As New SqlCommand
        Comm.Connection = ConnSql
        Comm.CommandText = "Update Empleados set Nombre=@Nombre, A_Paterno=@A_Paterno, A_Materno=@A_Materno, Direccion=@Direccion, Tel=@Tel, E_mail=@E_mail, 
            F_Nac=@F_Nac, Rfc=@Rfc, F_Ingreso=@F_Ingreso, Id_Categoria=@Id_Categoria, Foto=@Foto WHERE Id_Usuario=@Id_Usuario"


        Comm.Parameters.Add("@Id_Usuario", SqlDbType.NChar, 10).Value = txtID.Text.ToString()
        Comm.Parameters.Add("@Nombre", SqlDbType.NChar, 20).Value = txtNombre.Text.ToString()
        Comm.Parameters.Add("@A_Paterno", SqlDbType.NChar, 30).Value = txtaPaterno.Text.ToString()
        Comm.Parameters.Add("@A_Materno", SqlDbType.NChar, 30).Value = txtaMaterno.Text.ToString()
        Comm.Parameters.Add("@Direccion", SqlDbType.VarChar, 50).Value = txtDireccion.Text.ToString()
        Comm.Parameters.Add("@Tel", SqlDbType.NChar, 12).Value = txtTel.Text.ToString()
        Comm.Parameters.Add("@E_mail", SqlDbType.VarChar, 50).Value = txtEmail.Text.ToString()
        Comm.Parameters.Add("@F_Nac", SqlDbType.Date).Value = dtpFnac.Text.ToString()
        Comm.Parameters.Add("@Rfc", SqlDbType.NChar, 30).Value = txtRfc.Text.ToString()
        Comm.Parameters.Add("@F_Ingreso", SqlDbType.Date).Value = dtpFingreso.Text.ToString()
        Comm.Parameters.Add("@Id_Categoria", SqlDbType.NChar, 8).Value = txtCategoria.Text.ToString()
        Comm.Parameters.Add("@Foto", SqlDbType.NVarChar, 150).Value = OpenFileDialog1.FileName.ToString().Trim

        Comm.ExecuteNonQuery()
        MessageBox.Show(" Se Edito Correctamente el Usuario ")
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        PictureBox1.Image = Nothing
        txtID.Clear()
        txtaPaterno.Clear()
        txtaMaterno.Clear()
        txtCategoria.Clear()
        txtDireccion.Clear()
        txtEmail.Clear()
        txtLogin.Clear()
        txtPass.Clear()
        dtpFingreso.Text = ""
        dtpFnac.Text = ""
        cmbCategoria.Text = ""
        txtRfc.Clear()
        txtTel.Clear()
        txtNombre.Clear()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        Me.Close()

    End Sub

    Private Sub btnGafet_Click(sender As Object, e As EventArgs) Handles btnGafet.Click
        PrintPreviewDialog1.ShowDialog()

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawRectangle(Pens.Black, New Rectangle(10, 10, 400, 600))
        e.Graphics.DrawImage(PictureBox1.Image, 90, 30)
        Dim fuente As Font = New Font("Arial", 14, FontStyle.Bold)
        e.Graphics.DrawString("Nombre: " & txtNombre.Text.Trim() & " " & txtaPaterno.Text.Trim(), fuente, Brushes.Black, New Point(25, 200))
        e.Graphics.DrawString("Categoria " & cmbCategoria.Text.Trim(), fuente, Brushes.Black, New Point(25, 230))
        e.Graphics.DrawString("Empleado: ", fuente, Brushes.Black, New Point(25, 350))
        fuente = New Font("ABC C39 Tall Text", 16, FontStyle.Regular)
        e.Graphics.DrawString("*" & txtID.Text.Trim() & "*", fuente, Brushes.Black, New Point(150, 400))

    End Sub
End Class