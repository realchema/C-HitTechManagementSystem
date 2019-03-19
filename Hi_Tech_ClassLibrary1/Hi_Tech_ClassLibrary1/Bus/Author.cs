using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hi_Tech_ClassLibrary1.Bus
{
    public class Author
    {
        private int authorID;
        private string authorFName;
        private string authorLName;

        public int AuthorID
        {

            get { return authorID; }
            set { authorID = value; }


        }

        public string AuthorFName
        {

            get { return authorFName; }
            set { value = authorFName; }

        }

        public string AuthorLName
        {
            get { return authorLName; }
            set { value = authorLName; }



        }




        public Author()
        {
            authorID = 0000;
            authorFName = "";
            authorLName = "";

        }


        public Author(int authorID, string authorFName, string authorLName)

        {
            AuthorID = authorID;
            AuthorFName = authorFName;
            AuthorLName = authorLName;

        }
    }
}
