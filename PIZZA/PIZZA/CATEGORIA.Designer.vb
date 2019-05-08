<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CATEGORIA
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
        Me.txtaccesoCategoria = New System.Windows.Forms.TextBox()
        Me.btnAccesoMa = New System.Windows.Forms.Button()
        Me.btnSalirCat = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtaccesoCategoria
        '
        Me.txtaccesoCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaccesoCategoria.Location = New System.Drawing.Point(88, 56)
        Me.txtaccesoCategoria.Multiline = True
        Me.txtaccesoCategoria.Name = "txtaccesoCategoria"
        Me.txtaccesoCategoria.Size = New System.Drawing.Size(182, 41)
        Me.txtaccesoCategoria.TabIndex = 0
        Me.txtaccesoCategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnAccesoMa
        '
        Me.btnAccesoMa.Location = New System.Drawing.Point(112, 124)
        Me.btnAccesoMa.Name = "btnAccesoMa"
        Me.btnAccesoMa.Size = New System.Drawing.Size(126, 43)
        Me.btnAccesoMa.TabIndex = 1
        Me.btnAccesoMa.Text = "Acceso Manual"
        Me.btnAccesoMa.UseVisualStyleBackColor = True
        '
        'btnSalirCat
        '
        Me.btnSalirCat.Location = New System.Drawing.Point(278, 154)
        Me.btnSalirCat.Name = "btnSalirCat"
        Me.btnSalirCat.Size = New System.Drawing.Size(75, 23)
        Me.btnSalirCat.TabIndex = 2
        Me.btnSalirCat.Text = "&Salir"
        Me.btnSalirCat.UseVisualStyleBackColor = True
        '
        'CATEGORIA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(365, 189)
        Me.Controls.Add(Me.btnSalirCat)
        Me.Controls.Add(Me.btnAccesoMa)
        Me.Controls.Add(Me.txtaccesoCategoria)
        Me.Name = "CATEGORIA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CATEGORIA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtaccesoCategoria As TextBox
    Friend WithEvents btnAccesoMa As Button
    Friend WithEvents btnSalirCat As Button
End Class
