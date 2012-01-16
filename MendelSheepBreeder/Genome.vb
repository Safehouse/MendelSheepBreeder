Namespace ch.Morrolan.Minecraft.MendelSheepBreeder

    Friend Class Genome

#Region "Properties"

        Friend Property Naturalness As Allele

            Get
                Return _Naturalness
            End Get

            Set(value As Allele)
                _Naturalness = value
            End Set

        End Property

        Private _Naturalness As Allele


        Friend Property Colourness As Allele

            Get
                Return _Colourness
            End Get

            Set(value As Allele)
                _Colourness = value
            End Set

        End Property

        Private _Colourness As Allele


        Friend Property Lightness As Allele

            Get
                Return _Lightness
            End Get

            Set(value As Allele)
                _Lightness = value
            End Set

        End Property

        Private _Lightness As Allele


        Friend Property Hue As Allele

            Get
                Return _Hue
            End Get

            Set(value As Allele)
                _Hue = value
            End Set

        End Property

        Private _Hue As Allele

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

        Friend Sub New(ByVal Naturalness As Allele, ByVal Colourness As Allele, ByVal Lightness As Allele, ByVal Hue As Allele)

            Me.Naturalness = Naturalness
            Me.Colourness = Colourness
            Me.Lightness = Lightness
            Me.Hue = Hue

        End Sub

#End Region


#Region "DoStuff"

#End Region


    End Class

End Namespace