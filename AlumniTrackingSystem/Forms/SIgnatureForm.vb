Imports MySql.Data.MySqlClient

Public Class ThirdForm

    Public Property alumni_id1 As Integer
    Dim OpenFileDialog1 As New OpenFileDialog
    Dim dr As MySqlDataReader
    Dim bmp As Bitmap
    Dim p As Pen
    Dim x, y As Single


    Public Sub newBitMap()
        bmp = New Bitmap(626, 243)
        PictureBox1.BackColor = Color.White
        p = New Pen(Color.Black, 2)


    End Sub

    Private Sub ThirdForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '''''''''''connection'''''''''''''''''''''
        alumni_id1 = 15
        If fncConnectToDatabase() = True Then
        Else
            conReg.Close()
        End If
        ''''''''''''''''''''''''''''''''''''''''''
        txtpersonal_id.Text = alumni_id1
        newBitMap()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        SecondForm.Show()

    End Sub

    Private Sub btnAddorBrowse_Click(sender As Object, e As EventArgs) Handles btnAddorBrowse.Click
        If Not PictureBox1.Image Is Nothing Then

            If btnAddorBrowse.Text = "Save" Then

                Save_Signature()
                Me.Dispose()

            End If
        Else
            If txtpersonal_id.Text = 0 Then
                MsgBox("Please Insert Personal Information", MsgBoxStyle.Critical)
                Me.Dispose()

            Else
                Browse_Signature()
                btnAddorBrowse.Text = "Save"
            End If

        End If

    End Sub

    Public Sub Browse_Signature()
        Try
            With OpenFileDialog1

                'CHECK THE SELECTED FILE IF IT EXIST OTHERWISE THE DIALOG BOX WILL DISPLAY A WARNING.
                .CheckFileExists = True

                'CHECK THE SELECTED PATH IF IT EXIST OTHERWISE THE DIALOG BOX WILL DISPLAY A WARNING.
                .CheckPathExists = True

                'GET AND SET THE DEFAULT EXTENSION
                .DefaultExt = "jpg"

                'RETURN THE FILE LINKED TO THE LNK FILE
                .DereferenceLinks = True

                'SET THE FILE NAME TO EMPTY 
                .FileName = ""

                'FILTERING THE FILES
                .Filter = "(*.jpg)|*.jpg|(*.png)|*.png|(*.jpg)|*.jpg|All files|*.*"
                'SET THIS FOR ONE FILE SELECTION ONLY.
                .Multiselect = False



                'SET THIS TO PUT THE CURRENT FOLDER BACK TO WHERE IT HAS STARTED.
                .RestoreDirectory = True

                'SET THE TITLE OF THE DIALOG BOX.
                .Title = "Select a file to open"

                'ACCEPT ONLY THE VALID WIN32 FILE NAMES.
                .ValidateNames = True

                If .ShowDialog = DialogResult.OK Then
                    Try
                        PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
                    Catch fileException As Exception
                        Throw fileException
                    End Try
                End If

            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub

    Public Sub Save_Signature()
        Dim result As Integer
        Dim caption As String
        Dim arrImage() As Byte
        Dim mstream As New System.IO.MemoryStream()

        caption = System.IO.Path.GetFileName(OpenFileDialog1.FileName)
        'SPECIFIES THE FILE FORMAT OF THE IMAGE
        PictureBox1.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)

        'RETURNS THE ARRAY OF UNSIGNED BYTES FROM WHICH THIS STREAM WAS CREATED
        arrImage = mstream.GetBuffer()

        'GET THE SIZE OF THE STREAM IN BYTES
        Dim FileSize As UInt32
        FileSize = mstream.Length
        'CLOSES THE CURRENT STREAM AND RELEASE ANY RESOURCES ASSOCIATED WITH THE CURRENT STREAM
        mstream.Close()
        Try
            If fncConnectToDatabase() <> True Then
                fncConnectToDatabase()

            End If

            command.CommandText = "Select * From signature_tbl Where alumni_id='" & txtpersonal_id.Text & "'"
            dr = command.ExecuteReader

            If dr.HasRows Then
                MsgBox("Duplicate Entry Found!", MsgBoxStyle.Critical)
                conReg.Close()

            Else
                Sql = "INSERT INTO  signature_tbl (alumni_id, caption, signature) VALUES (@ALUMNI_ID, @CAPTION, @SIGNATURE)"
                command = New MySqlCommand
                With command
                    .Connection = conReg
                    .CommandText = Sql
                    .Parameters.AddWithValue("@ALUMNI_ID", alumni_id1)
                    .Parameters.AddWithValue("@CAPTION", caption)
                    .Parameters.AddWithValue("@SIGNATURE", arrImage)
                    result = .ExecuteNonQuery()
                End With
                If result > 0 Then
                    MsgBox("Picture has been save in the database")
                Else
                    MsgBox("Error query", MsgBoxStyle.Exclamation)
                End If

            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            conReg.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SaveFileDialog1.ShowDialog()

    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        bmp.Save(SaveFileDialog1.FileName)
    End Sub

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        x = e.X
        y = e.Y
    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        Dim g As Graphics = Graphics.FromImage(bmp)
        If e.Button = Windows.Forms.MouseButtons.Left Then
            g.DrawLine(p, x, y, e.X, e.Y)
            PictureBox1.Image = bmp
            x = e.X
            y = e.Y
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnClear.Click
        Dim g As Graphics = Graphics.FromImage(bmp)
        g.Clear(Color.White)
        PictureBox1.Image = bmp
    End Sub
End Class
