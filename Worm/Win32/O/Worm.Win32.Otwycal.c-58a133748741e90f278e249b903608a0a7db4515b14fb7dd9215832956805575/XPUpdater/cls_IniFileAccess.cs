using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace XPUpdater;

public class cls_IniFileAccess
{
	[DebuggerNonUserCode]
	public cls_IniFileAccess()
	{
	}

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetPrivateProfileStringA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpApplicationName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpKeyName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpDefault, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpReturnedString, int nSize, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpFileName);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int WritePrivateProfileStringA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpApplicationName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpKeyName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpString, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpFileName);

	public string GetKey(string part, string key, string path)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			FileInfo fileInfo = new FileInfo(path);
			if (!fileInfo.get_Exists())
			{
				Interaction.MsgBox((object)"你所指定的INI文件不存在！", (MsgBoxStyle)16, (object)"错误");
			}
			string lpReturnedString = new string(' ', 500);
			string lpDefault = string.Empty;
			int privateProfileStringA = GetPrivateProfileStringA(ref part, ref key, ref lpDefault, ref lpReturnedString, 500, ref path);
			return Strings.Left(lpReturnedString, privateProfileStringA);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Interaction.MsgBox((object)("错误：" + Conversions.ToString(Information.Err().get_Number()) + "\r\n" + Information.Err().get_Description()), (MsgBoxStyle)16, (object)"运行错误");
			string empty = string.Empty;
			ProjectData.ClearProjectError();
			return empty;
		}
	}

	public void SetKey(string part, string key, string value, string path)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		int try0001_dispatch = -1;
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num2 = 2;
					if (Operators.CompareString(FileSystem.Dir(path, (FileAttribute)0), "", false) == 0)
					{
						Interaction.MsgBox((object)"你所指定的INI文件不存在！", (MsgBoxStyle)16, (object)"错误");
					}
					else
					{
						WritePrivateProfileStringA(ref part, ref key, ref value, ref path);
					}
					goto end_IL_0001;
				case 150:
					num = -1;
					switch (num2)
					{
					case 2:
						Information.Err().get_Number();
						Interaction.MsgBox((object)("错误：" + Conversions.ToString(Information.Err().get_Number()) + "\r\n" + Information.Err().get_Description()), (MsgBoxStyle)16, (object)"运行错误");
						Information.Err().Clear();
						goto end_IL_0001;
					}
					break;
				}
				goto IL_00cc;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 150;
				continue;
			}
			break;
			IL_00cc:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}
}
