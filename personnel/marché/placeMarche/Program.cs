using System.Numerics;

namespace placeMarche
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var producteurs = new List<Producteur>
        {
            new Producteur(1, "Bornand", "Pommes", 20, "kg", 6.90),
            new Producteur(1, "Bornand", "Poires", 16, "kg", 3.50),
            new Producteur(1, "Bornand", "Pastèques", 14, "pièce", 6.00),
            new Producteur(1, "Bornand", "Melons", 5, "kg", 7.00),
            new Producteur(2, "Dumont", "Noix", 20, "sac", 8.60),
            new Producteur(2, "Dumont", "Raisin", 6, "kg", 5.60),
            new Producteur(2, "Dumont", "Pruneaux", 13, "kg", 8.10),
            new Producteur(2, "Dumont", "Myrtilles", 12, "kg", 8.90),
            new Producteur(2, "Dumont", "Groseilles", 12, "kg", 5.20),
            new Producteur(3, "Vonlanthen", "Pêches", 8, "kg", 8.70),
            new Producteur(3, "Vonlanthen", "Haricots", 6, "kg", 6.90),
            new Producteur(3, "Vonlanthen", "Courges", 18, "pièce", 4.30),
            new Producteur(3, "Vonlanthen", "Tomates", 12, "kg", 9.40),
            new Producteur(3, "Vonlanthen", "Pommes", 20, "kg", 3.90),
            new Producteur(4, "Barizzi", "Poires", 5, "kg", 6.30),
            new Producteur(4, "Barizzi", "Pastèques", 6, "pièce", 2.50),
            new Producteur(4, "Barizzi", "Melons", 14, "kg", 4.20),
            new Producteur(4, "Barizzi", "Noix", 20, "sac", 7.50),
            new Producteur(4, "Barizzi", "Raisin", 15, "kg", 7.20),
            new Producteur(5, "Blanc", "Pruneaux", 5, "kg", 9.00),
            new Producteur(5, "Blanc", "Myrtilles", 18, "kg", 5.60),
            new Producteur(5, "Blanc", "Groseilles", 10, "kg", 2.10),
            new Producteur(5, "Blanc", "Pêches", 20, "kg", 6.40),
            new Producteur(5, "Blanc", "Haricots", 9, "kg", 2.90),
            new Producteur(6, "Repond", "Courges", 12, "pièce", 7.40),
            new Producteur(6, "Repond", "Tomates", 12, "kg", 4.20),
            new Producteur(6, "Repond", "Pommes", 15, "kg", 6.50),
            new Producteur(6, "Repond", "Poires", 18, "kg", 2.40),
            new Producteur(6, "Repond", "Pastèques", 7, "pièce", 5.70),
            new Producteur(7, "Mancini", "Pêches", 10, "kg", 2.90),
            new Producteur(7, "Mancini", "Haricots", 11, "kg", 6.70),
            new Producteur(7, "Mancini", "Courges", 10, "pièce", 6.40),
            new Producteur(7, "Mancini", "Tomates", 13, "kg", 1.50),
            new Producteur(7, "Mancini", "Pommes", 14, "kg", 7.00),
            new Producteur(8, "Favre", "Poires", 5, "kg", 8.40),
            new Producteur(8, "Favre", "Pastèques", 5, "pièce", 1.70),
            new Producteur(8, "Favre", "Haricots", 5, "kg", 3.00),
            new Producteur(8, "Favre", "Courges", 17, "pièce", 2.00),
            new Producteur(8, "Favre", "Tomates", 9, "kg", 5.20),
            new Producteur(9, "Bovay", "Pommes", 13, "kg", 7.70),
            new Producteur(9, "Bovay", "Poires", 5, "kg", 3.80),
            new Producteur(9, "Bovay", "Pastèques", 20, "pièce", 2.10),
            new Producteur(9, "Bovay", "Melons", 20, "kg", 6.40),
            new Producteur(9, "Bovay", "Noix", 13, "sac", 8.80),
            new Producteur(10, "Cherix", "Raisin", 8, "kg", 7.10),
            new Producteur(10, "Cherix", "Pruneaux", 19, "kg", 7.90),
            new Producteur(10, "Cherix", "Myrtilles", 9, "kg", 4.20),
            new Producteur(10, "Cherix", "Groseilles", 10, "kg", 4.40),
            new Producteur(10, "Cherix", "Pêches", 9, "kg", 4.40),
            new Producteur(11, "Beaud", "Haricots", 19, "kg", 8.40),
            new Producteur(11, "Beaud", "Courges", 16, "pièce", 8.70),
            new Producteur(11, "Beaud", "Tomates", 18, "kg", 5.30),
            new Producteur(11, "Beaud", "Pommes", 8, "kg", 7.30),
            new Producteur(11, "Beaud", "Poires", 13, "kg", 9.20),
            new Producteur(12, "Corbaz", "Pastèques", 15, "pièce", 7.40),
            new Producteur(12, "Corbaz", "Melons", 12, "kg", 1.60),
            new Producteur(12, "Corbaz", "Noix", 11, "sac", 7.50),
            new Producteur(12, "Corbaz", "Raisin", 16, "kg", 4.50),
            new Producteur(12, "Corbaz", "Pruneaux", 20, "kg", 3.30),
            new Producteur(13, "Amaudruz", "Myrtilles", 18, "kg", 5.70),
            new Producteur(13, "Amaudruz", "Groseilles", 19, "kg", 8.00),
            new Producteur(13, "Amaudruz", "Pêches", 12, "kg", 5.50),
            new Producteur(13, "Amaudruz", "Haricots", 13, "kg", 5.20),
            new Producteur(13, "Amaudruz", "Courges", 7, "pièce", 9.60),
            new Producteur(14, "Bühlmann", "Tomates", 12, "kg", 7.70),
            new Producteur(14, "Bühlmann", "Pommes", 17, "kg", 1.90),
            new Producteur(14, "Bühlmann", "Poires", 7, "kg", 3.00),
            new Producteur(14, "Bühlmann", "Pastèques", 11, "pièce", 6.90),
            new Producteur(14, "Bühlmann", "Melons", 7, "kg", 4.70),
            new Producteur(15, "Crizzi", "Noix", 10, "sac", 1.60),
            new Producteur(15, "Crizzi", "Raisin", 17, "kg", 7.80),
            new Producteur(15, "Crizzi", "Pruneaux", 18, "kg", 9.00),
            new Producteur(15, "Crizzi", "Myrtilles", 12, "kg", 3.00),
            new Producteur(15, "Crizzi", "Groseilles", 12, "kg", 3.50)
        };
            pecheCount(producteurs);
            pastequeCount(producteurs);
            string pecheCount(List<Producteur> producteurs)
            {
                //int a = producteurs.Count(p => p.Produit == "Pêches");
                List<Producteur> pecheVendeurs = producteurs.Where(p => p.Produit == "Pêches").ToList();
                Console.WriteLine($"Il y a {pecheVendeurs.Count} vendeurs de pêches");
                return"";
            }

            string pastequeCount(List<Producteur> products) 
            { 
               /* int b = 0;
                string nom = "";
                int place = 0;

                foreach (var producteur in products)
                {
                    if(producteur.Produit == "Pastèques" && producteur.quantity > b)
                    {
                        b = producteur.quantity;
                        nom = producteur.Nom;
                        place = producteur.emplacement;
                    }
                }*/
                var pastequeVendeurs = producteurs.Where(p => p.Produit == "Pastèques" ).MaxBy(p => p.quantity);

                Console.WriteLine($"C'est {pastequeVendeurs.Nom} qui a le plus de pastèques (stand {pastequeVendeurs.emplacement}, {pastequeVendeurs.quantity} pièces)");
                return "";
            }
                    
          
        }
        
        
        
        class Producteur
        {
            public int emplacement { get; set; }

            public string Nom { get; set; }

            public string Produit { get; set; }

            public  int quantity { get; set; }

            public string Unity { get; set; }

            public double Price { get; set; }


            public Producteur(int emplacement, string Nom, string Produit, int quantity, string Unity,  double Price)
            {

                this.emplacement = emplacement;
                this.Nom = Nom;
                this.Produit = Produit;
                this.Unity = Unity;
                this.quantity = quantity;
                this.Price = Price;
            }
        }

    }
}
