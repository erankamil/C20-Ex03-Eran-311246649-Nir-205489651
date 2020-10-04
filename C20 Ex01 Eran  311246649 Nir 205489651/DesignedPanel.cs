using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace C20_Ex01_Eran__311246649_Nir_205489651
{
    public class DesignedPanel : Panel
    {
        private readonly int r_PanelMaxSize = 210;
        private List<DesignedButton> m_MenuButtonItems = new List<DesignedButton>();
        private int m_NextLocation = 1;

        public void Add(DesignedButton i_buttonItem)
        {
            if (m_NextLocation + i_buttonItem.Height + 5 < r_PanelMaxSize)
            {
                i_buttonItem.Size = new System.Drawing.Size(122, 35);
                m_MenuButtonItems.Add(i_buttonItem);
                i_buttonItem.Location = new System.Drawing.Point(4, m_NextLocation);
                m_NextLocation += i_buttonItem.Height + 5;
                this.Controls.Add(i_buttonItem);
            }
            else
            {
                throw new Exception("You have reached the max capacity of this panel");
            }
        }

        public void Remove(DesignedButton i_buttonItem)
        {
            m_MenuButtonItems.Remove(i_buttonItem);
            this.Controls.Remove(i_buttonItem);
        }
    }
}
