Imports System.Security.Principal
Public Class Form1

    Private Sub FlatButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton1.Click
        Try
            My.Computer.Registry.SetValue("HKEY_CLASSES_ROOT\dromjmfile", "", "")
            MessageBox.Show("Camtasia licence resetted!", "Camstadia Studio Trial Reset", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            Dim text = "Failed to reset Camtasia licence!"
            If My.User.IsInRole(ApplicationServices.BuiltInRole.Administrator) = False Then
                text += vbCrLf & vbCrLf & "Retry with administrator privileges."
            End If
            MessageBox.Show(text, "Camstadia Studio Trial Reset", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Computer.Info.OSVersion.StartsWith("6.1") Then
            FlatCheckBox1.Enabled = True
        Else
            FlatCheckBox1.Enabled = False
        End If
    End Sub
End Class
