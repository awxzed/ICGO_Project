using BiblioDAOICGO;
using BiblioManager;
using BiblioMetierICGO;
using BiblioSupport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppICGO
{
    public partial class frmSessionStage : Form
    {
        // Booléen indiquant si une session a été choisie dans cboSession
        private bool choixSession;

        public frmSessionStage()
        {
            InitializeComponent(); 
        }
        /// <summary>
        /// Vider les différents contrôles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            choixSession = false;
            txtNumSession.Clear();
            dtpDateSession.Value = DateTime.Now;
            cboAgence.SelectedIndex = -1;
            cboFormateur.SelectedIndex = -1;
            cboSession.SelectedIndex = -1;
            cboStage.SelectedIndex = -1;
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSessionStage_Load(object sender, EventArgs e)
        {
           // SessionStageManager.ChargerLesSessionsStage(cboSession);
        }

        private void cboSession_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idSession;
            string codeCompetence;
            Session uneSession;

            if (cboSession.SelectedIndex >= 0)
            {
               
               // uneSession = SessionDAO.GetSession(idCompetence, idStage,  idSession); 
            }

        }
    }
}
