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
        private void bt_save_MouseClick(object sender, MouseEventArgs e)
        {
            // guardar cambios del registro insertado a la tabla estudiante

            bool bandera = true;
            dataRow = dataT1.NewRow();
            dataRow["rude"] = tb_rude.Text;
            dataRow["CI"] = tb_ci.Text;
            dataRow["name"] = tb_name.Text;
            dataRow["last_names"] = tb_name.Text;
            dataRow["address"] = tb_name.Text;
            dataRow["cell"] = tb_cel.Text;
            dataRow["Birthday"] = dtp_birth.Text;

            /*PARA EL SEXO DEL ESTUDIANTE*/
            if (rb_male.Checked)
                dataRow["gender"] = "H";
            else
                dataRow["gender"] = "M";
            // guardar datos en la tabla academicos
            dataRow["rude"] = tb_rude.Text;

            /*PARA EL CURSO en la tabla academicos*/
            if (rb_c1.Checked)
                dataRow["Course"] = "1";
            else if (rb_c2.Checked)
                dataRow["Course"] = "2";
            else if (rb_c3.Checked)
                dataRow["Course"] = "3";
            else if (rb_c4.Checked)
                dataRow["Course"] = "4";
            else if (rb_c5.Checked)
                dataRow["Course"] = "5";
            else
                dataRow["Course"] = "6";
            // para paralelo en la tabla academicos
            if (rb_ca.Checked)
                dataRow["Parallel"] = "A";
            else if (rb_cb.Checked)
                dataRow["Parallel"] = "B";
            else
                dataRow["Parallel"] = "C";
            if (bandera)
            {
                // guarda datos en las dos tablas cuando es registro nuevo
                dataT1.Rows.Add(dataRow);
                bandera = false;
            }
            else
                // guarda datos en la tabla academicos de regulares
                dataT1.Rows.Add(dataRow);
            try

            {

                dataAdapter.Update(dataT1);
                dataT1.AcceptChanges();

                //dt1.AcceptChanges();
                if (Convert.ToInt32("0" + dataRow["rude"].ToString()) == 0)
                {
                    dataT1 = new DataTable();
                    dataAdapter.Fill(dataT1);
                }
                row = dataT1.Rows.Count - 1;
            }
            catch (DBConcurrencyException ex)
            {
                MessageBox.Show("Error de concurrencia:\n" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            //connection SQL
            SQLconnect = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=School;Integrated Security=True";

            SqlConnection = new SqlConnection(SQLconnect);

            sqlsel = "SELECT * Student ORDER BY rude";

            dataAdapter = new SqlDataAdapter(sqlsel, SqlConnection);
            sqlCommandBuilder = new SqlCommandBuilder(dataAdapter);
            sqlCommandBuilder.QuotePrefix = "[";
            sqlCommandBuilder.QuoteSuffix = "]";

            dataAdapter.UpdateCommand = sqlCommandBuilder.GetUpdateCommand();
            dataAdapter.InsertCommand = sqlCommandBuilder.GetInsertCommand();
            dataAdapter.DeleteCommand = sqlCommandBuilder.GetDeleteCommand();
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

        }
    }
}
