using System;
using System.Globalization;
using System.Reflection;

internal sealed class Class33 : Binder
{
	private Type type_0;

	private Type[] type_1;

	private bool bool_0;

	public Class33(Type type_2)
	{
		type_0 = type_2;
	}

	public Class33(Type type_2, Type[] type_3)
	{
		type_0 = type_2;
		type_1 = type_3;
		bool_0 = (type_3 != null || 1 == 0) && type_3.Length != 0;
	}

	public override FieldInfo BindToField(BindingFlags bindingAttr, FieldInfo[] match, object value, CultureInfo culture)
	{
		int num2 = default(int);
		FieldInfo fieldInfo = default(FieldInfo);
		while (true)
		{
			int num = Class42.smethod_0(92);
			while (true)
			{
				switch (num)
				{
				case 2:
					if (num2 != 0)
					{
						goto IL_0007;
					}
					goto IL_003f;
				case 0:
					num2 = 0;
					num = 2;
					goto case 2;
				case 1:
					fieldInfo = match[num2];
					num = 3;
					goto case 3;
				case 3:
					if (!fieldInfo.GetType().Equals(value.GetType()))
					{
						goto IL_003b;
					}
					num = 4;
					goto case 4;
				case 4:
					{
						if (0 == 0)
						{
							return fieldInfo;
						}
						goto IL_003b;
					}
					IL_003f:
					if (num2 >= match.Length)
					{
						return null;
					}
					goto case 1;
					IL_003b:
					num2++;
					goto IL_003f;
				}
				break;
				IL_0007:
				num = Class42.smethod_0(79);
			}
		}
	}

	public override MethodBase BindToMethod(BindingFlags bindingAttr, MethodBase[] match, ref object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] names, out object state)
	{
		state = null;
		MethodBase[] array = default(MethodBase[]);
		int num2 = default(int);
		MethodBase methodBase = default(MethodBase);
		ParameterInfo[] parameters = default(ParameterInfo[]);
		while (true)
		{
			int num = Class42.smethod_0(78);
			while (true)
			{
				switch (num)
				{
				case 4:
					goto IL_0006;
				case 3:
					array = match;
					num = 4;
					goto IL_0006;
				case 5:
					if (num2 == 0)
					{
						goto IL_005b;
					}
					num = 1;
					goto case 1;
				case 7:
					if (0 == 0)
					{
						return methodBase;
					}
					goto IL_0057;
				case 0:
					if (bool_0 != methodBase.IsGenericMethodDefinition)
					{
						goto IL_0057;
					}
					num = 2;
					goto case 2;
				case 2:
					parameters = methodBase.GetParameters();
					num = 6;
					goto case 6;
				case 6:
					if (method_0(parameters, args))
					{
						num = 7;
						goto case 7;
					}
					goto IL_0057;
				case 1:
					{
						methodBase = array[num2];
						num = 0;
						goto case 0;
					}
					IL_0057:
					num2++;
					goto IL_005b;
					IL_005b:
					if (num2 >= array.Length)
					{
						return null;
					}
					goto case 1;
				}
				break;
				IL_0006:
				num2 = 0;
				num = Class42.smethod_0(94);
			}
		}
	}

	public override object ChangeType(object value, Type type, CultureInfo culture)
	{
		try
		{
			return Convert.ChangeType(value, type);
		}
		catch (InvalidCastException)
		{
			return null;
		}
	}

	public override void ReorderArgumentArray(ref object[] args, object state)
	{
	}

	public override MethodBase SelectMethod(BindingFlags bindingAttr, MethodBase[] match, Type[] types, ParameterModifier[] modifiers)
	{
		MethodBase result = null;
		MethodBase methodBase = default(MethodBase);
		int num2 = default(int);
		while (true)
		{
			int num = Class42.smethod_0(82);
			while (true)
			{
				switch (num)
				{
				case 3:
					if (bool_0 != methodBase.IsGenericMethodDefinition)
					{
						goto IL_0091;
					}
					num = 1;
					goto case 1;
				case 1:
					if (bool_0)
					{
						goto IL_00c8;
					}
					if (true)
					{
						goto IL_000d;
					}
					goto case 5;
				case 5:
					if (methodBase.GetGenericArguments().Length == type_1.Length)
					{
						goto IL_000d;
					}
					goto IL_0091;
				case 4:
					methodBase = match[num2];
					num = 3;
					goto case 3;
				case 2:
					num2 = 0;
					num = 0;
					goto case 0;
				case 0:
					{
						if (num2 == 0)
						{
							goto IL_0076;
						}
						num = 4;
						goto case 4;
					}
					IL_0076:
					if (num2 < match.Length)
					{
						goto case 4;
					}
					goto IL_010c;
					IL_0091:
					num2++;
					goto IL_0076;
					IL_010c:
					return result;
					IL_000d:
					if (methodBase is MethodInfo || 1 == 0)
					{
						MethodInfo methodInfo = (MethodInfo)methodBase;
						if (bool_0 || 1 == 0)
						{
							try
							{
								methodBase = (methodInfo = methodInfo.MakeGenericMethod(type_1));
							}
							catch (Exception)
							{
								goto IL_0091;
							}
						}
						if ((!methodInfo.ReturnType.Equals(type_0)) ? true : false)
						{
							goto IL_0091;
						}
					}
					if ((!smethod_0(methodBase.GetParameters(), types)) ? true : false)
					{
						goto IL_0091;
					}
					result = methodBase;
					goto IL_010c;
				}
				break;
				IL_00c8:
				num = Class42.smethod_0(94);
			}
		}
	}

	public override PropertyInfo SelectProperty(BindingFlags bindingAttr, PropertyInfo[] match, Type returnType, Type[] indexes, ParameterModifier[] modifiers)
	{
		int num2 = default(int);
		PropertyInfo propertyInfo = default(PropertyInfo);
		while (true)
		{
			int num = Class42.smethod_0(82);
			while (true)
			{
				switch (num)
				{
				case 2:
					goto IL_0004;
				case 3:
					if (num2 == 0)
					{
						goto IL_0040;
					}
					num = 1;
					goto case 1;
				case 4:
					if (0 == 0 && (smethod_0(propertyInfo.GetIndexParameters(), indexes) || 1 == 0))
					{
						return propertyInfo;
					}
					goto IL_003c;
				case 0:
					if (propertyInfo.GetType().Equals(returnType))
					{
						num = 4;
						goto case 4;
					}
					goto IL_003c;
				case 1:
					{
						propertyInfo = match[num2];
						num = 0;
						goto case 0;
					}
					IL_003c:
					num2++;
					goto IL_0040;
					IL_0040:
					if (num2 >= match.Length)
					{
						return null;
					}
					goto case 1;
				}
				break;
				IL_0004:
				num2 = 0;
				num = Class42.smethod_0(78);
			}
		}
	}

	private bool method_0(ParameterInfo[] parameterInfo_0, object[] object_0)
	{
		if (parameterInfo_0.Length != object_0.Length)
		{
			return false;
		}
		int num = 0;
		while (true)
		{
			if (num < parameterInfo_0.Length)
			{
				if (!parameterInfo_0[num].ParameterType.Equals(object_0[num].GetType()) && 0 == 0)
				{
					break;
				}
				num++;
				continue;
			}
			return true;
		}
		return false;
	}

	private static bool smethod_0(ParameterInfo[] parameterInfo_0, Type[] type_2)
	{
		if (parameterInfo_0.Length != type_2.Length)
		{
			return false;
		}
		int num = 0;
		while (true)
		{
			if (num < parameterInfo_0.Length)
			{
				if (!parameterInfo_0[num].ParameterType.Equals(type_2[num]) && 0 == 0)
				{
					break;
				}
				num++;
				continue;
			}
			return true;
		}
		return false;
	}
}
