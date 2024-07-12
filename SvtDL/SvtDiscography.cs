
using Carat;

namespace SvtDL
{
    public class SvtDiscography
    {
        List<Discography> discography;
        SqlDataBase sqlData;
        public SvtDiscography()
        {
            discography = new List<Discography>();
            sqlData = new SqlDataBase();
        }

        public List<Discography> GetDiscography()
        {
            discography = sqlData.GetDiscographies();
            return discography;
        }

        public int AddDiscography(Discography discography)
        {
            return sqlData.AddDiscography(discography.Albumtype, discography.Title);
        }

        public int UpdateDiscography(Discography discography)
        {
            return sqlData.UpdateDiscography(discography.Title, discography.Albumtype);
        }

        public int DeleteDiscography(Discography discography)
        {
            return sqlData.DeleteDiscography(discography.Title, discography.Albumtype);
        }
    }
}
