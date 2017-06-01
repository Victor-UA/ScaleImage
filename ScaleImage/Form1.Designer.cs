namespace ScaleImage
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
            this.pictureBox_model = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_X = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_Y = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_Relative = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_rX = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_rY = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_Length = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_realLength = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_Operation = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_Scaling = new System.Windows.Forms.Button();
            this.button_WC_Start = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_model)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_model
            // 
            this.pictureBox_model.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_model.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_model.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_model.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_model.Name = "pictureBox_model";
            this.pictureBox_model.Size = new System.Drawing.Size(760, 251);
            this.pictureBox_model.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_model.TabIndex = 0;
            this.pictureBox_model.TabStop = false;
            this.pictureBox_model.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox_model.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            this.pictureBox_model.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_X,
            this.toolStripStatusLabel_Y,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel_Length,
            this.toolStripStatusLabel_Relative,
            this.toolStripStatusLabel_rX,
            this.toolStripStatusLabel_rY,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel_realLength,
            this.toolStripStatusLabel_Operation});
            this.statusStrip1.Location = new System.Drawing.Point(0, 338);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 24);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_X
            // 
            this.toolStripStatusLabel_X.AutoSize = false;
            this.toolStripStatusLabel_X.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel_X.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.toolStripStatusLabel_X.Name = "toolStripStatusLabel_X";
            this.toolStripStatusLabel_X.Size = new System.Drawing.Size(40, 19);
            // 
            // toolStripStatusLabel_Y
            // 
            this.toolStripStatusLabel_Y.AutoSize = false;
            this.toolStripStatusLabel_Y.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel_Y.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.toolStripStatusLabel_Y.Name = "toolStripStatusLabel_Y";
            this.toolStripStatusLabel_Y.Size = new System.Drawing.Size(40, 19);
            // 
            // toolStripStatusLabel_Relative
            // 
            this.toolStripStatusLabel_Relative.Name = "toolStripStatusLabel_Relative";
            this.toolStripStatusLabel_Relative.Size = new System.Drawing.Size(52, 19);
            this.toolStripStatusLabel_Relative.Text = "rRelative";
            // 
            // toolStripStatusLabel_rX
            // 
            this.toolStripStatusLabel_rX.AutoSize = false;
            this.toolStripStatusLabel_rX.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel_rX.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.toolStripStatusLabel_rX.Name = "toolStripStatusLabel_rX";
            this.toolStripStatusLabel_rX.Size = new System.Drawing.Size(100, 19);
            // 
            // toolStripStatusLabel_rY
            // 
            this.toolStripStatusLabel_rY.AutoSize = false;
            this.toolStripStatusLabel_rY.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel_rY.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.toolStripStatusLabel_rY.Name = "toolStripStatusLabel_rY";
            this.toolStripStatusLabel_rY.Size = new System.Drawing.Size(100, 19);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(44, 19);
            this.toolStripStatusLabel1.Text = "Length";
            // 
            // toolStripStatusLabel_Length
            // 
            this.toolStripStatusLabel_Length.AutoSize = false;
            this.toolStripStatusLabel_Length.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel_Length.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.toolStripStatusLabel_Length.Name = "toolStripStatusLabel_Length";
            this.toolStripStatusLabel_Length.Size = new System.Drawing.Size(60, 19);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(48, 19);
            this.toolStripStatusLabel2.Text = "rLength";
            // 
            // toolStripStatusLabel_realLength
            // 
            this.toolStripStatusLabel_realLength.AutoSize = false;
            this.toolStripStatusLabel_realLength.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel_realLength.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.toolStripStatusLabel_realLength.Name = "toolStripStatusLabel_realLength";
            this.toolStripStatusLabel_realLength.Size = new System.Drawing.Size(100, 19);
            // 
            // toolStripStatusLabel_Operation
            // 
            this.toolStripStatusLabel_Operation.Name = "toolStripStatusLabel_Operation";
            this.toolStripStatusLabel_Operation.Size = new System.Drawing.Size(154, 19);
            this.toolStripStatusLabel_Operation.Spring = true;
            this.toolStripStatusLabel_Operation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(760, 251);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // button_Scaling
            // 
            this.button_Scaling.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_Scaling.Location = new System.Drawing.Point(12, 287);
            this.button_Scaling.Name = "button_Scaling";
            this.button_Scaling.Size = new System.Drawing.Size(75, 23);
            this.button_Scaling.TabIndex = 3;
            this.button_Scaling.Text = "Scaling";
            this.button_Scaling.UseVisualStyleBackColor = true;
            this.button_Scaling.Click += new System.EventHandler(this.button_Scaling_Click);
            // 
            // button_WC_Start
            // 
            this.button_WC_Start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_WC_Start.Location = new System.Drawing.Point(93, 287);
            this.button_WC_Start.Name = "button_WC_Start";
            this.button_WC_Start.Size = new System.Drawing.Size(75, 23);
            this.button_WC_Start.TabIndex = 5;
            this.button_WC_Start.Text = "WC Start";
            this.button_WC_Start.UseVisualStyleBackColor = true;
            this.button_WC_Start.Click += new System.EventHandler(this.button_WC_Start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 362);
            this.Controls.Add(this.button_WC_Start);
            this.Controls.Add(this.button_Scaling);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox_model);
            this.Controls.Add(this.pictureBox1);
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_model)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_model;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_X;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Y;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Relative;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_rX;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_rY;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Length;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_realLength;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Operation;
        private System.Windows.Forms.Button button_Scaling;
        private System.Windows.Forms.Button button_WC_Start;
    }
}

