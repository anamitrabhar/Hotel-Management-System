<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckinForm
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CheckinForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnback = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.btnremove = New System.Windows.Forms.PictureBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.btnadd = New System.Windows.Forms.PictureBox()
        Me.btnminus = New System.Windows.Forms.PictureBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.btnplus = New System.Windows.Forms.PictureBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btncheckin = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.btnback, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.btnremove, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnadd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnminus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnplus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnback)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(696, 46)
        Me.Panel1.TabIndex = 0
        '
        'btnback
        '
        Me.btnback.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.btnback.Image = CType(resources.GetObject("btnback.Image"), System.Drawing.Image)
        Me.btnback.Location = New System.Drawing.Point(9, 9)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(30, 31)
        Me.btnback.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnback.TabIndex = 52
        Me.btnback.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(3, 3)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(166, 26)
        Me.TextBox1.TabIndex = 4
        Me.TextBox1.Text = "Check In"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.TextBox12)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.TextBox11)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.TextBox10)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.DateTimePicker1)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.TextBox9)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.TextBox8)
        Me.Panel2.Controls.Add(Me.btnremove)
        Me.Panel2.Controls.Add(Me.TextBox7)
        Me.Panel2.Controls.Add(Me.btnadd)
        Me.Panel2.Controls.Add(Me.btnminus)
        Me.Panel2.Controls.Add(Me.TextBox6)
        Me.Panel2.Controls.Add(Me.btnplus)
        Me.Panel2.Controls.Add(Me.TextBox5)
        Me.Panel2.Controls.Add(Me.TextBox4)
        Me.Panel2.Controls.Add(Me.TextBox3)
        Me.Panel2.Controls.Add(Me.TextBox2)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Location = New System.Drawing.Point(3, 49)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(690, 419)
        Me.Panel2.TabIndex = 21
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Location = New System.Drawing.Point(-1, 424)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(690, 70)
        Me.Panel3.TabIndex = 24
        '
        'TextBox12
        '
        Me.TextBox12.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox12.Location = New System.Drawing.Point(580, 379)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(97, 29)
        Me.TextBox12.TabIndex = 51
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(455, 383)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(119, 21)
        Me.Label17.TabIndex = 50
        Me.Label17.Text = "Total Balance :-"
        '
        'TextBox11
        '
        Me.TextBox11.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox11.Location = New System.Drawing.Point(580, 342)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(97, 29)
        Me.TextBox11.TabIndex = 49
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(483, 344)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(91, 21)
        Me.Label16.TabIndex = 48
        Me.Label16.Text = "Sub Total :-"
        '
        'TextBox10
        '
        Me.TextBox10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox10.Location = New System.Drawing.Point(580, 305)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(97, 29)
        Me.TextBox10.TabIndex = 47
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(411, 305)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(163, 21)
        Me.Label15.TabIndex = 46
        Me.Label15.Text = "Advance Payement :-"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(542, 62)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(109, 20)
        Me.DateTimePicker1.TabIndex = 45
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(399, 62)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(137, 21)
        Me.Label14.TabIndex = 44
        Me.Label14.Text = "Check Out Date :-"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(399, 31)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(124, 21)
        Me.Label13.TabIndex = 43
        Me.Label13.Text = "Check In Date :-"
        '
        'TextBox9
        '
        Me.TextBox9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox9.Location = New System.Drawing.Point(388, 120)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(180, 29)
        Me.TextBox9.TabIndex = 42
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(275, 120)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(107, 21)
        Me.Label12.TabIndex = 41
        Me.Label12.Text = "Room Type :-"
        '
        'TextBox8
        '
        Me.TextBox8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.Location = New System.Drawing.Point(157, 269)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(122, 29)
        Me.TextBox8.TabIndex = 40
        '
        'btnremove
        '
        Me.btnremove.Image = CType(resources.GetObject("btnremove.Image"), System.Drawing.Image)
        Me.btnremove.Location = New System.Drawing.Point(589, 234)
        Me.btnremove.Name = "btnremove"
        Me.btnremove.Size = New System.Drawing.Size(35, 30)
        Me.btnremove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnremove.TabIndex = 39
        Me.btnremove.TabStop = False
        '
        'TextBox7
        '
        Me.TextBox7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(521, 234)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(62, 29)
        Me.TextBox7.TabIndex = 38
        '
        'btnadd
        '
        Me.btnadd.Image = CType(resources.GetObject("btnadd.Image"), System.Drawing.Image)
        Me.btnadd.Location = New System.Drawing.Point(480, 233)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(35, 30)
        Me.btnadd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnadd.TabIndex = 37
        Me.btnadd.TabStop = False
        '
        'btnminus
        '
        Me.btnminus.Image = CType(resources.GetObject("btnminus.Image"), System.Drawing.Image)
        Me.btnminus.Location = New System.Drawing.Point(266, 233)
        Me.btnminus.Name = "btnminus"
        Me.btnminus.Size = New System.Drawing.Size(35, 30)
        Me.btnminus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnminus.TabIndex = 36
        Me.btnminus.TabStop = False
        '
        'TextBox6
        '
        Me.TextBox6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(198, 234)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(62, 29)
        Me.TextBox6.TabIndex = 35
        '
        'btnplus
        '
        Me.btnplus.Image = CType(resources.GetObject("btnplus.Image"), System.Drawing.Image)
        Me.btnplus.Location = New System.Drawing.Point(157, 233)
        Me.btnplus.Name = "btnplus"
        Me.btnplus.Size = New System.Drawing.Size(35, 30)
        Me.btnplus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnplus.TabIndex = 34
        Me.btnplus.TabStop = False
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(157, 194)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(49, 29)
        Me.TextBox5.TabIndex = 33
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(157, 157)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(97, 29)
        Me.TextBox4.TabIndex = 32
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(157, 120)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(97, 29)
        Me.TextBox3.TabIndex = 31
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(157, 82)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(216, 29)
        Me.TextBox2.TabIndex = 30
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(38, 85)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(113, 21)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Guest Name :-"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(53, 120)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(98, 21)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Room No. :-"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(46, 157)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 21)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Room Rate :-"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(43, 194)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 21)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "No. of Days :-"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(30, 233)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 21)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "No. of Adults :-"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 272)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(127, 21)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Discount Type :-"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(339, 237)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(135, 21)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "No. of Children :-"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 21)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Transaction ID :-"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 26)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 20
        Me.PictureBox2.TabStop = False
        '
        'btncheckin
        '
        Me.btncheckin.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.btncheckin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncheckin.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncheckin.ForeColor = System.Drawing.Color.White
        Me.btncheckin.Location = New System.Drawing.Point(487, 13)
        Me.btncheckin.Name = "btncheckin"
        Me.btncheckin.Size = New System.Drawing.Size(183, 40)
        Me.btncheckin.TabIndex = 22
        Me.btncheckin.Text = "Check-In"
        Me.btncheckin.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.PictureBox7)
        Me.Panel4.Controls.Add(Me.btncheckin)
        Me.Panel4.Location = New System.Drawing.Point(3, 474)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(690, 70)
        Me.Panel4.TabIndex = 24
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(491, 19)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(32, 27)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 24
        Me.PictureBox7.TabStop = False
        '
        'CheckinForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "CheckinForm"
        Me.Size = New System.Drawing.Size(696, 547)
        Me.Panel1.ResumeLayout(False)
        CType(Me.btnback, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.btnremove, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnadd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnminus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnplus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents btnback As System.Windows.Forms.PictureBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnremove As System.Windows.Forms.PictureBox
    Friend WithEvents btnadd As System.Windows.Forms.PictureBox
    Friend WithEvents btnminus As System.Windows.Forms.PictureBox
    Friend WithEvents btnplus As System.Windows.Forms.PictureBox
    Friend WithEvents btncheckin As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox

End Class
