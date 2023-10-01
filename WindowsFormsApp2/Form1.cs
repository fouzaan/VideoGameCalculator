
/*
Fouzaan ahmed shaik nissar
Durham college.
Objected Oriented Programming 2
100857977
Form1.cs
 */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class WeeklySalesForm : Form
    {

        // variables
        int index = 0;
        int days = 1;
        int totalSum = 0;
        int[] salesDaily = new int[7];
        double totalWeeklyAvarageSales = 0;

        /*
         * This Function shows takes the entry text which is entred in the SalesEntry input box
         * Then it validates if that is a proper number or not.
         * If it is proper numer the again it also varifies if iit is zero or more than the limit of the text which is float 32
         * if all the conditions match it calls the function AddData()
         * if any one of the conditions fails it shwos a message box and focusing it again in the text
         *
         */
        public void ValidateUserEntry()
        {
            int sales = 0;
            // if statement for verifying and converting a string into a number.
            if (int.TryParse(this.SalesEntry.Text, out sales))
            {
                //checking if the number is grater than 0 and letter than the int32 bit
                if (!(sales >= 0 && sales <= 2147483647))
                {
                    // showing the error message when the inut is lessar than 0 or over than int32
                    MessageBox.Show("Invalid Value / out of range", "Hint: Intger Number required");
                    SalesEntry.Focus();
                }
                // calling the fuction add data
                AddData();

            } else
            {
                // showing the message when the input entred is not a number.
                MessageBox.Show("Invalid Value / out of range", "Hint: Intger Number required");
                // focusing it to the entry.
                SalesEntry.Focus();
            }
        }

        /*
         * This fuction gets triggred when the data is validated from the above function.
         * this function takes the text entered by the user and when the user presses,
         * enter it appends the string to the array and it increezes the days by one.
         */
        public void AddData()
        {
            // allocating the days variable to the DayLable.
            DayLable.Text = days.ToString();
            // This takes the inut entered by the user and cnverts into an int, then we are allocating it to the index in salesDaily array 
            salesDaily[index] = int.Parse(SalesEntry.Text);
            // here we are appending the text to the WholeSalesChart and adding \n
            // because nect time when a new text is added it ges to the new line.
            WholeSalesChart.AppendText(SalesEntry.Text + "\n");
            // Calling the CalculateAvarage function
            CalculateAvarage();
            // Clearing the user input 
            SalesEntry.Clear();
            // focusing it to the user input
            SalesEntry.Focus();
            // increasing the index by 1
            index++;
            // increasing the index by 1
            days++;

            // checking if the days is increased by 6 days
            // if is then we are disabling the user entry.
            if (index > 6 )
            {
                // clearing the user entry
                SalesEntry.Clear();
                // disabling the user entry
                SalesEntry.Enabled = false;
                // disabling the entry button
                button1.Enabled = false;

            }


        }
        /*
         * 
         * This function calculates the avarage of the sales
         */
        public void CalculateAvarage()
        {
            // it adds the total sum plus the user entry from the array
            totalSum += salesDaily[index];
            // here we are converting the totalSum to a double then we are using Math.Round to round the decimal to 2 digits.
            totalWeeklyAvarageSales = Math.Round((double)totalSum / days, 2);
            // this takes the total avarage and shows it in the lable 
            ShowAvarageGameSales.Text = "Average Video Game Sales: $" + totalWeeklyAvarageSales;
        }

        /*
         * This fuction resets every lable, value etc.
         */
        public void Reset()
        {
            // resetting the day 
            days = 1;
            // resetting the index
            index = 0;
            // resetting the totalsum
            totalSum = 0;
            // resetting the totalWeeklyAvarageSales
            totalWeeklyAvarageSales = 0;
            // clearing the text entred by the user
            SalesEntry.Clear();
            // clearing the whole sales chart
            WholeSalesChart.Clear();
            // resettng the lable for showing avarage 
            ShowAvarageGameSales.Text = "Average Video Game Sales: $";
            // resetting day lable
            DayLable.Text = "";
            // enabling the user entry
            SalesEntry.Enabled = true;
            // enabling the entry button
            button1.Enabled = true;
            // focusing it to the user entry
            SalesEntry.Focus();
        }
        public WeeklySalesForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DayLable_Click(object sender, EventArgs e)
        {

        }

        private void SalesEntry_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // calling the validate function when the enter button is clicked
            Validate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // resetting when user clicks reset
           
            Reset();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            // closing the form when close is pressed
            Close();
        }

        private void ShowAvarageGameSales_TextChanged(object sender, EventArgs e)
        {

        }

        private void SalesEntry_KeyDown(object sender, KeyEventArgs e)
        {
            // using the keys like enter and esc.
            if (e.KeyCode == Keys.Enter)
            {
                // When the user clicks the enter buttons it calls the validate fucntion
                ValidateUserEntry();
            }

            // when the esc button is clicked it closses the form.
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
