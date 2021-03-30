
namespace Task7_Usvyatsov
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
            this.pxGraph = new System.Windows.Forms.PictureBox();
            this.buDraw = new System.Windows.Forms.Button();
            this.pxGraphChanged = new System.Windows.Forms.PictureBox();
            this.teEi = new System.Windows.Forms.TextBox();
            this.laEi = new System.Windows.Forms.Label();
            this.laEs = new System.Windows.Forms.Label();
            this.teEs = new System.Windows.Forms.TextBox();
            this.laD = new System.Windows.Forms.Label();
            this.teD = new System.Windows.Forms.TextBox();
            this.laX_ = new System.Windows.Forms.Label();
            this.teX_ = new System.Windows.Forms.TextBox();
            this.grIn = new System.Windows.Forms.GroupBox();
            this.grOut = new System.Windows.Forms.GroupBox();
            this.teUnfix = new System.Windows.Forms.TextBox();
            this.teOk = new System.Windows.Forms.TextBox();
            this.laOk = new System.Windows.Forms.Label();
            this.laFix = new System.Windows.Forms.Label();
            this.laUnfix = new System.Windows.Forms.Label();
            this.teFix = new System.Windows.Forms.TextBox();
            this.grOutChanged = new System.Windows.Forms.GroupBox();
            this.teOkChanged = new System.Windows.Forms.TextBox();
            this.laOkChanged = new System.Windows.Forms.Label();
            this.laFixChanged = new System.Windows.Forms.Label();
            this.teFixChanged = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pxGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxGraphChanged)).BeginInit();
            this.grIn.SuspendLayout();
            this.grOut.SuspendLayout();
            this.grOutChanged.SuspendLayout();
            this.SuspendLayout();
            // 
            // pxGraph
            // 
            this.pxGraph.BackColor = System.Drawing.Color.White;
            this.pxGraph.Location = new System.Drawing.Point(12, 12);
            this.pxGraph.Name = "pxGraph";
            this.pxGraph.Size = new System.Drawing.Size(600, 300);
            this.pxGraph.TabIndex = 0;
            this.pxGraph.TabStop = false;
            // 
            // buDraw
            // 
            this.buDraw.Location = new System.Drawing.Point(620, 578);
            this.buDraw.Name = "buDraw";
            this.buDraw.Size = new System.Drawing.Size(413, 40);
            this.buDraw.TabIndex = 1;
            this.buDraw.Text = "Построить";
            this.buDraw.UseVisualStyleBackColor = true;
            // 
            // pxGraphChanged
            // 
            this.pxGraphChanged.BackColor = System.Drawing.Color.White;
            this.pxGraphChanged.Location = new System.Drawing.Point(12, 318);
            this.pxGraphChanged.Name = "pxGraphChanged";
            this.pxGraphChanged.Size = new System.Drawing.Size(600, 300);
            this.pxGraphChanged.TabIndex = 2;
            this.pxGraphChanged.TabStop = false;
            // 
            // teEi
            // 
            this.teEi.Location = new System.Drawing.Point(103, 30);
            this.teEi.Name = "teEi";
            this.teEi.Size = new System.Drawing.Size(283, 23);
            this.teEi.TabIndex = 3;
            // 
            // laEi
            // 
            this.laEi.AutoSize = true;
            this.laEi.Location = new System.Drawing.Point(70, 33);
            this.laEi.Name = "laEi";
            this.laEi.Size = new System.Drawing.Size(27, 15);
            this.laEi.TabIndex = 4;
            this.laEi.Text = "ei =";
            // 
            // laEs
            // 
            this.laEs.AutoSize = true;
            this.laEs.Location = new System.Drawing.Point(68, 62);
            this.laEs.Name = "laEs";
            this.laEs.Size = new System.Drawing.Size(29, 15);
            this.laEs.TabIndex = 6;
            this.laEs.Text = "es =";
            // 
            // teEs
            // 
            this.teEs.Location = new System.Drawing.Point(103, 59);
            this.teEs.Name = "teEs";
            this.teEs.Size = new System.Drawing.Size(283, 23);
            this.teEs.TabIndex = 5;
            // 
            // laD
            // 
            this.laD.AutoSize = true;
            this.laD.Location = new System.Drawing.Point(70, 120);
            this.laD.Name = "laD";
            this.laD.Size = new System.Drawing.Size(25, 15);
            this.laD.TabIndex = 10;
            this.laD.Text = "σ =";
            // 
            // teD
            // 
            this.teD.Location = new System.Drawing.Point(103, 117);
            this.teD.Name = "teD";
            this.teD.Size = new System.Drawing.Size(283, 23);
            this.teD.TabIndex = 9;
            // 
            // laX_
            // 
            this.laX_.AutoSize = true;
            this.laX_.Location = new System.Drawing.Point(28, 91);
            this.laX_.Name = "laX_";
            this.laX_.Size = new System.Drawing.Size(69, 15);
            this.laX_.TabIndex = 8;
            this.laX_.Text = "x (ср. зн.) =";
            // 
            // teX_
            // 
            this.teX_.Location = new System.Drawing.Point(103, 88);
            this.teX_.Name = "teX_";
            this.teX_.Size = new System.Drawing.Size(283, 23);
            this.teX_.TabIndex = 7;
            // 
            // grIn
            // 
            this.grIn.Controls.Add(this.teEs);
            this.grIn.Controls.Add(this.laD);
            this.grIn.Controls.Add(this.teEi);
            this.grIn.Controls.Add(this.teD);
            this.grIn.Controls.Add(this.laEi);
            this.grIn.Controls.Add(this.laX_);
            this.grIn.Controls.Add(this.laEs);
            this.grIn.Controls.Add(this.teX_);
            this.grIn.Location = new System.Drawing.Point(620, 12);
            this.grIn.Name = "grIn";
            this.grIn.Size = new System.Drawing.Size(413, 161);
            this.grIn.TabIndex = 11;
            this.grIn.TabStop = false;
            this.grIn.Text = "Входные данные";
            // 
            // grOut
            // 
            this.grOut.Controls.Add(this.teUnfix);
            this.grOut.Controls.Add(this.teOk);
            this.grOut.Controls.Add(this.laOk);
            this.grOut.Controls.Add(this.laFix);
            this.grOut.Controls.Add(this.laUnfix);
            this.grOut.Controls.Add(this.teFix);
            this.grOut.Location = new System.Drawing.Point(620, 179);
            this.grOut.Name = "grOut";
            this.grOut.Size = new System.Drawing.Size(413, 133);
            this.grOut.TabIndex = 12;
            this.grOut.TabStop = false;
            this.grOut.Text = "Выходные данные";
            // 
            // teUnfix
            // 
            this.teUnfix.Location = new System.Drawing.Point(183, 61);
            this.teUnfix.Name = "teUnfix";
            this.teUnfix.Size = new System.Drawing.Size(212, 23);
            this.teUnfix.TabIndex = 5;
            // 
            // teOk
            // 
            this.teOk.Location = new System.Drawing.Point(183, 32);
            this.teOk.Name = "teOk";
            this.teOk.Size = new System.Drawing.Size(212, 23);
            this.teOk.TabIndex = 3;
            // 
            // laOk
            // 
            this.laOk.AutoSize = true;
            this.laOk.Location = new System.Drawing.Point(60, 35);
            this.laOk.Name = "laOk";
            this.laOk.Size = new System.Drawing.Size(117, 15);
            this.laOk.TabIndex = 4;
            this.laOk.Text = "% годных деталей =";
            // 
            // laFix
            // 
            this.laFix.AutoSize = true;
            this.laFix.Location = new System.Drawing.Point(37, 93);
            this.laFix.Name = "laFix";
            this.laFix.Size = new System.Drawing.Size(140, 15);
            this.laFix.TabIndex = 8;
            this.laFix.Text = "% исправимого брака =";
            // 
            // laUnfix
            // 
            this.laUnfix.AutoSize = true;
            this.laUnfix.Location = new System.Drawing.Point(24, 64);
            this.laUnfix.Name = "laUnfix";
            this.laUnfix.Size = new System.Drawing.Size(153, 15);
            this.laUnfix.TabIndex = 6;
            this.laUnfix.Text = "% неисправимого брака =";
            // 
            // teFix
            // 
            this.teFix.Location = new System.Drawing.Point(183, 90);
            this.teFix.Name = "teFix";
            this.teFix.Size = new System.Drawing.Size(212, 23);
            this.teFix.TabIndex = 7;
            // 
            // grOutChanged
            // 
            this.grOutChanged.Controls.Add(this.teOkChanged);
            this.grOutChanged.Controls.Add(this.laOkChanged);
            this.grOutChanged.Controls.Add(this.laFixChanged);
            this.grOutChanged.Controls.Add(this.teFixChanged);
            this.grOutChanged.Location = new System.Drawing.Point(620, 318);
            this.grOutChanged.Name = "grOutChanged";
            this.grOutChanged.Size = new System.Drawing.Size(413, 105);
            this.grOutChanged.TabIndex = 13;
            this.grOutChanged.TabStop = false;
            this.grOutChanged.Text = " Выходные данные при x (ср. зн.) = ....";
            // 
            // teOkChanged
            // 
            this.teOkChanged.Location = new System.Drawing.Point(183, 32);
            this.teOkChanged.Name = "teOkChanged";
            this.teOkChanged.Size = new System.Drawing.Size(212, 23);
            this.teOkChanged.TabIndex = 3;
            // 
            // laOkChanged
            // 
            this.laOkChanged.AutoSize = true;
            this.laOkChanged.Location = new System.Drawing.Point(60, 35);
            this.laOkChanged.Name = "laOkChanged";
            this.laOkChanged.Size = new System.Drawing.Size(117, 15);
            this.laOkChanged.TabIndex = 4;
            this.laOkChanged.Text = "% годных деталей =";
            // 
            // laFixChanged
            // 
            this.laFixChanged.AutoSize = true;
            this.laFixChanged.Location = new System.Drawing.Point(37, 64);
            this.laFixChanged.Name = "laFixChanged";
            this.laFixChanged.Size = new System.Drawing.Size(140, 15);
            this.laFixChanged.TabIndex = 8;
            this.laFixChanged.Text = "% исправимого брака =";
            // 
            // teFixChanged
            // 
            this.teFixChanged.Location = new System.Drawing.Point(183, 61);
            this.teFixChanged.Name = "teFixChanged";
            this.teFixChanged.Size = new System.Drawing.Size(212, 23);
            this.teFixChanged.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 629);
            this.Controls.Add(this.grOutChanged);
            this.Controls.Add(this.grOut);
            this.Controls.Add(this.grIn);
            this.Controls.Add(this.pxGraphChanged);
            this.Controls.Add(this.buDraw);
            this.Controls.Add(this.pxGraph);
            this.MaximumSize = new System.Drawing.Size(1061, 668);
            this.MinimumSize = new System.Drawing.Size(1061, 668);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pxGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxGraphChanged)).EndInit();
            this.grIn.ResumeLayout(false);
            this.grIn.PerformLayout();
            this.grOut.ResumeLayout(false);
            this.grOut.PerformLayout();
            this.grOutChanged.ResumeLayout(false);
            this.grOutChanged.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pxGraph;
        private System.Windows.Forms.Button buDraw;
        private System.Windows.Forms.PictureBox зчПкфзр;
        private System.Windows.Forms.PictureBox pxGraphChanged;
        private System.Windows.Forms.TextBox teEi;
        private System.Windows.Forms.Label laEi;
        private System.Windows.Forms.Label laEs;
        private System.Windows.Forms.TextBox teEs;
        private System.Windows.Forms.Label laD;
        private System.Windows.Forms.TextBox teD;
        private System.Windows.Forms.Label laX_;
        private System.Windows.Forms.TextBox teX_;
        private System.Windows.Forms.GroupBox grIn;
        private System.Windows.Forms.GroupBox grOut;
        private System.Windows.Forms.TextBox teUnfix;
        private System.Windows.Forms.TextBox teOk;
        private System.Windows.Forms.Label laOk;
        private System.Windows.Forms.Label laFix;
        private System.Windows.Forms.Label laUnfix;
        private System.Windows.Forms.TextBox teFix;
        private System.Windows.Forms.GroupBox grOutChanged;
        private System.Windows.Forms.TextBox teOkChanged;
        private System.Windows.Forms.Label laOkChanged;
        private System.Windows.Forms.Label laFixChanged;
        private System.Windows.Forms.TextBox teFixChanged;
    }
}

