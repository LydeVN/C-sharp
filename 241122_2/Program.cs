
using _241122_2;
using System.Security.Cryptography.X509Certificates;

//Création d'un array
int[] tasseDeCafeParJourDeLaSemaine = new int[] {2,7,0,5,9,2,0};
Console.WriteLine("le premier jour de la semaine je bois "+tasseDeCafeParJourDeLaSemaine[0]+" cafés");
Console.WriteLine("Mon array compte "+tasseDeCafeParJourDeLaSemaine.Length+"données");


//Aray avec 30 siègle et 12 rangées dans une salle de cinema
string[,] mesSièges = new string[30,12];
mesSièges[9,5] = "Jules Vannelli";
mesSièges[9, 4] = "Noa Nafi";
Console.WriteLine(mesSièges[9, 5] + " et " + mesSièges[9, 4] + " seront bien côte à côte.");


// créatoin d'une liste
IList<int> maListe = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
maListe.Insert(1,3);
Console.WriteLine(maListe[1]);
Console.WriteLine("Ma liste compte " + maListe.Count+" données");

//création d'un ensemble non ordonnée
ISet<string> mySet = new HashSet<string>();
mySet.Add("oeufs");
mySet.Add("sucre");
mySet.Add("beurre");
mySet.Add("sel");
Console.WriteLine(mySet.Count);

//création d'un dictionnaire
IDictionary<string, int> monDictionnaire = new Dictionary<string, int>();
monDictionnaire.Add("Jennifer", 34);
monDictionnaire.Add("Patrick", 53);
monDictionnaire.Add("Jean", 27);
Console.WriteLine("Jennifier a "+monDictionnaire["Jennifer"]+ " ans");

const int bestNumber = 12;
string monPrenom = "";
string message = "Salut à tous !";
int valeur = 13;
string ageChaine = "";
int age = 0;

Console.WriteLine("le meilleur nombre est "+bestNumber+".");
Console.WriteLine("Donne-moi ton prenom :");

monPrenom = Console.ReadLine();
Console.WriteLine("Bonjour " + monPrenom);

Console.WriteLine("donne moi ton age :");
ageChaine = Console.ReadLine();
age = int.Parse(ageChaine);
bool ageMM;
int differenceUserAge;

// majeur ou mineur
if (age >= 18)
{
    ageMM = true;
}
else
{
    ageMM = false;
}

// combien de temps depuis la majorité
if (ageMM == true)
{
    differenceUserAge = age - 18;
    Console.WriteLine("Vous êtes majeur depuis déjà " + differenceUserAge + " ans !");
}
else
{
    Console.WriteLine("Vous êtes mineur !");
}
age += 1;


// année prochaine
Console.WriteLine(monPrenom + ", l'an prochain tu auras " + age + " ans.");

int porteMonnaie = 1000;
int taxe = 2;
double final = porteMonnaie / (double) taxe;

Console.WriteLine(final);



Livre CraigLivre = new Livre();
Console.WriteLine("quel est le titre de votre livre ?");
CraigLivre.Titre = Console.ReadLine();

Console.WriteLine("Et l'auteur de ce livre ?");
CraigLivre.Auteur = Console.ReadLine();

CraigLivre.NombreDePages= 200;


Livre monLivre = new();


Console.WriteLine(CraigLivre.Titre);
Console.WriteLine(CraigLivre.Auteur);
Console.WriteLine(CraigLivre.NombreDePages);




// int budgetCourses = 500;
// int epargne = 1000;

// epargne += 100;

// Retirer 50 de notre budget Courses
// budgetCourses = budgetCourses - 50;

// Mettre à jour la durée d'épargne nécessaire pour atteindre l'objectif
// int nombreJoursEpargne = (5000 - budgetCourses) / 500;

// mettre à jour le budget courses 
// budgetCourses = budgetCourses + (30 - 10) * 7;
// Console.WriteLine(nombreJoursEpargne);
// Console.WriteLine(budgetCourses);