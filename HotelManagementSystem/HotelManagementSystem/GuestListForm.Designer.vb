<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GuestListForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GuestListForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnback = New System.Windows.Forms.PictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
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
        Me.Panel1.TabIndex = 51
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
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 118)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(670, 423)
        Me.DataGridView1.TabIndex = 53
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(23, 64)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(154, 26)
        Me.TextBox1.TabIndex = 52
        Me.TextBox1.Text = "Guest List"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RectangleShape1
        '
        Me.RectangleShape1.CornerRadius = 5
        Me.RectangleShape1.Location = New System.Drawing.Point(6, 51)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(683, 53)
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape2, Me.RectangleShape1})
        Me.ShapeContainer2.Size = New System.Drawing.Size(696, 547)
        Me.ShapeContainer2.TabIndex = 54
        Me.ShapeContainer2.TabStop = False
        '
        'RectangleShape2
        '
        Me.RectangleShape2.CornerRadius = 5
        Me.RectangleShape2.Location = New System.Drawing.Point(6, 111)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(683, 433)
        '
        'GuestListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ShapeContainer2)
        Me.Name = "GuestListForm"
        Me.Size = New System.Drawing.Size(696, 547)
        Me.Panel1.ResumeLayout(False)
        CType(Me.btnback, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnback As System.Windows.Forms.PictureBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer2 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape

End Class
