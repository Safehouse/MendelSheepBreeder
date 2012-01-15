Friend Class MendelSheep

#Region "Properties"

    Friend Property Genom As Genome

        Get
            Return _Genom
        End Get

        Set(value As Genome)
            _Genom = value
            UpdatePhenotype()
        End Set

    End Property

    Private _Genom As Genome


    Friend ReadOnly Property Phenotype As Phenotype

        Get
            Return _Phenotype
        End Get

    End Property

    Private _Phenotype As Phenotype

#End Region

#Region "New"

#End Region


    Private Sub UpdatePhenotype()

    End Sub



End Class
