Public Class LogDate

    Private _dateLogged As String
    Private _userInitials As String

    Public Sub New()
        Me._dateLogged = CType(Today, String)
        Me._userInitials = "NRG"
    End Sub

    Public Sub setUser(userInitials As String)
        Me._userInitials = userInitials
    End Sub

    Public Function getDate() As String
        Return CType(Today, String)
    End Function

    Public ReadOnly Property userInitials As String
        Get
            Return _userInitials
        End Get
    End Property

End Class