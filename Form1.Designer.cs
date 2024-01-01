namespace Analizador
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            CompilarJPG = new PictureBox();
            CompilarLbl = new Label();
            CompilarBtn = new Panel();
            ArchivoBtn = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            Analizadortxb = new TextBox();
            label5 = new Label();
            panel1 = new Panel();
            Salirbtn = new Button();
            Limpiarbtn = new Button();
            Guardarbtn = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            Token = new DataGridViewTextBoxColumn();
            Lexema = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            Lexemas = new DataGridViewTextBoxColumn();
            Analizadordgv = new DataGridView();
            a = new DataGridViewTextBoxColumn();
            b = new DataGridViewTextBoxColumn();
            c = new DataGridViewTextBoxColumn();
            sintacticodgv = new DataGridView();
            Estructura = new DataGridViewTextBoxColumn();
            Detalle = new DataGridViewTextBoxColumn();
            Fila = new DataGridViewTextBoxColumn();
            Columna = new DataGridViewTextBoxColumn();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)CompilarJPG).BeginInit();
            CompilarBtn.SuspendLayout();
            ArchivoBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Analizadordgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sintacticodgv).BeginInit();
            SuspendLayout();
            // 
            // CompilarJPG
            // 
            CompilarJPG.Location = new Point(0, 0);
            CompilarJPG.Name = "CompilarJPG";
            CompilarJPG.Size = new Size(91, 83);
            CompilarJPG.SizeMode = PictureBoxSizeMode.Zoom;
            CompilarJPG.TabIndex = 0;
            CompilarJPG.TabStop = false;
            // 
            // CompilarLbl
            // 
            CompilarLbl.AutoSize = true;
            CompilarLbl.Location = new Point(3, 86);
            CompilarLbl.Name = "CompilarLbl";
            CompilarLbl.Size = new Size(70, 20);
            CompilarLbl.TabIndex = 1;
            CompilarLbl.Text = "Compilar";
            // 
            // CompilarBtn
            // 
            CompilarBtn.Controls.Add(CompilarJPG);
            CompilarBtn.Controls.Add(CompilarLbl);
            CompilarBtn.Location = new Point(30, 12);
            CompilarBtn.Name = "CompilarBtn";
            CompilarBtn.Size = new Size(94, 108);
            CompilarBtn.TabIndex = 2;
            // 
            // ArchivoBtn
            // 
            ArchivoBtn.Controls.Add(pictureBox1);
            ArchivoBtn.Controls.Add(label1);
            ArchivoBtn.Location = new Point(143, 12);
            ArchivoBtn.Name = "ArchivoBtn";
            ArchivoBtn.Size = new Size(106, 108);
            ArchivoBtn.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(3, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(107, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 86);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 1;
            label1.Text = "Cargar Archivo";
            // 
            // Analizadortxb
            // 
            Analizadortxb.BackColor = Color.White;
            Analizadortxb.Cursor = Cursors.IBeam;
            Analizadortxb.Font = new Font("Arial Narrow", 12F, FontStyle.Italic, GraphicsUnit.Point);
            Analizadortxb.Location = new Point(27, 145);
            Analizadortxb.Multiline = true;
            Analizadortxb.Name = "Analizadortxb";
            Analizadortxb.Size = new Size(424, 745);
            Analizadortxb.TabIndex = 3;
            Analizadortxb.TextChanged += Analizadortxb_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(27, 118);
            label5.Name = "label5";
            label5.Size = new Size(67, 24);
            label5.TabIndex = 4;
            label5.Text = "Entrada";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(Salirbtn);
            panel1.Controls.Add(Limpiarbtn);
            panel1.Controls.Add(Guardarbtn);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(484, 145);
            panel1.Name = "panel1";
            panel1.Size = new Size(606, 61);
            panel1.TabIndex = 8;
            // 
            // Salirbtn
            // 
            Salirbtn.BackColor = Color.White;
            Salirbtn.FlatAppearance.CheckedBackColor = Color.White;
            Salirbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 192);
            Salirbtn.FlatStyle = FlatStyle.Popup;
            Salirbtn.Location = new Point(449, 12);
            Salirbtn.Name = "Salirbtn";
            Salirbtn.Size = new Size(126, 35);
            Salirbtn.TabIndex = 2;
            Salirbtn.Text = "Salir";
            Salirbtn.UseVisualStyleBackColor = false;
            Salirbtn.Click += Salirbtn_Click;
            // 
            // Limpiarbtn
            // 
            Limpiarbtn.BackColor = Color.White;
            Limpiarbtn.FlatAppearance.CheckedBackColor = Color.White;
            Limpiarbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 192);
            Limpiarbtn.FlatStyle = FlatStyle.Popup;
            Limpiarbtn.Location = new Point(235, 12);
            Limpiarbtn.Name = "Limpiarbtn";
            Limpiarbtn.Size = new Size(126, 35);
            Limpiarbtn.TabIndex = 1;
            Limpiarbtn.Text = "Limpiar";
            Limpiarbtn.UseVisualStyleBackColor = false;
            Limpiarbtn.Click += Limpiarbtn_Click;
            // 
            // Guardarbtn
            // 
            Guardarbtn.BackColor = Color.White;
            Guardarbtn.FlatAppearance.CheckedBackColor = Color.White;
            Guardarbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 192);
            Guardarbtn.FlatStyle = FlatStyle.Popup;
            Guardarbtn.Location = new Point(24, 10);
            Guardarbtn.Name = "Guardarbtn";
            Guardarbtn.Size = new Size(126, 35);
            Guardarbtn.TabIndex = 0;
            Guardarbtn.Text = "Guardar";
            Guardarbtn.UseVisualStyleBackColor = false;
            Guardarbtn.Click += Guardarbtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(484, 118);
            label2.Name = "label2";
            label2.Size = new Size(78, 24);
            label2.TabIndex = 9;
            label2.Text = "Opciones";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(478, 216);
            label3.Name = "label3";
            label3.Size = new Size(108, 24);
            label3.TabIndex = 10;
            label3.Text = "Salida Léxica";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Cookies and Cheese", 35F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(514, -1);
            label4.Name = "label4";
            label4.Size = new Size(245, 93);
            label4.TabIndex = 3;
            label4.Text = "Analizador";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Cookies and Cheese", 35F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(0, 192, 192);
            label7.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label7.Location = new Point(749, -5);
            label7.Name = "label7";
            label7.Size = new Size(422, 93);
            label7.TabIndex = 11;
            label7.Text = "Lexico y Sintactico";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Cookies and Cheese", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(514, 79);
            label8.Name = "label8";
            label8.Size = new Size(657, 44);
            label8.TabIndex = 12;
            label8.Text = "----------------------------------------------------------";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Arial Narrow", 10F, FontStyle.Italic, GraphicsUnit.Point);
            label9.Location = new Point(809, 66);
            label9.Name = "label9";
            label9.Size = new Size(66, 22);
            label9.TabIndex = 13;
            label9.Text = "Equipo 4";
            // 
            // Token
            // 
            Token.HeaderText = "Token";
            Token.MinimumWidth = 6;
            Token.Name = "Token";
            Token.Width = 90;
            // 
            // Lexema
            // 
            Lexema.HeaderText = "Lexema";
            Lexema.MinimumWidth = 6;
            Lexema.Name = "Lexema";
            Lexema.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Token";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // Lexemas
            // 
            Lexemas.HeaderText = "Lexemas";
            Lexemas.MinimumWidth = 6;
            Lexemas.Name = "Lexemas";
            Lexemas.Width = 125;
            // 
            // Analizadordgv
            // 
            Analizadordgv.AllowUserToDeleteRows = false;
            Analizadordgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Analizadordgv.BackgroundColor = Color.White;
            Analizadordgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Analizadordgv.Columns.AddRange(new DataGridViewColumn[] { a, b, c });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Arial Narrow", 12F, FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            Analizadordgv.DefaultCellStyle = dataGridViewCellStyle1;
            Analizadordgv.Location = new Point(469, 243);
            Analizadordgv.Name = "Analizadordgv";
            Analizadordgv.ReadOnly = true;
            Analizadordgv.RowHeadersWidth = 51;
            Analizadordgv.RowTemplate.Height = 29;
            Analizadordgv.Size = new Size(606, 647);
            Analizadordgv.TabIndex = 15;
            // 
            // a
            // 
            a.HeaderText = "Token";
            a.MinimumWidth = 6;
            a.Name = "a";
            a.ReadOnly = true;
            a.Width = 90;
            // 
            // b
            // 
            b.HeaderText = "Lexema";
            b.MinimumWidth = 6;
            b.Name = "b";
            b.ReadOnly = true;
            b.Width = 125;
            // 
            // c
            // 
            c.HeaderText = "Patron";
            c.MinimumWidth = 6;
            c.Name = "c";
            c.ReadOnly = true;
            c.Width = 325;
            // 
            // sintacticodgv
            // 
            sintacticodgv.AllowUserToDeleteRows = false;
            sintacticodgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            sintacticodgv.BackgroundColor = Color.White;
            sintacticodgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            sintacticodgv.Columns.AddRange(new DataGridViewColumn[] { Estructura, Detalle, Fila, Columna });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Arial Narrow", 12F, FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            sintacticodgv.DefaultCellStyle = dataGridViewCellStyle2;
            sintacticodgv.Location = new Point(1094, 243);
            sintacticodgv.Name = "sintacticodgv";
            sintacticodgv.ReadOnly = true;
            sintacticodgv.RowHeadersWidth = 51;
            sintacticodgv.RowTemplate.Height = 29;
            sintacticodgv.Size = new Size(631, 647);
            sintacticodgv.TabIndex = 17;
            // 
            // Estructura
            // 
            Estructura.HeaderText = "Estructura";
            Estructura.MinimumWidth = 6;
            Estructura.Name = "Estructura";
            Estructura.ReadOnly = true;
            Estructura.Width = 125;
            // 
            // Detalle
            // 
            Detalle.HeaderText = "Detalle";
            Detalle.MinimumWidth = 6;
            Detalle.Name = "Detalle";
            Detalle.ReadOnly = true;
            Detalle.Width = 300;
            // 
            // Fila
            // 
            Fila.HeaderText = "Fila";
            Fila.MinimumWidth = 6;
            Fila.Name = "Fila";
            Fila.ReadOnly = true;
            Fila.Width = 70;
            // 
            // Columna
            // 
            Columna.HeaderText = "Columna";
            Columna.MinimumWidth = 6;
            Columna.Name = "Columna";
            Columna.ReadOnly = true;
            Columna.Width = 80;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Narrow", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label10.Location = new Point(1103, 216);
            label10.Name = "label10";
            label10.Size = new Size(133, 24);
            label10.TabIndex = 16;
            label10.Text = "Salida Sintáctica";
            // 
            // Form1
            // 
            BackColor = Color.White;
            ClientSize = new Size(1736, 902);
            Controls.Add(sintacticodgv);
            Controls.Add(label10);
            Controls.Add(Analizadordgv);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(Analizadortxb);
            Font = new Font("Arial Narrow", 12F, FontStyle.Italic, GraphicsUnit.Point);
            Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)CompilarJPG).EndInit();
            CompilarBtn.ResumeLayout(false);
            CompilarBtn.PerformLayout();
            ArchivoBtn.ResumeLayout(false);
            ArchivoBtn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Analizadordgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)sintacticodgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox CompilarJPG;
        private Label CompilarLbl;
        private Panel CompilarBtn;
        private Panel ArchivoBtn;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox Analizadortxb;
        private Label label5;
        private Panel panel1;
        private Button Guardarbtn;
        private Label label2;
        private Button Salirbtn;
        private Button Limpiarbtn;
        private Label label3;
        private Label label4;
        private Label label7;
        private Label label8;
        private Label label9;
        private DataGridViewTextBoxColumn Token;
        private DataGridViewTextBoxColumn Lexema;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Lexemas;
        private DataGridView Analizadordgv;
        private DataGridViewTextBoxColumn a;
        private DataGridViewTextBoxColumn b;
        private DataGridViewTextBoxColumn c;
        private DataGridView sintacticodgv;
        private DataGridViewTextBoxColumn Estructura;
        private DataGridViewTextBoxColumn Detalle;
        private DataGridViewTextBoxColumn Fila;
        private DataGridViewTextBoxColumn Columna;
        private Label label10;
    }
}