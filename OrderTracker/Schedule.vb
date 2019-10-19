Public Class Schedule

    Public orderDelivery As Date
    Private Const engWeeks As Double = -42 '1 week
    Private Const drftWeeks As Double = -35 '1 week
    Private Const fabWeeks As Double = -28 '2 weeks
    Private Const finishWeeks As Double = -14 '1 week
    Private Const shipWeeks As Double = -7 '1 week

    Public Sub New()
        orderDelivery = Today
    End Sub
    Public Sub setDelivery(orderDelivery As Date)
        Me.orderDelivery = orderDelivery
    End Sub

    Public Function engDate() As Date
        Dim eng As Date = orderDelivery.AddDays(engWeeks)
        Return eng
    End Function

    Public Function drftDate() As Date
        Dim drft As Date = orderDelivery.AddDays(drftWeeks)
        Return drft
    End Function
    Public Function fabDate() As Date
        Dim fab As Date = orderDelivery.AddDays(fabWeeks)
        Return fab
    End Function
    Public Function finishDate() As Date
        Dim finish As Date = orderDelivery.AddDays(finishWeeks)
        Return finish
    End Function
    Public Function shipDate() As Date
        Dim ship As Date = orderDelivery.AddDays(shipWeeks)
        Return ship
    End Function
End Class
