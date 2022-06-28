Public Class Form1
    Dim barang As String
    Dim Harga As Double
    Dim totharga As Double
    Dim total As Double

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If kode.Text = "1001" Then
            barang = "Makanan Ringan"
            nama.Text = barang
            Harga = 5000
            price.Text = "RP 5.000"
        ElseIf kode.Text = "1002" Then
            barang = "Makanan Berat"
            nama.Text = barang
            Harga = 10000
            price.Text = "RP 10.000"
        ElseIf kode.Text = "1003" Then
            barang = "Minuman"
            nama.Text = barang
            Harga = 3000
            price.Text = "RP 3.000"
        ElseIf kode.Text = "1004" Then
            barang = "Obat-obatan"
            nama.Text = barang
            Harga = 7000
            price.Text = "RP 7.000"
        ElseIf kode.Text = "1005" Then
            barang = "Mainan"
            nama.Text = barang
            Harga = 15000
            price.Text = "RP 15.000"
        ElseIf kode.Text = "1006" Then
            barang = "Alat Mandi"
            nama.Text = barang
            Harga = 13000
            price.Text = "RP 13.000"
        ElseIf kode.Text = "" Then
            MsgBox("Enter The Code !!!", MsgBoxStyle.Information + vbOKOnly, "Perhatian")
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If qty.Text = "" Then
            MsgBox("Enter The Quantity !!!", MsgBoxStyle.Information + vbOKOnly, "Perhatian")
        ElseIf qty.Text = True Then
            Dim isi As New ListViewItem
            isi.Text = kode.Text
            isi.SubItems.Add(barang)
            isi.SubItems.Add(price.Text)
            isi.SubItems.Add(qty.Text)
            isi.SubItems.Add(CStr(Harga * Val(qty.Text)))
            lv.Items.Add(isi)

            kode.Text = ""
            nama.Text = ""
            price.Text = ""
            qty.Text = ""
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim GrandTotal As Integer = 0
        For i As Integer = 0 To lv.Items.Count - 1
            GrandTotal = GrandTotal + CInt(lv.Items(i).SubItems(4).Text)
        Next
        totprice.Text = GrandTotal
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        lv.Items.Clear()
        totprice.Text = ""
        pay.Text = ""
        bck.Text = ""

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        bck.Text = "Rp," & CInt(pay.Text) - CInt(totprice.Text)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub


End Class

