using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steganography
{
    public static class RandomWords
    {
       private static List<int> usedNumbers = new List<int>();

       private static readonly List<string> words = new List<string>() {

            "evidence","stopped","grass","related","planet","court","lungs","comfortable","there","bridge",
            "shown","daughter","air","love","excited","actual","already","picture","aside","facing",
            "pride","quiet","bean","growth","trunk","longer","rather","friendly","lamp","poem" ,
            "principle","see","tall","also","alive","stuck","ahead","diameter","throughout","wrote" ,
            "own","beneath","fox","lady","consist","sat","exciting","there","aboard","entire" ,
            "pride","least","support","then","high","combination","egg","bread","famous","word" ,
            "waste","further","curious","cake","worried","such","ask","occasionally","spring","easily" ,
            "copy","dangerous","mistake","fact","wrote","compass","coming","habit","further","take" ,
            "mine","off","invented","meal","pain","fierce","face","perfect","mixture","open" ,
            "salmon","question","south","pay","remember","inside","allow","select","natural","handle" ,
            "private","master","sang","rubbed","combine","board","cook","fast","easy","walk" ,
            "measure","mud","tell","brass","dangerous","known","drawn","road","familiar","shake" ,
            "attached","circus","involved","deer","sister","gray","secret","tales","compound","disease" ,
            "cup","done","eight","radio","lost","earth","aloud","decide","castle","cheese" ,
            "present","bread","base","colony","eleven","hot","ants","jump","easier","she" ,
            "product","five","easily","close","share","thy","owner","opposite","does","freedom" ,
            "eager","indeed","properly","vertical","today","develop","eight","opinion","fear","slow" ,
            "diameter","entirely","riding","just","using","certain","method","change","sun","larger" ,
            "begun","raise","unknown","brown","chapter","income","shorter","plant","quiet","military" ,
            "air","consider","did","potatoes","large","earlier","careful","rubbed","type","nearly" ,
            "copy","sea","column","church","silk","law","settlers","fifth","what","daughter" ,
            "room","nodded","may","voice","push","bean","example","across","written","process" ,
            "top","crowd","together","noted","later","tribe","nearer","unknown","screen","discuss" ,
            "sum","solve","well","sign","most","labor","people","root","dollar","position" ,
            "success","visit","basis","together","car","never","office","back","settle","rule" ,
            "crowd","pressure","yourself","globe","bicycle","stage","fine","structure","worker","eight" ,
            "led","hot","weather","wrote","vast","remove","climb","smoke","blow","world" ,
            "clay","steam","forth","discovery","finally","gave","spider","chamber","excitement","connected" ,
            "may","previous","brick","deep","near","near","luck","vertical","himself","hurried" ,
            "couple","potatoes","trace","pot","breath","court","bark","torn","threw","additional" ,
            "mind","pain","children","frozen","health","dangerous","vote","rich","flag","probably" ,
            "century","late","danger","taste","former","nor","solid","radio","search","term" ,
            "passage","minerals","offer","between","knew","seen","rose","wrapped","gradually","ago" ,
            "steel","mysterious","rough","fuel","region","lie","clock","dirty","massage","fly" ,
            "west","spread","tiny","hit","nodded","camp","indicate","interest","cotton","any" ,
            "arm","fur","cent","parallel","grain","actual","us","now","struggle","parent" ,
            "outline","charge","laid","enjoy","stairs","may","crop","dangerous","else","nearer" ,
            "teeth","speech","guide","negative","separate","flight","fresh","happy","weight","street" ,
            "want","catch","ranch","lamp","pupil","stronger","mainly","sugar","tiny","drink" ,
            "lion","black","massage","traffic","source","butter","grabbed","guess","dull","model" ,
            "society","thrown","horn","height","band","exclaimed","score","danger","obtain","piano" ,
            "shells","valuable","tightly","angry","union","toward","once","except","tonight","behavior" ,
            "brought","split","fireplace","meat","sat","bare","colony","chemical","root","joy" ,
            "wonder","mostly","kept","golden","depth","became","tropical","origin","maybe","somehow" ,
            "light","though","on","ready","tonight","soft","instead","sort","finger","bridge" ,
            "cause","spite","ill","school","experiment","farmer","announced","bell","anyone","right" ,
            "favorite","cry","little","jungle","mirror","path","current","simple","coach","wall" ,
            "driver","serious","explore","underline","parallel","find","army","as","temperature","desk" ,
            "tobacco","differ","father","general","wide","truck","essential","guard","particular","receive" ,
            "announced","touch","be","course","rapidly","mission","slabs","gravity","pilot","tell" ,
            "produce","club","habit","consist","evidence","fully","usual","or","thee","dropped" ,
            "met","blow","president","sleep","negative","air","bent","money","curious","lying" ,
            "crew","nation","hay","we","wash","clock","bring","last","bread","bow" ,
            "alike","past","come","command","stood","village","clothing","period","trade","slight" ,
            "doing","serious","obtain","spent","gave","rocky","related","describe","torn","nose" ,
            "mix","average","prepare","loose","slightly","trail","inside","came","us","tomorrow" ,
            "wherever","bar","finger","way","magnet","tone","mountain","report","horse","particularly" ,
            "tomorrow","over","boat","army","silence","join","here","gun","cry","cover" ,
            "drop","forgot","grown","inch","national","upper","greatly","bowl","joy","rhyme" ,
            "mix","represent","sort","indicate","better","worried","happened","direction","call","straight" ,
            "has","branch","lady","composed","win","swim","third","soon","seen","supply" ,
            "took","ball","needs","will","except","might","city","tube","mirror","dinner" ,
            "yard","mile","ball","herd","darkness","example","well","hay","rush","become" ,
            "every","broad","torn","surface","barn","character","height","five","feed","supply" ,
            "value","involved","stream","vertical","harder","sang","remember","whose","fairly","sit" ,
            "usually","excited","land","trip","fog","pig","taken","serious","globe","daughter" ,
            "pound","police","police","heavy","enter","constantly","shirt","possibly","include","corner" ,
            "must","orbit","lunch","recall","part","position","meant","suddenly","smallest","poet" ,
            "label","escape","oxygen","oxygen","excellent","grown","put","scared","speak","gravity" ,
            "within","specific","modern","improve","effect","friendly","freedom","put","principle","difficulty" ,
            "today","term","invented","previous","pressure","speed","operation","mirror","applied","noun" ,
            "changing","hung","therefore","circus","tropical","instance","human","please","face","kids" ,
            "dance","tube","what","salt","practical","excited","block","floating","rush","corn" ,
            "positive","there","mill","handsome","eventually","soil","hurry","possible","atomic","crop" ,
            "kitchen","but","species","earn","good","roof","recognize","molecular","author","particles" ,
            "thank","ever","instant","garden","course","event","industry","library","property","company" ,
            "when","regular","edge","class","primitive","song","map","colony","strange","according" ,
            "provide","official","day","come","motion","nor","upward","understanding","height","continued" ,
            "needle","stove","paper","recent","meat","harbor","bad","begun","use","changing" ,
            "symbol","earth","remove","newspaper","paid","fear","officer","forward","by","hardly" ,
            "tribe","told","mail","creature","dish","rear","slight","bear","with","am" ,
            "can","aid","bright","tobacco","town","produce","result","compound","yourself","pine" ,
            "family","union","safe","practice","ring","settle","lose","plastic","shut","planning" ,
            "notice","machine","fine","seed","ever","degree","consonant","rain","protection","settle" ,
            "lady","station","car","today","teach","air","three","dress","influence","donkey" ,
            "shoot","enjoy","pencil","slide","solar","again","football","consider","bank","gather" ,
            "place","supply","nice","green","bicycle","children","quietly","meat","fast","sign" ,
            "grass","get","change","invented","gray","heat","twice","mark","happy","lady" ,
            "duck","search","excitement","tower","leg","save","alone","except","slipped","her" ,
            "ought","piece","probably","while","consider","soft","favorite","tall","east","recently" ,
            "protection","center","trace","corn","topic","carefully","design","desk","here","mail" ,
            "settle","discover","remove","surprise","jump","military","map","winter","height","front" ,
            "spring","separate","passage","frame","composed","molecular","package","religious","beauty","only" ,
            "gather","wash","there","wrote","bus","met","bell","sheep","control","stopped" ,
            "sink","gold","usual","north","matter","temperature","ball","mail","opposite","usually" ,
            "use","village","enter","water","personal","cage","nobody","gain","gray","especially" ,
            "together","do","plural","play","form","numeral","wood","basic","thought","yard" ,
            "mostly","future","actual","test","lake","handsome","lucky","private","am","later" ,
            "stream","off","hair","first","pictured","promised","quiet","song","forth","round" ,
            "involved","level","larger","air","last","zero","draw","mysterious","transportation","sides" ,
            "bend","oxygen","bean","upper","only","highest","vertical","once","possible","passage" 
        };


        public static string GenerateRandomWord()
        {
            Random rand = new Random((int)DateTime.Now.Ticks+1);
            
            bool numberUsed = false;
            int number;

            do
            {
                number = rand.Next(words.Count);

                if (!usedNumbers.Contains(number))
                {
                    usedNumbers.Add(number);
                    numberUsed = true;
                }
                
            } while (!numberUsed);

            return words[number];
        }

        public static void ClearUsedWords()
        {
            usedNumbers.Clear();
        }
    }
}
