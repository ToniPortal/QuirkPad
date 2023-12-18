using System;
using System.Windows.Forms;
using System.IO;

namespace NomDuProjet
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }

    public class MainForm : Form
    {
        private TextBox? myTextBox;
        private Button? myButton;

        public MainForm()
        {
            // Initialisation des composants
            InitializeComponent();
        }


        private string fileString = "test.txt";

        private void InitializeComponent()
        {
            // Ajoutez ici les initialisations des composants, par exemple :
            this.Text = "FalseNotPad";
            this.Size = new System.Drawing.Size(400, 300);

            // Créez et ajoutez d'autres contrôles ici
            // Exemple : Button, TextBox, Label, etc.

            myTextBox = new TextBox();
            myTextBox.Location = new System.Drawing.Point(50, 50);
            myTextBox.Size = new System.Drawing.Size(200, 25);
            myTextBox.Text = "test.txt";

            //Button :
            myButton = new Button();
            myButton.Text = "Click Me!";
            myButton.Location = new System.Drawing.Point(50, 100);
            myButton.Size = new System.Drawing.Size(100, 30);
            myButton.Click += readFile; // Assign an event handler


            // Add TextBox to the form
            this.Controls.Add(myTextBox);
            this.Controls.Add(myButton);


        }
        private void readFile(object? sender, EventArgs e)
        {
            if (myTextBox == null)
            {
                return;
            }
            else
            {
                fileString = myTextBox.Text;
            }
            // Handle the button click event
            if (File.Exists(fileString))
            {
                // Read entire text file content in one string
                string text = File.ReadAllText(fileString);
                Console.WriteLine(text);
            }
            else
            {
                Console.WriteLine("Il n'y pas de fichier a lire");
            }
        }

    }
}
