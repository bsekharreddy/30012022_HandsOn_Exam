using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookRecomendationDTO;

namespace BookRecomendationDataAccessLayer
{
    //DO NOT MODIFY THE METHOD NAMES : Adding of parameters / changing the return types of the given methods may be required.
    public class BookRecomendationDAL
    {
        SqlConnection conObj;
        SqlCommand cmdObj;
        BookRecomendationContext contextObj;
        public BookRecomendationDAL()
        {
            conObj = new SqlConnection(ConfigurationManager.ConnectionStrings["BookRecomendationConnectionStr"].ConnectionString);
            contextObj = new BookRecomendationContext();
        }
        public int ConnectionToDB()
        {
            try
            {
                string sqlConStr = ConfigurationManager.ConnectionStrings["BookRecomendationConnectionStr"].ConnectionString;
                SqlConnection conObj = new SqlConnection(sqlConStr);
                conObj.Open();
                if (conObj.State.ToString() == "Open")
                    return 1;
                else
                    return -1;
            }
            catch (Exception ex)
            {
                return -99;
            }
        }




        public List<BookDTO> FetchReviewsForBook()
        {
            try
            {

                var result = (from rev in contextObj.Reviews
                              where rev.List > 1
                              select rev.ToList();
                List<BookDTO> lstReviewsFromDB = contextObj.Reviews.ToList();
                List<BookDTO> lstReviews = new List<BookDTO>();
                foreach (var rev in result)
                {
                    lstReviews.Add(new BookDTO()
                    {
                        BookNum = rev.book_isbn,
                        BookRateing = rev.rating,
                        BookReview = rev.review,
                    });
                }
                return lstReviews;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            }
          


        public void SaveReviewForBookToDB()
        {
        }

}
}
