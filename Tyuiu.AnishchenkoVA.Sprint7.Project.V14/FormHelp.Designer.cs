namespace Tyuiu.AnishchenkoVA.Sprint7.Project.V14
{
    partial class FormHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHelp));
            buttonOk_AVA = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonOk_AVA
            // 
            buttonOk_AVA.Location = new Point(692, 293);
            buttonOk_AVA.Name = "buttonOk_AVA";
            buttonOk_AVA.Size = new Size(96, 39);
            buttonOk_AVA.TabIndex = 1;
            buttonOk_AVA.Text = "Ок";
            buttonOk_AVA.UseVisualStyleBackColor = true;
            buttonOk_AVA.Click += buttonOk_AVA_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(774, 276);
            label1.TabIndex = 2;
            label1.Text = resources.GetString("label1.Text");
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FormHelp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 339);
            Controls.Add(label1);
            Controls.Add(buttonOk_AVA);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormHelp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Помощь";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonOk_AVA;
        private Label label1;
    }
}