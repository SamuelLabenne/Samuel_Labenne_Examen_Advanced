namespace Samuel_Labenne_Examen_Advanced
{
    partial class NewEventForm
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
            tbName = new TextBox();
            tbLocation = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Description = new Label();
            label4 = new Label();
            btnSubmit = new Button();
            tbDescription = new RichTextBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // tbName
            // 
            tbName.Location = new Point(226, 91);
            tbName.Name = "tbName";
            tbName.Size = new Size(100, 23);
            tbName.TabIndex = 0;
            // 
            // tbLocation
            // 
            tbLocation.Location = new Point(648, 89);
            tbLocation.Name = "tbLocation";
            tbLocation.Size = new Size(100, 23);
            tbLocation.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 97);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 2;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(549, 97);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 3;
            label2.Text = "Location";
            // 
            // Description
            // 
            Description.AutoSize = true;
            Description.Location = new Point(549, 172);
            Description.Name = "Description";
            Description.Size = new Size(67, 15);
            Description.TabIndex = 4;
            Description.Text = "Description";
            Description.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(105, 172);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 5;
            label4.Text = "Date";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(558, 431);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 6;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click_1;
            // 
            // tbDescription
            // 
            tbDescription.Location = new Point(648, 172);
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(339, 96);
            tbDescription.TabIndex = 8;
            tbDescription.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(549, 301);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 9;
            label3.Text = "Invited";
            label3.Click += label3_Click_1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(648, 301);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(216, 23);
            comboBox1.TabIndex = 11;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(226, 172);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 13;
            // 
            // NewEventForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1585, 558);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(tbDescription);
            Controls.Add(btnSubmit);
            Controls.Add(label4);
            Controls.Add(Description);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbLocation);
            Controls.Add(tbName);
            Name = "NewEventForm";
            Text = "Form3";
            Load += NewEventForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbName;
        private TextBox tbLocation;
        private Label label1;
        private Label label2;
        private Label Description;
        private Label label4;
        private Button btnSubmit;
        private RichTextBox tbDescription;
        private Label label3;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
    }
}