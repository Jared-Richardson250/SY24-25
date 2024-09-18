using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeper
{
        internal class Tile
        {
            private Button m_b;
            private Boolean m_flag;
            private Boolean m_dug;
            private Boolean m_mine;
            private int m_nearby;
            public Tile(Button b)
            {
                m_b = b;
            m_b.BackColor = Color.Green;
            }
        public void SetFlag(Boolean flag) { m_flag = flag; }
        public void SetMine(Boolean mine) { m_mine = mine; }
        public void SetDug(Boolean dug) { m_dug = dug; }
    }
    }