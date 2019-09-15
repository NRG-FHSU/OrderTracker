Public Class Form1

    'Private Sub ()
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

    Private Sub PricingStartedLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PricingCompletedLabel_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub Quote_Due_DateDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles Quote_Due_DateDateTimePicker.ValueChanged
        Quote_Due_DateDateTimePicker.CustomFormat = "MM/dd/yyyy"
    End Sub

    Private Sub PO_RecieptDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles PO_RecieptDateTimePicker.ValueChanged
        PO_RecieptDateTimePicker.CustomFormat = "MM/dd/yyyy"
    End Sub

    Private Sub Delivery_DateDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles Delivery_DateDateTimePicker.ValueChanged
        Delivery_DateDateTimePicker.CustomFormat = "MM/dd/yyyy"
    End Sub

    'Private Sub PricingRequiredDateTimePicker_ValueChanged(sender As Object, e As EventArgs)
    '    PricingRequiredDateTimePicker.CustomFormat = "MM/dd/yyyy"
    '    'If (PricingRequiredDateTimePicker.Value = DateTime.MinValue) Then PricingRequiredDateTimePicker.Checked = False
    '    'Else (PricingRequiredDateTimePicker.Checked = True) Then PricingRequiredDateTimePicker.Value = value
    'End Sub

    Private Sub Quote_Due_DateDateTimePicker_KeyDown(sender As Object, e As KeyEventArgs) Handles Quote_Due_DateDateTimePicker.KeyDown
        If ((e.KeyCode = Keys.Back) Or (e.KeyCode = Keys.Delete)) Then Quote_Due_DateDateTimePicker.CustomFormat = " "
    End Sub

    Private Sub PO_RecieptDateTimePicker_KeyDown(sender As Object, e As KeyEventArgs) Handles PO_RecieptDateTimePicker.KeyDown
        If ((e.KeyCode = Keys.Back) Or (e.KeyCode = Keys.Delete)) Then PO_RecieptDateTimePicker.CustomFormat = " "
    End Sub

    Private Sub Delivery_DateDateTimePicker_KeyDown(sender As Object, e As KeyEventArgs) Handles Delivery_DateDateTimePicker.KeyDown
        If ((e.KeyCode = Keys.Back) Or (e.KeyCode = Keys.Delete)) Then Delivery_DateDateTimePicker.CustomFormat = " "
    End Sub

    Private Sub Label_PricingRequired_Click(sender As Object, e As EventArgs) Handles Label_PricingRequired.Click

    End Sub

    Private Sub Label_PricingRequired_TextChanged(ByVal send As Object, ByVal e As EventArgs) Handles Label_PricingRequired.TextChanged
        'If PO_RecieptDateTimePicker.Value = "" Then ' .Text = "NULL" Then
        '    PO_RecieptDateTimePicker.CustomFormat = " "
        '    PO_RecieptDateTimePicker.Format = DateTimePickerFormat.Custom
        'Else
        '    PO_RecieptDateTimePicker.CustomFormat = ""
        'PO_RecieptDateTimePicker.Format = DateTimePickerFormat.Short
        'End If
    End Sub
End Class
