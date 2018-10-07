Module Zmienne
    'Zmienne do formy 1
    Public pole1 As String
    Public dzialanie1 As String
    Public pole2 As String
    Public dzialanie2 As String
    Public wynik As String

    'Wyniki działania
    Public niewiadoma2 As Byte
    Public wiadomaliczba As Byte
    Public wiadomaliczba2 As Byte
    Public wynikdzialania As Byte

    'Do kalkulatora
    Public pierwszawiadoma As Double
    Public drugawiadoma As Double
    Public rodzajdzialania As String
    Public wynikzkalkulatora As Double

    'Do odmierzania czasu
    Public godziny As Integer
    Public minuty As Integer
    Public sekundy As Integer
    Public godziny2 As Integer
    Public minuty2 As Integer
    Public czas As Integer
    Public czas2 As Integer
    Public czas3 As Integer

    'Do ładowania programu:
    Public ladowanie As Byte
    Public pasek1 As Byte
    Public pasek2 As Byte

    'Do notatnika:
    Public sciezkazapisu As String
    Public sciezkaodczytu As String

    'Do bootloadera:
    Public stanprogressbara As Byte = 0
    Public czasprogressbara As Byte
    Public czasprogressbara2 As Byte
    Public czasprogressbara3 As Byte

    'Do przelicznika długości:
    Public DlugoscLiczbaIlosci As Byte
    Public DlugoscWynik As Double

End Module
