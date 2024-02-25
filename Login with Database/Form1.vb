Imports System.Data.SqlClient

Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim connection As New SqlConnection("Data Source=DESKTOP-UEJ47KG\SQLEXPRESS01;Initial Catalog=Login_Form;Integrated Security=True")
        Dim command As New SqlCommand("select * from user_mst where Username= @username and Password = @password", connection)

        command.Parameters.Add("@username", SqlDbType.VarChar).Value = TextBox1.Text
        command.Parameters.Add("@password", SqlDbType.VarChar).Value = TextBox2.Text

        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        If table.Rows.Count() <= 0 Then
            MsgBox("Username or Password is invalid")
            TextBox1.Text = ""
            TextBox2.Text = ""
        Else
            'MsgBox("Login Successfully")
            Me.Hide()
            Form2.Show()

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Me.Close()

    End Sub

End Class
