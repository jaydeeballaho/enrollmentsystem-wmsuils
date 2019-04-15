Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class Payments

    Private _paymentid As Integer
    Public Property PaymentID As Integer
        Set(value As Integer)
            _paymentid = value
        End Set
        Get
            Return _paymentid
        End Get
    End Property
    Private _studentid As Integer
    Public Property StudentID As Integer
        Set(value As Integer)
            _studentid = value
        End Set
        Get
            Return _studentid
        End Get
    End Property
    Private _enrollmentid As Integer
    Public Property EnrollmentID As Integer
        Set(value As Integer)
            _enrollmentid = value
        End Set
        Get
            Return _enrollmentid
        End Get
    End Property
    Private _dop As Date
    Public Property DOP As Date
        Set(value As Date)
            _dop = value
        End Set
        Get
            Return _dop
        End Get
    End Property
    Private _amount As Decimal
    Public Property Amount As Decimal
        Set(value As Decimal)
            _amount = value
        End Set
        Get
            Return _amount
        End Get
    End Property
    Private _collectedby As String = frmHome.fullname
    Public Property CollectedBy As String
        Set(value As String)
            _collectedby = value
        End Set
        Get
            Return _collectedby
        End Get
    End Property
    Public Function AddPayment() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = ""
            sql = "INSERT INTO payment (enrollmentid,studentid,dop,amountpaid,collectedby) VALUES (@0,@1,@2,@3,@4);"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, EnrollmentID, StudentID, DOP, Amount, CollectedBy)
                Commit()
                bool = True
            End If
            Return bool
        Catch ex As Exception
            Rollback()
            Return False
        End Try
    End Function
    Public Function EditPayment() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = ""
            sql = "UPDATE payment SET amountpaid=@0,collectedby=@1 where paymentid=@2;"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, Amount, CollectedBy, PaymentID)
                Commit()
                bool = True
            End If
            Return bool
        Catch ex As Exception
            Rollback()
            Return False
        End Try
    End Function
    Public Sub SetPaymentDetails(id As Integer)
        Try
            Dim sql As String
            sql = "SELECT * FROM payment WHERE paymentid = " & id & ";"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    PaymentID = reader(0)
                    EnrollmentID = reader(1)
                    StudentID = reader(2)
                    DOP = reader(3)
                    Amount = reader(4)
                    CollectedBy = reader(5)
                End While
                reader.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Public Function GetPayments() As Decimal
        Try
            Dim d As Decimal = 0
            Dim sql As String
            sql = "SELECT COALESCE(SUM(amountpaid), 0) FROM payment WHERE studentid = " & StudentID & ";"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read
                    d = reader("COALESCE(SUM(amountpaid), 0)")
                End While
                reader.Close()
            End If
            Return d
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Sub ViewPayments(gv As DataGridView)
        Try
            Dim sql As String
            sql = "SELECT * FROM payment WHERE studentid = " & StudentID & " ORDER BY dop,paymentid DESC;"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                gv.Rows.Clear()
                While reader.Read()
                    gv.Rows.Add(reader("paymentid"), Date.Parse(reader("dop")).ToShortDateString, Integer.Parse(reader("paymentid")).ToString("D5"),
                                Decimal.Parse(reader("amountpaid")).ToString("N", CultureInfo.InvariantCulture), reader("collectedby"), "Edit")
                End While
                reader.Close()
                gv.ClearSelection()
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class
