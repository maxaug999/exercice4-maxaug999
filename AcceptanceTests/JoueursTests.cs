using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using PoolSaison2019.Data;
using PoolSaison2019.Models;
using Newtonsoft.Json;
using TestStack.BDDfy;
using Xunit;
using PoolSaison2019.Controllers;

namespace webapp.AcceptanceTests
{
    //TODO : Compléter le descriptif de la story
    [Story(
         Title = "Titre de la story",
         AsA = "Type d'utilisateur",
         IWant = "Intention de la story",
         SoThat = "But de la story")]

    public class JoueursTests : AcceptanceTestsBase
    {
        private string _htmlPageContent;
        private Joueur _joueur;

        //Critère 
        
        [Fact]
        public void afficher_la_liste_de_joueurs()
        {
            this.Given(x => un_joueurAsync())
                .When(x => l_utilisateur_demande_de_voir_la_liste_des_joueurs())
                .Then(x => l_information_concernant_le_joueur_s_affiche())
                .BDDfy();
        }

        private async Task un_joueurAsync()
        {
            var mockRepo = new MockJoueurRepository();
            _joueur = await mockRepo.GetById(0); //1
        }

        private async Task l_utilisateur_demande_de_voir_la_liste_des_joueurs()
        {
            //On invoque le Contrôleur
            var response = await HttpClient.GetAsync("/Joueurs");
            response.EnsureSuccessStatusCode();
			//On lit le contenu de la Vue
            _htmlPageContent = await response.Content.ReadAsStringAsync();
        }

        private void l_information_concernant_le_joueur_s_affiche()
        {
            Assert.Contains(_joueur.Nom,_htmlPageContent);
            Assert.Contains(_joueur.Position, _htmlPageContent);
            //Assert.Contains(_joueur.Salaire, _htmlPageContent.in);
        }
    }
}