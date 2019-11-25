using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card_App
{
    static class DataBase
    {
        static Phone[] phones;
        static DataBase()
        {
            phones = new Phone[]{
            new Phone{
                Name="Iphone X",
                Price=200,
                url=Properties.Resources._013_ph13_big
            },
            new Phone{
                Name="Iphone 5S",
                Price=200,
                url=Card_App.Properties.Resources._013_ph13_big
            },
            new Phone{
                Name="Samsung S8",
                Price=200,
                url=Card_App.Properties.Resources._013_ph13_big
            },
            new Phone{
                Name="Samsung A10",
                Price=200,
                url=Card_App.Properties.Resources._013_ph13_big
            },
            new Phone{
                Name="LG Leon",
                Price=200,
                url=Card_App.Properties.Resources._013_ph13_big
            },
            new Phone{
                Name="IphoneX2",
                Price=200,
                url=Card_App.Properties.Resources._013_ph13_big
            },
            new Phone{
                Name="IphoneX3",
                Price=200,
                url=Card_App.Properties.Resources._013_ph13_big
            },
            new Phone{
                Name="IphoneX4",
                Price=200,
                url=Card_App.Properties.Resources._013_ph13_big
            },
            new Phone{
                Name="IphoneX6",
                Price=200,
                url=Card_App.Properties.Resources._013_ph13_big
            },
            new Phone{
                Name="IphoneX5",
                Price=200,
                url=Card_App.Properties.Resources._013_ph13_big
            },
            new Phone{
                Name="IphoneX7",
                Price=200,
                url=Card_App.Properties.Resources._013_ph13_big
            },
            new Phone{
                Name="IphoneX8",
                Price=200,
                url=Card_App.Properties.Resources._013_ph13_big
            },
            new Phone{
                Name="IphoneX9",
                Price=200,
                url=Card_App.Properties.Resources._013_ph13_big
            },
            new Phone{
                Name="IphoneX10",
                Price=200,
                url=Card_App.Properties.Resources._013_ph13_big
            },
            new Phone{
                Name="IphoneX11",
                Price=200,
                url=Card_App.Properties.Resources._013_ph13_big
            },
            new Phone{
                Name="IphoneX12",
                Price=200,
                url=Card_App.Properties.Resources._013_ph13_big
            },
            new Phone{
                Name="IphoneX13",
                Price=200,
                url=Card_App.Properties.Resources._013_ph13_big
            },
            new Phone{
                Name="IphoneX14",
                Price=200,
                url=Card_App.Properties.Resources._013_ph13_big
            },
            new Phone{
                Name="IphoneX15",
                Price=200,
                url=Card_App.Properties.Resources._013_ph13_big
            },
            new Phone{
                Name="Zurna",
                Price=200,
                url=Card_App.Properties.Resources._013_ph13_big
            },


            };
        }

        public static  Phone[] GetDatas()
        {
            return phones;
        }
    }
}
