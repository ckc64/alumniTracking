Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.IO

Module ModGlobalVariable

    Public conReg As New MySqlConnection 'mao ni na variable na mu handle sa imong database connection
    Public command As New MySqlCommand 'mao ni na variable mo execute sa imong sql
    Public command1 As New MySqlCommand 'mao ni na variable mo execute sa imong sql
    Public strConnection As String 'string path sa database
    Public strsql 'variable mu handle sa sql statement
    Public servername As String 'variable sa mysql server
    Public databasename As String 'variable sa mysql database
    Public databaseuserid As String 'variable sa mysql username
    Public databasePassword As String 'variables sa mysql password
    Public cusphotopath As String
    Public id As Integer
    Public Sql As String

End Module
