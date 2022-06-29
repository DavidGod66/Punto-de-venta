Public Class Form1
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxProductos.SelectedIndexChanged
        Dim Can0, Pre0 As Double
        Select Case ComboBoxProductos.SelectedIndex
            Case 0
                Pre0 = 1000
                TxtPrecio.Text = Pre0
                Can0 = 1
                TxtCantidad.Text = Can0
            Case 1
                Pre0 = 10000
                TxtPrecio.Text = Pre0
                Can0 = 1
                TxtCantidad.Text = Can0
            Case 2
                Pre0 = 3500
                TxtPrecio.Text = Pre0
                Can0 = 1
                TxtCantidad.Text = Can0
            Case 3
                Pre0 = 8000
                TxtPrecio.Text = Pre0
                Can0 = 1
                TxtCantidad.Text = Can0
            Case 4
                Pre0 = 5000
                TxtPrecio.Text = Pre0
                Can0 = 1
                TxtCantidad.Text = Can0
        End Select
    End Sub
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Dim Total0, Total1, Total2, Total3, Total4 As Double
        Total0 = (TxtPrecio.Text * TxtCantidad.Text)
        Total1 = (TxtPrecio.Text * TxtCantidad.Text)
        Total2 = (TxtPrecio.Text * TxtCantidad.Text)
        Total3 = (TxtPrecio.Text * TxtCantidad.Text)
        Total4 = (TxtPrecio.Text * TxtCantidad.Text)
        Select Case ComboBoxProductos.SelectedIndex
            Case 0
                ListBoxProductos.Items.Add("Carretilla" & " " & "$" & Total0)
                ListBoxPrecios.Items.Add(Total0)
            Case 1
                ListBoxProductos.Items.Add("varillas" & " " & "$" & Total1)
                ListBoxPrecios.Items.Add(Total1)
            Case 2
                ListBoxProductos.Items.Add("bloques" & " " & "$" & Total2)
                ListBoxPrecios.Items.Add(Total2)
            Case 3
                ListBoxProductos.Items.Add("barro bloques" & " " & "$" & Total3)
                ListBoxPrecios.Items.Add(Total3)
            Case 4
                ListBoxProductos.Items.Add("cemento" & " " & "$" & Total4)
                ListBoxPrecios.Items.Add(Total4)
        End Select

    End Sub

    Private Sub BtnCalPreci_Click(sender As Object, e As EventArgs) Handles BtnCalPreci.Click
        Dim Precios As Integer
        For Each item In ListBoxPrecios.Items
            Precios += item.ToString
        Next
        TxtSubTotal.Text = Precios
        TxtTotal.Text = ((Precios * 0.16) + Precios)
    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click
        ComboBoxProductos.Text = "Seleccione un Producto"
        TxtPrecio.Text = "---"
        TxtCantidad.Text = "---"
        ListBoxPrecios.Items.Clear()
        ListBoxProductos.Items.Clear()
        TxtSubTotal.Text = "---"
        TxtTotal.Text = "---"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'FerreteriaDataSet.productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.FerreteriaDataSet.productos)

    End Sub

    Private Sub ListBoxProductos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxProductos.SelectedIndexChanged

    End Sub
End Class
