Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub minimizelbl_Click(sender As Object, e As EventArgs) Handles minimizelbl.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub closelbl_Click(sender As Object, e As EventArgs) Handles closelbl.Click
        Me.Close()

    End Sub

    Private Sub btnaddemp_MouseEnter(sender As Object, e As EventArgs) Handles btnAddEmp.MouseEnter
        btnAddEmp.BackColor = Color.Maroon
    End Sub

    Private Sub btnaddemp_MouseLeave(sender As Object, e As EventArgs) Handles btnAddEmp.MouseLeave
        btnAddEmp.BackColor = Color.Transparent
    End Sub

    Private Sub btnAddEmp_Info_MouseEnter(sender As Object, e As EventArgs) Handles btnAddEmp_Info.MouseEnter
        btnAddEmp_Info.BackColor = Color.Maroon
    End Sub

    Private Sub btnAddEmp_Info_MouseLeave(sender As Object, e As EventArgs) Handles btnAddEmp_Info.MouseLeave
        btnAddEmp_Info.BackColor = Color.Transparent
    End Sub

    Private Sub btnAddEmp_Aff_MouseEnter(sender As Object, e As EventArgs) Handles btnAddEmp_Aff.MouseEnter
        btnAddEmp_Aff.BackColor = Color.Maroon
    End Sub

    Private Sub btnAddEmp_Aff_MouseLeave(sender As Object, e As EventArgs) Handles btnAddEmp_Aff.MouseLeave
        btnAddEmp_Aff.BackColor = Color.Transparent
    End Sub

    Private Sub btnAddEmp_Sig_MouseEnter(sender As Object, e As EventArgs) Handles btnAddEmp_Records.MouseEnter
        btnAddEmp_Records.BackColor = Color.Maroon
    End Sub

    Private Sub btnAddEmp_Sig_MouseLeave(sender As Object, e As EventArgs) Handles btnAddEmp_Records.MouseLeave
        btnAddEmp_Records.BackColor = Color.Transparent
    End Sub

    Private Sub btnHelp_MouseEnter(sender As Object, e As EventArgs) Handles btnHelp.MouseEnter
        btnHelp.BackColor = Color.Maroon
    End Sub

    Private Sub btnHelp_MouseLeave(sender As Object, e As EventArgs) Handles btnHelp.MouseLeave
        btnHelp.BackColor = Color.Transparent
    End Sub

    Private Sub btnSettings_MouseEnter(sender As Object, e As EventArgs) Handles btnSettings.MouseEnter
        btnSettings.BackColor = Color.Maroon
    End Sub

    Private Sub btnSettings_MouseLeave(sender As Object, e As EventArgs) Handles btnSettings.MouseLeave
        btnSettings.BackColor = Color.Transparent
    End Sub

    Private Sub btnAddEmp_Click(sender As Object, e As EventArgs) Handles btnAddEmp.Click
        MsgBox("This Form For Employee")
    End Sub

    Private Sub btnAddEmp_Info_Click(sender As Object, e As EventArgs) Handles btnAddEmp_Info.Click
        SecondForm.Close()
        ThirdForm.Close()

        FirstForm.MdiParent = Me
        FirstForm.Dock = DockStyle.Fill
        FirstForm.StartPosition = FormStartPosition.CenterParent
        FirstForm.Show()
    End Sub

    Private Sub btnAddEmp_Aff_Click(sender As Object, e As EventArgs) Handles btnAddEmp_Aff.Click
        FirstForm.Close()
        ThirdForm.Close()

        SecondForm.MdiParent = Me
        SecondForm.Dock = DockStyle.Fill
        SecondForm.StartPosition = FormStartPosition.CenterParent
        SecondForm.Show()
    End Sub

    Private Sub btnAddEmp_Records_Click(sender As Object, e As EventArgs) Handles btnAddEmp_Records.Click
        FirstForm.Close()
        SecondForm.Close()

        RecordsForm.MdiParent = Me
        RecordsForm.Dock = DockStyle.Fill
        RecordsForm.StartPosition = FormStartPosition.CenterParent
        RecordsForm.Show()
    End Sub
End Class