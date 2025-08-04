Public Class Form1
    ' Evento que se ejecuta cuando el formulario se carga
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Añadir algunos órganos de ejemplo al ComboBox
        cmbOrganos.Items.Add("Cerebro/Dmax<60")
        cmbOrganos.Items.Add("Cerebro/Dmax=72")
        cmbOrganos.Items.Add("Brainstem/dmax<54")
        cmbOrganos.Items.Add("Brainstem/D0.1cc<=59")
        cmbOrganos.Items.Add("Med.espinal/D0.1cc<=50")
        cmbOrganos.Items.Add("Nerv.Optico/D0.1cc<=54")
        cmbOrganos.Items.Add("Quisma.Optico/D0.1cc<=54")
        cmbOrganos.Items.Add("Ojos/Dmax<54")
        cmbOrganos.Items.Add("Ojos/Dmedia<=35")
        cmbOrganos.Items.Add("Cristalino/D0.1cc<=10")
        cmbOrganos.Items.Add("Coclea/Dmedia<=45")
        cmbOrganos.Items.Add("Coclea/Dmedia<50")
        cmbOrganos.Items.Add("Parotida(s)/Dmedia<=26")
        cmbOrganos.Items.Add("Coclea/Dmedia<=45")
        cmbOrganos.Items.Add("Tiroides/Dmedia<=45")
        cmbOrganos.Items.Add("Laringe/Dmedia<=45")
        cmbOrganos.Items.Add("Laringe/Dmax<66")
        cmbOrganos.Items.Add("Esófago/Dmedia<34")
        cmbOrganos.Items.Add("Esófago/V40%<50")
        cmbOrganos.Items.Add("Mandibula/D0.1cc<=70")
        cmbOrganos.Items.Add("Cavidad oral/V73%<30")
        cmbOrganos.Items.Add("Labios/Dmedia<=50")
        cmbOrganos.Items.Add("Gland.Pituitaria/Dmax<=50")
        cmbOrganos.Items.Add("Pulmones/V30%<20")
        cmbOrganos.Items.Add("Corazón/Dmedia<26")
        cmbOrganos.Items.Add("Corazón/V30%<46")
        cmbOrganos.Items.Add("Liver/Dmedia<=32")
        cmbOrganos.Items.Add("Riñones/Dmedia<=18")
        cmbOrganos.Items.Add("Estomago/Dmedia<=45")
        cmbOrganos.Items.Add("Intestino/D195cc<=45")
        cmbOrganos.Items.Add("Recto/V50%<=50")
        cmbOrganos.Items.Add("Vejiga/V50%<=65")
        cmbOrganos.Items.Add("Cabez.Femoral/Dmax<=54")
        cmbOrganos.Items.Add("Cabez.Femoral/V10%<=50")

        ' Configurar colores del formulario y controles
        ConfigurarColores()
    End Sub

    ' Función para configurar los colores del formulario y controles
    Private Sub ConfigurarColores()
        ' Fondo del formulario
        Me.BackColor = Color.FromArgb(45, 45, 45) ' Fondo oscuro
        Me.ForeColor = Color.White ' Texto blanco

        ' Configurar colores del ComboBox
        cmbOrganos.BackColor = Color.FromArgb(60, 60, 60)
        cmbOrganos.ForeColor = Color.White

        ' Configurar colores de los TextBox
        txtValorConstraint.BackColor = Color.FromArgb(60, 60, 60)
        txtValorConstraint.ForeColor = Color.White
        txtAlphaBeta.BackColor = Color.FromArgb(60, 60, 60)
        txtAlphaBeta.ForeColor = Color.White
        txtEQD2Organo.BackColor = Color.FromArgb(60, 60, 60)
        txtEQD2Organo.ForeColor = Color.White
        txtBEDOrgano.BackColor = Color.FromArgb(60, 60, 60)
        txtBEDOrgano.ForeColor = Color.White
        txtDosisFisica.BackColor = Color.FromArgb(60, 60, 60)
        txtDosisFisica.ForeColor = Color.White
        txtSesiones.BackColor = Color.FromArgb(60, 60, 60)
        txtSesiones.ForeColor = Color.White
        txtEQD2Calculado.BackColor = Color.FromArgb(60, 60, 60)
        txtEQD2Calculado.ForeColor = Color.White
        txtBEDCalculado.BackColor = Color.FromArgb(60, 60, 60)
        txtBEDCalculado.ForeColor = Color.White

        ' Configurar colores del botón
        btnCalcular.BackColor = Color.FromArgb(0, 120, 215) ' Azul
        btnCalcular.ForeColor = Color.White
        btnCalcular.FlatStyle = FlatStyle.Flat
        btnCalcular.FlatAppearance.BorderSize = 0

        ' Configurar colores de las etiquetas (Labels)
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is Label Then
                ctrl.ForeColor = Color.White
            End If
        Next
    End Sub

    ' Evento que se ejecuta cuando se selecciona un órgano en el ComboBox
    Private Sub cmbOrganos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbOrganos.SelectedIndexChanged
        ' Extraer el valor de "Constraint" de la descripción del órgano seleccionado
        Dim selectedOrgan As String = cmbOrganos.SelectedItem.ToString()
        Dim constraintValue As Double = ExtraerConstraint(selectedOrgan)

        ' Mostrar el valor de "Constraint" en el TextBox correspondiente
        txtValorConstraint.Text = constraintValue.ToString()

        ' Calcular EQD2 y BED del órgano basado en el valor de alfa/beta ingresado
        CalcularEQD2yBEDOrgano()
    End Sub

    ' Función para extraer el valor de "Constraint" de la descripción del órgano
    Private Function ExtraerConstraint(organDescription As String) As Double
        ' Buscar el valor de "Constraint" en la descripción (por ejemplo, "dmax=50", "v30%<20", "dmax>=55")
        Dim constraintPart As String = organDescription.Split("/"c)(1) ' Obtener la parte después de "/"
        Dim constraintValue As Double

        ' Extraer el número del texto, independientemente del operador (<, >, <=, >=, =)
        Dim operators As String() = {"<=", ">=", "<", ">", "="}
        For Each op As String In operators
            If constraintPart.Contains(op) Then
                Dim valueText As String = constraintPart.Split(op)(1)
                If Double.TryParse(valueText, constraintValue) Then
                    Return constraintValue
                End If
            End If
        Next

        Return 0 ' Si no se encuentra un valor válido, devolver 0
    End Function

    ' Evento que se ejecuta cuando se cambia el valor de alfa/beta
    Private Sub txtAlphaBeta_TextChanged(sender As Object, e As EventArgs) Handles txtAlphaBeta.TextChanged
        ' Calcular EQD2 y BED del órgano basado en el valor de alfa/beta ingresado
        CalcularEQD2yBEDOrgano()
    End Sub

    ' Función para calcular EQD2 y BED del órgano basado en el valor de alfa/beta
    Private Sub CalcularEQD2yBEDOrgano()
        ' Verificar si se ha ingresado un valor válido para alfa/beta
        If Not Double.TryParse(txtAlphaBeta.Text, Nothing) Then
            txtEQD2Organo.Text = "0.00"
            txtBEDOrgano.Text = "0.00"
            Return
        End If

        ' Obtener el valor de alfa/beta
        Dim alphaBetaRatio As Double = Double.Parse(txtAlphaBeta.Text)

        ' Obtener el valor de "Constraint" del órgano seleccionado
        Dim constraint As Double
        If Double.TryParse(txtValorConstraint.Text, constraint) Then
            ' Fórmulas para EQD2 y BED del órgano
            Dim EQD2Organo As Double = constraint * (2 + alphaBetaRatio) / (2 + alphaBetaRatio)
            Dim BEDOrgano As Double = constraint * (1 + 2 / alphaBetaRatio)

            ' Mostrar los valores calculados en los TextBox correspondientes
            txtEQD2Organo.Text = EQD2Organo.ToString("F2")
            txtBEDOrgano.Text = BEDOrgano.ToString("F2")
        Else
            txtEQD2Organo.Text = "0.00"
            txtBEDOrgano.Text = "0.00"
        End If
    End Sub

    ' Evento que se ejecuta cuando se hace clic en el botón Calcular
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        ' Verificar si se han ingresado valores válidos
        If Not Double.TryParse(txtDosisFisica.Text, Nothing) Or Not Integer.TryParse(txtSesiones.Text, Nothing) Or Not Double.TryParse(txtAlphaBeta.Text, Nothing) Then
            MessageBox.Show("Por favor, ingrese valores válidos para la dosis física, número de sesiones y alfa/beta.")
            Return
        End If

        ' Obtener los valores ingresados por el usuario
        Dim dosisFisica As Double = Double.Parse(txtDosisFisica.Text)
        Dim sesiones As Integer = Integer.Parse(txtSesiones.Text)
        Dim alphaBetaRatio As Double = Double.Parse(txtAlphaBeta.Text)

        ' Calcular la dosis por fracción
        Dim dosisPorFraccion As Double = dosisFisica / sesiones

        ' Calcular EQD2 y BED
        Dim EQD2 As Double = dosisPorFraccion * (dosisPorFraccion + alphaBetaRatio) / (2 + alphaBetaRatio) * sesiones
        Dim BED As Double = dosisPorFraccion * sesiones * (1 + dosisPorFraccion / alphaBetaRatio)

        ' Mostrar los valores calculados en los TextBox correspondientes
        txtEQD2Calculado.Text = EQD2.ToString("F2")
        txtBEDCalculado.Text = BED.ToString("F2")
    End Sub
End Class