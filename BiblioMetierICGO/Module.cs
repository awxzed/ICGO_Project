using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioMetierICGO
{
    public class Module
    {

        #region Attributs privés

        private int numModule;
        private string nomModule;
        private string nomSupportCours;
        private string nomPresentation;
        private string placeSupportCours;
        private string placePresentation;
        private List<Stage> lesStages;

        #endregion

        #region Accesseurs
        public int NumModule { get => numModule; set => numModule = value; }
        public string NomModule { get => nomModule; set => nomModule = value; }
        public string NomSupportCours { get => nomSupportCours; set => nomSupportCours = value; }
        public string NomPresentation { get => nomPresentation; set => nomPresentation = value; }
        public string PlaceSupportCours { get => placeSupportCours; set => placeSupportCours = value; }
        public string PlacePresentation { get => placePresentation; set => placePresentation = value; }
        public List<Stage> LesStages { get => lesStages; set => lesStages = value; }

        #endregion

        #region Constructeurs

        public Module()
        {
            lesStages = new List<Stage>();
        }
       
        public Module(int numModule, string nomModule, string nomSupportCours, string nomPresentation, string placeSupportCours, string placePresentation)
        {
            this.numModule = numModule;
            this.nomModule = nomModule;
            this.nomSupportCours=nomSupportCours;
            this.nomPresentation = nomPresentation;
            this.placePresentation = placePresentation;
            this.placeSupportCours = placeSupportCours;

        }

        public Module (int numModule, string nomModule, string nomSupportCours, string nomPresentation, string placeSupportCours, string placePresentation, List<Stage> lesStages)
        {
            
            this.NumModule = numModule;
            this.NomModule = nomModule;
            this.NomSupportCours = nomSupportCours;
            this.NomPresentation = nomPresentation;
            this.PlaceSupportCours = placeSupportCours;
            this.PlacePresentation = placePresentation;
            this.LesStages = lesStages;
        }




        #endregion

        



        

    }
}
