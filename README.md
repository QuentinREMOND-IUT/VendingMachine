# 🥤 Vending Machine Simulator (C# Console)

Une application console en C# simulant le fonctionnement complet d'un distributeur automatique. 
Ce projet a été réalisé pour mettre en pratique les principes de la **Programmation Orientée Objet (POO)** et la logique algorithmique en .NET.

## 🚀 Fonctionnalités

L'application permet à l'utilisateur de simuler un cycle d'achat complet :

* **Consultation des produits :** Affichage dynamique de l'inventaire (Nom, Prix, Stock restant).
* **Gestion du porte-monnaie :** Insertion d'argent (crédit) et cumul du solde.
* **Achat de produits :** * Vérification du stock disponible.
    * Vérification du solde suffisant.
    * Mise à jour automatique des stocks et du solde après achat.
* **Rendu de monnaie :** Calcul et restitution du solde restant.
* **Boucle interactive :** Interface console persistante avec menu de navigation.

## 🛠️ Compétences Techniques Mises en Œuvre

Ce projet démontre la maîtrise des concepts suivants en C# :

* **Programmation Orientée Objet (POO) :**
    * Création de classes (`Product`, `VendingMachine`).
    * Encapsulation des données.
    * Manipulation d'objets et d'instances.
* **Structures de Données :** Utilisation de `List<T>` pour gérer l'inventaire.
* **Logique Algorithmique :** * Boucles (`foreach`, `while`).
    * Conditions (`if/else`, `switch`).
    * Recherche dans une liste (LINQ / Lambda expressions).
* **Précision Financière :** Utilisation du type `decimal` pour garantir la précision des calculs monétaires.

## 📂 Structure du Code

* `Program.cs` : Point d'entrée de l'application. Gère l'interface utilisateur (UI) et la boucle principale.
* `VendingMachine.cs` : Contient la logique métier (méthodes `BuyProduct`, `InsertMoney`, `ReturnChange`).
* `Product.cs` : Définit le modèle de données d'un article (ID, Nom, Prix, Stock).

## 🔧 Comment Lancer le Projet

1.  **Cloner le dépôt :**
    ```bash
    git clone [https://github.com/QuentinREMOND-IUT/VendingMachine.git](https://github.com/QuentinREMOND-IUT/VendingMachine.git)
    ```
2.  **Ouvrir le projet :**
    * Ouvrez le fichier `.sln` ou le dossier avec **Visual Studio** (ou VS Code).
3.  **Exécuter :**
    * Appuyez sur `F5` ou cliquez sur le bouton "Démarrer" pour lancer la console.

---
*Projet réalisé dans le cadre d'un portfolio pour une recherche d'alternance en développement C# / .NET.*
