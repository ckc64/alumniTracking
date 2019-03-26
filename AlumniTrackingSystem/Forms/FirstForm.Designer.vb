<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FirstForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FirstForm))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBoxStatus = New System.Windows.Forms.GroupBox()
        Me.rBtnSeparated = New System.Windows.Forms.RadioButton()
        Me.rBtnMarried = New System.Windows.Forms.RadioButton()
        Me.rBtnWidower = New System.Windows.Forms.RadioButton()
        Me.rBtnSingle = New System.Windows.Forms.RadioButton()
        Me.GroupBoxGender = New System.Windows.Forms.GroupBox()
        Me.rBtnMale = New System.Windows.Forms.RadioButton()
        Me.rBtnFemale = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtpersonal_id = New System.Windows.Forms.Label()
        Me.txtMiddleName = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.rBtnTechnical = New System.Windows.Forms.RadioButton()
        Me.rBtnPostDoctorate = New System.Windows.Forms.RadioButton()
        Me.rBtnDoctorate = New System.Windows.Forms.RadioButton()
        Me.rBtnBacca = New System.Windows.Forms.RadioButton()
        Me.rBtnMasters = New System.Windows.Forms.RadioButton()
        Me.dtpBatch = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCourse = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.typeOfBusCheckedListBox = New System.Windows.Forms.CheckedListBox()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.rBtnNonGIntl = New System.Windows.Forms.RadioButton()
        Me.rBtnNonGNatl = New System.Windows.Forms.RadioButton()
        Me.rBtnNonGLocal = New System.Windows.Forms.RadioButton()
        Me.rBtnMOrganization = New System.Windows.Forms.RadioButton()
        Me.rBtnPOrganization = New System.Windows.Forms.RadioButton()
        Me.rBtnPublicGovernment = New System.Windows.Forms.RadioButton()
        Me.rBtnPrivNatl = New System.Windows.Forms.RadioButton()
        Me.rBtnPrivLocal = New System.Windows.Forms.RadioButton()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.txtBoxCurrJobDesig = New System.Windows.Forms.RichTextBox()
        Me.txtBoxJobDes = New System.Windows.Forms.RichTextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.rBtnEmployedContractual = New System.Windows.Forms.RadioButton()
        Me.rBtnEmployedFulltime = New System.Windows.Forms.RadioButton()
        Me.rBtnSelfEmployed = New System.Windows.Forms.RadioButton()
        Me.rBtnEmployedPartTime = New System.Windows.Forms.RadioButton()
        Me.rBtnUnEmployed = New System.Windows.Forms.RadioButton()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.txtBoxCompanyEmployer = New System.Windows.Forms.RichTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtBoxCurrCompany = New System.Windows.Forms.RichTextBox()
        Me.dtpDateOfEmp = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBoxStatus.SuspendLayout()
        Me.GroupBoxGender.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        CType(Me.btnSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.GroupBoxStatus)
        Me.GroupBox1.Controls.Add(Me.GroupBoxGender)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 66)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(340, 277)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Personal Information"
        '
        'GroupBoxStatus
        '
        Me.GroupBoxStatus.Controls.Add(Me.rBtnSeparated)
        Me.GroupBoxStatus.Controls.Add(Me.rBtnMarried)
        Me.GroupBoxStatus.Controls.Add(Me.rBtnWidower)
        Me.GroupBoxStatus.Controls.Add(Me.rBtnSingle)
        Me.GroupBoxStatus.Location = New System.Drawing.Point(135, 164)
        Me.GroupBoxStatus.Name = "GroupBoxStatus"
        Me.GroupBoxStatus.Size = New System.Drawing.Size(189, 94)
        Me.GroupBoxStatus.TabIndex = 7
        Me.GroupBoxStatus.TabStop = False
        Me.GroupBoxStatus.Text = "Civil Status"
        '
        'rBtnSeparated
        '
        Me.rBtnSeparated.AutoSize = True
        Me.rBtnSeparated.Location = New System.Drawing.Point(77, 52)
        Me.rBtnSeparated.Name = "rBtnSeparated"
        Me.rBtnSeparated.Size = New System.Drawing.Size(74, 17)
        Me.rBtnSeparated.TabIndex = 4
        Me.rBtnSeparated.TabStop = True
        Me.rBtnSeparated.Text = "Separated"
        Me.rBtnSeparated.UseVisualStyleBackColor = True
        '
        'rBtnMarried
        '
        Me.rBtnMarried.AutoSize = True
        Me.rBtnMarried.Location = New System.Drawing.Point(77, 29)
        Me.rBtnMarried.Name = "rBtnMarried"
        Me.rBtnMarried.Size = New System.Drawing.Size(60, 17)
        Me.rBtnMarried.TabIndex = 3
        Me.rBtnMarried.TabStop = True
        Me.rBtnMarried.Text = "Married"
        Me.rBtnMarried.UseVisualStyleBackColor = True
        '
        'rBtnWidower
        '
        Me.rBtnWidower.AutoSize = True
        Me.rBtnWidower.Location = New System.Drawing.Point(6, 52)
        Me.rBtnWidower.Name = "rBtnWidower"
        Me.rBtnWidower.Size = New System.Drawing.Size(67, 17)
        Me.rBtnWidower.TabIndex = 2
        Me.rBtnWidower.TabStop = True
        Me.rBtnWidower.Text = "Widower"
        Me.rBtnWidower.UseVisualStyleBackColor = True
        '
        'rBtnSingle
        '
        Me.rBtnSingle.AutoSize = True
        Me.rBtnSingle.Location = New System.Drawing.Point(6, 29)
        Me.rBtnSingle.Name = "rBtnSingle"
        Me.rBtnSingle.Size = New System.Drawing.Size(54, 17)
        Me.rBtnSingle.TabIndex = 1
        Me.rBtnSingle.TabStop = True
        Me.rBtnSingle.Text = "Single"
        Me.rBtnSingle.UseVisualStyleBackColor = True
        '
        'GroupBoxGender
        '
        Me.GroupBoxGender.Controls.Add(Me.rBtnMale)
        Me.GroupBoxGender.Controls.Add(Me.rBtnFemale)
        Me.GroupBoxGender.Location = New System.Drawing.Point(6, 164)
        Me.GroupBoxGender.Name = "GroupBoxGender"
        Me.GroupBoxGender.Size = New System.Drawing.Size(123, 94)
        Me.GroupBoxGender.TabIndex = 6
        Me.GroupBoxGender.TabStop = False
        Me.GroupBoxGender.Text = "Gender"
        '
        'rBtnMale
        '
        Me.rBtnMale.AutoSize = True
        Me.rBtnMale.Location = New System.Drawing.Point(20, 52)
        Me.rBtnMale.Name = "rBtnMale"
        Me.rBtnMale.Size = New System.Drawing.Size(48, 17)
        Me.rBtnMale.TabIndex = 1
        Me.rBtnMale.Text = "Male"
        Me.rBtnMale.UseVisualStyleBackColor = True
        '
        'rBtnFemale
        '
        Me.rBtnFemale.AutoSize = True
        Me.rBtnFemale.Location = New System.Drawing.Point(20, 29)
        Me.rBtnFemale.Name = "rBtnFemale"
        Me.rBtnFemale.Size = New System.Drawing.Size(59, 17)
        Me.rBtnFemale.TabIndex = 0
        Me.rBtnFemale.Text = "Female"
        Me.rBtnFemale.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.txtpersonal_id)
        Me.GroupBox2.Controls.Add(Me.txtMiddleName)
        Me.GroupBox2.Controls.Add(Me.txtFirstName)
        Me.GroupBox2.Controls.Add(Me.txtSurname)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 20)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(318, 138)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Full Name"
        '
        'txtpersonal_id
        '
        Me.txtpersonal_id.AutoSize = True
        Me.txtpersonal_id.Location = New System.Drawing.Point(34, 43)
        Me.txtpersonal_id.Name = "txtpersonal_id"
        Me.txtpersonal_id.Size = New System.Drawing.Size(0, 13)
        Me.txtpersonal_id.TabIndex = 6
        '
        'txtMiddleName
        '
        Me.txtMiddleName.Location = New System.Drawing.Point(114, 99)
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.Size = New System.Drawing.Size(198, 20)
        Me.txtMiddleName.TabIndex = 5
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(114, 63)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(198, 20)
        Me.txtFirstName.TabIndex = 4
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(114, 25)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(198, 20)
        Me.txtSurname.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 18)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Middlename :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 18)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Firstname     :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Surname       :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.White
        Me.GroupBox4.Controls.Add(Me.GroupBox5)
        Me.GroupBox4.Controls.Add(Me.dtpBatch)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.txtCourse)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Location = New System.Drawing.Point(24, 349)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(340, 205)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Educational Background"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.rBtnTechnical)
        Me.GroupBox5.Controls.Add(Me.rBtnPostDoctorate)
        Me.GroupBox5.Controls.Add(Me.rBtnDoctorate)
        Me.GroupBox5.Controls.Add(Me.rBtnBacca)
        Me.GroupBox5.Controls.Add(Me.rBtnMasters)
        Me.GroupBox5.Location = New System.Drawing.Point(15, 119)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(309, 78)
        Me.GroupBox5.TabIndex = 8
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Highest Degree Earned in the University of Mindanao"
        '
        'rBtnTechnical
        '
        Me.rBtnTechnical.AutoSize = True
        Me.rBtnTechnical.Location = New System.Drawing.Point(201, 27)
        Me.rBtnTechnical.Name = "rBtnTechnical"
        Me.rBtnTechnical.Size = New System.Drawing.Size(72, 17)
        Me.rBtnTechnical.TabIndex = 9
        Me.rBtnTechnical.TabStop = True
        Me.rBtnTechnical.Text = "Technical"
        Me.rBtnTechnical.UseVisualStyleBackColor = True
        '
        'rBtnPostDoctorate
        '
        Me.rBtnPostDoctorate.AutoSize = True
        Me.rBtnPostDoctorate.Location = New System.Drawing.Point(107, 50)
        Me.rBtnPostDoctorate.Name = "rBtnPostDoctorate"
        Me.rBtnPostDoctorate.Size = New System.Drawing.Size(96, 17)
        Me.rBtnPostDoctorate.TabIndex = 8
        Me.rBtnPostDoctorate.TabStop = True
        Me.rBtnPostDoctorate.Text = "Post-Doctorate"
        Me.rBtnPostDoctorate.UseVisualStyleBackColor = True
        '
        'rBtnDoctorate
        '
        Me.rBtnDoctorate.AutoSize = True
        Me.rBtnDoctorate.Location = New System.Drawing.Point(107, 27)
        Me.rBtnDoctorate.Name = "rBtnDoctorate"
        Me.rBtnDoctorate.Size = New System.Drawing.Size(72, 17)
        Me.rBtnDoctorate.TabIndex = 7
        Me.rBtnDoctorate.TabStop = True
        Me.rBtnDoctorate.Text = "Doctorate"
        Me.rBtnDoctorate.UseVisualStyleBackColor = True
        '
        'rBtnBacca
        '
        Me.rBtnBacca.AutoSize = True
        Me.rBtnBacca.Location = New System.Drawing.Point(7, 27)
        Me.rBtnBacca.Name = "rBtnBacca"
        Me.rBtnBacca.Size = New System.Drawing.Size(94, 17)
        Me.rBtnBacca.TabIndex = 5
        Me.rBtnBacca.TabStop = True
        Me.rBtnBacca.Text = "Baccalaureate"
        Me.rBtnBacca.UseVisualStyleBackColor = True
        '
        'rBtnMasters
        '
        Me.rBtnMasters.AutoSize = True
        Me.rBtnMasters.Location = New System.Drawing.Point(7, 50)
        Me.rBtnMasters.Name = "rBtnMasters"
        Me.rBtnMasters.Size = New System.Drawing.Size(62, 17)
        Me.rBtnMasters.TabIndex = 6
        Me.rBtnMasters.TabStop = True
        Me.rBtnMasters.Text = "Masters"
        Me.rBtnMasters.UseVisualStyleBackColor = True
        '
        'dtpBatch
        '
        Me.dtpBatch.CustomFormat = "MM/DD/YY"
        Me.dtpBatch.Location = New System.Drawing.Point(129, 74)
        Me.dtpBatch.Name = "dtpBatch"
        Me.dtpBatch.Size = New System.Drawing.Size(195, 20)
        Me.dtpBatch.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 75)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 18)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Batch               :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 18)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Course/Major :"
        '
        'txtCourse
        '
        Me.txtCourse.Location = New System.Drawing.Point(129, 33)
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.Size = New System.Drawing.Size(195, 20)
        Me.txtCourse.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 13)
        Me.Label8.TabIndex = 0
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.White
        Me.GroupBox6.Controls.Add(Me.GroupBox10)
        Me.GroupBox6.Controls.Add(Me.GroupBox11)
        Me.GroupBox6.Controls.Add(Me.GroupBox7)
        Me.GroupBox6.Controls.Add(Me.GroupBox9)
        Me.GroupBox6.Controls.Add(Me.Label11)
        Me.GroupBox6.Location = New System.Drawing.Point(377, 5)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(970, 480)
        Me.GroupBox6.TabIndex = 8
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Employment Background"
        '
        'GroupBox10
        '
        Me.GroupBox10.BackColor = System.Drawing.Color.White
        Me.GroupBox10.Controls.Add(Me.typeOfBusCheckedListBox)
        Me.GroupBox10.Location = New System.Drawing.Point(13, 283)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(520, 180)
        Me.GroupBox10.TabIndex = 15
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Type Of Business/Company/Establishment"
        '
        'typeOfBusCheckedListBox
        '
        Me.typeOfBusCheckedListBox.FormattingEnabled = True
        Me.typeOfBusCheckedListBox.HorizontalScrollbar = True
        Me.typeOfBusCheckedListBox.Items.AddRange(New Object() {"Agriculture, Fishing, Hunting & Forestry", "Mining & Quarrying", "Manufacturing", "Electricity, Gas & Water Supply", "Construction", "Hotel & Restaurant", "Transportation & Logistics", "Financial Intermediation", "Real Estate, Renting & Business Activities", "Education", "Health & Social Work", "Public Administration and Defense;Compulsory Social Security", "Private Households with Employed Persons", "Extra-Territorial Organization and Bodies", "Wholesale & Retail Trade: Repair of Motor Vehicles, Motorcycles & Personal Househ" &
                "old Goods", "Other Community, Social & Personal Service Activities"})
        Me.typeOfBusCheckedListBox.Location = New System.Drawing.Point(6, 19)
        Me.typeOfBusCheckedListBox.Name = "typeOfBusCheckedListBox"
        Me.typeOfBusCheckedListBox.Size = New System.Drawing.Size(503, 154)
        Me.typeOfBusCheckedListBox.TabIndex = 0
        '
        'GroupBox11
        '
        Me.GroupBox11.BackColor = System.Drawing.Color.White
        Me.GroupBox11.Controls.Add(Me.rBtnNonGIntl)
        Me.GroupBox11.Controls.Add(Me.rBtnNonGNatl)
        Me.GroupBox11.Controls.Add(Me.rBtnNonGLocal)
        Me.GroupBox11.Controls.Add(Me.rBtnMOrganization)
        Me.GroupBox11.Controls.Add(Me.rBtnPOrganization)
        Me.GroupBox11.Controls.Add(Me.rBtnPublicGovernment)
        Me.GroupBox11.Controls.Add(Me.rBtnPrivNatl)
        Me.GroupBox11.Controls.Add(Me.rBtnPrivLocal)
        Me.GroupBox11.Location = New System.Drawing.Point(539, 283)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(423, 180)
        Me.GroupBox11.TabIndex = 14
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Nature Of Business/Company/Organization"
        '
        'rBtnNonGIntl
        '
        Me.rBtnNonGIntl.AutoSize = True
        Me.rBtnNonGIntl.Location = New System.Drawing.Point(217, 101)
        Me.rBtnNonGIntl.Name = "rBtnNonGIntl"
        Me.rBtnNonGIntl.Size = New System.Drawing.Size(173, 17)
        Me.rBtnNonGIntl.TabIndex = 7
        Me.rBtnNonGIntl.TabStop = True
        Me.rBtnNonGIntl.Text = "Non-Government - International"
        Me.rBtnNonGIntl.UseVisualStyleBackColor = True
        '
        'rBtnNonGNatl
        '
        Me.rBtnNonGNatl.AutoSize = True
        Me.rBtnNonGNatl.Location = New System.Drawing.Point(217, 78)
        Me.rBtnNonGNatl.Name = "rBtnNonGNatl"
        Me.rBtnNonGNatl.Size = New System.Drawing.Size(154, 17)
        Me.rBtnNonGNatl.TabIndex = 6
        Me.rBtnNonGNatl.TabStop = True
        Me.rBtnNonGNatl.Text = "Non-Government - National"
        Me.rBtnNonGNatl.UseVisualStyleBackColor = True
        '
        'rBtnNonGLocal
        '
        Me.rBtnNonGLocal.AutoSize = True
        Me.rBtnNonGLocal.Location = New System.Drawing.Point(217, 55)
        Me.rBtnNonGLocal.Name = "rBtnNonGLocal"
        Me.rBtnNonGLocal.Size = New System.Drawing.Size(141, 17)
        Me.rBtnNonGLocal.TabIndex = 5
        Me.rBtnNonGLocal.TabStop = True
        Me.rBtnNonGLocal.Text = "Non-Government - Local"
        Me.rBtnNonGLocal.UseVisualStyleBackColor = True
        '
        'rBtnMOrganization
        '
        Me.rBtnMOrganization.AutoSize = True
        Me.rBtnMOrganization.Location = New System.Drawing.Point(217, 32)
        Me.rBtnMOrganization.Name = "rBtnMOrganization"
        Me.rBtnMOrganization.Size = New System.Drawing.Size(146, 17)
        Me.rBtnMOrganization.TabIndex = 4
        Me.rBtnMOrganization.TabStop = True
        Me.rBtnMOrganization.Text = "Multinational Organization"
        Me.rBtnMOrganization.UseVisualStyleBackColor = True
        '
        'rBtnPOrganization
        '
        Me.rBtnPOrganization.AutoSize = True
        Me.rBtnPOrganization.Location = New System.Drawing.Point(24, 101)
        Me.rBtnPOrganization.Name = "rBtnPOrganization"
        Me.rBtnPOrganization.Size = New System.Drawing.Size(127, 17)
        Me.rBtnPOrganization.TabIndex = 3
        Me.rBtnPOrganization.TabStop = True
        Me.rBtnPOrganization.Text = "People's Organization"
        Me.rBtnPOrganization.UseVisualStyleBackColor = True
        '
        'rBtnPublicGovernment
        '
        Me.rBtnPublicGovernment.AutoSize = True
        Me.rBtnPublicGovernment.Location = New System.Drawing.Point(24, 78)
        Me.rBtnPublicGovernment.Name = "rBtnPublicGovernment"
        Me.rBtnPublicGovernment.Size = New System.Drawing.Size(123, 17)
        Me.rBtnPublicGovernment.TabIndex = 2
        Me.rBtnPublicGovernment.TabStop = True
        Me.rBtnPublicGovernment.Text = "Public / Government"
        Me.rBtnPublicGovernment.UseVisualStyleBackColor = True
        '
        'rBtnPrivNatl
        '
        Me.rBtnPrivNatl.AutoSize = True
        Me.rBtnPrivNatl.Location = New System.Drawing.Point(24, 55)
        Me.rBtnPrivNatl.Name = "rBtnPrivNatl"
        Me.rBtnPrivNatl.Size = New System.Drawing.Size(106, 17)
        Me.rBtnPrivNatl.TabIndex = 1
        Me.rBtnPrivNatl.TabStop = True
        Me.rBtnPrivNatl.Text = "Private - National"
        Me.rBtnPrivNatl.UseVisualStyleBackColor = True
        '
        'rBtnPrivLocal
        '
        Me.rBtnPrivLocal.AutoSize = True
        Me.rBtnPrivLocal.Location = New System.Drawing.Point(24, 32)
        Me.rBtnPrivLocal.Name = "rBtnPrivLocal"
        Me.rBtnPrivLocal.Size = New System.Drawing.Size(93, 17)
        Me.rBtnPrivLocal.TabIndex = 0
        Me.rBtnPrivLocal.TabStop = True
        Me.rBtnPrivLocal.Text = "Private - Local"
        Me.rBtnPrivLocal.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.txtBoxCurrJobDesig)
        Me.GroupBox7.Controls.Add(Me.txtBoxJobDes)
        Me.GroupBox7.Controls.Add(Me.Label13)
        Me.GroupBox7.Controls.Add(Me.GroupBox8)
        Me.GroupBox7.Controls.Add(Me.Label12)
        Me.GroupBox7.Location = New System.Drawing.Point(13, 149)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(949, 128)
        Me.GroupBox7.TabIndex = 13
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Current Employment Information"
        '
        'txtBoxCurrJobDesig
        '
        Me.txtBoxCurrJobDesig.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxCurrJobDesig.Location = New System.Drawing.Point(287, 84)
        Me.txtBoxCurrJobDesig.Name = "txtBoxCurrJobDesig"
        Me.txtBoxCurrJobDesig.Size = New System.Drawing.Size(641, 25)
        Me.txtBoxCurrJobDesig.TabIndex = 17
        Me.txtBoxCurrJobDesig.Text = ""
        '
        'txtBoxJobDes
        '
        Me.txtBoxJobDes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxJobDes.Location = New System.Drawing.Point(287, 35)
        Me.txtBoxJobDes.Name = "txtBoxJobDes"
        Me.txtBoxJobDes.Size = New System.Drawing.Size(641, 25)
        Me.txtBoxJobDes.TabIndex = 15
        Me.txtBoxJobDes.Text = ""
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label13.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(284, 15)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(331, 18)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Current Company/Establishment/Organization"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.rBtnEmployedContractual)
        Me.GroupBox8.Controls.Add(Me.rBtnEmployedFulltime)
        Me.GroupBox8.Controls.Add(Me.rBtnSelfEmployed)
        Me.GroupBox8.Controls.Add(Me.rBtnEmployedPartTime)
        Me.GroupBox8.Controls.Add(Me.rBtnUnEmployed)
        Me.GroupBox8.Location = New System.Drawing.Point(15, 19)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(257, 97)
        Me.GroupBox8.TabIndex = 9
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Current Employment Status"
        '
        'rBtnEmployedContractual
        '
        Me.rBtnEmployedContractual.AutoSize = True
        Me.rBtnEmployedContractual.Location = New System.Drawing.Point(11, 73)
        Me.rBtnEmployedContractual.Name = "rBtnEmployedContractual"
        Me.rBtnEmployedContractual.Size = New System.Drawing.Size(134, 17)
        Me.rBtnEmployedContractual.TabIndex = 14
        Me.rBtnEmployedContractual.TabStop = True
        Me.rBtnEmployedContractual.Text = "Employed - Contractual"
        Me.rBtnEmployedContractual.UseVisualStyleBackColor = True
        '
        'rBtnEmployedFulltime
        '
        Me.rBtnEmployedFulltime.AutoSize = True
        Me.rBtnEmployedFulltime.Location = New System.Drawing.Point(129, 50)
        Me.rBtnEmployedFulltime.Name = "rBtnEmployedFulltime"
        Me.rBtnEmployedFulltime.Size = New System.Drawing.Size(122, 17)
        Me.rBtnEmployedFulltime.TabIndex = 13
        Me.rBtnEmployedFulltime.TabStop = True
        Me.rBtnEmployedFulltime.Text = "Employed - Full Time"
        Me.rBtnEmployedFulltime.UseVisualStyleBackColor = True
        '
        'rBtnSelfEmployed
        '
        Me.rBtnSelfEmployed.AutoSize = True
        Me.rBtnSelfEmployed.Location = New System.Drawing.Point(11, 48)
        Me.rBtnSelfEmployed.Name = "rBtnSelfEmployed"
        Me.rBtnSelfEmployed.Size = New System.Drawing.Size(92, 17)
        Me.rBtnSelfEmployed.TabIndex = 11
        Me.rBtnSelfEmployed.TabStop = True
        Me.rBtnSelfEmployed.Text = "Self-Employed"
        Me.rBtnSelfEmployed.UseVisualStyleBackColor = True
        '
        'rBtnEmployedPartTime
        '
        Me.rBtnEmployedPartTime.AutoSize = True
        Me.rBtnEmployedPartTime.Location = New System.Drawing.Point(129, 27)
        Me.rBtnEmployedPartTime.Name = "rBtnEmployedPartTime"
        Me.rBtnEmployedPartTime.Size = New System.Drawing.Size(125, 17)
        Me.rBtnEmployedPartTime.TabIndex = 12
        Me.rBtnEmployedPartTime.TabStop = True
        Me.rBtnEmployedPartTime.Text = "Employed - Part Time"
        Me.rBtnEmployedPartTime.UseVisualStyleBackColor = True
        '
        'rBtnUnEmployed
        '
        Me.rBtnUnEmployed.AutoSize = True
        Me.rBtnUnEmployed.Location = New System.Drawing.Point(11, 25)
        Me.rBtnUnEmployed.Name = "rBtnUnEmployed"
        Me.rBtnUnEmployed.Size = New System.Drawing.Size(84, 17)
        Me.rBtnUnEmployed.TabIndex = 10
        Me.rBtnUnEmployed.TabStop = True
        Me.rBtnUnEmployed.Text = "Unemployed"
        Me.rBtnUnEmployed.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label12.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(284, 63)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(123, 18)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Job Designation"
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.txtBoxCompanyEmployer)
        Me.GroupBox9.Controls.Add(Me.Label7)
        Me.GroupBox9.Controls.Add(Me.txtBoxCurrCompany)
        Me.GroupBox9.Controls.Add(Me.dtpDateOfEmp)
        Me.GroupBox9.Controls.Add(Me.Label9)
        Me.GroupBox9.Controls.Add(Me.Label10)
        Me.GroupBox9.Location = New System.Drawing.Point(13, 23)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(949, 120)
        Me.GroupBox9.TabIndex = 1
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "1st Employment Information"
        '
        'txtBoxCompanyEmployer
        '
        Me.txtBoxCompanyEmployer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxCompanyEmployer.Location = New System.Drawing.Point(219, 87)
        Me.txtBoxCompanyEmployer.Name = "txtBoxCompanyEmployer"
        Me.txtBoxCompanyEmployer.Size = New System.Drawing.Size(641, 25)
        Me.txtBoxCompanyEmployer.TabIndex = 12
        Me.txtBoxCompanyEmployer.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(219, 68)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(320, 18)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Company/Employer On Your 1st Employment"
        '
        'txtBoxCurrCompany
        '
        Me.txtBoxCurrCompany.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxCurrCompany.Location = New System.Drawing.Point(219, 38)
        Me.txtBoxCurrCompany.Name = "txtBoxCurrCompany"
        Me.txtBoxCurrCompany.Size = New System.Drawing.Size(641, 25)
        Me.txtBoxCurrCompany.TabIndex = 10
        Me.txtBoxCurrCompany.Text = ""
        '
        'dtpDateOfEmp
        '
        Me.dtpDateOfEmp.CustomFormat = "MM/DD/YY"
        Me.dtpDateOfEmp.Location = New System.Drawing.Point(15, 46)
        Me.dtpDateOfEmp.Name = "dtpDateOfEmp"
        Me.dtpDateOfEmp.Size = New System.Drawing.Size(185, 20)
        Me.dtpDateOfEmp.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label9.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(216, 15)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(295, 18)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Job Designation on your 1st Employment"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label10.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 25)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(164, 18)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Date Of Employment  :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(7, 20)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(0, 13)
        Me.Label11.TabIndex = 0
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Green
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(704, 497)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(200, 50)
        Me.btnSave.TabIndex = 20
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.Indigo
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(924, 497)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(200, 50)
        Me.btnUpdate.TabIndex = 19
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.OrangeRed
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(1147, 496)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(200, 50)
        Me.btnClear.TabIndex = 18
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(24, 22)
        Me.txtSearch.Multiline = True
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(288, 30)
        Me.txtSearch.TabIndex = 21
        Me.txtSearch.Text = "Search....."
        '
        'btnSearch
        '
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Location = New System.Drawing.Point(312, 22)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(50, 30)
        Me.btnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnSearch.TabIndex = 22
        Me.btnSearch.TabStop = False
        '
        'FirstForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1366, 570)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "FirstForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Personal and Employment Information"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBoxStatus.ResumeLayout(False)
        Me.GroupBoxStatus.PerformLayout()
        Me.GroupBoxGender.ResumeLayout(False)
        Me.GroupBoxGender.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        CType(Me.btnSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents txtMiddleName As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents GroupBoxStatus As GroupBox
    Friend WithEvents GroupBoxGender As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents dtpBatch As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCourse As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents txtBoxCurrCompany As RichTextBox
    Friend WithEvents txtBoxCompanyEmployer As RichTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents dtpDateOfEmp As DateTimePicker
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents rBtnMale As RadioButton
    Friend WithEvents rBtnFemale As RadioButton
    Friend WithEvents rBtnSeparated As RadioButton
    Friend WithEvents rBtnMarried As RadioButton
    Friend WithEvents rBtnWidower As RadioButton
    Friend WithEvents rBtnSingle As RadioButton
    Friend WithEvents rBtnTechnical As RadioButton
    Friend WithEvents rBtnPostDoctorate As RadioButton
    Friend WithEvents rBtnDoctorate As RadioButton
    Friend WithEvents rBtnBacca As RadioButton
    Friend WithEvents rBtnMasters As RadioButton
    Friend WithEvents rBtnEmployedContractual As RadioButton
    Friend WithEvents rBtnEmployedFulltime As RadioButton
    Friend WithEvents rBtnSelfEmployed As RadioButton
    Friend WithEvents rBtnEmployedPartTime As RadioButton
    Friend WithEvents rBtnUnEmployed As RadioButton
    Friend WithEvents txtpersonal_id As Label
    Friend WithEvents txtBoxCurrJobDesig As RichTextBox
    Friend WithEvents txtBoxJobDes As RichTextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents typeOfBusCheckedListBox As CheckedListBox
    Friend WithEvents GroupBox11 As GroupBox
    Friend WithEvents rBtnNonGIntl As RadioButton
    Friend WithEvents rBtnNonGNatl As RadioButton
    Friend WithEvents rBtnNonGLocal As RadioButton
    Friend WithEvents rBtnMOrganization As RadioButton
    Friend WithEvents rBtnPOrganization As RadioButton
    Friend WithEvents rBtnPublicGovernment As RadioButton
    Friend WithEvents rBtnPrivNatl As RadioButton
    Friend WithEvents rBtnPrivLocal As RadioButton
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As PictureBox
End Class
