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
        Dim SLambatLabel As System.Windows.Forms.Label
        Dim LambatLabel As System.Windows.Forms.Label
        Dim CukupLabel As System.Windows.Forms.Label
        Dim CepatLabel As System.Windows.Forms.Label
        Dim SCepatLabel As System.Windows.Forms.Label
        Dim SJauhLabel As System.Windows.Forms.Label
        Dim AJauhLabel As System.Windows.Forms.Label
        Dim SedangLabel As System.Windows.Forms.Label
        Dim ADekatLabel As System.Windows.Forms.Label
        Dim SDekatLabel As System.Windows.Forms.Label
        Me.InferensiFuzzyLabel = New System.Windows.Forms.Label()
        Me.KecepatanLabel = New System.Windows.Forms.Label()
        Me.JarakLabel = New System.Windows.Forms.Label()
        Me.InputKecepatan = New System.Windows.Forms.TextBox()
        Me.InputJarak = New System.Windows.Forms.TextBox()
        Me.SLambatInput = New System.Windows.Forms.TextBox()
        Me.LambatInput = New System.Windows.Forms.TextBox()
        Me.CukupInput = New System.Windows.Forms.TextBox()
        Me.CepatInput = New System.Windows.Forms.TextBox()
        Me.SCepatInput = New System.Windows.Forms.TextBox()
        Me.SJauhInput = New System.Windows.Forms.TextBox()
        Me.AJauhInput = New System.Windows.Forms.TextBox()
        Me.SedangInput = New System.Windows.Forms.TextBox()
        Me.ADekatInput = New System.Windows.Forms.TextBox()
        Me.SDekatInput = New System.Windows.Forms.TextBox()
        Me.HitungButton = New System.Windows.Forms.Button()
        Me.SudutPengeremanLabel = New System.Windows.Forms.Label()
        Me.SudutPengeramanInput = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.AturanFuzzyListBox = New System.Windows.Forms.ListBox()
        SLambatLabel = New System.Windows.Forms.Label()
        LambatLabel = New System.Windows.Forms.Label()
        CukupLabel = New System.Windows.Forms.Label()
        CepatLabel = New System.Windows.Forms.Label()
        SCepatLabel = New System.Windows.Forms.Label()
        SJauhLabel = New System.Windows.Forms.Label()
        AJauhLabel = New System.Windows.Forms.Label()
        SedangLabel = New System.Windows.Forms.Label()
        ADekatLabel = New System.Windows.Forms.Label()
        SDekatLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'SLambatLabel
        '
        SLambatLabel.AutoSize = True
        SLambatLabel.Location = New System.Drawing.Point(23, 137)
        SLambatLabel.Name = "SLambatLabel"
        SLambatLabel.Size = New System.Drawing.Size(59, 15)
        SLambatLabel.TabIndex = 6
        SLambatLabel.Text = "S. Lambat"
        '
        'LambatLabel
        '
        LambatLabel.AutoSize = True
        LambatLabel.Location = New System.Drawing.Point(23, 166)
        LambatLabel.Name = "LambatLabel"
        LambatLabel.Size = New System.Drawing.Size(47, 15)
        LambatLabel.TabIndex = 8
        LambatLabel.Text = "Lambat"
        '
        'CukupLabel
        '
        CukupLabel.AutoSize = True
        CukupLabel.Location = New System.Drawing.Point(23, 195)
        CukupLabel.Name = "CukupLabel"
        CukupLabel.Size = New System.Drawing.Size(42, 15)
        CukupLabel.TabIndex = 10
        CukupLabel.Text = "Cukup"
        '
        'CepatLabel
        '
        CepatLabel.AutoSize = True
        CepatLabel.Location = New System.Drawing.Point(23, 224)
        CepatLabel.Name = "CepatLabel"
        CepatLabel.Size = New System.Drawing.Size(38, 15)
        CepatLabel.TabIndex = 12
        CepatLabel.Text = "Cepat"
        '
        'SCepatLabel
        '
        SCepatLabel.AutoSize = True
        SCepatLabel.Location = New System.Drawing.Point(23, 253)
        SCepatLabel.Name = "SCepatLabel"
        SCepatLabel.Size = New System.Drawing.Size(50, 15)
        SCepatLabel.TabIndex = 14
        SCepatLabel.Text = "S. Cepat"
        '
        'SJauhLabel
        '
        SJauhLabel.AutoSize = True
        SJauhLabel.Location = New System.Drawing.Point(23, 431)
        SJauhLabel.Name = "SJauhLabel"
        SJauhLabel.Size = New System.Drawing.Size(43, 15)
        SJauhLabel.TabIndex = 24
        SJauhLabel.Text = "S. Jauh"
        '
        'AJauhLabel
        '
        AJauhLabel.AutoSize = True
        AJauhLabel.Location = New System.Drawing.Point(23, 402)
        AJauhLabel.Name = "AJauhLabel"
        AJauhLabel.Size = New System.Drawing.Size(45, 15)
        AJauhLabel.TabIndex = 22
        AJauhLabel.Text = "A. Jauh"
        '
        'SedangLabel
        '
        SedangLabel.AutoSize = True
        SedangLabel.Location = New System.Drawing.Point(23, 373)
        SedangLabel.Name = "SedangLabel"
        SedangLabel.Size = New System.Drawing.Size(46, 15)
        SedangLabel.TabIndex = 20
        SedangLabel.Text = "Sedang"
        '
        'ADekatLabel
        '
        ADekatLabel.AutoSize = True
        ADekatLabel.Location = New System.Drawing.Point(23, 344)
        ADekatLabel.Name = "ADekatLabel"
        ADekatLabel.Size = New System.Drawing.Size(51, 15)
        ADekatLabel.TabIndex = 18
        ADekatLabel.Text = "A. Dekat"
        '
        'SDekatLabel
        '
        SDekatLabel.AutoSize = True
        SDekatLabel.Location = New System.Drawing.Point(23, 315)
        SDekatLabel.Name = "SDekatLabel"
        SDekatLabel.Size = New System.Drawing.Size(49, 15)
        SDekatLabel.TabIndex = 16
        SDekatLabel.Text = "S. Dekat"
        '
        'InferensiFuzzyLabel
        '
        Me.InferensiFuzzyLabel.AutoSize = True
        Me.InferensiFuzzyLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.InferensiFuzzyLabel.Location = New System.Drawing.Point(23, 9)
        Me.InferensiFuzzyLabel.Name = "InferensiFuzzyLabel"
        Me.InferensiFuzzyLabel.Size = New System.Drawing.Size(135, 21)
        Me.InferensiFuzzyLabel.TabIndex = 0
        Me.InferensiFuzzyLabel.Text = "INFERENSI FUZZY"
        '
        'KecepatanLabel
        '
        Me.KecepatanLabel.AutoSize = True
        Me.KecepatanLabel.Location = New System.Drawing.Point(23, 51)
        Me.KecepatanLabel.Name = "KecepatanLabel"
        Me.KecepatanLabel.Size = New System.Drawing.Size(62, 15)
        Me.KecepatanLabel.TabIndex = 1
        Me.KecepatanLabel.Text = "Kecepatan"
        '
        'JarakLabel
        '
        Me.JarakLabel.AutoSize = True
        Me.JarakLabel.Location = New System.Drawing.Point(23, 81)
        Me.JarakLabel.Name = "JarakLabel"
        Me.JarakLabel.Size = New System.Drawing.Size(33, 15)
        Me.JarakLabel.TabIndex = 3
        Me.JarakLabel.Text = "Jarak"
        '
        'InputKecepatan
        '
        Me.InputKecepatan.Location = New System.Drawing.Point(91, 48)
        Me.InputKecepatan.Name = "InputKecepatan"
        Me.InputKecepatan.Size = New System.Drawing.Size(94, 23)
        Me.InputKecepatan.TabIndex = 4
        '
        'InputJarak
        '
        Me.InputJarak.Location = New System.Drawing.Point(91, 78)
        Me.InputJarak.Name = "InputJarak"
        Me.InputJarak.Size = New System.Drawing.Size(94, 23)
        Me.InputJarak.TabIndex = 5
        '
        'SLambatInput
        '
        Me.SLambatInput.Location = New System.Drawing.Point(91, 134)
        Me.SLambatInput.Name = "SLambatInput"
        Me.SLambatInput.Size = New System.Drawing.Size(94, 23)
        Me.SLambatInput.TabIndex = 7
        '
        'LambatInput
        '
        Me.LambatInput.Location = New System.Drawing.Point(91, 163)
        Me.LambatInput.Name = "LambatInput"
        Me.LambatInput.Size = New System.Drawing.Size(94, 23)
        Me.LambatInput.TabIndex = 9
        '
        'CukupInput
        '
        Me.CukupInput.Location = New System.Drawing.Point(91, 192)
        Me.CukupInput.Name = "CukupInput"
        Me.CukupInput.Size = New System.Drawing.Size(94, 23)
        Me.CukupInput.TabIndex = 11
        '
        'CepatInput
        '
        Me.CepatInput.Location = New System.Drawing.Point(91, 221)
        Me.CepatInput.Name = "CepatInput"
        Me.CepatInput.Size = New System.Drawing.Size(94, 23)
        Me.CepatInput.TabIndex = 13
        '
        'SCepatInput
        '
        Me.SCepatInput.Location = New System.Drawing.Point(91, 250)
        Me.SCepatInput.Name = "SCepatInput"
        Me.SCepatInput.Size = New System.Drawing.Size(94, 23)
        Me.SCepatInput.TabIndex = 15
        '
        'SJauhInput
        '
        Me.SJauhInput.Location = New System.Drawing.Point(91, 428)
        Me.SJauhInput.Name = "SJauhInput"
        Me.SJauhInput.Size = New System.Drawing.Size(94, 23)
        Me.SJauhInput.TabIndex = 25
        '
        'AJauhInput
        '
        Me.AJauhInput.Location = New System.Drawing.Point(91, 399)
        Me.AJauhInput.Name = "AJauhInput"
        Me.AJauhInput.Size = New System.Drawing.Size(94, 23)
        Me.AJauhInput.TabIndex = 23
        '
        'SedangInput
        '
        Me.SedangInput.Location = New System.Drawing.Point(91, 370)
        Me.SedangInput.Name = "SedangInput"
        Me.SedangInput.Size = New System.Drawing.Size(94, 23)
        Me.SedangInput.TabIndex = 21
        '
        'ADekatInput
        '
        Me.ADekatInput.Location = New System.Drawing.Point(91, 341)
        Me.ADekatInput.Name = "ADekatInput"
        Me.ADekatInput.Size = New System.Drawing.Size(94, 23)
        Me.ADekatInput.TabIndex = 19
        '
        'SDekatInput
        '
        Me.SDekatInput.Location = New System.Drawing.Point(91, 312)
        Me.SDekatInput.Name = "SDekatInput"
        Me.SDekatInput.Size = New System.Drawing.Size(94, 23)
        Me.SDekatInput.TabIndex = 17
        '
        'HitungButton
        '
        Me.HitungButton.Location = New System.Drawing.Point(23, 470)
        Me.HitungButton.Name = "HitungButton"
        Me.HitungButton.Size = New System.Drawing.Size(328, 44)
        Me.HitungButton.TabIndex = 26
        Me.HitungButton.Text = "Hitung"
        Me.HitungButton.UseVisualStyleBackColor = True
        '
        'SudutPengeremanLabel
        '
        Me.SudutPengeremanLabel.AutoSize = True
        Me.SudutPengeremanLabel.Location = New System.Drawing.Point(215, 56)
        Me.SudutPengeremanLabel.Name = "SudutPengeremanLabel"
        Me.SudutPengeremanLabel.Size = New System.Drawing.Size(108, 15)
        Me.SudutPengeremanLabel.TabIndex = 27
        Me.SudutPengeremanLabel.Text = "Sudut Pengereman"
        '
        'SudutPengeramanInput
        '
        Me.SudutPengeramanInput.Location = New System.Drawing.Point(215, 78)
        Me.SudutPengeramanInput.Name = "SudutPengeramanInput"
        Me.SudutPengeramanInput.Size = New System.Drawing.Size(136, 23)
        Me.SudutPengeramanInput.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(215, 142)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 15)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Aturan Fuzzy"
        '
        'AturanFuzzyListBox
        '
        Me.AturanFuzzyListBox.FormattingEnabled = True
        Me.AturanFuzzyListBox.ItemHeight = 15
        Me.AturanFuzzyListBox.Location = New System.Drawing.Point(215, 163)
        Me.AturanFuzzyListBox.Name = "AturanFuzzyListBox"
        Me.AturanFuzzyListBox.Size = New System.Drawing.Size(136, 289)
        Me.AturanFuzzyListBox.TabIndex = 30
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 526)
        Me.Controls.Add(Me.AturanFuzzyListBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.SudutPengeramanInput)
        Me.Controls.Add(Me.SudutPengeremanLabel)
        Me.Controls.Add(Me.HitungButton)
        Me.Controls.Add(Me.SJauhInput)
        Me.Controls.Add(SJauhLabel)
        Me.Controls.Add(Me.AJauhInput)
        Me.Controls.Add(AJauhLabel)
        Me.Controls.Add(Me.SedangInput)
        Me.Controls.Add(SedangLabel)
        Me.Controls.Add(Me.ADekatInput)
        Me.Controls.Add(ADekatLabel)
        Me.Controls.Add(Me.SDekatInput)
        Me.Controls.Add(SDekatLabel)
        Me.Controls.Add(Me.SCepatInput)
        Me.Controls.Add(SCepatLabel)
        Me.Controls.Add(Me.CepatInput)
        Me.Controls.Add(CepatLabel)
        Me.Controls.Add(Me.CukupInput)
        Me.Controls.Add(CukupLabel)
        Me.Controls.Add(Me.LambatInput)
        Me.Controls.Add(LambatLabel)
        Me.Controls.Add(Me.SLambatInput)
        Me.Controls.Add(SLambatLabel)
        Me.Controls.Add(Me.InputJarak)
        Me.Controls.Add(Me.InputKecepatan)
        Me.Controls.Add(Me.JarakLabel)
        Me.Controls.Add(Me.KecepatanLabel)
        Me.Controls.Add(Me.InferensiFuzzyLabel)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents InferensiFuzzyLabel As Label
    Friend WithEvents KecepatanLabel As Label
    Friend WithEvents JarakLabel As Label
    Friend WithEvents InputKecepatan As TextBox
    Friend WithEvents InputJarak As TextBox
    Friend WithEvents SLambatInput As TextBox
    Friend WithEvents LambatInput As TextBox
    Friend WithEvents CukupInput As TextBox
    Friend WithEvents CepatInput As TextBox
    Friend WithEvents SCepatInput As TextBox
    Friend WithEvents SJauhInput As TextBox
    Friend WithEvents AJauhInput As TextBox
    Friend WithEvents SedangInput As TextBox
    Friend WithEvents ADekatInput As TextBox
    Friend WithEvents SDekatInput As TextBox
    Friend WithEvents HitungButton As Button
    Friend WithEvents SudutPengeremanLabel As Label
    Friend WithEvents SudutPengeramanInput As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents AturanFuzzyListBox As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents KecepatanInputLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
End Class
