
Imports System.Text
Imports System.Net.Http
Imports Newtonsoft.Json
Imports System.Net
Public Class Form4
    Private Sub TambahData()

        ' Set the data you want to send as key-value pairs
        Dim nps As String = txtNPS.Text
        Dim nama As String = txtNama.Text
        Dim jns_kostum As String = txtJns_Kostum.Text
        Dim tgl_sewa As String = txtTgl.Text
        Dim ukuran As String = txtUkuran.Text
        Dim harga As String = txtHarga.Text

        Dim postData As String = $"nps={nps}&nama={nama}&jns_kostum={jns_kostum}&tgl_sewa={tgl_sewa}&ukuran={ukuran}&harga={harga}"

        ' Create a new WebClient instance
        Dim client As New WebClient()

        ' Set the content type header
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded")

        Try
            ' Encode the data as a byte array
            Dim byteArray As Byte() = Encoding.ASCII.GetBytes(postData)

            ' Send the POST request and get the response
            Dim responseBytes As Byte() = client.UploadData(pasien_api, "POST", byteArray)

            ' Convert the response bytes to a string
            Dim responseBody As String = Encoding.ASCII.GetString(responseBytes)

            ' Display the response
            MessageBox.Show(responseBody, "Response")
        Catch ex As Exception
            ' Handle any errors that occur during the request
            MessageBox.Show("An error occurred: " & ex.Message, "Error")
        End Try
        GetClear()
    End Sub

    Private Sub UpdateData()

        ' Set the data you want to send as key-value pairs
        Dim nps As String = txtNPS.Text
        Dim nama As String = txtNama.Text
        Dim jns_kostum As String = txtJns_Kostum.Text
        Dim tgl_sewa As String = txtTgl.Text
        Dim ukuran As String = txtUkuran.Text
        Dim harga As String = txtHarga.Text

        Dim postData As String = $"nps={nps}&nama={nama}&jns_kostum={jns_kostum}&tgl_sewa={tgl_sewa}&ukuran={ukuran}&harga={harga}"

        ' Create a new WebClient instance
        Dim client As New WebClient()

        ' Set the content type header
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded")

        Try
            ' Encode the data as a byte array
            Dim byteArray As Byte() = Encoding.ASCII.GetBytes(postData)

            ' Send the PUT request and get the response
            Dim responseBytes As Byte() = client.UploadData(pasien_api & "?nps=" & txtNPS.Text, "PUT", byteArray)

            ' Convert the response bytes to a string
            Dim responseBody As String = Encoding.ASCII.GetString(responseBytes)

            ' Display the response
            MessageBox.Show(responseBody, "Response")
        Catch ex As Exception
            ' Handle any errors that occur during the request
            MessageBox.Show("An error occurred: " & ex.Message, "Error")
        End Try
        GetClear()
    End Sub

    Private Sub DeleteData()

        ' Set the data you want to send as key-value pairs
        Dim nps As String = txtNPS.Text
        Dim nama As String = txtNama.Text
        Dim jns_kostum As String = txtJns_Kostum.Text
        Dim tgl_sewa As String = txtTgl.Text
        Dim ukuran As String = txtUkuran.Text
        Dim harga As String = txtHarga.Text

        Dim postData As String = $"nps={nps}&nama={nama}&jns_kostum={jns_kostum}&tgl_sewa={tgl_sewa}&ukuran={ukuran}&harga={harga}"

        ' Create a new WebClient instance
        Dim client As New WebClient()

        ' Set the content type header
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded")

        Try
            ' Encode the data as a byte array
            Dim byteArray As Byte() = Encoding.ASCII.GetBytes(postData)

            ' Send the PUT request and get the response
            Dim responseBytes As Byte() = client.UploadData(pasien_api & "?nps=" & txtNPS.Text, "DELETE", byteArray)

            ' Convert the response bytes to a string
            Dim responseBody As String = Encoding.ASCII.GetString(responseBytes)

            ' Display the response
            MessageBox.Show(responseBody, "Response")
        Catch ex As Exception
            ' Handle any errors that occur during the request
            MessageBox.Show("An error occurred: " & ex.Message, "Error")
        End Try
        GetClear()
    End Sub

    Private Sub GetData()
        Using client As New HttpClient()
            ' Send a GET request to the API endpoint
            Dim response As HttpResponseMessage = client.GetAsync(pasien_api & "?nps=" & txtNPS.Text).Result

            ' Check if the request was successful
            If response.IsSuccessStatusCode Then
                ' Read the response content as a string
                Dim jsonString As String = response.Content.ReadAsStringAsync().Result
                Try
                    If (jsonString = "[]") Then
                        pasien_baru = True
                        MessageBox.Show("Data Not Found")
                        Exit Sub
                    Else
                        pasien_baru = False
                        Exit Sub
                    End If
                Catch ex As Exception

                Finally
                    If (pasien_baru = False) Then
                        ' Deserialize the JSON into objects
                        Dim data As List(Of Bajupesta) = JsonConvert.DeserializeObject(Of List(Of Bajupesta))(jsonString)

                        ' Create textboxes dynamically and set their values
                        For Each mydata As Bajupesta In data
                            txtNPS.Text = mydata.nps
                            txtNama.Text = mydata.nama
                            txtJns_kostum.Text = mydata.jns_kostum
                            txtTgl.Text = mydata.tgl_sewa
                            txtUkuran.Text = mydata.ukuran
                            txtHarga.Text = mydata.harga
                        Next
                    End If

                End Try

            Else
                ' Request failed, handle the error
                MessageBox.Show($"Error: {response.StatusCode} - {response.ReasonPhrase}")

            End If
        End Using
    End Sub
    Private Sub GetClear()
        txtNPS.Clear()
        txtNama.Clear()
        txtJnd_kostum.Clear()
        txtTgl.Clear()
        txtUkuran.Clear()
        txtHarga.Clear()
        Reloaded()
        txtN
        S.Focus()
    End Sub
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If (pasien_baru = True) Then
            TambahData()
        Else
            UpdateData()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        GetClear()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If (pasien_baru = False) Then
            Dim result As DialogResult = MessageBox.Show("Apakah data akan dihapus?", "Confirmation", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                DeleteData()
            Else
                MessageBox.Show("Data batal dihapus.")
            End If
        End If
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reloaded()
    End Sub

    Private Sub Reloaded()

        ' Create a WebClient instance to make the HTTP request
        Dim client As New WebClient()

        ' Make the GET request and retrieve the response
        Dim response As String = client.DownloadString(pasien_api)

        ' Deserialize the JSON response into a list of objects
        Dim data As List(Of Bajupesta) = JsonConvert.DeserializeObject(Of List(Of Bajupesta))(response)

        ' Bind the data to the DataGridView
        dgvData.DataSource = data
    End Sub

    Private Sub txtNPS_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNps.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            GetData()
        End If
    End Sub
End Class
