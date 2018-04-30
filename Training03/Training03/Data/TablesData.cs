using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Training03.Models.NHL; //dodaj

namespace Training03.Data
{
    public class TablesData
    {

        public static System.Collections.Generic.List<Team> getTeams()
        {
            List<Team> teams = new List<Team>()
            {
                new Team() {
                    TeamName = "Dubocica",
                    City = "Leskovac",
                    Province = "Juznomoravski region"
                },
                 new Team() {
                    TeamName = "Partizan",
                    City = "Beograd",
                    Province = "Capital"
                },
            };

            return teams;
        }

        //Kod tabele Player je Kardinalnost N, pa ovde imamo parametar u metodi
        //i ovde kreiramo FK, metoda mora da bude static
        public static List<Player> getPlayers(NhlContext context)
        {
            List<Player> players = new List<Player>()
            {
                new Player {
                   FirstName = "Perica",
                   LastName = "Ognjenovic",
                   Position = "Centarfor",
                   TeamName = context.Teams.Find("Dubocica").TeamName   
                   //Creating FK, uz pomoc context linkujemo Ime players sa ImenomTima
                },
                 new Player {
                   FirstName = "Zikica",
                   LastName = "Lozickovic",
                   Position = "Golman",
                   TeamName = context.Teams.Find("Partizan").TeamName
                },
                  new Player {
                   FirstName = "Djokica",
                   LastName = "Temeljkovic",
                   Position = "Centarhalf",
                   TeamName = context.Teams.Find("Dubocica").TeamName
                },
            };

            return players;

        }
    }
}