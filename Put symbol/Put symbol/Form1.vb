Public Class Form1
    Dim arrNum() As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim n = TextBox1.Text

        Dim x As Integer = TextBox2.Text
        Dim s As String = x.ToString
        Dim a(s.Length) As String

        Dim r(s.Length) As String

        Dim tmp As Integer = 1



        For i As Integer = 0 To s.Length - 1

            a(i) = s.Substring(i, 1)

            r(i) = s.Substring(0, tmp) + "**" + s.Substring(tmp)

            tmp += 1

        Next i

        Dim tmp2 = 2

        For i As Integer = 0 To n - 1
            r(i) = r(i).Replace(tmp2, "")
            r(i) = r(i).Replace(tmp2 + 1, "")
            ListBox1.Items.Add(r(i))

            tmp2 += 1
        Next i

    End Sub
End Class
