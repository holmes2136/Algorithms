using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Algorithms;
using Lucene.Net.Search;
using System.IO;
using Lucene.Net.Store;
using Lucene.Net.Index;
using Lucene.Net.Analysis.Standard;
using Version = Lucene.Net.Util.Version;
using Lucene.Net.Documents;
using Lucene.Net.QueryParsers;
using System.Collections;


public partial class TestIsContentSimilarty : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
//        string s1 = @"Prince Harry is currently in Cape Town awaiting an improvement in weather conditions so that he, along with his fellow Walking With The Wounded teammates, can fly to Antarctica's Novo Airbase and begin acclimating their bodies to the extreme conditions before their 200-mile trek to the South Pole.
//By committing to head to the bottom of the earth alongside his team, Harry is setting a whole new precedent in terms of royal charity involvement for the future.
//Victoria Arbiter
//Victoria Arbiter
//Members of the royal family serve to provide continuity, promote British interests, and act as global ambassadors by representing all that is great about Great Britain, but a large percentage of their operational life is devoted to charity work.
//For decades royals have travelled the length and breadth of the country, and indeed the globe, on behalf of their many organizations. They act as patron or president, raise awareness of the cause, cut ribbons, unveil plaques, attend dinners, plant trees, and most importantly -- raise money.
//A royal patronage is about the best gift a charity can receive short of a wealthy benefactor bequeathing millions of dollars to the cause on their death bed, and in times of recession and economic hardship the survival of many charities rests on the regal shoulders of its patron.
// Prince prepares for South Pole trek Cressida, the new diamond in the rough Princes unite to help Lesotho herd boys
//At 87 the Queen has more than 600 patronages and at 92 Prince Philip has about 800. According to a recent Time magazine article, Prince Charles raised $224 million for his charities between April 2012 and March 2013.
//Tickets to the upcoming Winter Whites Gala on behalf of homeless charity Centrepoint were going for the princely sum of £500 before selling out almost immediately. The reason for the large price tag and instant sell out? Prince William, Patron of Centrepoint, will be in attendance.
//Charities can command top dollar when a senior royal rolls out. Along with said royal comes a legion of reporters and wealthy benefactors, and whenever Kate's involved you can pretty much guarantee the occasion making front page news the following day. That type of attention leaves charity heads googly-eyed.
//The royals have always approached charity engagements with enthusiasm, well aware that their presence allows for worldwide exposure. One need only to look at coverage of Diana shaking hands with an AIDS patient in 1989, or her walk through a partially-cleared land mine field in Angola in 1997, to understand the power of a globally recognized figure.
//William and Harry, however, have taken things one step further in recent years by rolling up their proverbial sleeves and throwing themselves in at ground level.
//In December 2009 Prince William spent the night sleeping rough near Blackfriars Bridge in central London. He did so in order to gain a better understanding of what the homeless community experiences night after night.
//Had he simply dished out soup and shaken hands with a few volunteers he still would have drawn attention to the work of the charity Centrepoint, but by actually bedding down on the streets of Central London he significantly heightened public awareness.
//In March 2011 Prince Harry joined a team of injured servicemen for the first five days of their trek to the North Pole. Yes, of course it was about raising money for the charity Walking With The Wounded, but as Harry said at the time, it was also about raising an awareness of the debt the country owes to those it sends off to fight.
// Keeping Prince George from prying eyes The royal aunt and uncle Royal baby's 'fun' Uncle Harry
//Harry has made no secret of his dedication to the welfare of injured servicemen and women, and the money raised enables the charity to fulfill its mission; however, by taking part alongside his fellow soldiers, Harry gave them far more than a well-funded charity. He showed them that they matter, that their loss matters, and that their lives may continue to inspire.
//Looking to the future of the monarchy, Charles has made it clear he wants to push for a more streamlined royal family, but I hope that when the time comes he will make room for extended members of the family to step up and continue their efforts on behalf of their chosen charities.
//As the only blood-born princesses of their generation, Beatrice and Eugenie have already shown a readiness to support causes meaningful to them. Were the Queen to give them an official role, their potential could be enormous.
//It comes down to simple mathematics: streamline the monarchy, and funding to the smaller charities that rely on a royal patron slips down the tubes.
//Royals and charity work will always go hand-in-hand -- and long may it be so. Plaques will remain, trees will grow, and the work of the charity in question will continue, but it is this new hardcore approach that is so exciting.
//It won't work for everyone, and it would lose its impact if suddenly every engagement required rigorous training, compression chambers, hard hats, life vests and the likes, but we should salute Prince Harry on his epic polar endeavor.
//Harry's physical disability may be limited to a broken toe, but walking alongside those brave wounded warriors will no doubt leave him with an unbreakable spirit.";


//        string s2 = @"Now the welfare of footballers is top of Fabrice Muamba's agenda and he has urged FIFA to put the wellbeing of players at the center of any decision on the scheduling of the Qatar 2022 World Cup.
//FIFA president Sepp Blatter announced on Twitter last month that no decision on the staging of the 2022 World Cup -- be it in Qatar's summer or winter -- would be made until after the 2014 tournament in Brazil.
//I hope FIFA will have a second thought because playing in those conditions is very dangerous for people,the 25-year-old told CNN.
//The heat and the humidity in that country can damage people; they have to look at the bigger picture.
// Fabrice Muamba on playing soccer again Muamba: I've played football again
//Former England Under-21 international Muamba suffered an on-field heart seizure while playing for Bolton Wanderers against Tottenham Hotspur in March 2012.
//Read: Emotional Muamba gets closure
//The Congo-born midfielder was revived by medics before making a remarkable recovery in hospital.
//You worry, not just me but every player,continued Muamba. The humidity, the heat, playing in those conditions it is very worrying.
//President of world football's governing body since 1998, Blatter launched a consultation process on the issue involving all stakeholders in Qatar 2022.
//Harold Mayne-Nicholls led the FIFA inspection team which examined each of the bidding countries for the 2022 World Cup before delivering his report in October 2010.
//Mayne-Nicholls concluded that Qatar was a high-risk option because of its soaring temperatures -- but it was still chosen by 14 of the 22 executive committee members in the final round of voting in December that year.
// Fabrice Muamba leaves hospital Fabrice Muamba leaves hospital
// Fabrice Muamba tributes Fabrice Muamba tributes
//In June and July you cannot play, Mayne-Nicholls told CNN last month when asked about the conditions in Qatar.
//It's not for the players. The players will be OK with the cooling system but what about the fans?
//You'll have 50,000 fans walking three, four, even six blocks or more like in South Africa where I walked 10 blocks.
//They will be walking in 40 degrees and it's too much. One or two crucial cases will damage the entire image of the World Cup and we must be careful.
//Read: Devastated Muamba retires from football
//Muamba is pleased his experiences have raised awareness of heart conditions in football, but he wants to see the sport continue to prioritize player safety.
//We're trying to reach a standard where we're providing the best available equipment for the boys,said Muamba, who began his career with Arsenal. Also making sure every player gets a heart screen so we detect any damage or any medical issue.
//What I tried to do was raise awareness of sudden cardiac arrest, having a defibrillator not just in the stadium but in every public place so we can save lives and ensure peoples safety.";

        string s1 = "Mr. Green killed Colonel Mustard in the study with the candlestick. Mr.Green is not a very nice fellow";

        string s2 = "Professor Plumb has a green plant in his study";

        string s3 = "Miss Scarlett watered Professor Plumb's green plant while he was away from his office last week";

        BuildIndex(s1, s3);
        
        List<double> val  = GetTFIDF();

        List<double> val2 = GetTFIDF2();


        TFIDF cos = new TFIDF();

        //for (int i = 0; i < val.Count-1; i++)
        //{

        //    for (int j = 0; j < val2.Count-1; j++)
        //    {
                Response.Write(cos.cosineSimilarity(val, val2));
                Response.Write("<BR>");
        //    }
        //}
       
        
    }

    public void BuildIndex(string s1,string s2)
    {
        string text1 = s1;

        string text2 = s2;

        string indexPath = AppDomain.CurrentDomain.BaseDirectory.ToString() + "\\App_Data\\";
        DirectoryInfo dirInfo = new DirectoryInfo(indexPath);
        FSDirectory dir = FSDirectory.Open(dirInfo);
        IndexWriter iw = new IndexWriter(dir, new StandardAnalyzer(Version.LUCENE_30), true, IndexWriter.MaxFieldLength.UNLIMITED);

        Document doc = new Document();
        doc.Add(new Field("Text", text1, Field.Store.YES, Field.Index.ANALYZED, Field.TermVector.YES));
        iw.AddDocument(doc);

        Document doc1 = new Document();
        doc1.Add(new Field("Text", text2, Field.Store.YES, Field.Index.ANALYZED, Field.TermVector.YES));
        iw.AddDocument(doc1);

        iw.Optimize();
        iw.Commit();
        iw.Close();

    }


    public List<double> GetTFIDF()
    {
        List<double> returnVal = new List<double>() ;

        string indexPath = AppDomain.CurrentDomain.BaseDirectory.ToString() + "\\App_Data\\";

        DirectoryInfo dirInfo = new DirectoryInfo(indexPath);

        FSDirectory dir = FSDirectory.Open(dirInfo);

        Hashtable ht = new Hashtable();

        IndexReader ir = IndexReader.Open(dir, false);

        string[] label = null;

        int[] freq = null;

        DefaultSimilarity similarity = new DefaultSimilarity();

        foreach (var obj in ir.GetTermFreqVectors(0))
        {
            label = obj.GetTerms();
            freq = obj.GetTermFrequencies();
        }

        for (int i = 0; i <= label.Length - 1; i++)
        {
            ht.Add(label[i], freq[i]);
        }

        foreach (DictionaryEntry obj in ht)
        {
            Response.Write("lable:" + obj.Key + "<br>");
            Response.Write("freq:" + obj.Value + "<br>");
            Response.Write("TF:" + similarity.Tf(Convert.ToInt32(obj.Value)) + "<br>");
            float tf = similarity.Tf(Convert.ToInt32(obj.Value));
            Term t = new Term("Text", obj.Key.ToString());
            Response.Write("IDF:" + similarity.Idf(ir.DocFreq(t), ir.NumDocs()) + "<br>");
            float idf = similarity.Idf(ir.DocFreq(t), ir.NumDocs());
            Response.Write("TF-IDF:" + tf * idf + "<br>");
            Response.Write("<br>");

            returnVal.Add(tf * idf);
        }

        return returnVal;
    }

    public List<double> GetTFIDF2()
    {
        List<double> returnVal = new List<double>();

        string indexPath = AppDomain.CurrentDomain.BaseDirectory.ToString() + "\\App_Data\\";

        DirectoryInfo dirInfo = new DirectoryInfo(indexPath);

        FSDirectory dir = FSDirectory.Open(dirInfo);

        Hashtable ht = new Hashtable();

        IndexReader ir = IndexReader.Open(dir, false);

        string[] label = null;

        int[] freq = null;

        DefaultSimilarity similarity = new DefaultSimilarity();

        foreach (var obj in ir.GetTermFreqVectors(1))
        {
            label = obj.GetTerms();
            freq = obj.GetTermFrequencies();
        }

        for (int i = 0; i <= label.Length - 1; i++)
        {
            ht.Add(label[i], freq[i]);
        }

        foreach (DictionaryEntry obj in ht)
        {
            Response.Write("lable:" + obj.Key + "<br>");
            Response.Write("freq:" + obj.Value + "<br>");
            Response.Write("TF:" + similarity.Tf(Convert.ToInt32(obj.Value)) + "<br>");
            float tf = similarity.Tf(Convert.ToInt32(obj.Value));
            Term t = new Term("Text", obj.Key.ToString());
            Response.Write("IDF:" + similarity.Idf(ir.DocFreq(t), ir.NumDocs()) + "<br>");
            float idf = similarity.Idf(ir.DocFreq(t), ir.NumDocs());
            Response.Write("TF-IDF:" + tf * idf + "<br>");
            Response.Write("<br>");

            returnVal.Add(tf * idf);
        }

        return returnVal;
    }
}