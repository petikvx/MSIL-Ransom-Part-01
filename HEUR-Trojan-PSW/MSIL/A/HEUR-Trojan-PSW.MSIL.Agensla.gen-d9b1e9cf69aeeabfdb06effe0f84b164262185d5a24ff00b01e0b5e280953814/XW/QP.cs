using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Web.UI;

namespace XW;

public static class QP
{
	private static QP Yqd;

	public static string LLx(this string string_0, string string_1, HtmlTextWriterTag htmlTextWriterTag_0)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		string result = default(string);
		while (true)
		{
			bool flag = FXs.nJ(string_0, FXs.iXV);
			int num2 = 0;
			if (!aqU())
			{
				num2 = num;
			}
			while (true)
			{
				switch (num2)
				{
				default:
					if (!flag)
					{
						StringWriter stringWriter = new StringWriter();
						HtmlTextWriter val = new HtmlTextWriter((TextWriter)stringWriter);
						try
						{
							kXN.nJ(val, htmlTextWriterTag_0, kXN.eXW);
							Ew.nJ(val, string_1, Ew.GXU);
							Pyq.nJ(val, Pyq.NXj);
						}
						finally
						{
							if (val != null)
							{
								Su.nJ(val, Su.D4);
							}
						}
						result = yX8.nJ(string_0, string_1, Xi.nJ(stringWriter, Xi.l0), RegexOptions.IgnoreCase, yX8.vXT);
						num2 = 2;
						if (iqH() != null)
						{
							continue;
						}
					}
					else
					{
						result = null;
					}
					goto case 2;
				case 1:
					break;
				case 2:
					return result;
				}
				break;
			}
		}
	}

	public static string ILY(this string string_0, int int_0)
	{
		int num = 3;
		StringBuilder object_2 = default(StringBuilder);
		string[] array = default(string[]);
		int num3 = default(int);
		string result = default(string);
		string string_ = default(string);
		while (true)
		{
			bool flag = string_0 == null;
			int num2 = 2;
			if (!aqU())
			{
				break;
			}
			while (true)
			{
				switch (num2)
				{
				case 4:
					MXh.nJ(object_2, Lyn.nJ(array[num3], " ", Lyn.cyo), MXh.cXM);
					num3++;
					goto IL_000e;
				case 2:
				{
					if (flag)
					{
						result = string.Empty;
						num2 = 1;
						if (iqH() == null)
						{
							continue;
						}
						goto IL_0059;
					}
					Regex object_ = new Regex("\\s+");
					array = lX5.nJ(object_, string_0, lX5.gXl);
					if (array.Length > int_0)
					{
						object_2 = new StringBuilder();
						num3 = 0;
						goto IL_000e;
					}
					result = string_0;
					goto end_IL_00ca;
				}
				case 3:
					break;
				default:
					string_ = P3y.nJ(string_, P3y.vXC);
					result = Lyn.nJ(string_, "...", Lyn.cyo);
					goto end_IL_00ca;
				case 1:
					goto end_IL_00ca;
					IL_0059:
					num2 = num;
					continue;
					IL_000e:
					if (num3 < int_0)
					{
						goto case 4;
					}
					string_ = Xi.nJ(object_2, Xi.l0);
					num2 = 0;
					if (iqH() == null)
					{
						continue;
					}
					goto IL_0059;
				}
				break;
			}
			continue;
			end_IL_00ca:
			break;
		}
		return result;
	}

	[Obsolete("Use: CharLimit(this string input, int maxCharCount, bool addEllipsis)")]
	public static string PL8(this string string_0, int int_0)
	{
		string result;
		if (string_0 == null)
		{
			result = string.Empty;
			int num = 0;
			if (!aqU())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
		else
		{
			char[] source = oyx.nJ(string_0, oyx.uXL);
			result = ((source.Count() > int_0) ? NX2.nJ(string_0, 0, int_0, NX2.mXS) : string_0);
		}
		return result;
	}

	public static string ELn(this string string_0, int int_0, bool bool_0)
	{
		string result = default(string);
		if (string_0 == null)
		{
			int num = 0;
			if (iqH() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			while (true)
			{
				switch (num)
				{
				default:
					do
					{
						result = string.Empty;
						num = 1;
					}
					while (iqH() != null);
					continue;
				case 3:
					break;
				case 1:
				case 2:
					goto IL_00cb;
				}
				break;
			}
		}
		else
		{
			char[] source = oyx.nJ(string_0, oyx.uXL);
			if (source.Count() <= int_0)
			{
				result = string_0;
				goto IL_00cb;
			}
		}
		string text = NX2.nJ(string_0, 0, int_0, NX2.mXS);
		int num3 = wT.nJ(text, " ", wT.PXz);
		string string_ = ((num3 != -1) ? NX2.nJ(text, 0, num3, NX2.mXS) : text);
		string_ = P3y.nJ(string_, P3y.vXC);
		string string_2 = (bool_0 ? "..." : null);
		result = Lyn.nJ(string_, string_2, Lyn.cyo);
		goto IL_00cb;
		IL_00cb:
		return result;
	}

	private static string ALX(string string_0)
	{
		return FXs.nJ(string_0, FXs.iXV) ? string_0 : pcO.nJ(string_0, oyx.nJ(".;, ", oyx.xyR), pcO.icJ);
	}

	public static List<string> dLb(this string string_0, string string_1)
	{
		string[] array = null;
		if (!FXs.nJ(string_1, FXs.iXV) & !FXs.nJ(string_0, FXs.iXV))
		{
			array = GyZ.nJ(string_0, oyx.nJ(string_1, oyx.uXL), GyZ.fyB);
		}
		List<string> list = new List<string>();
		if (array != null)
		{
			string[] array2 = array;
			foreach (string item in array2)
			{
				list.Add(item);
			}
		}
		return list;
	}

	public static string dLc(this IEnumerable<string> ienumerable_0, string string_0)
	{
		if (ienumerable_0 == null || ienumerable_0.Count() < 1)
		{
			return null;
		}
		List<string> list = ienumerable_0.ToList();
		StringBuilder object_ = new StringBuilder();
		foreach (string item in list)
		{
			MXh.nJ(object_, item, MXh.cXM);
			if (list.IndexOf(item) != list.Count - 1)
			{
				MXh.nJ(object_, string_0, MXh.cXM);
			}
		}
		return Xi.nJ(object_, Xi.l0);
	}

	public static string GLg(this IEnumerable<string> ienumerable_0)
	{
		List<string> list = ienumerable_0.ToList();
		StringBuilder object_ = new StringBuilder();
		foreach (string item in list)
		{
			int num = list.IndexOf(item);
			int num2 = list.Count - 2;
			MXh.nJ(object_, item, MXh.cXM);
			if (num < num2)
			{
				MXh.nJ(object_, ", ", MXh.cXM);
			}
			if (num == num2)
			{
				MXh.nJ(object_, " and ", MXh.cXM);
			}
		}
		return Xi.nJ(object_, Xi.l0);
	}

	public static string SL0(this string string_0, char char_0)
	{
		string result = string.Empty;
		if (!FXs.nJ(string_0, FXs.iXV))
		{
			result = ac3.nJ(string_0, zya.nJ(ref char_0, zya.jyA), string.Empty, ac3.ncy);
			int num = 0;
			if (iqH() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
		return result;
	}

	[Obsolete("Use GetLede - which has identical function instead")]
	public static string oLl(this string string_0, int int_0)
	{
		if (string_0 == null || IJa.nJ(string_0, IJa.xcX) <= int_0)
		{
			goto IL_00cb;
		}
		string_0 = NX2.nJ(string_0, 0, int_0, NX2.mXS);
		int int_ = ((IJa.nJ(string_0, IJa.xcX) > 15) ? 15 : (IJa.nJ(string_0, IJa.xcX) - 1));
		string object_ = string_0;
		char[] array = new char[5];
		xcc.nJ(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, xcc.Icu);
		int num = ccP.nJ(object_, array, IJa.nJ(string_0, IJa.xcX) - 1, int_, ccP.Tct);
		if (num <= 0)
		{
			string_0 = NX2.nJ(string_0, 0, num, NX2.mXS);
		}
		string result = Lyn.nJ(string_0, " ...", Lyn.cyo);
		int num2 = 1;
		if (iqH() != null)
		{
			goto IL_00ba;
		}
		goto IL_00e1;
		IL_00cb:
		result = string_0;
		num2 = 2;
		if (iqH() != null)
		{
			int num3 = default(int);
			num2 = num3;
		}
		goto IL_00ba;
		IL_00ba:
		switch (num2)
		{
		case 1:
		case 2:
			goto IL_00e1;
		}
		goto IL_00cb;
		IL_00e1:
		return result;
	}

	public static string sLd(this string string_0)
	{
		if (string_0 != null)
		{
			int num = 0;
			if (!aqU())
			{
				int num2 = default(int);
				num = num2;
			}
			Regex object_ = default(Regex);
			while (true)
			{
				switch (num)
				{
				case 1:
					return ac3.nJ(object_, string_0, " ", ac3.rcp);
				}
				do
				{
					object_ = new Regex("<!--.*?-->|<[^>]*>|<[a-z]*>|<\\/[a-z]*>|<\\/[a-z]*$|^[a-z]*>|^\\/[a-z]*>|<[a-z]*$|[a-z]*>");
					num = 1;
				}
				while (!aqU());
			}
		}
		return string.Empty;
	}

	public static string nLV(int? nullable_0)
	{
		if (!nullable_0.HasValue)
		{
			return "Not specified.";
		}
		TimeSpan timeSpan_ = new TimeSpan(0, 0, nullable_0.Value, 0);
		int int_;
		if (Ycw.nJ(ref timeSpan_, Ycw.nch) > 0)
		{
			int_ = Gcf.nJ(ccM.nJ(ref timeSpan_, ccM.ycI), Gcf.yc7);
			return Lyn.nJ(Nck.nJ(ref int_, Nck.Mcd), " hours", Lyn.cyo);
		}
		if (Ycw.nJ(ref timeSpan_, Ycw.ocQ) > 1 && Ycw.nJ(ref timeSpan_, Ycw.Ecq) > 0)
		{
			return Yc9.nJ("{0} hours {1} mins", Ycw.nJ(ref timeSpan_, Ycw.ocQ), Ycw.nJ(ref timeSpan_, Ycw.Ecq), Yc9.wcZ);
		}
		if (Ycw.nJ(ref timeSpan_, Ycw.ocQ) > 1)
		{
			return HcB.nJ("{0} hours", Ycw.nJ(ref timeSpan_, Ycw.ocQ), HcB.ncx);
		}
		if (Ycw.nJ(ref timeSpan_, Ycw.ocQ) == 1 && Ycw.nJ(ref timeSpan_, Ycw.Ecq) > 0)
		{
			return HcB.nJ("1 hour {0} mins", Ycw.nJ(ref timeSpan_, Ycw.Ecq), HcB.ncx);
		}
		if (Ycw.nJ(ref timeSpan_, Ycw.ocQ) == 1)
		{
			return "1 hour";
		}
		int_ = Ycw.nJ(ref timeSpan_, Ycw.Ecq);
		return Lyn.nJ(Nck.nJ(ref int_, Nck.Mcd), " mins", Lyn.cyo);
	}

	public static string ELR(this string string_0)
	{
		if (FXs.nJ(string_0, FXs.iXV))
		{
			return " ";
		}
		return Lyn.nJ(string_0, " ", Lyn.cyo);
	}

	public static string hLO(this string string_0, string string_1)
	{
		if (FXs.nJ(string_0, FXs.iXV))
		{
			return null;
		}
		return Lyn.nJ(string_0, string_1, Lyn.cyo);
	}

	public static string JLM(this string string_0, int int_0, int int_1)
	{
		if (FXs.nJ(string_0, FXs.iXV))
		{
			return string.Empty;
		}
		string text = scR.nJ(string_0, int_0, scR.Kci);
		if (iqH() == null)
		{
			switch (0)
			{
			case 1:
			{
				string result = default(string);
				return result;
			}
			}
		}
		return (IJa.nJ(text, IJa.xcX) <= int_1) ? text : NX2.nJ(text, 0, int_1, NX2.mXS);
	}

	internal static bool aqU()
	{
		return Yqd == null;
	}

	internal static QP iqH()
	{
		return Yqd;
	}
}
