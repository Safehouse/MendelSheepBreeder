Namespace ch.Morrolan.Minecraft.MendelSheepBreeder

    Friend Class Genome

#Region "Properties"

        Friend Property Naturalness As Gene

            Get
                Return _Naturalness
            End Get

            Set(value As Gene)
                _Naturalness = value
            End Set

        End Property
        Private _Naturalness As Gene

        Friend Property Colourness As Gene

            Get
                Return _Colourness
            End Get

            Set(value As Gene)
                _Colourness = value
            End Set

        End Property
        Private _Colourness As Gene

        Friend Property Lightness As Gene

            Get
                Return _Lightness
            End Get

            Set(value As Gene)
                _Lightness = value
            End Set

        End Property
        Private _Lightness As Gene

        Friend Property Hue As Gene

            Get
                Return _Hue
            End Get

            Set(value As Gene)
                _Hue = value
            End Set

        End Property
        Private _Hue As Gene

#End Region

#Region "New"

        Friend Sub New()

        End Sub

        Friend Sub New(ByVal Genome As Genome)

            Naturalness = Genome.Naturalness
            Colourness = Genome.Colourness
            Lightness = Genome.Lightness
            Hue = Genome.Hue

        End Sub

        Friend Sub New(ByVal Naturalness As Gene, ByVal Colourness As Gene, ByVal Lightness As Gene, ByVal Hue As Gene)

            Me.Naturalness = Naturalness
            Me.Colourness = Colourness
            Me.Lightness = Lightness
            Me.Hue = Hue

        End Sub

#End Region

        Overrides Function ToString() As String

            Dim John As New System.Text.StringBuilder

            John.Append(Naturalness.ToString).AppendLine()
            John.Append(Colourness.ToString).AppendLine()
            John.Append(Lightness.ToString).AppendLine()
            John.Append(Hue.ToString).AppendLine()

            Return John.ToString

        End Function

    End Class

End Namespace