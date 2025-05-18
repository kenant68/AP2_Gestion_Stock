using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using MySql.Data.MySqlClient;  

namespace DAL
{
    public class Bdd
    {
        public static MySqlConnection c;

        public static MySqlConnection GetConnection()
        {
            return c;
        }

        //accès à la bdd
        public static bool ouvrirConnexion()
        {
            c = new MySqlConnection();
            c.ConnectionString = "server=localhost;user id=root;database=bd_stock_tekbas";
            //c.ConnectionString = "Data Source=SRV-SQL\\SQL_SLAM;Initial Catalog=BD_STOCK_TEKBAS; Integrated Security = SSPI";

            try
            {
                c.Open();
                return true;
            }
            catch (Exception ex) { return false; }
        }

        //fonction appelée avec un messagebox pour vérifier la connexion
        public static string afficherConnexion()
        {
            if (ouvrirConnexion())
            {
                return "Connexion réussie à la base de données : " + c.DataSource + "-->" + c.Database + "Etat = " + c.State;
            }
            else
            {
                return "Echec de la connexion à la base de données ";
            }
        }

        

        //récupération des fabricants
        public static List<Fabricant> GetFabricants()
        {
            List<Fabricant> res = new List<Fabricant>();
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader dr;
            cmd.Connection = c;
            cmd.CommandText = "select * from Fabricants";

            try
            {
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Fabricant m = new Fabricant(dr.GetString(0), dr.GetString(1), dr.GetString(2));
                    res.Add(m);
                }
                dr.Close();
                return res;
            }
            catch
            {
                return null;
            }
        }

        public static bool supprimerFabricant(string marque)
        {
            MySqlCommand cmd = new MySqlCommand("DELETE FROM Fabricants WHERE Marque = @marque", c);
            cmd.Parameters.AddWithValue("@marque", marque);

            try
            {
                int rows = cmd.ExecuteNonQuery();
                return rows > 0;
            }
            catch
            {
                return false;
            }
        }

        public static void mettreAJourFabricant(Fabricant fabricant, string newId, string newEntreprise, string newMarque)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = c;

            cmd.CommandText = @"
            UPDATE Fabricants
            SET IdFabricant = @newId,
                NomEntreprise = @newEntreprise,
                Marque = @newMarque
            WHERE IdFabricant = @oldId";

            cmd.Parameters.AddWithValue("@newId", newId);
            cmd.Parameters.AddWithValue("@newEntreprise", newEntreprise);
            cmd.Parameters.AddWithValue("@newMarque", newMarque);
            cmd.Parameters.AddWithValue("@oldId", fabricant.IdFabricant);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch { }
        }

        public static bool ajouterFabricant(Fabricant fabricant)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = c;

            cmd.CommandText = @"INSERT INTO Fabricants (IdFabricant, NomEntreprise, Marque) 
                        VALUES (@id, @entreprise, @marque)";

            cmd.Parameters.AddWithValue("@id", fabricant.IdFabricant);
            cmd.Parameters.AddWithValue("@entreprise", fabricant.NomEntreprise);
            cmd.Parameters.AddWithValue("@marque", fabricant.Marque);

            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //récupération des catégories
        public static List<Categorie> GetCategories() {
            List<Categorie> res = new List<Categorie>();
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader dr;
            cmd.Connection = c;
            cmd.CommandText = "select * from Categories";

            try
            {
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Categorie m = new Categorie(dr.GetString(0), dr.GetString(1));
                    res.Add(m);
                }
                dr.Close();
                return res;
            }
            catch
            {
                return null;
            }

        }

        //fonction pour supprimer une catégorie
        public static bool supprimerCategorie(string nom)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = c;
            cmd.CommandText = "DELETE FROM Categories WHERE Libelle = @nom";
            cmd.Parameters.AddWithValue("@nom", nom);

            try
            {
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch
            {
                return false;
            }
        }


        //fonction pour mettre à jour une catégorie
        public static void mettreAJourCategorie(Categorie categorie, string codeCategorie, string nouveauLibelle)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = c;

            cmd.CommandText = @"
                UPDATE Categories
                SET CodeCategorie = @codeCategorie,
                    Libelle = @libelle
                WHERE CodeCategorie = @oldCodeCategorie";

            cmd.Parameters.AddWithValue("@codeCategorie", codeCategorie);
            cmd.Parameters.AddWithValue("@libelle", nouveauLibelle);
            cmd.Parameters.AddWithValue("@oldCodeCategorie", categorie.CodeCategorie);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
        }


        //fonction pour ajouter une catégorie
        public static bool ajouterCategorie(Categorie categorie)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = c;

            cmd.CommandText = @"INSERT INTO Categories 
                        (CodeCategorie, Libelle) 
                        VALUES 
                        (@codeCategorie, @libelle)";

            cmd.Parameters.AddWithValue("@codeCategorie", categorie.CodeCategorie);
            cmd.Parameters.AddWithValue("@libelle", categorie.Libelle);

            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //récupération des dépots
        public static List<Depot> GetDepots()
        {
            List<Depot> res = new List<Depot>();
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader dr;
            cmd.Connection = c;
            cmd.CommandText = "select * from Depots";

            try
            {
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Depot m = new Depot(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetFloat(4), dr.GetFloat(5));
                    res.Add(m);
                }
                dr.Close();
                return res;
            }
            catch
            {
                return null;
            }

        }

        public static bool supprimerDepot(string nom)
        {
            MySqlCommand cmd = new MySqlCommand("DELETE FROM Depots WHERE Nom = @nom", c);
            cmd.Parameters.AddWithValue("@nom", nom);

            try
            {
                int rows = cmd.ExecuteNonQuery();
                return rows > 0;
            }
            catch
            {
                return false;
            }
        }

        public static bool mettreAJourDepot(Depot depot, int numero, string nom, string ville, string pays, float lat, float lon)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = c;

            cmd.CommandText = @"
                            UPDATE Depots
                            SET NumeroDepot = @numero, Nom = @nom,
                                Ville = @ville, Pays = @pays,
                                Latitude = @lat, Longitude = @lon
                            WHERE NumeroDepot = @oldNumero";

            cmd.Parameters.AddWithValue("@numero", numero);
            cmd.Parameters.AddWithValue("@nom", nom);
            cmd.Parameters.AddWithValue("@ville", ville);
            cmd.Parameters.AddWithValue("@pays", pays);
            cmd.Parameters.AddWithValue("@lat", lat);
            cmd.Parameters.AddWithValue("@lon", lon);
            cmd.Parameters.AddWithValue("@oldNumero", depot.NumeroDepot);

            try
            {
                int rows = cmd.ExecuteNonQuery();
                return rows > 0;
            }
            catch (Exception ex)
            {
                
                return false;
            }
        }


        public static bool ajouterDepot(Depot depot)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = c;

            cmd.CommandText = @"INSERT INTO Depots (NumeroDepot, Nom, Ville, Pays, Latitude, Longitude)
                        VALUES (@numero, @nom, @ville, @pays, @lat, @lon)";

            cmd.Parameters.AddWithValue("@numero", depot.NumeroDepot);
            cmd.Parameters.AddWithValue("@nom", depot.Nom);
            cmd.Parameters.AddWithValue("@ville", depot.Ville);
            cmd.Parameters.AddWithValue("@pays", depot.Pays);
            cmd.Parameters.AddWithValue("@lat", depot.Latitude);
            cmd.Parameters.AddWithValue("@lon", depot.Longitude);

            try
            {
                int rows = cmd.ExecuteNonQuery();
                return rows > 0;
            }
            catch (Exception ex)
            {
                
                return false;
            }
        }


        //récupération des dépots selon le pays
        public static List<Depot> GetDepotsSelonPays(string pays)
        {
            List<Depot> res = new List<Depot>();
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader dr;
            cmd.Connection = c;
            cmd.CommandText = "SELECT * FROM Depots WHERE Pays = @pays";
            cmd.Parameters.AddWithValue("@pays", pays);
            try
            {
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Depot m = new Depot(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetFloat(4), dr.GetFloat(5));
                    res.Add(m);
                }
                dr.Close();
                return res;
            }
            catch
            {
                return null;
            }
        }


        //récupération des unités
        public static List<Unite> GetUnite()
        {
            List<Unite> res = new List<Unite>();
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader dr;
            cmd.Connection = c;
            cmd.CommandText = "select * from unites";

            try
            {
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Unite m = new Unite(dr.GetString(0), dr.GetString(1));
                    res.Add(m);
                }
                dr.Close();
                return res;
            }
            catch
            {
                return null;
            }

        }

        public static bool supprimerUnite(string libelle)
        {
            MySqlCommand cmd = new MySqlCommand("DELETE FROM Unites WHERE Libelle = @libelle", c);
            cmd.Parameters.AddWithValue("@libelle", libelle);

            try
            {
                int rows = cmd.ExecuteNonQuery();
                return rows > 0;
            }
            catch
            {
                return false;
            }
        }

        public static void mettreAJourUnite(Unite unite, string newCode, string newLibelle)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = c;

            cmd.CommandText = @"
            UPDATE Unites
            SET CodeUnite = @newCode,
                Libelle = @newLibelle
            WHERE CodeUnite = @oldCode";

            cmd.Parameters.AddWithValue("@newCode", newCode);
            cmd.Parameters.AddWithValue("@newLibelle", newLibelle);
            cmd.Parameters.AddWithValue("@oldCode", unite.CodeUnite);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch { }
        }

        public static bool ajouterUnite(Unite unite)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = c;

            cmd.CommandText = @"INSERT INTO Unites (CodeUnite, Libelle) 
                        VALUES (@code, @libelle)";

            cmd.Parameters.AddWithValue("@code", unite.CodeUnite);
            cmd.Parameters.AddWithValue("@libelle", unite.Libelle);

            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //récupération des articles avec détails pour le datagridview du form1
        public static List<ArticleAffichage> GetArticlesAvecDetails()
        {
            List<ArticleAffichage> res = new List<ArticleAffichage>();
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader dr;

            cmd.Connection = c; 
            cmd.CommandText = @"
                SELECT 
                    a.ReferenceArticle,
                    a.Libelle,
                    c.Libelle AS Categorie,
                    f.Marque AS Fabricant,
                    u.Libelle AS Unites
                FROM Articles a
                JOIN Categories c ON a.CodeCategorie = c.CodeCategorie
                JOIN Fabricants f ON a.IdFabricant = f.IdFabricant
                JOIN Unites u ON a.CodeUnite = u.CodeUnite;

            ";

            try
            {
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ArticleAffichage articles = new ArticleAffichage
                    (
                        dr.GetString(0),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetString(3),
                        dr.GetString(4)
                        //dr.GetString(5)
                    );
                    res.Add(articles);
                }
                dr.Close();
                return res;
            }
            catch
            {
                return null;
            }
        }


        //requête pour récupérer le stock d'un article donné
        public static List<Stock> GetStock(string reference)
        {
            List<Stock> result = new List<Stock>();

            string query = @"
                SELECT
                    ds.ReferenceArticle,
                    ds.NumeroDepot,
                    SUM(ms.Qte) AS Quantite,
                    MAX(ms.DateHeureMouvement) AS DateHeureMouvement,  -- Supposons que tu veux aussi la dernière date de mouvement
                    'INV' AS Type  -- Ici on suppose que le type est toujours 'INV', mais tu peux l'adapter
                FROM (
                    SELECT
                        ReferenceArticle,
                        NumeroDepot,
                        MAX(DateHeureMouvement) AS DerniereDate
                    FROM MouvementStock
                    WHERE Type = 'INV'
                    GROUP BY ReferenceArticle, NumeroDepot
                ) ds
                JOIN MouvementStock ms
                    ON ms.ReferenceArticle = ds.ReferenceArticle
                    AND ms.NumeroDepot = ds.NumeroDepot
                    AND ms.DateHeureMouvement >= ds.DerniereDate
                WHERE ds.ReferenceArticle = @reference
                GROUP BY ds.ReferenceArticle, ds.NumeroDepot
                ";

            try
            {
                MySqlCommand cmd = new MySqlCommand(query, c);
                cmd.Parameters.AddWithValue("@reference", reference);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    result.Add(new Stock(
                        reader["ReferenceArticle"].ToString(),
                        Convert.ToInt32(reader["NumeroDepot"]),
                        Convert.ToDateTime(reader["DateHeureMouvement"]),
                        reader["Type"].ToString(),  
                        Convert.ToInt32(reader["Quantite"])
                    ));
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                
                return null;
            }

            return result;
        }

        //récupération des articles
        public static List<Article> GetArticles()
        {
            List<Article> res = new List<Article>();
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader dr;
            cmd.Connection = c;
            cmd.CommandText = "select * from Articles";

            try
            {
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Article m = new Article(dr.GetString(0), dr.GetString(1));
                    res.Add(m);
                }
                dr.Close();
                return res;
            }
            catch
            {
                return null;
            }
        }


        //fonction pour ajouter un article
        public static bool ajouterArticle(Article newArticle, string codeCategorie, string idFabricant, string codeUnite)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = c;

            cmd.CommandText = @"INSERT INTO Articles 
                        (ReferenceArticle, Libelle, CodeCategorie, IdFabricant, CodeUnite) 
                        VALUES 
                        (@reference, @libelle, @categorie, @fabricant, @unite)";
            cmd.Parameters.AddWithValue("@reference", newArticle.ReferenceArticle);
            cmd.Parameters.AddWithValue("@libelle", newArticle.Libelle);
            cmd.Parameters.AddWithValue("@categorie", codeCategorie);
            cmd.Parameters.AddWithValue("@fabricant", idFabricant);
            cmd.Parameters.AddWithValue("@unite", codeUnite);

            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }


        //fonction pour supprimer un article
        public static bool supprimerArticle(string reference)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = c;

            cmd.CommandText = "DELETE FROM Articles WHERE ReferenceArticle = @reference";
            cmd.Parameters.AddWithValue("@reference", reference);

            try
            {
                cmd.ExecuteNonQuery(); 
                return true;
            }
            catch
            {
                return false;
            }
        }

        //fonction pour mettre à jour un article
        public static void mettreAJourArticle(Article article, string codeCategorie, string idFabricant, string codeUnite)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = c;

            cmd.CommandText = @"
                                UPDATE Articles
                                SET Libelle = @libelle,
                                    CodeCategorie = @codeCategorie,
                                    IdFabricant = @idFabricant,
                                    CodeUnite = @codeUnite
                                WHERE ReferenceArticle = @reference";

            cmd.Parameters.AddWithValue("@libelle", article.Libelle);
            cmd.Parameters.AddWithValue("@codeCategorie", codeCategorie);
            cmd.Parameters.AddWithValue("@idFabricant", idFabricant);
            cmd.Parameters.AddWithValue("@codeUnite", codeUnite);
            cmd.Parameters.AddWithValue("@reference", article.ReferenceArticle);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
               
            }
        }




        public static List<ArticleAffichage> GetArticlesSelonDepot(string selectedDepot)
        {
            List<ArticleAffichage> result = new List<ArticleAffichage>();

            string query = @"
                        SELECT 
                            DISTINCT a.ReferenceArticle,
                            a.Libelle,
                            c.Libelle AS Categorie,
                            f.Marque AS Fabricant,
                            u.Libelle AS Unites
                        FROM Articles a
                        JOIN mouvementsstock ms ON a.ReferenceArticle = ms.ReferenceArticle
                        JOIN Categories c ON a.CodeCategorie = c.CodeCategorie
                        JOIN Fabricants f ON a.IdFabricant = f.IdFabricant
                        JOIN Unites u ON a.CodeUnite = u.CodeUnite
                        JOIN Depots d ON ms.NumeroDepot = d.NumeroDepot
                        WHERE d.Nom = @depot



                    ";

            using (MySqlCommand cmd = new MySqlCommand(query, c))
            {
                cmd.Parameters.AddWithValue("@depot", selectedDepot);



                try
                {
                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            result.Add(new ArticleAffichage(
                                dr.GetString(0),
                                dr.GetString(1),
                                dr.GetString(2),
                                dr.GetString(3),
                                dr.GetString(4)
                            ));
                        }
                    }
                }
                catch (Exception ex)
                {
                    
                    return new List<ArticleAffichage>(); 
                }
            }

            return result;
        }


        public static List<Stock> GetTousLesMouvements()
        {
            List<Stock> mouvements = new List<Stock>();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM MouvementsStock", c);

            try
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string reference = reader["ReferenceArticle"].ToString();
                        int depot = Convert.ToInt32(reader["NumeroDepot"]);
                        DateTime date = Convert.ToDateTime(reader["DateHeureMouvement"]);
                        string type = reader["Type"].ToString();
                        int quantite = int.Parse(reader["Quantite"].ToString());

                        mouvements.Add(new Stock(reference, depot, date, type, quantite));
                    }
                }
                return mouvements;
            }
            catch
            {
                return null;
            }
        }


        // Ajouter un mouvement de stock
        public static bool AjouterMouvementStock(Stock mouvement)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.Connection = c;
                cmd.CommandText = @"INSERT INTO MouvementsStock 
                            (ReferenceArticle, NumeroDepot, DateHeureMouvement, Type, Quantite)
                            VALUES 
                            (@reference, @depot, @date, @type, @quantite)";

                cmd.Parameters.AddWithValue("@reference", mouvement.ReferenceArticle);
                cmd.Parameters.AddWithValue("@depot", mouvement.NumeroDepot);
                cmd.Parameters.AddWithValue("@date", mouvement.DateHeureMouvement);
                cmd.Parameters.AddWithValue("@type", mouvement.Type);
                cmd.Parameters.AddWithValue("@quantite", mouvement.Quantite);

                try
                {
                    if (c.State != ConnectionState.Open)
                        c.Open();

                    return cmd.ExecuteNonQuery() > 0;
                }
                catch
                {
                    return false;
                }
                finally
                {
                    c.Close();
                }
            }
        }


        // Supprimer un mouvement de stock (en se basant sur tous les champs clés)
        public static bool SupprimerMouvementStock(Stock mouvement)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.Connection = c;
                cmd.CommandText = @"DELETE FROM MouvementsStock 
                            WHERE ReferenceArticle = @reference 
                            AND NumeroDepot = @depot 
                            AND DateHeureMouvement = @date 
                            AND Type = @type";

                cmd.Parameters.AddWithValue("@reference", mouvement.ReferenceArticle);
                cmd.Parameters.AddWithValue("@depot", mouvement.NumeroDepot);
                cmd.Parameters.AddWithValue("@date", mouvement.DateHeureMouvement);
                cmd.Parameters.AddWithValue("@type", mouvement.Type);

                try
                {
                    if (c.State != ConnectionState.Open)
                        c.Open();

                    return cmd.ExecuteNonQuery() > 0;
                }
                catch
                {
                    return false;
                }
                finally
                {
                    c.Close();
                }
            }
        }


        // Mettre à jour un mouvement de stock
        public static bool MettreAJourMouvementStock(Stock mouvement)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.Connection = c;
                cmd.CommandText = @"UPDATE MouvementsStock 
                            SET Quantite = @quantite 
                            WHERE ReferenceArticle = @reference 
                            AND NumeroDepot = @depot 
                            AND DateHeureMouvement = @date 
                            AND Type = @type";

                cmd.Parameters.AddWithValue("@quantite", mouvement.Quantite);
                cmd.Parameters.AddWithValue("@reference", mouvement.ReferenceArticle);
                cmd.Parameters.AddWithValue("@depot", mouvement.NumeroDepot);
                cmd.Parameters.AddWithValue("@date", mouvement.DateHeureMouvement);
                cmd.Parameters.AddWithValue("@type", mouvement.Type);

                try
                {
                    if (c.State != ConnectionState.Open)
                        c.Open();

                    return cmd.ExecuteNonQuery() > 0;
                }
                catch
                {
                    return false;
                }
                finally
                {
                    c.Close();
                }
            }
        }

    }



}

