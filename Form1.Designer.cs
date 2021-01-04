namespace WindowsFormsApp1
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.latencityNUD = new System.Windows.Forms.NumericUpDown();
            this.mainMemoryLatencityCB = new System.Windows.Forms.ComboBox();
            this.fetchRateCB = new System.Windows.Forms.ComboBox();
            this.instrBufferSizeCB = new System.Windows.Forms.ComboBox();
            this.issueRateMaxCB = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.latencityNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.latencityNUD);
            this.panel1.Controls.Add(this.mainMemoryLatencityCB);
            this.panel1.Controls.Add(this.fetchRateCB);
            this.panel1.Controls.Add(this.instrBufferSizeCB);
            this.panel1.Controls.Add(this.issueRateMaxCB);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 151);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Arhitecture Parameters";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fetch Rate (FR)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Instruction Buffer Size";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Issue Rate Max (IRMax)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Latency (for hit in cache)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Main Memory Latency";
            // 
            // latencityNUD
            // 
            this.latencityNUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.latencityNUD.Location = new System.Drawing.Point(137, 97);
            this.latencityNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.latencityNUD.Name = "latencityNUD";
            this.latencityNUD.Size = new System.Drawing.Size(50, 20);
            this.latencityNUD.TabIndex = 17;
            this.latencityNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // mainMemoryLatencityCB
            // 
            this.mainMemoryLatencityCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mainMemoryLatencityCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mainMemoryLatencityCB.FormattingEnabled = true;
            this.mainMemoryLatencityCB.Items.AddRange(new object[] {
            "10",
            "15",
            "20"});
            this.mainMemoryLatencityCB.Location = new System.Drawing.Point(137, 122);
            this.mainMemoryLatencityCB.Margin = new System.Windows.Forms.Padding(2);
            this.mainMemoryLatencityCB.Name = "mainMemoryLatencityCB";
            this.mainMemoryLatencityCB.Size = new System.Drawing.Size(50, 21);
            this.mainMemoryLatencityCB.TabIndex = 14;
            // 
            // fetchRateCB
            // 
            this.fetchRateCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fetchRateCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fetchRateCB.FormattingEnabled = true;
            this.fetchRateCB.Items.AddRange(new object[] {
            "4",
            "8",
            "16"});
            this.fetchRateCB.Location = new System.Drawing.Point(137, 21);
            this.fetchRateCB.Margin = new System.Windows.Forms.Padding(2);
            this.fetchRateCB.Name = "fetchRateCB";
            this.fetchRateCB.Size = new System.Drawing.Size(50, 21);
            this.fetchRateCB.TabIndex = 16;
            // 
            // instrBufferSizeCB
            // 
            this.instrBufferSizeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.instrBufferSizeCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.instrBufferSizeCB.FormattingEnabled = true;
            this.instrBufferSizeCB.Items.AddRange(new object[] {
            "4",
            "8",
            "16",
            "32"});
            this.instrBufferSizeCB.Location = new System.Drawing.Point(137, 46);
            this.instrBufferSizeCB.Margin = new System.Windows.Forms.Padding(2);
            this.instrBufferSizeCB.Name = "instrBufferSizeCB";
            this.instrBufferSizeCB.Size = new System.Drawing.Size(50, 21);
            this.instrBufferSizeCB.TabIndex = 15;
            // 
            // issueRateMaxCB
            // 
            this.issueRateMaxCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.issueRateMaxCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.issueRateMaxCB.FormattingEnabled = true;
            this.issueRateMaxCB.Items.AddRange(new object[] {
            "2",
            "4",
            "8",
            "16"});
            this.issueRateMaxCB.Location = new System.Drawing.Point(137, 71);
            this.issueRateMaxCB.Margin = new System.Windows.Forms.Padding(2);
            this.issueRateMaxCB.Name = "issueRateMaxCB";
            this.issueRateMaxCB.Size = new System.Drawing.Size(50, 21);
            this.issueRateMaxCB.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.latencityNUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.NumericUpDown latencityNUD;
        public System.Windows.Forms.ComboBox mainMemoryLatencityCB;
        public System.Windows.Forms.ComboBox fetchRateCB;
        public System.Windows.Forms.ComboBox instrBufferSizeCB;
        public System.Windows.Forms.ComboBox issueRateMaxCB;
    }
}

