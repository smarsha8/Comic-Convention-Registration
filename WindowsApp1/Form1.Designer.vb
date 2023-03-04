<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComicConventionRegistration
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
        Me.piccomic = New System.Windows.Forms.PictureBox()
        Me.lblcomicconvention = New System.Windows.Forms.Label()
        Me.lblGroupSize = New System.Windows.Forms.Label()
        Me.txtSizeentry = New System.Windows.Forms.TextBox()
        Me.grpSelectBadgeType = New System.Windows.Forms.GroupBox()
        Me.rdbtnConvention = New System.Windows.Forms.RadioButton()
        Me.rdbtnConventionAutographs = New System.Windows.Forms.RadioButton()
        Me.rdbtnConventionSuperhero = New System.Windows.Forms.RadioButton()
        Me.lblRegistrationCost = New System.Windows.Forms.Label()
        Me.lblRegistrationPrice = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnCleaar = New System.Windows.Forms.Button()
        CType(Me.piccomic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSelectBadgeType.SuspendLayout()
        Me.SuspendLayout()
        '
        'piccomic
        '
        Me.piccomic.Image = Global.WindowsApp1.My.Resources.Resources.comic
        Me.piccomic.Location = New System.Drawing.Point(-4, -2)
        Me.piccomic.Name = "piccomic"
        Me.piccomic.Size = New System.Drawing.Size(895, 271)
        Me.piccomic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.piccomic.TabIndex = 0
        Me.piccomic.TabStop = False
        '
        'lblcomicconvention
        '
        Me.lblcomicconvention.AutoSize = True
        Me.lblcomicconvention.BackColor = System.Drawing.SystemColors.Control
        Me.lblcomicconvention.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcomicconvention.ForeColor = System.Drawing.Color.Red
        Me.lblcomicconvention.Location = New System.Drawing.Point(129, 296)
        Me.lblcomicconvention.Name = "lblcomicconvention"
        Me.lblcomicconvention.Size = New System.Drawing.Size(601, 46)
        Me.lblcomicconvention.TabIndex = 1
        Me.lblcomicconvention.Text = "Comic Convention Registration"
        '
        'lblGroupSize
        '
        Me.lblGroupSize.AutoSize = True
        Me.lblGroupSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGroupSize.ForeColor = System.Drawing.Color.Red
        Me.lblGroupSize.Location = New System.Drawing.Point(224, 374)
        Me.lblGroupSize.Name = "lblGroupSize"
        Me.lblGroupSize.Size = New System.Drawing.Size(176, 32)
        Me.lblGroupSize.TabIndex = 2
        Me.lblGroupSize.Text = "Group Size:"
        '
        'txtSizeentry
        '
        Me.txtSizeentry.ForeColor = System.Drawing.Color.Red
        Me.txtSizeentry.Location = New System.Drawing.Point(480, 381)
        Me.txtSizeentry.Name = "txtSizeentry"
        Me.txtSizeentry.Size = New System.Drawing.Size(89, 26)
        Me.txtSizeentry.TabIndex = 3
        '
        'grpSelectBadgeType
        '
        Me.grpSelectBadgeType.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.grpSelectBadgeType.Controls.Add(Me.rdbtnConvention)
        Me.grpSelectBadgeType.Controls.Add(Me.rdbtnConventionAutographs)
        Me.grpSelectBadgeType.Controls.Add(Me.rdbtnConventionSuperhero)
        Me.grpSelectBadgeType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSelectBadgeType.ForeColor = System.Drawing.Color.Red
        Me.grpSelectBadgeType.Location = New System.Drawing.Point(113, 422)
        Me.grpSelectBadgeType.Name = "grpSelectBadgeType"
        Me.grpSelectBadgeType.Size = New System.Drawing.Size(603, 193)
        Me.grpSelectBadgeType.TabIndex = 4
        Me.grpSelectBadgeType.TabStop = False
        Me.grpSelectBadgeType.Text = "Select Badge Type:"
        '
        'rdbtnConvention
        '
        Me.rdbtnConvention.AutoSize = True
        Me.rdbtnConvention.Location = New System.Drawing.Point(33, 154)
        Me.rdbtnConvention.Name = "rdbtnConvention"
        Me.rdbtnConvention.Size = New System.Drawing.Size(169, 33)
        Me.rdbtnConvention.TabIndex = 2
        Me.rdbtnConvention.TabStop = True
        Me.rdbtnConvention.Text = "Convention"
        Me.rdbtnConvention.UseVisualStyleBackColor = True
        '
        'rdbtnConventionAutographs
        '
        Me.rdbtnConventionAutographs.AutoSize = True
        Me.rdbtnConventionAutographs.Location = New System.Drawing.Point(33, 102)
        Me.rdbtnConventionAutographs.Name = "rdbtnConventionAutographs"
        Me.rdbtnConventionAutographs.Size = New System.Drawing.Size(330, 33)
        Me.rdbtnConventionAutographs.TabIndex = 1
        Me.rdbtnConventionAutographs.TabStop = True
        Me.rdbtnConventionAutographs.Text = "Convention + Autographs"
        Me.rdbtnConventionAutographs.UseVisualStyleBackColor = True
        '
        'rdbtnConventionSuperhero
        '
        Me.rdbtnConventionSuperhero.AutoSize = True
        Me.rdbtnConventionSuperhero.Location = New System.Drawing.Point(33, 50)
        Me.rdbtnConventionSuperhero.Name = "rdbtnConventionSuperhero"
        Me.rdbtnConventionSuperhero.Size = New System.Drawing.Size(460, 33)
        Me.rdbtnConventionSuperhero.TabIndex = 0
        Me.rdbtnConventionSuperhero.TabStop = True
        Me.rdbtnConventionSuperhero.Text = "Convention + Superhero Experience"
        Me.rdbtnConventionSuperhero.UseVisualStyleBackColor = True
        '
        'lblRegistrationCost
        '
        Me.lblRegistrationCost.AutoSize = True
        Me.lblRegistrationCost.BackColor = System.Drawing.Color.Transparent
        Me.lblRegistrationCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistrationCost.ForeColor = System.Drawing.Color.Red
        Me.lblRegistrationCost.Location = New System.Drawing.Point(151, 658)
        Me.lblRegistrationCost.Name = "lblRegistrationCost"
        Me.lblRegistrationCost.Size = New System.Drawing.Size(259, 32)
        Me.lblRegistrationCost.TabIndex = 5
        Me.lblRegistrationCost.Text = "Registration Cost:"
        '
        'lblRegistrationPrice
        '
        Me.lblRegistrationPrice.AutoSize = True
        Me.lblRegistrationPrice.ForeColor = System.Drawing.Color.Red
        Me.lblRegistrationPrice.Location = New System.Drawing.Point(521, 664)
        Me.lblRegistrationPrice.Name = "lblRegistrationPrice"
        Me.lblRegistrationPrice.Size = New System.Drawing.Size(84, 20)
        Me.lblRegistrationPrice.TabIndex = 6
        Me.lblRegistrationPrice.Text = "$0000.00"
        Me.lblRegistrationPrice.Visible = False
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnCalculate.Font = New System.Drawing.Font("Franklin Gothic Heavy", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(179, 721)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(184, 57)
        Me.btnCalculate.TabIndex = 7
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnCleaar
        '
        Me.btnCleaar.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnCleaar.Font = New System.Drawing.Font("Franklin Gothic Heavy", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCleaar.Location = New System.Drawing.Point(546, 721)
        Me.btnCleaar.Name = "btnCleaar"
        Me.btnCleaar.Size = New System.Drawing.Size(184, 57)
        Me.btnCleaar.TabIndex = 8
        Me.btnCleaar.Text = "Clear"
        Me.btnCleaar.UseVisualStyleBackColor = False
        '
        'frmComicConventionRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1012, 799)
        Me.Controls.Add(Me.btnCleaar)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblRegistrationPrice)
        Me.Controls.Add(Me.lblRegistrationCost)
        Me.Controls.Add(Me.grpSelectBadgeType)
        Me.Controls.Add(Me.txtSizeentry)
        Me.Controls.Add(Me.lblGroupSize)
        Me.Controls.Add(Me.lblcomicconvention)
        Me.Controls.Add(Me.piccomic)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmComicConventionRegistration"
        Me.Text = "Comic Convention Registration"
        CType(Me.piccomic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSelectBadgeType.ResumeLayout(False)
        Me.grpSelectBadgeType.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents piccomic As PictureBox
    Friend WithEvents lblcomicconvention As Label
    Friend WithEvents lblGroupSize As Label
    Friend WithEvents txtSizeentry As TextBox
    Friend WithEvents grpSelectBadgeType As GroupBox
    Friend WithEvents rdbtnConvention As RadioButton
    Friend WithEvents rdbtnConventionAutographs As RadioButton
    Friend WithEvents rdbtnConventionSuperhero As RadioButton
    Friend WithEvents lblRegistrationCost As Label
    Friend WithEvents lblRegistrationPrice As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnCleaar As Button
End Class
