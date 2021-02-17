namespace View
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listView1 = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.buttonLargeIcon = new System.Windows.Forms.Button();
            this.buttonSmallIcon = new System.Windows.Forms.Button();
            this.buttonList = new System.Windows.Forms.Button();
            this.buttonDetail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.LabelEdit = true;
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(645, 402);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.n);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Screenshot (1).png");
            this.imageList1.Images.SetKeyName(1, "Screenshot (2).png");
            this.imageList1.Images.SetKeyName(2, "Screenshot (3).png");
            this.imageList1.Images.SetKeyName(3, "Screenshot (38).png");
            // 
            // buttonLargeIcon
            // 
            this.buttonLargeIcon.Location = new System.Drawing.Point(664, 24);
            this.buttonLargeIcon.Name = "buttonLargeIcon";
            this.buttonLargeIcon.Size = new System.Drawing.Size(104, 49);
            this.buttonLargeIcon.TabIndex = 1;
            this.buttonLargeIcon.Text = "LargeIcon";
            this.buttonLargeIcon.UseVisualStyleBackColor = true;
            this.buttonLargeIcon.Click += new System.EventHandler(this.buttonLargeIcon_Click);
            // 
            // buttonSmallIcon
            // 
            this.buttonSmallIcon.Location = new System.Drawing.Point(664, 103);
            this.buttonSmallIcon.Name = "buttonSmallIcon";
            this.buttonSmallIcon.Size = new System.Drawing.Size(104, 48);
            this.buttonSmallIcon.TabIndex = 2;
            this.buttonSmallIcon.Text = "SmallIcon";
            this.buttonSmallIcon.UseVisualStyleBackColor = true;
            this.buttonSmallIcon.Click += new System.EventHandler(this.buttonSmallIcon_Click);
            // 
            // buttonList
            // 
            this.buttonList.Location = new System.Drawing.Point(664, 198);
            this.buttonList.Name = "buttonList";
            this.buttonList.Size = new System.Drawing.Size(104, 49);
            this.buttonList.TabIndex = 3;
            this.buttonList.Text = "List";
            this.buttonList.UseVisualStyleBackColor = true;
            this.buttonList.Click += new System.EventHandler(this.buttonList_Click);
            // 
            // buttonDetail
            // 
            this.buttonDetail.Location = new System.Drawing.Point(664, 294);
            this.buttonDetail.Name = "buttonDetail";
            this.buttonDetail.Size = new System.Drawing.Size(104, 55);
            this.buttonDetail.TabIndex = 4;
            this.buttonDetail.Text = "Detail";
            this.buttonDetail.UseVisualStyleBackColor = true;
            this.buttonDetail.Click += new System.EventHandler(this.buttonDetail_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDetail);
            this.Controls.Add(this.buttonList);
            this.Controls.Add(this.buttonSmallIcon);
            this.Controls.Add(this.buttonLargeIcon);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button buttonLargeIcon;
        private System.Windows.Forms.Button buttonSmallIcon;
        private System.Windows.Forms.Button buttonList;
        private System.Windows.Forms.Button buttonDetail;
    }
}

