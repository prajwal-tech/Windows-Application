' Sample form with a title, question, and options
Imports System.Collections.Specialized
Imports System.Net
Imports System.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class MyForm

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Validate user input (replace with your validation logic)
        If TextBox1.Text = "" Then
            MessageBox.Show("Please enter your answer!")
            Exit Sub
        End If

        ' Prepare data to send (replace with actual form data)
        Dim data As New Dictionary(Of String, Object)
        data.Add("title", "My Form Title")
        data.Add("question", "What is your favorite color?")
        data.Add("answer", TextBox1.Text)

        ' Send data to backend server (replace with actual server URL and method)
        Dim response As String = SendDataToBackend("http://localhost:3000/submit", JsonConvert.SerializeObject(data))

        ' Handle response from server
        If response = "Success" Then
            MessageBox.Show("Form submitted successfully!")
        Else
            MessageBox.Show("Error submitting form: " & response)
        End If
    End Sub

    ' Simulates sending data to backend server (replace with actual implementation)
    Private Function SendDataToBackend(url As String, data As String) As String
        Dim request As New WebClient()
        Dim responseBytes As Byte() = request.UploadValues(url, New NameValueCollection() With {.Add("data", data)})
        Return Encoding.UTF8.GetString(responseBytes)
    End Function

End Class
