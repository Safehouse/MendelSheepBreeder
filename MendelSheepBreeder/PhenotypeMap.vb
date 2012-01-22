Namespace ch.Morrolan.Minecraft.MendelSheepBreeder

    Friend Module PhenotypeMap

        Private _Map(1, 1, 1, 1) As Phenotype


        Private Sub Initialize()

            ' Maps Genome-values (actually only the resulting ones, that is after taking into to account recessive / dominant mechanisms) to Phenotypes.
            ' Order of genomes is: Naturalness -Colourness - Lightness - Hue.
            _Map(0, 0, 0, 0) = Phenotype.Blue
            _Map(0, 0, 0, 1) = Phenotype.Purple
            _Map(0, 0, 1, 0) = Phenotype.LightBlue
            _Map(0, 0, 1, 1) = Phenotype.Cyan
            _Map(0, 1, 0, 0) = Phenotype.Brown
            _Map(0, 1, 0, 1) = Phenotype.Purple
            _Map(0, 1, 1, 0) = Phenotype.Red
            _Map(0, 1, 1, 1) = Phenotype.Pink
            _Map(1, 0, 0, 0) = Phenotype.Green
            _Map(1, 0, 0, 1) = Phenotype.Orange
            _Map(1, 0, 1, 0) = Phenotype.Lime
            _Map(1, 0, 1, 1) = Phenotype.Yellow
            _Map(1, 1, 0, 0) = Phenotype.Black
            _Map(1, 1, 0, 1) = Phenotype.LightGrey
            _Map(1, 1, 1, 0) = Phenotype.Grey
            _Map(1, 1, 1, 1) = Phenotype.White

        End Sub

        ''' <summary>
        ''' Takes the genome, calculates what the resulting genome is and returns the phenotype.
        ''' </summary>
        ''' <param name="Genome"></param>
        ''' <returns>Returns the phenotype corresponding to the genome.</returns>
        ''' <remarks></remarks>
        Friend Function GetPhenoype(ByVal Genome As Genome) As Phenotype

            Initialize()

            Dim ResultingNaturalness As Byte
            Dim ResultingColourness As Byte
            Dim ResultingLightness As Byte
            Dim ResultingHue As Byte

            ResultingNaturalness = Genome.Naturalness.Allele1 Or Genome.Naturalness.Allele2
            ResultingColourness = Genome.Colourness.Allele1 Or Genome.Colourness.Allele2
            ResultingLightness = Genome.Lightness.Allele1 Or Genome.Lightness.Allele2
            ResultingHue = Genome.Hue.Allele1 Or Genome.Hue.Allele2

            Dim Phenotype As New Phenotype
            Phenotype = _Map(ResultingNaturalness, ResultingColourness, ResultingLightness, ResultingHue)
            Return Phenotype

        End Function

    End Module

End Namespace
