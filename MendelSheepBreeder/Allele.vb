Namespace ch.Morrolan.Minecraft.MendelSheepBreeder

    Friend Class Allele

#Region "Properties"

        Friend Property Gene1 As Byte

            Get
                Return _Gene1
            End Get

            Set(value As Byte)
                Select Case value
                    Case 0
                        _Gene1 = 0
                    Case 1
                        _Gene1 = 1
                    Case Else
                        Throw New ArgumentOutOfRangeException("Gene1", "Has to be either 0 or 1")
                End Select
            End Set

        End Property

        Private _Gene1 As Byte


        Friend Property Gene2 As Byte

            Get
                Return _Gene2
            End Get

            Set(value As Byte)
                Select Case value
                    Case 0
                        _Gene2 = 0
                    Case 1
                        _Gene2 = 1
                    Case Else
                        Throw New ArgumentOutOfRangeException("Gene2", "Has to be either 0 or 1")
                End Select
            End Set

        End Property

        Private _Gene2 As Byte

#End Region

    End Class

End Namespace
