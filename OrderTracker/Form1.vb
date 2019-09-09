Public Class Form1
    Private Sub TableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.QuoteOrdersDS)

    End Sub

    Private Sub TableBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles TableBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.QuoteOrdersDS)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'QuoteOrdersDS.Table' table. You can move, or remove it, as needed.
        Me.TableTableAdapter.Fill(Me.QuoteOrdersDS.Table)

    End Sub

    Private Sub PricingStartedDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles PricingStartedDateTimePicker.ValueChanged

    End Sub

    Private Sub PricingStartedLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PricingCompletedLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PricingCompletedDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles PricingCompletedDateTimePicker.ValueChanged

    End Sub
End Class
