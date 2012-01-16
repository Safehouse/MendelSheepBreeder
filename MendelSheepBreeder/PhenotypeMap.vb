Friend Class PhenotypeMap

    Friend Map(,,,) As Phenotype

    Friend Sub New()

        ' Maps Genome-values (actually only the resulting ones, that is after taking into to account recessive / dominant mechanisms) to Phenotypes.
        ' Order of genomes is: Naturalness -Colourness - Lightness - Hue.
        Map(0, 0, 0, 0) = Phenotype.Blue
        Map(0, 0, 0, 1) = Phenotype.Purple
        Map(0, 0, 1, 0) = Phenotype.LightBlue
        Map(0, 0, 1, 1) = Phenotype.Cyan
        Map(0, 1, 0, 0) = Phenotype.Brown
        Map(0, 1, 0, 1) = Phenotype.Purple
        Map(0, 1, 1, 0) = Phenotype.Red
        Map(0, 1, 1, 1) = Phenotype.Pink
        Map(1, 0, 0, 0) = Phenotype.Green
        Map(1, 0, 0, 1) = Phenotype.Orange
        Map(1, 0, 1, 0) = Phenotype.Green
        Map(1, 0, 1, 1) = Phenotype.Yellow
        Map(1, 1, 0, 0) = Phenotype.Black
        Map(1, 1, 0, 1) = Phenotype.LightGrey
        Map(1, 1, 1, 0) = Phenotype.Grey
        Map(1, 1, 1, 1) = Phenotype.White

    End Sub

End Class
