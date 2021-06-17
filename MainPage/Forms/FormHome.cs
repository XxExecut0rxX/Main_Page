using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MainPage.Forms
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        //SQL conection
        SqlConnection SqlConnection;
        String SQLconnect, sqlsel;
        private DataTable dataT1;
        private SqlDataAdapter dataAdapter;
        int row;
        SqlCommandBuilder sqlCommandBuilder;
        DataRow dataRow;

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //rude
            if (char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;

            //enter
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                e.Handled = false;
        }

        private void tb_ci_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;

            //enter
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                e.Handled = false;
        }

        private void tb_ap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
                e.Handled = false;
            else if (char.IsSeparator(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;

            //enter
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                e.Handled = false;
        }

        private void tb_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
                e.Handled = false;
            else if (char.IsSeparator(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;

            //enter
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                e.Handled = false;
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            //connection SQL
            SQLconnect = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=School;Integrated Security=True";

            SqlConnection = new SqlConnection(SQLconnect);

            sqlsel = "SELECT * FROM Student ORDER BY rude";

            dataAdapter = new SqlDataAdapter(sqlsel, SqlConnection);
            sqlCommandBuilder = new SqlCommandBuilder(dataAdapter);
            sqlCommandBuilder.QuotePrefix = "[";
            sqlCommandBuilder.QuoteSuffix = "]";

            dataAdapter.UpdateCommand = sqlCommandBuilder.GetUpdateCommand();
            dataAdapter.InsertCommand = sqlCommandBuilder.GetUpdateCommand();
            dataAdapter.DeleteCommand = sqlCommandBuilder.GetUpdateCommand();
            dataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            dataT1 = new DataTable();

            dataAdapter.Fill(dataT1);
            
            if (dataT1.Rows.Count > 0)
            {
                dataRow = dataT1.Rows[row];
                row++;
            }
            else
                row--;

            dgv_student.DataSource = dataT1;
            
        }
    }
}
