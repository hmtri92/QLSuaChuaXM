using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Forms;


namespace DeTai
{
    class Check
    {
        public bool CheckPhone(String value)
        {
            Regex phoneNumber = new Regex(@"^[0-9]\d{3}-\d{3}-\d{4}$");
            Regex phoneNumber2 = new Regex(@"^[0-9]\d{2}-\d{3}-\d{4}$");
            Regex phoneNumber3 = new Regex(@"^[0-9]\d{3}-\d{4}-\d{4}$");

            if (!phoneNumber.IsMatch(value) && !phoneNumber2.IsMatch(value) && !phoneNumber3.IsMatch(value))
            {
                return false;
            }

            return true;
        }

        public bool checkPhone(Control control)
        {
            if (checkEmpty(control) == false)
                return false;

            if (CheckPhone(control.Text) == false)
            {
                Color color = Color.Khaki;
                changeBackColor(control, color);
                return false;
            }

            return true;
        }

        public bool CheckBike(String value)
        {
            //Regex number = new Regex(@"^[0-9]\d{2}\^[a-z]d{1}\^[0-9]d{1}-\d{4}");

            //if (!number.IsMatch(value))
            //{
            //    //MessageBox.Show("Định dạng số xe không đúng(60y8-1234 hoặc 60y8-12345)", "Lỗi",
            //    //    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return false;
            //}
            return true;
        }

       public  bool checkEmpty(Control control)
        {
            Color color = Color.Khaki;
            if (control.Text == "")
            {
                changeBackColor(control, color);
                return false;
            }
            return true;
        }

        private void changeBackColor(Control control, Color color)
        {
            control.BackColor = color;
        }
    }
}
