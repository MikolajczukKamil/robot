namespace TrybGraficzny
{
    partial class Map
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Map));
            this.TmpMoveBox = new System.Windows.Forms.Panel();
            this.NextMoveBox = new System.Windows.Forms.Panel();
            this.TargetBox = new System.Windows.Forms.PictureBox();
            this.RobotBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.TargetBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RobotBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TmpMoveBox
            // 
            this.TmpMoveBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.TmpMoveBox.Location = new System.Drawing.Point(24, 0);
            this.TmpMoveBox.Margin = new System.Windows.Forms.Padding(0);
            this.TmpMoveBox.Name = "TmpMoveBox";
            this.TmpMoveBox.Size = new System.Drawing.Size(100, 6);
            this.TmpMoveBox.TabIndex = 1;
            // 
            // NextMoveBox
            // 
            this.NextMoveBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.NextMoveBox.Location = new System.Drawing.Point(24, 18);
            this.NextMoveBox.Margin = new System.Windows.Forms.Padding(0);
            this.NextMoveBox.Name = "NextMoveBox";
            this.NextMoveBox.Size = new System.Drawing.Size(100, 6);
            this.NextMoveBox.TabIndex = 4;
            // 
            // TargetBox
            // 
            this.TargetBox.Image = ((System.Drawing.Image)(resources.GetObject("TargetBox.Image")));
            this.TargetBox.Location = new System.Drawing.Point(124, 0);
            this.TargetBox.Margin = new System.Windows.Forms.Padding(0);
            this.TargetBox.Name = "TargetBox";
            this.TargetBox.Size = new System.Drawing.Size(24, 24);
            this.TargetBox.TabIndex = 2;
            this.TargetBox.TabStop = false;
            // 
            // RobotBox
            // 
            this.RobotBox.Image = global::TrybGraficzny.Properties.Resources.robotics;
            this.RobotBox.Location = new System.Drawing.Point(0, 0);
            this.RobotBox.Margin = new System.Windows.Forms.Padding(0);
            this.RobotBox.Name = "RobotBox";
            this.RobotBox.Size = new System.Drawing.Size(25, 25);
            this.RobotBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RobotBox.TabIndex = 0;
            this.RobotBox.TabStop = false;
            this.RobotBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HideTmpPath_Event);
            // 
            // Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.TargetBox);
            this.Controls.Add(this.NextMoveBox);
            this.Controls.Add(this.RobotBox);
            this.Controls.Add(this.TmpMoveBox);
            this.Name = "Map";
            this.Size = new System.Drawing.Size(734, 609);
            this.Click += new System.EventHandler(this.Map_Click);
            this.MouseLeave += new System.EventHandler(this.HideTmpPath_Event);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Map_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.TargetBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RobotBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox RobotBox;
        private System.Windows.Forms.Panel TmpMoveBox;
        private System.Windows.Forms.PictureBox TargetBox;
        private System.Windows.Forms.Panel NextMoveBox;
    }
}
