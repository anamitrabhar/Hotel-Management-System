<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DiscountForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DiscountForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnback = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btncheckin = New System.Windows.Forms.Button()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Panel1.SuspendLayout()
        CType(Me.btnback, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
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
        Me.Panel1.TabIndex = 2
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
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.TextBox3)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.TextBox2)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Location = New System.Drawing.Point(3, 52)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(690, 204)
        Me.Panel2.TabIndex = 55
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(252, 59)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(216, 29)
        Me.TextBox2.TabIndex = 62
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(119, 62)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(127, 21)
        Me.Label11.TabIndex = 61
        Me.Label11.Text = "Discount Type :-"
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
        Me.TextBox1.Text = "Discount"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(252, 109)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(216, 29)
        Me.TextBox3.TabIndex = 64
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(94, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 21)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Discount Rate (%) :-"
        '
        'btncheckin
        '
        Me.btncheckin.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.btncheckin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncheckin.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncheckin.ForeColor = System.Drawing.Color.White
        Me.btncheckin.Location = New System.Drawing.Point(224, 274)
        Me.btncheckin.Name = "btncheckin"
        Me.btncheckin.Size = New System.Drawing.Size(248, 36)
        Me.btncheckin.TabIndex = 56
        Me.btncheckin.Text = "Submit"
        Me.btncheckin.UseVisualStyleBackColor = False
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(696, 547)
        Me.ShapeContainer1.TabIndex = 57
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.CornerRadius = 5
        Me.RectangleShape1.Location = New System.Drawing.Point(153, 328)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(395, 208)
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(163, 337)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(376, 191)
        Me.ListView1.TabIndex = 58
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'DiscountForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.btncheckin)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "DiscountForm"
        Me.Size = New System.Drawing.Size(696, 547)
        Me.Panel1.ResumeLayout(False)
        CType(Me.btnback, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnback As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btncheckin As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents ListView1 As System.Windows.Forms.ListView

End Class
