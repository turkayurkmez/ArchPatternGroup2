using System.Data.SqlClient;

namespace SingleResponsibility
{
    public partial class Form1 : Form
    {
        /*
         *  Bir objenin sadece bir sorumluluğu olmalı (Bir sorumluluk, birden fazla görevi kapsar).
         *  
         *  Bir sınıfta değişiklik yapmak için birden fazla sebebiniz varsa...
         */
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            decimal price = Convert.ToDecimal(textBoxPrice.Text);
            var rowCount = new ProductService().AddProduct(name, price);          
            var result = rowCount > 0 ? "Başarılı" : "Başarısız";
            MessageBox.Show(result);

        }
    }
}