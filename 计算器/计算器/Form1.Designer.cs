namespace Calculator
{
    partial class Operation
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Operation));
            this.number1 = new System.Windows.Forms.Button();
            this.number2 = new System.Windows.Forms.Button();
            this.number3 = new System.Windows.Forms.Button();
            this.number4 = new System.Windows.Forms.Button();
            this.number5 = new System.Windows.Forms.Button();
            this.number6 = new System.Windows.Forms.Button();
            this.number7 = new System.Windows.Forms.Button();
            this.number8 = new System.Windows.Forms.Button();
            this.number9 = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.TextBox();
            this.author = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // number1
            // 
            this.number1.CausesValidation = false;
            resources.ApplyResources(this.number1, "number1");
            this.number1.Name = "number1";
            this.number1.Click += new System.EventHandler(this.number1_Click);
            // 
            // number2
            // 
            resources.ApplyResources(this.number2, "number2");
            this.number2.Name = "number2";
            this.number2.UseVisualStyleBackColor = true;
            this.number2.Click += new System.EventHandler(this.number2_Click);
            // 
            // number3
            // 
            resources.ApplyResources(this.number3, "number3");
            this.number3.Name = "number3";
            this.number3.UseVisualStyleBackColor = true;
            this.number3.Click += new System.EventHandler(this.number3_Click);
            // 
            // number4
            // 
            resources.ApplyResources(this.number4, "number4");
            this.number4.Name = "number4";
            this.number4.UseVisualStyleBackColor = true;
            this.number4.Click += new System.EventHandler(this.number4_Click);
            // 
            // number5
            // 
            resources.ApplyResources(this.number5, "number5");
            this.number5.Name = "number5";
            this.number5.UseVisualStyleBackColor = true;
            this.number5.Click += new System.EventHandler(this.number5_Click);
            // 
            // number6
            // 
            resources.ApplyResources(this.number6, "number6");
            this.number6.Name = "number6";
            this.number6.UseVisualStyleBackColor = true;
            this.number6.Click += new System.EventHandler(this.number6_Click);
            // 
            // number7
            // 
            resources.ApplyResources(this.number7, "number7");
            this.number7.Name = "number7";
            this.number7.UseVisualStyleBackColor = true;
            this.number7.Click += new System.EventHandler(this.number7_Click);
            // 
            // number8
            // 
            resources.ApplyResources(this.number8, "number8");
            this.number8.Name = "number8";
            this.number8.UseVisualStyleBackColor = true;
            this.number8.Click += new System.EventHandler(this.number8_Click);
            // 
            // number9
            // 
            resources.ApplyResources(this.number9, "number9");
            this.number9.Name = "number9";
            this.number9.UseVisualStyleBackColor = true;
            this.number9.Click += new System.EventHandler(this.number9_Click);
            // 
            // zero
            // 
            resources.ApplyResources(this.zero, "zero");
            this.zero.Name = "zero";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // result
            // 
            resources.ApplyResources(this.result, "result");
            this.result.Name = "result";
            this.result.UseVisualStyleBackColor = true;
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // add
            // 
            resources.ApplyResources(this.add, "add");
            this.add.Name = "add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // sub
            // 
            resources.ApplyResources(this.sub, "sub");
            this.sub.Name = "sub";
            this.sub.UseVisualStyleBackColor = true;
            this.sub.Click += new System.EventHandler(this.sub_Click);
            // 
            // multiply
            // 
            resources.ApplyResources(this.multiply, "multiply");
            this.multiply.Name = "multiply";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // remove
            // 
            resources.ApplyResources(this.remove, "remove");
            this.remove.Name = "remove";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // back
            // 
            resources.ApplyResources(this.back, "back");
            this.back.Name = "back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // clear
            // 
            resources.ApplyResources(this.clear, "clear");
            this.clear.Name = "clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // output
            // 
            this.output.BackColor = System.Drawing.SystemColors.Window;
            this.output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.output.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.output.ForeColor = System.Drawing.SystemColors.WindowText;
            resources.ApplyResources(this.output, "output");
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.TextChanged += new System.EventHandler(this.output_TextChanged);
            // 
            // author
            // 
            resources.ApplyResources(this.author, "author");
            this.author.Name = "author";
            this.author.Click += new System.EventHandler(this.author_Click);
            // 
            // Operation
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.Controls.Add(this.author);
            this.Controls.Add(this.output);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.back);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.add);
            this.Controls.Add(this.result);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.number9);
            this.Controls.Add(this.number8);
            this.Controls.Add(this.number7);
            this.Controls.Add(this.number6);
            this.Controls.Add(this.number5);
            this.Controls.Add(this.number4);
            this.Controls.Add(this.number3);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.number1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Operation";
            this.Load += new System.EventHandler(this.operation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button number1;
        private System.Windows.Forms.Button number2;
        private System.Windows.Forms.Button number3;
        private System.Windows.Forms.Button number4;
        private System.Windows.Forms.Button number5;
        private System.Windows.Forms.Button number6;
        private System.Windows.Forms.Button number7;
        private System.Windows.Forms.Button number8;
        private System.Windows.Forms.Button number9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button result;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Label author;
    }
}

