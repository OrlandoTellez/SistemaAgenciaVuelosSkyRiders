<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PasarelaDePago
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PasarelaDePago))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnComprar = New System.Windows.Forms.Button()
        Me.txtCvv = New System.Windows.Forms.TextBox()
        Me.txtNombreTitular = New System.Windows.Forms.TextBox()
        Me.txtFechaEx = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNumeroTarjeta = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblPasajeros = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblDestino = New System.Windows.Forms.Label()
        Me.lblOrigen = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(295, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 45)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Pago Seguro"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(220, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(346, 25)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Completa tu compra de manera segura"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btnComprar)
        Me.Panel1.Controls.Add(Me.txtCvv)
        Me.Panel1.Controls.Add(Me.txtNombreTitular)
        Me.Panel1.Controls.Add(Me.txtFechaEx)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtNumeroTarjeta)
        Me.Panel1.Location = New System.Drawing.Point(32, 164)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(377, 286)
        Me.Panel1.TabIndex = 18
        '
        'btnComprar
        '
        Me.btnComprar.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnComprar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComprar.ForeColor = System.Drawing.Color.White
        Me.btnComprar.Location = New System.Drawing.Point(104, 225)
        Me.btnComprar.Name = "btnComprar"
        Me.btnComprar.Size = New System.Drawing.Size(161, 45)
        Me.btnComprar.TabIndex = 30
        Me.btnComprar.Text = "Comprar ahora"
        Me.btnComprar.UseVisualStyleBackColor = False
        '
        'txtCvv
        '
        Me.txtCvv.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.txtCvv.Location = New System.Drawing.Point(256, 190)
        Me.txtCvv.Name = "txtCvv"
        Me.txtCvv.Size = New System.Drawing.Size(93, 27)
        Me.txtCvv.TabIndex = 26
        '
        'txtNombreTitular
        '
        Me.txtNombreTitular.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.txtNombreTitular.Location = New System.Drawing.Point(26, 51)
        Me.txtNombreTitular.Name = "txtNombreTitular"
        Me.txtNombreTitular.Size = New System.Drawing.Size(323, 27)
        Me.txtNombreTitular.TabIndex = 20
        '
        'txtFechaEx
        '
        Me.txtFechaEx.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.txtFechaEx.Location = New System.Drawing.Point(26, 190)
        Me.txtFechaEx.Name = "txtFechaEx"
        Me.txtFechaEx.Size = New System.Drawing.Size(165, 27)
        Me.txtFechaEx.TabIndex = 25
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(21, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(278, 25)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Nombre del titular de la tarjeta"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(251, 162)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 25)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "CVV"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(21, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(170, 25)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Número de tarjeta"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(21, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(182, 25)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Fecha de expiracion"
        '
        'txtNumeroTarjeta
        '
        Me.txtNumeroTarjeta.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.txtNumeroTarjeta.Location = New System.Drawing.Point(26, 116)
        Me.txtNumeroTarjeta.Name = "txtNumeroTarjeta"
        Me.txtNumeroTarjeta.Size = New System.Drawing.Size(323, 27)
        Me.txtNumeroTarjeta.TabIndex = 22
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(358, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(73, 58)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(439, 187)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(185, 25)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Resumen del pedido"
        '
        'lblPasajeros
        '
        Me.lblPasajeros.AutoSize = True
        Me.lblPasajeros.Font = New System.Drawing.Font("Segoe UI", 10.75!, System.Drawing.FontStyle.Bold)
        Me.lblPasajeros.Location = New System.Drawing.Point(543, 312)
        Me.lblPasajeros.Name = "lblPasajeros"
        Me.lblPasajeros.Size = New System.Drawing.Size(75, 20)
        Me.lblPasajeros.TabIndex = 49
        Me.lblPasajeros.Text = "Pasajeros"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 10.75!, System.Drawing.FontStyle.Bold)
        Me.Label17.Location = New System.Drawing.Point(441, 312)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(79, 20)
        Me.Label17.TabIndex = 48
        Me.Label17.Text = "Pasajeros:"
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Font = New System.Drawing.Font("Segoe UI", 10.75!, System.Drawing.FontStyle.Bold)
        Me.lblPrecio.Location = New System.Drawing.Point(554, 379)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(52, 20)
        Me.lblPrecio.TabIndex = 47
        Me.lblPrecio.Text = "Precio"
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.Font = New System.Drawing.Font("Segoe UI", 10.75!, System.Drawing.FontStyle.Bold)
        Me.lblHora.Location = New System.Drawing.Point(543, 292)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(43, 20)
        Me.lblHora.TabIndex = 46
        Me.lblHora.Text = "Hora"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Segoe UI", 10.75!, System.Drawing.FontStyle.Bold)
        Me.lblFecha.Location = New System.Drawing.Point(543, 272)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(49, 20)
        Me.lblFecha.TabIndex = 45
        Me.lblFecha.Text = "Fecha"
        '
        'lblDestino
        '
        Me.lblDestino.AutoSize = True
        Me.lblDestino.Font = New System.Drawing.Font("Segoe UI", 10.75!, System.Drawing.FontStyle.Bold)
        Me.lblDestino.Location = New System.Drawing.Point(543, 247)
        Me.lblDestino.Name = "lblDestino"
        Me.lblDestino.Size = New System.Drawing.Size(63, 20)
        Me.lblDestino.TabIndex = 44
        Me.lblDestino.Text = "Destino"
        '
        'lblOrigen
        '
        Me.lblOrigen.AutoSize = True
        Me.lblOrigen.Font = New System.Drawing.Font("Segoe UI", 10.75!, System.Drawing.FontStyle.Bold)
        Me.lblOrigen.Location = New System.Drawing.Point(543, 227)
        Me.lblOrigen.Name = "lblOrigen"
        Me.lblOrigen.Size = New System.Drawing.Size(56, 20)
        Me.lblOrigen.TabIndex = 43
        Me.lblOrigen.Text = "Origen"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 10.75!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(441, 292)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 20)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "Hora Salida:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 10.75!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(441, 269)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 20)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "Fecha:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 10.75!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(441, 247)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 20)
        Me.Label11.TabIndex = 39
        Me.Label11.Text = "Destino:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 10.75!, System.Drawing.FontStyle.Bold)
        Me.Label12.Location = New System.Drawing.Point(441, 227)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 20)
        Me.Label12.TabIndex = 38
        Me.Label12.Text = "Origen:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 10.75!, System.Drawing.FontStyle.Bold)
        Me.Label13.Location = New System.Drawing.Point(440, 341)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(291, 20)
        Me.Label13.TabIndex = 50
        Me.Label13.Text = "_______________________________________________"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 10.75!, System.Drawing.FontStyle.Bold)
        Me.Label14.Location = New System.Drawing.Point(437, 379)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(105, 20)
        Me.Label14.TabIndex = 51
        Me.Label14.Text = "Total a pagar:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 10.75!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(540, 379)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(18, 20)
        Me.Label10.TabIndex = 52
        Me.Label10.Text = "$"
        '
        'PasarelaDePago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 471)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lblPasajeros)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.lblPrecio)
        Me.Controls.Add(Me.lblHora)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.lblDestino)
        Me.Controls.Add(Me.lblOrigen)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PasarelaDePago"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtCvv As TextBox
    Friend WithEvents txtNombreTitular As TextBox
    Friend WithEvents txtFechaEx As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNumeroTarjeta As TextBox
    Friend WithEvents btnComprar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lblPasajeros As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents lblPrecio As Label
    Friend WithEvents lblHora As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblDestino As Label
    Friend WithEvents lblOrigen As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label10 As Label
End Class
