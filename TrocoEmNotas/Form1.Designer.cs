namespace TrocoEmNotas
{
    partial class FormCalcular
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.textBoxPago = new System.Windows.Forms.TextBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelPago = new System.Windows.Forms.Label();
            this.richTextTroco = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(88, 123);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(88, 16);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(100, 23);
            this.textBoxTotal.TabIndex = 1;
            this.textBoxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTotal_KeyPress);
            this.textBoxTotal.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxTotal_Validating);
            // 
            // textBoxPago
            // 
            this.textBoxPago.Location = new System.Drawing.Point(88, 63);
            this.textBoxPago.Name = "textBoxPago";
            this.textBoxPago.Size = new System.Drawing.Size(100, 23);
            this.textBoxPago.TabIndex = 2;
            this.textBoxPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPago_KeyPress);
            this.textBoxPago.Validated += new System.EventHandler(this.textBoxPago_Validated);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(12, 24);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(61, 15);
            this.labelTotal.TabIndex = 3;
            this.labelTotal.Text = "Valor Total";
            // 
            // labelPago
            // 
            this.labelPago.AutoSize = true;
            this.labelPago.Location = new System.Drawing.Point(12, 71);
            this.labelPago.Name = "labelPago";
            this.labelPago.Size = new System.Drawing.Size(63, 15);
            this.labelPago.TabIndex = 4;
            this.labelPago.Text = "Valor Pago";
            // 
            // richTextTroco
            // 
            this.richTextTroco.Location = new System.Drawing.Point(48, 170);
            this.richTextTroco.Name = "richTextTroco";
            this.richTextTroco.Size = new System.Drawing.Size(237, 96);
            this.richTextTroco.TabIndex = 5;
            this.richTextTroco.Text = "";
            // 
            // FormCalcular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 287);
            this.Controls.Add(this.richTextTroco);
            this.Controls.Add(this.labelPago);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.textBoxPago);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.btnCalcular);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCalcular";
            this.Text = "Calculadora de troco";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCalcular;
        private TextBox textBoxTotal;
        private TextBox textBoxPago;
        private Label labelTotal;
        private Label labelPago;
        private RichTextBox richTextTroco;
    }
}