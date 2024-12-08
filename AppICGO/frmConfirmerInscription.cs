using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BiblioManager;
using BiblioDAOICGO;
using BiblioMetierICGO;
using BiblioSupport;

namespace AppICGO
{
    public partial class frmConfirmerInscription : Form
    {
        public frmConfirmerInscription()
        {
            InitializeComponent();
        }

        private void frmConfirmerInscription_Load(object sender, EventArgs e)
        {
            StagiaireManager.ChargerLesStagiaires(cboStagiaire);
        }

        private void cboStagiaire_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Valorisation de cboSession
            ChargerLesSessionsDuStagiaire();
        }

        /// <summary>
        /// Valorisation de cboSession : chargement des sessions du stagiaire
        /// </summary>
        private void ChargerLesSessionsDuStagiaire()
        {
            Stagiaire unStagiaire = new Stagiaire();
          //  SessionDAO.ChargerLesSessionsDuStagiaire(idStagiaire);


        }

        private void cboSession_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChargerLesSessions();
        }

        private void ChargerLesSessions()
        {

        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            /*
            int duree;
            string nbHeures;
            int nbPlaces;
            string prix;
            string nomStage;
            string jour;
            Competence uneCompetence;
            string codeCompetence, idCompetence;

            // si sélection d'un stage : extraction de son identifiant et recherche et affichage de ses caractéristiques
            if (cboStagiaire.SelectedIndex >= 0)
            {
                try
                {
                    Utilitaires.ExtraireIdStage(cboStage.Text, out idCompetence, out idStage);
                    codeCompetence = cboCompetence.Text;
                    uneCompetence = CompetenceDAO.GetCompetence(codeCompetence);
                    nomStage = txtNomStage.Text.Replace("'", "''");
                    prix = txtPrix.Text;
                    // Selon le type de stage
                    if (optEtale.Checked)
                    {
                        // Création d'un objet stage étalé
                        jour = cboJour.Text;
                        unStage = new StageEtale(numStage, nomStage, duree, prix, nbPlaces, uneCompetence, jour);
                    }
                    else
                    {
                        // Création d'un objet stage groupé
                        nbHeures = txtNbHeures.Text;
                        unStage = new StageGroupe(numStage, nomStage, duree, prix, nbPlaces, uneCompetence, nbHeures);
                    }

                    // Mise à jour du stage dans la base de données
                    StageDAO.ModifierUnStage(unStage, idCompetence, idStage);
                    // Valorisation de cboStage
                    StageManager.ChargerLesStages(cboStage);
                    // Message
                    MessageBox.Show("Stage modifié", "Mise à jour réussie !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Mise à jour échouée !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            else
                {
                    MessageBox.Show("Aucun stage choisi dans la liste", "Attention !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }*/

        }

    }
}
