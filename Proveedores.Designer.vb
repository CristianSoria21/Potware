<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Proveedores
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
        Me.Salir = New System.Windows.Forms.PictureBox()
        Me.Modificar = New System.Windows.Forms.PictureBox()
        Me.Eliminar = New System.Windows.Forms.PictureBox()
        Me.Insertar = New System.Windows.Forms.PictureBox()
        Me.Consultar = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Direccion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Ciudad = New System.Windows.Forms.TextBox()
        Me.Tel = New System.Windows.Forms.TextBox()
        Me.Encargado = New System.Windows.Forms.TextBox()
        Me.RazonSocial = New System.Windows.Forms.TextBox()
        Me.ID_Proveedores = New System.Windows.Forms.ComboBox()
        CType(Me.Salir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Modificar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Eliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Insertar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Consultar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Salir
        '
        Me.Salir.BackColor = System.Drawing.Color.Transparent
        Me.Salir.BackgroundImage = Global.Programa__POTWARE.My.Resources.Resources.Salir_V
        Me.Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Salir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Salir.Location = New System.Drawing.Point(180, 341)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(119, 63)
        Me.Salir.TabIndex = 7
        Me.Salir.TabStop = False
        '
        'Modificar
        '
        Me.Modificar.BackColor = System.Drawing.Color.Transparent
        Me.Modificar.BackgroundImage = Global.Programa__POTWARE.My.Resources.Resources.modificar_V
        Me.Modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Modificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Modificar.Location = New System.Drawing.Point(28, 422)
        Me.Modificar.Name = "Modificar"
        Me.Modificar.Size = New System.Drawing.Size(119, 60)
        Me.Modificar.TabIndex = 6
        Me.Modificar.TabStop = False
        '
        'Eliminar
        '
        Me.Eliminar.BackColor = System.Drawing.Color.Transparent
        Me.Eliminar.BackgroundImage = Global.Programa__POTWARE.My.Resources.Resources.eliminar_V
        Me.Eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Eliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Eliminar.Location = New System.Drawing.Point(28, 344)
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(119, 60)
        Me.Eliminar.TabIndex = 5
        Me.Eliminar.TabStop = False
        '
        'Insertar
        '
        Me.Insertar.BackColor = System.Drawing.Color.Transparent
        Me.Insertar.BackgroundImage = Global.Programa__POTWARE.My.Resources.Resources.insertar_V
        Me.Insertar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Insertar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Insertar.Location = New System.Drawing.Point(28, 260)
        Me.Insertar.Name = "Insertar"
        Me.Insertar.Size = New System.Drawing.Size(119, 63)
        Me.Insertar.TabIndex = 4
        Me.Insertar.TabStop = False
        '
        'Consultar
        '
        Me.Consultar.BackColor = System.Drawing.Color.Transparent
        Me.Consultar.BackgroundImage = Global.Programa__POTWARE.My.Resources.Resources.consultar_V
        Me.Consultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Consultar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Consultar.Location = New System.Drawing.Point(180, 260)
        Me.Consultar.Name = "Consultar"
        Me.Consultar.Size = New System.Drawing.Size(119, 63)
        Me.Consultar.TabIndex = 11
        Me.Consultar.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(58, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(5)
        Me.Label3.Size = New System.Drawing.Size(170, 28)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "ID PROVEEDORES:"
        '
        'Direccion
        '
        Me.Direccion.BackColor = System.Drawing.Color.White
        Me.Direccion.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Direccion.Location = New System.Drawing.Point(220, 117)
        Me.Direccion.Name = "Direccion"
        Me.Direccion.Size = New System.Drawing.Size(161, 29)
        Me.Direccion.TabIndex = 15
        Me.Direccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(75, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(5)
        Me.Label1.Size = New System.Drawing.Size(116, 28)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "DIRECCION:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(75, 193)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(5)
        Me.Label2.Size = New System.Drawing.Size(88, 28)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "CIUDAD:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(406, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Padding = New System.Windows.Forms.Padding(5)
        Me.Label4.Size = New System.Drawing.Size(130, 28)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "ENCARGADO:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(406, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Padding = New System.Windows.Forms.Padding(5)
        Me.Label5.Size = New System.Drawing.Size(90, 28)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "TEL/FAX:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(406, 193)
        Me.Label6.Name = "Label6"
        Me.Label6.Padding = New System.Windows.Forms.Padding(5)
        Me.Label6.Size = New System.Drawing.Size(147, 28)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "RAZON SOCIAL:"
        '
        'Ciudad
        '
        Me.Ciudad.BackColor = System.Drawing.Color.White
        Me.Ciudad.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ciudad.Location = New System.Drawing.Point(196, 192)
        Me.Ciudad.Name = "Ciudad"
        Me.Ciudad.Size = New System.Drawing.Size(185, 29)
        Me.Ciudad.TabIndex = 20
        Me.Ciudad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Tel
        '
        Me.Tel.BackColor = System.Drawing.Color.White
        Me.Tel.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tel.Location = New System.Drawing.Point(537, 40)
        Me.Tel.Name = "Tel"
        Me.Tel.Size = New System.Drawing.Size(181, 29)
        Me.Tel.TabIndex = 21
        Me.Tel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Encargado
        '
        Me.Encargado.BackColor = System.Drawing.Color.White
        Me.Encargado.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Encargado.Location = New System.Drawing.Point(557, 117)
        Me.Encargado.Name = "Encargado"
        Me.Encargado.Size = New System.Drawing.Size(161, 29)
        Me.Encargado.TabIndex = 22
        Me.Encargado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RazonSocial
        '
        Me.RazonSocial.BackColor = System.Drawing.Color.White
        Me.RazonSocial.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RazonSocial.Location = New System.Drawing.Point(571, 193)
        Me.RazonSocial.Name = "RazonSocial"
        Me.RazonSocial.Size = New System.Drawing.Size(147, 29)
        Me.RazonSocial.TabIndex = 23
        Me.RazonSocial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ID_Proveedores
        '
        Me.ID_Proveedores.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ID_Proveedores.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID_Proveedores.FormattingEnabled = True
        Me.ID_Proveedores.Location = New System.Drawing.Point(253, 42)
        Me.ID_Proveedores.Name = "ID_Proveedores"
        Me.ID_Proveedores.Size = New System.Drawing.Size(128, 30)
        Me.ID_Proveedores.TabIndex = 51
        '
        'Proveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Programa__POTWARE.My.Resources.Resources.Proveedores
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(784, 494)
        Me.Controls.Add(Me.ID_Proveedores)
        Me.Controls.Add(Me.RazonSocial)
        Me.Controls.Add(Me.Encargado)
        Me.Controls.Add(Me.Tel)
        Me.Controls.Add(Me.Ciudad)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Direccion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Consultar)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.Modificar)
        Me.Controls.Add(Me.Eliminar)
        Me.Controls.Add(Me.Insertar)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Name = "Proveedores"
        Me.Text = "Proveedores"
        CType(Me.Salir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Modificar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Eliminar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Insertar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Consultar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Salir As PictureBox
    Friend WithEvents Modificar As PictureBox
    Friend WithEvents Eliminar As PictureBox
    Friend WithEvents Insertar As PictureBox
    Friend WithEvents Consultar As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Direccion As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Ciudad As TextBox
    Friend WithEvents Tel As TextBox
    Friend WithEvents Encargado As TextBox
    Friend WithEvents RazonSocial As TextBox
    Friend WithEvents ID_Proveedores As ComboBox
End Class
