
namespace ADOWinForm
{
    partial class FrmWarmUp
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnHello = new System.Windows.Forms.Button();
            this.btnHi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSetProperty = new System.Windows.Forms.Button();
            this.btnReg3 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnNew1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHello
            // 
            this.btnHello.Location = new System.Drawing.Point(292, 135);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(75, 23);
            this.btnHello.TabIndex = 0;
            this.btnHello.Text = "Hello~UMU";
            this.btnHello.UseVisualStyleBackColor = true;
            this.btnHello.Click += new System.EventHandler(this.btnHello_Click);
            // 
            // btnHi
            // 
            this.btnHi.Location = new System.Drawing.Point(417, 135);
            this.btnHi.Name = "btnHi";
            this.btnHi.Size = new System.Drawing.Size(75, 23);
            this.btnHi.TabIndex = 1;
            this.btnHi.Text = "Hi";
            this.btnHi.UseVisualStyleBackColor = true;
            this.btnHi.Click += new System.EventHandler(this.btnHi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(392, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 3;
            // 
            // btnSetProperty
            // 
            this.btnSetProperty.Location = new System.Drawing.Point(571, 135);
            this.btnSetProperty.Name = "btnSetProperty";
            this.btnSetProperty.Size = new System.Drawing.Size(75, 23);
            this.btnSetProperty.TabIndex = 4;
            this.btnSetProperty.Text = "設定屬性";
            this.btnSetProperty.UseVisualStyleBackColor = true;
            this.btnSetProperty.Click += new System.EventHandler(this.btnSetProperty_Click);
            // 
            // btnReg3
            // 
            this.btnReg3.Location = new System.Drawing.Point(292, 223);
            this.btnReg3.Name = "btnReg3";
            this.btnReg3.Size = new System.Drawing.Size(75, 23);
            this.btnReg3.TabIndex = 5;
            this.btnReg3.Text = "+=註冊";
            this.btnReg3.UseVisualStyleBackColor = true;
            this.btnReg3.Click += new System.EventHandler(this.btnReg3_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(417, 223);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 23);
            this.btn3.TabIndex = 6;
            this.btn3.Text = "Botton3";
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // btnNew1
            // 
            this.btnNew1.Location = new System.Drawing.Point(292, 289);
            this.btnNew1.Name = "btnNew1";
            this.btnNew1.Size = new System.Drawing.Size(75, 23);
            this.btnNew1.TabIndex = 7;
            this.btnNew1.Text = "NewForm1";
            this.btnNew1.UseVisualStyleBackColor = true;
            this.btnNew1.Click += new System.EventHandler(this.btnNew1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(417, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Static vs instance property";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(417, 339);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(229, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Static vs instance method";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(159, 339);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(208, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Hello FormText";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(310, 396);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(208, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "Close";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNew1);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btnReg3);
            this.Controls.Add(this.btnSetProperty);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHi);
            this.Controls.Add(this.btnHello);
            this.Name = "Form1";
            this.Text = "Hello C#";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHello;
        private System.Windows.Forms.Button btnHi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSetProperty;
        private System.Windows.Forms.Button btnReg3;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnNew1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

