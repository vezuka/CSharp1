using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guess
{
    public partial class Form2 : Form
    {

        Guess guess;

        private Form1 m_parent;


        public Form2(Form1 frm1)
        {
            InitializeComponent();
            guess = new Guess();
            lblTextForm.Text = "Введи сюда свое число";
            btnCheck.Text = "Проверить";
            this.Text = "Введи число";
            m_parent = frm1;
        }

        /// <summary>
        /// Считываем число, введенное пользователем
        /// </summary>
        public int userNumber
        {
            get
            {
                //return int.Parse(textNumber.Text);
                return GetNumber();
            }
          
           
        }

        /// <summary>
        /// Обрабатываем исключение, если введено не целое число
        /// </summary>
        /// <returns></returns>
        public int GetNumber()
        {
              
            int a;
            try
            {
                a = int.Parse(textNumber.Text);
            }
            catch
            {
                a = 0;
                MessageBox.Show("Вводи числа от 1 до 100!");
            }

            return a;

        }

        

        private void btnCheck_Click(object sender, EventArgs e)
        {
            guess.CountIncrement();
            m_parent.FormUpdate();
            bool check;
            MessageBox.Show(guess.CheckUserNumber(out check, userNumber));
            if (check)
            {
                this.Visible = false;
                guess.Reset();
                m_parent.FormUpdate();

            }
            textNumber.Text = null;

        }
    }
}
