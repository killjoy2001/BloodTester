Public Class Form1
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

    Private Sub ComboBoxAnalysis_SelectedIndexChanged(sender As Object, e As EventArgs)
        ' aquí se pone el evento del primer combo box
    End Sub

    Private Sub ComboBoxGender_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

End Class
