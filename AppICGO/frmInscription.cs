using BiblioDAOICGO;
using BiblioManager;
using BiblioMetierICGO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AppICGO
{
    public partial class frmInscription : Form
    {
        public frmInscription()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Chargement du formulaire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmInscription_Load(object sender, EventArgs e)
        {

            // Charger les états d'inscription dans la ComboBox
           InscriptionManager.ChargerEtatInscription(cboEtat);
            // Charger les sessions dans la ComboBox
            InscriptionManager.ChargerLesSessions(cboSession);
            

           // Valorisation de cboEtat
            cboEtat.Items.Add("Définitif");
            cboEtat.Items.Add("Provisoire");

            
            // Valorisation de cboStagiaire
            StagiaireManager.ChargerLesStagiaires(cboStagiaire);
               
            
        }
        

        /// <summary>
        /// Remise à vide de l'ensemble des zones de saisie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            cboStagiaire.SelectedIndex = -1;
            cboSession.SelectedIndex = -1;
            cboEtat.SelectedIndex = -1;
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Ouverture du formulaire frmStagiaire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStagiaire_Click(object sender, EventArgs e)
        {
            frmStagiaire fs = new frmStagiaire();
            cboStagiaire.SelectedIndex = -1;
            fs.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int retour = InscriptionDAO.VerifierPlacesDisponibles("BDD", 1, 1);
            MessageBox.Show("Valeur retour = " + retour);
        }

        

        private void cboStagiaire_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            // Récupérer l'objet Stagiaire sélectionné
            if (cboStagiaire.SelectedItem != null)
            {
                KeyValuePair<int, Stagiaire> selectedItem = (KeyValuePair<int, Stagiaire>)cboStagiaire.SelectedItem;
                Stagiaire stagiaireSelectionne = selectedItem.Value; // L'objet Stagiaire complet
                int stagiaireId = selectedItem.Key; // ID du stagiaire

                // Vous pouvez maintenant utiliser `stagiaireSelectionne` ou `stagiaireId` pour d'autres traitements
                MessageBox.Show("Stagiaire sélectionné: " + stagiaireSelectionne.GetNomStagiaire() + " " + stagiaireSelectionne.GetPrenom());
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            // Exemple pour ajouter une inscription avec les valeurs saisies
            if (cboStagiaire.SelectedItem != null && cboEtat.SelectedIndex != -1)
            {
                KeyValuePair<int, Stagiaire> selectedItem = (KeyValuePair<int, Stagiaire>)cboStagiaire.SelectedItem;
                Stagiaire stagiaireSelectionne = selectedItem.Value;
                string etatInscription = cboEtat.SelectedItem.ToString();

              
            }
    }

        private void cboSession_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Vérifier si un élément a été sélectionné
            if (cboSession.SelectedIndex != -1)
            {
                // Récupérer l'élément sélectionné (texte)
                string selectedSession = cboSession.SelectedItem.ToString();

                // Afficher une simple boîte de message avec le texte de la session sélectionnée
                MessageBox.Show("Session sélectionnée : " + selectedSession);
            }
        }

        private void cboEtat_SelectedIndexChanged(object sender, EventArgs e)
        {

            
                // Vérifie si un élément est sélectionné
                if (cboEtat.SelectedIndex != -1)
                {
                    string etatSelectionne = cboEtat.SelectedItem.ToString();

                    // Affiche un message pour confirmer l'état sélectionné
                    MessageBox.Show("État sélectionné : " + etatSelectionne);

                
            }



        }
    }

}

