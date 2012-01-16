Friend Class Allele

#Region "Properties"

    Friend Property Gene1 As Byte

        Get
            Return _Gene1
        End Get

        Set(value As Byte)
            Select Case _Gene1
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

#End Region

End Class
