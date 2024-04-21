


using Carat;
using SvtDL;
using System.Collections.Generic;

namespace SvtBL
{
    public class CaratVerification
    {
        public bool VerifyCarat(string username, string password)
        {
            SvtCarat usercarat = new SvtCarat();
            var result = usercarat.GetCarat(username, password);

            return result.username != null ? true : false;

            
        }
        public List <Discography> album = new List<Discography> ();
        public List<Discography> GetDiscographies()
        {
            SvtDiscography callalbum = new SvtDiscography ();     
            return callalbum.GetDiscographies();

        }
        
        public void addDiscography(Discography discographies)
        {
            album.Add(discographies);
        }
    }
}
