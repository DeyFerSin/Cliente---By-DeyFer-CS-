<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    'Inherits System.Windows.Forms.Form
    Inherits MaterialSkin.Controls.MaterialForm

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
        Me.ClearLog = New MaterialSkin.Controls.MaterialButton()
        Me.BufferServer = New System.Windows.Forms.TextBox()
        Me.StartServer = New MaterialSkin.Controls.MaterialButton()
        Me.OpenCofre = New MaterialSkin.Controls.MaterialButton()
        Me.BuyCofre = New MaterialSkin.Controls.MaterialButton()
        Me.LabelEstado = New MaterialSkin.Controls.MaterialLabel()
        Me.LabelMonedas = New MaterialSkin.Controls.MaterialLabel()
        Me.SuspendLayout()
        '
        'ClearLog
        '
        Me.ClearLog.AutoSize = False
        Me.ClearLog.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClearLog.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.ClearLog.Depth = 0
        Me.ClearLog.HighEmphasis = True
        Me.ClearLog.Icon = Nothing
        Me.ClearLog.Location = New System.Drawing.Point(407, 66)
        Me.ClearLog.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.ClearLog.MouseState = MaterialSkin.MouseState.HOVER
        Me.ClearLog.Name = "ClearLog"
        Me.ClearLog.NoAccentTextColor = System.Drawing.Color.Empty
        Me.ClearLog.Size = New System.Drawing.Size(181, 36)
        Me.ClearLog.TabIndex = 8
        Me.ClearLog.Text = "Limpiar log"
        Me.ClearLog.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.ClearLog.UseAccentColor = False
        Me.ClearLog.UseVisualStyleBackColor = True
        '
        'BufferServer
        '
        Me.BufferServer.BackColor = System.Drawing.Color.Black
        Me.BufferServer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BufferServer.ForeColor = System.Drawing.Color.Lime
        Me.BufferServer.Location = New System.Drawing.Point(6, 105)
        Me.BufferServer.Multiline = True
        Me.BufferServer.Name = "BufferServer"
        Me.BufferServer.Size = New System.Drawing.Size(582, 305)
        Me.BufferServer.TabIndex = 6
        '
        'StartServer
        '
        Me.StartServer.AutoSize = False
        Me.StartServer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.StartServer.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.StartServer.Depth = 0
        Me.StartServer.HighEmphasis = True
        Me.StartServer.Icon = Nothing
        Me.StartServer.Location = New System.Drawing.Point(218, 66)
        Me.StartServer.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.StartServer.MouseState = MaterialSkin.MouseState.HOVER
        Me.StartServer.Name = "StartServer"
        Me.StartServer.NoAccentTextColor = System.Drawing.Color.Empty
        Me.StartServer.Size = New System.Drawing.Size(181, 36)
        Me.StartServer.TabIndex = 5
        Me.StartServer.Text = "Start Server"
        Me.StartServer.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.StartServer.UseAccentColor = False
        Me.StartServer.UseVisualStyleBackColor = True
        '
        'OpenCofre
        '
        Me.OpenCofre.AutoSize = False
        Me.OpenCofre.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.OpenCofre.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.OpenCofre.Depth = 0
        Me.OpenCofre.HighEmphasis = True
        Me.OpenCofre.Icon = Nothing
        Me.OpenCofre.Location = New System.Drawing.Point(6, 419)
        Me.OpenCofre.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.OpenCofre.MouseState = MaterialSkin.MouseState.HOVER
        Me.OpenCofre.Name = "OpenCofre"
        Me.OpenCofre.NoAccentTextColor = System.Drawing.Color.Empty
        Me.OpenCofre.Size = New System.Drawing.Size(181, 36)
        Me.OpenCofre.TabIndex = 5
        Me.OpenCofre.Text = "abrir un cofre"
        Me.OpenCofre.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.OpenCofre.UseAccentColor = False
        Me.OpenCofre.UseVisualStyleBackColor = True
        '
        'BuyCofre
        '
        Me.BuyCofre.AutoSize = False
        Me.BuyCofre.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BuyCofre.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.BuyCofre.Depth = 0
        Me.BuyCofre.HighEmphasis = True
        Me.BuyCofre.Icon = Nothing
        Me.BuyCofre.Location = New System.Drawing.Point(406, 419)
        Me.BuyCofre.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BuyCofre.MouseState = MaterialSkin.MouseState.HOVER
        Me.BuyCofre.Name = "BuyCofre"
        Me.BuyCofre.NoAccentTextColor = System.Drawing.Color.Empty
        Me.BuyCofre.Size = New System.Drawing.Size(181, 36)
        Me.BuyCofre.TabIndex = 8
        Me.BuyCofre.Text = "comprar un cofre"
        Me.BuyCofre.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.BuyCofre.UseAccentColor = False
        Me.BuyCofre.UseVisualStyleBackColor = True
        '
        'LabelEstado
        '
        Me.LabelEstado.AutoSize = True
        Me.LabelEstado.Depth = 0
        Me.LabelEstado.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.LabelEstado.Location = New System.Drawing.Point(6, 66)
        Me.LabelEstado.MouseState = MaterialSkin.MouseState.HOVER
        Me.LabelEstado.Name = "LabelEstado"
        Me.LabelEstado.Size = New System.Drawing.Size(54, 19)
        Me.LabelEstado.TabIndex = 9
        Me.LabelEstado.Text = "Estado:"
        '
        'LabelMonedas
        '
        Me.LabelMonedas.AutoSize = True
        Me.LabelMonedas.Depth = 0
        Me.LabelMonedas.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.LabelMonedas.Location = New System.Drawing.Point(6, 86)
        Me.LabelMonedas.MouseState = MaterialSkin.MouseState.HOVER
        Me.LabelMonedas.Name = "LabelMonedas"
        Me.LabelMonedas.Size = New System.Drawing.Size(71, 19)
        Me.LabelMonedas.TabIndex = 9
        Me.LabelMonedas.Text = "Monedas:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 460)
        Me.Controls.Add(Me.LabelMonedas)
        Me.Controls.Add(Me.LabelEstado)
        Me.Controls.Add(Me.BuyCofre)
        Me.Controls.Add(Me.ClearLog)
        Me.Controls.Add(Me.BufferServer)
        Me.Controls.Add(Me.OpenCofre)
        Me.Controls.Add(Me.StartServer)
        Me.Name = "Form1"
        Me.Text = "Cliente - By DeyFer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ClearLog As MaterialSkin.Controls.MaterialButton
    Friend WithEvents BufferServer As TextBox
    Friend WithEvents StartServer As MaterialSkin.Controls.MaterialButton
    Friend WithEvents OpenCofre As MaterialSkin.Controls.MaterialButton
    Friend WithEvents BuyCofre As MaterialSkin.Controls.MaterialButton
    Friend WithEvents LabelEstado As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents LabelMonedas As MaterialSkin.Controls.MaterialLabel
End Class
