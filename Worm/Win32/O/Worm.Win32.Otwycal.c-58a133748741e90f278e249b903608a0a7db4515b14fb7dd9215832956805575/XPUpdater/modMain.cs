using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using XPUpdater.My;

namespace XPUpdater;

[StandardModule]
internal sealed class modMain
{
	[AccessedThroughProperty("myUpdate")]
	private static clsXPUpdater _myUpdate;

	[AccessedThroughProperty("SysIcon")]
	private static NotifyIcon _SysIcon;

	[AccessedThroughProperty("myTime")]
	private static Timer _myTime;

	public static bool isGetTime;

	[SpecialName]
	private static bool _0024STATIC_0024main_0024001_0024GetParam;

	[SpecialName]
	private static DateTime _0024STATIC_0024myTime_Tick_00240211C1255_0024StartTime;

	[SpecialName]
	private static bool _0024STATIC_0024main_0024001_0024mainRun;

	public static clsXPUpdater myUpdate
	{
		[DebuggerNonUserCode]
		get
		{
			return _myUpdate;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_myUpdate != null)
			{
				_myUpdate.ChangeMessage -= myUpdate_ChangeMessage;
				_myUpdate.DonloadProgress -= myUpdate_DonloadProgress;
				_myUpdate.StartProgram -= myUpdate_StartProgram;
				_myUpdate.ErrorMessage -= myUpdate_ErrorMessage;
			}
			_myUpdate = value;
			if (_myUpdate != null)
			{
				_myUpdate.ChangeMessage += myUpdate_ChangeMessage;
				_myUpdate.DonloadProgress += myUpdate_DonloadProgress;
				_myUpdate.StartProgram += myUpdate_StartProgram;
				_myUpdate.ErrorMessage += myUpdate_ErrorMessage;
			}
		}
	} = new clsXPUpdater();


	public static NotifyIcon SysIcon
	{
		[DebuggerNonUserCode]
		get
		{
			return _SysIcon;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_SysIcon != null)
			{
				_SysIcon.remove_DoubleClick((EventHandler)SysIcon_DoubleClick);
			}
			_SysIcon = value;
			if (_SysIcon != null)
			{
				_SysIcon.add_DoubleClick((EventHandler)SysIcon_DoubleClick);
			}
		}
	} = new NotifyIcon();


	public static Timer myTime
	{
		[DebuggerNonUserCode]
		get
		{
			return _myTime;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_myTime != null)
			{
				_myTime.remove_Tick((EventHandler)myTime_Tick);
			}
			_myTime = value;
			if (_myTime != null)
			{
				_myTime.add_Tick((EventHandler)myTime_Tick);
			}
		}
	} = new Timer();


	public static bool CheckPrevInstance()
	{
		string moduleName = Process.GetCurrentProcess().MainModule!.ModuleName;
		string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(moduleName);
		if (Process.GetProcessesByName(fileNameWithoutExtension).Length > 1)
		{
			return true;
		}
		return false;
	}

	[STAThread]
	public static void main()
	{
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		string[] array;
		if (!_0024STATIC_0024main_0024001_0024GetParam)
		{
			array = Environment.GetCommandLineArgs();
			_0024STATIC_0024main_0024001_0024GetParam = true;
		}
		else
		{
			array = new string[1];
		}
		if (Information.UBound((Array)array, 1) != 0)
		{
			if (Operators.CompareString(array[1].ToUpper(), "/AUTORUN", false) == 0)
			{
				if (Operators.CompareString(myUpdate.ConfigFile.GetKey("UpdateInfo", "NextNoWarning", myUpdate._ConfigFile).ToUpper(), "TRUE", false) != 0)
				{
					goto IL_0146;
				}
				if (DateTime.Compare(Convert.ToDateTime(myUpdate.ConfigFile.GetKey("UpdateInfo", "NextStartTime", myUpdate._ConfigFile)), DateAndTime.get_Now()) >= 0)
				{
					return;
				}
				Interaction.MsgBox((object)"سىز ئۇيغۇرچە ۋىندوۋسنىڭ ئاپتوماتىك نۇسخا يېڭىلاش ئىقتىدارىنى توختىتىپ قويغىلى بىر ھەپتە بولدى، ناۋادا نۇسخا يېڭىلاش ئىقتىدارىنى داۋاملىق تاقاپ قويماقچى بولسىڭىز، بۇ قېتىم قايتىدىن تاللاش ئېلىپ بېرىڭ!", (MsgBoxStyle)48, (object)null);
			}
			else
			{
				Interaction.MsgBox((object)("بۇنداق پارامېتىر يوق\n" + array[1]), (MsgBoxStyle)48, (object)null);
				ProjectData.EndApp();
			}
		}
		else
		{
			myUpdate.ConfigFile.SetKey("UpdateInfo", "NextNoWarning", Convert.ToString(value: false), myUpdate._ConfigFile);
		}
		if (CheckPrevInstance())
		{
			Interaction.MsgBox((object)"ئوخشاش پروگراممىدىن 2 خىل قوزغىتىشقا بولمايدۇ، ۋەزىپە سىتونىدىكى كىچىك ئايكون سۈرەتنى قوش چېكىڭ:", (MsgBoxStyle)48, (object)null);
			Application.Exit();
			ProjectData.EndApp();
		}
		((Form)MyProject.Forms.frmMain).ShowDialog();
		goto IL_0146;
		IL_0146:
		SysIcon.set_Icon(((Form)MyProject.Forms.frmMain).get_Icon());
		SysIcon.set_Visible(true);
		myTime.set_Interval(1000);
		myTime.set_Enabled(true);
		if (!_0024STATIC_0024main_0024001_0024mainRun)
		{
			_0024STATIC_0024main_0024001_0024mainRun = true;
			Application.Run();
		}
	}

	private static void myUpdate_ChangeMessage(string Message)
	{
		MyProject.Forms.frmUpdate.ListBox1.get_Items().Add((object)Message);
		checked
		{
			MyProject.Forms.frmUpdate.ListBox1.set_SelectedIndex(MyProject.Forms.frmUpdate.ListBox1.get_Items().get_Count() - 1);
			long num = 0L;
			do
			{
				Application.DoEvents();
				num++;
			}
			while (num <= 1000L);
		}
	}

	private static void myUpdate_ErrorMessage(string uMessage, ErrObject Err)
	{
		myUpdate_ChangeMessage(uMessage);
	}

	private static void myUpdate_DonloadProgress(string FileURL, string localFile, long fileLength, long byteComplete)
	{
		checked
		{
			MyProject.Forms.frmUpdate.ProgressBar1.set_Maximum((int)fileLength);
			MyProject.Forms.frmUpdate.ProgressBar1.set_Minimum(0);
			MyProject.Forms.frmUpdate.ProgressBar1.set_Value((int)byteComplete);
		}
	}

	private static void SysIcon_DoubleClick(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.frmMain).Show();
		myTime.set_Enabled(false);
	}

	private static void myTime_Tick(object sender, EventArgs e)
	{
		if (!isGetTime)
		{
			_0024STATIC_0024myTime_Tick_00240211C1255_0024StartTime = Convert.ToDateTime(myUpdate.ConfigFile.GetKey("UpdateInfo", "NextStartTime", myUpdate._ConfigFile));
			isGetTime = true;
		}
		if (DateTime.Compare(Convert.ToDateTime(_0024STATIC_0024myTime_Tick_00240211C1255_0024StartTime), Convert.ToDateTime(DateAndTime.get_Now())) < 0)
		{
			myTime.set_Enabled(false);
			((Control)MyProject.Forms.frmMain).Show();
			isGetTime = false;
		}
	}

	public static void StartUpdate()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		((Control)MyProject.Forms.frmUpdate).Show();
		if (!myUpdate.UpdateRun())
		{
			Interaction.MsgBox((object)"كەچۈرۈڭ، ئاپتوماتىك نۇسخا يېڭىلاش مەشغۇلاتى ئوڭۇشلۇق بولمىدى، بەلكىم كومپيۇتېرىڭىز تورغا ئۇلانمىغان بولۇشى، ۋەياكى مۇلازىمېتىردا مەسىلە كۆرۈلگەن بولۇشى مۇمكىن، سەل تۇرۇپ قايتا سىناپ بېقىڭ", (MsgBoxStyle)48, (object)null);
			((Control)MyProject.Forms.frmMain).Show();
		}
		((Form)MyProject.Forms.frmUpdate).Close();
	}

	private static void myUpdate_StartProgram(string sFile)
	{
		short num = 0;
		checked
		{
			do
			{
				Application.DoEvents();
				num = (short)unchecked(num + 1);
			}
			while (num <= 1000);
		}
	}
}
