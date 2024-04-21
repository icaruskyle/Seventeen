using Carat;
using System;
using System.Collections.Generic;



    public class DiscographyInfo
    {
        public List<Discography> discographiesList = new List<Discography>();
        
        public static void DisplayDiscographyInfo(Discography discography)
        {
            Console.WriteLine("Title:" + discography.title);
            Console.WriteLine("Type of Album:" + discography.albumtype);
            Console.WriteLine("Date Release:" + discography.releasedate);
            Console.WriteLine("Albums Tracks:" + discography.tracks);
        }
    }
    

