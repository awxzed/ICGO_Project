using BiblioMetierICGO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioDAOICGO
{
    public class InscriptionDAO
    {
        /// <summary>
        /// Ajouter une inscription dans la table INSCRIRE
        /// </summary>
        /// <param name="uneInscription">Une inscription</param>
        public static void AjouterUneInscription(Inscription uneInscription)
        {
            // Exécution de la requête d'insertion
            string requete = "INSERT INTO inscrire VALUES (@numstagiaire, @numsession, @etatinscription)";
            Connexion.ExecutionMaj(requete,
               new MySqlParameter("@numstagiaire", uneInscription.GetLeStagiaire()),
               new MySqlParameter("@numsession", uneInscription.GetLaSession()),
               new MySqlParameter("@etatinscription", uneInscription.GetEtatInscription())
                );
        }

        /// <summary>
        /// Confirmer une inscription : état définitif 
        /// </summary>
        /// <param name="uneInscription">Une inscription</param>
        public static void ConfirmerInscription(Inscription uneInscription)
        {
            // Exécution de la requête d'insertion
            string requete = "UPDATE inscrire SET ETATINSCRIPTION='d' WHERE NUMSTAGIAIRE = @idStagiaire AND NUMSTAGE = @idStage AND NUMSESSION = @idSession";
            Connexion.ExecutionMaj(requete,
               new MySqlParameter("@idStagiaire", uneInscription.GetLeStagiaire()),
               new MySqlParameter("@numsession", uneInscription.GetLaSession()),
               new MySqlParameter("@idStage", uneInscription.GetEtatInscription())
                );
        }

        /// <summary>
        /// Supprimer une inscription identifiée par une session et un stagiaire
        /// </summary>
        /// <param name="idCompetence">Code compétence</param>
        /// <param name="idStage">Numéro stage</param>
        /// <param name="idSession">Numéro session</param>
        /// <param name="idStagiaire">Numéro stagiaire</param>
        public static void SupprimerUneInscription(string idCompetence, int idStage, int idSession, int idStagiaire)
        {
            // Exécution de la requête de suppression
            string requete = "DELETE FROM INSCRIPTION WHERE CODECOMPETENCE  = @idC AND NUMSTAGE = @idS AND NUMSESSION = @idSession AND NUMSTAGIAIRE = @idStagiaire" ;
            Connexion.ExecutionMaj(requete,
            new MySqlParameter("@idC", idCompetence));
            new MySqlParameter("@idS", idStage);
            new MySqlParameter("@idSession", idSession);
            new MySqlParameter("@idStagiaire", idCompetence);
        }

        public static int VerifierPlacesDisponibles(string idCompetence, int idStage, int idSession)
        {
            int dispo = Connexion.ExecutionProc(idCompetence, idStage, idSession);
            return dispo;
        }

        
        
    }
}
