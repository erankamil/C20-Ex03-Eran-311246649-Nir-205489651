using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using FaceBookAppLogic;

namespace C20_Ex01_Eran__311246649_Nir_205489651
{
    public partial class FormCheckInsDetails : Form
    {
        public FormCheckInsDetails()
        {
            InitializeComponent();
            this.checkinBindingSource.DataSource = AppManager.Instance.LoggedInUser.Checkins;
        }
    }
}
