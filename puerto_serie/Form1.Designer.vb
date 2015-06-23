<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnconectar = New System.Windows.Forms.Button()
        Me.btndeconectar = New System.Windows.Forms.Button()
        Me.cmbPort = New System.Windows.Forms.ComboBox()
        Me.txtrecibe = New System.Windows.Forms.TextBox()
        Me.txtenvia = New System.Windows.Forms.TextBox()
        Me.btnenviar = New System.Windows.Forms.Button()
        Me.sppuerto = New System.IO.Ports.SerialPort(Me.components)
        Me.SuspendLayout()
        '
        'btnconectar
        '
        Me.btnconectar.Location = New System.Drawing.Point(164, 23)
        Me.btnconectar.Name = "btnconectar"
        Me.btnconectar.Size = New System.Drawing.Size(75, 23)
        Me.btnconectar.TabIndex = 0
        Me.btnconectar.Text = "CONECTAR"
        Me.btnconectar.UseVisualStyleBackColor = True
        '
        'btndeconectar
        '
        Me.btndeconectar.Location = New System.Drawing.Point(275, 23)
        Me.btndeconectar.Name = "btndeconectar"
        Me.btndeconectar.Size = New System.Drawing.Size(104, 23)
        Me.btndeconectar.TabIndex = 1
        Me.btndeconectar.Text = "DESCONECTAR"
        Me.btndeconectar.UseVisualStyleBackColor = True
        '
        'cmbPort
        '
        Me.cmbPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPort.FormattingEnabled = True
        Me.cmbPort.Location = New System.Drawing.Point(12, 25)
        Me.cmbPort.Name = "cmbPort"
        Me.cmbPort.Size = New System.Drawing.Size(121, 21)
        Me.cmbPort.TabIndex = 2
        '
        'txtrecibe
        '
        Me.txtrecibe.Location = New System.Drawing.Point(12, 64)
        Me.txtrecibe.Multiline = True
        Me.txtrecibe.Name = "txtrecibe"
        Me.txtrecibe.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtrecibe.Size = New System.Drawing.Size(432, 126)
        Me.txtrecibe.TabIndex = 3
        '
        'txtenvia
        '
        Me.txtenvia.Location = New System.Drawing.Point(12, 216)
        Me.txtenvia.Name = "txtenvia"
        Me.txtenvia.Size = New System.Drawing.Size(305, 20)
        Me.txtenvia.TabIndex = 4
        '
        'btnenviar
        '
        Me.btnenviar.Location = New System.Drawing.Point(369, 213)
        Me.btnenviar.Name = "btnenviar"
        Me.btnenviar.Size = New System.Drawing.Size(75, 23)
        Me.btnenviar.TabIndex = 5
        Me.btnenviar.Text = "ENVIAR"
        Me.btnenviar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 257)
        Me.Controls.Add(Me.btnenviar)
        Me.Controls.Add(Me.txtenvia)
        Me.Controls.Add(Me.txtrecibe)
        Me.Controls.Add(Me.cmbPort)
        Me.Controls.Add(Me.btndeconectar)
        Me.Controls.Add(Me.btnconectar)
        Me.Name = "Form1"
        Me.Text = "LLER PUERTO SERIAL"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnconectar As System.Windows.Forms.Button
    Friend WithEvents btndeconectar As System.Windows.Forms.Button
    Friend WithEvents cmbPort As System.Windows.Forms.ComboBox
    Friend WithEvents txtrecibe As System.Windows.Forms.TextBox
    Friend WithEvents txtenvia As System.Windows.Forms.TextBox
    Friend WithEvents btnenviar As System.Windows.Forms.Button
    Friend WithEvents sppuerto As System.IO.Ports.SerialPort

End Class
