Public Class Form1

    Private analysisType As String
    Private gender As String
    Private value As Double

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBoxAnalysis.Items.Add("Red blood cells")
        ComboBoxAnalysis.Items.Add("Hemoglobin")
        ComboBoxAnalysis.Items.Add("Hematocrit")
        ComboBoxAnalysis.Items.Add("Leukocytes")
        ComboBoxAnalysis.Items.Add("MCV")
        ComboBoxAnalysis.Items.Add("MCHC")
        ComboBoxAnalysis.Items.Add("Platelets")

        ComboBoxGender.Items.Add("Male")
        ComboBoxGender.Items.Add("Female")
    End Sub

    Private Sub BSubmit_Click(sender As Object, e As EventArgs) Handles BSubmit.Click

        Dim valueString As Double
        'almacenamos los valores del dropdown en variables
        analysisType = ComboBoxAnalysis.SelectedItem.ToString() 'acá se asigna valor a la variable
        gender = ComboBoxGender.SelectedItem.ToString()
        valueString = textValue.Text
        value = Double.Parse(valueString)
        Dim result As String = calculate(analysisType, gender, value)

        lblResultado.Text = result
    End Sub

    Private Function calculate(analysisType As String, gender As String, value As Double)
        ' hematíes
        If (analysisType = "Red blood cells" AndAlso gender = "Male" AndAlso value >= 4.25 AndAlso value <= 5.9) OrElse
           (analysisType = "Red blood cells" AndAlso gender = "Female" AndAlso value >= 4.1 AndAlso value <= 5.1) OrElse
           (analysisType = "Hemoglobin" AndAlso gender = "Male" AndAlso value >= 14 AndAlso value <= 17.5) OrElse
           (analysisType = "Hemoglobin" AndAlso gender = "Female" AndAlso value >= 12.3 AndAlso value <= 15.3) OrElse
           (analysisType = "Hematocrit" AndAlso gender = "Male" AndAlso value >= 42.0 AndAlso value <= 50.0) OrElse
           (analysisType = "Hematocrit" AndAlso gender = "Female" AndAlso value >= 36.0 AndAlso value <= 45.0) OrElse
           (analysisType = "Leukocytes" AndAlso gender = "Male" AndAlso value >= 4.4 AndAlso value <= 11.3) OrElse
           (analysisType = "Leukocytes" AndAlso gender = "Female" AndAlso value >= 4.4 AndAlso value <= 11.3) OrElse
           (analysisType = "MCV" AndAlso gender = "Male" AndAlso value >= 80.0 AndAlso value <= 96.1) OrElse
           (analysisType = "MCV" AndAlso gender = "Female" AndAlso value >= 80.0 AndAlso value <= 96.1) OrElse
           (analysisType = "MCHC" AndAlso gender = "Male" AndAlso value >= 33.4 AndAlso value <= 35.5) OrElse
           (analysisType = "MCHC" AndAlso gender = "Female" AndAlso value >= 33.4 AndAlso value <= 35.5) OrElse
           (analysisType = "Platelets" AndAlso gender = "Male" AndAlso value >= 172 AndAlso value <= 450) OrElse
           (analysisType = "Platelets" AndAlso gender = "Female" AndAlso value >= 172 AndAlso value <= 450) Then
            Return "Standard"
        Else
            Return "Altered"
        End If

    End Function
End Class
