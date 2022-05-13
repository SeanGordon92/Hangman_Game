
namespace Hangman_Game
{
    partial class Hangman
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hangman));
            this.pic_Post = new System.Windows.Forms.PictureBox();
            this.btn_Play = new System.Windows.Forms.Button();
            this.lbl_Life = new System.Windows.Forms.Label();
            this.lbl_LifeValue = new System.Windows.Forms.Label();
            this.box_Keypad = new System.Windows.Forms.GroupBox();
            this.btn_Y = new System.Windows.Forms.Button();
            this.btn_Z = new System.Windows.Forms.Button();
            this.btn_W = new System.Windows.Forms.Button();
            this.btn_X = new System.Windows.Forms.Button();
            this.btn_P = new System.Windows.Forms.Button();
            this.btn_Q = new System.Windows.Forms.Button();
            this.btn_R = new System.Windows.Forms.Button();
            this.btn_S = new System.Windows.Forms.Button();
            this.btn_T = new System.Windows.Forms.Button();
            this.btn_U = new System.Windows.Forms.Button();
            this.btn_V = new System.Windows.Forms.Button();
            this.btn_N = new System.Windows.Forms.Button();
            this.btn_O = new System.Windows.Forms.Button();
            this.btn_M = new System.Windows.Forms.Button();
            this.btn_L = new System.Windows.Forms.Button();
            this.btn_K = new System.Windows.Forms.Button();
            this.btn_J = new System.Windows.Forms.Button();
            this.btn_I = new System.Windows.Forms.Button();
            this.btn_H = new System.Windows.Forms.Button();
            this.btn_G = new System.Windows.Forms.Button();
            this.btn_F = new System.Windows.Forms.Button();
            this.btn_E = new System.Windows.Forms.Button();
            this.btn_D = new System.Windows.Forms.Button();
            this.btn_C = new System.Windows.Forms.Button();
            this.btn_B = new System.Windows.Forms.Button();
            this.btn_A = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.lbl_Word = new System.Windows.Forms.Label();
            this.lbl_Wrongs = new System.Windows.Forms.Label();
            this.lbl_WrongPicked = new System.Windows.Forms.Label();
            this.pic_Head = new System.Windows.Forms.PictureBox();
            this.pic_Body = new System.Windows.Forms.PictureBox();
            this.pic_Right_Hand = new System.Windows.Forms.PictureBox();
            this.pic_Left_Hand = new System.Windows.Forms.PictureBox();
            this.pic_Left_Leg = new System.Windows.Forms.PictureBox();
            this.pic_Right_Leg = new System.Windows.Forms.PictureBox();
            this.lbl_Time_Left = new System.Windows.Forms.Label();
            this.lbl_Timer = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.lbl_Message = new System.Windows.Forms.Label();
            this.lbl_StreakMaxCount = new System.Windows.Forms.Label();
            this.lbl_StreakCount = new System.Windows.Forms.Label();
            this.lbl_Streak = new System.Windows.Forms.Label();
            this.lbl_lbl_StreakMax = new System.Windows.Forms.Label();
            this.btn_Finish = new System.Windows.Forms.Button();
            this.btn_Info = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Post)).BeginInit();
            this.box_Keypad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Head)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Body)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Right_Hand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Left_Hand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Left_Leg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Right_Leg)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_Post
            // 
            resources.ApplyResources(this.pic_Post, "pic_Post");
            this.pic_Post.BackColor = System.Drawing.Color.Transparent;
            this.pic_Post.Image = global::Hangman_Game.Properties.Resources.HangPost;
            this.pic_Post.Name = "pic_Post";
            this.pic_Post.TabStop = false;
            // 
            // btn_Play
            // 
            resources.ApplyResources(this.btn_Play, "btn_Play");
            this.btn_Play.BackColor = System.Drawing.Color.Red;
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.UseVisualStyleBackColor = false;
            this.btn_Play.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lbl_Life
            // 
            resources.ApplyResources(this.lbl_Life, "lbl_Life");
            this.lbl_Life.BackColor = System.Drawing.Color.SteelBlue;
            this.lbl_Life.Name = "lbl_Life";
            // 
            // lbl_LifeValue
            // 
            resources.ApplyResources(this.lbl_LifeValue, "lbl_LifeValue");
            this.lbl_LifeValue.BackColor = System.Drawing.Color.SteelBlue;
            this.lbl_LifeValue.Name = "lbl_LifeValue";
            this.lbl_LifeValue.Click += new System.EventHandler(this.lblLivesLeft_Click);
            // 
            // box_Keypad
            // 
            resources.ApplyResources(this.box_Keypad, "box_Keypad");
            this.box_Keypad.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.box_Keypad.Controls.Add(this.btn_Y);
            this.box_Keypad.Controls.Add(this.btn_Z);
            this.box_Keypad.Controls.Add(this.btn_W);
            this.box_Keypad.Controls.Add(this.btn_X);
            this.box_Keypad.Controls.Add(this.btn_P);
            this.box_Keypad.Controls.Add(this.btn_Q);
            this.box_Keypad.Controls.Add(this.btn_R);
            this.box_Keypad.Controls.Add(this.btn_S);
            this.box_Keypad.Controls.Add(this.btn_T);
            this.box_Keypad.Controls.Add(this.btn_U);
            this.box_Keypad.Controls.Add(this.btn_V);
            this.box_Keypad.Controls.Add(this.btn_N);
            this.box_Keypad.Controls.Add(this.btn_O);
            this.box_Keypad.Controls.Add(this.btn_M);
            this.box_Keypad.Controls.Add(this.btn_L);
            this.box_Keypad.Controls.Add(this.btn_K);
            this.box_Keypad.Controls.Add(this.btn_J);
            this.box_Keypad.Controls.Add(this.btn_I);
            this.box_Keypad.Controls.Add(this.btn_H);
            this.box_Keypad.Controls.Add(this.btn_G);
            this.box_Keypad.Controls.Add(this.btn_F);
            this.box_Keypad.Controls.Add(this.btn_E);
            this.box_Keypad.Controls.Add(this.btn_D);
            this.box_Keypad.Controls.Add(this.btn_C);
            this.box_Keypad.Controls.Add(this.btn_B);
            this.box_Keypad.Controls.Add(this.btn_A);
            this.box_Keypad.Name = "box_Keypad";
            this.box_Keypad.TabStop = false;
            // 
            // btn_Y
            // 
            resources.ApplyResources(this.btn_Y, "btn_Y");
            this.btn_Y.Name = "btn_Y";
            this.btn_Y.UseVisualStyleBackColor = true;
            this.btn_Y.Click += new System.EventHandler(this.btn_Y_Click);
            // 
            // btn_Z
            // 
            resources.ApplyResources(this.btn_Z, "btn_Z");
            this.btn_Z.Name = "btn_Z";
            this.btn_Z.UseVisualStyleBackColor = true;
            this.btn_Z.Click += new System.EventHandler(this.btn_Z_Click);
            // 
            // btn_W
            // 
            resources.ApplyResources(this.btn_W, "btn_W");
            this.btn_W.Name = "btn_W";
            this.btn_W.UseVisualStyleBackColor = true;
            this.btn_W.Click += new System.EventHandler(this.btn_W_Click);
            // 
            // btn_X
            // 
            resources.ApplyResources(this.btn_X, "btn_X");
            this.btn_X.Name = "btn_X";
            this.btn_X.UseVisualStyleBackColor = true;
            this.btn_X.Click += new System.EventHandler(this.btn_X_Click);
            // 
            // btn_P
            // 
            resources.ApplyResources(this.btn_P, "btn_P");
            this.btn_P.Name = "btn_P";
            this.btn_P.UseVisualStyleBackColor = true;
            this.btn_P.Click += new System.EventHandler(this.btn_P_Click);
            // 
            // btn_Q
            // 
            resources.ApplyResources(this.btn_Q, "btn_Q");
            this.btn_Q.Name = "btn_Q";
            this.btn_Q.UseVisualStyleBackColor = true;
            this.btn_Q.Click += new System.EventHandler(this.btn_Q_Click);
            // 
            // btn_R
            // 
            resources.ApplyResources(this.btn_R, "btn_R");
            this.btn_R.Name = "btn_R";
            this.btn_R.UseVisualStyleBackColor = true;
            this.btn_R.Click += new System.EventHandler(this.btn_R_Click);
            // 
            // btn_S
            // 
            resources.ApplyResources(this.btn_S, "btn_S");
            this.btn_S.Name = "btn_S";
            this.btn_S.UseVisualStyleBackColor = true;
            this.btn_S.Click += new System.EventHandler(this.btn_S_Click);
            // 
            // btn_T
            // 
            resources.ApplyResources(this.btn_T, "btn_T");
            this.btn_T.Name = "btn_T";
            this.btn_T.UseVisualStyleBackColor = true;
            this.btn_T.Click += new System.EventHandler(this.btn_T_Click);
            // 
            // btn_U
            // 
            resources.ApplyResources(this.btn_U, "btn_U");
            this.btn_U.Name = "btn_U";
            this.btn_U.UseVisualStyleBackColor = true;
            this.btn_U.Click += new System.EventHandler(this.btn_U_Click);
            // 
            // btn_V
            // 
            resources.ApplyResources(this.btn_V, "btn_V");
            this.btn_V.Name = "btn_V";
            this.btn_V.UseVisualStyleBackColor = true;
            this.btn_V.Click += new System.EventHandler(this.btn_V_Click);
            // 
            // btn_N
            // 
            resources.ApplyResources(this.btn_N, "btn_N");
            this.btn_N.Name = "btn_N";
            this.btn_N.UseVisualStyleBackColor = true;
            this.btn_N.Click += new System.EventHandler(this.btn_N_Click);
            // 
            // btn_O
            // 
            resources.ApplyResources(this.btn_O, "btn_O");
            this.btn_O.Name = "btn_O";
            this.btn_O.UseVisualStyleBackColor = true;
            this.btn_O.Click += new System.EventHandler(this.btn_O_Click);
            // 
            // btn_M
            // 
            resources.ApplyResources(this.btn_M, "btn_M");
            this.btn_M.Name = "btn_M";
            this.btn_M.UseVisualStyleBackColor = true;
            this.btn_M.Click += new System.EventHandler(this.btn_M_Click);
            // 
            // btn_L
            // 
            resources.ApplyResources(this.btn_L, "btn_L");
            this.btn_L.Name = "btn_L";
            this.btn_L.UseVisualStyleBackColor = true;
            this.btn_L.Click += new System.EventHandler(this.btn_L_Click);
            // 
            // btn_K
            // 
            resources.ApplyResources(this.btn_K, "btn_K");
            this.btn_K.Name = "btn_K";
            this.btn_K.UseVisualStyleBackColor = true;
            this.btn_K.Click += new System.EventHandler(this.btn_K_Click);
            // 
            // btn_J
            // 
            resources.ApplyResources(this.btn_J, "btn_J");
            this.btn_J.Name = "btn_J";
            this.btn_J.UseVisualStyleBackColor = true;
            this.btn_J.Click += new System.EventHandler(this.btn_J_Click);
            // 
            // btn_I
            // 
            resources.ApplyResources(this.btn_I, "btn_I");
            this.btn_I.Name = "btn_I";
            this.btn_I.UseVisualStyleBackColor = true;
            this.btn_I.Click += new System.EventHandler(this.btn_I_Click);
            // 
            // btn_H
            // 
            resources.ApplyResources(this.btn_H, "btn_H");
            this.btn_H.Name = "btn_H";
            this.btn_H.UseVisualStyleBackColor = true;
            this.btn_H.Click += new System.EventHandler(this.btn_H_Click);
            // 
            // btn_G
            // 
            resources.ApplyResources(this.btn_G, "btn_G");
            this.btn_G.Name = "btn_G";
            this.btn_G.UseVisualStyleBackColor = true;
            this.btn_G.Click += new System.EventHandler(this.btn_G_Click);
            // 
            // btn_F
            // 
            resources.ApplyResources(this.btn_F, "btn_F");
            this.btn_F.Name = "btn_F";
            this.btn_F.UseVisualStyleBackColor = true;
            this.btn_F.Click += new System.EventHandler(this.btn_F_Click);
            // 
            // btn_E
            // 
            resources.ApplyResources(this.btn_E, "btn_E");
            this.btn_E.Name = "btn_E";
            this.btn_E.UseVisualStyleBackColor = true;
            this.btn_E.Click += new System.EventHandler(this.btn_E_Click);
            // 
            // btn_D
            // 
            resources.ApplyResources(this.btn_D, "btn_D");
            this.btn_D.Name = "btn_D";
            this.btn_D.UseVisualStyleBackColor = true;
            this.btn_D.Click += new System.EventHandler(this.btn_D_Click);
            // 
            // btn_C
            // 
            resources.ApplyResources(this.btn_C, "btn_C");
            this.btn_C.Name = "btn_C";
            this.btn_C.UseVisualStyleBackColor = true;
            this.btn_C.Click += new System.EventHandler(this.btn_C_Click);
            // 
            // btn_B
            // 
            resources.ApplyResources(this.btn_B, "btn_B");
            this.btn_B.Name = "btn_B";
            this.btn_B.UseVisualStyleBackColor = true;
            this.btn_B.Click += new System.EventHandler(this.btn_B_Click);
            // 
            // btn_A
            // 
            resources.ApplyResources(this.btn_A, "btn_A");
            this.btn_A.Name = "btn_A";
            this.btn_A.UseVisualStyleBackColor = true;
            this.btn_A.Click += new System.EventHandler(this.btn_A_Click);
            // 
            // button13
            // 
            resources.ApplyResources(this.button13, "button13");
            this.button13.Name = "button13";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            resources.ApplyResources(this.button14, "button14");
            this.button14.Name = "button14";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            resources.ApplyResources(this.button15, "button15");
            this.button15.Name = "button15";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            resources.ApplyResources(this.button16, "button16");
            this.button16.Name = "button16";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // lbl_Word
            // 
            resources.ApplyResources(this.lbl_Word, "lbl_Word");
            this.lbl_Word.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_Word.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Word.Name = "lbl_Word";
            this.lbl_Word.Click += new System.EventHandler(this.lbl_Word_Click);
            // 
            // lbl_Wrongs
            // 
            resources.ApplyResources(this.lbl_Wrongs, "lbl_Wrongs");
            this.lbl_Wrongs.BackColor = System.Drawing.Color.LemonChiffon;
            this.lbl_Wrongs.Name = "lbl_Wrongs";
            // 
            // lbl_WrongPicked
            // 
            resources.ApplyResources(this.lbl_WrongPicked, "lbl_WrongPicked");
            this.lbl_WrongPicked.BackColor = System.Drawing.Color.LemonChiffon;
            this.lbl_WrongPicked.Name = "lbl_WrongPicked";
            // 
            // pic_Head
            // 
            resources.ApplyResources(this.pic_Head, "pic_Head");
            this.pic_Head.BackColor = System.Drawing.Color.Transparent;
            this.pic_Head.Image = global::Hangman_Game.Properties.Resources.Head;
            this.pic_Head.Name = "pic_Head";
            this.pic_Head.TabStop = false;
            // 
            // pic_Body
            // 
            resources.ApplyResources(this.pic_Body, "pic_Body");
            this.pic_Body.BackColor = System.Drawing.Color.Transparent;
            this.pic_Body.Image = global::Hangman_Game.Properties.Resources.Body;
            this.pic_Body.Name = "pic_Body";
            this.pic_Body.TabStop = false;
            // 
            // pic_Right_Hand
            // 
            resources.ApplyResources(this.pic_Right_Hand, "pic_Right_Hand");
            this.pic_Right_Hand.BackColor = System.Drawing.Color.Transparent;
            this.pic_Right_Hand.Image = global::Hangman_Game.Properties.Resources.Right_Hand;
            this.pic_Right_Hand.Name = "pic_Right_Hand";
            this.pic_Right_Hand.TabStop = false;
            // 
            // pic_Left_Hand
            // 
            resources.ApplyResources(this.pic_Left_Hand, "pic_Left_Hand");
            this.pic_Left_Hand.BackColor = System.Drawing.Color.Transparent;
            this.pic_Left_Hand.Image = global::Hangman_Game.Properties.Resources.Left_Hand;
            this.pic_Left_Hand.Name = "pic_Left_Hand";
            this.pic_Left_Hand.TabStop = false;
            // 
            // pic_Left_Leg
            // 
            resources.ApplyResources(this.pic_Left_Leg, "pic_Left_Leg");
            this.pic_Left_Leg.BackColor = System.Drawing.Color.Transparent;
            this.pic_Left_Leg.Image = global::Hangman_Game.Properties.Resources.Left_Leg;
            this.pic_Left_Leg.Name = "pic_Left_Leg";
            this.pic_Left_Leg.TabStop = false;
            // 
            // pic_Right_Leg
            // 
            resources.ApplyResources(this.pic_Right_Leg, "pic_Right_Leg");
            this.pic_Right_Leg.BackColor = System.Drawing.Color.Transparent;
            this.pic_Right_Leg.Image = global::Hangman_Game.Properties.Resources.Right_Leg;
            this.pic_Right_Leg.Name = "pic_Right_Leg";
            this.pic_Right_Leg.TabStop = false;
            // 
            // lbl_Time_Left
            // 
            resources.ApplyResources(this.lbl_Time_Left, "lbl_Time_Left");
            this.lbl_Time_Left.BackColor = System.Drawing.Color.Coral;
            this.lbl_Time_Left.Name = "lbl_Time_Left";
            // 
            // lbl_Timer
            // 
            resources.ApplyResources(this.lbl_Timer, "lbl_Timer");
            this.lbl_Timer.BackColor = System.Drawing.Color.Coral;
            this.lbl_Timer.Name = "lbl_Timer";
            this.lbl_Timer.Click += new System.EventHandler(this.lbl_Timer_Click);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.aTimer);
            // 
            // lbl_Message
            // 
            resources.ApplyResources(this.lbl_Message, "lbl_Message");
            this.lbl_Message.BackColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Message.Name = "lbl_Message";
            // 
            // lbl_StreakMaxCount
            // 
            resources.ApplyResources(this.lbl_StreakMaxCount, "lbl_StreakMaxCount");
            this.lbl_StreakMaxCount.BackColor = System.Drawing.Color.GreenYellow;
            this.lbl_StreakMaxCount.Name = "lbl_StreakMaxCount";
            // 
            // lbl_StreakCount
            // 
            resources.ApplyResources(this.lbl_StreakCount, "lbl_StreakCount");
            this.lbl_StreakCount.BackColor = System.Drawing.Color.GreenYellow;
            this.lbl_StreakCount.Name = "lbl_StreakCount";
            // 
            // lbl_Streak
            // 
            resources.ApplyResources(this.lbl_Streak, "lbl_Streak");
            this.lbl_Streak.BackColor = System.Drawing.Color.GreenYellow;
            this.lbl_Streak.Name = "lbl_Streak";
            // 
            // lbl_lbl_StreakMax
            // 
            resources.ApplyResources(this.lbl_lbl_StreakMax, "lbl_lbl_StreakMax");
            this.lbl_lbl_StreakMax.BackColor = System.Drawing.Color.GreenYellow;
            this.lbl_lbl_StreakMax.Name = "lbl_lbl_StreakMax";
            // 
            // btn_Finish
            // 
            resources.ApplyResources(this.btn_Finish, "btn_Finish");
            this.btn_Finish.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Finish.Name = "btn_Finish";
            this.btn_Finish.UseVisualStyleBackColor = false;
            this.btn_Finish.Click += new System.EventHandler(this.btn_Finish_Click);
            // 
            // btn_Info
            // 
            resources.ApplyResources(this.btn_Info, "btn_Info");
            this.btn_Info.BackColor = System.Drawing.Color.Sienna;
            this.btn_Info.Name = "btn_Info";
            this.btn_Info.UseVisualStyleBackColor = false;
            this.btn_Info.Click += new System.EventHandler(this.btn_Info_Click);
            // 
            // Hangman
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hangman_Game.Properties.Resources.Background;
            this.Controls.Add(this.btn_Info);
            this.Controls.Add(this.btn_Finish);
            this.Controls.Add(this.lbl_lbl_StreakMax);
            this.Controls.Add(this.lbl_Streak);
            this.Controls.Add(this.lbl_StreakCount);
            this.Controls.Add(this.lbl_StreakMaxCount);
            this.Controls.Add(this.lbl_Message);
            this.Controls.Add(this.lbl_Timer);
            this.Controls.Add(this.lbl_Time_Left);
            this.Controls.Add(this.pic_Left_Leg);
            this.Controls.Add(this.pic_Right_Hand);
            this.Controls.Add(this.pic_Body);
            this.Controls.Add(this.pic_Right_Leg);
            this.Controls.Add(this.pic_Left_Hand);
            this.Controls.Add(this.pic_Head);
            this.Controls.Add(this.lbl_WrongPicked);
            this.Controls.Add(this.lbl_Wrongs);
            this.Controls.Add(this.lbl_Word);
            this.Controls.Add(this.box_Keypad);
            this.Controls.Add(this.lbl_LifeValue);
            this.Controls.Add(this.lbl_Life);
            this.Controls.Add(this.btn_Play);
            this.Controls.Add(this.pic_Post);
            this.Name = "Hangman";
            this.Tag = "txtCharChoose";
            this.Load += new System.EventHandler(this.Hangman_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Post)).EndInit();
            this.box_Keypad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Head)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Body)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Right_Hand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Left_Hand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Left_Leg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Right_Leg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_Post;
        private System.Windows.Forms.Button btn_Play;
        private System.Windows.Forms.Label lbl_Life;
        private System.Windows.Forms.Label lbl_LifeValue;
        private System.Windows.Forms.GroupBox box_Keypad;
        private System.Windows.Forms.Button btn_Y;
        private System.Windows.Forms.Button btn_Z;
        private System.Windows.Forms.Button btn_W;
        private System.Windows.Forms.Button btn_X;
        private System.Windows.Forms.Button btn_P;
        private System.Windows.Forms.Button btn_Q;
        private System.Windows.Forms.Button btn_R;
        private System.Windows.Forms.Button btn_S;
        private System.Windows.Forms.Button btn_T;
        private System.Windows.Forms.Button btn_U;
        private System.Windows.Forms.Button btn_V;
        private System.Windows.Forms.Button btn_N;
        private System.Windows.Forms.Button btn_O;
        private System.Windows.Forms.Button btn_M;
        private System.Windows.Forms.Button btn_L;
        private System.Windows.Forms.Button btn_K;
        private System.Windows.Forms.Button btn_J;
        private System.Windows.Forms.Button btn_I;
        private System.Windows.Forms.Button btn_H;
        private System.Windows.Forms.Button btn_G;
        private System.Windows.Forms.Button btn_F;
        private System.Windows.Forms.Button btn_E;
        private System.Windows.Forms.Button btn_D;
        private System.Windows.Forms.Button btn_C;
        private System.Windows.Forms.Button btn_B;
        private System.Windows.Forms.Button btn_A;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Label lbl_Word;
        private System.Windows.Forms.Label lbl_Wrongs;
        private System.Windows.Forms.Label lbl_WrongPicked;
        private System.Windows.Forms.PictureBox pic_Head;
        private System.Windows.Forms.PictureBox pic_Body;
        private System.Windows.Forms.PictureBox pic_Right_Hand;
        private System.Windows.Forms.PictureBox pic_Left_Hand;
        private System.Windows.Forms.PictureBox pic_Left_Leg;
        private System.Windows.Forms.PictureBox pic_Right_Leg;
        private System.Windows.Forms.Label lbl_Time_Left;
        private System.Windows.Forms.Label lbl_Timer;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label lbl_Message;
        private System.Windows.Forms.Label lbl_StreakMaxCount;
        private System.Windows.Forms.Label lbl_StreakCount;
        private System.Windows.Forms.Label lbl_Streak;
        private System.Windows.Forms.Label lbl_lbl_StreakMax;
        private System.Windows.Forms.Button btn_Finish;
        private System.Windows.Forms.Button btn_Info;
    }
}