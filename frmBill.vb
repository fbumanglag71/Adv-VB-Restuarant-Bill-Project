'' Author: Francisco Bumanglag
'' Project: Restuarant Bill, Page 236
'' Assignment: Module 4 Exercise 
'' Course: Adv Visual Basic, Santa Ana College
'' Class: CMPR205 Dr. Kimberly Davis 
'' Date: February 25, 2024


Public Class frmBill

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click

        ''declare the variables
        Dim pizza As Integer = txtPizza.Text
        Dim fries As Integer = txtFries.Text
        Dim drinks As Integer = txtDrinks.Text

        ''calculations 
        Dim pizzaPrice As Decimal = pizza * 1.75D
        Dim friesPrice As Decimal = fries * 2D
        Dim drinkPrice As Decimal = drinks * 1.25D
        Dim totalAll As Decimal = pizzaPrice + friesPrice + drinkPrice

        ''clear the listbox 
        lstBox.Items.Clear()

        ''display the outcome in the listbox
        lstBox.Items.Add("ITEM                QUANTITY          PRICE")
        lstBox.Items.Add("Pizza Slices            " & pizza & "                     $" & pizzaPrice)
        lstBox.Items.Add("Fries                       " & pizza & "                     $" & pizzaPrice)
        lstBox.Items.Add("Soft Drinks             " & pizza & "                     $" & pizzaPrice)
        lstBox.Items.Add("TOTAL" & "                                          $" & totalAll)

    End Sub
End Class
