<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InicioCajas
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
        Me.gpbBuscarProducto = New System.Windows.Forms.GroupBox()
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.txtProducto = New System.Windows.Forms.TextBox()
        Me.dgvVentaDetalles = New System.Windows.Forms.DataGridView()
        Me.txtTipoProd = New System.Windows.Forms.TextBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtNumProducto = New System.Windows.Forms.TextBox()
        Me.txtNombreProducto = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnDom = New System.Windows.Forms.Button()
        Me.btnTel = New System.Windows.Forms.Button()
        Me.btnLocal = New System.Windows.Forms.Button()
        Me.btnParaLlevar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.btnNuevaVenta = New System.Windows.Forms.Button()
        Me.gpbDetalles = New System.Windows.Forms.GroupBox()
        Me.mskTxtTotal = New System.Windows.Forms.MaskedTextBox()
        Me.gpbBuscarProducto.SuspendLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvVentaDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.gpbDetalles.SuspendLayout()
        Me.SuspendLayout()
        '
        'gpbBuscarProducto
        '
        Me.gpbBuscarProducto.Controls.Add(Me.dgvProductos)
        Me.gpbBuscarProducto.Controls.Add(Me.txtProducto)
        Me.gpbBuscarProducto.Location = New System.Drawing.Point(12, 77)
        Me.gpbBuscarProducto.Name = "gpbBuscarProducto"
        Me.gpbBuscarProducto.Size = New System.Drawing.Size(569, 145)
        Me.gpbBuscarProducto.TabIndex = 1
        Me.gpbBuscarProducto.TabStop = False
        Me.gpbBuscarProducto.Text = "PRODUCTO"
        '
        'dgvProductos
        '
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductos.Location = New System.Drawing.Point(6, 46)
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.Size = New System.Drawing.Size(468, 78)
        Me.dgvProductos.TabIndex = 1
        '
        'txtProducto
        '
        Me.txtProducto.Location = New System.Drawing.Point(7, 20)
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.Size = New System.Drawing.Size(468, 20)
        Me.txtProducto.TabIndex = 0
        '
        'dgvVentaDetalles
        '
        Me.dgvVentaDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVentaDetalles.Location = New System.Drawing.Point(26, 108)
        Me.dgvVentaDetalles.Name = "dgvVentaDetalles"
        Me.dgvVentaDetalles.Size = New System.Drawing.Size(509, 89)
        Me.dgvVentaDetalles.TabIndex = 11
        '
        'txtTipoProd
        '
        Me.txtTipoProd.Location = New System.Drawing.Point(6, 73)
        Me.txtTipoProd.Name = "txtTipoProd"
        Me.txtTipoProd.Size = New System.Drawing.Size(54, 20)
        Me.txtTipoProd.TabIndex = 10
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(488, 68)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(76, 20)
        Me.txtCantidad.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(417, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "CANTIDAD:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "ID.ARTICULO"
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Location = New System.Drawing.Point(255, 73)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(50, 13)
        Me.lblPrecio.TabIndex = 6
        Me.lblPrecio.Text = "PRECIO:"
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(311, 70)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecio.TabIndex = 5
        '
        'txtNumProducto
        '
        Me.txtNumProducto.Location = New System.Drawing.Point(142, 70)
        Me.txtNumProducto.Name = "txtNumProducto"
        Me.txtNumProducto.Size = New System.Drawing.Size(116, 20)
        Me.txtNumProducto.TabIndex = 4
        '
        'txtNombreProducto
        '
        Me.txtNombreProducto.Location = New System.Drawing.Point(26, 26)
        Me.txtNombreProducto.Name = "txtNombreProducto"
        Me.txtNombreProducto.Size = New System.Drawing.Size(467, 20)
        Me.txtNombreProducto.TabIndex = 3
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnSalir)
        Me.GroupBox3.Controls.Add(Me.btnDom)
        Me.GroupBox3.Controls.Add(Me.btnTel)
        Me.GroupBox3.Controls.Add(Me.btnLocal)
        Me.GroupBox3.Controls.Add(Me.btnParaLlevar)
        Me.GroupBox3.Location = New System.Drawing.Point(606, 89)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(194, 268)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "SELECCIONE EL TIPO DE VENTA"
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(40, 212)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(133, 41)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnDom
        '
        Me.btnDom.Location = New System.Drawing.Point(40, 163)
        Me.btnDom.Name = "btnDom"
        Me.btnDom.Size = New System.Drawing.Size(133, 41)
        Me.btnDom.TabIndex = 3
        Me.btnDom.Text = "ENGREGA A DOMICILIO"
        Me.btnDom.UseVisualStyleBackColor = True
        '
        'btnTel
        '
        Me.btnTel.Location = New System.Drawing.Point(40, 116)
        Me.btnTel.Name = "btnTel"
        Me.btnTel.Size = New System.Drawing.Size(133, 41)
        Me.btnTel.TabIndex = 2
        Me.btnTel.Text = "TELEFONO/RECOGER EN LOCAL"
        Me.btnTel.UseVisualStyleBackColor = True
        '
        'btnLocal
        '
        Me.btnLocal.Location = New System.Drawing.Point(40, 69)
        Me.btnLocal.Name = "btnLocal"
        Me.btnLocal.Size = New System.Drawing.Size(133, 41)
        Me.btnLocal.TabIndex = 1
        Me.btnLocal.Text = "CONSUMO EN LOCAL"
        Me.btnLocal.UseVisualStyleBackColor = True
        '
        'btnParaLlevar
        '
        Me.btnParaLlevar.Location = New System.Drawing.Point(40, 22)
        Me.btnParaLlevar.Name = "btnParaLlevar"
        Me.btnParaLlevar.Size = New System.Drawing.Size(133, 41)
        Me.btnParaLlevar.TabIndex = 0
        Me.btnParaLlevar.Text = "PARA LLEVAR"
        Me.btnParaLlevar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(634, 431)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "TOTAL:   $"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txtID)
        Me.Panel2.Controls.Add(Me.btnNuevaVenta)
        Me.Panel2.Location = New System.Drawing.Point(28, 13)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(481, 47)
        Me.Panel2.TabIndex = 5
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(135, 14)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(171, 20)
        Me.txtID.TabIndex = 1
        '
        'btnNuevaVenta
        '
        Me.btnNuevaVenta.Location = New System.Drawing.Point(7, 12)
        Me.btnNuevaVenta.Name = "btnNuevaVenta"
        Me.btnNuevaVenta.Size = New System.Drawing.Size(108, 23)
        Me.btnNuevaVenta.TabIndex = 0
        Me.btnNuevaVenta.Text = "Nueva Ventana"
        Me.btnNuevaVenta.UseVisualStyleBackColor = True
        '
        'gpbDetalles
        '
        Me.gpbDetalles.Controls.Add(Me.dgvVentaDetalles)
        Me.gpbDetalles.Controls.Add(Me.txtTipoProd)
        Me.gpbDetalles.Controls.Add(Me.txtNumProducto)
        Me.gpbDetalles.Controls.Add(Me.txtNombreProducto)
        Me.gpbDetalles.Controls.Add(Me.txtCantidad)
        Me.gpbDetalles.Controls.Add(Me.txtPrecio)
        Me.gpbDetalles.Controls.Add(Me.Label2)
        Me.gpbDetalles.Controls.Add(Me.lblPrecio)
        Me.gpbDetalles.Controls.Add(Me.Label1)
        Me.gpbDetalles.Location = New System.Drawing.Point(12, 228)
        Me.gpbDetalles.Name = "gpbDetalles"
        Me.gpbDetalles.Size = New System.Drawing.Size(569, 229)
        Me.gpbDetalles.TabIndex = 12
        Me.gpbDetalles.TabStop = False
        '
        'mskTxtTotal
        '
        Me.mskTxtTotal.Location = New System.Drawing.Point(700, 428)
        Me.mskTxtTotal.Name = "mskTxtTotal"
        Me.mskTxtTotal.Size = New System.Drawing.Size(100, 20)
        Me.mskTxtTotal.TabIndex = 13
        '
        'InicioCajas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(837, 472)
        Me.Controls.Add(Me.mskTxtTotal)
        Me.Controls.Add(Me.gpbDetalles)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.gpbBuscarProducto)
        Me.Name = "InicioCajas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "InicioCajas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.gpbBuscarProducto.ResumeLayout(False)
        Me.gpbBuscarProducto.PerformLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvVentaDetalles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.gpbDetalles.ResumeLayout(False)
        Me.gpbDetalles.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gpbBuscarProducto As GroupBox
    Friend WithEvents txtProducto As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnDom As Button
    Friend WithEvents btnTel As Button
    Friend WithEvents btnLocal As Button
    Friend WithEvents btnParaLlevar As Button
    Friend WithEvents dgvVentaDetalles As DataGridView
    Friend WithEvents txtTipoProd As TextBox
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblPrecio As Label
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtNumProducto As TextBox
    Friend WithEvents txtNombreProducto As TextBox
    Friend WithEvents dgvProductos As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtID As TextBox
    Friend WithEvents btnNuevaVenta As Button
    Friend WithEvents gpbDetalles As GroupBox
    Friend WithEvents mskTxtTotal As MaskedTextBox
    Friend WithEvents btnSalir As Button
End Class
