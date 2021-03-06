﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace LP_projecto_final_Emanuel
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
     
            try {

                DateTime datanascimento = new DateTime(Convert.ToInt16(this.comboBox3.SelectedItem), Convert.ToInt16(this.comboBox1.SelectedItem),
                    Convert.ToInt16(this.comboBox2.SelectedItem));

                if (this.pictureBox2.Image == null)
                {
                    this.clienteTableAdapter.Insert(this.textBox1.Text,
                        this.textBox2.Text, this.textBox3.Text,this.textBox8.Text, datanascimento,
                        this.textBox5.Text, this.textBox6.Text, "", null);
                }
                else
                {
                    MemoryStream ms = new MemoryStream();
                    pictureBox2.Image.Save(ms, pictureBox2.Image.RawFormat);
                    Byte[] data = ms.GetBuffer();

                    this.clienteTableAdapter.Insert(this.textBox1.Text,
                       this.textBox2.Text, this.textBox3.Text, this.textBox8.Text, datanascimento,
                       this.textBox5.Text, this.textBox6.Text, "", data);
                }

                MessageBox.Show("Inserido novo Cliente");
                this.Close();
            }
            catch (Exception ex) {
                MessageBox.Show("ERRO" + ex.ToString());
            }
        }

    


        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
          

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            
            

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Close();
          
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (this.textBox1.Text == "")
                errorProvider1.SetError(this.textBox1, "nao pode ser vazio");
            else
            {
                errorProvider1.SetError(this.textBox1, "");
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (this.textBox2.Text == "")
                errorProvider1.SetError(this.textBox2, "nao pode ser vazio");
            else
            {
                errorProvider1.SetError(this.textBox2, "");
            }
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (this.textBox3.Text == "")
                errorProvider1.SetError(this.textBox3, "nao pode ser vazio");
            else
            {
                errorProvider1.SetError(this.textBox3, "");
            }
        }

        private void textBox8_Validating(object sender, CancelEventArgs e)
        {
            if (this.textBox8.Text == "")
                errorProvider1.SetError(this.textBox8, "nao pode ser vazio");
            else
            {
                errorProvider1.SetError(this.textBox8, "");
            }
        }

        private void textBox5_Validating(object sender, CancelEventArgs e)
        {
            if (this.textBox5.Text == "")
                errorProvider1.SetError(this.textBox5, "nao pode ser vazio");
            else
            {
                errorProvider1.SetError(this.textBox5, "");
            }
        }

        private void textBox6_Validating(object sender, CancelEventArgs e)
        {
            if (this.textBox6.Text == "")
                errorProvider1.SetError(this.textBox6, "nao pode ser vazio");
            else
            {
                errorProvider1.SetError(this.textBox6, "");
            }
        }

        private void textBox7_Validating(object sender, CancelEventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form8 frm = new Form8();
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form13 frm = new Form13();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try {
                this.openFileDialog1.FileName = null;
                this.openFileDialog1.Filter = "Fotografias | *.gif;*.jpg;*.png";
                this.openFileDialog1.ShowDialog();

                if (openFileDialog1.FileName != null) {
                    this.pictureBox2.ImageLocation = openFileDialog1.FileName;
                    this.pictureBox2.Image = Image.FromFile(openFileDialog1.FileName);
                }
            }
            catch {
                MessageBox.Show("Erro ao escolher imagem");
            }

        
          
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.pictureBox2.Image = null;
        }
    }
}
