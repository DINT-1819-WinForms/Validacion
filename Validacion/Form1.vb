Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Configuramos los mensajes de ayuda de cada control
        UsuarioTextBox.Tag = "El nombre de usuario solo puede contener letras, dígitos y puntos. Se puede borrar."
        ContraseñaTextBox.Tag = "La contraseña debe tener al menos 8 caracteres"
        ConfirmarTextBox.Tag = "Las dos contraseñas escritas deben coincidir"

    End Sub

    Private Sub TextBox_KeyUp(sender As Object, e As KeyEventArgs) Handles UsuarioTextBox.KeyUp, ContraseñaTextBox.KeyUp, ConfirmarTextBox.KeyUp

        If e.KeyCode = Keys.F1 Then
            'Si el usuario pulsa F1, mostramos la ayuda del campo
            MessageBox.Show(CType(sender, TextBox).Tag, "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Question)
        End If

    End Sub


    Private Sub UsuarioTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles UsuarioTextBox.KeyPress

        If Not (Char.IsLetterOrDigit(e.KeyChar) Or e.KeyChar = "."c Or Asc(e.KeyChar) = 8) Then
            'Si el caracter escrito no es una letra, dígito, punto o la tecla de retroceso, evitamos su escritura
            e.Handled = True
        End If

    End Sub

    Private Sub ContraseñaTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContraseñaTextBox.Validating

        If ContraseñaTextBox.Text.Length < 8 Then
            'Si la contraseña no tiene la longitud mínima, establecemos el mensaje de error en el ErrorProvider
            ErrorProvider1.SetError(sender, "Contraseña demasiado corta")
            'Y cancelamos el evento
            e.Cancel = True
            Exit Sub
        End If

    End Sub

    Private Sub ContraseñaTextBox_Validated(sender As Object, e As EventArgs) Handles ContraseñaTextBox.Validated

        'Si la validación ha sido correcta, eliminamos el mensaje de error
        ErrorProvider1.SetError(sender, "")

    End Sub



    Private Sub ConfirmarTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ConfirmarTextBox.Validating

        If ConfirmarTextBox.Text <> ContraseñaTextBox.Text Then
            'Si las contraseñas no coinciden, establecemos el mensaje de error en el ErrorProvider
            ErrorProvider1.SetError(sender, "No coinciden las contraseñas")
            'Y cancelamos el evento
            e.Cancel = True
        End If
    End Sub

    Private Sub Confirmar_Validated(sender As Object, e As EventArgs) Handles ConfirmarTextBox.Validated

        'Si la validación ha sido correcta, eliminamos el mensaje de error
        ErrorProvider1.SetError(sender, "")
    End Sub

    Private Sub CambiarCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles CambiarCheckBox.CheckedChanged
        If CambiarCheckBox.Checked Then
            'Si activamos la validación por botón lo habilitamos
            ValidarButton.Enabled = True
            'Cambiamos el tipo de validación del formulario
            Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Else
            'Si activamos la validación por botón lo habilitamos
            ValidarButton.Enabled = False
            'Cambiamos el tipo de validación del formulario
            Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        End If
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'Permitimos el cierre del formulario 
        e.Cancel = False
    End Sub

    Private Sub ValidarButton_Click(sender As Object, e As EventArgs) Handles ValidarButton.Click
        If Me.ValidateChildren() Then
            'Si la validación de todos los controles del formulario es correcta, informamos al usuario
            MessageBox.Show("Validación correcta", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

End Class
