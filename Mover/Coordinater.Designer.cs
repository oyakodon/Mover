namespace Mover
{
    partial class Coordinater
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Coordinater));
            this.lab_instr1 = new System.Windows.Forms.Label();
            this.lab_instr2 = new System.Windows.Forms.Label();
            this.btn_Start = new System.Windows.Forms.Button();
            this.tb_X = new System.Windows.Forms.TextBox();
            this.tb_Y = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lab_instr1
            // 
            this.lab_instr1.AutoSize = true;
            this.lab_instr1.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lab_instr1.Location = new System.Drawing.Point(13, 13);
            this.lab_instr1.Name = "lab_instr1";
            this.lab_instr1.Size = new System.Drawing.Size(40, 18);
            this.lab_instr1.TabIndex = 0;
            this.lab_instr1.Text = "X座標";
            // 
            // lab_instr2
            // 
            this.lab_instr2.AutoSize = true;
            this.lab_instr2.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lab_instr2.Location = new System.Drawing.Point(87, 13);
            this.lab_instr2.Name = "lab_instr2";
            this.lab_instr2.Size = new System.Drawing.Size(40, 18);
            this.lab_instr2.TabIndex = 1;
            this.lab_instr2.Text = "Y座標";
            // 
            // btn_Start
            // 
            this.btn_Start.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_Start.Location = new System.Drawing.Point(170, 22);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(75, 23);
            this.btn_Start.TabIndex = 2;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // tb_X
            // 
            this.tb_X.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tb_X.Location = new System.Drawing.Point(15, 38);
            this.tb_X.Name = "tb_X";
            this.tb_X.Size = new System.Drawing.Size(48, 19);
            this.tb_X.TabIndex = 3;
            this.tb_X.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbox_KeyPress);
            // 
            // tb_Y
            // 
            this.tb_Y.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tb_Y.Location = new System.Drawing.Point(89, 38);
            this.tb_Y.Name = "tb_Y";
            this.tb_Y.Size = new System.Drawing.Size(59, 19);
            this.tb_Y.TabIndex = 4;
            this.tb_Y.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbox_KeyPress);
            // 
            // Coordinater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 68);
            this.Controls.Add(this.tb_Y);
            this.Controls.Add(this.tb_X);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.lab_instr2);
            this.Controls.Add(this.lab_instr1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Coordinater";
            this.Text = "Coordinater";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_instr1;
        private System.Windows.Forms.Label lab_instr2;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.TextBox tb_X;
        private System.Windows.Forms.TextBox tb_Y;
    }
}