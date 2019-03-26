Imports MySql.Data.MySqlClient


Public Class FirstForm

    Public alumni_id As Integer
    Dim gender As String
    Dim civilstatus As String
    Dim highestdegreeInUM As String
    Dim currentemployedstatus As String
    Dim natureBCO As String
    Dim dr As MySqlDataReader
    Dim dr1 As MySqlDataReader
    Dim Sql1 As String
    Dim str As String




    Private Sub FirstForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '''''''''''connection'''''''''''''''''''''
        If fncConnectToDatabase() = True Then
        Else
            conReg.Close()
        End If
        ''''''''''''''''''''''''''''''''''''''''''

        ''''''''''''Generate Alumni ID''''''''''''''
        generate_Alumni_ID()

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs)

        Dim secondForm As New SecondForm
        'secondForm.alumni_id = txtpersonal_id.Text
        secondForm.Show()
        Me.Hide()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs)
        MsgBox("No Function!")

    End Sub

    Private Sub rBtnFemale_CheckedChanged(sender As Object, e As EventArgs) Handles rBtnFemale.CheckedChanged
        gender = "Female"
    End Sub

    Private Sub rBtnMale_CheckedChanged(sender As Object, e As EventArgs) Handles rBtnMale.CheckedChanged
        gender = "Male"
    End Sub

    Private Sub rBtnSingle_CheckedChanged(sender As Object, e As EventArgs) Handles rBtnSingle.CheckedChanged
        civilstatus = "Single"
    End Sub

    Private Sub rBtnMarried_CheckedChanged(sender As Object, e As EventArgs) Handles rBtnMarried.CheckedChanged
        civilstatus = "Married"
    End Sub

    Private Sub rBtnWidower_CheckedChanged(sender As Object, e As EventArgs) Handles rBtnWidower.CheckedChanged
        civilstatus = "Widower"
    End Sub

    Private Sub rBtnSeparated_CheckedChanged(sender As Object, e As EventArgs) Handles rBtnSeparated.CheckedChanged
        civilstatus = "Separated"
    End Sub

    Private Sub rBtnBacca_CheckedChanged(sender As Object, e As EventArgs) Handles rBtnBacca.CheckedChanged
        highestdegreeInUM = "Baccalaureate"
    End Sub

    Private Sub rBtnMasters_CheckedChanged(sender As Object, e As EventArgs) Handles rBtnMasters.CheckedChanged
        highestdegreeInUM = "Masters"
    End Sub

    Private Sub rBtnDoctorate_CheckedChanged(sender As Object, e As EventArgs) Handles rBtnDoctorate.CheckedChanged
        highestdegreeInUM = "Doctorate"
    End Sub

    Private Sub rBtnPostDoctorate_CheckedChanged(sender As Object, e As EventArgs) Handles rBtnPostDoctorate.CheckedChanged
        highestdegreeInUM = "Post-Doctorate"
    End Sub

    Private Sub rBtnTechnical_CheckedChanged(sender As Object, e As EventArgs) Handles rBtnTechnical.CheckedChanged
        highestdegreeInUM = "Technical"
    End Sub

    Private Sub rBtnUnEmployed_CheckedChanged(sender As Object, e As EventArgs) Handles rBtnUnEmployed.CheckedChanged
        currentemployedstatus = "Unemployed"
    End Sub

    Private Sub rBtnSelfEmployed_CheckedChanged(sender As Object, e As EventArgs) Handles rBtnSelfEmployed.CheckedChanged
        currentemployedstatus = "Self-Employed"
    End Sub

    Private Sub rBtnEmployedPartTime_CheckedChanged(sender As Object, e As EventArgs) Handles rBtnEmployedPartTime.CheckedChanged
        currentemployedstatus = "Employed-Part-Time"
    End Sub

    Private Sub rBtnEmployedFulltime_CheckedChanged(sender As Object, e As EventArgs) Handles rBtnEmployedFulltime.CheckedChanged
        currentemployedstatus = "Employed-Full-Time"
    End Sub

    Private Sub rBtnEmployedContractual_CheckedChanged(sender As Object, e As EventArgs) Handles rBtnEmployedContractual.CheckedChanged
        currentemployedstatus = "Employed-Contructual"
    End Sub

    Private Sub rBtnPrivLocal_CheckedChanged(sender As Object, e As EventArgs)
        natureBCO = "Private - Local"
    End Sub

    Private Sub rBtnPrivNatl_CheckedChanged(sender As Object, e As EventArgs)
        natureBCO = "Private - National"
    End Sub

    Private Sub rBtnPublicGovernment_CheckedChanged(sender As Object, e As EventArgs)
        natureBCO = "Public - Government"
    End Sub

    Private Sub rBtnPOrganization_CheckedChanged(sender As Object, e As EventArgs)
        natureBCO = "People's Organization"
    End Sub

    Private Sub rBtnMOrganization_CheckedChanged(sender As Object, e As EventArgs)
        natureBCO = "Multinational Organization"
    End Sub

    Private Sub rBtnNonGLocal_CheckedChanged(sender As Object, e As EventArgs)
        natureBCO = "Non-Government - Local"
    End Sub

    Private Sub rBtnNonGNatl_CheckedChanged(sender As Object, e As EventArgs)
        natureBCO = "Non-Government - National"
    End Sub

    Private Sub rBtnNonGIntl_CheckedChanged(sender As Object, e As EventArgs)
        natureBCO = "Non-Government - International"
    End Sub

    ''' <summary>
    ''' .................................................................................................................
    ''' Functions.................................................................................................................
    ''' .................................................................................................................
    ''' </summary>
    Private Sub getCheckedTypeBCE()

        Try
            If fncConnectToDatabase() <> True Then
                fncConnectToDatabase()

            End If

            'command1.CommandText = "Select * From type_bce_tbl Where alumni_id='" & txtpersonal_id.Text & "'"
            'dr = command1.ExecuteReader

            'If dr.HasRows Then
            'MsgBox("Duplicate Entry Found!", MsgBoxStyle.Critical)
            'conReg.Close()

            'Else

            Dim sb As New System.Text.StringBuilder

                Dim itemsList As ArrayList = New ArrayList

                Sql1 = "Insert Into type_bce_tbl(alumni_id, type_BCE) values (@ALUMNI_ID1, @TYPE_BCE)"
                command1.CommandText = Sql1

                For Each item In typeOfBusCheckedListBox.CheckedItems

                    sb.Append(item)

                    sb.Append(",")

                Next
                'MessageBox.Show(sb.ToString())
                itemsList.Add(sb.ToString())
                'MessageBox.Show("Array : " + itemsList.Item(0))

                str = itemsList.Item(0)

                command1.Parameters.AddWithValue("@ALUMNI_ID1", txtpersonal_id.Text)
                command1.Parameters.AddWithValue("@TYPE_BCE", str)
            command1.ExecuteNonQuery()
            command1.Parameters.Clear()

        Catch ex As Exception
            MsgBox(ex.ToString)

        Finally
            conReg.Close()

        End Try

    End Sub

    Public Sub generate_Alumni_ID()
        Dim SQLCustomerAdapter As New MySqlDataAdapter
        Dim DTEmployee As New DataTable
        Dim row As Long
        Dim num As Integer = 1
        txtpersonal_id.Enabled = False

        SQLCustomerAdapter = New MySqlDataAdapter
        DTEmployee = New DataTable

        Try
            command.Parameters.Clear()
            command.CommandText = "Select alumni_id from personal_employment_info_tbl ORDER BY alumni_id DESC LIMIT 1"
            SQLCustomerAdapter.SelectCommand = command
            DTEmployee.Clear()
            SQLCustomerAdapter.Fill(DTEmployee)

            If DTEmployee.Rows.Count > 0 Then

                row = 0

                While DTEmployee.Rows.Count > row
                    num = Integer.Parse(DTEmployee.Rows(row).Item("alumni_id").ToString) + 1
                    row += 1
                End While
                txtpersonal_id.Text = num
            Else
                txtpersonal_id.Text = num

            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Public Sub Save_Personal_And_Employment_Info()
        Try
            If fncConnectToDatabase() <> True Then
                fncConnectToDatabase()

            End If
            command.CommandText = "Select * From personal_employment_info_tbl Where alumni_id='" & txtpersonal_id.Text & "'"
            dr = command.ExecuteReader

            If dr.HasRows Then
                MsgBox("Duplicate Entry Found!", MsgBoxStyle.Critical)
                conReg.Close()

            Else
                conReg.Close()
                conReg.Open()
                Sql = "Insert Into personal_employment_info_tbl(alumni_id, surname, firstname, middlename, gender, civil_status,
                        course, batch_date, highestDInUM, date_employment, JD_first_employment, company_first_employment, 
                        current_employed_status, current_company, job_designation, natureBCO) 
                        values (@ALUMNI_ID, @SURNAME, @FIRSTNAME, @MIDDLENAME, @GENDER, @CIVIL_STATUS, @COURSE, @BATCH_DATE, @HIGH_UM,
                                @DATE_EMPLOYMENT, @JD_FIRST_EMPLOYMENT, @COMPANY_FIRST_EMPLOYMENT, @CURRENT_EMPLOYED_STATUS, @CURRENT_COMPANY,
                                @JOB_DESIGNATION, @NATURE_BCE)"

                command.CommandText = Sql
                command.Parameters.AddWithValue("@ALUMNI_ID", txtpersonal_id.Text)
                command.Parameters.AddWithValue("@SURNAME", txtSurname.Text)
                command.Parameters.AddWithValue("@FIRSTNAME", txtFirstName.Text)
                command.Parameters.AddWithValue("@MIDDLENAME", txtMiddleName.Text)
                command.Parameters.AddWithValue("@GENDER", gender)
                command.Parameters.AddWithValue("@CIVIL_STATUS", civilstatus)
                command.Parameters.AddWithValue("@COURSE", txtCourse.Text)
                command.Parameters.AddWithValue("@BATCH_DATE", Format(dtpBatch.Value, "yyyy-MM-dd"))
                command.Parameters.AddWithValue("@HIGH_UM", highestdegreeInUM)
                command.Parameters.AddWithValue("@DATE_EMPLOYMENT", Format(dtpDateOfEmp.Value, "yyyy-MM-dd"))
                command.Parameters.AddWithValue("@JD_FIRST_EMPLOYMENT", txtBoxJobDes.Text)
                command.Parameters.AddWithValue("@COMPANY_FIRST_EMPLOYMENT", txtBoxCompanyEmployer.Text)
                command.Parameters.AddWithValue("@CURRENT_EMPLOYED_STATUS", currentemployedstatus)
                command.Parameters.AddWithValue("@CURRENT_COMPANY", txtBoxCurrCompany.Text)
                command.Parameters.AddWithValue("@JOB_DESIGNATION", txtBoxCurrJobDesig.Text)
                command.Parameters.AddWithValue("@NATURE_BCE", natureBCO)

                Dim r As Integer
                r = command.ExecuteNonQuery()
                If r Then
                    Dim dia As DialogResult
                    dia = MessageBox.Show("Do you want to Save Data Information?", "Personal And Employment Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                    If dia = Windows.Forms.DialogResult.Yes Then

                        getCheckedTypeBCE()
                        MsgBox("Save Successfully!")

                        command.Parameters.Clear()
                        Me.Hide()
                        SecondForm.Show()
                    End If

                Else
                    MsgBox("Try Again")
                    command.Parameters.Clear()
                End If

            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            dr.Close()
            conReg.Close()



        End Try
    End Sub

    Private Sub btnSearch_MouseEnter(sender As Object, e As EventArgs) Handles btnSearch.MouseEnter
        btnSearch.BackColor = Color.Maroon
    End Sub

    Private Sub btnSearch_MouseLeave(sender As Object, e As EventArgs) Handles btnSearch.MouseLeave
        btnSearch.BackColor = Color.Transparent
    End Sub

    Private Sub txtSearch_MouseClick(sender As Object, e As MouseEventArgs) Handles txtSearch.MouseClick
        txtSearch.Clear()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Save_Personal_And_Employment_Info()


    End Sub

    Private Sub rBtnPrivLocal_CheckedChanged_1(sender As Object, e As EventArgs) Handles rBtnPrivLocal.CheckedChanged
        natureBCO = "Private - Local"
    End Sub

    Private Sub rBtnPrivNatl_CheckedChanged_1(sender As Object, e As EventArgs) Handles rBtnPrivNatl.CheckedChanged
        natureBCO = "Private - National"
    End Sub

    Private Sub rBtnPublicGovernment_CheckedChanged_1(sender As Object, e As EventArgs) Handles rBtnPublicGovernment.CheckedChanged
        natureBCO = "Public / Government"
    End Sub

    Private Sub rBtnPOrganization_CheckedChanged_1(sender As Object, e As EventArgs) Handles rBtnPOrganization.CheckedChanged
        natureBCO = "People's Organization"
    End Sub

    Private Sub rBtnMOrganization_CheckedChanged_1(sender As Object, e As EventArgs) Handles rBtnMOrganization.CheckedChanged
        natureBCO = "Multination Organization"
    End Sub

    Private Sub rBtnNonGLocal_CheckedChanged_1(sender As Object, e As EventArgs) Handles rBtnNonGLocal.CheckedChanged
        natureBCO = "Non-Government-Local"
    End Sub

    Private Sub rBtnNonGNatl_CheckedChanged_1(sender As Object, e As EventArgs) Handles rBtnNonGNatl.CheckedChanged
        natureBCO = "Non-Governemt-National"
    End Sub

    Private Sub rBtnNonGIntl_CheckedChanged_1(sender As Object, e As EventArgs) Handles rBtnNonGIntl.CheckedChanged
        natureBCO = "Non-Government-International"
    End Sub
End Class