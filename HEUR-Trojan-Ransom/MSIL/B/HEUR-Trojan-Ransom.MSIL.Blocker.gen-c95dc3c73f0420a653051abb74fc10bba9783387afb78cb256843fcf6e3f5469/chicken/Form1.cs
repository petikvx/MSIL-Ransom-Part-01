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
	private NamedPipeServerStream lqjvCfbBoecaaSkjyuzyLCpqcTraA;

	private static object nlWaQIYPViinnrUVTOlnZgavtMvy = new object();

	private static object oIJTqVLGsqcXgEOjxXPDfIqzINJh = new object();

	private static System.Timers.Timer uCNVwHcClYwousuUFpiJubcOhOOt;

	private static System.Timers.Timer CGzuxuNRXPjBMkODIxLWvjAxfmsaA;

	public static bool tostart = true;

	public static bool playSound = false;

	public static bool PatchButton = true;

	public static bool bool_ = false;

	private Point CjrzXUalgvmQabphQClrjnVBLEhjb = new Point(0, 0);

	public static string mrmessage = " 안내";

	public static string lineagecfg = "lineage.cfg";

	public static string linbin = "lin.bin";

	public static string dll = "z3dcom154.dll";

	public static string PackingLibrary = "PackingLibraryWrapper-Win32-Release.dll";

	public static int linbinlength = 1;

	public static Form1 _main;

	[CompilerGenerated]
	private bool tAeZpFPChFCFXSjzujftGzIazimK;

	private static ArrayList NFDuvXDPBvvORmMRNgeSkIZOEFCab = new ArrayList();

	private const int OMBjIxDuBNcGobbeFESRHLfYQOWaA = 1024;

	private static string sCvQPMbLjNChQbBxuLfoVDBZYyMfA;

	private static string IdujzdcUYbkwJDlnBrQSJNpQSVmnb = "test.txt";

	private const int mzdqVAMDUzRDcehsdiIZTgdizsWg = 9;

	private IContainer kIRxdvplOwoJsmagcKCtTAqXYlCQ;

	private PictureBox UpesJsowGRHAcNfGaCDBJLBwXvYf;

	private Buttoncontroller deQVXIyCRWtsCCsmeDHfkSJVqpIfA;

	private Buttoncontroller hHLQOZVlWoReUHZCUQULuUvSNUKM;

	private Buttoncontroller QRhFtpvhwjCEResawCSOjsCjdFYDA;

	private Buttoncontroller HnvVpWsOCBrCtOIHjdVkyOECRoeg;

	private Buttoncontroller LUhOmdCpvCpHJQqAGjyYDSozSmtMA;

	private Buttoncontroller MJyISYbldMwtgeSMkquOrIMKOIuv;

	private Buttoncontroller OuKhkYNzojOLqMtMZBzcHrarrQch;

	private Buttoncontroller xSoDAFZYkGJMbNaVCZVICWuHaLpI;

	private Label XJdmepMaRYKlbXjQBhsAOOWHILEQ;

	private ToolTip TQLNiKoaWKElGKylcuDAfWMJGztmA;

	private Buttoncontroller zttyTiXGZhUQnzXTWIhsPYFSaWuc;

	private Buttoncontroller PqGRpsIptQFxgMNhQgptxXsDcgMw;

	private Label vccFbAoUChBCCloCAEvjNGzFTzWI;

	private Timer kxeYXQeMsmqcZftZFgjuUgWShLTR;

	public bool _isrun
	{
		[CompilerGenerated]
		get
		{
			return tAeZpFPChFCFXSjzujftGzIazimK;
		}
		[CompilerGenerated]
		set
		{
			tAeZpFPChFCFXSjzujftGzIazimK = value;
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
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		tSSxvWKRPTkncrJVVkMRgnrXomxK();
		((Form)this).add_FormClosing(new FormClosingEventHandler(WmMQQObgWKvkVUfPQEprViJnYhHE));
	}

	protected override void OnLoad(EventArgs e)
	{
		Thread.Sleep(500);
		UpesJsowGRHAcNfGaCDBJLBwXvYf.set_ImageLocation("MrImage.gif");
		((Form)this).OnLoad(e);
	}

	private void LXROnCfzIjOtWDGqGgyAhzOQIJHz(object sender, EventArgs e)
	{
		deQVXIyCRWtsCCsmeDHfkSJVqpIfA.init();
		hHLQOZVlWoReUHZCUQULuUvSNUKM.init();
		QRhFtpvhwjCEResawCSOjsCjdFYDA.init();
		HnvVpWsOCBrCtOIHjdVkyOECRoeg.init();
		LUhOmdCpvCpHJQqAGjyYDSozSmtMA.init();
		MJyISYbldMwtgeSMkquOrIMKOIuv.init();
		OuKhkYNzojOLqMtMZBzcHrarrQch.init();
		xSoDAFZYkGJMbNaVCZVICWuHaLpI.init();
		zttyTiXGZhUQnzXTWIhsPYFSaWuc.init();
		PqGRpsIptQFxgMNhQgptxXsDcgMw.init();
		JgyzQxaTzuRVocubFxrYmJFGcWRaA();
		zceUkaQRcFHmXGgHpkBlSRUvBNWqA();
		uCNVwHcClYwousuUFpiJubcOhOOt = new System.Timers.Timer(1000.0);
		uCNVwHcClYwousuUFpiJubcOhOOt.Elapsed += WsBaCUenoOqTdXDARVPISMpunXpk;
		uCNVwHcClYwousuUFpiJubcOhOOt.Enabled = false;
		CGzuxuNRXPjBMkODIxLWvjAxfmsaA = new System.Timers.Timer(3000.0);
		CGzuxuNRXPjBMkODIxLWvjAxfmsaA.Elapsed += lueLTdwmCRHUbaGaxSeoEBcEgyjCc;
		CGzuxuNRXPjBMkODIxLWvjAxfmsaA.Enabled = false;
	}

	private void zceUkaQRcFHmXGgHpkBlSRUvBNWqA()
	{
		((Control)deQVXIyCRWtsCCsmeDHfkSJVqpIfA).set_BackColor(Color.Transparent);
		((Control)hHLQOZVlWoReUHZCUQULuUvSNUKM).set_BackColor(Color.Transparent);
		((Control)QRhFtpvhwjCEResawCSOjsCjdFYDA).set_BackColor(Color.Transparent);
		((Control)HnvVpWsOCBrCtOIHjdVkyOECRoeg).set_BackColor(Color.Transparent);
		((Control)LUhOmdCpvCpHJQqAGjyYDSozSmtMA).set_BackColor(Color.Transparent);
		((Control)MJyISYbldMwtgeSMkquOrIMKOIuv).set_BackColor(Color.Transparent);
		((Control)OuKhkYNzojOLqMtMZBzcHrarrQch).set_BackColor(Color.Transparent);
		((Control)xSoDAFZYkGJMbNaVCZVICWuHaLpI).set_BackColor(Color.Transparent);
		((Control)zttyTiXGZhUQnzXTWIhsPYFSaWuc).set_BackColor(Color.Transparent);
		((Control)PqGRpsIptQFxgMNhQgptxXsDcgMw).set_BackColor(Color.Transparent);
		Labelchange("게임을 진행 하시려면 '게임시작'을 누르십시오.");
		Labelchange2(ExrUtrGIrVegUboRfrYDiddupjgeA("Notice"));
		Console.WriteLine(ExrUtrGIrVegUboRfrYDiddupjgeA("Notice"));
	}

	public void Labelchange2(string ment)
	{
		((Control)vccFbAoUChBCCloCAEvjNGzFTzWI).set_Enabled(false);
		((Control)vccFbAoUChBCCloCAEvjNGzFTzWI).set_Text(ment);
		((Control)vccFbAoUChBCCloCAEvjNGzFTzWI).set_Enabled(true);
	}

	public void Labelchange(string ment)
	{
		((Control)XJdmepMaRYKlbXjQBhsAOOWHILEQ).set_Enabled(false);
		((Control)XJdmepMaRYKlbXjQBhsAOOWHILEQ).set_Text(ment);
		((Control)XJdmepMaRYKlbXjQBhsAOOWHILEQ).set_Enabled(true);
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

	private void nPOAGujVAfeUOcbXDuUZixNZRdeRb(object sender, MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		if ((int)e.get_Button() == 1048576)
		{
			CjrzXUalgvmQabphQClrjnVBLEhjb = new Point(-e.get_X(), -e.get_Y());
		}
	}

	private void zaBjAQAFwUGprbYRnhpkGtQJwOAGB(object sender, MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		if ((int)e.get_Button() == 1048576)
		{
			((Form)this).set_Location(new Point(((Form)this).get_Location().X + (CjrzXUalgvmQabphQClrjnVBLEhjb.X + e.get_X()), ((Form)this).get_Location().Y + (CjrzXUalgvmQabphQClrjnVBLEhjb.Y + e.get_Y())));
		}
	}

	private void yIyNtXdpvVzltvyvripsscwIQPtq()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			tgsxMlMaZDOPCtzFGaOqtPDKkIbE();
			Environment.Exit(0);
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message + "\r\n" + ex.StackTrace);
		}
	}

	private void tgsxMlMaZDOPCtzFGaOqtPDKkIbE()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Process[] processesByName = Process.GetProcessesByName(linbin);
			for (int i = 0; i < processesByName.Length; i++)
			{
				processesByName[i].Kill();
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message + "\r\n" + ex.StackTrace);
		}
	}

	public static void mrlogDelete()
	{
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		DirectoryInfo directoryInfo = new DirectoryInfo("C:\\Users\\User\\AppData\\Local\\Temp\\");
		try
		{
			if (string.IsNullOrWhiteSpace("*.log"))
			{
				FileInfo[] files = directoryInfo.GetFiles();
				for (int i = 0; i < files.Length; i++)
				{
					files[i].Delete();
				}
			}
			else
			{
				FileInfo[] files2 = directoryInfo.GetFiles("*.log");
				for (int j = 0; j < files2.Length; j++)
				{
					files2[j].Delete();
				}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message + "\r\n" + ex.StackTrace);
		}
	}

	private void tYRxGxHEoFbsOsvaRNemZbeXwVRX()
	{
		ThreadStart();
	}

	public static string LoadPage1(string type)
	{
		return Form2.webString.Replace(" ", "").Split(new string[1] { type + "]" }, StringSplitOptions.RemoveEmptyEntries)[1].Replace("[/", "").Split(new string[1] { "[/ip]" }, StringSplitOptions.RemoveEmptyEntries)[0];
	}

	public static string LoadPage2(string type)
	{
		return Form2.webString.Replace(" ", "").Split(new string[1] { type + "]" }, StringSplitOptions.RemoveEmptyEntries)[1].Replace("[/", "").Split(new string[1] { "[/port]" }, StringSplitOptions.RemoveEmptyEntries)[0];
	}

	private string tLTiSjNWzEPcqMOXODoUEgcPcmES(string type)
	{
		return Form2.webString.Replace(" ", "").Split(new string[1] { type + "]" }, StringSplitOptions.RemoveEmptyEntries)[1].Replace("[/", "").Split(new string[1] { "[/home]" }, StringSplitOptions.RemoveEmptyEntries)[0];
	}

	private string GRcTxnFFDPZCclUPVbjXoMIDNXdh(string type)
	{
		return Form2.webString.Replace(" ", "").Split(new string[1] { type + "]" }, StringSplitOptions.RemoveEmptyEntries)[1].Replace("[/", "").Split(new string[1] { "[/PowerBook]" }, StringSplitOptions.RemoveEmptyEntries)[0];
	}

	public static string LoadPage5(string type)
	{
		return Form2.webString.Replace(" ", "").Split(new string[1] { type + "]" }, StringSplitOptions.RemoveEmptyEntries)[1].Replace("[/", "").Split(new string[1] { "[/engine]" }, StringSplitOptions.RemoveEmptyEntries)[0];
	}

	private string ExrUtrGIrVegUboRfrYDiddupjgeA(string type)
	{
		return Form2.webString.Replace("<br />", "").Replace("</span>", "").Replace("nbsp;", "")
			.Split(new string[1] { "&lt;" + type + "&gt;" }, StringSplitOptions.RemoveEmptyEntries)[1].Replace("<br />", "").Replace("</span>", "").Replace("nbsp;", "")
			.Split(new string[1] { "&lt;/" + type + "&gt;" }, StringSplitOptions.RemoveEmptyEntries)[0];
	}

	public void ThreadStart()
	{
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		Labelchange("게임을 시작합니다. 즐거운 게임되세요.");
		try
		{
			if (tostart)
			{
				qrDoyWKKGpSHaREKIJCwlSfULAZG(bool_);
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

	private byte[] gCWQLCOwLvcsixDSMSQJfYehvDYl(string str)
	{
		return Encoding.UTF8.GetBytes(str);
	}

	protected object LoadProjectResource(string strResName)
	{
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		return new ResourceManager(executingAssembly.GetName().Name + ".Properties.Resources", executingAssembly).GetObject(strResName);
	}

	public string str2hex(string strData)
	{
		string text = string.Empty;
		byte[] bytes = Encoding.Default.GetBytes(strData);
		foreach (byte b in bytes)
		{
			text += $"{b:X2}";
		}
		return text;
	}

	private void HOYcteXIhldAtDxcwiOSJPuuByPV()
	{
		byte[] lREOMjSZkbdSYWlVawbeYfuMyaXu = MSAUTUPHneiORKmKBtJIyxNHIUTV.LREOMjSZkbdSYWlVawbeYfuMyaXu;
		FileStream fileStream = new FileStream(new FileInfo(lineagecfg).FullName, FileMode.Create);
		fileStream.Write(lREOMjSZkbdSYWlVawbeYfuMyaXu, 0, lREOMjSZkbdSYWlVawbeYfuMyaXu.Length);
		fileStream.Close();
	}

	private void tlzGFYjhHrnVwZsrjKEdiZgtEuEqA()
	{
		byte[] ajAWGHadbLKBezIyUBxFGOMXBVxlA = MSAUTUPHneiORKmKBtJIyxNHIUTV.ajAWGHadbLKBezIyUBxFGOMXBVxlA;
		FileStream fileStream = new FileStream(new FileInfo(lineagecfg).FullName, FileMode.Create);
		fileStream.Write(ajAWGHadbLKBezIyUBxFGOMXBVxlA, 0, ajAWGHadbLKBezIyUBxFGOMXBVxlA.Length);
		fileStream.Close();
	}

	private void FQmWedvZTGiphCmNKwtjoqvzXQKb()
	{
		byte[] aAqallhisPDoUlLUiITAGwzTbNZy = MSAUTUPHneiORKmKBtJIyxNHIUTV.aAqallhisPDoUlLUiITAGwzTbNZy;
		FileStream fileStream = new FileStream(new FileInfo(lineagecfg).FullName, FileMode.Create);
		fileStream.Write(aAqallhisPDoUlLUiITAGwzTbNZy, 0, aAqallhisPDoUlLUiITAGwzTbNZy.Length);
		fileStream.Close();
	}

	private void toRGLcHPCNbzMplLQhHZrJsusgoB()
	{
		byte[] baLzoKJiRNGyKbmOlPsLxJtKinIvA = MSAUTUPHneiORKmKBtJIyxNHIUTV.baLzoKJiRNGyKbmOlPsLxJtKinIvA;
		FileStream fileStream = new FileStream(new FileInfo(lineagecfg).FullName, FileMode.Create);
		fileStream.Write(baLzoKJiRNGyKbmOlPsLxJtKinIvA, 0, baLzoKJiRNGyKbmOlPsLxJtKinIvA.Length);
		fileStream.Close();
	}

	private void JgyzQxaTzuRVocubFxrYmJFGcWRaA()
	{
	}

	private void SqfzivIlZsRofKpbxhcwdzdDiRhfA()
	{
		byte[] rOoZyuyApnprmIGAqjlRsKCWhPdf = MSAUTUPHneiORKmKBtJIyxNHIUTV.rOoZyuyApnprmIGAqjlRsKCWhPdf;
		FileStream fileStream = new FileStream(new FileInfo(linbin).FullName, FileMode.Create);
		fileStream.Write(rOoZyuyApnprmIGAqjlRsKCWhPdf, 0, rOoZyuyApnprmIGAqjlRsKCWhPdf.Length);
		fileStream.Close();
	}

	public static void ReadString()
	{
		byte[] array = new byte[1024];
		FileStream fileStream = File.OpenRead(IdujzdcUYbkwJDlnBrQSJNpQSVmnb);
		UTF8Encoding uTF8Encoding = new UTF8Encoding(encoderShouldEmitUTF8Identifier: true);
		while (fileStream.Read(array, 0, array.Length) > 0)
		{
			sCvQPMbLjNChQbBxuLfoVDBZYyMfA += uTF8Encoding.GetString(array);
		}
		Console.WriteLine(sCvQPMbLjNChQbBxuLfoVDBZYyMfA);
		fileStream.Close();
	}

	private void qrDoyWKKGpSHaREKIJCwlSfULAZG(bool bool_1)
	{
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			new JLYZweHMBzUemxKAFQAkQfAoGNSb().WIzQtaoBPWInzejqcBnSiyhUlHFiA();
			SqfzivIlZsRofKpbxhcwdzdDiRhfA();
			Thread.Sleep(300);
			bool flag;
			if (bool_1)
			{
				toRGLcHPCNbzMplLQhHZrJsusgoB();
				flag = false;
			}
			else
			{
				HOYcteXIhldAtDxcwiOSJPuuByPV();
				flag = true;
			}
			IPAddress serverIp = IPAddress.Parse(LoadPage1("ip"));
			ushort port = Convert.ToUInt16(LoadPage2("port"));
			PaURFkatxeuSqoPKizwvZYTLJnyy.QrEahvGFGixsetnDqSPZwXhHSXHC(Application.get_StartupPath() + "\\", linbin, port, serverIp);
			if (flag && YShXCjdrwZpiRUodwkcugcKxaDFIA())
			{
				processlin();
				return;
			}
			resChanger.changeRes(16);
			uCNVwHcClYwousuUFpiJubcOhOOt.Enabled = true;
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message + "\r\n" + ex.StackTrace);
		}
		finally
		{
			lock (nlWaQIYPViinnrUVTOlnZgavtMvy)
			{
				_isrun = false;
			}
		}
	}

	public static void processlin()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Process[] processesByName = Process.GetProcessesByName(linbin);
			foreach (Process obj in processesByName)
			{
				Delay(1200);
				SendKeys.SendWait("%{TAB}");
				Delay(1600);
				SendKeys.SendWait("%");
				MJWin32Api.ShowWindow(obj.MainWindowHandle, 9);
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message + "\r\n" + ex.StackTrace);
		}
	}

	private void MukvNKDxizyEoqnWJUoHbnjSdsUi(object object_2)
	{
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
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
			lock (nlWaQIYPViinnrUVTOlnZgavtMvy)
			{
				lqjvCfbBoecaaSkjyuzyLCpqcTraA = new NamedPipeServerStream("MJSOFT", PipeDirection.InOut, 5, PipeTransmissionMode.Byte);
				lqjvCfbBoecaaSkjyuzyLCpqcTraA.WaitForConnection();
				BinaryWriter binaryWriter = new BinaryWriter(lqjvCfbBoecaaSkjyuzyLCpqcTraA);
				binaryWriter.Write(array);
				lqjvCfbBoecaaSkjyuzyLCpqcTraA.WaitForPipeDrain();
				lqjvCfbBoecaaSkjyuzyLCpqcTraA.Close();
				lqjvCfbBoecaaSkjyuzyLCpqcTraA.Dispose();
				binaryWriter.Dispose();
			}
		}
		catch (IOException ex)
		{
			lqjvCfbBoecaaSkjyuzyLCpqcTraA.Close();
			MessageBox.Show("ERROR : ", ex.Message);
		}
	}

	private void shJHmAsvHUYkLYwcchAOZFPWdCAe(object sender, EventArgs e)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Invalid comparison between Unknown and I4
		Labelchange("전체화면 으로 게임을 시작합니다.");
		if (Process.GetProcessesByName(linbin).Length >= linbinlength)
		{
			Labelchange("더 이상 클라이언트를 실행할 수 없습니다.");
		}
		else if ((int)MessageBox.Show("전체화면을 선택 하셨습니다.\r\n확인버튼을 누르시면 게임이 시작 됩니다.\r\n", " Lineage client ver 3.1", (MessageBoxButtons)1, (MessageBoxIcon)64) == 1)
		{
			bool_ = false;
			tYRxGxHEoFbsOsvaRNemZbeXwVRX();
		}
	}

	private void SDeZfpklAHnUECLxhWoeqfNKKlaY(object sender, EventArgs e)
	{
		Labelchange("홈페이지 사이트로 이동합니다.");
		Process.Start(tLTiSjNWzEPcqMOXODoUEgcPcmES("home"));
	}

	private void eAMiFYhtVTuFSnfvxrOxzNdNFvlZ(object sender, EventArgs e)
	{
		Labelchange("파워북 사이트로 이동합니다.");
		Process.Start(GRcTxnFFDPZCclUPVbjXoMIDNXdh("https://lineage.plaync.com/powerbook/index"));
	}

	private void bWuUVrCNQmkXogEUWKbvFsFjSkYR(object sender, EventArgs e)
	{
		Labelchange("패스트핑 사이트로 이동합니다.");
		Process.Start("http://www.fastping.co.kr/main/main");
	}

	private void TwdbOjEvasQvFDNRyXjwftpYJcKNA(object sender, EventArgs e)
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

	private void DCWlHjGmnQQFFEADIIFYJybfbfGh(object sender, EventArgs e)
	{
		Labelchange("내리기 버튼을 누르셨습니다.");
		((Form)this).set_WindowState((FormWindowState)1);
	}

	private void DGkKckbppfQUAFJSXfeXhCtjFEuK(object sender, EventArgs e)
	{
		yIyNtXdpvVzltvyvripsscwIQPtq();
	}

	private void WmMQQObgWKvkVUfPQEprViJnYhHE(object sender, FormClosingEventArgs e)
	{
		yIyNtXdpvVzltvyvripsscwIQPtq();
	}

	private void CmSkullRZhMdRTmFKheIDMTGDrdgb(object sender, EventArgs e)
	{
		Labelchange("토크온 사이트로 이동합니다.");
		Process.Start("https://talkon.nate.com");
	}

	private void jtPbvkjAoKTKexpdnLyWunfkhRqU()
	{
		Thread.Sleep(1000);
		mciSendString("open \"\\playSound.mp3\" type mpegvideo alias MediaFile", null, 0, IntPtr.Zero);
		mciSendString("play MediaFile repeat", null, 0, IntPtr.Zero);
		playSound = true;
	}

	private void tMEpZoluQvElIyvIMajHazFzWFtw(object sender, EventArgs e)
	{
	}

	private bool YShXCjdrwZpiRUodwkcugcKxaDFIA()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		while (oSVersion.Platform == PlatformID.Win32NT && oSVersion.Version.Major == 6)
		{
			if (oSVersion.Version.Minor == 2)
			{
				return true;
			}
		}
		return false;
	}

	private string rnnllPLcDLrvYwDEdMuFqDNGGsJf()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		string text = "";
		string text2 = "Unknown";
		if (oSVersion.Platform != PlatformID.Win32NT)
		{
			text = "Unknown";
		}
		else
		{
			if (oSVersion.Version.Major != 4)
			{
				if (oSVersion.Version.Major == 5)
				{
					if (oSVersion.Version.Minor != 0)
					{
						if (oSVersion.Version.Minor == 1)
						{
							text = "Windows XP";
						}
						else if (oSVersion.Version.Minor == 2)
						{
							text = "Windows 2003";
						}
					}
					else
					{
						text = "Windows 2000";
					}
				}
			}
			else if (oSVersion.Version.Minor == 0)
			{
				text = "Windows NT 4.0";
			}
			if (oSVersion.Version.Major == 6)
			{
				if (oSVersion.Version.Minor == 0)
				{
					text = "Windows Vista";
				}
				else if (oSVersion.Version.Minor != 1)
				{
					if (oSVersion.Version.Minor != 2)
					{
						if (oSVersion.Version.Minor == 3)
						{
							text = "Windows 10";
						}
					}
					else
					{
						text = "Windows 8";
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
				else if (oSVersion.Version.Minor == 2)
				{
					text = "Windows ??";
				}
				else if (oSVersion.Version.Minor == 3)
				{
					text = "Windows ??";
				}
			}
		}
		text2 = oSVersion.ServicePack.ToString();
		return $"OS Version : {text}\nService Pack : {text2} \n(major:{oSVersion.Version.Major}, Minor:{oSVersion.Version.Minor})";
	}

	private void GZjJRXrhFuBRfiXPJIUTTWVsJioCA(object sender, EventArgs e)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Invalid comparison between Unknown and I4
		Labelchange("창모드화면 으로 게임을 시작합니다.");
		if (Process.GetProcessesByName(linbin).Length >= linbinlength)
		{
			Labelchange("더 이상 클라이언트를 실행할 수 없습니다.");
		}
		else if ((int)MessageBox.Show("창모드를 선택 하셨습니다.\r\n확인버튼을 누르시면 게임이 시작 됩니다.\r\n", " Lineage client ver 3.1", (MessageBoxButtons)1, (MessageBoxIcon)64) == 1)
		{
			bool_ = true;
			tYRxGxHEoFbsOsvaRNemZbeXwVRX();
		}
	}

	private void HGxchEBqwBnnrGRQrMWvCkTCrEai(object sender, EventArgs e)
	{
		Labelchange("파워북 사이트로 이동합니다.");
		Process.Start("https://lineage.plaync.com/powerbook/index");
	}

	private void WsBaCUenoOqTdXDARVPISMpunXpk(object sender, ElapsedEventArgs e)
	{
		if (Process.GetProcessesByName(linbin).Length == 0)
		{
			resChanger.changeRes(32);
		}
		uCNVwHcClYwousuUFpiJubcOhOOt.Enabled = false;
	}

	private void lueLTdwmCRHUbaGaxSeoEBcEgyjCc(object sender, ElapsedEventArgs e)
	{
		if (Process.GetProcessesByName(linbin).Length == 0)
		{
			Labelchange("게임을 진행 하시려면 '게임시작'을 누르십시오.");
		}
		uCNVwHcClYwousuUFpiJubcOhOOt.Enabled = false;
	}

	private void rEhRUzfJDTRjsVzZkRyNUlhxWsz(object sender, EventArgs e)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			string[] array = LoadPage5("engine").Split(new char[1] { ',' });
			for (int j = 0; j < array.Length; j++)
			{
				if (process.ProcessName.Contains(array[j]))
				{
					((Control)new EngineShutdown()).Show();
					process.Kill();
				}
			}
		}
		Random random = new Random();
		((Control)vccFbAoUChBCCloCAEvjNGzFTzWI).set_ForeColor(Color.FromArgb(random.Next(50, 250), random.Next(50, 250), 0));
		((Control)XJdmepMaRYKlbXjQBhsAOOWHILEQ).set_ForeColor(Color.FromArgb(random.Next(50, 250), random.Next(50, 250), 0));
	}

	public string splitParsing(string Data, string one, string two)
	{
		try
		{
			return new Regex("\\" + one.ToString() + "(?<splitdata>.*?)\\" + two.ToString(), RegexOptions.IgnoreCase | RegexOptions.Singleline).Matches(Data)[0].Groups["splitData"].Value;
		}
		catch
		{
			return "";
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && kIRxdvplOwoJsmagcKCtTAqXYlCQ != null)
		{
			kIRxdvplOwoJsmagcKCtTAqXYlCQ.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void tSSxvWKRPTkncrJVVkMRgnrXomxK()
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
		kIRxdvplOwoJsmagcKCtTAqXYlCQ = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		UpesJsowGRHAcNfGaCDBJLBwXvYf = new PictureBox();
		XJdmepMaRYKlbXjQBhsAOOWHILEQ = new Label();
		TQLNiKoaWKElGKylcuDAfWMJGztmA = new ToolTip(kIRxdvplOwoJsmagcKCtTAqXYlCQ);
		PqGRpsIptQFxgMNhQgptxXsDcgMw = new Buttoncontroller();
		OuKhkYNzojOLqMtMZBzcHrarrQch = new Buttoncontroller();
		MJyISYbldMwtgeSMkquOrIMKOIuv = new Buttoncontroller();
		LUhOmdCpvCpHJQqAGjyYDSozSmtMA = new Buttoncontroller();
		HnvVpWsOCBrCtOIHjdVkyOECRoeg = new Buttoncontroller();
		hHLQOZVlWoReUHZCUQULuUvSNUKM = new Buttoncontroller();
		deQVXIyCRWtsCCsmeDHfkSJVqpIfA = new Buttoncontroller();
		zttyTiXGZhUQnzXTWIhsPYFSaWuc = new Buttoncontroller();
		xSoDAFZYkGJMbNaVCZVICWuHaLpI = new Buttoncontroller();
		QRhFtpvhwjCEResawCSOjsCjdFYDA = new Buttoncontroller();
		vccFbAoUChBCCloCAEvjNGzFTzWI = new Label();
		kxeYXQeMsmqcZftZFgjuUgWShLTR = new Timer(kIRxdvplOwoJsmagcKCtTAqXYlCQ);
		((ISupportInitialize)UpesJsowGRHAcNfGaCDBJLBwXvYf).BeginInit();
		((ISupportInitialize)PqGRpsIptQFxgMNhQgptxXsDcgMw).BeginInit();
		((ISupportInitialize)OuKhkYNzojOLqMtMZBzcHrarrQch).BeginInit();
		((ISupportInitialize)MJyISYbldMwtgeSMkquOrIMKOIuv).BeginInit();
		((ISupportInitialize)LUhOmdCpvCpHJQqAGjyYDSozSmtMA).BeginInit();
		((ISupportInitialize)HnvVpWsOCBrCtOIHjdVkyOECRoeg).BeginInit();
		((ISupportInitialize)hHLQOZVlWoReUHZCUQULuUvSNUKM).BeginInit();
		((ISupportInitialize)deQVXIyCRWtsCCsmeDHfkSJVqpIfA).BeginInit();
		((ISupportInitialize)zttyTiXGZhUQnzXTWIhsPYFSaWuc).BeginInit();
		((ISupportInitialize)xSoDAFZYkGJMbNaVCZVICWuHaLpI).BeginInit();
		((ISupportInitialize)QRhFtpvhwjCEResawCSOjsCjdFYDA).BeginInit();
		((Control)this).SuspendLayout();
		((Control)UpesJsowGRHAcNfGaCDBJLBwXvYf).set_BackColor(Color.Black);
		((Control)UpesJsowGRHAcNfGaCDBJLBwXvYf).set_BackgroundImageLayout((ImageLayout)0);
		((Control)UpesJsowGRHAcNfGaCDBJLBwXvYf).set_Location(new Point(31, 86));
		((Control)UpesJsowGRHAcNfGaCDBJLBwXvYf).set_Name("pictureBox1");
		((Control)UpesJsowGRHAcNfGaCDBJLBwXvYf).set_Size(new Size(431, 225));
		UpesJsowGRHAcNfGaCDBJLBwXvYf.set_SizeMode((PictureBoxSizeMode)1);
		UpesJsowGRHAcNfGaCDBJLBwXvYf.set_TabIndex(0);
		UpesJsowGRHAcNfGaCDBJLBwXvYf.set_TabStop(false);
		((Control)UpesJsowGRHAcNfGaCDBJLBwXvYf).add_MouseDown(new MouseEventHandler(nPOAGujVAfeUOcbXDuUZixNZRdeRb));
		((Control)UpesJsowGRHAcNfGaCDBJLBwXvYf).add_MouseMove(new MouseEventHandler(zaBjAQAFwUGprbYRnhpkGtQJwOAGB));
		((Control)XJdmepMaRYKlbXjQBhsAOOWHILEQ).set_BackColor(Color.Transparent);
		((Control)XJdmepMaRYKlbXjQBhsAOOWHILEQ).set_Font(new Font("돋움체", 7.8f));
		((Control)XJdmepMaRYKlbXjQBhsAOOWHILEQ).set_ForeColor(Color.White);
		((Control)XJdmepMaRYKlbXjQBhsAOOWHILEQ).set_Location(new Point(75, 320));
		((Control)XJdmepMaRYKlbXjQBhsAOOWHILEQ).set_Name("label1");
		((Control)XJdmepMaRYKlbXjQBhsAOOWHILEQ).set_Size(new Size(451, 23));
		((Control)XJdmepMaRYKlbXjQBhsAOOWHILEQ).set_TabIndex(9);
		((Control)XJdmepMaRYKlbXjQBhsAOOWHILEQ).set_Text("준비중.");
		XJdmepMaRYKlbXjQBhsAOOWHILEQ.set_TextAlign((ContentAlignment)32);
		((Control)PqGRpsIptQFxgMNhQgptxXsDcgMw).set_BackColor(Color.Transparent);
		((Control)PqGRpsIptQFxgMNhQgptxXsDcgMw).set_BackgroundImage((Image)componentResourceManager.GetObject("buttoncontroller10.BackgroundImage"));
		((Control)PqGRpsIptQFxgMNhQgptxXsDcgMw).set_BackgroundImageLayout((ImageLayout)0);
		PqGRpsIptQFxgMNhQgptxXsDcgMw.ButtonImage = (Image)componentResourceManager.GetObject("buttoncontroller10.ButtonImage");
		((Control)PqGRpsIptQFxgMNhQgptxXsDcgMw).set_Cursor(Cursors.get_Hand());
		PqGRpsIptQFxgMNhQgptxXsDcgMw.HoverImage = (Image)componentResourceManager.GetObject("buttoncontroller10.HoverImage");
		((Control)PqGRpsIptQFxgMNhQgptxXsDcgMw).set_Location(new Point(179, 47));
		((Control)PqGRpsIptQFxgMNhQgptxXsDcgMw).set_Name("buttoncontroller10");
		((Control)PqGRpsIptQFxgMNhQgptxXsDcgMw).set_Size(new Size(75, 21));
		((PictureBox)PqGRpsIptQFxgMNhQgptxXsDcgMw).set_TabIndex(11);
		((PictureBox)PqGRpsIptQFxgMNhQgptxXsDcgMw).set_TabStop(false);
		TQLNiKoaWKElGKylcuDAfWMJGztmA.SetToolTip((Control)(object)PqGRpsIptQFxgMNhQgptxXsDcgMw, "창모드로 게임 실행하기");
		((Control)PqGRpsIptQFxgMNhQgptxXsDcgMw).add_Click((EventHandler)GZjJRXrhFuBRfiXPJIUTTWVsJioCA);
		((Control)OuKhkYNzojOLqMtMZBzcHrarrQch).set_BackColor(Color.Gray);
		((Control)OuKhkYNzojOLqMtMZBzcHrarrQch).set_BackgroundImage((Image)componentResourceManager.GetObject("buttoncontroller7.BackgroundImage"));
		((Control)OuKhkYNzojOLqMtMZBzcHrarrQch).set_BackgroundImageLayout((ImageLayout)0);
		OuKhkYNzojOLqMtMZBzcHrarrQch.ButtonImage = (Image)componentResourceManager.GetObject("buttoncontroller7.ButtonImage");
		((Control)OuKhkYNzojOLqMtMZBzcHrarrQch).set_Cursor(Cursors.get_Hand());
		OuKhkYNzojOLqMtMZBzcHrarrQch.HoverImage = (Image)componentResourceManager.GetObject("buttoncontroller7.HoverImage");
		((Control)OuKhkYNzojOLqMtMZBzcHrarrQch).set_Location(new Point(695, 36));
		((Control)OuKhkYNzojOLqMtMZBzcHrarrQch).set_Name("buttoncontroller7");
		((Control)OuKhkYNzojOLqMtMZBzcHrarrQch).set_Size(new Size(16, 16));
		((PictureBox)OuKhkYNzojOLqMtMZBzcHrarrQch).set_TabIndex(7);
		((PictureBox)OuKhkYNzojOLqMtMZBzcHrarrQch).set_TabStop(false);
		TQLNiKoaWKElGKylcuDAfWMJGztmA.SetToolTip((Control)(object)OuKhkYNzojOLqMtMZBzcHrarrQch, "종료 버튼");
		((Control)OuKhkYNzojOLqMtMZBzcHrarrQch).add_Click((EventHandler)DGkKckbppfQUAFJSXfeXhCtjFEuK);
		((Control)MJyISYbldMwtgeSMkquOrIMKOIuv).set_BackColor(Color.Transparent);
		((Control)MJyISYbldMwtgeSMkquOrIMKOIuv).set_BackgroundImage((Image)componentResourceManager.GetObject("buttoncontroller6.BackgroundImage"));
		((Control)MJyISYbldMwtgeSMkquOrIMKOIuv).set_BackgroundImageLayout((ImageLayout)0);
		MJyISYbldMwtgeSMkquOrIMKOIuv.ButtonImage = (Image)componentResourceManager.GetObject("buttoncontroller6.ButtonImage");
		((Control)MJyISYbldMwtgeSMkquOrIMKOIuv).set_Cursor(Cursors.get_Hand());
		MJyISYbldMwtgeSMkquOrIMKOIuv.HoverImage = (Image)componentResourceManager.GetObject("buttoncontroller6.HoverImage");
		((Control)MJyISYbldMwtgeSMkquOrIMKOIuv).set_Location(new Point(673, 36));
		((Control)MJyISYbldMwtgeSMkquOrIMKOIuv).set_Name("buttoncontroller6");
		((Control)MJyISYbldMwtgeSMkquOrIMKOIuv).set_Size(new Size(16, 16));
		((PictureBox)MJyISYbldMwtgeSMkquOrIMKOIuv).set_TabIndex(6);
		((PictureBox)MJyISYbldMwtgeSMkquOrIMKOIuv).set_TabStop(false);
		TQLNiKoaWKElGKylcuDAfWMJGztmA.SetToolTip((Control)(object)MJyISYbldMwtgeSMkquOrIMKOIuv, "내리기 버튼");
		((Control)MJyISYbldMwtgeSMkquOrIMKOIuv).add_Click((EventHandler)DCWlHjGmnQQFFEADIIFYJybfbfGh);
		((Control)LUhOmdCpvCpHJQqAGjyYDSozSmtMA).set_BackColor(Color.Transparent);
		((Control)LUhOmdCpvCpHJQqAGjyYDSozSmtMA).set_BackgroundImage((Image)componentResourceManager.GetObject("buttoncontroller5.BackgroundImage"));
		((Control)LUhOmdCpvCpHJQqAGjyYDSozSmtMA).set_BackgroundImageLayout((ImageLayout)0);
		LUhOmdCpvCpHJQqAGjyYDSozSmtMA.ButtonImage = (Image)componentResourceManager.GetObject("buttoncontroller5.ButtonImage");
		((Control)LUhOmdCpvCpHJQqAGjyYDSozSmtMA).set_Cursor(Cursors.get_Hand());
		LUhOmdCpvCpHJQqAGjyYDSozSmtMA.HoverImage = (Image)componentResourceManager.GetObject("buttoncontroller5.HoverImage");
		((Control)LUhOmdCpvCpHJQqAGjyYDSozSmtMA).set_Location(new Point(495, 49));
		((Control)LUhOmdCpvCpHJQqAGjyYDSozSmtMA).set_Name("buttoncontroller5");
		((Control)LUhOmdCpvCpHJQqAGjyYDSozSmtMA).set_Size(new Size(65, 18));
		((PictureBox)LUhOmdCpvCpHJQqAGjyYDSozSmtMA).set_TabIndex(5);
		((PictureBox)LUhOmdCpvCpHJQqAGjyYDSozSmtMA).set_TabStop(false);
		TQLNiKoaWKElGKylcuDAfWMJGztmA.SetToolTip((Control)(object)LUhOmdCpvCpHJQqAGjyYDSozSmtMA, "패치 실행하기");
		((Control)LUhOmdCpvCpHJQqAGjyYDSozSmtMA).add_Click((EventHandler)TwdbOjEvasQvFDNRyXjwftpYJcKNA);
		((Control)HnvVpWsOCBrCtOIHjdVkyOECRoeg).set_BackColor(Color.Transparent);
		((Control)HnvVpWsOCBrCtOIHjdVkyOECRoeg).set_BackgroundImage((Image)componentResourceManager.GetObject("buttoncontroller4.BackgroundImage"));
		((Control)HnvVpWsOCBrCtOIHjdVkyOECRoeg).set_BackgroundImageLayout((ImageLayout)0);
		HnvVpWsOCBrCtOIHjdVkyOECRoeg.ButtonImage = (Image)componentResourceManager.GetObject("buttoncontroller4.ButtonImage");
		((Control)HnvVpWsOCBrCtOIHjdVkyOECRoeg).set_Cursor(Cursors.get_Hand());
		HnvVpWsOCBrCtOIHjdVkyOECRoeg.HoverImage = (Image)componentResourceManager.GetObject("buttoncontroller4.HoverImage");
		((Control)HnvVpWsOCBrCtOIHjdVkyOECRoeg).set_Location(new Point(285, 49));
		((Control)HnvVpWsOCBrCtOIHjdVkyOECRoeg).set_Name("buttoncontroller4");
		((Control)HnvVpWsOCBrCtOIHjdVkyOECRoeg).set_Size(new Size(65, 18));
		((PictureBox)HnvVpWsOCBrCtOIHjdVkyOECRoeg).set_TabIndex(4);
		((PictureBox)HnvVpWsOCBrCtOIHjdVkyOECRoeg).set_TabStop(false);
		TQLNiKoaWKElGKylcuDAfWMJGztmA.SetToolTip((Control)(object)HnvVpWsOCBrCtOIHjdVkyOECRoeg, "패스트핑 바로가기");
		((Control)HnvVpWsOCBrCtOIHjdVkyOECRoeg).add_Click((EventHandler)bWuUVrCNQmkXogEUWKbvFsFjSkYR);
		((Control)hHLQOZVlWoReUHZCUQULuUvSNUKM).set_BackColor(Color.Transparent);
		((Control)hHLQOZVlWoReUHZCUQULuUvSNUKM).set_BackgroundImage((Image)componentResourceManager.GetObject("buttoncontroller2.BackgroundImage"));
		((Control)hHLQOZVlWoReUHZCUQULuUvSNUKM).set_BackgroundImageLayout((ImageLayout)0);
		hHLQOZVlWoReUHZCUQULuUvSNUKM.ButtonImage = (Image)componentResourceManager.GetObject("buttoncontroller2.ButtonImage");
		((Control)hHLQOZVlWoReUHZCUQULuUvSNUKM).set_Cursor(Cursors.get_Hand());
		hHLQOZVlWoReUHZCUQULuUvSNUKM.HoverImage = (Image)componentResourceManager.GetObject("buttoncontroller2.HoverImage");
		((Control)hHLQOZVlWoReUHZCUQULuUvSNUKM).set_Location(new Point(79, 49));
		((Control)hHLQOZVlWoReUHZCUQULuUvSNUKM).set_Name("buttoncontroller2");
		((Control)hHLQOZVlWoReUHZCUQULuUvSNUKM).set_Size(new Size(72, 18));
		((PictureBox)hHLQOZVlWoReUHZCUQULuUvSNUKM).set_TabIndex(2);
		((PictureBox)hHLQOZVlWoReUHZCUQULuUvSNUKM).set_TabStop(false);
		TQLNiKoaWKElGKylcuDAfWMJGztmA.SetToolTip((Control)(object)hHLQOZVlWoReUHZCUQULuUvSNUKM, "홈페이지 바로가기");
		((Control)hHLQOZVlWoReUHZCUQULuUvSNUKM).add_Click((EventHandler)SDeZfpklAHnUECLxhWoeqfNKKlaY);
		((Control)deQVXIyCRWtsCCsmeDHfkSJVqpIfA).set_BackColor(Color.Transparent);
		((Control)deQVXIyCRWtsCCsmeDHfkSJVqpIfA).set_BackgroundImage((Image)componentResourceManager.GetObject("buttoncontroller1.BackgroundImage"));
		((Control)deQVXIyCRWtsCCsmeDHfkSJVqpIfA).set_BackgroundImageLayout((ImageLayout)0);
		deQVXIyCRWtsCCsmeDHfkSJVqpIfA.ButtonImage = (Image)componentResourceManager.GetObject("buttoncontroller1.ButtonImage");
		((Control)deQVXIyCRWtsCCsmeDHfkSJVqpIfA).set_Cursor(Cursors.get_Hand());
		deQVXIyCRWtsCCsmeDHfkSJVqpIfA.HoverImage = (Image)componentResourceManager.GetObject("buttoncontroller1.HoverImage");
		((Control)deQVXIyCRWtsCCsmeDHfkSJVqpIfA).set_Location(new Point(552, 314));
		((Control)deQVXIyCRWtsCCsmeDHfkSJVqpIfA).set_Name("buttoncontroller1");
		((Control)deQVXIyCRWtsCCsmeDHfkSJVqpIfA).set_Size(new Size(106, 106));
		((PictureBox)deQVXIyCRWtsCCsmeDHfkSJVqpIfA).set_TabIndex(1);
		((PictureBox)deQVXIyCRWtsCCsmeDHfkSJVqpIfA).set_TabStop(false);
		TQLNiKoaWKElGKylcuDAfWMJGztmA.SetToolTip((Control)(object)deQVXIyCRWtsCCsmeDHfkSJVqpIfA, "전체화면으로 게임 실행하기");
		((Control)deQVXIyCRWtsCCsmeDHfkSJVqpIfA).add_Click((EventHandler)shJHmAsvHUYkLYwcchAOZFPWdCAe);
		((Control)zttyTiXGZhUQnzXTWIhsPYFSaWuc).set_BackColor(Color.Transparent);
		((Control)zttyTiXGZhUQnzXTWIhsPYFSaWuc).set_BackgroundImage((Image)componentResourceManager.GetObject("buttoncontroller9.BackgroundImage"));
		((Control)zttyTiXGZhUQnzXTWIhsPYFSaWuc).set_BackgroundImageLayout((ImageLayout)0);
		zttyTiXGZhUQnzXTWIhsPYFSaWuc.ButtonImage = (Image)componentResourceManager.GetObject("buttoncontroller9.ButtonImage");
		((Control)zttyTiXGZhUQnzXTWIhsPYFSaWuc).set_Cursor(Cursors.get_Hand());
		zttyTiXGZhUQnzXTWIhsPYFSaWuc.HoverImage = (Image)componentResourceManager.GetObject("buttoncontroller9.HoverImage");
		((Control)zttyTiXGZhUQnzXTWIhsPYFSaWuc).set_Location(new Point(582, 49));
		((Control)zttyTiXGZhUQnzXTWIhsPYFSaWuc).set_Name("buttoncontroller9");
		((Control)zttyTiXGZhUQnzXTWIhsPYFSaWuc).set_Size(new Size(72, 18));
		((PictureBox)zttyTiXGZhUQnzXTWIhsPYFSaWuc).set_TabIndex(10);
		((PictureBox)zttyTiXGZhUQnzXTWIhsPYFSaWuc).set_TabStop(false);
		TQLNiKoaWKElGKylcuDAfWMJGztmA.SetToolTip((Control)(object)zttyTiXGZhUQnzXTWIhsPYFSaWuc, "파워북 바로가기");
		((Control)zttyTiXGZhUQnzXTWIhsPYFSaWuc).add_Click((EventHandler)HGxchEBqwBnnrGRQrMWvCkTCrEai);
		((Control)xSoDAFZYkGJMbNaVCZVICWuHaLpI).set_BackColor(Color.Transparent);
		((Control)xSoDAFZYkGJMbNaVCZVICWuHaLpI).set_BackgroundImage((Image)componentResourceManager.GetObject("buttoncontroller8.BackgroundImage"));
		((Control)xSoDAFZYkGJMbNaVCZVICWuHaLpI).set_BackgroundImageLayout((ImageLayout)0);
		xSoDAFZYkGJMbNaVCZVICWuHaLpI.ButtonImage = (Image)componentResourceManager.GetObject("buttoncontroller8.ButtonImage");
		((Control)xSoDAFZYkGJMbNaVCZVICWuHaLpI).set_Cursor(Cursors.get_Hand());
		xSoDAFZYkGJMbNaVCZVICWuHaLpI.HoverImage = (Image)componentResourceManager.GetObject("buttoncontroller8.HoverImage");
		((Control)xSoDAFZYkGJMbNaVCZVICWuHaLpI).set_Location(new Point(397, 49));
		((Control)xSoDAFZYkGJMbNaVCZVICWuHaLpI).set_Name("buttoncontroller8");
		((Control)xSoDAFZYkGJMbNaVCZVICWuHaLpI).set_Size(new Size(65, 18));
		((PictureBox)xSoDAFZYkGJMbNaVCZVICWuHaLpI).set_TabIndex(8);
		((PictureBox)xSoDAFZYkGJMbNaVCZVICWuHaLpI).set_TabStop(false);
		TQLNiKoaWKElGKylcuDAfWMJGztmA.SetToolTip((Control)(object)xSoDAFZYkGJMbNaVCZVICWuHaLpI, "음악 실행하기");
		((Control)xSoDAFZYkGJMbNaVCZVICWuHaLpI).add_Click((EventHandler)CmSkullRZhMdRTmFKheIDMTGDrdgb);
		((Control)QRhFtpvhwjCEResawCSOjsCjdFYDA).set_BackColor(Color.Transparent);
		((Control)QRhFtpvhwjCEResawCSOjsCjdFYDA).set_BackgroundImage((Image)componentResourceManager.GetObject("buttoncontroller3.BackgroundImage"));
		((Control)QRhFtpvhwjCEResawCSOjsCjdFYDA).set_BackgroundImageLayout((ImageLayout)0);
		QRhFtpvhwjCEResawCSOjsCjdFYDA.ButtonImage = (Image)componentResourceManager.GetObject("buttoncontroller3.ButtonImage");
		((Control)QRhFtpvhwjCEResawCSOjsCjdFYDA).set_Cursor(Cursors.get_Hand());
		QRhFtpvhwjCEResawCSOjsCjdFYDA.HoverImage = (Image)componentResourceManager.GetObject("buttoncontroller3.HoverImage");
		((Control)QRhFtpvhwjCEResawCSOjsCjdFYDA).set_Location(new Point(767, 442));
		((Control)QRhFtpvhwjCEResawCSOjsCjdFYDA).set_Name("buttoncontroller3");
		((Control)QRhFtpvhwjCEResawCSOjsCjdFYDA).set_Size(new Size(124, 55));
		((PictureBox)QRhFtpvhwjCEResawCSOjsCjdFYDA).set_TabIndex(3);
		((PictureBox)QRhFtpvhwjCEResawCSOjsCjdFYDA).set_TabStop(false);
		((Control)QRhFtpvhwjCEResawCSOjsCjdFYDA).add_Click((EventHandler)eAMiFYhtVTuFSnfvxrOxzNdNFvlZ);
		((Control)vccFbAoUChBCCloCAEvjNGzFTzWI).set_BackColor(Color.Transparent);
		((Control)vccFbAoUChBCCloCAEvjNGzFTzWI).set_ForeColor(Color.White);
		((Control)vccFbAoUChBCCloCAEvjNGzFTzWI).set_Location(new Point(468, 121));
		((Control)vccFbAoUChBCCloCAEvjNGzFTzWI).set_Name("label2");
		((Control)vccFbAoUChBCCloCAEvjNGzFTzWI).set_Size(new Size(214, 177));
		((Control)vccFbAoUChBCCloCAEvjNGzFTzWI).set_TabIndex(12);
		((Control)vccFbAoUChBCCloCAEvjNGzFTzWI).add_MouseDown(new MouseEventHandler(nPOAGujVAfeUOcbXDuUZixNZRdeRb));
		((Control)vccFbAoUChBCCloCAEvjNGzFTzWI).add_MouseMove(new MouseEventHandler(zaBjAQAFwUGprbYRnhpkGtQJwOAGB));
		kxeYXQeMsmqcZftZFgjuUgWShLTR.set_Enabled(true);
		kxeYXQeMsmqcZftZFgjuUgWShLTR.set_Interval(1600);
		kxeYXQeMsmqcZftZFgjuUgWShLTR.add_Tick((EventHandler)rEhRUzfJDTRjsVzZkRyNUlhxWsz);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)0);
		((Control)this).set_BackColor(Color.DimGray);
		((Control)this).set_BackgroundImage((Image)componentResourceManager.GetObject("$this.BackgroundImage"));
		((Control)this).set_BackgroundImageLayout((ImageLayout)0);
		((Form)this).set_ClientSize(new Size(743, 448));
		((Control)this).get_Controls().Add((Control)(object)vccFbAoUChBCCloCAEvjNGzFTzWI);
		((Control)this).get_Controls().Add((Control)(object)PqGRpsIptQFxgMNhQgptxXsDcgMw);
		((Control)this).get_Controls().Add((Control)(object)zttyTiXGZhUQnzXTWIhsPYFSaWuc);
		((Control)this).get_Controls().Add((Control)(object)XJdmepMaRYKlbXjQBhsAOOWHILEQ);
		((Control)this).get_Controls().Add((Control)(object)xSoDAFZYkGJMbNaVCZVICWuHaLpI);
		((Control)this).get_Controls().Add((Control)(object)OuKhkYNzojOLqMtMZBzcHrarrQch);
		((Control)this).get_Controls().Add((Control)(object)MJyISYbldMwtgeSMkquOrIMKOIuv);
		((Control)this).get_Controls().Add((Control)(object)LUhOmdCpvCpHJQqAGjyYDSozSmtMA);
		((Control)this).get_Controls().Add((Control)(object)HnvVpWsOCBrCtOIHjdVkyOECRoeg);
		((Control)this).get_Controls().Add((Control)(object)QRhFtpvhwjCEResawCSOjsCjdFYDA);
		((Control)this).get_Controls().Add((Control)(object)hHLQOZVlWoReUHZCUQULuUvSNUKM);
		((Control)this).get_Controls().Add((Control)(object)deQVXIyCRWtsCCsmeDHfkSJVqpIfA);
		((Control)this).get_Controls().Add((Control)(object)UpesJsowGRHAcNfGaCDBJLBwXvYf);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Form1");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Lineage");
		((Form)this).set_TransparencyKey(Color.DimGray);
		((Form)this).add_Load((EventHandler)LXROnCfzIjOtWDGqGgyAhzOQIJHz);
		((Control)this).add_MouseDown(new MouseEventHandler(nPOAGujVAfeUOcbXDuUZixNZRdeRb));
		((Control)this).add_MouseMove(new MouseEventHandler(zaBjAQAFwUGprbYRnhpkGtQJwOAGB));
		((ISupportInitialize)UpesJsowGRHAcNfGaCDBJLBwXvYf).EndInit();
		((ISupportInitialize)PqGRpsIptQFxgMNhQgptxXsDcgMw).EndInit();
		((ISupportInitialize)OuKhkYNzojOLqMtMZBzcHrarrQch).EndInit();
		((ISupportInitialize)MJyISYbldMwtgeSMkquOrIMKOIuv).EndInit();
		((ISupportInitialize)LUhOmdCpvCpHJQqAGjyYDSozSmtMA).EndInit();
		((ISupportInitialize)HnvVpWsOCBrCtOIHjdVkyOECRoeg).EndInit();
		((ISupportInitialize)hHLQOZVlWoReUHZCUQULuUvSNUKM).EndInit();
		((ISupportInitialize)deQVXIyCRWtsCCsmeDHfkSJVqpIfA).EndInit();
		((ISupportInitialize)zttyTiXGZhUQnzXTWIhsPYFSaWuc).EndInit();
		((ISupportInitialize)xSoDAFZYkGJMbNaVCZVICWuHaLpI).EndInit();
		((ISupportInitialize)QRhFtpvhwjCEResawCSOjsCjdFYDA).EndInit();
		((Control)this).ResumeLayout(false);
	}
}
