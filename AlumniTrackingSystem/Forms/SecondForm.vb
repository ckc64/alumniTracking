Public Class SecondForm

    Public alumni_id1 As Integer
    Public Property alumni_id As Integer
    Dim name_of_org As String
    Dim positions As String
    Dim period_cover As String
    Dim title As String
    Dim dateTitle As String
    Dim awards_given_by As String

    Private Sub SecondForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '''''''''''connection'''''''''''''''''''''
        alumni_id = 15
        If fncConnectToDatabase() = True Then
        Else
            conReg.Close()
        End If
        ''''''''''''''''''''''''''''''''''''''''''
        txtpersonal_id.Text = alumni_id

    End Sub

    Private Sub btnSignature_Click(sender As Object, e As EventArgs) Handles btnSignature.Click
        Dim thirdForm As New ThirdForm
        thirdForm.alumni_id1 = txtpersonal_id.Text
        thirdForm.Show()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        FirstForm.Show()
    End Sub

    ''' <summary>
    ''' .................................................................................................................
    ''' Functions.................................................................................................................
    ''' .................................................................................................................
    ''' </summary>
    Private Sub getCheckedTypeBCE()
        If typeOfOrgCheckedListBox.CheckedItems.Count > 0 Then
            For i As Integer = 0 To typeOfOrgCheckedListBox.CheckedItems.Count - 1
                MsgBox(typeOfOrgCheckedListBox.CheckedItems(i))
            Next
        End If
    End Sub

    Public Sub Save_Type_Of_Affilations_UM()

        Try
            If fncConnectToDatabase() <> True Then
                fncConnectToDatabase()

            End If

            name_of_org = txtNameOrgOne.Text + "," + txtNameOrgTwo.Text + "," + txtNameOrgThree.Text + "," + txtNameOrgFour.Text + "," + txtNameOrgFive.Text
            positions = txtPosHeldOne.Text + "," + txtPosHeldTwo.Text + "," + txtPosHeldThree.Text + "," + txtPosHeldFour.Text + "," + txtPosHeldFive.Text
            period_cover = txtPeriodCoveredOne.Text + "," + txtPeriodCoveredTwo.Text + "," + txtPeriodCoveredThree.Text + "," + txtPeriodCoveredFour.Text + "," + txtPeriodCoveredFive.Text

            ' For Each name_of_org In arrayOrg
            'Sql = "INSERT INTO affilations_um_tbl (alumni_id, name_of_org) VALUES('" & 1 & "','" & name_of_org & "');"
            'command.CommandText = Sql
            'command.ExecuteNonQuery()
            'Next


            'positions = txtPosHeldOne.Text + "," + txtPosHeldTwo.Text + "," + txtPosHeldThree.Text + "," + txtPosHeldFour.Text + "," + txtPosHeldFive.Text
            ' period_cover = txtPeriodCoveredOne.Text + "," + txtPeriodCoveredTwo.Text + "," + txtPeriodCoveredThree.Text + "," + txtPeriodCoveredFour.Text + "," + txtPeriodCoveredFive.Text

            Sql = "Insert Into affilations_um_tbl(alumni_id, name_of_org, position, period_cover) values (@ALUMNI_ID, @NAME_OF_ORG, @POSITION, @PERIOD_COVER)"

            command.CommandText = Sql
            command.Parameters.AddWithValue("@ALUMNI_ID", txtpersonal_id.Text)
            command.Parameters.AddWithValue("@NAME_OF_ORG", name_of_org)
            command.Parameters.AddWithValue("@POSITION", positions)
            command.Parameters.AddWithValue("@PERIOD_COVER", period_cover)
            command.ExecuteNonQuery()
            command.Parameters.Clear()

            conReg.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub Save_Type_Of_Organization()

        Dim sb As New System.Text.StringBuilder
        Dim itemsList As ArrayList = New ArrayList
        Dim str As String
        Try


            For Each item In typeOfOrgCheckedListBox.CheckedItems

                sb.Append(item)

                sb.Append(",")

            Next
            'MessageBox.Show(sb.ToString())
            itemsList.Add(sb.ToString())
            'MessageBox.Show("Array : " + itemsList.Item(0))

            str = itemsList.Item(0)


            If fncConnectToDatabase() <> True Then
                fncConnectToDatabase()

            End If

            Sql = "Insert Into type_organization_tbl(alumni_id, type_of_org) values (@ALUMNI_ID, @TYPE_ORG)"


            command.CommandText = Sql
            command.Parameters.AddWithValue("@ALUMNI_ID", txtpersonal_id.Text)
            command.Parameters.AddWithValue("@TYPE_ORG", str)
            command.ExecuteNonQuery()
            'MsgBox(typeOfBusCheckedListBox.CheckedItems(i))
            command.Parameters.Clear()
            conReg.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub Save_Honors_And_Awards_UM()

        Try
            If fncConnectToDatabase() <> True Then
                fncConnectToDatabase()

            End If

            awards_given_by = txtAwardsOne.Text + "," + txtAwardsTwo.Text + "," + txtAwardsThree.Text + "," + txtAwardsFour.Text + "," + txtAwardsFive.Text
            dateTitle = txtdateOne.Text + "," + txtdateTwo.Text + "," + txtdateThree.Text + "," + txtdateFour.Text + "," + txtdateFive.Text
            title = txtTitleOne.Text + "," + txtTitleTwo.Text + "," + txtTitleThree.Text + "," + txtTitleFour.Text + "," + txtTitleFive.Text

            Sql = "Insert Into honors_awards_um_tbl(alumni_id, title, date, awards_given_by) values (@ALUMNI_ID, @TITLE, @DATE, @AWARDS_GIVEN_BY)"

            command.CommandText = Sql
            command.Parameters.AddWithValue("@ALUMNI_ID", txtpersonal_id.Text)
            command.Parameters.AddWithValue("@TITLE", title)
            command.Parameters.AddWithValue("@DATE", dateTitle)
            command.Parameters.AddWithValue("@AWARDS_GIVEN_BY", awards_given_by)
            command.ExecuteNonQuery()
            command.Parameters.Clear()
            conReg.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Save_Type_Of_Affilations_UM()
        Save_Type_Of_Organization()
        Save_Honors_And_Awards_UM()
        MessageBox.Show("Successfully Save")
        Me.Hide()
        ThirdForm.Show()
    End Sub
End Class