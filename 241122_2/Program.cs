
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

class Livre
{
    public string titre {  get; set; }
    public string auteur { get; set; }
    public int NombreDePages { get; set; }

    // Constructeur par défaut
    public Livre()
    {
        titre = "Titre par défaut";
        auteur = "Auteur inconnu";
        NombreDePages = 0;
    }

}

Livre CraigLivre = new Livre();
CraigLivre.titre = "L'art de la programmation";
CraigLivre.auteur = "Moi";
CraigLivre.NombreDePages= 200;


Livre monLivre = new();


Console.WriteLine(monLivre.auteur);
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