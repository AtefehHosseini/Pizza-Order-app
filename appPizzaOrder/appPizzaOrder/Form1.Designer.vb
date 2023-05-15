<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnOrder = New System.Windows.Forms.Button()
        Me.rbLarge = New System.Windows.Forms.RadioButton()
        Me.rbMed = New System.Windows.Forms.RadioButton()
        Me.rbSmall = New System.Windows.Forms.RadioButton()
        Me.chbExHam = New System.Windows.Forms.CheckBox()
        Me.chbExCheese = New System.Windows.Forms.CheckBox()
        Me.cbType = New System.Windows.Forms.ComboBox()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.lblShow = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.pbAti = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pbAti, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnOrder
        '
        Me.btnOrder.BackColor = System.Drawing.Color.DarkSalmon
        Me.btnOrder.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrder.Location = New System.Drawing.Point(319, 191)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(133, 56)
        Me.btnOrder.TabIndex = 16
        Me.btnOrder.Text = "Enter Order"
        Me.btnOrder.UseVisualStyleBackColor = False
        '
        'rbLarge
        '
        Me.rbLarge.AutoSize = True
        Me.rbLarge.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rbLarge.Location = New System.Drawing.Point(17, 60)
        Me.rbLarge.Name = "rbLarge"
        Me.rbLarge.Size = New System.Drawing.Size(61, 19)
        Me.rbLarge.TabIndex = 15
        Me.rbLarge.TabStop = True
        Me.rbLarge.Text = "Large"
        Me.rbLarge.UseVisualStyleBackColor = True
        '
        'rbMed
        '
        Me.rbMed.AutoSize = True
        Me.rbMed.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rbMed.Location = New System.Drawing.Point(17, 37)
        Me.rbMed.Name = "rbMed"
        Me.rbMed.Size = New System.Drawing.Size(78, 19)
        Me.rbMed.TabIndex = 14
        Me.rbMed.TabStop = True
        Me.rbMed.Text = "Medium"
        Me.rbMed.UseVisualStyleBackColor = True
        '
        'rbSmall
        '
        Me.rbSmall.AutoSize = True
        Me.rbSmall.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rbSmall.Location = New System.Drawing.Point(17, 14)
        Me.rbSmall.Name = "rbSmall"
        Me.rbSmall.Size = New System.Drawing.Size(60, 19)
        Me.rbSmall.TabIndex = 13
        Me.rbSmall.TabStop = True
        Me.rbSmall.Text = "Small"
        Me.rbSmall.UseVisualStyleBackColor = True
        '
        'chbExHam
        '
        Me.chbExHam.AutoSize = True
        Me.chbExHam.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chbExHam.Location = New System.Drawing.Point(6, 58)
        Me.chbExHam.Name = "chbExHam"
        Me.chbExHam.Size = New System.Drawing.Size(94, 19)
        Me.chbExHam.TabIndex = 12
        Me.chbExHam.Text = "Extra Ham"
        Me.chbExHam.UseVisualStyleBackColor = True
        '
        'chbExCheese
        '
        Me.chbExCheese.AutoSize = True
        Me.chbExCheese.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chbExCheese.Location = New System.Drawing.Point(6, 19)
        Me.chbExCheese.Name = "chbExCheese"
        Me.chbExCheese.Size = New System.Drawing.Size(116, 19)
        Me.chbExCheese.TabIndex = 11
        Me.chbExCheese.Text = "Extra Cheese"
        Me.chbExCheese.UseVisualStyleBackColor = True
        '
        'cbType
        '
        Me.cbType.BackColor = System.Drawing.Color.Linen
        Me.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbType.FormattingEnabled = True
        Me.cbType.Items.AddRange(New Object() {"Peperoni", "Mash and Ham", "Vegetarian", "Spacial"})
        Me.cbType.Location = New System.Drawing.Point(24, 33)
        Me.cbType.Name = "cbType"
        Me.cbType.Size = New System.Drawing.Size(168, 23)
        Me.cbType.TabIndex = 9
        '
        'lblResult
        '
        Me.lblResult.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblResult.Location = New System.Drawing.Point(512, 367)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(52, 28)
        Me.lblResult.TabIndex = 17
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Red
        Me.btnCancel.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(319, 251)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(133, 42)
        Me.btnCancel.TabIndex = 18
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(291, 367)
        Me.txtQuantity.Multiline = True
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(58, 32)
        Me.txtQuantity.TabIndex = 19
        '
        'lblShow
        '
        Me.lblShow.BackColor = System.Drawing.Color.NavajoWhite
        Me.lblShow.Location = New System.Drawing.Point(512, 119)
        Me.lblShow.Name = "lblShow"
        Me.lblShow.Size = New System.Drawing.Size(210, 224)
        Me.lblShow.TabIndex = 20
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Controls.Add(Me.cbType)
        Me.GroupBox1.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(12, 101)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(231, 79)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pizza Type"
        '
        'pbAti
        '
        Me.pbAti.BackColor = System.Drawing.Color.Transparent
        Me.pbAti.Image = CType(resources.GetObject("pbAti.Image"), System.Drawing.Image)
        Me.pbAti.Location = New System.Drawing.Point(12, 12)
        Me.pbAti.Name = "pbAti"
        Me.pbAti.Size = New System.Drawing.Size(588, 74)
        Me.pbAti.TabIndex = 22
        Me.pbAti.TabStop = False
        Me.pbAti.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Maroon
        Me.GroupBox2.Controls.Add(Me.chbExHam)
        Me.GroupBox2.Controls.Add(Me.chbExCheese)
        Me.GroupBox2.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox2.Location = New System.Drawing.Point(12, 307)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(156, 90)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Option"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Maroon
        Me.GroupBox3.Controls.Add(Me.rbLarge)
        Me.GroupBox3.Controls.Add(Me.rbMed)
        Me.GroupBox3.Controls.Add(Me.rbSmall)
        Me.GroupBox3.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox3.Location = New System.Drawing.Point(18, 191)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(132, 104)
        Me.GroupBox3.TabIndex = 24
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Pizza Size"
        '
        'lblQuantity
        '
        Me.lblQuantity.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantity.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblQuantity.Location = New System.Drawing.Point(188, 367)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(97, 30)
        Me.lblQuantity.TabIndex = 25
        Me.lblQuantity.Text = "Quantity"
        Me.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(447, 365)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 30)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Total"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.pbAti)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblShow)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.btnOrder)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.pbAti, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnOrder As Button
    Friend WithEvents rbLarge As RadioButton
    Friend WithEvents rbMed As RadioButton
    Friend WithEvents rbSmall As RadioButton
    Friend WithEvents chbExHam As CheckBox
    Friend WithEvents chbExCheese As CheckBox
    Friend WithEvents cbType As ComboBox
    Friend WithEvents lblResult As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents lblShow As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents pbAti As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lblQuantity As Label
    Friend WithEvents Label2 As Label
End Class
