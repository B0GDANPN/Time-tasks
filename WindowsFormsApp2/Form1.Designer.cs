
namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.customListBox1 = new WindowsFormsApp2.CustomListBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.addTask = new System.Windows.Forms.ToolStripButton();
            this.deleteTask = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.playButton = new System.Windows.Forms.ToolStripButton();
            this.pauseButton = new System.Windows.Forms.ToolStripButton();
            this.stopButton = new System.Windows.Forms.ToolStripButton();
            this.completeButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer2 = new System.Windows.Forms.ToolStripContainer();
            this.fileListBox1 = new System.Windows.Forms.ListBox();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.addButton = new System.Windows.Forms.ToolStripButton();
            this.deleteButton = new System.Windows.Forms.ToolStripButton();
            this.sendButton = new System.Windows.Forms.ToolStripButton();
            this.backButton = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.toolStripContainer2.ContentPanel.SuspendLayout();
            this.toolStripContainer2.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer2.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(287, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(513, 150);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информация о задаче";
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.Location = new System.Drawing.Point(130, 122);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(383, 27);
            this.textBox4.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Куда разместить:";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(122, 86);
            this.textBox3.Name = "textBox3";
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox3.Size = new System.Drawing.Size(391, 27);
            this.textBox3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Комментарий:";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(73, 53);
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(440, 27);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Кому:";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(73, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(440, 27);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(3, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "От кого:";
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.customListBox1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(286, 382);
            this.toolStripContainer1.Location = new System.Drawing.Point(1, 1);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(286, 443);
            this.toolStripContainer1.TabIndex = 3;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip2);
            // 
            // customListBox1
            // 
            this.customListBox1.BackColor = System.Drawing.Color.White;
            this.customListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customListBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.customListBox1.FormattingEnabled = true;
            this.customListBox1.ItemHeight = 100;
            this.customListBox1.Location = new System.Drawing.Point(0, 0);
            this.customListBox1.Name = "customListBox1";
            this.customListBox1.Size = new System.Drawing.Size(286, 382);
            this.customListBox1.TabIndex = 0;
            this.customListBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.customListBox1_MouseDoubleClick_1);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.addTask,
            this.deleteTask});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(268, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.AutoSize = false;
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(114, 22);
            this.toolStripLabel1.Text = "Список задач:";
            // 
            // addTask
            // 
            this.addTask.AutoSize = false;
            this.addTask.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.addTask.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addTask.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addTask.Margin = new System.Windows.Forms.Padding(1, 1, 1, 2);
            this.addTask.Name = "addTask";
            this.addTask.Size = new System.Drawing.Size(70, 22);
            this.addTask.Text = "Добавить";
            this.addTask.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // deleteTask
            // 
            this.deleteTask.AutoSize = false;
            this.deleteTask.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.deleteTask.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteTask.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deleteTask.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteTask.Margin = new System.Windows.Forms.Padding(1, 1, 1, 2);
            this.deleteTask.Name = "deleteTask";
            this.deleteTask.Size = new System.Drawing.Size(68, 22);
            this.deleteTask.Text = "Удалить";
            this.deleteTask.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.playButton,
            this.pauseButton,
            this.stopButton,
            this.completeButton});
            this.toolStrip2.Location = new System.Drawing.Point(3, 25);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(268, 36);
            this.toolStrip2.TabIndex = 1;
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.AutoSize = false;
            this.toolStripLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(98, 33);
            this.toolStripLabel2.Text = "Состояние:";
            // 
            // playButton
            // 
            this.playButton.AutoSize = false;
            this.playButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.playButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.playButton.Image = global::WindowsFormsApp2.Properties.Resources.play;
            this.playButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.playButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.playButton.Margin = new System.Windows.Forms.Padding(1, 1, 5, 2);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(35, 33);
            this.playButton.Text = "toolStripButton3";
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.AutoSize = false;
            this.pauseButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pauseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pauseButton.Image = global::WindowsFormsApp2.Properties.Resources.pause;
            this.pauseButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.pauseButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.pauseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pauseButton.Margin = new System.Windows.Forms.Padding(1, 1, 3, 2);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(35, 33);
            this.pauseButton.Text = "toolStripButton4";
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.AutoSize = false;
            this.stopButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.stopButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stopButton.Image = global::WindowsFormsApp2.Properties.Resources.stop;
            this.stopButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.stopButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stopButton.Margin = new System.Windows.Forms.Padding(1, 1, 3, 2);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(35, 33);
            this.stopButton.Text = "toolStripButton5";
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // completeButton
            // 
            this.completeButton.AutoSize = false;
            this.completeButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.completeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.completeButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.completeButton.Image = global::WindowsFormsApp2.Properties.Resources.mark;
            this.completeButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.completeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.completeButton.Margin = new System.Windows.Forms.Padding(1, 1, 3, 2);
            this.completeButton.Name = "completeButton";
            this.completeButton.Size = new System.Drawing.Size(35, 33);
            this.completeButton.Text = "toolStripButton6";
            this.completeButton.Click += new System.EventHandler(this.completeButton_Click);
            // 
            // toolStripContainer2
            // 
            this.toolStripContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // toolStripContainer2.ContentPanel
            // 
            this.toolStripContainer2.ContentPanel.Controls.Add(this.fileListBox1);
            this.toolStripContainer2.ContentPanel.Size = new System.Drawing.Size(513, 272);
            this.toolStripContainer2.Location = new System.Drawing.Point(287, 156);
            this.toolStripContainer2.Name = "toolStripContainer2";
            this.toolStripContainer2.Size = new System.Drawing.Size(513, 297);
            this.toolStripContainer2.TabIndex = 4;
            this.toolStripContainer2.Text = "toolStripContainer2";
            // 
            // toolStripContainer2.TopToolStripPanel
            // 
            this.toolStripContainer2.TopToolStripPanel.Controls.Add(this.toolStrip3);
            // 
            // fileListBox1
            // 
            this.fileListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileListBox1.FormattingEnabled = true;
            this.fileListBox1.Location = new System.Drawing.Point(0, 0);
            this.fileListBox1.Name = "fileListBox1";
            this.fileListBox1.Size = new System.Drawing.Size(513, 272);
            this.fileListBox1.TabIndex = 0;
            this.fileListBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.fileListBox1_MouseDoubleClick);
            // 
            // toolStrip3
            // 
            this.toolStrip3.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addButton,
            this.deleteButton,
            this.sendButton,
            this.backButton});
            this.toolStrip3.Location = new System.Drawing.Point(3, 0);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(262, 25);
            this.toolStrip3.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.addButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(63, 22);
            this.addButton.Text = "Добавить";
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.deleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteButton.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(55, 22);
            this.deleteButton.Text = "Удалить";
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // sendButton
            // 
            this.sendButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.sendButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sendButton.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(69, 22);
            this.sendButton.Text = "Отправить";
            this.sendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // backButton
            // 
            this.backButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.backButton.Image = ((System.Drawing.Image)(resources.GetObject("backButton.Image")));
            this.backButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(43, 22);
            this.backButton.Text = "Hазад";
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStripContainer2);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.toolStripContainer2.ContentPanel.ResumeLayout(false);
            this.toolStripContainer2.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer2.TopToolStripPanel.PerformLayout();
            this.toolStripContainer2.ResumeLayout(false);
            this.toolStripContainer2.PerformLayout();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton addTask;
        private System.Windows.Forms.ToolStripButton deleteTask;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton playButton;
        private System.Windows.Forms.ToolStripButton pauseButton;
        private System.Windows.Forms.ToolStripButton stopButton;
        private System.Windows.Forms.ToolStripButton completeButton;
        public System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripContainer toolStripContainer2;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton addButton;
        private System.Windows.Forms.ToolStripButton deleteButton;
        private System.Windows.Forms.ToolStripButton sendButton;
        public CustomListBox customListBox1;
        private System.Windows.Forms.ListBox fileListBox1;
        private System.Windows.Forms.ToolStripButton backButton;
    }
}

