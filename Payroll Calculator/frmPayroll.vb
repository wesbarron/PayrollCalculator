Public Class frmPayroll
    Private Sub frmPayroll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblFederalTotal.Text = ""
        lblFICATotal.Text = ""
        lblStateTotal.Text = ""
        lblNetIncomeTotal.Text = ""
        txtBoxGrossPay.Focus()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblFederalTotal.Text = ""
        lblFICATotal.Text = ""
        lblStateTotal.Text = ""
        lblNetIncomeTotal.Text = ""
        txtBoxGrossPay.Text = ""
        txtBoxGrossPay.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnComputeTaxes_Click(sender As Object, e As EventArgs) Handles btnComputeTaxes.Click
        'Declerations
        Dim strIncome As String = txtBoxGrossPay.Text
        Dim decIncome As Decimal
        Dim decFica As Decimal
        Dim decFederal As Decimal
        Dim decState As Decimal
        Dim decNet As Decimal
        'Declare Constants
        Dim _cdecFica = 0.0765D
        Dim _cdecFed = 0.22D
        Dim _cdecState = 0.04D
        If IsNumeric(strIncome) Then
            'Convert strIncome to decIncome
            decIncome = Convert.ToDecimal(strIncome)
            If decIncome >= 0 Then
                'Convert 3 tax ammounts
                decFica = decIncome * _cdecFica
                decFederal = decIncome * _cdecFed
                decState = decIncome * _cdecState
                'Calculate Net Income
                decNet = decIncome - (decFica + decFederal + decState)
                'Display results
                lblNetIncomeTotal.Text = decNet.ToString("C")
                lblFICATotal.Text = decFica.ToString("N")
                lblFederalTotal.Text = decFederal.ToString("N")
                lblStateTotal.Text = decState.ToString("N")
            Else
                MsgBox("Please Enter a postive number value", , "Invalid Number Error")
            End If
        Else
            MsgBox("Please Enter a postive number value", , "Invalid Number Error")
        End If
    End Sub
End Class
