namespace Samuel_Labenne_Examen_Advanced
{
    partial class MdiParent
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
            button2 = new Button();
            btnNewEvent = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(76, 41);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "Open App";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnNewEvent
            // 
            btnNewEvent.Location = new Point(225, 41);
            btnNewEvent.Name = "btnNewEvent";
            btnNewEvent.Size = new Size(149, 23);
            btnNewEvent.TabIndex = 6;
            btnNewEvent.Text = "Nieuw Event";
            btnNewEvent.UseVisualStyleBackColor = true;
            btnNewEvent.Click += btnNewEvent_Click;
            // 
            // MdiParent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1585, 619);
            Controls.Add(btnNewEvent);
            Controls.Add(button2);
            IsMdiContainer = true;
            Name = "MdiParent";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
        private Button button2;
        private Button btnNewEvent;
    }
}