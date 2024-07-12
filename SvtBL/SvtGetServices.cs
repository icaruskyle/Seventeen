using SvtDL;
using Carat;

namespace SvtBL
{
    public class SvtGetServices
    {
        public List<Discography> GetAllDiscography()
        {
            SvtDiscography discographyData = new SvtDiscography();

            return discographyData.GetDiscography();

        }

        public Discography GetDiscography(string Title, string Albumtype)
        {
            Discography foundDiscography = new Discography();

            foreach (var discography in GetAllDiscography())
            {
                if (discography.Title == Title && discography.Albumtype == Albumtype)
                {
                    foundDiscography = discography;
                }
            }

            return foundDiscography;
        }

        public Discography GetDiscography(string Title)
        {
            Discography foundDiscography = new Discography();

            foreach (var discography in GetAllDiscography())
            {
                if (discography.Title == Title)
                {
                    foundDiscography = discography;
                }
            }

            return foundDiscography;
        }
    }
}
