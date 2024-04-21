
using System;

using SvtBL;
using SvtDL;
using Carat;
using System.Collections.Generic;


public class Program
{
    static SvtDiscography discography = new SvtDiscography();
    static void Main(string[] args)
    {

        Console.WriteLine("=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>");
        Console.WriteLine("Carat Username:");
        string username = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>");
        Console.WriteLine("Password: ");
        string password = Console.ReadLine();
        Console.WriteLine();

        CaratVerification carat = new CaratVerification();
        bool result = carat.VerifyCarat(username, password);

        if (result)
        {
            Console.WriteLine("=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>");

            Console.WriteLine("Hi Carat!");

            Console.WriteLine("=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>");
        }
        else
        {
            Console.WriteLine("=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>");

            Console.WriteLine("Invalid Input.");

            Console.WriteLine("=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>");

            return;
        }
        
        while (true)
        {

            Program DiscographyList = new Program();

            
            Console.WriteLine();
            Console.WriteLine("Seventeen to the WORLD!!");
            Console.WriteLine();
            Console.WriteLine("=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>");
            Console.WriteLine();
            Console.WriteLine("1.Description and Biography");
            Console.WriteLine("2.Discographies");
            Console.WriteLine("3.Exit");
            Console.WriteLine();
            Console.WriteLine("=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>");
            Console.WriteLine();
            Console.WriteLine("Select an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {

                case "1":

                    Console.WriteLine("=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>");
                    Console.WriteLine();
                    Console.WriteLine("""

                        Seventeen (Korean: 세븐틴; stylized in all caps or as SVT) 
                        is a South Korean boy band formed by Pledis Entertainment. 

                        The group consists of thirteen members: 

                                                S.Coups(Leader)
                                                Jeonghan
                                                Joshua
                                                Jun
                                                Hoshi
                                                Wonwoo
                                                Woozi
                                                DK
                                                Mingyu
                                                The8
                                                Seungkwan
                                                Vernon
                                                Dino
                                                
                        The name Seventeen is derived from the expression "13 members + 3 units + 1 group",
                        representing how the 13 members are divided into three different units and come together to form one cohesive group.
                        The name originally referred to how 17 members 
                        (with the other 4 former pre-debut trainees — Jang Do-yoon, Samuel Kim, Shin Dong-jin, 
                        and Yao Mingming)—planned to debut.
                        
                        Seventeen has conquered a large audience since its debut and has grown into an internationally
                        recognized K-Pop group with signature music and performances.

                        The group debuted on May 26, 2015, with the extended play (EP) 17 Carat,
                        which became the longest-charting K-pop album of the year in the US
                        and the only rookie album to appear on Billboard's "10 Best K-Pop Albums of 2015" list.
                        Seventeen has released four studio albums, twelve EPs and three reissues.

                        """);
                    Console.WriteLine();
                    Console.WriteLine("=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>");
                    break;
                case "2":
                    DiscographyList.DiscographiesList(discography.GetDiscographies());

                    break;
                case "3":
                    Console.WriteLine("=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>");
                    Console.WriteLine();
                    Console.WriteLine("Thank You carat hope you know more about Seventeen's Discographies!! LET'S STREAM!!!");
                    Console.WriteLine();
                    Console.WriteLine("=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>");
                    return;
                default:
                    Console.WriteLine("Uh-Oh Please Try Again");
                    break;
            }
        }
    }

    public void DiscographiesList(List<Discography> discographyList)
    {
        while (true)
        {
            Console.WriteLine("=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>");
            Console.WriteLine();
            Console.WriteLine("HERE ARE SOME OF SEVENTEEN'S DISCOGRAPHY");
            Console.WriteLine();
            Console.WriteLine("=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>");
            Console.WriteLine();
            Console.WriteLine("1.17 Carat");
            Console.WriteLine("2.Boys Be");
            Console.WriteLine("3.Love & Letter");
            Console.WriteLine("4.Very Nice");
            Console.WriteLine("5.Going Seventeen");
            Console.WriteLine("6.A|1");
            Console.WriteLine("7.Teen, Age");
            Console.WriteLine("8.Director's Cut");
            Console.WriteLine("9.You Make My Day");
            Console.WriteLine("10.You Made My Dawn");
            Console.WriteLine("11.An Ode");
            Console.WriteLine("12.Heng:garae");
            Console.WriteLine("13.Semicolon");
            Console.WriteLine("14.Your Choice");
            Console.WriteLine("15.Attaca");
            Console.WriteLine("16.Sector 17");
            Console.WriteLine("17.FML");
            Console.WriteLine("18.Seventeenth Album");
            Console.WriteLine("19.17 is Right Here");
            Console.WriteLine();
            Console.WriteLine("=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>");
            Console.WriteLine();
            Console.WriteLine("Choose a Discography:");


            string choose = Console.ReadLine();


            switch (choose)

            {

                case "1":
                    DiscographyInfo.DisplayDiscographyInfo(discographyList[0]);
                    break;
                case "2":
                    DiscographyInfo.DisplayDiscographyInfo(discographyList[1]);
                    break;
                case "3":
                    DiscographyInfo.DisplayDiscographyInfo(discographyList[2]);
                    break;
                case "4":
                    DiscographyInfo.DisplayDiscographyInfo(discographyList[3]);
                    break;
                case "5":
                    DiscographyInfo.DisplayDiscographyInfo(discographyList[4]);
                    break;
                case "6":
                    DiscographyInfo.DisplayDiscographyInfo(discographyList[5]);
                    break;
                case "7":
                    DiscographyInfo.DisplayDiscographyInfo(discographyList[6]);
                    break;
                case "8":
                    DiscographyInfo.DisplayDiscographyInfo(discographyList[7]);
                    break;
                case "9":
                    DiscographyInfo.DisplayDiscographyInfo(discographyList[8]);
                    break;
                case "10":
                    DiscographyInfo.DisplayDiscographyInfo(discographyList[9]);
                    break;
                case "11":
                    DiscographyInfo.DisplayDiscographyInfo(discographyList[10]);
                    break;
                case "12":
                    DiscographyInfo.DisplayDiscographyInfo(discographyList[11]);
                    break;
                case "13":
                    DiscographyInfo.DisplayDiscographyInfo(discographyList[12]);
                    break;
                case "14":
                    DiscographyInfo.DisplayDiscographyInfo(discographyList[13]);
                    break;
                case "15":
                    DiscographyInfo.DisplayDiscographyInfo(discographyList[14]);
                    break;
                case "16":
                    DiscographyInfo.DisplayDiscographyInfo(discographyList[15]);
                    break;
                case "17":
                    DiscographyInfo.DisplayDiscographyInfo(discographyList[16]);
                    break;
                case "18":
                    DiscographyInfo.DisplayDiscographyInfo(discographyList[17]);
                    break;
                case "19":
                    DiscographyInfo.DisplayDiscographyInfo(discographyList[18]);
                    break;
                default:
                    Console.WriteLine("Error.");
                    return;
            }

        }
    }
}
    





            

        
    


