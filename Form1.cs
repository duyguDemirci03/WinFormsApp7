namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime bugun = DateTime.Now;
            listBox1.Items.Add(bugun);
            listBox1.Items.Add(bugun.ToString());
            listBox1.Items.Add(bugun.ToLongDateString());
            listBox1.Items.Add(bugun.ToLongTimeString());
            listBox1.Items.Add(bugun.Day);
            listBox1.Items.Add(bugun.Month);
            listBox1.Items.Add(bugun.Year);
            listBox1.Items.Add(bugun.Hour);
            listBox1.Items.Add(bugun.Minute);
            listBox1.Items.Add(bugun.Second);
            listBox1.Items.Add(bugun.AddDays(6).ToString("dd.MM.yyyy"));

            DateTime tarih = new DateTime(2024, 11, 23,7,31,13);
            listBox1.Items.Add(tarih);
            listBox1.Items.Add(tarih.ToString());

            DateTime tarih1 = DateTime.Now;
            listBox1.Items.Add(tarih1.ToString("d"));
            listBox1.Items.Add(tarih1.ToString("D"));
            listBox1.Items.Add(tarih1.ToString("f"));
            listBox1.Items.Add(tarih1.ToString("F"));
            listBox1.Items.Add(tarih1.ToString("g"));
            listBox1.Items.Add(tarih1.ToString("G"));
            listBox1.Items.Add(tarih1.ToString("m"));
            listBox1.Items.Add(tarih1.ToString("M"));

            DateTime tarih2 = new DateTime(2022, 3, 25, 18, 30, 20);
            DateTime tarih3 = new DateTime(2023, 6, 13, 8, 50, 19);


            TimeSpan fark= tarih3 - tarih2;
            listBox1.Items.Add(fark.Days);
            listBox1.Items.Add(fark.TotalDays);
            listBox1.Items.Add(fark.Hours);
            listBox1.Items.Add(fark.TotalHours);




        }
    }
}