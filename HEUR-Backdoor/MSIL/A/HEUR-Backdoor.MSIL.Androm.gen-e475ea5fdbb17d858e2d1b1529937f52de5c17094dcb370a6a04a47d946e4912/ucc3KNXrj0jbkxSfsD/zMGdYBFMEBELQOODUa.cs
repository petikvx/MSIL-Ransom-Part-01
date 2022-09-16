using System;
using System.Reflection;
using LvkKBh2A1CcgxuCWgH4;
using Pj91rV27dKBAsuQFb5U;
using WEVFYJ2WPuik8y16vgG;
using piO3af2M2LrtQb05a7e;

namespace ucc3KNXrj0jbkxSfsD;

internal class zMGdYBFMEBELQOODUa
{
	internal delegate void KFXTmfQjX2HON3Dytc(object o);

	internal static Module fwIINsZ8N7;

	internal static zMGdYBFMEBELQOODUa m1yIO4t5Fv;

	internal static void WmkInD1VKi(int int_0)
	{
		Type type = i0bIydskx3(fwIINsZ8N7, 33554432 + int_0);
		FieldInfo[] fields = type.GetFields();
		int num = 1;
		if (iaSIKrNEov() != null)
		{
			goto IL_0083;
		}
		goto IL_008e;
		IL_008e:
		int num2 = default(int);
		do
		{
			switch (num)
			{
			case 2:
			{
				FieldInfo fieldInfo = fields[num2];
				MethodInfo method = (MethodInfo)fwIINsZ8N7.ResolveMethod(fieldInfo.MetadataToken + 100663296);
				KvII3xtVSo(fieldInfo, null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
				num2++;
				goto IL_002b;
			}
			case 1:
				num2 = 0;
				goto IL_002b;
			default:
				return;
				IL_002b:
				if (num2 >= fields.Length)
				{
					break;
				}
				goto case 2;
			}
			num = 0;
		}
		while (lAJIUEKKCE());
		goto IL_0083;
		IL_0083:
		int num3 = default(int);
		num = num3;
		goto IL_008e;
	}

	public zMGdYBFMEBELQOODUa()
	{
		SRi2wG2ekq8Qq3o8MsP.BBNk2FYz0y7N1();
		qrfVDV24YoTFkucSFup.SUCTSny3c8();
		base._002Ector();
	}

	static zMGdYBFMEBELQOODUa()
	{
		nohvtg2Jq63jo2SldqX.Yg2TdiiKvR();
		SRi2wG2ekq8Qq3o8MsP.BBNk2FYz0y7N1();
		qrfVDV24YoTFkucSFup.SUCTSny3c8();
		fwIINsZ8N7 = Type.GetTypeFromHandle(lV1d122Lk6LtLgF6whN.bosk2F09Lv4q3(33554466)).Assembly.ManifestModule;
	}

	internal static Type i0bIydskx3(object object_0, int int_0)
	{
		return ((Module)object_0).ResolveType(int_0);
	}

	internal static void KvII3xtVSo(object object_0, object object_1, object object_2)
	{
		((FieldInfo)object_0).SetValue(object_1, object_2);
	}

	internal static bool lAJIUEKKCE()
	{
		return m1yIO4t5Fv == null;
	}

	internal static zMGdYBFMEBELQOODUa iaSIKrNEov()
	{
		return m1yIO4t5Fv;
	}
}
