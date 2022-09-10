using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace CNBC_MONEY_2009;

[StandardModule]
internal sealed class mdlMain
{
	public static string gUserName;

	public static string gDomain;

	public static string gConnection;

	public static string gMktstartTime;

	public static string gMktEndTime;

	public static string gExchangeSymbol;

	public static string gMain;

	public static int gLoginID;

	public static bool gExternal;

	[STAThread]
	public static void Main()
	{
		if (!CheckForExistingInstance())
		{
			return;
		}
		try
		{
			if (Operators.CompareString(Strings.LCase(Interaction.Command().Trim()), "e", false) != 0)
			{
				FTP_Downloadfile("CNBC_MONEY_StartUp.exe");
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		gExternal = Conversions.ToBoolean(Interaction.IIf(Operators.CompareString(Strings.LCase(Interaction.Command().Trim()), "e", false) == 0, (object)true, (object)false));
		if (Operators.CompareString(Interaction.Command().Trim(), "e", false) == 0)
		{
			gMain = "MAINE";
		}
		else
		{
			gMain = "MAIN";
		}
		MDIParent mDIParent = new MDIParent();
		Application.Run((Form)(object)mDIParent);
	}

	[DllImport("kernel32", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	private static extern int WritePrivateProfileStringW([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpApplicationName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpKeyName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpString, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpFileName);

	[DllImport("kernel32", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	private static extern int GetPrivateProfileStringW([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpApplicationName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpKeyName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpDefault, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpReturnedString, int nSize, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpFileName);

	public static void ShowMessage(string strMsg, string strCaption = "CNBC Money 2010")
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		frmMessage frmMessage2 = new frmMessage();
		frmMessage frmMessage3 = frmMessage2;
		frmMessage3.MsgCaption = strCaption;
		frmMessage3.MsgText = strMsg;
		((Form)frmMessage3).ShowDialog();
		frmMessage3 = null;
	}

	private static bool CheckForExistingInstance()
	{
		checked
		{
			bool result = default(bool);
			try
			{
				Process[] processesByName = Process.GetProcessesByName("CNBC_MONEY_2009");
				int num = processesByName.Length - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					if (DateAndTime.DateDiff((DateInterval)9, processesByName[num2].StartTime, DateAndTime.get_Now(), (FirstDayOfWeek)1, (FirstWeekOfYear)1) > 1L)
					{
						processesByName[num2].Kill();
					}
					num2++;
				}
				result = true;
				return result;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	public static string INIRead(string INIPath, string SectionName, string KeyName, string DefaultValue)
	{
		string lpReturnedString = Strings.Space(1024);
		int privateProfileStringW = GetPrivateProfileStringW(ref SectionName, ref KeyName, ref DefaultValue, ref lpReturnedString, lpReturnedString.Length, ref INIPath);
		if (privateProfileStringW > 0)
		{
			return lpReturnedString.Substring(0, privateProfileStringW);
		}
		return "";
	}

	public static void INIWrite(string INIPath, string SectionName, string KeyName, string TheValue)
	{
		WritePrivateProfileStringW(ref SectionName, ref KeyName, ref TheValue, ref INIPath);
	}

	public static void INI_Delete(string INIPath, string SectionName, string KeyName)
	{
		string lpString = null;
		WritePrivateProfileStringW(ref SectionName, ref KeyName, ref lpString, ref INIPath);
	}

	public static void INI_Delete(string INIPath, string SectionName)
	{
		string lpKeyName = null;
		string lpString = null;
		WritePrivateProfileStringW(ref SectionName, ref lpKeyName, ref lpString, ref INIPath);
	}

	private static void FTP_Downloadfile(object Filename)
	{
		string text = Conversions.ToString(File.GetLastWriteTime(Application.get_StartupPath() + "/CNBC_MONEY_StartUp.exe"));
		DateTime fileDetail = GetFileDetail();
		if (DateTime.Compare(fileDetail, DateTime.MinValue) != 0 && DateTime.Compare(fileDetail, Conversions.ToDate(text)) <= 0)
		{
			return;
		}
		clsFTP clsFTP2 = new clsFTP("192.168.30.152", "RTUpdate", "bse_ftp", "bse!ftp", 21);
		try
		{
			if (clsFTP2.Login())
			{
				try
				{
					clsFTP2.SetBinaryMode(bMode: true);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				try
				{
					clsFTP2.DownloadFile(Conversions.ToString(Filename));
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.EndApp();
					ProjectData.ClearProjectError();
				}
			}
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		clsFTP2.CloseConnection();
	}

	private static DateTime GetFileDetail()
	{
		try
		{
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create("ftp://192.168.30.152/RTUpdate/CNBC_MONEY_StartUp.exe");
			ftpWebRequest.Credentials = new NetworkCredential("bse_ftp", "bse!ftp");
			ftpWebRequest.UsePassive = false;
			ftpWebRequest.Method = "LIST";
			WebResponse response = ftpWebRequest.GetResponse();
			Stream responseStream = response.GetResponseStream();
			StreamReader streamReader = new StreamReader(responseStream);
			string text = "";
			text = streamReader.ReadToEnd();
			return Conversions.ToDate(Strings.Mid(text, 1, 17));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			DateTime minValue = DateTime.MinValue;
			ProjectData.ClearProjectError();
			return minValue;
		}
	}

	public static string INIRead(string INIPath, string SectionName, string KeyName)
	{
		return INIRead(INIPath, SectionName, KeyName, "");
	}

	public static string INIRead(string INIPath, string SectionName)
	{
		return INIRead(INIPath, SectionName, null, "");
	}

	public static string INIRead(string INIPath)
	{
		return INIRead(INIPath, null, null, "");
	}
}
