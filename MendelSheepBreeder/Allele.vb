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

        Friend Property Name As String

            Get
                Return _Name
            End Get

            Set(value As String)
                _Name = value
            End Set

        End Property
        Private _Name As String

#End Region


#Region "New"

        Friend Sub New()

        End Sub

        Friend Sub New(ByVal Gene1 As Byte, ByVal Gene2 As Byte)

            Me.Gene1 = Gene1
            Me.Gene2 = Gene2

        End Sub

#End Region

        Overrides Function ToString() As String

            Dim John As String

            John = Name & ": " & CStr(Gene1) & "," & CStr(Gene2)
            Return John

        End Function

    End Class

End Namespace
