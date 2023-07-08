using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        //video 1
        Video video1 = new Video("Can a Lego Car Roll Downhill Forever?", "Brick Technology","9:11");
        Comment comment1 = new Comment("ethanpflederer3395", "I can see that the Brick Technology space program is going well.");
        Comment comment2 = new Comment("dripgod6776", "This could honestly be an awesome over engineered show stand for technic cars");
        Comment comment3 = new Comment("redevlmao", "5:48 Crazy to think that a goofy little Lego car had better controls than a million dollar submarine");

        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);
        videos.Add(video1);
        //video 2
        Video video2 = new Video("If Star Wars games had Lore Accurate Lightsabers", "Sharp47", "2:17");
        Comment comment4 = new Comment("Gurtington", "FINALLY SOMEONE DID IT. This was so satisfying to finally watch lightsabers do what they would really do.");
        Comment comment5 = new Comment("justincohen4823", "Jedi is such a peaceful religion. A piece over here, a piece over there.");
        Comment comment6 = new Comment("jakedude236", "If this is what these games were actually like, I'd play them");

        video2.AddComment(comment4);
        video2.AddComment(comment5);
        video2.AddComment(comment6);
        videos.Add(video2);
        //video 3
        Video video3 = new Video("Voice Overacting At Its Finest", "Andrew Levin", "0:18");
        Comment comment7 = new Comment("jaegermann4170", "Shocker was running up those stairs like he just turned off the lights to the basement");
        Comment comment8 = new Comment("MrFutago87", "If this ism't recreated in Spider Man 2 then there is something seriously wrong with the world.");
        Comment comment9 = new Comment("highgrove8545","The fact that shocker is a pretty low tier super villain makes this even better");

        video3.AddComment(comment7);
        video3.AddComment(comment8);
        video3.AddComment(comment9);
        videos.Add(video3);
        //video 4
        Video video4 = new Video("Leeroy Jenkins HD 1080p", "J Jonah Jameson", "2:51");
        Comment comment10 = new Comment("Jm-ki4su", "That horrified silence just after he charges in is criminally underrated");
        Comment comment11 = new Comment("julesalcantara835", "17 years later, Leeroy Jenkins is still legendary!");
        Comment comment12 = new Comment("Jon420g", "Hands down the greatest moment in gaming history");
        Comment comment13 = new Comment("thatguyty9540", "The fact Leeroy was AFK during the entire planning process is just hilarious");

        video4.AddComment(comment10);
        video4.AddComment(comment11);
        video4.AddComment(comment12);
        video4.AddComment(comment13);
        videos.Add(video4);
        //display video data
        foreach (Video video in videos)
        {
            video.Display();
        }
    }
}

