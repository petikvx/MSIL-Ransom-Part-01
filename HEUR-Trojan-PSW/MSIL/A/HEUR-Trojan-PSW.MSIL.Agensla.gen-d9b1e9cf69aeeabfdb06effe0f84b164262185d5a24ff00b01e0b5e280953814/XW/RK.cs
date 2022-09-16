using System;
using System.Text.RegularExpressions;

namespace XW;

public static class RK
{
	internal static RK xqh;

	public static string jiE(this string string_0)
	{
		while (true)
		{
			bool flag = FXs.nJ(string_0, FXs.iXV);
			int num = 0;
			if (dqJ() == null)
			{
				goto IL_0003;
			}
			goto IL_0013;
			IL_0013:
			switch (num)
			{
			case 1:
				break;
			case 2:
				continue;
			default:
				goto IL_0043;
			}
			goto IL_0003;
			IL_0003:
			if (!flag)
			{
				break;
			}
			num = 0;
			if (dqJ() != null)
			{
				goto IL_0013;
			}
			goto IL_0043;
			IL_0043:
			return string_0;
		}
		Regex object_ = new Regex(ncj.nJ(ncj.num));
		return yyv.nJ(object_, string_0, yyv.nX6) ? ac3.nJ(object_, string_0, "<br />", ac3.rcp) : string_0;
	}

	public static string Liw(this string string_0)
	{
		if (FXs.nJ(string_0, FXs.iXV))
		{
			return string_0;
		}
		string result;
		while (true)
		{
			Regex object_ = new Regex("<br />");
			if (yyv.nJ(object_, string_0, yyv.nX6))
			{
				if (dqJ() != null)
				{
					switch (0)
					{
					case 1:
						continue;
					}
				}
				result = ac3.nJ(object_, string_0, ncj.nJ(ncj.num), ac3.rcp);
			}
			else
			{
				result = string_0;
			}
			break;
		}
		return result;
	}

	public static string Yik<Ez>(this Ez YW3)
	{
		return ju1.nJ(YW3, default(Ez), ju1.juY) ? string.Empty : Aur.nJ(aG.nJ(typeof(Ez).TypeHandle, aG.ta), YW3, Aur.ouK);
	}

	public static int Rif<KWW>(this string string_0)
	{
		return (int)Iug.nJ(aG.nJ(typeof(KWW).TypeHandle, aG.ta), string_0, bool_0: true, Iug.ouD);
	}

	public static VWL Mir<VWL>(this string string_0)
	{
		if (string_0 == null)
		{
			throw new ArgumentException("Cannot parse null string to enum.");
		}
		string_0 = Xi.nJ(string_0, Xi.Vym);
		if (IJa.nJ(string_0, IJa.xcX) == 0)
		{
			throw new ArgumentException("Cannot parse empty string.");
		}
		Type type = aG.nJ(typeof(VWL).TypeHandle, aG.ta);
		if (!WM.nJ(type, WM.Ru9))
		{
			throw new ArgumentException("This method can only be used on an enumeration type.");
		}
		return (VWL)Iug.nJ(type, string_0, bool_0: true, Iug.ouD);
	}

	public static int? diy(string string_0)
	{
		int int_ = default(int);
		return eub.nJ(string_0, ref int_, eub.yu4) ? new int?(int_) : null;
	}

	public static DateTime? yix(string string_0)
	{
		DateTime dateTime_ = default(DateTime);
		return yuG.nJ(string_0, ref dateTime_, yuG.pua) ? new DateTime?(dateTime_) : null;
	}

	public static Guid? niY(string string_0)
	{
		Guid? result;
		try
		{
			return new Guid(string_0);
		}
		catch (Exception object_)
		{
			result = null;
			ayW.nJ(Xi.nJ(object_, Xi.wXG), ayW.qcr);
		}
		return result;
	}

	internal static bool mqC()
	{
		return xqh == null;
	}

	internal static RK dqJ()
	{
		return xqh;
	}
}
