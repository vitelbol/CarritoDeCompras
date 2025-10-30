namespace CarritoDeCompras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboProductos.Items.Add("Pantalon");
            cboProductos.Items.Add("Camisa");
            cboProductos.Items.Add("Zapatos");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string productoSeleccionado = cboProductos.SelectedItem.ToString();
            listCarritoDeCompras.Items.Add(productoSeleccionado);
        }
    }
}
