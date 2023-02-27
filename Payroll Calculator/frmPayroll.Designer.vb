<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayroll
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.picPayroll = New System.Windows.Forms.PictureBox()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblSubHeader = New System.Windows.Forms.Label()
        Me.lblGrossPay = New System.Windows.Forms.Label()
        Me.txtBoxGrossPay = New System.Windows.Forms.TextBox()
        Me.btnComputeTaxes = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblFICA = New System.Windows.Forms.Label()
        Me.lblNetIncome = New System.Windows.Forms.Label()
        Me.lblFICATotal = New System.Windows.Forms.Label()
        Me.lblFederalTotal = New System.Windows.Forms.Label()
        Me.lblFederal = New System.Windows.Forms.Label()
        Me.lblStateTotal = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.lblNetIncomeTotal = New System.Windows.Forms.Label()
        CType(Me.picPayroll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picPayroll
        '
        Me.picPayroll.Image = Global.Payroll_Calculator.My.Resources.Resources.payroll
        Me.picPayroll.Location = New System.Drawing.Point(-2, -1)
        Me.picPayroll.Name = "picPayroll"
        Me.picPayroll.Size = New System.Drawing.Size(318, 214)
        Me.picPayroll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPayroll.TabIndex = 0
        Me.picPayroll.TabStop = False
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Times New Roman", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(354, 21)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(308, 42)
        Me.lblHeading.TabIndex = 1
        Me.lblHeading.Text = "Payroll Calculator"
        '
        'lblSubHeader
        '
        Me.lblSubHeader.AutoSize = True
        Me.lblSubHeader.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubHeader.Location = New System.Drawing.Point(433, 87)
        Me.lblSubHeader.Name = "lblSubHeader"
        Me.lblSubHeader.Size = New System.Drawing.Size(151, 62)
        Me.lblSubHeader.TabIndex = 2
        Me.lblSubHeader.Text = "Paycheck" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Calculation"
        Me.lblSubHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblGrossPay
        '
        Me.lblGrossPay.AutoSize = True
        Me.lblGrossPay.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrossPay.Location = New System.Drawing.Point(179, 244)
        Me.lblGrossPay.Name = "lblGrossPay"
        Me.lblGrossPay.Size = New System.Drawing.Size(216, 31)
        Me.lblGrossPay.TabIndex = 4
        Me.lblGrossPay.Text = "Enter Gross Pay:"
        '
        'txtBoxGrossPay
        '
        Me.txtBoxGrossPay.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxGrossPay.Location = New System.Drawing.Point(455, 241)
        Me.txtBoxGrossPay.Name = "txtBoxGrossPay"
        Me.txtBoxGrossPay.Size = New System.Drawing.Size(110, 39)
        Me.txtBoxGrossPay.TabIndex = 5
        Me.txtBoxGrossPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnComputeTaxes
        '
        Me.btnComputeTaxes.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnComputeTaxes.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComputeTaxes.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.btnComputeTaxes.Location = New System.Drawing.Point(43, 312)
        Me.btnComputeTaxes.Name = "btnComputeTaxes"
        Me.btnComputeTaxes.Size = New System.Drawing.Size(162, 47)
        Me.btnComputeTaxes.TabIndex = 6
        Me.btnComputeTaxes.Text = "Compute Taxes"
        Me.btnComputeTaxes.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnClear.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.btnClear.Location = New System.Drawing.Point(278, 312)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(162, 47)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnExit.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.btnExit.Location = New System.Drawing.Point(500, 312)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(162, 47)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblFICA
        '
        Me.lblFICA.AutoSize = True
        Me.lblFICA.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFICA.Location = New System.Drawing.Point(48, 397)
        Me.lblFICA.Name = "lblFICA"
        Me.lblFICA.Size = New System.Drawing.Size(61, 22)
        Me.lblFICA.TabIndex = 9
        Me.lblFICA.Text = "FICA:"
        '
        'lblNetIncome
        '
        Me.lblNetIncome.AutoSize = True
        Me.lblNetIncome.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNetIncome.Location = New System.Drawing.Point(114, 472)
        Me.lblNetIncome.Name = "lblNetIncome"
        Me.lblNetIncome.Size = New System.Drawing.Size(241, 26)
        Me.lblNetIncome.TabIndex = 12
        Me.lblNetIncome.Text = "Net Paycheck Income:"
        '
        'lblFICATotal
        '
        Me.lblFICATotal.AutoSize = True
        Me.lblFICATotal.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFICATotal.Location = New System.Drawing.Point(115, 397)
        Me.lblFICATotal.Name = "lblFICATotal"
        Me.lblFICATotal.Size = New System.Drawing.Size(40, 22)
        Me.lblFICATotal.TabIndex = 14
        Me.lblFICATotal.Text = "123"
        '
        'lblFederalTotal
        '
        Me.lblFederalTotal.AutoSize = True
        Me.lblFederalTotal.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFederalTotal.Location = New System.Drawing.Point(393, 397)
        Me.lblFederalTotal.Name = "lblFederalTotal"
        Me.lblFederalTotal.Size = New System.Drawing.Size(40, 22)
        Me.lblFederalTotal.TabIndex = 16
        Me.lblFederalTotal.Text = "456"
        '
        'lblFederal
        '
        Me.lblFederal.AutoSize = True
        Me.lblFederal.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFederal.Location = New System.Drawing.Point(274, 397)
        Me.lblFederal.Name = "lblFederal"
        Me.lblFederal.Size = New System.Drawing.Size(113, 22)
        Me.lblFederal.TabIndex = 15
        Me.lblFederal.Text = "Federal Tax:"
        '
        'lblStateTotal
        '
        Me.lblStateTotal.AutoSize = True
        Me.lblStateTotal.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStateTotal.Location = New System.Drawing.Point(594, 397)
        Me.lblStateTotal.Name = "lblStateTotal"
        Me.lblStateTotal.Size = New System.Drawing.Size(40, 22)
        Me.lblStateTotal.TabIndex = 18
        Me.lblStateTotal.Text = "789"
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblState.Location = New System.Drawing.Point(496, 397)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(92, 22)
        Me.lblState.TabIndex = 17
        Me.lblState.Text = "State Tax:"
        '
        'lblNetIncomeTotal
        '
        Me.lblNetIncomeTotal.AutoSize = True
        Me.lblNetIncomeTotal.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNetIncomeTotal.Location = New System.Drawing.Point(434, 472)
        Me.lblNetIncomeTotal.Name = "lblNetIncomeTotal"
        Me.lblNetIncomeTotal.Size = New System.Drawing.Size(114, 26)
        Me.lblNetIncomeTotal.TabIndex = 19
        Me.lblNetIncomeTotal.Text = "$12345.67"
        '
        'frmPayroll
        '
        Me.AcceptButton = Me.btnComputeTaxes
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 535)
        Me.Controls.Add(Me.lblNetIncomeTotal)
        Me.Controls.Add(Me.lblStateTotal)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.lblFederalTotal)
        Me.Controls.Add(Me.lblFederal)
        Me.Controls.Add(Me.lblFICATotal)
        Me.Controls.Add(Me.lblNetIncome)
        Me.Controls.Add(Me.lblFICA)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnComputeTaxes)
        Me.Controls.Add(Me.txtBoxGrossPay)
        Me.Controls.Add(Me.lblGrossPay)
        Me.Controls.Add(Me.lblSubHeader)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.picPayroll)
        Me.Name = "frmPayroll"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payroll Every Two Weeks"
        CType(Me.picPayroll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picPayroll As PictureBox
    Friend WithEvents lblHeading As Label
    Friend WithEvents lblSubHeader As Label
    Friend WithEvents lblGrossPay As Label
    Friend WithEvents txtBoxGrossPay As TextBox
    Friend WithEvents btnComputeTaxes As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblFICA As Label
    Friend WithEvents lblNetIncome As Label
    Friend WithEvents lblFICATotal As Label
    Friend WithEvents lblFederalTotal As Label
    Friend WithEvents lblFederal As Label
    Friend WithEvents lblStateTotal As Label
    Friend WithEvents lblState As Label
    Friend WithEvents lblNetIncomeTotal As Label
End Class
