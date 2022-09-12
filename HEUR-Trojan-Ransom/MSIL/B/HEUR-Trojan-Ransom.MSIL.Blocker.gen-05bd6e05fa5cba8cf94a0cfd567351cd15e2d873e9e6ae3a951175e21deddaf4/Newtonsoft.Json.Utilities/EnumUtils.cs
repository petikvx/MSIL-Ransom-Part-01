using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ns0;
using ns10;
using ns11;
using ns13;
using ns17;
using ns5;
using ns7;

namespace Newtonsoft.Json.Utilities;

internal static class EnumUtils
{
	private const char char_0 = ',';

	private const string string_0 = ", ";

	internal static readonly Class111<Struct5<Type, Class115?>, Class77> class111_0 = new Class111<Struct5<Type, Class115>, Class77>((Func<Struct5<Type, Class115>, Class77>)Class4.smethod_172);

	internal static Class116 class116_0 = new Class116();

	public static IList<T> smethod_0<T>(T gparam_0) where T : struct
	{
		Type typeFromHandle = typeof(T);
		if (!typeFromHandle.IsDefined(typeof(FlagsAttribute), inherit: false))
		{
			throw new ArgumentException("Enum type {0} is not a set of flags.".smethod_1(CultureInfo.InvariantCulture, typeFromHandle));
		}
		Type underlyingType = Enum.GetUnderlyingType(gparam_0.GetType());
		ulong num = Class4.smethod_75((object)gparam_0);
		Class77 @class = Class4.smethod_762(typeFromHandle);
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
