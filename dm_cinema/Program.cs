// See https://aka.ms/new-console-template for more information
using dm_cinema;
using System.Security.Cryptography;
//Test
//Affichage Acteur 
Acteur monActeur = new Acteur(54321, "Ford", "Harisson", "13/06/1942");
Acteur monActeur2 = new Acteur(12345, "Hanks", "Tom", "09/07/1956");

//Cinema 
Cinema c1 = new Cinema();
c1.setActeur(monActeur);
c1.setActeur(monActeur2);
c1.setFilm(12345, "Blade Runner", "Science-Fiction", "L'action du film se situe à Los Angeles en 2019 et met en scène Rick Deckard (interprété par Harrison Ford), un ancien policier qui reprend du service pour traquer un groupe de réplicants, des androïdes créés à l'image de l'Homme, menés par l'énigmatique Roy Batty (interprété par Rutger Hauer)", 1982, monActeur);
c1.setFilm(25345,"Toy Story", "Animation", "Le film met en scène un groupe de jouets. Woody, une poupée représentant un cow-boy, et Buzz l'Éclair, une figurine d'astronaute, en sont les personnages principaux.",1992,monActeur);
foreach(Acteur acteur in c1.LesActeur)
{
    Console.WriteLine("--------------Film---------------");
    Console.WriteLine(acteur.ToString());
}
foreach (Film film in c1.LesFilms)
{
    Console.WriteLine("--------------Film-------------------");
    Console.WriteLine(film.ToString());
}


