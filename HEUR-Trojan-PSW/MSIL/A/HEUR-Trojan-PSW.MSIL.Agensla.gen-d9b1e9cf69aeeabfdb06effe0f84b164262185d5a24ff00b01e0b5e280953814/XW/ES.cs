using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace XW;

public class ES<St> where St : new()
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private IDictionary o1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private St B5;

	internal static object HF;

	public ES(IDictionary idictionary_0, St Uj)
	{
		G3.nJ(G3.By);
		base._002Ector();
		lv(idictionary_0);
		tG(Uj);
	}

	public ES()
	{
		G3.nJ(G3.By);
		base._002Ector();
	}

	public St u7()
	{
		IDictionaryEnumerator dictionaryEnumerator = Nq.nJ(lH(), Nq.c9);
		try
		{
			while (WM.nJ(dictionaryEnumerator, WM.gb))
			{
				DictionaryEntry dictionaryEntry_ = (DictionaryEntry)nZ.nJ(dictionaryEnumerator, nZ.SB);
				PropertyInfo propertyInfo = Uj(Xi.nJ(dx.nJ(ref dictionaryEntry_, dx.bR), Xi.l0));
				if (!Am.nJ(propertyInfo, null, Am.l1))
				{
					mg.nJ(propertyInfo, DU(), ys(dx.nJ(ref dictionaryEntry_, dx.cY), Hr.nJ(propertyInfo, Hr.hK)), null, mg.RD);
					continue;
				}
				break;
			}
		}
		finally
		{
			if (dictionaryEnumerator is IDisposable object_)
			{
				Su.nJ(object_, Su.D4);
			}
		}
		return DU();
	}

	private PropertyInfo Uj(string string_0)
	{
		Type object_ = aG.nJ(typeof(St).TypeHandle, aG.ta);
		return QA.nJ(object_, string_0, QA.Hv);
	}

	[SpecialName]
	[CompilerGenerated]
	private IDictionary lH()
	{
		return o1;
	}

	[SpecialName]
	[CompilerGenerated]
	private void lv(IDictionary idictionary_0)
	{
		o1 = idictionary_0;
	}

	[SpecialName]
	[CompilerGenerated]
	private St DU()
	{
		return B5;
	}

	[SpecialName]
	[CompilerGenerated]
	private void tG(St xh)
	{
		B5 = xh;
	}

	private object ys(object object_0, Type type_0)
	{
		string text = Xi.nJ(type_0, Xi.XH);
		string string_ = text;
		if (!Gn.nJ(string_, "String", Gn.co))
		{
			if (!Gn.nJ(string_, "Guid", Gn.co))
			{
				if (!Gn.nJ(string_, "Int32", Gn.co))
				{
					int num = 4;
					object result = default(object);
					while (!Gn.nJ(string_, "Boolean", Gn.co))
					{
						if (!Gn.nJ(string_, "Nullable`1", Gn.co))
						{
							if (!Gn.nJ(string_, "DateTime", Gn.co))
							{
								int num2 = 1;
								if (TV() != null)
								{
									num2 = num;
								}
								switch (num2)
								{
								case 4:
									continue;
								default:
									return object_0;
								case 2:
									break;
								case 3:
									return result;
								}
							}
							return H6.nJ(object_0 as string, H6.YF);
						}
						return xh(type_0, object_0);
					}
					return us.nJ(object_0, us.bV);
				}
				return te.nJ(object_0, te.uE);
			}
			return new Guid((string)object_0);
		}
		return object_0;
	}

	private object xh(Type type_0, object object_0)
	{
		NullableConverter object_ = new NullableConverter(type_0);
		Type object_2 = Hr.nJ(object_, Hr.IN);
		string text = Xi.nJ(object_2, Xi.XH);
		int num = 0;
		if (TV() == null)
		{
			goto IL_0031;
		}
		goto IL_0054;
		IL_0054:
		switch (num)
		{
		case 2:
			break;
		default:
			goto IL_0068;
		case 1:
			goto IL_009d;
		}
		goto IL_0031;
		IL_0031:
		string string_ = text;
		if (!Gn.nJ(string_, "Int32", Gn.co))
		{
			num = 0;
			if (TV() != null)
			{
				goto IL_0054;
			}
			goto IL_0068;
		}
		return RW.nJ((string)object_0, RW.cU);
		IL_0068:
		if (!Gn.nJ(string_, "DateTime", Gn.co))
		{
			if (!Gn.nJ(string_, "Guid", Gn.co))
			{
				return (int?)object_0;
			}
			goto IL_009d;
		}
		return (DateTime?)object_0;
		IL_009d:
		return (Guid?)object_0;
	}

	internal static bool T7()
	{
		return HF == null;
	}

	internal static object TV()
	{
		return HF;
	}
}
