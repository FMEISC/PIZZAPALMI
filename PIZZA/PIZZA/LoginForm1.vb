Imports System.Data
Imports System.Data.SqlClient
Public Class LoginForm1

    ' TODO: inserte el código para realizar autenticación personalizada usando el nombre de usuario y la contraseña proporcionada 
    ' (Consulte http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' El objeto principal personalizado se puede adjuntar al objeto principal del subproceso actual como se indica a continuación: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' donde CustomPrincipal es la implementación de IPrincipal utilizada para realizar la autenticación. 
    ' Posteriormente, My.User devolverá la información de identidad encapsulada en el objeto CustomPrincipal
    ' como el nombre de usuario, nombre para mostrar, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If txtlogin.Text.Trim() = "" Then
            Exit Sub
        End If

        Dim acc As String = ""
        Dim pass As String = ""
        Dim Comm As New SqlCommand()
        Comm.Connection = ConnSql
        Comm.CommandText = "AccesoUsuarioLogin"
        Comm.CommandType = CommandType.StoredProcedure
        Comm.Parameters.Add("@Login", SqlDbType.NChar, 25).Value = txtlogin.Text.ToString()
        Comm.Parameters.Add("@Password", SqlDbType.NChar, 35).Value = txtpass.Text.ToString()

        Dim DReader As SqlDataReader = Comm.ExecuteReader
        If DReader.HasRows Then
            While DReader.Read()
                acc = DReader("Nombre_Cat")
                pass = DReader("Password")

            End While
        Else
            MessageBox.Show("Usuario no encontrado", "Acceso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        DReader.Close()
        Select Case acc.Trim()
            Case "Administrador"
                CATALOGO.Show()
            Case "Cajero"
                InicioCajas.Show()
            Case ""
                Exit Sub
        End Select
        Me.Close()

        '//////////////////////////////////////////////////////////////////////////////////////////////
        '    Dim vAccesoConcedido As Boolean = False

        '    'Se declara una variable de tipo SqlCommand para realizar la consulta
        '    Dim Comm As SqlCommand = New SqlCommand()
        '    'Se establece la conexion a utilizar por el Commando
        '    Comm.Connection = ConnSql
        '    'Se establece como un comando de tipo Texto (o sea que se enviara una sentencia SQL)
        '    Comm.CommandType = CommandType.Text
        '    'Se asigna la sentencia sql al Comando, donde la variable @login de sql, se debe enviar
        '    'como un parametro al comando
        '    Comm.CommandText = "Select * from Acceso where Login=@Login"
        '    'Se agrega el parametro requerido para la consulta
        '    'un parametro se compone del nombre de la variable, tipo y longitud y en el caso
        '    'de la sentencia abajo se asigna el valor en el mismo renglon.
        '    Comm.Parameters.Add("@Login", SqlDbType.NChar, 25).Value = txtlogin.Text.ToString()
        '    'Se declara una variable de tipo SQLDataReader para realizar la consulta..
        '    Dim Dr As SqlDataReader
        '    'se ejecuta el comando y se asigna al reader
        '    Dr = Comm.ExecuteReader()
        '    'si se encontro la informacion
        '    If Dr.Read() Then
        '        'se verifica que el password sea el correcto
        '        If Dr("Password").ToString() = txtpass.Text.ToString() Then
        '            ' si es correcto, se pone en verdadero la variable booleana de acceso y se 
        '            ' asigna los valores a la variable de tipo estructura para guardarse en memoria.
        '            vAccesoConcedido = True
        '            Config.IdUsuario = Dr("NumEmpleado").ToString()

        '        Else
        '            MessageBox.Show("Error Password Invalido", "Pizzas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        End If
        '    Else
        '        MessageBox.Show("Usuario no Encontrado", "Pizzas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    End If
        '    'se cierra el datareader.
        '    Dr.Close()

        '    ' si el accesos es concedido
        '    If vAccesoConcedido = True Then
        '        'se verifica la categoria para determinar a que pantalla se da accesos
        '        Select Case acc.trim()
        '            Case "Administrador"
        '                CATALOGO.Show()
        '            Case "Cajero"
        '                InicioCajas.Show()
        '        End Select
        '        'se cierra la forma
        '        Me.Close()
        '    End If

    End Sub



    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        CATEGORIA.Show()
        Me.Hide()
    End Sub

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub
End Class
