namespace WFA_SansOyunu
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
            components=new System.ComponentModel.Container();
            label1=new Label();
            label3=new Label();
            lblFinish=new Label();
            btnBasla=new Button();
            btnSifirla=new Button();
            pictureBir=new PictureBox();
            pictureIki=new PictureBox();
            pictureUc=new PictureBox();
            timer1=new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureIki).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureUc).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor=SystemColors.ActiveCaptionText;
            label1.Location=new Point(89, 213);
            label1.Name="label1";
            label1.Size=new Size(501, 23);
            label1.TabIndex=0;
            label1.Text="label1";
            // 
            // label3
            // 
            label3.BackColor=SystemColors.ActiveCaptionText;
            label3.Location=new Point(89, 104);
            label3.Name="label3";
            label3.Size=new Size(501, 20);
            label3.TabIndex=2;
            label3.Text="label3";
            // 
            // lblFinish
            // 
            lblFinish.BackColor=SystemColors.ActiveCaptionText;
            lblFinish.Font=new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblFinish.ForeColor=SystemColors.ButtonHighlight;
            lblFinish.ImageAlign=ContentAlignment.TopLeft;
            lblFinish.Location=new Point(596, 31);
            lblFinish.Name="lblFinish";
            lblFinish.Size=new Size(40, 325);
            lblFinish.TabIndex=3;
            lblFinish.Text="FINISH";
            lblFinish.TextAlign=ContentAlignment.MiddleLeft;
            // 
            // btnBasla
            // 
            btnBasla.BackColor=SystemColors.ActiveCaption;
            btnBasla.Location=new Point(349, 0);
            btnBasla.Name="btnBasla";
            btnBasla.Size=new Size(100, 29);
            btnBasla.TabIndex=4;
            btnBasla.Text="Yarışı Başlat";
            btnBasla.UseVisualStyleBackColor=false;
            btnBasla.Click+=btnBasla_Click;
            // 
            // btnSifirla
            // 
            btnSifirla.BackColor=SystemColors.ActiveCaption;
            btnSifirla.Location=new Point(478, 0);
            btnSifirla.Name="btnSifirla";
            btnSifirla.Size=new Size(94, 29);
            btnSifirla.TabIndex=5;
            btnSifirla.Text="Yarışı Sıfırla";
            btnSifirla.UseVisualStyleBackColor=false;
            btnSifirla.Click+=btnSifirla_Click;
            // 
            // pictureBir
            // 
            pictureBir.Image=Properties.Resources.horse;
            pictureBir.InitialImage=Properties.Resources.horse;
            pictureBir.Location=new Point(89, 39);
            pictureBir.Name="pictureBir";
            pictureBir.Size=new Size(125, 62);
            pictureBir.SizeMode=PictureBoxSizeMode.StretchImage;
            pictureBir.TabIndex=6;
            pictureBir.TabStop=false;
            // 
            // pictureIki
            // 
            pictureIki.Image=Properties.Resources.horse;
            pictureIki.InitialImage=Properties.Resources.horse;
            pictureIki.Location=new Point(89, 138);
            pictureIki.Name="pictureIki";
            pictureIki.Size=new Size(125, 62);
            pictureIki.SizeMode=PictureBoxSizeMode.StretchImage;
            pictureIki.TabIndex=7;
            pictureIki.TabStop=false;
            // 
            // pictureUc
            // 
            pictureUc.Image=Properties.Resources.horse;
            pictureUc.InitialImage=Properties.Resources.horse;
            pictureUc.Location=new Point(89, 239);
            pictureUc.Name="pictureUc";
            pictureUc.Size=new Size(125, 62);
            pictureUc.SizeMode=PictureBoxSizeMode.StretchImage;
            pictureUc.TabIndex=8;
            pictureUc.TabStop=false;
            // 
            // timer1
            // 
            timer1.Tick+=timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            BackgroundImage=Properties.Resources.grass;
            ClientSize=new Size(712, 365);
            Controls.Add(pictureUc);
            Controls.Add(pictureIki);
            Controls.Add(pictureBir);
            Controls.Add(btnSifirla);
            Controls.Add(btnBasla);
            Controls.Add(lblFinish);
            Controls.Add(label3);
            Controls.Add(label1);
            Name="Form1";
            Text="Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBir).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureIki).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureUc).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label lblFinish;
        private Button btnBasla;
        private Button btnSifirla;
        private PictureBox pictureBir;
        private PictureBox pictureIki;
        private PictureBox pictureUc;
        private System.Windows.Forms.Timer timer1;
    }
}