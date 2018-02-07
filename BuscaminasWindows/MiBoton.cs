using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuscaminasWindows
{
    class MiBoton : Button
    {
        private int fil;
        private int col;

        public MiBoton(int f, int c) : base()
        {
            fil = f;
            col = c;
        }

        internal int getFila()
        {
            return fil;
        }

        internal int getColumna()
        {
            return col;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // MiBoton
            // 
            this.AutoEllipsis = true;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.FlatAppearance.BorderSize = 0;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(29, 29);
            this.Size = new System.Drawing.Size(29, 0);
            this.UseVisualStyleBackColor = false;
            this.ResumeLayout(false);

        }
    }
}
