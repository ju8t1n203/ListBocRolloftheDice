'Justin Bell
'RCET0265
'Fall24
'Roll of the Dice List Box
'linl
Public Class RolloftheDice
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub RollButton_Click(sender As Object, e As EventArgs) Handles RollButton.Click
        Dim header() As String = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"}
        Dim values As Integer
        Dim totals(11) As Integer
        Dim combinedValues As String = ""


        DiceBox.Items.Clear()

        'makes top headings
        DiceBox.Items.Add("                   Roll of the Dice")
        DiceBox.Items.Add("| 2  | 3  | 4  | 5  | 6  | 7  | 8  | 9  | 10 | 11 | 12 |")

        DiceBox.Items.Add(StrDup(56, "-"))

        'creates two dice rolls 1000 times
        For i = 0 To 1000
            values = GetRandomNumber(2, 12)
            totals(values - 2) += 1
        Next

        'displays number of times a number is rolled
        For i = 0 To 10
            combinedValues &= ($"|{totals(i)}").PadRight(4).ToString() & " "
        Next
        DiceBox.Items.Add(combinedValues.Trim())

    End Sub

    Function GetRandomNumber(min%, max%) As Integer
        Dim randomNumber%
        Randomize(DateTime.Now.Millisecond)
        randomNumber = CInt(Math.Floor(Rnd() * (max - min + 1))) + min
        Return randomNumber%
    End Function

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        DiceBox.Items.Clear()
    End Sub
End Class
