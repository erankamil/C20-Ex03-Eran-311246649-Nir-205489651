using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace C20_Ex01_Eran__311246649_Nir_205489651
{
    public class DesignedButton : Button
    {
        public Action CommandDelegate { get; set; }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            CommandDelegate?.Invoke();
        }
    }
}
