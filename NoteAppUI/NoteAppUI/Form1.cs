using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Главное окно программы";
            this.Size = new Size(400, 250);

            //Создаем кнопку
            var button = new Button();
            button.Text = "Сменить заголовок окна";
            button.Size = new Size(150, 25);
            button.Location = new Point(150, 150);
            //Помещаем кнопку на форму
            this.Controls.Add(button);

            //Подписываем кнопку на обработчик
            button.Click += Button_Click;
            //Помещаем кнопку на форму
            this.Controls.Add(button);

            ColorComboBox.Items.Add(Color.Red);
            ColorComboBox.Items.Add(Color.Green);
            ColorComboBox.Items.Add(Color.Blue);
            ColorComboBox.Items.Add(Color.White);
            //Задать зеленый цвет по умолчанию
            ColorComboBox.SelectedIndex = 1;
        }
        //Обработчик события нажатия кнопки
        private void Button_Click(object sender, EventArgs e)
        {
            //Здесь пишем код, который должен выполняться
            // каждый раз при нажатии на кнопку.
            this.Text = "Новый заголовок";
        }

        private void NumberTextBox_TextChanged(object sender, EventArgs e)
        {
            //Получаем текст из текстового поля
            // в переменную типа string
            string text = NumberTextBox.Text;
            //int number = int.Parse(text); // Преобразование текста в целое число.
            //int.TryParse(text, out number); // Исключение для преобразования, возвращает булевый тип.
            int number;
            if (int.TryParse(text, out number))
            {
                if (number >= 0 && number <= 100)
                {
                    NumberTextBox.BackColor = Color.White;
                    this.Text = number.ToString();
                }
                else
                {
                    this.Text = "Число не входит в диапазон";
                    NumberTextBox.BackColor = Color.LightSalmon;
                }
            }
            else
            {
                this.Text = "Не число";
                NumberTextBox.BackColor = Color.LightSalmon;
            }
           
        }

        private void ColorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Color selectedColor;
            selectedColor = (Color)ColorComboBox.SelectedItem;
            this.BackColor = selectedColor;
        }
    }
}
