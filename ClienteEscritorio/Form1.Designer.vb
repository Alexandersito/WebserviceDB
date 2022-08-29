<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCodEscuela = New System.Windows.Forms.TextBox()
        Me.txtLugNac = New System.Windows.Forms.TextBox()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.txtApellidos = New System.Windows.Forms.TextBox()
        Me.txtCodAlumno = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.cbBuscar = New System.Windows.Forms.ComboBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.gvAlumno = New System.Windows.Forms.DataGridView()
        Me.dtpFecNac = New System.Windows.Forms.DateTimePicker()
        CType(Me.gvAlumno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(343, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mantenimiento para alumno"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "CodAlumno"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Apellidos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nombres"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(40, 213)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "LugNac"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(40, 259)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "FecNac"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(40, 303)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "CodEscuela"
        '
        'txtCodEscuela
        '
        Me.txtCodEscuela.Location = New System.Drawing.Point(176, 303)
        Me.txtCodEscuela.Name = "txtCodEscuela"
        Me.txtCodEscuela.Size = New System.Drawing.Size(166, 22)
        Me.txtCodEscuela.TabIndex = 7
        '
        'txtLugNac
        '
        Me.txtLugNac.Location = New System.Drawing.Point(176, 208)
        Me.txtLugNac.Name = "txtLugNac"
        Me.txtLugNac.Size = New System.Drawing.Size(166, 22)
        Me.txtLugNac.TabIndex = 9
        '
        'txtNombres
        '
        Me.txtNombres.Location = New System.Drawing.Point(176, 162)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(166, 22)
        Me.txtNombres.TabIndex = 10
        '
        'txtApellidos
        '
        Me.txtApellidos.Location = New System.Drawing.Point(176, 114)
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(166, 22)
        Me.txtApellidos.TabIndex = 11
        '
        'txtCodAlumno
        '
        Me.txtCodAlumno.Location = New System.Drawing.Point(176, 71)
        Me.txtCodAlumno.Name = "txtCodAlumno"
        Me.txtCodAlumno.Size = New System.Drawing.Size(166, 22)
        Me.txtCodAlumno.TabIndex = 12
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(43, 350)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(92, 44)
        Me.btnAgregar.TabIndex = 13
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(337, 350)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(92, 44)
        Me.btnLimpiar.TabIndex = 14
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(141, 350)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(92, 44)
        Me.btnActualizar.TabIndex = 15
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(239, 350)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(92, 44)
        Me.btnEliminar.TabIndex = 16
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(45, 414)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 17)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Buscar"
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(112, 414)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(166, 22)
        Me.txtBuscar.TabIndex = 18
        '
        'cbBuscar
        '
        Me.cbBuscar.FormattingEnabled = True
        Me.cbBuscar.Items.AddRange(New Object() {"codAlumno", "alumno"})
        Me.cbBuscar.Location = New System.Drawing.Point(304, 414)
        Me.cbBuscar.Name = "cbBuscar"
        Me.cbBuscar.Size = New System.Drawing.Size(121, 24)
        Me.cbBuscar.TabIndex = 19
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(444, 403)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(92, 44)
        Me.btnBuscar.TabIndex = 20
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'gvAlumno
        '
        Me.gvAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gvAlumno.Location = New System.Drawing.Point(43, 463)
        Me.gvAlumno.Name = "gvAlumno"
        Me.gvAlumno.RowHeadersWidth = 51
        Me.gvAlumno.RowTemplate.Height = 24
        Me.gvAlumno.Size = New System.Drawing.Size(782, 216)
        Me.gvAlumno.TabIndex = 21
        '
        'dtpFecNac
        '
        Me.dtpFecNac.Location = New System.Drawing.Point(176, 254)
        Me.dtpFecNac.Name = "dtpFecNac"
        Me.dtpFecNac.Size = New System.Drawing.Size(234, 22)
        Me.dtpFecNac.TabIndex = 22
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(874, 691)
        Me.Controls.Add(Me.dtpFecNac)
        Me.Controls.Add(Me.gvAlumno)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.cbBuscar)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.txtCodAlumno)
        Me.Controls.Add(Me.txtApellidos)
        Me.Controls.Add(Me.txtNombres)
        Me.Controls.Add(Me.txtLugNac)
        Me.Controls.Add(Me.txtCodEscuela)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.gvAlumno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCodEscuela As TextBox
    Friend WithEvents txtLugNac As TextBox
    Friend WithEvents txtNombres As TextBox
    Friend WithEvents txtApellidos As TextBox
    Friend WithEvents txtCodAlumno As TextBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents cbBuscar As ComboBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents gvAlumno As DataGridView
    Friend WithEvents dtpFecNac As DateTimePicker
End Class
