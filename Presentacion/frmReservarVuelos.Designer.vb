<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReservarVuelos
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.nupPasajeros = New System.Windows.Forms.NumericUpDown()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbClase = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbDestino = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbOrigen = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.nupPasajeros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(984, 464)
        Me.Panel1.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Panel2.Controls.Add(Me.nupPasajeros)
        Me.Panel2.Controls.Add(Me.dtpFecha)
        Me.Panel2.Controls.Add(Me.btnBuscar)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.cbClase)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.cbDestino)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.cbOrigen)
        Me.Panel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(38, 95)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(921, 336)
        Me.Panel2.TabIndex = 8
        '
        'nupPasajeros
        '
        Me.nupPasajeros.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.nupPasajeros.Location = New System.Drawing.Point(509, 156)
        Me.nupPasajeros.Name = "nupPasajeros"
        Me.nupPasajeros.Size = New System.Drawing.Size(327, 27)
        Me.nupPasajeros.TabIndex = 9
        '
        'dtpFecha
        '
        Me.dtpFecha.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.dtpFecha.Location = New System.Drawing.Point(65, 156)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(382, 27)
        Me.dtpFecha.TabIndex = 19
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBuscar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.Location = New System.Drawing.Point(687, 235)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(149, 45)
        Me.btnBuscar.TabIndex = 18
        Me.btnBuscar.Text = "Buscar Vuelos"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(60, 201)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 30)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Clase"
        '
        'cbClase
        '
        Me.cbClase.BackColor = System.Drawing.Color.White
        Me.cbClase.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbClase.FormattingEnabled = True
        Me.cbClase.Items.AddRange(New Object() {"Economica", "Ejecutiva", "Primera Clase"})
        Me.cbClase.Location = New System.Drawing.Point(65, 245)
        Me.cbClase.Name = "cbClase"
        Me.cbClase.Size = New System.Drawing.Size(382, 28)
        Me.cbClase.TabIndex = 16
        Me.cbClase.Text = "Seleccione"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(504, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 30)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Pasajeros"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(60, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 30)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Fecha Salida"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(504, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 30)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Destino"
        '
        'cbDestino
        '
        Me.cbDestino.BackColor = System.Drawing.Color.White
        Me.cbDestino.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDestino.FormattingEnabled = True
        Me.cbDestino.Items.AddRange(New Object() {"Bogotá", "Chile", "São Paulo", "Costa Rica", "Madrid", "París", "Londres", "Roma", "Berlín", "México ", "Lima  ", "Buenos Aires", "Panamá ", "Nicaragua", "Brasil", "Ecuador"})
        Me.cbDestino.Location = New System.Drawing.Point(509, 66)
        Me.cbDestino.Name = "cbDestino"
        Me.cbDestino.Size = New System.Drawing.Size(327, 28)
        Me.cbDestino.TabIndex = 10
        Me.cbDestino.Text = "Seleccione"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(60, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 30)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Origen"
        '
        'cbOrigen
        '
        Me.cbOrigen.BackColor = System.Drawing.Color.White
        Me.cbOrigen.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbOrigen.FormattingEnabled = True
        Me.cbOrigen.Items.AddRange(New Object() {"México ", "Lima  ", "Buenos Aires", "Panamá ", "Nicaragua", "Brasil", "Ecuador", "Bogotá", "Chile", "São Paulo", "Costa Rica", "Madrid", "París", "Londres", "Roma", "Berlín"})
        Me.cbOrigen.Location = New System.Drawing.Point(65, 66)
        Me.cbOrigen.Name = "cbOrigen"
        Me.cbOrigen.Size = New System.Drawing.Size(382, 28)
        Me.cbOrigen.TabIndex = 7
        Me.cbOrigen.Text = "Seleccione"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(30, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(279, 45)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Reserva de vuelos"
        '
        'frmReservarVuelos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1008, 500)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmReservarVuelos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmReservarVuelos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.nupPasajeros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cbOrigen As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cbClase As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cbDestino As ComboBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents nupPasajeros As NumericUpDown
End Class
