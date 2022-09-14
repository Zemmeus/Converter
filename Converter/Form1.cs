using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClassCalculator calcv = new ClassCalculator();


            double ingr = Convert.ToDouble(textBox2.Text); 
            double ingr2 = Convert.ToDouble(textBox5.Text);

            textBox9.Text = Convert.ToString(ClassCalculator.Remains(ingr, ingr2));
            textBox6.Text = Convert.ToString(textBox3.Text);
            textBox7.Text = Convert.ToString(textBox4.Text);
            textBox8.Text = Convert.ToString(textBox2.Text);
            string textuu1 = textBox1.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            var person = File.Exists("person.json") ? JsonConvert.DeserializeObject<ClassConverter2>(File.ReadAllText("person.json")) : new ClassConverter2
            {
                portion = Convert.ToDouble(textBox1.Text),
                ingredients = Convert.ToDouble(textBox2.Text),
                costofingredients = Convert.ToDecimal(textBox3.Text),
                costOfportion = Convert.ToDecimal(textBox4.Text),
                ingridientsofstock = Convert.ToDouble(textBox5.Text),
                amountofconingr = Convert.ToDouble(textBox6.Text),
                remainsOfIngr = Convert.ToDouble(textBox9.Text),
            };

            //var person = new ClassConverter2
            //{
            //    portion = Convert.ToDouble(textBox1.Text),
            //    ingredients = Convert.ToDouble(textBox2.Text),
            //    costofingredients = Convert.ToDecimal(textBox3.Text),
            //    costOfportion = Convert.ToDecimal(textBox4.Text),
            //    ingridientsofstock = Convert.ToDouble(textBox5.Text),
            //    amountofconingr = Convert.ToDouble(textBox6.Text),
            //    remainsOfIngr = Convert.ToDouble(textBox9.Text),
            //};

            //string jsonData = JsonConvert.SerializeObject(person);

            //var person2 = JsonConvert.DeserializeObject<ClassConverter2>(jsonData);

            File.WriteAllText   ("person.json", JsonConvert.SerializeObject(person));

            MessageBox.Show("Сохранено");


        }

    }

}