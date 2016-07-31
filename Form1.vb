
Imports System.Security.Cryptography

Public Class Form1

    Private Sub TextBox6_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox6.TextChanged
        'Me.Close()
        Application.Exit()
    End Sub


    Private Sub btnGenerate_Click(sender As System.Object, e As System.EventArgs) Handles btnGenerate.Click

        'Generate a public/private key pair.
        Dim RSA As RSACryptoServiceProvider = New RSACryptoServiceProvider()

        Dim RSAKeyInfo As RSAParameters = RSA.ExportParameters(True) ' true gets public and private keys
        txtPublicKey.Text = Convert.ToBase64String(RSAKeyInfo.Modulus)

        txtPublicKey.Text = "e=" + Convert.ToBase64String(RSAKeyInfo.Exponent) + ", n=" + Convert.ToBase64String(RSAKeyInfo.Modulus)
        txtPrivatekey.Text = "d=" + Convert.ToBase64String(RSAKeyInfo.D) + ", n=" + Convert.ToBase64String(RSAKeyInfo.Modulus)



    End Sub



    Private Sub btnCopyPrivate_Click(sender As System.Object, e As System.EventArgs) Handles btnCopyPrivate.Click

        If txtPrivatekey.Text = "" Then MsgBox("Please generate your privacy keys first") : Exit Sub

        MsgBox("Please paste this into your personal details form")

        btnGenerate.Enabled = False
        btnGenerate.Visible = False

        If txtPrivatekey.Text <> String.Empty Then
            Clipboard.SetText(txtPrivatekey.Text)
        Else
            Clipboard.Clear()
        End If


    End Sub

    Private Sub btnCopyPublic_Click(sender As System.Object, e As System.EventArgs) Handles btnCopyPublic.Click

        If txtPublicKey.Text = "" Then MsgBox("Please generate your privacy keys first") : Exit Sub

        MsgBox("Please paste this into your public voting/census form")

        btnGenerate.Enabled = False
        btnGenerate.Visible = False

        If txtPublicKey.Text <> String.Empty Then
            Clipboard.SetText(txtPublicKey.Text)
        Else
            Clipboard.Clear()
        End If



    End Sub

    Private Sub btnVote_Click(sender As System.Object, e As System.EventArgs) Handles btnVote.Click

        If Panel3.Visible = True Then Panel3.Visible = False : Exit Sub

        Panel3.Visible = True

    End Sub

    Private Sub btnRegister_Click(sender As System.Object, e As System.EventArgs) Handles btnRegister.Click

        If Panel4.Visible = True Then Panel4.Visible = False : Exit Sub

        Panel4.Visible = True

    End Sub
End Class
