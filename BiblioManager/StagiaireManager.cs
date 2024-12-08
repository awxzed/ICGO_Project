using BiblioDAOICGO;
using BiblioMetierICGO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiblioManager
{
    public class StagiaireManager
    {
        /// <summary>
        /// Valorisation de cboStagiaire
        /// </summary>
        /// <param name="cboStagiaire">Combo cboStagiaire</param>
        static public void ChargerLesStagiaires(ComboBox cboStagiaire)
        {
            // Recherche des stagiaires dans la base de données via le DAO
            List<Stagiaire> lesStagiaires = StagiaireDAO.ChargerLesStagiaires();

            // Remise à vide du ComboBox
            cboStagiaire.Items.Clear();
            cboStagiaire.SelectedIndex = -1; 

            // Création d'un libellé "numéro. nom prénom" et ajout dans cboStagiaire pour chaque stagiaire
            foreach (Stagiaire unStagiaire in lesStagiaires)
            {
                // Ajouter chaque stagiaire comme objet, mais avec une représentation textuelle
                cboStagiaire.Items.Add(new KeyValuePair<int, Stagiaire>(
                    unStagiaire.GetNumStagiaire(), 
                    unStagiaire                     
                ));
            }

           
            cboStagiaire.DisplayMember = "Value";  
            cboStagiaire.ValueMember = "Key";      
        }

    }
}
