﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MindSweeper
{
    internal class Tile
    {
        private Button m_b;
        private Boolean m_flag;
        private Boolean m_dug;
        private Boolean m_mine;
        private int m_nearby;
        private Image m_FlagImage;
        private Image m_MineImage;
        public Tile(Button b)
        {
            m_b = b;
            m_b.BackColor = Color.Green;
        }
        public void SetNearby(int n) { m_nearby = n; }
        public void SetMineImage(Image mineImage) { m_MineImage = mineImage; }
        public void SetFlagImage(Image flagImage) { m_FlagImage = flagImage; }
        public void SetMine(Boolean b)
        {
            m_mine = b;
            m_b.BackgroundImage = m_MineImage;
        }
        public void SetDug(Boolean b) { m_dug = b; }
        public void SetFlag()
        {
            m_flag = !m_flag;
            if (m_flag)
            {
                m_b.BackgroundImage = m_FlagImage;
            }
            else
            {
                m_b.BackgroundImage=null;
            }
            m_b.BackgroundImage = m_FlagImage;
        }

    }
}