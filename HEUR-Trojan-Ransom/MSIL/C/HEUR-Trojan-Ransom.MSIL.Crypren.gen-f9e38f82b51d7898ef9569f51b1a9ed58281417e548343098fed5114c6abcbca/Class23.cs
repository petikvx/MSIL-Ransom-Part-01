using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;

internal sealed class Class23 : IDisposable
{
	private sealed class Class24
	{
		internal delegate Stream Delegate0(Stream stream_0);

		public static Stream smethod_0(Stream stream_0)
		{
			DynamicMethod dynamicMethod = new DynamicMethod(Guid.NewGuid().ToString(), typeof(Stream), new Type[1] { typeof(Stream) }, typeof(Class24).Module);
			smethod_1(dynamicMethod.GetILGenerator());
			return ((Delegate0)dynamicMethod.CreateDelegate(typeof(Delegate0)))(stream_0);
		}

		private static void smethod_1(ILGenerator ilgenerator_0)
		{
			Type type = Type.GetType(Class29.smethod_0("\uf7f6\uf7dc\uf7d6\uf7d1\uf7c0\uf7c8\uf78b\uf7e1\uf7cc\uf7c4\uf7c2\uf7cb\uf7ca\uf7d6\uf7d1\uf7cc\uf7c6\uf7d6\uf78b\uf7f6\uf7d1\uf7c4\uf7c6\uf7ce\uf7f1\uf7d7\uf7c4\uf7c6\uf7c0", 63397));
			ConstructorInfo constructor = type.GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[0], null);
			ParameterInfo[] parameters = default(ParameterInfo[]);
			MethodInfo methodInfo2 = default(MethodInfo);
			MethodInfo methodInfo = default(MethodInfo);
			MethodInfo[] methods = default(MethodInfo[]);
			int num2 = default(int);
			MethodInfo method = default(MethodInfo);
			MethodInfo method2 = default(MethodInfo);
			MethodInfo method3 = default(MethodInfo);
			MethodInfo method4 = default(MethodInfo);
			MethodInfo method5 = default(MethodInfo);
			MethodInfo method6 = default(MethodInfo);
			Label label5 = default(Label);
			Label label2 = default(Label);
			Label label = default(Label);
			Label label4 = default(Label);
			Label label3 = default(Label);
			while (true)
			{
				int num = Class9.smethod_4(33);
				while (true)
				{
					switch (num)
					{
					case 3:
						parameters = methodInfo2.GetParameters();
						num = 8;
						goto case 8;
					case 8:
						if (parameters != null)
						{
							goto IL_00a5;
						}
						if (true)
						{
							goto IL_002e;
						}
						goto case 13;
					case 13:
						if (((!methodInfo2.IsStatic) ? true : false) || parameters.Length != 1 || ((!(parameters[0].ParameterType.Name == Class29.smethod_0("\uf2cb\uf2ec\uf2ea\uf2fd\uf2f9\uf2f5", 62104))) ? true : false))
						{
							goto IL_002e;
						}
						methodInfo = methodInfo2;
						goto IL_0262;
					case 1:
						methodInfo2 = methods[num2];
						num = 3;
						goto case 3;
					case 12:
						methods = typeof(Class8).GetMethods(BindingFlags.Static | BindingFlags.NonPublic);
						num = 0;
						goto case 0;
					case 0:
						num2 = 0;
						num = 11;
						goto case 11;
					case 11:
						if (num2 == 0)
						{
							goto IL_0034;
						}
						num = 1;
						goto case 1;
					case 10:
						method = type.GetMethod(Class29.smethod_0("\uf086\uf0a4\uf0b5\uf087\uf0b3\uf0a0\uf0ac\uf0a4", 61633), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[1] { typeof(int) }, null);
						num = 2;
						goto case 2;
					case 2:
						method2 = Type.GetType(Class29.smethod_0("\uebc3\uebe9\uebe3\uebe4\uebf5\uebfd\uebbe\uebd4\uebf9\uebf1\uebf7\uebfe\uebff\uebe3\uebe4\uebf9\uebf3\uebe3\uebbe\uebc3\uebe4\uebf1\uebf3\uebfb\uebd6\uebe2\uebf1\uebfd\uebf5", 60304))!.GetMethod(Class29.smethod_0("\uec6c\uec4e\uec5f\uec66\uec4e\uec5f\uec43\uec44\uec4f", 60459), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[0], null);
						num = 9;
						goto case 9;
					case 9:
						method3 = typeof(MemberInfo).GetMethod(Class29.smethod_0("\ue4c8\ue4ca\ue4db\ue4f0\ue4eb\ue4ca\ue4cc\ue4c3\ue4ce\ue4dd\ue4c6\ue4c1\ue4c8\ue4fb\ue4d6\ue4df\ue4ca", 58543), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[0], null);
						num = 5;
						goto case 5;
					case 5:
						method4 = typeof(Type).GetMethod(Class29.smethod_0("\uf10f\uf10d\uf11c\uf137\uf12e\uf11d\uf104\uf104\uf126\uf109\uf105\uf10d", 61800), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[0], null);
						num = 4;
						goto case 4;
					case 4:
						method5 = typeof(string).GetMethod(Class29.smethod_0("\uf8a6\uf881\uf88b\uf88a\uf897\uf8a0\uf889", 63727), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[2]
						{
							typeof(string),
							typeof(StringComparison)
						}, null);
						num = 7;
						goto case 7;
					case 7:
						method6 = type.GetMethod(Class29.smethod_0("\ueea0\ueea2\ueeb3\uee98\uee81\ueeb5\ueea6\ueeaa\ueea2\uee84\ueea8\ueeb2\ueea9\ueeb3", 61127), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[0], null);
						num = 6;
						goto case 6;
					case 6:
						{
							methodInfo = null;
							num = 12;
							goto case 12;
						}
						IL_0034:
						if (num2 < methods.Length)
						{
							goto case 1;
						}
						goto IL_0262;
						IL_002e:
						num2++;
						goto IL_0034;
						IL_0262:
						if (object.Equals(methodInfo, null) || 1 == 0)
						{
							Class8.smethod_0(null);
						}
						ilgenerator_0.DeclareLocal(type);
						while (true)
						{
							int num3 = Class9.smethod_4(42);
							while (true)
							{
								switch (num3)
								{
								case 21:
									label5 = ilgenerator_0.DefineLabel();
									label2 = ilgenerator_0.DefineLabel();
									ilgenerator_0.Emit(OpCodes.Newobj, constructor);
									num3 = 4;
									goto case 4;
								case 4:
									ilgenerator_0.Emit(OpCodes.Stloc_0);
									ilgenerator_0.Emit(OpCodes.Ldc_I4_0);
									ilgenerator_0.Emit(OpCodes.Stloc_1);
									num3 = 9;
									goto case 9;
								case 9:
									ilgenerator_0.Emit(OpCodes.Br_S, label);
									ilgenerator_0.MarkLabel(label2);
									ilgenerator_0.Emit(OpCodes.Ldloc_0);
									num3 = 3;
									goto case 3;
								case 3:
									ilgenerator_0.Emit(OpCodes.Ldloc_1);
									while (true)
									{
										int num5 = Class9.smethod_4(39);
										while (true)
										{
											switch (num5)
											{
											case 2:
												ilgenerator_0.Emit(OpCodes.Callvirt, method);
												num5 = Class9.smethod_4(38);
												continue;
											case 1:
												ilgenerator_0.Emit(OpCodes.Callvirt, method2);
												num5 = 0;
												goto case 0;
											case 0:
												num3 = 17;
												num5 = 3;
												goto end_IL_0326;
											case 3:
												goto end_IL_0326;
											}
											break;
										}
										continue;
										end_IL_0326:
										break;
									}
									continue;
								case 20:
									ilgenerator_0.Emit(OpCodes.Beq_S, label5);
									ilgenerator_0.MarkLabel(label4);
									ilgenerator_0.Emit(OpCodes.Ldarg_0);
									num3 = 2;
									goto case 2;
								case 2:
									ilgenerator_0.Emit(OpCodes.Ret);
									ilgenerator_0.MarkLabel(label5);
									ilgenerator_0.Emit(OpCodes.Ldloc_1);
									num3 = Class9.smethod_4(38);
									continue;
								case 19:
									ilgenerator_0.Emit(OpCodes.Bne_Un_S, label4);
									ilgenerator_0.Emit(OpCodes.Ldloc_3);
									ilgenerator_0.Emit(OpCodes.Ldstr, Class29.smethod_0("\ue3b3\ue3b0\ue3b3\ue3b4\ue3bd\ue3a7\ue3bc", 58321));
									num3 = 7;
									goto case 7;
								case 7:
									ilgenerator_0.Emit(OpCodes.Ldc_I4_5);
									ilgenerator_0.Emit(OpCodes.Callvirt, method5);
									ilgenerator_0.Emit(OpCodes.Ldc_I4_M1);
									num3 = 16;
									goto case 16;
								case 16:
									ilgenerator_0.Emit(OpCodes.Bne_Un_S, label4);
									ilgenerator_0.Emit(OpCodes.Ldloc_3);
									ilgenerator_0.Emit(OpCodes.Ldstr, Class29.smethod_0("\ue77f\ue761\ue763\ue767\ue769\ue778\ue769\ue77f\ue778", 59148));
									num3 = 18;
									goto case 18;
								case 18:
									ilgenerator_0.Emit(OpCodes.Ldc_I4_5);
									ilgenerator_0.Emit(OpCodes.Callvirt, method5);
									ilgenerator_0.Emit(OpCodes.Ldc_I4_M1);
									num3 = 20;
									goto case 20;
								case 17:
									ilgenerator_0.Emit(OpCodes.Callvirt, method3);
									ilgenerator_0.Emit(OpCodes.Stloc_2);
									ilgenerator_0.Emit(OpCodes.Ldloc_2);
									num3 = 8;
									goto case 8;
								case 8:
									ilgenerator_0.Emit(OpCodes.Brfalse_S, label3);
									ilgenerator_0.Emit(OpCodes.Ldloc_2);
									ilgenerator_0.Emit(OpCodes.Callvirt, method4);
									num3 = 10;
									goto case 10;
								case 10:
									ilgenerator_0.Emit(OpCodes.Stloc_3);
									ilgenerator_0.Emit(OpCodes.Ldloc_3);
									ilgenerator_0.Emit(OpCodes.Ldstr, Class29.smethod_0("\uf5a9\uf5a8\uf5f9\uf5a9\uf5a2\uf5b9", 62925));
									num3 = 15;
									goto case 15;
								case 15:
									ilgenerator_0.Emit(OpCodes.Ldc_I4_5);
									ilgenerator_0.Emit(OpCodes.Callvirt, method5);
									ilgenerator_0.Emit(OpCodes.Ldc_I4_M1);
									num3 = 12;
									goto case 12;
								case 12:
									ilgenerator_0.Emit(OpCodes.Bne_Un_S, label4);
									ilgenerator_0.Emit(OpCodes.Ldloc_3);
									ilgenerator_0.Emit(OpCodes.Ldstr, Class29.smethod_0("\uf5ae\uf5bc\uf5b8\uf5f3", 62941));
									num3 = 6;
									goto case 6;
								case 6:
									ilgenerator_0.Emit(OpCodes.Ldc_I4_5);
									ilgenerator_0.Emit(OpCodes.Callvirt, method5);
									ilgenerator_0.Emit(OpCodes.Ldc_I4_M1);
									num3 = 19;
									goto case 19;
								case 14:
									label = ilgenerator_0.DefineLabel();
									label3 = ilgenerator_0.DefineLabel();
									label4 = ilgenerator_0.DefineLabel();
									num3 = 21;
									goto case 21;
								case 13:
									ilgenerator_0.DeclareLocal(typeof(int));
									while (true)
									{
										int num4 = Class9.smethod_4(39);
										while (true)
										{
											switch (num4)
											{
											case 2:
												ilgenerator_0.DeclareLocal(typeof(Type));
												num4 = Class9.smethod_4(37);
												continue;
											case 0:
												ilgenerator_0.DeclareLocal(typeof(string));
												num4 = 1;
												goto case 1;
											case 1:
												num3 = 14;
												num4 = 3;
												goto end_IL_05c9;
											case 3:
												goto end_IL_05c9;
											}
											break;
										}
										continue;
										end_IL_05c9:
										break;
									}
									continue;
								case 1:
									ilgenerator_0.Emit(OpCodes.Ldc_I4_1);
									ilgenerator_0.Emit(OpCodes.Add);
									ilgenerator_0.Emit(OpCodes.Stloc_1);
									num3 = 5;
									goto case 5;
								case 5:
									ilgenerator_0.MarkLabel(label);
									ilgenerator_0.Emit(OpCodes.Ldloc_1);
									ilgenerator_0.Emit(OpCodes.Ldloc_0);
									num3 = 11;
									goto case 11;
								case 11:
									ilgenerator_0.Emit(OpCodes.Callvirt, method6);
									ilgenerator_0.Emit(OpCodes.Blt_S, label2);
									ilgenerator_0.MarkLabel(label3);
									num3 = 0;
									goto case 0;
								case 0:
									ilgenerator_0.Emit(OpCodes.Ldarg_0);
									ilgenerator_0.Emit(OpCodes.Call, methodInfo);
									ilgenerator_0.Emit(OpCodes.Ret);
									num3 = 22;
									return;
								case 22:
									return;
								}
								break;
							}
						}
					}
					break;
					IL_00a5:
					num = Class9.smethod_4(42);
				}
			}
		}
	}

	private delegate string Delegate1(int int_0);

	private static Delegate1 delegate1_0;

	private Class25 class25_0;

	private Hashtable hashtable_0;

	public static Stream Stream_0 => null;

	public static string smethod_0(int int_0)
	{
		char[] array = "jv]kZ".ToCharArray();
		int num = array.Length;
		while (--num >= 0)
		{
			array[num] = (char)(array[num] ^ 0x6Fu ^ (uint)int_0);
		}
		return new string(array);
	}

	static Class23()
	{
		delegate1_0 = smethod_0;
	}

	public Class23()
	{
		class25_0 = smethod_1();
		if (class25_0 != null || 1 == 0)
		{
			GC.SuppressFinalize(class25_0);
		}
		hashtable_0 = new Hashtable();
	}

	~Class23()
	{
		method_0(bool_0: false);
	}

	private void method_0(bool bool_0)
	{
		try
		{
			if ((!bool_0) ? true : false)
			{
				return;
			}
			if (class25_0 != null || 1 == 0)
			{
				class25_0.Dispose();
			}
			IEnumerator enumerator = hashtable_0.Values.GetEnumerator();
			try
			{
				while (enumerator.MoveNext() ? true : false)
				{
					((Class25)enumerator.Current).Dispose();
				}
			}
			finally
			{
				IDisposable disposable = enumerator as IDisposable;
				if (disposable != null || 1 == 0)
				{
					disposable.Dispose();
				}
			}
		}
		finally
		{
			hashtable_0 = null;
		}
	}

	public void Dispose()
	{
		method_0(bool_0: true);
		GC.SuppressFinalize(this);
	}

	public Class12 method_1(int int_0)
	{
		Class12 @class = null;
		int num2 = default(int);
		int int_ = default(int);
		Class25 class2 = default(Class25);
		while (true)
		{
			int num = Class9.smethod_4(37);
			while (true)
			{
				switch (num)
				{
				case 3:
					num2 = int_0 >> 24;
					num = 1;
					goto case 1;
				case 1:
					if (num2 > 0)
					{
						goto IL_0010;
					}
					return class25_0.method_1(int_);
				case 0:
					int_ = int_0 & 0xFFFFFF;
					num = 3;
					goto case 3;
				case 2:
					class2 = (Class25)hashtable_0[num2];
					num = 4;
					goto case 4;
				case 4:
					if (class2 != null)
					{
						num = 5;
					}
					else if (0 == 0)
					{
						Stream stream = Class22.smethod_1(class25_0.method_2(num2));
						if (stream == null && 0 == 0)
						{
							throw new InvalidOperationException(Class29.smethod_0("\uf191\uf192\uf191\uf196\uf19f\uf1d3\uf19e\uf1c0", 61939));
						}
						GC.SuppressFinalize(stream);
						class2 = new Class25(Class47.smethod_0(stream));
						while (true)
						{
							switch (Class9.smethod_4(38))
							{
							default:
								continue;
							case 1:
							{
								GC.SuppressFinalize(class2);
								int num3 = 0;
								goto case 0;
							}
							case 0:
							{
								hashtable_0[num2] = class2;
								int num3 = 2;
								break;
							}
							case 2:
								break;
							}
							break;
						}
					}
					goto case 5;
				case 5:
					return class2.method_1(int_);
				}
				break;
				IL_0010:
				num = Class9.smethod_4(39);
			}
		}
	}

	private static Class25 smethod_1()
	{
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Stream stream = default(Stream);
		string text = default(string);
		while (true)
		{
			switch (Class9.smethod_4(37))
			{
			default:
				continue;
			case 0:
			{
				stream = Stream_0;
				int num = 1;
				goto case 1;
			}
			case 1:
			{
				text = delegate1_0(112);
				int num = 2;
				goto case 2;
			}
			case 2:
				if (string.IsNullOrEmpty(text))
				{
					int num = 3;
				}
				else if (0 == 0)
				{
					stream = executingAssembly.GetManifestResourceStream(text);
				}
				break;
			case 3:
				break;
			}
			break;
		}
		if (stream != null || 1 == 0)
		{
			stream = Class24.smethod_0(stream);
		}
		if (stream == null && 0 == 0)
		{
			return null;
		}
		GC.SuppressFinalize(stream);
		return new Class25(stream);
	}
}
