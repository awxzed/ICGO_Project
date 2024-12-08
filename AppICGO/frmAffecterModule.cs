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
    public partial class frmAffecterModule : Form
    {// Déclaration d'un objet dynamic qui sera soit un stage étalé soit un stage groupé lors de l'exécution


        /// <summary>
        /// Constructeur du formulaire
        /// </summary>
        /// <param name="leStage">Stage transmis par le formulaire frmStage</param>
        public frmAffecterModule(               )
        {
            InitializeComponent();
        }

        private void frmAffecterModule_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Fermeture du formulaire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Suppression d'un module d'un stage en cliquant sur le bouton supprimer (X)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvModule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /// <summary>
        /// Suppression de modules (sélection de un ou plusieurs) d'un stage par l'intermédiaire de la touche SUPPR du clavier
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvModule_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {

        }

        /// <summary>
        /// Valorisation de la liste lstModule
        /// </summary>
        private void ChargerListeModules()
        {



        }
    }
}
