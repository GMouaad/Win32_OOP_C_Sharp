namespace BloodPressureMeasurement
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

        MGenericTestG[] MArrayG = new MGenericTestG[10];
        int MCounterG = 0;
        private MGenericTestG currentTest;
        public MGenericTestG MgetCurrentTestG()
        {
            return currentTest;
        }
       

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));

            this.StartTestButton = new System.Windows.Forms.Button();

            this.button1 = new System.Windows.Forms.Button();

            //this.button2 = new System.Windows.Forms.Button();

            this.comboBox1 = new System.Windows.Forms.ComboBox();

            this.menuStrip1 = new System.Windows.Forms.MenuStrip();

            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();

            this.newTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();

            this.startTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();

            this.editTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();

            this.printTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();

            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();

            this.measurementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();

            this.readMeasurementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();

            this.loadMeasurementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();

            this.storeDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();

            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();

            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();

            this.menuStrip1.SuspendLayout();

            this.SuspendLayout();

            // 

            // StartTestButton

            // 

            this.StartTestButton.Location = new System.Drawing.Point(29, 123);

            this.StartTestButton.Name = "StartTestButton";

            this.StartTestButton.Size = new System.Drawing.Size(116, 23);

            this.StartTestButton.TabIndex = 0;

            this.StartTestButton.Text = "Start Test";

            this.StartTestButton.UseVisualStyleBackColor = true;

            this.StartTestButton.Click += new System.EventHandler(this.StartBtnClicked);

            // 

            // button1

            // 

            this.button1.Location = new System.Drawing.Point(29, 152);

            this.button1.Name = "button1";

            this.button1.Size = new System.Drawing.Size(116, 23);

            this.button1.TabIndex = 1;

            this.button1.Text = "Read Measurement";

            this.button1.UseVisualStyleBackColor = true;

            // 

            // button2

            // 

            /*this.button2.Location = new System.Drawing.Point(29, 208);

            this.button2.Name = "button2";

            this.button2.Size = new System.Drawing.Size(116, 23);

            this.button2.TabIndex = 2;

            this.button2.Text = "Exit";

            this.button2.UseVisualStyleBackColor = true;
            */
            // 

            // comboBox1

            // 

            this.comboBox1.BackColor = System.Drawing.SystemColors.MenuBar;

            this.comboBox1.FormattingEnabled = true;

            this.comboBox1.Location = new System.Drawing.Point(29, 181);

            this.comboBox1.Name = "comboBox1";

            this.comboBox1.Size = new System.Drawing.Size(116, 21);

            this.comboBox1.TabIndex = 3;

            this.comboBox1.Text = "Select Test";

            // 

            // menuStrip1

            // 

            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {

            this.testToolStripMenuItem,

            this.measurementToolStripMenuItem,

            this.windowToolStripMenuItem,

            this.helpToolStripMenuItem});

            this.menuStrip1.Location = new System.Drawing.Point(0, 0);

            this.menuStrip1.Name = "menuStrip1";

            this.menuStrip1.Size = new System.Drawing.Size(584, 24);

            this.menuStrip1.TabIndex = 4;

            this.menuStrip1.Text = "menuStrip1";

            // 

            // testToolStripMenuItem

            // 

            this.testToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {

            this.newTestToolStripMenuItem,

            this.startTestToolStripMenuItem,

            this.editTestToolStripMenuItem,

            this.printTestToolStripMenuItem,

            this.exitToolStripMenuItem});

            this.testToolStripMenuItem.Name = "testToolStripMenuItem";

            this.testToolStripMenuItem.Size = new System.Drawing.Size(37, 20);

            this.testToolStripMenuItem.Text = "File";

            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);

            // 

            // newTestToolStripMenuItem

            // 

            this.newTestToolStripMenuItem.Name = "newTestToolStripMenuItem";

            this.newTestToolStripMenuItem.Size = new System.Drawing.Size(152, 22);

            this.newTestToolStripMenuItem.Text = "New Test";

            // 

            // startTestToolStripMenuItem

            // 

            this.startTestToolStripMenuItem.Name = "startTestToolStripMenuItem";

            this.startTestToolStripMenuItem.Size = new System.Drawing.Size(152, 22);

            this.startTestToolStripMenuItem.Text = "Start Test";

            // 

            // editTestToolStripMenuItem

            // 

            this.editTestToolStripMenuItem.Name = "editTestToolStripMenuItem";

            this.editTestToolStripMenuItem.Size = new System.Drawing.Size(152, 22);

            this.editTestToolStripMenuItem.Text = "Edit Test";

            // 

            // printTestToolStripMenuItem

            // 

            this.printTestToolStripMenuItem.Name = "printTestToolStripMenuItem";

            this.printTestToolStripMenuItem.Size = new System.Drawing.Size(152, 22);

            this.printTestToolStripMenuItem.Text = "Print Test";

            // 

            // exitToolStripMenuItem

            // 

            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";

            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);

            this.exitToolStripMenuItem.Text = "Exit";

            // 

            // measurementToolStripMenuItem

            // 

            this.measurementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {

            this.readMeasurementToolStripMenuItem,

            this.loadMeasurementToolStripMenuItem,

            this.storeDataToolStripMenuItem});

            this.measurementToolStripMenuItem.Name = "measurementToolStripMenuItem";

            this.measurementToolStripMenuItem.Size = new System.Drawing.Size(92, 20);

            this.measurementToolStripMenuItem.Text = "Measurement";

            // 

            // readMeasurementToolStripMenuItem

            // 

            this.readMeasurementToolStripMenuItem.Name = "readMeasurementToolStripMenuItem";

            this.readMeasurementToolStripMenuItem.Size = new System.Drawing.Size(176, 22);

            this.readMeasurementToolStripMenuItem.Text = "Read Measurement";

            // 

            // loadMeasurementToolStripMenuItem

            // 

            this.loadMeasurementToolStripMenuItem.Name = "loadMeasurementToolStripMenuItem";

            this.loadMeasurementToolStripMenuItem.Size = new System.Drawing.Size(176, 22);

            this.loadMeasurementToolStripMenuItem.Text = "Load Measurement";

            // 

            // storeDataToolStripMenuItem

            // 

            this.storeDataToolStripMenuItem.Name = "storeDataToolStripMenuItem";

            this.storeDataToolStripMenuItem.Size = new System.Drawing.Size(176, 22);

            this.storeDataToolStripMenuItem.Text = "Store Data";

            // 

            // windowToolStripMenuItem

            // 

            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";

            this.windowToolStripMenuItem.Size = new System.Drawing.Size(61, 20);

            this.windowToolStripMenuItem.Text = "window";

            // 

            // helpToolStripMenuItem

            // 

            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";

            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);

            this.helpToolStripMenuItem.Text = "Help";

            // 

            // Form1

            // 

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);

            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize = new System.Drawing.Size(584, 361);

            this.Controls.Add(this.comboBox1);

            //this.Controls.Add(this.button2);

            this.Controls.Add(this.button1);

            this.Controls.Add(this.StartTestButton);

            this.Controls.Add(this.menuStrip1);

            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));

            this.MainMenuStrip = this.menuStrip1;

            this.Name = "Form1";

            this.Text = "Blood Pressure Measurement";

            this.menuStrip1.ResumeLayout(false);

            this.menuStrip1.PerformLayout();

            this.ResumeLayout(false);

            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartTestButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem measurementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readMeasurementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadMeasurementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem storeDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;

    }
}

