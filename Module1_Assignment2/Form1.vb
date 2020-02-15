''Jennifer Pezzulo
''February 15, 2020
''Module 1 Assignment 2
''CSC220C00 Intro to MS Visual Basic.NET
''git:  https://github.com/pwnstarprincess/Module1_Assignment2.git

Public Class Form1
    Private Sub Customer_TextChanged(sender As Object, e As EventArgs) Handles CustomerBox.TextChanged


    End Sub

    Private Sub Labor_TextChanged(sender As Object, e As EventArgs) Handles LaborBox.TextChanged

        ''If the string is not empty then validate input with a try catch block
        If (Not String.IsNullOrEmpty(LaborBox.Text)) Then

            ''Parse textbox as double
            Try
                Double.Parse(LaborBox.Text)
            Catch ex As Exception
                ''Throw alert and clear textbox if not double
                MessageBox.Show("Please enter a number")
                LaborBox.Clear()
            End Try

        End If

    End Sub

    Private Sub Supplies_TextChanged(sender As Object, e As EventArgs) Handles SuppliesBox.TextChanged
        ''If string is not empty then validate input with a try catch block
        If (Not String.IsNullOrEmpty(SuppliesBox.Text)) Then
            ''Parse textbox as a double
            Try
                Double.Parse(SuppliesBox.Text)
            Catch ex As Exception
                ''Throw alert and clear if not double
                MessageBox.Show("Please enter a number")
                SuppliesBox.Clear()
            End Try

        End If

    End Sub

    Private Sub TotalOutput_TextChanged(sender As Object, e As EventArgs) Handles TotalOutputBox.TextChanged

    End Sub

    Private Sub Calculate_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        ''create string and double variables
        Dim customerName, totalLabor, totalSupplies, totalBill As String
        Dim labor, supplies, total As Double
        ''set constant values for labor rate and tax rate
        Const LABOR_RATE As Double = 35
        Const TAX_RATE As Double = 0.05

        customerName = CustomerBox.Text
        ''Explicit conversion from string to double for labor hours
        labor = Convert.ToDouble(LaborBox.Text)
        ''multiple labor hours by the labor hourly rate
        labor = labor * LABOR_RATE
        ''convert back to string and format appropriately
        totalLabor = labor.ToString("0.00")
        ''Explicit conversion from string to double for supply cost
        supplies = Convert.ToDouble(SuppliesBox.Text)
        ''Add taxes to supply cost
        supplies = supplies * TAX_RATE + supplies
        ''Convert supply cost to string and format appropriately
        totalSupplies = supplies.ToString("0.00")
        ''add up the total cost
        total = supplies + labor
        ''convert total cost and format appropritately
        totalBill = total.ToString("0.00")
        ''output and format customer name, labor cost, supply cost, and total bill
        TotalOutputBox.AppendText("Customer:  " + customerName & Environment.NewLine)
        TotalOutputBox.AppendText("LaborCost:  " + "$" + totalLabor & Environment.NewLine)
        TotalOutputBox.AppendText("Parts Cost:  " + "$" + totalSupplies & Environment.NewLine)
        TotalOutputBox.AppendText("Total Cost:  " + "$" + totalBill & Environment.NewLine)

    End Sub
End Class



