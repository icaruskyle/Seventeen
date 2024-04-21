using Carat;
using System.Collections.Generic;



namespace SvtDL
{
    public class SvtCarat
    {
        List<Usercarats> CaratUser = new List<Usercarats>();

        public SvtCarat()
        {
           CreateCaratData();
        }

        private void CreateCaratData()
        {
            Usercarats caratOne = new Usercarats {username = "kyleluids", password = "123456"};
            CaratUser.Add(caratOne);

            Usercarats caratTwo = new Usercarats { username = "kea", password = "246810" };
            CaratUser.Add(caratTwo);

            Usercarats caratThree = new Usercarats { username = "elyrak", password = "3691215" };
            CaratUser.Add(caratThree);
        }
        public Usercarats GetCarat(string username, string password)
        {
            Usercarats foundCarat = new Usercarats();

            foreach (var usercarat in CaratUser)
            {
                if (username == usercarat.username && password == usercarat.password)
                {
                    foundCarat = usercarat;
                }
            }
            return foundCarat;
        }
    }

}
