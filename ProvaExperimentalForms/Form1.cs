using Microsoft.Data.SqlClient;
using ProvaExperimentalForms.DataBase;
using ProvaExperimentalForms.Entities;
using System.Globalization;

namespace ProvaExperimentalForms
{
    public partial class Form1 : Form
    {
        ProductDAL productDAL = new ProductDAL();
        
        public Form1()
        {
            InitializeComponent();
            loadProducts();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = txtNome.Text;
                string descricao = textDescricao.Text;
                double price = double.Parse(textPreco.Text, CultureInfo.InvariantCulture);
                bool available = chekAvailable.Checked ? true : false;

                productDAL.AddProduct(new Product(nome, descricao, price, available));

                txtNome.Clear();
                textDescricao.Clear();
                textPreco.Clear();

                loadProducts();




                MessageBox.Show("Produto adicionado!", "Sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void lstProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void loadProducts()
        {
            //Configuração visual da lstProducts.
            lstProducts.View = View.Details;
            lstProducts.LabelEdit = true;
            lstProducts.AllowColumnReorder = true;
            lstProducts.FullRowSelect = true;
            lstProducts.GridLines = true;

            lstProducts.Columns.Add("Nome", 170, HorizontalAlignment.Left);
            lstProducts.Columns.Add("Preço", 900, HorizontalAlignment.Left);
           

            //carregamento da lista

            using var connection = new Connection().ObtainConnection();
            connection.Open();

            string sql = "SELECT * FROM Products ORDER BY Price ASC ";
            SqlCommand command = new SqlCommand(sql, connection);

            using var reader = command.ExecuteReader();

            var row_listview = new ListViewItem();
            lstProducts.Items.Clear();

            while (reader.Read())
            {
                string name = reader.GetString(1);
                decimal price = reader.GetDecimal(3);
                string priceString = price.ToString("F2");

                string[] row =
                {
                name,
                priceString,
                };
                row_listview = new ListViewItem(row);
                lstProducts.Items.Add(row_listview);
            }
        }
    }
}
