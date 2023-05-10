<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_Cashier_Dashboard
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PNL_Menu = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LBLUsernameWelcome = New System.Windows.Forms.Label()
        Me.BTN_ManageProducts = New System.Windows.Forms.Button()
        Me.PNL_TitleBar = New System.Windows.Forms.Panel()
        Me.BTN_Exit = New System.Windows.Forms.Button()
        Me.LBL_CurrentFormTitle = New System.Windows.Forms.Label()
        Me.PNL_ChildForm = New System.Windows.Forms.Panel()
        Me.TABCONTROL_Main = New System.Windows.Forms.TabControl()
        Me.TABPAGE_Checkout = New System.Windows.Forms.TabPage()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTN_CheckOut = New System.Windows.Forms.Button()
        Me.TXT_TotalAmountCheckOut = New System.Windows.Forms.TextBox()
        Me.BTN_DoneCartEditing = New System.Windows.Forms.Button()
        Me.BTN_DeleteCartItem = New System.Windows.Forms.Button()
        Me.BTN_UpdateCartItem = New System.Windows.Forms.Button()
        Me.BTN_AddToCart = New System.Windows.Forms.Button()
        Me.TXT_TotalItemPrice = New System.Windows.Forms.TextBox()
        Me.TXT_ItemPrice = New System.Windows.Forms.TextBox()
        Me.TXT_Stocks = New System.Windows.Forms.TextBox()
        Me.CBO_ProductName = New System.Windows.Forms.ComboBox()
        Me.NMRC_Quantity = New System.Windows.Forms.NumericUpDown()
        Me.CartDataGridView = New System.Windows.Forms.DataGridView()
        Me.TABPAGE_Pay = New System.Windows.Forms.TabPage()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BTN_DoneTransaction = New System.Windows.Forms.Button()
        Me.BTN_Pay = New System.Windows.Forms.Button()
        Me.TXT_CustomerName = New System.Windows.Forms.TextBox()
        Me.TXT_TransactionID = New System.Windows.Forms.TextBox()
        Me.CartDataGridView_COPY = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TXT_Cash = New System.Windows.Forms.TextBox()
        Me.TXT_Change = New System.Windows.Forms.TextBox()
        Me.TXT_OverallTotal = New System.Windows.Forms.TextBox()
        Me.TransactionDataGridView = New System.Windows.Forms.DataGridView()
        Me.PNL_Menu.SuspendLayout()
        Me.PNL_TitleBar.SuspendLayout()
        Me.PNL_ChildForm.SuspendLayout()
        Me.TABCONTROL_Main.SuspendLayout()
        Me.TABPAGE_Checkout.SuspendLayout()
        CType(Me.NMRC_Quantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CartDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TABPAGE_Pay.SuspendLayout()
        CType(Me.CartDataGridView_COPY, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.TransactionDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PNL_Menu
        '
        Me.PNL_Menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.PNL_Menu.Controls.Add(Me.Label2)
        Me.PNL_Menu.Controls.Add(Me.LBLUsernameWelcome)
        Me.PNL_Menu.Controls.Add(Me.BTN_ManageProducts)
        Me.PNL_Menu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PNL_Menu.Location = New System.Drawing.Point(0, 0)
        Me.PNL_Menu.Name = "PNL_Menu"
        Me.PNL_Menu.Size = New System.Drawing.Size(220, 738)
        Me.PNL_Menu.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 2
        '
        'LBLUsernameWelcome
        '
        Me.LBLUsernameWelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLUsernameWelcome.ForeColor = System.Drawing.Color.White
        Me.LBLUsernameWelcome.Location = New System.Drawing.Point(0, 75)
        Me.LBLUsernameWelcome.Name = "LBLUsernameWelcome"
        Me.LBLUsernameWelcome.Padding = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.LBLUsernameWelcome.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LBLUsernameWelcome.Size = New System.Drawing.Size(220, 52)
        Me.LBLUsernameWelcome.TabIndex = 1
        Me.LBLUsernameWelcome.Text = "Welcome Cashier"
        Me.LBLUsernameWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BTN_ManageProducts
        '
        Me.BTN_ManageProducts.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.BTN_ManageProducts.FlatAppearance.BorderSize = 0
        Me.BTN_ManageProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_ManageProducts.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_ManageProducts.ForeColor = System.Drawing.Color.White
        Me.BTN_ManageProducts.Location = New System.Drawing.Point(0, 580)
        Me.BTN_ManageProducts.Name = "BTN_ManageProducts"
        Me.BTN_ManageProducts.Size = New System.Drawing.Size(220, 50)
        Me.BTN_ManageProducts.TabIndex = 63
        Me.BTN_ManageProducts.Text = "Manage Products"
        Me.BTN_ManageProducts.UseVisualStyleBackColor = False
        '
        'PNL_TitleBar
        '
        Me.PNL_TitleBar.BackColor = System.Drawing.Color.White
        Me.PNL_TitleBar.Controls.Add(Me.BTN_Exit)
        Me.PNL_TitleBar.Controls.Add(Me.LBL_CurrentFormTitle)
        Me.PNL_TitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PNL_TitleBar.Location = New System.Drawing.Point(220, 0)
        Me.PNL_TitleBar.Name = "PNL_TitleBar"
        Me.PNL_TitleBar.Size = New System.Drawing.Size(980, 75)
        Me.PNL_TitleBar.TabIndex = 1
        '
        'BTN_Exit
        '
        Me.BTN_Exit.BackColor = System.Drawing.Color.Transparent
        Me.BTN_Exit.FlatAppearance.BorderSize = 0
        Me.BTN_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_Exit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Exit.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.BTN_Exit.Location = New System.Drawing.Point(924, 12)
        Me.BTN_Exit.Name = "BTN_Exit"
        Me.BTN_Exit.Size = New System.Drawing.Size(35, 30)
        Me.BTN_Exit.TabIndex = 78
        Me.BTN_Exit.Text = "X"
        Me.BTN_Exit.UseVisualStyleBackColor = False
        '
        'LBL_CurrentFormTitle
        '
        Me.LBL_CurrentFormTitle.AutoSize = True
        Me.LBL_CurrentFormTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_CurrentFormTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.LBL_CurrentFormTitle.Location = New System.Drawing.Point(6, 28)
        Me.LBL_CurrentFormTitle.Name = "LBL_CurrentFormTitle"
        Me.LBL_CurrentFormTitle.Size = New System.Drawing.Size(188, 24)
        Me.LBL_CurrentFormTitle.TabIndex = 1
        Me.LBL_CurrentFormTitle.Text = "Cashier Dashboard"
        Me.LBL_CurrentFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PNL_ChildForm
        '
        Me.PNL_ChildForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.PNL_ChildForm.Controls.Add(Me.TABCONTROL_Main)
        Me.PNL_ChildForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PNL_ChildForm.Location = New System.Drawing.Point(220, 75)
        Me.PNL_ChildForm.Name = "PNL_ChildForm"
        Me.PNL_ChildForm.Size = New System.Drawing.Size(980, 663)
        Me.PNL_ChildForm.TabIndex = 2
        '
        'TABCONTROL_Main
        '
        Me.TABCONTROL_Main.Controls.Add(Me.TABPAGE_Checkout)
        Me.TABCONTROL_Main.Controls.Add(Me.TABPAGE_Pay)
        Me.TABCONTROL_Main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TABCONTROL_Main.Location = New System.Drawing.Point(0, 0)
        Me.TABCONTROL_Main.Name = "TABCONTROL_Main"
        Me.TABCONTROL_Main.SelectedIndex = 0
        Me.TABCONTROL_Main.Size = New System.Drawing.Size(980, 663)
        Me.TABCONTROL_Main.TabIndex = 58
        '
        'TABPAGE_Checkout
        '
        Me.TABPAGE_Checkout.BackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.TABPAGE_Checkout.Controls.Add(Me.Label14)
        Me.TABPAGE_Checkout.Controls.Add(Me.Label6)
        Me.TABPAGE_Checkout.Controls.Add(Me.Label5)
        Me.TABPAGE_Checkout.Controls.Add(Me.Label4)
        Me.TABPAGE_Checkout.Controls.Add(Me.Label3)
        Me.TABPAGE_Checkout.Controls.Add(Me.Label1)
        Me.TABPAGE_Checkout.Controls.Add(Me.BTN_CheckOut)
        Me.TABPAGE_Checkout.Controls.Add(Me.TXT_TotalAmountCheckOut)
        Me.TABPAGE_Checkout.Controls.Add(Me.BTN_DoneCartEditing)
        Me.TABPAGE_Checkout.Controls.Add(Me.BTN_DeleteCartItem)
        Me.TABPAGE_Checkout.Controls.Add(Me.BTN_UpdateCartItem)
        Me.TABPAGE_Checkout.Controls.Add(Me.BTN_AddToCart)
        Me.TABPAGE_Checkout.Controls.Add(Me.TXT_TotalItemPrice)
        Me.TABPAGE_Checkout.Controls.Add(Me.TXT_ItemPrice)
        Me.TABPAGE_Checkout.Controls.Add(Me.TXT_Stocks)
        Me.TABPAGE_Checkout.Controls.Add(Me.CBO_ProductName)
        Me.TABPAGE_Checkout.Controls.Add(Me.NMRC_Quantity)
        Me.TABPAGE_Checkout.Controls.Add(Me.CartDataGridView)
        Me.TABPAGE_Checkout.Location = New System.Drawing.Point(4, 22)
        Me.TABPAGE_Checkout.Name = "TABPAGE_Checkout"
        Me.TABPAGE_Checkout.Padding = New System.Windows.Forms.Padding(3)
        Me.TABPAGE_Checkout.Size = New System.Drawing.Size(972, 637)
        Me.TABPAGE_Checkout.TabIndex = 0
        Me.TABPAGE_Checkout.Text = "Checkout"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(339, 29)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(140, 20)
        Me.Label14.TabIndex = 77
        Me.Label14.Text = "Cart Information"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(548, 362)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(197, 20)
        Me.Label6.TabIndex = 74
        Me.Label6.Text = "Total Checkout Amount"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(13, 164)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(135, 20)
        Me.Label5.TabIndex = 73
        Me.Label5.Text = "Total Item Price"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(13, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 20)
        Me.Label4.TabIndex = 72
        Me.Label4.Text = "Item Price"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(13, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 20)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "Quantity"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(13, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 20)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Product Name"
        '
        'BTN_CheckOut
        '
        Me.BTN_CheckOut.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.BTN_CheckOut.Enabled = False
        Me.BTN_CheckOut.FlatAppearance.BorderSize = 0
        Me.BTN_CheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_CheckOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_CheckOut.ForeColor = System.Drawing.Color.White
        Me.BTN_CheckOut.Location = New System.Drawing.Point(751, 388)
        Me.BTN_CheckOut.Name = "BTN_CheckOut"
        Me.BTN_CheckOut.Size = New System.Drawing.Size(171, 28)
        Me.BTN_CheckOut.TabIndex = 69
        Me.BTN_CheckOut.Text = "CHECK OUT"
        Me.BTN_CheckOut.UseVisualStyleBackColor = False
        '
        'TXT_TotalAmountCheckOut
        '
        Me.TXT_TotalAmountCheckOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_TotalAmountCheckOut.Location = New System.Drawing.Point(751, 362)
        Me.TXT_TotalAmountCheckOut.Margin = New System.Windows.Forms.Padding(0)
        Me.TXT_TotalAmountCheckOut.Name = "TXT_TotalAmountCheckOut"
        Me.TXT_TotalAmountCheckOut.ReadOnly = True
        Me.TXT_TotalAmountCheckOut.Size = New System.Drawing.Size(171, 20)
        Me.TXT_TotalAmountCheckOut.TabIndex = 68
        '
        'BTN_DoneCartEditing
        '
        Me.BTN_DoneCartEditing.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.BTN_DoneCartEditing.Enabled = False
        Me.BTN_DoneCartEditing.FlatAppearance.BorderSize = 0
        Me.BTN_DoneCartEditing.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_DoneCartEditing.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_DoneCartEditing.ForeColor = System.Drawing.Color.White
        Me.BTN_DoneCartEditing.Location = New System.Drawing.Point(760, 271)
        Me.BTN_DoneCartEditing.Name = "BTN_DoneCartEditing"
        Me.BTN_DoneCartEditing.Size = New System.Drawing.Size(162, 28)
        Me.BTN_DoneCartEditing.TabIndex = 67
        Me.BTN_DoneCartEditing.Text = "Done Cart Editing"
        Me.BTN_DoneCartEditing.UseVisualStyleBackColor = False
        '
        'BTN_DeleteCartItem
        '
        Me.BTN_DeleteCartItem.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.BTN_DeleteCartItem.Enabled = False
        Me.BTN_DeleteCartItem.FlatAppearance.BorderSize = 0
        Me.BTN_DeleteCartItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_DeleteCartItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_DeleteCartItem.ForeColor = System.Drawing.Color.White
        Me.BTN_DeleteCartItem.Location = New System.Drawing.Point(579, 271)
        Me.BTN_DeleteCartItem.Name = "BTN_DeleteCartItem"
        Me.BTN_DeleteCartItem.Size = New System.Drawing.Size(158, 28)
        Me.BTN_DeleteCartItem.TabIndex = 66
        Me.BTN_DeleteCartItem.Text = "Delete Cart Item"
        Me.BTN_DeleteCartItem.UseVisualStyleBackColor = False
        '
        'BTN_UpdateCartItem
        '
        Me.BTN_UpdateCartItem.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.BTN_UpdateCartItem.Enabled = False
        Me.BTN_UpdateCartItem.FlatAppearance.BorderSize = 0
        Me.BTN_UpdateCartItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_UpdateCartItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_UpdateCartItem.ForeColor = System.Drawing.Color.White
        Me.BTN_UpdateCartItem.Location = New System.Drawing.Point(396, 271)
        Me.BTN_UpdateCartItem.Name = "BTN_UpdateCartItem"
        Me.BTN_UpdateCartItem.Size = New System.Drawing.Size(161, 28)
        Me.BTN_UpdateCartItem.TabIndex = 65
        Me.BTN_UpdateCartItem.Text = "Update Cart Item"
        Me.BTN_UpdateCartItem.UseVisualStyleBackColor = False
        '
        'BTN_AddToCart
        '
        Me.BTN_AddToCart.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.BTN_AddToCart.FlatAppearance.BorderSize = 0
        Me.BTN_AddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_AddToCart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_AddToCart.ForeColor = System.Drawing.Color.White
        Me.BTN_AddToCart.Location = New System.Drawing.Point(171, 199)
        Me.BTN_AddToCart.Name = "BTN_AddToCart"
        Me.BTN_AddToCart.Size = New System.Drawing.Size(138, 26)
        Me.BTN_AddToCart.TabIndex = 64
        Me.BTN_AddToCart.Text = "ADD TO CART"
        Me.BTN_AddToCart.UseVisualStyleBackColor = False
        '
        'TXT_TotalItemPrice
        '
        Me.TXT_TotalItemPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_TotalItemPrice.Location = New System.Drawing.Point(170, 164)
        Me.TXT_TotalItemPrice.Margin = New System.Windows.Forms.Padding(0)
        Me.TXT_TotalItemPrice.Name = "TXT_TotalItemPrice"
        Me.TXT_TotalItemPrice.ReadOnly = True
        Me.TXT_TotalItemPrice.Size = New System.Drawing.Size(139, 20)
        Me.TXT_TotalItemPrice.TabIndex = 62
        '
        'TXT_ItemPrice
        '
        Me.TXT_ItemPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_ItemPrice.Location = New System.Drawing.Point(170, 127)
        Me.TXT_ItemPrice.Margin = New System.Windows.Forms.Padding(0)
        Me.TXT_ItemPrice.Name = "TXT_ItemPrice"
        Me.TXT_ItemPrice.ReadOnly = True
        Me.TXT_ItemPrice.Size = New System.Drawing.Size(139, 20)
        Me.TXT_ItemPrice.TabIndex = 61
        '
        'TXT_Stocks
        '
        Me.TXT_Stocks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_Stocks.Location = New System.Drawing.Point(246, 88)
        Me.TXT_Stocks.Margin = New System.Windows.Forms.Padding(0)
        Me.TXT_Stocks.Name = "TXT_Stocks"
        Me.TXT_Stocks.ReadOnly = True
        Me.TXT_Stocks.Size = New System.Drawing.Size(63, 20)
        Me.TXT_Stocks.TabIndex = 60
        '
        'CBO_ProductName
        '
        Me.CBO_ProductName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBO_ProductName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CBO_ProductName.FormattingEnabled = True
        Me.CBO_ProductName.Location = New System.Drawing.Point(170, 47)
        Me.CBO_ProductName.Margin = New System.Windows.Forms.Padding(0)
        Me.CBO_ProductName.Name = "CBO_ProductName"
        Me.CBO_ProductName.Size = New System.Drawing.Size(139, 21)
        Me.CBO_ProductName.TabIndex = 57
        '
        'NMRC_Quantity
        '
        Me.NMRC_Quantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NMRC_Quantity.Location = New System.Drawing.Point(170, 88)
        Me.NMRC_Quantity.Margin = New System.Windows.Forms.Padding(0)
        Me.NMRC_Quantity.Name = "NMRC_Quantity"
        Me.NMRC_Quantity.ReadOnly = True
        Me.NMRC_Quantity.Size = New System.Drawing.Size(70, 20)
        Me.NMRC_Quantity.TabIndex = 58
        '
        'CartDataGridView
        '
        Me.CartDataGridView.AllowUserToAddRows = False
        Me.CartDataGridView.AllowUserToDeleteRows = False
        Me.CartDataGridView.AllowUserToResizeColumns = False
        Me.CartDataGridView.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CartDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.CartDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CartDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.CartDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.CartDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CartDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.CartDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Pink
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LavenderBlush
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CartDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.CartDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CartDataGridView.Cursor = System.Windows.Forms.Cursors.Arrow
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CartDataGridView.DefaultCellStyle = DataGridViewCellStyle3
        Me.CartDataGridView.GridColor = System.Drawing.SystemColors.ButtonFace
        Me.CartDataGridView.Location = New System.Drawing.Point(343, 49)
        Me.CartDataGridView.Margin = New System.Windows.Forms.Padding(0)
        Me.CartDataGridView.MultiSelect = False
        Me.CartDataGridView.Name = "CartDataGridView"
        Me.CartDataGridView.ReadOnly = True
        Me.CartDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CartDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.CartDataGridView.RowHeadersVisible = False
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LavenderBlush
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CartDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.CartDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.CartDataGridView.RowTemplate.ReadOnly = True
        Me.CartDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CartDataGridView.ShowEditingIcon = False
        Me.CartDataGridView.Size = New System.Drawing.Size(579, 200)
        Me.CartDataGridView.TabIndex = 46
        '
        'TABPAGE_Pay
        '
        Me.TABPAGE_Pay.BackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.TABPAGE_Pay.Controls.Add(Me.Label10)
        Me.TABPAGE_Pay.Controls.Add(Me.Label9)
        Me.TABPAGE_Pay.Controls.Add(Me.Label8)
        Me.TABPAGE_Pay.Controls.Add(Me.Label7)
        Me.TABPAGE_Pay.Controls.Add(Me.BTN_DoneTransaction)
        Me.TABPAGE_Pay.Controls.Add(Me.BTN_Pay)
        Me.TABPAGE_Pay.Controls.Add(Me.TXT_CustomerName)
        Me.TABPAGE_Pay.Controls.Add(Me.TXT_TransactionID)
        Me.TABPAGE_Pay.Controls.Add(Me.CartDataGridView_COPY)
        Me.TABPAGE_Pay.Controls.Add(Me.GroupBox2)
        Me.TABPAGE_Pay.Controls.Add(Me.TransactionDataGridView)
        Me.TABPAGE_Pay.Location = New System.Drawing.Point(4, 22)
        Me.TABPAGE_Pay.Name = "TABPAGE_Pay"
        Me.TABPAGE_Pay.Padding = New System.Windows.Forms.Padding(3)
        Me.TABPAGE_Pay.Size = New System.Drawing.Size(972, 637)
        Me.TABPAGE_Pay.TabIndex = 1
        Me.TABPAGE_Pay.Text = "Pay"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(353, 142)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(200, 20)
        Me.Label10.TabIndex = 77
        Me.Label10.Text = "Transaction Information"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(353, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(140, 20)
        Me.Label9.TabIndex = 76
        Me.Label9.Text = "Cart Information"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(13, 75)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(137, 20)
        Me.Label8.TabIndex = 75
        Me.Label8.Text = "Customer Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(13, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(127, 20)
        Me.Label7.TabIndex = 74
        Me.Label7.Text = "Transaction ID"
        '
        'BTN_DoneTransaction
        '
        Me.BTN_DoneTransaction.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.BTN_DoneTransaction.Enabled = False
        Me.BTN_DoneTransaction.FlatAppearance.BorderSize = 0
        Me.BTN_DoneTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_DoneTransaction.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_DoneTransaction.ForeColor = System.Drawing.Color.White
        Me.BTN_DoneTransaction.Location = New System.Drawing.Point(777, 510)
        Me.BTN_DoneTransaction.Name = "BTN_DoneTransaction"
        Me.BTN_DoneTransaction.Size = New System.Drawing.Size(128, 50)
        Me.BTN_DoneTransaction.TabIndex = 67
        Me.BTN_DoneTransaction.Text = "DONE"
        Me.BTN_DoneTransaction.UseVisualStyleBackColor = False
        '
        'BTN_Pay
        '
        Me.BTN_Pay.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.BTN_Pay.FlatAppearance.BorderSize = 0
        Me.BTN_Pay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_Pay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Pay.ForeColor = System.Drawing.Color.White
        Me.BTN_Pay.Location = New System.Drawing.Point(633, 510)
        Me.BTN_Pay.Name = "BTN_Pay"
        Me.BTN_Pay.Size = New System.Drawing.Size(128, 50)
        Me.BTN_Pay.TabIndex = 66
        Me.BTN_Pay.Text = "PAY"
        Me.BTN_Pay.UseVisualStyleBackColor = False
        '
        'TXT_CustomerName
        '
        Me.TXT_CustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_CustomerName.Location = New System.Drawing.Point(156, 75)
        Me.TXT_CustomerName.Margin = New System.Windows.Forms.Padding(0)
        Me.TXT_CustomerName.Name = "TXT_CustomerName"
        Me.TXT_CustomerName.Size = New System.Drawing.Size(173, 20)
        Me.TXT_CustomerName.TabIndex = 65
        '
        'TXT_TransactionID
        '
        Me.TXT_TransactionID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_TransactionID.Location = New System.Drawing.Point(156, 43)
        Me.TXT_TransactionID.Margin = New System.Windows.Forms.Padding(0)
        Me.TXT_TransactionID.Name = "TXT_TransactionID"
        Me.TXT_TransactionID.ReadOnly = True
        Me.TXT_TransactionID.Size = New System.Drawing.Size(173, 20)
        Me.TXT_TransactionID.TabIndex = 64
        '
        'CartDataGridView_COPY
        '
        Me.CartDataGridView_COPY.AllowUserToAddRows = False
        Me.CartDataGridView_COPY.AllowUserToDeleteRows = False
        Me.CartDataGridView_COPY.AllowUserToResizeColumns = False
        Me.CartDataGridView_COPY.AllowUserToResizeRows = False
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CartDataGridView_COPY.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.CartDataGridView_COPY.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CartDataGridView_COPY.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.CartDataGridView_COPY.BackgroundColor = System.Drawing.Color.White
        Me.CartDataGridView_COPY.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CartDataGridView_COPY.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.CartDataGridView_COPY.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.Pink
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LavenderBlush
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CartDataGridView_COPY.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.CartDataGridView_COPY.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CartDataGridView_COPY.Cursor = System.Windows.Forms.Cursors.Arrow
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CartDataGridView_COPY.DefaultCellStyle = DataGridViewCellStyle8
        Me.CartDataGridView_COPY.GridColor = System.Drawing.SystemColors.ButtonFace
        Me.CartDataGridView_COPY.Location = New System.Drawing.Point(357, 46)
        Me.CartDataGridView_COPY.Margin = New System.Windows.Forms.Padding(0)
        Me.CartDataGridView_COPY.MultiSelect = False
        Me.CartDataGridView_COPY.Name = "CartDataGridView_COPY"
        Me.CartDataGridView_COPY.ReadOnly = True
        Me.CartDataGridView_COPY.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CartDataGridView_COPY.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.CartDataGridView_COPY.RowHeadersVisible = False
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.LavenderBlush
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CartDataGridView_COPY.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.CartDataGridView_COPY.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.CartDataGridView_COPY.RowTemplate.ReadOnly = True
        Me.CartDataGridView_COPY.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CartDataGridView_COPY.ShowEditingIcon = False
        Me.CartDataGridView_COPY.Size = New System.Drawing.Size(581, 82)
        Me.CartDataGridView_COPY.TabIndex = 62
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.TXT_Cash)
        Me.GroupBox2.Controls.Add(Me.TXT_Change)
        Me.GroupBox2.Controls.Add(Me.TXT_OverallTotal)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(23, 293)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(915, 196)
        Me.GroupBox2.TabIndex = 44
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cash"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(234, 143)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(103, 29)
        Me.Label13.TabIndex = 80
        Me.Label13.Text = "Change"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(265, 89)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 29)
        Me.Label12.TabIndex = 79
        Me.Label12.Text = "Cash"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(178, 33)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(164, 29)
        Me.Label11.TabIndex = 78
        Me.Label11.Text = "Overall Total"
        '
        'TXT_Cash
        '
        Me.TXT_Cash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_Cash.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_Cash.Location = New System.Drawing.Point(368, 86)
        Me.TXT_Cash.Margin = New System.Windows.Forms.Padding(0)
        Me.TXT_Cash.Name = "TXT_Cash"
        Me.TXT_Cash.Size = New System.Drawing.Size(514, 35)
        Me.TXT_Cash.TabIndex = 68
        Me.TXT_Cash.Text = "0.00"
        '
        'TXT_Change
        '
        Me.TXT_Change.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_Change.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_Change.Location = New System.Drawing.Point(368, 140)
        Me.TXT_Change.Margin = New System.Windows.Forms.Padding(0)
        Me.TXT_Change.Name = "TXT_Change"
        Me.TXT_Change.ReadOnly = True
        Me.TXT_Change.Size = New System.Drawing.Size(514, 35)
        Me.TXT_Change.TabIndex = 67
        Me.TXT_Change.Text = "0.00"
        '
        'TXT_OverallTotal
        '
        Me.TXT_OverallTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_OverallTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_OverallTotal.Location = New System.Drawing.Point(368, 30)
        Me.TXT_OverallTotal.Margin = New System.Windows.Forms.Padding(0)
        Me.TXT_OverallTotal.Name = "TXT_OverallTotal"
        Me.TXT_OverallTotal.ReadOnly = True
        Me.TXT_OverallTotal.Size = New System.Drawing.Size(514, 35)
        Me.TXT_OverallTotal.TabIndex = 66
        Me.TXT_OverallTotal.Text = "0.00"
        '
        'TransactionDataGridView
        '
        Me.TransactionDataGridView.AllowUserToAddRows = False
        Me.TransactionDataGridView.AllowUserToDeleteRows = False
        Me.TransactionDataGridView.AllowUserToResizeColumns = False
        Me.TransactionDataGridView.AllowUserToResizeRows = False
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TransactionDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11
        Me.TransactionDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TransactionDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.TransactionDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.TransactionDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TransactionDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.TransactionDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.Pink
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.LavenderBlush
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TransactionDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.TransactionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TransactionDataGridView.Cursor = System.Windows.Forms.Cursors.Arrow
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TransactionDataGridView.DefaultCellStyle = DataGridViewCellStyle13
        Me.TransactionDataGridView.GridColor = System.Drawing.SystemColors.ButtonFace
        Me.TransactionDataGridView.Location = New System.Drawing.Point(357, 173)
        Me.TransactionDataGridView.Margin = New System.Windows.Forms.Padding(0)
        Me.TransactionDataGridView.MultiSelect = False
        Me.TransactionDataGridView.Name = "TransactionDataGridView"
        Me.TransactionDataGridView.ReadOnly = True
        Me.TransactionDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TransactionDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.TransactionDataGridView.RowHeadersVisible = False
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.LavenderBlush
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TransactionDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle15
        Me.TransactionDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.TransactionDataGridView.RowTemplate.ReadOnly = True
        Me.TransactionDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TransactionDataGridView.ShowEditingIcon = False
        Me.TransactionDataGridView.Size = New System.Drawing.Size(581, 117)
        Me.TransactionDataGridView.TabIndex = 54
        '
        'FRM_Cashier_Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 738)
        Me.Controls.Add(Me.PNL_ChildForm)
        Me.Controls.Add(Me.PNL_TitleBar)
        Me.Controls.Add(Me.PNL_Menu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRM_Cashier_Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cashier Dashboard"
        Me.PNL_Menu.ResumeLayout(False)
        Me.PNL_Menu.PerformLayout()
        Me.PNL_TitleBar.ResumeLayout(False)
        Me.PNL_TitleBar.PerformLayout()
        Me.PNL_ChildForm.ResumeLayout(False)
        Me.TABCONTROL_Main.ResumeLayout(False)
        Me.TABPAGE_Checkout.ResumeLayout(False)
        Me.TABPAGE_Checkout.PerformLayout()
        CType(Me.NMRC_Quantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CartDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TABPAGE_Pay.ResumeLayout(False)
        Me.TABPAGE_Pay.PerformLayout()
        CType(Me.CartDataGridView_COPY, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.TransactionDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PNL_Menu As Panel
    Friend WithEvents LBLUsernameWelcome As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PNL_TitleBar As Panel
    Friend WithEvents LBL_CurrentFormTitle As Label
    Friend WithEvents PNL_ChildForm As Panel
    Friend WithEvents CartDataGridView As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TransactionDataGridView As DataGridView
    Friend WithEvents CartDataGridView_COPY As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents NMRC_Quantity As NumericUpDown
    Friend WithEvents CBO_ProductName As ComboBox
    Friend WithEvents TABCONTROL_Main As TabControl
    Friend WithEvents TABPAGE_Checkout As TabPage
    Friend WithEvents TABPAGE_Pay As TabPage
    Friend WithEvents TXT_Stocks As TextBox
    Friend WithEvents BTN_AddToCart As Button
    Friend WithEvents BTN_ManageProducts As Button
    Friend WithEvents TXT_ItemPrice As TextBox
    Friend WithEvents TXT_TotalItemPrice As TextBox
    Friend WithEvents BTN_UpdateCartItem As Button
    Friend WithEvents BTN_DeleteCartItem As Button
    Friend WithEvents BTN_DoneCartEditing As Button
    Friend WithEvents TXT_TotalAmountCheckOut As TextBox
    Friend WithEvents BTN_CheckOut As Button
    Friend WithEvents TXT_CustomerName As TextBox
    Friend WithEvents TXT_TransactionID As TextBox
    Friend WithEvents TXT_OverallTotal As TextBox
    Friend WithEvents TXT_Cash As TextBox
    Friend WithEvents TXT_Change As TextBox
    Friend WithEvents BTN_Pay As Button
    Friend WithEvents BTN_DoneTransaction As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents BTN_Exit As Button
End Class
