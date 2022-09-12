using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Pipes;
using System.Net;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using chicken.src.Gui;
using chicken.src.Util;

namespace chicken;

public class Form1 : Form
{
	private NamedPipeServerStream eCxsZGNcqZkMgxOKtCqFEryhPeaAA = null;

	private static object oBKhixmwZXBBbEhoSNqWtxpeqzkv = new object();

	private static object vwZXfmxusTpQkrbImxCcRkhuxtMS = new object();

	private static System.Timers.Timer xpNnpaKbldlEqBitOhekGqnXejDHA;

	private static System.Timers.Timer XMlPnTfFNknKKDuXLKCbTXnaTbre;

	public static bool tostart = true;

	public static bool playSound = false;

	public static bool PatchButton = true;

	public static bool bool_ = false;

	private Point HvffZjKibIsygEEvLgkCDYnGleyg = new Point(0, 0);

	public static string mrmessage = " 안내";

	public static string lineagecfg = "lineage.cfg";

	public static string linbin = "lin.bin";

	public static string dll = "z3dcom154.dll";

	public static string PackingLibrary = "PackingLibraryWrapper-Win32-Release.dll";

	public static int linbinlength = 1;

	public static Form1 _main;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool etwPjshjfwhpJFrMdXiSamRfCKdCb;

	private static ArrayList SlBNsudHsQcJJRwRUbkhmAbNyoNd = new ArrayList();

	private const int FwZdqUntXufuwOmJQGPqhjgVQlNo = 1024;

	private static string jqvfOjJtteVqSeiIlwxJfjEIJJPj;

	private static string RouHOscEaIQILYQemHmxhmuDqBrE = "test.txt";

	private const int dMfvYrqfBKIzqVgActjyhHqtYYZt = 9;

	private IContainer hUHlHIVtIZNMyNATlFHUIjnUgWJBb = null;

	private PictureBox DEuhSXIQsqNbiIynbJPcbvGpReRHb;

	private Buttoncontroller okAlEpSBZnUeOnlDpCwOmLKMEbZL;

	private Buttoncontroller mvLopefPYXEaSmClJDEgEtmHzyRF;

	private Buttoncontroller JGvNFIBEyAenNDfJzdBhLpDungHP;

	private Buttoncontroller IHxTpnQSMiuThvVsqrwTAtXZeSzJ;

	private Buttoncontroller AcrKWAcOvvxSVpjbTvlbugvmTQiL;

	private Buttoncontroller TzyAutPizdXHkTKlthbxNmPTBpxfA;

	private Buttoncontroller FLKfXhxpqKAsutglECUXFtngjOngb;

	private Buttoncontroller alqQjqxQkpitpgcoXiCbJstUZRePA;

	private Label QefWKYgcJjaidBefCHvtswPGVyRpA;

	private ToolTip OEVIRlGPGxHoSJmWzScfwzBUUteh;

	private Buttoncontroller cNxsQTxWISSmvOKyPwHCfXJJGJLO;

	private Buttoncontroller EXSJXVqPzhLNkdDMDonKVTrUBVHg;

	private Label gOeLlzGvWCezMGQbRBPInheEHoDiA;

	private Timer pjctolIhaJEcTMLwElqNyCLTyPSk;

	public bool _isrun
	{
		[CompilerGenerated]
		get
		{
			return etwPjshjfwhpJFrMdXiSamRfCKdCb;
		}
		[CompilerGenerated]
		set
		{
			etwPjshjfwhpJFrMdXiSamRfCKdCb = value;
		}
	}

	[DllImport("user32.dll")]
	public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

	[DllImport("user32.dll")]
	public static extern int SendMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);

	[DllImport("winmm.dll")]
	private static extern long mciSendString(string strCommand, StringBuilder strReturn, int iReturnLength, IntPtr hwndCallback);

	public Form1()
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		elGrDrgnJeFUoSEuIevkfWkCRVaIA();
		((Form)this).add_FormClosing(new FormClosingEventHandler(VFCtcrHqmpjJXjWUDAPMrmtozdGv));
	}

	protected override void OnLoad(EventArgs e)
	{
		Thread.Sleep(500);
		DEuhSXIQsqNbiIynbJPcbvGpReRHb.set_ImageLocation("MrImage.gif");
		((Form)this).OnLoad(e);
	}

	private void IfBZYpJQOMXHQaFRZIvzNQPXuqWM(object sender, EventArgs e)
	{
		okAlEpSBZnUeOnlDpCwOmLKMEbZL.init();
		mvLopefPYXEaSmClJDEgEtmHzyRF.init();
		JGvNFIBEyAenNDfJzdBhLpDungHP.init();
		IHxTpnQSMiuThvVsqrwTAtXZeSzJ.init();
		AcrKWAcOvvxSVpjbTvlbugvmTQiL.init();
		TzyAutPizdXHkTKlthbxNmPTBpxfA.init();
		FLKfXhxpqKAsutglECUXFtngjOngb.init();
		alqQjqxQkpitpgcoXiCbJstUZRePA.init();
		cNxsQTxWISSmvOKyPwHCfXJJGJLO.init();
		EXSJXVqPzhLNkdDMDonKVTrUBVHg.init();
		AtmuYYEbUXfocFYlKwbbQKuPncQG();
		mqgMVZsMggSbFPumwMoCtgTasJFi();
		xpNnpaKbldlEqBitOhekGqnXejDHA = new System.Timers.Timer(1000.0);
		xpNnpaKbldlEqBitOhekGqnXejDHA.Elapsed += HdNjmpMNudafjiLfYISjdqerLAqjA;
		xpNnpaKbldlEqBitOhekGqnXejDHA.Enabled = false;
		XMlPnTfFNknKKDuXLKCbTXnaTbre = new System.Timers.Timer(3000.0);
		XMlPnTfFNknKKDuXLKCbTXnaTbre.Elapsed += yHclcMOPGguhbloRcpzPzPnjNfkH;
		XMlPnTfFNknKKDuXLKCbTXnaTbre.Enabled = false;
	}

	private void mqgMVZsMggSbFPumwMoCtgTasJFi()
	{
		((Control)okAlEpSBZnUeOnlDpCwOmLKMEbZL).set_BackColor(Color.Transparent);
		((Control)mvLopefPYXEaSmClJDEgEtmHzyRF).set_BackColor(Color.Transparent);
		((Control)JGvNFIBEyAenNDfJzdBhLpDungHP).set_BackColor(Color.Transparent);
		((Control)IHxTpnQSMiuThvVsqrwTAtXZeSzJ).set_BackColor(Color.Transparent);
		((Control)AcrKWAcOvvxSVpjbTvlbugvmTQiL).set_BackColor(Color.Transparent);
		((Control)TzyAutPizdXHkTKlthbxNmPTBpxfA).set_BackColor(Color.Transparent);
		((Control)FLKfXhxpqKAsutglECUXFtngjOngb).set_BackColor(Color.Transparent);
		((Control)alqQjqxQkpitpgcoXiCbJstUZRePA).set_BackColor(Color.Transparent);
		((Control)cNxsQTxWISSmvOKyPwHCfXJJGJLO).set_BackColor(Color.Transparent);
		((Control)EXSJXVqPzhLNkdDMDonKVTrUBVHg).set_BackColor(Color.Transparent);
		Labelchange("게임을 진행 하시려면 '게임시작'을 누르십시오.");
		Labelchange2(RdlTsOiEbcMaKLwiwHniRAkfgOvu("Notice"));
		Console.WriteLine(RdlTsOiEbcMaKLwiwHniRAkfgOvu("Notice"));
	}

	public void Labelchange2(string ment)
	{
		((Control)gOeLlzGvWCezMGQbRBPInheEHoDiA).set_Enabled(false);
		((Control)gOeLlzGvWCezMGQbRBPInheEHoDiA).set_Text(ment);
		((Control)gOeLlzGvWCezMGQbRBPInheEHoDiA).set_Enabled(true);
	}

	public void Labelchange(string ment)
	{
		((Control)QefWKYgcJjaidBefCHvtswPGVyRpA).set_Enabled(false);
		((Control)QefWKYgcJjaidBefCHvtswPGVyRpA).set_Text(ment);
		((Control)QefWKYgcJjaidBefCHvtswPGVyRpA).set_Enabled(true);
	}

	public void Decrementer()
	{
		Labelchange("서버 패치 작업을 완료 하였습니다.");
	}

	public static DateTime Delay(int ms)
	{
		DateTime now = DateTime.Now;
		TimeSpan value = new TimeSpan(0, 0, 0, 0, ms);
		DateTime dateTime = now.Add(value);
		while (dateTime >= now)
		{
			Application.DoEvents();
			now = DateTime.Now;
		}
		return DateTime.Now;
	}

	private void MfoTpoIKLoWQSkxLtqTxCAGZvf(object sender, MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		if ((int)e.get_Button() == 1048576)
		{
			HvffZjKibIsygEEvLgkCDYnGleyg = new Point(-e.get_X(), -e.get_Y());
		}
	}

	private void sKBezVtacjJihxiosirRBBClrvPC(object sender, MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		if ((int)e.get_Button() == 1048576)
		{
			((Form)this).set_Location(new Point(((Form)this).get_Location().X + (HvffZjKibIsygEEvLgkCDYnGleyg.X + e.get_X()), ((Form)this).get_Location().Y + (HvffZjKibIsygEEvLgkCDYnGleyg.Y + e.get_Y())));
		}
	}

	private void nWkHhmJnxeFMxIRSawjLQzxRijuj()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			qjgeNrdeeaKgBaOMHRjxeHCZMLoYA();
			Environment.Exit(0);
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message + "\r\n" + ex.StackTrace);
		}
	}

	private void qjgeNrdeeaKgBaOMHRjxeHCZMLoYA()
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Process[] processesByName = Process.GetProcessesByName(linbin);
			foreach (Process process in processesByName)
			{
				process.Kill();
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message + "\r\n" + ex.StackTrace);
		}
	}

	public static void mrlogDelete()
	{
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		DirectoryInfo directoryInfo = new DirectoryInfo("C:\\Users\\User\\AppData\\Local\\Temp\\");
		try
		{
			if (string.IsNullOrWhiteSpace("*.log"))
			{
				FileInfo[] files = directoryInfo.GetFiles();
				foreach (FileInfo fileInfo in files)
				{
					fileInfo.Delete();
				}
			}
			else
			{
				FileInfo[] files2 = directoryInfo.GetFiles("*.log");
				foreach (FileInfo fileInfo2 in files2)
				{
					fileInfo2.Delete();
				}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message + "\r\n" + ex.StackTrace);
		}
	}

	private void mjPhJUxhocWGCXHBGrzFnXfCaqWL()
	{
		ThreadStart();
	}

	public static string LoadPage1(string type)
	{
		string text = Form2.webString.Replace(" ", "").Split(new string[1] { type + "]" }, StringSplitOptions.RemoveEmptyEntries)[1];
		return text.Replace("[/", "").Split(new string[1] { "[/ip]" }, StringSplitOptions.RemoveEmptyEntries)[0];
	}

	public static string LoadPage2(string type)
	{
		string text = Form2.webString.Replace(" ", "").Split(new string[1] { type + "]" }, StringSplitOptions.RemoveEmptyEntries)[1];
		return text.Replace("[/", "").Split(new string[1] { "[/port]" }, StringSplitOptions.RemoveEmptyEntries)[0];
	}

	private string ibHkUMxHxvGOypJuXKKbgzdCqNFw(string type)
	{
		string text = Form2.webString.Replace(" ", "").Split(new string[1] { type + "]" }, StringSplitOptions.RemoveEmptyEntries)[1];
		return text.Replace("[/", "").Split(new string[1] { "[/home]" }, StringSplitOptions.RemoveEmptyEntries)[0];
	}

	private string ZkcnpOlHTaCvocKeAFgkMOPCyouwA(string type)
	{
		string text = Form2.webString.Replace(" ", "").Split(new string[1] { type + "]" }, StringSplitOptions.RemoveEmptyEntries)[1];
		return text.Replace("[/", "").Split(new string[1] { "[/PowerBook]" }, StringSplitOptions.RemoveEmptyEntries)[0];
	}

	public static string LoadPage5(string type)
	{
		string text = Form2.webString.Replace(" ", "").Split(new string[1] { type + "]" }, StringSplitOptions.RemoveEmptyEntries)[1];
		return text.Replace("[/", "").Split(new string[1] { "[/engine]" }, StringSplitOptions.RemoveEmptyEntries)[0];
	}

	private string RdlTsOiEbcMaKLwiwHniRAkfgOvu(string type)
	{
		string text = Form2.webString.Replace("<br />", "").Replace("</span>", "").Replace("nbsp;", "")
			.Split(new string[1] { "&lt;" + type + "&gt;" }, StringSplitOptions.RemoveEmptyEntries)[1];
		return text.Replace("<br />", "").Replace("</span>", "").Replace("nbsp;", "")
			.Split(new string[1] { "&lt;/" + type + "&gt;" }, StringSplitOptions.RemoveEmptyEntries)[0];
	}

	public void ThreadStart()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		Labelchange("게임을 시작합니다. 즐거운 게임되세요.");
		try
		{
			if (tostart)
			{
				hMFGGBiWAQdcgbwzLZAFrHDJKkWOA(bool_);
			}
			tostart = false;
			Process[] processesByName = Process.GetProcessesByName(linbin);
			if (processesByName.Length >= linbinlength)
			{
				tostart = false;
			}
			Delay(3000);
			Labelchange(" (" + processesByName.Length + ") 개의 게임이 진행중 입니다.");
			tostart = true;
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message + "\r\n" + ex.StackTrace);
		}
	}

	public static byte[] HexToByte(string hex)
	{
		byte[] array = new byte[hex.Length / 2];
		int num = array.Length;
		for (int i = 0; i < num; i++)
		{
			array[i] = Convert.ToByte(hex.Substring(i * 2), 16);
		}
		return array;
	}

	private byte[] vqWvnxoTPOEZmANlVRpyTFtoQpBJ(string str)
	{
		return Encoding.UTF8.GetBytes(str);
	}

	protected object LoadProjectResource(string strResName)
	{
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		string baseName = executingAssembly.GetName().Name + ".Properties.Resources";
		ResourceManager resourceManager = new ResourceManager(baseName, executingAssembly);
		return resourceManager.GetObject(strResName);
	}

	public string str2hex(string strData)
	{
		string text = string.Empty;
		byte[] bytes = Encoding.Default.GetBytes(strData);
		byte[] array = bytes;
		foreach (byte b in array)
		{
			text += $"{b:X2}";
		}
		return text;
	}

	private void OFKiSDpjhMVmzoDTzCTvbznpaLGkA()
	{
		byte[] sYCgqQcqoMukKzaubmvBkcxJRFUk = BEMfLrhfEPoZBtrtCSUfMODAbESg.SYCgqQcqoMukKzaubmvBkcxJRFUk;
		FileSystemInfo fileSystemInfo = new FileInfo(lineagecfg);
		FileStream fileStream = new FileStream(fileSystemInfo.FullName, FileMode.Create);
		fileStream.Write(sYCgqQcqoMukKzaubmvBkcxJRFUk, 0, sYCgqQcqoMukKzaubmvBkcxJRFUk.Length);
		fileStream.Close();
	}

	private void aWzjbqNHBGfqvXCDeXYOdhZqNXac()
	{
		byte[] ftMFiyWkdgQpkYgBHoscwPXAqcwM = BEMfLrhfEPoZBtrtCSUfMODAbESg.ftMFiyWkdgQpkYgBHoscwPXAqcwM;
		FileSystemInfo fileSystemInfo = new FileInfo(lineagecfg);
		FileStream fileStream = new FileStream(fileSystemInfo.FullName, FileMode.Create);
		fileStream.Write(ftMFiyWkdgQpkYgBHoscwPXAqcwM, 0, ftMFiyWkdgQpkYgBHoscwPXAqcwM.Length);
		fileStream.Close();
	}

	private void KgagoDGXVrVEjEpRLExKxMneGeJsA()
	{
		byte[] bTgRAMTIsoYCWSqxxaMpupmKcyYU = BEMfLrhfEPoZBtrtCSUfMODAbESg.bTgRAMTIsoYCWSqxxaMpupmKcyYU;
		FileSystemInfo fileSystemInfo = new FileInfo(lineagecfg);
		FileStream fileStream = new FileStream(fileSystemInfo.FullName, FileMode.Create);
		fileStream.Write(bTgRAMTIsoYCWSqxxaMpupmKcyYU, 0, bTgRAMTIsoYCWSqxxaMpupmKcyYU.Length);
		fileStream.Close();
	}

	private void iowDiwkvRuETzEWAEZqkEHKWvFxLc()
	{
		byte[] cGXEInrIBkUMAHVlmxEcjceFEUFU = BEMfLrhfEPoZBtrtCSUfMODAbESg.cGXEInrIBkUMAHVlmxEcjceFEUFU;
		FileSystemInfo fileSystemInfo = new FileInfo(lineagecfg);
		FileStream fileStream = new FileStream(fileSystemInfo.FullName, FileMode.Create);
		fileStream.Write(cGXEInrIBkUMAHVlmxEcjceFEUFU, 0, cGXEInrIBkUMAHVlmxEcjceFEUFU.Length);
		fileStream.Close();
	}

	private void AtmuYYEbUXfocFYlKwbbQKuPncQG()
	{
	}

	private void PwrMhGshBREnjlAAalLZVAcEIgkV()
	{
		byte[] khcMjHGShWQDmnztxmkqAKRFzGwP = BEMfLrhfEPoZBtrtCSUfMODAbESg.khcMjHGShWQDmnztxmkqAKRFzGwP;
		FileSystemInfo fileSystemInfo = new FileInfo(linbin);
		FileStream fileStream = new FileStream(fileSystemInfo.FullName, FileMode.Create);
		fileStream.Write(khcMjHGShWQDmnztxmkqAKRFzGwP, 0, khcMjHGShWQDmnztxmkqAKRFzGwP.Length);
		fileStream.Close();
	}

	public static void ReadString()
	{
		byte[] array = new byte[1024];
		FileStream fileStream = File.OpenRead(RouHOscEaIQILYQemHmxhmuDqBrE);
		UTF8Encoding uTF8Encoding = new UTF8Encoding(encoderShouldEmitUTF8Identifier: true);
		while (fileStream.Read(array, 0, array.Length) > 0)
		{
			jqvfOjJtteVqSeiIlwxJfjEIJJPj += uTF8Encoding.GetString(array);
		}
		Console.WriteLine(jqvfOjJtteVqSeiIlwxJfjEIJJPj);
		fileStream.Close();
	}

	private void hMFGGBiWAQdcgbwzLZAFrHDJKkWOA(bool bool_1)
	{
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			EHAerTgvSAPiijIrFCRhYkmPjbKCB eHAerTgvSAPiijIrFCRhYkmPjbKCB = new EHAerTgvSAPiijIrFCRhYkmPjbKCB();
			eHAerTgvSAPiijIrFCRhYkmPjbKCB.VazheFGoLlOBbNNJvoupWJeTYqUS();
			PwrMhGshBREnjlAAalLZVAcEIgkV();
			Thread.Sleep(300);
			bool flag;
			if (bool_1)
			{
				iowDiwkvRuETzEWAEZqkEHKWvFxLc();
				flag = false;
			}
			else
			{
				OFKiSDpjhMVmzoDTzCTvbznpaLGkA();
				flag = true;
			}
			IPAddress serverIp = IPAddress.Parse(LoadPage1("ip"));
			ushort port = Convert.ToUInt16(LoadPage2("port"));
			EHUvTRWufNsGsLlhntmObjSWSDhl.VfSyUAiLYZSHeCCwnXZySxEYQjKs(Application.get_StartupPath(), linbin, port, serverIp);
			if (!flag || !FYdiTWDmIoGbLnGKhxlRGATwbgQx())
			{
				resChanger.changeRes(16);
				xpNnpaKbldlEqBitOhekGqnXejDHA.Enabled = true;
			}
			else
			{
				processlin();
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message + "\r\n" + ex.StackTrace);
		}
		finally
		{
			lock (oBKhixmwZXBBbEhoSNqWtxpeqzkv)
			{
				_isrun = false;
			}
		}
	}

	public static void processlin()
	{
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Process[] processesByName = Process.GetProcessesByName(linbin);
			foreach (Process process in processesByName)
			{
				Delay(1200);
				SendKeys.SendWait("%{TAB}");
				Delay(1600);
				SendKeys.SendWait("%");
				MJWin32Api.ShowWindow(process.MainWindowHandle, 9);
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message + "\r\n" + ex.StackTrace);
		}
	}

	private void JgkQBrlWiSjYkHufEGViZAiRdYVY(object object_2)
	{
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		Console.WriteLine("아이피: " + LoadPage1("ip") + "/ 포트: " + Convert.ToUInt16(LoadPage2("port")));
		try
		{
			ushort num = Convert.ToUInt16(LoadPage2("port"));
			byte[] bytes = Encoding.ASCII.GetBytes(LoadPage1("ip"));
			byte[] array = new byte[45];
			Array.Copy(bytes, array, bytes.Length);
			if (bytes.Length < 20)
			{
				for (int i = bytes.Length; i < 20; i++)
				{
					array[i] = 0;
				}
			}
			array[20] = (byte)(num & 0xFFu);
			array[21] = (byte)((uint)(num >> 8) & 0xFFu);
			Array.Copy(bytes, 0, array, 22, bytes.Length);
			if (bytes.Length < 20)
			{
				for (int j = bytes.Length; j < 20; j++)
				{
					array[22 + j] = 0;
				}
			}
			lock (oBKhixmwZXBBbEhoSNqWtxpeqzkv)
			{
				eCxsZGNcqZkMgxOKtCqFEryhPeaAA = new NamedPipeServerStream("MJSOFT", PipeDirection.InOut, 5, PipeTransmissionMode.Byte);
				eCxsZGNcqZkMgxOKtCqFEryhPeaAA.WaitForConnection();
				BinaryWriter binaryWriter = new BinaryWriter(eCxsZGNcqZkMgxOKtCqFEryhPeaAA);
				binaryWriter.Write(array);
				eCxsZGNcqZkMgxOKtCqFEryhPeaAA.WaitForPipeDrain();
				eCxsZGNcqZkMgxOKtCqFEryhPeaAA.Close();
				eCxsZGNcqZkMgxOKtCqFEryhPeaAA.Dispose();
				binaryWriter.Dispose();
			}
		}
		catch (IOException ex)
		{
			eCxsZGNcqZkMgxOKtCqFEryhPeaAA.Close();
			MessageBox.Show("ERROR : ", ex.Message);
		}
	}

	private void dmvebJCIlplywMnLhlqffzWZuYVRA(object sender, EventArgs e)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Invalid comparison between Unknown and I4
		Labelchange("전체화면 으로 게임을 시작합니다.");
		Process[] processesByName = Process.GetProcessesByName(linbin);
		if (processesByName.Length < linbinlength)
		{
			DialogResult val = MessageBox.Show("전체화면을 선택 하셨습니다.\r\n확인버튼을 누르시면 게임이 시작 됩니다.\r\n", " Lineage client ver 3.1", (MessageBoxButtons)1, (MessageBoxIcon)64);
			if ((int)val == 1)
			{
				bool_ = false;
				mjPhJUxhocWGCXHBGrzFnXfCaqWL();
			}
		}
		else
		{
			Labelchange("더 이상 클라이언트를 실행할 수 없습니다.");
		}
	}

	private void VqsZxCACbmsbUzGYoVMXGAvFKejg(object sender, EventArgs e)
	{
		Labelchange("홈페이지 사이트로 이동합니다.");
		Process.Start(ibHkUMxHxvGOypJuXKKbgzdCqNFw("home"));
	}

	private void dkAzUvZgBeErOYSAwsJMTVkGqEsm(object sender, EventArgs e)
	{
		Labelchange("파워북 사이트로 이동합니다.");
		Process.Start(ZkcnpOlHTaCvocKeAFgkMOPCyouwA("https://lineage.plaync.com/powerbook/index"));
	}

	private void mCodRYmDQPfVwBpGZqeSjEOyZJXH(object sender, EventArgs e)
	{
		Labelchange("패스트핑 사이트로 이동합니다.");
		Process.Start("http://www.fastping.co.kr/main/main");
	}

	private void CljgYJnyNfJJAioxfkPfLyiBRDkc(object sender, EventArgs e)
	{
		Labelchange("서버 패치를 진행합니다.");
		if (PatchButton)
		{
			Form3 form = new Form3();
			((Form)form).set_Owner((Form)(object)this);
			((Control)form).Show();
			PatchButton = false;
		}
	}

	private void SRAdRmCgylvoJQzfRrXrejroqCHYA(object sender, EventArgs e)
	{
		Labelchange("내리기 버튼을 누르셨습니다.");
		((Form)this).set_WindowState((FormWindowState)1);
	}

	private void YcagiRDTbEAkEDiwSdkesFaipizxA(object sender, EventArgs e)
	{
		nWkHhmJnxeFMxIRSawjLQzxRijuj();
	}

	private void VFCtcrHqmpjJXjWUDAPMrmtozdGv(object sender, FormClosingEventArgs e)
	{
		nWkHhmJnxeFMxIRSawjLQzxRijuj();
	}

	private void JVGbSKHfTMcPPcooNPvfYsOTDImjb(object sender, EventArgs e)
	{
		Labelchange("토크온 사이트로 이동합니다.");
		Process.Start("https://talkon.nate.com");
	}

	private void mdZMFXFpuzbymQaOcbffOuqdqujw()
	{
		Thread.Sleep(1000);
		mciSendString("open \"\\playSound.mp3\" type mpegvideo alias MediaFile", null, 0, IntPtr.Zero);
		mciSendString("play MediaFile repeat", null, 0, IntPtr.Zero);
		playSound = true;
	}

	private void iaQjKRZuWQBlOJzVTexgMQNkqesF(object sender, EventArgs e)
	{
	}

	private bool FYdiTWDmIoGbLnGKhxlRGATwbgQx()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		while (true)
		{
			PlatformID platform = oSVersion.Platform;
			PlatformID platformID = platform;
			if (platformID != PlatformID.Win32NT || oSVersion.Version.Major != 6)
			{
				break;
			}
			if (oSVersion.Version.Minor == 2)
			{
				return true;
			}
		}
		return false;
	}

	private string yazBPuhrRaaDOAXfeeBmySWbBpQHc()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		string text = "";
		string text2 = "Unknown";
		PlatformID platform = oSVersion.Platform;
		PlatformID platformID = platform;
		if (platformID != PlatformID.Win32NT)
		{
			text = "Unknown";
		}
		else
		{
			if (oSVersion.Version.Major == 4)
			{
				if (oSVersion.Version.Minor == 0)
				{
					text = "Windows NT 4.0";
				}
			}
			else if (oSVersion.Version.Major == 5)
			{
				if (oSVersion.Version.Minor != 0)
				{
					if (oSVersion.Version.Minor != 1)
					{
						if (oSVersion.Version.Minor == 2)
						{
							text = "Windows 2003";
						}
					}
					else
					{
						text = "Windows XP";
					}
				}
				else
				{
					text = "Windows 2000";
				}
			}
			if (oSVersion.Version.Major == 6)
			{
				if (oSVersion.Version.Minor == 0)
				{
					text = "Windows Vista";
				}
				else if (oSVersion.Version.Minor != 1)
				{
					if (oSVersion.Version.Minor == 2)
					{
						text = "Windows 8";
					}
					else if (oSVersion.Version.Minor == 3)
					{
						text = "Windows 10";
					}
				}
				else
				{
					text = "Windows 7";
				}
			}
			if (oSVersion.Version.Major == 7)
			{
				if (oSVersion.Version.Minor == 0)
				{
					text = "Windows ??";
				}
				else if (oSVersion.Version.Minor == 1)
				{
					text = "Windows ??";
				}
				else if (oSVersion.Version.Minor != 2)
				{
					if (oSVersion.Version.Minor == 3)
					{
						text = "Windows ??";
					}
				}
				else
				{
					text = "Windows ??";
				}
			}
		}
		text2 = oSVersion.ServicePack.ToString();
		return $"OS Version : {text}\nService Pack : {text2} \n(major:{oSVersion.Version.Major}, Minor:{oSVersion.Version.Minor})";
	}

	private void VpvCxkXoJJVhtqTcGaTcuIWjjDht(object sender, EventArgs e)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Invalid comparison between Unknown and I4
		Labelchange("창모드화면 으로 게임을 시작합니다.");
		Process[] processesByName = Process.GetProcessesByName(linbin);
		if (processesByName.Length < linbinlength)
		{
			DialogResult val = MessageBox.Show("창모드를 선택 하셨습니다.\r\n확인버튼을 누르시면 게임이 시작 됩니다.\r\n", " Lineage client ver 3.1", (MessageBoxButtons)1, (MessageBoxIcon)64);
			if ((int)val == 1)
			{
				bool_ = true;
				mjPhJUxhocWGCXHBGrzFnXfCaqWL();
			}
		}
		else
		{
			Labelchange("더 이상 클라이언트를 실행할 수 없습니다.");
		}
	}

	private void AzzMGvpnuqXTvpinaxHWazSVpWnR(object sender, EventArgs e)
	{
		Labelchange("파워북 사이트로 이동합니다.");
		Process.Start("https://lineage.plaync.com/powerbook/index");
	}

	private void HdNjmpMNudafjiLfYISjdqerLAqjA(object sender, ElapsedEventArgs e)
	{
		Process[] processesByName = Process.GetProcessesByName(linbin);
		if (processesByName.Length == 0)
		{
			resChanger.changeRes(32);
		}
		xpNnpaKbldlEqBitOhekGqnXejDHA.Enabled = false;
	}

	private void yHclcMOPGguhbloRcpzPzPnjNfkH(object sender, ElapsedEventArgs e)
	{
		Process[] processesByName = Process.GetProcessesByName(linbin);
		if (processesByName.Length == 0)
		{
			Labelchange("게임을 진행 하시려면 '게임시작'을 누르십시오.");
		}
		xpNnpaKbldlEqBitOhekGqnXejDHA.Enabled = false;
	}

	private void eMQerzbRFixfnloYSMMXamaqLbjz(object sender, EventArgs e)
	{
		Process[] processes = Process.GetProcesses();
		Process[] array = processes;
		foreach (Process process in array)
		{
			string text = LoadPage5("engine");
			string[] array2 = text.Split(new char[1] { ',' });
			for (int j = 0; j < array2.Length; j++)
			{
				if (process.ProcessName.Contains(array2[j]))
				{
					EngineShutdown engineShutdown = new EngineShutdown();
					((Control)engineShutdown).Show();
					process.Kill();
				}
			}
		}
		Random random = new Random();
		((Control)gOeLlzGvWCezMGQbRBPInheEHoDiA).set_ForeColor(Color.FromArgb(random.Next(50, 250), random.Next(50, 250), 0));
		((Control)QefWKYgcJjaidBefCHvtswPGVyRpA).set_ForeColor(Color.FromArgb(random.Next(50, 250), random.Next(50, 250), 0));
	}

	public string splitParsing(string Data, string one, string two)
	{
		try
		{
			string pattern = "\\" + one.ToString() + "(?<splitdata>.*?)\\" + two.ToString();
			Regex regex = new Regex(pattern, RegexOptions.IgnoreCase | RegexOptions.Singleline);
			MatchCollection matchCollection = regex.Matches(Data);
			Match match = matchCollection[0];
			return match.Groups["splitData"].Value;
		}
		catch
		{
			return "";
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && hUHlHIVtIZNMyNATlFHUIjnUgWJBb != null)
		{
			hUHlHIVtIZNMyNATlFHUIjnUgWJBb.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void elGrDrgnJeFUoSEuIevkfWkCRVaIA()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Expected O, but got Unknown
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Expected O, but got Unknown
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Expected O, but got Unknown
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Expected O, but got Unknown
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Expected O, but got Unknown
		//IL_030c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0316: Expected O, but got Unknown
		//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c2: Expected O, but got Unknown
		//IL_03df: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e9: Expected O, but got Unknown
		//IL_040a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0414: Expected O, but got Unknown
		//IL_04b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bf: Expected O, but got Unknown
		//IL_04dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e6: Expected O, but got Unknown
		//IL_0507: Unknown result type (might be due to invalid IL or missing references)
		//IL_0511: Expected O, but got Unknown
		//IL_05b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bc: Expected O, but got Unknown
		//IL_05d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e3: Expected O, but got Unknown
		//IL_0604: Unknown result type (might be due to invalid IL or missing references)
		//IL_060e: Expected O, but got Unknown
		//IL_06af: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b9: Expected O, but got Unknown
		//IL_06d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e0: Expected O, but got Unknown
		//IL_0701: Unknown result type (might be due to invalid IL or missing references)
		//IL_070b: Expected O, but got Unknown
		//IL_07ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b6: Expected O, but got Unknown
		//IL_07d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07dd: Expected O, but got Unknown
		//IL_07fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0808: Expected O, but got Unknown
		//IL_08a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b0: Expected O, but got Unknown
		//IL_08cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d7: Expected O, but got Unknown
		//IL_08f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0902: Expected O, but got Unknown
		//IL_09a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b0: Expected O, but got Unknown
		//IL_09cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d7: Expected O, but got Unknown
		//IL_09f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a02: Expected O, but got Unknown
		//IL_0aa4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aae: Expected O, but got Unknown
		//IL_0acb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad5: Expected O, but got Unknown
		//IL_0af6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b00: Expected O, but got Unknown
		//IL_0ba1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bab: Expected O, but got Unknown
		//IL_0bc8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd2: Expected O, but got Unknown
		//IL_0bf3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bfd: Expected O, but got Unknown
		//IL_0ce5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cef: Expected O, but got Unknown
		//IL_0cfc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d06: Expected O, but got Unknown
		//IL_0d57: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d61: Expected O, but got Unknown
		//IL_0e6d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e77: Expected O, but got Unknown
		//IL_0eb9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec3: Expected O, but got Unknown
		//IL_0ecb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed5: Expected O, but got Unknown
		hUHlHIVtIZNMyNATlFHUIjnUgWJBb = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		DEuhSXIQsqNbiIynbJPcbvGpReRHb = new PictureBox();
		QefWKYgcJjaidBefCHvtswPGVyRpA = new Label();
		OEVIRlGPGxHoSJmWzScfwzBUUteh = new ToolTip(hUHlHIVtIZNMyNATlFHUIjnUgWJBb);
		EXSJXVqPzhLNkdDMDonKVTrUBVHg = new Buttoncontroller();
		FLKfXhxpqKAsutglECUXFtngjOngb = new Buttoncontroller();
		TzyAutPizdXHkTKlthbxNmPTBpxfA = new Buttoncontroller();
		AcrKWAcOvvxSVpjbTvlbugvmTQiL = new Buttoncontroller();
		IHxTpnQSMiuThvVsqrwTAtXZeSzJ = new Buttoncontroller();
		mvLopefPYXEaSmClJDEgEtmHzyRF = new Buttoncontroller();
		okAlEpSBZnUeOnlDpCwOmLKMEbZL = new Buttoncontroller();
		cNxsQTxWISSmvOKyPwHCfXJJGJLO = new Buttoncontroller();
		alqQjqxQkpitpgcoXiCbJstUZRePA = new Buttoncontroller();
		JGvNFIBEyAenNDfJzdBhLpDungHP = new Buttoncontroller();
		gOeLlzGvWCezMGQbRBPInheEHoDiA = new Label();
		pjctolIhaJEcTMLwElqNyCLTyPSk = new Timer(hUHlHIVtIZNMyNATlFHUIjnUgWJBb);
		((ISupportInitialize)DEuhSXIQsqNbiIynbJPcbvGpReRHb).BeginInit();
		((ISupportInitialize)EXSJXVqPzhLNkdDMDonKVTrUBVHg).BeginInit();
		((ISupportInitialize)FLKfXhxpqKAsutglECUXFtngjOngb).BeginInit();
		((ISupportInitialize)TzyAutPizdXHkTKlthbxNmPTBpxfA).BeginInit();
		((ISupportInitialize)AcrKWAcOvvxSVpjbTvlbugvmTQiL).BeginInit();
		((ISupportInitialize)IHxTpnQSMiuThvVsqrwTAtXZeSzJ).BeginInit();
		((ISupportInitialize)mvLopefPYXEaSmClJDEgEtmHzyRF).BeginInit();
		((ISupportInitialize)okAlEpSBZnUeOnlDpCwOmLKMEbZL).BeginInit();
		((ISupportInitialize)cNxsQTxWISSmvOKyPwHCfXJJGJLO).BeginInit();
		((ISupportInitialize)alqQjqxQkpitpgcoXiCbJstUZRePA).BeginInit();
		((ISupportInitialize)JGvNFIBEyAenNDfJzdBhLpDungHP).BeginInit();
		((Control)this).SuspendLayout();
		((Control)DEuhSXIQsqNbiIynbJPcbvGpReRHb).set_BackColor(Color.Black);
		((Control)DEuhSXIQsqNbiIynbJPcbvGpReRHb).set_BackgroundImageLayout((ImageLayout)0);
		((Control)DEuhSXIQsqNbiIynbJPcbvGpReRHb).set_Location(new Point(31, 86));
		((Control)DEuhSXIQsqNbiIynbJPcbvGpReRHb).set_Name("pictureBox1");
		((Control)DEuhSXIQsqNbiIynbJPcbvGpReRHb).set_Size(new Size(431, 225));
		DEuhSXIQsqNbiIynbJPcbvGpReRHb.set_SizeMode((PictureBoxSizeMode)1);
		DEuhSXIQsqNbiIynbJPcbvGpReRHb.set_TabIndex(0);
		DEuhSXIQsqNbiIynbJPcbvGpReRHb.set_TabStop(false);
		((Control)DEuhSXIQsqNbiIynbJPcbvGpReRHb).add_MouseDown(new MouseEventHandler(MfoTpoIKLoWQSkxLtqTxCAGZvf));
		((Control)DEuhSXIQsqNbiIynbJPcbvGpReRHb).add_MouseMove(new MouseEventHandler(sKBezVtacjJihxiosirRBBClrvPC));
		((Control)QefWKYgcJjaidBefCHvtswPGVyRpA).set_BackColor(Color.Transparent);
		((Control)QefWKYgcJjaidBefCHvtswPGVyRpA).set_Font(new Font("돋움체", 7.8f));
		((Control)QefWKYgcJjaidBefCHvtswPGVyRpA).set_ForeColor(Color.White);
		((Control)QefWKYgcJjaidBefCHvtswPGVyRpA).set_Location(new Point(75, 320));
		((Control)QefWKYgcJjaidBefCHvtswPGVyRpA).set_Name("label1");
		((Control)QefWKYgcJjaidBefCHvtswPGVyRpA).set_Size(new Size(451, 23));
		((Control)QefWKYgcJjaidBefCHvtswPGVyRpA).set_TabIndex(9);
		((Control)QefWKYgcJjaidBefCHvtswPGVyRpA).set_Text("준비중.");
		QefWKYgcJjaidBefCHvtswPGVyRpA.set_TextAlign((ContentAlignment)32);
		((Control)EXSJXVqPzhLNkdDMDonKVTrUBVHg).set_BackColor(Color.Transparent);
		((Control)EXSJXVqPzhLNkdDMDonKVTrUBVHg).set_BackgroundImage((Image)componentResourceManager.GetObject("buttoncontroller10.BackgroundImage"));
		((Control)EXSJXVqPzhLNkdDMDonKVTrUBVHg).set_BackgroundImageLayout((ImageLayout)0);
		EXSJXVqPzhLNkdDMDonKVTrUBVHg.ButtonImage = (Image)componentResourceManager.GetObject("buttoncontroller10.ButtonImage");
		((Control)EXSJXVqPzhLNkdDMDonKVTrUBVHg).set_Cursor(Cursors.get_Hand());
		EXSJXVqPzhLNkdDMDonKVTrUBVHg.HoverImage = (Image)componentResourceManager.GetObject("buttoncontroller10.HoverImage");
		((Control)EXSJXVqPzhLNkdDMDonKVTrUBVHg).set_Location(new Point(179, 47));
		((Control)EXSJXVqPzhLNkdDMDonKVTrUBVHg).set_Name("buttoncontroller10");
		((Control)EXSJXVqPzhLNkdDMDonKVTrUBVHg).set_Size(new Size(75, 21));
		((PictureBox)EXSJXVqPzhLNkdDMDonKVTrUBVHg).set_TabIndex(11);
		((PictureBox)EXSJXVqPzhLNkdDMDonKVTrUBVHg).set_TabStop(false);
		OEVIRlGPGxHoSJmWzScfwzBUUteh.SetToolTip((Control)(object)EXSJXVqPzhLNkdDMDonKVTrUBVHg, "창모드로 게임 실행하기");
		((Control)EXSJXVqPzhLNkdDMDonKVTrUBVHg).add_Click((EventHandler)VpvCxkXoJJVhtqTcGaTcuIWjjDht);
		((Control)FLKfXhxpqKAsutglECUXFtngjOngb).set_BackColor(Color.Gray);
		((Control)FLKfXhxpqKAsutglECUXFtngjOngb).set_BackgroundImage((Image)componentResourceManager.GetObject("buttoncontroller7.BackgroundImage"));
		((Control)FLKfXhxpqKAsutglECUXFtngjOngb).set_BackgroundImageLayout((ImageLayout)0);
		FLKfXhxpqKAsutglECUXFtngjOngb.ButtonImage = (Image)componentResourceManager.GetObject("buttoncontroller7.ButtonImage");
		((Control)FLKfXhxpqKAsutglECUXFtngjOngb).set_Cursor(Cursors.get_Hand());
		FLKfXhxpqKAsutglECUXFtngjOngb.HoverImage = (Image)componentResourceManager.GetObject("buttoncontroller7.HoverImage");
		((Control)FLKfXhxpqKAsutglECUXFtngjOngb).set_Location(new Point(695, 36));
		((Control)FLKfXhxpqKAsutglECUXFtngjOngb).set_Name("buttoncontroller7");
		((Control)FLKfXhxpqKAsutglECUXFtngjOngb).set_Size(new Size(16, 16));
		((PictureBox)FLKfXhxpqKAsutglECUXFtngjOngb).set_TabIndex(7);
		((PictureBox)FLKfXhxpqKAsutglECUXFtngjOngb).set_TabStop(false);
		OEVIRlGPGxHoSJmWzScfwzBUUteh.SetToolTip((Control)(object)FLKfXhxpqKAsutglECUXFtngjOngb, "종료 버튼");
		((Control)FLKfXhxpqKAsutglECUXFtngjOngb).add_Click((EventHandler)YcagiRDTbEAkEDiwSdkesFaipizxA);
		((Control)TzyAutPizdXHkTKlthbxNmPTBpxfA).set_BackColor(Color.Transparent);
		((Control)TzyAutPizdXHkTKlthbxNmPTBpxfA).set_BackgroundImage((Image)componentResourceManager.GetObject("buttoncontroller6.BackgroundImage"));
		((Control)TzyAutPizdXHkTKlthbxNmPTBpxfA).set_BackgroundImageLayout((ImageLayout)0);
		TzyAutPizdXHkTKlthbxNmPTBpxfA.ButtonImage = (Image)componentResourceManager.GetObject("buttoncontroller6.ButtonImage");
		((Control)TzyAutPizdXHkTKlthbxNmPTBpxfA).set_Cursor(Cursors.get_Hand());
		TzyAutPizdXHkTKlthbxNmPTBpxfA.HoverImage = (Image)componentResourceManager.GetObject("buttoncontroller6.HoverImage");
		((Control)TzyAutPizdXHkTKlthbxNmPTBpxfA).set_Location(new Point(673, 36));
		((Control)TzyAutPizdXHkTKlthbxNmPTBpxfA).set_Name("buttoncontroller6");
		((Control)TzyAutPizdXHkTKlthbxNmPTBpxfA).set_Size(new Size(16, 16));
		((PictureBox)TzyAutPizdXHkTKlthbxNmPTBpxfA).set_TabIndex(6);
		((PictureBox)TzyAutPizdXHkTKlthbxNmPTBpxfA).set_TabStop(false);
		OEVIRlGPGxHoSJmWzScfwzBUUteh.SetToolTip((Control)(object)TzyAutPizdXHkTKlthbxNmPTBpxfA, "내리기 버튼");
		((Control)TzyAutPizdXHkTKlthbxNmPTBpxfA).add_Click((EventHandler)SRAdRmCgylvoJQzfRrXrejroqCHYA);
		((Control)AcrKWAcOvvxSVpjbTvlbugvmTQiL).set_BackColor(Color.Transparent);
		((Control)AcrKWAcOvvxSVpjbTvlbugvmTQiL).set_BackgroundImage((Image)componentResourceManager.GetObject("buttoncontroller5.BackgroundImage"));
		((Control)AcrKWAcOvvxSVpjbTvlbugvmTQiL).set_BackgroundImageLayout((ImageLayout)0);
		AcrKWAcOvvxSVpjbTvlbugvmTQiL.ButtonImage = (Image)componentResourceManager.GetObject("buttoncontroller5.ButtonImage");
		((Control)AcrKWAcOvvxSVpjbTvlbugvmTQiL).set_Cursor(Cursors.get_Hand());
		AcrKWAcOvvxSVpjbTvlbugvmTQiL.HoverImage = (Image)componentResourceManager.GetObject("buttoncontroller5.HoverImage");
		((Control)AcrKWAcOvvxSVpjbTvlbugvmTQiL).set_Location(new Point(495, 49));
		((Control)AcrKWAcOvvxSVpjbTvlbugvmTQiL).set_Name("buttoncontroller5");
		((Control)AcrKWAcOvvxSVpjbTvlbugvmTQiL).set_Size(new Size(65, 18));
		((PictureBox)AcrKWAcOvvxSVpjbTvlbugvmTQiL).set_TabIndex(5);
		((PictureBox)AcrKWAcOvvxSVpjbTvlbugvmTQiL).set_TabStop(false);
		OEVIRlGPGxHoSJmWzScfwzBUUteh.SetToolTip((Control)(object)AcrKWAcOvvxSVpjbTvlbugvmTQiL, "패치 실행하기");
		((Control)AcrKWAcOvvxSVpjbTvlbugvmTQiL).add_Click((EventHandler)CljgYJnyNfJJAioxfkPfLyiBRDkc);
		((Control)IHxTpnQSMiuThvVsqrwTAtXZeSzJ).set_BackColor(Color.Transparent);
		((Control)IHxTpnQSMiuThvVsqrwTAtXZeSzJ).set_BackgroundImage((Image)componentResourceManager.GetObject("buttoncontroller4.BackgroundImage"));
		((Control)IHxTpnQSMiuThvVsqrwTAtXZeSzJ).set_BackgroundImageLayout((ImageLayout)0);
		IHxTpnQSMiuThvVsqrwTAtXZeSzJ.ButtonImage = (Image)componentResourceManager.GetObject("buttoncontroller4.ButtonImage");
		((Control)IHxTpnQSMiuThvVsqrwTAtXZeSzJ).set_Cursor(Cursors.get_Hand());
		IHxTpnQSMiuThvVsqrwTAtXZeSzJ.HoverImage = (Image)componentResourceManager.GetObject("buttoncontroller4.HoverImage");
		((Control)IHxTpnQSMiuThvVsqrwTAtXZeSzJ).set_Location(new Point(285, 49));
		((Control)IHxTpnQSMiuThvVsqrwTAtXZeSzJ).set_Name("buttoncontroller4");
		((Control)IHxTpnQSMiuThvVsqrwTAtXZeSzJ).set_Size(new Size(65, 18));
		((PictureBox)IHxTpnQSMiuThvVsqrwTAtXZeSzJ).set_TabIndex(4);
		((PictureBox)IHxTpnQSMiuThvVsqrwTAtXZeSzJ).set_TabStop(false);
		OEVIRlGPGxHoSJmWzScfwzBUUteh.SetToolTip((Control)(object)IHxTpnQSMiuThvVsqrwTAtXZeSzJ, "패스트핑 바로가기");
		((Control)IHxTpnQSMiuThvVsqrwTAtXZeSzJ).add_Click((EventHandler)mCodRYmDQPfVwBpGZqeSjEOyZJXH);
		((Control)mvLopefPYXEaSmClJDEgEtmHzyRF).set_BackColor(Color.Transparent);
		((Control)mvLopefPYXEaSmClJDEgEtmHzyRF).set_BackgroundImage((Image)componentResourceManager.GetObject("buttoncontroller2.BackgroundImage"));
		((Control)mvLopefPYXEaSmClJDEgEtmHzyRF).set_BackgroundImageLayout((ImageLayout)0);
		mvLopefPYXEaSmClJDEgEtmHzyRF.ButtonImage = (Image)componentResourceManager.GetObject("buttoncontroller2.ButtonImage");
		((Control)mvLopefPYXEaSmClJDEgEtmHzyRF).set_Cursor(Cursors.get_Hand());
		mvLopefPYXEaSmClJDEgEtmHzyRF.HoverImage = (Image)componentResourceManager.GetObject("buttoncontroller2.HoverImage");
		((Control)mvLopefPYXEaSmClJDEgEtmHzyRF).set_Location(new Point(79, 49));
		((Control)mvLopefPYXEaSmClJDEgEtmHzyRF).set_Name("buttoncontroller2");
		((Control)mvLopefPYXEaSmClJDEgEtmHzyRF).set_Size(new Size(72, 18));
		((PictureBox)mvLopefPYXEaSmClJDEgEtmHzyRF).set_TabIndex(2);
		((PictureBox)mvLopefPYXEaSmClJDEgEtmHzyRF).set_TabStop(false);
		OEVIRlGPGxHoSJmWzScfwzBUUteh.SetToolTip((Control)(object)mvLopefPYXEaSmClJDEgEtmHzyRF, "홈페이지 바로가기");
		((Control)mvLopefPYXEaSmClJDEgEtmHzyRF).add_Click((EventHandler)VqsZxCACbmsbUzGYoVMXGAvFKejg);
		((Control)okAlEpSBZnUeOnlDpCwOmLKMEbZL).set_BackColor(Color.Transparent);
		((Control)okAlEpSBZnUeOnlDpCwOmLKMEbZL).set_BackgroundImage((Image)componentResourceManager.GetObject("buttoncontroller1.BackgroundImage"));
		((Control)okAlEpSBZnUeOnlDpCwOmLKMEbZL).set_BackgroundImageLayout((ImageLayout)0);
		okAlEpSBZnUeOnlDpCwOmLKMEbZL.ButtonImage = (Image)componentResourceManager.GetObject("buttoncontroller1.ButtonImage");
		((Control)okAlEpSBZnUeOnlDpCwOmLKMEbZL).set_Cursor(Cursors.get_Hand());
		okAlEpSBZnUeOnlDpCwOmLKMEbZL.HoverImage = (Image)componentResourceManager.GetObject("buttoncontroller1.HoverImage");
		((Control)okAlEpSBZnUeOnlDpCwOmLKMEbZL).set_Location(new Point(552, 314));
		((Control)okAlEpSBZnUeOnlDpCwOmLKMEbZL).set_Name("buttoncontroller1");
		((Control)okAlEpSBZnUeOnlDpCwOmLKMEbZL).set_Size(new Size(106, 106));
		((PictureBox)okAlEpSBZnUeOnlDpCwOmLKMEbZL).set_TabIndex(1);
		((PictureBox)okAlEpSBZnUeOnlDpCwOmLKMEbZL).set_TabStop(false);
		OEVIRlGPGxHoSJmWzScfwzBUUteh.SetToolTip((Control)(object)okAlEpSBZnUeOnlDpCwOmLKMEbZL, "전체화면으로 게임 실행하기");
		((Control)okAlEpSBZnUeOnlDpCwOmLKMEbZL).add_Click((EventHandler)dmvebJCIlplywMnLhlqffzWZuYVRA);
		((Control)cNxsQTxWISSmvOKyPwHCfXJJGJLO).set_BackColor(Color.Transparent);
		((Control)cNxsQTxWISSmvOKyPwHCfXJJGJLO).set_BackgroundImage((Image)componentResourceManager.GetObject("buttoncontroller9.BackgroundImage"));
		((Control)cNxsQTxWISSmvOKyPwHCfXJJGJLO).set_BackgroundImageLayout((ImageLayout)0);
		cNxsQTxWISSmvOKyPwHCfXJJGJLO.ButtonImage = (Image)componentResourceManager.GetObject("buttoncontroller9.ButtonImage");
		((Control)cNxsQTxWISSmvOKyPwHCfXJJGJLO).set_Cursor(Cursors.get_Hand());
		cNxsQTxWISSmvOKyPwHCfXJJGJLO.HoverImage = (Image)componentResourceManager.GetObject("buttoncontroller9.HoverImage");
		((Control)cNxsQTxWISSmvOKyPwHCfXJJGJLO).set_Location(new Point(582, 49));
		((Control)cNxsQTxWISSmvOKyPwHCfXJJGJLO).set_Name("buttoncontroller9");
		((Control)cNxsQTxWISSmvOKyPwHCfXJJGJLO).set_Size(new Size(72, 18));
		((PictureBox)cNxsQTxWISSmvOKyPwHCfXJJGJLO).set_TabIndex(10);
		((PictureBox)cNxsQTxWISSmvOKyPwHCfXJJGJLO).set_TabStop(false);
		OEVIRlGPGxHoSJmWzScfwzBUUteh.SetToolTip((Control)(object)cNxsQTxWISSmvOKyPwHCfXJJGJLO, "파워북 바로가기");
		((Control)cNxsQTxWISSmvOKyPwHCfXJJGJLO).add_Click((EventHandler)AzzMGvpnuqXTvpinaxHWazSVpWnR);
		((Control)alqQjqxQkpitpgcoXiCbJstUZRePA).set_BackColor(Color.Transparent);
		((Control)alqQjqxQkpitpgcoXiCbJstUZRePA).set_BackgroundImage((Image)componentResourceManager.GetObject("buttoncontroller8.BackgroundImage"));
		((Control)alqQjqxQkpitpgcoXiCbJstUZRePA).set_BackgroundImageLayout((ImageLayout)0);
		alqQjqxQkpitpgcoXiCbJstUZRePA.ButtonImage = (Image)componentResourceManager.GetObject("buttoncontroller8.ButtonImage");
		((Control)alqQjqxQkpitpgcoXiCbJstUZRePA).set_Cursor(Cursors.get_Hand());
		alqQjqxQkpitpgcoXiCbJstUZRePA.HoverImage = (Image)componentResourceManager.GetObject("buttoncontroller8.HoverImage");
		((Control)alqQjqxQkpitpgcoXiCbJstUZRePA).set_Location(new Point(397, 49));
		((Control)alqQjqxQkpitpgcoXiCbJstUZRePA).set_Name("buttoncontroller8");
		((Control)alqQjqxQkpitpgcoXiCbJstUZRePA).set_Size(new Size(65, 18));
		((PictureBox)alqQjqxQkpitpgcoXiCbJstUZRePA).set_TabIndex(8);
		((PictureBox)alqQjqxQkpitpgcoXiCbJstUZRePA).set_TabStop(false);
		OEVIRlGPGxHoSJmWzScfwzBUUteh.SetToolTip((Control)(object)alqQjqxQkpitpgcoXiCbJstUZRePA, "음악 실행하기");
		((Control)alqQjqxQkpitpgcoXiCbJstUZRePA).add_Click((EventHandler)JVGbSKHfTMcPPcooNPvfYsOTDImjb);
		((Control)JGvNFIBEyAenNDfJzdBhLpDungHP).set_BackColor(Color.Transparent);
		((Control)JGvNFIBEyAenNDfJzdBhLpDungHP).set_BackgroundImage((Image)componentResourceManager.GetObject("buttoncontroller3.BackgroundImage"));
		((Control)JGvNFIBEyAenNDfJzdBhLpDungHP).set_BackgroundImageLayout((ImageLayout)0);
		JGvNFIBEyAenNDfJzdBhLpDungHP.ButtonImage = (Image)componentResourceManager.GetObject("buttoncontroller3.ButtonImage");
		((Control)JGvNFIBEyAenNDfJzdBhLpDungHP).set_Cursor(Cursors.get_Hand());
		JGvNFIBEyAenNDfJzdBhLpDungHP.HoverImage = (Image)componentResourceManager.GetObject("buttoncontroller3.HoverImage");
		((Control)JGvNFIBEyAenNDfJzdBhLpDungHP).set_Location(new Point(767, 442));
		((Control)JGvNFIBEyAenNDfJzdBhLpDungHP).set_Name("buttoncontroller3");
		((Control)JGvNFIBEyAenNDfJzdBhLpDungHP).set_Size(new Size(124, 55));
		((PictureBox)JGvNFIBEyAenNDfJzdBhLpDungHP).set_TabIndex(3);
		((PictureBox)JGvNFIBEyAenNDfJzdBhLpDungHP).set_TabStop(false);
		((Control)JGvNFIBEyAenNDfJzdBhLpDungHP).add_Click((EventHandler)dkAzUvZgBeErOYSAwsJMTVkGqEsm);
		((Control)gOeLlzGvWCezMGQbRBPInheEHoDiA).set_BackColor(Color.Transparent);
		((Control)gOeLlzGvWCezMGQbRBPInheEHoDiA).set_ForeColor(Color.White);
		((Control)gOeLlzGvWCezMGQbRBPInheEHoDiA).set_Location(new Point(468, 121));
		((Control)gOeLlzGvWCezMGQbRBPInheEHoDiA).set_Name("label2");
		((Control)gOeLlzGvWCezMGQbRBPInheEHoDiA).set_Size(new Size(214, 177));
		((Control)gOeLlzGvWCezMGQbRBPInheEHoDiA).set_TabIndex(12);
		((Control)gOeLlzGvWCezMGQbRBPInheEHoDiA).add_MouseDown(new MouseEventHandler(MfoTpoIKLoWQSkxLtqTxCAGZvf));
		((Control)gOeLlzGvWCezMGQbRBPInheEHoDiA).add_MouseMove(new MouseEventHandler(sKBezVtacjJihxiosirRBBClrvPC));
		pjctolIhaJEcTMLwElqNyCLTyPSk.set_Enabled(true);
		pjctolIhaJEcTMLwElqNyCLTyPSk.set_Interval(1600);
		pjctolIhaJEcTMLwElqNyCLTyPSk.add_Tick((EventHandler)eMQerzbRFixfnloYSMMXamaqLbjz);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)0);
		((Control)this).set_BackColor(Color.DimGray);
		((Control)this).set_BackgroundImage((Image)componentResourceManager.GetObject("$this.BackgroundImage"));
		((Control)this).set_BackgroundImageLayout((ImageLayout)0);
		((Form)this).set_ClientSize(new Size(743, 448));
		((Control)this).get_Controls().Add((Control)(object)gOeLlzGvWCezMGQbRBPInheEHoDiA);
		((Control)this).get_Controls().Add((Control)(object)EXSJXVqPzhLNkdDMDonKVTrUBVHg);
		((Control)this).get_Controls().Add((Control)(object)cNxsQTxWISSmvOKyPwHCfXJJGJLO);
		((Control)this).get_Controls().Add((Control)(object)QefWKYgcJjaidBefCHvtswPGVyRpA);
		((Control)this).get_Controls().Add((Control)(object)alqQjqxQkpitpgcoXiCbJstUZRePA);
		((Control)this).get_Controls().Add((Control)(object)FLKfXhxpqKAsutglECUXFtngjOngb);
		((Control)this).get_Controls().Add((Control)(object)TzyAutPizdXHkTKlthbxNmPTBpxfA);
		((Control)this).get_Controls().Add((Control)(object)AcrKWAcOvvxSVpjbTvlbugvmTQiL);
		((Control)this).get_Controls().Add((Control)(object)IHxTpnQSMiuThvVsqrwTAtXZeSzJ);
		((Control)this).get_Controls().Add((Control)(object)JGvNFIBEyAenNDfJzdBhLpDungHP);
		((Control)this).get_Controls().Add((Control)(object)mvLopefPYXEaSmClJDEgEtmHzyRF);
		((Control)this).get_Controls().Add((Control)(object)okAlEpSBZnUeOnlDpCwOmLKMEbZL);
		((Control)this).get_Controls().Add((Control)(object)DEuhSXIQsqNbiIynbJPcbvGpReRHb);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Form1");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Lineage");
		((Form)this).set_TransparencyKey(Color.DimGray);
		((Form)this).add_Load((EventHandler)IfBZYpJQOMXHQaFRZIvzNQPXuqWM);
		((Control)this).add_MouseDown(new MouseEventHandler(MfoTpoIKLoWQSkxLtqTxCAGZvf));
		((Control)this).add_MouseMove(new MouseEventHandler(sKBezVtacjJihxiosirRBBClrvPC));
		((ISupportInitialize)DEuhSXIQsqNbiIynbJPcbvGpReRHb).EndInit();
		((ISupportInitialize)EXSJXVqPzhLNkdDMDonKVTrUBVHg).EndInit();
		((ISupportInitialize)FLKfXhxpqKAsutglECUXFtngjOngb).EndInit();
		((ISupportInitialize)TzyAutPizdXHkTKlthbxNmPTBpxfA).EndInit();
		((ISupportInitialize)AcrKWAcOvvxSVpjbTvlbugvmTQiL).EndInit();
		((ISupportInitialize)IHxTpnQSMiuThvVsqrwTAtXZeSzJ).EndInit();
		((ISupportInitialize)mvLopefPYXEaSmClJDEgEtmHzyRF).EndInit();
		((ISupportInitialize)okAlEpSBZnUeOnlDpCwOmLKMEbZL).EndInit();
		((ISupportInitialize)cNxsQTxWISSmvOKyPwHCfXJJGJLO).EndInit();
		((ISupportInitialize)alqQjqxQkpitpgcoXiCbJstUZRePA).EndInit();
		((ISupportInitialize)JGvNFIBEyAenNDfJzdBhLpDungHP).EndInit();
		((Control)this).ResumeLayout(false);
	}
}
