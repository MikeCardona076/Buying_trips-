Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub Label1_Click(sender As Object, e As EventArgs) Handles Label_Destino.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox_ida.TextChanged

    End Sub


    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button_venta.Click

        Label1.Text = TextBox_destino.Text
        Label2.Text = TextBox_ida.Text
        Label10.Text = TextBox_vuleta.Text
        Label3.Text = "$1,500"

        Label4.Text = "$1,300"
        Label5.Text = TextBox_ida.Text
        Label11.Text = TextBox_vuleta.Text
        Label6.Text = TextBox_destino.Text

        Label7.Text = "$800"
        Label8.Text = TextBox_ida.Text
        Label12.Text = TextBox_vuleta.Text
        Label9.Text = TextBox_destino.Text

        GroupBox1.Show()
        GroupBox2.Show()
        GroupBox3.Show()

        Label13.Text = TextBox_destino.Text
        Label15.Text = TextBox_vuleta.Text
        Label14.Text = TextBox_ida.Text

        Label23.Text = TextBox_vuleta.Text
        Label24.Text = TextBox_ida.Text
        Label25.Text = TextBox_destino.Text

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox_destino.TextChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Operador As Boolean
        Operador = True
        Label_Destino.Hide()
        Label_Horario.Hide()
        Label_ida.Hide()
        Label_vuelta.Hide()
        TextBox_destino.Hide()
        TextBox_ida.Hide()
        TextBox_vuleta.Hide()
        Button_venta.Hide()
        GroupBox1.Hide()
        GroupBox2.Hide()
        GroupBox3.Hide()
        GroupBoxSelected.Show()
        Label16.Text = Label3.Text
        GroupBoxAcompañantes.Show()
        Label13.Text = TextBox_destino.Text
        Label15.Text = TextBox_vuleta.Text
        Label14.Text = TextBox_ida.Text
        Label26.Text = "AeroMike"
        Label27.Text = "AeroMike"
        Label22.Text = Label3.Text
        Label26.Show()

    End Sub

    Private Sub Label_vuelta_Click(sender As Object, e As EventArgs) Handles Label_vuelta.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label_Destino.Hide()
        Label_Horario.Hide()
        Label_ida.Hide()
        Label_vuelta.Hide()
        TextBox_destino.Hide()
        TextBox_ida.Hide()
        TextBox_vuleta.Hide()
        Button_venta.Hide()
        GroupBox1.Hide()
        GroupBox2.Hide()
        GroupBox3.Hide()
        GroupBoxSelected.Show()
        Label16.Text = Label4.Text
        GroupBoxAcompañantes.Show()
        Label13.Text = TextBox_destino.Text
        Label15.Text = TextBox_vuleta.Text
        Label14.Text = TextBox_ida.Text
        Label27.Text = "AeroMexico"
        Label26.Text = "AeroMexico"
        Label22.Text = Label4.Text
        Label26.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label_Destino.Hide()
        Label_Horario.Hide()
        Label_ida.Hide()
        Label_vuelta.Hide()
        TextBox_destino.Hide()
        TextBox_ida.Hide()
        TextBox_vuleta.Hide()
        Button_venta.Hide()
        GroupBox1.Hide()
        GroupBox2.Hide()
        GroupBox3.Hide()
        GroupBoxSelected.Show()
        Label16.Text = Label7.Text
        GroupBoxAcompañantes.Show()
        Label13.Text = TextBox_destino.Text
        Label15.Text = TextBox_vuleta.Text
        Label14.Text = TextBox_ida.Text
        Label27.Text = "Volaris"
        Label26.Text = "Volaris"
        Label22.Text = Label7.Text
        Label26.Show()
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub Label_Horario_Click(sender As Object, e As EventArgs) Handles Label_Horario.Click

    End Sub

    Private Sub Label_ida_Click(sender As Object, e As EventArgs) Handles Label_ida.Click

    End Sub

    Private Sub TextBox_vuleta_TextChanged(sender As Object, e As EventArgs) Handles TextBox_vuleta.TextChanged

    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBoxSelected.Enter

    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click

    End Sub

    Private Sub GroupBoxAcompañantes_Enter(sender As Object, e As EventArgs) Handles GroupBoxAcompañantes.Enter

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            CheckBox2.Hide()
            CheckBox3.Hide()
            CheckBox5.Hide()
            GroupBox4.Show()
            GroupBoxAcompañantes.Hide()
            GroupBoxSelected.Hide()
        End If
        If CheckBox1.Checked = False Then
            CheckBox2.Show()
            CheckBox3.Show()
            CheckBox5.Show()
            GroupBox4.Hide()
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged

        Dim Precio As Integer
        Precio = Label22.Text
        If CheckBox2.Checked = True Then
            CheckBox1.Hide()
            CheckBox3.Hide()
            CheckBox5.Hide()
            GroupBox4.Show()
            Precio = Precio * 2
            Label22.Text = Precio
            GroupBoxAcompañantes.Hide()
            GroupBoxSelected.Hide()
        End If

        If CheckBox2.Checked = False Then
            CheckBox1.Show()
            CheckBox3.Show()
            CheckBox5.Show()
            GroupBox4.Hide()

        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        Dim Precio As Integer
        Precio = Label22.Text
        If CheckBox3.Checked = True Then
            CheckBox1.Hide()
            CheckBox2.Hide()
            CheckBox5.Hide()
            GroupBox4.Show()
            Precio = Precio * 4
            Label22.Text = Precio
            GroupBoxAcompañantes.Hide()
            GroupBoxSelected.Hide()
        End If
        If CheckBox3.Checked = False Then
            CheckBox1.Show()
            CheckBox2.Show()
            CheckBox5.Show()
            GroupBox4.Hide()
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged

        If CheckBox5.Checked = True Then
            TextBox1.Show()
            CheckBox1.Hide()
            CheckBox2.Hide()
            CheckBox3.Hide()
            Button4.Show()
        End If
        If CheckBox5.Checked = False Then
            TextBox1.Hide()
            CheckBox1.Show()
            CheckBox2.Show()
            CheckBox3.Show()
            GroupBox4.Hide()
            Button4.Hide()
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub ButtonRegresar_Click(sender As Object, e As EventArgs) Handles ButtonRegresar.Click
        Label_Destino.Show()
        Label_Horario.Show()
        Label_ida.Show()
        Label_vuelta.Show()
        TextBox_destino.Show()
        TextBox_ida.Show()
        TextBox_vuleta.Show()
        Button_venta.Show()
        GroupBoxSelected.Hide()
        GroupBoxAcompañantes.Hide()
        Label20.Hide()
        TextBox2.Hide()
        GroupBox4.Hide()
        Button6.Hide()
        Label28.Hide()
        Inicio.Hide()
    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click

    End Sub

    Private Sub Label20_Click(sender As Object, e As EventArgs) Handles Label20.Click

    End Sub

    Private Sub TextBox2_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Label25_Click(sender As Object, e As EventArgs) Handles Label25.Click

    End Sub

    Private Sub Label24_Click(sender As Object, e As EventArgs) Handles Label24.Click

    End Sub

    Private Sub Label21_Click(sender As Object, e As EventArgs) Handles Label21.Click

    End Sub

    Private Sub Label23_Click(sender As Object, e As EventArgs) Handles Label23.Click

    End Sub

    Private Sub Label22_Click(sender As Object, e As EventArgs) Handles Label22.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles ButtonComprar.Click
        Label20.Show()
        TextBox2.Show()
        Button6.Show()
    End Sub

    Private Sub GroupBox4_Enter_1(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Dim Precio As Integer
        Precio = TextBox1.Text
        Precio = Precio * Label22.Text
        Label22.Text = Precio
        GroupBox4.Show()
        GroupBoxAcompañantes.Hide()
        GroupBoxSelected.Hide()
    End Sub

    Private Sub Label27_Click(sender As Object, e As EventArgs) Handles Label27.Click

    End Sub

    Private Sub Label26_Click(sender As Object, e As EventArgs) Handles Label26.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Label_Destino.Show()
        Label_Horario.Show()
        Label_ida.Show()
        Label_vuelta.Show()
        TextBox_destino.Show()
        TextBox_ida.Show()
        TextBox_vuleta.Show()
        Button_venta.Show()
        GroupBoxSelected.Hide()
        GroupBoxAcompañantes.Hide()
        Label20.Hide()
        TextBox2.Hide()
        GroupBox4.Hide()
        Button6.Hide()
        Label28.Hide()
        Inicio.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Label20.Hide()
        TextBox2.Hide()
        Label28.Show()
        Inicio.Show()
        Button6.Hide()
        GroupBox4.Hide()
    End Sub

    Private Sub Label28_Click(sender As Object, e As EventArgs) Handles Label28.Click

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Inicio.Click
        Label_Destino.Show()
        Label_Horario.Show()
        Label_ida.Show()
        Label_vuelta.Show()
        TextBox_destino.Show()
        TextBox_ida.Show()
        TextBox_vuleta.Show()
        Button_venta.Show()
        GroupBoxSelected.Hide()
        GroupBoxAcompañantes.Hide()
        Label20.Hide()
        TextBox2.Hide()
        GroupBox4.Hide()
        Button6.Hide()
        Label28.Hide()
        Inicio.Hide()
    End Sub
End Class
