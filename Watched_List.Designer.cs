namespace Final_Eda
{
    partial class Watched_List
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
            Watched_list_lbl = new Label();
            monthCbox = new ComboBox();
            username_lbl = new Label();
            dataGridView1 = new DataGridView();
            create_acc = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Watched_list_lbl
            // 
            Watched_list_lbl.AutoSize = true;
            Watched_list_lbl.BackColor = Color.Transparent;
            Watched_list_lbl.Font = new Font("Gadugi", 24F, FontStyle.Bold, GraphicsUnit.Point);
            Watched_list_lbl.ForeColor = Color.FromArgb(203, 212, 242);
            Watched_list_lbl.Location = new Point(49, 112);
            Watched_list_lbl.Name = "Watched_list_lbl";
            Watched_list_lbl.Size = new Size(266, 38);
            Watched_list_lbl.TabIndex = 4;
            Watched_list_lbl.Text = "Watched Movies";
            // 
            // monthCbox
            // 
            monthCbox.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point);
            monthCbox.FormattingEnabled = true;
            monthCbox.Items.AddRange(new object[] { "Title", "Director", "Genre", "Language" });
            monthCbox.Location = new Point(26, 203);
            monthCbox.Name = "monthCbox";
            monthCbox.Size = new Size(306, 27);
            monthCbox.TabIndex = 7;
            // 
            // username_lbl
            // 
            username_lbl.AutoSize = true;
            username_lbl.BackColor = Color.Transparent;
            username_lbl.Font = new Font("Gadugi", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            username_lbl.ForeColor = Color.FromArgb(203, 212, 242);
            username_lbl.Location = new Point(26, 178);
            username_lbl.Name = "username_lbl";
            username_lbl.Size = new Size(73, 22);
            username_lbl.TabIndex = 8;
            username_lbl.Text = "Sort By:";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.FromArgb(52, 71, 105);
            dataGridView1.Location = new Point(26, 249);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(306, 374);
            dataGridView1.TabIndex = 9;
            // 
            // create_acc
            // 
            create_acc.BackColor = Color.FromArgb(67, 137, 207);
            create_acc.FlatAppearance.BorderSize = 0;
            create_acc.FlatStyle = FlatStyle.Flat;
            create_acc.Font = new Font("Gadugi", 15F, FontStyle.Bold, GraphicsUnit.Point);
            create_acc.ForeColor = SystemColors.ButtonHighlight;
            create_acc.Location = new Point(26, 648);
            create_acc.Margin = new Padding(4);
            create_acc.Name = "create_acc";
            create_acc.Size = new Size(306, 36);
            create_acc.TabIndex = 10;
            create_acc.Text = "Back";
            create_acc.UseVisualStyleBackColor = false;
            // 
            // Watched_List
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background_app;
            ClientSize = new Size(357, 776);
            Controls.Add(create_acc);
            Controls.Add(dataGridView1);
            Controls.Add(username_lbl);
            Controls.Add(monthCbox);
            Controls.Add(Watched_list_lbl);
            Name = "Watched_List";
            Text = "Watched_List";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Watched_list_lbl;
        private ComboBox monthCbox;
        private Label username_lbl;
        private DataGridView dataGridView1;
        private Button create_acc;
    }
}