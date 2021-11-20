<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.IconButton6 = New FontAwesome.Sharp.IconButton()
        Me.IconButton5 = New FontAwesome.Sharp.IconButton()
        Me.btnRegistrarProducto = New FontAwesome.Sharp.IconButton()
        Me.btnCargaSucursal = New FontAwesome.Sharp.IconButton()
        Me.btnRegistrarClient = New FontAwesome.Sharp.IconButton()
        Me.btnRegistrarEmpl = New FontAwesome.Sharp.IconButton()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.imgLogoDashboard = New FontAwesome.Sharp.IconPictureBox()
        Me.lblFormTittle = New System.Windows.Forms.Label()
        Me.IconHome = New FontAwesome.Sharp.IconPictureBox()
        Me.PanelDesktop = New System.Windows.Forms.Panel()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PanelMenu.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.imgLogoDashboard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconHome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.IconButton1)
        Me.PanelMenu.Controls.Add(Me.IconButton6)
        Me.PanelMenu.Controls.Add(Me.IconButton5)
        Me.PanelMenu.Controls.Add(Me.btnRegistrarProducto)
        Me.PanelMenu.Controls.Add(Me.btnCargaSucursal)
        Me.PanelMenu.Controls.Add(Me.btnRegistrarClient)
        Me.PanelMenu.Controls.Add(Me.btnRegistrarEmpl)
        Me.PanelMenu.Controls.Add(Me.PanelLogo)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(220, 607)
        Me.PanelMenu.TabIndex = 0
        '
        'IconButton1
        '
        Me.IconButton1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.Font = New System.Drawing.Font("Fira Code Medium", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton1.ForeColor = System.Drawing.Color.Gainsboro
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt
        Me.IconButton1.IconColor = System.Drawing.Color.Gainsboro
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 40
        Me.IconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.Location = New System.Drawing.Point(0, 547)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.IconButton1.Size = New System.Drawing.Size(220, 60)
        Me.IconButton1.TabIndex = 7
        Me.IconButton1.Text = "Salir"
        Me.IconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'IconButton6
        '
        Me.IconButton6.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButton6.FlatAppearance.BorderSize = 0
        Me.IconButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton6.Font = New System.Drawing.Font("Fira Code Medium", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton6.ForeColor = System.Drawing.Color.Gainsboro
        Me.IconButton6.IconChar = FontAwesome.Sharp.IconChar.FilePdf
        Me.IconButton6.IconColor = System.Drawing.Color.Gainsboro
        Me.IconButton6.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton6.IconSize = 40
        Me.IconButton6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton6.Location = New System.Drawing.Point(0, 440)
        Me.IconButton6.Name = "IconButton6"
        Me.IconButton6.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.IconButton6.Size = New System.Drawing.Size(220, 60)
        Me.IconButton6.TabIndex = 6
        Me.IconButton6.Text = "Reportes"
        Me.IconButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton6.UseVisualStyleBackColor = True
        '
        'IconButton5
        '
        Me.IconButton5.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButton5.FlatAppearance.BorderSize = 0
        Me.IconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton5.Font = New System.Drawing.Font("Fira Code Medium", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton5.ForeColor = System.Drawing.Color.Gainsboro
        Me.IconButton5.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart
        Me.IconButton5.IconColor = System.Drawing.Color.Gainsboro
        Me.IconButton5.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton5.IconSize = 40
        Me.IconButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton5.Location = New System.Drawing.Point(0, 380)
        Me.IconButton5.Name = "IconButton5"
        Me.IconButton5.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.IconButton5.Size = New System.Drawing.Size(220, 60)
        Me.IconButton5.TabIndex = 5
        Me.IconButton5.Text = "Tienda"
        Me.IconButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton5.UseVisualStyleBackColor = True
        '
        'btnRegistrarProducto
        '
        Me.btnRegistrarProducto.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRegistrarProducto.FlatAppearance.BorderSize = 0
        Me.btnRegistrarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistrarProducto.Font = New System.Drawing.Font("Fira Code Medium", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrarProducto.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnRegistrarProducto.IconChar = FontAwesome.Sharp.IconChar.AppleAlt
        Me.btnRegistrarProducto.IconColor = System.Drawing.Color.Gainsboro
        Me.btnRegistrarProducto.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnRegistrarProducto.IconSize = 40
        Me.btnRegistrarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegistrarProducto.Location = New System.Drawing.Point(0, 320)
        Me.btnRegistrarProducto.Name = "btnRegistrarProducto"
        Me.btnRegistrarProducto.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnRegistrarProducto.Size = New System.Drawing.Size(220, 60)
        Me.btnRegistrarProducto.TabIndex = 4
        Me.btnRegistrarProducto.Text = "Productos"
        Me.btnRegistrarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegistrarProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRegistrarProducto.UseVisualStyleBackColor = True
        '
        'btnCargaSucursal
        '
        Me.btnCargaSucursal.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCargaSucursal.FlatAppearance.BorderSize = 0
        Me.btnCargaSucursal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCargaSucursal.Font = New System.Drawing.Font("Fira Code Medium", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCargaSucursal.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnCargaSucursal.IconChar = FontAwesome.Sharp.IconChar.Store
        Me.btnCargaSucursal.IconColor = System.Drawing.Color.Gainsboro
        Me.btnCargaSucursal.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnCargaSucursal.IconSize = 40
        Me.btnCargaSucursal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCargaSucursal.Location = New System.Drawing.Point(0, 260)
        Me.btnCargaSucursal.Name = "btnCargaSucursal"
        Me.btnCargaSucursal.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnCargaSucursal.Size = New System.Drawing.Size(220, 60)
        Me.btnCargaSucursal.TabIndex = 3
        Me.btnCargaSucursal.Text = "Sucursales"
        Me.btnCargaSucursal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCargaSucursal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCargaSucursal.UseVisualStyleBackColor = True
        '
        'btnRegistrarClient
        '
        Me.btnRegistrarClient.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRegistrarClient.FlatAppearance.BorderSize = 0
        Me.btnRegistrarClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistrarClient.Font = New System.Drawing.Font("Fira Code Medium", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrarClient.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnRegistrarClient.IconChar = FontAwesome.Sharp.IconChar.UserAlt
        Me.btnRegistrarClient.IconColor = System.Drawing.Color.Gainsboro
        Me.btnRegistrarClient.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnRegistrarClient.IconSize = 40
        Me.btnRegistrarClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegistrarClient.Location = New System.Drawing.Point(0, 200)
        Me.btnRegistrarClient.Name = "btnRegistrarClient"
        Me.btnRegistrarClient.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnRegistrarClient.Size = New System.Drawing.Size(220, 60)
        Me.btnRegistrarClient.TabIndex = 2
        Me.btnRegistrarClient.Text = "Clientes"
        Me.btnRegistrarClient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegistrarClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRegistrarClient.UseVisualStyleBackColor = True
        '
        'btnRegistrarEmpl
        '
        Me.btnRegistrarEmpl.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRegistrarEmpl.FlatAppearance.BorderSize = 0
        Me.btnRegistrarEmpl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistrarEmpl.Font = New System.Drawing.Font("Fira Code Medium", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrarEmpl.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnRegistrarEmpl.IconChar = FontAwesome.Sharp.IconChar.IdCardAlt
        Me.btnRegistrarEmpl.IconColor = System.Drawing.Color.Gainsboro
        Me.btnRegistrarEmpl.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnRegistrarEmpl.IconSize = 40
        Me.btnRegistrarEmpl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegistrarEmpl.Location = New System.Drawing.Point(0, 140)
        Me.btnRegistrarEmpl.Name = "btnRegistrarEmpl"
        Me.btnRegistrarEmpl.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnRegistrarEmpl.Size = New System.Drawing.Size(220, 60)
        Me.btnRegistrarEmpl.TabIndex = 1
        Me.btnRegistrarEmpl.Text = "Empleados"
        Me.btnRegistrarEmpl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegistrarEmpl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRegistrarEmpl.UseVisualStyleBackColor = True
        '
        'PanelLogo
        '
        Me.PanelLogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(220, 140)
        Me.PanelLogo.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Panel1.Controls.Add(Me.imgLogoDashboard)
        Me.Panel1.Controls.Add(Me.lblFormTittle)
        Me.Panel1.Controls.Add(Me.IconHome)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(220, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(973, 75)
        Me.Panel1.TabIndex = 1
        '
        'imgLogoDashboard
        '
        Me.imgLogoDashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.imgLogoDashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imgLogoDashboard.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.imgLogoDashboard.IconColor = System.Drawing.Color.White
        Me.imgLogoDashboard.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.imgLogoDashboard.Location = New System.Drawing.Point(938, 3)
        Me.imgLogoDashboard.Name = "imgLogoDashboard"
        Me.imgLogoDashboard.Size = New System.Drawing.Size(32, 32)
        Me.imgLogoDashboard.TabIndex = 2
        Me.imgLogoDashboard.TabStop = False
        '
        'lblFormTittle
        '
        Me.lblFormTittle.AutoSize = True
        Me.lblFormTittle.Font = New System.Drawing.Font("Fira Code Medium", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormTittle.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblFormTittle.Location = New System.Drawing.Point(60, 29)
        Me.lblFormTittle.Name = "lblFormTittle"
        Me.lblFormTittle.Size = New System.Drawing.Size(49, 19)
        Me.lblFormTittle.TabIndex = 1
        Me.lblFormTittle.Text = "Home"
        '
        'IconHome
        '
        Me.IconHome.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.IconHome.ForeColor = System.Drawing.Color.MediumPurple
        Me.IconHome.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.IconHome.IconColor = System.Drawing.Color.MediumPurple
        Me.IconHome.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconHome.IconSize = 36
        Me.IconHome.Location = New System.Drawing.Point(22, 20)
        Me.IconHome.Name = "IconHome"
        Me.IconHome.Size = New System.Drawing.Size(36, 36)
        Me.IconHome.TabIndex = 0
        Me.IconHome.TabStop = False
        '
        'PanelDesktop
        '
        Me.PanelDesktop.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.PanelDesktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDesktop.Location = New System.Drawing.Point(220, 75)
        Me.PanelDesktop.Name = "PanelDesktop"
        Me.PanelDesktop.Size = New System.Drawing.Size(973, 532)
        Me.PanelDesktop.TabIndex = 2
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1193, 607)
        Me.Controls.Add(Me.PanelDesktop)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelMenu)
        Me.Name = "Dashboard"
        Me.Text = "Dasboard"
        Me.PanelMenu.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.imgLogoDashboard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconHome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PanelDesktop As Panel
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton6 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton5 As FontAwesome.Sharp.IconButton
    Friend WithEvents btnRegistrarProducto As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCargaSucursal As FontAwesome.Sharp.IconButton
    Friend WithEvents btnRegistrarClient As FontAwesome.Sharp.IconButton
    Friend WithEvents btnRegistrarEmpl As FontAwesome.Sharp.IconButton
    Friend WithEvents imgLogoDashboard As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents lblFormTittle As Label
    Friend WithEvents IconHome As FontAwesome.Sharp.IconPictureBox


End Class
