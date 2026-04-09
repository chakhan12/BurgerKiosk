namespace BurgerKiosk
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            HB = new RadioButton();
            BHB = new RadioButton();
            CHB = new RadioButton();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            groupBox1 = new GroupBox();
            PHOTO = new CheckBox();
            COLA = new CheckBox();
            CHEESE = new CheckBox();
            SAUCE = new CheckBox();
            groupBox2 = new GroupBox();
            listBox1 = new ListBox();
            money = new Label();
            groupBox3 = new GroupBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(42, 31);
            label1.Name = "label1";
            label1.Size = new Size(344, 50);
            label1.TabIndex = 0;
            label1.Text = "버거 주문 키오스크";
            // 
            // HB
            // 
            HB.AutoSize = true;
            HB.Font = new Font("맑은 고딕", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 129);
            HB.ForeColor = Color.Black;
            HB.Location = new Point(11, 52);
            HB.Name = "HB";
            HB.Size = new Size(104, 35);
            HB.TabIndex = 1;
            HB.TabStop = true;
            HB.Text = "햄버거";
            HB.UseVisualStyleBackColor = true;
            HB.CheckedChanged += HB_CheckedChanged;
            // 
            // BHB
            // 
            BHB.AutoSize = true;
            BHB.Font = new Font("맑은 고딕", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 129);
            BHB.ForeColor = Color.Black;
            BHB.Location = new Point(11, 143);
            BHB.Name = "BHB";
            BHB.Size = new Size(158, 35);
            BHB.TabIndex = 2;
            BHB.TabStop = true;
            BHB.Text = "불고기 버거";
            BHB.UseVisualStyleBackColor = true;
            // 
            // CHB
            // 
            CHB.AutoSize = true;
            CHB.Font = new Font("맑은 고딕", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 129);
            CHB.ForeColor = Color.Black;
            CHB.Location = new Point(11, 241);
            CHB.Name = "CHB";
            CHB.Size = new Size(127, 35);
            CHB.TabIndex = 3;
            CHB.TabStop = true;
            CHB.Text = "치킨버거";
            CHB.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(172, 230);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(110, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(175, 124);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(110, 80);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(175, 24);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(110, 80);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(CHB);
            groupBox1.Controls.Add(BHB);
            groupBox1.Controls.Add(HB);
            groupBox1.Font = new Font("맑은 고딕", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 129);
            groupBox1.ForeColor = Color.Red;
            groupBox1.Location = new Point(25, 112);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(313, 384);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "메뉴 선택";
            // 
            // PHOTO
            // 
            PHOTO.AutoSize = true;
            PHOTO.Font = new Font("맑은 고딕", 12F);
            PHOTO.ForeColor = Color.Black;
            PHOTO.Location = new Point(20, 48);
            PHOTO.Name = "PHOTO";
            PHOTO.Size = new Size(114, 32);
            PHOTO.TabIndex = 8;
            PHOTO.Text = "감자튀김";
            PHOTO.UseVisualStyleBackColor = true;
            // 
            // COLA
            // 
            COLA.AutoSize = true;
            COLA.Font = new Font("맑은 고딕", 12F);
            COLA.ForeColor = Color.Black;
            COLA.Location = new Point(20, 106);
            COLA.Name = "COLA";
            COLA.Size = new Size(74, 32);
            COLA.TabIndex = 9;
            COLA.Text = "콜라";
            COLA.UseVisualStyleBackColor = true;
            // 
            // CHEESE
            // 
            CHEESE.AutoSize = true;
            CHEESE.Font = new Font("맑은 고딕", 12F);
            CHEESE.ForeColor = Color.Black;
            CHEESE.Location = new Point(20, 162);
            CHEESE.Name = "CHEESE";
            CHEESE.Size = new Size(121, 32);
            CHEESE.TabIndex = 10;
            CHEESE.Text = "치즈 추가";
            CHEESE.UseVisualStyleBackColor = true;
            // 
            // SAUCE
            // 
            SAUCE.AutoSize = true;
            SAUCE.Font = new Font("맑은 고딕", 12F);
            SAUCE.ForeColor = Color.Black;
            SAUCE.Location = new Point(20, 213);
            SAUCE.Name = "SAUCE";
            SAUCE.Size = new Size(121, 32);
            SAUCE.TabIndex = 11;
            SAUCE.Text = "소스 추가";
            SAUCE.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(SAUCE);
            groupBox2.Controls.Add(CHEESE);
            groupBox2.Controls.Add(COLA);
            groupBox2.Controls.Add(PHOTO);
            groupBox2.ForeColor = Color.Red;
            groupBox2.Location = new Point(353, 136);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(164, 272);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "추가 옵션";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(8, 39);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(206, 144);
            listBox1.TabIndex = 13;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // money
            // 
            money.AutoSize = true;
            money.Font = new Font("맑은 고딕", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 129);
            money.ForeColor = Color.Blue;
            money.Location = new Point(8, 210);
            money.Name = "money";
            money.Size = new Size(148, 31);
            money.TabIndex = 14;
            money.Text = "총 금액 : 0원";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(money);
            groupBox3.Controls.Add(listBox1);
            groupBox3.ForeColor = Color.Red;
            groupBox3.Location = new Point(554, 143);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(231, 258);
            groupBox3.TabIndex = 15;
            groupBox3.TabStop = false;
            groupBox3.Text = "주문 내역";
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            button1.ForeColor = Color.White;
            button1.Location = new Point(526, 449);
            button1.Name = "button1";
            button1.Size = new Size(122, 47);
            button1.TabIndex = 16;
            button1.Text = "주문하기";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            button2.ForeColor = Color.White;
            button2.Location = new Point(679, 446);
            button2.Name = "button2";
            button2.Size = new Size(122, 47);
            button2.TabIndex = 17;
            button2.Text = "초기화";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 539);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "ㅌ";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton HB;
        private RadioButton BHB;
        private RadioButton CHB;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private GroupBox groupBox1;
        private CheckBox PHOTO;
        private CheckBox COLA;
        private CheckBox CHEESE;
        private CheckBox SAUCE;
        private GroupBox groupBox2;
        private ListBox listBox1;
        private Label money;
        private GroupBox groupBox3;
        private Button button1;
        private Button button2;
    }
}
