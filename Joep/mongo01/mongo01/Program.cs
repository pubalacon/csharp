using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Bson;
/*
 *  https://codelp.com/create-a-crud-repository-using-mongodb-and-c/
 *  
 */

namespace mongo01
{
    class Program
    {
        static async void EnterInfos(User newUser, UsersRepository repo)
        {
            Console.Write("User Name: ");
            newUser.Name = Console.ReadLine();
            Console.Write("User Blog: ");
            newUser.Blog = Console.ReadLine();
            Console.Write("User Age: ");
            newUser.Age = Convert.ToInt32(Console.ReadLine());
            Console.Write("User Location: ");
            newUser.Location = Console.ReadLine();

            await repo.InsertUser(newUser);

        }

        static async void ShowListe(List<User> ListeUsers, UsersRepository repo)
        {
            ListeUsers = await repo.GetAllUsers();

            foreach (User item in ListeUsers)
            {
                Console.WriteLine($"User #{ item.Id} -> {item.Name} \"{item.Blog}\" {item.Age} {item.Location}");
            }

        }
        static async void UpdateInfos(User newUser, UsersRepository repo)
        {
            ObjectId existingId;

            Console.Write("User Id to modify: ");
            ObjectId.TryParse(Console.ReadLine(), out existingId);

            /*
             * test s'il existe
             */
            if (repo.UserExists(existingId) > 0)
            {
                Console.Write("User Name: ");
                newUser.Name = Console.ReadLine();
                Console.Write("User Blog: ");
                newUser.Blog = Console.ReadLine();
                Console.Write("User Age: ");
                newUser.Age = Convert.ToInt32(Console.ReadLine());
                Console.Write("User Location: ");
                newUser.Location = Console.ReadLine();

                await repo.UpdateUser(existingId, "Name", newUser.Name);
                await repo.UpdateUser(existingId, "Blog", newUser.Blog);
                await repo.UpdateUser(existingId, "Age", newUser.Age.ToString());
                await repo.UpdateUser(existingId, "Location", newUser.Location);

                return;
            }

            Console.WriteLine("L'ID demandée n'existe pas...");

        }
        static async void DeleteInfos(User newUser, UsersRepository repo)
        {
            ObjectId existingId;

            Console.Write("User Id to delete: ");
            ObjectId.TryParse(Console.ReadLine(), out existingId);

            /*
             * test s'il existe
             */
            if (repo.UserExists(existingId) > 0)
            {
                await repo.DeleteUserById(existingId);
                return;
            }

            Console.WriteLine("L'ID demandée n'existe pas...");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("CRUD(ing) with MongoDB");

            User myUser = new User();
            UsersRepository repo = new UsersRepository("blog", "users");
            List<User> ListeUsers = new List<User>();
            int choix = 0;

            Console.WriteLine("1 - Lister les utilisateurs");
            Console.WriteLine("2 - Créer un utilisateur");
            Console.WriteLine("3 - Modifier un utilisateur");
            Console.WriteLine("4 - Supprimer un utilisateur");
            Console.Write("Votre choix: ");
            choix = Convert.ToInt32(Console.ReadLine());

            switch(choix)
            {
                case 1:
                    ShowListe(ListeUsers, repo);
                    break;

                case 2:
                    EnterInfos(myUser, repo);
                    break;

                case 3:
                    UpdateInfos(myUser, repo);
                    break;

                case 4:
                    DeleteInfos(myUser, repo);
                    break;

                default:
                    break;
            }

            Console.Write("Valider pour continuer..."); Console.ReadKey();

        }
    }
}
