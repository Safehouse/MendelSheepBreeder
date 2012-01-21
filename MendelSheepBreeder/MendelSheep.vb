Namespace ch.Morrolan.Minecraft.MendelSheepBreeder

    Friend Class MendelSheep

#Region "Properties"

        Friend Property Genome As Genome

            Get
                Return _Genome
            End Get

            Set(value As Genome)
                _Genome = value
                UpdatePhenotype()
            End Set

        End Property

        Private _Genome As Genome


        Friend ReadOnly Property Phenotype As Phenotype

            Get
                Return _Phenotype
            End Get

        End Property

        Private _Phenotype As Phenotype

#End Region

#Region "New"

        Friend Sub New()

        End Sub

        Friend Sub New(ByVal Genome As Genome)

            Me.Genome = Genome

        End Sub

#End Region

        ''' <summary>
        ''' Updates the phenotype according to the PhenotypeMap by using the specified genome.
        ''' </summary>
        ''' <remarks></remarks>
        Private Sub UpdatePhenotype()

            Me._Phenotype = PhenotypeMap.GetPhenoype(Me.Genome)

        End Sub

    End Class


End Namespace