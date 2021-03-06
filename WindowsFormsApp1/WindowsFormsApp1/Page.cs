﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Page : Form
    {
        //private PictureBox pictureBox = new PictureBox();
        //private TextBox countOfClustersTB = new TextBox();
        //private RichTextBox infoOfClustersRTB = new RichTextBox();
       // private Label F1Lb = new Label();
        //private Label F2Lb = new Label();

        int number;
        Dendogram d;
        private PictureBox pictureBox;
        private TextBox countOfClustersTB;
        private RichTextBox infoOfClustersRTB;
        private Label F1Lb;
        private Label F2Lb;
        private Button executeBtn;
        private CheckBox manualCB;
        private Button Export;
        Bitmap btm;
        public void ChangeNumber(int Number)
        {
            number = Number;
            Text = "Page " + Number;
        }
        public Page(int Number, Dendogram D)
        {

            InitializeComponent();
            ChangeNumber(Number);
            d = D;
            btm = d.GetPicture(d.AutoCount);
            pictureBox.Width = btm.Width;
            pictureBox.Height = btm.Height;
            pictureBox.Image = btm;
            countOfClustersTB.Text = d.AutoCount.ToString();
            infoOfClustersRTB.Text = GetInfoOfClusters();
            pictureBox.Show();
            double F1 = (AnalysisOfClustering.F1(d.fullData, d.clusters));
            double F2 = (AnalysisOfClustering.F4(d.fullData, d.clusters));
            F1Lb.Text = F1.ToString();
            F2Lb.Text = F2.ToString() + "\n" + (F1 / F2).ToString();
            string s1 = ""; string s2 = "";
            for (int i = 1; i <= d.fullData.Count; i++)
            {
                btm = d.GetPicture(i);
                s1 += (AnalysisOfClustering.F1(d.fullData, d.clusters)).ToString() + "\t";
                s2 += (AnalysisOfClustering.F4(d.fullData, d.clusters)).ToString() + "\t";
            }
            infoOfClustersRTB.Text += "F1:" + s1 + "\n";
            infoOfClustersRTB.Text += "F2:" + s2 + "\n";
        }
        //private void manualCB_CheckedChanged(object sender, EventArgs e)
        //{
        //    if ((sender as CheckBox).Checked == true)
        //        countOfClustersTB.Enabled = true;
        //    else
        //    {
        //        countOfClustersTB.Enabled = false;
        //        countOfClustersTB.Text = d.AutoCount.ToString();
        //    }
        //}
        //private void executeBtn_Click(object sender, EventArgs e)
        //{
        //    int countOfClusters;
        //    if (Int32.TryParse(countOfClustersTB.Text, out countOfClusters))
        //    {
        //        btm = d.GetPicture(countOfClusters);
        //        pictureBox.Image = d.GetPicture(countOfClusters);
        //        infoOfClustersRTB.Text = GetInfoOfClusters();
        //        double F1 = (AnalysisOfClustering.F1(d.fullData, d.clusters));
        //        double F2 = (AnalysisOfClustering.F4(d.fullData, d.clusters));
        //        F1Lb.Text = F1.ToString();
        //        F2Lb.Text = F2.ToString() + "\n" + (F1 / F2).ToString();
        //    }
        //    else
        //        MessageBox.Show("Not digital count of clusters");
        //}
        private string GetInfoOfClusters()
        {
            string str = "";
            for (int i = 0; i < d.clusters.Count; i++)
            {
                d.clusters[i].Sort();
                str += "Cluster " + (i + 1) + ": {";
                str += d.clusters[i][0];
                for (int elem = 1; elem < d.clusters[i].Count; elem++)
                    str += ", " + d.clusters[i][elem];
                str += "}\n";
            }
            return str;
        }
        private void Page_FormClosing(object sender, FormClosingEventArgs e)
        {
            Repository.Delete(number);
        }

        //private void Export_Click(object sender, EventArgs e)
        //{
        //    btm.Save(Text, System.Drawing.Imaging.ImageFormat.Jpeg);
        //}

        private void InitializeComponent()
        {
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.countOfClustersTB = new System.Windows.Forms.TextBox();
            this.infoOfClustersRTB = new System.Windows.Forms.RichTextBox();
            this.F1Lb = new System.Windows.Forms.Label();
            this.F2Lb = new System.Windows.Forms.Label();
            this.executeBtn = new System.Windows.Forms.Button();
            this.manualCB = new System.Windows.Forms.CheckBox();
            this.Export = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(269, 26);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(457, 315);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // countOfClustersTB
            // 
            this.countOfClustersTB.Location = new System.Drawing.Point(12, 36);
            this.countOfClustersTB.Name = "countOfClustersTB";
            this.countOfClustersTB.Size = new System.Drawing.Size(126, 26);
            this.countOfClustersTB.TabIndex = 1;
            // 
            // infoOfClustersRTB
            // 
            this.infoOfClustersRTB.Location = new System.Drawing.Point(12, 106);
            this.infoOfClustersRTB.Name = "infoOfClustersRTB";
            this.infoOfClustersRTB.Size = new System.Drawing.Size(126, 190);
            this.infoOfClustersRTB.TabIndex = 2;
            this.infoOfClustersRTB.Text = "";
            // 
            // F1Lb
            // 
            this.F1Lb.AutoSize = true;
            this.F1Lb.Location = new System.Drawing.Point(23, 301);
            this.F1Lb.Name = "F1Lb";
            this.F1Lb.Size = new System.Drawing.Size(46, 20);
            this.F1Lb.TabIndex = 3;
            this.F1Lb.Text = "F1Lb";
            // 
            // F2Lb
            // 
            this.F2Lb.AutoSize = true;
            this.F2Lb.Location = new System.Drawing.Point(23, 345);
            this.F2Lb.Name = "F2Lb";
            this.F2Lb.Size = new System.Drawing.Size(46, 20);
            this.F2Lb.TabIndex = 4;
            this.F2Lb.Text = "F2Lb";
            // 
            // executeBtn
            // 
            this.executeBtn.Location = new System.Drawing.Point(12, 68);
            this.executeBtn.Name = "executeBtn";
            this.executeBtn.Size = new System.Drawing.Size(91, 33);
            this.executeBtn.TabIndex = 5;
            this.executeBtn.Text = "Execute";
            this.executeBtn.UseVisualStyleBackColor = true;
            this.executeBtn.Click += new System.EventHandler(this.ExecuteBtn_Click_1);
            // 
            // manualCB
            // 
            this.manualCB.AutoSize = true;
            this.manualCB.Location = new System.Drawing.Point(36, 6);
            this.manualCB.Name = "manualCB";
            this.manualCB.Size = new System.Drawing.Size(113, 24);
            this.manualCB.TabIndex = 6;
            this.manualCB.Text = "checkBox1";
            this.manualCB.UseVisualStyleBackColor = true;
            this.manualCB.CheckedChanged += new System.EventHandler(this.ManualCB_CheckedChanged_1);
            // 
            // Export
            // 
            this.Export.Location = new System.Drawing.Point(27, 384);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(76, 31);
            this.Export.TabIndex = 7;
            this.Export.Text = "Export";
            this.Export.UseVisualStyleBackColor = true;
            this.Export.Click += new System.EventHandler(this.Export_Click_1);
            // 
            // Page
            // 
            this.ClientSize = new System.Drawing.Size(815, 459);
            this.Controls.Add(this.Export);
            this.Controls.Add(this.manualCB);
            this.Controls.Add(this.executeBtn);
            this.Controls.Add(this.F2Lb);
            this.Controls.Add(this.F1Lb);
            this.Controls.Add(this.infoOfClustersRTB);
            this.Controls.Add(this.countOfClustersTB);
            this.Controls.Add(this.pictureBox);
            this.Name = "Page";
            this.Load += new System.EventHandler(this.Page_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Page_Load(object sender, EventArgs e)
        {

        }

        private void ExecuteBtn_Click_1(object sender, EventArgs e)
        {
            int countOfClusters;
            if (Int32.TryParse(countOfClustersTB.Text, out countOfClusters))
            {
                btm = d.GetPicture(countOfClusters);
                pictureBox.Image = d.GetPicture(countOfClusters);
                infoOfClustersRTB.Text = GetInfoOfClusters();
                double F1 = (AnalysisOfClustering.F1(d.fullData, d.clusters));
                double F2 = (AnalysisOfClustering.F4(d.fullData, d.clusters));
                F1Lb.Text = F1.ToString();
                F2Lb.Text = F2.ToString() + "\n" + (F1 / F2).ToString();
            }
            else
                MessageBox.Show("Not digital count of clusters");
        }

        private void ManualCB_CheckedChanged_1(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked == true)
                countOfClustersTB.Enabled = true;
            else
            {
                countOfClustersTB.Enabled = false;
                countOfClustersTB.Text = d.AutoCount.ToString();
            }
        }

        private void Export_Click_1(object sender, EventArgs e)
        {
            btm.Save(Text, System.Drawing.Imaging.ImageFormat.Jpeg);
        }
    }

}
