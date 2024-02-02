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
    End Sub
End Class
