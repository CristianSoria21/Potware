<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ENTRAR = New System.Windows.Forms.PictureBox()
        Me.SALIR = New System.Windows.Forms.PictureBox()
        CType(Me.ENTRAR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SALIR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ENTRAR
        '
        Me.ENTRAR.BackColor = System.Drawing.Color.Transparent
        Me.ENTRAR.BackgroundImage = Global.Programa__POTWARE.My.Resources.Resources.BotonEntrar
        Me.ENTRAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ENTRAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ENTRAR.Location = New System.Drawing.Point(145, 349)
        Me.ENTRAR.Name = "ENTRAR"
        Me.ENTRAR.Size = New System.Drawing.Size(167, 71)
        Me.ENTRAR.TabIndex = 0
        Me.ENTRAR.TabStop = False
        '
        'SALIR
        '
        Me.SALIR.BackColor = System.Drawing.Color.Transparent
        Me.SALIR.BackgroundImage = Global.Programa__POTWARE.My.Resources.Resources.BotonSalir
        Me.SALIR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.SALIR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SALIR.Location = New System.Drawing.Point(476, 349)
        Me.SALIR.Name = "SALIR"
        Me.SALIR.Size = New System.Drawing.Size(167, 71)
        Me.SALIR.TabIndex = 1
        Me.SALIR.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(784, 494)
        Me.Controls.Add(Me.SALIR)
        Me.Controls.Add(Me.ENTRAR)
        Me.Name = "Form1"
        Me.Text = "Pantalla_Inicio"
        CType(Me.ENTRAR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SALIR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ENTRAR As PictureBox
    Friend WithEvents SALIR As PictureBox
End Class
