namespace Informacion_estudiantes
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
            btnsave = new Button();
            txtcompras = new TextBox();
            label1 = new Label();
            listcompras = new ListView();
            btnshow = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnsave
            // 
            btnsave.BackColor = SystemColors.Highlight;
            btnsave.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnsave.Location = new Point(532, 74);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(179, 57);
            btnsave.TabIndex = 0;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = false;
            btnsave.Click += btnsave_Click;
            // 
            // txtcompras
            // 
            txtcompras.BackColor = SystemColors.InactiveCaption;
            txtcompras.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtcompras.Location = new Point(96, 88);
            txtcompras.Name = "txtcompras";
            txtcompras.Size = new Size(338, 33);
            txtcompras.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(350, 20);
            label1.Name = "label1";
            label1.Size = new Size(144, 30);
            label1.TabIndex = 3;
            label1.Text = "Shopping list";
            // 
            // listcompras
            // 
            listcompras.BackColor = SystemColors.InactiveBorder;
            listcompras.Location = new Point(62, 159);
            listcompras.Name = "listcompras";
            listcompras.Size = new Size(408, 283);
            listcompras.TabIndex = 4;
            listcompras.UseCompatibleStateImageBehavior = false;
            listcompras.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // btnshow
            // 
            btnshow.BackColor = SystemColors.Highlight;
            btnshow.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnshow.Location = new Point(532, 352);
            btnshow.Name = "btnshow";
            btnshow.Size = new Size(179, 66);
            btnshow.TabIndex = 5;
            btnshow.Text = "Show";
            btnshow.UseVisualStyleBackColor = false;
            btnshow.Click += btnshow_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(500, 20);
            label2.Name = "label2";
            label2.Size = new Size(38, 30);
            label2.TabIndex = 6;
            label2.Text = "C#";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(865, 478);
            Controls.Add(label2);
            Controls.Add(btnshow);
            Controls.Add(listcompras);
            Controls.Add(label1);
            Controls.Add(txtcompras);
            Controls.Add(btnsave);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnsave;
        private TextBox txtcompras;
        private Label label1;
        private ListView listcompras;
        private Button btnshow;
        private Label label2;
    }
}