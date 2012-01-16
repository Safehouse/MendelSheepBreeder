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

        End Function



        Friend Function GetGenomesNaturalness() As List(Of Genome)

        End Function

        Friend Function GetGenomesColourness() As List(Of Genome)

        End Function

        Friend Function GetGenomesLightness() As List(Of Genome)

        End Function

        Friend Function GetGenomesHue() As List(Of Genome)

        End Function




    End Module

End Namespace