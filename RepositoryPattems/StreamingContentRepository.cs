using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattems
{
    public class StreamingContentRepository
    {
        //will prevent user from changing and read only
        protected readonly List<StreamingContent> _contentDirectory = new List<StreamingContent>();
        
        // create methods
        //1.create
        public bool AddContentToDirectory(StreamingContent content)
        {
            //starting/intitiating to count the content directory
            //here we are declaring and intiliazing using the .Count to count what is in _contentDirectory
            int startingCount = _contentDirectory.Count;

            //adding content to the directory
            _contentDirectory.Add(content);

            //terenary, using to check if content was added to directory
            //is it greater than what it started out as?
            bool wasAdded = (_contentDirectory.Count > startingCount) ? true : false;
            return wasAdded;

        }
        //get contents of list
        //2.Read
        public List<StreamingContent> GetContents()
        {
            return _contentDirectory;
        }
        //pull by the title from other class
        //3. read --> helper method b/c used throughout this repo
        public StreamingContent GetContentByTitle(string title)
        {
            foreach(StreamingContent content in _contentDirectory)
            {
                if(content.Title.ToLower() == title.ToLower())
                {
                    return content;
                }
            }
            //not best practice, professionally speaking. 
            //Try to always return some type of value 
            return null;
        }

        //Practice Challenge
        public StreamingContent GetContentByStarRating(double starRating)
        {
            foreach(StreamingContent content in _contentDirectory)
            {
                if (content.StarRating  == starRating)
                {
                    return content;
                }
            }
            return null;
        }

        public StreamingContent GetContentByGenreType(GenreType genreType)
        {            
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.GenreType == genreType)
                {
                    return content;
                }
            }
            return null;
        }

        public StreamingContent GetContentByMaturityRating(MaturityRating maturityRating)
        {
            //trying to make a list of content for the specified by user
            //List<StreamingContent> MaturityList = new List<StreamingContent>();

            foreach (StreamingContent content in _contentDirectory)
            {
                if(content.MaturityRating == maturityRating)
                {
                    return content;
                }
            }
            //help
            //MaturityList.Add(content.);
            return null;
            ///List code help from Michael Steele, breakout room
            //public StreamingContent GetContentByMaturityRating(MaturityRating maturityRating)
            //{
            //    List<StreamingContent> listOfContent = new List<StreamingContent>();
            //    foreach (StreamingContent content in listOfContent)
            //    {
            //        if (content.MaturityRating == maturityRating)
            //        {
            //            listOfContent.Add(content);
            //            return content;
            //        }
            //    }
            //    return null;

            //}
            //note: that's top to bottom for the maturity rating


        }
        //End Practice Challenge


        //to let some update if they input wrong
        //4. Update
        public bool UpdateExistingContent(string originalTitle, StreamingContent newContent)
        {
            //start method by getting all info attached to specific Title and set to old content
            StreamingContent oldContent = GetContentByTitle(originalTitle);
            //update content
            if (oldContent != null)
            {
                //put in same order as it originally is !
                //Here we are using GetContentByTitle to take the originalTile and set it to oldContent
                //then we changed oldContent to newContent
                oldContent.Title = newContent.Title;
                oldContent.Description = newContent.Description;
                oldContent.MaturityRating = newContent.MaturityRating;
                oldContent.GenreType = newContent.GenreType;
                oldContent.StarRating = newContent.StarRating;

                return true;
            }
            else
            {
                return false;
            }
        }
        //if someone enters something wrong and just wants it gone, we'll ake this
        //so it can be deleted
        //5.Delete
        public bool DeleteExistingContent(StreamingContent existingContent)
        {
            bool deleteResult = _contentDirectory.Remove(existingContent);
            return deleteResult;
        }

    }
}
