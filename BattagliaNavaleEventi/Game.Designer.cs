namespace BattagliaNavaleEventi
{
    partial class Game
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
            lbl_bestAttemps = new Label();
            lbl_numAttemps = new Label();
            lbl_shipsSunk = new Label();
            tbl_grid = new TableLayoutPanel();
            SuspendLayout();
            // 
            // lbl_bestAttemps
            // 
            lbl_bestAttemps.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_bestAttemps.Location = new Point(538, 137);
            lbl_bestAttemps.Name = "lbl_bestAttemps";
            lbl_bestAttemps.Size = new Size(324, 63);
            lbl_bestAttemps.TabIndex = 7;
            lbl_bestAttemps.Text = "Tentativi min salvati: 0";
            lbl_bestAttemps.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_numAttemps
            // 
            lbl_numAttemps.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_numAttemps.Location = new Point(538, 74);
            lbl_numAttemps.Name = "lbl_numAttemps";
            lbl_numAttemps.Size = new Size(324, 63);
            lbl_numAttemps.TabIndex = 6;
            lbl_numAttemps.Text = "Numero tentativi: 0";
            lbl_numAttemps.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_shipsSunk
            // 
            lbl_shipsSunk.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_shipsSunk.Location = new Point(538, 11);
            lbl_shipsSunk.Name = "lbl_shipsSunk";
            lbl_shipsSunk.Size = new Size(324, 63);
            lbl_shipsSunk.TabIndex = 5;
            lbl_shipsSunk.Text = "Navi affondate: 0";
            lbl_shipsSunk.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbl_grid
            // 
            tbl_grid.ColumnCount = 10;
            tbl_grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tbl_grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tbl_grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tbl_grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tbl_grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tbl_grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tbl_grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tbl_grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tbl_grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tbl_grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tbl_grid.Location = new Point(14, 11);
            tbl_grid.Name = "tbl_grid";
            tbl_grid.RowCount = 10;
            tbl_grid.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tbl_grid.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tbl_grid.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tbl_grid.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tbl_grid.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tbl_grid.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tbl_grid.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tbl_grid.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tbl_grid.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tbl_grid.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tbl_grid.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tbl_grid.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tbl_grid.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tbl_grid.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tbl_grid.Size = new Size(490, 490);
            tbl_grid.TabIndex = 4;
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 525);
            Controls.Add(lbl_bestAttemps);
            Controls.Add(lbl_numAttemps);
            Controls.Add(lbl_shipsSunk);
            Controls.Add(tbl_grid);
            Name = "Game";
            Text = "Game";
            ResumeLayout(false);
        }

        #endregion

        private Label lbl_bestAttemps;
        private Label lbl_numAttemps;
        private Label lbl_shipsSunk;
        private TableLayoutPanel tbl_grid;
    }
}