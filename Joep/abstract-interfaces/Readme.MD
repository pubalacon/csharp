Voir Animal.cs, AnimalInterface.cs et Lion.cs pour l'info pricipale.
AnimalPark.cs pour un example de l'utilisation des classes abstraites.


classe abstraite:

ne peut etre instanciee (ie: Animal chat = new Animal(); n'est pas permis)
doit contenir au moins une methode Abstraite. Les methodes abstraites DOIVENT etre definies ds les classes derivees.

Elles servent a eviter la redondance de Code, en effet les fonctions communes a tous les Animals sont definies ici;
Elles servent a definir un patron (toutes les classes derivees auront une fonction Feed() ce qui permet d'eviter les erreurs)
Elle permet de definir (ailleurs) une fonction UnJourPasse(Animal bete) => {bete.Feed(); bete.Hunger()}


Methode Abstraite:

Une methode dont on ne definit que le nom et les arguments. Elle doit etre definie par les classes derivees.


Interface:

une interface est une classe abstraite ou toutes les fonctions sont abstraites (le mot clef abstract est omis)
elle sert a definir un plan pour les classes l'implementant
