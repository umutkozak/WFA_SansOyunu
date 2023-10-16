namespace WFA_SansOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnBasla_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        Random rnd = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            int birinciAt = pictureBir.Width;
            int ikinciAt = pictureIki.Width;
            int ucuncuAt = pictureIki.Width;
            int bitis = lblFinish.Left;
            pictureBir.Left=pictureBir.Left+rnd.Next(5, 15);
            pictureIki.Left=pictureIki.Left+rnd.Next(5, 15);
            pictureUc.Left=pictureUc.Left+rnd.Next(5, 15);

            if (birinciAt+pictureBir.Left>=lblFinish.Left)
            {
                timer1.Stop();
                MessageBox.Show("Birinci Tay Kazandý");
            }
            else if (ikinciAt+pictureIki.Left>=lblFinish.Left)
            {
                timer1.Stop();
                MessageBox.Show("Ýkinci Tay Kazandý");
            }
            else if (ucuncuAt+pictureUc.Left>=lblFinish.Left)
            {
                timer1.Stop();
                MessageBox.Show("Son Tay Kazandý");
            }

        }

        private void btnSifirla_Click(object sender, EventArgs e)
        {
            pictureBir.Location=new Point(89, 39);
            pictureIki.Location=new Point(89, 138);
            pictureUc.Location=new Point(89, 239);


        }
    }
}