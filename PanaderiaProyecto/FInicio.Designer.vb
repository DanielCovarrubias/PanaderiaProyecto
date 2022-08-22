<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FInicio
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
        Dim IdUsuarioLabel As System.Windows.Forms.Label
        Dim PassLabel As System.Windows.Forms.Label
        Dim NivelLabel As System.Windows.Forms.Label
        Me.TxUser = New System.Windows.Forms.TextBox()
        Me.TxPass = New System.Windows.Forms.TextBox()
        Me.BLogin = New System.Windows.Forms.Button()
        Me.UsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PanDBDataSet = New PanaderiaProyecto.PanDBDataSet()
        Me.IdUsuarioTextBox = New System.Windows.Forms.TextBox()
        Me.PassTextBox = New System.Windows.Forms.TextBox()
        Me.NivelTextBox = New System.Windows.Forms.TextBox()
        Me.UsuariosTableAdapter = New PanaderiaProyecto.PanDBDataSetTableAdapters.UsuariosTableAdapter()
        Me.TableAdapterManager = New PanaderiaProyecto.PanDBDataSetTableAdapters.TableAdapterManager()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        IdUsuarioLabel = New System.Windows.Forms.Label()
        PassLabel = New System.Windows.Forms.Label()
        NivelLabel = New System.Windows.Forms.Label()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdUsuarioLabel
        '
        IdUsuarioLabel.AutoSize = True
        IdUsuarioLabel.Location = New System.Drawing.Point(99, 48)
        IdUsuarioLabel.Name = "IdUsuarioLabel"
        IdUsuarioLabel.Size = New System.Drawing.Size(58, 13)
        IdUsuarioLabel.TabIndex = 4
        IdUsuarioLabel.Text = "Id Usuario:"
        '
        'PassLabel
        '
        PassLabel.AutoSize = True
        PassLabel.Location = New System.Drawing.Point(100, 87)
        PassLabel.Name = "PassLabel"
        PassLabel.Size = New System.Drawing.Size(33, 13)
        PassLabel.TabIndex = 6
        PassLabel.Text = "Pass:"
        '
        'NivelLabel
        '
        NivelLabel.AutoSize = True
        NivelLabel.Location = New System.Drawing.Point(99, 135)
        NivelLabel.Name = "NivelLabel"
        NivelLabel.Size = New System.Drawing.Size(34, 13)
        NivelLabel.TabIndex = 8
        NivelLabel.Text = "Nivel:"
        '
        'TxUser
        '
        Me.TxUser.Location = New System.Drawing.Point(88, 258)
        Me.TxUser.Name = "TxUser"
        Me.TxUser.Size = New System.Drawing.Size(100, 20)
        Me.TxUser.TabIndex = 0
        '
        'TxPass
        '
        Me.TxPass.Location = New System.Drawing.Point(88, 327)
        Me.TxPass.Name = "TxPass"
        Me.TxPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxPass.Size = New System.Drawing.Size(100, 20)
        Me.TxPass.TabIndex = 1
        '
        'BLogin
        '
        Me.BLogin.BackColor = System.Drawing.Color.Blue
        Me.BLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BLogin.ForeColor = System.Drawing.Color.White
        Me.BLogin.Location = New System.Drawing.Point(74, 376)
        Me.BLogin.Name = "BLogin"
        Me.BLogin.Size = New System.Drawing.Size(128, 34)
        Me.BLogin.TabIndex = 2
        Me.BLogin.Text = "Iniciar Sesión"
        Me.BLogin.UseVisualStyleBackColor = False
        '
        'UsuariosBindingSource
        '
        Me.UsuariosBindingSource.DataMember = "Usuarios"
        Me.UsuariosBindingSource.DataSource = Me.PanDBDataSet
        '
        'PanDBDataSet
        '
        Me.PanDBDataSet.DataSetName = "PanDBDataSet"
        Me.PanDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IdUsuarioTextBox
        '
        Me.IdUsuarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "IdUsuario", True))
        Me.IdUsuarioTextBox.Location = New System.Drawing.Point(102, 64)
        Me.IdUsuarioTextBox.Name = "IdUsuarioTextBox"
        Me.IdUsuarioTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdUsuarioTextBox.TabIndex = 5
        '
        'PassTextBox
        '
        Me.PassTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "Pass", True))
        Me.PassTextBox.Location = New System.Drawing.Point(102, 103)
        Me.PassTextBox.Name = "PassTextBox"
        Me.PassTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PassTextBox.TabIndex = 7
        '
        'NivelTextBox
        '
        Me.NivelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "Nivel", True))
        Me.NivelTextBox.Location = New System.Drawing.Point(102, 151)
        Me.NivelTextBox.Name = "NivelTextBox"
        Me.NivelTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NivelTextBox.TabIndex = 9
        '
        'UsuariosTableAdapter
        '
        Me.UsuariosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.DetallePedidoTableAdapter = Nothing
        Me.TableAdapterManager.PedidosTableAdapter = Nothing
        Me.TableAdapterManager.ProductosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PanaderiaProyecto.PanDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Me.UsuariosTableAdapter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PanaderiaProyecto.My.Resources.Resources.login
        Me.PictureBox1.Location = New System.Drawing.Point(44, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(195, 180)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(84, 235)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 20)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(84, 304)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 20)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Contraseña"
        '
        'FInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(287, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(NivelLabel)
        Me.Controls.Add(Me.NivelTextBox)
        Me.Controls.Add(PassLabel)
        Me.Controls.Add(Me.PassTextBox)
        Me.Controls.Add(IdUsuarioLabel)
        Me.Controls.Add(Me.IdUsuarioTextBox)
        Me.Controls.Add(Me.BLogin)
        Me.Controls.Add(Me.TxPass)
        Me.Controls.Add(Me.TxUser)
        Me.Name = "FInicio"
        Me.Text = "FInicio"
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxUser As TextBox
    Friend WithEvents TxPass As TextBox
    Friend WithEvents BLogin As Button
    Friend WithEvents PanDBDataSet As PanDBDataSet
    Friend WithEvents UsuariosBindingSource As BindingSource
    Friend WithEvents UsuariosTableAdapter As PanDBDataSetTableAdapters.UsuariosTableAdapter
    Friend WithEvents TableAdapterManager As PanDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IdUsuarioTextBox As TextBox
    Friend WithEvents PassTextBox As TextBox
    Friend WithEvents NivelTextBox As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
