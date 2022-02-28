using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizzaci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        static int toplamTutar = 0;
        

        private void btnsiparisver_Click(object sender, EventArgs e)
        {
       
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> pizzalar = new List<string>();
            pizzalar.Add("Sosyal Pizza 30₺");           
            pizzalar.Add("Ballı Hardallı Tavuklu 25₺");
            pizzalar.Add("Vegi 34₺");
            pizzalar.Add("Fit & Fresh 40₺");
            pizzalar.Add("Dopdolu Extra 37₺");

            foreach (var pizza in pizzalar)
            {
                cbpizzalar.Items.Add(pizza);
            }
        }

        

        private void cbpizzalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cbpizzalar.SelectedIndex == 0)
            {
                toplamTutar += 30;
                label4.Text = toplamTutar.ToString();
                listBox1.Items.Add(cbpizzalar.SelectedItem);
            }
            
            else if (cbpizzalar.SelectedIndex == 1)
            {
                toplamTutar += 25;
                label4.Text = toplamTutar.ToString();
                listBox1.Items.Add(cbpizzalar.SelectedItem);
            }
            else if (cbpizzalar.SelectedIndex == 2)
            {
                toplamTutar += 34;
                label4.Text = toplamTutar.ToString();
                listBox1.Items.Add(cbpizzalar.SelectedItem);
            }
            else if (cbpizzalar.SelectedIndex == 3)
            {
                toplamTutar += 40;
                label4.Text = toplamTutar.ToString();
                listBox1.Items.Add(cbpizzalar.SelectedItem);
            }
            else if (cbpizzalar.SelectedIndex == 4)
            {
                toplamTutar += 37;
                label4.Text = toplamTutar.ToString();
                listBox1.Items.Add(cbpizzalar.SelectedItem);
            }
        }

        private void cbsalam_CheckedChanged(object sender, EventArgs e)
        {
            if (cbsalam.Checked == true)
            {
                int ucret = 2;
                toplamTutar += ucret;
                label4.Text = toplamTutar.ToString();
                listBox1.Items.Add(cbsalam.Text);
            }
            if (cbsalam.Checked == false)
            {
                int ucret = 2;
                toplamTutar -= ucret;
                label4.Text = toplamTutar.ToString();
                listBox1.Items.Remove(cbsalam.Text);
            }    
        }

        private void cbsosis_CheckedChanged(object sender, EventArgs e)
        {
            if (cbsosis.Checked == true)
            {
                int ucret = 2;
                toplamTutar += ucret;
                label4.Text = toplamTutar.ToString();
                listBox1.Items.Add(cbsosis.Text);
            }
            if (cbsosis.Checked == false)
            {                
                int ucret = 2;
                toplamTutar -= ucret;
                label4.Text = toplamTutar.ToString();
                listBox1.Items.Remove(cbsosis.Text);
            }
        }

        private void cbzeytin_CheckedChanged(object sender, EventArgs e)
        {
            if (cbzeytin.Checked == true)
            {
                int ucret = 2;
                toplamTutar += ucret;
                label4.Text = toplamTutar.ToString();
                listBox1.Items.Add(cbzeytin.Text);
            }
            if (cbzeytin.Checked == false)
            {
                int ucret = 2;
                toplamTutar -= ucret;
                label4.Text = toplamTutar.ToString();
                listBox1.Items.Remove(cbzeytin.Text);
            }
        }

        private void cbbiber_CheckedChanged(object sender, EventArgs e)
        {
            if (cbbiber.Checked == true)
            {
                int ucret = 2;
                toplamTutar += ucret;
                label4.Text = toplamTutar.ToString();
                listBox1.Items.Add(cbbiber.Text);
            }
            if (cbbiber.Checked == false)
            {
                int ucret = 2;
                toplamTutar -= ucret;
                label4.Text = toplamTutar.ToString();
                listBox1.Items.Remove(cbbiber.Text);
            }
        }

        private void cbdomates_CheckedChanged(object sender, EventArgs e)
        {
            if (cbdomates.Checked == true)
            {
                int ucret = 2;
                toplamTutar += ucret;
                label4.Text = toplamTutar.ToString();
                listBox1.Items.Add(cbdomates.Text);
            }
            if (cbdomates.Checked == false)
            {
                int ucret = 2;
                toplamTutar -= ucret;
                label4.Text = toplamTutar.ToString();
                listBox1.Items.Remove(cbdomates.Text);
            }
        }

        private void cbmantar_CheckedChanged(object sender, EventArgs e)
        {
            if (cbmantar.Checked == true)
            {
                int ucret = 2;
                toplamTutar += ucret;
                label4.Text = toplamTutar.ToString();
                listBox1.Items.Add(cbmantar.Text);
            }
            if (cbmantar.Checked == false)
            {
                int ucret = 2;
                toplamTutar -= ucret;
                label4.Text = toplamTutar.ToString();
                listBox1.Items.Remove(cbmantar.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            label4.Text = "";
        }

        
    }
}
