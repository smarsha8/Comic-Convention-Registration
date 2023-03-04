Public Class frmComicConventionRegistration
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblGroupSize.Click
        'Declaration
        Dim strSizeEntry = txtSizeentry.Text
        Dim intGroup As Integer = 0
        Dim decTotalCost As Decimal


        Dim _decSuperHero As Integer
        Dim _decSizeEntry As Decimal = 0
        Dim _decTotalCost As Decimal = 0
        intGroup = Convert.ToInt32(strSizeEntry)
        Dim int As Integer = 0
        Dim decRegistration As Decimal

        Dim decSuperHero As Decimal = 380D
        Dim decAutographs As Decimal = 275D
        Dim decConvention As Decimal = 209D
        Dim _decintSizeEntry As Decimal = 0
        lblRegistrationPrice.Text = decTotalCost.ToString("c")

        Dim decTotal As Decimal = _decSuperHero * intGroup

        If IsNumeric(txtSizeentry.Text) Then
            intGroup = Convert.ToInt32(txtSizeentry.Text)

            'Is number of Group Greater Than Zero
            If intGroup > 0 And intGroup < 20 Then
                'Calculate and display cost

                If rdbtnConventionSuperhero.Checked Then
                    decRegistration = decSuperHero
                ElseIf rdbtnConventionAutographs.Checked Then
                    decRegistration = decAutographs
                ElseIf rdbtnConvention.Checked Then
                    decRegistration = decConvention
                End If

                decTotalCost = (intGroup * decRegistration)
                lblRegistrationCost.Text = decTotalCost.ToString("C")
            Else
                'Display error message if user entered a negative
                MsgBox("Enter a positive number between 1 and 20", , "Invalid Number Error")
            End If
        Else
            'Display error message if user entered a nonnumeric value
            MsgBox("Enter a reasonable number between 1 and 20",, "Invalid Entry Error")
        End If
        txtSizeentry.Text = ""
        lblRegistrationPrice.Text = ""

    End Sub

    Private Sub btnCleaar_Click(sender As Object, e As EventArgs) Handles btnCleaar.Click
        txtSizeentry.Clear()
        lblRegistrationCost.Text = ""
        rdbtnConvention.Checked = True
        rdbtnConventionAutographs.Checked = False
        rdbtnConventionSuperhero.Checked = False
        txtSizeentry.Focus()


    End Sub
End Class
