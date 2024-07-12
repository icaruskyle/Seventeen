namespace SvtBL;

public class SvtValidationServices
{

    SvtGetServices getservices = new SvtGetServices();

    public bool CheckIfDiscographyExists(string Title)
    {
        bool result = getservices.GetDiscography(Title) != null;
        return result;
    }

    public bool CheckIfDiscographyExists(string Title, string Albumtype)
    {
        bool result = getservices.GetDiscography(Title, Albumtype) != null;
        return result;
    }

}