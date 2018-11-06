Public Class Form1
    Private Sub principal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles principal.KeyPress
        If (Not Char.IsControl(e.KeyChar) _
                     AndAlso (Not Char.IsDigit(e.KeyChar) _
                     AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
            e.Handled = True
        End If
    End Sub
    Private Sub rate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles rate.KeyPress
        If (Not Char.IsControl(e.KeyChar) _
                     AndAlso (Not Char.IsDigit(e.KeyChar) _
                     AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
            e.Handled = True
        End If
    End Sub
    Private Sub time_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles time.KeyPress
        If (Not Char.IsControl(e.KeyChar) _
                     AndAlso (Not Char.IsDigit(e.KeyChar) _
                     AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
            e.Handled = True
        End If
    End Sub
    Private Sub simple_I_Click(sender As Object, e As EventArgs) Handles simple_I.Click
        Try
            result.Text = (Int(principal.Text) * Int(rate.Text) * Int(time.Text)) / 100
        Catch ex As Exception
            MessageBox.Show("Please enter a value!", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub exiter_Click(sender As Object, e As EventArgs) Handles exiter.Click
        Me.Close()
    End Sub

    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        result.Text = ""
        principal.Text = ""
        rate.Text = ""
        time.Text = ""
    End Sub

    Private Sub compound_I_Click(sender As Object, e As EventArgs) Handles compound_I.Click
        result.Text = Int(principal.Text) * Math.Pow(1 + Int(rate.Text), Int(time.Text))
    End Sub
End Class
