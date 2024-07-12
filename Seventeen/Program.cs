using Carat;
using SvtBL;
using SvtDL;


namespace Seventeen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SvtGetServices getServices = new SvtGetServices();

            var discography = getServices.GetAllDiscography();

            foreach (var item in discography)
            {
                Console.WriteLine(item.Title);
                Console.WriteLine(item.Albumtype);
            }

        }
    }

}