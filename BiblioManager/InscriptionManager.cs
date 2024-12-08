using BiblioDAOICGO;
using BiblioMetierICGO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiblioManager
{
    public class InscriptionManager
    {
        /// <summary>
        /// Valorisation de cboStagiaire
        /// </summary>
        /// <param name="cboStagiaire">Combo cboStagiaire</param>
        static public void ChargerLesStagiaire(ComboBox cboStagiaire)
        {
            List<Stagiaire> lesStagiaires = new List<Stagiaire>();

            // Recherche des Stagiaire dans la base de données
            lesStagiaires = StagiaireDAO.ChargerLesStagiaires();
            // Remise à vide de cboStagiaire
            cboStagiaire.SelectedIndex = -1;
            cboStagiaire.Items.Clear();
            // Création d'un libellé "numéro. nom prénom" et ajout dans cboStagiaire pour chaque Stagiaire
            foreach (Stagiaire unStagiaire in lesStagiaires)
            {
                cboStagiaire.Items.Add(unStagiaire.GetNumStagiaire() + ". " + unStagiaire.GetNomStagiaire() + " " + unStagiaire.GetPrenom());
            }


        }
        static public void ChargerLesSessions(ComboBox cboSession)
        {
            List<Session> sessions = new List<Session>();

            // Recherche des sessions dans la base de données
            sessions = SessionDAO.ChargerLesSessions();

            // Remise à vide de cboSession
            cboSession.SelectedIndex = -1;
            cboSession.Items.Clear();

            // Création d'un libellé "compétence.code. stage.num. stage.nom" et ajout dans cboSession pour chaque session
            foreach (Session uneSession in sessions)
            {
                // Construction du libellé à afficher dans la combo box
                string libelleSession = uneSession.getCompetence().GetCodeCompetence() + ". " +
                                        uneSession.GetLeStage().GetNumStage() + ". " +
                                        uneSession.GetLeStage().GetNomStage();

                // Ajout du libellé dans la combo box
                cboSession.Items.Add(libelleSession);
            }
        }

        static public void ChargerEtatInscription(ComboBox cboEtat)
        {
            // Liste des états d'inscription que vous souhaitez afficher dans le ComboBox
            List<string> etatsInscription = new List<string>
    {
        "Définitif",
        "Provisoire"
    };

            // Remise à zéro de cboEtat
            cboEtat.SelectedIndex = -1;
            cboEtat.Items.Clear();

            // Ajout des états d'inscription dans le ComboBox
            foreach (string etat in etatsInscription)
            {
                cboEtat.Items.Add(etat);
            }
        }

    }
}
