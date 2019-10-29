namespace TrybGraficzny
{
    partial class Main
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

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.SidePanel = new System.Windows.Forms.Panel();
            this.ManyStepsBox = new System.Windows.Forms.Label();
            this.TxtManySteps = new System.Windows.Forms.Label();
            this.ButtonDescrptionAside = new System.Windows.Forms.Panel();
            this.ButtonDescription = new System.Windows.Forms.Button();
            this.ButtonResetAside = new System.Windows.Forms.Panel();
            this.ButtonReset = new System.Windows.Forms.Button();
            this.ButtonAIAside = new System.Windows.Forms.Panel();
            this.ButtonAI = new System.Windows.Forms.Button();
            this.ButtonStartAside = new System.Windows.Forms.Panel();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.StepsBox = new System.Windows.Forms.Label();
            this.StepsDirectionArrow = new System.Windows.Forms.PictureBox();
            this.TxtStep = new System.Windows.Forms.Label();
            this.DirectionArrow = new System.Windows.Forms.PictureBox();
            this.TxtDirection = new System.Windows.Forms.Label();
            this.PositionBox = new System.Windows.Forms.Label();
            this.TxtPozition = new System.Windows.Forms.Label();
            this.DistanceBox = new System.Windows.Forms.Label();
            this.EnergyBox = new System.Windows.Forms.Label();
            this.TxtToAim = new System.Windows.Forms.Label();
            this.TxtEnergyCount = new System.Windows.Forms.Label();
            this.TxtSubTitle = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.PanelTop = new System.Windows.Forms.Panel();
            this.ContainerMain = new System.Windows.Forms.Panel();
            this.ContainerRight = new System.Windows.Forms.Panel();
            this.PanelMap = new System.Windows.Forms.Panel();
            this.GameMap = new TrybGraficzny.Map();
            this.PanelTopRight = new System.Windows.Forms.Panel();
            this.TxtName = new System.Windows.Forms.Label();
            this.TxtAuthor = new System.Windows.Forms.Label();
            this.SidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StepsDirectionArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DirectionArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.ContainerMain.SuspendLayout();
            this.ContainerRight.SuspendLayout();
            this.PanelMap.SuspendLayout();
            this.PanelTopRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(171)))));
            this.SidePanel.Controls.Add(this.ManyStepsBox);
            this.SidePanel.Controls.Add(this.TxtManySteps);
            this.SidePanel.Controls.Add(this.ButtonDescrptionAside);
            this.SidePanel.Controls.Add(this.ButtonDescription);
            this.SidePanel.Controls.Add(this.ButtonResetAside);
            this.SidePanel.Controls.Add(this.ButtonReset);
            this.SidePanel.Controls.Add(this.ButtonAIAside);
            this.SidePanel.Controls.Add(this.ButtonAI);
            this.SidePanel.Controls.Add(this.ButtonStartAside);
            this.SidePanel.Controls.Add(this.ButtonStart);
            this.SidePanel.Controls.Add(this.StepsBox);
            this.SidePanel.Controls.Add(this.StepsDirectionArrow);
            this.SidePanel.Controls.Add(this.TxtStep);
            this.SidePanel.Controls.Add(this.DirectionArrow);
            this.SidePanel.Controls.Add(this.TxtDirection);
            this.SidePanel.Controls.Add(this.PositionBox);
            this.SidePanel.Controls.Add(this.TxtPozition);
            this.SidePanel.Controls.Add(this.DistanceBox);
            this.SidePanel.Controls.Add(this.EnergyBox);
            this.SidePanel.Controls.Add(this.TxtToAim);
            this.SidePanel.Controls.Add(this.TxtEnergyCount);
            this.SidePanel.Controls.Add(this.TxtSubTitle);
            this.SidePanel.Controls.Add(this.Logo);
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanel.Location = new System.Drawing.Point(0, 12);
            this.SidePanel.Margin = new System.Windows.Forms.Padding(0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(250, 857);
            this.SidePanel.TabIndex = 2;
            // 
            // ManyStepsBox
            // 
            this.ManyStepsBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ManyStepsBox.ForeColor = System.Drawing.Color.White;
            this.ManyStepsBox.Location = new System.Drawing.Point(166, 455);
            this.ManyStepsBox.Name = "ManyStepsBox";
            this.ManyStepsBox.Size = new System.Drawing.Size(71, 23);
            this.ManyStepsBox.TabIndex = 32;
            this.ManyStepsBox.Text = "----";
            this.ManyStepsBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtManySteps
            // 
            this.TxtManySteps.AutoSize = true;
            this.TxtManySteps.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxtManySteps.ForeColor = System.Drawing.Color.White;
            this.TxtManySteps.Location = new System.Drawing.Point(18, 455);
            this.TxtManySteps.Name = "TxtManySteps";
            this.TxtManySteps.Size = new System.Drawing.Size(126, 23);
            this.TxtManySteps.TabIndex = 31;
            this.TxtManySteps.Text = "Licznik ruchów";
            // 
            // ButtonDescrptionAside
            // 
            this.ButtonDescrptionAside.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.ButtonDescrptionAside.Location = new System.Drawing.Point(0, 768);
            this.ButtonDescrptionAside.Name = "ButtonDescrptionAside";
            this.ButtonDescrptionAside.Size = new System.Drawing.Size(10, 61);
            this.ButtonDescrptionAside.TabIndex = 30;
            // 
            // ButtonDescription
            // 
            this.ButtonDescription.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonDescription.FlatAppearance.BorderSize = 0;
            this.ButtonDescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDescription.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonDescription.ForeColor = System.Drawing.Color.White;
            this.ButtonDescription.Image = global::TrybGraficzny.Properties.Resources.hastag;
            this.ButtonDescription.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonDescription.Location = new System.Drawing.Point(6, 768);
            this.ButtonDescription.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonDescription.Name = "ButtonDescription";
            this.ButtonDescription.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.ButtonDescription.Size = new System.Drawing.Size(241, 61);
            this.ButtonDescription.TabIndex = 29;
            this.ButtonDescription.Text = "     Opis";
            this.ButtonDescription.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonDescription.UseVisualStyleBackColor = false;
            this.ButtonDescription.Click += new System.EventHandler(this.ButtonDescription_Click);
            // 
            // ButtonResetAside
            // 
            this.ButtonResetAside.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.ButtonResetAside.Location = new System.Drawing.Point(0, 683);
            this.ButtonResetAside.Name = "ButtonResetAside";
            this.ButtonResetAside.Size = new System.Drawing.Size(10, 61);
            this.ButtonResetAside.TabIndex = 28;
            // 
            // ButtonReset
            // 
            this.ButtonReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonReset.FlatAppearance.BorderSize = 0;
            this.ButtonReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonReset.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonReset.ForeColor = System.Drawing.Color.White;
            this.ButtonReset.Image = global::TrybGraficzny.Properties.Resources.settings;
            this.ButtonReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonReset.Location = new System.Drawing.Point(9, 683);
            this.ButtonReset.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonReset.Name = "ButtonReset";
            this.ButtonReset.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.ButtonReset.Size = new System.Drawing.Size(241, 61);
            this.ButtonReset.TabIndex = 27;
            this.ButtonReset.Text = "     Reset";
            this.ButtonReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonReset.UseVisualStyleBackColor = false;
            this.ButtonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // ButtonAIAside
            // 
            this.ButtonAIAside.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.ButtonAIAside.Location = new System.Drawing.Point(0, 592);
            this.ButtonAIAside.Name = "ButtonAIAside";
            this.ButtonAIAside.Size = new System.Drawing.Size(10, 61);
            this.ButtonAIAside.TabIndex = 26;
            // 
            // ButtonAI
            // 
            this.ButtonAI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAI.FlatAppearance.BorderSize = 0;
            this.ButtonAI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAI.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonAI.ForeColor = System.Drawing.Color.White;
            this.ButtonAI.Image = global::TrybGraficzny.Properties.Resources.ai;
            this.ButtonAI.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonAI.Location = new System.Drawing.Point(6, 592);
            this.ButtonAI.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonAI.Name = "ButtonAI";
            this.ButtonAI.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.ButtonAI.Size = new System.Drawing.Size(241, 61);
            this.ButtonAI.TabIndex = 25;
            this.ButtonAI.Tag = "";
            this.ButtonAI.Text = "     Pomoc AI";
            this.ButtonAI.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonAI.UseVisualStyleBackColor = false;
            this.ButtonAI.Click += new System.EventHandler(this.AIMove);
            // 
            // ButtonStartAside
            // 
            this.ButtonStartAside.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.ButtonStartAside.Location = new System.Drawing.Point(0, 502);
            this.ButtonStartAside.Name = "ButtonStartAside";
            this.ButtonStartAside.Size = new System.Drawing.Size(10, 61);
            this.ButtonStartAside.TabIndex = 24;
            // 
            // ButtonStart
            // 
            this.ButtonStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonStart.FlatAppearance.BorderSize = 0;
            this.ButtonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonStart.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonStart.ForeColor = System.Drawing.Color.White;
            this.ButtonStart.Image = global::TrybGraficzny.Properties.Resources.cosmos;
            this.ButtonStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonStart.Location = new System.Drawing.Point(9, 502);
            this.ButtonStart.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.ButtonStart.Size = new System.Drawing.Size(241, 61);
            this.ButtonStart.TabIndex = 23;
            this.ButtonStart.Text = "     Start";
            this.ButtonStart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonStart.UseVisualStyleBackColor = false;
            this.ButtonStart.Click += new System.EventHandler(this.NextStep);
            // 
            // StepsBox
            // 
            this.StepsBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StepsBox.ForeColor = System.Drawing.Color.White;
            this.StepsBox.Location = new System.Drawing.Point(96, 401);
            this.StepsBox.Name = "StepsBox";
            this.StepsBox.Size = new System.Drawing.Size(82, 23);
            this.StepsBox.TabIndex = 22;
            this.StepsBox.Text = "---";
            this.StepsBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StepsDirectionArrow
            // 
            this.StepsDirectionArrow.Image = global::TrybGraficzny.Properties.Resources.navigation;
            this.StepsDirectionArrow.Location = new System.Drawing.Point(188, 402);
            this.StepsDirectionArrow.Name = "StepsDirectionArrow";
            this.StepsDirectionArrow.Size = new System.Drawing.Size(24, 24);
            this.StepsDirectionArrow.TabIndex = 21;
            this.StepsDirectionArrow.TabStop = false;
            // 
            // TxtStep
            // 
            this.TxtStep.AutoSize = true;
            this.TxtStep.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxtStep.ForeColor = System.Drawing.Color.White;
            this.TxtStep.Location = new System.Drawing.Point(21, 400);
            this.TxtStep.Name = "TxtStep";
            this.TxtStep.Size = new System.Drawing.Size(46, 23);
            this.TxtStep.TabIndex = 20;
            this.TxtStep.Text = "Krok";
            // 
            // DirectionArrow
            // 
            this.DirectionArrow.Image = global::TrybGraficzny.Properties.Resources.navigation;
            this.DirectionArrow.Location = new System.Drawing.Point(188, 235);
            this.DirectionArrow.Name = "DirectionArrow";
            this.DirectionArrow.Size = new System.Drawing.Size(24, 24);
            this.DirectionArrow.TabIndex = 19;
            this.DirectionArrow.TabStop = false;
            // 
            // TxtDirection
            // 
            this.TxtDirection.AutoSize = true;
            this.TxtDirection.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxtDirection.ForeColor = System.Drawing.Color.White;
            this.TxtDirection.Location = new System.Drawing.Point(21, 235);
            this.TxtDirection.Name = "TxtDirection";
            this.TxtDirection.Size = new System.Drawing.Size(81, 23);
            this.TxtDirection.TabIndex = 18;
            this.TxtDirection.Text = "Kierunek";
            // 
            // PositionBox
            // 
            this.PositionBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PositionBox.ForeColor = System.Drawing.Color.White;
            this.PositionBox.Location = new System.Drawing.Point(153, 268);
            this.PositionBox.Name = "PositionBox";
            this.PositionBox.Size = new System.Drawing.Size(94, 23);
            this.PositionBox.TabIndex = 17;
            this.PositionBox.Text = "(----, ----)";
            this.PositionBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtPozition
            // 
            this.TxtPozition.AutoSize = true;
            this.TxtPozition.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxtPozition.ForeColor = System.Drawing.Color.White;
            this.TxtPozition.Location = new System.Drawing.Point(21, 268);
            this.TxtPozition.Name = "TxtPozition";
            this.TxtPozition.Size = new System.Drawing.Size(69, 23);
            this.TxtPozition.TabIndex = 16;
            this.TxtPozition.Text = "Pozycja";
            // 
            // DistanceBox
            // 
            this.DistanceBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DistanceBox.ForeColor = System.Drawing.Color.White;
            this.DistanceBox.Location = new System.Drawing.Point(157, 301);
            this.DistanceBox.Name = "DistanceBox";
            this.DistanceBox.Size = new System.Drawing.Size(90, 23);
            this.DistanceBox.TabIndex = 13;
            this.DistanceBox.Text = "----";
            this.DistanceBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EnergyBox
            // 
            this.EnergyBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EnergyBox.ForeColor = System.Drawing.Color.White;
            this.EnergyBox.Location = new System.Drawing.Point(157, 349);
            this.EnergyBox.Name = "EnergyBox";
            this.EnergyBox.Size = new System.Drawing.Size(90, 23);
            this.EnergyBox.TabIndex = 12;
            this.EnergyBox.Text = "------";
            this.EnergyBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtToAim
            // 
            this.TxtToAim.AutoSize = true;
            this.TxtToAim.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxtToAim.ForeColor = System.Drawing.Color.White;
            this.TxtToAim.Location = new System.Drawing.Point(21, 301);
            this.TxtToAim.Name = "TxtToAim";
            this.TxtToAim.Size = new System.Drawing.Size(69, 23);
            this.TxtToAim.TabIndex = 11;
            this.TxtToAim.Text = "Do celu";
            // 
            // TxtEnergyCount
            // 
            this.TxtEnergyCount.AutoSize = true;
            this.TxtEnergyCount.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxtEnergyCount.ForeColor = System.Drawing.Color.White;
            this.TxtEnergyCount.Location = new System.Drawing.Point(21, 349);
            this.TxtEnergyCount.Name = "TxtEnergyCount";
            this.TxtEnergyCount.Size = new System.Drawing.Size(105, 23);
            this.TxtEnergyCount.TabIndex = 10;
            this.TxtEnergyCount.Text = "Ilość Energii";
            // 
            // TxtSubTitle
            // 
            this.TxtSubTitle.AutoSize = true;
            this.TxtSubTitle.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxtSubTitle.ForeColor = System.Drawing.Color.White;
            this.TxtSubTitle.Location = new System.Drawing.Point(17, 180);
            this.TxtSubTitle.Name = "TxtSubTitle";
            this.TxtSubTitle.Size = new System.Drawing.Size(220, 29);
            this.TxtSubTitle.TabIndex = 1;
            this.TxtSubTitle.Text = "Centrum Sterowania";
            // 
            // Logo
            // 
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Logo.ErrorImage = global::TrybGraficzny.Properties.Resources.chip;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(52, 11);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(150, 150);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // PanelTop
            // 
            this.PanelTop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Margin = new System.Windows.Forms.Padding(0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(1008, 12);
            this.PanelTop.TabIndex = 0;
            // 
            // ContainerMain
            // 
            this.ContainerMain.Controls.Add(this.ContainerRight);
            this.ContainerMain.Controls.Add(this.SidePanel);
            this.ContainerMain.Controls.Add(this.PanelTop);
            this.ContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContainerMain.Location = new System.Drawing.Point(0, 0);
            this.ContainerMain.Name = "ContainerMain";
            this.ContainerMain.Size = new System.Drawing.Size(1008, 869);
            this.ContainerMain.TabIndex = 9;
            // 
            // ContainerRight
            // 
            this.ContainerRight.Controls.Add(this.PanelMap);
            this.ContainerRight.Controls.Add(this.PanelTopRight);
            this.ContainerRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContainerRight.Location = new System.Drawing.Point(250, 12);
            this.ContainerRight.Name = "ContainerRight";
            this.ContainerRight.Size = new System.Drawing.Size(758, 857);
            this.ContainerRight.TabIndex = 6;
            // 
            // PanelMap
            // 
            this.PanelMap.Controls.Add(this.GameMap);
            this.PanelMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMap.Location = new System.Drawing.Point(0, 48);
            this.PanelMap.Margin = new System.Windows.Forms.Padding(0, 12, 12, 12);
            this.PanelMap.Name = "PanelMap";
            this.PanelMap.Padding = new System.Windows.Forms.Padding(12, 0, 12, 12);
            this.PanelMap.Size = new System.Drawing.Size(758, 809);
            this.PanelMap.TabIndex = 10;
            // 
            // GameMap
            // 
            this.GameMap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GameMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GameMap.Location = new System.Drawing.Point(12, 0);
            this.GameMap.Name = "GameMap";
            this.GameMap.Size = new System.Drawing.Size(734, 797);
            this.GameMap.TabIndex = 0;
            // 
            // PanelTopRight
            // 
            this.PanelTopRight.Controls.Add(this.TxtName);
            this.PanelTopRight.Controls.Add(this.TxtAuthor);
            this.PanelTopRight.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTopRight.Location = new System.Drawing.Point(0, 0);
            this.PanelTopRight.Name = "PanelTopRight";
            this.PanelTopRight.Size = new System.Drawing.Size(758, 48);
            this.PanelTopRight.TabIndex = 9;
            // 
            // TxtName
            // 
            this.TxtName.AutoSize = true;
            this.TxtName.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxtName.Location = new System.Drawing.Point(3, 8);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(190, 29);
            this.TxtName.TabIndex = 4;
            this.TxtName.Text = "Robot Marsjański";
            // 
            // TxtAuthor
            // 
            this.TxtAuthor.AutoSize = true;
            this.TxtAuthor.Font = new System.Drawing.Font("Lato Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxtAuthor.Location = new System.Drawing.Point(199, 18);
            this.TxtAuthor.Name = "TxtAuthor";
            this.TxtAuthor.Size = new System.Drawing.Size(116, 17);
            this.TxtAuthor.TabIndex = 5;
            this.TxtAuthor.Text = "Kamil Mikołajczuk";
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1008, 869);
            this.Controls.Add(this.ContainerMain);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Robot Marsjański";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.SidePanel.ResumeLayout(false);
            this.SidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StepsDirectionArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DirectionArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ContainerMain.ResumeLayout(false);
            this.ContainerRight.ResumeLayout(false);
            this.PanelMap.ResumeLayout(false);
            this.PanelTopRight.ResumeLayout(false);
            this.PanelTopRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label TxtSubTitle;
        private System.Windows.Forms.PictureBox DirectionArrow;
        private System.Windows.Forms.Label TxtDirection;
        private System.Windows.Forms.Label PositionBox;
        private System.Windows.Forms.Label TxtPozition;
        private System.Windows.Forms.Label DistanceBox;
        private System.Windows.Forms.Label EnergyBox;
        private System.Windows.Forms.Label TxtToAim;
        private System.Windows.Forms.Label TxtEnergyCount;
        private System.Windows.Forms.Panel ButtonStartAside;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Label StepsBox;
        private System.Windows.Forms.PictureBox StepsDirectionArrow;
        private System.Windows.Forms.Label TxtStep;
        private System.Windows.Forms.Panel ButtonAIAside;
        private System.Windows.Forms.Button ButtonAI;
        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.Panel ContainerMain;
        private System.Windows.Forms.Panel ContainerRight;
        private System.Windows.Forms.Panel PanelTopRight;
        private System.Windows.Forms.Label TxtName;
        private System.Windows.Forms.Label TxtAuthor;
        private System.Windows.Forms.Panel PanelMap;
        private Map GameMap;
        private System.Windows.Forms.Panel ButtonResetAside;
        private System.Windows.Forms.Button ButtonReset;
        private System.Windows.Forms.Panel ButtonDescrptionAside;
        private System.Windows.Forms.Button ButtonDescription;
        private System.Windows.Forms.Label ManyStepsBox;
        private System.Windows.Forms.Label TxtManySteps;
    }
}

