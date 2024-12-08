using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BiblioMetierICGO;
using MySql.Data.MySqlClient;

namespace BiblioDAOICGO
{
    public class ModuleDAO
    {
        /// <summary>
        /// Ajouter un module dans la table MODULE
        /// </summary>
        /// <param name="unModule">Un module</param>
        public static void AjouterUnModule(Module unModule)
        {



        }

        /// <summary>
        /// Charger les modules de la table MODULE dans une liste de modules
        /// </summary>
        /// <returns></returns>
        public static List<Module> ChargerLesModules()
        {
            List<Module> lesModules = new List<Module>();

            return lesModules;
        }

        /// <summary>
        /// Retourne un module identifié par son numéro dans la table MODULE
        /// </summary>
        /// <param name="idModule">Numéro module</param>
        /// <returns></returns>
        public static Module GetModule(int idModule)
        {
            Module unModule = new Module();

            return unModule;
        }

        /// <summary>
        /// Modifier les caractéristiques d'un module identifié par son numéro dans la table MODULE
        /// </summary>
        /// <param name="unModule">Un module</param>
        /// <param name="idModule">Numéro module</param>
        public static void ModifierUnModule(Module unModule, int idModule)
        {



        }

        /// <summary>
        /// Supprimer un module identifié par son numéro dans la table MODULE
        /// </summary>
        /// <param name="idModule">Numéro module</param>
        public static void SupprimerUnModule(int idModule)
        {



        }

        /// <summary>
        /// Charger les modules de la table COMPOSER d'un stage identifié par son code compétence et numéro stage
        /// </summary>
        /// <param name="idCompetence">Code compétence</param>
        /// <param name="idStage">Numéro stage</param>
        /// <returns></returns>
        public static List<Module> ChargerLesModulesDuStage(string idCompetence, int idStage)
        {
            List<Module> lesModules = new List<Module>();

            return lesModules;

        }
    }
}
