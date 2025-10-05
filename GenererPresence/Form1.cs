using System.Diagnostics;

namespace GenererPresence
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ChargerTireurs();
        }

        private void ChargerTireurs()
        {
            listBox1.Items.Clear();
            var path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            List<string> tireurs = File.ReadAllLines(path + @"\" + "AllTireurs.txt").ToList();
            foreach (string tireur in tireurs)
            {
                string[] dataTireur = tireur.Split(';');
                listBox1.Items.Add(dataTireur[0] + " " + dataTireur[1]);
                listBox2.Items.Add(dataTireur[2]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RTB1.Text = "";
            RTB1.Text += "                " + "new JourDePrésence()" + Environment.NewLine;
            RTB1.Text += "                " + "{" + Environment.NewLine;
            RTB1.Text += "                " + "  DatePrésence = new DateTime(" + monthCalendar1.SelectionRange.Start.Year
                                + "," + monthCalendar1.SelectionRange.Start.Month + "," + monthCalendar1.SelectionRange.Start.Day + ")," + Environment.NewLine;
            RTB1.Text += "                " + "  EscrimeurId = new List<Guid>()" + Environment.NewLine;
            RTB1.Text += "                " + "  {" + Environment.NewLine;

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                var text = listBox1.GetItemText(listBox1.Items[i]);
                bool selected = listBox1.GetSelected(i);
                if (selected)
                {
                    RTB1.Text += "                    " + listBox2.Items[i].ToString() + "," + Environment.NewLine;
                }
            }
            RTB1.Text += "                " + "  }" + Environment.NewLine;
            RTB1.Text += "                " + "},";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(RTB1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe", Directory.GetCurrentDirectory() + @"\AllTireurs.txt");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ChargerTireurs();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            label5.Text = monthCalendar1.SelectionStart.Date.ToLongDateString() + "  (" + monthCalendar1.SelectionStart.Date.ToShortDateString() + ")";

        }
    }
}
