Imports System.IO
Imports System.Text

Public Class Form1
    Dim strFileName As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim AmbilFile As New OpenFileDialog
        AmbilFile.CheckFileExists = True
        AmbilFile.Filter = "TXT File (*.txt) | *.txt"
        AmbilFile.Title = "Pilih TXT File aja, jangan yg lain"
        AmbilFile.Multiselect = False
        AmbilFile.ShowDialog()
        strFileName = AmbilFile.FileName
        TextBox1.Text = strFileName

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim mystream As New System.IO.StreamReader(strFileName)
        Dim BacaString As String
        Dim TextPerBaris As String = ""

        Me.ListBox1.Items.Clear()
        While Not (mystream.EndOfStream)

            BacaString = mystream.ReadLine
            Me.ListBox1.Items.Add(BacaString)

        End While
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim MyArray(Me.ListBox1.Items.Count) As String

        Me.ListBox1.Items.CopyTo(MyArray, 0)
        Array.Sort(MyArray)
        ListBox2.Items.Clear()

        For i As Integer = 1 To MyArray.Count - 1
            ListBox2.Items.Add(MyArray(i))
        Next
    End Sub
End Class
