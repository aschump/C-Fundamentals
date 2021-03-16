using Microsoft.VisualStudio.TestTools.UnitTesting;
using RepositoryPattems;
using System;
using System.Collections.Generic;

namespace StreamingContentRepositoryTest
{
    [TestClass]
    public class UnitTest1
    {
        //so we want to The Add method in the repo
        [TestMethod]
        public void AddToDirectory_ShouldIGetCorrectBoolean()
        {
            //AAA ---> Arrange, Act, Assert

            //Arrange --> overall setup
            StreamingContent content = new StreamingContent();
            StreamingContentRepository repository = new StreamingContentRepository();

            //Act---> Get/run the code to test
            bool addResult = repository.AddContentToDirectory(content);

            //Assert --> Used to get the expected outcome of a test / prebuilt class that is deisnged to do just what is stated
            Assert.IsTrue(addResult);

        }

        //testing the readmethod
        [TestMethod]
        public void GetDirectory_ShouldReturnCorrectCollect()
        {
            //AAA Rules Apply...
            //Arrange
            //creating the content
            StreamingContent content = new StreamingContent();
            
            //creating the repo
            StreamingContentRepository repo = new StreamingContentRepository();
           
            //adding to the repo(content)
            repo.AddContentToDirectory(content);

            //-------------------separate
            //Act
            //our plan is to store the list of streaming content w/in a variable
            List<StreamingContent> listOfMovies = repo.GetContents();

            //looks throuh our entire list and returns  true if ther is content
            bool directoryHasContent = listOfMovies.Contains(content);

            //Assert
            Assert.IsTrue(directoryHasContent);
        }

        //we will start with private 'fields'
        private StreamingContentRepository _repo;
        private StreamingContent _content;

        //this is the arrange part
        [TestInitialize]
        public void Arrange()
        {
            _repo = new StreamingContentRepository();
            
            //we make a new movie here fo list...FINALLY...
            _content = new StreamingContent("Rubber", "A car tire comes to life with the power to make people explode",
                                            MaturityRating.R, GenreType.Drama,5.8d);
            
            //add to repo, so now the movie is in our 'database' (list)
            _repo.AddContentToDirectory(_content);
        }

        //moretest methods
        //retrieve a single piecce of content by its titles
        [TestMethod]
        public void GetByTitle_ShouldReturnCorrectContent()
        {
            //Arrange ..Already done above
            
            //Act
            //we want searchResult to have the content inside of it (the container), _repo resides in out stremingcontent repository (line 64)
            StreamingContent searchResult = _repo.GetContentByTitle("Rubber");

            //Assert
            Assert.AreEqual(_content, searchResult);

        }

        //test the update method
        [TestMethod]
        public void UpdateExistingContent_ShouldReturnTrue()
        {
            //Act
            StreamingContent newContent = new StreamingContent("Rubber Part 2", "A car tire comes to life with the power to make people explode",
                                            MaturityRating.R, GenreType.Drama, 9.8d);
            //Act
            bool updateResult = _repo.UpdateExistingContent("Rubber", newContent);

            //Assert
            Assert.IsTrue(updateResult);


        }
        //Testing the Delete Method
        [TestMethod]
        public void DeleteExistingContent_ShouldReturnTrue()
        {
            //Arrange
            StreamingContent content = _repo.GetContentByTitle("Rubber");

            //Act
            //we are removing the content
            bool removeResult = _repo.DeleteExistingContent(content);

            //Assert
            Assert.IsTrue(removeResult);

        }
    }
}
