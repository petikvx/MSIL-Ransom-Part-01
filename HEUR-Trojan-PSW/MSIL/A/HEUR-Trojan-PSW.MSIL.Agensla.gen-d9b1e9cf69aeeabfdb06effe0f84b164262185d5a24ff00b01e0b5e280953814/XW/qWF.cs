using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Web.Configuration;

namespace XW;

public class qWF
{
	private List<object> aaL;

	public readonly object pai;

	private static qWF Nqn;

	public qWF(object object_0)
	{
		G3.nJ(G3.By);
		aaL = new List<object>();
		base._002Ector();
		pai = object_0;
	}

	public string jiK()
	{
		string result = default(string);
		if (pai == null)
		{
			result = string.Empty;
			goto IL_00ce;
		}
		StringBuilder object_ = new StringBuilder();
		string string_ = zuS.nJ(this, pai, 1, zuS.uuz);
		MXh.nJ(object_, string_, MXh.cXM);
		List<object>.Enumerator enumerator = aaL.GetEnumerator();
		int num = 0;
		if (fqR() != null)
		{
			goto IL_005b;
		}
		goto IL_00bf;
		IL_00ce:
		return result;
		IL_005b:
		try
		{
			while (enumerator.MoveNext())
			{
				object current = enumerator.Current;
				string string_2 = zuS.nJ(this, current, 2, zuS.uuz);
				MXh.nJ(object_, string_2, MXh.cXM);
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
		result = Xi.nJ(object_, Xi.l0);
		num = 1;
		if (!Hqc())
		{
			int num2 = default(int);
			num = num2;
		}
		goto IL_00bf;
		IL_00bf:
		switch (num)
		{
		case 1:
			goto IL_00ce;
		}
		goto IL_005b;
	}

	public string XiT()
	{
		return Lyn.nJ(lcz.nJ(this, lcz.jPO), ((FormsAuthPasswordFormat)2).Yik<FormsAuthPasswordFormat>(), Lyn.QPJ);
	}

	private string oiz(object object_0, int int_0)
	{
		Type object_ = Hr.nJ(object_0, Hr.Rc1);
		StringBuilder object_2 = new StringBuilder();
		PropertyInfo[] array = lcK.nJ(object_, lcK.Ocg);
		int num3 = default(int);
		object obj = default(object);
		FieldInfo fieldInfo = default(FieldInfo);
		FieldInfo[] array3 = default(FieldInfo[]);
		bool flag = default(bool);
		PropertyInfo propertyInfo = default(PropertyInfo);
		object obj2 = default(object);
		FieldInfo[] array4 = default(FieldInfo[]);
		int num4 = default(int);
		while (true)
		{
			IL_016c:
			PropertyInfo[] array2 = array;
			int num = 0;
			int num2 = 0;
			if (fqR() != null)
			{
				goto IL_003f;
			}
			goto IL_0132;
			IL_0132:
			while (true)
			{
				switch (num2)
				{
				case 9:
					break;
				default:
					goto IL_003f;
				case 1:
					goto IL_0096;
				case 11:
					goto IL_016c;
				case 8:
					num3 = 0;
					goto IL_0248;
				case 7:
					obj = kPt.nJ(fieldInfo, object_0, kPt.mPp);
					goto case 4;
				case 4:
					if (aPw.nJ(this, fieldInfo, aPw.KPh))
					{
						if (!FXs.nJ(Xi.nJ(fieldInfo, Xi.XH), FXs.iXV))
						{
							goto case 6;
						}
					}
					else
					{
						MXh.nJ(rPX.nJ(MXh.nJ(MXh.nJ(object_2, Xi.nJ(fieldInfo, Xi.XH), MXh.cXM), ":", MXh.cXM), obj, rPX.EPc), "|", MXh.cXM);
					}
					goto case 3;
				case 6:
					if (int_0 != 1)
					{
						if (int_0 != 2)
						{
							goto end_IL_016c;
						}
					}
					else
					{
						aaL.Add(obj);
					}
					goto case 3;
				case 3:
					num3++;
					goto IL_0248;
				case 5:
					goto end_IL_016c;
				case 10:
					{
						return Xi.nJ(object_2, Xi.l0);
					}
					IL_0248:
					if (num3 < array3.Length)
					{
						fieldInfo = array3[num3];
						goto case 7;
					}
					goto case 10;
				}
				break;
				IL_0096:
				if (flag)
				{
					if (!FXs.nJ(Xi.nJ(propertyInfo, Xi.XH), FXs.iXV))
					{
						switch (int_0)
						{
						case 1:
							aaL.Add(obj2);
							break;
						case 2:
							break;
						default:
							return Xi.nJ(object_2, Xi.l0);
						}
					}
				}
				else
				{
					MXh.nJ(rPX.nJ(MXh.nJ(MXh.nJ(object_2, Xi.nJ(propertyInfo, Xi.XH), MXh.cXM), ":", MXh.cXM), obj2, rPX.EPc), "|", MXh.cXM);
				}
				num++;
				num2 = 0;
				if (fqR() != null)
				{
					continue;
				}
				goto IL_003f;
			}
			goto IL_0027;
			IL_003f:
			if (num >= array2.Length)
			{
				array4 = WPu.nJ(object_, WPu.aPP);
				goto IL_0027;
			}
			propertyInfo = array2[num];
			obj2 = pj.nJ(propertyInfo, object_0, null, pj.h8);
			flag = jP3.nJ(this, propertyInfo, jP3.HPy);
			num2 = 1;
			if (fqR() != null)
			{
				num2 = num4;
			}
			goto IL_0132;
			IL_0027:
			array3 = array4;
			num2 = 8;
			if (fqR() != null)
			{
				break;
			}
			goto IL_0132;
			continue;
			end_IL_016c:
			break;
		}
		return Xi.nJ(object_2, Xi.l0);
	}

	private bool da3(PropertyInfo propertyInfo_0)
	{
		int num = 1;
		int result;
		while (true)
		{
			if (WM.nJ(Hr.nJ(propertyInfo_0, Hr.hK), WM.hPM))
			{
				int num2 = 0;
				if (!Hqc())
				{
					num2 = num;
				}
				switch (num2)
				{
				case 1:
					continue;
				}
				if (!WM.nJ(Hr.nJ(propertyInfo_0, Hr.hK), WM.HPI) && !WM.nJ(Hr.nJ(propertyInfo_0, Hr.hK), WM.pPf))
				{
					result = (Gn.nJ(lcz.nJ(Hr.nJ(propertyInfo_0, Hr.hK), lcz.QP7), "System.String", Gn.jPk) ? 1 : 0);
					break;
				}
			}
			result = 0;
			break;
		}
		return (byte)result != 0;
	}

	private bool faW(FieldInfo fieldInfo_0)
	{
		int result;
		if (WM.nJ(Hr.nJ(fieldInfo_0, Hr.sPd), WM.hPM) && !WM.nJ(Hr.nJ(fieldInfo_0, Hr.sPd), WM.HPI))
		{
			int num = 0;
			if (fqR() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			if (!WM.nJ(Hr.nJ(fieldInfo_0, Hr.sPd), WM.pPf))
			{
				result = (Gn.nJ(lcz.nJ(Hr.nJ(fieldInfo_0, Hr.sPd), lcz.QP7), "System.String", Gn.jPk) ? 1 : 0);
				goto IL_0086;
			}
		}
		result = 0;
		goto IL_0086;
		IL_0086:
		return (byte)result != 0;
	}

	internal static bool Hqc()
	{
		return Nqn == null;
	}

	internal static qWF fqR()
	{
		return Nqn;
	}
}
