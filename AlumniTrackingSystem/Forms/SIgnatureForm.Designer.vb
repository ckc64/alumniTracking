<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ThirdForm
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
        Me.Signature = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnAddorBrowse = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.txtpersonal_id = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Signature.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Signature
        '
        Me.Signature.Controls.Add(Me.PictureBox1)
        Me.Signature.Location = New System.Drawing.Point(56, 32)
        Me.Signature.Name = "Signature"
        Me.Signature.Size = New System.Drawing.Size(694, 310)
        Me.Signature.TabIndex = 0
        Me.Signature.TabStop = False
        Me.Signature.Text = "Signature"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Location = New System.Drawing.Point(36, 43)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(626, 243)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnAddorBrowse
        '
        Me.btnAddorBrowse.BackColor = System.Drawing.Color.Blue
        Me.btnAddorBrowse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddorBrowse.ForeColor = System.Drawing.Color.White
        Me.btnAddorBrowse.Location = New System.Drawing.Point(413, 358)
        Me.btnAddorBrowse.Name = "btnAddorBrowse"
        Me.btnAddorBrowse.Size = New System.Drawing.Size(123, 47)
        Me.btnAddorBrowse.TabIndex = 1
        Me.btnAddorBrowse.Text = "Add or Browse"
        Me.btnAddorBrowse.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.OrangeRed
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(155, 358)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(123, 47)
        Me.btnBack.TabIndex = 2
        Me.btnBack.Text = "<< Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'txtpersonal_id
        '
        Me.txtpersonal_id.AutoSize = True
        Me.txtpersonal_id.Location = New System.Drawing.Point(53, 375)
        Me.txtpersonal_id.Name = "txtpersonal_id"
        Me.txtpersonal_id.Size = New System.Drawing.Size(61, 13)
        Me.txtpersonal_id.TabIndex = 29
        Me.txtpersonal_id.Text = "personal_id"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Blue
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(542, 358)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(123, 47)
        Me.btnSave.TabIndex = 30
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog2"
        '
        'SaveFileDialog1
        '
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.OrangeRed
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(284, 358)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(123, 47)
        Me.btnClear.TabIndex = 31
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'ThirdForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 431)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtpersonal_id)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnAddorBrowse)
        Me.Controls.Add(Me.Signature)
        Me.MaximizeBox = False
        Me.Name = "ThirdForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Signature"
        Me.Signature.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Signature As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnAddorBrowse As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents txtpersonal_id As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents btnClear As Button
End Class
