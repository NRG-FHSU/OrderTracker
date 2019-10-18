Public Class LogDate

    Public dateLogged As Date
    Public userInitials As String

    Public Sub New()
        Me.dateLogged = Today
        Me.userInitials = "NRG"

    End Sub
    Public Sub New(dateLogged As Date, userInitials As String)
        Me.dateLogged = dateLogged
        Me.userInitials = userInitials
    End Sub

End Class
