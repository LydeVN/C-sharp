//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//double celcius, faranheit;
//celcius = 65.8;
//faranheit = 45.2;
//string monPrenom;
//Console.WriteLine(celcius + faranheit);
//Console.WriteLine("Donne-moi ton prenom :");
//monPrenom = Console.ReadLine();
//Console.WriteLine("Bonjour "+monPrenom);

int budgetCourses = 500;
int epargne = 1000;

epargne += 100;

//Retirer 50 de notre budget Courses
budgetCourses = budgetCourses - 50;

//Mettre à jour la durée d'épargne nécessaire pour atteindre l'objectif
int nombreJoursEpargne = (5000 - budgetCourses) / 500;

//mettre à jour le budget courses 
budgetCourses = budgetCourses + (30 - 10) * 7;
Console.WriteLine(nombreJoursEpargne);
Console.WriteLine(budgetCourses);