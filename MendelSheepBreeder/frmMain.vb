Imports ch.Morrolan.Minecraft.MendelSheepBreeder

Public Class frmMain

    ' Order of genomes is: Naturalness -Colourness - Lightness - Hue.


    Private Parent1 As New MendelSheep
    Private Parent2 As New MendelSheep


    ''' <summary>
    ''' Updates the parents objects based on the input specified by the numericupdown controls.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub UpdateParents()

        Dim Naturalness As New Allele
        Dim Colourness As New Allele
        Dim Lightness As New Allele
        Dim Hue As New Allele

        Dim Genome As New Genome


        ' Get the specified information for the first parent.
        Naturalness.Gene1 = CByte(nmrParentsGenome1Naturalness1.Value)
        Naturalness.Gene2 = CByte(nmrParentsGenome1Naturalness2.Value)

        Colourness.Gene1 = CByte(nmrParentsGenome1Colourness1.Value)
        Colourness.Gene2 = CByte(nmrParentsGenome1Colourness2.Value)

        Lightness.Gene1 = CByte(nmrParentsGenome1Lightness1.Value)
        Lightness.Gene2 = CByte(nmrParentsGenome1Lightness2.Value)

        Hue.Gene1 = CByte(nmrParentsGenome1Hue1.Value)
        Hue.Gene2 = CByte(nmrParentsGenome1Hue2.Value)

        Genome.Naturalness = Naturalness
        Genome.Colourness = Colourness
        Genome.Lightness = Lightness
        Genome.Hue = Hue

        Parent1.Genome = Genome


        ' Get the specified information for the second parent.
        Naturalness.Gene1 = CByte(nmrParentsGenome2Naturalness1.Value)
        Naturalness.Gene2 = CByte(nmrParentsGenome2Naturalness2.Value)

        Colourness.Gene1 = CByte(nmrParentsGenome2Colourness1.Value)
        Colourness.Gene2 = CByte(nmrParentsGenome2Colourness2.Value)

        Lightness.Gene1 = CByte(nmrParentsGenome2Lightness1.Value)
        Lightness.Gene2 = CByte(nmrParentsGenome2Lightness2.Value)

        Hue.Gene1 = CByte(nmrParentsGenome2Hue1.Value)
        Hue.Gene2 = CByte(nmrParentsGenome2Hue2.Value)

        Genome.Naturalness = Naturalness
        Genome.Colourness = Colourness
        Genome.Lightness = Lightness
        Genome.Hue = Hue

        Parent2.Genome = Genome


        UpdateParentsImages()


    End Sub

    ''' <summary>
    ''' Updates the shown images of the parents based on their phenotypes.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub UpdateParentsImages()

        Select Case Parent1.Phenotype
            Case Phenotype.Black
                pctParent1.Image = My.Resources.sheep_black
            Case Phenotype.Blue
                pctParent1.Image = My.Resources.sheep_blue
            Case Phenotype.Brown
                pctParent1.Image = My.Resources.sheep_brown
            Case Phenotype.Cyan
                pctParent1.Image=My.Resources.sheep_cyan
            Case Phenotype.Green
                pctParent1.Image = My.Resources.sheep_green
            Case Phenotype.Grey
                pctParent1.Image = My.Resources.sheep_grey
            Case Phenotype.LightBlue
                pctParent1.Image = My.Resources.sheep_lightblue
            Case Phenotype.LightGrey
                pctParent1.Image = My.Resources.sheep_lightgrey
            Case Phenotype.Lime
                pctParent1.Image = My.Resources.sheep_lime
            Case Phenotype.Magenta
                pctParent1.Image = My.Resources.sheep_magenta
            Case Phenotype.Orange
                pctParent1.Image = My.Resources.sheep_orange
            Case Phenotype.Pink
                pctParent1.Image = My.Resources.sheep_pink
            Case Phenotype.Purple
                pctParent1.Image = My.Resources.sheep_purple
            Case Phenotype.Red
                pctParent1.Image = My.Resources.sheep_red
            Case Phenotype.White
                pctParent1.Image = My.Resources.sheep_white
            Case Phenotype.Yellow
                pctParent1.Image = My.Resources.sheep_yellow
        End Select

        Select Case Parent2.Phenotype
            Case Phenotype.Black
                pctParent2.Image = My.Resources.sheep_black
            Case Phenotype.Blue
                pctParent2.Image = My.Resources.sheep_blue
            Case Phenotype.Brown
                pctParent2.Image = My.Resources.sheep_brown
            Case Phenotype.Cyan
                pctParent2.Image = My.Resources.sheep_cyan
            Case Phenotype.Green
                pctParent2.Image = My.Resources.sheep_green
            Case Phenotype.Grey
                pctParent2.Image = My.Resources.sheep_grey
            Case Phenotype.LightBlue
                pctParent2.Image = My.Resources.sheep_lightblue
            Case Phenotype.LightGrey
                pctParent2.Image = My.Resources.sheep_lightgrey
            Case Phenotype.Lime
                pctParent2.Image = My.Resources.sheep_lime
            Case Phenotype.Magenta
                pctParent2.Image = My.Resources.sheep_magenta
            Case Phenotype.Orange
                pctParent2.Image = My.Resources.sheep_orange
            Case Phenotype.Pink
                pctParent2.Image = My.Resources.sheep_pink
            Case Phenotype.Purple
                pctParent2.Image = My.Resources.sheep_purple
            Case Phenotype.Red
                pctParent2.Image = My.Resources.sheep_red
            Case Phenotype.White
                pctParent2.Image = My.Resources.sheep_white
            Case Phenotype.Yellow
                pctParent2.Image = My.Resources.sheep_yellow
        End Select

    End Sub



    ''' <summary>
    ''' Whenever any of the NumericUpDown's values changes the parents get updated with the new information.
    ''' Theoretically some calculation time could be saved by updating only the parent which changed or even only the allele which changed, but that's not worth the hassle.
    ''' </summary>
    ''' <remarks></remarks>
#Region "GenomeInputChanged"

    Private Sub nmrParentsGenome1Naturalness1_ValueChanged(sender As System.Object, e As System.EventArgs) Handles nmrParentsGenome1Naturalness1.ValueChanged
        UpdateParents()
    End Sub

    Private Sub NumericUpDonmrParentsGenome1Naturalness2_ValueChanged(sender As System.Object, e As System.EventArgs) Handles nmrParentsGenome1Naturalness2.ValueChanged
        UpdateParents()
    End Sub

    Private Sub NumericUpDonmrParentsGenome1Colourness1_ValueChanged(sender As System.Object, e As System.EventArgs) Handles nmrParentsGenome1Colourness1.ValueChanged
        UpdateParents()
    End Sub

    Private Sub NumericUpDonmrParentsGenome1Colourness2_ValueChanged(sender As System.Object, e As System.EventArgs) Handles nmrParentsGenome1Colourness2.ValueChanged
        UpdateParents()
    End Sub

    Private Sub NumericUpDonmrParentsGenome1Lightness1_ValueChanged(sender As System.Object, e As System.EventArgs) Handles nmrParentsGenome1Lightness1.ValueChanged
        UpdateParents()
    End Sub

    Private Sub NumericUpDonmrParentsGenome1Lightness2_ValueChanged(sender As System.Object, e As System.EventArgs) Handles nmrParentsGenome1Lightness2.ValueChanged
        UpdateParents()
    End Sub

    Private Sub NumericUpDonmrParentsGenome1Hue1_ValueChanged(sender As System.Object, e As System.EventArgs) Handles nmrParentsGenome1Hue1.ValueChanged
        UpdateParents()
    End Sub

    Private Sub NumericUpDonmrParentsGenome1Hue2_ValueChanged(sender As System.Object, e As System.EventArgs) Handles nmrParentsGenome1Hue2.ValueChanged
        UpdateParents()
    End Sub

    Private Sub NumericUpDonmrParentsGenome2Naturalness1_ValueChanged(sender As System.Object, e As System.EventArgs) Handles nmrParentsGenome2Naturalness1.ValueChanged
        UpdateParents()
    End Sub

    Private Sub NumericUpDonmrParentsGenome2Naturalness2_ValueChanged(sender As System.Object, e As System.EventArgs) Handles nmrParentsGenome2Naturalness2.ValueChanged
        UpdateParents()
    End Sub

    Private Sub NumericUpDonmrParentsGenome2Colourness1_ValueChanged(sender As System.Object, e As System.EventArgs) Handles nmrParentsGenome2Colourness1.ValueChanged
        UpdateParents()
    End Sub

    Private Sub NumericUpDonmrParentsGenome2Colourness2_ValueChanged(sender As System.Object, e As System.EventArgs) Handles nmrParentsGenome2Colourness2.ValueChanged
        UpdateParents()
    End Sub

    Private Sub NumericUpDonmrParentsGenome2Lightness1_ValueChanged(sender As System.Object, e As System.EventArgs) Handles nmrParentsGenome2Lightness1.ValueChanged
        UpdateParents()
    End Sub

    Private Sub NumericUpDonmrParentsGenome2Lightness2_ValueChanged(sender As System.Object, e As System.EventArgs) Handles nmrParentsGenome2Lightness2.ValueChanged
        UpdateParents()
    End Sub

    Private Sub NumericUpDonmrParentsGenome2Hue1_ValueChanged(sender As System.Object, e As System.EventArgs) Handles nmrParentsGenome2Hue1.ValueChanged
        UpdateParents()
    End Sub

    Private Sub NumericUpDonmrParentsGenome2Hue2_ValueChanged(sender As System.Object, e As System.EventArgs) Handles nmrParentsGenome2Hue2.ValueChanged
        UpdateParents()
    End Sub


#End Region

End Class

