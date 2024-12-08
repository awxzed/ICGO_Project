using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BiblioMetierICGO;
using MySql.Data.MySqlClient;

namespace BiblioDAOICGO
{
    public class SessionDAO
    {
        /// <summary>
        /// Ajouter une session dans la table SESSION
        /// </summary>
        /// <param name="uneSession"></param>
        public static void AjouterUneSession(Session uneSession)
        {
            string requete;

            requete = "INSERT INTO SESSION VALUES(@codeCompetence, @numStage, @numSession, @nomAgence, numFormateur, dateDebutSession)";
            Connexion.ExecutionMaj(requete,
                new MySqlParameter("@codeCompetence", uneSession.getCompetence().GetCodeCompetence()),
                new MySqlParameter("@numStage", uneSession.GetLeStage().GetNumStage()),
                new MySqlParameter("@numSession", uneSession.GetNumSession()),
                new MySqlParameter("@nomAgence", uneSession.GetNomAgence()),
                new MySqlParameter("@numFormateur", uneSession.GetLeFormateur().GetNumFormateur()),
                new MySqlParameter("@dateDebutSession", uneSession.GetDateSession())); 
        }

        /// <summary>
        ///  Charger les sessions de la table SESSION dans une liste de sessions
        /// </summary>
        /// <returns></returns>
        public static List<Session> ChargerLesSessions()
        {
            List<Session> lesSessions = new List<Session>();
            Session uneSession;
            string codeCompetence;
            int numStage;
            int numSession;
            string nomAgence;
            int numFormateur;
            DateTime dateDebutSession;

            lesSessions.Clear();

            // Requête : 
            string requete = "SELECT * FROM session";
            DataTable dt = Connexion.ExecutionRequete(requete, null); 

            foreach (DataRow uneLigne in dt.Rows)
            {
                // Récupération des caractéristiques d'une session à partir du résultat de la requête
                codeCompetence = uneLigne["CODECOMPETENCE"].ToString();
                numStage = int.Parse(uneLigne["NUMSTAGE"].ToString());
                numSession = int.Parse(uneLigne["NUMSESSION"].ToString());
                nomAgence = uneLigne["NOMAGENCE"].ToString(); 
                numFormateur = int.Parse(uneLigne["NUMFORMATEUR"].ToString()) ;
                dateDebutSession = DateTime.Parse(uneLigne["DATEDEBUTSESSION"].ToString());

                uneSession = new Session(CompetenceDAO.GetCompetence(codeCompetence), numSession, dateDebutSession, StageDAO.GetStage(codeCompetence, numStage), FormateurDAO.GetFormateur(numFormateur), nomAgence);
                lesSessions.Add(uneSession); 
            }

            return lesSessions;
        }

        /// <summary>
        /// Retourne une session identifiée dans la table SESSION
        /// </summary>
        /// <param name="idCompetence">Code compétence</param>
        /// <param name="idStage">Numéro stage</param>
        /// <param name="idSession">Numéro session</param>
        /// <returns></returns>
        public static Session GetSession(string idCompetence, int idStage, int idSession)
        {
            Session uneSession = new Session();
            string codeCompetence;
            int numStage;
            int numSession;
            string nomAgence;
            int numFormateur;
            DateTime dateDebutSession;

            string requete = "SELECT * FROM session WHERE CODECOMPETENCE = @idCompetence AND NUMSTAGE = @idStage AND NUMSESSION = @idSession)";
            DataTable dt = Connexion.ExecutionRequete(requete,
            new MySqlParameter("@idCompetence", idCompetence),
            new MySqlParameter("@idSession", idSession),
            new MySqlParameter("@idSession", idSession));

            if (dt.Rows.Count == 1)
            {
                codeCompetence = dt.Rows[0]["CODECOMPETENCE"].ToString();
                numStage = int.Parse(dt.Rows[0]["NUMSTAGE"].ToString());
                numSession = int.Parse(dt.Rows[0]["NUMSESSION"].ToString());
                nomAgence = dt.Rows[0]["NOMAGENCE"].ToString();
                numFormateur = int.Parse(dt.Rows[0]["NUMFORMATEUR"].ToString());
                dateDebutSession = DateTime.Parse(dt.Rows[0]["DATEDEBUTSESSION"].ToString());

                Session session = new Session(CompetenceDAO.GetCompetence(codeCompetence), numSession, dateDebutSession, StageDAO.GetStage(idCompetence, idStage), FormateurDAO.GetFormateur(numFormateur), nomAgence);
                uneSession = session;
            }

            return uneSession;
        }

            /// <summary>
            /// Modifier les caractéristiques d'une session identifiée dans la table SESSION
            /// </summary>
            /// <param name="uneSession">Une session</param>
            /// <param name="idCompetence">Code compétence</param>
            /// <param name="idStage">Numéro stage</param>
            /// <param name="idSession">Numéro session</param>
            public static void ModifierUneSession(Session uneSession, string idCompetence, int idStage, int idSession)
        {



        }

        /// <summary>
        /// Supprimer une session identifiée dans la table SESSION
        /// </summary>
        /// <param name="idCompetence">Code compétence</param>
        /// <param name="idStage">Numéro stage</param>
        /// <param name="idSession">Numéro session</param>
        public static void SupprimerUneSession(string idCompetence, int idStage, int idSession)
        {



        }

        /// <summary>
        /// Charger les sessions de la table INSCRIRE d'un stagiaire identifié par son numéro
        /// </summary>
        /// <param name="idStagiaire">Numéro stagiaire</param>
        /// <returns></returns>
        public static List<Session> ChargerLesSessionsDuStagiaire(int idStagiaire)
        {
            List<Session> lesSessions = new List<Session>();

            return lesSessions;
        }

        /// <summary>
        /// Charger les sessions n'appartenant pas à la table INSCRIRE d'un stagiaire identifié par son numéro
        /// </summary>
        /// <param name="idStagiaire">Numéro stagiaire</param>
        /// <returns></returns>
        public static List<Session> ChargerLesSessionsNonChoisiesDuStagiaire(int idStagiaire)
        {
            List<Session> lesSessions = new List<Session>();

            return lesSessions;
        }
    }
}
