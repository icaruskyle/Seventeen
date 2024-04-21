
using Carat;
using System;
using System.Collections.Generic;

namespace SvtDL;



    public class SvtDiscography
    {

        List<Discography> discographyList = new List<Discography>();


    public SvtDiscography()
    {
        SeventeenDiscography();
    }
    public void SeventeenDiscography()
    { 

            Discography discographyOne = new Discography();
            discographyOne.title = "17 carat";
            discographyOne.albumtype = "1st Mini Album";
            discographyOne.releasedate = "May 29, 2015";
            discographyOne.tracks = """
               
                1. Shining Diamond, 
                2. Adore u(Title Track)  
                3.Ah Yeah 
                4. Jam Jam
                5. 20
                
                """;
            discographyList.Add(discographyOne);

            Discography discographyTwo = new Discography();
            discographyTwo.title = "BOYS BE";
            discographyTwo.albumtype = "2nd Mini Album";
            discographyTwo.releasedate = "September 10, 2015";
            discographyTwo.tracks = "1. Fronting," +
                " 2. Mansae(Title Track)," +
                " 3.When I Grow Up," +
                " 4. OMG," +
                " 5. Rock";
            discographyList.Add(discographyTwo);

            Discography discographyThree = new Discography();
            discographyThree.title = "LOVE&LETTER";
            discographyThree.albumtype = "1st Full Album";
            discographyThree.releasedate = "April 25, 2016";
            discographyThree.tracks = """

                 1. Chuck
                 2. Pretty U(Title Track)
                 3. Still Lonely
                 4. Hit Song
                 5. Say Yes
                 6. Drift Away
                 7. Adore U(Vocal Team)
                 8. Mansae (Hip-Hop Team)
                 9. Shining Diamond (Performance Team)
                 10. Love Letter
                
                """;
            discographyList.Add(discographyThree);

            Discography discographyFour = new Discography();
            discographyFour.title = "Very Nice";
            discographyFour.albumtype = "1st Repackage Album";
            discographyFour.releasedate = "July 4, 2016";
            discographyFour.tracks = """
            
                 1. NO F.U.N.
                 2. VERY NICE
                 3. Healing
                 4. SIMPLE
                 5. Space
                 6.Chuck
                 7. Pretty U(Title Track)
                 8. Still Lonely
                 9. Hit Song
                 10. Say Yes
                 11. Drift Away
                 12. Adore U(Vocal Team)
                 13. Mansae (Hip-Hop Team)
                 14. Shining Diamond (Performance Team)
                 15. Love Letter
                
                """;
            discographyList.Add(discographyFour);

            Discography discographyFive = new Discography();
            discographyFive.title = "GOING SEVENTEEN";
            discographyFive.albumtype = "3rd Mini Album";
            discographyFive.releasedate = "December 5, 2016";
            discographyFive.tracks = """

                1.BEAUTIFUL (Mix Team)
                2. BOOMBOOM
                3. HIGHLIGHT (Performance Team) 
                4. Lean On Me 
                5. Fast Pace 
                6. Don’t Listen In Secret (Vocal Team)
                7. I Don’t Know (Mix Team)
                8. Smile Flower
            """;
            discographyList.Add(discographyFive);

            Discography discographySix = new Discography();
            discographySix.title = "A|1";
            discographySix.albumtype = "4th Mini Album";
            discographySix.releasedate = "May 22, 2017";
            discographySix.tracks = """

            Don’t Wanna Cry
            Habit (Vocal Team)
            If I (Hip-Hop Team)
            Swimming Fool (Performance Team)
            MY I (JUN & THE8)
            Crazy in Love
            Who (Performance Team)
            Check-In (Hip-Hop Team)

            """;
            discographyList.Add(discographySix);

            Discography discographySeven = new Discography();
            discographySeven.title = "TEEN, AGE";
            discographySeven.albumtype = "2nd Full Album";
            discographySeven.releasedate = "November 6, 2017";
            discographySeven.tracks = """

            Intro. 新世界
            CHANGE UP (SVT Leaders)
            Without You
            CLAP
            BRING IT (HOSHI & WOOZI)
            Lilili Yabbay (Performance Team)
            TRAUMA (Hip-Hop Team)
            Pinwheel (Vocal Team)
            Flower (S.COUPS, JEONGHAN, WONWOO, THE8, SEUNGKWAN, DINO)
            ROCKET (JOSHUA & VERNON)
            Hello (JUN, MINGYU & DK)
            Campfire
            Outro. 未完

            """;
            discographyList.Add(discographySeven);

            Discography discographyEight = new Discography();
            discographyEight.title = "DIRECTOR'S CUT";
            discographyEight.albumtype = "1st Special Album";
            discographyEight.releasedate = "February 5, 2018";
            discographyEight.tracks = """

            Thinkin’ about you
            THANKS
            Run to You
            Falling For You

            """;
            discographyList.Add(discographyEight);

            Discography discographyNine = new Discography();
            discographyNine.title = "YOU MAKE MY DAY";
            discographyNine.albumtype = "5th Mini Album";
            discographyNine.releasedate = "July 16, 2018";
            discographyNine.tracks = """

            Oh My!
            Holiday
            Come to me
            What’s Good
            MOONWALKER
            Our dawn is hotter than day

            """;
            discographyList.Add(discographyNine);

            Discography discographyTen = new Discography();
            discographyTen.title = "YOU MADE MY DAWN";
            discographyTen.albumtype = "8th Mini Album";
            discographyTen.releasedate = "January 21, 2019";
            discographyTen.tracks = """

            Good to Me
            Home
            Hug (Vocal Team)
            Chilli (Hip-Hop Team)
            Shhh (Performance Team)
            Getting Closer

            """;
            discographyList.Add(discographyTen);

            Discography discographyEleven = new Discography();
            discographyEleven.title = "An Ode";
            discographyEleven.albumtype = "3rd Full Album";
            discographyEleven.releasedate = "September 16, 2019";
            discographyEleven.tracks = """

            HIT
            Lie Again
            Fear
            Let me hear you say
            247 (Performance Team)
            Second Life (Vocal Team)
            Network Love (Joshua, Jun, The8, & Vernon)
            Back It Up (Hip-Hop Team)
            Lucky
            Snap Shoot
            Happy Ending (Korean Ver.)

            """;
            discographyList.Add(discographyEleven);

            Discography discographyTwelve = new Discography();
            discographyTwelve.title = "Heng:garae";
            discographyTwelve.albumtype = "7th Mini Album";
            discographyTwelve.releasedate = "June 22, 2020";
            discographyTwelve.tracks = """

            Fearless
            Left & Right
            I Wish
            My My
            Kidult
            Together

            """;
            discographyList.Add(discographyTwelve);

            Discography discographyThirteen = new Discography();
            discographyThirteen.title = "Semicolon";
            discographyThirteen.albumtype = "2nd Special Album";
            discographyThirteen.releasedate = "October 19, 2020";
            discographyThirteen.tracks = """

            HOME;RUN
            Do Re Mi (Maknae line: SEUNGKWAN, VERNON, DINO)
            HEY BUDDY (97 liners: THE8, MINGYU, DK)
            Light a flame (96 liners: JUN, HOSHI, WONWOO, WOOZI)
            AH! LOVE (95 liners: S.COUPS, JEONGHAN, JOSHUA)
            All My Love

            """;
            discographyList.Add(discographyThirteen);

            Discography discographyFourthteen = new Discography();
            discographyFourthteen.title = "Your Choice";
            discographyFourthteen.albumtype = "8th Mini Album";
            discographyFourthteen.releasedate = "June 18, 2021";
            discographyFourthteen.tracks = """

            Heaven’s Cloud
            Ready to love
            Anyone
            GAM3 BO1
            Wave
            Same dream, same mind, same night (같은 꿈, 같은 맘, 같은 밤)

            """;
            discographyList.Add(discographyFourthteen);

            Discography discographyFifteen = new Discography();
            discographyFifteen.title = "Attaca";
            discographyFifteen.albumtype = "9th Mini Album";
            discographyFifteen.releasedate = "October 22, 2021";
            discographyFifteen.tracks = """

            To you (소용돌이)
            Rock with you
            Crush
            PANG! (Performance Team)
            Imperfect love (매일 그대라서 행복하다) (Vocal Team)
            I can’t run away (그리워하는 갓까지) (Hip-Hop Team)
            2 MINUS 1 (Digital only) (JOSHUA & VERNON)

            """;
            discographyList.Add(discographyFifteen);

            Discography discographySixteen = new Discography();
            discographySixteen.title = "Sector 17";
            discographySixteen.albumtype = "2nd Repackage Album";
            discographySixteen.releasedate = "July 18, 2022";
            discographySixteen.tracks = """

            Circles (놀고 놀아)
            _WORLD
            Fallin’ Flower (Korean Ver.)
            CHEERS (SVT Leaders)
            Darl+ing
            HOT
            DON QUIXOTE
            March
            Domino
            Shadow
            ’bout you (노래해)
            IF you leave me
            Ash

            """;
            discographyList.Add(discographySixteen);

            Discography discographySeventeen = new Discography();
            discographySeventeen.title = "FML";
            discographySeventeen.albumtype = "10th Mini Album";
            discographySeventeen.releasedate = "April 24, 2023";
            discographySeventeen.tracks = """

            F*ck My Life
            손오공 (Super)
            Fire (HipHop Team)
            I don’t Understand But I Luv U (Performance Team)
            먼지 (Dust) (Vocal Team)
            April Shower

            """;
            discographyList.Add(discographySeventeen);

            Discography discographyEighteen = new Discography();
            discographyEighteen.title = "SEVENTEENTH ALBUM";
            discographyEighteen.albumtype = "11th Mini Album";
            discographyEighteen.releasedate = "October 23, 2023";
            discographyEighteen.tracks = """

            SOS (prod.Marshmello)
            God of Music
            Diamond Days
            Back 2 Back (Performance Unit)
            Monster (Hip-Hop Unit)
            Yawn (Vocal Unit)
            Headliner
            God of Music (Instrumental)

            """;
            discographyList.Add(discographyEighteen);

            Discography discographyNineteen = new Discography();
            discographyNineteen.title = "17 IS RIGHT HERE";
            discographyNineteen.albumtype = "Best Album";
            discographyNineteen.releasedate = "April 29, 2024";
            discographyNineteen.tracks = """

                        Tracklist (Disc 1)

            MAESTRO
            SPELL
            LALALI (힙합팀)
            청춘찬가
            CALL CALL CALL! (Korean ver.)
            Happy Ending (Korean ver.)
            Fallin’ Flower (Korean ver.)
            24H (Korean ver.)
            Not Alone (Korean Ver.)
            Power of Love (Korean ver.)
            DREAM (Korean ver.)
            Ima – Even If The World Ends Tomorrow (Korean ver.)
            
                        Tracklist (Disc 2)

            아낀다 (Adore U)
            만세 (MANSAE)
            예쁘다 (Pretty U)
            아주 Nice (Very Nice)
            붐붐 (BOOM BOOM)
            울고 싶지 않아 (Don’t Wanna Cry)
            박수 (Clap)
            고맙다 (THANKS)
            어쩌나 (Oh My!)
            Home
            독: Fear
            Left & Right
            HOME;RUN
            Ready to love
            Rock with you
            HOT
            _WORLD
            F*ck My Life
            손오공 (Super)
            음악의 신 (God of Music)

            """;
            discographyList.Add(discographyNineteen);
        }
      public List<Discography> GetDiscographies()
    {
        return discographyList;
    }
    }

