using Hi_Tech_ClassLibrary1.Bus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hi_Tech_ClassLibrary1
{
    


        public enum EnumCatofBooks
        {
            Undefined, Classics, Bestsellers, History, Culture, Art, Biography, Science,
            Languajes, Health, Philosophy, Literature, Politics, Religion, Romance,
            Music, Others
        }

        public enum EnumCatofSoftware { Undefined, Productivity, Games, Education, Finance, Music, Photo, Video }
        public class Product : Author
        {

            private int iSBN;

            private string title;

            private double unitprice;

            private int yearpublished;

            private int qOH;

            private EnumCatofSoftware catofS;

            private EnumCatofBooks catofB;

            public EnumCatofBooks CatofB
            {
                get { return catofB; }
                set { value = catofB; }

            }



            public int ISBN
            {
                get { return iSBN; }

                set { iSBN = value; }

            }

            public string Title
            {
                get { return title; }
                set { title = value; }

            }

            public double Unitprice
            {

                get { return unitprice; }
                set { unitprice = value; }



            }

            public int Yearpublished
            {

                get { return yearpublished; }
                set { yearpublished = value; }

            }

            public int QOH
            {

                get { return qOH; }
                set { qOH = value; }


            }

            public EnumCatofSoftware CatofS
            {
                get
                {
                    return catofS;
                }

                set
                {
                    catofS = value;
                }
            }

            public Product()
            {

                iSBN = 00;
                title = "";
                unitprice = 00;
                yearpublished = 0000;
                qOH = 0000;
                catofB = EnumCatofBooks.Undefined;
                catofS = EnumCatofSoftware.Undefined;

            }


            public Product(int iSBN, string title, double unitprice, int yearpublished, int qOH,
                        EnumCatofBooks catofB, int authorid, string authorfn, string authorln)
                        : base(authorid, authorfn, authorln)

            {
                ISBN = iSBN;
                Title = title;
                Unitprice = unitprice;
                Yearpublished = yearpublished;
                QOH = qOH;
                CatofB = catofB;
            }


        }
    }
