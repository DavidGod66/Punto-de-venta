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
        Me.ComboBoxProductos = New System.Windows.Forms.ComboBox()
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FerreteriaDataSet = New WindowsApplication1.FerreteriaDataSet()
        Me.TxtPrecio = New System.Windows.Forms.TextBox()
        Me.TxtCantidad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ListBoxProductos = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.BtnBorrar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtSubTotal = New System.Windows.Forms.TextBox()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.BtnCalPreci = New System.Windows.Forms.Button()
        Me.ProductosTableAdapter = New WindowsApplication1.FerreteriaDataSetTableAdapters.productosTableAdapter()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FerreteriaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBoxProductos
        '
        Me.ComboBoxProductos.DataSource = Me.ProductosBindingSource
        Me.ComboBoxProductos.DisplayMember = "Nombre_producto"
        Me.ComboBoxProductos.FormattingEnabled = True
        Me.ComboBoxProductos.Location = New System.Drawing.Point(12, 78)
        Me.ComboBoxProductos.Name = "ComboBoxProductos"
        Me.ComboBoxProductos.Size = New System.Drawing.Size(145, 39)
        Me.ComboBoxProductos.TabIndex = 0
        Me.ComboBoxProductos.ValueMember = "precioV_producto"
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "productos"
        Me.ProductosBindingSource.DataSource = Me.FerreteriaDataSet
        '
        'FerreteriaDataSet
        '
        Me.FerreteriaDataSet.DataSetName = "FerreteriaDataSet"
        Me.FerreteriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TxtPrecio
        '
        Me.TxtPrecio.Location = New System.Drawing.Point(176, 78)
        Me.TxtPrecio.Multiline = True
        Me.TxtPrecio.Name = "TxtPrecio"
        Me.TxtPrecio.Size = New System.Drawing.Size(99, 39)
        Me.TxtPrecio.TabIndex = 1
        '
        'TxtCantidad
        '
        Me.TxtCantidad.Location = New System.Drawing.Point(293, 78)
        Me.TxtCantidad.Multiline = True
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.Size = New System.Drawing.Size(99, 39)
        Me.TxtCantidad.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 31)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Productos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(170, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 31)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Precio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(287, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 31)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Cantidad"
        '
        'ListBoxProductos
        '
        Me.ListBoxProductos.FormattingEnabled = True
        Me.ListBoxProductos.ItemHeight = 31
        Me.ListBoxProductos.Location = New System.Drawing.Point(412, 30)
        Me.ListBoxProductos.Name = "ListBoxProductos"
        Me.ListBoxProductos.Size = New System.Drawing.Size(216, 190)
        Me.ListBoxProductos.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(170, 234)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(216, 31)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "SubTotal(SinIVA)"
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(12, 123)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(124, 46)
        Me.BtnAgregar.TabIndex = 8
        Me.BtnAgregar.Text = "Agregar Producto a la Lista"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'BtnBorrar
        '
        Me.BtnBorrar.Location = New System.Drawing.Point(164, 123)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(111, 47)
        Me.BtnBorrar.TabIndex = 9
        Me.BtnBorrar.Text = "Borrar Todo"
        Me.BtnBorrar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(170, 279)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(181, 31)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Total(ConIVA)"
        '
        'TxtSubTotal
        '
        Me.TxtSubTotal.Location = New System.Drawing.Point(401, 234)
        Me.TxtSubTotal.Multiline = True
        Me.TxtSubTotal.Name = "TxtSubTotal"
        Me.TxtSubTotal.Size = New System.Drawing.Size(121, 39)
        Me.TxtSubTotal.TabIndex = 12
        '
        'TxtTotal
        '
        Me.TxtTotal.BackColor = System.Drawing.SystemColors.Menu
        Me.TxtTotal.Location = New System.Drawing.Point(401, 279)
        Me.TxtTotal.Multiline = True
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(121, 39)
        Me.TxtTotal.TabIndex = 13
        '
        'BtnCalPreci
        '
        Me.BtnCalPreci.Location = New System.Drawing.Point(12, 205)
        Me.BtnCalPreci.Name = "BtnCalPreci"
        Me.BtnCalPreci.Size = New System.Drawing.Size(124, 55)
        Me.BtnCalPreci.TabIndex = 14
        Me.BtnCalPreci.Text = "Calcular Precios de la Lista" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BtnCalPreci.UseVisualStyleBackColor = True
        '
        'ProductosTableAdapter
        '
        Me.ProductosTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(15.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(644, 346)
        Me.Controls.Add(Me.BtnCalPreci)
        Me.Controls.Add(Me.TxtTotal)
        Me.Controls.Add(Me.TxtSubTotal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BtnBorrar)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ListBoxProductos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtCantidad)
        Me.Controls.Add(Me.TxtPrecio)
        Me.Controls.Add(Me.ComboBoxProductos)
        Me.Font = New System.Drawing.Font("Times New Roman", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.Name = "Form1"
        Me.Text = "Punto de venta Ferreteria Los Socios"
        Me.TransparencyKey = System.Drawing.Color.Aqua
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FerreteriaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBoxProductos As System.Windows.Forms.ComboBox
    Friend WithEvents TxtPrecio As System.Windows.Forms.TextBox
    Friend WithEvents TxtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ListBoxProductos As System.Windows.Forms.ListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BtnAgregar As System.Windows.Forms.Button
    Friend WithEvents BtnBorrar As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtSubTotal As System.Windows.Forms.TextBox
    Friend WithEvents TxtTotal As System.Windows.Forms.TextBox
    Friend WithEvents BtnCalPreci As System.Windows.Forms.Button
    Friend WithEvents FerreteriaDataSet As FerreteriaDataSet
    Friend WithEvents ProductosBindingSource As BindingSource
    Friend WithEvents ProductosTableAdapter As FerreteriaDataSetTableAdapters.productosTableAdapter
End Class
