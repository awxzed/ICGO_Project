using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BiblioMetierICGO;


namespace BiblioMetierICGO
{
    public class Inscription
    {

        #region Attributs privés
        private Session laSession;
        private Stagiaire leStagiaire;
        private string etatInscription;

       


        #endregion

        #region Constructeurs
        public Inscription(Session laSession, Stagiaire leStagiaire, string etatInscription)
        {
            this.laSession = laSession;
            this.leStagiaire = leStagiaire;
            this.etatInscription = etatInscription;
        }

        public Inscription()
        {

        }



        #endregion

        #region Accesseurs

        public Session GetLaSession()
        {
            return laSession;
        }

        public void SetLaSession(Session value)
        {
            laSession = value;
        }

        public Stagiaire GetLeStagiaire()
        {
            return leStagiaire;
        }

        public void SetLeStagiaire(Stagiaire value)
        {
            leStagiaire = value;
        }

        public string GetEtatInscription()
        {
            return etatInscription;
        }

        public void SetEtatInscription(string value)
        {
            etatInscription = value;
        }

       

        #endregion
    }
}
