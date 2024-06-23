Imports System.Data.SqlClient

Public Class Form1

    Dim connectionString As String = "Data Source=DESKTOP-FRBT9HC;Initial Catalog=ClinicaDB;Integrated Security=True"
    Dim connection As SqlConnection = New SqlConnection(connectionString)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadComboBoxes()
        LoadDataGrids()
    End Sub

    Private Sub LoadComboBoxes()
        LoadComboBox("SELECT * FROM Especialidades", cbMedicoEspecialidad, "Nombre", "EspecialidadID")
        LoadComboBox("SELECT * FROM Pacientes", cbAtencionPaciente, "Nombre", "PacienteID")
        LoadComboBox("SELECT * FROM Medicos", cbAtencionMedico, "Nombre", "MedicoID")
        LoadComboBox("SELECT * FROM Especialidades", cbAtencionEspecialidad, "Nombre", "EspecialidadID")
        LoadComboBox("SELECT * FROM Actividades", cbAtencionActividad, "Nombre", "ActividadID")
    End Sub

    Private Sub LoadComboBox(query As String, comboBox As ComboBox, displayMember As String, valueMember As String)
        Dim adapter As SqlDataAdapter = New SqlDataAdapter(query, connection)
        Dim table As DataTable = New DataTable()
        adapter.Fill(table)
        comboBox.DataSource = table
        comboBox.DisplayMember = displayMember
        comboBox.ValueMember = valueMember
    End Sub

    Private Sub LoadDataGrids()
        LoadDataGrid("SELECT * FROM Medicos", dgvMedicos)
        LoadDataGrid("SELECT * FROM Pacientes", dgvPacientes)
        LoadDataGrid("SELECT * FROM Especialidades", dgvEspecialidades)
        LoadDataGrid("SELECT * FROM Actividades", dgvActividades)
        LoadAtenciones()
    End Sub

    Private Sub LoadDataGrid(query As String, dataGridView As DataGridView)
        Dim adapter As SqlDataAdapter = New SqlDataAdapter(query, connection)
        Dim table As DataTable = New DataTable()
        adapter.Fill(table)
        dataGridView.DataSource = table
    End Sub

    Private Sub LoadAtenciones()
        Dim query As String = "SELECT Atenciones.AtencionID, Atenciones.Fecha, Pacientes.Nombre AS Paciente, Medicos.Nombre AS Medico, Especialidades.Nombre AS Especialidad, Actividades.Nombre AS Actividad 
                               FROM Atenciones 
                               INNER JOIN Pacientes ON Atenciones.PacienteID = Pacientes.PacienteID 
                               INNER JOIN Medicos ON Atenciones.MedicoID = Medicos.MedicoID 
                               INNER JOIN Especialidades ON Atenciones.EspecialidadID = Especialidades.EspecialidadID 
                               INNER JOIN Actividades ON Atenciones.ActividadID = Actividades.ActividadID"
        Dim adapter As SqlDataAdapter = New SqlDataAdapter(query, connection)
        Dim table As DataTable = New DataTable()
        adapter.Fill(table)
        dgvAtenciones.DataSource = table
    End Sub

    ' CRUD para Médicos
    Private Sub btnGuardarMedico_Click(sender As Object, e As EventArgs) Handles btnGuardarMedico.Click
        Dim query As String = "INSERT INTO Medicos (Nombre, EspecialidadID) VALUES (@Nombre, @EspecialidadID)"
        Using command As SqlCommand = New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@Nombre", txtMedicoNombre.Text)
            command.Parameters.AddWithValue("@EspecialidadID", cbMedicoEspecialidad.SelectedValue)
            connection.Open()
            command.ExecuteNonQuery()
            connection.Close()
        End Using
        LoadDataGrid("SELECT * FROM Medicos", dgvMedicos)
    End Sub

    Private Sub btnActualizarMedico_Click(sender As Object, e As EventArgs) Handles btnActualizarMedico.Click
        If dgvMedicos.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dgvMedicos.SelectedRows(0)
            Dim medicoID As Integer = selectedRow.Cells("MedicoID").Value
            Dim query As String = "UPDATE Medicos SET Nombre = @Nombre, EspecialidadID = @EspecialidadID WHERE MedicoID = @MedicoID"
            Using command As SqlCommand = New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@MedicoID", medicoID)
                command.Parameters.AddWithValue("@Nombre", txtMedicoNombre.Text)
                command.Parameters.AddWithValue("@EspecialidadID", cbMedicoEspecialidad.SelectedValue)
                connection.Open()
                command.ExecuteNonQuery()
                connection.Close()
            End Using
            LoadDataGrid("SELECT * FROM Medicos", dgvMedicos)
        End If
    End Sub

    Private Sub btnEliminarMedico_Click(sender As Object, e As EventArgs) Handles btnEliminarMedico.Click
        If dgvMedicos.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dgvMedicos.SelectedRows(0)
            Dim medicoID As Integer = selectedRow.Cells("MedicoID").Value
            Dim query As String = "DELETE FROM Medicos WHERE MedicoID = @MedicoID"
            Using command As SqlCommand = New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@MedicoID", medicoID)
                connection.Open()
                command.ExecuteNonQuery()
                connection.Close()
            End Using
            LoadDataGrid("SELECT * FROM Medicos", dgvMedicos)
        End If
    End Sub

    Private Sub btnBuscarMedico_Click(sender As Object, e As EventArgs) Handles btnBuscarMedico.Click
        Dim query As String = "SELECT * FROM Medicos WHERE Nombre LIKE '%' + @Nombre + '%'"
        Using command As SqlCommand = New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@Nombre", txtMedicoNombre.Text)
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(command)
            Dim table As DataTable = New DataTable()
            adapter.Fill(table)
            dgvMedicos.DataSource = table
        End Using
    End Sub

    ' CRUD para Pacientes
    Private Sub btnGuardarPaciente_Click(sender As Object, e As EventArgs) Handles btnGuardarPaciente.Click
        Dim query As String = "INSERT INTO Pacientes (Nombre) VALUES (@Nombre)"
        Using command As SqlCommand = New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@Nombre", txtPacienteNombre.Text)
            connection.Open()
            command.ExecuteNonQuery()
            connection.Close()
        End Using
        LoadDataGrid("SELECT * FROM Pacientes", dgvPacientes)
    End Sub

    Private Sub btnActualizarPaciente_Click(sender As Object, e As EventArgs) Handles btnActualizarPaciente.Click
        If dgvPacientes.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dgvPacientes.SelectedRows(0)
            Dim pacienteID As Integer = selectedRow.Cells("PacienteID").Value
            Dim query As String = "UPDATE Pacientes SET Nombre = @Nombre WHERE PacienteID = @PacienteID"
            Using command As SqlCommand = New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@PacienteID", pacienteID)
                command.Parameters.AddWithValue("@Nombre", txtPacienteNombre.Text)
                connection.Open()
                command.ExecuteNonQuery()
                connection.Close()
            End Using
            LoadDataGrid("SELECT * FROM Pacientes", dgvPacientes)
        End If
    End Sub

    Private Sub btnEliminarPaciente_Click(sender As Object, e As EventArgs) Handles btnEliminarPaciente.Click
        If dgvPacientes.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dgvPacientes.SelectedRows(0)
            Dim pacienteID As Integer = selectedRow.Cells("PacienteID").Value
            Dim query As String = "DELETE FROM Pacientes WHERE PacienteID = @PacienteID"
            Using command As SqlCommand = New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@PacienteID", pacienteID)
                connection.Open()
                command.ExecuteNonQuery()
                connection.Close()
            End Using
            LoadDataGrid("SELECT * FROM Pacientes", dgvPacientes)
        End If
    End Sub

    Private Sub btnBuscarPaciente_Click(sender As Object, e As EventArgs) Handles btnBuscarPaciente.Click
        Dim query As String = "SELECT * FROM Pacientes WHERE Nombre LIKE '%' + @Nombre + '%'"
        Using command As SqlCommand = New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@Nombre", txtPacienteNombre.Text)
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(command)
            Dim table As DataTable = New DataTable()
            adapter.Fill(table)
            dgvPacientes.DataSource = table
        End Using
    End Sub

    ' CRUD para Especialidades
    Private Sub btnGuardarEspecialidad_Click(sender As Object, e As EventArgs) Handles btnGuardarEspecialidad.Click
        Dim query As String = "INSERT INTO Especialidades (Nombre) VALUES (@Nombre)"
        Using command As SqlCommand = New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@Nombre", txtEspecialidadNombre.Text)
            connection.Open()
            command.ExecuteNonQuery()
            connection.Close()
        End Using
        LoadDataGrid("SELECT * FROM Especialidades", dgvEspecialidades)
    End Sub

    Private Sub btnActualizarEspecialidad_Click(sender As Object, e As EventArgs) Handles btnActualizarEspecialidad.Click
        If dgvEspecialidades.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dgvEspecialidades.SelectedRows(0)
            Dim especialidadID As Integer = selectedRow.Cells("EspecialidadID").Value
            Dim query As String = "UPDATE Especialidades SET Nombre = @Nombre WHERE EspecialidadID = @EspecialidadID"
            Using command As SqlCommand = New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@EspecialidadID", especialidadID)
                command.Parameters.AddWithValue("@Nombre", txtEspecialidadNombre.Text)
                connection.Open()
                command.ExecuteNonQuery()
                connection.Close()
            End Using
            LoadDataGrid("SELECT * FROM Especialidades", dgvEspecialidades)
        End If
    End Sub

    Private Sub btnEliminarEspecialidad_Click(sender As Object, e As EventArgs) Handles btnEliminarEspecialidad.Click
        If dgvEspecialidades.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dgvEspecialidades.SelectedRows(0)
            Dim especialidadID As Integer = selectedRow.Cells("EspecialidadID").Value
            Dim query As String = "DELETE FROM Especialidades WHERE EspecialidadID = @EspecialidadID"
            Using command As SqlCommand = New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@EspecialidadID", especialidadID)
                connection.Open()
                command.ExecuteNonQuery()
                connection.Close()
            End Using
            LoadDataGrid("SELECT * FROM Especialidades", dgvEspecialidades)
        End If
    End Sub

    Private Sub btnBuscarEspecialidad_Click(sender As Object, e As EventArgs) Handles btnBuscarEspecialidad.Click
        Dim query As String = "SELECT * FROM Especialidades WHERE Nombre LIKE '%' + @Nombre + '%'"
        Using command As SqlCommand = New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@Nombre", txtEspecialidadNombre.Text)
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(command)
            Dim table As DataTable = New DataTable()
            adapter.Fill(table)
            dgvEspecialidades.DataSource = table
        End Using
    End Sub

    ' CRUD para Actividades
    Private Sub btnGuardarActividad_Click(sender As Object, e As EventArgs) Handles btnGuardarActividad.Click
        Dim query As String = "INSERT INTO Actividades (Nombre) VALUES (@Nombre)"
        Using command As SqlCommand = New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@Nombre", txtActividadNombre.Text)
            connection.Open()
            command.ExecuteNonQuery()
            connection.Close()
        End Using
        LoadDataGrid("SELECT * FROM Actividades", dgvActividades)
    End Sub

    Private Sub btnActualizarActividad_Click(sender As Object, e As EventArgs) Handles btnActualizarActividad.Click
        If dgvActividades.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dgvActividades.SelectedRows(0)
            Dim actividadID As Integer = selectedRow.Cells("ActividadID").Value
            Dim query As String = "UPDATE Actividades SET Nombre = @Nombre WHERE ActividadID = @ActividadID"
            Using command As SqlCommand = New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@ActividadID", actividadID)
                command.Parameters.AddWithValue("@Nombre", txtActividadNombre.Text)
                connection.Open()
                command.ExecuteNonQuery()
                connection.Close()
            End Using
            LoadDataGrid("SELECT * FROM Actividades", dgvActividades)
        End If
    End Sub

    Private Sub btnEliminarActividad_Click(sender As Object, e As EventArgs) Handles btnEliminarActividad.Click
        If dgvActividades.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dgvActividades.SelectedRows(0)
            Dim actividadID As Integer = selectedRow.Cells("ActividadID").Value
            Dim query As String = "DELETE FROM Actividades WHERE ActividadID = @ActividadID"
            Using command As SqlCommand = New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@ActividadID", actividadID)
                connection.Open()
                command.ExecuteNonQuery()
                connection.Close()
            End Using
            LoadDataGrid("SELECT * FROM Actividades", dgvActividades)
        End If
    End Sub

    Private Sub btnBuscarActividad_Click(sender As Object, e As EventArgs) Handles btnBuscarActividad.Click
        Dim query As String = "SELECT * FROM Actividades WHERE Nombre LIKE '%' + @Nombre + '%'"
        Using command As SqlCommand = New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@Nombre", txtActividadNombre.Text)
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(command)
            Dim table As DataTable = New DataTable()
            adapter.Fill(table)
            dgvActividades.DataSource = table
        End Using
    End Sub

    ' CRUD para Atenciones
    Private Sub btnGuardarAtencion_Click(sender As Object, e As EventArgs) Handles btnGuardarAtencion.Click
        Dim query As String = "INSERT INTO Atenciones (Fecha, PacienteID, MedicoID, EspecialidadID, ActividadID) 
                               VALUES (@Fecha, @PacienteID, @MedicoID, @EspecialidadID, @ActividadID)"
        Using command As SqlCommand = New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@Fecha", dtpAtencionFecha.Value)
            command.Parameters.AddWithValue("@PacienteID", cbAtencionPaciente.SelectedValue)
            command.Parameters.AddWithValue("@MedicoID", cbAtencionMedico.SelectedValue)
            command.Parameters.AddWithValue("@EspecialidadID", cbAtencionEspecialidad.SelectedValue)
            command.Parameters.AddWithValue("@ActividadID", cbAtencionActividad.SelectedValue)
            connection.Open()
            command.ExecuteNonQuery()
            connection.Close()
        End Using
        LoadAtenciones()
    End Sub

    Private Sub btnActualizarAtencion_Click(sender As Object, e As EventArgs) Handles btnActualizarAtencion.Click
        If dgvAtenciones.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dgvAtenciones.SelectedRows(0)
            Dim atencionID As Integer = selectedRow.Cells("AtencionID").Value
            Dim query As String = "UPDATE Atenciones SET Fecha = @Fecha, PacienteID = @PacienteID, MedicoID = @MedicoID, EspecialidadID = @EspecialidadID, ActividadID = @ActividadID 
                                   WHERE AtencionID = @AtencionID"
            Using command As SqlCommand = New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@AtencionID", atencionID)
                command.Parameters.AddWithValue("@Fecha", dtpAtencionFecha.Value)
                command.Parameters.AddWithValue("@PacienteID", cbAtencionPaciente.SelectedValue)
                command.Parameters.AddWithValue("@MedicoID", cbAtencionMedico.SelectedValue)
                command.Parameters.AddWithValue("@EspecialidadID", cbAtencionEspecialidad.SelectedValue)
                command.Parameters.AddWithValue("@ActividadID", cbAtencionActividad.SelectedValue)
                connection.Open()
                command.ExecuteNonQuery()
                connection.Close()
            End Using
            LoadAtenciones()
        End If
    End Sub

    Private Sub btnEliminarAtencion_Click(sender As Object, e As EventArgs) Handles btnEliminarAtencion.Click
        If dgvAtenciones.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dgvAtenciones.SelectedRows(0)
            Dim atencionID As Integer = selectedRow.Cells("AtencionID").Value
            Dim query As String = "DELETE FROM Atenciones WHERE AtencionID = @AtencionID"
            Using command As SqlCommand = New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@AtencionID", atencionID)
                connection.Open()
                command.ExecuteNonQuery()
                connection.Close()
            End Using
            LoadAtenciones()
        End If
    End Sub

    Private Sub btnBuscarAtencion_Click(sender As Object, e As EventArgs) Handles btnBuscarAtencion.Click
        Dim query As String = "SELECT Atenciones.AtencionID, Atenciones.Fecha, Pacientes.Nombre AS Paciente, Medicos.Nombre AS Medico, Especialidades.Nombre AS Especialidad, Actividades.Nombre AS Actividad 
                               FROM Atenciones 
                               INNER JOIN Pacientes ON Atenciones.PacienteID = Pacientes.PacienteID 
                               INNER JOIN Medicos ON Atenciones.MedicoID = Medicos.MedicoID 
                               INNER JOIN Especialidades ON Atenciones.EspecialidadID = Especialidades.EspecialidadID 
                               INNER JOIN Actividades ON Atenciones.ActividadID = Actividades.ActividadID
                               WHERE Pacientes.Nombre LIKE '%' + @Paciente + '%' AND Medicos.Nombre LIKE '%' + @Medico + '%' AND Especialidades.Nombre LIKE '%' + @Especialidad + '%' AND Actividades.Nombre LIKE '%' + @Actividad + '%'"
        Using command As SqlCommand = New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@Paciente", cbAtencionPaciente.Text)
            command.Parameters.AddWithValue("@Medico", cbAtencionMedico.Text)
            command.Parameters.AddWithValue("@Especialidad", cbAtencionEspecialidad.Text)
            command.Parameters.AddWithValue("@Actividad", cbAtencionActividad.Text)
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(command)
            Dim table As DataTable = New DataTable()
            adapter.Fill(table)
            dgvAtenciones.DataSource = table
        End Using
    End Sub

End Class
