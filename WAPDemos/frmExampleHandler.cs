using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WAPDemos
{
    public partial class frmExampleHandler : Form
    {

        #region Data Members
        private frmDemo01_Ordenar _frmDemo01 = null;
        private frmDemo02_Ordenar _frmDemo02 = null;
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        public frmExampleHandler()
        {
            InitializeComponent();
        }

        #endregion
        private void subMenuClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region Public Methods
        /// <summary>
        /// open Demo01 form
        /// </summary>
        public void OpenDemo01()
        {
             if(_frmDemo01 == null || _frmDemo01.IsDisposed)
            {
                _frmDemo01 = new frmDemo01_Ordenar();
            }

            OpenChildForm(_frmDemo01);
        }
        /// <summary>
        /// open Demo02 form
        /// </summary>
        public void OpenDemo02()
        {
            if(_frmDemo02 == null || _frmDemo02.IsDisposed)
            {
                _frmDemo02 = new frmDemo02_Ordenar();
            }

            OpenChildForm(_frmDemo02);
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// method to open child window form
        /// </summary>
        /// <param name="childForm">child form</param>
        private void OpenChildForm(Form childForm)
        {
            childForm.MdiParent = this;
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Show();
        }
        #endregion

        #region Tool Bar Events
        private void submenuDemo01_Click(object sender, EventArgs e)
        {
            OpenDemo01();
        }
        #endregion

        private void submenuDemo02_Click(object sender, EventArgs e)
        {
            OpenDemo02();
        }
    }
}
