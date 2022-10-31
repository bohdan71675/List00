using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List00
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //****************************************
        //Vytvoření instance seznamfilmu třídy List
        //List bude obsahovat řetězce
        
        List<string> seznamfilmu = new List<string>();    //Vytvořili jsme prázdný list řetězců, do seznamu budeme ukládat názvy filmů

        //*****************************************

        private void button1_Click(object sender, EventArgs e)
        {
            //Metoda Add
            //(Jako řetězec zadejte název filmu)
            seznamfilmu.Add("aa");
            seznamfilmu.Add("bbaa");
            seznamfilmu.Add("ccaa");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Počet prvků v kolekci - metoda Count

            listBox1.Items.Clear();
            // *** cyklem foreach ***
            foreach (string s in seznamfilmu)
            {
                listBox1.Items.Add(s);
            }

            // *** cyklem for - přes indexy ***

            //for (int i = 0; i < seznamfilmu.Count; i++)
            //{
            //    listBox1.Items.Add(seznamfilmu[i]);
            //}
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //metoda Remove - odstraní první nalezený řetězec

            string film = textBox1.Text;

            if (!seznamfilmu.Remove(film))
            {
                MessageBox.Show("Film neni v seznamu");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Clear
           
            seznamfilmu.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //RemoveAt()

            int n = int.Parse(textBox2.Text);
            if (n < seznamfilmu.Count)
                seznamfilmu.RemoveAt(n);
            else
                MessageBox.Show("Index mimo rozsah");

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Contains
            string n = textBox3.Text;
            if (seznamfilmu.Contains(n))
            {
                MessageBox.Show("Ano obsahuje");
            }
            else
            {
                MessageBox.Show("Ne neobsahuje");
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //IndexOf

            string n = textBox4.Text;
            int index = seznamfilmu.IndexOf(n);
            MessageBox.Show("Index je " + index);
           
            //Pokud prvek v seznamu není, vrací metoda IndexOf() hodnotu -1
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //LastIndexOf
            
            string n = textBox4.Text;
            int lindex = seznamfilmu.LastIndexOf(n);
            MessageBox.Show("Index je " + lindex);

            //Pokud prvek není v List obsažen, vrátí index -1
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //Distinct
            //Vrátí List s odlišnými prvky

            seznamfilmu = seznamfilmu.Distinct().ToList();
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //Insert

            int index = int.Parse(textBox7.Text);
            string prvek = textBox8.Text;
            if (index < seznamfilmu.Count)
            {
                seznamfilmu.Insert(index, prvek);
            }
            else
            { MessageBox.Show("Index mimo rozsah"); }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //Count
            MessageBox.Show("Pocet prvku " + seznamfilmu.Count());

        }

        private void button12_Click(object sender, EventArgs e)
        {
            //index píšene stejně jako u pole v hranatých závorkách
            //1. prvek má index 0

            int index = int.Parse(textBox9.Text);
            MessageBox.Show("Prvek na indexu je " + seznamfilmu[index]);
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //Sort
            seznamfilmu.Sort();
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //Reverse
            seznamfilmu.Reverse();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //AddRange
            List<string> novySeznam = seznamfilmu.Take(2).ToList();
            foreach (string film in novySeznam) MessageBox.Show(film);
        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            string[] poleFilmu = new string[seznamfilmu.Count];
            seznamfilmu.CopyTo(poleFilmu);
            foreach (string film in poleFilmu) MessageBox.Show(film);
        }
    }
}
