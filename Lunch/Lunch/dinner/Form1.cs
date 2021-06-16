using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            #region Чтение данных

            var pathForRead = @"C:\Users\Мария\Desktop\Lunch\Lunch\Menu.txt";
            var input = "";
            
            try
            {
                using var sr = new StreamReader(pathForRead);
                input = sr.ReadToEnd();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            #endregion

            #region Форматирование данных и добавление меню

            var dishes = input
                .Split(';')
                .Select(str => str.Split())
                .Select(pair => new Dish(pair[0], Convert.ToInt32(pair[1])))
                .ToList();

            checkedListBox1.DataSource = dishes;

            #endregion
        }

        private void calculation_Click(object sender, EventArgs e)
        {
            var sum = checkedListBox1.CheckedItems
                .Cast<Dish>()
                .Select(x => x.Price)
                .Sum();
            
            label1.Text = $"Сумма заказа: {sum}";
        }
    }

    class Dish
    {
        public readonly string Name;
        public readonly int Price;

        public Dish(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString() => $"{Name}: {Price} руб.";
    }
}
