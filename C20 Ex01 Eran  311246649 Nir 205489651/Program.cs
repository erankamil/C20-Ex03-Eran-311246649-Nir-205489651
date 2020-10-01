using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Facebook;
using FacebookWrapper;
using FaceBookAppLogic;

namespace C20_Ex01_Eran__311246649_Nir_205489651
{ 
    public static class Program //check
    {
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            FormAccount loginAndAcountForm = new FormAccount();
            loginAndAcountForm.ShowDialog();
        }
    }
}
