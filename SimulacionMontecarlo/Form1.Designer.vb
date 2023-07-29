<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Title2 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Title3 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Title4 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Chart100 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart200 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart500 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart1000 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.Chart100, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart200, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart500, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1000, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.LavenderBlush
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.TextBox2)
        Me.TabPage1.Controls.Add(Me.TextBox1)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.TableLayoutPanel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1349, 661)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Simulacion Montecarlo Area Bajo La Curva"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Malgun Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(138, 103)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 37)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Calcular"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Malgun Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(233, 409)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(199, 25)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Area de 1000 Puntos"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Malgun Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(26, 409)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(188, 25)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Area de 500 Puntos"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Malgun Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(233, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(188, 25)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Area de 200 Puntos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Malgun Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Area de 100 Puntos"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(245, 59)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(132, 22)
        Me.TextBox2.TabIndex = 9
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(50, 59)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(132, 22)
        Me.TextBox1.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Malgun Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(205, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "b:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Malgun Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "a:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Malgun Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(389, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ingrese el rango (a,b) en el que desea calcular el área:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Chart100, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Chart200, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Chart500, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Chart1000, 1, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(442, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(902, 662)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Chart100
        '
        Me.Chart100.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ChartArea1.Name = "ChartArea1"
        Me.Chart100.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart100.Legends.Add(Legend1)
        Me.Chart100.Location = New System.Drawing.Point(3, 3)
        Me.Chart100.Name = "Chart100"
        Me.Chart100.Size = New System.Drawing.Size(445, 325)
        Me.Chart100.TabIndex = 8
        Me.Chart100.Text = "Chart1"
        Title1.BackColor = System.Drawing.Color.DarkOrchid
        Title1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Title1.Font = New System.Drawing.Font("Malgun Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title1.Name = "Title1"
        Title1.Text = "100 PUNTOS"
        Me.Chart100.Titles.Add(Title1)
        '
        'Chart200
        '
        Me.Chart200.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ChartArea2.Name = "ChartArea1"
        Me.Chart200.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.Chart200.Legends.Add(Legend2)
        Me.Chart200.Location = New System.Drawing.Point(454, 3)
        Me.Chart200.Name = "Chart200"
        Me.Chart200.Size = New System.Drawing.Size(445, 325)
        Me.Chart200.TabIndex = 7
        Me.Chart200.Text = "Chart2"
        Title2.BackColor = System.Drawing.Color.Thistle
        Title2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Title2.Font = New System.Drawing.Font("Malgun Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title2.Name = "Title1"
        Title2.Text = "200 PUNTOS"
        Me.Chart200.Titles.Add(Title2)
        '
        'Chart500
        '
        Me.Chart500.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ChartArea3.Name = "ChartArea1"
        Me.Chart500.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Me.Chart500.Legends.Add(Legend3)
        Me.Chart500.Location = New System.Drawing.Point(3, 334)
        Me.Chart500.Name = "Chart500"
        Me.Chart500.Size = New System.Drawing.Size(445, 325)
        Me.Chart500.TabIndex = 7
        Me.Chart500.Text = "Chart3"
        Title3.BackColor = System.Drawing.Color.Plum
        Title3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Title3.Font = New System.Drawing.Font("Malgun Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title3.Name = "Title1"
        Title3.Text = "500 PUNTOS"
        Me.Chart500.Titles.Add(Title3)
        '
        'Chart1000
        '
        Me.Chart1000.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ChartArea4.Name = "ChartArea1"
        Me.Chart1000.ChartAreas.Add(ChartArea4)
        Legend4.Name = "Legend1"
        Me.Chart1000.Legends.Add(Legend4)
        Me.Chart1000.Location = New System.Drawing.Point(454, 334)
        Me.Chart1000.Name = "Chart1000"
        Me.Chart1000.Size = New System.Drawing.Size(445, 325)
        Me.Chart1000.TabIndex = 8
        Me.Chart1000.Text = "Chart4"
        Title4.BackColor = System.Drawing.Color.LavenderBlush
        Title4.BorderColor = System.Drawing.Color.DarkSlateGray
        Title4.Font = New System.Drawing.Font("Malgun Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title4.Name = "Title1"
        Title4.Text = "1000 PUNTOS"
        Me.Chart1000.Titles.Add(Title4)
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1357, 690)
        Me.TabControl1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1375, 702)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.Chart100, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart200, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart500, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1000, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Chart200 As DataVisualization.Charting.Chart
    Friend WithEvents Chart100 As DataVisualization.Charting.Chart
    Friend WithEvents Chart1000 As DataVisualization.Charting.Chart
    Friend WithEvents Chart500 As DataVisualization.Charting.Chart
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
End Class
