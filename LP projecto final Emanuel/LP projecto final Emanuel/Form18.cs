using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LP_projecto_final_Emanuel
{
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
        }

        private void quartoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.quartoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void quartoBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.quartoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Form18_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Quarto' table. You can move, or remove it, as needed.
            this.quartoTableAdapter.Fill(this.database1DataSet.Quarto);

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
           try
            {

                this.quartoTableAdapter.Insert(Convert.ToInt32(this.textBox3.Text), textBox1.Text, Convert.ToInt16(textBox2.Text), Convert.ToString(comboBox1.SelectedValue), null, "livre");
                MessageBox.Show("Inserido novo Quarto !!");

            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 frm = new Form2();
            frm.ShowDialog();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (this.textBox1.Text == "")
                errorProvider1.SetError(this.textBox1, "nao pode ser vazio");
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (this.textBox2.Text == "")
                errorProvider1.SetError(this.textBox2, "nao pode ser vazio");
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Form19 frm = new Form19();
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            Form18 frm = new Form18();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {/*
            FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
            byte[] photo_aray = new byte[fs.Length];
            fs.Read(photo_aray, 0, photo_aray.Length);
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, ImageFormat.Jpeg);
            byte[] photo_aray = new byte[ms.Length];
            ms.Position = 0;
            ms.Read(photo_aray, 0, photo_aray.Length);*/
        }
    }
}