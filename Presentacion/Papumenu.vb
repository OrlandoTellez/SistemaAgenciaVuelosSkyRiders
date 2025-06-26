Imports System.Windows.Forms
Imports Dominio

Public Class Papumenu
    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewToolStripMenuItem.Click
        Dim reservas As frmReservarVuelos = New frmReservarVuelos()
        reservas.ShowDialog()
    End Sub



    Private Sub ReservarVehiculoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReservarVehiculoToolStripMenuItem.Click
        Dim reservarAuto As New frmReservarVehiculo()
        reservarAuto.ShowDialog()
    End Sub

    Private Sub RToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RToolStripMenuItem.Click
        Dim reservarHotel As New frmReservarHotel()
        reservarHotel.ShowDialog()
    End Sub

    Private Sub VerPerfilToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim perfilCliente As New PerfilDelCliente()
        perfilCliente.Show()
    End Sub


    Private Sub MisReservasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MisReservasToolStripMenuItem.Click
        Dim verReservas As New VerReservas()
        verReservas.Show()
    End Sub

    Private Sub VerPerfilToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles VerPerfilToolStripMenuItem.Click
        Dim perfil As New PerfilDelCliente()

        perfil.Show()
    End Sub

    Private Sub btnOferta1_Click_1(sender As Object, e As EventArgs) Handles btnOferta1.Click
        Dim cantidadPasajeros As New EscogerCantidadPasajeros()

        VariablesPublicas.fechaReserva = Date.Today

        VariablesPublicas.Origen = "Nicaragua"
        VariablesPublicas.Destino = "Costa Rica"
        VariablesPublicas.Clase = "Economico"
        VariablesPublicas.FechaSalida = New Date(2024, 12, 11)
        VariablesPublicas.FechaLlegada = New Date(2024, 12, 12)
        VariablesPublicas.HoraSalida = New TimeSpan(2, 0, 0)
        VariablesPublicas.horaLlegada = New TimeSpan(6, 0, 0)
        VariablesPublicas.Precio = 100

        cantidadPasajeros.Show()
    End Sub

    Private Sub btnOferta2_Click_1(sender As Object, e As EventArgs) Handles btnOferta2.Click
        Dim cantidadPasajeros As New EscogerCantidadPasajeros()

        VariablesPublicas.fechaReserva = Date.Today

        VariablesPublicas.Origen = "Nicaragua"
        VariablesPublicas.Destino = "Bogota"
        VariablesPublicas.Clase = "Economico"
        VariablesPublicas.FechaSalida = New Date(2025, 1, 23)
        VariablesPublicas.FechaLlegada = New Date(2025, 1, 24)
        VariablesPublicas.HoraSalida = New TimeSpan(2, 0, 0)
        VariablesPublicas.horaLlegada = New TimeSpan(6, 0, 0)
        VariablesPublicas.Precio = 250

        cantidadPasajeros.Show()
    End Sub

    Private Sub btnOferta3_Click_1(sender As Object, e As EventArgs) Handles btnOferta3.Click
        Dim cantidadPasajeros As New EscogerCantidadPasajeros()

        VariablesPublicas.fechaReserva = Date.Today

        VariablesPublicas.Origen = "Costa Rica"
        VariablesPublicas.Destino = "Buenos aires"
        VariablesPublicas.Clase = "Economico"
        VariablesPublicas.FechaSalida = New Date(2025, 1, 20)
        VariablesPublicas.FechaLlegada = New Date(2025, 1, 21)
        VariablesPublicas.HoraSalida = New TimeSpan(2, 0, 0)
        VariablesPublicas.horaLlegada = New TimeSpan(6, 0, 0)
        VariablesPublicas.Precio = 300

        cantidadPasajeros.Show()
    End Sub
    ''''''''''''''''''''''''''CODIGO DEL MDI''''''''''''''''''''''''''''''''''''''
    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: agregue código aquí para abrir el archivo.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: agregue código aquí para guardar el contenido actual del formulario en un archivo.
        End If
    End Sub

    Private Sub Papumenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panelCentro.Left = (Me.ClientSize.Width - panelCentro.Width) \ 2
        panelCentro.Top = (Me.ClientSize.Height - panelCentro.Height) \ 2
    End Sub


End Class
