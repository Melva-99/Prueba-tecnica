Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Input

Public Class conexion
    Public conexion As SqlConnection = New SqlConnection("Data Source=DESKTOP-5KTJMQQ; Initial Catalog=BD_USUARIOS; Integrated Security=True")
    Public cmb As SqlCommand
    Public da As SqlDataAdapter
    Public dt As DataTable

    Public Sub conectar()
        Try
            conexion.Open()
            MessageBox.Show("Conexión exitosa")
        Catch ex As Exception
            MessageBox.Show("Error conexion de base de datos")
        Finally
            conexion.Close()
        End Try
    End Sub

    Public Function llenarcbm(sql As String, cbo As ComboBox)
        Try
            conexion.Open()

            cmb = New SqlCommand
            da = New SqlDataAdapter
            dt = New DataTable

            With cmb
                .Connection = conexion
                .CommandText = sql
            End With

            With da
                .SelectCommand = cmb
                .Fill(dt)
            End With

            cbo.DataSource = dt
            cbo.DisplayMember = dt.Columns(1).ColumnName
            cbo.ValueMember = dt.Columns(0).ColumnName

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conexion.Close()
        End Try
    End Function

    Public Function insertar(nombre As String, apellido As String, Identidad As String, sexo As String, celular As String, correo As String, usuario As String)
        Try
            conexion.Open()
            cmb = New SqlCommand("insertar", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@Nombre", nombre)
            cmb.Parameters.AddWithValue("@Apellido", apellido)
            cmb.Parameters.AddWithValue("@Identidad", Identidad)
            cmb.Parameters.AddWithValue("@Sexo", sexo)
            cmb.Parameters.AddWithValue("@Celular", celular)
            cmb.Parameters.AddWithValue("@Correo", correo)
            cmb.Parameters.AddWithValue("@Usuario", usuario)
            If cmb.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try
    End Function

    Public Function mostrar()
        Try
            conexion.Open()
            cmb = New SqlCommand("mostrar", conexion)
            cmb.CommandType = CommandType.StoredProcedure

            cmb.Connection = conexion

            If cmb.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmb)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            conexion.Close()
        End Try
    End Function

    Public Function modificar(Id As String, nombre As String, apellido As String, identidad As String, sexo As String, celular As String, correo As String, usuario As String)
        Try
            conexion.Open()
            cmb = New SqlCommand("modificar", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@Id", Id)
            cmb.Parameters.AddWithValue("@Nombre", nombre)
            cmb.Parameters.AddWithValue("@Apellido", apellido)
            cmb.Parameters.AddWithValue("@Identidad", identidad)
            cmb.Parameters.AddWithValue("@Sexo", sexo)
            cmb.Parameters.AddWithValue("@Celular", celular)
            cmb.Parameters.AddWithValue("@Correo", correo)
            cmb.Parameters.AddWithValue("@Usuario", usuario)
            If cmb.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try

    End Function

    Public Function eliminar(Id As String)
        Try
            conexion.Open()
            cmb = New SqlCommand("eliminar", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@Id", Id)
            If cmb.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try
    End Function

End Class
