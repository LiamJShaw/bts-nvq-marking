Imports System.IO
Imports System.Data
Imports System.Reflection
Imports System.Text
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class frmMarking

    Public unitName, unitCriteria, unitDirectory, learnerName, markerName As String
    Dim markOptional, markMandatory As Integer
    Dim markPass, markCredit, markDistinction As String 'These hold the values for pass marks
    Dim gradeAchieved As String
    Dim dateMarked As String

    Dim meantToClose As Boolean

    Dim path As String = My.Application.Info.DirectoryPath

    Private Sub frmMarking_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        meantToClose = False 'This is a hacky way of allowing us to get back to the course selector and still make sure that you don't accdientally shut the app

        unitName = frmSelect.cmbUnitName.Text
        unitDirectory = frmSelect.SubDir 'Pulls the directory where the Units are stored from the other form
        unitCriteria = (unitDirectory + "\" + frmSelect.cmbUnitName.Text + ".txt") 'Creates a path with extension for the file reader
        learnerName = frmSelect.txtLearner.Text
        markerName = frmSelect.txtMarker.Text
        dateMarked = Format(frmSelect.datDateBox.Value, "d")

        lblUnitName.Text = unitName 'Changes label at top to be the name of the text file used to populate DGV

        Using stream As System.IO.FileStream = System.IO.File.OpenRead(unitCriteria) 'Opens text file based on what was selected in frmSelect 
            Using reader As New System.IO.StreamReader(stream) 'Reads the text file from the stream

                Dim line As String

                markPass = reader.ReadLine()
                markCredit = reader.ReadLine()
                markDistinction = reader.ReadLine()

                While (reader.Peek > -1) 'Runs until the end of the file

                    Dim i As Integer = 0

                    line = reader.ReadLine()

                    Dim columns = line.Split(";") 'Sets the splitter as a semicolon

                    Dim index = Me.dataMarks.Rows.Add()

                    Me.dataMarks.Rows(index).SetValues(columns) 'Adds the line to the dataMarks DGV

                End While
            End Using
        End Using

        For i = 0 To dataMarks.Rows.Count - 1
            If dataMarks.Rows(i).Cells(2).Value = "M" Then
                dataMarks.Rows(i).DefaultCellStyle.Font = New System.Drawing.Font("Arial", 9, FontStyle.Bold) 'Makes mandatory marks bold in the DGV
            End If
        Next

        dataMarks.DefaultCellStyle.WrapMode = DataGridViewTriState.True

        lblPass.Text = markPass
        lblCredit.Text = markCredit
        lblDistinction.Text = markDistinction

        sttMarker.Text = "Assessor Name: " + markerName
        sttLearner.Text = "Learner Name: " + learnerName
        sttDate.Text = "Date: " + DateTime.Today

    End Sub

    Private Sub btnExport_Click(sender As System.Object, e As System.EventArgs) Handles btnExport.Click

        'Creating iTextSharp Table from the DataTable data
        Dim pdfTable As New PdfPTable(dataMarks.ColumnCount)

        pdfTable.DefaultCell.Padding = 3
        pdfTable.WidthPercentage = 100
        pdfTable.HorizontalAlignment = Element.ALIGN_LEFT
        pdfTable.DefaultCell.BorderWidth = 1

        Dim titleFont As Font = FontFactory.GetFont("Arial") 'Creates style for table title font
        titleFont.SetStyle("Bold")
        titleFont.SetColor(255, 255, 255)

        'Adding Header row
        For Each column As DataGridViewColumn In dataMarks.Columns
            Dim cell As New PdfPCell(New Phrase(column.HeaderText, titleFont))
            cell.BackgroundColor = New iTextSharp.text.BaseColor(0, 92, 169) 'Baltic Blue, yo.
            cell.BorderWidthTop = 2.0F
            cell.PaddingBottom = 10.0F
            cell.PaddingTop = 4.0F
            pdfTable.AddCell(cell)
        Next

        'Adding DataRow
        For Each row As DataGridViewRow In dataMarks.Rows
            For Each cell As DataGridViewCell In row.Cells
                If cell.Value IsNot Nothing Then 'If the value of any of the checkboxes is null then display "false" in the PDF
                    If cell.Value.ToString() = "True" Then
                        pdfTable.AddCell("X")
                    ElseIf cell.Value.ToString() = "False" Then
                        pdfTable.AddCell("")
                    Else
                        pdfTable.AddCell(cell.Value.ToString())
                    End If
                Else
                    pdfTable.AddCell("")
                End If
            Next
        Next

        Dim intTblWidth() As Integer = {40, 50, 10, 10}
        pdfTable.SetWidths(intTblWidth)

        'Bring up the save file dialog
        saveAs.FileName = learnerName + " - " + unitName
        saveAs.Filter = "PDF Files (*.pdf)|*.pdf"

        Try
            If saveAs.ShowDialog = Windows.Forms.DialogResult.OK Then
                Using stream As New FileStream(saveAs.FileName, FileMode.Create)
                    Dim pdfDoc As New Document(PageSize.A4, 10.0F, 10.0F, 10.0F, 0.0F)
                    PdfWriter.GetInstance(pdfDoc, stream)
                    pdfDoc.Open()

                    Dim logo As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(My.Resources.baltic, System.Drawing.Imaging.ImageFormat.Png)
                    logo.ScalePercent(75)
                    logo.SetAbsolutePosition(pdfDoc.PageSize.Width - 36.0F - 117.75F, pdfDoc.PageSize.Height - 36.0F - 161.25F)
                    pdfDoc.Add(logo)

                    Dim x As Font = FontFactory.GetFont("Arial")
                    x.Size = 28
                    x.SetStyle("Bold")
                    x.SetColor(0, 92, 169)

                    pdfDoc.Add(New Paragraph("Baltic Training Services", x))

                    pdfDoc.Add(New Paragraph(Environment.NewLine))

                    pdfDoc.Add(New Paragraph("Course name: " & unitName))
                    pdfDoc.Add(New Paragraph("Learner name: " & learnerName))
                    pdfDoc.Add(New Paragraph("Assessor name: " & markerName))
                    pdfDoc.Add(New Paragraph("Date Marked: " & dateMarked))

                    pdfDoc.Add(New Paragraph(Environment.NewLine))

                    pdfDoc.Add(New Paragraph("Mandatory marks attained: " & markMandatory))
                    pdfDoc.Add(New Paragraph("Optional marks attained: " & markOptional))

                    If chkRework.Checked = False Then
                        pdfDoc.Add(New Paragraph("Grade achieved: " & gradeAchieved))
                    ElseIf chkRework.Checked = True And gradeAchieved.Equals("Pass") Then 'If the rework checkbox is checked
                        pdfDoc.Add(New Paragraph("Grade achieved: Pass (Rework)"))
                    End If

                    pdfDoc.Add(New Paragraph(Environment.NewLine))

                    pdfDoc.Add(New Paragraph("Pass: " & markPass))
                    pdfDoc.Add(New Paragraph("Credit: " & markCredit))
                    pdfDoc.Add(New Paragraph("Distinction: " & markDistinction))

                    pdfDoc.Add(New Paragraph(Environment.NewLine))

                    pdfDoc.Add(New Paragraph("Assessor: ______________________" & "       Date: _______________"))
                    pdfDoc.Add(New Paragraph("Candidate: _____________________" & "       Date: _______________"))
                    pdfDoc.Add(New Paragraph("Quality Nominee: _________________" & "     Date: _______________"))
                    pdfDoc.Add(New Paragraph("External Verifier: _________________" & "      Date: _______________"))

                    pdfDoc.Add(New Paragraph(Environment.NewLine))

                    pdfDoc.Add(pdfTable) 'Add the table into the new PDF document
                    pdfDoc.Close()
                    stream.Close()
                End Using
            End If
        Catch ex As Exception
            MessageBox.Show("File not able to be saved.", "ERROR")
        End Try
        
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        Dim result As Integer = MessageBox.Show("Are you sure you'd like to clear all checkboxes?", "Baltic Marking Application", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then

            btnExport.Enabled = False

            For Each row As DataGridViewRow In dataMarks.Rows
                row.Cells(3).Value = False 'Clear all checked boxes in DGV
            Next
            lblGrade.Text = "[Grade Achieved]" 'Clear the GRADE ACHIEVED
            lblGrade.ForeColor = Color.Black

            lblMandatoryAmount.Text = "0"
            lblOptionalAmount.Text = "0"
        End If
    End Sub

    Private Sub btnMark_Click(sender As Object, e As EventArgs) Handles btnMark.Click

        btnExport.Enabled = True

        Dim mandatoryTotal As Integer

        markMandatory = 0
        markOptional = 0

        For Each row As DataGridViewRow In dataMarks.Rows
            If row.Cells(2).Value = "M" Then 'Counts up amount of mandatory marks available
                mandatoryTotal += 1
            End If
        Next

        For Each row As DataGridViewRow In dataMarks.Rows

            If row.Cells(2).Value = "M" And row.Cells(3).Value = True Then
                markMandatory += 1  'If mark is mandatory AND true, then add one to Mandatory Marks
            ElseIf row.Cells(3).Value = True Then
                markOptional += 1 'If it's NOT mandatory and it is checked, add one to Optional Marks
            End If
        Next

        If markMandatory = mandatoryTotal Then 'Checks if all mandatory marks are True. If they are, it then checks the optional marks.
            If markOptional < markPass Then
                gradeAchieved = "Fail"
                lblGrade.ForeColor = Color.Red
            ElseIf markOptional >= markPass And markOptional < markCredit Then
                gradeAchieved = "Pass"
                lblGrade.ForeColor = Color.Green
            ElseIf markOptional >= markCredit And markOptional < markDistinction And chkRework.Checked = False Then
                gradeAchieved = "Credit"
                lblGrade.ForeColor = Color.Green
            ElseIf markOptional >= markDistinction And chkRework.Checked = False Then
                gradeAchieved = "Distinction"
                lblGrade.ForeColor = Color.Green
            ElseIf markOptional >= markCredit And markOptional < markDistinction And chkRework.Checked = True Then
                gradeAchieved = "Pass"
                lblGrade.ForeColor = Color.Green
            ElseIf markOptional >= markDistinction And chkRework.Checked = True Then
                gradeAchieved = "Pass"
                lblGrade.ForeColor = Color.Green
            End If
        Else
            gradeAchieved = "Fail"
            lblGrade.ForeColor = Color.Red
        End If

        lblMandatoryAmount.Text = markMandatory
        lblOptionalAmount.Text = markOptional
        lblGrade.Text = gradeAchieved

    End Sub

    Private Sub Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If meantToClose = False Then
            Dim result As Integer = MessageBox.Show("Are you sure you'd like to exit?", "Baltic Marking Application", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                'Application exits
            ElseIf result = DialogResult.No Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub ChangeInfoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ChangeInfoToolStripMenuItem1.Click
        frmInfo.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        frmAbout.Show()
    End Sub

    Private Sub CourseSelectorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CourseSelectorToolStripMenuItem.Click
        Dim result As Integer = MessageBox.Show("Are you sure you'd like to go back to the course selector? All unsaved data will be lost", "Baltic Marking Application", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            meantToClose = True
            frmSelect.Show()
            Me.Close()
        End If
    End Sub
End Class