using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Forms;
using BZJnSPwx;
using CCfpfC7h;
using Microsoft.VisualBasic.Devices;
using Y7FbhctW;
using ZqaFD1Ap;
using av2p5dFj;
using di1mqJMz;
using iiraiv39;
using ns0;
using ns2;
using p80hVGtz;

namespace qGIjTe0w;

internal class m7bmPddy
{
	public Form form_0;

	private GEBbAG79 F55xShIp;

	private string l8iHSAmN;

	private gMotwPfU XIHfw88n;

	private kk3OTTuY AApQFtxG;

	private liNXssyF j1mhjjxc;

	private Process process_0;

	private CXqgbBIh fUTwSlqw;

	private const string WHWiSRKS = "    ";

	private const string ACoQe5tD = "\r\n";

	private const string au98m8Rn = "Run";

	public CXqgbBIh BPkBmfke => fUTwSlqw;

	private bool method_0()
	{
		O4s9Dog1.CzLTISFT(O4s9Dog1.jghAQYJA((ServerComputer)(object)c.B_0, 18821), "Run", 48350);
		return true;
	}

	public m7bmPddy(ref GEBbAG79 m7TTnCss)
	{
		F55xShIp = m7TTnCss;
		method_0();
		l8iHSAmN = ivlgLlId.jnXal2jf(O4s9Dog1.BG85lvs2(42744), "\\Run", 28657);
		XIHfw88n = new gMotwPfU(ref m7TTnCss);
		AApQFtxG = new kk3OTTuY(ref m7TTnCss);
		m7bmPddy GvMNrrXE = this;
		j1mhjjxc = new liNXssyF(ref GvMNrrXE);
		fUTwSlqw = CXqgbBIh.hffibYPG;
	}

	public List<string> A5B9jfy7()
	{
		List<string> list = new List<string>();
		using List<vilSnlZy>.Enumerator enumerator = F55xShIp.QefPU7tp.GetEnumerator();
		int num = 0;
		vilSnlZy current = default(vilSnlZy);
		while (true)
		{
			if (num != 0)
			{
				list.Add(current.PYBbtbg6);
			}
			if (enumerator.MoveNext())
			{
				current = enumerator.Current;
				num = 1;
				continue;
			}
			break;
		}
		return list;
	}

	public bool tYu7tlwi()
	{
		return new cCuqyt2h(ref F55xShIp, ref XIHfw88n, ref AApQFtxG, CkPzD4SB: true, l8iHSAmN).jiy3Brdl();
	}

	public bool dSoaGy08()
	{
		Process process = new Process();
		try
		{
			O4s9Dog1.vJEE6dE6(O4s9Dog1.qGpfompX(process, 5768), "cmd.exe", 44457);
			O4s9Dog1.sBrEZDs4(O4s9Dog1.qGpfompX(process, 5768), bool_0: false, 64890);
			O4s9Dog1.sBrEZDs4(O4s9Dog1.qGpfompX(process, 5768), bool_0: true, 64891);
			O4s9Dog1.sBrEZDs4(O4s9Dog1.qGpfompX(process, 5768), bool_0: true, 64888);
			O4s9Dog1.sBrEZDs4(O4s9Dog1.qGpfompX(process, 5768), bool_0: true, 64889);
			O4s9Dog1.smethod_0(process, 45528);
			O4s9Dog1.erhmZZbp(O4s9Dog1.sTrZYBnH(process, 63497), FFXb5i9i.smethod_0("del \"", l8iHSAmN, "\\main.exe\"", 52605), 59159);
			O4s9Dog1.erhmZZbp(O4s9Dog1.sTrZYBnH(process, 63497), "\"C:\\Archivos de programa\\Microsoft Visual Studio 9.0\\VC\\vcvarsall.bat\"", 59159);
			string string_ = FFXb5i9i.Be2UxXd8(new string[5] { "cl \"", l8iHSAmN, "\\*.c\" /Fe\"", l8iHSAmN, "\\main.exe\" /link User32.lib" }, 53581);
			O4s9Dog1.erhmZZbp(O4s9Dog1.sTrZYBnH(process, 63497), string_, 59159);
			O4s9Dog1.erhmZZbp(O4s9Dog1.sTrZYBnH(process, 63497), FFXb5i9i.smethod_0("del \"", l8iHSAmN, "\\*.c\"", 52605), 59159);
			O4s9Dog1.erhmZZbp(O4s9Dog1.sTrZYBnH(process, 63497), FFXb5i9i.smethod_0("del \"", l8iHSAmN, "\\*.h\"", 52605), 59159);
			O4s9Dog1.erhmZZbp(O4s9Dog1.sTrZYBnH(process, 63497), FFXb5i9i.smethod_0("del \"", l8iHSAmN, "\\*.obj", 52605), 59159);
			O4s9Dog1.erhmZZbp(O4s9Dog1.sTrZYBnH(process, 63497), "exit", 59159);
			O4s9Dog1.YciAeyRu(O4s9Dog1.utxmaIHB(process, 12026), 45303);
			O4s9Dog1.c4EhBjUB(process, 41159);
		}
		finally
		{
			if (process != null)
			{
				O4s9Dog1.On3jH8m9(process, 63973);
			}
		}
		return true;
	}

	public bool method_1()
	{
		process_0 = new Process();
		Process process = process_0;
		O4s9Dog1.vJEE6dE6(O4s9Dog1.qGpfompX(process, 5768), "cmd.exe", 44457);
		O4s9Dog1.sBrEZDs4(O4s9Dog1.qGpfompX(process, 5768), bool_0: false, 64890);
		O4s9Dog1.sBrEZDs4(O4s9Dog1.qGpfompX(process, 5768), bool_0: true, 64891);
		O4s9Dog1.sBrEZDs4(O4s9Dog1.qGpfompX(process, 5768), bool_0: true, 64888);
		O4s9Dog1.sBrEZDs4(O4s9Dog1.qGpfompX(process, 5768), bool_0: true, 64889);
		O4s9Dog1.smethod_0(process, 45528);
		O4s9Dog1.erhmZZbp(O4s9Dog1.sTrZYBnH(process, 63497), FFXb5i9i.smethod_0("\"", l8iHSAmN, "\\main.exe\"", 52605), 59159);
		fUTwSlqw = CXqgbBIh.eiTWUGWQ;
		return true;
	}

	public bool MMH6nGnR()
	{
		return j1mhjjxc.BP4p0Noz();
	}

	public void GZjJB531()
	{
		j1mhjjxc.method_0("RequestActiveSteps");
	}

	public void BAFveiM2()
	{
		j1mhjjxc.method_0("RequestVariables");
	}

	public void method_2()
	{
		j1mhjjxc.method_0("step");
	}

	public void wQlHDqVw(ref vilSnlZy vxtGfhw0, string jybcmXpu)
	{
		string string_ = vxtGfhw0.String_2;
		if (ivlgLlId.smethod_3(string_, "BOOL", bool_0: false, 3221) == 0)
		{
			jybcmXpu = XIHfw88n.oUJpcypU(jybcmXpu).ToString();
		}
		j1mhjjxc.method_0(FFXb5i9i.MhuSoiDL("SetVariable ", vxtGfhw0.PYBbtbg6, " ", jybcmXpu, 9407));
	}

	public void ZE1UDqbV()
	{
		j1mhjjxc.method_0("end");
		for (int num = 0; num == 0; num = 1)
		{
			fUTwSlqw = CXqgbBIh.hffibYPG;
		}
	}

	public bool EScKKlna()
	{
		return j1mhjjxc.YqehMG5R();
	}

	public void F90HO5NN(string W3D7z83z)
	{
		if (W3D7z83z == null)
		{
			return;
		}
		string[] array = FFXb5i9i.fLadxka9(W3D7z83z, new char[1] { ' ' }, 33801);
		string string_ = array[0];
		string text = ((array.Length <= 1) ? "" : array[1]);
		string mFVyBQBI = ((array.Length <= 2) ? "" : array[2]);
		if (ivlgLlId.smethod_3(string_, "ResponseActiveSteps", bool_0: false, 3221) != 0)
		{
			if (ivlgLlId.smethod_3(string_, "ResponseVariables", bool_0: false, 3221) != 0)
			{
				if (ivlgLlId.smethod_3(string_, "SetVariable", bool_0: false, 3221) == 0)
				{
					GEBbAG79 f55xShIp = F55xShIp;
					av2p5dFj.EJ0keUOA<vilSnlZy, string> khV0i9G = ODkTDnLD(text, mFVyBQBI);
					f55xShIp.xVhnJba4(ref khV0i9G);
				}
			}
			else
			{
				GEBbAG79 f55xShIp2 = F55xShIp;
				av2p5dFj.EJ0keUOA<vilSnlZy, string> khV0i9G = b1xdXIFU(text);
				f55xShIp2.xVhnJba4(ref khV0i9G);
			}
		}
		else
		{
			GEBbAG79 f55xShIp3 = F55xShIp;
			av2p5dFj.EJ0keUOA<sm18FGKs, StKhY3Gf> MTo7NOKF = qQHZp1T4(text);
			f55xShIp3.LZAIdk2a(ref MTo7NOKF);
		}
	}

	private av2p5dFj.EJ0keUOA<sm18FGKs, StKhY3Gf> qQHZp1T4(string ly2m4MgX)
	{
		av2p5dFj.EJ0keUOA<sm18FGKs, StKhY3Gf> eJ0keUOA = new av2p5dFj.EJ0keUOA<sm18FGKs, StKhY3Gf>();
		StKhY3Gf stKhY3Gf = new StKhY3Gf();
		string[] array = FFXb5i9i.fLadxka9(ly2m4MgX, new char[1] { ',' }, 33801);
		int num = 0;
		string[] array2 = array;
		checked
		{
			for (int i = 0; i < array2.Length; i++)
			{
				string text = KcEKvRC1.bJcnPWi8(array2[i]);
				int num2 = XIHfw88n.CfoWAt93[num].ej0keUOA_0.Count - ivlgLlId.f5lHgZCI(text, 64616);
				if (num2 > 0)
				{
					int num3 = num2;
					for (int j = 1; j <= num3; j++)
					{
						text = ivlgLlId.jnXal2jf("0", text, 28657);
					}
				}
				else if (num2 < 0)
				{
					text = ivlgLlId.V6rQQ40U(text, num2 * -1 + 1, 55775);
				}
				int num4 = ivlgLlId.f5lHgZCI(text, 64616);
				for (int j = 1; j <= num4; j++)
				{
					int lJo6VyYf = ivlgLlId.f5lHgZCI(text, 64616) - j;
					if ((double)ivlgLlId.PluO6Q6e(ivlgLlId.zIKBYyAm(text, j, 1, 41221), 37974) == O4s9Dog1.HP9gYOXQ("1", 4542))
					{
						stKhY3Gf.Add(XIHfw88n.IDqdc8Nt(num, lJo6VyYf));
					}
				}
				eJ0keUOA.Add(F55xShIp.kf6SJ6Gg[num], stKhY3Gf);
				num++;
			}
			return eJ0keUOA;
		}
	}

	private av2p5dFj.EJ0keUOA<vilSnlZy, string> b1xdXIFU(string QdYAN4mw)
	{
		av2p5dFj.EJ0keUOA<vilSnlZy, string> eJ0keUOA = new av2p5dFj.EJ0keUOA<vilSnlZy, string>();
		string[] array = FFXb5i9i.fLadxka9(QdYAN4mw, new char[1] { ',' }, 33801);
		object object_ = default(object);
		object object_2 = default(object);
		if (vRvDyS3Z.KE94ovRt(object_, 1, array.Length, 1, ref object_2, ref object_, 23616))
		{
			KeyValuePair<vilSnlZy, string> current = default(KeyValuePair<vilSnlZy, string>);
			do
			{
				int key = FFXb5i9i.fEqPi5J6(FFXb5i9i.TCNI2YTH(object_, 1, 1487), 22520);
				vilSnlZy vilSnlZy = AApQFtxG.h3zupNkI[key];
				string mFVyBQBI = array[FFXb5i9i.fEqPi5J6(FFXb5i9i.TCNI2YTH(object_, 1, 1487), 22520)];
				av2p5dFj.EJ0keUOA<vilSnlZy, string> eJ0keUOA2 = ODkTDnLD(vilSnlZy.PYBbtbg6, mFVyBQBI);
				using Dictionary<vilSnlZy, string>.Enumerator enumerator = eJ0keUOA2.GetEnumerator();
				int num = 0;
				while (true)
				{
					if (num != 0)
					{
						eJ0keUOA.Add(current.Key, current.Value);
					}
					if (enumerator.MoveNext())
					{
						current = enumerator.Current;
						num = 1;
						continue;
					}
					break;
				}
			}
			while (vRvDyS3Z.m3io0jnW(object_, object_2, ref object_, 51640));
		}
		return eJ0keUOA;
	}

	private av2p5dFj.EJ0keUOA<vilSnlZy, string> ODkTDnLD(string fVmg3qIa, string MFVyBQBI)
	{
		av2p5dFj.EJ0keUOA<vilSnlZy, string> eJ0keUOA = new av2p5dFj.EJ0keUOA<vilSnlZy, string>();
		vilSnlZy vilSnlZy = XIHfw88n.qFlLSVvw[fVmg3qIa];
		string string_ = vilSnlZy.String_2;
		if (ivlgLlId.smethod_3(string_, "BOOL", bool_0: false, 3221) != 0)
		{
			if (ivlgLlId.smethod_3(string_, "INT", bool_0: false, 3221) != 0)
			{
				if (ivlgLlId.smethod_3(string_, "REAL", bool_0: false, 3221) == 0)
				{
					eJ0keUOA.Add(vilSnlZy, bN8b3jgg(MFVyBQBI).ToString());
				}
			}
			else
			{
				eJ0keUOA.Add(vilSnlZy, ivlgLlId.PluO6Q6e(MFVyBQBI, 37974).ToString());
			}
		}
		else
		{
			string string_2 = vRvDyS3Z.RaPIakol(fTY1moQq(MFVyBQBI), 42328);
			eJ0keUOA.Add(vilSnlZy, FFXb5i9i.UUMks6OM(string_2, 63152));
		}
		return eJ0keUOA;
	}

	private float bN8b3jgg(string bwyrrnjN)
	{
		NumberFormatInfo iformatProvider_ = vRvDyS3Z.smethod_0(new CultureInfo("en-US", useUserOverride: false), 40301);
		return vRvDyS3Z.erQzpN5j(bwyrrnjN, iformatProvider_, 36845);
	}

	private bool fTY1moQq(string uON78OVY)
	{
		return ivlgLlId.smethod_3(uON78OVY, "1", bool_0: false, 3221) == 0;
	}
}
