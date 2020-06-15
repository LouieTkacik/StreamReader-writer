using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;  //allows for stream reader and writer

//The testanswers.txt file
//1. B    2. D    3. A    4. A    5. C
//6. A    7. B    8. A    9. C    10. D
//11. B    12. C    13. D    14. A    15. D
//16. C    17. C    18. B    19. D    20. A
namespace TKACIKDriversLicenseExam
{
    public partial class Form1 : Form
    {
        //public arrays for the file and for the answer key
        //public variable for score
        int score = 0;
        int wrong = 0;
        const int SIZE = 20;
        string[] answerKey = new string[SIZE];
        string[] studentAnswers = new string[SIZE];
        // readers
        StreamReader readKey = new StreamReader("testanswers.txt");
        StreamReader studentKey = new StreamReader("studentanswers.txt");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Button below to handle reading the file
        private void readbutton_Click(object sender, EventArgs e)
        {
            //calls a method to read the files and put them into arrays
            convert_files();
            //Calls a method to score the array
            grade_score();
            wrong = 20 - score;

            //output() outputs everything EXCEPT for the list which is added as the array is compared. 
            output();
        }
        //this method reads BOTH files and puts them into the arrays
        private void convert_files()
        {
            int count = 0;
            string holder;
            while((holder=studentKey.ReadLine()) != null)
            {
                studentAnswers[count] = holder;
                count++;
            }
            int countTwo = 0; //functions as a count but I just wanna be safe
            string holderTwo; //same thing
            while((holderTwo=readKey.ReadLine()) != null)
            {
                answerKey[countTwo] = holderTwo;
                countTwo++;
            }
        


        }
        //this method reads the array and compares it to the answer key
        private void grade_score()
        {

            //final score will be put into score
            //if clause used to compare contents of array
            int count = 0;
            while (count > 20)
            {
                if (answerKey[count] == studentAnswers[count])
                {
                    score++;
                }
                else
                {
                    listOfWrong.Items.Add(studentAnswers[count]);
                }

                count++;

            }
            
           
        }
        private void output()
        {

        }

    }
}
