using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Reflection;
using System.ServiceProcess;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using EO.WebBrowser;
using EO.WebEngine;
using EO.WinForm;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using Microsoft.Win32;
using Poshmark_tools;
using SEO_BB.Harvester;

namespace WindowsFormsApplication1;

public class Form1 : MetroForm
{
	private struct cef_download
	{
		public string path;

		public string link;
	}

	private class Browser
	{
		public string Name { get; set; }

		public string Path { get; set; }

		public string IconPath { get; set; }

		public string Version { get; set; }
	}

	public static string _new_user_key = "";

	public static List<string> brands_list = new List<string>();

	public static string found_email = "";

	public static string schedule_end_date = "Not permitted";

	public static string schedule_textbox_expiry_date = "";

	public static string registration_label = "";

	public static string regisration_status = "";

	public static string schedule_rows = "3";

	public static Form1 mainform;

	public static string Enl_permission = "Not permitted";

	public static string bulk_edit_permission = "Not permitted";

	public static string report_registration = "Not permitted";

	public static string user_key = "";

	public static string poshmark_username = "";

	public static string protoll_registration = "";

	public static string InstaPosh_registration = "";

	public static string proLeed_registration = "";

	public static string pinterest_registration = "";

	public static Thread thread2;

	public static Thread t;

	public static Thread restart_thread;

	public string hidden_path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\system.pt";

	public string bulk_permission_hidden_path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\system_b.pt";

	public static CookieContainer ck;

	public static string expiry = "";

	public static int captcha_solved = 0;

	public static string firefox_path = "";

	public static Thread t_browser;

	public Thread infinite_thread;

	public static bool firefox_ver = false;

	public static int app_instances_MAX = 4;

	public static extract_data ed;

	public static login_poshmark lg = new login_poshmark();

	public static webrequests wb = new webrequests();

	public static DateTime today_date_microsolft;

	public static string like_comment_save_path = Directory.GetCurrentDirectory() + "/help_files/lk_cm.pt";

	public static string schedule_save_path = Directory.GetCurrentDirectory() + "/help_files/schd.sch";

	public static string credential_path = Directory.GetCurrentDirectory() + "/help_files/cre.cd";

	public static bool _canadian_Check = false;

	private static List<cef_download> unsuccessfull_downloads = new List<cef_download>();

	public static Pro_tools pro_tools_class = new Pro_tools();

	public static Pro_leads pro_leads_class = new Pro_leads();

	public static Pro_closet_backup pro_closet_backup_class = new Pro_closet_backup();

	public static Pro_enl pro_enl_class = new Pro_enl();

	public static Pro_influencer pro_influencer_class = new Pro_influencer();

	public static Pro_share_follow_schedules pro_share_follow_schedules_class = new Pro_share_follow_schedules();

	public static Pro_configurations pro_configuration_class = new Pro_configurations();

	public static Pro_bulk_price_editor pro_bulk_editor = new Pro_bulk_price_editor();

	public static Pro_browser pro_browser = new Pro_browser();

	public static Register register_control = new Register();

	public static About_us about_us_class = new About_us();

	public static WebBrowser news_webbrowser_2 = new WebBrowser();

	public static news news_class = new news();

	public static WebBrowser brower_webbrowser_2 = new WebBrowser();

	public static WebControl eob = new WebControl();

	public static string cookie_save_path = update_app.folder_path + "\\login_data.csft";

	public static Pro_report pro_report_class = new Pro_report();

	public static string _2captcha_key = "";

	public static string _2captcha_password = "";

	public static string hidden_path_trial = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\system.ppt";

	public static string ALL_brands = "!it jeans,& Other Stories,1 Madison,1 Oak,1. State,10 Crosby Derek Lam,10.Deep,100% Pure,11 By Boris Bidjan Saberi,1154 Lill Studio,11thstreet,12 Pm By Mon Ami,143 Girl,143rd Style Haus,14th & Union,17 Sundays,17/21 Exclusive Denim,17basics,1822 Denim,19 Cooper,1901,191 Unlimited,1928,1955 Vintage,1989 Place,1D,1st Kiss,2 a T Boutique,2 Chic,2 Cute,2 Lips Too,2.1 Denim,212 Collection,21men,24/7 Comfort Apparel,24th & Ocean,26 International,2B Bebe,2B.Rych,2bamboo,2Chillies,2kuhl,2tee Couture,2xist,2xu,3 Royal Dazzy,3 Sisters,3.1 Phillip Lim,3.1 Phillip Lim for Target,31 Bits,32 Degrees,337 Brand,36 Point 5,360 Cashmere,360 Sweater,385 Fifth,3C4G,3M Thinsulate,3Pommes,3x1,40weft,41 Hawthorn,47,5 Seconds Of Summer,5.11 Tactical,5/48,51Twenty,52 Weekends,525 America,579,5th & Love,5th & Ocean,5th Culture,6 degrees,6 Shore Road,686,7 Diamonds,7 For All Mankind,77kids,8 Other Reasons,80%20,89th & Madison,9.2 By Carlo Chionna,90 Degree By Reflex,9fifty,@danglina,A Fine Mess,A Girl Thing,A Is For Audrey,A Knitch Above,A Mermaid's Epiphany,a new day,A Pea in the Pod,a'gaci,A'Reve,A+ Ellen,A. Byer,A. Giannetti,A. Marinelli,a. testoni,A.J. Bari,A.J. Morgan,A.L.C.,a.n.a,A.P.C.,A.P.N.Y.,A.X.N.Y. American Exchange,A/X Armani Exchange,A2 By Aerosoles,A3 Design,Aa Studio,Aaron Ashe,Aaron Chang,AB Studio,Abaete,Abas,Abbeline,Abbey Dawn,Abbie's Anchor,Abbot Main,ABBY & GRACE,Abella,Abeo,Abercrombie & Fitch,abercrombie kids,Abi Ferrin,Abound,About A Girl,ABS Allen Schwartz,Abs Platinum,Absolute Angel,Absolutely,Absolutely Creative Worldwide,Absolutely Famous,Absorba,Abyss By Abby,acacia swimwear,Access Denied,Accessorize,Accessory Collective,Accidentally In Love,Ace & Jig,Acemi,Acevog,Acnaib Swim,Acne,Acorn,Acquitted Apparel,Acrobat,Active Basic,Active Life,Active Ride Shop,Active USA,Actra,Ada,Adam,Adam by Adam Lippes,Adam Levine Collection,Adam Lippes For Target,Adam Tucker,Add Down,Addicted Brands,Addiction,Adee Kaye,Adelyn Rae,aden + anais,Adia,Adia Kibur,adidas,Adidas by Stella McCartney,Adiktd,Adiva,ADMU,Adolfo,Adolfo Dominguez,Adonna,Adore,Adore Me,Adriana New York,Adrianna Papell,Adrienne,Adrienne Landau,Adrienne Maloof,Adrienne Vittadini,Advance Apparels,Adventure Time,aerie,Aerin,Aerology,Aeronautica Militare,Aeropostale,AEROSOLES,Aesthetica,Aetrex,AFF,Affinitas,Affliction,Affordable Fashion Finds,After Six,Ag Adriano Goldschmied,Agatha Cub,Agatha Ruiz De La Prada,Agave,AGB,Agenda,Agent Provocateur,Agl,Aglini,Agnes & Dora,Agnes B.,Agolde,Agora,Agua Bendita,Ahnu,ai riders on the storm,Aidan Mattox,Aigle,Aiko,Aimee Kestenberg,Aina Be,Air Balance,Airwalk,Aj Morgan,Aj Valenci,AKA New York,Akademiks,Akiko,AKIRA,Akoo,Akribos XXIV,Akris,Akris Punto,Akualani,Alaia,Alain,Alala,Alan Flusser,Alan K,Alan Stuart,Alara,Alba,Albert Nipon,Alberta Di Canio,Alberta Ferretti,Alberto Fermani,Alberto Guardian,Alberto Makali,Albion,Alden,Aldo,Alegria,Alejandro Ingelmo,Alessandro Dell'Acqua,Alessi,Alex and Ani,Alex Evenings,Alex Marie,Alex Mill,Alexander Julian,Alexander McQueen,Alexander Olch,Alexander Wang,Alexandra Bartlett,Alexandra Neel,Alexandre Birman,Alexandre Plokhov,Alexia Admor,Alexia Designs,Alexis,Alexis Bittar,Alexis Hudson,Alfani,Alfred Angelo,Alfred Dunner,ALFRED SUNG,ALI & JAY,Ali & Kris,Ali Ro,Alia,Alice & Trixie,Alice & You,Alice + Olivia,Alice Blue,ALICE by Temperley,Alice McCall,Alice Moon,Alicia Jean,Alife,Alisa Michelle,Alisha Hill,Alisha Levine,Alivia Simone,All For Color,All Saints,All that Jazz,All Things Fabulous,allbirds,Allegra K,Allegri,Allen Allen,Allen B. By Allen Schwartz,Allen Edmonds,Allie & Rob,Allison Brittney,Allison Daley,Allison Izu,Allison Morgan,Allison Taylor,ALLOY,Allure,Allure Bridals,Ally B,Allyson Whitmore,Almay,Almia,Almost Famous,ALO Yoga,Aloha Island,Alpha Industries,Alpha Massimo Rebecchi,Alphalete,Alpine Design,Alpine Swiss,Alpinestars,Alquimia,Alstyle,Altamont,Altar'd State,Altea,Alternative,Alternative Apparel,Altra,Altru,Altuzarra,Altuzarra For Target,Aluna Levi,Alviero Martini,Alvin Valley,Alvina Valenta,Always For Me,Alya,Alyce Paris,Alyn Paige,Alyssa Nicole,Alythea,Alyx,Amalfi,Amanda & Chelsea,Amanda Lane,Amanda Smith,Amanda Uprichard,Amandine,Amazing Lace,Amber & Vanilla,Amber Hagen,Ambiance,Ambrielle,AME Sleepwear,Ameda,Amelia James,Ameribag,American Age,American Apparel,American Bazi,American City Wear,American Colors,American Dream,American Eagle By Payless,American Eagle Outfitters,American Exchange,American Fighter,American Girl,American Living,American Needle,American Princess,American Rag,American Retro,American Stitch,American Threads,American Tourister,American Twist,American Vintage,American West,Amethyst Jeans,Ami,Ami Alexandre Mattiussi,Amiana,Aminco,Amirah,AMIRI,Amisu,Amor Adore,Amoralia,Amore Pacific,Amour Vert,Amrita Singh,Amsale,Amuse Society,Amy Byer,Amy Coe,Amy's Closet,Anac,Anage,Analili,Analog,Anama,Ananda Design,Anastasia,Anastasia Beverly Hills,Anatomie,anchor blue,Ancient Greek Sandals,And1,Anderson Bean,Andre Assous,Andre Oliver,Andrea Candela,ANDREA FENZI,Andrea Jovine,Andree,Andrew & Co,Andrew Charles,Andrew Christian,Andrew Fezza,Andrew Geller,Andrew Marc,Andrew Stevens,Andy & Evan,Aneka Brown Designs,Anemone,Angel,Angel Biba,Angel Dear,angel forever,Angel Kiss,Angel Of The North,Angel Ribbons,Angela & Alison,Angela Moore,Angela Roi,Angelica,Angelina,Angelique's Atelier,angelochekk boutique,Angels,Angels & Diamonds,Angels Jeans,Angie,ANGL,Angry Rabbit,Angulus,Aniina,Animal,Animale,Anine Bing,Anita,Anitanja,Anlo,Ann Chery,Ann Demeulemeester,Ann Ferriday,Ann Loren,Ann Marino,Ann Michell,Ann Taylor,Ann Taylor Factory,Anna,Anna & Ava,Anna And Frank,Anna Beck,Anna Grace,Anna Scholz,Anna Sui,Annabel Ingall,Annabella,Annabelle,Annalee + Hope,Anne Carson,Anne Cole,Anne Fontaine,Anne Klein,Anne Klein Sport,Anne Marie,Anne Michelle,Annee Matthew,Annianna,Annie,Annie Griffin,Anniel,Anny Lee,Anoname,Antelope,Anthem of the Ants,Anthony Richards,Anthropologie,Anti Social Social Club,Antigua,Antik Batik,Antik Denim,Antik Kraft,Antilia Femme,Antique,Antique Rivet,Antonio Marras,Antonio Maurizi,ANTONIO MELANI,Antony Morato,Antonym,Antthony,Anuschka,Anvil,Anya Hindmarch,Anyi Lu,Apana,APC,Apepazza,Aperture,Aphorism,Aphrodite,Apiece Apart,APL,Apollo Jeans,Apollo Swim,Apostrophe,Appaman,Apparel Candy,Apparenza,Apple Blossoms,Apple Bottoms,Appleseed's,Aprico,Apricot Lane,April Cornell,April Spirit,Apt. 9,AQ/AQ,AQS,Aqua,Aqua Madonna,Aquarama,Aquarium Kidz,Aquascutum London,Aquaswiss,Aquatalia,Aquazzura,Ara,Aran Crafts,Aran's Den,Arawak Jewelry,Arbonne,Arbor,Arc'teryx,Arcadia,Archaic,Arche,Ardell,Arden B,Ardene,ARE YOU AM I,Area Trend,Areve,Argento Vivo,Aria,Ariana Grande,Arianne,Ariat,Ariella,Arigrl,Aris,Aritzia,Ariya,Arizona Jean Company,Ark & Co,Armani Collezioni,Armani Exchange,Armani Jeans,Armani Junior,Armata Di Mare,Armitron,Armor Lux,Arnette,Arnhem,Aroma Home,Array,Arrow,Art And Soul,art class,Arthur George,Articles Of Society,Artisan Moon,Artisan Ny,Arturo Chiang,Aryeh,Aryn K,As U Wish,Ascend,Ash,Ashish,Ashlee Natalia,Ashley Ann,Ashley Blue,Ashley Bridget,Ashley By 26 International,Ashley Cooper,Ashley Graham,Ashley Judd,Ashley Mason,Ashley Nell Tipton,Ashley Nicole Maternity,Ashley Stewart,Ashro,Ashworth,Asics,Asilio,Asolo,ASOS,ASOS Curve,ASOS Maternity,ASOS Petite,Aspeed,Aspen Rise,Aspesi,Asphalt,Asphalt Yacht Club,Aspire,ASSETS by Sara Blakely,Assets By Spanx,Astars,Astr,At Last,Atelier Sona,Athena,Athena Alexander,Athleta,Athletech,Athletic Works,Atid Clothing,Ativa,ATM Anthony Thomas Melillo,Atmosphere,Atsuyo et Akiko,attention,Attilio Giusti Leombruni,Attyre,Atx Mafia,Au Jour Le Jour,Audemars Piguet,Auditions,audrey,Audrey & Grace,Audrey 3+1,Audrey Ann,Audrey Brooke,August Hats,August Max,august silk,August Steiner,Augusta Sportswear,Aura,Aurielle,Austen Heller,Austin Clothing Co.,austin gal,Austin Reed,Australia Luxe Collective,Authentic American Heritage,Authentic Original Vintage Style,Autumn Cashmere,AUW,Ava & Aiden,Ava & Grace,Ava & Viv,Ava Sky,Avalanche,Avalon,AVEDA,Aventura,Avenue,Avia,Aviana,Aviator Nation,Avital & Co Jewelry,Avon,Awake,AX Paris,AX Paris Curve,Axcess,AXIOLOGY,Axist,Azazie,B Brian Atwood,B Darlin,B Jewel,B-Long Boutique,B-Low the Belt,b. makowsky,B. Smart,B. Swim,B.L.E.U.,b.o.c.,Babe & Tess,Babiators,BabiesRUs,Baby Aspen,BaBy BanZ,Baby Be Mine,Baby CZ,Baby Deer,Baby Essentials,Baby Fanatic,Baby Gear,Baby Graziella,Baby Leg,Baby Nay,Baby Phat,Baby Soy,Baby Starters,Baby Steps,BabyBriefcase,Babymel,Baccarat,Baccini,Bacco Bucci,Bachrach,Back2Basics,Badgley Mischka,Baffin,bagatelle,Baggallini,BAGGU,Bagutta,Bailey 44,bailey blue,Bailey Of Hollywood,Baja East,Baker by Ted Baker,Bakers,Balance Collection,Balenciaga,balera,Bali,Ballantyne,Bally,Balmain,BAMBOO,ban.do,Banana Republic,Banana Republic Factory,Bananamoon,Band of Gypsies,Band Of Outsiders,Bandolino,Banjanan,Bape,Bar III,Barba,Barbara Bui,Barbara Speer,Barbie,Barbour,Barco Uniforms,Bardot,Bare Anthology,Bare Escentuals,Bare Necessities,Barefoot Dreams,Barella Girl,bareMinerals,Barena,BareTraps,Bargain Cable,Bari Jay,Bark,Barney Cools,Barneys New York,Barneys New York CO-OP,Baron Von Fancy,Barton Perreira,Barts,Base London,Basic Editions,Basicon,Basler,Bass,Batman,BaubleBar,Bay Studio,BB Dakota,BC Footwear,BCBG,BCBG Paris,BCBGeneration,BCBGirls,BCBGMaxAzria,bcg,BCX,BDG,Be & D,BE COOL,be inspired,Be Seen Sales,Be Still Boutique,Beach Bunny,Beach Riot,Beachbody,Beachcoco,beachlunchlounge,Bear Dance,BearPaw,Bearsland,Beatnix Fashions,Beautees,beauticontrol,Beautify Beautique,Beauty & Bling,Beauty Creations,beautyblender,beautycounter,bebe,Bebe au Lait,BeBop,Bec & Bridge,BECCA,Bed Stu,BedHead,Beeko,Behnaz Sarafpour,Beige by eci,Beijo,Belabumbum,belk,belkin,Bella & Nash Boutique,Bella Amore,Bella Canvas,Bella D.,Bella Dahl,Bella Edge,Bella Luxx,Bella Marie,bella Perlina,Bella Rene,Bella Vita,BELLAMI,Bellamie,Bellanblue,Bellatrix,BellaVictoriaBoutique,Belldini,Belle by Sigerson Morrison,Belle Du Jour,Bellerose,Bellfield,Belli Skincare Maternity,Bellini,Bellino Clothing,Bellwood,Belly Bandit,Belly Dance Maternity,BellyBra,Belstaff,Beltshazzar Jewelry,BeMaternity,Ben Davis,Ben Nye,Ben Sherman,Ben-Amun,Bench,Benefit,Bensimon,BeOnly,Beora Jewelry,Berghaus,Berle,Bernardo,Bernie Dexter,bernie mev.,Bershka,Berwich,BespokeFit,Best Fairy Dust Wishes,Best Hombre Fashion,Betabrand,Bethany Mota,Betsey Johnson,Betsy & Adam,Better Be,BETTER BODIES,Bettie Page,Betty Boop,bettye muller,Betwoin,Beulah,Beverly Drive,Beverly Feldman,Beverly Hills Polo Club,Beyond the Bump,Beyond Yoga,BGU (Big Girls United),BH Cosmetics,BHLDN,Big Buddha,Big Chill,Big Star,Bijoux Terner,Bikini Nation,Bikkembergs,Bila,bill blass,Bill Levkoff,Billabong,Billieblush,Billionaire Boys Club,Billtornade,Billy Jealousy,Billy Reid,Bioworld,Bird by Juicy Couture,Birkenstock,Biscotti,Bisou Bisou,Bit & Bridle,Bite Beauty,Bitten by Sarah Jessica Parker,Bixbee,Bjorn Borg,Bjorndal,BKE,Black,Black Bead,Black Brown 1826,Black Diamond,Black Halo,Black Matter,Black Orchid,Black Poppy,Black Rainn,Black Rivet,Black Scale,Black Swan,BlackCherry,Blackheart,Blackmilk,Blackstone,Blade + Blue,Blair,blanc noir,Blancheaux Boutique,Blank NYC,BLANQI,Blaque Label,Blauer,bleuh ciel,Bliss,BLK DNM,Bloch,Blomor,Blonde-Tees,Blondie Nites,Blondo,Blood Brother,bloom,Bloomingdale's,Blossom & Thorn,Blowfish,Blu Pepper,Blu Planet,Blue & Cream,Blue 84,Blue Apple Co.,Blue Asphalt,Blue Bird,Blue Blush,Blue Fish,Blue Life,Blue Q,Blue Rain,Blue Rooster Collection,Blue Sky,Blue Spice,Blue Willi's,Bluebelle,Blueberi Boulevard,Blumarine,Blundstone,Blush,Blush by Us Angels,BLVD,BMW,Bob Mackie,Bobbi Brown,Bobbie Brooks,Bobby Jones,bobeau,bobi,Bobo Choses,Bobux,boc,Boconi,Boden,Body After Baby,Body Central,Body Glove,Boglioli,Bogner,Bogs,Boheme,Boho Gypsy Sisters,BohoBeauRoseBoutique,bolle,Bon Bebe,Bondhu,BONGO,Bonnibel,Bonnie Baby,Bonnie Jean,Bonobos,Bonpoint,Bonton,Boob Design,Boohoo,Boohoo Petite,Boohoo Plus,Boom Boom Jeans,Bordeaux,Bordello,Borger Shoes,Boris,Born,Bosca,Boss Black,BOSS ORANGE,Bossy's Boutique,Boston Proper,Bostonian,Botkier,Bottega Veneta,Bourbon and Bowties,Boutique 9,Boutique By The Bay,Bow & Drape,boxercraft,Boy + Girl,Boy Meets Girl,boy. by Band of Outsiders,Boys + Arrows,Bozzolo,bp,Braciano,Brahmin,Brandon Thomas,Brandy Melville,Brash,Brat Star,Bravado,Breckelles,Breed,Breezy Excursion,Breitling,Brian Atwood,Brian Dales,Bric's,Briggs & Riley,Briggs New York,Brighton,Brioni,British Khaki,Brittany Black,Brixon Ivy,Brixton,Bronx,Brooklyn Industries,Brooks,Brooks Brothers,Brooksfield,Browning,Brunello Cucinelli,Bruno Bordese,Bruno Magli,bryn Walker,Bryna Nicole,btween,Bubblegum,bucco,Bucket Feet,Buckle,Buddy Basics,Buddy Love,Budweiser,Bueno,Buff,Buffalo David Bitton,BuffBunny,Bugatchi,Bugatti,Bugle Boy,Build-A-Bear,BULGA,Bulgari,Bullhead,Bulova,Bumkins,Bumper,BumpStart,Bunnies by the Bay,Bunny Dear,Burberry,Burgmeister,burnside,Burt's Bees,Burt's Bees Baby,Burton,Buscemi,Butter,butter LONDON,Butter Shoes,buttons,Buxom,Buxton,Bwear,by & by,by the way.,Byblos,Byer California,Byron Lars,C de C,C Label,C&C California,C'est Ca New York,C. Luce,C. Wonder,C.C,C.I. Castro,C.P. Company,C/MEO Collective,C2 by Calibrate,C9 by Champion,Cabela's,Cabernet,CAbi,Cabin Creek,Cable & Gauge,Caboodles,Cabrini,Cache,Cache Coeur,Cachet,Cacique,Cactus,Cake,CALIA by Carrie Underwood,California Waves,Call It Spring,Callahan,Callaway,Callie Lives,Callisto,Cals,Calvin Klein,Calvin Klein Collection,Calvin Klein Jeans,Calvin Klein Underwear,Calypso St. Barth,Camelbak,cameo,Camilla,camilla & marc,Camille La Vie,Camo,Camper,Canada Goose,Canali,Candie's,Canon,Cantarelli,Canyon River Blues,Caparros,Cape Robbin,Capelli of New York,Capezio,Capsul Jewelry,Capsule Jewelry,Cara Couture,Caramel,Carbon,Care Label,Caren Sport,Cargo,Carhartt,Caribbean Joe,Caribbean Queen,Carleoni,Carlisle,Carlos Falchi,Carlos Santana,Carmakoma,Carmar,Carmen Marc Valvo,Carol Rose,Carole Little,Carolee,Carolina Herrera,Caroline Bosmans,Carolyn Taylor,Carrera,Carter's,Cartier,Caruso,Carve Designs,Carven,Casadei,Cascade Collective,case-mate,Casetify,Casio,Caslon,Casual Corner,Cat & Jack,Catalina,Caterpillar,Cath Kidston,Catherine Malandrino,Catherine Popesco,Catherines,Cathy Daniels,Cathy Jean,Catimini,Cato,Caution To The Wind,Cazal,CC Boutique,CC Resorts,CC Skye,CCM,CDC,CeCe,Cecico,Cejon,Celebrity Pink,Celeste,Celestial Bodiez,Celine,Cello,Celtek,Central Park West,Ceremony by Joanna August,Cesare Paciotti,Cesca,Cette,cha cha vente,Chaco,Chadwicks,Chalona,CHALOU,Chamilia,Champagne,Champion,Champs,Chan Luu,CHANEL,Chantelle,Chaps,Chapter,Charles Albert,Charles David,Charles Henry,Charles Jourdan,Charles Tyrwhitt,Charley&Me,Charlie Banana,charlie jade,Charlie Paige,Charlie Rocket,Charlotte Olympia,Charlotte Ronson,Charlotte Russe,Charlotte Tarantola,Charlotte Tilbury,Charming Charlie,Charriol,Charter Club,Charvet,Chase + Chloe,Chase Authentics,Chaser,Chateau,chatties,Chaus,Cheap Monday,Chelsea & Theodore,Chelsea & Violet,Chelsea & Zoe,chelsea crew,Chelsea28,Cherish,Cherokee,Chesca,Chesley,Chetta B,Chey Mina Brand,Chi Chi London,Chi Swimwear,Chiara Boni,chic,Chic by the Beach,CHICBOMB,Chico's,Chicwish,child of mine,Child of Wild,Children's Place,Chin Up Apparel,Chinese Laundry,Chip & Pepper,Chipie,Chippewa,Chloe,Chloe + Isabel,Chloe K,Chloe Sevingy for Opening Ceremony,Chocolate,Choices,Choies,CHOISE,chooka,Chooze,Chopard,Chor,Chris & Carol,Chris Benz,Christian Audigier,Christian Lacroix,Christian Louboutin,Christian Siriano,Christina,Christine Alexander,Christopher & Banks,Christopher Blue,Christopher Kane,Christopher Raebur,Christy Dawn,Chrome Hearts,chubbies,Church's,Ci Sono,Ciao Lola,Ciate,Cielito Lindo,Cienta,Cinch,Cinderella,Cinderella's Closet,cinq a sept,Circo,Circus by Sam Edelman,Ciso,Citizen,Citizens Of Humanity,City Chic,City Color,City Streets,City Studio,City Threads,City Triangles,Cityclassified,Civas,CJ Banks,CL by Laundry,Clae,Claiborne,Claire's,Clare Vivier,Clarins,Clarisse,Clarks,Class Club,Class Roberto Cavalli,Classic,Classic Elements,Classic Woman,Classified,Classiques Entier,Claudia Richard,Clayeux,cle de peau,cleo,Cleo Harper,Cleobella,Clinique,Clio,clmayfae,Clmayfae Wholesale,Closed,Closet,cloth & stone,Cloud 9,Cloud B,Cloud Chaser,cloud island,Cloudbase,Clover Canyon,Club Monaco,Club Room,CN G,CNC Costume National,CO,Coach,Coach and Four,Coastal Scents,Cobian,Coca Cola,Coccoli,COCLICO,Coco Rave,Coco Reef,Cocomo,Coconuts by Matisse,CoffeeShop,Cold Crush,Coldwater Creek,Cole Haan,Coleen Bow,Colette Malouf,Colin Stuart,Collectif,Collection B,Collection XIIX,Collective Concepts,Collective Rack,Color Story,Color Street,Colors of California,Colosseum,Colourpop,Columbia,Comfort Colors,comfort plus by Predictions,comfortview,Commando,Comme des Garcons,Common Projects,Como Vintage,Comptoir Des Cotonniers,Concept K,connected apparel,Connection 18,Connie,Consuela,Context,Contourelle,Converse,coobie,COOGI,Cookie Lee,cooper & ella,Cooperative,Copper Key,Coral Bay,Corkys,Corneliani,Coro,Corona,Corral,Corso Como,COS,Cosabella,Cosmopolitan,Cost Plus World Market,Costa,Costa Blanca,Costume National,Cotton Candy,Cotton Emporium,Cotton Express,Cotton On,Cotton Whisper,Coulbourne,Counterparts,Country Kids,Country Mermaids,Courtenay,Couture Gypsy,Couture Trading Co,COVER FX,COVERGIRL,Coveted Clothing,Covington,Cowgirl Tuff,CP Shades,Craft,Craghoppers,Crash & Burn,Crazy 8,Crazy Dog T-Shirts,Crazy Train,Createilogy,Creative Adornment,Creative Recreation,Crescent,Crest,Crevo,Crewcuts,Cristiani,Cristinalove,CROCS,croft & barrow,Crooks & Castles,crosby.,Croton,Crown,crown & ivy,Crown Vintage,Cruciani,Cruel Girl,Cruyff,Crystal Doll,Cubavera,Cuddl Duds,Cufflinks Inc.,Cult of Individuality,cupcakes & cashmere,Cupcakes & Pastries,Cupid,Cupio,Cupoftea,Cupshe,Curfew,Current/Elliott,Cursing Ballerina,Curvy Couture,Custo Barcelona,cut loose,Cut25 by Yigal Azrouel,Cutter & Buck,Cuyana,Cyberjammies,Cynthia Rowley,Cynthia Steffe,Cynthia Vincent,Cyrillus,Cyrus,D Celli,D&G,D&Y,D'Or Skincare,d. jeans,D.Green Designs,Da-Nang,Dagne Dover,Dainty Hooligan,Daisy,Daisy Fuentes,Daisys Boutique,Dakine,Dakini,Dale of Norway,Dalia,Dalia Collection,Damir Doma,Damo,Damon Sky,Dan Post,Dana Buchman,Dance & Marvel,Dance Class,Dancing Queen,Dani Rogue,Daniel Cremieux,Daniel Rainn,Daniel Wellington,Daniele Alessandrini,Daniele Fiesoli,Danielle Nicole,Danner,DANNIJO,Danny & Nicole,Danskin,Danskin Now,Dansko,Dantelle,Darling,Dave & Johnny,David Donahue,David Kahn,David Lerner,David Meister,David Yurman,David's Bridal,Dawgs,Daydreamer,Daytrip,DC,DC Comics,De Blossom Collection,Dea London,Deakin & Francis,dear creatures,Dear John,dearfoams,Deb,Debbie Morgan,debut,Decree,dee elle,Deena & Ozzy,Deer Stags,Deesse Lingerie,Dekker,Del Toro,Deletta,dELiA*s,Delicacy,delicates,Delicious,Delightful Designs,Delirious,Della Ciana,Delman,Delta,Delta Burke,Democracy,Demonia,Denham Jeans,Denim & Flower,Denim & Supply Ralph Lauren,Denim 24/7,Denim&Co,Denizen from Levi's,dennis basso,Derek Heart,Derek Lam,Derek Rose,Dereon,Derhy Kids,Dermablend,dermalogica,Design History,Design Lab Lord & Taylor,Designers Originals,Designs on Demand,Desigual,Desired Collection,Dessy Collection,Destination Maternity,Deux Lux,deux par deux,Dex,dexflex comfort,Dexter,Diadora,Dialogue,Diamond Supply Co.,Diamonds & Jules,Diamonique,Diana Broussard,Diane Gilman,Diane Von Furstenberg,Diba,Dickies,Diesel,Diesel Black Gold,Diff Eyewear,Dimepiece,dina be,dingo,Dior,Dirk Bikkembergs,Dirtee Hollywood,Dirty Laundry,Discreet,Disney,DITA,Dittos,Diva,DIVA Lounge,Divided,Dizzy,Dkny,DKNYC,DL1961,DNA couture,DNY,do & be,Dockers,Doe & Rae,Doen,Dogeared,dolan,Dolce & Gabbana,Dolce Vita,Dollcake,Dolled Up,Dollhouse,Dollie & Me,Dolls Kill,Dollz Glamtique,Doma,Dominiue Auxilly,Domino Dollhouse,Donald J. Pliner,Doncaster,Dondup,Donna Karan,Donna Morgan,Donna Ricco,Doo.Ri,Doodle Pants,Dooney & Bourke,Dopp,Doris Streich,Dorothy Perkins,Dose of Colors,Dot Dot Smile,Dots,Dotti,Double D Ranch,Double Zero,Doublju,Doucal's,Doucce,Douuod,DownEast,Dr. Denim,Dr. Martens,Dr. Scholl's,DR2,Drakes,Draper James,Dreamers,Dreamgirl,Dreams are Granted,Dress Barn,Dress the Population,dressbarn,Dresses Unlimited,DREW,Dries Van Noten,Drumohr,DSQUARED,DSW,Duck Head,Dune London,Dunham,Dunhill,duo Maternity,Durango,Duvetica,DV by Dolce Vita,Dx-Xtreme,DYI,dylan,Dynamite,E-Land Kids,E.Kammeyer Accessories,Earl Jeans,Earnest Sewn,Earth,Earth Art hand crafted artisan,Earth Origins,Earth Spirit,EARTHBOUND,Earthies,easel,East 5th,Eastern Mountain Sports,Eastland,Easton,Eastpak,Easy Spirit,easy street,Eberjey,Ecco,Echo,ECI,Ecko Unlimited,Ecote,ecotools,ecru,Ed Hardy,Eddie Bauer,Eden & Olivia,edge,Edgehill Collection,Edith Domen,Edox,EDUN,Edwin,EGO,eight eight eight,Eight Sixty,Eighty Eight,Eileen Fisher,ekattire,Elaine Turner,Elan,Elbon Boutique,Eleanor Rose,Electric Family,Electric Yoga,Elegant Moments,Element,Elemente Clemente,Elements by Nina,Elementz,Elena Grunert,Elena Miro,elephanten,Elephantito,Eleven Paris,elevenses,Eleventy,ELF,Eliana and Eli,Eliana et Lena,Elie Saab,Elie Tahari,Elila,Elini Barokas,Eliot Danori,Elisa Cavaletti,Eliza J,Eliza Parker,Elizabeth and James,Elizabeth Arden,Elizabeth Hurley,Elizabeth McKay,Ella,Ella Moss,Ellbi,Elle,ellebee206,ellemenno,Ellen Tracy,Ellesse,Ellie,Ellie Kids,Ellington,Elliott Lucca,Ellison,ellos,Elodie,Elomi,Eloquii,else,Elvi,Elvis et Moi,Emanuel Ungaro,Embody Denim,Emerald,Emerald & Onyx,Emerald Fashion,Emerald Sundae,Emerica.,Emerson Fry,Emile et Ida,Emile et Rose,Emilio Pucci,Emily Designs,Emily Hsu Designs,Emily Keller,Emily Ray,Emily Rose,Emma & Michelle,Emma & Sam,Emma Fox,Emma James,Emmelee for F.C.,emory park,Emporio Armani,Empowered By You,Empress Lingerie,Empyre,Emu,En Creme,Endless Rose,Energie,Energy Zone,Enfocus Studio,English Factory,English Laundry,english rose,enough about me...,Entre Amis Men,entro,envy,Enyce,Enza Costa,Enzo Angiolini,eos,EP Pro,Epic Threads,Epica Clothing,Equipe,Equipment,ERDEM,Erfurt Tucher,Erge,Eric Javits,Eric Michael,Erica Lyons,Erica Rose,Erickson Beamon,Erika,Erimish,ERIN by Erin Fetherston,erin london,Ermanno Scervino,Ermenegildo Zegna,Escada,Escaladya,escapada,eshakti,eskandar,eskander,Esley,Esley Collection,Espresso,Esprit,Essentials,Essentials by Milano,Estate,Estee Lauder,Estrella & Luna,Etage,Etcetera,Eterna,Eternal Sunshine Creations,Ethik,ethika,Etichetta 35,Etienne Aigner,Etiquette Clothiers,Etnies,Eton,Etro,ettika,Etudes Studio,Eugenia Kim,eunina,European Culture,Eva Alexander,Eva Franco,eva mendes for New York & Company,Evan Picone,Eve,Evelin Brandt,Evereve,Everlane,Everlast,Everly,Everly Grey,Evette Encounters,Evolving Always,EXCHANGE,Exelle,exertek,Exibit,Exist,Exofficio,Expected by Lilac,Express,eye candy,Eye Pop Supply,eyelash couture,Eyeshadow,Eytys,Ezekiel,ezra,fab'rik,fabkids,Fabletics,Fabrizio Del Carlo,Fabulous Furs,Fabutiq,Faconnable,Faded Glory,Faherty,Fahrenheit,Fairchild Baldwin,fairlygirly,Faith and Joy,Faith Connexion,Faithfull the Brand,Falke,Falls Creek,Fame and Partners,Famous Stars & Straps,Fanatics,Fancyinn,FANG,Fantasie,Fantastic Fawn,Farah,Farah Jewelry,Fashion BohoLoco,Fashion Bug,Fashion Jewelry,Fashion Nova,Fashion to Figure,Fashion Union,Fashionomics,Fat Face,Fate,Faviana,Favorite Characters,Fawn Design,Fay,feathers,Feiyue,Felicias,Felicity & Coco,Felina,Feminine Funk,Fender,Fendi,Fenn Wright Manson,Fenty Beauty,Fergalicious,Fergie,Fernweh Boheme,Ferragamo,Ferrari,Ferrecci,Fever,Fever London,Field & Stream,Fiesta,Fifth Sun,Fighting Eel,Figs,Fila,Filling Pieces,Filly Flair,Fillyboo,Filson,Final Touch,Finders Keepers,Finesse,Finger In The Nose,Finish Line,finn & clover,FIONI Clothing,Fiorentini + Baker,Fire Los Angeles,First Aid Beauty,First Impressions,First Looks,First Wave,Fisher-Price,Fisheter,Fitflop,Five Four,Fjallraven,flag nor fail,Flap Happy,Flapdoodles,Flash Tattoo,Flax,Fleo,Fleurish,Flexees,Flint+Feather,flirtitude,Floatimini,Flora Nikrooz,Florence Eiseman,Florsheim,Flowers by Zoe,fluff,Fly London,Flying Monkey,Flying Tomato,Flynn Skye,Foamtreads,Focallure,Focus 2000,Foley + Corinna,Folk,FootJoy,FootMates,For Bare Feet,For Cynthia,For Love And Lemons,Foreign Exchange,Forenza,Forever 21,Forever Unique,Forever Young,Forplay,Fortis,FORTNER FRENZY,Forzieri,Fossil,Foster Grant,Fox,Foxcroft,Fraas,Fragrant Jewels,Frame Denim,Franato,Francesca's Collections,Francesco Biasia,Franco Fortini,Franco Sarto,Frank & Eileen,Frank & Oak,Frankie B.,Frankie Morello,Frankie's Bikinis,Franklin & Marshall,Franklin Covey,Frapp,Fratelli Rossetti,Fraternity Collection,Freakyflax,Fred David,Fred Mello,Fred Perry,Freda Salvador,Freddy,Frederick's of Hollywood,Free and Spirit,Free Country,Free Kisses,Free People,Free Planet,free press,freebird,Freebird by Steven,freecity,Freeloader,Freestyle,Freeway,Freeze,French Atmosphere,French Connection,French Laundry,french pastry,French Toast,Frenchi,fresh,fresh produce,Freshly Picked,Freshman,Freya,FRH,Fruit of the Loom,Frye,FUBU,Full Tilt,Fun & Flirt,fun 2 fun,Fun Mum,Function & Fringe,FunFash,Funko,Funky People,Funkyberry,Funtasma,Furla,Futuro,G by Guess,G-Shock,G-Star,G.H. Bass & Co.,Gabby Skye,Gabriella Rocha,GAIAM,Gallery,gallery_of_gems,Galliano,Gallucci,Game Time,Gander Mountain,Ganesh,Ganni,Gant,GAP,Garage,Garanimals,Garnet Hill,Garrett Leight,GASOLINE GLAMOUR,Gaudi',Gayla Bentley,gaze,Gazzarrini,GB girls,GBX,Generation Love,GENERATION Y,GENERRA,Genetic Denim,Geneva,Geneva Platinum,Gentle Fawn,gentle souls,Gents,Genuine Merchandise,Geoffrey Beene,George,George Simonton,Georgia Boot,Geox,Gerard Cosmetics,Gerard Darel,Gerber,Geren Ford,Gerry Weber,Ghurka,Gia Parks,giacca,Gianfranco Ferre,Giani Bernini,Gianluca Capannolo,Gianmarco Lorenzi,Gianni Bini,Gianvito Rossi,Gibson,Gibson Latimer,Giesswein,giggle Better Basics,Giggle Moon,GiGi New York,Gildan,Gilli,Gilli clothing,Gilligan & O'Malley,Gilly Hicks,gimmicks by BKE,Gina Bacconi,Ginger G,Giorgio Armani,Giorgio Brato,Giorgio Brutini,Giorgio Fiorelli,girl krazy,girlfriend collective,Gitano,Gitman Brothers,Giulia's,Giuliana + Madison,Giuseppe Zanotti,Givenchy,GK,glam,Glam Squad 2 You,Glam Threads Boutique,glamfoxx,GLAMGLOW,Glamorise,Glamorous,Glamour,Glamour & Co.,Glamour Empire,Glamour Kills,Glamvault,Glanshirt,Glaze,Glitz,GLO jeans,Glo Skin Beauty,Globe,Gloria Vanderbilt,Glossier,Glyder,GNW,Go Couture,GoByte,Goddess,GoJane,Gola,Gold Toe,Golden Goose,Golden Threads,Goldsheep,Goldsign,Gomax,Good American,Good Chic,good hYOUman,Good Lad,Goodchic,Goodfellow & Co,Goodnight Macaroon,Gordon Rush,Gorjana,gorman,Gossip,Gossip Girl,Gotta Flurt,Gottex,Goyard,Gozzip,Grace,Grace & Lace,Grace Adele,Grace Elements,Grace in LA,Grace Karin,Grace Loves Lace,Gracia,Gran Sasso,grand & greene,Grand Slam,Grand Style,Grane,grass collection,Grasshoppers,Grateful Dead,Grayers,Grayson Threads,Grazie,Great Expectations,Great Northwest Clothing Company,Greats,Green Apple,Green Envelope,greendog,GreenTea,Greg Norman Collection,Grenson,Gretchen Scott Designs,Grevi,Grey Daniele Alessandrini,Grey's Anatomy,Greylin,Gritu,Grizas,GRLFRND,Gro Company,groove,Gryphon,Gucci,Gudrun Sjoden,GUERLAIN,Guess,Guess by Marciano,Guidi,Gunne Sax,Guy Harvey,GX by Gwen Stefani,Gymboree,Gymshark,Gypsy 05,Gypsy Los Angeles,Gypsy Warrior,H by bordeaux,H by Halston,H By Hudson,H&M,h.i.p.,Haani,Habitat,Habitual,Hackett,Haddad,Haggar,Haia,Haia Accessories,Haider Ackermann,Hailey Logan,Halabaloo,Hale Bob,Half United,Hallmark,Halo,Halo Innovations,Halogen,Halston Heritage,Hamilton,Hammitt,Hanes,Hang Ten,Hanky Panky,Hanna Andersson,Hannah,Hannah Banana,Hannah Beury,Hanro,happening in the present,Happy Mama Boutique,Happy Socks,Harajuku Lovers,Hard Candy,Hard Rock Cafe,Hard Tail,Hardy Amies,Harley-Davidson,Harlow,Harlowe & Graham,Harmont & Blaine,Harold's,Harper,Harper Canyon,Harry's of London,Hart Schaffner Marx,Hartford,Hartstrings,Harve Benard,Harveys,Hasbro,Hatch,Hatley,Haute Ellie,Haute Hippie,Haute Monde,Haute Society,Havaianas,Have,Hawke & Co,Hayden,hazel,HBCali,Head,Head Over Heels,healing hands,healthtex,Heart & Hips,Heart Hips,Heart Moon Star,Heart Soul,Heartloom,HeartSoul,Heather Gardner,Heather Tees,Hebbeding,Heelys,Heidi Daus,Heidi Klein,Heidi Klum Intimates,Helena,Helix,Hell Bunny,Hello Kitty,hello miss,Hello MIZ,Hello Molly,Helly Hansen,Helmut Lang,Helzberg Diamonds,Hem & Thread,henri bendel,Henri Lloyd,Henry & Belle,Henry Cotton's,Henry Ferrera,Her Universe,Her Velvet Vase,Heritage,Heritage 1981,Hermann Lange,Hermes,Herno,Heroine Sport,Herschel Supply Company,Herstyle,Herve Leger,Hi-Tec,Hickey Freeman,High Sierra,Highlevel BYC,Highway Jeans,Hilary Radley,Hillard & Hanson,Hilo Hattie,Hind,hinge,HipFinds,hippie laundry,Hippie Rose,Hive & Honey,HM Leathercraft,hm-moden,Hobie,HOBO,Hogan,Hoka,Hoka One One,HOLDING HORSES,Holiday Editions,Holiday Time,Hollister,Hollywood Rage Wholesale,HOMAGE,Honey and Lace,Honey Belle,Honey Punch,HoneyBee Gardens,Honeydew Intimates,Honeydew USA,Honora,Hood by Air,Hooters,Hope and Harvest,Hope's,Horny Toad,Hosio,Hot & Delicious,Hot Gal,Hot in Hollywood,Hot Kiss,Hot Miami Styles,HOT MILK,Hot Sox,Hot Tomato,Hot Topic,Hot2own Boutique,Hourglass,Hourglass Lady,Hourglass Lilly,House of CB,House of Harlow 1960,House of Holland,House of Lashes,House of Magpie,Howe,HTC,Hublot,HUDA BEAUTY,Hudson Jeans,HUE,Hues of Ego,HUF,HUGO,Hugo Boss,Hugo Buscati,Hula Honey,Hula Star,Hundred Pieces,Hunt Club,Hunter,Hunter for Target,Hurley,Hush Puppies,Hustler Hollywood,hwl boutique,Hybrid & company,Hydraulic,Hydrogen,HydroPeptide,HYFVE,Hype,I Heart Ronson,i jeans by Buffalo,I Love Gorgeous,I Play,I.AM.GIA,I.N. San Francisco,I.N. Studio,ibex,Ice,Ice Iceberg,Iceberg,Icebreaker,Icing,ICON,Iconic Legend,Idea Piu,Ideology,IEdesigned,Igigi,Igor,Igor Dobranic,iHeartRaves,iHome,Ike Behar,IKEA,Ikks,Il Gufo,ILIA,ILLA ILLA,Illesteva,Ilse Jacobsen,Ily Couture,imaginary voyage,IMAN,Imanimo,Imoga,Imoshion,Imperial Motion,Imperial Star,Impo,imPRESS,Impressions,Imps & Elfs,In Bloom,Ina,INC International Concepts,Incase,Incipio,Incotex,Indah,India Boutique,India Hicks,Indigo,Indigo Blue,Indigo Rein,Indikidual,indulge,Infinity Raine,Ing,Ingear,Ingersoll,INGLOT,Ingrid & Isabel,INKnBURN,Insight,Insignia by Sigvaris,Inspire,Inspired Hearts,INTERMIX,intimissimi,Intimo,intro.,Investments,Invicta,Ipanema,Ippolita,ipsy,iRE Fashion,iris,iris & ivy,Iris Basic,Irish Eyes,Irish Setter,IRO,Iron Fist,Iron Man,Irregular Choice,Isaac Mizrahi,Isabel Benenato,Isabel Garreton,Isabel Marant,Isabel Marant pour H&M,Isabel Maternity by Ingrid & Isabel,Isabel Toledo,Isabella Fiore,Isabella Oliver,Isabella Rodriguez,Isaia,ISH,Isis,Island Escape,Isobella & Chloe,Isola,Isolde Roth,isotoner,Issa London,Issey Miyake,ISSI,it cosmetics,It's Our Time,Italian Shoemakers,Itty Bitty Toes,Ivanka Trump,Ivivva,ivory ella,ivy jane,Ivy Kirzhner,IVY PARK,IWC,Iz Byer,Izod,Izzy & Lola,Izzy Maternity,J Brand,J for Justify,J Kara,J-41,J. Crew,J. Crew Factory,J. Jill,J. Khaki,J. Lindeberg,J. McLaughlin,J. Mendel,J.B.S.,J.Elizabeth,J.O.A.,J.Renee,J.W. Anderson,J.W. Tabacchi,Jaanuu,Jaase,Jac Vanek,Jacadi,Jachs,JACHS Girlfriend,Jack and Jones,Jack by BB Dakota,Jack Mason Brand,Jack Rogers,Jack Spade,Jack Wills,Jack Wolfskin,Jaclyn Smith,Jacob Cohen,Jacqueline Ferrar,Jacques Lemans,Jacques Moret,Jade,Jadelynn Brooke,Jag Jeans,Jaggy,Jamberry,Jambu,Jameela Jamil,James & Joy,James Avery,James Campbell,James Jeans,James Perse,jamie sadock,Jams World,Jan Leslie,Jane Ashley,jane iredale,Janessa Leone,Janie and Jack,Janiko,Jansport,Jantzen,January Summer,Japan Rags,Japanese Weekend,Japna,Jared Lang,Jasmine,jason maxwell,Jason Wu,Jax,Jay King,JAYGODFREY,Jayli,Jayne Copeland,JB by Julie Brown,jcpenney,Jealous Tomato,Jean Bourget,Jean Marc Philippe,Jean Paul Gaultier,JEANNE PIERRE,Jeckerson,Jeep,Jeetly,Jefferies Socks,Jeffree Star,Jeffrey & Paula,Jeffrey Campbell,Jella Couture,Jelly Beans,Jelly The Pug,Jellypop,JEM,Jen's Pirate Booty,Jenna Jameson,Jenni,Jenni Kayne,Jennifer Bryde,Jennifer Lopez,Jennifer Meyer,Jennifer Moore,Jennifer's Chic Boutique,Jenny Bird,Jenny Packham,Jenny Yoo,Jeremy Scott,Jeremy Scott x Adidas,Jerome Dreyfuss,Jerzees,Jesi's Fashionz,Jesse Kamm,Jessica Elliot,Jessica Howard,Jessica London,Jessica McClintock,Jessica Simpson,Jette,Jewel Kade,Jewelmint,Jewely's Justifiables,Jey Cole Man,Jezebel,jf j.ferrar,JGoods,JH Collectibles,JHaus,Jibri,Jijil,Jil Sander,Jill Alexander Designs,Jill Marie Boutique,Jill Stuart,Jilsen Quality Boots,Jimmy Choo,Jivago,JJ Cole,JJ Footwear,JK Designs,JM Collection,Jo Malone,Jo-Jo,Joan & David,Joan Calabrese,Joan Rivers,Joan Vass,Joanna August,jocelyn,Jockey,Jodi Kristopher,Jodi's Jewelry,JODIFL,Joe & Elle,Joe B,Joe Benbasset,Joe Boxer,Joe Browns,Joe Fresh,Joe's Jeans,Joey,Jofit,John Ashford,John Deere,John Fluevog,John Galliano,John Hardy,John Lobb,John Richmond,John Smedley,John Varvatos,John W. Nordstrom,Johnny Cupcakes,Johnny Martin,Johnny Was,JohnPaulRichard,Johnston & Murphy,Joie,Jolie,Jolt,Jolyn Clothing,Jon & Anna,Jona Michelle,Jonathan Adler,jonathan martin,Jonathan Simkhai,Jones New York,Jones Studio,Jones Wear,Jordache,Jordan,Jos. A. Bank,Josef Seibel,Joseph,Joseph & Feiss,Joseph Abboud,Joseph Allen,Joseph Ribkoff,Josephine Chaus,Josette,JOSIE MARAN,Josmo,Jou Jou,jouer,Joules,Journee Collection,Jovani,Joy Joy,Joy Lab,Joy Mangano,Joyce Leslie,Joyfolie,Joyrich,JS Boutique,JS Collections,Ju-Ju-Be,Jude Connally,Judith Jack,Judith Leiber,Judith March,Judith Ripka,Judy Blue,Juice Beauty,Juicy Couture,JuJu,Julep,Jules & Leopold,julia jordan,Julian Taylor,julie's closet,Julius,Jump,jumping beans,Jumping Jacks,Juna Blue,Junarose,Junior Drake,Junior Gaultier,Junk Food Clothing,Junya Watanabe,just be,Just Black,Just Cavalli,just ginger,Just Love,Just Me,Just My Size,Just USA,Just...Taylor,JustFab,Justice,Justify,Justin Bieber,Justin Boots,Juun.J,JV Boutique,K-DEER,K-Swiss,K-Way,K/Lab,Kaachi & Co.,Kaari Blue,Kaii,Kaisely,Kaitlyn,Kaktus,Kala Vella,Kali,Kalli Collection,Kamik,KanCan,Kangol,Kangra Cashmere,Kanu Surf,Kanz,Kaos,Kappa,Kara and Kate,Kardashian Kids,Kardashian Kollection,Karen Kane,Karen Millen,Karen Scott,Karen Walker,Karen Zambos,karin stevens,Karina Grimaldi,Karis' Kloset,Karl Lagerfeld,Karlie,Karma,Kasper,Kat Von D,Kate & Mallory,Kate Hill,Kate Landry,Kate Mack,kate spade,Katherine Barclay,Kathie Lee Collection,Kathrono,kathy ireland,Kathy Van Zeeland,Katie K,Katin,Katy Perry Collections,Kavu,Kay Collective,Kay Jewelers,Kay Unger,Keds,Keen,KEEP Collective,KEEPSAKE the Label,Kekoo,Kelly & Katie,Kelly Brook,Kelly Moore,Kelsi Dagger,Kenar,Kendall & Kylie,Kendra Scott,Kenneth Cole,Kenneth Cole Reaction,Kenneth Jay Lane,Kensie,Kensie Girl,kenzie,Kenzo,Kerisma,Kerrits,Kersh,Kerstin Florian,Ketiketa,Ketzali,Kevyn Aucoin,Khaya,Khey's Pick,Khombu,Kiara,Kickee Pants,Kickers,Kid Dangerous,Kid Express,Kid's Dream,Kidgets,Kidorable,Kids Headquarters,Kiehl's,Kiel James Patrick,KIINI,Kiko,Killstar,Kim & Cami,Kim Rogers,Kimchi Blue,Kimi and Kai,Kimmer Kay,King Baby Studio,Kings of Cole,Kinwolfe,Kiola Designs,Kipling,Kirkland Signature,Kirna Zabete,Kirra,Kirsten Moden,Kische,Kiss,Kissy Kissy,Kit and Ace,Kith,Kiton,kitson,Kittenish,Kiwi,Kiyonna,Kj Brand,Kleancolor,Kling,Klogs,Knighbury,Knights Apparel,Knitworks,knot sisters,Knox Rose,Koala Kids,koi,Kokomarina,Kokon To Zai,Kolor,Komar Kids,Komarov,Komono,Konstantino,Kooba,Koolaburra,Koral,Koret,Kori,Kork-Ease,Korres,KORS Michael Kors,Kortni Jeane,KR3W,Kris Van Assche,Kristen Blake,Kristin Miles,Kruger,Krush,KS Selection,Ksubi,Kuhl,Kuinua Co,Kurt Geiger,Kut from the Kloth,Kylie Cosmetics,Kyme,Kyodan,Kyoot Klothing,L&B,L'AGENCE,L'Amour,L'ATISTE,L'OCCITANE,L'Oreal,L'ovedbaby,L'Wren Scott,L'Wren Scott at Banana Republic,l*space,L.A. Gear,L.A. idol,L.A. Shoes,L.A.M.B.,L.B. Evans,L.L. Bean,L.O.L. Vintage,L8teR,La Belle,La Blanca,La Boheme,La CANADIENNE,La Femme,LA Girl,La Hearts,La Leche League International,LA made,La Mer,La Mienne,La Mouette,La Perla,La Prairie,La Regale,La SENZA,La Sportiv,La Stampa,La Stupenderia,Lab. Pal Zileri,LAB40,Lacey Ryan,Lack Of Color,LaClef,Lacoste,LaCrosse,Ladakh,Lady Hagen,Lafayette 148 New York,LAGOS,Lalagen,LAmade,Lamaze,Lamo,Lancome,Landau,Lands' End,Lane Bryant,Laneus,Language,Lani,Lansinoh,Lanvin,Lanvin for H&M,Lapis,LARA,Lardini,Laredo,LaRok,Larry Levine,last kiss,latico,Latigo,Laugh Cry Repeat,Laundry by Design,Laundry By Shelli Segal,Laura Ashley,Laura Geller,laura mercier,Laura Scott,Laurel Burch,Lauren James,Lauren Manoogian,Lauren Merkin,Lauren Michelle,Lauren Moshi,Lauren Ralph Lauren,Lauren Vidal,Laurence Decade,Laurence Kazar,Lavender's Jungle,Lavish,Lavish Alice,LAWLESS,Layer 8,Lazy Oaf,LC Lauren Conrad,LC Trendz,le chateau,Le Coq Sportif,Le Crown,Le Due Sorelle Boutique,Le Lis,Le Mystere,Le Specs,Le Suit,Le Temps Des Cerises,Le Tigre,Le Top,Le Vain,Leachco,Leading Lady,Leather and Sequins,Leather Crown,Lee,Leg Avenue,Lego,lei,leifsdottir,Leila Stone,Leith,Lela Rose,Lelli Kelly Kids,Lemaire,Lemon Loves Lime,Lena,Leo & Nicole,Leona Edminston,Leoninus,Leota,Les (Art)ists,Les Copains,Les Hommes,Les Lunes,leshop,Leslie Fay,LeslieVegan,Lesportsac,Letarte,Letters By Zoe,Level 99,Levi's,Levian,levity,Lewboutiquetwo,LF,Lia Larrea,Lia Sophia,libby. edelman,Liberty Love,Liberty of London,Liberty of London for Target,Libian,Liebeskind,Life After Denim,life in progress,Life Is Good,Life N Jeans,Life Stride,LifeProof,Lija,Likely,likeNarly,Lila Rose,Lilac Clothing,lilah b.,Lili Gaufrette,Liliana,Lilla P,Lillie Ruben,Lillie Rubin,Lilly Pulitzer,Lilly Pulitzer for Target,Lilu,Lily,LILY AND LAURA,Lily Bleu,Lily Bloom,Lily Lotus,Lily Nily,Lily of France,Lily Rose,Lily Star,Lily White,Lilyette,Lime Crime,Limeapple,Limelight,Limited Too,Lina,Linda Farrow,Linden,lindsay phillips,Lindsey Brown Luxe Resort,Lindy Bop,Line & Dot,Linea Donatella,Linea Pelle,Link,Lioness,Lip Service,LipSense,Lipstick Boutique,Lipstick Queen,Lipsy,Liquid Blue,Lira,Lisa Frank,Lisa international,Lissmore,Listicle,Little Eleven Paris,Little Giraffe,Little Green Radicals,Little Karl Marc John,Little Lass,Little Marc Jacobs,Little Marcel,Little Mary,Little Mass,Little Me,Little Miss,Little Mistress,Little Remix,Little Things Mean a Lot,Liu Jo,Live 4 Truth,Live a Little,live and let live,Live Unlimited London,Liverpool Jeans Company,Livie & Luca,living doll,liz & co.,Liz & Me,Liz Baker,Liz Claiborne,Liz Lange,Liz Lange for Target,Liz Larios,LJ Rose,LK Bennett,Lm Lulu,lmw0082,LNA,Lodis,Loeffler Randall,Loewe,LOFT,Loft Fashion,LOGO 7,LOGO by Lori Goldstein,Lois Hill,Lokai,lola,Lola Getts Active,Lola Shoetique,Lole,Lolli,Lolly Wolly Doodle,London Fog,London Sole,London Style,London Times,London Trash,LONDONJEAN,Long Elegant Legs,long tall sally,Longaberger,Longchamp,Longines,lonna & lilly,Loola,Loomstate,Loot Crate,LORAC,Lord & Taylor,Loren Hope,lorenzo,Lorenzo Uomo,Lorna Jane,Loro Piana,Lost,Lot801,Lou & Grey,Loudmouth,Louis Vuitton,Louise et Cie,Loungefly,Loup,Love,Love & Legend,Love By Design,Love Culture,Love in,love J,Love Moschino,Love Notes,love on a hanger,Love Reign,Love Riche,Love Rocks,Love Sam,Love Squared,Love Stitch,Love Tease,Love Token,Love Tree,Love Your Melon,love,Fire,Love,Lacy,love...ady,Loveappella,Lovedrobe,Lovely Day,lovenote,Lovers + Friends,Lovesick,lovestitch,Low Luv x Erin Wasson,Lowa,LOWER EAST SIDE,LPA,Lrg,Lubiam,Luca + Danni,Lucca Couture,Lucchese,Luciano Barbera,Lucien Piccard,Lucky Brand,Lucky in Love,Lucky Jade,Lucy,Lucy & Laurel,Lucy Love,Lucy Paris,lug,Lugz,Luichiny,Luigi Bianchi Mantova,Luii,Luiza Estella & Co.,Luke 1977,LuLaRoe,Luli & Me,Luli Fama,Lulu Frost,Lulu Guinness,Lulu Townsend,Lulu's,lululemon athletica,Lulumari,LuMee,Lumiere,Luna Claire,Lush,Luukaa,Luv Aj,Luvable Friends,Lux,Luxe,Luxe Essentials Apparel,Luxie,Luxology,luxury rebel,Luxxel,Lyle & Scott,Lysse,M by Missoni,M. Gemi,M.Grifoni Denim,M.STUDIO,Maaji,Mabella Chic,mac & jac,MAC Cosmetics,Mac Duggal,Macbeth Collection by  Margaret Josephs,Macchia J,MaCherie,Machine,Mackage,Macy's,Mad Love,Madden Girl,Madderson London,made for life,Made Kids,Madeline,Madeline Stuart,Madewell,Madison,madison leigh,Madison Marcus,Madison Studio,Madison West,Mads Norgaard,Madson Discount,Maestrami,Maeve,Magaschoni,Magellan Outdoors,Magen's Fairytale Creations,Maggie & Zoe,Maggie Barnes,Maggie Sottero,Maggy London,Magic,Magic Fit,Magicsuit,Magisculpt,Magnanni,Magnificent Baby,Magnolia,Magnolia Pearl,Magnum,mahina,Maidenform,Maison Clochard,Maison Jules,MAISON KITSUNE,Maison Martin Margiela,Maison Martin Margiela for H&M,maitai,Maje,Majesti Clothing,Majestic,MAJORELLE,Makers of True Originals,Makeup Forever,makeup geek,Makeup Revolution,Makie,Malibu,Mally Beauty,Malo,Mama Licious,Mammut,Mandalynn,mandee,manduka,Manga,Mango,Manolo Blahnik,Manon Baptiste,Mansur Gavriel,Manuel Ritz,Mara Hoffman,Maralyn & Me,MarandNua,Marc Anthony,Marc By Marc Jacobs,Marc Ecko,Marc Fisher,Marc Jacobs,Marcelo Burlon County of Milan,Marchesa,Marciano,Marco Santi,Margaret M,Margaret O'Leary,Margaritaville,Margittes,margot,Maria Tash,Marie Chantal,Marie Melodie,Marika,Marilyn Monroe,Marimekko,MARINA,Marina Rinaldi,Marine Layer,Marineblu,Mario Matteo,Mario Orlandi,Mario Valentino,Maripe,Marisa Christina,Marissa Webb,Marithe Francois Girbaud,mark.,Market & Spruce,Marks & Spencer,Markus Lupfer,Marlboro,Marley B Parker Jewelry,Marlow,marmellata,Marmot,Marni,Married to the Mob,Marsell,Marsh Landing,Marshall Rousso,Marshalls,Martin + Osa,Martin Dingman,MARTIN GRANT,Martin McCrea,Martina Liana,Martine Dayan,Martinez Valero,Martini Ranch,Marvel,Marvin Richards,Mary & Mabel,Mary Frances,Mary Jane,MARY KATRANTZOU,Mary Kay,Mary L Couture,Mary McFadden,Mary's Bridal,Maryam Nassir Zadeh,Marysia Swim,MAS_Q,Masala Baby,Mascara,Mason,Masquerade,Massimo,Massimo Alba,Massimo Dutti,Massimo Rebecchi,Massini,Mastai Ferretti,Master Coat,Master Of Bling,mat.,Mata Traders,Material Girl,Maternal America,Matiko,Matilda Jane,Matisse,Matix,Matix Clothing Company,Matt & Nat,Matt Bernson,Matta,Matthew Christopher,Matthew Williamson,Matty M,MAUD FRIZON,Maude,Maui Jim,Mauri,Mauri Simone,Maurice Lacroix,Maurices,Maurizio Pecoraro,Maurizio Taiuti,Mauro Grifoni,Mauve,Mavi,MAWI,Max & Cleo,Max & Co.,Max de Carlo,Max Edition,Max Jeans,Max Nugus,Max Rave,Max Studio,Maxima,Maxime,Maxine of Hollywood,MaxMara,Maxx New York,May Queen,Maya,Maybelline,Mayle,Mayoral,MBLife,mblm,MBM Unlimited,MBT,MC2 Saint Barth,MCE,McGinn,McGregor,McGuire Denim,MCM,MCNY,McQ by Alexander McQueen,Me & Ro,Me Jane,ME Makeover Essentials,Me to We,me too,Mea Shadow,Meadow Rue,MEADOWLARK,Meaningful Beauty,mecca,Meccafox,Mechant,Med Couture,Medela,Meduse,Meg Carter Designs,Meghan LA,Meira T,Mejuri,MEK,Mel by Melissa,Meli Melo,Melie Bianco,Melin (Shoes),Melin Brand (Headwear),Melinda Eng,Melinda Maria,Melindagloss,Melissa,Melissa + Alexandre Herchcovitch,Melissa Joy Manning,Melissa Masse,Melissa McCarthy,Melissa McCarthy Seven7,Melissa Odabash,Melissa Paige,Melissa Sweet,Mellem,Melly M,Melody Ehsani x Reebok,Melody Maternity,Melrose and Market,Melrose Kids,Meltin Pot,Members Only,Meme,Menbur,Mendocino,Mephisto,meraki,Mercedes AMG Petronas,MERCEDES CASTILLO,mercer & madison,Mercer Street Studio,Mermaid Maternity,Merona,Merrell,Merritt Charles,Merry Modes,Mes Demoiselles,Mes Soeurs Et Moi,Meshki,Messagerie,Messeca New York,Metal Mulisha,Metaphor,Metradamo,Metro 7,Metro Wear,Metropark,metrostyle,MEXICANA,Mexx,Mezcalero,Mezlan,Mezon,MHI,Mi Amore,Mi.iM,Mia,Mia Bossi,Mia Chica,Mia Shoes,Mia Solano,miami,Miami Lace,Miansai,Michael Antonio,Michael Bastian,Michael Brandon,Michael Costello,Michael Dawkins,Michael Hoban,Michael Kors,Michael Kors Collection,Michael Lauren,MICHAEL Michael Kors,Michael Rome,Michael Shannon,Michael Simon,Michael Stars,Michaelangelo,Michal Negrin,Miche,Michel Perry,Michel Studio,Michelangelo,Michele,Michelle D,Michelle Jonas,Michelle K,Michelle Nicole,Michelle Stuart,MICHI,Micros,Midnight by Carole Hochman,Midnight Rider,Midnight Velvet,Mido,Midori,Mieka,Mighty Fine,Mignon,Mignon Faget,Mignonette,Miguel Ases,Miguelina,Miharayasuhiro,Miilla Clothing,Miista,Mika Yoga Wear,Mikael Aghal,Mikaella Bridal,Mikarose,Mike & Chris,Miken,Mikimoto,Mikoh,Mila Paoli,Milani,Milano,Milano Formals,Miley Cyrus & Max Azria,Milk & Soda,Milk Makeup,Millage,MillaNova,Millau,Milly,Milly Minis,Milly of New York,Milor,Mim-Pi,MIMI & COCO,Mimi & Maggie,Mimi Chica,Mimi Maternity,Mind Code,mine,Mine Finds by Jay King,Minelli,Mineral Fusion,Ming Wang,Mini A Ture,Mini Boden,Mini Melissa,Mini Rodini,Minicci,Minimale Animale,Minimum,MINKPINK,Minna Parikka,Minnetonka,Minnie Rose,Mint,MINT Jodi Arnold,Mint Pear Beauty,Minuet Petite,Mira Mikati,Miraclesuit,Mirasol,Miriam Haskell,Miriam Salat,Mirtillo,MischkaPu,Misha And Puff,MISHA COLLECTION,Mismash,Misook,Misope,Miss Albright,Miss Blumarine,Miss Chic Jeans,Miss Chievous,Miss Closet,Miss Elliette,Miss Grant,Miss Jeaniest,Miss KG,Miss London,Miss Me,Miss Rossi,Miss Selfridge,Miss Sixty,Miss Tina,Miss Y by Yoek,Missguided,Missguided +,Missoni,Missoni for Target,Misty Pearl,Mitchell & Ness,mittoshop,Miu Miu,Miusol,Mix It,Mix No. 6,Mixit,Mixx Shuz,Miz Mooz,Miztique,Mizuki,Mizuno,Mizzen+Main,MK Boutique,MKM Designs,MLB,Mlle Gabrielle,MLM,MLV,MM Couture,MM Lafleur,MM6 Maison Martin Margiela,MMS Design Studio,MNM Couture,Moa Moa,MOA USA,moana bikini,MOCIUN,Mod Ref,Moda,Moda International,Moda Luxe,MODA ME COUTURE,MoDa New York,Moda Spana,Modcloth,Model Novias,Modern Amusement,Modern Citizen,Modern Eternity,Modern Lux,Modern Soul,Modern Trousseau,Modern Vice,Modern Vintage,Modish Maze,Mois Studio,Mojo Moxy,Molli And Mia,Molly B,MOLLY GODDARD,Molly New York,Molo,Mom2moM,Moma,Momino,Momo Maternity,MomoDesign,Mon Cheri,Mona B,MONA LISA,monaco,Moncler,Moncler Gamme Bleu,Moncler Gamme Rouge,Mondaine,Mondani,Mondetta,Mondi,Monet,MONICA VINADER,Monies,Monif C.,Monika Chiang,Monika Rose SF,Monique Leshman,Monique Lhuillier,Monique Lhuillier Bridesmaids,Monique Luo,MonnaLisa,Mono B,Monocrom,Monoreno,Monroe & Main,Monrow,Monsac,Monserat De Lucca,Monsoon,monster high,Mont Blanc,Montage by Mon Cheri,Montana West,Montblanc,Montce,Monte Rosso,Monteau,Montedoro,Montego Bay Club,Monterey Bay,Moo Roo,Moods of Norway,MooMoo Designs,Moon Boot,Moon Collection,Moon Katz,Moon River,Moonlight Bridal,Moosejaw,Mootsies Tootsies,mophie,Morbid Metals,Morbid Threads,Moreschi,Morgan & Co.,Morgan & Milo,Morgan 4 Ever,Morgan de Toi,Morgan McFeeters,Morgan Miller,Morgan Taylor,Morgan&Milo Kids,Morgane Le Fay,Mori Lee,Morley,Moroccan Lush,Morphe,Morphine Generation,Morrell Maxie,Morrissey Y?,Moschino,MOSCOT,moss mills,Mossimo Supply Co.,Mossy Oak,Mostly Heard Rarely Seen,Motel Rocks,Moth,MOTHER,Mother of Pearl,Motherhood,Motherhood Maternity,Mothers en Vogue,Motionwear,Motivi,Mou,Moulinette Soeurs,Mountain Hardwear,Mountain Lake,Movado,Moving Comfort,Moyna,Moyuru,MPG,Mr & Mrs Italy,MR by Man Repeller,Mr.Swim,mrsalliexo,MS Shoe Designs,MSGM,MSK,Mstylelab,Mth Degree,MTNG,MTV,Mud Pie,Mudd,Mugler,Muji,Muk Luks,Mulberry,Mulberry for Target,Mulco,Multiples,Munchkin,mundi,munki munki,Munro,Munster,Mura Boutique,Mural,Murano,Murval,Musani Couture,Muse,Muse Refined,Music Legs,Must Have,Mustard Pie,Mustard Seed,Muubaa,Muza,MV Sport,MVMT,MXM,My Bella Mama,My Beloved,My Flat in London,My Little Pony,My Michelle,My Star Denim,My Story,My Tribe,MyaBlueBeach,Mycra Pac,Mycra Pac Designer Wear,MYKITA,Myne,MYNT 1792,Myrene de Premonville,mysisterskloset,Mystic,Mystique Boutique,Mystree,Myths,MZ Wallace,n.d.c.,N.Y.L.A.,n:PHILANTHROPY,Na Hoku,naartjie,Nadia Rima,Nadri,Naeem Khan,NAF NAF,Naghedi,Nahui Ollin,NAILA,Nais,Nakamol,Naked & Famous Denim,naked cosmetics,Naked Feet,Naked Truth,naked wardrobe,Naked Zebra,Naketano,Nakimuli,Nally & Millie,Nameless,NaNa,Nancy Ganz,Nancy Gonzalez,Nancy Rose Performance,Nando Muzi,Nanette Baby,Nanette Lepore,Nanette Lepore for Keds,Nanis Italian Jewels,Nannette,Nannini,Nano,Naot,Napapijri,Napier,Naracamicie,Narciso Rodriguez,Nardos Imam,Narianna,NARS,Nascar,Nashelle,Nasty Gal,Nat Nast,Natalia Brilli,Natalie Dancewear,Natan,Natasha Couture,Natasha Denona,Natasha Zinko,Nataya,Nation LTD,Native,Native Intimates,Native Shoes,NATIVE YOUTH,Natori,NATURAL LIFE,Natural Reflections,Natural Soul,Natural Steps,Naturalizer,Nature Breeze,Natures Purest,Naturino,Nau,naughty monkey,Nautica,navabi,Naven,Navid O Nadia,Naya,NBA,NBD,NCAA,Nearly Nude,Necessary Clothing,Necessary Objects,Needle & Thread,Neff,Neil Barrett,Neil M,Neiman Marcus,nejd,Nektar de Stagni,Nektaria,Nell Couture,Nella Fantasia,Neoclassics,neon buddha,Nero Giardini,Neutrogena,Neuw,New Balance,new directions,new england jewelry designs,New Era,New Frontier,New Look,New Mix,New York & Company,New York Transit,Newport News,next,Next Direct,Next Era,Next Level Apparel,Nexx,NFINITY,NFL,NHL,NIC+ZOE,Nica,Nicce,NICHOLAS,Nicholas K,Nicholas Kirkwood,Nick & Mo,Nick & Nora,Nick Fouquet,Nickelodeon,Nickels,Nicki Minaj,Nicky Butler,Nico Nico,NICOLA,Nicolasa Cicero,Nicole,Nicole Bakti,Nicole by Nicole Miller,NICOLE FARHI,Nicole Lee,Nicole Mighty Designs,Nicole Miller,Nicole Miller Bridal,Nicole Richie Collection,Nicole Sabbattini,NICOLI,Nicolita,Nieves Lavi,Nigel Preston & Knight,Night Moves,Night Moves Prom Collection,Night Way Collections,Nightcap,NIGHTWALKER,NIKA,Nike,Nike ACG,Nike MLB,Niki Lavis,Nikibiki,Nikon,Nila Anthony,Nili Lotan,NILS,Nina,Nina Austin,Nina Canacci,Nina Capri,Nina Leonard,Nina Originals,Nina Piccalino,Nina Ricci,Nina Shoes,Nine & Co.,Nine West,Ninety,Nino BOSSI,NinoXIV,Nintendo,Nipon Boutique,Nisolo,Niteline,Nixon,NLST,No Added Sugar,No Boundaries,No. 21,No. 6,Noble U,NoBull Project,Nocona,Noel Asmar,Noelle,nOir Jewelry,noir kei ninomiya,Nola,Nolah Elan,Nolan Miller,Nollie,Nom Maternity,Nomad Footwear,Nomadic Traders,nomi,Nomos,Noodle & Boo,Nook,Nookie,Noonday Collection,Noppies,NOR,Nordstrom,Nordstrom Baby,Norm Thompson,Norma Kamali,Noro,Norse Projects,Norsewear,North Beach Leather,North Sails,Northcrest,Northern Reflections,Northside,Northwest Blue,Norton McNaughton,Nostalgia,Not Rated,Not Rational,Notations,Nothing But Love,Nougat London,Noukie's,Nouveau Riche,nouvelle AMSALE,Novara,Novella Royale,NSF,NSR,Nu Collective,NuBra,NUDESTIX,Nudie Jeans,Nue by Shani,Nue Options,Nui,Nunn Bush,nununu,Nurse Mates,Nursery Rhyme,Nurture by Lamaze,NUX,NY Collection,NYC,NYDJ,NYMPHE,NYTT,NYX,O'2nd,O'Neill,OAK,Oakley,Oamc,OASAP,Oasis,Obakki,Obermeyer,Obey,Objects of Desire,Obsession Rules,Obsessions Couture,Obsessive Compulsive Cosmetics,OC by Oleg Cassini,Ocasion,Ocean Current,Ocean Dreams,Ocean Drive,Ocean Fashion,Oceanaut,Ocra,October Love,Oday Shakar,Odd Future,Odd Molly,ODDY,Odille,Oeuf,Of Two Minds,Off-White,Officine Creative,Officine Generale,Offspring,OFRA,OGIO,Oh Baby by Motherhood,Oh Deer!,Oh My Gauze!,OH MY JULIAN INC.,Oh My Love,Oh Polly,Oh! Mamma,Oh,it's Fayth,Ohne Titel,Oilily,OiOi Australia,oiselle,OKA b.,Okabashi,okie dokie,Olcay Gulsen,Old Glory,Old Gringo,Old Navy,Old Soles,Old West,Oleg Cassini,Oleg Cassini Sport,Olga,OLIA ZAVOZINA,Olian,Olivaceous,Olive & Oak,Olive Olivia,Oliver Jung,Oliver Peoples,Oliver Spencer,Olivia + Joy,OLIVIA BURTON,Olivia Harris,Olivia M,Olivia Matthews,Olivia Miller,Olivia Moon,Olivia Rose Tal,Olivia Sky,Olivia von Halle,Olivia Welles,Ollio,Olsenboye,OluKai,OLVI'S,Olympia Activewear,Omega,omelle,Omero,omighty,OMOCAT,On Fire,On Gossamer,on the byas,OndadeMar,one 5 one,One A,ONE by Contrarian,one clothing,One Girl Who,One One Three,One Step Ahead,One Teaspoon,ONE WORLD,Onesole,Onex,Onia,Onitsuka Tiger by Asics,Only,ONLY & SONS,Only Hearts,Only Mine,Only Necessities,Onna Ehrlich,Onque Casuals,Onque Woman,Ontheblvrd,Onyx,Onyx Nite,Onzie,Ooh! La,La! Couture,oomphies,Oonagh by Nanette Lepore,OP,Open End,Opening Ceremony,OPI,OppoSuits,Optic Nerve,Or Paz,Ora Delphine,orange creek,Orciani,Orefici,Ori Ami Knits,Origami Owl,Original Paperbacks,Original Penguin,Original Retro Brand,Origins,Orion London,Oris,Orla Kiely,Orlebar Brown,Ornamental Stone,OROBLU,Oroton,Orvis,orYANY,Oscar de la Renta,Oscar de la Renta Bridal,Oscar de la Renta Sleepwear,Oscar Tiye,OshKosh B'gosh,Osiris,OSMAN,OSPREY,OTBT,Others Follow,OtterBox,Oulm,Our Legacy,Outback Red,Outdoor Research,Outdoor Voices,Outer Edge,Outerwear by Lisa,Ovi,P&Y Denim,P'tula,P.E Nation,P.J. Salvage,P.R.I.M.A. Glitz by Kari Chang,Pablosky Kids,Pacific Sunwear,Pacific Trail,Pacifica,Paco Gil,Pacsafe,PacSun,PAIGE,painted threads,Paisley Sky,Pajar,Pakaloha,Pal Zileri,Pali Hawaii,Palladium,Palm Angels,Palm Beach Boutique,Palm Beach Sandals,Paloma Barcelo,Paloma Blanca,Paloma Picasso,Palomitas,Pam & Gela,Pamela Dennis,Pamela Love,Pamela McCoy,Pamella Roland,Pampili,Pampolina,Panacea Cache,Panache,Panache Lingerie,Panama Jack,Pandora,Panerai,Panhandle Slim,Paniz,Panoply,Pantherella,Pantofola D'oro,Paola Frani,Paolo,Paolo Casalini,Paolo Masi,Paolo Pecora,Paoloni,paparazzi,Papaya,Papell Boutique,Paper Crane,Paper Crown,Paper Denim & Cloth,paper doll,Paper Fox,paper tee,Paperbacks,Paperboy Clothing,Papermoon,Paperwallet,Papillon Blanc,Papo d'Anjo,Pappagallo,Paprika,Paradis Miss,Paradox,Paradox London Pink,Paraella,Parajumpers,Paraphrase,Parasuco,Pardon,Paris Blues,Paris Hilton,Parisian Works,Park Lane,Parke & Ronen,Parker,PARKER SMITH,Parsley & Sage,Party City,Party Time Formals,Pas de Rouge,Pasha & Jo,pashmina,PASKAL,Pasquale Bruni,Passport,Pastels,Pastels Clothing,Pastry,Pat McGrath,Patagonia,Patchington,Pate De Sable,Patek Philippe,Patra,Patricia Field,Patricia Green,Patricia Nash,Patricia Underwood,Patricia Viera,Patrick Cox,Patrick Kelly,Patrizia Luca,Patrizia Pepe,Patrons of Peace,Patterson J. Kincaid,PattyBoutik,Paul & Joe,Paul & Shark,Paul Andrew,Paul Frank,Paul Green,Paul Mayer,Paul Morelli,PAUL PARKMAN,Paul Smith,Paul Smith Junior,Paul Smith London,Paul Stuart,Paul Warmer,Paula Cademartori,Paula Hian,Paula Varsalona,PAULE KA,Paulina Jeans,Pauline et Julie,Pauw Amsterdam,Payless,Paz Creations,Pazitos,PAZZO,PD&C,Peace Love World,Peace of Cloth,Peach Couture,Peach Love California,Peaches Uniforms,Peak Performance,Peanuts,Pearl,Pearl by Georgina Chapman,Pearl Izumi,Pearlfection,Peasants & Travelers,Pebble Beach,Peck & Peck,pediped,Pedro Garcia,Pedro Miralles,Peek,Peggy Hartanto,Peggy Jennings,Pelle Moda,Pelle Pelle,Pelle Studio,Pelletterie 2F,Pencey,Pendleton,Penelope Chilvers,Penelope Mack,Penfield,Penningtons,Penny Loves Kenny,PennyLu,Penolope Mack,Penoy Jewelery,Penthouse by Ellie Shoes,Peony and Moss,People Like Frank,People's Liberation,Pepe Jeans,Peppa Pig,Peppe Peluso,Peppercorn Kids,Peppermayo,Peppermint,Per Se,PER TE BY KRIZIA,per una,Perceptions,Perfect Details,Perfect Silhouettes,Perfection,Perfectly Posh,Periwinkle by Barlow,Perlina,Perrelet,Perricone MD,Perry Ellis,Persaman New York,Perseption,Persnickety,Persol,Persona,Persona by Marina Rinaldi,Peruvian Connection,Petar Petrov,Peter Grimm,Peter Kaiser,Peter Langner,Peter Luft,Peter Millar,Peter Nygard,Peter Pilotto,Peter Pilotto for Target,Peter Rutz,Peter Som,Petit Ami,Petit Bateau,Petit Lem,Petite Sophisticate,Petra Fashions,Petro Zillia,Petticoat Alley,Petunia Pickle Bottom,Peugeot,Peuterey,Pez D'Or,PGA Tour,Phanuel,Phase 3,Phat Farm,Phelan,Phenix,Philip Simon,Philip Stein,Philip Treacy,Philipp Plein,Philippe Adec,Philippe Model,Philosophy,Philosophy di Alberta Ferretti,Philosophy di Lorenzo Serafini,Phoebe Couture,Physicians Formula,Piaget,Piamita,Piattelli,Piazza Sempione,Picadilly Fashion,Picasso Babe,PIECE A CONVICTION,Piero Guidi,Pierre Balmain,Pierre Cardin,Pierre Dumas,Pierre Hardy,Pierri New York,Pietro Alessandro,Pietro Brunelli,Piko 1988,PIKOLINOS,Pilcro and the Letterpress,Pilgrim,Pilyq,Pim + Larkin,Pin-Up Stars,Pinc,Pinc Premium,Pinco Pallino,Pineapple.Palmbeach,Ping,PINK,Pink & Pepper,Pink Chicken,Pink Clove,Pink Cookie,Pink Cosmo,Pink Dolphin,Pink Envelope,Pink Floyd,Pink Haley,Pink Lotus,Pink Martini,Pink Owl,pink paradox London,Pink Peplum Boutique,Pink Platinum,Pink Republic,Pink Rose,Pink Tartan,PINK Victoria's Secret,Pinkblush,Pinkimo,Pinko,Pinky,Pinkyotto,Pinqlo,Pins & Needles,Pinup Couture,Piombo,Piper,Piper & Blue,Piper Gore,Piperlime,Pippa & Julie,Pisarro Nights,pistola,Pitaya,Pixi,Pixie Market,Pixley,PJ Salvage,PJK Patterson J. Kincaid,PLAE,Planet Blue,Planet Gold,Planet Motherhood,Plastic Island,PLAYBOY,Playtex,Pleaser,Pleasure Doing Business,Plein Sud,Pleione,Plenty by Tracy Reese,PLH Bows & Laces,Plinio Visona,Plomo,Plugg,Plum Creek Boutique,Plum Pretty Sugar,PLUME COSMETICS,Plunder,Plus by Etage,ply cashmere,Pnina Tornai,Poema,Poetic License,Poetry,Point Zero,Pokemon,POL,Polarn O. Pyret,Polaroid,Polder,Poleci,Poler,Pollini,Polly & Esther,Polo by Ralph Lauren,Pologeorgis,Pom D'Api,Pomellato,Pomelo,Pompili,Pons Quintana,Pont Neuf,Ponte Vecchio,Pony,Poof Couture,Poof Excellence,Poof!,POP ICON CLOTHING,Popana,Popatu,Popband,Poppie Jones,POPPY FINCH,Popsy,Popular Basics,Porsamo Bleu,Porsche Design,PORSELLI,Port Authority,Porta Romana,Portolano,Ports 1961,Posh,Posh Garden,Posh Pua,Posh Wellies,PosherSwag,Positive Attitude,Postella,Potter's Pot,Pottery Barn Kids,Pour La Victoire,Pout,POVERTY FLATS by rian,Power Ranger,PPLA,Prabal Gurung,Prabal Gurung for Target,Prada,Prada Linea Rossa,Prairie New York,Prairie Underground,Prana,Precious Formals,Precious Moments,Predictions,Preen by Thornton Bregazzi,PREFRESH,Preggers,Premiata,Premier,Premier Designs,Premiere Denim by rue21,Premise,Prep Coterie,Presley Jaymes Boutique,Presley Skye,Pressley&Co,Preston & York,Preswick & Moore,Pret-a-Surf,Pretty Angel,Pretty Ballerinas,Pretty Good,Pretty Green,Pretty Maids,Pretty Persuasions,Pretty Polly,Pretty Pushers,Pretty Rebellious,Pretty Vulgar,PrettyLittleThing,Prevata,Preview Collection,Preview International,Prickly Cactus Boutique,Prima Donna,Primark,Primary,Primavera Couture,Primigi,Primitive,Primo Emporio,Primp,Prince,Prince & Fox,Prince Peter Collection,Princess Linens,Princess Polly,princess vera wang,Pringle,Prisa,Priscilla of Boston,PRISM,PRISMSPORT,Pritzi,Privacy Please,Private Label,Private Label by G,PRIVATE PARTY,Privatsachen,Privileged,Privo,Pro Edge,Pro Player,Pro Spirit Athletic Gear,Proenza Schouler,Proenza Schouler for Target,Profile By Gottex,Profusion Cosmetics,Project E,Project Social T,Promesa,PromGirl,Promise,Promo Uomo,Promod,Pronovias,Pronto Uomo,Propet,Propper,PRPS,Prune,PRVCY,PS Paul Smith,Psycho Bunny,Pt01,Public Desire,Public School,Publish,Pugster,Puli,Pulicati,Pull&Bear,Pulsar,Pulse,Puma,pumpkin patch,Punk Royal,Punto Fashion,Pur,Pur Minerals,Pura Lopez,Pura Vida,Pure Barre,Pure Collection,Pure Energy,Pure Romance,Purebaby,Puritan,Purple Rain,Purple Snow,PurseN,Pusheen,Pussycat London,Pyon Pyon,Pyrenex,Q by Pasquale,Q-T Intimates,Q2,QED London,QMack,Qristyl Frazier Designs,Quacker Factory,Quay Australia,Que,Queen Bee Maternity,Quiksilver,Quinn,Quoddy,Qupid,QVC,R & M Richards,R 13,R&K,R&M Richards,R.J. Graziano,R13,R2,Rabbit Rabbit Rabbit,Rachael & Chloe,Rachel,Rachel Allan,Rachel Antonoff,Rachel Art Jewelry,Rachel Comey,Rachel Gilbert,Rachel Kate,Rachel Leigh,Rachel Pally,Rachel Pally White Label,RACHEL Rachel Roy,Rachel Reinhardt,Rachel Riley,Rachel Simpson,Rachel Zoe,Rad and Refined,RADLEY LONDON,Rado,Radzoli,RAEN,Raf Simons,RAFAEL,Rafaella,Rafe,rag & bone,RAGA,RAGAZZA,Ragdoll,Rags and Couture,Rags to Raches,Rails,Rainbow,Rainbow Club,RAINFOREST,Rains,Raisins,Raj,Raleigh Runway,Rallier,Ralph Lauren,Ralph Lauren Black Label,Ralph Lauren Blue Label,Ralph Lauren Purple Label,Ralph Lauren RRL,Rami Kashou for bebe Bridal,Ramon Tenza,Rampage,Ramy Brook,Randolph Duke,Randolph Engineering,Rangoni,Ransom,Raoul,Raparo,Raphaela by Brax,Raquel Allegra,Rare Editions,Rare London,Ras,Rasolli,Raul Blanco,rave,Rave 4 Real,ravel,Raven + Lily,Raven Denim,Raven Kauffman,Ravi Ratan,Raviani,Raviya,Rawlings,Ray Griffiths,Ray-Ban,raya sun,RAYE,Raylia Designs,Raymond Weil,RBX,RD Style,RDI,Re-Hash,Re/Done,re:named,Reaction Kenneth Cole,Real Collectibles by Adrienne,Real Size Bride,Real Techniques,RealHer,Realisation,Realitee Clothing,Realtree,Reba,Rebdolls,Rebeca Sanver,Rebecca Beeson,Rebecca Malone,Rebecca Minkoff,Rebecca Moses,Rebecca Schoneveld,Rebecca Taylor,Rebel Spirit,Rebel Yell,Rebellion,Rebellious One,rebels,Reborn,Reborn J,Reclaimed Vintage,Recycled Karma,Red,Red Camel,Red Carter,Red Circle Footwear,Red Dress Boutique,Red Engine,Red Envelope,Red Haute,Red Jacket,Red Rivet,RED Valentino,Red Wing Shoes,RedHead,Redline,Reebok,Reece Hudson,Reed Evins,Reed Krakoff,Reef,Reel Legends,Reem Acra,Reflex,Reformation,Refresh,refuge,Regency Cashmere,Rehab,REI,Reign,Reigning Champ,Reiss,Rejina Pyo,Relais Knitware,Relativity,Relic,Relished,RELLECIGA,Rem Garson,remanika,Remington,Remo Tulliani,Remy Leather,Rena Koh,Rena Lange,Rena Rowan,Renato Angi,Renaud Pellegrino,Rene Caovilla,Rene Lezard,Rene Mancini,Rene Rofe,Rene Rofe baby,Rene Ruiz,Renee C.,Reneeze,Renuar,Renvy,Renzo and Kai,ReoRia,Repetto,Replace,Replay,Report,Report Collection,Report Signature,Requirements,Reserved,Restoration Hardware,Restricted,Retois,Retro Chic,Retrofit,Retrofits,RetroSuperFuture,Retta Wolff,Reuben Reuel,Reverse,Revlon,Revo,Revolt Jeans,Revolt Society,Revolution,Rewash,Rewind,reyn spooner,Rhapsody,Rhea Costa,Rhona Sutton,Rhonda Ochs,Rhonda Shear,Rialto,RIANI,Riccio,Rich & Skinny,Richard Chai,Richard Chai for Target,Richard Glasgow,Richard James,Richard Nicoll,Richard Tyler,Richard Tyler Couture,Richmond,Richmond Jr,Richmond X,Rick Owens,Rickie Freeman for Teri Jon,Riders by Lee,Rieker,Rihanna,Riki Rosetta,Riller & Fount,Rima Imar,Rime Arodaky,Rimini,Rimmel London,Rina diMontella,Rina Rich,Rina Rossi,Rinascimento,Ring of Fire,Rioni,Rios of Mercedes,riot society,Rip Curl,Ripe,Ripe Maternity,Ripndip,Ripple Junction,Rising International,Rising Tide,Ritmo di Perla,Riva Designs,Rivamonti,River Island,Rivet & Blues,Riviera,Rivieras,Rivini,Rivka Friedman,Rizal,RJs Jewelry Boutique,RLX Ralph Lauren,RMS Beauty,Ro & De,Roaman's,Roar,Robbi & Nikki by Robert Rodriguez,Robbie Bee,Robeez,Robell,Robert Barakett,Robert Bullock Bride,Robert Clergerie,Robert Friedman,Robert Geller,Robert Graham,Robert Lee Morris,Robert Louis,Robert Rodriguez,Robert Rose,Robert Talbott,Robert Wayne,Robert Zur,Roberta Bridal,Roberta di Camerino,Roberta Einer,Roberta Roller Rabbit,Roberto Bianci,Roberto Botticelli,Roberto Cavalli,Roberto Coin,Roberto Collina,Roberto Del Carlo,Roberto Vascon,Robin Jillian Bridal,Robin Jordan,Robin K,Robin Piccone,Robin Ruth,Robin's Jean,Robin's Nest Jewels,Robyn Lawley,Robyn-Lyn,Rocawear,Rocco D'Amelio,Rocco P.,Rochas,Rock & Candy,Rock & Republic,Rock & Roll Cowgirl,Rock Revival,Rock Your Baby,Rocket Dog,Rocketbuster Boots,Rockport,RockSteady,Rocky,Roda,Rodarte,Rodarte for Target,Rodd & Gunn,RODIER,Rodo,Rodolphe Menudier,Rogan for Target,Roger Dubuis,Roger Vivier,Rogue,Rohnisch,Roksanda Ilincic,Roland Cartier,Roland Klein,Roland Mouret,Roland Nivelais,Rolex,Rolf Bleu,Rolfs,Rolla Coster,Rolling Sage,Roma,Romain Jerome,Roman Grey,Romano Ridolfi,Romeo & Juliet Couture,Romfh,Romika,Romona Keveza,ROMWE,Romy,Romygold,Ron Jon,Ronald van der Kemp,Ronen Chen,Roni Rabl,Ronni Nicole,Ronny Kobo Collection,Roolee,Roommates,Roots,Roper,Rory Beca,Ros Hommerson,Rosa Clara,Rosa Couture,Rose & Olive,Rose Taft,Roseanna,Rosebud,Rosebullet,Rosegal,Rosegold Shoes,Rosetta Getty,Rosetti,Rosie Pope,Rosio,Ross Sportswear,Ross-Simons,Rossella Jardini,Rotary Watches,Rothco,Rothschild,Rothy's,Rouge Helium,Rough Roses,Rouje,Roulette,Roundtree & Yorke,Route 66,Rowallan,Rowdy Sprout,Rowen,Roxann Slate,Roxy,Roy Rogers,Royal Bones,Royal Robbins,Royal Tapisserie,Royal Underground,Royce Leather,Roz & Ali,Rozae Nichols,RSQ,RSVP,Rubber Ducky Productions,Inc.,Rubbish,Rubie's,Rubinacci Napoli,ruby & bloom,ruby moon,Ruby Rd.,Ruby Ribbon,Ruby Rox,Ruche,RUDE,RUDSAK,Rue 107,Rue De Seine,Rue21,Ruehl No.925,Ruff Hewn,Ruff Life,Rugby Ralph Lauren,RUKEN,Rum and Coke,Rupert Sanderson,Russell Athletic,Russell Kemp,Rustic Cuff,Rustler,Rusty,Ruthie Davis,Ruum,RVCA,RVN,RVT,RXB,Ryan Haber,Ryan Roche,Ryan Seacrest Distinction,Ryan's Corner Jewelry,Rye,Ryka,Ryu,S&D,S&G Apparel Inc.,S-Twelve,S. the Widow,S.L. Fashions,SAACHI,Sabika,Sabina,Sabine,Sabo Skirt,Sabora,Saboroma,Sacai,Sacha London,SACHI,Sachin + Babi,Sacred Threads,Saddlebred,Sade New York,Sadie & Sage,Sag Harbor,Saga Furs,Sage,sahalie,Sail to Sable,Sailormade,Saint Grace,Saint James,Saint John's Bay Active,Saint Laurent,Saint Tropez West,Saison Blanche,Saivana,Saja,Sakkas,Sakroots,Saks Fifth Avenue,Saks Fifth Avenue Black Label,Salinas,Sallie Sahne,Sally LaPointe,Sally Miller,Salomon,SALONI,Salt City Emporium,Salt Gypsy,Salt Lake Clothing,Salt Life,Salt Swimwear,Salt Water Sandals by Hoy,Salt Works,Salvador Bachiller,Salvage,Salvatore Ferragamo,Salvini,Salwar Kameez,Sam & Lavi,Sam & Libby,Sam & Max,Sam Edelman,SAM.,Samantha Chang,Samantha Patterson Designs,Samantha Thavasa,Samantha Treacy,Samantha Wills,Sami & Jo,SAMOON,Samsonite,Samsung,Samudra,Samuel B.,Samuel Dong,Samuelsohn,Samya,San Diego Hat Company,San Joy,San Lorenzo,San Moire,Sanayi 313,Sanctuary,Sandra Darren,Sandra Ingrish,Sandra Portelli,Sandra Weil,Sandro,Sandro Moscoloni,Sanita,Sanrio,Sans Souci,Santana Canada,Santoni,Santorelli,Sanuk,Sapsucker,Sara,Sara Battaglia,Sara Berman,Sara Blaine,Sara Boo,Sara Campbell,Sara Gabriel,Sara Kety,Sara Sara,Sara's Prints,Sarah & George,SARAH & SEBASTIAN,Sarah Cavender Metalworks,Sarah Coventry,Sarah Danielle,Sarah Elizabeth,Sarah Graham,Sarah Jayne,Sarah Pacini,Sarah Seven,Sarah Siah,Sarah Spencer,Sartore,SAS,Sasch,Sasha Fabiani,sass & bide,Sassi Holford,Sasson Jeans,Sassybax,Satomi Kawakita,Saturdays New York City,Satya Jewelry,Saucony,Savane,Savannah,Save The Queen,Savi Mom,Savvy Cie,Saxx,Say What?,SAYLOR,SB Glam,SB Scrubs,Sbicca,Scala,Scarlett,Scarlett Nite,Scarpa,Scene Weaver,School Issue,Schott NYC,Schultz,SCHUTZ,Scoop NYC,Scorpio Sol,Scotch & Soda,Scotch R'Belle,Scotch Shrunk,Scott Kay,Scott McClintock,Scottevest,Scout,Scrapbook,Scrubstar,Scuderia Ferrari,Scully,SD Collection,SE Boutique by Sam Edelman Designs,Sea,Sea New York,Seafolly,Sean Collection,Sean John,Search for Sanity,Searle,Sears,SeaVees,Sebago,Sebastian Milano,Sebby,Second Skin Overalls,Secret Treasures,Secrets of Charm,SEDUCE,See By Chloe,See Kai Run,See Thru Soul,See You Monday,seeyou,Sefirah Fierce Designs,Segolene Paris,Seidengang,Seiko,Seirus Innovatio,Sejour,Selby,Selena Gomez,Selene Sport,Self Esteem,Self-Portrait,Semantiks,Sempre Piu,Sendra,Seneca Rising,SeneGence,Senreve,SENSO,Seoul Little,Sephora,Sequin Hearts,Sequoia,Seraphine,Serengeti,Serenity,Serfontaine,Sergio Rossi,Sergio Rossi for Puma,Sergio Tacchini,Sergio Valente,Sergio Zelcer,Sermoneta Gloves,Sesame Street,SESSIONS,Sesto Meucci,Setsuko Jewelry,Seven Dials,Seven7,Seventy,Sexy SuperShero,Seychelles,Sezane,Shabby Apple,Shablool Silver Jewelry Design,Shade & Shore,SHADES OF GREY BY MICAH COHEN,Shakuhachi,SHAN,Shanghai Tang,Shape FX,Sharagano,Share Spirit,Sharif,Sharon Young,Shasa,Shaun White,Shavonne Dorsey,Shawna Hofmann,She and Sky,SHE MADE ME,She's Cool,shebeest,SHEIN,Shelby & Palmer,Shellys London,Sheri Bodell,Sheri Martin,Sheridan Mia,Sherpani,Sherri Hill,Sherrie Bloom,Sherry Cassin,Shery Shabani,Sheryl Lowe,Shi by JOURNEYS,Shiekh,Shimano,Shimera,Shin Choi,Shinestar,Shinola,Shipley & Halmos,Shiraleah,Shirin Guild,Shirley of Hollywood,Shiseido,Sho Max Originals,Shoe Dazzle,Shoe Republic LA,Shoe Supply,Shoemint,Shoeroom21 boutique,Shoes For Crews,Shoes of Prey,Shop Jeen,Shop Stevie,Shop Vida,Shopkins,Shoreline,Shoshanna,shosho,Shourouk,Show Me Your MuMu,Showpo.,Showtime Collection,Shrimps,Shrinking Violet,Shully's,ShuShop,Shwings,Shwood,Shyanne,Siaomimi,Sidney's Furs & Sons,Sidonie Larizzi,Siena Studio,Sienna Ricchi,Sienna Rose,Sienna Sky,Sies Marjan,Sigerson Morrison,Sigma Beauty,Signature,Signature by Larry Levine,Signature by Levi Strauss,Signature by Robbie Bee,Signature by Sangria,Signature Studio,Signature8,Signorelli,Sigrid Olsen,silence + noise,Silk and Sable,Silkies,SilkLand,Silpada,Silver Forest,Silver Jeans,Silver Stars Collection,Silverskylight,Silx by August Silk,Sima K,Simon Chang,Simon G.,Simon Miller,Simon Sebbag,Simone Carvalli,Simone Perele,Simone Rocha,Simonetta,Simple,Simple Feather Boutique,Simple Sanctuary,Simplicitie Inc.,Simplicity,Simply Be,Simply Couture,Simply Emma,Simply Liliana,Simply Noelle,Simply Southern,Simply Styled,Simply Vera Vera Wang,SimplyBridal,Sincerely Jules,Sincerity Bridal,Sincerly Jules,Sinclaire 10,Sinful,Sinn,Sioni,Sip N' Sparkle,Sir Alistair Rai,Sisley,Sister Jane,Siviglia,Siwy,Sixtyseven,SJP by Sarah Jessica Parker,Skagen,Skaist Taylor,Skargorn,Skechers,Skemo,Skies Are Blue,Skin,SKINN,Skinny Minnie,Skinny Tie Madness,Skip Hop,Skirtin Around,SkirtSports,SKITS,Skunkfunk,Sky,SKYE by Infinity Raine,Skye Swimwear,Skye's the Limit,SL Fashions,SLANE,Slate & Stone,Slate & Willow,Slazenger,Sleepy Jones,Slinky Brand,Sloane & Tate,Sloggi,Slop USA,SM New York,smart & sexy,smartfit,Smartty,Smartwool,Smashbox,Smell the Roses,SMITH,Smith Optics,SML Sport,Smythe,Smythson,Snap,Snapper Rock,Sneak Peek,Snob Essentials,SNOWMAN New York,Snozu,Snuglo,SO,So De Mel,So Wear It Declare It,Soap & Glory,SOBEYO,Sobral,Social Bridesmaids,Social Occasions by Mon Cheri,Socialite,Societe Anonyme,Society of Chic,Society Plus,Sociology,Soda,Soda Blu,SODO,soeur,Soffe,Sofft,sofia by sofia vergara,SOFIA by ViX,Sofie D'Hoore,Sofra,Sofrancisco Tech Accessories,sofsy,Soft Gallery,Soft Joie,Soft Surroundings,Softspots,SoftWalk,Soho,Soho Apparel,SOHO Beauty,Soho Girls,Soia & Kyo,Soieblu,Soixante Neuf,Sol Angeles,Sol Sana,Solace London,SOLD Design Lab,Sole La Vie,Sole Society,Solemio,Solid,SOLID & STRIPED,Solitaire,Solmate Socks,solo,SOLOW,Solstice,Soludos,Soma,Somedays Lovin,Somekind of wonderfull,Something Bleu Bridal,Something Navy,Something Strong,Son Paises,Sondra Roberts,Sonia Kashuk,Sonia Rykiel,Sonix,Sonoma,Sons of Trade,Sony,Sonya Renee Jewelry,Sophia & Camilla,Sophia & Lee,Sophia Caperelli,Sophia Eugene,Sophia Max,Sophia Tolli,Sophia Visconti,Sophia Webster,sophie b.,Sophie Hulme,Sophie Max,Sophie Rue,Sophie Theallet,Sophomore,Soprano,Sorbet,Sorel,SORELLA VITA,Sorial,Sorrelli,SoShelbie,Sottero and Midgley,Soul Flower,Soul Revival,soulcycle,SoulCycle X Target,Soulland,Soulmates,Sound & Matter,Soundgirl,Sourpuss,South Moon Under,South Pole,Southern Girl Fashion,Southern Grace,Southern Marsh,Southern Proper,Southern Tide,Sovereign Code,Soya Fish,Soybu,Sozo,SPA Accessoires,Space 46 Boutique,Space Style Concept,Spalding,SPANNER,SPANX,Sparkle & Fade,Sparkling Mine,Sparkling Sage,sparrow,Spartina 449,Special Occasions by Saugus Shoe,Specialty girl,speck,Speechless,Speed Control,Speed Limit 98,Speedo,Speidel,Spell & The Gypsy Collective,Spencer's,Spense,Spenser Jeremy,Sperry,Spicy Footwear,Spiderman,Spiegel,Spiewak,Spigen,Spirit,Spirit Moda,SpiritHoods,Spiritual Gangster,Spitfire,Splash,Splendid,split,Splits59,Spoiled,SpongeBob Squarepants,Spool 72,Sport Haley,Sportalm,Sportelle,Sportmax,Sporto,Spring Step,Spring Street,SPY,Spyder,Squeeze,St. Anthony Evening,St. John,St. John Collection,St. John Sport by Marie Gray,St. John's Bay,St. Patrick,St. Pucchi,ST. studio,St. Tropez,StableWoman,Staccato,Stacy Adams,Stacy Sklar,Stadium Athletics,Stafford,Stampd,Stance,Staple,Star City,Star Mela,Star Vixen,Star Wars,Starbucks,Staring at Stars,Start Rite,Startas,STARTER,Starting Out,State of Mind,Stateside,Stefanel,Stefano Ricci,Steilmann,Steinmark,Stella & Dot,Stella & Jamie,Stella Carakasi,Stella Cove,Stella Jean,Stella Laguna Beach,Stella Luce,Stella Maternity,Stella McCartney,Stella McCartney Kids,Stella York,stem,Stem Baby,Stenay,steph&co,Stephane Kelian,Stephane Verdino,Stephanie Johnson,Stephanie Rogers,Stephen Dweck,Stephen Webster,Stephen Yearick,Steppin' Out,Sterntaler,Stetson,Steve & Barry's,Steve Madden,Steven Alan,Steven Alan Optical,Steven By Steve Madden,Stevie Hender,Stevie Mac New York,Stevies,Stila,Stitch Note,Stitch's,Stizzoli,Stone & Co.,Stone Cold Fox,Stone Fox Swim,Stone Island,Stone Mountain Accessories,Stone Rose,Stonz,Stoosh,Stooshy,Stop Staring,storets,Storksak,Storm,Story of My Dress,Strada,stradivarius,Stranded,STRATEGIA,Straw Studios,Street Level,Streets Ahead,Strellson,STRENESSE,Stretta,Stride Rite,Strom,Strong Suit,Structure,Strut!,STS Blue,Stuart Weitzman,Stubbs & Wootton,Studio,Studio 17,Studio 1940,Studio Barse,Studio by JPR,Studio I,Studio M,Studio One,Studio Paolo,Studio Pollini,Studio West,Studio Works,Studio Y,Stuhrling Original,Stussy,Stutterheim,Style & Co,Style Link Miami,Style Mafia,Stylein,StyleMint,Stylestalker,STYLUS,Styluxe,Suarez,Submarine,Subtle Luxury,Sucre D'Orge,Sudini,Sue Devitt,Sue Wong,Sugar,Sugar Punch Couture,Sugarfly,Sugarlips,SUGOI,Suit Studio,summer & rose,Summer Rio,Sun & Shadow,Sun 68,Sun n Moon,Sunahara Jewelry,Sunbelt,Sunchild,SUNCLOUD,SUNCOO,Sundance,sundance boutique,Sunday in Brooklyn,Sunday Somewhere,Sundek,Sundry,Sunny Girl,Sunny Leigh,Sunny Taylor,SUNO,Sunshine & Shadow,Sunspel,Super Sunglasses,Superdry,SUPERFINE,Superfit,Superga,Supertrash,Supra,SUPRE,Supreme,Surell,Surf Gypsy,Surface to Air,Surfside Supply,Suruchi,Susan Bennis/Warren Edwards,Susan Bristol,Susan Farber Collections,Susan Gail,Susan Graver,Susan Lawrence,Susan Nichole,Susan Woo,Susana Monaco,Susi Apparel,Susina,Sutton Cashmere,Sutton Studio,Suunto,Suzanne Betro,Suzanne Somers,Suzelle,Suzi Chin,Suzi Chin for Maggy Boutique,Suzi Roher,Suzie In The City,Suzy Shier,Sven,SW3 Bespoke,Swaddle Designs,SWAK,SwankStyles,Swanky Coconut,Swarovski,Swatch,Sweater Project,Sweaterworks,Sweaty Betty,Swedish Hasbeens,Sweet Baby Jane,Sweet by Miss Me,Sweet Claire,Sweet Heart Rose,Sweet Love,Sweet Pea,Sweet Pea by Stacy Frati,Sweet Peanut,Sweet Rain,Sweet Romance,Sweet Romeo,Sweet Storm,Sweet Wanderer,Sweetees,Sweetheart Clothing,Sweetie Pie Collection,SWEETRICHES,Sweetums,Swell,Swim Solutions,Swims,Swimsuits For All,Swiss Legend,SwissGear,Swoon Boutique,Sydney Love,Sydney's Closet,Sylvia Heisel,Symmetry,Symphony,Symphony Bridal,Synergy Organic Clothing,T by Alexander Wang,T Party Fashion,T Tahari,T&G,T&J Designs,T-Bags,T-Shirt Addicts,T. Cappelli,T.J.Maxx,T.La,T.M.Lewin,T.U.K,t/o,T2 Love,Tabitha Simmons,Taboo,Tacera,Tacori,Tadashi Shoji,Tafford,Taft,TAG Elemental,Tag Heuer,Tag Twenty Two,Taggies,Tagliatore,Tahari,Tahari Woman,Tai,Tail,Tailor B. Moss,Tailor New York,Tailor Vintage,Tailorbyrd,TAJ by Sabrina Crippa,Taka,Takara,take out,Takeout,Takeshy Kurosawa,Talbots,Talitha,Talk of the Walk,Tally Ho,Talula,TALULAH,Tamara Mellon,Tammi Lyn,Tangerine,Tangerine NYC,TanJay,Tanner Krolle,Tannery West,Tano,Tantalyzn Apparel,Tantrums,Tanya Hawkes,Tanya Taylor,Tanya-b,Taos Footwear,Tapout,Tara Jarmon,Tara Keely,Targus,Tarik Ediz,Tarina Tarantino,Tark 1,Tarnish,Tart,Tart Collections,Tart Maternity,tarte,Tartine et Chocolat,Tarun Tahiliani,Taryn Rose,Tasha,Tasha Polizzi,Tasso Elba,Tatcha,Tateossian,Tatyana,Taunt,Taverniti So Jeans,Tavik,Taylor,Taylor & Sage,Taylor Dresses,Taylor Stitch,Taylor Swift,Tayzani,tba,TC,TCEC,Te Casan,Tea Collection,Tea n Cup,tea n rose,Teal Pineapple,Team Apparel,tech21,Technibond,Techno Com by KC,Technomarine,Tecnica,Ted Baker,Ted Baker London,Ted Rossi,Ted&Muffy,Teddi,Tee's Plus,teeki,TeenBell,Teenflo,Teenie Weenie,Tees by Tina,Teeze Me,TEHAMA,Tehen par Poles,Teija,tek gear,Tela,Temperley London,TEMPLE ST CLAIR,Tempo Paris,Tempted,Tempted Hearts,Ten Sixty Sherman,Terani Couture,Teresa Crowninshield,Terez,Teri Jon,Terra & Sky,Terramina,Terry Lewis Classic Luxuries,Terzetto,Tesori,Tessa Kim,Tessuto Menswear,Teva,Tevolio,Texas Leather Manufacturing,TEXTILE Elizabeth and James,TFNC,Thakoon,Thalia Sodi,Thalian,Thamanyah,The Academy Brand,The Accessory Collective,THE BABE COLLECTION,The Beatles,The Bikini Lab,The Black Dog,The Blossom Apparel,The Body Shop,The Cambridge Satchel Company,The Chic Petunia,The Children's Place,The Classic,the clothing company,The Fifth Label,THE FLEXX,The Girls,The Giving Keys,The Great China Wall,THE GREAT.,The Hanger,The Honest Company,The Hundreds,The Impeccable Pig,The Jetset Diaries,The Kooples,The Last Minute Bride,The Laundry Room,The Letter,The Limited,The Lost Boy Collective,The Mini Classy,The Mountain,The NEW Boutique,The North Face,The O Boutique,The Original Car Shoe,The Propose Inc.,The Pyramid Collection,The Rail,the room,The Row,The Row for Superga,The Sak,The Shirt by Rochelle Behrens,The Southern Shirt Company,The Territory Ahead,The Tie Bar,The Urban Ma,The Vanity Room,The Vintage Shop,The Wanderlust Bazaar,The Webster at Target,theBalm,Theia,thejeweladdict,Theme,Theodora & Callum,Theory,THEPERFEXT,therapy,Theyskens' Theory,THIERRY LASRY,Thierry Mugler,Thierry Rabotin,ThirdLove,thirty-one,THML,Thom Browne,Thom McAn,Thomas & Friends,Thomas Dean,Thomas Knoell Designs,Thomas Pink,Thomas Rabe,Thomas Sabo,Thomas Wylde,Thompson,thor,Thrasher,Thread & Supply,Thread Social,Threadless,Threads & Trends,Threads 4 Thought,Threadzwear,Three Bird Nest,Three Dots,Three Floor,Three for Twelve,Three Hearts,Three Seasons Maternity,Thursday Friday,Ti Adora by Alvina Valenta,Tia Dresses,Tiana B.,Tianello,Tiannl,Tiara,Tiare Hawaii,Tibi,Ticci Tonetto,Tieks,Tiffany & Co.,Tiffany & Fred,Tiffany Designs,Tiffany Jones Designs,Tifosi Optics,Tiger Mist,Tiger of Sweden,Tigerlily,TIGI,Tignanello,Til You Collapse,Tildon,Tilly's,TILT,Tim Coppens,Timberland,Timbuk2,Time and Tru,Timex,Timi & Leslie,Timing,Timmy Woods,Timo Weiland,Timothy Hitsman,Tina Hagen,Tinley Road,Tinsel,Tinseltown,Tion Design,Tip Toey Joey,Tip Top Kids,Tipsy Elves,Tissavel of France,Tissot,Titan,Titanium,Title nine,Titleist,Tivoli,Tiziana Cervasio,Tiziano Reali,TKEES,TKO,TNA,To Boot,To the Max,Toad&Co,Tobi,Tocca,Tod's,Todd Oldham,Todd Snyder,TOGA,TOGA Pulla,Together,Toi et Moi,tokidoki,tokyo Darling,TOKYObay,Tolani,Tom Binns,Tom Ford,Tom Rebl,TOM WOOD,Tomas Maier,Tomasina,Tombolini,Tommy Bahama,Tommy Hilfiger,Tommy John,TOMORROWLAND,Toms,Tonello,TONI FEDERICI,Tony Bianco,Tony Bowls,Tony Hawk,Tony Lama,Too Faced,Too Fast,Toobydoo,Toots Boutique,TOP Moda,Top of the World,Top Secret,Topfoxx,Topia,Topman,Topshop,Topshop MATERNITY,Topshop PETITE,Tori Praver,Tori Praver Swimwear,Tori Richard,Torn by Ronny Kobo,torrid,Tory Burch,Tory Klein,TOSCA BLU,Toska,Toskana,total girl,totes,Tottenham Hotspur,Touch by Alyssa Milano,Touch of Nina,Touch Ups,Toughskins,Tourneau,Tous,TOV Holy,Towne & Reese,TOWNSEN,ToyWatch,Trac,Traci Lynn,Tracie Martyn,Tractr,Tracy Evans,Tracy Feith,Tracy M,Tracy Negoshian,Tracy Reese,Trader Bay,Tradlands,Trafalgar,Trafaluc,Traffic,Traffic People,Tramp,Transparente,Trash & Luxury,Trashy Diva,Trask,Trau & Loevner,Travelon,TravelSmith,Travis Ayers,Travis Mathew,Tre Vero,Treasure & Bond,Treesje,TRELISE COOPER,Trendy boutique,Trendy Jewels,Trendy Tummy Maternity,Tres Bien,Tres Jolie Accessories,Tresics,Treska,Trespass,Tretorn,triangl swimwear,Tribal,Tribeca by Kenneth Cole,Tricia Fix,Tricker's,Tricot Comme des Garcons,Tricotez,Trifari,Trillium,Trina Turk,Trindy Clozet Boutique,Trio New York,Triple 7,Triple Five Soul,Tripp nyc,Trish McEvoy,Triumph,Trixxi,Troizenfants,Trollbeads,Tropical Escape,Trosman,Trotters,Trouve,Trovata,Tru Luxe Jeans,Tru Trussardi,True Craft,True Freedom,True Grit,TRUE LIGHT,True Meaning,True Religion,TRUE ROCK,Truenyc.,Trukfit,Truly Madly Deeply,Truly Me,Trumpet Jewels,Trumpette,Trunk Ltd,Trussardi,Truth and Pride,Truth NYC,Truth Soul Armor,Tryst,TSE,TSH,Tsubo,Tsukihoshi,Tsumori Chisato,Tu es mon TRESOR,Tua,Tucker,Tucker + Tate,Tudor,Tuff Athletics,Tufi Duek,tuk,Tula,Tularosa,Tuleh,Tulle,Tultex,Tumi,Tundra,Turbulence,Turnbull & Asser,Tutu Du Monde,Tuzzi Nero,TW Steel,Tweeds,Twelfth Street by Cynthia Vincent,Twelve by Twelve,Twenty,Twenty8Twelve,Twice Chic Boutique,twiggy LONDON,Twilight Gypsy Collective,Twill Twenty Two,Twin-Set,Twinkle by Wenlan,Twisted,TWISTED HEART,Twisted X,Twister,Two by Vince Camuto,Two Girls,Two Hearts Maternity,Two Lips,Twobirds,TY Original Wear,Tyche,Tyler Boe,Tyler Rodan,Tyler Rose Swimwear,Tylie Malibu,Type Z,TYR,Tyte Jeans,U-Boat,U-Knit Dresses,U-NI-TY,U.S. Polo Assn.,U2 Wear Me Out,UGG,UjENA,UK2LA,Ulla Johnson,Ulla Popken,Ulla-Maija,Ulta Beauty,Ultimate Miks,Ultra Dress Collection,Ultra Flirt,Ultra Pink,Ulu,Ulysse Nardin,Umberto Raffini,Umbro,Umgee,Umi,Umit Benan,Un Deux Trois,Uncle Frank,Uncommon,Unconditional,Undefeated,Under Armour,Under One Sky,Under Skies,under.ligne,Undercover,Undercover Mama,Undergirl,Ungaro Fever,UNIF,Uniform Advantage,Unik,UNIONBAY,Uniqlo,Uniqlo x KAWS,Unique Bargains,Unique Spectrum,Unique Vintage,Unisa,United Colors Of Benetton,United Nude,united states sweaters,Uniti Casual,Unity World Wear,Universal,Universal Standard,Universal Thread,Univibe,Unlisted,Unlisted by Kenneth Cole,UNO de 50,Unreal Fur,Unsensored,UNTAMED PETALS BY AMANDA JUDGE,UNTUCKit,Unwritten,Unyx,UpSpring Baby,Urban 1972,Urban Behavior,Urban Decay,Urban Expressions,Urban Girl Nites,Urban Luxe Design Co.,Urban Mix LA,Urban Originals,Urban Outfitters,urban pipeline,Urban Renewal,Urban Republic,Urban Sweetheart,Urbane,Urge,Ursula of Switzerland,Us Angels,Usher,Uterque,Utex,Utopia Africa Designs,Uttam London,V By Eva,V. FRAAS,V::room,Va et Vien for BHLDN,Va Va Voom,Vacheron Constantin,Vagabond,VAHAN,Vakko,Val Stefani,Valenti Franco,Valentina,Valentina Terra,Valentino,Valentino Garavani,Valentino Orlandi,Valerie Bertinelli,Valerie Stevens,Valette,Valextra,Valfre,Valia,Valleau Apparel,Valley Eyewear,Valley Lane,ValMarie,Valmont,Van Cleef & Arpels,Van Eli,Van Heusen,Vaneli,Vanessa Bruno,Vanessa Mooney,Vanessa Seward,Vanilla Bay,Vanilla Star,Vanilla Sugar,Vanity,Vanity Fair,VANNI,Vans,Varga,Varley,Varsavia Viamara,Varsity,Vasque,vassarette,Vaute Couture,Vava by Joy Han,VBH,Vecceli Italy,Veda,Vedette Shapewear,Veja,Velvet,Velvet Angels,Velvet by Graham & Spencer,Velvet Heart,Velvet Torch,Velzera,Vena Cava,Venettini,Venezia,Ventti,VENUS,Venus Bridal,Venus of Cortland,Vera Bradley,Vera Mont,Vera Pelle,Vera Wang,Vera Wang Lavender Label,Veranesi,Vericci,Vero Cuoio,Vero Moda,Veronica Beard,Veronica M,veronique branquinho,Verpass,Verragio,Versace,Versace Collection,Versace for H&M,Versace Jeans Collection,Versani,Versona,Versus By Versace,Versus Versace,Vertigo Paris,verty,Verve Ami,Very J,Very Moda,Very Volatile,Vestal,Vesti,vestique,Vetements,Veto,VfEmage,vfish,Via Appia Due,Via Condotti,Via Neroli,Via Prive,Via Spiga,Via Veneto,Vibe,Vibram,Vibrant,Vic Matie,Vici,Vicini,Victor Alfaro,Victor Costa,Victoria Beckham,Victoria Beckham for Target,Victoria Emerson,Victoria Jones Woman,Victoria K,Victoria Luxury Silk,Victoria Lynn,Victoria Royal Ltd,Victoria Townsend,Victoria Wieck,Victoria's Bridal Collection,Victoria's Secret,Victoria/Tomas,Victorinox,VIDA,Vienna Prom,VienneMilano,Vieste,VIETA Fashion,Vigold,Vigoss,Vigotti,Vikki Vi,Viktor & Rolf,VILA,Vilebrequin,villager,Vimmia,Vince,Vince Camuto,Vincent Longo,Vincenzo Allocca,Vine Street Apparel,Vineyard Vines,Vintage,Vintage 316,Vintage 55,Vintage America,Vintage Havana,Vintage Rebel,Vintage Suzie,Violet & Claire,Violet Kay,Violet Voss,Vionic,Vionnet,VIP,Virgins Saints & Angels,Virgo,VISSLA,Visvim,Vita Fede,Vitamin A,Vitamins Baby,Vittorio,Vivacouture,ViVI,Viviana,Vivienne Tam,Vivienne Westwood,Vivo barefoot,Vix,VLONE,VM,Vocal,VOGO Athletica,Vogue,Vogue Eyewear,Voile Blanche,Voir Voir,Volatile,Volcom,Von Dutch,Von Vonni,Von Zipper,Voodoo Vixen,Voom by Joy Han,Votre Nom,VPL,vu,Vuarnet,W by Worth,W. Kleinberg,W.R.K,W118 by Walter Baker,W5,Wacoal,Walborg,Wallflower,Wallis,Wallpapher,Walter Baker,Walter Genuin,Walter Steiger,Wanda Nylon,Want It All,WANT Les Essentiels,Wanted,Warby Parker,Warehouse,Warm,Warner Bros.,Warner's,Wasson,Wathne,Watters,Waverly Grey,Wax Jean,Waxing Poetic,Wayf,Wayuu Tribe,WD.NY,We The Free,Weatherproof,Weavers,Weavz,WEDDING BELLES NEW YORK,Weddington Way,Wee Ones,Weekend Society,Weekenders,Weimann,Weise,Weiss Furs,Weissman,Well Dressed Wolf,Well Worn,Wells Grace,Wembley,Wendy Bellissimo,Wendy Glez,Wendy Hil,Wendy Katlen,Wendye Chaitin,Wenger,Wes Gordon,Wesc,West Blvd,West Kei,west loop,Westbound,Western Chief,Weston Wear,Westport,Westward Leaning,wet n wild,Wet Seal,What Goes Around Comes Around,Whetherly,Whimsical Watches,Whirlaway Frocks,Whistles,WHIT,White + Warren,White by Vera Wang,White Fox Boutique,White House Black Market,White Label Rofa Fashion,White Mark,White Mountain,White Mountaineering,White Sierra,White Stag,Whiting & Davis,Whitney Eve,Who What Wear,Wico,WILA,Wild Diva,wild fable,Wild Pair,Wild Pearl,Wild Rose,Wilda,Wildflower,Wildfox,Wilfred,Will Leather Goods,Willi Smith,William Barry,William Rast,Willow & Clay,Willow Ridge,Wilson,Wilsons Leather,Wilt,Wimbledon,Windsor,Wings + Horns,WINKY LUX,Winnie Couture,Winter Kate,WinterSilks,WinWin,Wish,Wishes Wishes Wishes,Wishful Park,Wishlist,Wit & Wisdom,With & Wessel,With Jean,Without Walls,Witness,Wolford,Wolky,Wolverine,Woman I am by anja gockel,Woman Within,Woman's Touch Apparel,Womyn,wonder nation,Wonderbra,Wonderkids,WONDERLAND,WonderWink,Wood Wood,Wooden Ships,Woolrich,woowaa,Wooyoungmi,Workshop Republic Clothing,Worth,Worthington,Wound Up,WOW couture,Wrangler,Wrapper,Wren,Wright & Ditson,Wtoo,WTXtreme,Wunderbrow,Wundervoll,Wurkin Stiffs,Wurl,WWAKE,WWE,Wyeth by Todd Magill,Wythe NY,x-appeal,X2,Xacus,Xadoo,Xappeal,Xcite Prom,XCVI,Xenia Boutique,Xersion,Xhilaration,XiRENA,XOXO,Xscape,Xtaren,Xtraordinary,Xtreme Lashes by Jo Mousselli,Y&S Handbags,Y's by Yohji Yamamoto,Y-3,Y/Project,Ya Los Angeles,Ya Ya Club,Yag Couture,Yahada,Yak Pak,Yakum,Yala,Yandy,Yansi Fugel,Yanuk,YaYa Aflalo,Yazilind,Yeezy,Yelete,Yellow Box,Yeti,Yigal Azrouel,YINER,YL by Yair,YMC,YMI,YNS Generic,Yoana Baraschi,Yochi,Yoek,Yogalicious,Yohji Yamamoto,Yoki,Yolanda Couture,Yoli Rapp,Yoly Munoz,Yoon,Yoona,Yosi Samra,Youmita,Young & Reckless,Young Essence,Young Fabulous & Broke,Youngland,Younique,Yours Clothing,Yppig,YRU,Ysa Makino,Yukiko,Yumi Katsura,Yumi Kim,Yumiko,Yummie by Heather Thomson,Yuu,Yves Rocher,Yves Saint Laurent,Yves Salomon,Yves St. Clair,Z Spoke by Zac Posen,Z Supply,Z Zegna,Z-Coil,Z. Cavaricci,Zable,Zac & Rachel,Zac Posen,Zac Posen for Target,ZAC Zac Posen,Zachary Prell,Zachary's Smile,Zackali 4 Kids,ZAD,Zadig & Voltaire,Zaful,Zagliani,Zales,Zalo,Zana Di,Zanadi,Zanella,Zanerobe,Zang Toi,Zanone,Zanzea,Zara,Zara Terez,Zay,ZCO,zdazzled,zedd plus,ZEF,Zele,Zelie for She,Zella,Zella Girl,Zena,Zenana Outfitters,Zenim,Zenith,Zenobia,Zephyr,Zero + Maria Cornejo,Zero 2 Nine Maternity,ZeroXposur,Zerres,zestt,Zeta Ville,Zeugari,Zhenzi,Ziani Couture,ZIGI girl,Zigi Soho,ZIIIRO,Zimmerli,Zimmermann,Zina Eva,zinc,Zine Clothing,Zinke,Zion Rootswear,Zizzi,Zobha,Zoccai,Zodiac,Zoe + Liv,Zoe Chicco,Zoe Karssen,Zoe Ltd,ZOEVA,Zoey Zoso,ZokyDoky,Zoo York,Zoompy,Zoot,Zoran,Zoya,Zuhair Murad,Zum Zum by Niki Livas,Zumba Fitness,Zumiez,Zunie,Zutano,Zveil,Zwilling Pour Homme,ZYDO";

	public static int status_check_iter = 0;

	private update_app up = new update_app();

	private int iter_visuals = 0;

	private static string pepsi = "";

	private IContainer components = null;

	private MetroPanel metroPanel1;

	private ToolStripMenuItem homeToolStripMenuItem1;

	private ToolStripMenuItem featuresToolStripMenuItem;

	private ToolStripMenuItem poshmarkProToolsToolStripMenuItem;

	private ToolStripMenuItem poshmarkProLeadsToolStripMenuItem;

	private ToolStripMenuItem instaPoshToolStripMenuItem;

	private ToolStripMenuItem backupClosetToolStripMenuItem;

	private ToolStripMenuItem editAndListENLToolStripMenuItem;

	private ToolStripMenuItem poshmarkInfluencerToolStripMenuItem;

	private ToolStripMenuItem poshmarkSchedulerToolStripMenuItem;

	private ToolStripMenuItem settingsToolStripMenuItem;

	private ToolStripMenuItem configurationToolStripMenuItem;

	private ToolStripMenuItem registerToolStripMenuItem;

	private Splitter splitter1;

	private SplitContainer splitContainer1;

	private SplitContainer splitContainer2;

	public TextBox Log_textBox1;

	public TextBox status_textBox1;

	private MetroButton Continue_button3;

	private MetroButton Pause_button2;

	public MetroButton Stop_button1;

	public MetroButton Start_button1;

	public MetroLabel mainform_header;

	public MetroLabel metroLabel1;

	private ToolStripMenuItem otherToolStripMenuItem;

	private ToolStripMenuItem chatToolStripMenuItem;

	private ToolStripMenuItem messageUsToolStripMenuItem;

	private PictureBox pictureBox1;

	private ToolStripMenuItem pinPoshToolStripMenuItem;

	public MetroLabel lastTab_metroLabel2;

	private ToolStripMenuItem aboutUsToolStripMenuItem;

	private ToolStripMenuItem reportToolStripMenuItem;

	private ToolStripMenuItem generateReportToolStripMenuItem;

	private ToolStripMenuItem proToolsManualToolStripMenuItem;

	private ToolStripMenuItem bulkPriceEditToolStripMenuItem;

	private SplitContainer splitContainer3;

	public MetroLabel instance_count;

	private ToolStripMenuItem listingsUplodFromExcelToolStripMenuItem;

	private ToolStripMenuItem newsToolStripMenuItem;

	public MetroLabel version_label;

	public MetroLabel coupon_metroLabel2;

	public MenuStrip menuStrip1;

	public ToolStripMenuItem browserToolStripMenuItem;

	public ToolStripMenuItem update_menu_button;

	public void restart_app_forcefully()
	{
		try
		{
			int num = 1;
			while (true)
			{
				Thread.Sleep(28800000);
				up.MakeRequests(this, "just_update_button");
				if (num % 2 == 0)
				{
					_ = key_generator_class.real_time;
					num = 0;
					eob.get_WebView().Reload();
				}
				register_control.registration_Button1_Click(null, null);
				num++;
				try
				{
					string text = lg.get_user_email(ck);
					if (text != null)
					{
						upload_email(text);
					}
				}
				catch
				{
				}
			}
		}
		catch
		{
		}
	}

	public void set_eo_cookie()
	{
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected O, but got Unknown
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Expected O, but got Unknown
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected O, but got Unknown
		try
		{
			if (!File.Exists(cookie_save_path))
			{
				File.WriteAllText(cookie_save_path, "");
			}
			if (((CheckBox)pro_configuration_class.save_login_metroCheckBox1).get_Checked())
			{
				string input = File.ReadAllText(cookie_save_path);
				ck = new CookieContainer();
				ck.PerDomainCapacity = 300;
				string[] array = Regex.Split(input, "\r\n");
				string[] array2 = array;
				foreach (string text in array2)
				{
					try
					{
						if (!(text == ""))
						{
							string[] array3 = Regex.Split(text, ";");
							string[] array4 = Regex.Split(array3[0], "=");
							Cookie cookie = new Cookie();
							Cookie val = new Cookie(array4[0], array4[1]);
							cookie.Name = array4[0];
							cookie.Value = array4[1];
							cookie.Domain = "poshmark.com";
							if (((CheckBox)pro_configuration_class.canadian_closet_metroCheckBox1).get_Checked())
							{
								cookie.Domain = "poshmark.ca";
							}
							ck.Add(cookie);
							val.set_Domain(cookie.Domain);
							eob.get_WebView().get_Engine().get_CookieManager()
								.SetCookie(val);
						}
					}
					catch (Exception)
					{
					}
				}
			}
			eob.get_WebView().set_Url("https://poshmark.com/login");
		}
		catch
		{
		}
		eob.get_WebView().add_NewWindow(new NewWindowHandler(webView1_NewWindow));
		eob.get_WebView().add_LoadCompleted(new LoadCompletedEventHandler(WebView_LoadCompleted));
		eob.get_WebView().add_LaunchUrl(new LaunchUrlHandler(WebView_LaunchUrl));
		eob.get_WebView().add_UrlChanged((EventHandler)WebView_UrlChanged);
	}

	public Form1()
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_026d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected O, but got Unknown
		//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_041c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0423: Expected O, but got Unknown
		//IL_046a: Unknown result type (might be due to invalid IL or missing references)
		//IL_052f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0534: Unknown result type (might be due to invalid IL or missing references)
		//IL_0536: Unknown result type (might be due to invalid IL or missing references)
		//IL_0539: Invalid comparison between Unknown and I4
		//IL_05d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05dc: Invalid comparison between Unknown and I4
		InitializeComponent();
		try
		{
			ServiceController val = new ServiceController();
			val.set_MachineName(".");
			val.set_ServiceName("mysql");
			val.Stop();
		}
		catch
		{
		}
		ServicePointManager.Expect100Continue = true;
		ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
		brands_list = Regex.Split(ALL_brands, ",").ToList();
		brands_list = brands_list.Distinct().ToList();
		((Control)version_label).set_Text("Version: " + Assembly.GetExecutingAssembly().GetName().Version!.ToString() + ", Product Not Activated");
		key_generator_class key_generator_class = new key_generator_class();
		_new_user_key = key_generator_class.system_key;
		_ = key_generator_class.real_time;
		try
		{
			if (File.Exists(credential_path))
			{
				string text = File.ReadAllText(credential_path);
				if (text != "")
				{
					((Control)register_control.license_key_TextBox1).set_Text(text);
				}
			}
		}
		catch
		{
		}
		try
		{
			infinite_thread = new Thread(restart_app_forcefully);
			infinite_thread.Start();
		}
		catch
		{
		}
		try
		{
			mainform = this;
			((Control)Log_textBox1).set_Visible(false);
			((Control)status_textBox1).set_Visible(false);
			((Control)Continue_button3).set_Visible(false);
			((Control)Pause_button2).set_Visible(false);
			((Control)Stop_button1).set_Visible(false);
			((Control)Start_button1).set_Visible(false);
			ed = new extract_data(lg);
			((Control)mainform_header).set_Text("");
			((Control)lastTab_metroLabel2).set_Text("");
			check_mandatory_things();
			registry_check();
			if (!File.Exists(update_app.folder_path + "\\msi.msp"))
			{
				File.WriteAllText(update_app.folder_path + "\\msi.msp", "");
			}
			download_all_files();
			try
			{
				Runtime.AddLicense("6A+frfD09uihfsay4Q/lW5f69h3youbyzs2xaqW0s8uud7Pl9Q+frfD09uihfsay6BvlW5f69h3youbyzs2xaaW0s8uud7Pl9Q+frfD09uihfsay6BvlW5f69h3youbyzs2xaqW0s8uud7Oz8hfrqO7CzRrxndz22hnlqJfo8h/kdpm1wNyuaae0ws2frOzm1iPvounpBOzzdpm1wNyucrC9ys2fr9z2BBTup7Smw82faLXABBTmp9j4Bh3kd+T20tbFiajL4fPRoenW2RX4ksbS4hK8drOzBBTmp9j4Bh3kd7Oz/RTinuX39ul14+30EO2s3MLNF+ic3PIEEMidtbXE3rZ1pvD6DuSn6unaD7112PD9GvZ3s+X1D5+t8PT26KF+xrLUE/Go5Omzy/We6ff6Gu12mbbB2a9bl7PP5+Cd26QFJO+etKbW+q183/YAGORbl/r2HfKi5vLOzbFqpbSzy653s+X1D5+t8PT26KF+xrLoEOFbl/r2HfKi5vLOzbFppbSzy653s+X1D5+t8PT26KF+xrLoEOFbl/r2HfKi5vLOzbFqpbSzy653s+X1D5+t8PT26KF+xrLhD+Vbl/r2HfKi5vLOzbFppbSzy653s+X1");
			}
			catch
			{
			}
			try
			{
				Runtime.get_DefaultEngineOptions().set_DisableGPU(true);
			}
			catch
			{
			}
			if (!Directory.Exists(update_app.folder_path + "\\eoo"))
			{
				Directory.CreateDirectory(update_app.folder_path + "\\eoo");
			}
			WebView val2 = new WebView();
			val2.set_ZoomFactor(0.75);
			eob.set_WebView(val2);
			Engine val3 = Engine.Create("poshmarktools");
			val3.get_Options().set_CachePath(update_app.folder_path + "\\eoo");
			val3.Start();
			eob.get_WebView().set_Engine(val3);
			try
			{
				read_backup_data();
			}
			catch (Exception ex)
			{
				MessageBox.Show("ppss-- " + ex.ToString());
			}
			set_eo_cookie();
			register_control.registration_Button1_Click(null, null);
			((Control)register_control.Regitsration_Status__label).set_Text("Pro Tools Registration: " + protoll_registration + "\r\nPro Leads Registration: " + proLeed_registration + "\r\nInsta Posh Registration: " + InstaPosh_registration + "\r\nENL Registration: " + Enl_permission + "\r\nPinterest Registration: " + pinterest_registration + "\r\nSchedules Expiry Registration: " + schedule_end_date + " - " + schedule_rows + "\r\nReports Status: " + report_registration + "\r\nBulk Edit Status: " + bulk_edit_permission);
			try
			{
				if (!Directory.Exists("logs"))
				{
					Directory.CreateDirectory("logs");
				}
				List<string> list = File.ReadAllLines("logs//logs.jk").ToList();
				if (list.Count > 300)
				{
					list.RemoveRange(0, 300);
					File.WriteAllLines("logs//logs.jk", list);
				}
			}
			catch
			{
			}
			Icon icon = new Icon(update_app.folder_path + "\\Poshmark_.ico");
			((Form)this).set_Icon(icon);
			up.move_files();
			check_2captcha_Service_configuration();
			try
			{
				pro_browser.main_initialize();
			}
			catch
			{
			}
			console_start_class.ld.close_this_form();
		}
		catch (Exception ex2)
		{
			MessageBox.Show("111-- " + ex2.ToString());
		}
		try
		{
			hide_all_files();
			Thread thread = new Thread((ThreadStart)delegate
			{
				up.MakeRequests(this, "true");
			});
			thread.Start();
		}
		catch
		{
		}
		try
		{
			int num = 0;
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				if (process.ProcessName.Contains("Poshmark_tool"))
				{
					num++;
				}
			}
			try
			{
				((Control)instance_count).set_Text(num + "/" + app_instances_MAX);
			}
			catch
			{
			}
			if (num > app_instances_MAX)
			{
				DialogResult val4 = MessageBox.Show("You are trying to run more than allowed (" + app_instances_MAX + ") pro tools app, Click yes to close extra apps, Or purchase Commercial License", "Pro Tools App Already Running", (MessageBoxButtons)4);
				if ((int)val4 == 6)
				{
					int id = Process.GetCurrentProcess().Id;
					num = 1;
					Process[] processes2 = Process.GetProcesses();
					foreach (Process process2 in processes2)
					{
						if (process2.ProcessName.ToLower().Contains("poshmark_tools") && id != process2.Id)
						{
							num++;
							if (num > app_instances_MAX)
							{
								process2.Kill();
							}
						}
					}
					try
					{
						((Control)instance_count).set_Text(num + "/" + app_instances_MAX);
					}
					catch
					{
					}
				}
				else if ((int)val4 == 7)
				{
					Environment.Exit(1);
				}
			}
		}
		catch
		{
		}
		newsToolStripMenuItem_Click(null, null);
		try
		{
			((TextBoxBase)Log_textBox1).set_WordWrap(false);
			((TextBoxBase)status_textBox1).set_WordWrap(false);
		}
		catch
		{
		}
	}

	private void hide_all_files()
	{
		try
		{
			string[] files = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.*", SearchOption.TopDirectoryOnly);
			string[] array = files;
			foreach (string text in array)
			{
				if (!text.Contains("Poshmark_tools.exe"))
				{
					File.SetAttributes(text, FileAttributes.Hidden);
				}
			}
			string[] directories = Directory.GetDirectories(Directory.GetCurrentDirectory());
			foreach (string text2 in directories)
			{
				if (!text2.Contains("Poshmark_tools.exe") && !text2.Contains("Reports"))
				{
					File.SetAttributes(text2, FileAttributes.Hidden);
				}
			}
		}
		catch
		{
		}
	}

	private void check_2captcha_Service_configuration()
	{
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			List<string> list = File.ReadAllLines(update_app.folder_path + "\\Captcha_data.txt").ToList();
			((Control)pro_configuration_class.captcha_2_password_textbox).set_Text(list[2]);
			((Control)pro_configuration_class.captcha_api2_textbox).set_Text(list[0]);
			((Control)pro_configuration_class.catcha_2_username).set_Text(list[1]);
			if (((Control)pro_configuration_class.captcha_2_password_textbox).get_Text() != "" && ((Control)pro_configuration_class.captcha_api2_textbox).get_Text() != "" && ((Control)pro_configuration_class.catcha_2_username).get_Text() != "")
			{
				_2captcha_key = ((Control)pro_configuration_class.captcha_api2_textbox).get_Text();
				_2captcha_password = ((Control)pro_configuration_class.captcha_2_password_textbox).get_Text();
				C2CaptchaService c2CaptchaService = new C2CaptchaService(_2captcha_key, _2captcha_password);
				string text = c2CaptchaService.GetBalance().ToString();
				if (text == "-1")
				{
					_2captcha_key = "";
					_2captcha_password = "";
					((Control)pro_configuration_class.captcha_balence).set_Text("2Captcha Not Configured");
					MessageBox.Show("Cannot able to autheticate 2captcha, check again");
				}
				else
				{
					if (text == "0.0")
					{
						MessageBox.Show("You 2Captcha balence is 0");
					}
					((Control)pro_configuration_class.captcha_balence).set_Text("2Captcha Balence: " + text + " (Configured Successfully)");
				}
			}
			else
			{
				((Control)pro_configuration_class.captcha_balence).set_Text("2Captcha: (Not Configured)");
			}
		}
		catch
		{
			((Control)pro_configuration_class.captcha_balence).set_Text("2Captcha: (Not Configured)");
		}
	}

	public void download_all_files()
	{
	}

	public void Essential_object_dlls()
	{
		try
		{
			string sourceArchiveFileName = Directory.GetCurrentDirectory() + "\\EO.zip";
			string text = Directory.GetCurrentDirectory() + "\\EO";
			if (Directory.Exists(text))
			{
				return;
			}
			if (!File.Exists("EO.zip"))
			{
				using WebClient webClient = new WebClient();
				webClient.DownloadFile("http://poshmarktools.com/support/mpt/EO.zip", Directory.GetCurrentDirectory() + "\\EO.zip");
			}
			if (File.Exists("EO.zip"))
			{
				ZipFile.ExtractToDirectory(sourceArchiveFileName, text);
			}
			DirectoryInfo directoryInfo = new DirectoryInfo(text);
			FileInfo[] files = directoryInfo.GetFiles("*.dll");
			FileInfo[] array = files;
			foreach (FileInfo fileInfo in array)
			{
				File.Move(fileInfo.FullName, Directory.GetCurrentDirectory() + "\\" + fileInfo.Name);
			}
		}
		catch
		{
		}
	}

	public static void test_threading(object data)
	{
		cef_download item = (cef_download)data;
		try
		{
			using WebClient webClient = new WebClient();
			webClient.DownloadFile(item.link, item.path);
		}
		catch
		{
			unsuccessfull_downloads.Add(item);
		}
	}

	private void registry_check()
	{
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Invalid comparison between Unknown and I4
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Invalid comparison between Unknown and I4
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\WOW6432Node\\Clients\\StartMenuInternet");
			if (registryKey == null)
			{
				registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Clients\\StartMenuInternet");
			}
			string[] subKeyNames = registryKey.GetSubKeyNames();
			List<Browser> list = new List<Browser>();
			for (int i = 0; i < subKeyNames.Length; i++)
			{
				Browser browser = new Browser();
				RegistryKey registryKey2 = registryKey.OpenSubKey(subKeyNames[i]);
				browser.Name = (string)registryKey2.GetValue(null);
				RegistryKey registryKey3 = registryKey2.OpenSubKey("shell\\open\\command");
				browser.Path = registryKey3.GetValue(null)!.ToString();
				RegistryKey registryKey4 = registryKey2.OpenSubKey("DefaultIcon");
				browser.IconPath = registryKey4.GetValue(null)!.ToString();
				if (browser.Path != null)
				{
					browser.Version = FileVersionInfo.GetVersionInfo(browser.Path.Replace("\"", "")).FileVersion;
				}
				else
				{
					browser.Version = "unknown";
				}
				list.Add(browser);
			}
			foreach (Browser item in list)
			{
				if (!((CheckBox)pro_configuration_class.browser_checkBox1).get_Checked())
				{
					if (item.Name.ToLower() == "internet explorer")
					{
						string[] array = Regex.Split(item.Version, "\\.");
						if (int.Parse(array[0]) >= 11)
						{
							break;
						}
						DialogResult val = MessageBox.Show("You have old Internet Explorer installed, click yes to update your browser", "Old Browser", (MessageBoxButtons)4);
						if ((int)val == 6)
						{
							Process.Start("https://www.microsoft.com/en-us/download/internet-explorer-11-for-windows-7-details.aspx");
							Environment.Exit(1);
						}
						else if ((int)val == 7)
						{
							Environment.Exit(1);
						}
					}
				}
				else if (((CheckBox)pro_configuration_class.browser_checkBox1).get_Checked())
				{
					break;
				}
			}
		}
		catch
		{
		}
	}

	private void check_mandatory_things()
	{
		try
		{
			if (!Directory.Exists(update_app.folder_path))
			{
				Directory.CreateDirectory(update_app.folder_path);
			}
			if (!Directory.Exists(update_app.folder_path_backup))
			{
				Directory.CreateDirectory(update_app.folder_path_backup);
			}
			if (!File.Exists(update_app.folder_path + "\\Poshmark_.ico"))
			{
				using WebClient webClient = new WebClient();
				webClient.DownloadFile("http://poshmarktools.com/support/mpt/DownloadableFiles/Poshmark_.ico", update_app.folder_path + "\\Poshmark_.ico");
			}
			if (!File.Exists(update_app.folder_path + "\\giphy.gif"))
			{
				using WebClient webClient2 = new WebClient();
				webClient2.DownloadFile("http://poshmarktools.com/support/mpt/DownloadableFiles/giphy.gif", update_app.folder_path + "\\giphy.gif");
			}
			try
			{
				if (Directory.Exists(update_app.folder_path))
				{
					if (File.Exists(update_app.folder_path + "\\snk.pk"))
					{
						string text = File.ReadAllText(update_app.folder_path + "\\snk.pk");
						if (!(text == Assembly.GetExecutingAssembly().GetName().Version!.ToString()))
						{
							File.WriteAllText(update_app.folder_path + "\\snk.pk", Assembly.GetExecutingAssembly().GetName().Version!.ToString());
						}
					}
					else
					{
						File.WriteAllText(update_app.folder_path + "\\snk.pk", Assembly.GetExecutingAssembly().GetName().Version!.ToString());
					}
				}
			}
			catch
			{
			}
			try
			{
				if (File.Exists(update_app.folder_path + "//browser.ck"))
				{
					string text2 = File.ReadAllText(update_app.folder_path + "//browser.ck");
					if (text2 == "0")
					{
						((CheckBox)pro_configuration_class.browser_checkBox1).set_Checked(false);
					}
					else
					{
						((CheckBox)pro_configuration_class.browser_checkBox1).set_Checked(true);
					}
				}
				else
				{
					((CheckBox)pro_configuration_class.browser_checkBox1).set_Checked(true);
				}
			}
			catch
			{
			}
		}
		catch (Exception)
		{
		}
	}

	private void delete_extracontrols(Control c)
	{
		try
		{
			c.set_Dock((DockStyle)5);
			if (!((Control)splitContainer2.get_Panel1()).get_Controls().Contains(c))
			{
				((Control)splitContainer2.get_Panel1()).get_Controls().Add(c);
			}
			for (int i = 0; i < ((ArrangedElementCollection)((Control)splitContainer2.get_Panel1()).get_Controls()).get_Count(); i++)
			{
				if (c != ((Control)splitContainer2.get_Panel1()).get_Controls().get_Item(i))
				{
					((Control)splitContainer2.get_Panel1()).get_Controls().Remove(((Control)splitContainer2.get_Panel1()).get_Controls().get_Item(i));
				}
				else if (iter_visuals < 1)
				{
					delete_extracontrols(c);
					iter_visuals++;
				}
			}
			if (c.get_Name() == "Register" || c.get_Name() == "Pro_configurations" || c.get_Name() == "About_us" || c.get_Name() == "Pro_browser" || c.get_Name() == "news")
			{
				splitContainer1.set_Panel2Collapsed(true);
				((Control)splitContainer1.get_Panel2()).Hide();
				splitContainer2.set_Panel2Collapsed(true);
				((Control)splitContainer2.get_Panel2()).Hide();
				((Control)Log_textBox1).set_Visible(false);
				((Control)status_textBox1).set_Visible(false);
				((Control)Continue_button3).set_Visible(false);
				((Control)Pause_button2).set_Visible(false);
				((Control)Stop_button1).set_Visible(false);
				((Control)Start_button1).set_Visible(false);
			}
			else
			{
				splitContainer1.set_Panel2Collapsed(false);
				splitContainer1.get_Panel2().set_Visible(true);
				splitContainer2.set_Panel2Collapsed(false);
				splitContainer2.get_Panel2().set_Visible(true);
				((Control)Log_textBox1).set_Visible(true);
				((Control)status_textBox1).set_Visible(true);
				((Control)Continue_button3).set_Visible(true);
				((Control)Pause_button2).set_Visible(true);
				((Control)Stop_button1).set_Visible(true);
				((Control)Start_button1).set_Visible(true);
			}
		}
		catch (Exception ex)
		{
			if (!Directory.Exists("logs"))
			{
				Directory.CreateDirectory("logs");
			}
			File.AppendAllText("logs//logs.jk", "dlt) " + ex.ToString() + "\r\n");
		}
	}

	private void registerToolStripMenuItem_Click(object sender, EventArgs e)
	{
		delete_extracontrols((Control)(object)register_control);
		((Control)mainform_header).set_Text("Register");
	}

	public void poshmarkProToolsToolStripMenuItem_Click(object sender, EventArgs e)
	{
		delete_extracontrols((Control)(object)pro_tools_class);
		((Control)mainform_header).set_Text("Poshmark Pro Tools");
	}

	private void poshmarkProLeadsToolStripMenuItem_Click(object sender, EventArgs e)
	{
		delete_extracontrols((Control)(object)pro_leads_class);
		((Control)mainform_header).set_Text("Pro Leads");
	}

	private void backupClosetToolStripMenuItem_Click(object sender, EventArgs e)
	{
		delete_extracontrols((Control)(object)pro_closet_backup_class);
		((Control)mainform_header).set_Text("Closet backup");
	}

	private void editAndListENLToolStripMenuItem_Click(object sender, EventArgs e)
	{
		delete_extracontrols((Control)(object)pro_enl_class);
		((Control)mainform_header).set_Text("ENL");
	}

	private void poshmarkInfluencerToolStripMenuItem_Click(object sender, EventArgs e)
	{
		delete_extracontrols((Control)(object)pro_influencer_class);
		((Control)mainform_header).set_Text("Poshmark Influencer");
	}

	private void poshmarkSchedulerToolStripMenuItem_Click(object sender, EventArgs e)
	{
		delete_extracontrols((Control)(object)pro_share_follow_schedules_class);
		((Control)mainform_header).set_Text("Share/Follow Schedule");
		pro_share_follow_schedules_class.schedule_load_button1_Click(null, null);
	}

	private void configurationToolStripMenuItem_Click(object sender, EventArgs e)
	{
		delete_extracontrols((Control)(object)pro_configuration_class);
		((Control)mainform_header).set_Text("Configuration");
	}

	private void Start_button1_Click(object sender, EventArgs e)
	{
		try
		{
			clear_all_before_start();
			string text = ((Control)mainform_header).get_Text();
			((Control)lastTab_metroLabel2).set_Text("Last Running Tab: " + text);
			switch (text)
			{
			case "Poshmark Pro Tools":
				if (protoll_registration.Contains("Expire") || protoll_registration == "")
				{
					((Control)status_textBox1).set_Text("You are not Allowed to use Poshmark Pro Tools, Purchase Pro Tools License\r\n");
					return;
				}
				break;
			case "Pro Leads":
				if (proLeed_registration.Contains("Expire") || proLeed_registration == "")
				{
					((Control)status_textBox1).set_Text("You are not Allowed to use Poshmark Pro Leads, Purchase Pro Leads License\r\n");
					return;
				}
				break;
			case "InstaPosh":
				if (InstaPosh_registration.Contains("Expire") || InstaPosh_registration == "")
				{
					((Control)status_textBox1).set_Text("You are not Allowed to use InstaPosh, purchase Instaposh License\r\n");
					return;
				}
				break;
			case "Share/Follow Schedule":
				if (schedule_rows == "0")
				{
					((Control)status_textBox1).set_Text("You are not Allowed to use Schedules, buy Schedule License\r\n");
					return;
				}
				break;
			case "Closet backup":
				if (!InstaPosh_registration.Contains("Registered") && !proLeed_registration.Contains("permitted") && !protoll_registration.Contains("permitted"))
				{
					((Control)status_textBox1).set_Text("Register in Poshmark Pro Tools, Poshmark Pro Leads or Instaposh to use this service\r\n");
					return;
				}
				break;
			case "ENL":
				if (Enl_permission.Contains("Expire"))
				{
					((Control)status_textBox1).set_Text("You are not Allowed to use ENL, buy ENL License\r\n");
					return;
				}
				break;
			case "PinPosh":
				if (pinterest_registration.Contains("Expire") || pinterest_registration == "")
				{
					((Control)status_textBox1).set_Text("You are not Allowed to use Poshmark Pinterest\r\n");
					return;
				}
				break;
			case "Generate Report":
				if (report_registration == "Not permitted")
				{
					((Control)status_textBox1).set_Text("You are not Allowed to use Report, purchase license and get detailed report about your closet\r\n");
					return;
				}
				break;
			case "Bulk Price Edit":
				if (!bulk_edit_permission.Contains("Not permitted"))
				{
					break;
				}
				if (File.Exists(bulk_permission_hidden_path))
				{
					try
					{
						string input = File.ReadAllText(bulk_permission_hidden_path);
						string[] array = Regex.Split(input, "--");
						DateTime dateTime = DateTime.ParseExact(array[0], "dd-MM-yyyy", CultureInfo.InvariantCulture);
						string text2 = "0";
						if (today_date_microsolft.Date > dateTime.Date)
						{
							File.WriteAllText(bulk_permission_hidden_path, today_date_microsolft.ToString("dd-MM-yyyy") + "--" + text2.ToString());
						}
						else
						{
							if (!(today_date_microsolft.Date == dateTime.Date))
							{
								return;
							}
							text2 = array[1];
						}
						if (int.Parse(text2) > 10)
						{
							((TextBoxBase)status_textBox1).AppendText("Your Free Bulk Edit daily Limit Reached, Buy license for further use or wait for 1 day\r\n");
							return;
						}
						((Control)status_textBox1).set_Text("Free bulk edit left for today " + (10 - int.Parse(text2)) + "\r\n");
					}
					catch
					{
						((Control)status_textBox1).set_Text("(1) You are not Allowed to use bulk edit, your limit is reached for today, buy bulk edit License\r\n");
						return;
					}
				}
				else
				{
					File.WriteAllText(bulk_permission_hidden_path, today_date_microsolft.ToString("dd-MM-yyyy") + "--" + 0);
				}
				break;
			}
			t = new Thread(startworker_);
			t.Start();
			t.IsBackground = true;
		}
		catch (Exception ex)
		{
			if (!Directory.Exists("logs"))
			{
				Directory.CreateDirectory("logs");
			}
			File.AppendAllText("logs//logs.jk", "107) " + ex.ToString() + "\r\n");
		}
	}

	public void Stop_button1_Click(object sender, EventArgs e)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		((Control)status_textBox1).Invoke((Delegate)(MethodInvoker)delegate
		{
			((TextBoxBase)status_textBox1).AppendText("App Stopped at" + DateTime.Now.ToString() + "\r\n");
		});
		((Control)Start_button1).Invoke((Delegate)(MethodInvoker)delegate
		{
			((Control)Start_button1).set_Enabled(true);
		});
		try
		{
			t.Abort();
		}
		catch
		{
		}
	}

	private void Pause_button2_Click(object sender, EventArgs e)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		((Control)status_textBox1).Invoke((Delegate)(MethodInvoker)delegate
		{
			((TextBoxBase)status_textBox1).AppendText("App Paused at" + DateTime.Now.ToString() + "\r\n");
		});
		try
		{
			t.Suspend();
		}
		catch
		{
		}
	}

	private void Continue_button3_Click(object sender, EventArgs e)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		((Control)status_textBox1).Invoke((Delegate)(MethodInvoker)delegate
		{
			((TextBoxBase)status_textBox1).AppendText("App Continue at" + DateTime.Now.ToString() + "\r\n");
		});
		try
		{
			t.Resume();
		}
		catch
		{
		}
	}

	public void clear_all_before_start()
	{
		((Control)status_textBox1).set_Text("");
		((Control)Log_textBox1).set_Text("");
		try
		{
			t.Abort();
		}
		catch
		{
		}
	}

	private void startworker_()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Expected O, but got Unknown
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Expected O, but got Unknown
		try
		{
			if (!validate_input_data())
			{
				return;
			}
			((Control)Start_button1).Invoke((Delegate)(MethodInvoker)delegate
			{
				((Control)Start_button1).set_Enabled(false);
			});
			if (cookie_Set())
			{
				string text = ((Control)mainform_header).get_Text();
				try
				{
					switch (text)
					{
					case "Poshmark Pro Tools":
						pro_tools_class.start_poshmark_pro_tools();
						break;
					case "Pro Leads":
						pro_leads_class.start_poshmark_pro_leads();
						break;
					case "Poshmark Influencer":
						pro_influencer_class.start_poshmark__influencer();
						break;
					case "Share/Follow Schedule":
						pro_share_follow_schedules_class.start_poshmark__scheduler();
						break;
					case "ENL":
					{
						edit_listing edit_listing3 = new edit_listing();
						int delay2 = 60;
						try
						{
							delay2 = ed.delay_value_getter(((Control)pro_enl_class.delay_enl_textBox2).get_Text());
						}
						catch
						{
						}
						edit_listing3.edit_listing_main("", this, delay2);
						break;
					}
					case "Closet backup":
						pro_closet_backup_class.start_poshmark__uploader();
						break;
					case "Generate Report":
						pro_report_class.generate_report(0);
						break;
					case "Bulk Price Edit":
					{
						edit_listing edit_listing2 = new edit_listing();
						int delay = 60;
						try
						{
							delay = ed.delay_value_getter(((Control)pro_enl_class.delay_enl_textBox2).get_Text());
						}
						catch
						{
						}
						edit_listing2.edit_listing_main_price_Edit("", this, delay);
						break;
					}
					case "InstaPosh":
						break;
					case "PinPosh":
						break;
					case "Listing Upload from Excel":
						break;
					}
				}
				catch (Exception)
				{
				}
			}
			((Control)Start_button1).Invoke((Delegate)(MethodInvoker)delegate
			{
				((Control)Start_button1).set_Enabled(true);
			});
		}
		catch (Exception ex2)
		{
			if (!Directory.Exists("logs"))
			{
				Directory.CreateDirectory("logs");
			}
			File.AppendAllText("logs//logs.jk", "str) " + ex2.ToString() + "\r\n");
			((Control)Start_button1).Invoke((Delegate)(MethodInvoker)delegate
			{
				((Control)Start_button1).set_Enabled(true);
			});
		}
	}

	public bool validate_input_data()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected O, but got Unknown
		try
		{
			switch (((Control)mainform_header).get_Text())
			{
			case "Poshmark Pro Tools":
			{
				_ = (string)((Control)this).Invoke((Delegate)(Func<string>)(() => ((Control)pro_tools_class.metroTabControl1).get_Text()));
				string poshmark_protool_tab = (string)((Control)this).Invoke((Delegate)(Func<string>)(() => ((Control)((TabControl)pro_tools_class.metroTabControl1).get_SelectedTab()).get_Text()));
				if (pro_tools_class.check_required_things(poshmark_protool_tab))
				{
					((Control)status_textBox1).Invoke((Delegate)(MethodInvoker)delegate
					{
						((Control)status_textBox1).set_Text("Validation Done\r\n");
					});
					goto case "Share/Follow Schedule";
				}
				return false;
			}
			case "Pro Leads":
				if (!pro_leads_class.check_required_things())
				{
					return false;
				}
				goto case "Share/Follow Schedule";
			case "Poshmark Influencer":
				if (!pro_influencer_class.check_required_things())
				{
					return false;
				}
				goto case "Share/Follow Schedule";
			case "Share/Follow Schedule":
			case "Closet backup":
			case "ENL":
			case "PinPosh":
			case "Generate Report":
			case "Bulk Price Edit":
			case "Listing Upload from Excel":
				return true;
			default:
				((Control)status_textBox1).Invoke((Delegate)(MethodInvoker)delegate
				{
					((Control)status_textBox1).set_Text("Select a Valid App Tab to start\r\nPro Tools\r\nPro Leads\r\nInstaPosh\r\nScheduler\r\nInfluencer");
				});
				return false;
			}
		}
		catch (Exception ex)
		{
			if (!Directory.Exists("logs"))
			{
				Directory.CreateDirectory("logs");
			}
			File.AppendAllText("logs//logs.jk", "vld) " + ex.ToString() + "\r\n");
			return false;
		}
	}

	public static bool cookie_Set()
	{
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected O, but got Unknown
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Expected O, but got Unknown
		try
		{
			if (((CheckBox)pro_configuration_class.browser_checkBox1).get_Checked())
			{
				try
				{
					CookieCollection cookies = eob.get_WebView().get_Engine().get_CookieManager()
						.GetCookies((string)null, true);
					string text = ((object)cookies).ToString();
					if (((CheckBox)pro_configuration_class.save_login_metroCheckBox1).get_Checked())
					{
						File.WriteAllText(cookie_save_path, text);
					}
					ck = new CookieContainer();
					ck.PerDomainCapacity = 300;
					string[] array = Regex.Split(text, "\r\n");
					string[] array2 = array;
					foreach (string text2 in array2)
					{
						if (!(text2 == ""))
						{
							string[] array3 = Regex.Split(text2, ";");
							string[] array4 = Regex.Split(array3[0], "=");
							Cookie cookie = new Cookie();
							cookie.Name = array4[0];
							cookie.Value = array4[1];
							cookie.Domain = "poshmark.com";
							if (((CheckBox)pro_configuration_class.canadian_closet_metroCheckBox1).get_Checked())
							{
								cookie.Domain = "poshmark.ca";
							}
							ck.Add(cookie);
						}
					}
				}
				catch
				{
				}
			}
			else
			{
				string cookie2 = lg.GetCookie("https://poshmark.com/feed");
				if (((CheckBox)pro_configuration_class.canadian_closet_metroCheckBox1).get_Checked())
				{
					cookie2 = lg.GetCookie("https://poshmark.ca/feed");
				}
				ck = new CookieContainer();
				ck.PerDomainCapacity = 300;
				string[] array5 = Regex.Split(cookie2, "; ");
				string[] array6 = array5;
				foreach (string input in array6)
				{
					string[] array7 = Regex.Split(input, "=");
					Cookie cookie3 = new Cookie();
					cookie3.Name = array7[0];
					cookie3.Value = array7[1];
					cookie3.Domain = "poshmark.com";
					if (((CheckBox)pro_configuration_class.canadian_closet_metroCheckBox1).get_Checked())
					{
						cookie3.Domain = "poshmark.ca";
					}
					ck.Add(cookie3);
				}
			}
			string loginedperson = lg.check_who_is_logined(ck);
			if (loginedperson != null)
			{
				ed = new extract_data(lg);
				try
				{
					string email = lg.get_user_email(ck);
					upload_email(email);
				}
				catch
				{
				}
				MethodInvoker val = (MethodInvoker)delegate
				{
					((TextBoxBase)mainform.status_textBox1).AppendText("Successfully Login: " + loginedperson + "\r\n");
				};
				((Control)mainform).Invoke((Delegate)(object)val);
				return true;
			}
			object obj3 = _003C_003Ec._003C_003E9__92_1;
			if (obj3 == null)
			{
				MethodInvoker val2 = delegate
				{
					((TextBoxBase)mainform.status_textBox1).AppendText("You are not Login to Poshmark\r\n");
				};
				obj3 = (object)val2;
				_003C_003Ec._003C_003E9__92_1 = val2;
			}
			MethodInvoker val3 = (MethodInvoker)obj3;
			((Control)mainform).Invoke((Delegate)(object)val3);
			return false;
		}
		catch (Exception ex)
		{
			if (!Directory.Exists("logs"))
			{
				Directory.CreateDirectory("logs");
			}
			File.AppendAllText("logs//logs.jk", "cke) " + ex.ToString() + "\r\n");
			return false;
		}
	}

	public static void upload_email(string email)
	{
		try
		{
			if (email == null || !(email != "") || found_email.Contains(email))
			{
				return;
			}
			found_email += email;
			DataTable dataTable = Register.run_querry("Select * from license_details WHERE password LIKE '" + ((Control)register_control.license_key_TextBox1).get_Text().TrimStart(new char[0]).TrimEnd(new char[0]) + "'");
			if (dataTable.Rows.Count > 0)
			{
				string text = dataTable.Rows[0]["emails"].ToString();
				if (!text.Contains(email))
				{
					text = text + "--" + email;
					Register.run_querry("UPDATE license_details SET emails = '" + text + "' WHERE password LIKE '" + ((Control)register_control.license_key_TextBox1).get_Text().TrimStart(new char[0]).TrimEnd(new char[0]) + "'");
				}
				return;
			}
			dataTable = Register.run_querry("Select * from wpec_edd_subscriptions WHERE password LIKE '" + ((Control)register_control.license_key_TextBox1).get_Text().TrimStart(new char[0]).TrimEnd(new char[0]) + "'");
			if (dataTable.Rows.Count > 0)
			{
				string text2 = dataTable.Rows[0]["emails"].ToString();
				if (!text2.Contains(email))
				{
					text2 = text2 + "--" + email;
					Register.run_querry("UPDATE wpec_edd_subscriptions SET emails = '" + text2 + "' WHERE password LIKE '" + ((Control)register_control.license_key_TextBox1).get_Text().TrimStart(new char[0]).TrimEnd(new char[0]) + "'");
				}
			}
		}
		catch
		{
		}
	}

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		try
		{
			thread2.Abort();
		}
		catch
		{
		}
		try
		{
			t_browser.Abort();
		}
		catch
		{
		}
		try
		{
			t.Abort();
		}
		catch
		{
		}
		try
		{
			infinite_thread.Abort();
		}
		catch
		{
		}
		try
		{
			restart_thread.Abort();
		}
		catch
		{
		}
		try
		{
			Process[] processesByName = Process.GetProcessesByName("geckodriver");
			foreach (Process process in processesByName)
			{
				process.Kill();
			}
		}
		catch
		{
		}
		try
		{
			Process[] processesByName2 = Process.GetProcessesByName("chromedriver");
			foreach (Process process2 in processesByName2)
			{
				process2.Kill();
			}
		}
		catch
		{
		}
		try
		{
			loading_form.thread1.Abort();
		}
		catch
		{
		}
	}

	private void chatToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Process[] processes = Process.GetProcesses();
			int num = 0;
			while (true)
			{
				if (num < processes.Length)
				{
					Process process = processes[num];
					if (process.ProcessName == "PoshmarkC")
					{
						break;
					}
					num++;
					continue;
				}
				if (poshmark_username != "")
				{
					if (!File.Exists(update_app.folder_path + "//PoshmarkC.exe"))
					{
						using WebClient webClient = new WebClient();
						webClient.DownloadFile(new Uri("http://poshmarktools.com/support/mpt/DownloadableFiles/PoshmarkC.exe"), update_app.folder_path + "//PoshmarkC.exe");
					}
					Process.Start(update_app.folder_path + "//PoshmarkC.exe", "ProTOolsApps " + poshmark_username + " 5.189.166.171");
				}
				else
				{
					MessageBox.Show("Register to use Chat");
				}
				return;
			}
			MessageBox.Show("Already chat box is opened, close previous and then try again");
		}
		catch (Exception ex)
		{
			if (!Directory.Exists("logs"))
			{
				Directory.CreateDirectory("logs");
			}
			File.AppendAllText("logs//logs.jk", "chtbx) " + ex.ToString() + "\r\n");
		}
	}

	private void messageUsToolStripMenuItem_Click(object sender, EventArgs e)
	{
		Process.Start("https://poshmarktools.com/app-contact-us-button/");
	}

	private bool Request_poshmarktools_com(out HttpWebResponse response, string url)
	{
		response = null;
		try
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
			httpWebRequest.KeepAlive = true;
			httpWebRequest.Headers.Set(HttpRequestHeader.CacheControl, "max-age=0");
			httpWebRequest.Headers.Add("Upgrade-Insecure-Requests", "1");
			httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/65.0.3325.181 Safari/537.36";
			httpWebRequest.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8";
			httpWebRequest.Referer = "http://poshmarktools.com/support/mpt/";
			httpWebRequest.Headers.Set(HttpRequestHeader.AcceptEncoding, "gzip, deflate");
			httpWebRequest.Headers.Set(HttpRequestHeader.AcceptLanguage, "en-US,en;q=0.9");
			response = (HttpWebResponse)httpWebRequest.GetResponse();
		}
		catch (WebException ex)
		{
			if (ex.Status != WebExceptionStatus.ProtocolError)
			{
				return false;
			}
			response = (HttpWebResponse)ex.Response;
		}
		catch (Exception)
		{
			if (response != null)
			{
				response.Close();
			}
			return false;
		}
		return true;
	}

	private string ReadResponse(HttpWebResponse response)
	{
		using Stream stream = response.GetResponseStream();
		Stream stream2 = stream;
		if (response.ContentEncoding.ToLower().Contains("gzip"))
		{
			stream2 = new GZipStream(stream2, CompressionMode.Decompress);
		}
		else if (response.ContentEncoding.ToLower().Contains("deflate"))
		{
			stream2 = new DeflateStream(stream2, CompressionMode.Decompress);
		}
		using StreamReader streamReader = new StreamReader(stream2, Encoding.UTF8);
		return streamReader.ReadToEnd();
	}

	private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
	{
		delete_extracontrols((Control)(object)about_us_class);
		((Control)mainform_header).set_Text("About Us");
	}

	private void generateReportToolStripMenuItem_Click(object sender, EventArgs e)
	{
		delete_extracontrols((Control)(object)pro_report_class);
		((Control)mainform_header).set_Text("Generate Report");
	}

	private void proToolsManualToolStripMenuItem_Click(object sender, EventArgs e)
	{
		Process.Start("http://poshmarktools.com/support/mpt/Poshmark Tools Manual.pdf");
	}

	private void bulkPriceEditToolStripMenuItem_Click(object sender, EventArgs e)
	{
		delete_extracontrols((Control)(object)pro_bulk_editor);
		((Control)mainform_header).set_Text("Bulk Price Edit");
	}

	private void update_in_app_button1_Click(object sender, EventArgs e)
	{
		update_app update_app2 = new update_app();
		update_app2.MakeRequests(this, "false");
	}

	private void listingsUplodFromExcelToolStripMenuItem_Click(object sender, EventArgs e)
	{
	}

	public void browserToolStripMenuItem_Click(object sender, EventArgs e)
	{
		delete_extracontrols((Control)(object)pro_browser);
		((Control)mainform_header).set_Text("Browser Window");
	}

	private void newsToolStripMenuItem_Click(object sender, EventArgs e)
	{
		delete_extracontrols((Control)(object)news_class);
		((Control)mainform_header).set_Text("News Window");
	}

	private void version_label_Click(object sender, EventArgs e)
	{
		registerToolStripMenuItem_Click(null, null);
	}

	private void update_menu_button_Click(object sender, EventArgs e)
	{
		update_app update_app2 = new update_app();
		update_app2.MakeRequests(this, "false");
	}

	public static void sleep_stats_function(int delay, string misc)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		try
		{
			string status_textbox_text = ((Control)mainform.status_textBox1).get_Text();
			while (delay > 0)
			{
				((Control)mainform.status_textBox1).Invoke((Delegate)(MethodInvoker)delegate
				{
					((Control)mainform.status_textBox1).set_Text(status_textbox_text + delay + " " + DateTime.Now.ToString() + "\r\n");
				});
				Thread.Sleep(1000);
				delay--;
			}
		}
		catch
		{
		}
	}

	public static void update_backup_data(string control_name, string key)
	{
		try
		{
			List<string> list = File.ReadAllLines(update_app.folder_path + "\\msi.msp").ToList();
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			foreach (string item in list)
			{
				if (item != "")
				{
					string[] array = Regex.Split(item, "----");
					dictionary.Add(array[0], array[1]);
				}
			}
			if (dictionary.ContainsKey(control_name))
			{
				dictionary[control_name] = key;
			}
			else
			{
				dictionary.Add(control_name, key);
			}
			File.WriteAllText(update_app.folder_path + "\\msi.msp", "");
			foreach (KeyValuePair<string, string> item2 in dictionary)
			{
				File.AppendAllText(update_app.folder_path + "\\msi.msp", item2.Key + "----" + item2.Value + "\r\n");
			}
		}
		catch
		{
		}
	}

	public static void read_backup_data()
	{
		try
		{
			if (!File.Exists(update_app.folder_path + "\\msi.msp"))
			{
				File.WriteAllText(update_app.folder_path + "\\msi.msp", "");
			}
			List<string> list = File.ReadAllLines(update_app.folder_path + "\\msi.msp").ToList();
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			foreach (string item in list)
			{
				if (item != "")
				{
					string[] array = Regex.Split(item, "----");
					dictionary.Add(array[0], array[1]);
				}
			}
			foreach (KeyValuePair<string, string> item2 in dictionary)
			{
				try
				{
					string[] array2 = Regex.Split(item2.Key, "______;");
					string text = array2[0];
					string text2 = array2[1];
					string value = item2.Value;
					if (item2.Value == "T" || item2.Value == "F")
					{
						if (text == "Pro_tools")
						{
							if (!(text2 == "share_my_feed_checkBox1"))
							{
							}
						}
						else
						{
							if (!(text == "Pro_configurations"))
							{
								continue;
							}
							if (text2 == "fetch_all_listings_metroCheckBox1")
							{
								if (item2.Value == "T")
								{
									((CheckBox)pro_configuration_class.fetch_all_listings_metroCheckBox1).set_Checked(true);
								}
								else
								{
									((CheckBox)pro_configuration_class.fetch_all_listings_metroCheckBox1).set_Checked(false);
								}
							}
							else if (text2 == "save_login_metroCheckBox1")
							{
								if (item2.Value == "T")
								{
									((CheckBox)pro_configuration_class.save_login_metroCheckBox1).set_Checked(true);
								}
								else
								{
									((CheckBox)pro_configuration_class.save_login_metroCheckBox1).set_Checked(false);
								}
							}
							continue;
						}
					}
					else if (text == "Pro_tools")
					{
						switch (text2)
						{
						case "shareloop_TextBox5":
							((Control)pro_tools_class.shareloop_TextBox5).set_Text(value);
							break;
						case "share_item_textBox6":
							((Control)pro_tools_class.share_item_textBox6).set_Text(value);
							break;
						case "delayLoop_textBox8":
							((Control)pro_tools_class.delayLoop_textBox8).set_Text(value);
							break;
						case "delay_share_textBox7":
							((Control)pro_tools_class.delay_share_textBox7).set_Text(value);
							break;
						case "share_listings_with_keywords_textBox5":
							((Control)pro_tools_class.share_listings_with_keywords_textBox5).set_Text(value);
							break;
						}
					}
					else if (text == "Pro_leads")
					{
						switch (text2)
						{
						case "keyword_pro_leads_textBox6":
							((Control)pro_leads_class.keyword_pro_leads_textBox6).set_Text(value);
							break;
						case "delay_pro_leads_textBox5":
							((Control)pro_leads_class.delay_pro_leads_textBox5).set_Text(value);
							break;
						case "quantity_pro_leads_textBox1":
							((Control)pro_leads_class.quantity_pro_leads_textBox1).set_Text(value);
							break;
						}
					}
				}
				catch
				{
				}
			}
		}
		catch
		{
		}
	}

	private void WebView_LoadCompleted(object sender, LoadCompletedEventArgs e)
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected O, but got Unknown
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected O, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		string url = e.get_Url();
		if (!url.Contains("?logout=true"))
		{
			return;
		}
		try
		{
			eob.get_WebView().get_Engine().Stop(true);
			try
			{
				Thread.Sleep(1000);
				eob.set_WebView(new WebView());
				eob.get_WebView().set_ZoomFactor(0.75);
				eob.get_WebView().get_Engine().get_Options()
					.set_CachePath(update_app.folder_path + "\\eoo");
				eob.get_WebView().set_Url("https://www.poshmark.com/feed?logout=true");
			}
			catch (Exception)
			{
			}
			eob.get_WebView().add_NewWindow(new NewWindowHandler(webView1_NewWindow));
			eob.get_WebView().add_LoadCompleted(new LoadCompletedEventHandler(WebView_LoadCompleted));
			eob.get_WebView().add_LaunchUrl(new LaunchUrlHandler(WebView_LaunchUrl));
			eob.get_WebView().add_UrlChanged((EventHandler)WebView_UrlChanged);
		}
		catch (Exception)
		{
		}
	}

	private void WebView_LaunchUrl(object sender, LaunchUrlEventArgs e)
	{
		e.get_Url();
	}

	private void WebView_UrlChanged(object sender, EventArgs e)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected O, but got Unknown
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		try
		{
			WebView val = (WebView)((sender is WebView) ? sender : null);
			string url = val.get_Url();
			if (url.Contains("fallback_redirect_uri=https%3A%2F%2Fposhmark.com"))
			{
				try
				{
					Thread.Sleep(1000);
					eob.set_WebView(new WebView());
					eob.get_WebView().set_ZoomFactor(0.75);
					eob.get_WebView().get_Engine().get_Options()
						.set_CachePath(update_app.folder_path + "\\eoo");
					eob.get_WebView().set_Url("https://www.poshmark.com/feed?login=true");
				}
				catch (Exception)
				{
				}
				eob.get_WebView().add_NewWindow(new NewWindowHandler(webView1_NewWindow));
				eob.get_WebView().add_LoadCompleted(new LoadCompletedEventHandler(WebView_LoadCompleted));
				eob.get_WebView().add_LaunchUrl(new LaunchUrlHandler(WebView_LaunchUrl));
				eob.get_WebView().add_UrlChanged((EventHandler)WebView_UrlChanged);
			}
		}
		catch
		{
		}
	}

	private static void webView1_NewWindow(object sender, NewWindowEventArgs e)
	{
		pepsi = e.get_TargetUrl();
		Thread.Sleep(500);
		Thread thread = new Thread(get_updated_cookie);
		thread.Start();
	}

	public static void get_updated_cookie()
	{
		eob.get_WebView().set_Url(pepsi);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected O, but got Unknown
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected O, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected O, but got Unknown
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected O, but got Unknown
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected O, but got Unknown
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected O, but got Unknown
		//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Expected O, but got Unknown
		//IL_038c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b59: Expected O, but got Unknown
		//IL_0c23: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c2d: Expected O, but got Unknown
		//IL_0d15: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f52: Unknown result type (might be due to invalid IL or missing references)
		//IL_101e: Unknown result type (might be due to invalid IL or missing references)
		//IL_10c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1152: Unknown result type (might be due to invalid IL or missing references)
		//IL_121f: Unknown result type (might be due to invalid IL or missing references)
		//IL_12a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_132f: Unknown result type (might be due to invalid IL or missing references)
		//IL_13b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_143d: Unknown result type (might be due to invalid IL or missing references)
		//IL_14ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_155b: Unknown result type (might be due to invalid IL or missing references)
		//IL_165a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1719: Unknown result type (might be due to invalid IL or missing references)
		//IL_17cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_185d: Unknown result type (might be due to invalid IL or missing references)
		//IL_190a: Unknown result type (might be due to invalid IL or missing references)
		//IL_19fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a46: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a50: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		menuStrip1 = new MenuStrip();
		homeToolStripMenuItem1 = new ToolStripMenuItem();
		registerToolStripMenuItem = new ToolStripMenuItem();
		featuresToolStripMenuItem = new ToolStripMenuItem();
		poshmarkProToolsToolStripMenuItem = new ToolStripMenuItem();
		poshmarkProLeadsToolStripMenuItem = new ToolStripMenuItem();
		instaPoshToolStripMenuItem = new ToolStripMenuItem();
		backupClosetToolStripMenuItem = new ToolStripMenuItem();
		editAndListENLToolStripMenuItem = new ToolStripMenuItem();
		poshmarkInfluencerToolStripMenuItem = new ToolStripMenuItem();
		poshmarkSchedulerToolStripMenuItem = new ToolStripMenuItem();
		pinPoshToolStripMenuItem = new ToolStripMenuItem();
		bulkPriceEditToolStripMenuItem = new ToolStripMenuItem();
		listingsUplodFromExcelToolStripMenuItem = new ToolStripMenuItem();
		settingsToolStripMenuItem = new ToolStripMenuItem();
		configurationToolStripMenuItem = new ToolStripMenuItem();
		otherToolStripMenuItem = new ToolStripMenuItem();
		chatToolStripMenuItem = new ToolStripMenuItem();
		messageUsToolStripMenuItem = new ToolStripMenuItem();
		aboutUsToolStripMenuItem = new ToolStripMenuItem();
		reportToolStripMenuItem = new ToolStripMenuItem();
		generateReportToolStripMenuItem = new ToolStripMenuItem();
		proToolsManualToolStripMenuItem = new ToolStripMenuItem();
		browserToolStripMenuItem = new ToolStripMenuItem();
		newsToolStripMenuItem = new ToolStripMenuItem();
		update_menu_button = new ToolStripMenuItem();
		metroPanel1 = new MetroPanel();
		splitContainer1 = new SplitContainer();
		splitContainer2 = new SplitContainer();
		metroLabel1 = new MetroLabel();
		pictureBox1 = new PictureBox();
		Log_textBox1 = new TextBox();
		lastTab_metroLabel2 = new MetroLabel();
		Continue_button3 = new MetroButton();
		Pause_button2 = new MetroButton();
		Stop_button1 = new MetroButton();
		Start_button1 = new MetroButton();
		status_textBox1 = new TextBox();
		splitContainer3 = new SplitContainer();
		coupon_metroLabel2 = new MetroLabel();
		version_label = new MetroLabel();
		instance_count = new MetroLabel();
		splitter1 = new Splitter();
		mainform_header = new MetroLabel();
		((Control)menuStrip1).SuspendLayout();
		((Control)metroPanel1).SuspendLayout();
		((ISupportInitialize)splitContainer1).BeginInit();
		((Control)splitContainer1.get_Panel1()).SuspendLayout();
		((Control)splitContainer1.get_Panel2()).SuspendLayout();
		((Control)splitContainer1).SuspendLayout();
		((ISupportInitialize)splitContainer2).BeginInit();
		((Control)splitContainer2.get_Panel1()).SuspendLayout();
		((Control)splitContainer2.get_Panel2()).SuspendLayout();
		((Control)splitContainer2).SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		((ISupportInitialize)splitContainer3).BeginInit();
		((Control)splitContainer3.get_Panel1()).SuspendLayout();
		((Control)splitContainer3.get_Panel2()).SuspendLayout();
		((Control)splitContainer3).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)menuStrip1).set_Font(new Font("Segoe UI", 10f));
		((ToolStrip)menuStrip1).set_ImageScalingSize(new Size(24, 24));
		((ToolStrip)menuStrip1).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[10]
		{
			(ToolStripItem)homeToolStripMenuItem1,
			(ToolStripItem)featuresToolStripMenuItem,
			(ToolStripItem)settingsToolStripMenuItem,
			(ToolStripItem)otherToolStripMenuItem,
			(ToolStripItem)aboutUsToolStripMenuItem,
			(ToolStripItem)reportToolStripMenuItem,
			(ToolStripItem)proToolsManualToolStripMenuItem,
			(ToolStripItem)browserToolStripMenuItem,
			(ToolStripItem)newsToolStripMenuItem,
			(ToolStripItem)update_menu_button
		});
		((Control)menuStrip1).set_Location(new Point(30, 92));
		((Control)menuStrip1).set_Name("menuStrip1");
		((Control)menuStrip1).set_Padding(new Padding(9, 3, 0, 3));
		((Control)menuStrip1).set_Size(new Size(1167, 38));
		((Control)menuStrip1).set_TabIndex(0);
		((Control)menuStrip1).set_Text("menuStrip1");
		((ToolStripItem)homeToolStripMenuItem1).set_BackColor(Color.FromArgb(255, 224, 192));
		((ToolStripDropDownItem)homeToolStripMenuItem1).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)registerToolStripMenuItem });
		((ToolStripItem)homeToolStripMenuItem1).set_Name("homeToolStripMenuItem1");
		((ToolStripItem)homeToolStripMenuItem1).set_Size(new Size(180, 32));
		((ToolStripItem)homeToolStripMenuItem1).set_Text("License Activation");
		((ToolStripItem)registerToolStripMenuItem).set_Name("registerToolStripMenuItem");
		((ToolStripItem)registerToolStripMenuItem).set_Size(new Size(167, 32));
		((ToolStripItem)registerToolStripMenuItem).set_Text("Activate");
		((ToolStripItem)registerToolStripMenuItem).add_Click((EventHandler)registerToolStripMenuItem_Click);
		((ToolStripDropDownItem)featuresToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[10]
		{
			(ToolStripItem)poshmarkProToolsToolStripMenuItem,
			(ToolStripItem)poshmarkProLeadsToolStripMenuItem,
			(ToolStripItem)instaPoshToolStripMenuItem,
			(ToolStripItem)backupClosetToolStripMenuItem,
			(ToolStripItem)editAndListENLToolStripMenuItem,
			(ToolStripItem)poshmarkInfluencerToolStripMenuItem,
			(ToolStripItem)poshmarkSchedulerToolStripMenuItem,
			(ToolStripItem)pinPoshToolStripMenuItem,
			(ToolStripItem)bulkPriceEditToolStripMenuItem,
			(ToolStripItem)listingsUplodFromExcelToolStripMenuItem
		});
		((ToolStripItem)featuresToolStripMenuItem).set_Name("featuresToolStripMenuItem");
		((ToolStripItem)featuresToolStripMenuItem).set_Size(new Size(97, 32));
		((ToolStripItem)featuresToolStripMenuItem).set_Text("Features");
		((ToolStripItem)poshmarkProToolsToolStripMenuItem).set_Name("poshmarkProToolsToolStripMenuItem");
		((ToolStripItem)poshmarkProToolsToolStripMenuItem).set_Size(new Size(327, 32));
		((ToolStripItem)poshmarkProToolsToolStripMenuItem).set_Text("Poshmark Pro Tools");
		((ToolStripItem)poshmarkProToolsToolStripMenuItem).add_Click((EventHandler)poshmarkProToolsToolStripMenuItem_Click);
		((ToolStripItem)poshmarkProLeadsToolStripMenuItem).set_Name("poshmarkProLeadsToolStripMenuItem");
		((ToolStripItem)poshmarkProLeadsToolStripMenuItem).set_Size(new Size(327, 32));
		((ToolStripItem)poshmarkProLeadsToolStripMenuItem).set_Text("Poshmark Pro Leads");
		((ToolStripItem)poshmarkProLeadsToolStripMenuItem).add_Click((EventHandler)poshmarkProLeadsToolStripMenuItem_Click);
		((ToolStripItem)instaPoshToolStripMenuItem).set_Name("instaPoshToolStripMenuItem");
		((ToolStripItem)instaPoshToolStripMenuItem).set_Size(new Size(327, 32));
		((ToolStripItem)instaPoshToolStripMenuItem).set_Text("InstaPosh");
		((ToolStripItem)instaPoshToolStripMenuItem).set_Visible(false);
		((ToolStripItem)backupClosetToolStripMenuItem).set_Name("backupClosetToolStripMenuItem");
		((ToolStripItem)backupClosetToolStripMenuItem).set_Size(new Size(327, 32));
		((ToolStripItem)backupClosetToolStripMenuItem).set_Text("Backup Closet");
		((ToolStripItem)backupClosetToolStripMenuItem).add_Click((EventHandler)backupClosetToolStripMenuItem_Click);
		((ToolStripItem)editAndListENLToolStripMenuItem).set_Name("editAndListENLToolStripMenuItem");
		((ToolStripItem)editAndListENLToolStripMenuItem).set_Size(new Size(327, 32));
		((ToolStripItem)editAndListENLToolStripMenuItem).set_Text("Edit and List (ENL) / Delete");
		((ToolStripItem)editAndListENLToolStripMenuItem).add_Click((EventHandler)editAndListENLToolStripMenuItem_Click);
		((ToolStripItem)poshmarkInfluencerToolStripMenuItem).set_Name("poshmarkInfluencerToolStripMenuItem");
		((ToolStripItem)poshmarkInfluencerToolStripMenuItem).set_Size(new Size(327, 32));
		((ToolStripItem)poshmarkInfluencerToolStripMenuItem).set_Text("Poshmark Influencer");
		((ToolStripItem)poshmarkInfluencerToolStripMenuItem).add_Click((EventHandler)poshmarkInfluencerToolStripMenuItem_Click);
		((ToolStripItem)poshmarkSchedulerToolStripMenuItem).set_Name("poshmarkSchedulerToolStripMenuItem");
		((ToolStripItem)poshmarkSchedulerToolStripMenuItem).set_Size(new Size(327, 32));
		((ToolStripItem)poshmarkSchedulerToolStripMenuItem).set_Text("Poshmark Scheduler");
		((ToolStripItem)poshmarkSchedulerToolStripMenuItem).add_Click((EventHandler)poshmarkSchedulerToolStripMenuItem_Click);
		((ToolStripItem)pinPoshToolStripMenuItem).set_Name("pinPoshToolStripMenuItem");
		((ToolStripItem)pinPoshToolStripMenuItem).set_Size(new Size(327, 32));
		((ToolStripItem)pinPoshToolStripMenuItem).set_Text("PinPosh");
		((ToolStripItem)pinPoshToolStripMenuItem).set_Visible(false);
		((ToolStripItem)bulkPriceEditToolStripMenuItem).set_Name("bulkPriceEditToolStripMenuItem");
		((ToolStripItem)bulkPriceEditToolStripMenuItem).set_Size(new Size(327, 32));
		((ToolStripItem)bulkPriceEditToolStripMenuItem).set_Text("Bulk Price Edit");
		((ToolStripItem)bulkPriceEditToolStripMenuItem).add_Click((EventHandler)bulkPriceEditToolStripMenuItem_Click);
		((ToolStripItem)listingsUplodFromExcelToolStripMenuItem).set_Name("listingsUplodFromExcelToolStripMenuItem");
		((ToolStripItem)listingsUplodFromExcelToolStripMenuItem).set_Size(new Size(327, 32));
		((ToolStripItem)listingsUplodFromExcelToolStripMenuItem).set_Text("Listings Uplod From Excel");
		((ToolStripItem)listingsUplodFromExcelToolStripMenuItem).set_Visible(false);
		((ToolStripItem)listingsUplodFromExcelToolStripMenuItem).add_Click((EventHandler)listingsUplodFromExcelToolStripMenuItem_Click);
		((ToolStripDropDownItem)settingsToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)configurationToolStripMenuItem });
		((ToolStripItem)settingsToolStripMenuItem).set_Name("settingsToolStripMenuItem");
		((ToolStripItem)settingsToolStripMenuItem).set_Size(new Size(95, 32));
		((ToolStripItem)settingsToolStripMenuItem).set_Text("Settings");
		((ToolStripItem)configurationToolStripMenuItem).set_Name("configurationToolStripMenuItem");
		((ToolStripItem)configurationToolStripMenuItem).set_Size(new Size(217, 32));
		((ToolStripItem)configurationToolStripMenuItem).set_Text("Configuration");
		((ToolStripItem)configurationToolStripMenuItem).add_Click((EventHandler)configurationToolStripMenuItem_Click);
		((ToolStripDropDownItem)otherToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)chatToolStripMenuItem,
			(ToolStripItem)messageUsToolStripMenuItem
		});
		((ToolStripItem)otherToolStripMenuItem).set_Name("otherToolStripMenuItem");
		((ToolStripItem)otherToolStripMenuItem).set_Size(new Size(92, 32));
		((ToolStripItem)otherToolStripMenuItem).set_Text("Contact");
		((ToolStripItem)otherToolStripMenuItem).set_Visible(false);
		((ToolStripItem)chatToolStripMenuItem).set_Name("chatToolStripMenuItem");
		((ToolStripItem)chatToolStripMenuItem).set_Size(new Size(199, 32));
		((ToolStripItem)chatToolStripMenuItem).set_Text("Chat");
		((ToolStripItem)chatToolStripMenuItem).set_Visible(false);
		((ToolStripItem)chatToolStripMenuItem).add_Click((EventHandler)chatToolStripMenuItem_Click);
		((ToolStripItem)messageUsToolStripMenuItem).set_Name("messageUsToolStripMenuItem");
		((ToolStripItem)messageUsToolStripMenuItem).set_Size(new Size(199, 32));
		((ToolStripItem)messageUsToolStripMenuItem).set_Text("Message Us");
		((ToolStripItem)messageUsToolStripMenuItem).add_Click((EventHandler)messageUsToolStripMenuItem_Click);
		((ToolStripItem)aboutUsToolStripMenuItem).set_Name("aboutUsToolStripMenuItem");
		((ToolStripItem)aboutUsToolStripMenuItem).set_Size(new Size(106, 32));
		((ToolStripItem)aboutUsToolStripMenuItem).set_Text("About Us");
		((ToolStripItem)aboutUsToolStripMenuItem).add_Click((EventHandler)aboutUsToolStripMenuItem_Click);
		((ToolStripDropDownItem)reportToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)generateReportToolStripMenuItem });
		((ToolStripItem)reportToolStripMenuItem).set_Name("reportToolStripMenuItem");
		((ToolStripItem)reportToolStripMenuItem).set_Size(new Size(83, 32));
		((ToolStripItem)reportToolStripMenuItem).set_Text("Report");
		((ToolStripItem)generateReportToolStripMenuItem).set_Name("generateReportToolStripMenuItem");
		((ToolStripItem)generateReportToolStripMenuItem).set_Size(new Size(239, 32));
		((ToolStripItem)generateReportToolStripMenuItem).set_Text("Generate Report");
		((ToolStripItem)generateReportToolStripMenuItem).add_Click((EventHandler)generateReportToolStripMenuItem_Click);
		((ToolStripItem)proToolsManualToolStripMenuItem).set_Name("proToolsManualToolStripMenuItem");
		((ToolStripItem)proToolsManualToolStripMenuItem).set_Size(new Size(174, 32));
		((ToolStripItem)proToolsManualToolStripMenuItem).set_Text("Pro Tools Manual");
		((ToolStripItem)proToolsManualToolStripMenuItem).add_Click((EventHandler)proToolsManualToolStripMenuItem_Click);
		((ToolStripItem)browserToolStripMenuItem).set_BackColor(Color.FromArgb(255, 192, 128));
		((ToolStripItem)browserToolStripMenuItem).set_Font(new Font("Segoe UI", 10f, (FontStyle)1));
		((ToolStripItem)browserToolStripMenuItem).set_ForeColor(Color.IndianRed);
		((ToolStripItem)browserToolStripMenuItem).set_Name("browserToolStripMenuItem");
		((ToolStripItem)browserToolStripMenuItem).set_Size(new Size(195, 32));
		((ToolStripItem)browserToolStripMenuItem).set_Text("Browser For Login");
		((ToolStripItem)browserToolStripMenuItem).add_Click((EventHandler)browserToolStripMenuItem_Click);
		((ToolStripItem)newsToolStripMenuItem).set_Name("newsToolStripMenuItem");
		((ToolStripItem)newsToolStripMenuItem).set_Size(new Size(71, 32));
		((ToolStripItem)newsToolStripMenuItem).set_Text("News");
		((ToolStripItem)newsToolStripMenuItem).add_Click((EventHandler)newsToolStripMenuItem_Click);
		((ToolStripItem)update_menu_button).set_BackColor(Color.PaleTurquoise);
		((ToolStripItem)update_menu_button).set_Font(new Font("Segoe UI", 10f, (FontStyle)1));
		((ToolStripItem)update_menu_button).set_ForeColor(Color.Maroon);
		((ToolStripItem)update_menu_button).set_Name("update_menu_button");
		((ToolStripItem)update_menu_button).set_Size(new Size(393, 32));
		((ToolStripItem)update_menu_button).set_Text("Update Available (Click to update App)");
		((ToolStripItem)update_menu_button).set_Visible(false);
		((ToolStripItem)update_menu_button).add_Click((EventHandler)update_menu_button_Click);
		((Control)metroPanel1).get_Controls().Add((Control)(object)splitContainer1);
		((Control)metroPanel1).get_Controls().Add((Control)(object)splitContainer3);
		((Control)metroPanel1).set_Dock((DockStyle)5);
		metroPanel1.HorizontalScrollbarBarColor = true;
		metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
		metroPanel1.HorizontalScrollbarSize = 15;
		((Control)metroPanel1).set_Location(new Point(30, 130));
		((Control)metroPanel1).set_Margin(new Padding(4, 5, 4, 5));
		((Control)metroPanel1).set_Name("metroPanel1");
		((Control)metroPanel1).set_Size(new Size(1167, 595));
		((Control)metroPanel1).set_TabIndex(1);
		metroPanel1.VerticalScrollbarBarColor = true;
		metroPanel1.VerticalScrollbarHighlightOnWheel = false;
		metroPanel1.VerticalScrollbarSize = 15;
		splitContainer1.set_Dock((DockStyle)5);
		((Control)splitContainer1).set_Location(new Point(0, 0));
		((Control)splitContainer1).set_Margin(new Padding(4, 5, 4, 5));
		((Control)splitContainer1).set_Name("splitContainer1");
		splitContainer1.set_Orientation((Orientation)0);
		((Control)splitContainer1.get_Panel1()).get_Controls().Add((Control)(object)splitContainer2);
		((Control)splitContainer1.get_Panel2()).get_Controls().Add((Control)(object)lastTab_metroLabel2);
		((Control)splitContainer1.get_Panel2()).get_Controls().Add((Control)(object)Continue_button3);
		((Control)splitContainer1.get_Panel2()).get_Controls().Add((Control)(object)Pause_button2);
		((Control)splitContainer1.get_Panel2()).get_Controls().Add((Control)(object)Stop_button1);
		((Control)splitContainer1.get_Panel2()).get_Controls().Add((Control)(object)Start_button1);
		((Control)splitContainer1.get_Panel2()).get_Controls().Add((Control)(object)status_textBox1);
		((Control)splitContainer1).set_Size(new Size(1167, 570));
		splitContainer1.set_SplitterDistance(250);
		splitContainer1.set_SplitterWidth(6);
		((Control)splitContainer1).set_TabIndex(2);
		splitContainer2.set_Dock((DockStyle)5);
		((Control)splitContainer2).set_Location(new Point(0, 0));
		((Control)splitContainer2).set_Margin(new Padding(4, 5, 4, 5));
		((Control)splitContainer2).set_Name("splitContainer2");
		((Control)splitContainer2.get_Panel1()).get_Controls().Add((Control)(object)metroLabel1);
		((Control)splitContainer2.get_Panel1()).get_Controls().Add((Control)(object)pictureBox1);
		((Control)splitContainer2.get_Panel1()).set_Padding(new Padding(15, 23, 15, 15));
		((Control)splitContainer2.get_Panel2()).get_Controls().Add((Control)(object)Log_textBox1);
		((Control)splitContainer2).set_Size(new Size(1167, 250));
		splitContainer2.set_SplitterDistance(379);
		splitContainer2.set_SplitterWidth(6);
		((Control)splitContainer2).set_TabIndex(0);
		((Control)metroLabel1).set_AutoSize(true);
		((Control)metroLabel1).set_BackColor(Color.Transparent);
		metroLabel1.FontSize = MetroLabelSize.Tall;
		metroLabel1.FontWeight = MetroLabelWeight.Bold;
		((Control)metroLabel1).set_ForeColor(Color.Purple);
		((Control)metroLabel1).set_Location(new Point(382, 49));
		((Control)metroLabel1).set_Margin(new Padding(4, 0, 4, 0));
		((Control)metroLabel1).set_Name("metroLabel1");
		((Control)metroLabel1).set_Size(new Size(433, 325));
		metroLabel1.Style = MetroColorStyle.Brown;
		((Control)metroLabel1).set_TabIndex(0);
		((Control)metroLabel1).set_Text(componentResourceManager.GetString("metroLabel1.Text"));
		((Label)metroLabel1).set_TextAlign((ContentAlignment)2);
		metroLabel1.UseStyleColors = true;
		((Control)pictureBox1).set_Dock((DockStyle)5);
		((Control)pictureBox1).set_Location(new Point(15, 23));
		((Control)pictureBox1).set_Margin(new Padding(4, 5, 4, 5));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(349, 212));
		pictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		pictureBox1.set_TabIndex(1);
		pictureBox1.set_TabStop(false);
		((Control)Log_textBox1).set_BackColor(Color.LightGray);
		((Control)Log_textBox1).set_Dock((DockStyle)5);
		((Control)Log_textBox1).set_Location(new Point(0, 0));
		((Control)Log_textBox1).set_Margin(new Padding(4, 5, 4, 5));
		((TextBoxBase)Log_textBox1).set_Multiline(true);
		((Control)Log_textBox1).set_Name("Log_textBox1");
		((TextBoxBase)Log_textBox1).set_ReadOnly(true);
		Log_textBox1.set_ScrollBars((ScrollBars)3);
		((Control)Log_textBox1).set_Size(new Size(782, 250));
		((Control)Log_textBox1).set_TabIndex(79);
		((Control)lastTab_metroLabel2).set_AutoSize(true);
		((Control)lastTab_metroLabel2).set_BackColor(Color.Transparent);
		((Control)lastTab_metroLabel2).set_Dock((DockStyle)4);
		lastTab_metroLabel2.FontSize = MetroLabelSize.Small;
		((Control)lastTab_metroLabel2).set_ForeColor(Color.Purple);
		((Control)lastTab_metroLabel2).set_Location(new Point(1070, 190));
		((Control)lastTab_metroLabel2).set_Margin(new Padding(4, 0, 4, 0));
		((Control)lastTab_metroLabel2).set_Name("lastTab_metroLabel2");
		((Control)lastTab_metroLabel2).set_Size(new Size(97, 15));
		lastTab_metroLabel2.Style = MetroColorStyle.Brown;
		((Control)lastTab_metroLabel2).set_TabIndex(91);
		((Control)lastTab_metroLabel2).set_Text("__________________");
		lastTab_metroLabel2.UseStyleColors = true;
		((Control)Continue_button3).set_Location(new Point(640, 200));
		((Control)Continue_button3).set_Margin(new Padding(4, 5, 4, 5));
		((Control)Continue_button3).set_Name("Continue_button3");
		((Control)Continue_button3).set_Size(new Size(202, 40));
		((Control)Continue_button3).set_TabIndex(90);
		((Control)Continue_button3).set_Text("Continue");
		((Control)Continue_button3).add_Click((EventHandler)Continue_button3_Click);
		((Control)Pause_button2).set_Location(new Point(429, 200));
		((Control)Pause_button2).set_Margin(new Padding(4, 5, 4, 5));
		((Control)Pause_button2).set_Name("Pause_button2");
		((Control)Pause_button2).set_Size(new Size(202, 40));
		((Control)Pause_button2).set_TabIndex(89);
		((Control)Pause_button2).set_Text("Pause");
		((Control)Pause_button2).add_Click((EventHandler)Pause_button2_Click);
		((Control)Stop_button1).set_Location(new Point(218, 200));
		((Control)Stop_button1).set_Margin(new Padding(4, 5, 4, 5));
		((Control)Stop_button1).set_Name("Stop_button1");
		((Control)Stop_button1).set_Size(new Size(202, 40));
		((Control)Stop_button1).set_TabIndex(88);
		((Control)Stop_button1).set_Text("Stop");
		((Control)Stop_button1).add_Click((EventHandler)Stop_button1_Click);
		((Control)Start_button1).set_Location(new Point(6, 200));
		((Control)Start_button1).set_Margin(new Padding(4, 5, 4, 5));
		((Control)Start_button1).set_Name("Start_button1");
		((Control)Start_button1).set_Size(new Size(202, 40));
		((Control)Start_button1).set_TabIndex(87);
		((Control)Start_button1).set_Text("Start");
		((Control)Start_button1).add_Click((EventHandler)Start_button1_Click);
		((Control)status_textBox1).set_Dock((DockStyle)1);
		((Control)status_textBox1).set_Location(new Point(0, 0));
		((Control)status_textBox1).set_Margin(new Padding(4, 5, 4, 5));
		((TextBoxBase)status_textBox1).set_Multiline(true);
		((Control)status_textBox1).set_Name("status_textBox1");
		((TextBoxBase)status_textBox1).set_ReadOnly(true);
		status_textBox1.set_ScrollBars((ScrollBars)3);
		((Control)status_textBox1).set_Size(new Size(1167, 190));
		((Control)status_textBox1).set_TabIndex(86);
		splitContainer3.set_Dock((DockStyle)2);
		((Control)splitContainer3).set_Location(new Point(0, 570));
		((Control)splitContainer3).set_Margin(new Padding(4, 5, 4, 5));
		((Control)splitContainer3).set_Name("splitContainer3");
		((Control)splitContainer3.get_Panel1()).get_Controls().Add((Control)(object)coupon_metroLabel2);
		((Control)splitContainer3.get_Panel1()).get_Controls().Add((Control)(object)version_label);
		((Control)splitContainer3.get_Panel2()).get_Controls().Add((Control)(object)instance_count);
		((Control)splitContainer3).set_Size(new Size(1167, 25));
		splitContainer3.set_SplitterDistance(733);
		splitContainer3.set_SplitterWidth(6);
		((Control)splitContainer3).set_TabIndex(92);
		((Control)coupon_metroLabel2).set_AutoSize(true);
		((Control)coupon_metroLabel2).set_Dock((DockStyle)4);
		coupon_metroLabel2.FontWeight = MetroLabelWeight.Bold;
		((Control)coupon_metroLabel2).set_ForeColor(Color.Black);
		((Control)coupon_metroLabel2).set_Location(new Point(664, 0));
		((Control)coupon_metroLabel2).set_Margin(new Padding(4, 0, 4, 0));
		((Control)coupon_metroLabel2).set_Name("coupon_metroLabel2");
		((Control)coupon_metroLabel2).set_Size(new Size(69, 19));
		coupon_metroLabel2.Style = MetroColorStyle.Red;
		((Control)coupon_metroLabel2).set_TabIndex(4);
		((Control)coupon_metroLabel2).set_Text("__________");
		coupon_metroLabel2.UseStyleColors = true;
		((Control)coupon_metroLabel2).set_Visible(false);
		((Control)version_label).set_AutoSize(true);
		((Control)version_label).set_Dock((DockStyle)2);
		version_label.FontWeight = MetroLabelWeight.Bold;
		((Control)version_label).set_ForeColor(Color.Black);
		((Control)version_label).set_Location(new Point(0, 6));
		((Control)version_label).set_Margin(new Padding(4, 0, 4, 0));
		((Control)version_label).set_Name("version_label");
		((Control)version_label).set_Size(new Size(154, 19));
		version_label.Style = MetroColorStyle.Brown;
		((Control)version_label).set_TabIndex(3);
		((Control)version_label).set_Text("License Not Activated");
		version_label.UseStyleColors = true;
		((Control)version_label).add_Click((EventHandler)version_label_Click);
		((Control)instance_count).set_AutoSize(true);
		((Control)instance_count).set_Dock((DockStyle)4);
		((Control)instance_count).set_Location(new Point(366, 0));
		((Control)instance_count).set_Margin(new Padding(4, 0, 4, 0));
		((Control)instance_count).set_Name("instance_count");
		((Control)instance_count).set_Size(new Size(62, 19));
		instance_count.Style = MetroColorStyle.Brown;
		((Control)instance_count).set_TabIndex(121);
		((Control)instance_count).set_Text("Pro tools");
		instance_count.UseStyleColors = true;
		((Control)splitter1).set_Dock((DockStyle)2);
		((Control)splitter1).set_Location(new Point(30, 720));
		((Control)splitter1).set_Margin(new Padding(4, 5, 4, 5));
		((Control)splitter1).set_Name("splitter1");
		((Control)splitter1).set_Size(new Size(1167, 5));
		((Control)splitter1).set_TabIndex(3);
		splitter1.set_TabStop(false);
		((Control)mainform_header).set_AutoSize(true);
		((Control)mainform_header).set_BackColor(Color.Transparent);
		((Control)mainform_header).set_Dock((DockStyle)1);
		mainform_header.FontWeight = MetroLabelWeight.Bold;
		((Control)mainform_header).set_ForeColor(Color.Purple);
		((Control)mainform_header).set_Location(new Point(30, 130));
		((Control)mainform_header).set_Margin(new Padding(4, 0, 4, 0));
		((Control)mainform_header).set_Name("mainform_header");
		((Control)mainform_header).set_Size(new Size(59, 19));
		mainform_header.Style = MetroColorStyle.Brown;
		((Control)mainform_header).set_TabIndex(4);
		((Control)mainform_header).set_Text("Header");
		mainform_header.UseStyleColors = true;
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(9f, 20f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(1227, 756));
		((Control)this).get_Controls().Add((Control)(object)mainform_header);
		((Control)this).get_Controls().Add((Control)(object)splitter1);
		((Control)this).get_Controls().Add((Control)(object)metroPanel1);
		((Control)this).get_Controls().Add((Control)(object)menuStrip1);
		((Control)this).set_ForeColor(Color.Brown);
		((Form)this).set_MainMenuStrip(menuStrip1);
		((Form)this).set_Margin(new Padding(4, 5, 4, 5));
		((Control)this).set_Name("Form1");
		base.Padding = new Padding(30, 92, 30, 31);
		base.Style = MetroColorStyle.Brown;
		((Control)this).set_Text("Poshmark Pro Tools");
		((Form)this).set_WindowState((FormWindowState)2);
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
		((Control)menuStrip1).ResumeLayout(false);
		((Control)menuStrip1).PerformLayout();
		((Control)metroPanel1).ResumeLayout(false);
		((Control)splitContainer1.get_Panel1()).ResumeLayout(false);
		((Control)splitContainer1.get_Panel2()).ResumeLayout(false);
		((Control)splitContainer1.get_Panel2()).PerformLayout();
		((ISupportInitialize)splitContainer1).EndInit();
		((Control)splitContainer1).ResumeLayout(false);
		((Control)splitContainer2.get_Panel1()).ResumeLayout(false);
		((Control)splitContainer2.get_Panel1()).PerformLayout();
		((Control)splitContainer2.get_Panel2()).ResumeLayout(false);
		((Control)splitContainer2.get_Panel2()).PerformLayout();
		((ISupportInitialize)splitContainer2).EndInit();
		((Control)splitContainer2).ResumeLayout(false);
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)splitContainer3.get_Panel1()).ResumeLayout(false);
		((Control)splitContainer3.get_Panel1()).PerformLayout();
		((Control)splitContainer3.get_Panel2()).ResumeLayout(false);
		((Control)splitContainer3.get_Panel2()).PerformLayout();
		((ISupportInitialize)splitContainer3).EndInit();
		((Control)splitContainer3).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
