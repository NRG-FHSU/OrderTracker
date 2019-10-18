Imports System.Data.SqlClient

Public Class Form1

    'Private Sub ()
    Dim fieldSearch As Search = New Search()
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
        'TODO: This line of code loads data into the 'QuoteOrdersDS1.Table' table. You can move, or remove it, as needed.
        Me.TableTableAdapter.Fill(Me.QuoteOrdersDS1.Table)
        'TODO: This line of code loads data into the 'QuoteOrdersDS.Table' table. You can move, or remove it, as needed.
        Me.TableTableAdapter.Fill(Me.QuoteOrdersDS.Table)
        TableBindingSource.Sort = "QuoteNo ASC"

        ComboBox1.Items.AddRange({"QuoteNo", "OrderNo", "PONo", "Customer", "Project"})
        ComboBox1.SelectedIndex = 3

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
        'unused
    End Sub

    Private Sub Label_PricingRequired_TextChanged(ByVal send As Object, ByVal e As EventArgs) Handles Label_PricingRequired.TextChanged
        If PO_RecieptDateTimePicker.Text = "NULL" Then
            PO_RecieptDateTimePicker.CustomFormat = " "
            PO_RecieptDateTimePicker.Format = DateTimePickerFormat.Custom
        Else
            '    PO_RecieptDateTimePicker.CustomFormat = ""
            PO_RecieptDateTimePicker.Format = DateTimePickerFormat.Short
        End If
    End Sub

    Private Sub TextBox_Find_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Find.TextChanged
        TableBindingSource.Filter = String.Format("[{0}] LIKE '%{1}%'", fieldSearch.Field, TextBox_Find.Text)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        fieldSearch.setField(ComboBox1.Text)
    End Sub

    Private Sub Button_BackSchedule_Click(sender As Object, e As EventArgs) Handles Button_BackSchedule.Click
        'this needs to back schedule the required dates for each department of the perocess.
    End Sub

    Private Sub Button_LogDatePriceStart_Click(sender As Object, e As EventArgs) Handles Button_LogDatePriceStart.Click
        'log pricing start date here
    End Sub

    Private Sub Button_LogDatePriceComplete_Click(sender As Object, e As EventArgs) Handles Button_LogDatePriceComplete.Click
        'log pricing completion date here
    End Sub

    Private Sub Button_LogDateEngStart_Click(sender As Object, e As EventArgs) Handles Button_LogDateEngStart.Click
        'log eng start date here
    End Sub

    Private Sub Button_LogDateEngComplete_Click(sender As Object, e As EventArgs) Handles Button_LogDateEngComplete.Click
        'log eng completion date here
    End Sub

    Private Sub Button_LogDateDrftStart_Click(sender As Object, e As EventArgs) Handles Button_LogDateDrftStart.Click
        'log drft start date here
    End Sub

    Private Sub Button_LogDateDrftComplete_Click(sender As Object, e As EventArgs) Handles Button_LogDateDrftComplete.Click
        'log drft completion date here
    End Sub

    Private Sub Button_LogDateFabStart_Click(sender As Object, e As EventArgs) Handles Button_LogDateFabStart.Click
        'log fab start date here
    End Sub

    Private Sub Button_LogDateFabComplete_Click(sender As Object, e As EventArgs) Handles Button_LogDateFabComplete.Click
        'log fab completion date here
    End Sub

    Private Sub Button_LogDateFinishStart_Click(sender As Object, e As EventArgs) Handles Button_LogDateFinishStart.Click
        'log finish start date here
    End Sub

    Private Sub Button_LogDateFinishComplete_Click(sender As Object, e As EventArgs) Handles Button_LogDateFinishComplete.Click
        'log finish completion date here
    End Sub

    Private Sub Button_LogDateShipStart_Click(sender As Object, e As EventArgs) Handles Button_LogDateShipStart.Click
        'log ship start date here
    End Sub

    Private Sub Button_LogDateShipComplete_Click(sender As Object, e As EventArgs) Handles Button_LogDateShipComplete.Click
        'log ship completion date here
    End Sub

    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs)

    End Sub
End Class
