﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmArticulos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmArticulos))
        Me.tabspag1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TsbNuevo = New System.Windows.Forms.ToolStripButton()
        Me.TsbGrabar = New System.Windows.Forms.ToolStripButton()
        Me.TsbBorrar = New System.Windows.Forms.ToolStripButton()
        Me.TsbEditar = New System.Windows.Forms.ToolStripButton()
        Me.TsbCancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.TsbPrimero = New System.Windows.Forms.ToolStripButton()
        Me.TsbAnterior = New System.Windows.Forms.ToolStripButton()
        Me.TsbSiguiente = New System.Windows.Forms.ToolStripButton()
        Me.TsbUltimo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.DgvArticulos = New System.Windows.Forms.DataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTipoProd = New System.Windows.Forms.TextBox()
        Me.cmbStatus = New System.Windows.Forms.DateTimePicker()
        Me.cmbUM = New System.Windows.Forms.TextBox()
        Me.NdMaximo = New System.Windows.Forms.NumericUpDown()
        Me.NdMinimo = New System.Windows.Forms.NumericUpDown()
        Me.txtPrecioVenta = New System.Windows.Forms.TextBox()
        Me.txtCantidadExistente = New System.Windows.Forms.TextBox()
        Me.txtCosto = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtIDArticulo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tabspag1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DgvArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NdMaximo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NdMinimo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabspag1
        '
        Me.tabspag1.Controls.Add(Me.TabPage1)
        Me.tabspag1.Controls.Add(Me.TabPage2)
        Me.tabspag1.Location = New System.Drawing.Point(2, 45)
        Me.tabspag1.Name = "tabspag1"
        Me.tabspag1.SelectedIndex = 0
        Me.tabspag1.Size = New System.Drawing.Size(669, 348)
        Me.tabspag1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DgvArticulos)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(661, 322)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Lista"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.txtTipoProd)
        Me.TabPage2.Controls.Add(Me.cmbStatus)
        Me.TabPage2.Controls.Add(Me.cmbUM)
        Me.TabPage2.Controls.Add(Me.NdMaximo)
        Me.TabPage2.Controls.Add(Me.NdMinimo)
        Me.TabPage2.Controls.Add(Me.txtPrecioVenta)
        Me.TabPage2.Controls.Add(Me.txtCantidadExistente)
        Me.TabPage2.Controls.Add(Me.txtCosto)
        Me.TabPage2.Controls.Add(Me.txtNombre)
        Me.TabPage2.Controls.Add(Me.txtIDArticulo)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(661, 322)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Detalles"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TsbNuevo, Me.TsbGrabar, Me.TsbBorrar, Me.TsbEditar, Me.TsbCancelar, Me.ToolStripSeparator1, Me.TsbPrimero, Me.TsbAnterior, Me.TsbSiguiente, Me.TsbUltimo, Me.ToolStripSeparator2, Me.TsbSalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(683, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'TsbNuevo
        '
        Me.TsbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TsbNuevo.Image = CType(resources.GetObject("TsbNuevo.Image"), System.Drawing.Image)
        Me.TsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsbNuevo.Name = "TsbNuevo"
        Me.TsbNuevo.Size = New System.Drawing.Size(23, 22)
        Me.TsbNuevo.Text = "Agregar"
        '
        'TsbGrabar
        '
        Me.TsbGrabar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TsbGrabar.Image = CType(resources.GetObject("TsbGrabar.Image"), System.Drawing.Image)
        Me.TsbGrabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsbGrabar.Name = "TsbGrabar"
        Me.TsbGrabar.Size = New System.Drawing.Size(23, 22)
        Me.TsbGrabar.Text = "Guardar"
        '
        'TsbBorrar
        '
        Me.TsbBorrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TsbBorrar.Image = CType(resources.GetObject("TsbBorrar.Image"), System.Drawing.Image)
        Me.TsbBorrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsbBorrar.Name = "TsbBorrar"
        Me.TsbBorrar.Size = New System.Drawing.Size(23, 22)
        Me.TsbBorrar.Text = "Borrar"
        '
        'TsbEditar
        '
        Me.TsbEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TsbEditar.Image = CType(resources.GetObject("TsbEditar.Image"), System.Drawing.Image)
        Me.TsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsbEditar.Name = "TsbEditar"
        Me.TsbEditar.Size = New System.Drawing.Size(23, 22)
        Me.TsbEditar.Text = "Modificar"
        '
        'TsbCancelar
        '
        Me.TsbCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TsbCancelar.Image = CType(resources.GetObject("TsbCancelar.Image"), System.Drawing.Image)
        Me.TsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsbCancelar.Name = "TsbCancelar"
        Me.TsbCancelar.Size = New System.Drawing.Size(23, 22)
        Me.TsbCancelar.Text = "Cancelar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'TsbPrimero
        '
        Me.TsbPrimero.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TsbPrimero.Image = CType(resources.GetObject("TsbPrimero.Image"), System.Drawing.Image)
        Me.TsbPrimero.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsbPrimero.Name = "TsbPrimero"
        Me.TsbPrimero.Size = New System.Drawing.Size(23, 22)
        Me.TsbPrimero.Text = "Inicio"
        '
        'TsbAnterior
        '
        Me.TsbAnterior.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TsbAnterior.Image = CType(resources.GetObject("TsbAnterior.Image"), System.Drawing.Image)
        Me.TsbAnterior.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsbAnterior.Name = "TsbAnterior"
        Me.TsbAnterior.Size = New System.Drawing.Size(23, 22)
        Me.TsbAnterior.Text = "Atrasar"
        '
        'TsbSiguiente
        '
        Me.TsbSiguiente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TsbSiguiente.Image = CType(resources.GetObject("TsbSiguiente.Image"), System.Drawing.Image)
        Me.TsbSiguiente.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsbSiguiente.Name = "TsbSiguiente"
        Me.TsbSiguiente.Size = New System.Drawing.Size(23, 22)
        Me.TsbSiguiente.Text = "Adelantar"
        '
        'TsbUltimo
        '
        Me.TsbUltimo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TsbUltimo.Image = CType(resources.GetObject("TsbUltimo.Image"), System.Drawing.Image)
        Me.TsbUltimo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsbUltimo.Name = "TsbUltimo"
        Me.TsbUltimo.Size = New System.Drawing.Size(23, 22)
        Me.TsbUltimo.Text = "Final"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'TsbSalir
        '
        Me.TsbSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TsbSalir.Image = CType(resources.GetObject("TsbSalir.Image"), System.Drawing.Image)
        Me.TsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsbSalir.Name = "TsbSalir"
        Me.TsbSalir.Size = New System.Drawing.Size(23, 22)
        Me.TsbSalir.Text = "Cerrar"
        '
        'DgvArticulos
        '
        Me.DgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvArticulos.Location = New System.Drawing.Point(0, 6)
        Me.DgvArticulos.Name = "DgvArticulos"
        Me.DgvArticulos.Size = New System.Drawing.Size(658, 313)
        Me.DgvArticulos.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(19, 276)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(106, 16)
        Me.Label10.TabIndex = 43
        Me.Label10.Text = "Tipo Producto"
        '
        'txtTipoProd
        '
        Me.txtTipoProd.Location = New System.Drawing.Point(168, 277)
        Me.txtTipoProd.Name = "txtTipoProd"
        Me.txtTipoProd.Size = New System.Drawing.Size(100, 20)
        Me.txtTipoProd.TabIndex = 42
        '
        'cmbStatus
        '
        Me.cmbStatus.Location = New System.Drawing.Point(168, 194)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(200, 20)
        Me.cmbStatus.TabIndex = 41
        '
        'cmbUM
        '
        Me.cmbUM.Location = New System.Drawing.Point(168, 85)
        Me.cmbUM.Name = "cmbUM"
        Me.cmbUM.Size = New System.Drawing.Size(100, 20)
        Me.cmbUM.TabIndex = 40
        '
        'NdMaximo
        '
        Me.NdMaximo.Location = New System.Drawing.Point(168, 141)
        Me.NdMaximo.Name = "NdMaximo"
        Me.NdMaximo.Size = New System.Drawing.Size(120, 20)
        Me.NdMaximo.TabIndex = 39
        '
        'NdMinimo
        '
        Me.NdMinimo.Location = New System.Drawing.Point(168, 115)
        Me.NdMinimo.Name = "NdMinimo"
        Me.NdMinimo.Size = New System.Drawing.Size(107, 20)
        Me.NdMinimo.TabIndex = 38
        '
        'txtPrecioVenta
        '
        Me.txtPrecioVenta.Location = New System.Drawing.Point(168, 251)
        Me.txtPrecioVenta.Name = "txtPrecioVenta"
        Me.txtPrecioVenta.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecioVenta.TabIndex = 37
        '
        'txtCantidadExistente
        '
        Me.txtCantidadExistente.Location = New System.Drawing.Point(168, 218)
        Me.txtCantidadExistente.Name = "txtCantidadExistente"
        Me.txtCantidadExistente.Size = New System.Drawing.Size(100, 20)
        Me.txtCantidadExistente.TabIndex = 36
        '
        'txtCosto
        '
        Me.txtCosto.Location = New System.Drawing.Point(168, 168)
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.Size = New System.Drawing.Size(100, 20)
        Me.txtCosto.TabIndex = 35
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(168, 59)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(473, 20)
        Me.txtNombre.TabIndex = 34
        '
        'txtIDArticulo
        '
        Me.txtIDArticulo.Location = New System.Drawing.Point(168, 26)
        Me.txtIDArticulo.Name = "txtIDArticulo"
        Me.txtIDArticulo.Size = New System.Drawing.Size(100, 20)
        Me.txtIDArticulo.TabIndex = 33
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(19, 251)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(101, 16)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Precio Venta:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(19, 223)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(141, 16)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Cantidad Existente:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(19, 200)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 16)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Vigencia:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(19, 173)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 16)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Costo:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 16)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Maximo:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 16)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Minimo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 16)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Unidad De Medida:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 16)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 16)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "ID Articulo:"
        '
        'frmArticulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(683, 405)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.tabspag1)
        Me.Name = "frmArticulos"
        Me.Text = "frmArticulos"
        Me.tabspag1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DgvArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NdMaximo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NdMinimo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tabspag1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents TsbNuevo As ToolStripButton
    Friend WithEvents TsbGrabar As ToolStripButton
    Friend WithEvents TsbBorrar As ToolStripButton
    Friend WithEvents TsbEditar As ToolStripButton
    Friend WithEvents TsbCancelar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents TsbPrimero As ToolStripButton
    Friend WithEvents TsbAnterior As ToolStripButton
    Friend WithEvents TsbSiguiente As ToolStripButton
    Friend WithEvents TsbUltimo As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents TsbSalir As ToolStripButton
    Friend WithEvents DgvArticulos As DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents txtTipoProd As TextBox
    Friend WithEvents cmbStatus As DateTimePicker
    Friend WithEvents cmbUM As TextBox
    Friend WithEvents NdMaximo As NumericUpDown
    Friend WithEvents NdMinimo As NumericUpDown
    Friend WithEvents txtPrecioVenta As TextBox
    Friend WithEvents txtCantidadExistente As TextBox
    Friend WithEvents txtCosto As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtIDArticulo As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
