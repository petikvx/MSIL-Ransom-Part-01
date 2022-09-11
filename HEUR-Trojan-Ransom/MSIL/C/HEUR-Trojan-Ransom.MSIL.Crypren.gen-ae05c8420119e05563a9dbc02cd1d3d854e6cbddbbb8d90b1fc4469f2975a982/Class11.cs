using System;
using System.Collections;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;

internal sealed class Class11
{
	private ModuleBuilder moduleBuilder_0;

	private Hashtable hashtable_0;

	public Module module_0;

	public Class11()
	{
		hashtable_0 = new Hashtable();
		string text = default(string);
		Guid guid = default(Guid);
		AssemblyName assemblyName = default(AssemblyName);
		AssemblyBuilder assemblyBuilder = default(AssemblyBuilder);
		Module[] modules = default(Module[]);
		while (true)
		{
			int num = Class39.smethod_0(79);
			while (true)
			{
				switch (num)
				{
				case 1:
					goto IL_0013;
				case 0:
					text = guid.ToString();
					num = 7;
					goto case 7;
				case 7:
					assemblyName = new AssemblyName(text);
					num = 6;
					goto case 6;
				case 6:
					assemblyName.Version = new Version(1, 0, 0, 0);
					num = 4;
					goto case 4;
				case 4:
					assemblyBuilder = AppDomain.CurrentDomain.DefineDynamicAssembly(assemblyName, AssemblyBuilderAccess.Run);
					num = 2;
					goto case 2;
				case 2:
					moduleBuilder_0 = assemblyBuilder.DefineDynamicModule(text, false);
					num = 3;
					goto case 3;
				case 3:
					modules = moduleBuilder_0.Assembly.GetModules();
					num = 5;
					goto case 5;
				case 5:
					module_0 = modules[0];
					num = 8;
					return;
				case 8:
					return;
				}
				break;
				IL_0013:
				guid = Guid.NewGuid();
				num = Class39.smethod_0(92);
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
		FieldBuilder field = default(FieldBuilder);
		TypeBuilder typeBuilder = default(TypeBuilder);
		string text = default(string);
		Type typeFromHandle = default(Type);
		FieldBuilder field2 = default(FieldBuilder);
		Type typeFromHandle2 = default(Type);
		ConstructorInfo constructor = default(ConstructorInfo);
		ILGenerator iLGenerator = default(ILGenerator);
		MethodInfo method = default(MethodInfo);
		while (true)
		{
			int num = Class39.smethod_0(92);
			while (true)
			{
				switch (num)
				{
				case 10:
					field = typeBuilder.DefineField(text.Substring(0, 4), typeFromHandle, FieldAttributes.Private);
					while (true)
					{
						switch (Class39.smethod_0(79))
						{
						default:
							continue;
						case 1:
						{
							field2 = typeBuilder.DefineField(text.Substring(4, 4), typeFromHandle2, FieldAttributes.Private);
							int num4 = 0;
							goto case 0;
						}
						case 0:
						{
							num = Class10.smethod_0(87);
							int num4 = 2;
							break;
						}
						case 2:
							break;
						}
						break;
					}
					continue;
				case 9:
					typeFromHandle = typeof(DynamicMethod);
					typeFromHandle2 = typeof(Type);
					num = 10;
					goto case 10;
				case 8:
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
						switch (Class39.smethod_0(79))
						{
						default:
							continue;
						case 1:
						{
							iLGenerator.Emit(OpCodes.Ldarg_0);
							int num3 = 0;
							goto case 0;
						}
						case 0:
						{
							num = 4;
							int num3 = 2;
							break;
						}
						case 2:
							break;
						}
						break;
					}
					continue;
				}
				case 7:
					iLGenerator.Emit(OpCodes.Stfld, field2);
					iLGenerator.Emit(OpCodes.Ret);
					num = 1;
					goto case 1;
				case 1:
					iLGenerator = typeBuilder.DefineMethod(dynamicMethod_0.Name, MethodAttributes.Public | MethodAttributes.HideBySig, typeof(Delegate), new Type[1] { typeof(object) }).GetILGenerator();
					while (true)
					{
						switch (Class39.smethod_0(79))
						{
						default:
							continue;
						case 1:
						{
							method = typeof(DynamicMethod).GetMethod(Class33.smethod_0("\ue25e\ue26f\ue278\ue27c\ue269\ue278\ue259\ue278\ue271\ue278\ue27a\ue27c\ue269\ue278", 57885), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[2]
							{
								typeof(Type),
								typeof(object)
							}, null);
							int num2 = 0;
							goto case 0;
						}
						case 0:
						{
							num = 2;
							int num2 = 2;
							break;
						}
						case 2:
							break;
						}
						break;
					}
					continue;
				case 6:
					iLGenerator.Emit(OpCodes.Ldarg_0);
					iLGenerator.Emit(OpCodes.Ldarg_2);
					num = 7;
					goto case 7;
				case 5:
					iLGenerator.Emit(OpCodes.Ldarg_1);
					iLGenerator.Emit(OpCodes.Stfld, field);
					num = 6;
					goto case 6;
				case 4:
					iLGenerator.Emit(OpCodes.Call, constructor);
					iLGenerator.Emit(OpCodes.Ldarg_0);
					num = 5;
					goto case 5;
				case 0:
					text = guid.ToString();
					typeBuilder = moduleBuilder_0.DefineType(text, TypeAttributes.Public | TypeAttributes.Sealed | TypeAttributes.AutoClass, typeof(object));
					num = 9;
					goto case 9;
				case 2:
					iLGenerator.Emit(OpCodes.Ldarg_0);
					iLGenerator.Emit(OpCodes.Ldfld, field);
					num = 3;
					goto case 3;
				case 3:
					iLGenerator.Emit(OpCodes.Ldarg_0);
					iLGenerator.Emit(OpCodes.Ldfld, field2);
					num = 11;
					goto case 11;
				case 11:
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
			switch (Class39.smethod_0(79))
			{
			default:
				continue;
			case 1:
			{
				typeBuilder.DefineConstructor(MethodAttributes.Public | MethodAttributes.HideBySig | MethodAttributes.RTSpecialName, CallingConventions.Standard, new Type[2]
				{
					typeof(object),
					typeof(IntPtr)
				}).SetImplementationFlags(MethodImplAttributes.CodeTypeMask);
				int num = 0;
				goto case 0;
			}
			case 0:
			{
				typeBuilder.DefineMethod(Class33.smethod_0("\uee18\uee3f\uee27\uee3e\uee3a\uee34", 61009), MethodAttributes.Public | MethodAttributes.Virtual | MethodAttributes.HideBySig | MethodAttributes.VtableLayoutMask, type_0, type_1).SetImplementationFlags(MethodImplAttributes.CodeTypeMask);
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
		Type[] array = default(Type[]);
		int num2 = default(int);
		Type type = default(Type);
		while (true)
		{
			int num = Class39.smethod_0(92);
			while (true)
			{
				switch (num)
				{
				case 4:
					array = type_1;
					num = 1;
					goto case 1;
				case 1:
					num2 = 0;
					num = 2;
					goto case 2;
				case 2:
					if (num2 != 0)
					{
						goto IL_0026;
					}
					goto IL_0071;
				case 0:
					stringBuilder.Append(type_0.FullName);
					num = 4;
					goto case 4;
				case 3:
					type = array[num2];
					num = 5;
					goto case 5;
				case 5:
					stringBuilder.Append(type.FullName);
					num = 6;
					goto case 6;
				case 6:
					{
						num2++;
						goto IL_0071;
					}
					IL_0071:
					if (num2 >= array.Length)
					{
						return stringBuilder.ToString();
					}
					goto case 3;
				}
				break;
				IL_0026:
				num = Class39.smethod_0(78);
			}
		}
	}
}
