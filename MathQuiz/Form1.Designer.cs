namespace MathQuiz
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timeLabel = new System.Windows.Forms.Label();
            this.lblTimeLeft = new System.Windows.Forms.Label();
            this.plusLeftLabel = new System.Windows.Forms.Label();
            this.plusLeft = new System.Windows.Forms.Label();
            this.plusRightLabel = new System.Windows.Forms.Label();
            this.plusRight = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.NumericUpDown();
            this.minus = new System.Windows.Forms.NumericUpDown();
            this.rightMinus = new System.Windows.Forms.Label();
            this.minusRightLabel = new System.Windows.Forms.Label();
            this.leftMinus = new System.Windows.Forms.Label();
            this.minusLeftLabel = new System.Windows.Forms.Label();
            this.quotient = new System.Windows.Forms.NumericUpDown();
            this.dividedRight = new System.Windows.Forms.Label();
            this.dividedRightLabel = new System.Windows.Forms.Label();
            this.dividedLeft = new System.Windows.Forms.Label();
            this.dividedLeftLabel = new System.Windows.Forms.Label();
            this.product = new System.Windows.Forms.NumericUpDown();
            this.timesRight = new System.Windows.Forms.Label();
            this.timesRightLabel = new System.Windows.Forms.Label();
            this.timesLeft = new System.Windows.Forms.Label();
            this.timesLeftLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).BeginInit();
            this.SuspendLayout();
            // 
            // timeLabel
            // 
            this.timeLabel.BackColor = System.Drawing.SystemColors.Control;
            this.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(241, 15);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(200, 30);
            this.timeLabel.TabIndex = 0;
            // 
            // lblTimeLeft
            // 
            this.lblTimeLeft.AutoSize = true;
            this.lblTimeLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeLeft.Location = new System.Drawing.Point(127, 17);
            this.lblTimeLeft.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTimeLeft.Name = "lblTimeLeft";
            this.lblTimeLeft.Size = new System.Drawing.Size(101, 25);
            this.lblTimeLeft.TabIndex = 1;
            this.lblTimeLeft.Text = "Time Left";
            // 
            // plusLeftLabel
            // 
            this.plusLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusLeftLabel.Location = new System.Drawing.Point(50, 75);
            this.plusLeftLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.plusLeftLabel.Name = "plusLeftLabel";
            this.plusLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.plusLeftLabel.TabIndex = 2;
            this.plusLeftLabel.Text = "?";
            this.plusLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plusLeft
            // 
            this.plusLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusLeft.Location = new System.Drawing.Point(112, 75);
            this.plusLeft.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.plusLeft.Name = "plusLeft";
            this.plusLeft.Size = new System.Drawing.Size(60, 50);
            this.plusLeft.TabIndex = 3;
            this.plusLeft.Text = "+";
            this.plusLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plusRightLabel
            // 
            this.plusRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusRightLabel.Location = new System.Drawing.Point(174, 75);
            this.plusRightLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.plusRightLabel.Name = "plusRightLabel";
            this.plusRightLabel.Size = new System.Drawing.Size(60, 50);
            this.plusRightLabel.TabIndex = 4;
            this.plusRightLabel.Text = "?";
            this.plusRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plusRight
            // 
            this.plusRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusRight.Location = new System.Drawing.Point(236, 75);
            this.plusRight.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.plusRight.Name = "plusRight";
            this.plusRight.Size = new System.Drawing.Size(60, 50);
            this.plusRight.TabIndex = 5;
            this.plusRight.Text = "=";
            this.plusRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sum
            // 
            this.sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sum.Location = new System.Drawing.Point(300, 84);
            this.sum.Name = "sum";
            this.sum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sum.Size = new System.Drawing.Size(100, 35);
            this.sum.TabIndex = 2;
            this.sum.Click += new System.EventHandler(this.answer_Enter);
            this.sum.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // minus
            // 
            this.minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minus.Location = new System.Drawing.Point(300, 139);
            this.minus.Name = "minus";
            this.minus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.minus.Size = new System.Drawing.Size(100, 35);
            this.minus.TabIndex = 3;
            this.minus.Click += new System.EventHandler(this.answer_Enter);
            this.minus.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // rightMinus
            // 
            this.rightMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightMinus.Location = new System.Drawing.Point(236, 129);
            this.rightMinus.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.rightMinus.Name = "rightMinus";
            this.rightMinus.Size = new System.Drawing.Size(60, 50);
            this.rightMinus.TabIndex = 10;
            this.rightMinus.Text = "=";
            this.rightMinus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minusRightLabel
            // 
            this.minusRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusRightLabel.Location = new System.Drawing.Point(174, 129);
            this.minusRightLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.minusRightLabel.Name = "minusRightLabel";
            this.minusRightLabel.Size = new System.Drawing.Size(60, 50);
            this.minusRightLabel.TabIndex = 9;
            this.minusRightLabel.Text = "?";
            this.minusRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // leftMinus
            // 
            this.leftMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftMinus.Location = new System.Drawing.Point(112, 129);
            this.leftMinus.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.leftMinus.Name = "leftMinus";
            this.leftMinus.Size = new System.Drawing.Size(60, 50);
            this.leftMinus.TabIndex = 8;
            this.leftMinus.Text = "-";
            this.leftMinus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minusLeftLabel
            // 
            this.minusLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusLeftLabel.Location = new System.Drawing.Point(50, 129);
            this.minusLeftLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.minusLeftLabel.Name = "minusLeftLabel";
            this.minusLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.minusLeftLabel.TabIndex = 7;
            this.minusLeftLabel.Text = "?";
            this.minusLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quotient
            // 
            this.quotient.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quotient.Location = new System.Drawing.Point(300, 246);
            this.quotient.Name = "quotient";
            this.quotient.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.quotient.Size = new System.Drawing.Size(100, 35);
            this.quotient.TabIndex = 5;
            this.quotient.Click += new System.EventHandler(this.answer_Enter);
            this.quotient.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // dividedRight
            // 
            this.dividedRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividedRight.Location = new System.Drawing.Point(236, 237);
            this.dividedRight.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.dividedRight.Name = "dividedRight";
            this.dividedRight.Size = new System.Drawing.Size(60, 50);
            this.dividedRight.TabIndex = 20;
            this.dividedRight.Text = "=";
            this.dividedRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dividedRightLabel
            // 
            this.dividedRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividedRightLabel.Location = new System.Drawing.Point(174, 237);
            this.dividedRightLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.dividedRightLabel.Name = "dividedRightLabel";
            this.dividedRightLabel.Size = new System.Drawing.Size(60, 50);
            this.dividedRightLabel.TabIndex = 19;
            this.dividedRightLabel.Text = "?";
            this.dividedRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dividedLeft
            // 
            this.dividedLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividedLeft.Location = new System.Drawing.Point(112, 237);
            this.dividedLeft.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.dividedLeft.Name = "dividedLeft";
            this.dividedLeft.Size = new System.Drawing.Size(60, 50);
            this.dividedLeft.TabIndex = 18;
            this.dividedLeft.Text = "÷";
            this.dividedLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dividedLeftLabel
            // 
            this.dividedLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividedLeftLabel.Location = new System.Drawing.Point(50, 237);
            this.dividedLeftLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.dividedLeftLabel.Name = "dividedLeftLabel";
            this.dividedLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.dividedLeftLabel.TabIndex = 17;
            this.dividedLeftLabel.Text = "?";
            this.dividedLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // product
            // 
            this.product.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product.Location = new System.Drawing.Point(300, 192);
            this.product.Name = "product";
            this.product.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.product.Size = new System.Drawing.Size(100, 35);
            this.product.TabIndex = 4;
            this.product.Click += new System.EventHandler(this.answer_Enter);
            this.product.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // timesRight
            // 
            this.timesRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timesRight.Location = new System.Drawing.Point(236, 183);
            this.timesRight.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.timesRight.Name = "timesRight";
            this.timesRight.Size = new System.Drawing.Size(60, 50);
            this.timesRight.TabIndex = 15;
            this.timesRight.Text = "=";
            this.timesRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timesRightLabel
            // 
            this.timesRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timesRightLabel.Location = new System.Drawing.Point(174, 183);
            this.timesRightLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.timesRightLabel.Name = "timesRightLabel";
            this.timesRightLabel.Size = new System.Drawing.Size(60, 50);
            this.timesRightLabel.TabIndex = 14;
            this.timesRightLabel.Text = "?";
            this.timesRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timesLeft
            // 
            this.timesLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timesLeft.Location = new System.Drawing.Point(112, 183);
            this.timesLeft.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.timesLeft.Name = "timesLeft";
            this.timesLeft.Size = new System.Drawing.Size(60, 50);
            this.timesLeft.TabIndex = 13;
            this.timesLeft.Text = "×";
            this.timesLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timesLeftLabel
            // 
            this.timesLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timesLeftLabel.Location = new System.Drawing.Point(50, 183);
            this.timesLeftLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.timesLeftLabel.Name = "timesLeftLabel";
            this.timesLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.timesLeftLabel.TabIndex = 12;
            this.timesLeftLabel.Text = "?";
            this.timesLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startButton
            // 
            this.startButton.AutoSize = true;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(169, 309);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(127, 34);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start the quiz";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // dateLabel
            // 
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(370, 323);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(100, 25);
            this.dateLabel.TabIndex = 21;
            this.dateLabel.Text = "-- : -- : ----";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 357);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.quotient);
            this.Controls.Add(this.dividedRight);
            this.Controls.Add(this.dividedRightLabel);
            this.Controls.Add(this.dividedLeft);
            this.Controls.Add(this.dividedLeftLabel);
            this.Controls.Add(this.product);
            this.Controls.Add(this.timesRight);
            this.Controls.Add(this.timesRightLabel);
            this.Controls.Add(this.timesLeft);
            this.Controls.Add(this.timesLeftLabel);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.rightMinus);
            this.Controls.Add(this.minusRightLabel);
            this.Controls.Add(this.leftMinus);
            this.Controls.Add(this.minusLeftLabel);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.plusRight);
            this.Controls.Add(this.plusRightLabel);
            this.Controls.Add(this.plusLeft);
            this.Controls.Add(this.plusLeftLabel);
            this.Controls.Add(this.lblTimeLeft);
            this.Controls.Add(this.timeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Ilya Kovalyov Math Quiz";
            ((System.ComponentModel.ISupportInitialize)(this.sum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label lblTimeLeft;
        private System.Windows.Forms.Label plusLeftLabel;
        private System.Windows.Forms.Label plusLeft;
        private System.Windows.Forms.Label plusRightLabel;
        private System.Windows.Forms.Label plusRight;
        private System.Windows.Forms.NumericUpDown sum;
        private System.Windows.Forms.NumericUpDown minus;
        private System.Windows.Forms.Label rightMinus;
        private System.Windows.Forms.Label minusRightLabel;
        private System.Windows.Forms.Label leftMinus;
        private System.Windows.Forms.Label minusLeftLabel;
        private System.Windows.Forms.NumericUpDown quotient;
        private System.Windows.Forms.Label dividedRight;
        private System.Windows.Forms.Label dividedRightLabel;
        private System.Windows.Forms.Label dividedLeft;
        private System.Windows.Forms.Label dividedLeftLabel;
        private System.Windows.Forms.NumericUpDown product;
        private System.Windows.Forms.Label timesRight;
        private System.Windows.Forms.Label timesRightLabel;
        private System.Windows.Forms.Label timesLeft;
        private System.Windows.Forms.Label timesLeftLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label dateLabel;
    }
}

