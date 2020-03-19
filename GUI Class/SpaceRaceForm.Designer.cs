namespace GUI_Class
{
    partial class SpaceRaceForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tlpBoard = new System.Windows.Forms.TableLayoutPanel();
            this.gbSingleStep = new System.Windows.Forms.GroupBox();
            this.rbtStepNo = new System.Windows.Forms.RadioButton();
            this.rbtStepYes = new System.Windows.Forms.RadioButton();
            this.btGameReset = new System.Windows.Forms.Button();
            this.btGameRoll = new System.Windows.Forms.Button();
            this.cbNumberOfPlayers = new System.Windows.Forms.ComboBox();
            this.lbNumberOfPlayers = new System.Windows.Forms.Label();
            this.lbGamePlayers = new System.Windows.Forms.Label();
            this.lbGameName = new System.Windows.Forms.Label();
            this.dgvPlayers = new System.Windows.Forms.DataGridView();
            this.playerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btExit = new System.Windows.Forms.Button();
            this.PlayerTokenImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rocketFuelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbSingleStep.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tlpBoard);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gbSingleStep);
            this.splitContainer1.Panel2.Controls.Add(this.btGameReset);
            this.splitContainer1.Panel2.Controls.Add(this.btGameRoll);
            this.splitContainer1.Panel2.Controls.Add(this.cbNumberOfPlayers);
            this.splitContainer1.Panel2.Controls.Add(this.lbNumberOfPlayers);
            this.splitContainer1.Panel2.Controls.Add(this.lbGamePlayers);
            this.splitContainer1.Panel2.Controls.Add(this.lbGameName);
            this.splitContainer1.Panel2.Controls.Add(this.dgvPlayers);
            this.splitContainer1.Panel2.Controls.Add(this.btExit);
            this.splitContainer1.Size = new System.Drawing.Size(882, 653);
            this.splitContainer1.SplitterDistance = 633;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // tlpBoard
            // 
            this.tlpBoard.AutoSize = true;
            this.tlpBoard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpBoard.ColumnCount = 8;
            this.tlpBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBoard.Location = new System.Drawing.Point(0, 0);
            this.tlpBoard.Name = "tlpBoard";
            this.tlpBoard.RowCount = 7;
            this.tlpBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpBoard.Size = new System.Drawing.Size(633, 653);
            this.tlpBoard.TabIndex = 0;
            // 
            // gbSingleStep
            // 
            this.gbSingleStep.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gbSingleStep.Controls.Add(this.rbtStepNo);
            this.gbSingleStep.Controls.Add(this.rbtStepYes);
            this.gbSingleStep.Location = new System.Drawing.Point(53, 303);
            this.gbSingleStep.Name = "gbSingleStep";
            this.gbSingleStep.Size = new System.Drawing.Size(140, 55);
            this.gbSingleStep.TabIndex = 8;
            this.gbSingleStep.TabStop = false;
            this.gbSingleStep.Text = "Single Step?";
            // 
            // rbtStepNo
            // 
            this.rbtStepNo.AutoSize = true;
            this.rbtStepNo.Location = new System.Drawing.Point(88, 24);
            this.rbtStepNo.Name = "rbtStepNo";
            this.rbtStepNo.Size = new System.Drawing.Size(47, 21);
            this.rbtStepNo.TabIndex = 8;
            this.rbtStepNo.Text = "No";
            this.rbtStepNo.UseVisualStyleBackColor = true;
            this.rbtStepNo.Click += new System.EventHandler(this.rbtStepNo_Click);
            // 
            // rbtStepYes
            // 
            this.rbtStepYes.AutoSize = true;
            this.rbtStepYes.Location = new System.Drawing.Point(12, 24);
            this.rbtStepYes.Name = "rbtStepYes";
            this.rbtStepYes.Size = new System.Drawing.Size(53, 21);
            this.rbtStepYes.TabIndex = 7;
            this.rbtStepYes.Text = "Yes";
            this.rbtStepYes.UseVisualStyleBackColor = true;
            this.rbtStepYes.Click += new System.EventHandler(this.rbtStepYes_Click);
            // 
            // btGameReset
            // 
            this.btGameReset.AutoSize = true;
            this.btGameReset.Enabled = false;
            this.btGameReset.Location = new System.Drawing.Point(17, 616);
            this.btGameReset.Name = "btGameReset";
            this.btGameReset.Size = new System.Drawing.Size(97, 27);
            this.btGameReset.TabIndex = 7;
            this.btGameReset.Text = "Game Reset";
            this.btGameReset.UseVisualStyleBackColor = true;
            this.btGameReset.Click += new System.EventHandler(this.btGameReset_Click);
            // 
            // btGameRoll
            // 
            this.btGameRoll.Enabled = false;
            this.btGameRoll.Location = new System.Drawing.Point(73, 562);
            this.btGameRoll.Name = "btGameRoll";
            this.btGameRoll.Size = new System.Drawing.Size(97, 27);
            this.btGameRoll.TabIndex = 6;
            this.btGameRoll.Text = "Roll dice";
            this.btGameRoll.UseVisualStyleBackColor = true;
            this.btGameRoll.Click += new System.EventHandler(this.btGameRoll_Click);
            // 
            // cbNumberOfPlayers
            // 
            this.cbNumberOfPlayers.FormattingEnabled = true;
            this.cbNumberOfPlayers.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cbNumberOfPlayers.Location = new System.Drawing.Point(176, 59);
            this.cbNumberOfPlayers.Name = "cbNumberOfPlayers";
            this.cbNumberOfPlayers.Size = new System.Drawing.Size(42, 24);
            this.cbNumberOfPlayers.TabIndex = 5;
            this.cbNumberOfPlayers.Text = "6";
            this.cbNumberOfPlayers.SelectedIndexChanged += new System.EventHandler(this.cbNumberOfPlayers_SelectedIndexChanged);
            // 
            // lbNumberOfPlayers
            // 
            this.lbNumberOfPlayers.AutoSize = true;
            this.lbNumberOfPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbNumberOfPlayers.Location = new System.Drawing.Point(27, 62);
            this.lbNumberOfPlayers.Name = "lbNumberOfPlayers";
            this.lbNumberOfPlayers.Size = new System.Drawing.Size(142, 17);
            this.lbNumberOfPlayers.TabIndex = 4;
            this.lbNumberOfPlayers.Text = "Number of Players";
            // 
            // lbGamePlayers
            // 
            this.lbGamePlayers.AutoSize = true;
            this.lbGamePlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbGamePlayers.Location = new System.Drawing.Point(53, 98);
            this.lbGamePlayers.Name = "lbGamePlayers";
            this.lbGamePlayers.Size = new System.Drawing.Size(117, 32);
            this.lbGamePlayers.TabIndex = 3;
            this.lbGamePlayers.Text = "Players";
            // 
            // lbGameName
            // 
            this.lbGameName.AutoSize = true;
            this.lbGameName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbGameName.Location = new System.Drawing.Point(24, 9);
            this.lbGameName.Name = "lbGameName";
            this.lbGameName.Size = new System.Drawing.Size(179, 32);
            this.lbGameName.TabIndex = 2;
            this.lbGameName.Text = "Space Race";
            // 
            // dgvPlayers
            // 
            this.dgvPlayers.AllowUserToAddRows = false;
            this.dgvPlayers.AllowUserToDeleteRows = false;
            this.dgvPlayers.AutoGenerateColumns = false;
            this.dgvPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PlayerTokenImage,
            this.nameDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn,
            this.rocketFuelDataGridViewTextBoxColumn});
            this.dgvPlayers.DataSource = this.playerBindingSource;
            this.dgvPlayers.Location = new System.Drawing.Point(6, 133);
            this.dgvPlayers.Name = "dgvPlayers";
            this.dgvPlayers.RowHeadersVisible = false;
            this.dgvPlayers.RowTemplate.Height = 24;
            this.dgvPlayers.Size = new System.Drawing.Size(235, 150);
            this.dgvPlayers.TabIndex = 1;
            // 
            // playerBindingSource
            // 
            this.playerBindingSource.DataSource = typeof(Object_Classes.Player);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(135, 616);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(97, 27);
            this.btExit.TabIndex = 0;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // PlayerTokenImage
            // 
            this.PlayerTokenImage.DataPropertyName = "PlayerTokenImage";
            this.PlayerTokenImage.HeaderText = "";
            this.PlayerTokenImage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.PlayerTokenImage.Name = "PlayerTokenImage";
            this.PlayerTokenImage.ReadOnly = true;
            this.PlayerTokenImage.Width = 20;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 40;
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "Square";
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            this.positionDataGridViewTextBoxColumn.ReadOnly = true;
            this.positionDataGridViewTextBoxColumn.Width = 50;
            // 
            // rocketFuelDataGridViewTextBoxColumn
            // 
            this.rocketFuelDataGridViewTextBoxColumn.DataPropertyName = "RocketFuel";
            this.rocketFuelDataGridViewTextBoxColumn.HeaderText = "Fuel";
            this.rocketFuelDataGridViewTextBoxColumn.Name = "rocketFuelDataGridViewTextBoxColumn";
            this.rocketFuelDataGridViewTextBoxColumn.ReadOnly = true;
            this.rocketFuelDataGridViewTextBoxColumn.Width = 50;
            // 
            // SpaceRaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 653);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SpaceRaceForm";
            this.Text = "Space Race";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gbSingleStep.ResumeLayout(false);
            this.gbSingleStep.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tlpBoard;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.DataGridView dgvPlayers;
        private System.Windows.Forms.BindingSource playerBindingSource;
        private System.Windows.Forms.Label lbGamePlayers;
        private System.Windows.Forms.Label lbGameName;
        private System.Windows.Forms.ComboBox cbNumberOfPlayers;
        private System.Windows.Forms.Label lbNumberOfPlayers;
        private System.Windows.Forms.GroupBox gbSingleStep;
        private System.Windows.Forms.RadioButton rbtStepNo;
        private System.Windows.Forms.RadioButton rbtStepYes;
        private System.Windows.Forms.Button btGameReset;
        private System.Windows.Forms.Button btGameRoll;
        private System.Windows.Forms.DataGridViewImageColumn PlayerTokenImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rocketFuelDataGridViewTextBoxColumn;
    }
}

