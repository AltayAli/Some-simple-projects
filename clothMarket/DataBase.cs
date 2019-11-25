using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clothMarket
{
    class DataBase
    {
        public static  cloth[] myClothes;
        public DataBase()
        {
            myClothes = new cloth[]
            {
                new cloth{name="zurna",size="x",price=50,color="red"},
                new cloth{name="zurna1",size="x",price=50,color="red"},
                new cloth{name="zurna2",size="x",price=50,color="red"},
                new cloth{name="zurna3",size="x",price=50,color="red"},
                new cloth{name="zurna4",size="x",price=50,color="red"},
                new cloth{name="zurna5",size="x",price=50,color="red"},
                new cloth{name="zurna6",size="x",price=50,color="red"},
                new cloth{name="zurna7",size="x",price=50,color="red"},
                new cloth{name="zurna8",size="x",price=50,color="red"},
                new cloth{name="zurna9",size="x",price=50,color="red"},
                new cloth{name="zurna10",size="x",price=50,color="red"},
                new cloth{name="zurna11",size="x",price=50,color="red"},
                new cloth{name="zurna12",size="x",price=50,color="red"},
                new cloth{name="zurna13",size="x",price=50,color="red"},
                new cloth{name="zurna14",size="x",price=50,color="red"},
                new cloth{name="zurna15",size="x",price=50,color="red"},
                new cloth{name="zurna16",size="x",price=50,color="red"},
                new cloth{name="zurna17",size="x",price=50,color="red"},
                new cloth{name="zurna18",size="x",price=50,color="red"},
                new cloth{name="zurna19",size="x",price=50,color="red"},
                new cloth{name="zurna20",size="x",price=50,color="red"},
                new cloth{name="zurna21",size="x",price=50,color="red"},
                new cloth{name="zurna22",size="x",price=50,color="red"},
                new cloth{name="zurna23",size="x",price=50,color="red"},
                new cloth{name="zurna24",size="x",price=50,color="red"},
                new cloth{name="zurna25",size="x",price=50,color="red"},
                new cloth{name="zurna26",size="x",price=50,color="red"},
                new cloth{name="zurna27",size="x",price=50,color="red"},
                new cloth{name="zurna28",size="x",price=50,color="red"},
                new cloth{name="zurna29",size="x",price=50,color="red"},
                new cloth{name="zurna30",size="x",price=50,color="red"},
                new cloth{name="zurna31",size="x",price=50,color="red"},
                new cloth{name="zurna32",size="x",price=50,color="red"},
                new cloth{name="zurna33",size="x",price=50,color="red"},
                new cloth{name="zurna34",size="x",price=50,color="red"},
                new cloth{name="zurna35",size="x",price=50,color="red"},
            };
        }
        public static cloth[] GetAllClothes()
        {
            return myClothes;
        }

        
    }
}
