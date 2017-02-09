Public Class frmSelect

    Dim path As String = My.Application.Info.DirectoryPath
    Public Dir As String = path + "\Units\" 'Directory where unit txt files are stored. This will be changed for the final published EXE as relative paths will be used.
    Public SubDir As String

    Private Sub frmSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        datDateBox.Value = Today()

        Try
            For Each directory As String In System.IO.Directory.GetDirectories(Dir)
                Dim dirInfo As New System.IO.DirectoryInfo(directory)
                cmbCategory.Items.Add(dirInfo.Name)
            Next

            For Each file As String In System.IO.Directory.GetFiles(Dir + cmbCategory.Text)
                cmbUnitName.Items.Add(System.IO.Path.GetFileNameWithoutExtension(file))
            Next
        Catch
            MessageBox.Show("Error - No unit files found")
            Me.Close()
        End Try
    End Sub

    Private Sub btnMark_Click(sender As Object, e As EventArgs) Handles btnMark.Click
        Dim password As String = "Procom03"
        If cmbUnitName.Text = "000 - How to use" Then 'Checks if required boxes are filled
            txtLearner.Text = "Learner Name"
            txtMarker.Text = "Assessor Name"

            frmMarking.Show()
            Me.Close()

        ElseIf cmbUnitName.Text <> "" And txtLearner.Text <> "" And txtMarker.Text <> "" And txtPassword.Text = password Then
            frmMarking.Show()
            Me.Close()

        Else : MsgBox("Please fill in all boxes and ensure password is correct")

        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtLearner.Text = ""
        txtMarker.Text = ""
        cmbUnitName.Text = ""
        txtPassword.Text = ""
    End Sub

    Private Sub cmbUnitName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbUnitName.SelectedIndexChanged

        If cmbUnitName.Text = "000 - How to use" Then 'Checks if required boxes are filled

            txtLearner.Text = "Press Mark for a tutorial"
            txtMarker.Text = "You will not require a password"
            txtPassword.Text = "password"

        ElseIf txtLearner.Text <> "Press Mark for a tutorial" And txtMarker.Text <> "You will not require a password" Then

        Else
            txtLearner.Text = ""
            txtMarker.Text = ""
            txtPassword.Text = ""
        End If
    End Sub

    Private Sub cmbCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategory.SelectedIndexChanged

        cmbUnitName.Items.Clear()
        cmbUnitName.Text = ""

        If txtLearner.Text = "Press Mark for a tutorial" Or txtMarker.Text = "You will not require a password" Or txtPassword.Text = "password" Then
            txtLearner.Text = ""
            txtMarker.Text = ""
            txtPassword.Text = ""
        Else
            cmbUnitName.Text = ""
        End If



        SubDir = Dir + cmbCategory.Text

        For Each file As String In System.IO.Directory.GetFiles(SubDir)
            cmbUnitName.Items.Add(System.IO.Path.GetFileNameWithoutExtension(file))
        Next

    End Sub
End Class
