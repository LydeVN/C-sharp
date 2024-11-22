string monPrenom = "";
string message = "Salut à tous !";
int valeur = 13;
string ageChaine = "";
int age = 0; 

Console.WriteLine(age);
Console.WriteLine("Donne-moi ton prenom :");

monPrenom = Console.ReadLine();
Console.WriteLine("Bonjour "+monPrenom);

Console.WriteLine("donne moi ton age :");
ageChaine = Console.ReadLine();
age = int.Parse(ageChaine);
age += 1;
Console.WriteLine("Bonjour " +monPrenom+ ", l'an prochain tu auras " +age+ " ans !");

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