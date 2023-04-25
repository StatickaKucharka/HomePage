using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HomePage.strany
{
    /// <summary>
    /// Interaction logic for LandingPage.xaml
    /// </summary>
    public partial class LandingPage : Page
    {
        
        
        private List<Recipe> recipes = new List<Recipe>();
        public List<Recipe> Recipes { get { return this.recipes; } set { this.recipes = value; } }



        public LandingPage()
        {

            
            InitializeComponent();
            
            
            this.DataContext = this;
            AddRecipe(new Recipe("recept1",
                "/Obrazky/recepty/recept1.jpg",
                "1\r\nRúru rozohrejeme na 170ºC a menší, hlbší plech (22x32 cm) vymastíme trochou masla.\r\n\r\n2\r\nCesto: v miske spolu premiešame múku, cukor, soľ a pridáme na kocky pokrájané maslo. Prstami spracujeme mrveničku.\r\n\r\n3\r\nTretinu mrveničky odložíme bokom a zvyšok vysypeme a utlačíme na dno a trochu vytiahneme aj po stranách (asi 1 cm vysoko) plechu.\r\n\r\n4\r\nPlech vložíme do rúry na cca 12 minút, kým kraje cesta nezhnednú, vytiahneme a necháme vychladnúť bokom.\r\n\r\n5\r\nPlnka: v miske spolu premiešame cukor, múku, pridáme dve vajcia, kyslú smotanu a všetko vymiešame metličkou do hladka.",
                "CESTO:\r\n200 g\r\nhladká múka\r\n150 g\r\nkryštálový cukor\r\n0.5 KL\r\nsoľ\r\n170 g\r\nmaslo\r\nPLNKA:\r\n40 g\r\nhladká múka\r\n200 g\r\nkryštálový cukor\r\n2 ks\r\nvajce\r\n100 g\r\nkyslá smotana\r\n300 g\r\nčučoriedky\r\n1 PL\r\ncitrónová kôra"));
            AddRecipe(new Recipe("recept2", "/Obrazky/recepty/recept2.jpg",
                "1.\r\nParadajky a cibuľu nakrájame na menšie kúsky. Pridáme nadrobno nasekanú petržlenovú vňať a všetko zalejeme zálievkou. 2.\r\nTú si pripravíme z oleja, octu, cukru, korenia a zo soli.",
                "6 ks\r\nparadajka\r\n2 ks\r\ncibuľa\r\n3 PL\r\npetržlenová vňať\r\n2 PL\r\nolivový olej\r\n1 PL\r\ncukor\r\n2 PL\r\nvínny ocot\r\npodľa chuti\r\nsoľ, mleté čierne korenie\r\n"));
            AddRecipe(new Recipe("recept3", "/Obrazky/recepty/recept3.jpg",
                " 1.\r\nRúru rozohrejeme na 170ºC a menší, hlbší plech (22x32 cm) vymastíme trochou masla.\r\n\r\n2\r\nCesto: v miske spolu premiešame múku, cukor, soľ a pridáme na kocky pokrájané maslo. Prstami spracujeme mrveničku.\r\n\r\n3\r\nTretinu mrveničky odložíme bokom a zvyšok vysypeme a utlačíme na dno a trochu vytiahneme aj po stranách (asi 1 cm vysoko) plechu.\r\n\r\n4\r\nPlech vložíme do rúry na cca 12 minút, kým kraje cesta nezhnednú, vytiahneme a necháme vychladnúť bokom.\r\n\r\n5\r\nPlnka: v miske spolu premiešame cukor, múku, pridáme dve vajcia, kyslú smotanu a všetko vymiešame metličkou do hladka.",
                "200 g\r\nhladká múka\r\n150 g\r\nkryštálový cukor\r\n0.5 KL\r\nsoľ\r\n170 g\r\nmaslo\r\nPLNKA:\r\n40 g\r\nhladká múka\r\n200 g\r\nkryštálový cukor\r\n2 ks\r\nvajce\r\n100 g\r\nkyslá smotana\r\n300 g\r\nčučoriedky\r\n1 PL\r\ncitrónová kôra"));
            AddRecipe(new Recipe("recept4", "/Obrazky/recepty/recept4.jpg", 
                "1\r\nZemiaky očistíme, pokrájame na kocky a v hrnci zalejeme vodu iba toľko, aby ich zakrývala.\r\n\r\n2\r\nDobre ich osolíme a dáme variť do mäkka.\r\n\r\n3\r\nUvravené zemiaky popučíme aj s vodou, v ktorej sa varili, zamiešame k nim múku, dochutíme ich soľou, zakryjeme pokrievkou a necháme postáť asi štvrť hodinku.\r\n\r\n4\r\nNa panvici necháme škvariť na plátky / kocky pokrájanú slaninu do chrumkava.\r\n\r\n5\r\nNásledne odoberáme kúsky cesta, ktoré v naolejovaných dlaniach tvarujeme do valčeka a pokrájame na menšie kocky. Tie môžeme ešte vytvarovať do malý ch guličiek.",
                "1 kg\r\nzemiaky\r\n250 g\r\npolohrubá múka\r\npodľa chuti\r\nsoľ\r\n100 g\r\nslanina"));
            AddRecipe(new Recipe("recept5", "/Obrazky/recepty/recept5.jpg", "" +
                "1\r\nBrokolicu rozdelíme na menšie ružičky, ktoré dobre opláchneme a necháme odkvapkať.\r\n\r\n2\r\nV rajnici zahrejeme maslo, pridáme nasekaný cesnak, ktorý restujeme asi jednu minútku.\r\n\r\n3\r\nPotom pridáme nasekanú cibuľku a restujeme ďalšiu minútku.\r\n\r\n4\r\nNásledne do rajnice pridáme ružičky brokolice, chvíľku ich otestujeme a zalejeme vývarom.\r\n\r\n5\r\nZakrytú polievku privedieme k varu na asi 3 minúty (kým brokolica nezmäkne) a prisypeme umyté listy špenátu.6\r\nVzápätí pridáme strúhaný syr a prilejeme asi deci smotany (zvyšok si necháme na dekorovanie polievky).\r\n\r\n7\r\nPolievku dochutíme soľou, korením, chvíľku prevaríme a rozmixujeme ponorným mixérom.\r\n\r\n8\r\nPodávame pokvapkanú smotanou a posypanú nasekanými a nasucho opraženými orieškami.  ",
                "2 PL\r\nmaslo\r\n3 strúčiky\r\ncesnak\r\n1 ks\r\nmenšia cibuľa\r\n1 ks\r\nbrokolica\r\n1 liter\r\nzeleninový vývar\r\n1 balíček\r\nšpenátové listy\r\n50 g\r\nstrúhaný syr\r\n200 ml\r\nsmotana našľahanie\r\npodľa chuti\r\nsoľ, mleté čierne korenie\r\n1 hrsť\r\nvlašské oriešky"));
            AddRecipe(new Recipe("recept6", "/Obrazky/recepty/recept6.jpg",
                "Mäso môžete pripraviť už hodinu (alebo i dlhšie) pred varením. Zmiešajte mleté hovädzie mäso s worcestrovou omáčkou, vytvarujte do placiek a vložte do chladničky.\r\nDôležité je všetko si vopred nachystať, pretože burger je hotový rýchlo. Vytiahnite mäsové placky z chladničky, osoľte a okoreňte z každej strany. Nakrájajte cibuľu, rajčinu a zaváranú uhorku na hrubšie plátky. Umyte šalát a nechajte ho odkvapkať.\r\nPripravte si taktiež dresing zmiešaním potrebných ingrediencií uvedených vyššie.\r\nMajte prichystané dve panvice. V jednej opečte mäso a v druhej žemle, slaninu a cibuľu. Ak máte k dispozícii gril, samozrejme ho môžete použiť.\r\nMäso smažte z každej strany približne 4 minúty. Čas môžete prispôsobiť podľa toho, aký stupeň prepečenia máte radi. Otočte mäso iba raz a hneď po otočení položte naňho syr.\r\nNo a na záver už len dajte dokopy všetky suroviny, v tomto poradí: žemľa, dresing, šalát, rajčina, mäso, syr, cibuľka, slanina, uhorka, dresing, žemľa.\r\n",
                "450g hovädzie mäso (80% chudé, 20% tučné)\r\n1 žĺtok\r\n1 PL worcestrovej omáčky\r\n3 žemle (domáce)\r\n6 šalátových listov\r\n3 hrubé plátky cibule\r\n6 plátkov slaniny\r\n3 hrubé plátky rajčiny\r\n3 plátky syra (čedar)\r\n6 plátkov zaváranej uhorky\r\nSoľ a čierne korenie podľa chuti\r\nDresing\r\n3 PL kečupu\r\n1 PL horčice\r\n2 PL majonézy\r\n8 kvapiek tabasca\r\n1/2 ČL sušeného oregana"));
            AddRecipe(new Recipe("recept7", "/Obrazky/recepty/recept7.jpg",
                "1\r\nMäso umyjeme a nakrájame na kocky. Na panvicu dáme trochu oleja a prudko opečieme z každej strany. Vyberieme a dáme do misky.\r\n2\r\nV menšej miske zmiešame 1 polievkovú lyžicu olivového oleja, sójovú omáčku, trstinový cukor, soľ a čierne korenie. Takto pripravenú marinádu vylejeme k opečenému mäsu a dobre premiešame.\r\n\r\n3\r\nŠampiňóny očistíme a nakrájame na plátky. Na panvici, v ktorej sme restovali mäso, prudko opečieme šampiňóny do zlatista. Krátko dusíme, pridáme nasekaný cesnak a následne marinované mäso. Dobre premiešame, pridáme očistenú a na ružičky pripravenú brokolicu. \r\n4\r\nPodľa chuti pridáme ešte soľ, mleté čierne korenie, citrónovú šťavu a chilli. Podlejeme trochou vody a necháme dusiť približne 10 minút.\r\n\r\n5\r\nPodávame s ryžou. Dobrú chuť.",
                "500 g\r\nkuracie prsia\r\n300 g\r\nbrokolica\r\n100 g\r\nšampiňóny hnedé\r\n3 PL\r\nolivový olej\r\n1 strúčik\r\ncesnak\r\n0.5 ks\r\nšťava z polovice citróna\r\n3 PL\r\nsójová omáčka\r\n1 ČL\r\ntrstinový cukor\r\npodľa chuti\r\nsoľ, mleté čierne korenie\r\npodľa chuti\r\nchilli"));
            AddRecipe(new Recipe("recept8", "/Obrazky/recepty/recept8.jpg",
                "1\r\nDresing: Postup na prípravu malinového dresingu nájdete TU.\r\n\r\n2\r\nŠalát: Avokádo zbavíme šupky a kôstky a pokrájame na kocky. Rukolu a maliny umyjeme a osušíme. Všetko spolu zľahka premiešame v miske. \r\n\r\n3\r\nŠalát rozdelíme na dva taniere. Bryndzu v rukách rozdrobíme na šalát. Nakoniec prelejeme malinovým dresingom.",
                "ŠALÁT:\r\n100 g\r\nrukola\r\n0.5 ks\r\navokádo\r\n2 hrste\r\nčerstvé maliny\r\n50 g\r\nbryndza\r\nDRESING:\r\n1 hrsť\r\nčerstvé maliny\r\n1 KL\r\nmed\r\n2 PL\r\nolivový olej\r\n1 PL\r\nvoda\r\n1 vetvička\r\nrozmarín\r\npodľa chuti\r\nsoľ\r\npodľa chuti\r\nmleté čierne korenie"));
            AddRecipe(new Recipe("recept9", "/Obrazky/recepty/recept9.jpg",
                "Mäso môžete pripraviť už hodinu (alebo i dlhšie) pred varením. Zmiešajte mleté hovädzie mäso s worcestrovou omáčkou, vytvarujte do placiek a vložte do chladničky.\r\nDôležité je všetko si vopred nachystať, pretože burger je hotový rýchlo. Vytiahnite mäsové placky z chladničky, osoľte a okoreňte z každej strany. Nakrájajte cibuľu, rajčinu a zaváranú uhorku na hrubšie plátky. Umyte šalát a nechajte ho odkvapkať.\r\nPripravte si taktiež dresing zmiešaním potrebných ingrediencií uvedených vyššie.\r\nMajte prichystané dve panvice. V jednej opečte mäso a v druhej žemle, slaninu a cibuľu. Ak máte k dispozícii gril, samozrejme ho môžete použiť.\r\nMäso smažte z každej strany približne 4 minúty. Čas môžete prispôsobiť podľa toho, aký stupeň prepečenia máte radi. Otočte mäso iba raz a hneď po otočení položte naňho syr.\r\nNo a na záver už len dajte dokopy všetky suroviny, v tomto poradí: žemľa, dresing, šalát, rajčina, mäso, syr, cibuľka, slanina, uhorka, dresing, žemľa.\r\n",
                "500 g\r\nkuracie prsia\r\n300 g\r\nbrokolica\r\n100 g\r\nšampiňóny hnedé\r\n3 PL\r\nolivový olej\r\n1 strúčik\r\ncesnak\r\n0.5 ks\r\nšťava z polovice citróna\r\n3 PL\r\nsójová omáčka\r\n1 ČL\r\ntrstinový cukor\r\npodľa chuti\r\nsoľ, mleté čierne korenie\r\npodľa chuti\r\nchilli"));
            AddRecipe(new Recipe("recept10", "/Obrazky/recepty/recept10.jpg",
                "1\r\nVo väčšom hrnci zahrejeme olej a pridáme nadrobno nakrájanú cibuľku.\r\n\r\n2\r\nCibuľku restujeme, kým nezmäkne a následne pridáme na kocky pokrájaný zeler a mrkvu. Zeleninu zľahka posolíme, hrniec zakryjeme a spolu restujeme na miernom ohni asi 3 minútky.\r\n\r\n3\r\nKeď je zelenina po okrajoch zmäknutá, zalejeme ju asi dvoma litrami vriacej vody. Pridáme na kocky pokrájané zemiaky a tiež prepláchnutú pohánku.\r\n\r\n4\r\nVšetko spolu privedieme k varu a spolu povaríme zhruba 20 minút.\r\n\r\n5\r\nPolievku dochutíme korením, rascou a dosolíme a pred odstavením z ohňa zamiešame do polievky čerstvé bylinky.",
                "2 PL\r\nolej\r\n1 ks\r\ncibuľa\r\n0.25 ks\r\nzeler\r\n2 ks\r\nstredne veľká mrkva\r\n4 ks\r\nstredne veľký zemiak\r\n100 g\r\nlúpaná pohánka\r\npodľa chuti\r\nsoľ, mleté čierne korenie, mletá rasca\r\npodľa chuti\r\nčerstvé bylinky (petržlenová vňať, kôpor, tymian, ...)"));
            AddRecipe(new Recipe("recept11", "/Obrazky/recepty/recept11.jpg",
                "1\r\nOčistené zemiaky postrúhame na jemno (ideálne strúhadlom na pyré) a vo väčšej mise zmiešame s múkou a soľou. \r\n\r\n2\r\nVo väčšom hrnci necháme zovrieť osolenú vodu a cesto pretláčame priamo do vody cez sitko na halušky. Halušky budú uvarené zhruba za 10 minút, alebo keď všetky vyplávajú na povrch.3\r\nPredtým ako halušky scedíme odoberieme malú naberačku vody, v ktorej sa varili. Vo väčšej mise potom zmiešame bryndzu, smotanu, rozpustené maslo a vodu z halušiek. Do tejto zmesi pridáme scedené halušky a dobre premiešame. \r\n\r\n4\r\nSlaninku pokrájame na malé štvorčeky a na panvici opečieme do chrumkava. Halušky podávame posypané opečenou slaninkou a preliate slaninkovým omastkom.   ",
                "1 kg\r\nzemiaky\r\n250 g\r\npolohrubá múka\r\n1 KL\r\nsoľ\r\n250 g\r\nbryndza\r\n200 ml\r\n33% smotana na šľahanie\r\n100 g\r\nmaslo\r\n300 g\r\noravská slanina"));
            AddRecipe(new Recipe("recept12", "/Obrazky/recepty/recept12.jpg",
                "1\r\nRukolu umyjeme. Mandarínku ošúpeme a nakrájame na kúsky. Pomelo ošúpeme a nafiletujeme – mesiačiky dužiny vyrežeme z vnútorných blán, nakrájame.\r\n\r\n2\r\nGranátové jablko rozrežeme na polovicu a zrnká z neho vyklepeme vareškou alebo lyžicou. Všetko dáme do misy, osolíme, okoreníme.\r\n\r\n3\r\nPripravíme dresing, zalejeme šalát a premiešame. Ak chceme výdatnejšiu verziu, pridáme slaný syr – fetu alebo ovčí syr.",
                "\r\n250 g\t\r\nrukola\r\n4 ks\t\r\nmandarínka\r\n1 ks\t\r\npomelo\r\n1 ks\t\r\njablko granátové\r\nkorenie štyroch farieb drvené\r\nsoľ\r\nDresing:\r\nz 1 mandarínky\t\r\nšťava mandarínková\r\npodľa chuti\t\r\nšťava citrónová\r\nmed\r\nvoda\r\nsoľ"));
            

           

            if (Recipes.Count > 0)
            {
                ListViewRecipes.ItemsSource = Recipes;
            }


        }
        public void WriteOut() 
        {
            string connectionString = "server=localhost;UID=root;password=Lukas230920051508;database=kucharka;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            // create a SQL query to insert a new recipe
            string query = "INSERT INTO recepty (nadpis, ingrediencie, postup, adresaObrazku) VALUES (@nadpis, @ingrediencie, @postup, @adresaObrazku)";
            MySqlCommand command = new MySqlCommand(query, connection);
        }
        public void AddRecipe(Recipe recept)
        {
            recipes.Add(recept);
            

        }
        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Recepticky s = new Recepticky();
            
            Recipe selectedRecipe = (Recipe)((Border)sender).DataContext;
            s.DataContext = selectedRecipe;
            NavigationService.Navigate(s);
            

        }

        private void MenuAsiLol_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
