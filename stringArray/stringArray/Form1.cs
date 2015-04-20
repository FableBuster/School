using System;
using System.Windows.Forms;

namespace stringArray
{
    public partial class Form1 : Form
    {
        //Fields
        private Persoon _zwartePiet;
        private Persoon _sinterKlaas;
        private string[] _myArray;


        public Form1()
        {
            InitializeComponent();

            //Initializing an array with 10 elements
            _myArray = new string[10];

            //Initializing two Persoon objects
            _sinterKlaas = new Persoon("SinterKlaas");
            _zwartePiet = new Persoon("Zwarte Piet");
        }


        //Method
        private void WhileArray()
        {
        
            int i = 10;
            while (i > 0)
            {
                i--;
                if (i != 3)
                {
                    _myArray[i] = "AAA";
                    listBoxArrays.Items.Add(_myArray[i]);
           
                }
                else
                {
                    _myArray[i] = "ZZZ";
                    listBoxArrays.Items.Add(_myArray[i]);
                }
               
            }
        }

        //Method
        private void ForArray()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i != 3)
                {
                    _myArray[i] = "AAA";
                    listBoxArrays.Items.Add(_myArray[i]);
                }
                else
                {
                    _myArray[i] = "ZZZ";
                    listBoxArrays.Items.Add(_myArray[i]);
                }
            }
        }


        //Method
        public void PietSintArray()
        {
            Persoon[] persoon = new Persoon[10];
            for (int i = 0; i < 10; i++)
            {
                if (i != 2)
                {
                    persoon[i] = _zwartePiet;
                    listBoxArrays.Items.Add(persoon[i].Naam);
                }
                else
                {
                    persoon[i] = _sinterKlaas;
                    listBoxArrays.Items.Add(persoon[i].Naam);
                }
            }
        }


        //Method
        public void PietSintArrayThirtyElements()
        {
            Persoon[] persoon = new Persoon[30];
            for (int i = 0; i < 30; i++)
            {
                if (i != 2)
                {
                    persoon[i] = _zwartePiet;
                    listBoxArrays.Items.Add(persoon[i].Naam);
                }
                else
                {
                    persoon[i] = _sinterKlaas;
                    listBoxArrays.Items.Add(persoon[i].Naam);
                }
            }
        }


        
        private void btnAddWhile_Click(object sender, EventArgs e)
        {
            listBoxArrays.Items.Add("While Loop:");
            WhileArray();
            LineSpace();
        }

        private void btnForLoop_Click(object sender, EventArgs e)
        {
            listBoxArrays.Items.Add("For Loop:");
            ForArray();
            LineSpace();
        }

        private void btnCleanListBox_Click(object sender, EventArgs e)
        {
            listBoxArrays.Items.Clear();
        }

        private void btnSintPiet_Click(object sender, EventArgs e)
        {
            listBoxArrays.Items.Add("10 elements for loop:");
            PietSintArray();
            LineSpace();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBoxArrays.Items.Add("30 elements for loop:");
            PietSintArrayThirtyElements();
            LineSpace();
        }

        private void btnAddAll_Click(object sender, EventArgs e)
        {
            listBoxArrays.Items.Add("While Loop:");
            WhileArray();
            LineSpace();
            listBoxArrays.Items.Add("For Loop:");
            ForArray();
            LineSpace();
            listBoxArrays.Items.Add("10 elements for loop:");
            PietSintArray();
            LineSpace();
            listBoxArrays.Items.Add("30 elements for loop:");
            PietSintArrayThirtyElements();
            LineSpace();
        }

        private void LineSpace()
        {
            listBoxArrays.Items.Add("----------------------------------------------------------");
        }

    }
}
