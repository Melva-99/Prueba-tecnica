<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Apellido = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.Sexo = New System.Windows.Forms.Label()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtCel = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.cmbSexo = New System.Windows.Forms.ComboBox()
        Me.dgDatos = New System.Windows.Forms.DataGridView()
        CType(Me.dgDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(86, 79)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(178, 20)
        Me.txtName.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre"
        '
        'Apellido
        '
        Me.Apellido.AutoSize = True
        Me.Apellido.Location = New System.Drawing.Point(28, 146)
        Me.Apellido.Name = "Apellido"
        Me.Apellido.Size = New System.Drawing.Size(44, 13)
        Me.Apellido.TabIndex = 3
        Me.Apellido.Text = "Apellido"
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(86, 143)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(178, 20)
        Me.txtApellido.TabIndex = 2
        '
        'Sexo
        '
        Me.Sexo.AutoSize = True
        Me.Sexo.Location = New System.Drawing.Point(591, 85)
        Me.Sexo.Name = "Sexo"
        Me.Sexo.Size = New System.Drawing.Size(31, 13)
        Me.Sexo.TabIndex = 5
        Me.Sexo.Text = "Sexo"
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(357, 143)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(185, 20)
        Me.txtCorreo.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(297, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Correo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(297, 207)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "User"
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(357, 207)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(185, 20)
        Me.txtUser.TabIndex = 9
        '
        'txtCel
        '
        Me.txtCel.Location = New System.Drawing.Point(357, 82)
        Me.txtCel.Name = "txtCel"
        Me.txtCel.Size = New System.Drawing.Size(185, 20)
        Me.txtCel.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(297, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Celular"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(86, 207)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(178, 20)
        Me.txtId.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 207)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Identidad"
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAgregar.Location = New System.Drawing.Point(598, 178)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(81, 42)
        Me.btnAgregar.TabIndex = 14
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnModificar.Location = New System.Drawing.Point(717, 178)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(80, 42)
        Me.btnModificar.TabIndex = 15
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.Red
        Me.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnEliminar.Location = New System.Drawing.Point(836, 178)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 42)
        Me.btnEliminar.TabIndex = 16
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'cmbSexo
        '
        Me.cmbSexo.FormattingEnabled = True
        Me.cmbSexo.Location = New System.Drawing.Point(649, 82)
        Me.cmbSexo.Name = "cmbSexo"
        Me.cmbSexo.Size = New System.Drawing.Size(178, 21)
        Me.cmbSexo.TabIndex = 17
        '
        'dgDatos
        '
        Me.dgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDatos.Location = New System.Drawing.Point(55, 279)
        Me.dgDatos.Name = "dgDatos"
        Me.dgDatos.ReadOnly = True
        Me.dgDatos.Size = New System.Drawing.Size(840, 208)
        Me.dgDatos.TabIndex = 18
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(967, 499)
        Me.Controls.Add(Me.dgDatos)
        Me.Controls.Add(Me.cmbSexo)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Sexo)
        Me.Controls.Add(Me.txtCorreo)
        Me.Controls.Add(Me.Apellido)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtName)
        Me.Name = "Form1"
        Me.Text = "Usuarios"
        CType(Me.dgDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Apellido As Label
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents Sexo As Label
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtCel As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents cmbSexo As ComboBox
    Friend WithEvents dgDatos As DataGridView
End Class
