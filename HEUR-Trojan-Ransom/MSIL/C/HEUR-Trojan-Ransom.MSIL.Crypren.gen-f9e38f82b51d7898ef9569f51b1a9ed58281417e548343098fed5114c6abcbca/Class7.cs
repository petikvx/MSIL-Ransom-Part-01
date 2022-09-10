using System;
using System.Collections;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;

internal sealed class Class7
{
	private ModuleBuilder moduleBuilder_0;

	private Hashtable hashtable_0;

	public Module module_0;

	public Class7()
	{
		hashtable_0 = new Hashtable();
		AssemblyBuilder assemblyBuilder = default(AssemblyBuilder);
		string text = default(string);
		Module[] modules = default(Module[]);
		Guid guid = default(Guid);
		AssemblyName assemblyName = default(AssemblyName);
		while (true)
		{
			int num = Class9.smethod_4(40);
			while (true)
			{
				switch (num)
				{
				case 7:
					moduleBuilder_0 = assemblyBuilder.DefineDynamicModule(text, false);
					num = 1;
					goto case 1;
				case 1:
					modules = moduleBuilder_0.Assembly.GetModules();
					num = 0;
					goto IL_003b;
				case 0:
					goto IL_003b;
				case 6:
					text = guid.ToString();
					num = 5;
					goto case 5;
				case 5:
					assemblyName = new AssemblyName(text);
					num = 4;
					goto case 4;
				case 4:
					assemblyName.Version = new Version(1, 0, 0, 0);
					num = 2;
					goto case 2;
				case 2:
					assemblyBuilder = AppDomain.CurrentDomain.DefineDynamicAssembly(assemblyName, AssemblyBuilderAccess.Run);
					num = 7;
					goto case 7;
				case 3:
					guid = Guid.NewGuid();
					num = 6;
					goto case 6;
				case 8:
					return;
				}
				break;
				IL_003b:
				module_0 = modules[0];
				num = Class9.smethod_4(36);
			}
		}
	}

	internal Type method_0(string string_0, Type type_0, Type[] type_1)
	{
		string key = smethod_0(type_0, type_1);
		Type type = (Type)hashtable_0[key];
		if ((object)type != null || 1 == 0)
		{
			return type;
		}
		type = method_2(string_0, type_0, type_1);
		hashtable_0[key] = type;
		return type;
	}

	internal object method_1(DynamicMethod dynamicMethod_0, Type type_0)
	{
		Guid guid = Guid.NewGuid();
		ILGenerator iLGenerator = default(ILGenerator);
		FieldBuilder field2 = default(FieldBuilder);
		TypeBuilder typeBuilder = default(TypeBuilder);
		MethodInfo method = default(MethodInfo);
		FieldBuilder field = default(FieldBuilder);
		string text = default(string);
		Type typeFromHandle = default(Type);
		Type typeFromHandle2 = default(Type);
		ConstructorInfo constructor = default(ConstructorInfo);
		while (true)
		{
			int num = Class9.smethod_4(38);
			while (true)
			{
				switch (num)
				{
				case 11:
					iLGenerator.Emit(OpCodes.Ldarg_0);
					iLGenerator.Emit(OpCodes.Ldarg_2);
					num = 8;
					goto case 8;
				case 8:
					iLGenerator.Emit(OpCodes.Stfld, field2);
					iLGenerator.Emit(OpCodes.Ret);
					num = 5;
					goto case 5;
				case 5:
					iLGenerator = typeBuilder.DefineMethod(dynamicMethod_0.Name, MethodAttributes.Public | MethodAttributes.HideBySig, typeof(Delegate), new Type[1] { typeof(object) }).GetILGenerator();
					while (true)
					{
						switch (Class9.smethod_4(38))
						{
						default:
							continue;
						case 1:
						{
							method = typeof(DynamicMethod).GetMethod(Class29.smethod_0("\ue1df\ue1ee\ue1f9\ue1fd\ue1e8\ue1f9\ue1d8\ue1f9\ue1f0\ue1f9\ue1fb\ue1fd\ue1e8\ue1f9", 57756), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[2]
							{
								typeof(Type),
								typeof(object)
							}, null);
							int num4 = 0;
							goto case 0;
						}
						case 0:
						{
							num = 9;
							int num4 = 2;
							break;
						}
						case 2:
							break;
						}
						break;
					}
					continue;
				case 10:
					iLGenerator.Emit(OpCodes.Ldarg_1);
					iLGenerator.Emit(OpCodes.Stfld, field);
					num = 11;
					goto case 11;
				case 4:
					field = typeBuilder.DefineField(text.Substring(0, 4), typeFromHandle, FieldAttributes.Private);
					while (true)
					{
						switch (Class9.smethod_4(37))
						{
						default:
							continue;
						case 0:
						{
							field2 = typeBuilder.DefineField(text.Substring(4, 4), typeFromHandle2, FieldAttributes.Private);
							int num3 = 1;
							goto case 1;
						}
						case 1:
						{
							num = 2;
							int num3 = 2;
							break;
						}
						case 2:
							break;
						}
						break;
					}
					continue;
				case 3:
					iLGenerator.Emit(OpCodes.Call, constructor);
					iLGenerator.Emit(OpCodes.Ldarg_0);
					num = 10;
					goto case 10;
				case 2:
				{
					ConstructorBuilder constructorBuilder = typeBuilder.DefineConstructor(MethodAttributes.Public | MethodAttributes.HideBySig, CallingConventions.Standard, new Type[2]
					{
						typeof(DynamicMethod),
						typeof(Type)
					});
					constructor = typeof(object).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[0], null);
					iLGenerator = constructorBuilder.GetILGenerator();
					while (true)
					{
						switch (Class9.smethod_4(38))
						{
						default:
							continue;
						case 1:
						{
							iLGenerator.Emit(OpCodes.Ldarg_0);
							int num2 = 0;
							goto case 0;
						}
						case 0:
						{
							num = Class9.smethod_4(40);
							int num2 = 2;
							break;
						}
						case 2:
							break;
						}
						break;
					}
					continue;
				}
				case 1:
					text = guid.ToString();
					typeBuilder = moduleBuilder_0.DefineType(text, TypeAttributes.Public | TypeAttributes.Sealed | TypeAttributes.AutoClass, typeof(object));
					num = 0;
					goto case 0;
				case 0:
					typeFromHandle = typeof(DynamicMethod);
					typeFromHandle2 = typeof(Type);
					num = 4;
					goto case 4;
				case 9:
					iLGenerator.Emit(OpCodes.Ldarg_0);
					iLGenerator.Emit(OpCodes.Ldfld, field);
					num = 6;
					goto case 6;
				case 6:
					iLGenerator.Emit(OpCodes.Ldarg_0);
					iLGenerator.Emit(OpCodes.Ldfld, field2);
					num = 7;
					goto case 7;
				case 7:
					iLGenerator.Emit(OpCodes.Ldarg_1);
					iLGenerator.Emit(OpCodes.Callvirt, method);
					num = 12;
					goto case 12;
				case 12:
					iLGenerator.Emit(OpCodes.Ret);
					return Activator.CreateInstance(typeBuilder.CreateType(), dynamicMethod_0, type_0);
				}
				break;
			}
		}
	}

	private Type method_2(string string_0, Type type_0, Type[] type_1)
	{
		TypeBuilder typeBuilder = moduleBuilder_0.DefineType(string_0, TypeAttributes.Public | TypeAttributes.Sealed | TypeAttributes.AutoClass, typeof(MulticastDelegate));
		while (true)
		{
			switch (Class9.smethod_4(37))
			{
			default:
				continue;
			case 0:
			{
				typeBuilder.DefineConstructor(MethodAttributes.Public | MethodAttributes.HideBySig | MethodAttributes.RTSpecialName, CallingConventions.Standard, new Type[2]
				{
					typeof(object),
					typeof(IntPtr)
				}).SetImplementationFlags(MethodImplAttributes.CodeTypeMask);
				int num = 1;
				goto case 1;
			}
			case 1:
			{
				typeBuilder.DefineMethod(Class29.smethod_0("\ue3cf\ue3e8\ue3f0\ue3e9\ue3ed\ue3e3", 58246), MethodAttributes.Public | MethodAttributes.Virtual | MethodAttributes.HideBySig | MethodAttributes.VtableLayoutMask, type_0, type_1).SetImplementationFlags(MethodImplAttributes.CodeTypeMask);
				int num = 2;
				break;
			}
			case 2:
				break;
			}
			break;
		}
		return typeBuilder.CreateType();
	}

	private static string smethod_0(Type type_0, Type[] type_1)
	{
		if (type_1.Length == 0 && 0 == 0)
		{
			return type_0.FullName;
		}
		StringBuilder stringBuilder = new StringBuilder();
		int num2 = default(int);
		Type type = default(Type);
		Type[] array = default(Type[]);
		while (true)
		{
			int num = Class9.smethod_4(43);
			while (true)
			{
				switch (num)
				{
				case 6:
					num2++;
					goto IL_001d;
				case 2:
					type = array[num2];
					num = 5;
					goto IL_002a;
				case 5:
					goto IL_002a;
				case 4:
					stringBuilder.Append(type_0.FullName);
					num = 0;
					goto case 0;
				case 0:
					array = type_1;
					num = 3;
					goto case 3;
				case 3:
					num2 = 0;
					num = 1;
					goto case 1;
				case 1:
					{
						if (num2 == 0)
						{
							goto IL_001d;
						}
						num = 2;
						goto case 2;
					}
					IL_001d:
					if (num2 >= array.Length)
					{
						return stringBuilder.ToString();
					}
					goto case 2;
				}
				break;
				IL_002a:
				stringBuilder.Append(type.FullName);
				num = Class9.smethod_4(34);
			}
		}
	}

	internal static int smethod_1(int int_0)
	{
		if (int_0 == 35)
		{
			return 5;
		}
		return -1;
	}
}
