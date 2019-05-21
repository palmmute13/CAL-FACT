<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtnCalcular = New System.Windows.Forms.Button
        Me.TbxDCosto = New System.Windows.Forms.TextBox
        Me.LblItebis = New System.Windows.Forms.Label
        Me.LblFerreteria = New System.Windows.Forms.Label
        Me.ChbTransporte = New System.Windows.Forms.CheckBox
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.RbDiez = New System.Windows.Forms.RadioButton
        Me.RbVente = New System.Windows.Forms.RadioButton
        Me.RbTrenta = New System.Windows.Forms.RadioButton
        Me.RbCuarenta = New System.Windows.Forms.RadioButton
        Me.RbCincuenta = New System.Windows.Forms.RadioButton
        Me.SuspendLayout()
        '
        'BtnCalcular
        '
        Me.BtnCalcular.Location = New System.Drawing.Point(216, 380)
        Me.BtnCalcular.Name = "BtnCalcular"
        Me.BtnCalcular.Size = New System.Drawing.Size(71, 82)
        Me.BtnCalcular.TabIndex = 0
        Me.BtnCalcular.Text = "CALCULAR"
        Me.BtnCalcular.UseVisualStyleBackColor = True
        '
        'TbxDCosto
        '
        Me.TbxDCosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbxDCosto.Location = New System.Drawing.Point(114, 43)
        Me.TbxDCosto.Name = "TbxDCosto"
        Me.TbxDCosto.Size = New System.Drawing.Size(173, 29)
        Me.TbxDCosto.TabIndex = 1
        Me.TbxDCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LblItebis
        '
        Me.LblItebis.AutoSize = True
        Me.LblItebis.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.LblItebis.Location = New System.Drawing.Point(110, 75)
        Me.LblItebis.Margin = New System.Windows.Forms.Padding(3, 0, 3, 10)
        Me.LblItebis.Name = "LblItebis"
        Me.LblItebis.Size = New System.Drawing.Size(21, 24)
        Me.LblItebis.TabIndex = 2
        Me.LblItebis.Text = "0"
        '
        'LblFerreteria
        '
        Me.LblFerreteria.AutoSize = True
        Me.LblFerreteria.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.LblFerreteria.Location = New System.Drawing.Point(110, 109)
        Me.LblFerreteria.Margin = New System.Windows.Forms.Padding(3, 0, 3, 10)
        Me.LblFerreteria.Name = "LblFerreteria"
        Me.LblFerreteria.Size = New System.Drawing.Size(21, 24)
        Me.LblFerreteria.TabIndex = 3
        Me.LblFerreteria.Text = "0"
        '
        'ChbTransporte
        '
        Me.ChbTransporte.AutoSize = True
        Me.ChbTransporte.Location = New System.Drawing.Point(12, 232)
        Me.ChbTransporte.Name = "ChbTransporte"
        Me.ChbTransporte.Size = New System.Drawing.Size(77, 17)
        Me.ChbTransporte.TabIndex = 4
        Me.ChbTransporte.Text = "Transporte"
        Me.ChbTransporte.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(12, 255)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox2.TabIndex = 5
        Me.CheckBox2.Text = "CheckBox2"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'RbDiez
        '
        Me.RbDiez.AutoSize = True
        Me.RbDiez.Location = New System.Drawing.Point(12, 353)
        Me.RbDiez.Name = "RbDiez"
        Me.RbDiez.Size = New System.Drawing.Size(48, 17)
        Me.RbDiez.TabIndex = 6
        Me.RbDiez.TabStop = True
        Me.RbDiez.Text = "10 %"
        Me.RbDiez.UseVisualStyleBackColor = True
        '
        'RbVente
        '
        Me.RbVente.AutoSize = True
        Me.RbVente.Location = New System.Drawing.Point(12, 376)
        Me.RbVente.Name = "RbVente"
        Me.RbVente.Size = New System.Drawing.Size(48, 17)
        Me.RbVente.TabIndex = 7
        Me.RbVente.TabStop = True
        Me.RbVente.Text = "20 %"
        Me.RbVente.UseVisualStyleBackColor = True
        '
        'RbTrenta
        '
        Me.RbTrenta.AutoSize = True
        Me.RbTrenta.Location = New System.Drawing.Point(12, 399)
        Me.RbTrenta.Name = "RbTrenta"
        Me.RbTrenta.Size = New System.Drawing.Size(48, 17)
        Me.RbTrenta.TabIndex = 8
        Me.RbTrenta.TabStop = True
        Me.RbTrenta.Text = "30 %"
        Me.RbTrenta.UseVisualStyleBackColor = True
        '
        'RbCuarenta
        '
        Me.RbCuarenta.AutoSize = True
        Me.RbCuarenta.Location = New System.Drawing.Point(12, 422)
        Me.RbCuarenta.Name = "RbCuarenta"
        Me.RbCuarenta.Size = New System.Drawing.Size(48, 17)
        Me.RbCuarenta.TabIndex = 9
        Me.RbCuarenta.TabStop = True
        Me.RbCuarenta.Text = "40 %"
        Me.RbCuarenta.UseVisualStyleBackColor = True
        '
        'RbCincuenta
        '
        Me.RbCincuenta.AutoSize = True
        Me.RbCincuenta.Location = New System.Drawing.Point(12, 445)
        Me.RbCincuenta.Name = "RbCincuenta"
        Me.RbCincuenta.Size = New System.Drawing.Size(48, 17)
        Me.RbCincuenta.TabIndex = 10
        Me.RbCincuenta.TabStop = True
        Me.RbCincuenta.Text = "50 %"
        Me.RbCincuenta.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(299, 474)
        Me.Controls.Add(Me.RbCincuenta)
        Me.Controls.Add(Me.RbCuarenta)
        Me.Controls.Add(Me.RbTrenta)
        Me.Controls.Add(Me.RbVente)
        Me.Controls.Add(Me.RbDiez)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.ChbTransporte)
        Me.Controls.Add(Me.LblFerreteria)
        Me.Controls.Add(Me.LblItebis)
        Me.Controls.Add(Me.TbxDCosto)
        Me.Controls.Add(Me.BtnCalcular)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(315, 512)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(315, 512)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CALCULADORA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnCalcular As System.Windows.Forms.Button
    Friend WithEvents TbxDCosto As System.Windows.Forms.TextBox
    Friend WithEvents LblItebis As System.Windows.Forms.Label
    Friend WithEvents LblFerreteria As System.Windows.Forms.Label
    Friend WithEvents ChbTransporte As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents RbDiez As System.Windows.Forms.RadioButton
    Friend WithEvents RbVente As System.Windows.Forms.RadioButton
    Friend WithEvents RbTrenta As System.Windows.Forms.RadioButton
    Friend WithEvents RbCuarenta As System.Windows.Forms.RadioButton
    Friend WithEvents RbCincuenta As System.Windows.Forms.RadioButton

End Class
