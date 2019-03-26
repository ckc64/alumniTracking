Imports MySql.Data.MySqlClient
Imports System.Data

Module ModGlobalProcedure

    Public Function fncConnectToDatabase() As Boolean
        Try
            servername = "localhost"
            databasename = "alumnitracking_db"
            databaseuserid = "root"
            databasePassword = ""


            If conReg.State = ConnectionState.Closed Then
                conReg = New MySqlConnection

                strConnection = "SERVER=" & servername & ";" _
                                          & "DATABASE=" & databasename & ";" _
                                          & "USERNAME=" & databaseuserid & ";" _
                                          & "PASSWORD=" & databasePassword & ";"

                conReg.ConnectionString = strConnection
                conReg.Open()
                command.Connection = conReg
                command1.Connection = conReg
                Return True
            Else
                conReg.Close()

                Return False

            End If
        Catch ex As Exception
            MessageBox.Show("ERRORS", ex.Message)
            Return False

        End Try

    End Function

End Module
