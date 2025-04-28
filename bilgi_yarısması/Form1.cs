namespace bilgi_yarısması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int soruno = 0, dogruno = 0, yanlısno = 0;


        private void btnsonraki_Click(object sender, EventArgs e)
        {
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnc.Enabled = true;
            btnd.Enabled = true;
            btnsonraki.Enabled = false;


            soruno++;
            lblsoruno.Text = soruno.ToString();
            if (soruno == 1)
            {
                richTextBox1.Text = "1.Türkiye'nin en büyük dağı hangisidir ?";
                btnA.Text = "Erciyes Dağı ";
                btnB.Text = "Kaçkar Dağı ";
                btnc.Text = "Ağrı Dağı";
                btnd.Text = "Uludağ";
                label4.Text = "Ağrı Dağı";

            }
            if (soruno == 2)
            {
                richTextBox1.Text = "2. Mona Lisa tablosunun ressamı kimdir?";
                btnA.Text = "Pablo Picasso";
                btnB.Text = "Leonardo da Vinci";
                btnc.Text = "Vincent van Gogh";
                btnd.Text = "Michelangelo";
                label4.Text = "Leonardo da Vinci";

            }
            if (soruno == 3)
            {
                richTextBox1.Text = "3. 'Sefiller' romanının yazarı kimdir ?";
                btnA.Text = "Charles Dickens";
                btnB.Text = "Lev Tolstoy";
                btnc.Text = "Victor Hugo";
                btnd.Text = "Franz Kafka";
                label4.Text = "Victor Hugo";
            }
            if (soruno == 4)
            {
                richTextBox1.Text = "4. Hangi gezegen Güneş Sistemi'nde en büyük gezegendir ?";
                btnA.Text = "Dünya";
                btnB.Text = "Mars";
                btnc.Text = "Jüpiter";
                btnd.Text = "Satürn";
                label4.Text = "Jüpiter";
            }
            if (soruno == 5)
            {
                richTextBox1.Text = "5. Türkiye'nin yüzölçümü en büyük ili hangisidir ?";
                btnA.Text = "Sivas";
                btnB.Text = "Konya";
                btnc.Text = "Ankara";
                btnd.Text = "Erzurum";
                label4.Text = "Konya";
                btnsonraki.Text = "Sonuç";

            }
            string durum;
            if (dogruno >= 3)
            {
                durum = "Genel Kültürünüz iyi,tebrikler";

            }
            else
            {
                durum = "Genel Kültürünüz kötü,biraz daha çalışın";

            }



            if (soruno == 6)
            {
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnc.Enabled = false;
                btnd.Enabled = false;
                btnsonraki.Enabled = false;
                lblsoruno.Text = "5";
                MessageBox.Show("Doğru : " + dogruno + "\n" + "Yanlış :" + yanlısno + "\n" + durum, "Bilgi", MessageBoxButtons.OK);
            }

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;



        }

        private void btnA_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btnsonraki.Enabled = true;
            label5.Text = btnA.Text;
            if (label4.Text == label5.Text)
            {
                dogruno++;
                lbldogru.Text = dogruno.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlısno++;
                lblyanlıs.Text = yanlısno.ToString();
                pictureBox2.Visible = true;

            }

        }

        private void btnB_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btnsonraki.Enabled = true;
            label5.Text = btnB.Text;
            if (label4.Text == label5.Text)
            {
                dogruno++;
                lbldogru.Text = dogruno.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlısno++;
                lblyanlıs.Text = yanlısno.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btnsonraki.Enabled = true;
            label5.Text = btnc.Text;
            if (label4.Text == label5.Text)
            {
                dogruno++;
                lbldogru.Text = dogruno.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlısno++;
                lblyanlıs.Text = yanlısno.ToString();
                pictureBox2.Visible = true;

            }
        }

        private void btnd_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btnsonraki.Enabled = true;
            label5.Text = btnd.Text;
            if (label4.Text == label5.Text)
            {
                dogruno++;
                lbldogru.Text = dogruno.ToString();
                pictureBox1.Visible = true;
            }
            else
            {

                yanlısno++;
                lblyanlıs.Text = yanlısno.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
