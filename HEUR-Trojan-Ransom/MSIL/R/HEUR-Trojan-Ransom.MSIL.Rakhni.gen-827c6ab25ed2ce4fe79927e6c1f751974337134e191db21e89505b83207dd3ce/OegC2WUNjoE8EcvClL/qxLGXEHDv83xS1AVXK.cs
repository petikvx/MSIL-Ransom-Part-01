using System;
using System.Reflection;
using g1YNiPtPvSRBvAhXIq;
using gw3DRdpG9gZIr60hEO;
using qHZoQ70I3GAyXG32d6;

namespace OegC2WUNjoE8EcvClL;

internal class qxLGXEHDv83xS1AVXK
{
	internal delegate void LSXPl9CFiM75VJVxeL(object o);

	internal static Module QhS0XsUKK;

	internal static qxLGXEHDv83xS1AVXK RY6kHQo6FSyMpK1HmY;

	internal static void eM9Lcoxxx2gja(int typemdt)
	{
		Type type = cn2JdvAAyw0LvIdlw39(QhS0XsUKK, 33554432 + typemdt);
		FieldInfo[] fields = type.GetFields();
		int num = 0;
		if (rN2gQJAHw5NR9ELGk9K() != null)
		{
			goto IL_00a9;
		}
		goto IL_00ae;
		IL_00ae:
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			case 3:
			case 4:
				break;
			case 1:
				goto IL_006b;
			case 2:
				goto IL_0094;
			default:
				goto IL_00a9;
			}
			break;
			IL_0094:
			num2++;
			num = 3;
			if (zpLRROzxNGmAlM8lLy())
			{
				continue;
			}
			goto IL_008e;
		}
		goto IL_002e;
		IL_008e:
		int num3 = default(int);
		num = num3;
		goto IL_00ae;
		IL_00a9:
		num2 = 0;
		goto IL_002e;
		IL_002e:
		FieldInfo fieldInfo = default(FieldInfo);
		MethodInfo method = default(MethodInfo);
		if (num2 < fields.Length)
		{
			fieldInfo = fields[num2];
			method = (MethodInfo)QhS0XsUKK.ResolveMethod(PPJ5qrAUw5Ptcdcbm2I(fieldInfo) + 100663296);
			num = 0;
			if (rN2gQJAHw5NR9ELGk9K() == null)
			{
				goto IL_006b;
			}
			goto IL_00ae;
		}
		return;
		IL_006b:
		fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
		num = 2;
		if (rN2gQJAHw5NR9ELGk9K() != null)
		{
			goto IL_008e;
		}
		goto IL_00ae;
	}

	public qxLGXEHDv83xS1AVXK()
	{
		toV60DAqnk9CjLivEtp();
		base._002Ector();
	}

	static qxLGXEHDv83xS1AVXK()
	{
		J5LlPjhj0b2Nc1D9HG.PKPIlAlcr();
		iVZG9R1oqUZrSiIOLE.ExbLcoxzRwxZj();
		QhS0XsUKK = (Module)bmFYsqAip8yBhoJcAi6(Type.GetTypeFromHandle(LBxSG5ATq96qpwMA0Fe(33554445)).Assembly);
	}

	internal static Type cn2JdvAAyw0LvIdlw39(object object_0, int int_0)
	{
		return ((Module)object_0).ResolveType(int_0);
	}

	internal static int PPJ5qrAUw5Ptcdcbm2I(object object_0)
	{
		return ((MemberInfo)object_0).MetadataToken;
	}

	internal static bool zpLRROzxNGmAlM8lLy()
	{
		return RY6kHQo6FSyMpK1HmY == null;
	}

	internal static qxLGXEHDv83xS1AVXK rN2gQJAHw5NR9ELGk9K()
	{
		return RY6kHQo6FSyMpK1HmY;
	}

	internal static void toV60DAqnk9CjLivEtp()
	{
		iVZG9R1oqUZrSiIOLE.ExbLcoxzRwxZj();
	}

	internal static RuntimeTypeHandle LBxSG5ATq96qpwMA0Fe(int token)
	{
		return ViBwlnT746vjKBAiJi.bOHLco5kYYJmr(token);
	}

	internal static object bmFYsqAip8yBhoJcAi6(object object_0)
	{
		return ((Assembly)object_0).ManifestModule;
	}
}
