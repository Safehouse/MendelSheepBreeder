Namespace ch.Morrolan.Minecraft.MendelSheepBreeder

    Friend Class SheepStatistic

#Region "Properties"

        Friend ReadOnly Property CountTotal As Integer

            Get
                Return _CountTotal
            End Get

        End Property
        Private _CountTotal As Integer

        Friend ReadOnly Property CountWhite As Integer

            Get
                Return _CountWhite
            End Get

        End Property

        Private _CountWhite As Integer

        Friend ReadOnly Property CountLightGrey As Integer

            Get
                Return _CountLightGrey
            End Get

        End Property
        Private _CountLightGrey As Integer

        Friend ReadOnly Property CountGrey As Integer

            Get
                Return _CountGrey
            End Get

        End Property
        Private _CountGrey As Integer

        Friend ReadOnly Property CountBlack As Integer

            Get
                Return _CountBlack
            End Get

        End Property
        Private _CountBlack As Integer

        Friend ReadOnly Property CountBrown As Integer

            Get
                Return _CountBrown
            End Get

        End Property
        Private _CountBrown As Integer

        Friend ReadOnly Property CountPink As Integer

            Get
                Return _CountPink
            End Get

        End Property
        Private _CountPink As Integer

        Friend ReadOnly Property CountRed As Integer

            Get
                Return _CountRed
            End Get

        End Property
        Private _CountRed As Integer

        Friend ReadOnly Property CountOrange As Integer

            Get
                Return _CountOrange
            End Get

        End Property
        Private _CountOrange As Integer

        Friend ReadOnly Property CountYellow As Integer

            Get
                Return _CountYellow
            End Get

        End Property
        Private _CountYellow As Integer

        Friend ReadOnly Property CountLime As Integer

            Get
                Return _CountLime
            End Get

        End Property
        Private _CountLime As Integer

        Friend ReadOnly Property CountGreen As Integer

            Get
                Return _CountGreen
            End Get

        End Property
        Private _CountGreen As Integer

        Friend ReadOnly Property CountLightBlue As Integer

            Get
                Return _CountLightBlue
            End Get

        End Property
        Private _CountLightBlue As Integer

        Friend ReadOnly Property CountCyan As Integer

            Get
                Return _CountCyan
            End Get

        End Property
        Private _CountCyan As Integer

        Friend ReadOnly Property CountBlue As Integer

            Get
                Return _CountBlue
            End Get

        End Property
        Private _CountBlue As Integer

        Friend ReadOnly Property CountPurple As Integer

            Get
                Return _CountPurple
            End Get

        End Property
        Private _CountPurple As Integer

        Friend ReadOnly Property CountMagenta As Integer

            Get
                Return _CountMagenta
            End Get

        End Property
        Private _CountMagenta As Integer



#End Region

        ''' <summary>
        ''' Takes a list of sheep and create statistics for them.
        ''' </summary>
        ''' <param name="ListOfSheep"></param>
        ''' <remarks></remarks>
        Friend Sub CreateStatistics(ByVal ListOfSheep As List(Of MendelSheep))

            ClearStatistics()

            _CountTotal = ListOfSheep.Count

            For Each Sheep As MendelSheep In ListOfSheep

                Select Case Sheep.Phenotype
                    Case Phenotype.Black
                        _CountBlack += 1
                    Case Phenotype.Blue
                        _CountBlue += 1
                    Case Phenotype.Brown
                        _CountBrown += 1
                    Case Phenotype.Cyan
                        _CountCyan += 1
                    Case Phenotype.Green
                        _CountGreen += 1
                    Case Phenotype.Grey
                        _CountGrey += 1
                    Case Phenotype.LightBlue
                        _CountLightBlue += 1
                    Case Phenotype.LightGrey
                        _CountLightGrey += 1
                    Case Phenotype.Lime
                        _CountLime += 1
                    Case Phenotype.Magenta
                        _CountMagenta += 1
                    Case Phenotype.Orange
                        _CountOrange += 1
                    Case Phenotype.Pink
                        _CountPink += 1
                    Case Phenotype.Purple
                        _CountPurple += 1
                    Case Phenotype.Red
                        _CountRed += 1
                    Case Phenotype.White
                        _CountWhite += 1
                    Case Phenotype.Yellow
                        _CountYellow += 1
                End Select

            Next


        End Sub

        ''' <summary>
        ''' Sets all the count-variables back to zero.
        ''' </summary>
        ''' <remarks></remarks>
        Private Sub ClearStatistics()

            _CountBlack = 0
            _CountBlack = 0
            _CountBrown = 0
            _CountCyan = 0
            _CountGreen = 0
            _CountGrey = 0
            _CountLightBlue = 0
            _CountLightGrey = 0
            _CountLime = 0
            _CountMagenta = 0
            _CountOrange = 0
            _CountPink = 0
            _CountPurple = 0
            _CountRed = 0
            _CountWhite = 0
            _CountYellow = 0

            _CountTotal = 0

        End Sub

    End Class

End Namespace