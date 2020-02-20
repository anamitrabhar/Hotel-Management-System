<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckoutForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CheckoutForm))
        Me.btnback = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.btncheckin = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnplus = New System.Windows.Forms.PictureBox()
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
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.btnback, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.btnplus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnback)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(696, 46)
        Me.Panel1.TabIndex = 1
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
        Me.btncheckin.Text = "Check-Out"
        Me.btncheckin.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.TextBox14)
        Me.Panel4.Controls.Add(Me.TextBox13)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.PictureBox7)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.btncheckin)
        Me.Panel4.Location = New System.Drawing.Point(3, 474)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(690, 70)
        Me.Panel4.TabIndex = 53
        '
        'TextBox13
        '
        Me.TextBox13.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox13.Location = New System.Drawing.Point(91, 16)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(97, 29)
        Me.TextBox13.TabIndex = 82
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 21)
        Me.Label1.TabIndex = 81
        Me.Label1.Text = "CASH :-"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnplus)
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
        Me.Panel2.Controls.Add(Me.TextBox7)
        Me.Panel2.Controls.Add(Me.TextBox6)
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
        Me.Panel2.Location = New System.Drawing.Point(3, 52)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(690, 416)
        Me.Panel2.TabIndex = 54
        '
        'btnplus
        '
        Me.btnplus.Image = CType(resources.GetObject("btnplus.Image"), System.Drawing.Image)
        Me.btnplus.Location = New System.Drawing.Point(383, 84)
        Me.btnplus.Name = "btnplus"
        Me.btnplus.Size = New System.Drawing.Size(35, 30)
        Me.btnplus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnplus.TabIndex = 80
        Me.btnplus.TabStop = False
        '
        'TextBox12
        '
        Me.TextBox12.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox12.Location = New System.Drawing.Point(584, 381)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(97, 29)
        Me.TextBox12.TabIndex = 79
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(459, 385)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(119, 21)
        Me.Label17.TabIndex = 78
        Me.Label17.Text = "Total Balance :-"
        '
        'TextBox11
        '
        Me.TextBox11.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox11.Location = New System.Drawing.Point(584, 344)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(97, 29)
        Me.TextBox11.TabIndex = 77
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(487, 346)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(91, 21)
        Me.Label16.TabIndex = 76
        Me.Label16.Text = "Sub Total :-"
        '
        'TextBox10
        '
        Me.TextBox10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox10.Location = New System.Drawing.Point(584, 307)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(97, 29)
        Me.TextBox10.TabIndex = 75
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(415, 307)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(163, 21)
        Me.Label15.TabIndex = 74
        Me.Label15.Text = "Advance Payement :-"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(546, 53)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(109, 20)
        Me.DateTimePicker1.TabIndex = 73
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(403, 52)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(137, 21)
        Me.Label14.TabIndex = 72
        Me.Label14.Text = "Check Out Date :-"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(403, 22)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(124, 21)
        Me.Label13.TabIndex = 71
        Me.Label13.Text = "Check In Date :-"
        '
        'TextBox9
        '
        Me.TextBox9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox9.Location = New System.Drawing.Point(392, 122)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(180, 29)
        Me.TextBox9.TabIndex = 70
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(279, 122)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(107, 21)
        Me.Label12.TabIndex = 69
        Me.Label12.Text = "Room Type :-"
        '
        'TextBox8
        '
        Me.TextBox8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.Location = New System.Drawing.Point(161, 270)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(122, 29)
        Me.TextBox8.TabIndex = 68
        '
        'TextBox7
        '
        Me.TextBox7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(484, 236)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(62, 29)
        Me.TextBox7.TabIndex = 67
        '
        'TextBox6
        '
        Me.TextBox6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(161, 233)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(62, 29)
        Me.TextBox6.TabIndex = 66
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(161, 196)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(49, 29)
        Me.TextBox5.TabIndex = 65
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(161, 159)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(97, 29)
        Me.TextBox4.TabIndex = 64
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(161, 122)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(97, 29)
        Me.TextBox3.TabIndex = 63
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(161, 84)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(216, 29)
        Me.TextBox2.TabIndex = 62
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(42, 87)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(113, 21)
        Me.Label11.TabIndex = 61
        Me.Label11.Text = "Guest Name :-"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(57, 122)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(98, 21)
        Me.Label10.TabIndex = 60
        Me.Label10.Text = "Room No. :-"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(50, 159)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 21)
        Me.Label9.TabIndex = 59
        Me.Label9.Text = "Room Rate :-"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(47, 196)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 21)
        Me.Label8.TabIndex = 58
        Me.Label8.Text = "No. of Days :-"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(34, 235)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 21)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = "No. of Adults :-"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(28, 274)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(127, 21)
        Me.Label6.TabIndex = 56
        Me.Label6.Text = "Discount Type :-"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(343, 239)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(135, 21)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "No. of Children :-"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(28, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 21)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "Transaction ID :-"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(7, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 26)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 53
        Me.PictureBox2.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(7, 5)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(166, 26)
        Me.TextBox1.TabIndex = 52
        Me.TextBox1.Text = "Check Out"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox14
        '
        Me.TextBox14.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox14.Location = New System.Drawing.Point(316, 16)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(97, 29)
        Me.TextBox14.TabIndex = 84
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(215, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 21)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "CHANGE :-"
        '
        'CheckoutForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "CheckoutForm"
        Me.Size = New System.Drawing.Size(696, 547)
        CType(Me.btnback, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.btnplus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnback As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents btncheckin As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
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
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnplus As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
