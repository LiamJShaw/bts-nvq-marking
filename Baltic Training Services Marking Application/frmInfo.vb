Public Class frmInfo

    Private Sub frmInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmMarking.Enabled = False

        txtLearner.Text = frmMarking.learnerName
        txtMarker.Text = frmMarking.markerName

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        frmMarking.learnerName = txtLearner.Text
        frmMarking.markerName = txtMarker.Text

        frmMarking.statLearner.Text = "Learner Name: " + txtLearner.Text
        frmMarking.statMarker.Text = "Marker Name: " + txtMarker.Text

        frmMarking.Enabled = True
        Me.Close()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        frmMarking.Enabled = True
        Me.Close()

    End Sub
End Class