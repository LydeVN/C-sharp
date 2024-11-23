
using _241122_2;
using System.Security.Cryptography.X509Certificates;

const int bestNumber = 12;
string monPrenom = "";
string message = "Salut à tous !";
int valeur = 13;
string ageChaine = "";
int age = 0;

Console.WriteLine(age);
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