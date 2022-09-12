using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ns10;
using ns13;
using ns15;
using ns3;
using ns4;
using ns5;
using ns7;

namespace Newtonsoft.Json.Utilities;

internal static class EnumUtils
{
	private const char char_0 = ',';

	private const string string_0 = ", ";

	internal static readonly Class110<Struct5<Type, Class114?>, Class76> class110_0 = new Class110<Struct5<Type, Class114>, Class76>((Func<Struct5<Type, Class114>, Class76>)Class131.smethod_293);

	internal static Class115 class115_0 = new Class115();

	public static IList<T> smethod_0<T>(T gparam_0) where T : struct
	{
		Type typeFromHandle = typeof(T);
		if (!typeFromHandle.IsDefined(typeof(FlagsAttribute), inherit: false))
		{
			throw new ArgumentException("Enum type {0} is not a set of flags.".smethod_1(CultureInfo.InvariantCulture, typeFromHandle));
		}
		Type underlyingType = Enum.GetUnderlyingType(gparam_0.GetType());
		ulong num = Class131.smethod_176((object)gparam_0);
		Class76 @class = Class131.smethod_545(typeFromHandle);
		IList<T> list = new List<T>();
		for (int i = 0; i < @class.ulong_0.Length; i++)
		{
			ulong num2 = @class.ulong_0[i];
			if ((num & num2) == num2 && num2 != 0L)
			{
				list.Add((T)Convert.ChangeType(num2, underlyingType, CultureInfo.CurrentCulture));
			}
		}
		if (list.Count == 0 && @class.ulong_0.Any((ulong ulong_0) => ulong_0 == 0L))
		{
			list.Add(default(T));
		}
		return list;
	}
}
