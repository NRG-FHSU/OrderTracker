<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Quote_Label As System.Windows.Forms.Label
        Dim Order_Label As System.Windows.Forms.Label
        Dim CustomerLabel As System.Windows.Forms.Label
        Dim ProjectLabel As System.Windows.Forms.Label
        Dim PO_Label As System.Windows.Forms.Label
        Dim PO_RecieptLabel As System.Windows.Forms.Label
        Dim Delivery_DateLabel As System.Windows.Forms.Label
        Dim Quote_Due_DateLabel As System.Windows.Forms.Label
        Dim PricingRequiredLabel As System.Windows.Forms.Label
        Dim PricingStartedLabel As System.Windows.Forms.Label
        Dim PricingCompletedLabel As System.Windows.Forms.Label
        Dim Label12 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim Label13 As System.Windows.Forms.Label
        Dim Label14 As System.Windows.Forms.Label
        Dim Label15 As System.Windows.Forms.Label
        Dim Label16 As System.Windows.Forms.Label
        Dim Label17 As System.Windows.Forms.Label
        Dim Label18 As System.Windows.Forms.Label
        Dim Label19 As System.Windows.Forms.Label
        Dim Label20 As System.Windows.Forms.Label
        Dim Label21 As System.Windows.Forms.Label
        Dim Label22 As System.Windows.Forms.Label
        Dim Label23 As System.Windows.Forms.Label
        Dim Label24 As System.Windows.Forms.Label
        Dim Label25 As System.Windows.Forms.Label
        Dim Label26 As System.Windows.Forms.Label
        Dim Label27 As System.Windows.Forms.Label
        Dim Label28 As System.Windows.Forms.Label
        Dim Label29 As System.Windows.Forms.Label
        Dim Label30 As System.Windows.Forms.Label
        Dim Label31 As System.Windows.Forms.Label
        Dim Label32 As System.Windows.Forms.Label
        Dim Label33 As System.Windows.Forms.Label
        Dim Label34 As System.Windows.Forms.Label
        Dim Label35 As System.Windows.Forms.Label
        Dim Label36 As System.Windows.Forms.Label
        Dim Label37 As System.Windows.Forms.Label
        Dim Label38 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TableDataGridView = New System.Windows.Forms.DataGridView()
        Me.QuoteNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PONo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QuoteOrdersDS = New OrderTracker.QuoteOrdersDS()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBox_ShipActual = New System.Windows.Forms.PictureBox()
        Me.PictureBox_ShipCommit = New System.Windows.Forms.PictureBox()
        Me.PictureBox_EngActual = New System.Windows.Forms.PictureBox()
        Me.PictureBox_EngCommit = New System.Windows.Forms.PictureBox()
        Me.PictureBox_FinishActual = New System.Windows.Forms.PictureBox()
        Me.PictureBox_FinishCommit = New System.Windows.Forms.PictureBox()
        Me.PictureBox_FabActual = New System.Windows.Forms.PictureBox()
        Me.PictureBox_FabCommit = New System.Windows.Forms.PictureBox()
        Me.PictureBox_DrftActual = New System.Windows.Forms.PictureBox()
        Me.PictureBox_DrftCommit = New System.Windows.Forms.PictureBox()
        Me.PictureBox_PriceActual = New System.Windows.Forms.PictureBox()
        Me.PictureBox_PriceCommit = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBox_OpenProjects = New System.Windows.Forms.CheckBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox_Find = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button_OrderReport = New System.Windows.Forms.Button()
        Me.Button_QuoteReport = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.Label_UserShipComplete = New System.Windows.Forms.Label()
        Me.Button_LogDateShipComplete = New System.Windows.Forms.Button()
        Me.Label_UserShipStart = New System.Windows.Forms.Label()
        Me.Label_ShipRequired = New System.Windows.Forms.Label()
        Me.Button_LogDateShipStart = New System.Windows.Forms.Button()
        Me.Label_DateShipCompleted = New System.Windows.Forms.Label()
        Me.Label_DateShipStart = New System.Windows.Forms.Label()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.Label_UserDrftComplete = New System.Windows.Forms.Label()
        Me.Button_LogDateDrftComplete = New System.Windows.Forms.Button()
        Me.Label_UserDrftStart = New System.Windows.Forms.Label()
        Me.Label_DateDrftComplete = New System.Windows.Forms.Label()
        Me.Button_LogDateDrftStart = New System.Windows.Forms.Button()
        Me.Label_DateDrftStart = New System.Windows.Forms.Label()
        Me.Label_DrftRequired = New System.Windows.Forms.Label()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.Label_UserFinishComplete = New System.Windows.Forms.Label()
        Me.Button_LogDateFinishComplete = New System.Windows.Forms.Button()
        Me.Label_UserFinishStart = New System.Windows.Forms.Label()
        Me.Label_FinishRequired = New System.Windows.Forms.Label()
        Me.Button_LogDateFinishStart = New System.Windows.Forms.Button()
        Me.Label_DateFinishCompleted = New System.Windows.Forms.Label()
        Me.Label_DateFinishStart = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Label_UserEngComplete = New System.Windows.Forms.Label()
        Me.Button_LogDateEngComplete = New System.Windows.Forms.Button()
        Me.Label_UserEngStart = New System.Windows.Forms.Label()
        Me.Label_EngRequired = New System.Windows.Forms.Label()
        Me.Button_LogDateEngStart = New System.Windows.Forms.Button()
        Me.Label_DateEngCompleted = New System.Windows.Forms.Label()
        Me.Label_DateEngStart = New System.Windows.Forms.Label()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.Label_UserFabComplete = New System.Windows.Forms.Label()
        Me.Button_LogDateFabComplete = New System.Windows.Forms.Button()
        Me.Label_UserFabStart = New System.Windows.Forms.Label()
        Me.Label_DateFabCompleted = New System.Windows.Forms.Label()
        Me.Button_LogDateFabStart = New System.Windows.Forms.Button()
        Me.Label_FabRequired = New System.Windows.Forms.Label()
        Me.Label_DateFabStarted = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label_UserPriceComplete = New System.Windows.Forms.Label()
        Me.Label_UserPriceStarted = New System.Windows.Forms.Label()
        Me.Button_LogDatePriceComplete = New System.Windows.Forms.Button()
        Me.Button_LogDatePriceStart = New System.Windows.Forms.Button()
        Me.Label_DatePricingComplet = New System.Windows.Forms.Label()
        Me.Label_DatePricingStarted = New System.Windows.Forms.Label()
        Me.Label_PricingRequired = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Button_BackSchedule = New System.Windows.Forms.Button()
        Me.Delivery_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.PO_RecieptDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.PO_TextBox = New System.Windows.Forms.TextBox()
        Me.TextBox_PoProject = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button_Convert2Order = New System.Windows.Forms.Button()
        Me.ProjectTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerTextBox = New System.Windows.Forms.TextBox()
        Me.Order_TextBox = New System.Windows.Forms.TextBox()
        Me.Quote_TextBox = New System.Windows.Forms.TextBox()
        Me.Quote_Due_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TableBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TableBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripComboBox_User = New System.Windows.Forms.ToolStripComboBox()
        Me.TableTableAdapter = New OrderTracker.QuoteOrdersDSTableAdapters.TableTableAdapter()
        Me.TableAdapterManager = New OrderTracker.QuoteOrdersDSTableAdapters.TableAdapterManager()
        Me.QuoteOrdersDS1 = New OrderTracker.QuoteOrdersDS()
        Quote_Label = New System.Windows.Forms.Label()
        Order_Label = New System.Windows.Forms.Label()
        CustomerLabel = New System.Windows.Forms.Label()
        ProjectLabel = New System.Windows.Forms.Label()
        PO_Label = New System.Windows.Forms.Label()
        PO_RecieptLabel = New System.Windows.Forms.Label()
        Delivery_DateLabel = New System.Windows.Forms.Label()
        Quote_Due_DateLabel = New System.Windows.Forms.Label()
        PricingRequiredLabel = New System.Windows.Forms.Label()
        PricingStartedLabel = New System.Windows.Forms.Label()
        PricingCompletedLabel = New System.Windows.Forms.Label()
        Label12 = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        Label13 = New System.Windows.Forms.Label()
        Label14 = New System.Windows.Forms.Label()
        Label15 = New System.Windows.Forms.Label()
        Label16 = New System.Windows.Forms.Label()
        Label17 = New System.Windows.Forms.Label()
        Label18 = New System.Windows.Forms.Label()
        Label19 = New System.Windows.Forms.Label()
        Label20 = New System.Windows.Forms.Label()
        Label21 = New System.Windows.Forms.Label()
        Label22 = New System.Windows.Forms.Label()
        Label23 = New System.Windows.Forms.Label()
        Label24 = New System.Windows.Forms.Label()
        Label25 = New System.Windows.Forms.Label()
        Label26 = New System.Windows.Forms.Label()
        Label27 = New System.Windows.Forms.Label()
        Label28 = New System.Windows.Forms.Label()
        Label29 = New System.Windows.Forms.Label()
        Label30 = New System.Windows.Forms.Label()
        Label31 = New System.Windows.Forms.Label()
        Label32 = New System.Windows.Forms.Label()
        Label33 = New System.Windows.Forms.Label()
        Label34 = New System.Windows.Forms.Label()
        Label35 = New System.Windows.Forms.Label()
        Label36 = New System.Windows.Forms.Label()
        Label37 = New System.Windows.Forms.Label()
        Label38 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.TableDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuoteOrdersDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox_ShipActual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_ShipCommit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_EngActual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_EngCommit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_FinishActual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_FinishCommit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_FabActual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_FabCommit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_DrftActual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_DrftCommit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_PriceActual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_PriceCommit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.TableBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableBindingNavigator.SuspendLayout()
        CType(Me.QuoteOrdersDS1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Quote_Label
        '
        Quote_Label.AutoSize = True
        Quote_Label.Location = New System.Drawing.Point(17, 22)
        Quote_Label.Name = "Quote_Label"
        Quote_Label.Size = New System.Drawing.Size(56, 13)
        Quote_Label.TabIndex = 2
        Quote_Label.Text = "Quote No:"
        '
        'Order_Label
        '
        Order_Label.AutoSize = True
        Order_Label.Location = New System.Drawing.Point(141, 22)
        Order_Label.Name = "Order_Label"
        Order_Label.Size = New System.Drawing.Size(53, 13)
        Order_Label.TabIndex = 4
        Order_Label.Text = "Order No:"
        '
        'CustomerLabel
        '
        CustomerLabel.AutoSize = True
        CustomerLabel.Location = New System.Drawing.Point(19, 48)
        CustomerLabel.Name = "CustomerLabel"
        CustomerLabel.Size = New System.Drawing.Size(54, 13)
        CustomerLabel.TabIndex = 6
        CustomerLabel.Text = "Customer:"
        '
        'ProjectLabel
        '
        ProjectLabel.AutoSize = True
        ProjectLabel.Location = New System.Drawing.Point(30, 74)
        ProjectLabel.Name = "ProjectLabel"
        ProjectLabel.Size = New System.Drawing.Size(43, 13)
        ProjectLabel.TabIndex = 8
        ProjectLabel.Text = "Project:"
        '
        'PO_Label
        '
        PO_Label.AutoSize = True
        PO_Label.Location = New System.Drawing.Point(37, 22)
        PO_Label.Name = "PO_Label"
        PO_Label.Size = New System.Drawing.Size(42, 13)
        PO_Label.TabIndex = 10
        PO_Label.Text = "PO No:"
        '
        'PO_RecieptLabel
        '
        PO_RecieptLabel.AutoSize = True
        PO_RecieptLabel.Location = New System.Drawing.Point(14, 48)
        PO_RecieptLabel.Name = "PO_RecieptLabel"
        PO_RecieptLabel.Size = New System.Drawing.Size(65, 13)
        PO_RecieptLabel.TabIndex = 12
        PO_RecieptLabel.Text = "PO Reciept:"
        '
        'Delivery_DateLabel
        '
        Delivery_DateLabel.AutoSize = True
        Delivery_DateLabel.Location = New System.Drawing.Point(5, 99)
        Delivery_DateLabel.Name = "Delivery_DateLabel"
        Delivery_DateLabel.Size = New System.Drawing.Size(74, 13)
        Delivery_DateLabel.TabIndex = 14
        Delivery_DateLabel.Text = "Delivery Date:"
        '
        'Quote_Due_DateLabel
        '
        Quote_Due_DateLabel.AutoSize = True
        Quote_Due_DateLabel.Location = New System.Drawing.Point(11, 100)
        Quote_Due_DateLabel.Name = "Quote_Due_DateLabel"
        Quote_Due_DateLabel.Size = New System.Drawing.Size(62, 13)
        Quote_Due_DateLabel.TabIndex = 16
        Quote_Due_DateLabel.Text = "Quote Due:"
        '
        'PricingRequiredLabel
        '
        PricingRequiredLabel.AutoSize = True
        PricingRequiredLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PricingRequiredLabel.Location = New System.Drawing.Point(6, 25)
        PricingRequiredLabel.Name = "PricingRequiredLabel"
        PricingRequiredLabel.Size = New System.Drawing.Size(62, 13)
        PricingRequiredLabel.TabIndex = 18
        PricingRequiredLabel.Text = "Required:"
        '
        'PricingStartedLabel
        '
        PricingStartedLabel.AutoSize = True
        PricingStartedLabel.Location = New System.Drawing.Point(23, 75)
        PricingStartedLabel.Name = "PricingStartedLabel"
        PricingStartedLabel.Size = New System.Drawing.Size(44, 13)
        PricingStartedLabel.TabIndex = 20
        PricingStartedLabel.Text = "Started:"
        '
        'PricingCompletedLabel
        '
        PricingCompletedLabel.AutoSize = True
        PricingCompletedLabel.Location = New System.Drawing.Point(13, 101)
        PricingCompletedLabel.Name = "PricingCompletedLabel"
        PricingCompletedLabel.Size = New System.Drawing.Size(54, 13)
        PricingCompletedLabel.TabIndex = 22
        PricingCompletedLabel.Text = "Complete:"
        '
        'Label12
        '
        Label12.AutoSize = True
        Label12.Location = New System.Drawing.Point(36, 74)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(43, 13)
        Label12.TabIndex = 8
        Label12.Text = "Project:"
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label11.Location = New System.Drawing.Point(86, 53)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(43, 13)
        Label11.TabIndex = 20
        Label11.Text = "Actual"
        '
        'Label13
        '
        Label13.AutoSize = True
        Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label13.Location = New System.Drawing.Point(155, 53)
        Label13.Name = "Label13"
        Label13.Size = New System.Drawing.Size(33, 13)
        Label13.TabIndex = 21
        Label13.Text = "User"
        '
        'Label14
        '
        Label14.AutoSize = True
        Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label14.Location = New System.Drawing.Point(155, 53)
        Label14.Name = "Label14"
        Label14.Size = New System.Drawing.Size(33, 13)
        Label14.TabIndex = 21
        Label14.Text = "User"
        '
        'Label15
        '
        Label15.AutoSize = True
        Label15.Location = New System.Drawing.Point(23, 75)
        Label15.Name = "Label15"
        Label15.Size = New System.Drawing.Size(44, 13)
        Label15.TabIndex = 20
        Label15.Text = "Started:"
        '
        'Label16
        '
        Label16.AutoSize = True
        Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label16.Location = New System.Drawing.Point(86, 53)
        Label16.Name = "Label16"
        Label16.Size = New System.Drawing.Size(43, 13)
        Label16.TabIndex = 20
        Label16.Text = "Actual"
        '
        'Label17
        '
        Label17.AutoSize = True
        Label17.Location = New System.Drawing.Point(13, 101)
        Label17.Name = "Label17"
        Label17.Size = New System.Drawing.Size(54, 13)
        Label17.TabIndex = 22
        Label17.Text = "Complete:"
        '
        'Label18
        '
        Label18.AutoSize = True
        Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label18.Location = New System.Drawing.Point(6, 25)
        Label18.Name = "Label18"
        Label18.Size = New System.Drawing.Size(62, 13)
        Label18.TabIndex = 18
        Label18.Text = "Required:"
        '
        'Label19
        '
        Label19.AutoSize = True
        Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label19.Location = New System.Drawing.Point(155, 53)
        Label19.Name = "Label19"
        Label19.Size = New System.Drawing.Size(33, 13)
        Label19.TabIndex = 21
        Label19.Text = "User"
        '
        'Label20
        '
        Label20.AutoSize = True
        Label20.Location = New System.Drawing.Point(23, 75)
        Label20.Name = "Label20"
        Label20.Size = New System.Drawing.Size(44, 13)
        Label20.TabIndex = 20
        Label20.Text = "Started:"
        '
        'Label21
        '
        Label21.AutoSize = True
        Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label21.Location = New System.Drawing.Point(84, 53)
        Label21.Name = "Label21"
        Label21.Size = New System.Drawing.Size(43, 13)
        Label21.TabIndex = 20
        Label21.Text = "Actual"
        '
        'Label22
        '
        Label22.AutoSize = True
        Label22.Location = New System.Drawing.Point(13, 101)
        Label22.Name = "Label22"
        Label22.Size = New System.Drawing.Size(54, 13)
        Label22.TabIndex = 22
        Label22.Text = "Complete:"
        '
        'Label23
        '
        Label23.AutoSize = True
        Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label23.Location = New System.Drawing.Point(6, 25)
        Label23.Name = "Label23"
        Label23.Size = New System.Drawing.Size(62, 13)
        Label23.TabIndex = 18
        Label23.Text = "Required:"
        '
        'Label24
        '
        Label24.AutoSize = True
        Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label24.Location = New System.Drawing.Point(155, 53)
        Label24.Name = "Label24"
        Label24.Size = New System.Drawing.Size(33, 13)
        Label24.TabIndex = 21
        Label24.Text = "User"
        '
        'Label25
        '
        Label25.AutoSize = True
        Label25.Location = New System.Drawing.Point(23, 75)
        Label25.Name = "Label25"
        Label25.Size = New System.Drawing.Size(44, 13)
        Label25.TabIndex = 20
        Label25.Text = "Started:"
        '
        'Label26
        '
        Label26.AutoSize = True
        Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label26.Location = New System.Drawing.Point(86, 53)
        Label26.Name = "Label26"
        Label26.Size = New System.Drawing.Size(43, 13)
        Label26.TabIndex = 20
        Label26.Text = "Actual"
        '
        'Label27
        '
        Label27.AutoSize = True
        Label27.Location = New System.Drawing.Point(13, 101)
        Label27.Name = "Label27"
        Label27.Size = New System.Drawing.Size(54, 13)
        Label27.TabIndex = 22
        Label27.Text = "Complete:"
        '
        'Label28
        '
        Label28.AutoSize = True
        Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label28.Location = New System.Drawing.Point(6, 25)
        Label28.Name = "Label28"
        Label28.Size = New System.Drawing.Size(62, 13)
        Label28.TabIndex = 18
        Label28.Text = "Required:"
        '
        'Label29
        '
        Label29.AutoSize = True
        Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label29.Location = New System.Drawing.Point(155, 53)
        Label29.Name = "Label29"
        Label29.Size = New System.Drawing.Size(33, 13)
        Label29.TabIndex = 21
        Label29.Text = "User"
        '
        'Label30
        '
        Label30.AutoSize = True
        Label30.Location = New System.Drawing.Point(23, 75)
        Label30.Name = "Label30"
        Label30.Size = New System.Drawing.Size(44, 13)
        Label30.TabIndex = 20
        Label30.Text = "Started:"
        '
        'Label31
        '
        Label31.AutoSize = True
        Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label31.Location = New System.Drawing.Point(86, 53)
        Label31.Name = "Label31"
        Label31.Size = New System.Drawing.Size(43, 13)
        Label31.TabIndex = 20
        Label31.Text = "Actual"
        '
        'Label32
        '
        Label32.AutoSize = True
        Label32.Location = New System.Drawing.Point(13, 101)
        Label32.Name = "Label32"
        Label32.Size = New System.Drawing.Size(54, 13)
        Label32.TabIndex = 22
        Label32.Text = "Complete:"
        '
        'Label33
        '
        Label33.AutoSize = True
        Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label33.Location = New System.Drawing.Point(6, 25)
        Label33.Name = "Label33"
        Label33.Size = New System.Drawing.Size(62, 13)
        Label33.TabIndex = 18
        Label33.Text = "Required:"
        '
        'Label34
        '
        Label34.AutoSize = True
        Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label34.Location = New System.Drawing.Point(155, 53)
        Label34.Name = "Label34"
        Label34.Size = New System.Drawing.Size(33, 13)
        Label34.TabIndex = 21
        Label34.Text = "User"
        '
        'Label35
        '
        Label35.AutoSize = True
        Label35.Location = New System.Drawing.Point(23, 75)
        Label35.Name = "Label35"
        Label35.Size = New System.Drawing.Size(44, 13)
        Label35.TabIndex = 20
        Label35.Text = "Started:"
        '
        'Label36
        '
        Label36.AutoSize = True
        Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label36.Location = New System.Drawing.Point(86, 53)
        Label36.Name = "Label36"
        Label36.Size = New System.Drawing.Size(43, 13)
        Label36.TabIndex = 20
        Label36.Text = "Actual"
        '
        'Label37
        '
        Label37.AutoSize = True
        Label37.Location = New System.Drawing.Point(13, 101)
        Label37.Name = "Label37"
        Label37.Size = New System.Drawing.Size(54, 13)
        Label37.TabIndex = 22
        Label37.Text = "Complete:"
        '
        'Label38
        '
        Label38.AutoSize = True
        Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label38.Location = New System.Drawing.Point(6, 25)
        Label38.Name = "Label38"
        Label38.Size = New System.Drawing.Size(62, 13)
        Label38.TabIndex = 18
        Label38.Text = "Required:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, 28)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(803, 502)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TableDataGridView)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(795, 476)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Main"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TableDataGridView
        '
        Me.TableDataGridView.AutoGenerateColumns = False
        Me.TableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TableDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.QuoteNo, Me.DataGridViewTextBoxColumn9, Me.OrderNo, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn8, Me.PONo})
        Me.TableDataGridView.DataSource = Me.TableBindingSource
        Me.TableDataGridView.Location = New System.Drawing.Point(8, 102)
        Me.TableDataGridView.Name = "TableDataGridView"
        Me.TableDataGridView.Size = New System.Drawing.Size(781, 374)
        Me.TableDataGridView.TabIndex = 5
        '
        'QuoteNo
        '
        Me.QuoteNo.DataPropertyName = "QuoteNo"
        Me.QuoteNo.HeaderText = "Quote No"
        Me.QuoteNo.Name = "QuoteNo"
        Me.QuoteNo.Width = 75
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Quote Due Date"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Quote Due Date"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 108
        '
        'OrderNo
        '
        Me.OrderNo.DataPropertyName = "OrderNo"
        Me.OrderNo.HeaderText = "Order No"
        Me.OrderNo.Name = "OrderNo"
        Me.OrderNo.Width = 75
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Customer"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Customer"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Project"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Project"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 150
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Delivery Date"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Delivery Date"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'PONo
        '
        Me.PONo.DataPropertyName = "PONo"
        Me.PONo.HeaderText = "PO No"
        Me.PONo.Name = "PONo"
        Me.PONo.Width = 105
        '
        'TableBindingSource
        '
        Me.TableBindingSource.DataMember = "Table"
        Me.TableBindingSource.DataSource = Me.QuoteOrdersDS
        '
        'QuoteOrdersDS
        '
        Me.QuoteOrdersDS.DataSetName = "QuoteOrdersDS"
        Me.QuoteOrdersDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PictureBox_ShipActual)
        Me.GroupBox2.Controls.Add(Me.PictureBox_ShipCommit)
        Me.GroupBox2.Controls.Add(Me.PictureBox_EngActual)
        Me.GroupBox2.Controls.Add(Me.PictureBox_EngCommit)
        Me.GroupBox2.Controls.Add(Me.PictureBox_FinishActual)
        Me.GroupBox2.Controls.Add(Me.PictureBox_FinishCommit)
        Me.GroupBox2.Controls.Add(Me.PictureBox_FabActual)
        Me.GroupBox2.Controls.Add(Me.PictureBox_FabCommit)
        Me.GroupBox2.Controls.Add(Me.PictureBox_DrftActual)
        Me.GroupBox2.Controls.Add(Me.PictureBox_DrftCommit)
        Me.GroupBox2.Controls.Add(Me.PictureBox_PriceActual)
        Me.GroupBox2.Controls.Add(Me.PictureBox_PriceCommit)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(414, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(375, 90)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Status"
        '
        'PictureBox_ShipActual
        '
        Me.PictureBox_ShipActual.Image = CType(resources.GetObject("PictureBox_ShipActual.Image"), System.Drawing.Image)
        Me.PictureBox_ShipActual.Location = New System.Drawing.Point(320, 60)
        Me.PictureBox_ShipActual.Name = "PictureBox_ShipActual"
        Me.PictureBox_ShipActual.Size = New System.Drawing.Size(31, 22)
        Me.PictureBox_ShipActual.TabIndex = 19
        Me.PictureBox_ShipActual.TabStop = False
        '
        'PictureBox_ShipCommit
        '
        Me.PictureBox_ShipCommit.Image = Global.OrderTracker.My.Resources.Resources.greenSquare
        Me.PictureBox_ShipCommit.Location = New System.Drawing.Point(320, 32)
        Me.PictureBox_ShipCommit.Name = "PictureBox_ShipCommit"
        Me.PictureBox_ShipCommit.Size = New System.Drawing.Size(31, 22)
        Me.PictureBox_ShipCommit.TabIndex = 18
        Me.PictureBox_ShipCommit.TabStop = False
        '
        'PictureBox_EngActual
        '
        Me.PictureBox_EngActual.Image = CType(resources.GetObject("PictureBox_EngActual.Image"), System.Drawing.Image)
        Me.PictureBox_EngActual.Location = New System.Drawing.Point(120, 60)
        Me.PictureBox_EngActual.Name = "PictureBox_EngActual"
        Me.PictureBox_EngActual.Size = New System.Drawing.Size(31, 22)
        Me.PictureBox_EngActual.TabIndex = 17
        Me.PictureBox_EngActual.TabStop = False
        '
        'PictureBox_EngCommit
        '
        Me.PictureBox_EngCommit.Image = Global.OrderTracker.My.Resources.Resources.greenSquare
        Me.PictureBox_EngCommit.Location = New System.Drawing.Point(120, 32)
        Me.PictureBox_EngCommit.Name = "PictureBox_EngCommit"
        Me.PictureBox_EngCommit.Size = New System.Drawing.Size(31, 22)
        Me.PictureBox_EngCommit.TabIndex = 16
        Me.PictureBox_EngCommit.TabStop = False
        '
        'PictureBox_FinishActual
        '
        Me.PictureBox_FinishActual.Image = CType(resources.GetObject("PictureBox_FinishActual.Image"), System.Drawing.Image)
        Me.PictureBox_FinishActual.Location = New System.Drawing.Point(270, 60)
        Me.PictureBox_FinishActual.Name = "PictureBox_FinishActual"
        Me.PictureBox_FinishActual.Size = New System.Drawing.Size(31, 22)
        Me.PictureBox_FinishActual.TabIndex = 15
        Me.PictureBox_FinishActual.TabStop = False
        '
        'PictureBox_FinishCommit
        '
        Me.PictureBox_FinishCommit.Image = Global.OrderTracker.My.Resources.Resources.greenSquare
        Me.PictureBox_FinishCommit.Location = New System.Drawing.Point(270, 32)
        Me.PictureBox_FinishCommit.Name = "PictureBox_FinishCommit"
        Me.PictureBox_FinishCommit.Size = New System.Drawing.Size(31, 22)
        Me.PictureBox_FinishCommit.TabIndex = 14
        Me.PictureBox_FinishCommit.TabStop = False
        '
        'PictureBox_FabActual
        '
        Me.PictureBox_FabActual.Image = CType(resources.GetObject("PictureBox_FabActual.Image"), System.Drawing.Image)
        Me.PictureBox_FabActual.Location = New System.Drawing.Point(219, 60)
        Me.PictureBox_FabActual.Name = "PictureBox_FabActual"
        Me.PictureBox_FabActual.Size = New System.Drawing.Size(31, 22)
        Me.PictureBox_FabActual.TabIndex = 13
        Me.PictureBox_FabActual.TabStop = False
        '
        'PictureBox_FabCommit
        '
        Me.PictureBox_FabCommit.Image = Global.OrderTracker.My.Resources.Resources.greenSquare
        Me.PictureBox_FabCommit.Location = New System.Drawing.Point(219, 32)
        Me.PictureBox_FabCommit.Name = "PictureBox_FabCommit"
        Me.PictureBox_FabCommit.Size = New System.Drawing.Size(31, 22)
        Me.PictureBox_FabCommit.TabIndex = 12
        Me.PictureBox_FabCommit.TabStop = False
        '
        'PictureBox_DrftActual
        '
        Me.PictureBox_DrftActual.Image = CType(resources.GetObject("PictureBox_DrftActual.Image"), System.Drawing.Image)
        Me.PictureBox_DrftActual.Location = New System.Drawing.Point(169, 60)
        Me.PictureBox_DrftActual.Name = "PictureBox_DrftActual"
        Me.PictureBox_DrftActual.Size = New System.Drawing.Size(31, 22)
        Me.PictureBox_DrftActual.TabIndex = 11
        Me.PictureBox_DrftActual.TabStop = False
        '
        'PictureBox_DrftCommit
        '
        Me.PictureBox_DrftCommit.Image = Global.OrderTracker.My.Resources.Resources.greenSquare
        Me.PictureBox_DrftCommit.Location = New System.Drawing.Point(169, 32)
        Me.PictureBox_DrftCommit.Name = "PictureBox_DrftCommit"
        Me.PictureBox_DrftCommit.Size = New System.Drawing.Size(31, 22)
        Me.PictureBox_DrftCommit.TabIndex = 10
        Me.PictureBox_DrftCommit.TabStop = False
        '
        'PictureBox_PriceActual
        '
        Me.PictureBox_PriceActual.Image = Global.OrderTracker.My.Resources.Resources.yellowSquare
        Me.PictureBox_PriceActual.Location = New System.Drawing.Point(71, 60)
        Me.PictureBox_PriceActual.Name = "PictureBox_PriceActual"
        Me.PictureBox_PriceActual.Size = New System.Drawing.Size(31, 22)
        Me.PictureBox_PriceActual.TabIndex = 9
        Me.PictureBox_PriceActual.TabStop = False
        '
        'PictureBox_PriceCommit
        '
        Me.PictureBox_PriceCommit.Image = Global.OrderTracker.My.Resources.Resources.greenSquare
        Me.PictureBox_PriceCommit.InitialImage = Nothing
        Me.PictureBox_PriceCommit.Location = New System.Drawing.Point(71, 32)
        Me.PictureBox_PriceCommit.Name = "PictureBox_PriceCommit"
        Me.PictureBox_PriceCommit.Size = New System.Drawing.Size(31, 22)
        Me.PictureBox_PriceCommit.TabIndex = 8
        Me.PictureBox_PriceCommit.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(323, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(28, 13)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Ship"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(267, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Finish"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(222, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(25, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Fab"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(172, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(24, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Drft"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(122, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Eng"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(71, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Price"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Actual:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Committed:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBox_OpenProjects)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox_Find)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(402, 90)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search"
        '
        'CheckBox_OpenProjects
        '
        Me.CheckBox_OpenProjects.AutoSize = True
        Me.CheckBox_OpenProjects.Location = New System.Drawing.Point(42, 62)
        Me.CheckBox_OpenProjects.Name = "CheckBox_OpenProjects"
        Me.CheckBox_OpenProjects.Size = New System.Drawing.Size(117, 17)
        Me.CheckBox_OpenProjects.TabIndex = 4
        Me.CheckBox_OpenProjects.Text = "Open Projects Only"
        Me.CheckBox_OpenProjects.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.AllowDrop = True
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ComboBox1.Location = New System.Drawing.Point(237, 26)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(151, 21)
        Me.ComboBox1.TabIndex = 3
        '
        'TextBox_Find
        '
        Me.TextBox_Find.Location = New System.Drawing.Point(42, 27)
        Me.TextBox_Find.Name = "TextBox_Find"
        Me.TextBox_Find.Size = New System.Drawing.Size(151, 20)
        Me.TextBox_Find.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(199, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Field:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Find:"
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Me.Button_OrderReport)
        Me.TabPage2.Controls.Add(Me.Button_QuoteReport)
        Me.TabPage2.Controls.Add(Me.GroupBox5)
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(795, 476)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Quote/Order"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button_OrderReport
        '
        Me.Button_OrderReport.Location = New System.Drawing.Point(542, 95)
        Me.Button_OrderReport.Name = "Button_OrderReport"
        Me.Button_OrderReport.Size = New System.Drawing.Size(243, 72)
        Me.Button_OrderReport.TabIndex = 58
        Me.Button_OrderReport.Text = "Order Report"
        Me.Button_OrderReport.UseVisualStyleBackColor = True
        '
        'Button_QuoteReport
        '
        Me.Button_QuoteReport.Location = New System.Drawing.Point(542, 12)
        Me.Button_QuoteReport.Name = "Button_QuoteReport"
        Me.Button_QuoteReport.Size = New System.Drawing.Size(243, 72)
        Me.Button_QuoteReport.TabIndex = 57
        Me.Button_QuoteReport.Text = "Quote Report"
        Me.Button_QuoteReport.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.GroupBox9)
        Me.GroupBox5.Controls.Add(Me.GroupBox8)
        Me.GroupBox5.Controls.Add(Me.GroupBox10)
        Me.GroupBox5.Controls.Add(Me.GroupBox7)
        Me.GroupBox5.Controls.Add(Me.GroupBox11)
        Me.GroupBox5.Controls.Add(Me.GroupBox6)
        Me.GroupBox5.Location = New System.Drawing.Point(8, 173)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(784, 297)
        Me.GroupBox5.TabIndex = 56
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Schedule"
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.Label_UserShipComplete)
        Me.GroupBox9.Controls.Add(Me.Button_LogDateShipComplete)
        Me.GroupBox9.Controls.Add(Me.Label_UserShipStart)
        Me.GroupBox9.Controls.Add(Me.Label_ShipRequired)
        Me.GroupBox9.Controls.Add(Me.Button_LogDateShipStart)
        Me.GroupBox9.Controls.Add(Label24)
        Me.GroupBox9.Controls.Add(Label25)
        Me.GroupBox9.Controls.Add(Label26)
        Me.GroupBox9.Controls.Add(Label27)
        Me.GroupBox9.Controls.Add(Label28)
        Me.GroupBox9.Controls.Add(Me.Label_DateShipCompleted)
        Me.GroupBox9.Controls.Add(Me.Label_DateShipStart)
        Me.GroupBox9.Location = New System.Drawing.Point(524, 158)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(253, 133)
        Me.GroupBox9.TabIndex = 35
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Shipping"
        '
        'Label_UserShipComplete
        '
        Me.Label_UserShipComplete.AutoSize = True
        Me.Label_UserShipComplete.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "UserShipComplete", True))
        Me.Label_UserShipComplete.Location = New System.Drawing.Point(156, 101)
        Me.Label_UserShipComplete.Name = "Label_UserShipComplete"
        Me.Label_UserShipComplete.Size = New System.Drawing.Size(57, 13)
        Me.Label_UserShipComplete.TabIndex = 48
        Me.Label_UserShipComplete.Text = "UserShipC"
        '
        'Button_LogDateShipComplete
        '
        Me.Button_LogDateShipComplete.Location = New System.Drawing.Point(207, 95)
        Me.Button_LogDateShipComplete.Name = "Button_LogDateShipComplete"
        Me.Button_LogDateShipComplete.Size = New System.Drawing.Size(40, 24)
        Me.Button_LogDateShipComplete.TabIndex = 46
        Me.Button_LogDateShipComplete.Text = "Log"
        Me.Button_LogDateShipComplete.UseVisualStyleBackColor = True
        '
        'Label_UserShipStart
        '
        Me.Label_UserShipStart.AutoSize = True
        Me.Label_UserShipStart.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "UserShipStart", True))
        Me.Label_UserShipStart.Location = New System.Drawing.Point(156, 75)
        Me.Label_UserShipStart.Name = "Label_UserShipStart"
        Me.Label_UserShipStart.Size = New System.Drawing.Size(57, 13)
        Me.Label_UserShipStart.TabIndex = 47
        Me.Label_UserShipStart.Text = "UserShipS"
        '
        'Label_ShipRequired
        '
        Me.Label_ShipRequired.AutoSize = True
        Me.Label_ShipRequired.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "ShipRequired", True))
        Me.Label_ShipRequired.Location = New System.Drawing.Point(74, 25)
        Me.Label_ShipRequired.Name = "Label_ShipRequired"
        Me.Label_ShipRequired.Size = New System.Drawing.Size(45, 13)
        Me.Label_ShipRequired.TabIndex = 41
        Me.Label_ShipRequired.Text = "DateSR"
        '
        'Button_LogDateShipStart
        '
        Me.Button_LogDateShipStart.Location = New System.Drawing.Point(207, 69)
        Me.Button_LogDateShipStart.Name = "Button_LogDateShipStart"
        Me.Button_LogDateShipStart.Size = New System.Drawing.Size(40, 24)
        Me.Button_LogDateShipStart.TabIndex = 45
        Me.Button_LogDateShipStart.Text = "Log"
        Me.Button_LogDateShipStart.UseVisualStyleBackColor = True
        '
        'Label_DateShipCompleted
        '
        Me.Label_DateShipCompleted.AutoSize = True
        Me.Label_DateShipCompleted.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "ShipCompleted", True))
        Me.Label_DateShipCompleted.Location = New System.Drawing.Point(74, 101)
        Me.Label_DateShipCompleted.Name = "Label_DateShipCompleted"
        Me.Label_DateShipCompleted.Size = New System.Drawing.Size(58, 13)
        Me.Label_DateShipCompleted.TabIndex = 48
        Me.Label_DateShipCompleted.Text = "DateShipC"
        '
        'Label_DateShipStart
        '
        Me.Label_DateShipStart.AutoSize = True
        Me.Label_DateShipStart.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "ShipStarted", True))
        Me.Label_DateShipStart.Location = New System.Drawing.Point(74, 75)
        Me.Label_DateShipStart.Name = "Label_DateShipStart"
        Me.Label_DateShipStart.Size = New System.Drawing.Size(58, 13)
        Me.Label_DateShipStart.TabIndex = 47
        Me.Label_DateShipStart.Text = "DateShipS"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.Label_UserDrftComplete)
        Me.GroupBox8.Controls.Add(Me.Button_LogDateDrftComplete)
        Me.GroupBox8.Controls.Add(Me.Label_UserDrftStart)
        Me.GroupBox8.Controls.Add(Me.Label_DateDrftComplete)
        Me.GroupBox8.Controls.Add(Me.Button_LogDateDrftStart)
        Me.GroupBox8.Controls.Add(Me.Label_DateDrftStart)
        Me.GroupBox8.Controls.Add(Me.Label_DrftRequired)
        Me.GroupBox8.Controls.Add(Label19)
        Me.GroupBox8.Controls.Add(Label20)
        Me.GroupBox8.Controls.Add(Label21)
        Me.GroupBox8.Controls.Add(Label22)
        Me.GroupBox8.Controls.Add(Label23)
        Me.GroupBox8.Location = New System.Drawing.Point(524, 19)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(253, 133)
        Me.GroupBox8.TabIndex = 32
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Drafting"
        '
        'Label_UserDrftComplete
        '
        Me.Label_UserDrftComplete.AutoSize = True
        Me.Label_UserDrftComplete.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "UserDrftComplete", True))
        Me.Label_UserDrftComplete.Location = New System.Drawing.Point(156, 101)
        Me.Label_UserDrftComplete.Name = "Label_UserDrftComplete"
        Me.Label_UserDrftComplete.Size = New System.Drawing.Size(53, 13)
        Me.Label_UserDrftComplete.TabIndex = 46
        Me.Label_UserDrftComplete.Text = "UserDrftC"
        '
        'Button_LogDateDrftComplete
        '
        Me.Button_LogDateDrftComplete.Location = New System.Drawing.Point(207, 95)
        Me.Button_LogDateDrftComplete.Name = "Button_LogDateDrftComplete"
        Me.Button_LogDateDrftComplete.Size = New System.Drawing.Size(40, 24)
        Me.Button_LogDateDrftComplete.TabIndex = 44
        Me.Button_LogDateDrftComplete.Text = "Log"
        Me.Button_LogDateDrftComplete.UseVisualStyleBackColor = True
        '
        'Label_UserDrftStart
        '
        Me.Label_UserDrftStart.AutoSize = True
        Me.Label_UserDrftStart.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "UserDrftStart", True))
        Me.Label_UserDrftStart.Location = New System.Drawing.Point(156, 75)
        Me.Label_UserDrftStart.Name = "Label_UserDrftStart"
        Me.Label_UserDrftStart.Size = New System.Drawing.Size(53, 13)
        Me.Label_UserDrftStart.TabIndex = 45
        Me.Label_UserDrftStart.Text = "UserDrftS"
        '
        'Label_DateDrftComplete
        '
        Me.Label_DateDrftComplete.AutoSize = True
        Me.Label_DateDrftComplete.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "DrftCompleted", True))
        Me.Label_DateDrftComplete.Location = New System.Drawing.Point(71, 101)
        Me.Label_DateDrftComplete.Name = "Label_DateDrftComplete"
        Me.Label_DateDrftComplete.Size = New System.Drawing.Size(54, 13)
        Me.Label_DateDrftComplete.TabIndex = 42
        Me.Label_DateDrftComplete.Text = "DateDrftC"
        '
        'Button_LogDateDrftStart
        '
        Me.Button_LogDateDrftStart.Location = New System.Drawing.Point(207, 69)
        Me.Button_LogDateDrftStart.Name = "Button_LogDateDrftStart"
        Me.Button_LogDateDrftStart.Size = New System.Drawing.Size(40, 24)
        Me.Button_LogDateDrftStart.TabIndex = 43
        Me.Button_LogDateDrftStart.Text = "Log"
        Me.Button_LogDateDrftStart.UseVisualStyleBackColor = True
        '
        'Label_DateDrftStart
        '
        Me.Label_DateDrftStart.AutoSize = True
        Me.Label_DateDrftStart.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "DrftStarted", True))
        Me.Label_DateDrftStart.Location = New System.Drawing.Point(71, 75)
        Me.Label_DateDrftStart.Name = "Label_DateDrftStart"
        Me.Label_DateDrftStart.Size = New System.Drawing.Size(54, 13)
        Me.Label_DateDrftStart.TabIndex = 41
        Me.Label_DateDrftStart.Text = "DateDrftS"
        '
        'Label_DrftRequired
        '
        Me.Label_DrftRequired.AutoSize = True
        Me.Label_DrftRequired.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "DrftRequired", True))
        Me.Label_DrftRequired.Location = New System.Drawing.Point(71, 25)
        Me.Label_DrftRequired.Name = "Label_DrftRequired"
        Me.Label_DrftRequired.Size = New System.Drawing.Size(46, 13)
        Me.Label_DrftRequired.TabIndex = 38
        Me.Label_DrftRequired.Text = "DateDR"
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.Label_UserFinishComplete)
        Me.GroupBox10.Controls.Add(Me.Button_LogDateFinishComplete)
        Me.GroupBox10.Controls.Add(Me.Label_UserFinishStart)
        Me.GroupBox10.Controls.Add(Me.Label_FinishRequired)
        Me.GroupBox10.Controls.Add(Me.Button_LogDateFinishStart)
        Me.GroupBox10.Controls.Add(Label29)
        Me.GroupBox10.Controls.Add(Label30)
        Me.GroupBox10.Controls.Add(Me.Label_DateFinishCompleted)
        Me.GroupBox10.Controls.Add(Label31)
        Me.GroupBox10.Controls.Add(Label32)
        Me.GroupBox10.Controls.Add(Label33)
        Me.GroupBox10.Controls.Add(Me.Label_DateFinishStart)
        Me.GroupBox10.Location = New System.Drawing.Point(265, 158)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(253, 133)
        Me.GroupBox10.TabIndex = 34
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Finish"
        '
        'Label_UserFinishComplete
        '
        Me.Label_UserFinishComplete.AutoSize = True
        Me.Label_UserFinishComplete.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "UserFinishComplete", True))
        Me.Label_UserFinishComplete.Location = New System.Drawing.Point(156, 101)
        Me.Label_UserFinishComplete.Name = "Label_UserFinishComplete"
        Me.Label_UserFinishComplete.Size = New System.Drawing.Size(50, 13)
        Me.Label_UserFinishComplete.TabIndex = 46
        Me.Label_UserFinishComplete.Text = "UserFinC"
        '
        'Button_LogDateFinishComplete
        '
        Me.Button_LogDateFinishComplete.Location = New System.Drawing.Point(207, 95)
        Me.Button_LogDateFinishComplete.Name = "Button_LogDateFinishComplete"
        Me.Button_LogDateFinishComplete.Size = New System.Drawing.Size(40, 24)
        Me.Button_LogDateFinishComplete.TabIndex = 46
        Me.Button_LogDateFinishComplete.Text = "Log"
        Me.Button_LogDateFinishComplete.UseVisualStyleBackColor = True
        '
        'Label_UserFinishStart
        '
        Me.Label_UserFinishStart.AutoSize = True
        Me.Label_UserFinishStart.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "UserFinishStart", True))
        Me.Label_UserFinishStart.Location = New System.Drawing.Point(156, 75)
        Me.Label_UserFinishStart.Name = "Label_UserFinishStart"
        Me.Label_UserFinishStart.Size = New System.Drawing.Size(50, 13)
        Me.Label_UserFinishStart.TabIndex = 45
        Me.Label_UserFinishStart.Text = "UserFinS"
        '
        'Label_FinishRequired
        '
        Me.Label_FinishRequired.AutoSize = True
        Me.Label_FinishRequired.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "FinishRequired", True))
        Me.Label_FinishRequired.Location = New System.Drawing.Point(74, 25)
        Me.Label_FinishRequired.Name = "Label_FinishRequired"
        Me.Label_FinishRequired.Size = New System.Drawing.Size(52, 13)
        Me.Label_FinishRequired.TabIndex = 40
        Me.Label_FinishRequired.Text = "DateFinR"
        '
        'Button_LogDateFinishStart
        '
        Me.Button_LogDateFinishStart.Location = New System.Drawing.Point(207, 69)
        Me.Button_LogDateFinishStart.Name = "Button_LogDateFinishStart"
        Me.Button_LogDateFinishStart.Size = New System.Drawing.Size(40, 24)
        Me.Button_LogDateFinishStart.TabIndex = 45
        Me.Button_LogDateFinishStart.Text = "Log"
        Me.Button_LogDateFinishStart.UseVisualStyleBackColor = True
        '
        'Label_DateFinishCompleted
        '
        Me.Label_DateFinishCompleted.AutoSize = True
        Me.Label_DateFinishCompleted.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "FinishCompleted", True))
        Me.Label_DateFinishCompleted.Location = New System.Drawing.Point(74, 101)
        Me.Label_DateFinishCompleted.Name = "Label_DateFinishCompleted"
        Me.Label_DateFinishCompleted.Size = New System.Drawing.Size(51, 13)
        Me.Label_DateFinishCompleted.TabIndex = 46
        Me.Label_DateFinishCompleted.Text = "DateFinC"
        '
        'Label_DateFinishStart
        '
        Me.Label_DateFinishStart.AutoSize = True
        Me.Label_DateFinishStart.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "FinishStarted", True))
        Me.Label_DateFinishStart.Location = New System.Drawing.Point(74, 75)
        Me.Label_DateFinishStart.Name = "Label_DateFinishStart"
        Me.Label_DateFinishStart.Size = New System.Drawing.Size(51, 13)
        Me.Label_DateFinishStart.TabIndex = 45
        Me.Label_DateFinishStart.Text = "DateFinS"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Label_UserEngComplete)
        Me.GroupBox7.Controls.Add(Me.Button_LogDateEngComplete)
        Me.GroupBox7.Controls.Add(Me.Label_UserEngStart)
        Me.GroupBox7.Controls.Add(Me.Label_EngRequired)
        Me.GroupBox7.Controls.Add(Me.Button_LogDateEngStart)
        Me.GroupBox7.Controls.Add(Label14)
        Me.GroupBox7.Controls.Add(Me.Label_DateEngCompleted)
        Me.GroupBox7.Controls.Add(Label15)
        Me.GroupBox7.Controls.Add(Me.Label_DateEngStart)
        Me.GroupBox7.Controls.Add(Label16)
        Me.GroupBox7.Controls.Add(Label17)
        Me.GroupBox7.Controls.Add(Label18)
        Me.GroupBox7.Location = New System.Drawing.Point(265, 19)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(253, 133)
        Me.GroupBox7.TabIndex = 31
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Engineering"
        '
        'Label_UserEngComplete
        '
        Me.Label_UserEngComplete.AutoSize = True
        Me.Label_UserEngComplete.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "UserEngComplete", True))
        Me.Label_UserEngComplete.Location = New System.Drawing.Point(156, 101)
        Me.Label_UserEngComplete.Name = "Label_UserEngComplete"
        Me.Label_UserEngComplete.Size = New System.Drawing.Size(55, 13)
        Me.Label_UserEngComplete.TabIndex = 44
        Me.Label_UserEngComplete.Text = "UserEngC"
        '
        'Button_LogDateEngComplete
        '
        Me.Button_LogDateEngComplete.Location = New System.Drawing.Point(207, 95)
        Me.Button_LogDateEngComplete.Name = "Button_LogDateEngComplete"
        Me.Button_LogDateEngComplete.Size = New System.Drawing.Size(40, 24)
        Me.Button_LogDateEngComplete.TabIndex = 42
        Me.Button_LogDateEngComplete.Text = "Log"
        Me.Button_LogDateEngComplete.UseVisualStyleBackColor = True
        '
        'Label_UserEngStart
        '
        Me.Label_UserEngStart.AutoSize = True
        Me.Label_UserEngStart.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "UserEngStart", True))
        Me.Label_UserEngStart.Location = New System.Drawing.Point(156, 75)
        Me.Label_UserEngStart.Name = "Label_UserEngStart"
        Me.Label_UserEngStart.Size = New System.Drawing.Size(55, 13)
        Me.Label_UserEngStart.TabIndex = 43
        Me.Label_UserEngStart.Text = "UserEngS"
        '
        'Label_EngRequired
        '
        Me.Label_EngRequired.AutoSize = True
        Me.Label_EngRequired.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "EngRequired", True))
        Me.Label_EngRequired.Location = New System.Drawing.Point(74, 25)
        Me.Label_EngRequired.Name = "Label_EngRequired"
        Me.Label_EngRequired.Size = New System.Drawing.Size(45, 13)
        Me.Label_EngRequired.TabIndex = 37
        Me.Label_EngRequired.Text = "DateER"
        '
        'Button_LogDateEngStart
        '
        Me.Button_LogDateEngStart.Location = New System.Drawing.Point(207, 69)
        Me.Button_LogDateEngStart.Name = "Button_LogDateEngStart"
        Me.Button_LogDateEngStart.Size = New System.Drawing.Size(40, 24)
        Me.Button_LogDateEngStart.TabIndex = 41
        Me.Button_LogDateEngStart.Text = "Log"
        Me.Button_LogDateEngStart.UseVisualStyleBackColor = True
        '
        'Label_DateEngCompleted
        '
        Me.Label_DateEngCompleted.AutoSize = True
        Me.Label_DateEngCompleted.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "EngCompleted", True))
        Me.Label_DateEngCompleted.Location = New System.Drawing.Point(74, 101)
        Me.Label_DateEngCompleted.Name = "Label_DateEngCompleted"
        Me.Label_DateEngCompleted.Size = New System.Drawing.Size(56, 13)
        Me.Label_DateEngCompleted.TabIndex = 40
        Me.Label_DateEngCompleted.Text = "DateEngC"
        '
        'Label_DateEngStart
        '
        Me.Label_DateEngStart.AutoSize = True
        Me.Label_DateEngStart.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "EngStarted", True))
        Me.Label_DateEngStart.Location = New System.Drawing.Point(74, 75)
        Me.Label_DateEngStart.Name = "Label_DateEngStart"
        Me.Label_DateEngStart.Size = New System.Drawing.Size(59, 13)
        Me.Label_DateEngStart.TabIndex = 39
        Me.Label_DateEngStart.Text = "DateEngSt"
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.Label_UserFabComplete)
        Me.GroupBox11.Controls.Add(Me.Button_LogDateFabComplete)
        Me.GroupBox11.Controls.Add(Me.Label_UserFabStart)
        Me.GroupBox11.Controls.Add(Me.Label_DateFabCompleted)
        Me.GroupBox11.Controls.Add(Me.Button_LogDateFabStart)
        Me.GroupBox11.Controls.Add(Me.Label_FabRequired)
        Me.GroupBox11.Controls.Add(Me.Label_DateFabStarted)
        Me.GroupBox11.Controls.Add(Label34)
        Me.GroupBox11.Controls.Add(Label35)
        Me.GroupBox11.Controls.Add(Label36)
        Me.GroupBox11.Controls.Add(Label37)
        Me.GroupBox11.Controls.Add(Label38)
        Me.GroupBox11.Location = New System.Drawing.Point(6, 158)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(253, 133)
        Me.GroupBox11.TabIndex = 33
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Fabrication"
        '
        'Label_UserFabComplete
        '
        Me.Label_UserFabComplete.AutoSize = True
        Me.Label_UserFabComplete.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "UserFabComplete", True))
        Me.Label_UserFabComplete.Location = New System.Drawing.Point(155, 101)
        Me.Label_UserFabComplete.Name = "Label_UserFabComplete"
        Me.Label_UserFabComplete.Size = New System.Drawing.Size(54, 13)
        Me.Label_UserFabComplete.TabIndex = 44
        Me.Label_UserFabComplete.Text = "UserFabC"
        '
        'Button_LogDateFabComplete
        '
        Me.Button_LogDateFabComplete.Location = New System.Drawing.Point(207, 95)
        Me.Button_LogDateFabComplete.Name = "Button_LogDateFabComplete"
        Me.Button_LogDateFabComplete.Size = New System.Drawing.Size(40, 24)
        Me.Button_LogDateFabComplete.TabIndex = 42
        Me.Button_LogDateFabComplete.Text = "Log"
        Me.Button_LogDateFabComplete.UseVisualStyleBackColor = True
        '
        'Label_UserFabStart
        '
        Me.Label_UserFabStart.AutoSize = True
        Me.Label_UserFabStart.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "UserFabStart", True))
        Me.Label_UserFabStart.Location = New System.Drawing.Point(155, 75)
        Me.Label_UserFabStart.Name = "Label_UserFabStart"
        Me.Label_UserFabStart.Size = New System.Drawing.Size(54, 13)
        Me.Label_UserFabStart.TabIndex = 43
        Me.Label_UserFabStart.Text = "UserFabS"
        '
        'Label_DateFabCompleted
        '
        Me.Label_DateFabCompleted.AutoSize = True
        Me.Label_DateFabCompleted.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "FabCompleted", True))
        Me.Label_DateFabCompleted.Location = New System.Drawing.Point(74, 101)
        Me.Label_DateFabCompleted.Name = "Label_DateFabCompleted"
        Me.Label_DateFabCompleted.Size = New System.Drawing.Size(55, 13)
        Me.Label_DateFabCompleted.TabIndex = 44
        Me.Label_DateFabCompleted.Text = "DateFabC"
        '
        'Button_LogDateFabStart
        '
        Me.Button_LogDateFabStart.Location = New System.Drawing.Point(207, 69)
        Me.Button_LogDateFabStart.Name = "Button_LogDateFabStart"
        Me.Button_LogDateFabStart.Size = New System.Drawing.Size(40, 24)
        Me.Button_LogDateFabStart.TabIndex = 41
        Me.Button_LogDateFabStart.Text = "Log"
        Me.Button_LogDateFabStart.UseVisualStyleBackColor = True
        '
        'Label_FabRequired
        '
        Me.Label_FabRequired.AutoSize = True
        Me.Label_FabRequired.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "FabRequired", True))
        Me.Label_FabRequired.Location = New System.Drawing.Point(74, 25)
        Me.Label_FabRequired.Name = "Label_FabRequired"
        Me.Label_FabRequired.Size = New System.Drawing.Size(56, 13)
        Me.Label_FabRequired.TabIndex = 39
        Me.Label_FabRequired.Text = "DateFabR"
        '
        'Label_DateFabStarted
        '
        Me.Label_DateFabStarted.AutoSize = True
        Me.Label_DateFabStarted.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "FabStarted", True))
        Me.Label_DateFabStarted.Location = New System.Drawing.Point(74, 75)
        Me.Label_DateFabStarted.Name = "Label_DateFabStarted"
        Me.Label_DateFabStarted.Size = New System.Drawing.Size(55, 13)
        Me.Label_DateFabStarted.TabIndex = 43
        Me.Label_DateFabStarted.Text = "DateFabS"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label_UserPriceComplete)
        Me.GroupBox6.Controls.Add(Me.Label_UserPriceStarted)
        Me.GroupBox6.Controls.Add(Me.Button_LogDatePriceComplete)
        Me.GroupBox6.Controls.Add(Me.Button_LogDatePriceStart)
        Me.GroupBox6.Controls.Add(Me.Label_DatePricingComplet)
        Me.GroupBox6.Controls.Add(Me.Label_DatePricingStarted)
        Me.GroupBox6.Controls.Add(Me.Label_PricingRequired)
        Me.GroupBox6.Controls.Add(Label13)
        Me.GroupBox6.Controls.Add(PricingStartedLabel)
        Me.GroupBox6.Controls.Add(Label11)
        Me.GroupBox6.Controls.Add(PricingCompletedLabel)
        Me.GroupBox6.Controls.Add(PricingRequiredLabel)
        Me.GroupBox6.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(253, 133)
        Me.GroupBox6.TabIndex = 30
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Pricing"
        '
        'Label_UserPriceComplete
        '
        Me.Label_UserPriceComplete.AutoSize = True
        Me.Label_UserPriceComplete.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "UserPriceComplete", True))
        Me.Label_UserPriceComplete.Location = New System.Drawing.Point(155, 101)
        Me.Label_UserPriceComplete.Name = "Label_UserPriceComplete"
        Me.Label_UserPriceComplete.Size = New System.Drawing.Size(60, 13)
        Me.Label_UserPriceComplete.TabIndex = 42
        Me.Label_UserPriceComplete.Text = "UserPriceC"
        '
        'Label_UserPriceStarted
        '
        Me.Label_UserPriceStarted.AutoSize = True
        Me.Label_UserPriceStarted.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "UserPriceStart", True))
        Me.Label_UserPriceStarted.Location = New System.Drawing.Point(155, 75)
        Me.Label_UserPriceStarted.Name = "Label_UserPriceStarted"
        Me.Label_UserPriceStarted.Size = New System.Drawing.Size(60, 13)
        Me.Label_UserPriceStarted.TabIndex = 41
        Me.Label_UserPriceStarted.Text = "UserPriceS"
        '
        'Button_LogDatePriceComplete
        '
        Me.Button_LogDatePriceComplete.Location = New System.Drawing.Point(207, 95)
        Me.Button_LogDatePriceComplete.Name = "Button_LogDatePriceComplete"
        Me.Button_LogDatePriceComplete.Size = New System.Drawing.Size(40, 24)
        Me.Button_LogDatePriceComplete.TabIndex = 40
        Me.Button_LogDatePriceComplete.Text = "Log"
        Me.Button_LogDatePriceComplete.UseVisualStyleBackColor = True
        '
        'Button_LogDatePriceStart
        '
        Me.Button_LogDatePriceStart.Location = New System.Drawing.Point(207, 69)
        Me.Button_LogDatePriceStart.Name = "Button_LogDatePriceStart"
        Me.Button_LogDatePriceStart.Size = New System.Drawing.Size(40, 24)
        Me.Button_LogDatePriceStart.TabIndex = 39
        Me.Button_LogDatePriceStart.Text = "Log"
        Me.Button_LogDatePriceStart.UseVisualStyleBackColor = True
        '
        'Label_DatePricingComplet
        '
        Me.Label_DatePricingComplet.AutoSize = True
        Me.Label_DatePricingComplet.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "PricingCompleted", True))
        Me.Label_DatePricingComplet.Location = New System.Drawing.Point(74, 101)
        Me.Label_DatePricingComplet.Name = "Label_DatePricingComplet"
        Me.Label_DatePricingComplet.Size = New System.Drawing.Size(61, 13)
        Me.Label_DatePricingComplet.TabIndex = 38
        Me.Label_DatePricingComplet.Text = "DatePriceC"
        '
        'Label_DatePricingStarted
        '
        Me.Label_DatePricingStarted.AutoSize = True
        Me.Label_DatePricingStarted.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "PricingStarted", True))
        Me.Label_DatePricingStarted.Location = New System.Drawing.Point(74, 75)
        Me.Label_DatePricingStarted.Name = "Label_DatePricingStarted"
        Me.Label_DatePricingStarted.Size = New System.Drawing.Size(61, 13)
        Me.Label_DatePricingStarted.TabIndex = 37
        Me.Label_DatePricingStarted.Text = "DatePriceS"
        '
        'Label_PricingRequired
        '
        Me.Label_PricingRequired.AutoSize = True
        Me.Label_PricingRequired.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "PricingRequired", True))
        Me.Label_PricingRequired.Location = New System.Drawing.Point(74, 25)
        Me.Label_PricingRequired.Name = "Label_PricingRequired"
        Me.Label_PricingRequired.Size = New System.Drawing.Size(45, 13)
        Me.Label_PricingRequired.TabIndex = 36
        Me.Label_PricingRequired.Text = "DatePR"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Button_BackSchedule)
        Me.GroupBox4.Controls.Add(Label12)
        Me.GroupBox4.Controls.Add(Delivery_DateLabel)
        Me.GroupBox4.Controls.Add(PO_RecieptLabel)
        Me.GroupBox4.Controls.Add(Me.Delivery_DateDateTimePicker)
        Me.GroupBox4.Controls.Add(PO_Label)
        Me.GroupBox4.Controls.Add(Me.PO_RecieptDateTimePicker)
        Me.GroupBox4.Controls.Add(Me.PO_TextBox)
        Me.GroupBox4.Controls.Add(Me.TextBox_PoProject)
        Me.GroupBox4.Location = New System.Drawing.Point(273, 6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(259, 161)
        Me.GroupBox4.TabIndex = 55
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Order"
        '
        'Button_BackSchedule
        '
        Me.Button_BackSchedule.Location = New System.Drawing.Point(85, 123)
        Me.Button_BackSchedule.Name = "Button_BackSchedule"
        Me.Button_BackSchedule.Size = New System.Drawing.Size(168, 24)
        Me.Button_BackSchedule.TabIndex = 18
        Me.Button_BackSchedule.Text = "Back Schedule"
        Me.Button_BackSchedule.UseVisualStyleBackColor = True
        '
        'Delivery_DateDateTimePicker
        '
        Me.Delivery_DateDateTimePicker.CustomFormat = " "
        Me.Delivery_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TableBindingSource, "Delivery Date", True))
        Me.Delivery_DateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Delivery_DateDateTimePicker.Location = New System.Drawing.Point(85, 96)
        Me.Delivery_DateDateTimePicker.Name = "Delivery_DateDateTimePicker"
        Me.Delivery_DateDateTimePicker.Size = New System.Drawing.Size(115, 20)
        Me.Delivery_DateDateTimePicker.TabIndex = 15
        '
        'PO_RecieptDateTimePicker
        '
        Me.PO_RecieptDateTimePicker.CustomFormat = " "
        Me.PO_RecieptDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TableBindingSource, "PO Reciept", True))
        Me.PO_RecieptDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.PO_RecieptDateTimePicker.Location = New System.Drawing.Point(85, 45)
        Me.PO_RecieptDateTimePicker.Name = "PO_RecieptDateTimePicker"
        Me.PO_RecieptDateTimePicker.Size = New System.Drawing.Size(115, 20)
        Me.PO_RecieptDateTimePicker.TabIndex = 13
        '
        'PO_TextBox
        '
        Me.PO_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "PONo", True))
        Me.PO_TextBox.Location = New System.Drawing.Point(85, 19)
        Me.PO_TextBox.Name = "PO_TextBox"
        Me.PO_TextBox.Size = New System.Drawing.Size(168, 20)
        Me.PO_TextBox.TabIndex = 11
        '
        'TextBox_PoProject
        '
        Me.TextBox_PoProject.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "POProject", True))
        Me.TextBox_PoProject.Location = New System.Drawing.Point(85, 71)
        Me.TextBox_PoProject.Name = "TextBox_PoProject"
        Me.TextBox_PoProject.Size = New System.Drawing.Size(168, 20)
        Me.TextBox_PoProject.TabIndex = 9
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button_Convert2Order)
        Me.GroupBox3.Controls.Add(Quote_Label)
        Me.GroupBox3.Controls.Add(ProjectLabel)
        Me.GroupBox3.Controls.Add(CustomerLabel)
        Me.GroupBox3.Controls.Add(Me.ProjectTextBox)
        Me.GroupBox3.Controls.Add(Order_Label)
        Me.GroupBox3.Controls.Add(Me.CustomerTextBox)
        Me.GroupBox3.Controls.Add(Me.Order_TextBox)
        Me.GroupBox3.Controls.Add(Quote_Due_DateLabel)
        Me.GroupBox3.Controls.Add(Me.Quote_TextBox)
        Me.GroupBox3.Controls.Add(Me.Quote_Due_DateDateTimePicker)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(259, 161)
        Me.GroupBox3.TabIndex = 54
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Quote"
        '
        'Button_Convert2Order
        '
        Me.Button_Convert2Order.Location = New System.Drawing.Point(79, 123)
        Me.Button_Convert2Order.Name = "Button_Convert2Order"
        Me.Button_Convert2Order.Size = New System.Drawing.Size(174, 24)
        Me.Button_Convert2Order.TabIndex = 18
        Me.Button_Convert2Order.Text = "Convert to Order"
        Me.Button_Convert2Order.UseVisualStyleBackColor = True
        '
        'ProjectTextBox
        '
        Me.ProjectTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "Project", True))
        Me.ProjectTextBox.Location = New System.Drawing.Point(79, 71)
        Me.ProjectTextBox.Name = "ProjectTextBox"
        Me.ProjectTextBox.Size = New System.Drawing.Size(174, 20)
        Me.ProjectTextBox.TabIndex = 9
        '
        'CustomerTextBox
        '
        Me.CustomerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "Customer", True))
        Me.CustomerTextBox.Location = New System.Drawing.Point(79, 45)
        Me.CustomerTextBox.Name = "CustomerTextBox"
        Me.CustomerTextBox.Size = New System.Drawing.Size(174, 20)
        Me.CustomerTextBox.TabIndex = 7
        '
        'Order_TextBox
        '
        Me.Order_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "OrderNo", True))
        Me.Order_TextBox.Location = New System.Drawing.Point(200, 19)
        Me.Order_TextBox.Name = "Order_TextBox"
        Me.Order_TextBox.ReadOnly = True
        Me.Order_TextBox.Size = New System.Drawing.Size(53, 20)
        Me.Order_TextBox.TabIndex = 5
        '
        'Quote_TextBox
        '
        Me.Quote_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableBindingSource, "QuoteNo", True))
        Me.Quote_TextBox.Location = New System.Drawing.Point(79, 19)
        Me.Quote_TextBox.Name = "Quote_TextBox"
        Me.Quote_TextBox.Size = New System.Drawing.Size(53, 20)
        Me.Quote_TextBox.TabIndex = 3
        '
        'Quote_Due_DateDateTimePicker
        '
        Me.Quote_Due_DateDateTimePicker.CustomFormat = " "
        Me.Quote_Due_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TableBindingSource, "Quote Due Date", True))
        Me.Quote_Due_DateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Quote_Due_DateDateTimePicker.Location = New System.Drawing.Point(79, 97)
        Me.Quote_Due_DateDateTimePicker.Name = "Quote_Due_DateDateTimePicker"
        Me.Quote_Due_DateDateTimePicker.Size = New System.Drawing.Size(115, 20)
        Me.Quote_Due_DateDateTimePicker.TabIndex = 17
        '
        'TableBindingNavigator
        '
        Me.TableBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TableBindingNavigator.BindingSource = Me.TableBindingSource
        Me.TableBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TableBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TableBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TableBindingNavigatorSaveItem, Me.ToolStripLabel1, Me.ToolStripComboBox_User})
        Me.TableBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TableBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TableBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TableBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TableBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TableBindingNavigator.Name = "TableBindingNavigator"
        Me.TableBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TableBindingNavigator.Size = New System.Drawing.Size(799, 25)
        Me.TableBindingNavigator.TabIndex = 1
        Me.TableBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'TableBindingNavigatorSaveItem
        '
        Me.TableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TableBindingNavigatorSaveItem.Image = CType(resources.GetObject("TableBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TableBindingNavigatorSaveItem.Name = "TableBindingNavigatorSaveItem"
        Me.TableBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TableBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(76, 22)
        Me.ToolStripLabel1.Text = "Current User:"
        '
        'ToolStripComboBox_User
        '
        Me.ToolStripComboBox_User.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ToolStripComboBox_User.Name = "ToolStripComboBox_User"
        Me.ToolStripComboBox_User.Size = New System.Drawing.Size(121, 25)
        '
        'TableTableAdapter
        '
        Me.TableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TableTableAdapter = Me.TableTableAdapter
        Me.TableAdapterManager.UpdateOrder = OrderTracker.QuoteOrdersDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'QuoteOrdersDS1
        '
        Me.QuoteOrdersDS1.DataSetName = "QuoteOrdersDS"
        Me.QuoteOrdersDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 529)
        Me.Controls.Add(Me.TableBindingNavigator)
        Me.Controls.Add(Me.TabControl1)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Order Tracker v1.0"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.TableDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuoteOrdersDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox_ShipActual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_ShipCommit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_EngActual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_EngCommit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_FinishActual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_FinishCommit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_FabActual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_FabCommit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_DrftActual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_DrftCommit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_PriceActual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_PriceCommit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.TableBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableBindingNavigator.ResumeLayout(False)
        Me.TableBindingNavigator.PerformLayout()
        CType(Me.QuoteOrdersDS1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PictureBox_ShipActual As PictureBox
    Friend WithEvents PictureBox_ShipCommit As PictureBox
    Friend WithEvents PictureBox_EngActual As PictureBox
    Friend WithEvents PictureBox_EngCommit As PictureBox
    Friend WithEvents PictureBox_FinishActual As PictureBox
    Friend WithEvents PictureBox_FinishCommit As PictureBox
    Friend WithEvents PictureBox_FabActual As PictureBox
    Friend WithEvents PictureBox_FabCommit As PictureBox
    Friend WithEvents PictureBox_DrftActual As PictureBox
    Friend WithEvents PictureBox_DrftCommit As PictureBox
    Friend WithEvents PictureBox_PriceActual As PictureBox
    Friend WithEvents PictureBox_PriceCommit As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CheckBox_OpenProjects As CheckBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox_Find As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents QuoteOrdersDS As QuoteOrdersDS
    Friend WithEvents TableBindingSource As BindingSource
    Friend WithEvents TableTableAdapter As QuoteOrdersDSTableAdapters.TableTableAdapter
    Friend WithEvents TableAdapterManager As QuoteOrdersDSTableAdapters.TableAdapterManager
    Friend WithEvents TableBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents TableBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents TableDataGridView As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button_Convert2Order As Button
    Friend WithEvents ProjectTextBox As TextBox
    Friend WithEvents CustomerTextBox As TextBox
    Friend WithEvents Order_TextBox As TextBox
    Friend WithEvents Quote_TextBox As TextBox
    Friend WithEvents Quote_Due_DateDateTimePicker As DateTimePicker
    Friend WithEvents PO_TextBox As TextBox
    Friend WithEvents PO_RecieptDateTimePicker As DateTimePicker
    Friend WithEvents Delivery_DateDateTimePicker As DateTimePicker
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Button_BackSchedule As Button
    Friend WithEvents TextBox_PoProject As TextBox
    Friend WithEvents Button_OrderReport As Button
    Friend WithEvents Button_QuoteReport As Button
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents GroupBox11 As GroupBox
    Friend WithEvents Label_PricingRequired As Label
    Friend WithEvents Label_ShipRequired As Label
    Friend WithEvents Label_DrftRequired As Label
    Friend WithEvents Label_FinishRequired As Label
    Friend WithEvents Label_EngRequired As Label
    Friend WithEvents Label_FabRequired As Label
    Friend WithEvents Label_DatePricingComplet As Label
    Friend WithEvents Label_DatePricingStarted As Label
    Friend WithEvents Label_DateShipCompleted As Label
    Friend WithEvents Label_DateShipStart As Label
    Friend WithEvents Label_DateDrftComplete As Label
    Friend WithEvents Label_DateDrftStart As Label
    Friend WithEvents Label_DateFinishCompleted As Label
    Friend WithEvents Label_DateFinishStart As Label
    Friend WithEvents Label_DateEngCompleted As Label
    Friend WithEvents Label_DateEngStart As Label
    Friend WithEvents Label_DateFabCompleted As Label
    Friend WithEvents Label_DateFabStarted As Label
    Friend WithEvents Button_LogDateShipComplete As Button
    Friend WithEvents Button_LogDateShipStart As Button
    Friend WithEvents Button_LogDateDrftComplete As Button
    Friend WithEvents Button_LogDateDrftStart As Button
    Friend WithEvents Button_LogDateFinishComplete As Button
    Friend WithEvents Button_LogDateFinishStart As Button
    Friend WithEvents Button_LogDateEngComplete As Button
    Friend WithEvents Button_LogDateEngStart As Button
    Friend WithEvents Button_LogDateFabComplete As Button
    Friend WithEvents Button_LogDateFabStart As Button
    Friend WithEvents Button_LogDatePriceComplete As Button
    Friend WithEvents Button_LogDatePriceStart As Button
    Friend WithEvents Label_UserPriceStarted As Label
    Friend WithEvents Label_UserPriceComplete As Label
    Friend WithEvents Label_UserShipComplete As Label
    Friend WithEvents Label_UserShipStart As Label
    Friend WithEvents Label_UserDrftComplete As Label
    Friend WithEvents Label_UserDrftStart As Label
    Friend WithEvents Label_UserFinishComplete As Label
    Friend WithEvents Label_UserFinishStart As Label
    Friend WithEvents Label_UserEngComplete As Label
    Friend WithEvents Label_UserEngStart As Label
    Friend WithEvents Label_UserFabComplete As Label
    Friend WithEvents Label_UserFabStart As Label
    Friend WithEvents QuoteOrdersDS1 As QuoteOrdersDS
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents QuoteNo As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents OrderNo As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents PONo As DataGridViewTextBoxColumn
    Friend WithEvents ToolStripComboBox_User As ToolStripComboBox
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
End Class
