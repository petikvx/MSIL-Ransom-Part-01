using System;
using System.Globalization;
using System.Reflection;

internal sealed class Class30 : Binder
{
	private Type type_0;

	private Type[] type_1;

	private bool bool_0;

	public Class30(Type type_2)
	{
		type_0 = type_2;
	}

	public Class30(Type type_2, Type[] type_3)
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
			int num = Class13.smethod_4(37);
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
				num = Class13.smethod_4(38);
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
			int num = Class13.smethod_4(37);
			while (true)
			{
				int num3;
				switch (num)
				{
				case 1:
					goto IL_0006;
				case 0:
					array = match;
					num = 1;
					goto IL_0006;
				case 2:
					if (num2 == 0)
					{
						goto IL_00ae;
					}
					num = 4;
					goto case 4;
				case 5:
					if (false || methodBase.IsGenericMethodDefinition || 1 == 0)
					{
						goto IL_0052;
					}
					goto IL_00aa;
				case 3:
					if (bool_0)
					{
						num = 5;
						goto case 5;
					}
					goto IL_0052;
				case 4:
					{
						methodBase = array[num2];
						num = 3;
						goto case 3;
					}
					IL_0052:
					if (!bool_0 && 0 == 0)
					{
						if (methodBase.IsGenericMethodDefinition ? true : false)
						{
							goto IL_00aa;
						}
						while (true)
						{
							switch (Class13.smethod_4(37))
							{
							case 0:
								goto end_IL_006e;
							case 1:
								goto IL_0096;
							case 2:
								goto IL_00e2;
							}
							continue;
							end_IL_006e:
							break;
						}
					}
					parameters = methodBase.GetParameters();
					num3 = 1;
					goto IL_0096;
					IL_00ae:
					if (num2 >= array.Length)
					{
						return null;
					}
					goto case 4;
					IL_0096:
					if (method_0(parameters, args))
					{
						num3 = 2;
					}
					else if (true)
					{
						goto IL_00aa;
					}
					goto IL_00e2;
					IL_00aa:
					num2++;
					goto IL_00ae;
					IL_00e2:
					return methodBase;
				}
				break;
				IL_0006:
				num2 = 0;
				num = Class13.smethod_4(39);
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
		int num = 0;
		MethodBase methodBase = default(MethodBase);
		while (true)
		{
			int num2 = Class13.smethod_4(38);
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (num != 0)
					{
						goto IL_000a;
					}
					goto IL_00a3;
				case 0:
					methodBase = match[num];
					num2 = 2;
					goto case 2;
				case 2:
					if (!bool_0)
					{
						goto IL_0032;
					}
					num2 = 3;
					goto case 3;
				case 3:
					{
						if (false)
						{
							goto IL_0032;
						}
						if ((methodBase.IsGenericMethodDefinition || 1 == 0) && methodBase.GetGenericArguments().Length == type_1.Length)
						{
							goto IL_0040;
						}
						goto IL_009f;
					}
					IL_00a3:
					if (num >= match.Length)
					{
						return null;
					}
					goto case 0;
					IL_0032:
					if (!methodBase.IsGenericMethodDefinition && 0 == 0)
					{
						goto IL_0040;
					}
					goto IL_009f;
					IL_0040:
					if (methodBase is MethodInfo || 1 == 0)
					{
						MethodInfo methodInfo = (MethodInfo)methodBase;
						if (bool_0 || 1 == 0)
						{
							methodBase = (methodInfo = methodInfo.MakeGenericMethod(type_1));
						}
						if ((!methodInfo.ReturnType.Equals(type_0)) ? true : false)
						{
							goto IL_009f;
						}
					}
					if (smethod_0(methodBase.GetParameters(), types) || 1 == 0)
					{
						return methodBase;
					}
					goto IL_009f;
					IL_009f:
					num++;
					goto IL_00a3;
				}
				break;
				IL_000a:
				num2 = Class13.smethod_4(37);
			}
		}
	}

	public override PropertyInfo SelectProperty(BindingFlags bindingAttr, PropertyInfo[] match, Type returnType, Type[] indexes, ParameterModifier[] modifiers)
	{
		int num2 = default(int);
		PropertyInfo propertyInfo = default(PropertyInfo);
		while (true)
		{
			int num = Class13.smethod_4(37);
			while (true)
			{
				switch (num)
				{
				case 1:
					if (num2 != 0)
					{
						goto IL_0007;
					}
					goto IL_003f;
				case 0:
					num2 = 0;
					num = 1;
					goto case 1;
				case 3:
					propertyInfo = match[num2];
					num = 2;
					goto case 2;
				case 2:
					if (!propertyInfo.GetType().Equals(returnType))
					{
						goto IL_003b;
					}
					num = 4;
					goto case 4;
				case 4:
					{
						if (0 == 0 && (smethod_0(propertyInfo.GetIndexParameters(), indexes) || 1 == 0))
						{
							return propertyInfo;
						}
						goto IL_003b;
					}
					IL_003f:
					if (num2 >= match.Length)
					{
						return null;
					}
					goto case 3;
					IL_003b:
					num2++;
					goto IL_003f;
				}
				break;
				IL_0007:
				num = Class13.smethod_4(40);
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
