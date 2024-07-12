using Carat;
using SvtDL;

namespace SvtBL
{
    public class SvtTransactionServices
    {
        SvtValidationServices validationServices = new SvtValidationServices();
        SvtDiscography discographyData = new SvtDiscography();

        public bool CreateDiscography(Discography discography)
        {
            bool result = false;

            if (validationServices.CheckIfDiscographyExists(discography.Title))
            {
                result = discographyData.AddDiscography(discography) > 0;
            }

            return result;
        }

        public bool CreateDiscography(string Title, string Albumtype)
        {
            Discography discography = new Discography { Title = Title, Albumtype = Albumtype };

            return CreateDiscography(discography);
        }

        public bool UpdateDiscography(Discography discography)
        {
            bool result = false;

            if (validationServices.CheckIfDiscographyExists(discography.Title))
            {
                result = discographyData.UpdateDiscography(discography) > 0;
            }

            return result;
        }

        public bool UpdateDiscography(string Title, string Albumtype)
        {
            Discography discography = new Discography { Title = Title, Albumtype = Albumtype };

            return UpdateDiscography(discography);
        }

        public bool DeleteDiscography(Discography discography)
        {
            bool result = false;

            if (validationServices.CheckIfDiscographyExists(discography.Title))
            {
                result = discographyData.DeleteDiscography(discography) > 0;
            }

            return result;
        }
    }
}
