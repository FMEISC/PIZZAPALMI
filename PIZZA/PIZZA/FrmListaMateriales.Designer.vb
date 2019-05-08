<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListaMateriales
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblNumPro = New System.Windows.Forms.Label()
        Me.txtNumProducto = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblArticulo = New System.Windows.Forms.Label()
        Me.cmbArticuloID = New System.Windows.Forms.ComboBox()
        Me.lblIdArticulo = New System.Windows.Forms.Label()
        Me.txtNombreArt = New System.Windows.Forms.TextBox()
        Me.lblUnidadMEdi = New System.Windows.Forms.Label()
        Me.txtUnidadMedida = New System.Windows.Forms.TextBox()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.DgvLista = New System.Windows.Forms.DataGridView()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNumPro
        '
        Me.lblNumPro.AutoSize = True
        Me.lblNumPro.Location = New System.Drawing.Point(13, 13)
        Me.lblNumPro.Name = "lblNumPro"
        Me.lblNumPro.Size = New System.Drawing.Size(78, 13)
        Me.lblNumPro.TabIndex = 0
        Me.lblNumPro.Text = "Num Producto:"
        '
        'txtNumProducto
        '
        Me.txtNumProducto.Location = New System.Drawing.Point(16, 30)
        Me.txtNumProducto.Name = "txtNumProducto"
        Me.txtNumProducto.Size = New System.Drawing.Size(141, 20)
        Me.txtNumProducto.TabIndex = 1
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(187, 29)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(332, 20)
        Me.txtNombre.TabIndex = 2
        '
        'lblArticulo
        '
        Me.lblArticulo.AutoSize = True
        Me.lblArticulo.Location = New System.Drawing.Point(6, 28)
        Me.lblArticulo.Name = "lblArticulo"
        Me.lblArticulo.Size = New System.Drawing.Size(45, 13)
        Me.lblArticulo.TabIndex = 3
        Me.lblArticulo.Text = "Articulo:"
        '
        'cmbArticuloID
        '
        Me.cmbArticuloID.FormattingEnabled = True
        Me.cmbArticuloID.Location = New System.Drawing.Point(117, 25)
        Me.cmbArticuloID.Name = "cmbArticuloID"
        Me.cmbArticuloID.Size = New System.Drawing.Size(392, 21)
        Me.cmbArticuloID.TabIndex = 4
        '
        'lblIdArticulo
        '
        Me.lblIdArticulo.AutoSize = True
        Me.lblIdArticulo.Location = New System.Drawing.Point(6, 70)
        Me.lblIdArticulo.Name = "lblIdArticulo"
        Me.lblIdArticulo.Size = New System.Drawing.Size(56, 13)
        Me.lblIdArticulo.TabIndex = 5
        Me.lblIdArticulo.Text = "ID Articulo"
        '
        'txtNombreArt
        '
        Me.txtNombreArt.Location = New System.Drawing.Point(117, 63)
        Me.txtNombreArt.Name = "txtNombreArt"
        Me.txtNombreArt.Size = New System.Drawing.Size(201, 20)
        Me.txtNombreArt.TabIndex = 6
        '
        'lblUnidadMEdi
        '
        Me.lblUnidadMEdi.AutoSize = True
        Me.lblUnidadMEdi.Location = New System.Drawing.Point(6, 99)
        Me.lblUnidadMEdi.Name = "lblUnidadMEdi"
        Me.lblUnidadMEdi.Size = New System.Drawing.Size(97, 13)
        Me.lblUnidadMEdi.TabIndex = 7
        Me.lblUnidadMEdi.Text = "Unidad de Medida:"
        '
        'txtUnidadMedida
        '
        Me.txtUnidadMedida.Location = New System.Drawing.Point(117, 99)
        Me.txtUnidadMedida.Name = "txtUnidadMedida"
        Me.txtUnidadMedida.Size = New System.Drawing.Size(201, 20)
        Me.txtUnidadMedida.TabIndex = 8
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Location = New System.Drawing.Point(6, 135)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(52, 13)
        Me.lblCantidad.TabIndex = 9
        Me.lblCantidad.Text = "Cantidad:"
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(117, 132)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(201, 20)
        Me.txtCantidad.TabIndex = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblArticulo)
        Me.GroupBox1.Controls.Add(Me.txtCantidad)
        Me.GroupBox1.Controls.Add(Me.cmbArticuloID)
        Me.GroupBox1.Controls.Add(Me.lblCantidad)
        Me.GroupBox1.Controls.Add(Me.lblIdArticulo)
        Me.GroupBox1.Controls.Add(Me.txtUnidadMedida)
        Me.GroupBox1.Controls.Add(Me.txtNombreArt)
        Me.GroupBox1.Controls.Add(Me.lblUnidadMEdi)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 72)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(553, 174)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(102, 252)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 12
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(195, 252)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 13
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(285, 252)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(75, 23)
        Me.btnBorrar.TabIndex = 14
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'DgvLista
        '
        Me.DgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvLista.Location = New System.Drawing.Point(16, 296)
        Me.DgvLista.Name = "DgvLista"
        Me.DgvLista.Size = New System.Drawing.Size(553, 86)
        Me.DgvLista.TabIndex = 15
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(376, 252)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 16
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'FrmListaMateriales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(589, 398)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.DgvLista)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtNumProducto)
        Me.Controls.Add(Me.lblNumPro)
        Me.Name = "FrmListaMateriales"
        Me.Text = "Lista de Materiales"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DgvLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNumPro As Label
    Friend WithEvents txtNumProducto As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblArticulo As Label
    Friend WithEvents cmbArticuloID As ComboBox
    Friend WithEvents lblIdArticulo As Label
    Friend WithEvents txtNombreArt As TextBox
    Friend WithEvents lblUnidadMEdi As Label
    Friend WithEvents txtUnidadMedida As TextBox
    Friend WithEvents lblCantidad As Label
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnBorrar As Button
    Friend WithEvents DgvLista As DataGridView
    Friend WithEvents btnSalir As Button
End Class
