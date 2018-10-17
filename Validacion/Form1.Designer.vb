<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.UsuarioTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ContraseñaTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ConfirmarTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ValidarButton = New System.Windows.Forms.Button()
        Me.CambiarCheckBox = New System.Windows.Forms.CheckBox()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsuarioTextBox
        '
        Me.UsuarioTextBox.Location = New System.Drawing.Point(133, 23)
        Me.UsuarioTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.UsuarioTextBox.Name = "UsuarioTextBox"
        Me.UsuarioTextBox.ShortcutsEnabled = False
        Me.UsuarioTextBox.Size = New System.Drawing.Size(132, 22)
        Me.UsuarioTextBox.TabIndex = 1
        Me.UsuarioTextBox.Tag = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 27)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Usuario"
        '
        'ContraseñaTextBox
        '
        Me.ContraseñaTextBox.Location = New System.Drawing.Point(133, 70)
        Me.ContraseñaTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ContraseñaTextBox.Name = "ContraseñaTextBox"
        Me.ContraseñaTextBox.Size = New System.Drawing.Size(132, 22)
        Me.ContraseñaTextBox.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 74)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Contraseña"
        '
        'ConfirmarTextBox
        '
        Me.ConfirmarTextBox.Location = New System.Drawing.Point(133, 113)
        Me.ConfirmarTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ConfirmarTextBox.Name = "ConfirmarTextBox"
        Me.ConfirmarTextBox.Size = New System.Drawing.Size(132, 22)
        Me.ConfirmarTextBox.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 117)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Confirmar"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ValidarButton
        '
        Me.ValidarButton.Enabled = False
        Me.ValidarButton.Location = New System.Drawing.Point(190, 174)
        Me.ValidarButton.Name = "ValidarButton"
        Me.ValidarButton.Size = New System.Drawing.Size(75, 23)
        Me.ValidarButton.TabIndex = 7
        Me.ValidarButton.Text = "Validar"
        Me.ValidarButton.UseVisualStyleBackColor = True
        '
        'CambiarCheckBox
        '
        Me.CambiarCheckBox.AutoSize = True
        Me.CambiarCheckBox.Location = New System.Drawing.Point(35, 176)
        Me.CambiarCheckBox.Name = "CambiarCheckBox"
        Me.CambiarCheckBox.Size = New System.Drawing.Size(141, 21)
        Me.CambiarCheckBox.TabIndex = 8
        Me.CambiarCheckBox.Text = "Validar con botón"
        Me.CambiarCheckBox.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.ClientSize = New System.Drawing.Size(320, 231)
        Me.Controls.Add(Me.CambiarCheckBox)
        Me.Controls.Add(Me.ValidarButton)
        Me.Controls.Add(Me.ContraseñaTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ConfirmarTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.UsuarioTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Validación"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UsuarioTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ContraseñaTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ConfirmarTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents CambiarCheckBox As CheckBox
    Friend WithEvents ValidarButton As Button
End Class
