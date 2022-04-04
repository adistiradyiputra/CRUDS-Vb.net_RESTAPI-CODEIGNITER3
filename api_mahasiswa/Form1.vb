Imports System.Net
Imports System.IO
Imports System.Web.Script.Serialization

Public Class Form1

    'Start get data
    Private Sub getData()
        Try
            dg_mahasiswa.Rows.Clear()
            Dim uriString As String = "http://localhost/CodeIgniter_API/index.php/Api/GetData/"
            Dim uri As New Uri(uriString)
            Dim request As HttpWebRequest = HttpWebRequest.Create(uri)
            request.Method = "GET"
            Dim response As HttpWebResponse = request.GetResponse()
            Dim read = New StreamReader(response.GetResponseStream())
            Dim raw As String = read.ReadToEnd()
            Dim dict As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(raw)
            For Each item As Object In dict
                dg_mahasiswa.Rows.Add(item("npm").ToString, item("nama").ToString, item("jurusan").ToString,
                                       item("prodi").ToString, item("kelas").ToString)
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Notifikasi")
        End Try

    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getData()
    End Sub
    'End get data


    'Start insert Data
    Private Sub insertData()
        Try
            dg_mahasiswa.Rows.Clear()
            Dim uriString As String = "http://localhost/CodeIgniter_API/index.php/Api/PostData/" & txt_npm.Text.Trim & "/" & txt_nama.Text.Trim & "/" & txt_jurusan.Text.Trim & "/" & txt_prodi.Text.Trim & "/" & txt_kelas.Text.Trim
            Dim uri As New Uri(uriString)
            Dim request As HttpWebRequest = HttpWebRequest.Create(uri)
            request.Method = "POST"
            Dim response As HttpWebResponse = request.GetResponse()
            Dim read = New StreamReader(response.GetResponseStream())
            Dim raw As String = read.ReadToEnd()
            Dim dict As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(raw)
            For Each item As Object In dict
                dg_mahasiswa.Rows.Add(item("npm").ToString, item("nama").ToString, item("jurusan").ToString,
                                       item("prodi").ToString, item("kelas").ToString)
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Notifikasi")
        End Try

    End Sub
    Private Sub btn_insert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_insert.Click
        If txt_npm.Text = "" Or txt_nama.Text = "" Or txt_jurusan.Text = "" Or txt_prodi.Text = "" Or txt_kelas.Text = "" Then
            MsgBox("Pastikan Semua Data terisi!", vbInformation)
            getData()
        Else
            insertData()
            MsgBox("Data Berhasil Ditambahkan", vbInformation)
            getData()
        End If


        txt_npm.Text = ""
        txt_nama.Text = ""
        txt_jurusan.Text = ""
        txt_prodi.Text = ""
        txt_kelas.Text = ""
    End Sub
    'end insert data

    'Start update data
    Private Sub updateData()
        Try
            dg_mahasiswa.Rows.Clear()
            Dim uriString As String = "http://localhost/CodeIgniter_API/index.php/Api/PutData/" & txt_npm.Text.Trim & "/" & txt_nama.Text.Trim & "/" & txt_jurusan.Text.Trim & "/" & txt_prodi.Text.Trim & "/" & txt_kelas.Text.Trim
            Dim uri As New Uri(uriString)
            Dim request As HttpWebRequest = HttpWebRequest.Create(uri)
            request.Method = "PUT"
            Dim response As HttpWebResponse = request.GetResponse()
            Dim read = New StreamReader(response.GetResponseStream())
            Dim raw As String = read.ReadToEnd()
            Dim dict As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(raw)
            For Each item As Object In dict
                dg_mahasiswa.Rows.Add(item("npm").ToString, item("nama").ToString, item("jurusan").ToString,
                                       item("prodi").ToString, item("kelas").ToString)
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Notifikasi")
        End Try
    End Sub

    Private Sub btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click
        If txt_npm.Text = "" Or txt_nama.Text = "" Or txt_jurusan.Text = "" Or txt_prodi.Text = "" Or txt_kelas.Text = "" Then
            MsgBox("Pastikan Semua Data terisi!", vbInformation)
            getData()
        Else
            updateData()
            MsgBox("Data berhasil di update", vbInformation)
            getData()
        End If

        txt_npm.Text = ""
        txt_nama.Text = ""
        txt_jurusan.Text = ""
        txt_prodi.Text = ""
        txt_kelas.Text = ""
    End Sub
    'End Update Data


    'Start Delete Data
    Private Sub deleteData()
        Try
            dg_mahasiswa.Rows.Clear()
            Dim uriString As String = "http://localhost/CodeIgniter_API/index.php/Api/DeleteData/" & txt_npm.Text.Trim & "/" & txt_nama.Text.Trim & "/" & txt_jurusan.Text.Trim & "/" & txt_prodi.Text.Trim & "/" & txt_kelas.Text.Trim
            Dim uri As New Uri(uriString)
            Dim request As HttpWebRequest = HttpWebRequest.Create(uri)
            request.Method = "DELETE"
            Dim response As HttpWebResponse = request.GetResponse()
            Dim read = New StreamReader(response.GetResponseStream())
            Dim raw As String = read.ReadToEnd()
            Dim dict As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(raw)
            For Each item As Object In dict
                dg_mahasiswa.Rows.Add(item("npm").ToString, item("nama").ToString, item("jurusan").ToString,
                                       item("prodi").ToString, item("kelas").ToString)
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Notifikasi")
        End Try

    End Sub
    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        Dim konfir As String

        konfir = MsgBox("Yakin Ingin dihapus ?", vbQuestion + vbYesNo, "Konfirmasi")
        If konfir = vbYes Then
            deleteData()
            konfir = MsgBox("Data Berhasil Dihapus !", vbInformation)
            getData()
        ElseIf konfir = vbNo Then
            getData()

            Label1.Visible = True
            txt_npm.Enabled = True
            txt_npm.Visible = True
        End If

        txt_npm.Text = ""
        txt_nama.Text = ""
        txt_jurusan.Text = ""
        txt_prodi.Text = ""
        txt_kelas.Text = ""
    End Sub
    'End Delete data

    'Start Search Data
    Private Sub searchData()
        Try
            dg_mahasiswa.Rows.Clear()
            Dim uriString As String = "http://localhost/CodeIgniter_API/index.php/Api/SearchData/" & txt_pencarian.Text.Trim
            Dim uri As New Uri(uriString)
            Dim request As HttpWebRequest = HttpWebRequest.Create(uri)
            request.Method = "GET"
            Dim response As HttpWebResponse = request.GetResponse()
            Dim read = New StreamReader(response.GetResponseStream())
            Dim raw As String = read.ReadToEnd()
            Dim dict As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(raw)
            For Each item As Object In dict
                dg_mahasiswa.Rows.Add(item("npm").ToString, item("nama").ToString, item("jurusan").ToString,
                                       item("prodi").ToString, item("kelas").ToString)
            Next
        Catch ex As Exception

        End Try
    End Sub

    'End Search Data


    Private Sub dg_mahasiswa_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg_mahasiswa.CellContentClick
        txt_npm.Enabled = False
        txt_npm.Visible = True
        Label1.Visible = True

        txt_npm.Text = dg_mahasiswa.Rows(e.RowIndex).Cells(0).Value
        txt_nama.Text = dg_mahasiswa.Rows(e.RowIndex).Cells(1).Value
        txt_jurusan.Text = dg_mahasiswa.Rows(e.RowIndex).Cells(2).Value
        txt_prodi.Text = dg_mahasiswa.Rows(e.RowIndex).Cells(3).Value
        txt_kelas.Text = dg_mahasiswa.Rows(e.RowIndex).Cells(4).Value
    End Sub

    Private Sub dg_mahasiswa_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg_mahasiswa.CellDoubleClick
        txt_npm.Enabled = False
        txt_npm.Visible = True
        Label1.Visible = True

        txt_npm.Text = dg_mahasiswa.Rows(e.RowIndex).Cells(0).Value
        txt_nama.Text = dg_mahasiswa.Rows(e.RowIndex).Cells(1).Value
        txt_jurusan.Text = dg_mahasiswa.Rows(e.RowIndex).Cells(2).Value
        txt_prodi.Text = dg_mahasiswa.Rows(e.RowIndex).Cells(3).Value
        txt_kelas.Text = dg_mahasiswa.Rows(e.RowIndex).Cells(4).Value
    End Sub

    Private Sub btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add.Click
        Label1.Visible = True
        txt_npm.Enabled = True
        txt_npm.Visible = True


        txt_npm.Text = ""
        txt_nama.Text = ""
        txt_jurusan.Text = ""
        txt_prodi.Text = ""
        txt_kelas.Text = ""
        txt_npm.Focus()
    End Sub

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        Label1.Visible = True
        txt_npm.Enabled = True
        txt_npm.Visible = True

        txt_npm.Text = ""
        txt_nama.Text = ""
        txt_jurusan.Text = ""
        txt_prodi.Text = ""
        txt_kelas.Text = ""
    End Sub

    Private Sub txt_pencarian_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_pencarian.TextChanged
        searchData()
        If txt_pencarian.Text Is "" Then
            getData()
        End If
    End Sub
End Class
