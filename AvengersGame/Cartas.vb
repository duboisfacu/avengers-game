Public Class Cartas
    Private nombre_ As String
    Private imagen_ As String
    Private fuerza_ As Integer
    Private inteligencia_ As Integer
    Private resistencia_ As Integer
    Private destreza_ As Integer

    Public Property nombre() As String
        Get
            Return nombre_
        End Get
        Set(ByVal value As String)
            nombre_ = value
        End Set
    End Property

    Public Property imagen() As String

        Get
            Return imagen_
        End Get
        Set(ByVal value As String)
            imagen_ = value
        End Set
    End Property

    Public Property fuerza() As Integer
        Get
            Return fuerza_
        End Get
        Set(ByVal value As Integer)
            fuerza_ = value
        End Set
    End Property

    Public Property inteligencia() As Integer
        Get
            Return inteligencia_
        End Get
        Set(ByVal value As Integer)
            inteligencia_ = value
        End Set
    End Property

    Public Property resistencia() As Integer
        Get
            Return resistencia_
        End Get
        Set(ByVal value As Integer)
            resistencia_ = value
        End Set
    End Property

    Public Property destreza() As Integer
        Get
            Return destreza_
        End Get
        Set(ByVal value As Integer)
            destreza_ = value
        End Set
    End Property

End Class
