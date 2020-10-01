using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace C20_Ex01_Eran__311246649_Nir_205489651
{
    public partial class FormPleaseWait : Form
    {
        public Action Worker { get; set; }

        public FormPleaseWait(Action i_Worker)
        {
            InitializeComponent();
            if (i_Worker == null)
            {
                throw new ArgumentNullException();
            }

            Worker = i_Worker;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Task.Factory.StartNew(Worker).ContinueWith(t => { this.Close(); }, TaskScheduler.FromCurrentSynchronizationContext());
        }
    }
}