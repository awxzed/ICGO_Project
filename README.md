# IC-GO

Application de gestion des formations

IC-GO est une application C# avec interface graphique développée dans Visual Studio 2022. Elle permet de gérer les formations, les participants et les sessions, conçue pour le suivi et l’administration des formations en milieu professionnel ou scolaire.

## 🖥️ Technologies utilisées

- **C# / .NET**
- **Windows Forms** (interface graphique)
- **Visual Studio 2022**
- **SQL Server / LocalDB** (gestion des données)

## 🎨 Design & UI/UX

- Interface graphique intuitive (menus, boutons)
- Tableaux et listes dynamiques
- Adaptation aux différentes tailles d’écran desktop

## 📂 Structure du projet

- `AppICGO` : Interface graphique (UI)
- `AppliConsole` : Version console pour tests et administration
- `BiblioDAOICGO` : Accès à la base de données (CRUD, connexions)
- `BiblioMetierICGO` : Logique métier et entités (Formation, Participant, Session)
- `BiblioManager` : Coordination entre UI, métier et DAO
- `BiblioSupport` : Utilitaires et helpers
- `Documents` : Scripts SQL, documentations
- `ProjetICGO.sln` : Solution Visual Studio
- `icgo(1).sql` : Script de création de la base de données

## 🚀 Fonctionnalités principales

- Ajouter, modifier et supprimer des formations
- Gérer les participants et les assigner aux sessions
- Suivi et filtrage des formations et participants
- Interface conviviale pour la gestion quotidienne

## 📧 Contact

**Auteur** : aymen.boubarrada@epitech.eu
