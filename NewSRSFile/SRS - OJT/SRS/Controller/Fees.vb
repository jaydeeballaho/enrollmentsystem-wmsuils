Imports MySql.Data.MySqlClient
Imports System.Globalization
Imports MetroFramework.Controls

Public Class Fees

    Private _feesid As Integer = 0
    Public Property FeesID As Integer
        Set(value As Integer)
            _feesid = value
        End Set
        Get
            Return _feesid
        End Get
    End Property
    Private _feesname As String = ""
    Public Property FeesName As String
        Set(value As String)
            _feesname = value
        End Set
        Get
            Return _feesname
        End Get
    End Property
    Private _amount As Decimal = 0
    Public Property Amount As Decimal
        Set(value As Decimal)
            _amount = value
        End Set
        Get
            Return _amount
        End Get
    End Property
    Private _feestype As String = "LOCAL FEES"
    Public Property FeesType As String
        Set(value As String)
            _feestype = value
        End Set
        Get
            Return _feestype
        End Get
    End Property
    Private _required As String = "REQUIRED"
    Public Property Required As String
        Set(value As String)
            _required = value
        End Set
        Get
            Return _required
        End Get
    End Property
   
    Public Sub SetFeesID()
        Dim sql As String = "SELECT LAST_INSERT_ID();"
        Dim cmd = New MySqlCommand(sql, getServerConnection)
        FeesID = CInt(cmd.ExecuteScalar())
    End Sub

    'METHODS

    Public Function AddFees() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = "INSERT INTO fees (feesname,amount,feestype,required) values (@0,@1,@2,@3);"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, FeesName, Amount, FeesType, Required)
                Commit()
                bool = True
            End If
            Return bool
        Catch ex As Exception
            Rollback()
            Return False
        End Try
    End Function
    Public Function AddFeesToLevel(sy As Integer, gl As Integer) As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = "INSERT INTO feesschoolyear (schoolyearid,feesid,gradelevelid) values (@0,@1,@2);"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, sy, FeesID, gl)
                Commit()
                bool = True
            End If
            Return bool
        Catch ex As Exception
            Rollback()
            Return False
        End Try
    End Function
    Public Function EditFees() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = "UPDATE fees SET feesname=@0,amount=@1,feestype=@2,required=@3 WHERE feesid = @4;"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, FeesName, Amount, FeesType, Required, FeesID)
                Commit()
                bool = True
            End If
            Return bool
        Catch ex As Exception
            Rollback()
            Return False
        End Try
    End Function

    Public Function DeleteFees() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = "DELETE FROM fees WHERE feesid = @0;"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, FeesID)
                Commit()
                bool = True
            End If
            Return bool
        Catch ex As Exception
            Rollback()
            Return False
        End Try
    End Function

    Public Function RemoveFees(id As Integer) As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = "DELETE FROM feesschoolyear WHERE feessyid = @0;"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, id)
                Commit()
                bool = True
            End If
            Return bool
        Catch ex As Exception
            Rollback()
            Return False
        End Try
    End Function

    Public Function IsFeesExist(id As Integer, gl As Integer, sy As Integer) As Boolean
        Try
            Dim sql As String
            Dim bool As Boolean = True
            sql = "SELECT * FROM feesschoolyear WHERE feesid = " & id & " AND schoolyearid = " & sy & " AND gradelevelid = " & gl & ";"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.HasRows Then
                    bool = True
                Else
                    bool = False
                End If
                reader.Close()
            End If
            Return bool
        Catch ex As Exception
            Return True
        End Try
    End Function

    Public Sub SetFeesDetails(i As Integer)
        Try
            Dim sql As String
            sql = "SELECT * FROM fees WHERE feesid = " & i & ";"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    FeesID = reader("feesid")
                    FeesName = reader("feesname")
                    Amount = reader("amount")
                    FeesType = reader("feestype")
                    Required = reader("required")
                End While
                reader.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Public Sub GetFeesType(i As Integer)
        Try
            Dim sql As String
            sql = "SELECT * FROM fees as p1 inner join feesschoolyear as p2 on p1.feesid=p2.feesid WHERE feessyid = " & i & ";"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    Required = reader("required")
                End While
                reader.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Public Sub SearchAllFees(kw As String, gv As DataGridView)
        Try
            Dim sql As String
            sql = "SELECT * FROM fees WHERE feesname LIKE '" & kw & "%' or feestype LIKE '" & kw & "%' ORDER BY feesname ASC;"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                gv.Rows.Clear()
                While reader.Read()
                    If reader("required").ToString() = "Optional" Then
                        gv.Rows.Add(reader("feesid"), reader("feesname") + " (Optional)", _
                                Decimal.Parse(reader("amount")).ToString("N", CultureInfo.InvariantCulture), reader("feestype"), _
                                "Edit", "Delete")
                    Else
                        gv.Rows.Add(reader("feesid"), reader("feesname"), _
                                Decimal.Parse(reader("amount")).ToString("N", CultureInfo.InvariantCulture), reader("feestype"), _
                                "Edit", "Delete")
                    End If
                End While
                reader.Close()
                gv.ClearSelection()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Public Sub ViewAllFees(gv As DataGridView)
        Try
            Dim sql As String
            sql = "SELECT * FROM fees ORDER BY feesname ASC;"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                gv.Rows.Clear()
                While reader.Read()
                    If reader("required").ToString() = "Optional" Then
                        gv.Rows.Add(reader("feesid"), reader("feesname") + " (Optional)", _
                                Decimal.Parse(reader("amount")).ToString("N", CultureInfo.InvariantCulture), reader("feestype"), _
                                "Edit", "Delete")
                    Else
                        gv.Rows.Add(reader("feesid"), reader("feesname"), _
                                Decimal.Parse(reader("amount")).ToString("N", CultureInfo.InvariantCulture), reader("feestype"), _
                                "Edit", "Delete")
                    End If
                End While
                reader.Close()
                gv.ClearSelection()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub ViewlocalFeesFromPSY(gl As Integer, sy As Integer, gv As DataGridView, tb As MetroTextBox, sy2 As Integer)
        Try
            Dim sql As String
            sql = "select * from fees f1 inner join feesschoolyear f2 ON f1.feesid = f2.feesid " _
                & "where f2.gradelevelid = " & gl & " and f2.schoolyearid = " & sy & " and feestype = 'LOCAL FEES' ORDER BY feesname ASC;"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                gv.Rows.Clear()
                tb.Text = 0.0
                While reader.Read()
                    If reader("required").ToString() = "Optional" Then
                        gv.Rows.Add(reader("feesid"), reader("feesname") + " (Optional)", _
                                Decimal.Parse(reader("amount")).ToString("N", CultureInfo.InvariantCulture))
                        tb.Text = (Decimal.Parse(tb.Text) + Decimal.Parse(reader("amount"))).ToString("N", CultureInfo.InvariantCulture)
                    Else
                        gv.Rows.Add(reader("feesid"), reader("feesname"), _
                                Decimal.Parse(reader("amount")).ToString("N", CultureInfo.InvariantCulture))
                        tb.Text = (Decimal.Parse(tb.Text) + Decimal.Parse(reader("amount"))).ToString("N", CultureInfo.InvariantCulture)
                    End If
                End While
                reader.Close()
                gv.ClearSelection()
                For Each row As DataGridViewRow In gv.Rows
                    If IsFeesExist(row.Cells(0).Value, gl, sy2) = False Then
                        row.DefaultCellStyle.ForeColor = Color.Crimson
                    End If
                Next
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub ViewUniversityFeesFromPSY(gl As Integer, sy As Integer, gv As DataGridView, tb As MetroTextBox, sy2 As Integer)
        Try
            Dim sql As String
            sql = "select * from fees f1 inner join feesschoolyear f2 ON f1.feesid = f2.feesid " _
                & "where f2.gradelevelid = " & gl & " and f2.schoolyearid = " & sy & " and feestype = 'UNIVERSITY FEES' ORDER BY feesname ASC;"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                gv.Rows.Clear()
                tb.Text = 0.0
                While reader.Read()
                    If reader("required").ToString() = "Optional" Then
                        gv.Rows.Add(reader("feesid"), reader("feesname") + " (Optional)", _
                                Decimal.Parse(reader("amount")).ToString("N", CultureInfo.InvariantCulture), reader("feestype"))
                        tb.Text = (Decimal.Parse(tb.Text) + Decimal.Parse(reader("amount"))).ToString("N", CultureInfo.InvariantCulture)
                    Else
                        gv.Rows.Add(reader("feesid"), reader("feesname"), _
                                Decimal.Parse(reader("amount")).ToString("N", CultureInfo.InvariantCulture), reader("feestype"))
                        tb.Text = (Decimal.Parse(tb.Text) + Decimal.Parse(reader("amount"))).ToString("N", CultureInfo.InvariantCulture)
                    End If
                End While
                reader.Close()
                gv.ClearSelection()
                For Each row As DataGridViewRow In gv.Rows
                    If IsFeesExist(row.Cells(0).Value, gl, sy2) = False Then
                        row.DefaultCellStyle.ForeColor = Color.Crimson
                    End If
                Next
            End If
        Catch ex As Exception
        End Try
    End Sub
    Public Sub ViewUniversityToAdd(gl As Integer, sy As Integer, gv As DataGridView)
        Try
            Dim sql As String
            sql = "select * from fees f where not exists (select * from feesschoolyear f1 where f.feesid = f1.feesid " _
                & "and f1.gradelevelid = " & gl & " and f1.schoolyearid = " & sy & ") and feestype = 'University Fees' ORDER BY feesname ASC;"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                gv.Rows.Clear()
                While reader.Read()
                    If reader("required").ToString() = "Optional" Then
                        gv.Rows.Add(reader("feesid"), False, reader("feesname") + " (Optional)", _
                                Decimal.Parse(reader("amount")).ToString("N", CultureInfo.InvariantCulture))
                    Else
                        gv.Rows.Add(reader("feesid"), False, reader("feesname"), _
                                Decimal.Parse(reader("amount")).ToString("N", CultureInfo.InvariantCulture))
                    End If
                End While
                reader.Close()
                gv.ClearSelection()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Public Sub ViewLocalFeesToAdd(gl As Integer, sy As Integer, gv As DataGridView)
        Try
            Dim sql As String
            sql = "select * from fees f where not exists (select * from feesschoolyear f1 where f.feesid = f1.feesid " _
                & "and f1.gradelevelid = " & gl & " and f1.schoolyearid = " & sy & ") and feestype = 'Local Fees' ORDER BY feesname ASC;"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                gv.Rows.Clear()
                While reader.Read()
                    If reader("required").ToString() = "Optional" Then
                        gv.Rows.Add(reader("feesid"), False, reader("feesname") + " (Optional)", _
                                Decimal.Parse(reader("amount")).ToString("N", CultureInfo.InvariantCulture))
                    Else
                        gv.Rows.Add(reader("feesid"), False, reader("feesname"), _
                                Decimal.Parse(reader("amount")).ToString("N", CultureInfo.InvariantCulture))
                    End If
                End While
                reader.Close()
                gv.ClearSelection()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub ViewLocalFees(sy As String, gl As String, gv As DataGridView, tb As MetroTextBox)
        Try
            Dim sql As String
            sql = "select * from feesschoolyear inner join fees on feesschoolyear.feesid = fees.feesid" _
                    & " inner join schoolyear on feesschoolyear.schoolyearid = schoolyear.schoolyearid" _
                    & " inner join gradelevel on feesschoolyear.gradelevelid = gradelevel.gradelevelid" _
                    & " where schoolyearno = '" & sy & "' and gradelevelno = '" & gl & "' and feestype = 'LOCAL FEES' ORDER BY feesname;"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                gv.Rows.Clear()
                tb.Text = 0
                While reader.Read()
                    If reader("required") = "Optional" Then
                        gv.Rows.Add(reader("feessyid"), reader("feesname") + " (Optional)", _
                                Decimal.Parse(reader("amount")).ToString("N", CultureInfo.InvariantCulture), "Remove")
                        tb.Text = (Decimal.Parse(tb.Text) + Decimal.Parse(reader("amount"))).ToString("N", CultureInfo.InvariantCulture)
                    Else
                        gv.Rows.Add(reader("feessyid"), reader("feesname"), _
                                Decimal.Parse(reader("amount")).ToString("N", CultureInfo.InvariantCulture), "Remove")
                        tb.Text = (Decimal.Parse(tb.Text) + Decimal.Parse(reader("amount"))).ToString("N", CultureInfo.InvariantCulture)
                    End If
                End While
                reader.Close()
                gv.ClearSelection()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Public Sub ViewUniversityFees(sy As String, gl As String, gv As DataGridView, tb As MetroTextBox)
        Try
            Dim sql As String
            sql = "select * from feesschoolyear inner join fees on feesschoolyear.feesid = fees.feesid" _
                    & " inner join schoolyear on feesschoolyear.schoolyearid = schoolyear.schoolyearid" _
                    & " inner join gradelevel on feesschoolyear.gradelevelid = gradelevel.gradelevelid" _
                    & " where schoolyearno = '" & sy & "' and gradelevelno = '" & gl & "' and feestype = 'UNIVERSITY FEES' ORDER BY feesname;"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                gv.Rows.Clear()
                tb.Text = 0
                While reader.Read()
                    If reader("required") = "Optional" Then
                        gv.Rows.Add(reader("feessyid"), reader("feesname") + " (Optional)", _
                                Decimal.Parse(reader("amount")).ToString("N", CultureInfo.InvariantCulture), "Remove")
                        tb.Text = (Decimal.Parse(tb.Text) + Decimal.Parse(reader("amount"))).ToString("N", CultureInfo.InvariantCulture)
                    Else
                        gv.Rows.Add(reader("feessyid"), reader("feesname"), _
                                Decimal.Parse(reader("amount")).ToString("N", CultureInfo.InvariantCulture), "Remove")
                        tb.Text = (Decimal.Parse(tb.Text) + Decimal.Parse(reader("amount"))).ToString("N", CultureInfo.InvariantCulture)
                    End If

                End While
                reader.Close()
                gv.ClearSelection()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub ViewLocalFees2(sy As String, gl As String, gv As DataGridView, tb As MetroTextBox)
        Try
            Dim sql As String
            sql = "select * from feesschoolyear inner join fees on feesschoolyear.feesid = fees.feesid" _
                    & " inner join schoolyear on feesschoolyear.schoolyearid = schoolyear.schoolyearid" _
                    & " inner join gradelevel on feesschoolyear.gradelevelid = gradelevel.gradelevelid" _
                    & " where schoolyearno = '" & sy & "' and gradelevelno = '" & gl & "' and feestype = 'LOCAL FEES' ORDER BY feesname;"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                gv.Rows.Clear()
                tb.Text = 0
                While reader.Read()
                    If reader("required") = "Optional" Then
                        gv.Rows.Add(reader("feessyid"), True, reader("feesname") + " (Optional)", _
                                Decimal.Parse(reader("amount")).ToString("N", CultureInfo.InvariantCulture))
                        tb.Text = (Decimal.Parse(tb.Text) + Decimal.Parse(reader("amount"))).ToString("N", CultureInfo.InvariantCulture)
                        gv.Rows(gv.RowCount - 1).DefaultCellStyle.ForeColor = Color.Blue
                    Else
                        gv.Rows.Add(reader("feessyid"), True, reader("feesname"), _
                                Decimal.Parse(reader("amount")).ToString("N", CultureInfo.InvariantCulture))
                        tb.Text = (Decimal.Parse(tb.Text) + Decimal.Parse(reader("amount"))).ToString("N", CultureInfo.InvariantCulture)
                    End If
                End While
                reader.Close()
                gv.ClearSelection()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Public Sub ViewUniversityFees2(sy As String, gl As String, gv As DataGridView, tb As MetroTextBox)
        Try
            Dim sql As String
            sql = "select * from feesschoolyear inner join fees on feesschoolyear.feesid = fees.feesid" _
                    & " inner join schoolyear on feesschoolyear.schoolyearid = schoolyear.schoolyearid" _
                    & " inner join gradelevel on feesschoolyear.gradelevelid = gradelevel.gradelevelid" _
                    & " where schoolyearno = '" & sy & "' and gradelevelno = '" & gl & "' and feestype = 'UNIVERSITY FEES' ORDER BY feesname;"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                gv.Rows.Clear()
                tb.Text = 0
                While reader.Read()
                    If reader("required") = "Optional" Then
                        gv.Rows.Add(reader("feessyid"), reader("feesname") + " (Optional)", _
                                Decimal.Parse(reader("amount")).ToString("N", CultureInfo.InvariantCulture))
                        tb.Text = (Decimal.Parse(tb.Text) + Decimal.Parse(reader("amount"))).ToString("N", CultureInfo.InvariantCulture)
                    Else
                        gv.Rows.Add(reader("feessyid"), reader("feesname"), _
                                Decimal.Parse(reader("amount")).ToString("N", CultureInfo.InvariantCulture), _
                                "0.00", Decimal.Parse(reader("amount")).ToString("N", CultureInfo.InvariantCulture))
                        tb.Text = (Decimal.Parse(tb.Text) + Decimal.Parse(reader("amount"))).ToString("N", CultureInfo.InvariantCulture)
                    End If

                End While
                reader.Close()
                gv.ClearSelection()
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class
