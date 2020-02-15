''Jennifer Pezzulo

Public Class Form1
    Private Sub Customer_TextChanged(sender As Object, e As EventArgs) Handles CustomerBox.TextChanged


    End Sub

    Private Sub Labor_TextChanged(sender As Object, e As EventArgs) Handles LaborBox.TextChanged


        If (String.IsNullOrEmpty(LaborBox.Text)) Then

        Else

            Try
                Double.Parse(LaborBox.Text)
            Catch ex As Exception
                MessageBox.Show("Please enter a number")
                LaborBox.Clear()
            End Try

        End If

    End Sub

    Private Sub Supplies_TextChanged(sender As Object, e As EventArgs) Handles SuppliesBox.TextChanged

        If (String.IsNullOrEmpty(SuppliesBox.Text)) Then

        Else

            Try
                Double.Parse(SuppliesBox.Text)
            Catch ex As Exception
                MessageBox.Show("Please enter a number")
                SuppliesBox.Clear()
            End Try

        End If

    End Sub

    Private Sub TotalOutput_TextChanged(sender As Object, e As EventArgs) Handles TotalOutputBox.TextChanged

    End Sub

    Private Sub Calculate_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click

        Dim customerName, totalLabor, totalSupplies, totalBill As String
        Dim labor, supplies, total As Double
        Const LABOR_RATE As Double = 35
        Const TAX_RATE As Double = 0.05

        customerName = CustomerBox.Text

        labor = Convert.ToDouble(LaborBox.Text)
        labor = labor * LABOR_RATE
        totalLabor = labor.ToString("0.00")

        supplies = Convert.ToDouble(SuppliesBox.Text)
        supplies = supplies * TAX_RATE + supplies
        totalSupplies = supplies.ToString("0.00")

        total = supplies + labor
        totalBill = total.ToString("0.00")

        TotalOutputBox.AppendText("Customer:  " + customerName & Environment.NewLine)
        TotalOutputBox.AppendText("LaborCost:  " + "$" + totalLabor & Environment.NewLine)
        TotalOutputBox.AppendText("Parts Cost:  " + "$" + totalSupplies & Environment.NewLine)
        TotalOutputBox.AppendText("Total Cost:  " + "$" + totalBill & Environment.NewLine)

    End Sub
End Class



