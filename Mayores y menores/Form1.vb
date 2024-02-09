Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1, num2, num3 As Integer
        num1 = Val(TextBox1.Text)
        num2 = Val(TextBox2.Text)
        num3 = Val(TextBox3.Text)
        If num1 > num2 And num1 > num3 Then
            MessageBox.Show("El numero mayor es " & num1)
        Else
            If num2 > num1 And num2 > num3 Then
                MessageBox.Show("El numero mayor es " & num2)
            Else
                If num3 > num2 And num3 > num1 Then
                    MessageBox.Show("el numero mayor es " & num3)
                Else
                End If
                If num1 = num2 = num3 Then
                    MessageBox.Show("Los numeros son iguales")
                End If
            End If
            End If
    End Sub
End Class
