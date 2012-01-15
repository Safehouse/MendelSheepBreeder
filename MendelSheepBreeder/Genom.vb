Friend Class Genom

#Region "Properties"

    Friend Property Naturalness As Byte

        Get
            Return _Naturalness
        End Get

        Set(value As Byte)
            Select Case value
                Case 0
                    _Naturalness = 0
                Case 1
                    _Naturalness = 1
                Case Else
                    Throw New ArgumentOutOfRangeException("Naturalness", "Has to be either 0 or 1")
            End Select
        End Set

    End Property

    Private _Naturalness As Byte


    Friend Property Colourness As Byte

        Get
            Return _Colourness
        End Get

        Set(value As Byte)
            Select Case value
                Case 0
                    _Colourness = 0
                Case 1
                    _Colourness = 1
                Case Else
                    Throw New ArgumentOutOfRangeException("Colourness", "Has to be either 0 or 1")
            End Select
        End Set

    End Property

    Private _Colourness As Byte


    Friend Property Lightness As Byte

        Get
            Return _Lightness
        End Get

        Set(value As Byte)
            Select Case value
                Case 0
                    _Lightness = 0
                Case 1
                    _Lightness = 1
                Case Else
                    Throw New ArgumentOutOfRangeException("Lightness", "Has to be either 0 or 1")
            End Select
        End Set

    End Property

    Private _Lightness As Byte


    Friend Property Hue As Byte

        Get
            Return _Hue
        End Get

        Set(value As Byte)
            Select Case value
                Case 0
                    _Hue = 0
                Case 1
                    _Hue = 1
                Case Else
                    Throw New ArgumentOutOfRangeException("Hue", "Has to be either 0 or 1")
            End Select
        End Set

    End Property

    Private _Hue As Byte

#End Region

#Region "New"

    Friend Sub New()

    End Sub

    Friend Sub New(ByVal Genom As Genom)

        _Naturalness = Genom.Naturalness
        _Colourness = Genom.Colourness
        _Lightness = Genom.Lightness
        _Hue = Genom.Hue

    End Sub

    Friend Sub New(ByVal Naturalness As Byte, ByVal Colourness As Byte, ByVal Lightness As Byte, ByVal Hue As Byte)

        _Naturalness = Naturalness
        _Colourness = Colourness
        _Lightness = Lightness
        _Hue = Hue

    End Sub

#End Region



End Class