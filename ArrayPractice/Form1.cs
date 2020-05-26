using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ArrayPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            // Create 2 arrays to hold 10 values each
            int[] array1 = new int[10];
            int[] array2 = new int[10];

            // variables that can be used to determine outcomes of questions
            int samePosition = 0;
            double average = 0;
            double sum = 0;

            Random randGen = new Random();

            //1. Generate random values for both pre-created arrays
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = randGen.Next(0, 11);
            }
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = randGen.Next(0, 11);
            }
            //2. Display array 1
            for (int i = 0; i < array1.Length; i++)
            {
                array1Output.Text += $"{array1[i]} ";
            }

            //3. Display array 2
            for (int i = 0; i < array2.Length; i++)
            {
                array2Output.Text += $"{array2[i]} ";
            }

            //4. Display array 1 in reverse order
            for (int i = array1.Length -1; i >= 0; i--)
            {
                reverseOutput.Text += $"{array1[i]} ";
            }

            //5. Determine and display the largest value in array 1      
            int[] tempArray = array1;
            Array.Sort(tempArray);
            maxOutput.Text = Convert.ToString(tempArray[9]);

            //6.Determine and display the average of all values in array 1

            for (int i = array1.Length -1; i >= 0; i--)
            {
                average += array1[i];
            }
            average /= array1.Length;
            averageOutput.Text = Convert.ToString(average);
            //7. Determine and display the sum of all even values in array 1
            for (int i = array1.Length -1; i >= 0; i--)
            {
                if (array1[i] % 2 == 0)
                {
                    sum += array1[i];
                }
            }
            evenOutput.Text = Convert.ToString(sum);
            //8. Determine and display the number of 3s in array 1
            int threes = 0;
            for (int i = array1.Length -1; i >= 0; i--)
            {
                if (array1[i]== 3)
                {
                    threes++;
                }
            }
            threeOutput.Text = Convert.ToString(threes);

            //9. Determine and display how many matching numbers in matching positions between the 2 arrays there are
            for (int i = array1.Length -1; i >= 0; i--)
            {
                if (array1[i] == array2[i])
                {
                   samePosition++;
                }
            }
            matchOutput.Text = Convert.ToString(samePosition);

            // ----------------------
            // ##### ENRICHMENT #####
            // ----------------------


            //1. Determine and display at what index is the first 0 in array 1, (show "null" if no 0 exists)
            int zeroIndex = 99;
            for (int i = array1.Length -1; i >= 0; i--)
            {
                if (array1[i] == 0)
                {
                    zeroIndex = i;
                    zeroOutput.Text = Convert.ToString(zeroIndex);
                    break;
                }
            }
            if (zeroIndex == 99)
            {
                zeroOutput.Text = "null";
            }
            //2. swap and display all values between array1 and array2
            tempArray = array1;
            array1 = array2;
            array2 = tempArray;
            for (int i = array1.Length -1; i >= 0; i--)
            {
                swap1Output.Text += array1[i] + " ";
                swap2Output.Text += array2[i] + " ";
            }
            
            
        }
    }
}
