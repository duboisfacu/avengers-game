<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AvengersGame
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AvengersGame))
        Me.btnNueva = New System.Windows.Forms.Button
        Me.cmbCartaElegida = New System.Windows.Forms.ComboBox
        Me.btnJugar = New System.Windows.Forms.Button
        Me.lblpuntpc = New System.Windows.Forms.Label
        Me.lblpuntjugador = New System.Windows.Forms.Label
        Me.txtCartaElegida = New System.Windows.Forms.TextBox
        Me.lblpuntuacion = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.pic_logo = New System.Windows.Forms.PictureBox
        Me.piccartapc = New System.Windows.Forms.PictureBox
        Me.piccartajugador = New System.Windows.Forms.PictureBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.piccartapc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.piccartajugador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnNueva
        '
        Me.btnNueva.Location = New System.Drawing.Point(334, 101)
        Me.btnNueva.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnNueva.Name = "btnNueva"
        Me.btnNueva.Size = New System.Drawing.Size(222, 49)
        Me.btnNueva.TabIndex = 0
        Me.btnNueva.Text = "Nueva Partida..."
        Me.btnNueva.UseVisualStyleBackColor = True
        '
        'cmbCartaElegida
        '
        Me.cmbCartaElegida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCartaElegida.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCartaElegida.FormattingEnabled = True
        Me.cmbCartaElegida.Location = New System.Drawing.Point(15, 485)
        Me.cmbCartaElegida.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmbCartaElegida.Name = "cmbCartaElegida"
        Me.cmbCartaElegida.Size = New System.Drawing.Size(317, 23)
        Me.cmbCartaElegida.TabIndex = 2
        '
        'btnJugar
        '
        Me.btnJugar.Enabled = False
        Me.btnJugar.Location = New System.Drawing.Point(335, 424)
        Me.btnJugar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnJugar.Name = "btnJugar"
        Me.btnJugar.Size = New System.Drawing.Size(222, 47)
        Me.btnJugar.TabIndex = 3
        Me.btnJugar.Text = "Jugar"
        Me.btnJugar.UseVisualStyleBackColor = True
        '
        'lblpuntpc
        '
        Me.lblpuntpc.AutoSize = True
        Me.lblpuntpc.BackColor = System.Drawing.Color.Transparent
        Me.lblpuntpc.Font = New System.Drawing.Font("Calibri", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpuntpc.ForeColor = System.Drawing.Color.White
        Me.lblpuntpc.Location = New System.Drawing.Point(488, 215)
        Me.lblpuntpc.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblpuntpc.Name = "lblpuntpc"
        Me.lblpuntpc.Size = New System.Drawing.Size(49, 59)
        Me.lblpuntpc.TabIndex = 6
        Me.lblpuntpc.Text = "0"
        '
        'lblpuntjugador
        '
        Me.lblpuntjugador.AutoSize = True
        Me.lblpuntjugador.BackColor = System.Drawing.Color.Transparent
        Me.lblpuntjugador.Font = New System.Drawing.Font("Calibri", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpuntjugador.ForeColor = System.Drawing.Color.White
        Me.lblpuntjugador.Location = New System.Drawing.Point(350, 215)
        Me.lblpuntjugador.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblpuntjugador.Name = "lblpuntjugador"
        Me.lblpuntjugador.Size = New System.Drawing.Size(49, 59)
        Me.lblpuntjugador.TabIndex = 7
        Me.lblpuntjugador.Text = "0"
        '
        'txtCartaElegida
        '
        Me.txtCartaElegida.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.txtCartaElegida.Location = New System.Drawing.Point(562, 485)
        Me.txtCartaElegida.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtCartaElegida.Name = "txtCartaElegida"
        Me.txtCartaElegida.ReadOnly = True
        Me.txtCartaElegida.Size = New System.Drawing.Size(317, 23)
        Me.txtCartaElegida.TabIndex = 8
        Me.txtCartaElegida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblpuntuacion
        '
        Me.lblpuntuacion.AutoSize = True
        Me.lblpuntuacion.BackColor = System.Drawing.Color.Transparent
        Me.lblpuntuacion.Font = New System.Drawing.Font("Calibri", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpuntuacion.ForeColor = System.Drawing.Color.White
        Me.lblpuntuacion.Location = New System.Drawing.Point(338, 173)
        Me.lblpuntuacion.Name = "lblpuntuacion"
        Me.lblpuntuacion.Size = New System.Drawing.Size(218, 42)
        Me.lblpuntuacion.TabIndex = 14
        Me.lblpuntuacion.Text = "PUNTUACIÓN"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Calibri", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(414, 228)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 42)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "VS"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.AvengersGame.My.Resources.Resources.img_software
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(380, 485)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(121, 23)
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'pic_logo
        '
        Me.pic_logo.BackColor = System.Drawing.Color.Transparent
        Me.pic_logo.BackgroundImage = Global.AvengersGame.My.Resources.Resources.img_avengersgamelogo
        Me.pic_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pic_logo.Location = New System.Drawing.Point(349, 29)
        Me.pic_logo.Name = "pic_logo"
        Me.pic_logo.Size = New System.Drawing.Size(192, 66)
        Me.pic_logo.TabIndex = 16
        Me.pic_logo.TabStop = False
        '
        'piccartapc
        '
        Me.piccartapc.BackgroundImage = Global.AvengersGame.My.Resources.Resources.img_0
        Me.piccartapc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.piccartapc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.piccartapc.Location = New System.Drawing.Point(561, 29)
        Me.piccartapc.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.piccartapc.Name = "piccartapc"
        Me.piccartapc.Size = New System.Drawing.Size(317, 442)
        Me.piccartapc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.piccartapc.TabIndex = 10
        Me.piccartapc.TabStop = False
        '
        'piccartajugador
        '
        Me.piccartajugador.BackgroundImage = Global.AvengersGame.My.Resources.Resources.img_0
        Me.piccartajugador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.piccartajugador.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.piccartajugador.Location = New System.Drawing.Point(14, 29)
        Me.piccartajugador.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.piccartajugador.Name = "piccartajugador"
        Me.piccartajugador.Size = New System.Drawing.Size(317, 442)
        Me.piccartajugador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.piccartajugador.TabIndex = 9
        Me.piccartajugador.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(349, 260)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(188, 169)
        Me.PictureBox3.TabIndex = 13
        Me.PictureBox3.TabStop = False
        '
        'AvengersGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.DimGray
        Me.BackgroundImage = Global.AvengersGame.My.Resources.Resources.img_background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(889, 520)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pic_logo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblpuntuacion)
        Me.Controls.Add(Me.lblpuntpc)
        Me.Controls.Add(Me.piccartapc)
        Me.Controls.Add(Me.piccartajugador)
        Me.Controls.Add(Me.txtCartaElegida)
        Me.Controls.Add(Me.lblpuntjugador)
        Me.Controls.Add(Me.btnJugar)
        Me.Controls.Add(Me.cmbCartaElegida)
        Me.Controls.Add(Me.btnNueva)
        Me.Controls.Add(Me.PictureBox3)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.MaximizeBox = False
        Me.Name = "AvengersGame"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AvengersGame"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.piccartapc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.piccartajugador, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnNueva As System.Windows.Forms.Button
    Friend WithEvents btnJugar As System.Windows.Forms.Button
    Friend WithEvents lblpuntpc As System.Windows.Forms.Label
    Friend WithEvents lblpuntjugador As System.Windows.Forms.Label
    Friend WithEvents txtCartaElegida As System.Windows.Forms.TextBox
    Friend WithEvents piccartajugador As System.Windows.Forms.PictureBox
    Friend WithEvents piccartapc As System.Windows.Forms.PictureBox
    Friend WithEvents cmbCartaElegida As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents lblpuntuacion As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents pic_logo As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
