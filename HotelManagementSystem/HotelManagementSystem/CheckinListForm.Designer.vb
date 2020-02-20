<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckinListForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CheckinListForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnback = New System.Windows.Forms.PictureBox()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape4 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.btnback, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.TabIndex = 1
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
        'RectangleShape1
        '
        Me.RectangleShape1.CornerRadius = 5
        Me.RectangleShape1.Location = New System.Drawing.Point(5, 52)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(683, 46)
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape4, Me.RectangleShape3, Me.RectangleShape2, Me.RectangleShape1})
        Me.ShapeContainer2.Size = New System.Drawing.Size(696, 547)
        Me.ShapeContainer2.TabIndex = 2
        Me.ShapeContainer2.TabStop = False
        '
        'RectangleShape4
        '
        Me.RectangleShape4.CornerRadius = 5
        Me.RectangleShape4.Location = New System.Drawing.Point(7, 106)
        Me.RectangleShape4.Name = "RectangleShape4"
        Me.RectangleShape4.Size = New System.Drawing.Size(681, 434)
        '
        'RectangleShape3
        '
        Me.RectangleShape3.Location = New System.Drawing.Point(0, 0)
        Me.RectangleShape3.Name = "RectangleShape3"
        Me.RectangleShape3.Size = New System.Drawing.Size(75, 23)
        '
        'RectangleShape2
        '
        Me.RectangleShape2.Location = New System.Drawing.Point(0, 0)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(75, 23)
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(22, 62)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(166, 26)
        Me.TextBox1.TabIndex = 5
        Me.TextBox1.Text = "Check In List"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(310, 68)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(109, 20)
        Me.DateTimePicker1.TabIndex = 47
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(242, 65)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(62, 21)
        Me.Label14.TabIndex = 46
        Me.Label14.Text = "From :-"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CalendarFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(517, 68)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(109, 20)
        Me.DateTimePicker2.TabIndex = 49
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(470, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 21)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "To :-"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 112)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(670, 423)
        Me.DataGridView1.TabIndex = 50
        '
        'CheckinListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ShapeContainer2)
        Me.Name = "CheckinListForm"
        Me.Size = New System.Drawing.Size(696, 547)
        Me.Panel1.ResumeLayout(False)
        CType(Me.btnback, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnback As System.Windows.Forms.PictureBox
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer2 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents RectangleShape4 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape3 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView

End Class
