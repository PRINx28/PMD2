<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.Title = New System.Windows.Forms.Label()
        Me.ButtonInsertPhoto = New System.Windows.Forms.Button()
        Me.ButtonInsert = New System.Windows.Forms.Button()
        Me.TextBoxUHC = New System.Windows.Forms.TextBox()
        Me.LabelUHC = New System.Windows.Forms.Label()
        Me.LabelCategory = New System.Windows.Forms.Label()
        Me.RichTextBoxRemarks = New System.Windows.Forms.RichTextBox()
        Me.LabelRemarks = New System.Windows.Forms.Label()
        Me.RichTextBoxAI = New System.Windows.Forms.RichTextBox()
        Me.LabelAI = New System.Windows.Forms.Label()
        Me.TextBoxOffice = New System.Windows.Forms.TextBox()
        Me.LabelOffice = New System.Windows.Forms.Label()
        Me.TextBoxPR = New System.Windows.Forms.TextBox()
        Me.LabelPR = New System.Windows.Forms.Label()
        Me.TextBoxOHV = New System.Windows.Forms.TextBox()
        Me.LabelOHV = New System.Windows.Forms.Label()
        Me.TextBoxUV = New System.Windows.Forms.TextBox()
        Me.LabelUV = New System.Windows.Forms.Label()
        Me.TextBoxQty = New System.Windows.Forms.TextBox()
        Me.LabelUnit = New System.Windows.Forms.Label()
        Me.TextBoxUnit = New System.Windows.Forms.TextBox()
        Me.LabelQty = New System.Windows.Forms.Label()
        Me.TextBoxPoN = New System.Windows.Forms.TextBox()
        Me.LabelPoN = New System.Windows.Forms.Label()
        Me.TextBoxIIN = New System.Windows.Forms.TextBox()
        Me.LabelIIN = New System.Windows.Forms.Label()
        Me.LabelDoP = New System.Windows.Forms.Label()
        Me.RichTextBoxDesc = New System.Windows.Forms.RichTextBox()
        Me.LabelDesc = New System.Windows.Forms.Label()
        Me.LabelSc = New System.Windows.Forms.Label()
        Me.TextBoxFund = New System.Windows.Forms.TextBox()
        Me.LabelFund = New System.Windows.Forms.Label()
        Me.TextBoxAC = New System.Windows.Forms.TextBox()
        Me.LabelAC = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.DateTimePickerDoP = New System.Windows.Forms.DateTimePicker()
        Me.ComboBoxCat = New System.Windows.Forms.ComboBox()
        Me.ComboBoxSubCat = New System.Windows.Forms.ComboBox()
        Me.ButtonBack = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.Location = New System.Drawing.Point(62, 22)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(118, 23)
        Me.Title.TabIndex = 77
        Me.Title.Text = "Insert Data"
        '
        'ButtonInsertPhoto
        '
        Me.ButtonInsertPhoto.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonInsertPhoto.FlatAppearance.BorderSize = 0
        Me.ButtonInsertPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonInsertPhoto.Image = Global.PMSInput.My.Resources.Resources.icons8_add_photo_29
        Me.ButtonInsertPhoto.Location = New System.Drawing.Point(746, 340)
        Me.ButtonInsertPhoto.Name = "ButtonInsertPhoto"
        Me.ButtonInsertPhoto.Size = New System.Drawing.Size(37, 32)
        Me.ButtonInsertPhoto.TabIndex = 75
        Me.ButtonInsertPhoto.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.ButtonInsertPhoto.UseVisualStyleBackColor = True
        '
        'ButtonInsert
        '
        Me.ButtonInsert.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonInsert.FlatAppearance.BorderSize = 0
        Me.ButtonInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonInsert.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonInsert.Image = CType(resources.GetObject("ButtonInsert.Image"), System.Drawing.Image)
        Me.ButtonInsert.Location = New System.Drawing.Point(766, 430)
        Me.ButtonInsert.Name = "ButtonInsert"
        Me.ButtonInsert.Size = New System.Drawing.Size(38, 38)
        Me.ButtonInsert.TabIndex = 74
        Me.ButtonInsert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ButtonInsert.UseVisualStyleBackColor = True
        '
        'TextBoxUHC
        '
        Me.TextBoxUHC.Location = New System.Drawing.Point(388, 132)
        Me.TextBoxUHC.Name = "TextBoxUHC"
        Me.TextBoxUHC.Size = New System.Drawing.Size(114, 20)
        Me.TextBoxUHC.TabIndex = 73
        '
        'LabelUHC
        '
        Me.LabelUHC.AutoSize = True
        Me.LabelUHC.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUHC.Location = New System.Drawing.Point(386, 113)
        Me.LabelUHC.Name = "LabelUHC"
        Me.LabelUHC.Size = New System.Drawing.Size(99, 16)
        Me.LabelUHC.TabIndex = 72
        Me.LabelUHC.Text = "Unit Hand Count"
        '
        'LabelCategory
        '
        Me.LabelCategory.AutoSize = True
        Me.LabelCategory.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCategory.Location = New System.Drawing.Point(30, 167)
        Me.LabelCategory.Name = "LabelCategory"
        Me.LabelCategory.Size = New System.Drawing.Size(58, 16)
        Me.LabelCategory.TabIndex = 70
        Me.LabelCategory.Text = "Category"
        '
        'RichTextBoxRemarks
        '
        Me.RichTextBoxRemarks.Location = New System.Drawing.Point(581, 188)
        Me.RichTextBoxRemarks.Name = "RichTextBoxRemarks"
        Me.RichTextBoxRemarks.Size = New System.Drawing.Size(223, 73)
        Me.RichTextBoxRemarks.TabIndex = 69
        Me.RichTextBoxRemarks.Text = ""
        '
        'LabelRemarks
        '
        Me.LabelRemarks.AutoSize = True
        Me.LabelRemarks.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRemarks.Location = New System.Drawing.Point(578, 167)
        Me.LabelRemarks.Name = "LabelRemarks"
        Me.LabelRemarks.Size = New System.Drawing.Size(57, 16)
        Me.LabelRemarks.TabIndex = 68
        Me.LabelRemarks.Text = "Remarks"
        '
        'RichTextBoxAI
        '
        Me.RichTextBoxAI.Location = New System.Drawing.Point(581, 83)
        Me.RichTextBoxAI.Name = "RichTextBoxAI"
        Me.RichTextBoxAI.Size = New System.Drawing.Size(223, 74)
        Me.RichTextBoxAI.TabIndex = 67
        Me.RichTextBoxAI.Text = ""
        '
        'LabelAI
        '
        Me.LabelAI.AutoSize = True
        Me.LabelAI.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAI.Location = New System.Drawing.Point(578, 64)
        Me.LabelAI.Name = "LabelAI"
        Me.LabelAI.Size = New System.Drawing.Size(133, 16)
        Me.LabelAI.TabIndex = 66
        Me.LabelAI.Text = "Additional Information"
        '
        'TextBoxOffice
        '
        Me.TextBoxOffice.Location = New System.Drawing.Point(392, 291)
        Me.TextBoxOffice.Name = "TextBoxOffice"
        Me.TextBoxOffice.Size = New System.Drawing.Size(114, 20)
        Me.TextBoxOffice.TabIndex = 65
        '
        'LabelOffice
        '
        Me.LabelOffice.AutoSize = True
        Me.LabelOffice.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelOffice.Location = New System.Drawing.Point(389, 272)
        Me.LabelOffice.Name = "LabelOffice"
        Me.LabelOffice.Size = New System.Drawing.Size(40, 16)
        Me.LabelOffice.TabIndex = 64
        Me.LabelOffice.Text = "Office"
        '
        'TextBoxPR
        '
        Me.TextBoxPR.Location = New System.Drawing.Point(388, 240)
        Me.TextBoxPR.Name = "TextBoxPR"
        Me.TextBoxPR.Size = New System.Drawing.Size(114, 20)
        Me.TextBoxPR.TabIndex = 63
        '
        'LabelPR
        '
        Me.LabelPR.AutoSize = True
        Me.LabelPR.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPR.Location = New System.Drawing.Point(386, 221)
        Me.LabelPR.Name = "LabelPR"
        Me.LabelPR.Size = New System.Drawing.Size(118, 16)
        Me.LabelPR.TabIndex = 62
        Me.LabelPR.Text = "Person Responsible"
        '
        'TextBoxOHV
        '
        Me.TextBoxOHV.Location = New System.Drawing.Point(388, 183)
        Me.TextBoxOHV.Name = "TextBoxOHV"
        Me.TextBoxOHV.Size = New System.Drawing.Size(114, 20)
        Me.TextBoxOHV.TabIndex = 61
        '
        'LabelOHV
        '
        Me.LabelOHV.AutoSize = True
        Me.LabelOHV.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelOHV.Location = New System.Drawing.Point(385, 167)
        Me.LabelOHV.Name = "LabelOHV"
        Me.LabelOHV.Size = New System.Drawing.Size(92, 16)
        Me.LabelOHV.TabIndex = 60
        Me.LabelOHV.Text = "On Hand Value"
        '
        'TextBoxUV
        '
        Me.TextBoxUV.Location = New System.Drawing.Point(388, 83)
        Me.TextBoxUV.Name = "TextBoxUV"
        Me.TextBoxUV.Size = New System.Drawing.Size(114, 20)
        Me.TextBoxUV.TabIndex = 59
        '
        'LabelUV
        '
        Me.LabelUV.AutoSize = True
        Me.LabelUV.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUV.Location = New System.Drawing.Point(385, 64)
        Me.LabelUV.Name = "LabelUV"
        Me.LabelUV.Size = New System.Drawing.Size(65, 16)
        Me.LabelUV.TabIndex = 58
        Me.LabelUV.Text = "Unit Value"
        '
        'TextBoxQty
        '
        Me.TextBoxQty.Location = New System.Drawing.Point(207, 241)
        Me.TextBoxQty.Name = "TextBoxQty"
        Me.TextBoxQty.Size = New System.Drawing.Size(114, 20)
        Me.TextBoxQty.TabIndex = 57
        '
        'LabelUnit
        '
        Me.LabelUnit.AutoSize = True
        Me.LabelUnit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUnit.Location = New System.Drawing.Point(204, 167)
        Me.LabelUnit.Name = "LabelUnit"
        Me.LabelUnit.Size = New System.Drawing.Size(29, 16)
        Me.LabelUnit.TabIndex = 56
        Me.LabelUnit.Text = "Unit"
        '
        'TextBoxUnit
        '
        Me.TextBoxUnit.Location = New System.Drawing.Point(207, 183)
        Me.TextBoxUnit.Name = "TextBoxUnit"
        Me.TextBoxUnit.Size = New System.Drawing.Size(114, 20)
        Me.TextBoxUnit.TabIndex = 55
        '
        'LabelQty
        '
        Me.LabelQty.AutoSize = True
        Me.LabelQty.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelQty.Location = New System.Drawing.Point(204, 221)
        Me.LabelQty.Name = "LabelQty"
        Me.LabelQty.Size = New System.Drawing.Size(26, 16)
        Me.LabelQty.TabIndex = 54
        Me.LabelQty.Text = "Qty"
        '
        'TextBoxPoN
        '
        Me.TextBoxPoN.Location = New System.Drawing.Point(207, 132)
        Me.TextBoxPoN.Name = "TextBoxPoN"
        Me.TextBoxPoN.Size = New System.Drawing.Size(114, 20)
        Me.TextBoxPoN.TabIndex = 53
        '
        'LabelPoN
        '
        Me.LabelPoN.AutoSize = True
        Me.LabelPoN.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPoN.Location = New System.Drawing.Point(204, 113)
        Me.LabelPoN.Name = "LabelPoN"
        Me.LabelPoN.Size = New System.Drawing.Size(46, 16)
        Me.LabelPoN.TabIndex = 52
        Me.LabelPoN.Text = "PO No."
        '
        'TextBoxIIN
        '
        Me.TextBoxIIN.Location = New System.Drawing.Point(207, 83)
        Me.TextBoxIIN.Name = "TextBoxIIN"
        Me.TextBoxIIN.Size = New System.Drawing.Size(114, 20)
        Me.TextBoxIIN.TabIndex = 51
        '
        'LabelIIN
        '
        Me.LabelIIN.AutoSize = True
        Me.LabelIIN.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelIIN.Location = New System.Drawing.Point(204, 64)
        Me.LabelIIN.Name = "LabelIIN"
        Me.LabelIIN.Size = New System.Drawing.Size(113, 16)
        Me.LabelIIN.TabIndex = 50
        Me.LabelIIN.Text = "Inventory Item No."
        '
        'LabelDoP
        '
        Me.LabelDoP.AutoSize = True
        Me.LabelDoP.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDoP.Location = New System.Drawing.Point(30, 272)
        Me.LabelDoP.Name = "LabelDoP"
        Me.LabelDoP.Size = New System.Drawing.Size(104, 16)
        Me.LabelDoP.TabIndex = 48
        Me.LabelDoP.Text = "Date of Purchase"
        '
        'RichTextBoxDesc
        '
        Me.RichTextBoxDesc.Location = New System.Drawing.Point(33, 340)
        Me.RichTextBoxDesc.Name = "RichTextBoxDesc"
        Me.RichTextBoxDesc.Size = New System.Drawing.Size(301, 128)
        Me.RichTextBoxDesc.TabIndex = 47
        Me.RichTextBoxDesc.Text = ""
        '
        'LabelDesc
        '
        Me.LabelDesc.AutoSize = True
        Me.LabelDesc.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDesc.Location = New System.Drawing.Point(30, 321)
        Me.LabelDesc.Name = "LabelDesc"
        Me.LabelDesc.Size = New System.Drawing.Size(70, 16)
        Me.LabelDesc.TabIndex = 46
        Me.LabelDesc.Text = "Description"
        '
        'LabelSc
        '
        Me.LabelSc.AutoSize = True
        Me.LabelSc.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSc.Location = New System.Drawing.Point(30, 221)
        Me.LabelSc.Name = "LabelSc"
        Me.LabelSc.Size = New System.Drawing.Size(78, 16)
        Me.LabelSc.TabIndex = 44
        Me.LabelSc.Text = "Subcategory"
        '
        'TextBoxFund
        '
        Me.TextBoxFund.Location = New System.Drawing.Point(33, 132)
        Me.TextBoxFund.Name = "TextBoxFund"
        Me.TextBoxFund.Size = New System.Drawing.Size(114, 20)
        Me.TextBoxFund.TabIndex = 43
        '
        'LabelFund
        '
        Me.LabelFund.AutoSize = True
        Me.LabelFund.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFund.Location = New System.Drawing.Point(30, 113)
        Me.LabelFund.Name = "LabelFund"
        Me.LabelFund.Size = New System.Drawing.Size(35, 16)
        Me.LabelFund.TabIndex = 42
        Me.LabelFund.Text = "Fund"
        '
        'TextBoxAC
        '
        Me.TextBoxAC.Location = New System.Drawing.Point(33, 83)
        Me.TextBoxAC.Name = "TextBoxAC"
        Me.TextBoxAC.Size = New System.Drawing.Size(114, 20)
        Me.TextBoxAC.TabIndex = 41
        '
        'LabelAC
        '
        Me.LabelAC.AutoSize = True
        Me.LabelAC.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAC.Location = New System.Drawing.Point(30, 64)
        Me.LabelAC.Name = "LabelAC"
        Me.LabelAC.Size = New System.Drawing.Size(85, 16)
        Me.LabelAC.TabIndex = 40
        Me.LabelAC.Text = "Account Code"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel1.Controls.Add(Me.PictureBox)
        Me.Panel1.Location = New System.Drawing.Point(581, 291)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(159, 128)
        Me.Panel1.TabIndex = 76
        '
        'PictureBox
        '
        Me.PictureBox.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(159, 128)
        Me.PictureBox.TabIndex = 37
        Me.PictureBox.TabStop = False
        '
        'DateTimePickerDoP
        '
        Me.DateTimePickerDoP.Location = New System.Drawing.Point(33, 291)
        Me.DateTimePickerDoP.Name = "DateTimePickerDoP"
        Me.DateTimePickerDoP.Size = New System.Drawing.Size(204, 20)
        Me.DateTimePickerDoP.TabIndex = 78
        '
        'ComboBoxCat
        '
        Me.ComboBoxCat.FormattingEnabled = True
        Me.ComboBoxCat.Location = New System.Drawing.Point(33, 186)
        Me.ComboBoxCat.Name = "ComboBoxCat"
        Me.ComboBoxCat.Size = New System.Drawing.Size(114, 21)
        Me.ComboBoxCat.TabIndex = 79
        '
        'ComboBoxSubCat
        '
        Me.ComboBoxSubCat.FormattingEnabled = True
        Me.ComboBoxSubCat.Location = New System.Drawing.Point(33, 240)
        Me.ComboBoxSubCat.Name = "ComboBoxSubCat"
        Me.ComboBoxSubCat.Size = New System.Drawing.Size(114, 21)
        Me.ComboBoxSubCat.TabIndex = 80
        '
        'ButtonBack
        '
        Me.ButtonBack.FlatAppearance.BorderSize = 0
        Me.ButtonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonBack.Image = CType(resources.GetObject("ButtonBack.Image"), System.Drawing.Image)
        Me.ButtonBack.Location = New System.Drawing.Point(33, 22)
        Me.ButtonBack.Name = "ButtonBack"
        Me.ButtonBack.Size = New System.Drawing.Size(23, 23)
        Me.ButtonBack.TabIndex = 81
        Me.ButtonBack.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(840, 497)
        Me.Controls.Add(Me.ButtonBack)
        Me.Controls.Add(Me.ComboBoxSubCat)
        Me.Controls.Add(Me.ComboBoxCat)
        Me.Controls.Add(Me.DateTimePickerDoP)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.ButtonInsertPhoto)
        Me.Controls.Add(Me.ButtonInsert)
        Me.Controls.Add(Me.TextBoxUHC)
        Me.Controls.Add(Me.LabelUHC)
        Me.Controls.Add(Me.LabelCategory)
        Me.Controls.Add(Me.RichTextBoxRemarks)
        Me.Controls.Add(Me.LabelRemarks)
        Me.Controls.Add(Me.RichTextBoxAI)
        Me.Controls.Add(Me.LabelAI)
        Me.Controls.Add(Me.TextBoxOffice)
        Me.Controls.Add(Me.LabelOffice)
        Me.Controls.Add(Me.TextBoxPR)
        Me.Controls.Add(Me.LabelPR)
        Me.Controls.Add(Me.TextBoxOHV)
        Me.Controls.Add(Me.LabelOHV)
        Me.Controls.Add(Me.TextBoxUV)
        Me.Controls.Add(Me.LabelUV)
        Me.Controls.Add(Me.TextBoxQty)
        Me.Controls.Add(Me.LabelUnit)
        Me.Controls.Add(Me.TextBoxUnit)
        Me.Controls.Add(Me.LabelQty)
        Me.Controls.Add(Me.TextBoxPoN)
        Me.Controls.Add(Me.LabelPoN)
        Me.Controls.Add(Me.TextBoxIIN)
        Me.Controls.Add(Me.LabelIIN)
        Me.Controls.Add(Me.LabelDoP)
        Me.Controls.Add(Me.RichTextBoxDesc)
        Me.Controls.Add(Me.LabelDesc)
        Me.Controls.Add(Me.LabelSc)
        Me.Controls.Add(Me.TextBoxFund)
        Me.Controls.Add(Me.LabelFund)
        Me.Controls.Add(Me.TextBoxAC)
        Me.Controls.Add(Me.LabelAC)
        Me.Controls.Add(Me.Panel1)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Property Management System"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Title As Label
    Friend WithEvents ButtonInsertPhoto As Button
    Friend WithEvents ButtonInsert As Button
    Friend WithEvents TextBoxUHC As TextBox
    Friend WithEvents LabelUHC As Label
    Friend WithEvents LabelCategory As Label
    Friend WithEvents RichTextBoxRemarks As RichTextBox
    Friend WithEvents LabelRemarks As Label
    Friend WithEvents RichTextBoxAI As RichTextBox
    Friend WithEvents LabelAI As Label
    Friend WithEvents TextBoxOffice As TextBox
    Friend WithEvents LabelOffice As Label
    Friend WithEvents TextBoxPR As TextBox
    Friend WithEvents LabelPR As Label
    Friend WithEvents TextBoxOHV As TextBox
    Friend WithEvents LabelOHV As Label
    Friend WithEvents TextBoxUV As TextBox
    Friend WithEvents LabelUV As Label
    Friend WithEvents TextBoxQty As TextBox
    Friend WithEvents LabelUnit As Label
    Friend WithEvents TextBoxUnit As TextBox
    Friend WithEvents LabelQty As Label
    Friend WithEvents TextBoxPoN As TextBox
    Friend WithEvents LabelPoN As Label
    Friend WithEvents TextBoxIIN As TextBox
    Friend WithEvents LabelIIN As Label
    Friend WithEvents LabelDoP As Label
    Friend WithEvents RichTextBoxDesc As RichTextBox
    Friend WithEvents LabelDesc As Label
    Friend WithEvents LabelSc As Label
    Friend WithEvents TextBoxFund As TextBox
    Friend WithEvents LabelFund As Label
    Friend WithEvents TextBoxAC As TextBox
    Friend WithEvents LabelAC As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox As PictureBox
    Friend WithEvents DateTimePickerDoP As DateTimePicker
    Friend WithEvents ComboBoxCat As ComboBox
    Friend WithEvents ComboBoxSubCat As ComboBox
    Friend WithEvents ButtonBack As Button
End Class
