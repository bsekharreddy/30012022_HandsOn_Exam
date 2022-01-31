using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookRecomendationDataAccessLayer;
using BookRecomendationDTO;

namespace BookRecomendationBusinessLayer
{
    //DO NOT MODIFY THE METHOD NAMES : Adding of parameters / changing the return types of the given methods may be required. 
    public class BookRemendationDAL
    {
        BookRecomendationDAL dalObj;
        public BookRemendationDAL()
        {
            dalObj = new BookRecomendationDAL();
        }
        public int ConnectToDB()
        {
            try
            {
                BookRecomendationDAL dalObj = new BookRecomendationDAL();
                return dalObj.ConnectionToDB();
            }
            catch (Exception ex)
            {
                return -89;
            }
        }

        public void ShowReviewsForBook()
        {
            BookRecomendationDAL balobj = new BookRecomendationDAL();
            dalObj.ConnectionToDB();




        }


        public void AddReviewForBook()
        {
          
        }
      
    }
}
