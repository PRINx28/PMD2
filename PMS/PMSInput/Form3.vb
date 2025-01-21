Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports PMSsearch2


Public Class Form3

    Private connectionString As String = "Server=10.0.1.26;Port=3306;Database=propertymanagementdatabase;Uid=longlong;Pwd=Cy[ltM)yUqZ[W/Vc;"

    Private Sub TextBoxAC_TextChanged(sender As Object, e As EventArgs) Handles TextBoxAC.TextChanged

    End Sub

    Private Sub LabelDesc_Click(sender As Object, e As EventArgs) Handles LabelDesc.Click

    End Sub

    Private Sub LabelSc_Click(sender As Object, e As EventArgs) Handles LabelSc.Click

    End Sub

    Private Sub LabelQty_Click(sender As Object, e As EventArgs) Handles LabelQty.Click

    End Sub

    Private Sub TextBoxPR_TextChanged(sender As Object, e As EventArgs) Handles TextBoxPR.TextChanged

    End Sub

    Private Sub LabelOffice_Click(sender As Object, e As EventArgs) Handles LabelOffice.Click

    End Sub

    Private Sub TextBoxOffice_TextChanged(sender As Object, e As EventArgs) Handles TextBoxOffice.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private imagePath As String = String.Empty

    Private Sub ButtonInsertPhoto_Click(sender As Object, e As EventArgs) Handles ButtonInsertPhoto.Click
        ' Create an instance of OpenFileDialog
        Using openFileDialog As New OpenFileDialog()
            ' Set the filter for image files
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
            openFileDialog.Title = "Select an Image"

            ' Show the dialog and check if the user selected a file
            If openFileDialog.ShowDialog() = DialogResult.OK Then
                ' Get the path of the selected file
                imagePath = openFileDialog.FileName
                ' Load the image into the PictureBox
                PictureBox.Image = Image.FromFile(imagePath)
                ' Set the SizeMode to StretchImage to fit the PictureBox
                PictureBox.SizeMode = PictureBoxSizeMode.StretchImage
            End If
        End Using
    End Sub

    Private Sub PictureBox_Click(sender As Object, e As EventArgs) Handles PictureBox.Click
        ' You can add any functionality you want when the PictureBox is clicked
        MessageBox.Show("You clicked the PictureBox!")
    End Sub

    Private Sub TextBoxFund_TextChanged(sender As Object, e As EventArgs) Handles TextBoxFund.TextChanged

    End Sub

    Private Sub TextBoxCategory_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBoxSc_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub RichTextBoxDesc_TextChanged(sender As Object, e As EventArgs) Handles RichTextBoxDesc.TextChanged

    End Sub

    Private Sub TextBoxDop_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBoxIIN_TextChanged(sender As Object, e As EventArgs) Handles TextBoxIIN.TextChanged

    End Sub

    Private Sub TextBoxPoN_TextChanged(sender As Object, e As EventArgs) Handles TextBoxPoN.TextChanged

    End Sub

    Private Sub TextBoxUnit_TextChanged(sender As Object, e As EventArgs) Handles TextBoxUnit.TextChanged

    End Sub

    Private Sub TextBoxQty_TextChanged(sender As Object, e As EventArgs) Handles TextBoxQty.TextChanged

    End Sub

    Private Sub TextBoxUV_TextChanged(sender As Object, e As EventArgs) Handles TextBoxUV.TextChanged

    End Sub

    Private Sub TextBoxUHC_TextChanged(sender As Object, e As EventArgs) Handles TextBoxUHC.TextChanged

    End Sub

    Private Sub TextBoxOHV_TextChanged(sender As Object, e As EventArgs) Handles TextBoxOHV.TextChanged

    End Sub

    Private Sub RichTextBoxAI_TextChanged(sender As Object, e As EventArgs) Handles RichTextBoxAI.TextChanged

    End Sub

    Private Sub RichTextBoxRemarks_TextChanged(sender As Object, e As EventArgs) Handles RichTextBoxRemarks.TextChanged

    End Sub

    Private Sub DateTimePickerDoP_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerDoP.ValueChanged

    End Sub

    Private Sub ComboBoxCat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCat.SelectedIndexChanged

    End Sub

    Private Sub ComboBoxSubCat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxSubCat.SelectedIndexChanged

    End Sub

    'Private Sub ButtonBack_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click
    '    Dim Form2 As New Form2()
    '    Form2.Show()
    '    Me.Hide()
    'End Sub


    Private Sub ButtonInsert_Click(sender As Object, e As EventArgs) Handles ButtonInsert.Click

        Using connection As New MySqlConnection(connectionString)

            Try
                ' Open the connection
                connection.Open()

                ' SQL Insert query
                Dim query As String = "INSERT INTO tblproperty (AccountCode, DateOfPurchase, Qty, Office, Fund, InventoryItemNo, Category, Subcategory, Unit, UnitValue, UnitHandCount, OnHandValue, Description, AdditionalInfo, Remarks, PersonResponsible, ImagePath) " &
                                      "VALUES (@AccountCode, @DateOfPurchase, @Qty, @Office, @Fund, @InventoryItemNo, @Category, @PONO, @Subcategory, @Unit, @UnitValue, @UnitHandCount, @OnHandValue, @Description, @AdditionalInfo, @Remarks, @PersonResponsible, @ImagePath)"

                ' Create the command
                Using command As New MySqlCommand(query, connection)
                    ' Add parameters
                    command.Parameters.AddWithValue("@AccountCode", TextBoxAC.Text)
                    command.Parameters.AddWithValue("@DateOfPurchase", DateTimePickerDoP.Value)
                    command.Parameters.AddWithValue("@Qty", Integer.Parse(TextBoxQty.Text))
                    command.Parameters.AddWithValue("@Office", TextBoxOffice.Text)
                    command.Parameters.AddWithValue("@Fund", TextBoxFund.Text)
                    command.Parameters.AddWithValue("@InventoryItemNo", TextBoxIIN.Text)
                    command.Parameters.AddWithValue("@Category", ComboBoxCat.Text)
                    command.Parameters.AddWithValue("@PONO", TextBoxPoN.Text)
                    command.Parameters.AddWithValue("@Subcategory", ComboBoxSubCat.Text)
                    command.Parameters.AddWithValue("@Unit", TextBoxUnit.Text)
                    command.Parameters.AddWithValue("@UnitValue", Decimal.Parse(TextBoxUV.Text))
                    command.Parameters.AddWithValue("@UnitHandCount", Integer.Parse(TextBoxUHC.Text))
                    command.Parameters.AddWithValue("@OnHandValue", Decimal.Parse(TextBoxOHV.Text))
                    command.Parameters.AddWithValue("@Description", RichTextBoxDesc.Text)
                    command.Parameters.AddWithValue("@AdditionalInfo", RichTextBoxAI.Text)
                    command.Parameters.AddWithValue("@Remarks", RichTextBoxRemarks.Text)
                    command.Parameters.AddWithValue("@PersonResponsible", TextBoxPR.Text)
                    command.Parameters.AddWithValue("@ImagePath", imagePath)

                    ' Execute the command
                    command.ExecuteNonQuery()

                    ' Inform the user
                    MessageBox.Show("Data successfully inserted!")
                End Using
            Catch ex As Exception
                ' Handle errors
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try
        End Using
    End Sub


End Class
