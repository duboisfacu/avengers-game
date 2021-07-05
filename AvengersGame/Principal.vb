Public Class AvengersGame
    Dim nombres() As String = {"Capitan America", "Ironman", "Thanos", "Vision", "Capitana Marvel", "Spiderman", "Ancestral", "Ant-Man", "Black Panther", "Bucky", "Black Widow", "Doctor Strange", "Drax", "Ego", "Falcon", "Gamora", "Baby Groot", "Hawkeye", "Hela", "Howard El Pato", "Hulk", "Loki", "Mantis", "Nebula", "Odin", "Okoye", "Quicksilver", "Red Skull", "Rescue", "Rocket", "Stan Lee", "Starlord", "Surtur", "Scarlet Witch", "Thor", "Ultron", "Valkyrie", "War Machine", "Wasp", "Yondu"}
    Dim imagenes() As String = {"..\\..\Resources\img_capi.jpg", "..\\..\Resources\img_ironman.jpg", "..\\..\Resources\img_thanos.jpg", "..\\..\Resources\img_vision.jpg", "..\\..\Resources\img_carol.jpg", "..\\..\Resources\img_spiderman.jpg", "..\\..\Resources\img_ancestral.jpg", "..\\..\Resources\img_antman.jpg", "..\\..\Resources\img_blackpanther.jpg", "..\\..\Resources\img_bucky.jpg", "..\\..\Resources\img_bw.jpg", "..\\..\Resources\img_dr.jpg", "..\\..\Resources\img_drax.jpg", "..\\..\Resources\img_ego.jpg", "..\\..\Resources\img_falcon.jpg", "..\\..\Resources\img_gamora.jpg", "..\\..\Resources\img_groot.jpg", "..\\..\Resources\img_hawkeye.jpg", "..\\..\Resources\img_hela.jpg", "..\\..\Resources\img_howard.jpg", "..\\..\Resources\img_hulk.jpg", "..\\..\Resources\img_loki.jpg", "..\\..\Resources\img_mantis.jpg", "..\\..\Resources\img_nebula.jpg", "..\\..\Resources\img_odin.jpg", "..\\..\Resources\img_okoye.jpg", "..\\..\Resources\img_rayo.jpg", "..\\..\Resources\img_redskull.jpg", "..\\..\Resources\img_rescue.jpg", "..\\..\Resources\img_rocket.jpg", "..\\..\Resources\img_stanlee.jpg", "..\\..\Resources\img_starlord.jpg", "..\\..\Resources\img_surtur.jpg", "..\\..\Resources\img_sw.jpg", "..\\..\Resources\img_thor.jpg", "..\\..\Resources\img_ultron.jpg", "..\\..\Resources\img_valkyrie.jpg", "..\\..\Resources\img_war.jpg", "..\\..\Resources\img_wasp.jpg", "..\\..\Resources\img_yondu.jpg"}
    Dim fuerzas() As Integer = {70, 60, 90, 70, 100, 40, 100, 60, 60, 70, 50, 70, 60, 100, 60, 60, 50, 60, 100, 30, 80, 50, 30, 60, 100, 60, 50, 50, 60, 60, 100, 50, 100, 100, 90, 80, 60, 60, 60, 80}
    Dim inteligencias() As Integer = {60, 100, 90, 80, 80, 70, 100, 70, 60, 50, 60, 80, 10, 100, 50, 70, 10, 70, 70, 70, 20, 60, 60, 70, 100, 60, 60, 60, 60, 90, 100, 40, 70, 60, 40, 100, 60, 50, 80, 50}
    Dim resistencias() As Integer = {80, 60, 80, 40, 80, 30, 80, 50, 100, 80, 60, 50, 80, 100, 40, 50, 80, 30, 70, 30, 80, 50, 20, 40, 80, 40, 20, 60, 60, 50, 100, 50, 100, 50, 80, 90, 60, 60, 50, 40}
    Dim destrezas() As Integer = {80, 80, 70, 70, 70, 100, 80, 80, 90, 80, 100, 50, 60, 70, 80, 90, 50, 90, 80, 40, 70, 80, 30, 60, 50, 60, 100, 50, 80, 90, 100, 70, 70, 50, 60, 60, 70, 70, 90, 70}
    Dim mazo As New List(Of Cartas)
    Dim mazoCompu As New List(Of Cartas)
    Dim mazoJugador As New List(Of Cartas)
    Dim cartaElegidaCompu As Cartas
    Dim puntajeCompu, puntajeJugador As Integer

    Private Sub Principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For i As Integer = 0 To nombres.Length - 1
            Dim cartaCompu As New Cartas
            cartaCompu.nombre = nombres(i)
            cartaCompu.imagen = imagenes(i)
            cartaCompu.fuerza = fuerzas(i)
            cartaCompu.inteligencia = inteligencias(i)
            cartaCompu.resistencia = resistencias(i)
            cartaCompu.destreza = destrezas(i)
            mazo.Add(cartaCompu)
        Next

        'gif de deadpool
        PictureBox3.Image = Image.FromFile("..\\..\Resources\deadpool.gif")
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage

    End Sub

    Private Sub btnNueva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNueva.Click
        My.Computer.Audio.Play(My.Resources.snd_new, AudioPlayMode.WaitToComplete)
        btnJugar.Enabled = False
        Dim mazoCompleto As New List(Of Cartas)
        Dim CantCartasMazoCompleto As Integer = 0

        Do While CantCartasMazoCompleto < nombres.Length
            Dim encontrada As Boolean = False
            Randomize()
            Dim idCartaAlAzar As Integer = Int(Rnd() * nombres.Length)
            Dim cartaAlAzar As New Cartas
            cartaAlAzar = mazo(idCartaAlAzar)
            For Each carta As Cartas In mazoCompleto
                If mazo(idCartaAlAzar).nombre = carta.nombre Then
                    encontrada = True
                End If
            Next
            If encontrada = False Then
                mazoCompleto.Add(cartaAlAzar)
                CantCartasMazoCompleto += 1
            End If
        Loop

        mazoCompu.Clear()
        For i As Integer = 0 To (nombres.Length / 2) - 1
            mazoCompu.Add(mazoCompleto(i))
        Next

        cartaElegidaCompu = mazoCompu(0)
        txtCartaElegida.Text = cartaElegidaCompu.nombre
        piccartapc.ImageLocation = mazoCompu(0).imagen
        piccartapc.SizeMode = PictureBoxSizeMode.StretchImage


        mazoJugador.Clear()
        cmbCartaElegida.Items.Clear()
        For i As Integer = nombres.Length / 2 To nombres.Length - 1
            mazoJugador.Add(mazoCompleto(i))
            cmbCartaElegida.Items.Add(mazoCompleto(i).nombre)
        Next

        puntajeCompu = 0
        puntajeJugador = 0
        lblpuntpc.Text = puntajeCompu
        lblpuntjugador.Text = puntajeJugador
        piccartajugador.Image = Image.FromFile("..\\..\Resources\img_0.jpg")
    End Sub

    Private Sub btnJugar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJugar.Click

        piccartajugador.Image = Image.FromFile("..\\..\Resources\img_0.jpg")
        My.Computer.Audio.Play(My.Resources.snd_jugar, AudioPlayMode.WaitToComplete)

        Dim f1, f2, r1, r2, i1, i2, d1, d2, a1, b1, a2, b2, s1, s2 As Integer
        f1 = mazoCompu(0).fuerza
        i1 = mazoCompu(0).inteligencia
        r1 = mazoCompu(0).resistencia
        d1 = mazoCompu(0).destreza

        f2 = mazoJugador(cmbCartaElegida.SelectedIndex).fuerza
        i2 = mazoJugador(cmbCartaElegida.SelectedIndex).inteligencia
        r2 = mazoJugador(cmbCartaElegida.SelectedIndex).resistencia
        d2 = mazoJugador(cmbCartaElegida.SelectedIndex).destreza

        a1 = f1 - r2 / (100 + r2) * f1
        b1 = i1 - d2 / (100 + d2) * i1

        a2 = f2 - r1 / (100 + r1) * f2
        b2 = i2 - d1 / (100 + d1) * i2

        s1 = a1 + b1
        s2 = a2 + b2


        If s1 > s2 Then
            puntajeCompu += 1
            My.Computer.Audio.Play(My.Resources.snd_lose, AudioPlayMode.WaitToComplete)

        Else
            puntajeJugador += 1
            My.Computer.Audio.Play(My.Resources.snd_win, AudioPlayMode.WaitToComplete)

        End If

        lblpuntpc.Text = puntajeCompu
        lblpuntjugador.Text = puntajeJugador
        mazoCompu.Remove(mazoCompu(0))

        If mazoCompu.Count > 0 Then
            txtCartaElegida.Text = mazoCompu(0).nombre
            piccartapc.ImageLocation = mazoCompu(0).imagen
            cmbCartaElegida.Focus()
        End If

        If mazoCompu.Count = 0 Then
            If puntajeCompu = puntajeJugador Then
                MsgBox("        Empate!")
            Else
                If puntajeCompu > puntajeJugador Then
                    MsgBox("        Perdiste!")
                Else
                    MsgBox("        Ganaste!")
                End If
            End If
            btnNueva.PerformClick()
        Else
            cartaElegidaCompu = mazoCompu(0)
            mazoJugador.Remove(mazoJugador(cmbCartaElegida.SelectedIndex))
            cmbCartaElegida.Items.RemoveAt(cmbCartaElegida.SelectedIndex)
        End If

        btnJugar.Enabled = False

    End Sub

    Private Sub cmbCartaElegida_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCartaElegida.SelectedIndexChanged

        My.Computer.Audio.Play(My.Resources.snd_selectdeck, AudioPlayMode.WaitToComplete)
        piccartajugador.ImageLocation = mazoJugador(cmbCartaElegida.SelectedIndex).imagen

        If cmbCartaElegida.SelectedIndex.Equals(-1) Then
            btnJugar.Enabled = False
        Else
            btnJugar.Enabled = True
        End If
    End Sub

End Class
