<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMarking
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMarking))
        Me.lblUnitName = New System.Windows.Forms.Label()
        Me.lblMandatory = New System.Windows.Forms.Label()
        Me.lblMandatoryAmount = New System.Windows.Forms.Label()
        Me.lblOptional = New System.Windows.Forms.Label()
        Me.lblOptionalAmount = New System.Windows.Forms.Label()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblGrade = New System.Windows.Forms.Label()
        Me.dataMarks = New System.Windows.Forms.DataGridView()
        Me.Information = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Criteria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mark = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btnMark = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblDistinction = New System.Windows.Forms.Label()
        Me.lblCredit = New System.Windows.Forms.Label()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.statLearner = New System.Windows.Forms.ToolStripStatusLabel()
        Me.statDate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.statBar = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.statMarker = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeInfoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CourseSelectorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuCourseSelector = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.saveAs = New System.Windows.Forms.SaveFileDialog()
        Me.chkRework = New System.Windows.Forms.CheckBox()
        Me.sttMarker = New System.Windows.Forms.ToolStripStatusLabel()
        Me.sttLearner = New System.Windows.Forms.ToolStripStatusLabel()
        Me.sttDate = New System.Windows.Forms.ToolStripStatusLabel()
        CType(Me.dataMarks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.statBar.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblUnitName
        '
        Me.lblUnitName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUnitName.AutoSize = True
        Me.lblUnitName.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnitName.Location = New System.Drawing.Point(24, 35)
        Me.lblUnitName.Name = "lblUnitName"
        Me.lblUnitName.Size = New System.Drawing.Size(445, 29)
        Me.lblUnitName.TabIndex = 0
        Me.lblUnitName.Text = "Unit Name (Pulled from title of txt file)"
        '
        'lblMandatory
        '
        Me.lblMandatory.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblMandatory.AutoSize = True
        Me.lblMandatory.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMandatory.Location = New System.Drawing.Point(356, 723)
        Me.lblMandatory.Name = "lblMandatory"
        Me.lblMandatory.Size = New System.Drawing.Size(96, 20)
        Me.lblMandatory.TabIndex = 3
        Me.lblMandatory.Text = "Mandatory"
        '
        'lblMandatoryAmount
        '
        Me.lblMandatoryAmount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblMandatoryAmount.AutoSize = True
        Me.lblMandatoryAmount.Location = New System.Drawing.Point(468, 725)
        Me.lblMandatoryAmount.Name = "lblMandatoryAmount"
        Me.lblMandatoryAmount.Size = New System.Drawing.Size(16, 17)
        Me.lblMandatoryAmount.TabIndex = 4
        Me.lblMandatoryAmount.Text = "0"
        '
        'lblOptional
        '
        Me.lblOptional.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblOptional.AutoSize = True
        Me.lblOptional.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOptional.Location = New System.Drawing.Point(519, 724)
        Me.lblOptional.Name = "lblOptional"
        Me.lblOptional.Size = New System.Drawing.Size(79, 20)
        Me.lblOptional.TabIndex = 5
        Me.lblOptional.Text = "Optional"
        '
        'lblOptionalAmount
        '
        Me.lblOptionalAmount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblOptionalAmount.AutoSize = True
        Me.lblOptionalAmount.Location = New System.Drawing.Point(616, 725)
        Me.lblOptionalAmount.Name = "lblOptionalAmount"
        Me.lblOptionalAmount.Size = New System.Drawing.Size(16, 17)
        Me.lblOptionalAmount.TabIndex = 6
        Me.lblOptionalAmount.Text = "0"
        '
        'btnExport
        '
        Me.btnExport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExport.Enabled = False
        Me.btnExport.Location = New System.Drawing.Point(161, 717)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(137, 28)
        Me.btnExport.TabIndex = 2
        Me.btnExport.Text = "Export as PDF"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnClear.Location = New System.Drawing.Point(161, 751)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(136, 31)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblGrade
        '
        Me.lblGrade.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblGrade.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrade.Location = New System.Drawing.Point(340, 763)
        Me.lblGrade.Name = "lblGrade"
        Me.lblGrade.Size = New System.Drawing.Size(302, 38)
        Me.lblGrade.TabIndex = 10
        Me.lblGrade.Text = "[Grade Achieved]"
        Me.lblGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dataMarks
        '
        Me.dataMarks.AllowUserToAddRows = False
        Me.dataMarks.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataMarks.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dataMarks.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dataMarks.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.dataMarks.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dataMarks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataMarks.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Information, Me.Criteria, Me.Type, Me.Mark})
        Me.dataMarks.Location = New System.Drawing.Point(30, 71)
        Me.dataMarks.Name = "dataMarks"
        Me.dataMarks.RowTemplate.Height = 24
        Me.dataMarks.ShowEditingIcon = False
        Me.dataMarks.Size = New System.Drawing.Size(800, 626)
        Me.dataMarks.TabIndex = 11
        '
        'Information
        '
        Me.Information.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Information.HeaderText = "Information"
        Me.Information.Name = "Information"
        Me.Information.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Criteria
        '
        Me.Criteria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Criteria.DefaultCellStyle = DataGridViewCellStyle2
        Me.Criteria.HeaderText = "Criteria"
        Me.Criteria.Name = "Criteria"
        Me.Criteria.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Type
        '
        Me.Type.HeaderText = "Type"
        Me.Type.Name = "Type"
        Me.Type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Type.Visible = False
        '
        'Mark
        '
        Me.Mark.HeaderText = "Mark"
        Me.Mark.Name = "Mark"
        Me.Mark.ToolTipText = "Checkboxes for each mark"
        Me.Mark.Width = 50
        '
        'btnMark
        '
        Me.btnMark.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnMark.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMark.Location = New System.Drawing.Point(30, 716)
        Me.btnMark.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnMark.Name = "btnMark"
        Me.btnMark.Size = New System.Drawing.Size(126, 102)
        Me.btnMark.TabIndex = 12
        Me.btnMark.Text = "Mark"
        Me.btnMark.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(664, 728)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 17)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Pass:"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(664, 758)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 17)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Credit:"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(664, 784)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 17)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Distinction:"
        '
        'lblDistinction
        '
        Me.lblDistinction.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblDistinction.AutoSize = True
        Me.lblDistinction.Location = New System.Drawing.Point(764, 783)
        Me.lblDistinction.Name = "lblDistinction"
        Me.lblDistinction.Size = New System.Drawing.Size(87, 17)
        Me.lblDistinction.TabIndex = 18
        Me.lblDistinction.Text = "lblDistinction"
        '
        'lblCredit
        '
        Me.lblCredit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCredit.AutoSize = True
        Me.lblCredit.Location = New System.Drawing.Point(764, 756)
        Me.lblCredit.Name = "lblCredit"
        Me.lblCredit.Size = New System.Drawing.Size(59, 17)
        Me.lblCredit.TabIndex = 17
        Me.lblCredit.Text = "lblCredit"
        '
        'lblPass
        '
        Me.lblPass.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblPass.AutoSize = True
        Me.lblPass.Location = New System.Drawing.Point(764, 727)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(53, 17)
        Me.lblPass.TabIndex = 16
        Me.lblPass.Text = "lblPass"
        '
        'statLearner
        '
        Me.statLearner.Name = "statLearner"
        Me.statLearner.Size = New System.Drawing.Size(82, 20)
        Me.statLearner.Text = "statLearner"
        '
        'statDate
        '
        Me.statDate.Name = "statDate"
        Me.statDate.Size = New System.Drawing.Size(65, 20)
        Me.statDate.Text = "statDate"
        '
        'statBar
        '
        Me.statBar.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.statBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.sttMarker, Me.sttLearner, Me.sttDate})
        Me.statBar.Location = New System.Drawing.Point(0, 835)
        Me.statBar.Name = "statBar"
        Me.statBar.Size = New System.Drawing.Size(858, 25)
        Me.statBar.TabIndex = 19
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 20)
        '
        'statMarker
        '
        Me.statMarker.Name = "statMarker"
        Me.statMarker.Size = New System.Drawing.Size(79, 20)
        Me.statMarker.Text = "statMarker"
        '
        'MenuStrip
        '
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(858, 28)
        Me.MenuStrip.TabIndex = 20
        Me.MenuStrip.Text = "MenuStrip"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangeInfoToolStripMenuItem1, Me.CourseSelectorToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ChangeInfoToolStripMenuItem1
        '
        Me.ChangeInfoToolStripMenuItem1.Name = "ChangeInfoToolStripMenuItem1"
        Me.ChangeInfoToolStripMenuItem1.Size = New System.Drawing.Size(181, 24)
        Me.ChangeInfoToolStripMenuItem1.Text = "Change Info"
        '
        'CourseSelectorToolStripMenuItem
        '
        Me.CourseSelectorToolStripMenuItem.Name = "CourseSelectorToolStripMenuItem"
        Me.CourseSelectorToolStripMenuItem.Size = New System.Drawing.Size(181, 24)
        Me.CourseSelectorToolStripMenuItem.Text = "Course Selector"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(62, 24)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'menuFile
        '
        Me.menuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangeInfoToolStripMenuItem, Me.menuCourseSelector})
        Me.menuFile.Name = "menuFile"
        Me.menuFile.Size = New System.Drawing.Size(44, 24)
        Me.menuFile.Text = "File"
        '
        'ChangeInfoToolStripMenuItem
        '
        Me.ChangeInfoToolStripMenuItem.Name = "ChangeInfoToolStripMenuItem"
        Me.ChangeInfoToolStripMenuItem.Size = New System.Drawing.Size(181, 24)
        Me.ChangeInfoToolStripMenuItem.Text = "Change Info"
        '
        'menuCourseSelector
        '
        Me.menuCourseSelector.Name = "menuCourseSelector"
        Me.menuCourseSelector.Size = New System.Drawing.Size(181, 24)
        Me.menuCourseSelector.Text = "Course Selector"
        '
        'menuAbout
        '
        Me.menuAbout.Name = "menuAbout"
        Me.menuAbout.Size = New System.Drawing.Size(62, 24)
        Me.menuAbout.Text = "About"
        '
        'chkRework
        '
        Me.chkRework.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkRework.AutoSize = True
        Me.chkRework.Location = New System.Drawing.Point(187, 797)
        Me.chkRework.Name = "chkRework"
        Me.chkRework.Size = New System.Drawing.Size(77, 21)
        Me.chkRework.TabIndex = 21
        Me.chkRework.Text = "Rework"
        Me.chkRework.UseVisualStyleBackColor = True
        '
        'sttMarker
        '
        Me.sttMarker.Name = "sttMarker"
        Me.sttMarker.Size = New System.Drawing.Size(71, 20)
        Me.sttMarker.Text = "sttMarker"
        '
        'sttLearner
        '
        Me.sttLearner.Name = "sttLearner"
        Me.sttLearner.Size = New System.Drawing.Size(74, 20)
        Me.sttLearner.Text = "sttLearner"
        '
        'sttDate
        '
        Me.sttDate.Name = "sttDate"
        Me.sttDate.Size = New System.Drawing.Size(57, 20)
        Me.sttDate.Text = "sttDate"
        '
        'frmMarking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(858, 860)
        Me.Controls.Add(Me.chkRework)
        Me.Controls.Add(Me.statBar)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.lblDistinction)
        Me.Controls.Add(Me.lblCredit)
        Me.Controls.Add(Me.lblPass)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnMark)
        Me.Controls.Add(Me.dataMarks)
        Me.Controls.Add(Me.lblGrade)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.lblOptionalAmount)
        Me.Controls.Add(Me.lblOptional)
        Me.Controls.Add(Me.lblMandatoryAmount)
        Me.Controls.Add(Me.lblMandatory)
        Me.Controls.Add(Me.lblUnitName)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "frmMarking"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Baltic Training Services Marking Application"
        CType(Me.dataMarks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.statBar.ResumeLayout(False)
        Me.statBar.PerformLayout()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblUnitName As System.Windows.Forms.Label
    Friend WithEvents lblMandatory As System.Windows.Forms.Label
    Friend WithEvents lblMandatoryAmount As System.Windows.Forms.Label
    Friend WithEvents lblOptional As System.Windows.Forms.Label
    Friend WithEvents lblOptionalAmount As System.Windows.Forms.Label
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lblGrade As System.Windows.Forms.Label
    Friend WithEvents dataMarks As System.Windows.Forms.DataGridView
    Friend WithEvents btnMark As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblDistinction As System.Windows.Forms.Label
    Friend WithEvents lblCredit As System.Windows.Forms.Label
    Friend WithEvents lblPass As System.Windows.Forms.Label
    Friend WithEvents statLearner As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents statDate As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents statBar As System.Windows.Forms.StatusStrip
    Friend WithEvents statMarker As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents menuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangeInfoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents saveAs As System.Windows.Forms.SaveFileDialog
    Friend WithEvents menuCourseSelector As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents chkRework As System.Windows.Forms.CheckBox
    Friend WithEvents Information As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Criteria As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Type As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Mark As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangeInfoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CourseSelectorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents sttMarker As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents sttLearner As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents sttDate As System.Windows.Forms.ToolStripStatusLabel
End Class
