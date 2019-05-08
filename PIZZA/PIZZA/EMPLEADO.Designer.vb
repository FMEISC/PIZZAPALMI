<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EMPLEADO
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EMPLEADO))
        Me.cmbCategoria = New System.Windows.Forms.ComboBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblCategoria = New System.Windows.Forms.Label()
        Me.dtpFingreso = New System.Windows.Forms.DateTimePicker()
        Me.txtCategoria = New System.Windows.Forms.TextBox()
        Me.dtpFnac = New System.Windows.Forms.DateTimePicker()
        Me.lblFingreso = New System.Windows.Forms.Label()
        Me.lblRfc = New System.Windows.Forms.Label()
        Me.lblFnac = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblTel = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblAmaterno = New System.Windows.Forms.Label()
        Me.lblApaterno = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.txtRfc = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtaMaterno = New System.Windows.Forms.TextBox()
        Me.txtaPaterno = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtLogin = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.btnFoto = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tolAgregar = New System.Windows.Forms.ToolTip(Me.components)
        Me.tolBuscar = New System.Windows.Forms.ToolTip(Me.components)
        Me.tolEliminar = New System.Windows.Forms.ToolTip(Me.components)
        Me.tolEditar = New System.Windows.Forms.ToolTip(Me.components)
        Me.tolLimpiar = New System.Windows.Forms.ToolTip(Me.components)
        Me.tolImagen = New System.Windows.Forms.ToolTip(Me.components)
        Me.tolSalir = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnGafet = New System.Windows.Forms.Button()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbCategoria
        '
        Me.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategoria.FormattingEnabled = True
        Me.cmbCategoria.Location = New System.Drawing.Point(18, 343)
        Me.cmbCategoria.Name = "cmbCategoria"
        Me.cmbCategoria.Size = New System.Drawing.Size(121, 21)
        Me.cmbCategoria.TabIndex = 1
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblCategoria)
        Me.GroupBox1.Controls.Add(Me.dtpFingreso)
        Me.GroupBox1.Controls.Add(Me.txtCategoria)
        Me.GroupBox1.Controls.Add(Me.dtpFnac)
        Me.GroupBox1.Controls.Add(Me.lblFingreso)
        Me.GroupBox1.Controls.Add(Me.lblRfc)
        Me.GroupBox1.Controls.Add(Me.lblFnac)
        Me.GroupBox1.Controls.Add(Me.lblEmail)
        Me.GroupBox1.Controls.Add(Me.lblTel)
        Me.GroupBox1.Controls.Add(Me.lblDireccion)
        Me.GroupBox1.Controls.Add(Me.lblAmaterno)
        Me.GroupBox1.Controls.Add(Me.lblApaterno)
        Me.GroupBox1.Controls.Add(Me.lblNombre)
        Me.GroupBox1.Controls.Add(Me.lblID)
        Me.GroupBox1.Controls.Add(Me.txtRfc)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.txtTel)
        Me.GroupBox1.Controls.Add(Me.txtDireccion)
        Me.GroupBox1.Controls.Add(Me.txtaMaterno)
        Me.GroupBox1.Controls.Add(Me.txtaPaterno)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(225, 316)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'lblCategoria
        '
        Me.lblCategoria.AutoSize = True
        Me.lblCategoria.Location = New System.Drawing.Point(116, 289)
        Me.lblCategoria.Name = "lblCategoria"
        Me.lblCategoria.Size = New System.Drawing.Size(52, 13)
        Me.lblCategoria.TabIndex = 22
        Me.lblCategoria.Text = "Categoria"
        '
        'dtpFingreso
        '
        Me.dtpFingreso.Location = New System.Drawing.Point(7, 257)
        Me.dtpFingreso.Name = "dtpFingreso"
        Me.dtpFingreso.Size = New System.Drawing.Size(100, 20)
        Me.dtpFingreso.TabIndex = 21
        '
        'txtCategoria
        '
        Me.txtCategoria.Location = New System.Drawing.Point(7, 283)
        Me.txtCategoria.Name = "txtCategoria"
        Me.txtCategoria.Size = New System.Drawing.Size(100, 20)
        Me.txtCategoria.TabIndex = 8
        Me.txtCategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dtpFnac
        '
        Me.dtpFnac.Location = New System.Drawing.Point(6, 203)
        Me.dtpFnac.Name = "dtpFnac"
        Me.dtpFnac.Size = New System.Drawing.Size(100, 20)
        Me.dtpFnac.TabIndex = 20
        '
        'lblFingreso
        '
        Me.lblFingreso.AutoSize = True
        Me.lblFingreso.Location = New System.Drawing.Point(113, 258)
        Me.lblFingreso.Name = "lblFingreso"
        Me.lblFingreso.Size = New System.Drawing.Size(75, 13)
        Me.lblFingreso.TabIndex = 19
        Me.lblFingreso.Text = "Fecha Ingreso"
        '
        'lblRfc
        '
        Me.lblRfc.AutoSize = True
        Me.lblRfc.Location = New System.Drawing.Point(113, 232)
        Me.lblRfc.Name = "lblRfc"
        Me.lblRfc.Size = New System.Drawing.Size(24, 13)
        Me.lblRfc.TabIndex = 18
        Me.lblRfc.Text = "Rfc"
        '
        'lblFnac
        '
        Me.lblFnac.AutoSize = True
        Me.lblFnac.Location = New System.Drawing.Point(113, 205)
        Me.lblFnac.Name = "lblFnac"
        Me.lblFnac.Size = New System.Drawing.Size(75, 13)
        Me.lblFnac.TabIndex = 17
        Me.lblFnac.Text = "Fecha de Nac"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(113, 178)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(39, 13)
        Me.lblEmail.TabIndex = 16
        Me.lblEmail.Text = "E_Mail"
        '
        'lblTel
        '
        Me.lblTel.AutoSize = True
        Me.lblTel.Location = New System.Drawing.Point(113, 155)
        Me.lblTel.Name = "lblTel"
        Me.lblTel.Size = New System.Drawing.Size(49, 13)
        Me.lblTel.TabIndex = 15
        Me.lblTel.Text = "Telefono"
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Location = New System.Drawing.Point(113, 129)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(52, 13)
        Me.lblDireccion.TabIndex = 14
        Me.lblDireccion.Text = "Direccion"
        '
        'lblAmaterno
        '
        Me.lblAmaterno.AutoSize = True
        Me.lblAmaterno.Location = New System.Drawing.Point(113, 100)
        Me.lblAmaterno.Name = "lblAmaterno"
        Me.lblAmaterno.Size = New System.Drawing.Size(86, 13)
        Me.lblAmaterno.TabIndex = 13
        Me.lblAmaterno.Text = "Apellido Materno"
        '
        'lblApaterno
        '
        Me.lblApaterno.AutoSize = True
        Me.lblApaterno.Location = New System.Drawing.Point(113, 74)
        Me.lblApaterno.Name = "lblApaterno"
        Me.lblApaterno.Size = New System.Drawing.Size(84, 13)
        Me.lblApaterno.TabIndex = 12
        Me.lblApaterno.Text = "Apellido Paterno"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(113, 51)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 11
        Me.lblNombre.Text = "Nombre"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(113, 25)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(72, 13)
        Me.lblID.TabIndex = 10
        Me.lblID.Text = "ID de Usuario"
        '
        'txtRfc
        '
        Me.txtRfc.Location = New System.Drawing.Point(6, 229)
        Me.txtRfc.Name = "txtRfc"
        Me.txtRfc.Size = New System.Drawing.Size(100, 20)
        Me.txtRfc.TabIndex = 7
        Me.txtRfc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(6, 175)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(100, 20)
        Me.txtEmail.TabIndex = 6
        Me.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTel
        '
        Me.txtTel.Location = New System.Drawing.Point(6, 148)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(100, 20)
        Me.txtTel.TabIndex = 5
        Me.txtTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(6, 122)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(100, 20)
        Me.txtDireccion.TabIndex = 4
        Me.txtDireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtaMaterno
        '
        Me.txtaMaterno.Location = New System.Drawing.Point(6, 97)
        Me.txtaMaterno.Name = "txtaMaterno"
        Me.txtaMaterno.Size = New System.Drawing.Size(100, 20)
        Me.txtaMaterno.TabIndex = 3
        Me.txtaMaterno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtaPaterno
        '
        Me.txtaPaterno.Location = New System.Drawing.Point(6, 71)
        Me.txtaPaterno.Name = "txtaPaterno"
        Me.txtaPaterno.Size = New System.Drawing.Size(100, 20)
        Me.txtaPaterno.TabIndex = 2
        Me.txtaPaterno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(6, 45)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 1
        Me.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(6, 19)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 0
        Me.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtLogin
        '
        Me.txtLogin.Location = New System.Drawing.Point(400, 227)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(100, 20)
        Me.txtLogin.TabIndex = 7
        Me.txtLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(400, 277)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(100, 20)
        Me.txtPass.TabIndex = 8
        Me.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(515, 230)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Login"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(518, 283)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Password"
        '
        'btnSalir
        '
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Image = Global.PIZZA.My.Resources.Resources.exit_closethesession_close_6317
        Me.btnSalir.Location = New System.Drawing.Point(510, 329)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(60, 47)
        Me.btnSalir.TabIndex = 14
        Me.tolSalir.SetToolTip(Me.btnSalir, "Exit")
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.FlatAppearance.BorderSize = 0
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.Image = Global.PIZZA.My.Resources.Resources.Clear_37294
        Me.btnLimpiar.Location = New System.Drawing.Point(258, 262)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(60, 47)
        Me.btnLimpiar.TabIndex = 13
        Me.tolLimpiar.SetToolTip(Me.btnLimpiar, "Limpiar Datos")
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.FlatAppearance.BorderSize = 0
        Me.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizar.Image = Global.PIZZA.My.Resources.Resources.businessapplication_edit_male_user_thepencil_theclient_negocio_2321_1_
        Me.btnActualizar.Location = New System.Drawing.Point(258, 199)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(60, 47)
        Me.btnActualizar.TabIndex = 12
        Me.tolEditar.SetToolTip(Me.btnActualizar, "Editar Usuario")
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Image = Global.PIZZA.My.Resources.Resources.delete_delete_deleteusers_delete_male_user_maleclient_2348
        Me.btnEliminar.Location = New System.Drawing.Point(258, 140)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(60, 47)
        Me.btnEliminar.TabIndex = 11
        Me.tolEliminar.SetToolTip(Me.btnEliminar, "Eliminar Usuario")
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.FlatAppearance.BorderSize = 0
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Image = Global.PIZZA.My.Resources.Resources.business_man_usersearch_thesearch_theclient_2356_1_
        Me.btnBuscar.Location = New System.Drawing.Point(258, 29)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(60, 47)
        Me.btnBuscar.TabIndex = 6
        Me.btnBuscar.Tag = ""
        Me.tolBuscar.SetToolTip(Me.btnBuscar, "Buscar Usuario")
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'BtnAgregar
        '
        Me.BtnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAgregar.FlatAppearance.BorderSize = 0
        Me.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgregar.Image = Global.PIZZA.My.Resources.Resources.business_application_addmale_useradd_insert_add_user_client_2312_1_
        Me.BtnAgregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnAgregar.Location = New System.Drawing.Point(258, 87)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(60, 47)
        Me.BtnAgregar.TabIndex = 3
        Me.tolAgregar.SetToolTip(Me.BtnAgregar, "Agregar Usuario")
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'btnFoto
        '
        Me.btnFoto.FlatAppearance.BorderSize = 0
        Me.btnFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFoto.Image = Global.PIZZA.My.Resources.Resources.iPhoto_photo_picture_camera_2661
        Me.btnFoto.Location = New System.Drawing.Point(440, 165)
        Me.btnFoto.Name = "btnFoto"
        Me.btnFoto.Size = New System.Drawing.Size(60, 47)
        Me.btnFoto.TabIndex = 2
        Me.tolImagen.SetToolTip(Me.btnFoto, "Agregar Imagen")
        Me.btnFoto.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(392, 40)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(160, 119)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnGafet
        '
        Me.btnGafet.Location = New System.Drawing.Point(352, 343)
        Me.btnGafet.Name = "btnGafet"
        Me.btnGafet.Size = New System.Drawing.Size(75, 23)
        Me.btnGafet.TabIndex = 15
        Me.btnGafet.Text = "Gafet"
        Me.btnGafet.UseVisualStyleBackColor = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDocument1
        '
        '
        'EMPLEADO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 385)
        Me.Controls.Add(Me.btnGafet)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtLogin)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.btnFoto)
        Me.Controls.Add(Me.cmbCategoria)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EMPLEADO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EMPLEADO"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cmbCategoria As ComboBox
    Friend WithEvents btnFoto As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtaPaterno As TextBox
    Friend WithEvents txtaMaterno As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtTel As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtRfc As TextBox
    Friend WithEvents lblFingreso As Label
    Friend WithEvents lblRfc As Label
    Friend WithEvents lblFnac As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblTel As Label
    Friend WithEvents lblDireccion As Label
    Friend WithEvents lblAmaterno As Label
    Friend WithEvents lblApaterno As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblID As Label
    Friend WithEvents dtpFingreso As DateTimePicker
    Friend WithEvents dtpFnac As DateTimePicker
    Friend WithEvents txtCategoria As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents lblCategoria As Label
    Friend WithEvents txtLogin As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents tolAgregar As ToolTip
    Friend WithEvents tolBuscar As ToolTip
    Friend WithEvents tolLimpiar As ToolTip
    Friend WithEvents tolEditar As ToolTip
    Friend WithEvents tolEliminar As ToolTip
    Friend WithEvents tolImagen As ToolTip
    Friend WithEvents tolSalir As ToolTip
    Friend WithEvents btnGafet As Button
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
