Public Class Search

    Private _field As String

    Public Sub New()
        _field = "Customer"
    End Sub

    Public Sub New(field As String)
        _field = field
    End Sub

    Public Sub setField(ByVal field As String)
        _field = field
    End Sub
    Public ReadOnly Property Field As String
        Get
            Return _field
        End Get
    End Property
End Class
