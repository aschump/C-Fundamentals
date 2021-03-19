using RepositoryPattems;
using StreamingContent_Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingContent_Console
{
    public class ProgramUI
    {
        private readonly StreamingRepository _streamingRepo = new StreamingRepository();
        public void Run()
        {
            //coding with intent
            //we know we will have these methods created by the time we're done
            SeedContentList();
            RunMenu();
        }

        private void RunMenu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();
                //\n is new line
                Console.WriteLine("Enter the number of the option you would like to select:\n" +
                    "1: Show all streaming content\n" +
                    "2: Find streaming content by title\n" +
                    "3: Add new streaming content\n" +
                    "4: Remove streaming content\n" +
                    "5: Exit");
                
                //will give user chance to input their choice
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        ShowAllContent();
                        break;
                    case "2":
                        ShowContentByTitle();
                        break;
                    case "3":
                        CreateNewContent();
                        break;
                    case "4":
                        RemoveContentFromList();
                        break;
                    case "5":
                        continueToRun = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number beween 1 and 5\n" +
                            "Press any key to continue...................");
                        Console.ReadKey();
                        break;
                }
            }
        }
        //start creating our new methods
        private void CreateNewContent()
        {
            Console.Clear();
            //Instantiation: instantiating new streamingcontent aka "NewUp" an instance of
            //metaphorically speaking, we are grabbing cookie cutter we made and are about to make a cookie with it 
            StreamingContent content = new StreamingContent();

            Console.WriteLine("Welcome to your Streaming Content Craeter Page !!");
            Console.WriteLine("Please enter a title");
            //taking in user input and setting it to content.Title
            content.Title = Console.ReadLine();

            Console.WriteLine("Please enter a decsription:");
            content.Description = Console.ReadLine();

            //bc readlines come out as strings we need to convert for StarRating
            //ways to convert the string ReadLine
            //Convert.ToDouble(Console.ReadLine());
            //double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a star rating (1-5):");
            content.StarRating = double.Parse(Console.ReadLine());

            //one way to process through enum
            Console.WriteLine("Select a Maturity Rating:/n" +
            "1:G\n" +
            "2:PG\n" +
            "3:PG_13\n" +
            "4:R\n" +
            "5:TV_Y\n" +
            "6:TV_G" +
            "7:TV_PG\n" +
            "8:TV_14\n" +
            "9:NC_17\n" +
            "10:TV_MA\n");
            string maturityRating = Console.ReadLine();

            switch (maturityRating)
            {
                case "1":
                    content.MaturityRating = MaturityRating.G;
                    break;
                case "2":
                    content.MaturityRating = MaturityRating.PG;
                    break;
                case "3":
                    content.MaturityRating = MaturityRating.PG_13;
                    break;
                case "4":
                    content.MaturityRating = MaturityRating.R;
                    break;
                case "5":
                    content.MaturityRating = MaturityRating.TV_Y;
                    break;
                case "6":
                    content.MaturityRating = MaturityRating.TV_G;
                    break;
                case "7":
                    content.MaturityRating = MaturityRating.TV_PG;
                    break;
                case "8":
                    content.MaturityRating = MaturityRating.TV_14;
                    break;
                case "9":
                    content.MaturityRating = MaturityRating.NC_17;
                    break;
                case "10":
                    content.MaturityRating = MaturityRating.TV_MA;
                    break;

            }
            //another way to show how to process through enums
            Console.WriteLine("Select a Genre Type: please select a number between 1 and 7\n" +
                "1:Horror\n" +
                "2:RomCom\n" +
                "3:SciFi\n" +
                "4:Documentary\n" +
                "5:Bromance\n" +
                "6:Drama\n" +
                "7:Action");
            string genreInput = Console.ReadLine();
            
            int genreID = int.Parse(genreInput);

            content.GenreType = (GenreType)genreID;

            //adding content to our directory
            _streamingRepo.AddContentToDirectory(content);
        }
        private void ShowAllContent()
        {
            Console.Clear();

            List<StreamingContent> listOfContent = _streamingRepo.GetContent();
            foreach (StreamingContent content in listOfContent)
            {
                DisplayContent(content);
            }
            Console.WriteLine("Press any key to continue............");
            Console.ReadKey();
        }

        private void ShowContentByTitle()
        {
            Console.Clear();
            Console.WriteLine("Please enter a Title:");
            string title = Console.ReadLine();
            StreamingContent content = _streamingRepo.GetContentByTitle(title);
            if(content != null)
            {
                DisplayContent(content);
            }
            else
            {
                Console.WriteLine($"Invalid Title. Could not find results for {title}");
            }
            Console.WriteLine("Press any key to continue.........");
            Console.ReadLine();
        }
        private void RemoveContentFromList()
        {
            //will display everything in the list
            Console.WriteLine("Which item would you like to remove?");
            //pulling information one by one and giving it a number 
            List<StreamingContent> contentList = _streamingRepo.GetContent();
            int count = 0;
            foreach (StreamingContent content in contentList)
            {
                //for every time it goes through and pulls content its going to add a count
                count++;
                Console.WriteLine($"{count}. {content.Title}");
            }
            int targetContentID = int.Parse(Console.ReadLine());
            int targetIndex = targetContentID - 1;

            if(targetIndex >= 0 && targetIndex < contentList.Count)
            {
                // if referencing index value then use [ ]
                StreamingContent desiredContent = contentList[targetIndex];
                //applying deletexistingcontent method 
                if (_streamingRepo.DeleteExistingContent(desiredContent))
                {
                    Console.WriteLine($"{desiredContent.Title} was successfully removed.");
                }
                else
                {
                    Console.WriteLine("I'm sorry, Dave. I'm afraid I can't do that.");
                }
            }
            else
            {
                Console.WriteLine("No content has that ID.");
            }
            Console.WriteLine("Press any key to continue......");
            Console.ReadKey();
        }


        //Helper Method that has all of our Info
        private void DisplayContent(StreamingContent content)
        {
                Console.WriteLine($"Title: {content.Title}\n" +
                    $"Description: {content.Description}\n" +
                    $"Star Rating: {content.StarRating}\n" +
                    $"Maturity Rating: {content.MaturityRating}\n" +
                    $"Is Family Friendly: {content.IsFamilyFriendly}\n" +
                    $"Genre: {content.GenreType}");

        }
        //content for the program
        private void SeedContentList()
        {
            StreamingContent rubber = new StreamingContent("Rubber", "Tire comes to life and kills people", MaturityRating.R, GenreType.Drama, 5.8d);
            StreamingContent toystory = new StreamingContent("Toy Story", "Best childhood", MaturityRating.G, GenreType.Bromance, 10.0d);
            StreamingContent starwars = new StreamingContent("Star Wars", "Jar Jar saves that world", MaturityRating.PG_13, GenreType.SciFi, 9.2);

            _streamingRepo.AddContentToDirectory(rubber);
            _streamingRepo.AddContentToDirectory(toystory);
            _streamingRepo.AddContentToDirectory(starwars);
        }
    }
}
