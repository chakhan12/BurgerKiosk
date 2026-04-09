namespace BurgerKiosk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            listBox1.Items.Clear();

            int totalCost = 0;

            if (HB.Checked)
            {
                listBox1.Items.Add("햄버거");
                totalCost += 5000;
            }
            else if (BHB.Checked)
            {
                listBox1.Items.Add("불고기버거");
                totalCost += 5500;
            }
            else if (CHB.Checked)
            {
                listBox1.Items.Add("치킨버거");
                totalCost += 5300;
            }


            if (PHOTO.Checked)
            {
                listBox1.Items.Add("- 감자튀김");
                totalCost += 1500;
            }
            if (COLA.Checked)
            {
                listBox1.Items.Add("- 콜라");
                totalCost += 1000;
            }
            if (CHEESE.Checked)
            {
                listBox1.Items.Add("- 치즈 추가");
                totalCost += 500;
            }
            if (SAUCE.Checked)
            {
                listBox1.Items.Add("- 소스 추가");
                totalCost += 300;
            }

            money.Text = "총 금액 : " + totalCost.ToString() + "원";

        }

        private void button2_Click(object sender, EventArgs e)
        {


            HB.Checked = true;


            PHOTO.Checked = false;
            COLA.Checked = false;
            CHEESE.Checked = false;
            SAUCE.Checked = false;

            listBox1.Items.Clear();
            money.Text = "총 금액 : 0원";

        }

        private void HB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HB.Checked = false;
            BHB.Checked = false;
            CHB.Checked = false;


            PHOTO.Checked = false;
            COLA.Checked = false;
            CHEESE.Checked = false;
            SAUCE.Checked = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
