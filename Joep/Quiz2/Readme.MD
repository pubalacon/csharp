ArticlesQte.Add(new KeyValuePair<Product, int>(article, quantity));

1) What is the difference between an instance and a class.
La classe est une definition de structure et l'instance un objet construit avec cette structure
2) How and when can you redefine a function in a derived class ?
On peut redefinir une fonction dans une classe fille avec la meme signature , on utilise new
Si la fonction base est de type virtual on utilise override
La classe parente ne doit pas etre finale
3) What is the difference between an abstract method and a virtual method ?
methode abstraite seulement dans une classe abstraite
Une methode abstraite doit etre implementee
une methode virtual peut etre implementée et peut etre overridee
4) what is the difference between "new" and "override" ?
new : on cherche la fonction dans le parent, override on la cherche dans la fille
leur principale difference reste leur accessibilité.
5) Does a virtual method need to have an implementation ?
Oui
6) What is the difference between method overriding and method overloading ?
L'override est le fait de declarer la meme methode dans plusieurs classes avec la meme signature (ecrase)
L'overloading est le fait de declarer plusieurs fois la meme methode dans une classe avec des signatures differentes
7) What is an indexer ?
C'est un pattern qui permet d'acceder a un element d'une classe comme si celle-ci etait un tableau
8) When is the "Finally" block of a try catch executed ? When is it not excecuted ?
Le Finally est toujours executé en fin de ty catch
9) What is a cast ? Give an example of why it is sometimes necessary to use it ?
C'est le fait de forcer un type en un autre. Par exemple si on veut utiliser des fonctionalités de Parent alors que l'objet est de type Fille, on caste Fille en Parent. Fonctionne dans un type plus restrictif (ascendant)
10) What is a constructor ? how is it called ?
Le constructeur est une methode particuliere de la classe, sa signature comprend le nom de la classe et les attributs qu'on souhaite initialiser, son retour est un objet. 
Il est appelé lors du new Object
11) How would you choose between a list and an array ?
Par exemple si on connait le nb de membre final, tableau, sinon liste.
Si on veut rajouter des membres, complique avec un array 
12) What do ref and out do ? What is the difference between them ? (ex code)
ref et out passent un pointeur sur la variable.
ref est interressant pour les types de valeur (int, double)
f(a) { a = a+1; } // a n'est jamais changé, car on passe a par valeur
f(ref a) { a = a+1; } // a change a chaque appelé

out est un endroit pour stocker une valeur de sortie, et n'aura donc pas besoin d'etre initialisée
int a; f(a) { ... } -> erreur, a doit avoir une valeur
int a=1; int b; f(int a, out b) { ... } // OK 

13) what is serialization ?  //vous ne savez pas celui la.
Le fait de tyransformer une structure en string (ex: classe Vehicule en format JSon)
14) Give a description of the different access modifiers.
internal: accessible au sein de l'assembly
sealed: ne peut pas etre herité
public: accessible a tous
private: accessible a l'instance seule
protected: accessible a la classe et ses derivés
15) Describe exception handling in c#. write exampls code.
Une exception est une classe specifique dediée à la gestion d'erreur, on peut definir ses exception personnalisées a partir des exceptions existantes
16) What does the Static modifier do ?
attribut: l'assigne a la classe mais pas a l'instance de la classe, il rend donc la valeur d'un attribut accessible a toutes les instances de la classe
classe: il permet d'utiliser une classe sans qu'on puisse l'instancier
17) What does void mean ?
C'est un type "vide"
18) what does "const" mean ?
Constante
19) What is "this" ?
this est le mot clé qui represente l'instance appelante
20) What is an abstract class ? when are they useful ? what is the difference with an interface ?
une interface ne comprend que des methodes abstraites, une classe abstraite pas forcement car elle peut implementer d'autres fonctions
On ne peut pas instancier un objet de type classe abstraite ou interface
Elles servent à mettre du code en commun, et a generaliser des fonctions
21) What are value types and reference types ?
Un type valeur est une donnee dont le contenu est accessible directement (la variable contient la donnee), une reference est un pointeur intermediaire par lequel on doit passer pour acceder au contenu
22) What is method overloading ? how can it be achieved ?
Une methode overloadee est une methode de meme nom et type mais avec plusieurs signatures (nb de parametres differents, retour peut etre de type different pour les 2)
23) What is polymorphism ? how does it manifest in c# ?
Le polymorphisme est la capacité à etre transformé. Exemple: l'overriding ou l'overloading
24) How do you inherit from a class in c# ? Can you inherit from multiple classes ?
Une classe ne peut heriter que d'une autre, elle herite par la declaration class Fille : Parent et par l'utilisation (optionnelle) de :base 1/ au niveau du constructeur 2/ en prefixe aux methodes du parent.
25) How do you call a function of the "parent class" inside a child class function definition ?
base.fonction
26) What is a delegate ? a Multiple delegate ?
Un delegate simple est une fonction qui se substitue a une fonction ou un groupe de fonction liées par un operateur
Il sert dans le pattern Editor/Publisher par exemple
27) Can we use "this" in a static method ?
Non