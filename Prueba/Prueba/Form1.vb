Public Class Form1
    Dim conexion As New conexion()
    Dim dt As New DataTable
    Dim sql As String

    Private Sub limpiar()
        txtName.Clear()
        txtApellido.Clear()
        txtId.Clear()
        cmbSexo.SelectedValue = 0
        txtCel.Clear()
        txtCorreo.Clear()
        txtUser.Clear()
    End Sub
    Private Sub insertar()
        Dim idSexo As Object = cmbSexo.SelectedValue
        Dim sexo As String

        sexo = Convert.ToString(idSexo)

        Dim nombre As String = StrConv(txtName.Text, VbStrConv.ProperCase)
        Dim apellido As String = StrConv(txtApellido.Text, VbStrConv.ProperCase)
        Dim identidad As String = txtId.Text
        Dim fksexo = sexo
        Dim celular As String = txtCel.Text
        Dim correo As String = txtCorreo.Text
        Dim usuario As String = txtUser.Text

        Try
            If conexion.insertar(nombre, apellido, identidad, fksexo, celular, correo, usuario) Then
                MessageBox.Show("Ingresado correctamente", "Hecho!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                limpiar()
            Else
                MessageBox.Show("Error al registrar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        insertar()
        mostrar()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
        sql = "select * From Sexos"
        conexion.llenarcbm(sql, cmbSexo)

    End Sub

    Private Sub mostrar()
        Try
            Dim func As New conexion
            dt = func.mostrar
            If dt.Rows.Count <> 0 Then
                dgDatos.DataSource = dt
                dgDatos.ColumnHeadersVisible = True
            Else
                dgDatos.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub modificar()
        Dim Fila = dgDatos.CurrentRow.Index
        Dim Id As Integer = dgDatos.Rows(Fila).Cells(0).Value
        Dim idSexo As Object = cmbSexo.SelectedValue
        Dim sexo As String

        sexo = Convert.ToString(idSexo)

        Dim nombre As String = StrConv(txtName.Text, VbStrConv.ProperCase)
        Dim apellido As String = StrConv(txtApellido.Text, VbStrConv.ProperCase)
        Dim identidad As String = txtId.Text
        Dim fksexo = sexo
        Dim celular As String = txtCel.Text
        Dim correo As String = txtCorreo.Text
        Dim usuario As String = txtUser.Text

        Try
            If conexion.modificar(Id, nombre, apellido, identidad, fksexo, celular, correo, usuario) Then
                MessageBox.Show("Modificado correctamente", "Hecho!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                limpiar()
                mostrar()
            Else
                MessageBox.Show("Error al modificar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgDatos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgDatos.CellClick
        Dim Fila = dgDatos.CurrentRow.Index
        Try
            txtName.Text = dgDatos.Rows(Fila).Cells(1).Value
            txtApellido.Text = dgDatos.Rows(Fila).Cells(2).Value
            txtId.Text = dgDatos.Rows(Fila).Cells(3).Value
            cmbSexo.Text = dgDatos.Rows(Fila).Cells(4).Value
            txtCel.Text = dgDatos.Rows(Fila).Cells(5).Value
            txtCorreo.Text = dgDatos.Rows(Fila).Cells(6).Value
            txtUser.Text = dgDatos.Rows(Fila).Cells(7).Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        modificar()
    End Sub

    Private Sub eliminar()
        Dim Fila = dgDatos.CurrentRow.Index
        Dim Id As Integer = dgDatos.Rows(Fila).Cells(0).Value
        Try
            If conexion.eliminar(Id) Then
                MessageBox.Show("El Usuario ha sido eliminado.", "Hecho!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                limpiar()
                mostrar()
            Else
                MessageBox.Show("Error al eliminar el usuario.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        eliminar()
    End Sub
End Class
