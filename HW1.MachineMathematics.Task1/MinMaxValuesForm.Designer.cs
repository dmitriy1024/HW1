namespace HW1.MachineMathematics.Task1
{
    partial class MinMaxValuesForm
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
            this.ByteBtn = new System.Windows.Forms.Button();
            this.SByteBtn = new System.Windows.Forms.Button();
            this.Int16Btn = new System.Windows.Forms.Button();
            this.UInt16Btn = new System.Windows.Forms.Button();
            this.Int32Btn = new System.Windows.Forms.Button();
            this.UInt32Btn = new System.Windows.Forms.Button();
            this.Int64Btn = new System.Windows.Forms.Button();
            this.UInt64Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ByteBtn
            // 
            this.ByteBtn.Location = new System.Drawing.Point(13, 26);
            this.ByteBtn.Name = "ByteBtn";
            this.ByteBtn.Size = new System.Drawing.Size(172, 23);
            this.ByteBtn.TabIndex = 0;
            this.ByteBtn.Text = "Byte";
            this.ByteBtn.UseVisualStyleBackColor = true;
            this.ByteBtn.Click += new System.EventHandler(this.ByteBtn_Click);
            // 
            // SByteBtn
            // 
            this.SByteBtn.Location = new System.Drawing.Point(13, 57);
            this.SByteBtn.Name = "SByteBtn";
            this.SByteBtn.Size = new System.Drawing.Size(172, 23);
            this.SByteBtn.TabIndex = 1;
            this.SByteBtn.Text = "SByte";
            this.SByteBtn.UseVisualStyleBackColor = true;
            this.SByteBtn.Click += new System.EventHandler(this.SByteBtn_Click);
            // 
            // Int16Btn
            // 
            this.Int16Btn.Location = new System.Drawing.Point(13, 86);
            this.Int16Btn.Name = "Int16Btn";
            this.Int16Btn.Size = new System.Drawing.Size(172, 23);
            this.Int16Btn.TabIndex = 2;
            this.Int16Btn.Text = "Int16";
            this.Int16Btn.UseVisualStyleBackColor = true;
            this.Int16Btn.Click += new System.EventHandler(this.Int16Btn_Click);
            // 
            // UInt16Btn
            // 
            this.UInt16Btn.Location = new System.Drawing.Point(13, 117);
            this.UInt16Btn.Name = "UInt16Btn";
            this.UInt16Btn.Size = new System.Drawing.Size(172, 23);
            this.UInt16Btn.TabIndex = 3;
            this.UInt16Btn.Text = "UInt16";
            this.UInt16Btn.UseVisualStyleBackColor = true;
            this.UInt16Btn.Click += new System.EventHandler(this.UInt16Btn_Click);
            // 
            // Int32Btn
            // 
            this.Int32Btn.Location = new System.Drawing.Point(13, 146);
            this.Int32Btn.Name = "Int32Btn";
            this.Int32Btn.Size = new System.Drawing.Size(172, 23);
            this.Int32Btn.TabIndex = 4;
            this.Int32Btn.Text = "Int32";
            this.Int32Btn.UseVisualStyleBackColor = true;
            this.Int32Btn.Click += new System.EventHandler(this.Int32Btn_Click);
            // 
            // UInt32Btn
            // 
            this.UInt32Btn.Location = new System.Drawing.Point(13, 175);
            this.UInt32Btn.Name = "UInt32Btn";
            this.UInt32Btn.Size = new System.Drawing.Size(172, 23);
            this.UInt32Btn.TabIndex = 5;
            this.UInt32Btn.Text = "UInt32";
            this.UInt32Btn.UseVisualStyleBackColor = true;
            this.UInt32Btn.Click += new System.EventHandler(this.UInt32Btn_Click);
            // 
            // Int64Btn
            // 
            this.Int64Btn.Location = new System.Drawing.Point(12, 204);
            this.Int64Btn.Name = "Int64Btn";
            this.Int64Btn.Size = new System.Drawing.Size(173, 23);
            this.Int64Btn.TabIndex = 6;
            this.Int64Btn.Text = "Int64";
            this.Int64Btn.UseVisualStyleBackColor = true;
            this.Int64Btn.Click += new System.EventHandler(this.Int64Btn_Click);
            // 
            // UInt64Btn
            // 
            this.UInt64Btn.Location = new System.Drawing.Point(12, 234);
            this.UInt64Btn.Name = "UInt64Btn";
            this.UInt64Btn.Size = new System.Drawing.Size(173, 23);
            this.UInt64Btn.TabIndex = 7;
            this.UInt64Btn.Text = "UInt64";
            this.UInt64Btn.UseVisualStyleBackColor = true;
            this.UInt64Btn.Click += new System.EventHandler(this.UInt64Btn_Click);
            // 
            // MinMaxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 277);
            this.Controls.Add(this.UInt64Btn);
            this.Controls.Add(this.Int64Btn);
            this.Controls.Add(this.UInt32Btn);
            this.Controls.Add(this.Int32Btn);
            this.Controls.Add(this.UInt16Btn);
            this.Controls.Add(this.Int16Btn);
            this.Controls.Add(this.SByteBtn);
            this.Controls.Add(this.ByteBtn);
            this.Name = "MinMaxForm";
            this.Text = "MinMax";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ByteBtn;
        private System.Windows.Forms.Button SByteBtn;
        private System.Windows.Forms.Button Int16Btn;
        private System.Windows.Forms.Button UInt16Btn;
        private System.Windows.Forms.Button Int32Btn;
        private System.Windows.Forms.Button UInt32Btn;
        private System.Windows.Forms.Button Int64Btn;
        private System.Windows.Forms.Button UInt64Btn;
    }
}

