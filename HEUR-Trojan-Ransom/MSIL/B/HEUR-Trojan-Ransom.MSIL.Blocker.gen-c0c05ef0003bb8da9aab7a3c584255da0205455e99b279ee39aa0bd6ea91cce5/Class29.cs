using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;

internal sealed class Class29 : IDisposable
{
	private sealed class Class30
	{
		internal delegate Stream Delegate0(Stream stream_0);

		public static Stream smethod_0(Stream stream_0)
		{
			DynamicMethod dynamicMethod = new DynamicMethod(Guid.NewGuid().ToString(), typeof(Stream), new Type[1] { typeof(Stream) }, typeof(Class30).Module);
			smethod_1(dynamicMethod.GetILGenerator());
			return ((Delegate0)dynamicMethod.CreateDelegate(typeof(Delegate0)))(stream_0);
		}

		private static void smethod_1(ILGenerator ilgenerator_0)
		{
			Type type = Type.GetType(Class35.smethod_0("\ue5d3\ue5f9\ue5f3\ue5f4\ue5e5\ue5ed\ue5ae\ue5c4\ue5e9\ue5e1\ue5e7\ue5ee\ue5ef\ue5f3\ue5f4\ue5e9\ue5e3\ue5f3\ue5ae\ue5d3\ue5f4\ue5e1\ue5e3\ue5eb\ue5d4\ue5f2\ue5e1\ue5e3\ue5e5", 58752));
			ParameterInfo[] parameters = default(ParameterInfo[]);
			MethodInfo methodInfo2 = default(MethodInfo);
			MethodInfo methodInfo = default(MethodInfo);
			MethodInfo[] methods = default(MethodInfo[]);
			int num2 = default(int);
			MethodInfo method6 = default(MethodInfo);
			MethodInfo method4 = default(MethodInfo);
			MethodInfo method5 = default(MethodInfo);
			MethodInfo method = default(MethodInfo);
			MethodInfo method2 = default(MethodInfo);
			MethodInfo method3 = default(MethodInfo);
			ConstructorInfo constructor = default(ConstructorInfo);
			Label label3 = default(Label);
			Label label5 = default(Label);
			Label label = default(Label);
			Label label2 = default(Label);
			Label label4 = default(Label);
			while (true)
			{
				int num = Class12.smethod_0(87);
				while (true)
				{
					switch (num)
					{
					case 7:
						parameters = methodInfo2.GetParameters();
						num = 2;
						goto case 2;
					case 2:
						if (parameters != null)
						{
							goto IL_0094;
						}
						if (true)
						{
							goto IL_001d;
						}
						goto case 14;
					case 14:
						if (((!methodInfo2.IsStatic) ? true : false) || parameters.Length != 1 || ((!(parameters[0].ParameterType.Name == Class35.smethod_0("\uf3ba\uf39d\uf39b\uf38c\uf388\uf384", 62441))) ? true : false))
						{
							goto IL_001d;
						}
						methodInfo = methodInfo2;
						goto IL_0277;
					case 0:
						methodInfo2 = methods[num2];
						num = 7;
						goto case 7;
					case 13:
						methods = typeof(Class14).GetMethods(BindingFlags.Static | BindingFlags.NonPublic);
						num = 1;
						goto case 1;
					case 1:
						num2 = 0;
						num = 6;
						goto case 6;
					case 6:
						if (num2 == 0)
						{
							goto IL_0023;
						}
						num = 0;
						goto case 0;
					case 12:
						method6 = type.GetMethod(Class35.smethod_0("\ue924\ue926\ue937\ue91c\ue905\ue931\ue922\ue92e\ue926\ue900\ue92c\ue936\ue92d\ue937", 59715), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[0], null);
						num = 4;
						goto case 4;
					case 4:
						methodInfo = null;
						num = 13;
						goto case 13;
					case 11:
						method4 = typeof(Type).GetMethod(Class35.smethod_0("\uf35b\uf359\uf348\uf363\uf37a\uf349\uf350\uf350\uf372\uf35d\uf351\uf359", 62268), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[0], null);
						num = 9;
						goto case 9;
					case 9:
						method5 = typeof(string).GetMethod(Class35.smethod_0("\ueb08\ueb2f\ueb25\ueb24\ueb39\ueb0e\ueb27", 60225), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[2]
						{
							typeof(string),
							typeof(StringComparison)
						}, null);
						num = 12;
						goto case 12;
					case 10:
						method = type.GetMethod(Class35.smethod_0("\uf890\uf8b2\uf8a3\uf891\uf8a5\uf8b6\uf8ba\uf8b2", 63703), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[1] { typeof(int) }, null);
						num = 3;
						goto case 3;
					case 3:
						method2 = Type.GetType(Class35.smethod_0("\uef32\uef18\uef12\uef15\uef04\uef0c\uef4f\uef25\uef08\uef00\uef06\uef0f\uef0e\uef12\uef15\uef08\uef02\uef12\uef4f\uef32\uef15\uef00\uef02\uef0a\uef27\uef13\uef00\uef0c\uef04", 61281))!.GetMethod(Class35.smethod_0("\uf627\uf605\uf614\uf62d\uf605\uf614\uf608\uf60f\uf604", 63072), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[0], null);
						num = 5;
						goto case 5;
					case 5:
						method3 = typeof(MemberInfo).GetMethod(Class35.smethod_0("\ueaf2\ueaf0\ueae1\ueaca\uead1\ueaf0\ueaf6\ueaf9\ueaf4\ueae7\ueafc\ueafb\ueaf2\ueac1\ueaec\ueae5\ueaf0", 60053), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[0], null);
						num = 11;
						goto case 11;
					case 8:
						{
							constructor = type.GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[0], null);
							num = 10;
							goto case 10;
						}
						IL_0023:
						if (num2 < methods.Length)
						{
							goto case 0;
						}
						goto IL_0277;
						IL_001d:
						num2++;
						goto IL_0023;
						IL_0277:
						if (object.Equals(methodInfo, null) || 1 == 0)
						{
							Class14.smethod_0(null);
						}
						ilgenerator_0.DeclareLocal(type);
						while (true)
						{
							int num3 = Class41.smethod_0(90);
							while (true)
							{
								switch (num3)
								{
								case 17:
									label3 = ilgenerator_0.DefineLabel();
									label5 = ilgenerator_0.DefineLabel();
									label = ilgenerator_0.DefineLabel();
									num3 = 7;
									goto case 7;
								case 7:
									label2 = ilgenerator_0.DefineLabel();
									label4 = ilgenerator_0.DefineLabel();
									ilgenerator_0.Emit(OpCodes.Newobj, constructor);
									num3 = 6;
									goto case 6;
								case 6:
									ilgenerator_0.Emit(OpCodes.Stloc_0);
									ilgenerator_0.Emit(OpCodes.Ldc_I4_0);
									ilgenerator_0.Emit(OpCodes.Stloc_1);
									num3 = 13;
									goto case 13;
								case 13:
									ilgenerator_0.Emit(OpCodes.Br_S, label3);
									ilgenerator_0.MarkLabel(label4);
									ilgenerator_0.Emit(OpCodes.Ldloc_0);
									num3 = 4;
									goto case 4;
								case 4:
									ilgenerator_0.Emit(OpCodes.Ldloc_1);
									ilgenerator_0.Emit(OpCodes.Callvirt, method);
									ilgenerator_0.Emit(OpCodes.Callvirt, method2);
									num3 = 1;
									goto case 1;
								case 1:
									ilgenerator_0.Emit(OpCodes.Callvirt, method3);
									ilgenerator_0.Emit(OpCodes.Stloc_2);
									ilgenerator_0.Emit(OpCodes.Ldloc_2);
									num3 = 11;
									goto case 11;
								case 11:
									ilgenerator_0.Emit(OpCodes.Brfalse_S, label5);
									ilgenerator_0.Emit(OpCodes.Ldloc_2);
									ilgenerator_0.Emit(OpCodes.Callvirt, method4);
									num3 = 10;
									goto case 10;
								case 10:
									ilgenerator_0.Emit(OpCodes.Stloc_3);
									ilgenerator_0.Emit(OpCodes.Ldloc_3);
									ilgenerator_0.Emit(OpCodes.Ldstr, Class35.smethod_0("\uf35d\uf35c\uf30d\uf35d\uf356\uf34d", 62265));
									num3 = 2;
									goto case 2;
								case 2:
									ilgenerator_0.Emit(OpCodes.Ldc_I4_5);
									while (true)
									{
										switch (Class41.smethod_0(79))
										{
										default:
											continue;
										case 1:
										{
											ilgenerator_0.Emit(OpCodes.Callvirt, method5);
											int num5 = 0;
											goto case 0;
										}
										case 0:
										{
											ilgenerator_0.Emit(OpCodes.Ldc_I4_M1);
											int num5 = 2;
											goto case 2;
										}
										case 2:
										{
											num3 = Class41.smethod_0(88);
											int num5 = 3;
											break;
										}
										case 3:
											break;
										}
										break;
									}
									continue;
								case 15:
									ilgenerator_0.DeclareLocal(typeof(int));
									while (true)
									{
										int num4 = Class41.smethod_0(79);
										while (true)
										{
											switch (num4)
											{
											case 1:
												ilgenerator_0.DeclareLocal(typeof(Type));
												num4 = 0;
												goto case 0;
											case 0:
												ilgenerator_0.DeclareLocal(typeof(string));
												num4 = Class41.smethod_0(82);
												continue;
											case 2:
												num3 = 17;
												num4 = 3;
												goto end_IL_0477;
											case 3:
												goto end_IL_0477;
											}
											break;
										}
										continue;
										end_IL_0477:
										break;
									}
									continue;
								case 21:
									ilgenerator_0.Emit(OpCodes.Bne_Un_S, label);
									ilgenerator_0.Emit(OpCodes.Ldloc_3);
									ilgenerator_0.Emit(OpCodes.Ldstr, Class35.smethod_0("\uf1ef\uf1fd\uf1f9\uf1b2", 61852));
									num3 = 16;
									goto case 16;
								case 16:
									ilgenerator_0.Emit(OpCodes.Ldc_I4_5);
									ilgenerator_0.Emit(OpCodes.Callvirt, method5);
									ilgenerator_0.Emit(OpCodes.Ldc_I4_M1);
									num3 = 18;
									goto case 18;
								case 18:
									ilgenerator_0.Emit(OpCodes.Bne_Un_S, label);
									ilgenerator_0.Emit(OpCodes.Ldloc_3);
									ilgenerator_0.Emit(OpCodes.Ldstr, Class35.smethod_0("\ueeea\ueee9\ueeea\ueeed\ueee4\ueefe\ueee5", 61064));
									num3 = 20;
									goto case 20;
								case 20:
									ilgenerator_0.Emit(OpCodes.Ldc_I4_5);
									ilgenerator_0.Emit(OpCodes.Callvirt, method5);
									ilgenerator_0.Emit(OpCodes.Ldc_I4_M1);
									num3 = 8;
									goto case 8;
								case 8:
									ilgenerator_0.Emit(OpCodes.Bne_Un_S, label);
									ilgenerator_0.Emit(OpCodes.Ldloc_3);
									ilgenerator_0.Emit(OpCodes.Ldstr, Class35.smethod_0("\ue993\ue98d\ue98f\ue98b\ue985\ue994\ue985\ue993\ue994", 59872));
									num3 = 9;
									goto case 9;
								case 9:
									ilgenerator_0.Emit(OpCodes.Ldc_I4_5);
									ilgenerator_0.Emit(OpCodes.Callvirt, method5);
									ilgenerator_0.Emit(OpCodes.Ldc_I4_M1);
									num3 = 0;
									goto case 0;
								case 0:
									ilgenerator_0.Emit(OpCodes.Beq_S, label2);
									ilgenerator_0.MarkLabel(label);
									ilgenerator_0.Emit(OpCodes.Ldarg_0);
									num3 = 3;
									goto case 3;
								case 3:
									ilgenerator_0.Emit(OpCodes.Ret);
									ilgenerator_0.MarkLabel(label2);
									ilgenerator_0.Emit(OpCodes.Ldloc_1);
									num3 = 12;
									goto case 12;
								case 12:
									ilgenerator_0.Emit(OpCodes.Ldc_I4_1);
									ilgenerator_0.Emit(OpCodes.Add);
									ilgenerator_0.Emit(OpCodes.Stloc_1);
									num3 = 14;
									goto case 14;
								case 14:
									ilgenerator_0.MarkLabel(label3);
									ilgenerator_0.Emit(OpCodes.Ldloc_1);
									ilgenerator_0.Emit(OpCodes.Ldloc_0);
									num3 = 19;
									goto case 19;
								case 19:
									ilgenerator_0.Emit(OpCodes.Callvirt, method6);
									ilgenerator_0.Emit(OpCodes.Blt_S, label4);
									ilgenerator_0.MarkLabel(label5);
									num3 = 5;
									goto case 5;
								case 5:
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
					IL_0094:
					num = Class12.smethod_0(80);
				}
			}
		}
	}

	private delegate string Delegate1(int int_0);

	private static Delegate1 delegate1_0;

	private Class31 class31_0;

	private Hashtable hashtable_0;

	public static Stream Stream_0 => null;

	public static string smethod_0(int int_0)
	{
		char[] array = "\u008e\u0081\u0089º".ToCharArray();
		int num = array.Length;
		while (--num >= 0)
		{
			array[num] = (char)(array[num] ^ 0x9Eu ^ (uint)int_0);
		}
		return new string(array);
	}

	static Class29()
	{
		delegate1_0 = smethod_0;
	}

	public Class29()
	{
		class31_0 = smethod_1();
		if (class31_0 != null || 1 == 0)
		{
			GC.SuppressFinalize(class31_0);
		}
		hashtable_0 = new Hashtable();
	}

	~Class29()
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
			if (class31_0 != null || 1 == 0)
			{
				class31_0.Dispose();
			}
			IEnumerator enumerator = hashtable_0.Values.GetEnumerator();
			try
			{
				while (enumerator.MoveNext() ? true : false)
				{
					((Class31)enumerator.Current).Dispose();
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

	public Class18 method_1(int int_0)
	{
		Class18 @class = null;
		int int_ = default(int);
		int num2 = default(int);
		Class31 class2 = default(Class31);
		while (true)
		{
			switch (Class41.smethod_0(82))
			{
			default:
				continue;
			case 2:
			{
				int_ = int_0 & 0xFFFFFF;
				int num = 3;
				goto case 3;
			}
			case 3:
			{
				num2 = int_0 >> 24;
				int num = 1;
				goto case 1;
			}
			case 1:
				if (num2 > 0)
				{
					int num = 4;
					goto case 4;
				}
				return class31_0.method_1(int_);
			case 4:
			{
				class2 = (Class31)hashtable_0[num2];
				int num = 0;
				goto case 0;
			}
			case 0:
				if (class2 != null)
				{
					int num = 5;
				}
				else if (0 == 0)
				{
					Stream stream = Class28.smethod_1(class31_0.method_2(num2));
					if (stream == null && 0 == 0)
					{
						throw new InvalidOperationException(Class35.smethod_0("\ue502\ue501\ue502\ue505\ue50c\ue540\ue50d\ue553", 58720));
					}
					GC.SuppressFinalize(stream);
					class2 = new Class31(Class49.smethod_0(stream));
					GC.SuppressFinalize(class2);
					hashtable_0[num2] = class2;
				}
				break;
			case 5:
				break;
			}
			break;
		}
		return class2.method_1(int_);
	}

	private static Class31 smethod_1()
	{
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		string text = default(string);
		Stream stream = default(Stream);
		while (true)
		{
			int num = Class41.smethod_0(92);
			while (true)
			{
				switch (num)
				{
				case 0:
					goto IL_0008;
				case 2:
					text = delegate1_0(93);
					num = 1;
					goto case 1;
				case 1:
					if (string.IsNullOrEmpty(text))
					{
						num = 3;
					}
					else if (0 == 0)
					{
						stream = executingAssembly.GetManifestResourceStream(text);
					}
					goto case 3;
				case 3:
					if (stream != null || 1 == 0)
					{
						stream = Class30.smethod_0(stream);
					}
					if (stream == null && 0 == 0)
					{
						return null;
					}
					GC.SuppressFinalize(stream);
					return new Class31(stream);
				}
				break;
				IL_0008:
				stream = Stream_0;
				num = Class41.smethod_0(82);
			}
		}
	}
}
