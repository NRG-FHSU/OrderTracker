Imports System.Data.SqlClient

Public Class Form1

    'Private Sub ()
    Dim fieldSearch As Search = New Search()
    Dim backschedule As Schedule = New Schedule()
    Dim logging As LogDate = New LogDate()
    'Dim user As String ' = "NRG"
    Private Sub TableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.QuoteOrdersDS)

    End Sub

    Private Sub TableBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles TableBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TableBindingSource.EndEdit()
        On Error Resume Next 'handle for concurrency violation for multiple users that should not be present
        Me.TableAdapterManager.UpdateAll(Me.QuoteOrdersDS)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'QuoteOrdersDS1.Table' table. You can move, or remove it, as needed.
        'Me.TableTableAdapter.Fill(Me.QuoteOrdersDS1.Table)
        'TODO: This line of code loads data into the 'QuoteOrdersDS.Table' table. You can move, or remove it, as needed.
        Me.TableTableAdapter.Fill(Me.QuoteOrdersDS.Table) 'fills the table
        TableBindingSource.Sort = "QuoteNo ASC" 'sorts the table

        ToolStripComboBox_User.Items.AddRange({"NRG", "ABC", "BTN", "CAG", "LBW", "SLP"})
        ToolStripComboBox_User.SelectedIndex = 0

        'user = ToolStripComboBox_User.Text
        logging.setUser(ToolStripComboBox_User.Text)

        ComboBox1.Items.AddRange({"QuoteNo", "OrderNo", "PONo", "Customer", "Project"}) 'populates combo box
        ComboBox1.SelectedIndex = 3 'initiates combo box to Customer

    End Sub

    Private Sub Quote_Due_DateDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles Quote_Due_DateDateTimePicker.ValueChanged
        Quote_Due_DateDateTimePicker.CustomFormat = "MM/dd/yyyy" 'display formatting
        Label_PricingRequired.Text = Quote_Due_DateDateTimePicker.Value.ToString("d")
    End Sub

    Private Sub PO_RecieptDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles PO_RecieptDateTimePicker.ValueChanged
        PO_RecieptDateTimePicker.CustomFormat = "MM/dd/yyyy" 'display formatting
    End Sub

    Private Sub Delivery_DateDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles Delivery_DateDateTimePicker.ValueChanged
        Delivery_DateDateTimePicker.CustomFormat = "MM/dd/yyyy" 'display formatting
    End Sub

    Private Sub Quote_Due_DateDateTimePicker_KeyDown(sender As Object, e As KeyEventArgs) Handles Quote_Due_DateDateTimePicker.KeyDown
        If ((e.KeyCode = Keys.Back) Or (e.KeyCode = Keys.Delete)) Then Quote_Due_DateDateTimePicker.CustomFormat = " " 'display formatting
    End Sub

    Private Sub PO_RecieptDateTimePicker_KeyDown(sender As Object, e As KeyEventArgs) Handles PO_RecieptDateTimePicker.KeyDown
        If ((e.KeyCode = Keys.Back) Or (e.KeyCode = Keys.Delete)) Then PO_RecieptDateTimePicker.CustomFormat = " " 'display formatting
    End Sub

    Private Sub Delivery_DateDateTimePicker_KeyDown(sender As Object, e As KeyEventArgs) Handles Delivery_DateDateTimePicker.KeyDown
        If ((e.KeyCode = Keys.Back) Or (e.KeyCode = Keys.Delete)) Then Delivery_DateDateTimePicker.CustomFormat = " " 'display formatting
    End Sub

    Private Sub Label_PricingRequired_TextChanged(ByVal send As Object, ByVal e As EventArgs) Handles Label_PricingRequired.TextChanged
        If PO_RecieptDateTimePicker.Text = "NULL" Then
            PO_RecieptDateTimePicker.CustomFormat = " "
            PO_RecieptDateTimePicker.Format = DateTimePickerFormat.Custom
        Else
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

        'need to add logic for ship date being within 6 weeks of delivery

        'this needs to back schedule the required dates for each department of the process.
        backschedule.setDelivery(Delivery_DateDateTimePicker.Value.Date)
        Label_EngRequired.Text = backschedule.engDate.ToString("d")
        Label_DrftRequired.Text = backschedule.drftDate.ToString("d")
        Label_FabRequired.Text = backschedule.fabDate.ToString("d")
        Label_FinishRequired.Text = backschedule.finishDate.ToString("d")
        Label_ShipRequired.Text = backschedule.shipDate.ToString("d")
    End Sub

    Private Sub Button_LogDatePriceStart_Click(sender As Object, e As EventArgs) Handles Button_LogDatePriceStart.Click
        'log pricing start date here
        Label_DatePricingStarted.Text = logging.getDate()
        Label_UserPriceStarted.Text = logging.userInitials
    End Sub

    Private Sub Button_LogDatePriceComplete_Click(sender As Object, e As EventArgs) Handles Button_LogDatePriceComplete.Click
        'log pricing completion date here
        Label_DatePricingComplet.Text = logging.getDate()
        Label_UserPriceComplete.Text = logging.userInitials
    End Sub

    Private Sub Button_LogDateEngStart_Click(sender As Object, e As EventArgs) Handles Button_LogDateEngStart.Click
        'log eng start date here
        Label_DateEngStart.Text = logging.getDate()
        Label_UserEngStart.Text = logging.userInitials
    End Sub

    Private Sub Button_LogDateEngComplete_Click(sender As Object, e As EventArgs) Handles Button_LogDateEngComplete.Click
        'log eng completion date here
        Label_DateEngCompleted.Text = logging.getDate()
        Label_UserEngComplete.Text = logging.userInitials
    End Sub

    Private Sub Button_LogDateDrftStart_Click(sender As Object, e As EventArgs) Handles Button_LogDateDrftStart.Click
        'log drft start date here
        Label_DateDrftStart.Text = logging.getDate()
        Label_UserDrftStart.Text = logging.userInitials
    End Sub

    Private Sub Button_LogDateDrftComplete_Click(sender As Object, e As EventArgs) Handles Button_LogDateDrftComplete.Click
        'log drft completion date here
        Label_DateDrftComplete.Text = logging.getDate()
        Label_UserDrftComplete.Text = logging.userInitials
    End Sub

    Private Sub Button_LogDateFabStart_Click(sender As Object, e As EventArgs) Handles Button_LogDateFabStart.Click
        'log fab start date here
        Label_DateFabStarted.Text = logging.getDate()
        Label_UserFabStart.Text = logging.userInitials
    End Sub

    Private Sub Button_LogDateFabComplete_Click(sender As Object, e As EventArgs) Handles Button_LogDateFabComplete.Click
        'log fab completion date here
        Label_DateFabCompleted.Text = logging.getDate()
        Label_UserFabComplete.Text = logging.userInitials
    End Sub

    Private Sub Button_LogDateFinishStart_Click(sender As Object, e As EventArgs) Handles Button_LogDateFinishStart.Click
        'log finish start date here
        Label_DateFinishStart.Text = logging.getDate()
        Label_UserFinishStart.Text = logging.userInitials
    End Sub

    Private Sub Button_LogDateFinishComplete_Click(sender As Object, e As EventArgs) Handles Button_LogDateFinishComplete.Click
        'log finish completion date here
        Label_DateFinishCompleted.Text = logging.getDate()
        Label_UserFinishComplete.Text = logging.userInitials
    End Sub

    Private Sub Button_LogDateShipStart_Click(sender As Object, e As EventArgs) Handles Button_LogDateShipStart.Click
        'log ship start date here
        Label_DateShipStart.Text = logging.getDate()
        Label_UserShipStart.Text = logging.userInitials
    End Sub

    Private Sub Button_LogDateShipComplete_Click(sender As Object, e As EventArgs) Handles Button_LogDateShipComplete.Click
        'log ship completion date here
        Label_DateShipCompleted.Text = logging.getDate()
        Label_UserShipComplete.Text = logging.userInitials
    End Sub

    Private Sub Button_Convert2Order_Click(sender As Object, e As EventArgs) Handles Button_Convert2Order.Click
        'takes quote number, removes the 'Q', and stores the number as an order
        Dim orderNumber As String
        orderNumber = Quote_TextBox.Text.Replace("Q", "")
        Order_TextBox.Text = orderNumber
        TextBox_PoProject.Text = ProjectTextBox.Text
    End Sub

    Private Sub CheckBox_OpenProjects_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_OpenProjects.CheckedChanged
        'This should check for Ship complete. If ship complete is logged it should not show the project as it is closed out.
    End Sub

    Private Sub ToolStripComboBox_User_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ToolStripComboBox_User.SelectedIndexChanged
        logging.setUser(ToolStripComboBox_User.Text)
    End Sub

    Private Sub BindingNavigatorPositionItem_TextChanged(sender As Object, e As EventArgs) Handles BindingNavigatorPositionItem.TextChanged
        'using this function as a check for status of each record (Quote/Order)
    End Sub
End Class
