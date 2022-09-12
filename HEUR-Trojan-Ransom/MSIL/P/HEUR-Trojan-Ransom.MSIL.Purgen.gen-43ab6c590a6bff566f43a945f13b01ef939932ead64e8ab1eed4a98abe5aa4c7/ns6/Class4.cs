using System;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Security;
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;
using Microsoft.CodeAnalysis.BuildTasks;

namespace ns6;

internal static class Class4
{
	private const string string_0 = null;

	internal static bool smethod_0(ITaskItem itaskItem_0, string string_1)
	{
		string metadata = itaskItem_0.GetMetadata(string_1);
		if (metadata != null && metadata.Length != 0)
		{
			try
			{
				return smethod_1(metadata);
			}
			catch (ArgumentException exception_)
			{
				throw smethod_8(exception_, ErrorString.get_General_InvalidAttributeMetadata(), new object[4]
				{
					itaskItem_0.get_ItemSpec(),
					string_1,
					metadata,
					"吾娜吾М比娜弗弗比艾吾娜吾М比艾弗吾"
				});
			}
		}
		return false;
	}

	internal static bool smethod_1(string string_1)
	{
		if (smethod_3(string_1))
		{
			return true;
		}
		if (!smethod_4(string_1))
		{
			throw smethod_9(ErrorString.get_General_CannotConvertStringToBool(), new object[1] { string_1 });
		}
		return false;
	}

	internal static bool smethod_2(string string_1)
	{
		if (!smethod_3(string_1))
		{
			return smethod_4(string_1);
		}
		return true;
	}

	private static bool smethod_3(string string_1)
	{
		if (string.Compare(string_1, "吉勒勒贼艾克贼贼克艾克", StringComparison.OrdinalIgnoreCase) != 0 && string.Compare(string_1, "比比尔诶尔诶Щ比尔比诶", StringComparison.OrdinalIgnoreCase) != 0 && string.Compare(string_1, "伊Г维Г娜Г娜Г维维Г马Г艾艾Г伊维", StringComparison.OrdinalIgnoreCase) != 0 && string.Compare(string_1, "贼Х艾屁Х艾Х勒尔Х贼贼", StringComparison.OrdinalIgnoreCase) != 0 && string.Compare(string_1, "开吉吾克尔尔丝吾吉克", StringComparison.OrdinalIgnoreCase) != 0)
		{
			return string.Compare(string_1, "尺尺屁艾伊吾杰尺艾伊杰杰吾杰杰屁伊伊吾艾吾伊", StringComparison.OrdinalIgnoreCase) == 0;
		}
		return true;
	}

	private static bool smethod_4(string string_1)
	{
		if (string.Compare(string_1, "艾艾诶弗艾弗诶艾艾艾诶艾弗", StringComparison.OrdinalIgnoreCase) != 0 && string.Compare(string_1, "克哦杰艾杰迪艾克克", StringComparison.OrdinalIgnoreCase) != 0 && string.Compare(string_1, "西马马勒艾吉马艾勒勒西艾艾艾马艾西西吉吉马贝西贝吉吉勒西贝", StringComparison.OrdinalIgnoreCase) != 0 && string.Compare(string_1, "克Г艾杰ТГ艾艾Т艾克Г艾艾Т", StringComparison.OrdinalIgnoreCase) != 0 && string.Compare(string_1, "比屁屁哦屁屁Г哦屁屁屁比屁屁比屁Г屁", StringComparison.OrdinalIgnoreCase) != 0)
		{
			return string.Compare(string_1, "Т儿艾Т儿Т儿艾Т诶儿艾诶艾艾儿儿", StringComparison.OrdinalIgnoreCase) == 0;
		}
		return true;
	}

	internal static string smethod_5(string string_1)
	{
		try
		{
			string_1 = Path.GetFullPath(string_1);
			return string_1;
		}
		catch (Exception exception_) when (smethod_7(exception_))
		{
			return string_1;
		}
	}

	internal static void smethod_6(string string_1)
	{
		try
		{
			File.Delete(string_1);
		}
		catch (Exception exception_) when (smethod_7(exception_))
		{
		}
	}

	internal static bool smethod_7(Exception exception_0)
	{
		if (!(exception_0 is UnauthorizedAccessException) && !(exception_0 is NotSupportedException) && (!(exception_0 is ArgumentException) || exception_0 is ArgumentNullException) && !(exception_0 is SecurityException))
		{
			return exception_0 is IOException;
		}
		return true;
	}

	internal static Exception smethod_8(Exception exception_0, string string_1, object[] object_0)
	{
		return new ArgumentException(string.Format(CultureInfo.CurrentCulture, string_1, object_0), exception_0);
	}

	internal static Exception smethod_9(string string_1, object[] object_0)
	{
		return new ArgumentException(string.Format(CultureInfo.CurrentCulture, string_1, object_0));
	}

	internal static string smethod_10(Assembly assembly_0)
	{
		MethodInfo methodInfo = typeof(Assembly).GetTypeInfo().GetDeclaredProperty("吾马哦斯德马斯马斯吾马德马哦吾德哦马马德马德斯马哦斯马")?.GetMethod;
		if ((object)methodInfo == null)
		{
			return null;
		}
		return (string)methodInfo.Invoke(assembly_0, null);
	}

	public static string smethod_11(string string_1)
	{
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		string text = null;
		Assembly assembly = typeof(Class4).GetTypeInfo().get_Assembly();
		if ((bool?)typeof(Assembly).GetTypeInfo().GetDeclaredProperty("艾尺尺尺艾克艾勒З艾З克尺艾艾艾尺З尺艾勒克尺")?.GetMethod.Invoke(assembly, null) != true)
		{
			string text2 = (string)typeof(Assembly).GetTypeInfo().GetDeclaredProperty("吉Ш贝吾丝吉Ш")?.GetMethod.Invoke(assembly, null);
			if (text2 != null)
			{
				Uri val = new Uri(text2);
				string text3 = null;
				if (val.get_IsFile())
				{
					text3 = val.get_LocalPath();
				}
				else
				{
					string text4 = smethod_10((Assembly)(typeof(Assembly).GetTypeInfo().GetDeclaredMethod("Щ克И克Щ克克克克克弗吉")?.Invoke(null, null)));
					if (text4 != null)
					{
						text3 = text4;
					}
				}
				if (text3 != null)
				{
					string? directoryName = Path.GetDirectoryName(text3);
					string text5 = Path.Combine(directoryName, string_1);
					string text6 = Path.Combine(directoryName, "УМ艾М娜杰维УМ娜М", string_1);
					if (File.Exists(text5))
					{
						text = text5;
					}
					else if (File.Exists(text6))
					{
						text = text6;
					}
				}
			}
			if (text == null)
			{
				string pathToBuildTools = ToolLocationHelper.GetPathToBuildTools(ToolLocationHelper.get_CurrentToolsVersion(), (DotNetFrameworkArchitecture)1);
				if (pathToBuildTools != null)
				{
					string text7 = Path.Combine(pathToBuildTools, "德西西豆豆М德", string_1);
					if (File.Exists(text7))
					{
						text = text7;
					}
				}
			}
		}
		return text;
	}
}
