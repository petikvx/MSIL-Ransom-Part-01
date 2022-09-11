using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

namespace PreEmptive.Analytics.NET.Common;

public static class NetUtilities
{
	[CompilerGenerated]
	private sealed class Class6
	{
		public StringBuilder stringBuilder_0;

		public void method_0(MethodInfo methodInfo_0)
		{
			int num = -15613;
			int num2 = num;
			num = -15613;
			switch (num2 == num)
			{
			}
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			stringBuilder_0.Append(methodInfo_0.ReturnType);
		}
	}

	private static bool? nullable_0;

	internal static string smethod_0(this MethodBase methodBase_0)
	{
		int num = 14;
		int num2 = 30849;
		int num3 = num2;
		num2 = 30849;
		int num4;
		Class6 @class = default(Class6);
		ParameterInfo[] parameters = default(ParameterInfo[]);
		ParameterInfo[] array = default(ParameterInfo[]);
		int num5 = default(int);
		switch (num3 == num2)
		{
		default:
			if (0 == 0)
			{
			}
			switch (0)
			{
			}
			goto IL_0130;
		case false:
		case true:
			goto IL_0185;
			IL_0185:
			num2 = 6;
			num4 = num2;
			goto IL_0060;
			IL_0130:
			@class = new Class6();
			@class.stringBuilder_0 = new StringBuilder();
			methodBase_0.smethod_1<MethodInfo>(@class.method_0);
			@class.stringBuilder_0.Append("꺚");
			parameters = methodBase_0.GetParameters();
			array = parameters;
			num5 = 0;
			num2 = 4;
			num4 = num2;
			goto IL_0060;
			IL_0060:
			while (true)
			{
				switch (num4)
				{
				case 6:
					if (parameters.Length > 0)
					{
						num2 = 2;
						num4 = num2;
						continue;
					}
					goto case 5;
				case 1:
				case 4:
					num2 = 0;
					num4 = num2;
					continue;
				case 2:
					@class.stringBuilder_0.Remove(@class.stringBuilder_0.Length - 2, 2);
					num2 = 5;
					num4 = num2;
					continue;
				case 0:
					break;
				default:
					goto end_IL_0060;
				case 3:
					goto IL_0185;
				case 5:
					if (1 == 0)
					{
					}
					@class.stringBuilder_0.Append("꺛");
					return @class.stringBuilder_0.ToString();
				}
				if (num5 >= array.Length)
				{
					num2 = 3;
					num4 = num2;
					continue;
				}
				ParameterInfo arg = array[num5];
				@class.stringBuilder_0.Append(string.Format("껉늆뛏늒뺒", arg));
				num5++;
				num2 = 1;
				num4 = num2;
				continue;
				end_IL_0060:
				break;
			}
			goto IL_0130;
		}
	}

	internal static void smethod_1<T>(this object object_0, Action<T> action_0)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
			{
				if (!(object_0 is T))
				{
					return;
				}
				num = 29782;
				int num3 = num;
				num = 29782;
				switch (num3 == num)
				{
				default:
					if (0 == 0)
					{
					}
					num = 0;
					num2 = num;
					goto end_IL_0080;
				case false:
				case true:
					break;
				}
				goto case 1;
			}
			case 0:
				action_0((T)object_0);
				num = 1;
				num2 = num;
				break;
			case 1:
				{
					if (true)
					{
					}
					return;
				}
				end_IL_0080:
				break;
			}
		}
	}

	internal static string smethod_2(this string string_0, string string_1)
	{
		if (string_0.StartsWith(string_1))
		{
			int num = 4847;
			int num2 = num;
			num = 4847;
			switch (num2 == num)
			{
			default:
				if (1 == 0)
				{
				}
				if (false)
				{
				}
				break;
			case false:
			case true:
				break;
			}
			return string_0.Substring(string_1.Length);
		}
		return string_0;
	}

	internal static string smethod_3(this string string_0, string string_1)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			int num = -8076;
			int num2 = num;
			num = -8076;
			switch (num2 == num)
			{
			default:
				if (0 == 0)
				{
				}
				if (true)
				{
				}
				break;
			case false:
			case true:
				break;
			}
			return string_1;
		}
		return string_0;
	}

	internal static string smethod_4(this string string_0)
	{
		int num = 16;
		int num2 = 16280;
		int num3 = num2;
		num2 = 16280;
		switch (num3 == num2)
		{
		default:
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			return string_0.Replace("닪", "닩").Replace("늙", "닩").Replace("늞", "닭")
				.Replace("늟", "닫")
				.Replace("늕", "닩");
		}
	}

	public static bool RunningInMono()
	{
		int num = 18;
		int num2 = 2;
		int num3 = num2;
		while (true)
		{
			switch (num3)
			{
			default:
			{
				if (nullable_0.HasValue)
				{
					break;
				}
				num2 = 17957;
				int num4 = num2;
				num2 = 17957;
				switch (num4 == num2)
				{
				default:
					if (0 == 0)
					{
					}
					num2 = 0;
					num3 = num2;
					continue;
				case false:
				case true:
					break;
				}
				goto case 1;
			}
			case 0:
			{
				Type type = Type.GetType("뛿닑뻜닙뚜닼긧券嘦刷帿刳");
				nullable_0 = type != null;
				num2 = 1;
				num3 = num2;
				continue;
			}
			case 1:
				if (true)
				{
				}
				break;
			}
			break;
		}
		return nullable_0.Value;
	}

	static NetUtilities()
	{
		int num = -11722;
		int num2 = num;
		num = -11722;
		switch (num2 == num)
		{
		}
		if (1 == 0)
		{
		}
		if (0 == 0)
		{
		}
		nullable_0 = null;
	}
}
