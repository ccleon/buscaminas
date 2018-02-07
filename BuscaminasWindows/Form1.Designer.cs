namespace BuscaminasWindows
{
    partial class ventana_JuegoBuscaminas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_nivel = new System.Windows.Forms.Label();
            this.cbox_nivel = new System.Windows.Forms.ComboBox();
            this.btn_comenzar = new System.Windows.Forms.Button();
            this.btn_restart = new System.Windows.Forms.Button();
            this.lyt_tablero = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_levantadas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_nivel
            // 
            this.lbl_nivel.AutoSize = true;
            this.lbl_nivel.Location = new System.Drawing.Point(26, 22);
            this.lbl_nivel.Name = "lbl_nivel";
            this.lbl_nivel.Size = new System.Drawing.Size(71, 13);
            this.lbl_nivel.TabIndex = 0;
            this.lbl_nivel.Text = "Escoge nivel:";
            // 
            // cbox_nivel
            // 
            this.cbox_nivel.FormattingEnabled = true;
            this.cbox_nivel.Items.AddRange(new object[] {
            "Facil",
            "Medio",
            "Dificil"});
            this.cbox_nivel.Location = new System.Drawing.Point(109, 19);
            this.cbox_nivel.Name = "cbox_nivel";
            this.cbox_nivel.Size = new System.Drawing.Size(71, 21);
            this.cbox_nivel.TabIndex = 1;
            // 
            // btn_comenzar
            // 
            this.btn_comenzar.Location = new System.Drawing.Point(202, 17);
            this.btn_comenzar.Name = "btn_comenzar";
            this.btn_comenzar.Size = new System.Drawing.Size(75, 23);
            this.btn_comenzar.TabIndex = 2;
            this.btn_comenzar.Text = "Comenzar";
            this.btn_comenzar.UseVisualStyleBackColor = true;
            this.btn_comenzar.Click += new System.EventHandler(this.btn_comenzar_Click);
            // 
            // btn_restart
            // 
            this.btn_restart.Location = new System.Drawing.Point(361, 17);
            this.btn_restart.Name = "btn_restart";
            this.btn_restart.Size = new System.Drawing.Size(75, 23);
            this.btn_restart.TabIndex = 4;
            this.btn_restart.Text = "Restart";
            this.btn_restart.UseVisualStyleBackColor = true;
            this.btn_restart.Visible = false;
            this.btn_restart.Click += new System.EventHandler(this.btn_restart_Click);
            // 
            // lyt_tablero
            // 
            this.lyt_tablero.ColumnCount = 2;
            this.lyt_tablero.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.lyt_tablero.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.lyt_tablero.Location = new System.Drawing.Point(29, 59);
            this.lyt_tablero.Margin = new System.Windows.Forms.Padding(0);
            this.lyt_tablero.Name = "lyt_tablero";
            this.lyt_tablero.RowCount = 2;
            this.lyt_tablero.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.lyt_tablero.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.lyt_tablero.Size = new System.Drawing.Size(566, 530);
            this.lyt_tablero.TabIndex = 5;
            // 
            // lbl_levantadas
            // 
            this.lbl_levantadas.AutoSize = true;
            this.lbl_levantadas.Location = new System.Drawing.Point(473, 22);
            this.lbl_levantadas.Name = "lbl_levantadas";
            this.lbl_levantadas.Size = new System.Drawing.Size(64, 13);
            this.lbl_levantadas.TabIndex = 6;
            this.lbl_levantadas.Text = "Puntuacion:";
            this.lbl_levantadas.Visible = false;
            // 
            // ventana_JuegoBuscaminas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(614, 619);
            this.Controls.Add(this.lbl_levantadas);
            this.Controls.Add(this.lyt_tablero);
            this.Controls.Add(this.btn_restart);
            this.Controls.Add(this.btn_comenzar);
            this.Controls.Add(this.cbox_nivel);
            this.Controls.Add(this.lbl_nivel);
            this.Name = "ventana_JuegoBuscaminas";
            this.Text = "Buscaminas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nivel;
        private System.Windows.Forms.ComboBox cbox_nivel;
        private System.Windows.Forms.Button btn_comenzar;
        private System.Windows.Forms.Button btn_restart;
        private System.Windows.Forms.TableLayoutPanel lyt_tablero;
        private System.Windows.Forms.Label lbl_levantadas;
    }
}

