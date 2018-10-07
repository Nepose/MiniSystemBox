Public Class FormaGlowna

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        ComboBox4.Text = ""
        ComboBox5.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        Label1.Hide()
        Label2.Hide()
        Label3.Hide()
        TextBox1.Hide()
        TextBox2.Hide()
        TextBox3.Hide()
        EtykietaWynikuDzialania.Text = ""
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        pierwszawiadoma = TextBox5.Text
        drugawiadoma = TextBox4.Text
        If rodzajdzialania = "plus" Then
            wynikzkalkulatora = pierwszawiadoma + drugawiadoma
            WynikDzialania.Text = wynikzkalkulatora
        ElseIf rodzajdzialania = "minus" Then
            wynikzkalkulatora = pierwszawiadoma - drugawiadoma
            WynikDzialania.Text = wynikzkalkulatora
        ElseIf rodzajdzialania = "razy" Then
            wynikzkalkulatora = pierwszawiadoma * drugawiadoma
            WynikDzialania.Text = wynikzkalkulatora
        ElseIf rodzajdzialania = "dzielic" Then
            wynikzkalkulatora = pierwszawiadoma / drugawiadoma
            WynikDzialania.Text = wynikzkalkulatora
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ComboBox7.Text = ""
        rodzajdzialania = ""
        TextBox5.Text = wynikzkalkulatora
        TextBox4.Text = ""
        WynikDzialania.Text = ""
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ComboBox7.Text = ""
        rodzajdzialania = ""
        TextBox4.Text = wynikzkalkulatora
        TextBox5.Text = ""
        WynikDzialania.Text = ""
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        ComboBox7.Text = ""
        rodzajdzialania = ""
        TextBox5.Text = ""
        TextBox4.Text = ""
        WynikDzialania.Text = ""
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        '1 - niewiadoma
        '2 - wiadoma
        '3 - dodać
        '4 - odjąć
        '5 - pomnożyć
        '6 - podzielić
        '7 - równa się
        '8 - wynik

        'pole1 - pierwsza część
        'dzialanie1 - znak między 1 a 2 częścią
        'pole2 - druga część
        'dzialanie2 - znak między 2 a 3 częścią
        wynik = TextBox3.Text
        If pole1 = "2" Then
            If dzialanie1 = "6" Then
                If pole2 = "2" Then
                    wiadomaliczba = TextBox1.Text
                    wiadomaliczba2 = TextBox2.Text
                    niewiadoma2 = wiadomaliczba / wiadomaliczba2
                    Label4.Show()
                    EtykietaWynikuDzialania.Text = niewiadoma2
                End If
                If pole2 = "1" Then
                    wiadomaliczba = TextBox1.Text
                    niewiadoma2 = wiadomaliczba / wynik
                    Label4.Show()
                    EtykietaWynikuDzialania.Text = niewiadoma2
                End If
            End If
            If dzialanie1 = "5" Then
                If pole2 = "2" Then
                    wiadomaliczba = TextBox1.Text
                    wiadomaliczba2 = TextBox2.Text
                    niewiadoma2 = wiadomaliczba * wiadomaliczba2
                    Label4.Show()
                    EtykietaWynikuDzialania.Text = niewiadoma2
                End If
                If pole2 = "1" Then
                    wiadomaliczba = TextBox1.Text
                    niewiadoma2 = wynik / wiadomaliczba
                    Label4.Show()
                    EtykietaWynikuDzialania.Text = niewiadoma2
                End If
            End If
            If dzialanie1 = "4" Then
                If pole2 = "2" Then
                    wiadomaliczba = TextBox1.Text
                    wiadomaliczba2 = TextBox2.Text
                    niewiadoma2 = wiadomaliczba - wiadomaliczba2
                    Label4.Show()
                    EtykietaWynikuDzialania.Text = niewiadoma2
                End If
                If pole2 = "1" Then
                    wiadomaliczba = TextBox1.Text
                    niewiadoma2 = wynik + wiadomaliczba
                    Label4.Show()
                    EtykietaWynikuDzialania.Text = niewiadoma2
                End If
            End If
            If dzialanie1 = "3" Then
                If pole2 = "2" Then
                    wiadomaliczba = TextBox1.Text
                    wiadomaliczba2 = TextBox2.Text
                    niewiadoma2 = wiadomaliczba + wiadomaliczba2
                    Label4.Show()
                    EtykietaWynikuDzialania.Text = niewiadoma2
                End If
                If pole2 = "1" Then
                    wiadomaliczba = TextBox1.Text
                    niewiadoma2 = wynik - wiadomaliczba
                    Label4.Show()
                    EtykietaWynikuDzialania.Text = niewiadoma2
                End If
            End If
        End If
        If pole1 = "1" Then
            If dzialanie1 = "6" Then
                If pole2 = "2" Then
                    If dzialanie2 = "7" Then
                        wiadomaliczba = TextBox2.Text
                        niewiadoma2 = wynik * wiadomaliczba
                        Label4.Show()
                        EtykietaWynikuDzialania.Text = niewiadoma2
                    End If
                End If
            End If
            If dzialanie1 = "5" Then
                If pole2 = "2" Then
                    If dzialanie2 = "7" Then
                        wiadomaliczba = TextBox2.Text
                        niewiadoma2 = wynik / wiadomaliczba
                        Label4.Show()
                        EtykietaWynikuDzialania.Text = niewiadoma2
                    End If
                End If
            End If
            If dzialanie1 = "4" Then
                If pole2 = "2" Then
                    If dzialanie2 = "7" Then
                        wiadomaliczba = TextBox2.Text
                        niewiadoma2 = wynik + wiadomaliczba
                        Label4.Show()
                        EtykietaWynikuDzialania.Text = niewiadoma2
                    End If
                End If
            End If
            If dzialanie1 = "3" Then
                If pole2 = "2" Then
                    If dzialanie2 = "7" Then
                        wiadomaliczba = TextBox2.Text
                        niewiadoma2 = wynik - wiadomaliczba
                        Label4.Show()
                        EtykietaWynikuDzialania.Text = niewiadoma2
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub ComboBox7_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox7.SelectedIndexChanged
        If ComboBox7.Text = ">>wybierz opcję<<" Then
            rodzajdzialania = ""
        ElseIf ComboBox7.Text = "Dodać" Then
            rodzajdzialania = "plus"
        ElseIf ComboBox7.Text = "Odjąć" Then
            rodzajdzialania = "minus"
        ElseIf ComboBox7.Text = "Mnożyć" Then
            rodzajdzialania = "razy"
        ElseIf ComboBox7.Text = "Dzielić" Then
            rodzajdzialania = "dzielic"
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If RadioButton1.Checked = "True" Then
            WebBrowser2.Navigate("http://www.google.pl/search?q=" & SzukajWInternecie.Text)
        ElseIf RadioButton2.Checked = "True" Then
            WebBrowser2.Navigate("http://www.google.pl/search?q=" & SzukajWInternecie.Text & "&tbm=isch")
        ElseIf RadioButton3.Checked = "True" Then
            WebBrowser2.Navigate("http://www.google.pl/search?q=" & SzukajWInternecie.Text & "&tbm=vid")
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Niewiadoma" Then
            '1 - niewiadoma
            '2 - wiadoma
            '3 - dodać
            '4 - odjąć
            '5 - pomnożyć
            '6 - podzielić
            '7 - równa się
            '8 - wynik
            pole1 = "1"
            TextBox1.Hide()
            Label1.Hide()
        ElseIf ComboBox1.Text = "Wiadoma" Then
            pole1 = "2"
            TextBox1.Show()
            Label1.Show()
        ElseIf ComboBox1.Text = ">>wybierz opcję<<" Then
            pole1 = ""
            TextBox1.Hide()
            Label1.Hide()
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        '1 - niewiadoma
        '2 - wiadoma
        '3 - dodać
        '4 - odjąć
        '5 - pomnożyć
        '6 - podzielić
        '7 - równa się
        '8 - wynik
        If ComboBox2.Text = ">>wybierz opcję<<" Then
            dzialanie1 = ""
        ElseIf ComboBox2.Text = "Dodać" Then
            dzialanie1 = "3"
        ElseIf ComboBox2.Text = "Odjąć" Then
            dzialanie1 = "4"
        ElseIf ComboBox2.Text = "Mnożyć" Then
            dzialanie1 = "5"
        ElseIf ComboBox2.Text = "Dzielić" Then
            dzialanie1 = "6"
        End If
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        '1 - niewiadoma
        '2 - wiadoma
        '3 - dodać
        '4 - odjąć
        '5 - pomnożyć
        '6 - podzielić
        '7 - równa się
        '8 - wynik
        If ComboBox3.Text = "Niewiadoma" Then
            pole2 = "1"
            TextBox2.Hide()
            Label2.Hide()
        ElseIf ComboBox3.Text = "Wiadoma" Then
            pole2 = "2"
            TextBox2.Show()
            Label2.Show()
        ElseIf ComboBox3.Text = ">>wybierz opcję<<" Then
            pole2 = ""
            TextBox2.Hide()
            Label2.Hide()
        End If
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox4.SelectedIndexChanged
        '1 - niewiadoma
        '2 - wiadoma
        '3 - dodać
        '4 - odjąć
        '5 - pomnożyć
        '6 - podzielić
        '7 - równa się
        '8 - wynik
        If ComboBox4.Text = ">>wybierz opcję<<" Then
            dzialanie2 = ""
        ElseIf ComboBox4.Text = "Równa Się" Then
            dzialanie2 = "7"
        End If
    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox5.SelectedIndexChanged
        '1 - niewiadoma
        '2 - wiadoma
        '3 - dodać
        '4 - odjąć
        '5 - pomnożyć
        '6 - podzielić
        '7 - równa się
        '8 - wynik
        If ComboBox5.Text = ">>wybierz opcję<<" Then
            TextBox3.Hide()
            Label3.Hide()
        ElseIf ComboBox5.Text = "Wynik" Then
            TextBox3.Show()
            Label3.Show()
        End If
    End Sub

    Private Sub FormaGlowna_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Ikona powiadomień
        NotifyIcon1.Visible = True

        'Ładowanie programu
        pasek1 = 1
        TextBox1.Hide()
        Label1.Hide()
        TextBox2.Hide()
        Label2.Hide()
        TextBox3.Hide()
        Label3.Hide()

        Timer2.Start()

        'WebBrowser5 - Poczta email
        If My.Settings.PreferowanaPocztaEmail = "Gmail" Then
            WebBrowser5.Navigate("http://www.gmail.com")
        ElseIf My.Settings.PreferowanaPocztaEmail = "Outlook" Then
            WebBrowser5.Navigate("http://www.outlook.com")
        ElseIf My.Settings.PreferowanaPocztaEmail = "o2" Then
            WebBrowser5.Navigate("http://www.o2.pl")
        End If
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        OdmierzanieCzasu.Show()
        godziny = TextBox8.Text
        minuty = TextBox7.Text
        sekundy = TextBox6.Text
        godziny2 = godziny * 60 * 60
        minuty2 = minuty * 60
        czas = godziny2 + minuty2 + sekundy
        Timer1.Start()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Timer1.Stop()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        OdmierzanieCzasu.Hide()
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        OdmierzanieCzasu.Text = ""
        czas = "0"
        czas2 = "0"
        czas3 = "0"
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        czas2 += 1
        czas3 = czas - czas2
        OdmierzanieCzasu.Text = czas3
        If czas = czas2 Then
            Timer1.Stop()
            MsgBox("Czas minął!", vbInformation + vbOKOnly, "Multi Box")
        End If
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Button11.Text = "Ładowanie... Poczekaj chwilę."
        WebBrowser4.Navigate("http://sites.google.com/view/mini-system-box")
        Button11.Text = "Sprawdź aktualizacje oprogramowania"
    End Sub

    Private Sub ToolStripProgressBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        WebBrowser5.GoBack()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        WebBrowser5.GoForward()
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        WebBrowser6.GoBack()
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        WebBrowser6.GoForward()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        sciezkazapisu = InputBox("Wpisz ścieżkę zapisu pliku:", "Mini System Box")
        System.IO.File.WriteAllText(sciezkazapisu, Me.TextBox9.Text)
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        sciezkaodczytu = InputBox("Wpisz ścieżkę, pod jaką jest zapisany plik, który chcesz odczytać.", "Mini System Box")
        Me.TextBox9.Text = System.IO.File.ReadAllText(sciezkaodczytu)
    End Sub

    Private Sub Notatnik_KeyDown(ByVal sender As System.Object, ByVal e As KeyEventArgs) Handles Notatnik.KeyDown
        If e.KeyCode = Keys.F10 Then
            sciezkazapisu = InputBox("Wpisz ścieżkę zapisu pliku:", "Mini System Box")
            System.IO.File.WriteAllText(sciezkazapisu, Me.TextBox9.Text)
        ElseIf e.KeyCode = Keys.F11 Then
            sciezkaodczytu = InputBox("Wpisz ścieżkę, pod jaką jest zapisany plik, który chcesz odczytać.", "Mini System Box")
            Me.TextBox9.Text = System.IO.File.ReadAllText(sciezkaodczytu)
        End If
    End Sub

    Private Sub PrzeliczDlugosc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrzeliczDlugosc.Click
        DlugoscLiczbaIlosci = DlugoscIlosc.Text
        If Dlugosc1.Text = "Metry" Then
            If Dlugosc2.Text = "Jardy" Then
                DlugoscWynik = DlugoscLiczbaIlosci * 1.093613
                WynikDlugosc.Text = DlugoscWynik
            ElseIf Dlugosc2.Text = "Cale" Then
                DlugoscWynik = DlugoscLiczbaIlosci * 39.37008
                WynikDlugosc.Text = DlugoscWynik
            ElseIf Dlugosc2.Text = "Metry" Then
                WynikDlugosc.Text = DlugoscLiczbaIlosci
            End If
        ElseIf Dlugosc1.Text = "Jardy" Then
            If Dlugosc2.Text = "Jardy" Then
                WynikDlugosc.Text = DlugoscLiczbaIlosci
            ElseIf Dlugosc2.Text = "Metry" Then
                DlugoscWynik = DlugoscLiczbaIlosci * 0.9144
                WynikDlugosc.Text = DlugoscWynik
            ElseIf Dlugosc2.Text = "Cale" Then
                DlugoscWynik = DlugoscLiczbaIlosci * 36
                WynikDlugosc.Text = DlugoscWynik
            End If
        ElseIf Dlugosc1.Text = "Cale" Then
            If Dlugosc2.Text = "Cale" Then
                WynikDlugosc.Text = DlugoscLiczbaIlosci
            ElseIf Dlugosc2.Text = "Metry" Then
                DlugoscWynik = DlugoscLiczbaIlosci * 0.0254
                WynikDlugosc.Text = DlugoscWynik
            ElseIf Dlugosc2.Text = "Jardy" Then
                DlugoscWynik = DlugoscLiczbaIlosci * 0.027778
                WynikDlugosc.Text = DlugoscWynik
            End If
        End If
    End Sub

    Private Sub WyczyscDlugosc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WyczyscDlugosc.Click
        Dlugosc1.Text = ""
        Dlugosc2.Text = ""
        DlugoscIlosc.Text = ""
        WynikDlugosc.Text = ""
        DlugoscLiczbaIlosci = "0"

    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        MsgBox("Skróty klawiaturowe w Mini System Box:" & vbCrLf & vbCrLf & "F1 - start czasomierza" & vbCrLf & "F2 - stop czasomierza" & vbCrLf & "F3 - wyczyść czasomierz" & vbCrLf & "F10 - zapisuje pracę w Notatniku" & vbCrLf & "F11 - odczytuje plik w Notatniku", vbQuestion, "Mini System Box")
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        WebBrowser2.GoBack()
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        WebBrowser2.GoForward()
    End Sub

    Private Sub ZamknijAplikacjęToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZamknijAplikacjęToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub GroupBox7_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox7.Enter

    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        WebBrowser1.Navigate("http://www.kalbi.pl")
    End Sub

    Private Sub PrzegladarkaWWWToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrzegladarkaWWWToolStripMenuItem.Click
        TabControl1.SelectedTab = PrzegladarkaWWW
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        My.Settings.PreferowanaPocztaEmail = "Gmail"
    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        My.Settings.PreferowanaPocztaEmail = "Outlook"
    End Sub

    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton6.CheckedChanged
        My.Settings.PreferowanaPocztaEmail = "o2"
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        'WebBrowser5 - Poczta email
        If My.Settings.PreferowanaPocztaEmail = "Gmail" Then
            WebBrowser5.Navigate("http://www.gmail.com")
        ElseIf My.Settings.PreferowanaPocztaEmail = "Outlook" Then
            WebBrowser5.Navigate("http://www.outlook.com")
        ElseIf My.Settings.PreferowanaPocztaEmail = "o2" Then
            WebBrowser5.Navigate("http://www.o2.pl")
        End If
    End Sub

    Private Sub Ustawienia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ustawienia.Click

    End Sub

    Private Sub KalendarzToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KalendarzToolStripMenuItem1.Click
        TabControl1.SelectedTab = Kalendarz
    End Sub

    Private Sub KalkulatorToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KalkulatorToolStripMenuItem1.Click
        TabControl1.SelectedTab = Kalkulator
    End Sub

    Private Sub PrzelicznikToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrzelicznikToolStripMenuItem.Click
        TabControl1.SelectedTab = Przelicznik
    End Sub

    Private Sub CzasomierzToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CzasomierzToolStripMenuItem.Click
        TabControl1.SelectedTab = Czasomierz
    End Sub

    Private Sub NotatnikToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotatnikToolStripMenuItem.Click
        TabControl1.SelectedTab = Notatnik
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick

    End Sub

    Private Sub ToolStripComboBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripComboBox1.Click
        If ToolStripComboBox1.Text = "Pokaż" Then
            NotifyIcon1.Visible = True
        ElseIf ToolStripComboBox1.Text = "Ukryj" Then
            NotifyIcon1.Visible = False
        End If
    End Sub

    Private Sub RadioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RadioToolStripMenuItem.Click
        TabControl1.SelectedTab = Radio
    End Sub

    Private Sub PocztaEmailToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PocztaEmailToolStripMenuItem.Click
        TabControl1.SelectedTab = Email
    End Sub

    Private Sub YouTubeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YouTubeToolStripMenuItem.Click
        TabControl1.SelectedTab = YouTube
    End Sub

    Private Sub UstawieniaAplikacjiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UstawieniaAplikacjiToolStripMenuItem.Click
        TabControl1.SelectedTab = Ustawienia
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub
End Class
