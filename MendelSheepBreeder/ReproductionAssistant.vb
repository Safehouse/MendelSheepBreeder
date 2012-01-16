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

            Dim ListOfAllelesNaturalness As List(Of Allele) = GetAllelesNaturalness(Genome1.Naturalness, Genome2.Naturalness)
            Dim ListOfAllelesColourness As List(Of Allele) = GetAllelesColourness(Genome1.Colourness, Genome2.Colourness)
            Dim ListOfAllelesLightness As List(Of Allele) = GetAllelesLightness(Genome1.Lightness, Genome2.Lightness)
            Dim ListOfAllelesHue As List(Of Allele) = GetAllelesHue(Genome1.Hue, Genome2.Hue)

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



        Friend Function GetAllelesNaturalness(ByVal Naturalness1 As Allele, ByVal Naturalness2 As Allele) As List(Of Allele)

            Dim ListOfAllelesNaturalness As New List(Of Allele)

            ListOfAllelesNaturalness.Add(New Allele(Naturalness1.Gene1, Naturalness2.Gene1))
            ListOfAllelesNaturalness.Add(New Allele(Naturalness1.Gene1, Naturalness2.Gene2))
            ListOfAllelesNaturalness.Add(New Allele(Naturalness1.Gene2, Naturalness2.Gene1))
            ListOfAllelesNaturalness.Add(New Allele(Naturalness1.Gene2, Naturalness2.Gene2))

            Return ListOfAllelesNaturalness

        End Function

        Friend Function GetAllelesColourness(ByVal Colourness1 As Allele, ByVal Colourness2 As Allele) As List(Of Allele)

            Dim ListOfAllelesColourness As New List(Of Allele)

            ListOfAllelesColourness.Add(New Allele(Colourness1.Gene1, Colourness2.Gene1))
            ListOfAllelesColourness.Add(New Allele(Colourness1.Gene1, Colourness2.Gene2))
            ListOfAllelesColourness.Add(New Allele(Colourness1.Gene2, Colourness2.Gene1))
            ListOfAllelesColourness.Add(New Allele(Colourness1.Gene2, Colourness2.Gene2))

            Return ListOfAllelesColourness

        End Function

        Friend Function GetAllelesLightness(ByVal Lightness1 As Allele, ByVal Lightness2 As Allele) As List(Of Allele)

            Dim ListOfAllelesLightness As New List(Of Allele)

            ListOfAllelesLightness.Add(New Allele(Lightness1.Gene1, Lightness2.Gene1))
            ListOfAllelesLightness.Add(New Allele(Lightness1.Gene1, Lightness2.Gene2))
            ListOfAllelesLightness.Add(New Allele(Lightness1.Gene2, Lightness2.Gene1))
            ListOfAllelesLightness.Add(New Allele(Lightness1.Gene2, Lightness2.Gene2))

            Return ListOfAllelesLightness

        End Function

        Friend Function GetAllelesHue(ByVal Hue1 As Allele, ByVal Hue2 As Allele) As List(Of Allele)

            Dim ListOfAllelesHue As New List(Of Allele)

            ListOfAllelesHue.Add(New Allele(Hue1.Gene1, Hue2.Gene1))
            ListOfAllelesHue.Add(New Allele(Hue1.Gene1, Hue2.Gene2))
            ListOfAllelesHue.Add(New Allele(Hue1.Gene2, Hue2.Gene1))
            ListOfAllelesHue.Add(New Allele(Hue1.Gene2, Hue2.Gene2))

            Return ListOfAllelesHue

        End Function




    End Module

End Namespace