Namespace ch.Morrolan.Minecraft.MendelSheepBreeder

    ' Order of genomes is: Naturalness -Colourness - Lightness - Hue.

    Module ReproductionAssistant

        ''' <summary>
        ''' Returns all the possible children when given the two parents.
        ''' </summary>
        ''' <param name="Parent1">First parent</param>
        ''' <param name="Parent2">Second Parent</param>
        ''' <returns>A list containing all possible children</returns>
        ''' <remarks></remarks>
        Friend Function GetChildren(ByVal Parent1 As MendelSheep, ByVal Parent2 As MendelSheep) As List(Of MendelSheep)

            Dim ListOfChildren As New List(Of MendelSheep)

            Dim ListOfGenomes As List(Of Genome) = GetGenomes(Parent1.Genome, Parent2.Genome)

            For Each Genome In ListOfGenomes

                ListOfChildren.Add(New MendelSheep(Genome))

            Next

            Return ListOfChildren

        End Function


        ''' <summary>
        ''' Returns a list of all the possible genomes when given the two genomes of the parents.
        ''' </summary>
        ''' <param name="Genome1">First genome</param>
        ''' <param name="Genome2">Second genome</param>
        ''' <returns>A list containing all possible genomes</returns>
        ''' <remarks></remarks>
        Friend Function GetGenomes(ByVal Genome1 As Genome, ByVal Genome2 As Genome) As List(Of Genome)

            Dim ListOfGenomes As New List(Of Genome)

            Dim ListOfAllelesNaturalness As List(Of Gene) = GetAllelesNaturalness(Genome1.Naturalness, Genome2.Naturalness)
            Dim ListOfAllelesColourness As List(Of Gene) = GetAllelesColourness(Genome1.Colourness, Genome2.Colourness)
            Dim ListOfAllelesLightness As List(Of Gene) = GetAllelesLightness(Genome1.Lightness, Genome2.Lightness)
            Dim ListOfAllelesHue As List(Of Gene) = GetAllelesHue(Genome1.Hue, Genome2.Hue)

            For Each AlleleNaturalness In ListOfAllelesNaturalness

                For Each AlleleColourness In ListOfAllelesColourness

                    For Each AlleleLightness In ListOfAllelesLightness

                        For Each AlleleHue In ListOfAllelesHue

                            ListOfGenomes.Add(New Genome(AlleleNaturalness, AlleleColourness, AlleleLightness, AlleleHue))

                        Next

                    Next

                Next

            Next


            Return ListOfGenomes

        End Function



        Friend Function GetAllelesNaturalness(ByVal Naturalness1 As Gene, ByVal Naturalness2 As Gene) As List(Of Gene)

            Dim ListOfAllelesNaturalness As New List(Of Gene)

            ListOfAllelesNaturalness.Add(New Gene(Naturalness1.Allele1, Naturalness2.Allele1))
            ListOfAllelesNaturalness.Add(New Gene(Naturalness1.Allele1, Naturalness2.Allele2))
            ListOfAllelesNaturalness.Add(New Gene(Naturalness1.Allele2, Naturalness2.Allele1))
            ListOfAllelesNaturalness.Add(New Gene(Naturalness1.Allele2, Naturalness2.Allele2))

            Return ListOfAllelesNaturalness

        End Function

        Friend Function GetAllelesColourness(ByVal Colourness1 As Gene, ByVal Colourness2 As Gene) As List(Of Gene)

            Dim ListOfAllelesColourness As New List(Of Gene)

            ListOfAllelesColourness.Add(New Gene(Colourness1.Allele1, Colourness2.Allele1))
            ListOfAllelesColourness.Add(New Gene(Colourness1.Allele1, Colourness2.Allele2))
            ListOfAllelesColourness.Add(New Gene(Colourness1.Allele2, Colourness2.Allele1))
            ListOfAllelesColourness.Add(New Gene(Colourness1.Allele2, Colourness2.Allele2))

            Return ListOfAllelesColourness

        End Function

        Friend Function GetAllelesLightness(ByVal Lightness1 As Gene, ByVal Lightness2 As Gene) As List(Of Gene)

            Dim ListOfAllelesLightness As New List(Of Gene)

            ListOfAllelesLightness.Add(New Gene(Lightness1.Allele1, Lightness2.Allele1))
            ListOfAllelesLightness.Add(New Gene(Lightness1.Allele1, Lightness2.Allele2))
            ListOfAllelesLightness.Add(New Gene(Lightness1.Allele2, Lightness2.Allele1))
            ListOfAllelesLightness.Add(New Gene(Lightness1.Allele2, Lightness2.Allele2))

            Return ListOfAllelesLightness

        End Function

        Friend Function GetAllelesHue(ByVal Hue1 As Gene, ByVal Hue2 As Gene) As List(Of Gene)

            Dim ListOfAllelesHue As New List(Of Gene)

            ListOfAllelesHue.Add(New Gene(Hue1.Allele1, Hue2.Allele1))
            ListOfAllelesHue.Add(New Gene(Hue1.Allele1, Hue2.Allele2))
            ListOfAllelesHue.Add(New Gene(Hue1.Allele2, Hue2.Allele1))
            ListOfAllelesHue.Add(New Gene(Hue1.Allele2, Hue2.Allele2))

            Return ListOfAllelesHue

        End Function




    End Module

End Namespace