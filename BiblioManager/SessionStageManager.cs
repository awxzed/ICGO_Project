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
    public class SessionStageManager
    {
        static public void ChargerLesSessionsStage(ComboBox cboSession)
        {
            List<Session> lesSessions = new List<Session>();

            // Recherche des stages dans la base de données
            lesSessions = SessionDAO.ChargerLesSessions();
            // Remise à vide de cboStage
            cboSession.SelectedIndex = -1;
            cboSession.Items.Clear();
            // Création d'un libellé "numéro. nom" et ajout dans cboStage pour chaque stage (étalé ou groupé)
            foreach (Session uneSession in lesSessions)
            {
                cboSession.Items.Add(uneSession.getCompetence().GetCodeCompetence() + ". " + uneSession.GetLeStage().GetNumStage() + ". " + uneSession.GetLeStage().GetNomStage());
            }
        }
    }
}
