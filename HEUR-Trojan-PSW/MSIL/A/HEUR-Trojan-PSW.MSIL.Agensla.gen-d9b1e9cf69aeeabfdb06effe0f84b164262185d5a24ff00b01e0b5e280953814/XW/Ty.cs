using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;

namespace XW;

public static class Ty
{
	private static Ty Lqs;

	public static string miu(this Enum enum_0)
	{
		if (enum_0 == null)
		{
			throw new ArgumentNullException("value");
		}
		string text = Xi.nJ(enum_0, Xi.l0);
		FieldInfo object_ = vuc.nJ(Hr.nJ(enum_0, Hr.Rc1), text, vuc.Juu);
		Qr[] array = (Qr[])kuP.nJ(object_, aG.nJ(typeof(Qr).TypeHandle, aG.ta), bool_0: false, kuP.Eut);
		if (array != null && array.Length != 0)
		{
			int num = 0;
			if (!nqj())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			case 1:
			{
				string result = default(string);
				return result;
			}
			}
			text = lcz.nJ(array[0], lcz.zup);
		}
		return text;
	}

	public static IList rie(this Type type_0)
	{
		if (wuw.nJ(type_0, null, wuw.cuh))
		{
			throw new ArgumentNullException("type");
		}
		ArrayList arrayList = new ArrayList();
		Array object_ = cuM.nJ(type_0, cuM.cuI);
		IEnumerator enumerator = Iuf.nJ(object_, Iuf.Vu7);
		try
		{
			while (WM.nJ(enumerator, WM.gb))
			{
				Enum @enum = (Enum)nZ.nJ(enumerator, nZ.SB);
				quQ.nJ(arrayList, new KeyValuePair<Enum, string>(@enum, Nuk.nJ(@enum, Nuk.tud)), quQ.Muq);
			}
		}
		finally
		{
			if (enumerator is IDisposable object_2)
			{
				Su.nJ(object_2, Su.D4);
			}
		}
		return arrayList;
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public static IList riA<Gx>(this Type type_0)
	{
		if (wuw.nJ(type_0, null, wuw.cuh))
		{
			throw new ArgumentNullException("type");
		}
		if (!WM.nJ(type_0, WM.Ru9))
		{
			throw new ArgumentException("Must be an enumeration", "type");
		}
		ArrayList arrayList = new ArrayList();
		Array object_ = cuM.nJ(type_0, cuM.cuI);
		IEnumerator enumerator = Iuf.nJ(object_, Iuf.Vu7);
		try
		{
			while (WM.nJ(enumerator, WM.gb))
			{
				Enum @enum = (Enum)nZ.nJ(enumerator, nZ.SB);
				quQ.nJ(arrayList, new X8<Enum, Gx, string>(@enum, (Gx)aux.nJ(@enum, aG.nJ(typeof(Gx).TypeHandle, aG.ta), huZ.nJ(huZ.wuB), aux.KuR), Nuk.nJ(@enum, Nuk.tud)), quQ.Muq);
			}
		}
		finally
		{
			if (enumerator is IDisposable object_2)
			{
				Su.nJ(object_2, Su.D4);
			}
		}
		return arrayList;
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public static List<X8<Enum, AY, string>> ciC<AY>(this Type type_0)
	{
		if (wuw.nJ(type_0, null, wuw.cuh))
		{
			throw new ArgumentNullException("type");
		}
		if (!WM.nJ(type_0, WM.Ru9))
		{
			throw new ArgumentException("Must be an enumeration", "type");
		}
		List<X8<Enum, AY, string>> list = new List<X8<Enum, AY, string>>();
		Array object_ = cuM.nJ(type_0, cuM.cuI);
		IEnumerator enumerator = Iuf.nJ(object_, Iuf.Vu7);
		try
		{
			while (WM.nJ(enumerator, WM.gb))
			{
				Enum @enum = (Enum)nZ.nJ(enumerator, nZ.SB);
				list.Add(new X8<Enum, AY, string>(@enum, (AY)aux.nJ(@enum, aG.nJ(typeof(AY).TypeHandle, aG.ta), huZ.nJ(huZ.wuB), aux.KuR), Nuk.nJ(@enum, Nuk.tud)));
			}
		}
		finally
		{
			if (enumerator is IDisposable object_2)
			{
				Su.nJ(object_2, Su.D4);
			}
		}
		return list;
	}

	internal static bool nqj()
	{
		return Lqs == null;
	}

	internal static Ty jqG()
	{
		return Lqs;
	}
}
