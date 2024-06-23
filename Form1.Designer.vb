<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        tabControlMain = New TabControl()
        tabPageAtenciones = New TabPage()
        dgvAtenciones = New DataGridView()
        btnBuscarAtencion = New Button()
        btnEliminarAtencion = New Button()
        btnActualizarAtencion = New Button()
        btnGuardarAtencion = New Button()
        cbAtencionActividad = New ComboBox()
        cbAtencionEspecialidad = New ComboBox()
        cbAtencionMedico = New ComboBox()
        lblAtencionActividad = New Label()
        lblAtencionEspecialidad = New Label()
        lblAtencionMedico = New Label()
        cbAtencionPaciente = New ComboBox()
        lblAtencionPaciente = New Label()
        dtpAtencionFecha = New DateTimePicker()
        lblAtencionFecha = New Label()
        tabPagePacientes = New TabPage()
        dgvPacientes = New DataGridView()
        btnBuscarPaciente = New Button()
        btnEliminarPaciente = New Button()
        btnActualizarPaciente = New Button()
        btnGuardarPaciente = New Button()
        txtPacienteNombre = New TextBox()
        lblPacienteNombre = New Label()
        tabPageMedicos = New TabPage()
        cbMedicoEspecialidad = New ComboBox()
        lblMedicoEspecialidad = New Label()
        dgvMedicos = New DataGridView()
        btnBuscarMedico = New Button()
        btnEliminarMedico = New Button()
        btnActualizarMedico = New Button()
        btnGuardarMedico = New Button()
        txtMedicoNombre = New TextBox()
        lblMedicoNombre = New Label()
        tabPageEspecialidades = New TabPage()
        dgvEspecialidades = New DataGridView()
        btnBuscarEspecialidad = New Button()
        btnEliminarEspecialidad = New Button()
        btnActualizarEspecialidad = New Button()
        btnGuardarEspecialidad = New Button()
        txtEspecialidadNombre = New TextBox()
        lblEspecialidadNombre = New Label()
        tabPageActividades = New TabPage()
        dgvActividades = New DataGridView()
        btnBuscarActividad = New Button()
        btnEliminarActividad = New Button()
        btnActualizarActividad = New Button()
        btnGuardarActividad = New Button()
        txtActividadNombre = New TextBox()
        lblActividadNombre = New Label()
        tabControlMain.SuspendLayout()
        tabPageAtenciones.SuspendLayout()
        CType(dgvAtenciones, ComponentModel.ISupportInitialize).BeginInit()
        tabPagePacientes.SuspendLayout()
        CType(dgvPacientes, ComponentModel.ISupportInitialize).BeginInit()
        tabPageMedicos.SuspendLayout()
        CType(dgvMedicos, ComponentModel.ISupportInitialize).BeginInit()
        tabPageEspecialidades.SuspendLayout()
        CType(dgvEspecialidades, ComponentModel.ISupportInitialize).BeginInit()
        tabPageActividades.SuspendLayout()
        CType(dgvActividades, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' tabControlMain
        ' 
        tabControlMain.Controls.Add(tabPageAtenciones)
        tabControlMain.Controls.Add(tabPagePacientes)
        tabControlMain.Controls.Add(tabPageMedicos)
        tabControlMain.Controls.Add(tabPageEspecialidades)
        tabControlMain.Controls.Add(tabPageActividades)
        tabControlMain.Location = New Point(12, 12)
        tabControlMain.Name = "tabControlMain"
        tabControlMain.SelectedIndex = 0
        tabControlMain.Size = New Size(729, 426)
        tabControlMain.TabIndex = 0
        ' 
        ' tabPageAtenciones
        ' 
        tabPageAtenciones.Controls.Add(dgvAtenciones)
        tabPageAtenciones.Controls.Add(btnBuscarAtencion)
        tabPageAtenciones.Controls.Add(btnEliminarAtencion)
        tabPageAtenciones.Controls.Add(btnActualizarAtencion)
        tabPageAtenciones.Controls.Add(btnGuardarAtencion)
        tabPageAtenciones.Controls.Add(cbAtencionActividad)
        tabPageAtenciones.Controls.Add(cbAtencionEspecialidad)
        tabPageAtenciones.Controls.Add(cbAtencionMedico)
        tabPageAtenciones.Controls.Add(lblAtencionActividad)
        tabPageAtenciones.Controls.Add(lblAtencionEspecialidad)
        tabPageAtenciones.Controls.Add(lblAtencionMedico)
        tabPageAtenciones.Controls.Add(cbAtencionPaciente)
        tabPageAtenciones.Controls.Add(lblAtencionPaciente)
        tabPageAtenciones.Controls.Add(dtpAtencionFecha)
        tabPageAtenciones.Controls.Add(lblAtencionFecha)
        tabPageAtenciones.Location = New Point(4, 24)
        tabPageAtenciones.Name = "tabPageAtenciones"
        tabPageAtenciones.Padding = New Padding(3)
        tabPageAtenciones.Size = New Size(721, 398)
        tabPageAtenciones.TabIndex = 0
        tabPageAtenciones.Text = "Atenciones"
        tabPageAtenciones.UseVisualStyleBackColor = True
        ' 
        ' dgvAtenciones
        ' 
        dgvAtenciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvAtenciones.Location = New Point(35, 142)
        dgvAtenciones.Name = "dgvAtenciones"
        dgvAtenciones.Size = New Size(653, 221)
        dgvAtenciones.TabIndex = 14
        ' 
        ' btnBuscarAtencion
        ' 
        btnBuscarAtencion.Location = New Point(613, 369)
        btnBuscarAtencion.Name = "btnBuscarAtencion"
        btnBuscarAtencion.Size = New Size(75, 23)
        btnBuscarAtencion.TabIndex = 13
        btnBuscarAtencion.Text = "Buscar"
        btnBuscarAtencion.UseVisualStyleBackColor = True
        ' 
        ' btnEliminarAtencion
        ' 
        btnEliminarAtencion.Location = New Point(532, 369)
        btnEliminarAtencion.Name = "btnEliminarAtencion"
        btnEliminarAtencion.Size = New Size(75, 23)
        btnEliminarAtencion.TabIndex = 12
        btnEliminarAtencion.Text = "Eliminar"
        btnEliminarAtencion.UseVisualStyleBackColor = True
        ' 
        ' btnActualizarAtencion
        ' 
        btnActualizarAtencion.Location = New Point(451, 369)
        btnActualizarAtencion.Name = "btnActualizarAtencion"
        btnActualizarAtencion.Size = New Size(75, 23)
        btnActualizarAtencion.TabIndex = 11
        btnActualizarAtencion.Text = "Actualizar"
        btnActualizarAtencion.UseVisualStyleBackColor = True
        ' 
        ' btnGuardarAtencion
        ' 
        btnGuardarAtencion.Location = New Point(370, 369)
        btnGuardarAtencion.Name = "btnGuardarAtencion"
        btnGuardarAtencion.Size = New Size(75, 23)
        btnGuardarAtencion.TabIndex = 10
        btnGuardarAtencion.Text = "Guardar"
        btnGuardarAtencion.UseVisualStyleBackColor = True
        ' 
        ' cbAtencionActividad
        ' 
        cbAtencionActividad.FormattingEnabled = True
        cbAtencionActividad.Location = New Point(411, 86)
        cbAtencionActividad.Name = "cbAtencionActividad"
        cbAtencionActividad.Size = New Size(136, 23)
        cbAtencionActividad.TabIndex = 9
        ' 
        ' cbAtencionEspecialidad
        ' 
        cbAtencionEspecialidad.FormattingEnabled = True
        cbAtencionEspecialidad.Location = New Point(411, 57)
        cbAtencionEspecialidad.Name = "cbAtencionEspecialidad"
        cbAtencionEspecialidad.Size = New Size(136, 23)
        cbAtencionEspecialidad.TabIndex = 8
        ' 
        ' cbAtencionMedico
        ' 
        cbAtencionMedico.FormattingEnabled = True
        cbAtencionMedico.Location = New Point(96, 86)
        cbAtencionMedico.Name = "cbAtencionMedico"
        cbAtencionMedico.Size = New Size(150, 23)
        cbAtencionMedico.TabIndex = 7
        ' 
        ' lblAtencionActividad
        ' 
        lblAtencionActividad.AutoSize = True
        lblAtencionActividad.Location = New Point(330, 89)
        lblAtencionActividad.Name = "lblAtencionActividad"
        lblAtencionActividad.Size = New Size(60, 15)
        lblAtencionActividad.TabIndex = 6
        lblAtencionActividad.Text = "Actividad:"
        ' 
        ' lblAtencionEspecialidad
        ' 
        lblAtencionEspecialidad.AutoSize = True
        lblAtencionEspecialidad.Location = New Point(330, 60)
        lblAtencionEspecialidad.Name = "lblAtencionEspecialidad"
        lblAtencionEspecialidad.Size = New Size(75, 15)
        lblAtencionEspecialidad.TabIndex = 5
        lblAtencionEspecialidad.Text = "Especialidad:"
        ' 
        ' lblAtencionMedico
        ' 
        lblAtencionMedico.AutoSize = True
        lblAtencionMedico.Location = New Point(35, 89)
        lblAtencionMedico.Name = "lblAtencionMedico"
        lblAtencionMedico.Size = New Size(50, 15)
        lblAtencionMedico.TabIndex = 4
        lblAtencionMedico.Text = "Medico:"
        ' 
        ' cbAtencionPaciente
        ' 
        cbAtencionPaciente.FormattingEnabled = True
        cbAtencionPaciente.Location = New Point(96, 57)
        cbAtencionPaciente.Name = "cbAtencionPaciente"
        cbAtencionPaciente.Size = New Size(150, 23)
        cbAtencionPaciente.TabIndex = 3
        ' 
        ' lblAtencionPaciente
        ' 
        lblAtencionPaciente.AutoSize = True
        lblAtencionPaciente.Location = New Point(35, 60)
        lblAtencionPaciente.Name = "lblAtencionPaciente"
        lblAtencionPaciente.Size = New Size(55, 15)
        lblAtencionPaciente.TabIndex = 2
        lblAtencionPaciente.Text = "Paciente:"
        ' 
        ' dtpAtencionFecha
        ' 
        dtpAtencionFecha.Location = New Point(96, 28)
        dtpAtencionFecha.Name = "dtpAtencionFecha"
        dtpAtencionFecha.Size = New Size(215, 23)
        dtpAtencionFecha.TabIndex = 1
        ' 
        ' lblAtencionFecha
        ' 
        lblAtencionFecha.AutoSize = True
        lblAtencionFecha.Location = New Point(35, 34)
        lblAtencionFecha.Name = "lblAtencionFecha"
        lblAtencionFecha.Size = New Size(41, 15)
        lblAtencionFecha.TabIndex = 0
        lblAtencionFecha.Text = "Fecha:"
        ' 
        ' tabPagePacientes
        ' 
        tabPagePacientes.Controls.Add(dgvPacientes)
        tabPagePacientes.Controls.Add(btnBuscarPaciente)
        tabPagePacientes.Controls.Add(btnEliminarPaciente)
        tabPagePacientes.Controls.Add(btnActualizarPaciente)
        tabPagePacientes.Controls.Add(btnGuardarPaciente)
        tabPagePacientes.Controls.Add(txtPacienteNombre)
        tabPagePacientes.Controls.Add(lblPacienteNombre)
        tabPagePacientes.Location = New Point(4, 24)
        tabPagePacientes.Name = "tabPagePacientes"
        tabPagePacientes.Padding = New Padding(3)
        tabPagePacientes.Size = New Size(721, 398)
        tabPagePacientes.TabIndex = 1
        tabPagePacientes.Text = "Pacientes"
        tabPagePacientes.UseVisualStyleBackColor = True
        ' 
        ' dgvPacientes
        ' 
        dgvPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPacientes.Location = New Point(31, 103)
        dgvPacientes.Name = "dgvPacientes"
        dgvPacientes.Size = New Size(318, 260)
        dgvPacientes.TabIndex = 18
        ' 
        ' btnBuscarPaciente
        ' 
        btnBuscarPaciente.Location = New Point(274, 74)
        btnBuscarPaciente.Name = "btnBuscarPaciente"
        btnBuscarPaciente.Size = New Size(75, 23)
        btnBuscarPaciente.TabIndex = 17
        btnBuscarPaciente.Text = "Buscar"
        btnBuscarPaciente.UseVisualStyleBackColor = True
        ' 
        ' btnEliminarPaciente
        ' 
        btnEliminarPaciente.Location = New Point(193, 74)
        btnEliminarPaciente.Name = "btnEliminarPaciente"
        btnEliminarPaciente.Size = New Size(75, 23)
        btnEliminarPaciente.TabIndex = 16
        btnEliminarPaciente.Text = "Eliminar"
        btnEliminarPaciente.UseVisualStyleBackColor = True
        ' 
        ' btnActualizarPaciente
        ' 
        btnActualizarPaciente.Location = New Point(112, 74)
        btnActualizarPaciente.Name = "btnActualizarPaciente"
        btnActualizarPaciente.Size = New Size(75, 23)
        btnActualizarPaciente.TabIndex = 15
        btnActualizarPaciente.Text = "Actualizar"
        btnActualizarPaciente.UseVisualStyleBackColor = True
        ' 
        ' btnGuardarPaciente
        ' 
        btnGuardarPaciente.Location = New Point(31, 74)
        btnGuardarPaciente.Name = "btnGuardarPaciente"
        btnGuardarPaciente.Size = New Size(75, 23)
        btnGuardarPaciente.TabIndex = 14
        btnGuardarPaciente.Text = "Guardar"
        btnGuardarPaciente.UseVisualStyleBackColor = True
        ' 
        ' txtPacienteNombre
        ' 
        txtPacienteNombre.Location = New Point(112, 38)
        txtPacienteNombre.Name = "txtPacienteNombre"
        txtPacienteNombre.Size = New Size(156, 23)
        txtPacienteNombre.TabIndex = 1
        ' 
        ' lblPacienteNombre
        ' 
        lblPacienteNombre.AutoSize = True
        lblPacienteNombre.Location = New Point(31, 41)
        lblPacienteNombre.Name = "lblPacienteNombre"
        lblPacienteNombre.Size = New Size(54, 15)
        lblPacienteNombre.TabIndex = 0
        lblPacienteNombre.Text = "Nombre:"
        ' 
        ' tabPageMedicos
        ' 
        tabPageMedicos.Controls.Add(cbMedicoEspecialidad)
        tabPageMedicos.Controls.Add(lblMedicoEspecialidad)
        tabPageMedicos.Controls.Add(dgvMedicos)
        tabPageMedicos.Controls.Add(btnBuscarMedico)
        tabPageMedicos.Controls.Add(btnEliminarMedico)
        tabPageMedicos.Controls.Add(btnActualizarMedico)
        tabPageMedicos.Controls.Add(btnGuardarMedico)
        tabPageMedicos.Controls.Add(txtMedicoNombre)
        tabPageMedicos.Controls.Add(lblMedicoNombre)
        tabPageMedicos.Location = New Point(4, 24)
        tabPageMedicos.Name = "tabPageMedicos"
        tabPageMedicos.Padding = New Padding(3)
        tabPageMedicos.Size = New Size(721, 398)
        tabPageMedicos.TabIndex = 2
        tabPageMedicos.Text = "Médicos"
        tabPageMedicos.UseVisualStyleBackColor = True
        ' 
        ' cbMedicoEspecialidad
        ' 
        cbMedicoEspecialidad.FormattingEnabled = True
        cbMedicoEspecialidad.Location = New Point(124, 63)
        cbMedicoEspecialidad.Name = "cbMedicoEspecialidad"
        cbMedicoEspecialidad.Size = New Size(156, 23)
        cbMedicoEspecialidad.TabIndex = 27
        ' 
        ' lblMedicoEspecialidad
        ' 
        lblMedicoEspecialidad.AutoSize = True
        lblMedicoEspecialidad.Location = New Point(43, 66)
        lblMedicoEspecialidad.Name = "lblMedicoEspecialidad"
        lblMedicoEspecialidad.Size = New Size(75, 15)
        lblMedicoEspecialidad.TabIndex = 26
        lblMedicoEspecialidad.Text = "Especialidad:"
        ' 
        ' dgvMedicos
        ' 
        dgvMedicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMedicos.Location = New Point(43, 121)
        dgvMedicos.Name = "dgvMedicos"
        dgvMedicos.Size = New Size(375, 246)
        dgvMedicos.TabIndex = 25
        ' 
        ' btnBuscarMedico
        ' 
        btnBuscarMedico.Location = New Point(286, 92)
        btnBuscarMedico.Name = "btnBuscarMedico"
        btnBuscarMedico.Size = New Size(75, 23)
        btnBuscarMedico.TabIndex = 24
        btnBuscarMedico.Text = "Buscar"
        btnBuscarMedico.UseVisualStyleBackColor = True
        ' 
        ' btnEliminarMedico
        ' 
        btnEliminarMedico.Location = New Point(205, 92)
        btnEliminarMedico.Name = "btnEliminarMedico"
        btnEliminarMedico.Size = New Size(75, 23)
        btnEliminarMedico.TabIndex = 23
        btnEliminarMedico.Text = "Eliminar"
        btnEliminarMedico.UseVisualStyleBackColor = True
        ' 
        ' btnActualizarMedico
        ' 
        btnActualizarMedico.Location = New Point(124, 92)
        btnActualizarMedico.Name = "btnActualizarMedico"
        btnActualizarMedico.Size = New Size(75, 23)
        btnActualizarMedico.TabIndex = 22
        btnActualizarMedico.Text = "Actualizar"
        btnActualizarMedico.UseVisualStyleBackColor = True
        ' 
        ' btnGuardarMedico
        ' 
        btnGuardarMedico.Location = New Point(43, 92)
        btnGuardarMedico.Name = "btnGuardarMedico"
        btnGuardarMedico.Size = New Size(75, 23)
        btnGuardarMedico.TabIndex = 21
        btnGuardarMedico.Text = "Guardar"
        btnGuardarMedico.UseVisualStyleBackColor = True
        ' 
        ' txtMedicoNombre
        ' 
        txtMedicoNombre.Location = New Point(124, 34)
        txtMedicoNombre.Name = "txtMedicoNombre"
        txtMedicoNombre.Size = New Size(156, 23)
        txtMedicoNombre.TabIndex = 20
        ' 
        ' lblMedicoNombre
        ' 
        lblMedicoNombre.AutoSize = True
        lblMedicoNombre.Location = New Point(43, 37)
        lblMedicoNombre.Name = "lblMedicoNombre"
        lblMedicoNombre.Size = New Size(54, 15)
        lblMedicoNombre.TabIndex = 19
        lblMedicoNombre.Text = "Nombre:"
        ' 
        ' tabPageEspecialidades
        ' 
        tabPageEspecialidades.Controls.Add(dgvEspecialidades)
        tabPageEspecialidades.Controls.Add(btnBuscarEspecialidad)
        tabPageEspecialidades.Controls.Add(btnEliminarEspecialidad)
        tabPageEspecialidades.Controls.Add(btnActualizarEspecialidad)
        tabPageEspecialidades.Controls.Add(btnGuardarEspecialidad)
        tabPageEspecialidades.Controls.Add(txtEspecialidadNombre)
        tabPageEspecialidades.Controls.Add(lblEspecialidadNombre)
        tabPageEspecialidades.Location = New Point(4, 24)
        tabPageEspecialidades.Name = "tabPageEspecialidades"
        tabPageEspecialidades.Padding = New Padding(3)
        tabPageEspecialidades.Size = New Size(721, 398)
        tabPageEspecialidades.TabIndex = 3
        tabPageEspecialidades.Text = "Especialidades"
        tabPageEspecialidades.UseVisualStyleBackColor = True
        ' 
        ' dgvEspecialidades
        ' 
        dgvEspecialidades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvEspecialidades.Location = New Point(33, 92)
        dgvEspecialidades.Name = "dgvEspecialidades"
        dgvEspecialidades.Size = New Size(318, 274)
        dgvEspecialidades.TabIndex = 25
        ' 
        ' btnBuscarEspecialidad
        ' 
        btnBuscarEspecialidad.Location = New Point(276, 63)
        btnBuscarEspecialidad.Name = "btnBuscarEspecialidad"
        btnBuscarEspecialidad.Size = New Size(75, 23)
        btnBuscarEspecialidad.TabIndex = 24
        btnBuscarEspecialidad.Text = "Buscar"
        btnBuscarEspecialidad.UseVisualStyleBackColor = True
        ' 
        ' btnEliminarEspecialidad
        ' 
        btnEliminarEspecialidad.Location = New Point(195, 63)
        btnEliminarEspecialidad.Name = "btnEliminarEspecialidad"
        btnEliminarEspecialidad.Size = New Size(75, 23)
        btnEliminarEspecialidad.TabIndex = 23
        btnEliminarEspecialidad.Text = "Eliminar"
        btnEliminarEspecialidad.UseVisualStyleBackColor = True
        ' 
        ' btnActualizarEspecialidad
        ' 
        btnActualizarEspecialidad.Location = New Point(114, 63)
        btnActualizarEspecialidad.Name = "btnActualizarEspecialidad"
        btnActualizarEspecialidad.Size = New Size(75, 23)
        btnActualizarEspecialidad.TabIndex = 22
        btnActualizarEspecialidad.Text = "Actualizar"
        btnActualizarEspecialidad.UseVisualStyleBackColor = True
        ' 
        ' btnGuardarEspecialidad
        ' 
        btnGuardarEspecialidad.Location = New Point(33, 63)
        btnGuardarEspecialidad.Name = "btnGuardarEspecialidad"
        btnGuardarEspecialidad.Size = New Size(75, 23)
        btnGuardarEspecialidad.TabIndex = 21
        btnGuardarEspecialidad.Text = "Guardar"
        btnGuardarEspecialidad.UseVisualStyleBackColor = True
        ' 
        ' txtEspecialidadNombre
        ' 
        txtEspecialidadNombre.Location = New Point(114, 27)
        txtEspecialidadNombre.Name = "txtEspecialidadNombre"
        txtEspecialidadNombre.Size = New Size(156, 23)
        txtEspecialidadNombre.TabIndex = 20
        ' 
        ' lblEspecialidadNombre
        ' 
        lblEspecialidadNombre.AutoSize = True
        lblEspecialidadNombre.Location = New Point(33, 30)
        lblEspecialidadNombre.Name = "lblEspecialidadNombre"
        lblEspecialidadNombre.Size = New Size(54, 15)
        lblEspecialidadNombre.TabIndex = 19
        lblEspecialidadNombre.Text = "Nombre:"
        ' 
        ' tabPageActividades
        ' 
        tabPageActividades.Controls.Add(dgvActividades)
        tabPageActividades.Controls.Add(btnBuscarActividad)
        tabPageActividades.Controls.Add(btnEliminarActividad)
        tabPageActividades.Controls.Add(btnActualizarActividad)
        tabPageActividades.Controls.Add(btnGuardarActividad)
        tabPageActividades.Controls.Add(txtActividadNombre)
        tabPageActividades.Controls.Add(lblActividadNombre)
        tabPageActividades.Location = New Point(4, 24)
        tabPageActividades.Name = "tabPageActividades"
        tabPageActividades.Padding = New Padding(3)
        tabPageActividades.Size = New Size(721, 398)
        tabPageActividades.TabIndex = 4
        tabPageActividades.Text = "Actividades"
        tabPageActividades.UseVisualStyleBackColor = True
        ' 
        ' dgvActividades
        ' 
        dgvActividades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvActividades.Location = New Point(33, 89)
        dgvActividades.Name = "dgvActividades"
        dgvActividades.Size = New Size(318, 274)
        dgvActividades.TabIndex = 32
        ' 
        ' btnBuscarActividad
        ' 
        btnBuscarActividad.Location = New Point(276, 60)
        btnBuscarActividad.Name = "btnBuscarActividad"
        btnBuscarActividad.Size = New Size(75, 23)
        btnBuscarActividad.TabIndex = 31
        btnBuscarActividad.Text = "Buscar"
        btnBuscarActividad.UseVisualStyleBackColor = True
        ' 
        ' btnEliminarActividad
        ' 
        btnEliminarActividad.Location = New Point(195, 60)
        btnEliminarActividad.Name = "btnEliminarActividad"
        btnEliminarActividad.Size = New Size(75, 23)
        btnEliminarActividad.TabIndex = 30
        btnEliminarActividad.Text = "Eliminar"
        btnEliminarActividad.UseVisualStyleBackColor = True
        ' 
        ' btnActualizarActividad
        ' 
        btnActualizarActividad.Location = New Point(114, 60)
        btnActualizarActividad.Name = "btnActualizarActividad"
        btnActualizarActividad.Size = New Size(75, 23)
        btnActualizarActividad.TabIndex = 29
        btnActualizarActividad.Text = "Actualizar"
        btnActualizarActividad.UseVisualStyleBackColor = True
        ' 
        ' btnGuardarActividad
        ' 
        btnGuardarActividad.Location = New Point(33, 60)
        btnGuardarActividad.Name = "btnGuardarActividad"
        btnGuardarActividad.Size = New Size(75, 23)
        btnGuardarActividad.TabIndex = 28
        btnGuardarActividad.Text = "Guardar"
        btnGuardarActividad.UseVisualStyleBackColor = True
        ' 
        ' txtActividadNombre
        ' 
        txtActividadNombre.Location = New Point(114, 24)
        txtActividadNombre.Name = "txtActividadNombre"
        txtActividadNombre.Size = New Size(156, 23)
        txtActividadNombre.TabIndex = 27
        ' 
        ' lblActividadNombre
        ' 
        lblActividadNombre.AutoSize = True
        lblActividadNombre.Location = New Point(33, 27)
        lblActividadNombre.Name = "lblActividadNombre"
        lblActividadNombre.Size = New Size(54, 15)
        lblActividadNombre.TabIndex = 26
        lblActividadNombre.Text = "Nombre:"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(753, 450)
        Controls.Add(tabControlMain)
        Name = "Form1"
        Text = "Registro de Atenciones"
        tabControlMain.ResumeLayout(False)
        tabPageAtenciones.ResumeLayout(False)
        tabPageAtenciones.PerformLayout()
        CType(dgvAtenciones, ComponentModel.ISupportInitialize).EndInit()
        tabPagePacientes.ResumeLayout(False)
        tabPagePacientes.PerformLayout()
        CType(dgvPacientes, ComponentModel.ISupportInitialize).EndInit()
        tabPageMedicos.ResumeLayout(False)
        tabPageMedicos.PerformLayout()
        CType(dgvMedicos, ComponentModel.ISupportInitialize).EndInit()
        tabPageEspecialidades.ResumeLayout(False)
        tabPageEspecialidades.PerformLayout()
        CType(dgvEspecialidades, ComponentModel.ISupportInitialize).EndInit()
        tabPageActividades.ResumeLayout(False)
        tabPageActividades.PerformLayout()
        CType(dgvActividades, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents tabControlMain As TabControl
    Friend WithEvents tabPageAtenciones As TabPage
    Friend WithEvents tabPagePacientes As TabPage
    Friend WithEvents tabPageMedicos As TabPage
    Friend WithEvents tabPageEspecialidades As TabPage
    Friend WithEvents tabPageActividades As TabPage
    Friend WithEvents dtpAtencionFecha As DateTimePicker
    Friend WithEvents lblAtencionFecha As Label
    Friend WithEvents lblAtencionPaciente As Label
    Friend WithEvents cbAtencionActividad As ComboBox
    Friend WithEvents cbAtencionEspecialidad As ComboBox
    Friend WithEvents cbAtencionMedico As ComboBox
    Friend WithEvents lblAtencionActividad As Label
    Friend WithEvents lblAtencionEspecialidad As Label
    Friend WithEvents lblAtencionMedico As Label
    Friend WithEvents cbAtencionPaciente As ComboBox
    Friend WithEvents dgvAtenciones As DataGridView
    Friend WithEvents btnBuscarAtencion As Button
    Friend WithEvents btnEliminarAtencion As Button
    Friend WithEvents btnActualizarAtencion As Button
    Friend WithEvents btnGuardarAtencion As Button
    Friend WithEvents dgvPacientes As DataGridView
    Friend WithEvents btnBuscarPaciente As Button
    Friend WithEvents btnEliminarPaciente As Button
    Friend WithEvents btnActualizarPaciente As Button
    Friend WithEvents btnGuardarPaciente As Button
    Friend WithEvents txtPacienteNombre As TextBox
    Friend WithEvents lblPacienteNombre As Label
    Friend WithEvents cbMedicoEspecialidad As ComboBox
    Friend WithEvents lblMedicoEspecialidad As Label
    Friend WithEvents dgvMedicos As DataGridView
    Friend WithEvents btnBuscarMedico As Button
    Friend WithEvents btnEliminarMedico As Button
    Friend WithEvents btnActualizarMedico As Button
    Friend WithEvents btnGuardarMedico As Button
    Friend WithEvents txtMedicoNombre As TextBox
    Friend WithEvents lblMedicoNombre As Label
    Friend WithEvents dgvEspecialidades As DataGridView
    Friend WithEvents btnBuscarEspecialidad As Button
    Friend WithEvents btnEliminarEspecialidad As Button
    Friend WithEvents btnActualizarEspecialidad As Button
    Friend WithEvents btnGuardarEspecialidad As Button
    Friend WithEvents txtEspecialidadNombre As TextBox
    Friend WithEvents lblEspecialidadNombre As Label
    Friend WithEvents dgvActividades As DataGridView
    Friend WithEvents btnBuscarActividad As Button
    Friend WithEvents btnEliminarActividad As Button
    Friend WithEvents btnActualizarActividad As Button
    Friend WithEvents btnGuardarActividad As Button
    Friend WithEvents txtActividadNombre As TextBox
    Friend WithEvents lblActividadNombre As Label

End Class
