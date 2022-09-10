using System;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0;

public class GClass5
{
	[DebuggerNonUserCode]
	public GClass5()
	{
		smethod_3(this);
	}

	public static string smethod_0(string string_0 = "", string string_1 = "", bool bool_0 = false)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Invalid comparison between Unknown and I4
		smethod_9();
		OpenFileDialog object_ = default(OpenFileDialog);
		if (!smethod_10())
		{
			object_ = new OpenFileDialog();
			smethod_4(object_, string_1);
			smethod_5(object_, bool_0);
			smethod_6(object_, string_0);
		}
		if ((int)smethod_7(object_) == 1)
		{
			return (string)smethod_8(object_);
		}
		return null;
	}

	public static string smethod_1(string string_0 = "", string string_1 = "", string string_2 = null)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Invalid comparison between Unknown and I4
		while (true)
		{
			SaveFileDialog object_ = new SaveFileDialog();
			while (true)
			{
				IL_0003:
				smethod_4(object_, string_1);
				smethod_10();
				if (!smethod_9())
				{
					goto IL_0072;
				}
				while (true)
				{
					smethod_6(object_, string_0);
					if (!smethod_9())
					{
						break;
					}
					switch (6)
					{
					case 7:
						break;
					case 1:
					case 2:
						continue;
					case 0:
						goto end_IL_0003;
					case 6:
						if (smethod_11(string_2, null, bool_0: false) == 0)
						{
							goto end_IL_0017;
						}
						goto IL_0072;
					default:
						goto IL_0072;
					case 5:
						goto IL_0079;
					case 3:
						goto end_IL_0017;
					case 9:
						goto IL_0089;
					}
					goto IL_0003;
					continue;
					end_IL_0017:
					break;
				}
				goto IL_0080;
				IL_0089:
				return (string)smethod_8(object_);
				IL_0072:
				smethod_12(object_, bool_0: true);
				goto IL_0079;
				IL_0079:
				smethod_13(object_, string_2);
				goto IL_0080;
				IL_0080:
				if ((int)smethod_7(object_) != 1)
				{
					return null;
				}
				goto IL_0089;
				continue;
				end_IL_0003:
				break;
			}
		}
	}

	public static object smethod_2(string string_0 = "", bool bool_0 = true, Environment.SpecialFolder specialFolder_0 = Environment.SpecialFolder.Desktop)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Invalid comparison between Unknown and I4
		FolderBrowserDialog object_ = new FolderBrowserDialog();
		smethod_14(object_, string_0);
		smethod_10();
		if (smethod_9())
		{
			smethod_15(object_, bool_0);
		}
		smethod_16(object_, specialFolder_0);
		if ((int)smethod_7(object_) == 1)
		{
			return smethod_17(object_);
		}
		return null;
	}

	internal static void smethod_3(object object_0)
	{
		object_0._002Ector();
	}

	internal static void smethod_4(object object_0, object object_1)
	{
		((FileDialog)object_0).set_Filter((string)object_1);
	}

	internal static void smethod_5(object object_0, bool bool_0)
	{
		((OpenFileDialog)object_0).set_Multiselect(bool_0);
	}

	internal static void smethod_6(object object_0, object object_1)
	{
		((FileDialog)object_0).set_Title((string)object_1);
	}

	internal static DialogResult smethod_7(object object_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((CommonDialog)object_0).ShowDialog();
	}

	internal static object smethod_8(object object_0)
	{
		return ((FileDialog)object_0).get_FileName();
	}

	internal static bool smethod_9()
	{
		return true;
	}

	internal static bool smethod_10()
	{
		return false;
	}

	internal static int smethod_11(object object_0, object object_1, bool bool_0)
	{
		return Operators.CompareString((string)object_0, (string)object_1, bool_0);
	}

	internal static void smethod_12(object object_0, bool bool_0)
	{
		((FileDialog)object_0).set_AddExtension(bool_0);
	}

	internal static void smethod_13(object object_0, object object_1)
	{
		((FileDialog)object_0).set_DefaultExt((string)object_1);
	}

	internal static void smethod_14(object object_0, object object_1)
	{
		((FolderBrowserDialog)object_0).set_Description((string)object_1);
	}

	internal static void smethod_15(object object_0, bool bool_0)
	{
		((FolderBrowserDialog)object_0).set_ShowNewFolderButton(bool_0);
	}

	internal static void smethod_16(object object_0, Environment.SpecialFolder specialFolder_0)
	{
		((FolderBrowserDialog)object_0).set_RootFolder(specialFolder_0);
	}

	internal static object smethod_17(object object_0)
	{
		return ((FolderBrowserDialog)object_0).get_SelectedPath();
	}
}
