using System;
using System.Reflection;
using System.Reflection.Emit;

internal class Class47
{
	private static ModuleHandle moduleHandle_0;

	static Class47()
	{
		moduleHandle_0 = typeof(Class47).Assembly.ManifestModule.ModuleHandle;
	}

	public static void smethod_0(int int_0, int int_1, int int_2)
	{
		int_0--;
		int num9 = default(int);
		RuntimeFieldHandle handle3 = default(RuntimeFieldHandle);
		RuntimeTypeHandle handle = default(RuntimeTypeHandle);
		RuntimeMethodHandle handle2 = default(RuntimeMethodHandle);
		Type typeFromHandle = default(Type);
		MethodInfo methodInfo = default(MethodInfo);
		FieldInfo fieldFromHandle = default(FieldInfo);
		MethodInfo methodInfo2 = default(MethodInfo);
		Type type2 = default(Type);
		FieldInfo fieldInfo2 = default(FieldInfo);
		bool isStatic = default(bool);
		int num4 = default(int);
		ILGenerator iLGenerator2 = default(ILGenerator);
		int num6 = default(int);
		int num8 = default(int);
		ILGenerator iLGenerator = default(ILGenerator);
		int i = default(int);
		Delegate value = default(Delegate);
		while (true)
		{
			int num = Class48.smethod_0(87);
			while (true)
			{
				switch (num)
				{
				case 15:
					int_2 = (int_2 | (num9 - 15)) ^ 0x6F06AC02;
					num = 2;
					goto case 2;
				case 2:
					handle3 = moduleHandle_0.ResolveFieldHandle(int_2);
					num = 7;
					goto IL_0041;
				case 7:
					goto IL_0041;
				case 12:
					int_0 = (int_0 + 1) ^ 0x6F06AC02 ^ 0x408E6A7F ^ 0x6F06AC02;
					num = 4;
					goto case 4;
				case 4:
					num9 = int_2 & 0xFF;
					num = 5;
					goto case 5;
				case 5:
					int_2 ^= num9;
					num = 10;
					goto case 10;
				case 10:
					num9 += 15;
					num = 6;
					goto case 6;
				case 6:
					handle = moduleHandle_0.ResolveTypeHandle(int_0);
					num = 11;
					goto case 11;
				case 11:
					int_1 = (int_1 - 1) ^ num9 ^ 0x7BCCF57B ^ num9;
					num = 9;
					goto case 9;
				case 9:
					handle2 = moduleHandle_0.ResolveMethodHandle(int_1);
					num = 15;
					goto case 15;
				case 8:
					int_1++;
					num = 12;
					goto case 12;
				case 1:
					typeFromHandle = Type.GetTypeFromHandle(handle);
					num = 0;
					goto case 0;
				case 0:
					methodInfo = (MethodInfo)MethodBase.GetMethodFromHandle(handle2);
					num = 13;
					goto case 13;
				case 13:
				{
					FieldInfo fieldInfo = fieldFromHandle;
					Type type = typeFromHandle;
					methodInfo2 = methodInfo;
					type2 = type;
					fieldInfo2 = fieldInfo;
					num = 3;
					goto case 3;
				}
				case 3:
					isStatic = methodInfo2.IsStatic;
					num = 14;
					goto case 14;
				case 14:
					if (isStatic)
					{
						num = 16;
					}
					else if (true)
					{
						ParameterInfo[] parameters = methodInfo2.GetParameters();
						int num2 = parameters.Length + 1;
						Type[] array = new Type[num2];
						array[0] = ((methodInfo2.DeclaringType!.IsValueType ? true : false) ? methodInfo2.DeclaringType!.MakeByRefType() : typeof(object));
						while (true)
						{
							int num3 = Class48.smethod_0(92);
							while (true)
							{
								DynamicMethod dynamicMethod;
								switch (num3)
								{
								case 3:
									num4++;
									goto IL_0270;
								case 0:
									goto IL_0282;
								case 2:
									if (num4 == 0)
									{
										num3 = 0;
										goto IL_0282;
									}
									goto IL_0270;
								case 1:
									{
										num4 = 1;
										num3 = 2;
										goto case 2;
									}
									IL_0270:
									if ((num4 < num2) ? true : false)
									{
										goto IL_0282;
									}
									dynamicMethod = new DynamicMethod(string.Empty, methodInfo2.ReturnType, array, type2, skipVisibility: true);
									while (true)
									{
										int num5 = Class48.smethod_0(91);
										while (true)
										{
											switch (num5)
											{
											case 3:
												iLGenerator2.Emit(OpCodes.Ldarg_0);
												num5 = 2;
												goto case 2;
											case 2:
											{
												ILGenerator iLGenerator3 = iLGenerator2;
												num6 = num2;
												num8 = 1;
												iLGenerator = iLGenerator3;
												num5 = 1;
												goto IL_0336;
											}
											case 1:
												goto IL_0336;
											case 0:
												iLGenerator2 = dynamicMethod.GetILGenerator();
												num5 = 3;
												goto case 3;
											case 4:
												for (; i < num6; i++)
												{
													if (1 == 0)
													{
														break;
													}
													switch (i)
													{
													default:
														iLGenerator.Emit(OpCodes.Ldarg_S, i);
														break;
													case 0:
														iLGenerator.Emit(OpCodes.Ldarg_0);
														break;
													case 1:
														iLGenerator.Emit(OpCodes.Ldarg_1);
														break;
													case 2:
														iLGenerator.Emit(OpCodes.Ldarg_2);
														break;
													case 3:
														iLGenerator.Emit(OpCodes.Ldarg_3);
														break;
													}
												}
												iLGenerator2.Emit((fieldInfo2.IsAssembly ? true : false) ? OpCodes.Callvirt : OpCodes.Call, methodInfo2);
												while (true)
												{
													switch (Class48.smethod_0(92))
													{
													default:
														continue;
													case 1:
													{
														iLGenerator2.Emit(OpCodes.Ret);
														int num7 = 0;
														goto case 0;
													}
													case 0:
													{
														value = dynamicMethod.CreateDelegate(type2);
														int num7 = 2;
														break;
													}
													case 2:
														break;
													}
													break;
												}
												fieldInfo2.SetValue(null, value);
												return;
											}
											break;
											IL_0336:
											i = num8;
											num5 = Class48.smethod_0(84);
										}
									}
								}
								break;
								IL_0282:
								array[num4] = parameters[num4 - 1].ParameterType;
								num3 = Class48.smethod_0(86);
							}
						}
					}
					goto case 16;
				case 16:
					fieldInfo2.SetValue(null, Delegate.CreateDelegate(fieldInfo2.FieldType, methodInfo2));
					return;
				}
				break;
				IL_0041:
				fieldFromHandle = FieldInfo.GetFieldFromHandle(handle3);
				num = Class48.smethod_0(92);
			}
		}
	}

	public static void smethod_1(int int_0, int int_1, int int_2, int int_3)
	{
		int_0--;
		int num2 = default(int);
		RuntimeTypeHandle handle = default(RuntimeTypeHandle);
		RuntimeFieldHandle handle2 = default(RuntimeFieldHandle);
		FieldInfo fieldFromHandle = default(FieldInfo);
		Type typeFromHandle = default(Type);
		MethodInfo methodInfo = default(MethodInfo);
		MethodInfo methodInfo2 = default(MethodInfo);
		Type type2 = default(Type);
		FieldInfo fieldInfo2 = default(FieldInfo);
		bool isStatic = default(bool);
		int num5 = default(int);
		ILGenerator iLGenerator = default(ILGenerator);
		int num7 = default(int);
		int num8 = default(int);
		ILGenerator iLGenerator3 = default(ILGenerator);
		int i = default(int);
		Delegate value = default(Delegate);
		while (true)
		{
			int num = Class48.smethod_0(85);
			while (true)
			{
				switch (num)
				{
				case 15:
					goto IL_000f;
				case 9:
					int_3++;
					num = 1;
					goto case 1;
				case 1:
					int_2--;
					num = 8;
					goto case 8;
				case 8:
					int_0 = (int_0 + 1) ^ 0x7BCCF57B ^ 0x408E6A7F ^ 0x7BCCF57B;
					num = 15;
					goto IL_000f;
				case 16:
					int_1 ^= num2;
					num = 10;
					goto case 10;
				case 10:
					num2 += 15;
					num = 14;
					goto case 14;
				case 14:
					handle = moduleHandle_0.ResolveTypeHandle(int_0);
					num = 2;
					goto case 2;
				case 2:
					int_3 = (int_3 - 1) ^ num2 ^ 0x6F06AC02 ^ num2;
					num = 12;
					goto case 12;
				case 12:
					int_1 = (int_1 | (num2 - 15)) ^ 0x7BCCF57B;
					num = 5;
					goto case 5;
				case 5:
					handle2 = moduleHandle_0.ResolveFieldHandle(int_3);
					num = 13;
					goto case 13;
				case 13:
					fieldFromHandle = FieldInfo.GetFieldFromHandle(handle2);
					num = 0;
					goto case 0;
				case 0:
					int_2 = (int_2 + 1) ^ 0x6F06AC02 ^ 0x408E6A7F ^ 0x6F06AC02;
					num = 7;
					goto case 7;
				case 7:
					typeFromHandle = Type.GetTypeFromHandle(handle);
					num = 4;
					goto case 4;
				case 4:
					methodInfo = (MethodInfo)MethodBase.GetMethodFromHandle(moduleHandle_0.ResolveMethodHandle(int_1), moduleHandle_0.ResolveTypeHandle(int_2));
					num = 3;
					goto case 3;
				case 3:
				{
					FieldInfo fieldInfo = fieldFromHandle;
					Type type = typeFromHandle;
					methodInfo2 = methodInfo;
					type2 = type;
					fieldInfo2 = fieldInfo;
					num = 6;
					goto case 6;
				}
				case 6:
					isStatic = methodInfo2.IsStatic;
					num = 11;
					goto case 11;
				case 11:
					if (isStatic)
					{
						num = 17;
					}
					else if (true)
					{
						ParameterInfo[] parameters = methodInfo2.GetParameters();
						int num3 = parameters.Length + 1;
						Type[] array = new Type[num3];
						array[0] = ((methodInfo2.DeclaringType!.IsValueType ? true : false) ? methodInfo2.DeclaringType!.MakeByRefType() : typeof(object));
						while (true)
						{
							int num4 = Class48.smethod_0(91);
							while (true)
							{
								switch (num4)
								{
								case 2:
									if (num5 == 0)
									{
										goto IL_0295;
									}
									goto IL_02d4;
								case 0:
									num5 = 1;
									num4 = 2;
									goto case 2;
								case 1:
									array[num5] = parameters[num5 - 1].ParameterType;
									num4 = 3;
									goto case 3;
								case 3:
									{
										num5++;
										goto IL_02d4;
									}
									IL_02d4:
									if (num5 >= num3 && 0 == 0)
									{
										DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, methodInfo2.ReturnType, array, type2, skipVisibility: true);
										while (true)
										{
											switch (Class48.smethod_0(92))
											{
											default:
												continue;
											case 1:
											{
												iLGenerator = dynamicMethod.GetILGenerator();
												int num6 = 2;
												goto case 2;
											}
											case 2:
											{
												iLGenerator.Emit(OpCodes.Ldarg_0);
												int num6 = 3;
												goto case 3;
											}
											case 3:
											{
												ILGenerator iLGenerator2 = iLGenerator;
												num7 = num3;
												num8 = 1;
												iLGenerator3 = iLGenerator2;
												int num6 = 0;
												goto case 0;
											}
											case 0:
											{
												i = num8;
												int num6 = 4;
												break;
											}
											case 4:
												break;
											}
											break;
										}
										for (; i < num7; i++)
										{
											if (1 == 0)
											{
												break;
											}
											switch (i)
											{
											default:
												iLGenerator3.Emit(OpCodes.Ldarg_S, i);
												break;
											case 0:
												iLGenerator3.Emit(OpCodes.Ldarg_0);
												break;
											case 1:
												iLGenerator3.Emit(OpCodes.Ldarg_1);
												break;
											case 2:
												iLGenerator3.Emit(OpCodes.Ldarg_2);
												break;
											case 3:
												iLGenerator3.Emit(OpCodes.Ldarg_3);
												break;
											}
										}
										iLGenerator.Emit((fieldInfo2.IsAssembly ? true : false) ? OpCodes.Callvirt : OpCodes.Call, methodInfo2);
										while (true)
										{
											switch (Class48.smethod_0(91))
											{
											default:
												continue;
											case 0:
											{
												iLGenerator.Emit(OpCodes.Ret);
												int num9 = 1;
												goto case 1;
											}
											case 1:
											{
												value = dynamicMethod.CreateDelegate(type2);
												int num9 = 2;
												break;
											}
											case 2:
												break;
											}
											break;
										}
										fieldInfo2.SetValue(null, value);
										return;
									}
									goto case 1;
								}
								break;
								IL_0295:
								num4 = Class48.smethod_0(92);
							}
						}
					}
					goto case 17;
				case 17:
					fieldInfo2.SetValue(null, Delegate.CreateDelegate(fieldInfo2.FieldType, methodInfo2));
					return;
				}
				break;
				IL_000f:
				num2 = int_1 & 0xFF;
				num = Class48.smethod_1(88);
			}
		}
	}

	public static void smethod_2(int int_0, int int_1, int int_2)
	{
		int_0++;
		int num2 = default(int);
		RuntimeTypeHandle handle = default(RuntimeTypeHandle);
		RuntimeMethodHandle handle2 = default(RuntimeMethodHandle);
		RuntimeFieldHandle handle3 = default(RuntimeFieldHandle);
		FieldInfo fieldFromHandle = default(FieldInfo);
		Type typeFromHandle = default(Type);
		ConstructorInfo constructorInfo = default(ConstructorInfo);
		ConstructorInfo constructorInfo2 = default(ConstructorInfo);
		Type type2 = default(Type);
		FieldInfo fieldInfo2 = default(FieldInfo);
		ParameterInfo[] parameters = default(ParameterInfo[]);
		int num3 = default(int);
		Type[] array = default(Type[]);
		int num4 = default(int);
		ILGenerator iLGenerator = default(ILGenerator);
		int num6 = default(int);
		int num7 = default(int);
		ILGenerator iLGenerator3 = default(ILGenerator);
		int i = default(int);
		Delegate value = default(Delegate);
		while (true)
		{
			int num = Class48.smethod_1(93);
			while (true)
			{
				switch (num)
				{
				case 19:
					goto IL_000f;
				case 18:
					int_0 = (int_0 - 1) ^ 0x6F06AC02 ^ 0x408E6A7F ^ 0x6F06AC02;
					num = 19;
					goto IL_000f;
				case 7:
					int_1--;
					num = 18;
					goto case 18;
				case 8:
					int_2 ^= num2;
					num = 16;
					goto case 16;
				case 16:
					num2 += 15;
					num = 10;
					goto case 10;
				case 10:
					handle = moduleHandle_0.ResolveTypeHandle(int_0);
					num = 5;
					goto case 5;
				case 5:
					int_1 = (int_1 + 1) ^ num2 ^ 0x4F7429D ^ num2;
					num = 4;
					goto case 4;
				case 4:
					handle2 = moduleHandle_0.ResolveMethodHandle(int_1);
					num = 0;
					goto case 0;
				case 0:
					int_2 = (int_2 | (num2 - 15)) ^ 0x6F06AC02;
					num = 1;
					goto case 1;
				case 1:
					handle3 = moduleHandle_0.ResolveFieldHandle(int_2);
					num = 15;
					goto case 15;
				case 15:
					fieldFromHandle = FieldInfo.GetFieldFromHandle(handle3);
					num = 2;
					goto case 2;
				case 2:
					typeFromHandle = Type.GetTypeFromHandle(handle);
					num = 14;
					goto case 14;
				case 14:
					constructorInfo = (ConstructorInfo)MethodBase.GetMethodFromHandle(handle2);
					num = 3;
					goto case 3;
				case 3:
				{
					FieldInfo fieldInfo = fieldFromHandle;
					Type type = typeFromHandle;
					constructorInfo2 = constructorInfo;
					type2 = type;
					fieldInfo2 = fieldInfo;
					num = 13;
					goto case 13;
				}
				case 13:
					parameters = constructorInfo2.GetParameters();
					num = 12;
					goto case 12;
				case 12:
					num3 = parameters.Length;
					num = 17;
					goto case 17;
				case 17:
					array = new Type[num3];
					num = 9;
					goto case 9;
				case 9:
					num4 = 0;
					num = 11;
					goto case 11;
				case 11:
					if (num4 == 0)
					{
						goto IL_0220;
					}
					num = 6;
					goto case 6;
				case 20:
					num4++;
					goto IL_0220;
				case 6:
					{
						array[num4] = parameters[num4].ParameterType;
						num = 20;
						goto case 20;
					}
					IL_0220:
					if (num4 >= num3 && 0 == 0)
					{
						DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, constructorInfo2.DeclaringType, array, type2, skipVisibility: true);
						while (true)
						{
							switch (Class48.smethod_0(91))
							{
							default:
								continue;
							case 0:
							{
								iLGenerator = dynamicMethod.GetILGenerator();
								int num5 = 2;
								goto case 2;
							}
							case 2:
							{
								ILGenerator iLGenerator2 = iLGenerator;
								num6 = num3;
								num7 = 0;
								iLGenerator3 = iLGenerator2;
								int num5 = 1;
								goto case 1;
							}
							case 1:
							{
								i = num7;
								int num5 = 3;
								break;
							}
							case 3:
								break;
							}
							break;
						}
						for (; i < num6; i++)
						{
							if (1 == 0)
							{
								break;
							}
							switch (i)
							{
							default:
								iLGenerator3.Emit(OpCodes.Ldarg_S, i);
								break;
							case 0:
								iLGenerator3.Emit(OpCodes.Ldarg_0);
								break;
							case 1:
								iLGenerator3.Emit(OpCodes.Ldarg_1);
								break;
							case 2:
								iLGenerator3.Emit(OpCodes.Ldarg_2);
								break;
							case 3:
								iLGenerator3.Emit(OpCodes.Ldarg_3);
								break;
							}
						}
						iLGenerator.Emit(OpCodes.Newobj, constructorInfo2);
						int num8;
						while (true)
						{
							switch (Class48.smethod_0(91))
							{
							default:
								continue;
							case 0:
								iLGenerator.Emit(OpCodes.Ret);
								num8 = 2;
								goto case 2;
							case 2:
								value = dynamicMethod.CreateDelegate(type2);
								num8 = 1;
								break;
							case 1:
								break;
							case 3:
								return;
							}
							break;
						}
						fieldInfo2.SetValue(null, value);
						num8 = 3;
						return;
					}
					goto case 6;
				}
				break;
				IL_000f:
				num2 = int_2 & 0xFF;
				num = Class48.smethod_0(87);
			}
		}
	}

	public static void smethod_3(int int_0, int int_1, int int_2, int int_3)
	{
		int_0++;
		int num2 = default(int);
		RuntimeTypeHandle handle = default(RuntimeTypeHandle);
		RuntimeFieldHandle handle2 = default(RuntimeFieldHandle);
		FieldInfo fieldFromHandle = default(FieldInfo);
		Type typeFromHandle = default(Type);
		ConstructorInfo constructorInfo = default(ConstructorInfo);
		ConstructorInfo constructorInfo2 = default(ConstructorInfo);
		Type type2 = default(Type);
		FieldInfo fieldInfo2 = default(FieldInfo);
		ParameterInfo[] parameters = default(ParameterInfo[]);
		int num3 = default(int);
		Type[] array = default(Type[]);
		int num4 = default(int);
		ILGenerator iLGenerator2 = default(ILGenerator);
		int num6 = default(int);
		int num8 = default(int);
		ILGenerator iLGenerator = default(ILGenerator);
		int i = default(int);
		Delegate value = default(Delegate);
		while (true)
		{
			int num = Class48.smethod_1(83);
			while (true)
			{
				switch (num)
				{
				case 17:
					goto IL_000c;
				case 4:
					int_2++;
					num = 13;
					goto case 13;
				case 13:
					int_0 = (int_0 - 1) ^ 0x7BCCF57B ^ 0x408E6A7F ^ 0x7BCCF57B;
					num = 9;
					goto case 9;
				case 9:
					num2 = int_3 & 0xFF;
					num = 18;
					goto case 18;
				case 18:
					int_3 ^= num2;
					num = 1;
					goto case 1;
				case 1:
					num2 += 15;
					num = 19;
					goto case 19;
				case 19:
					handle = moduleHandle_0.ResolveTypeHandle(int_0);
					num = 10;
					goto case 10;
				case 10:
					int_1 = (int_1 + 1) ^ num2 ^ 0x4F7429D ^ num2;
					num = 3;
					goto case 3;
				case 3:
					int_3 = (int_3 | (num2 - 15)) ^ 0x6F06AC02;
					num = 8;
					goto case 8;
				case 8:
					handle2 = moduleHandle_0.ResolveFieldHandle(int_3);
					num = 7;
					goto case 7;
				case 7:
					fieldFromHandle = FieldInfo.GetFieldFromHandle(handle2);
					num = 11;
					goto case 11;
				case 11:
					int_2 = (int_2 - 1) ^ 0x7BCCF57B ^ 0x408E6A7F ^ 0x7BCCF57B;
					num = 20;
					goto case 20;
				case 20:
					typeFromHandle = Type.GetTypeFromHandle(handle);
					num = 0;
					goto case 0;
				case 0:
					constructorInfo = (constructorInfo = (ConstructorInfo)MethodBase.GetMethodFromHandle(moduleHandle_0.ResolveMethodHandle(int_1), moduleHandle_0.ResolveTypeHandle(int_2)));
					num = 14;
					goto case 14;
				case 14:
				{
					FieldInfo fieldInfo = fieldFromHandle;
					Type type = typeFromHandle;
					constructorInfo2 = constructorInfo;
					type2 = type;
					fieldInfo2 = fieldInfo;
					num = 16;
					goto case 16;
				}
				case 16:
					parameters = constructorInfo2.GetParameters();
					num = 5;
					goto case 5;
				case 5:
					num3 = parameters.Length;
					num = 15;
					goto case 15;
				case 15:
					array = new Type[num3];
					num = 12;
					goto case 12;
				case 12:
					num4 = 0;
					num = 2;
					goto case 2;
				case 2:
					if (num4 == 0)
					{
						goto IL_0251;
					}
					num = 6;
					goto case 6;
				case 21:
					num4++;
					goto IL_0251;
				case 6:
					{
						array[num4] = parameters[num4].ParameterType;
						num = 21;
						goto case 21;
					}
					IL_0251:
					if (num4 >= num3 && 0 == 0)
					{
						DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, constructorInfo2.DeclaringType, array, type2, skipVisibility: true);
						while (true)
						{
							int num5 = Class48.smethod_0(91);
							while (true)
							{
								switch (num5)
								{
								case 2:
									goto IL_02a4;
								case 1:
								{
									ILGenerator iLGenerator3 = iLGenerator2;
									num6 = num3;
									num8 = 0;
									iLGenerator = iLGenerator3;
									num5 = 2;
									goto IL_02a4;
								}
								case 0:
									iLGenerator2 = dynamicMethod.GetILGenerator();
									num5 = 1;
									goto case 1;
								case 3:
								{
									for (; i < num6; i++)
									{
										if (1 == 0)
										{
											break;
										}
										switch (i)
										{
										default:
											iLGenerator.Emit(OpCodes.Ldarg_S, i);
											break;
										case 0:
											iLGenerator.Emit(OpCodes.Ldarg_0);
											break;
										case 1:
											iLGenerator.Emit(OpCodes.Ldarg_1);
											break;
										case 2:
											iLGenerator.Emit(OpCodes.Ldarg_2);
											break;
										case 3:
											iLGenerator.Emit(OpCodes.Ldarg_3);
											break;
										}
									}
									iLGenerator2.Emit(OpCodes.Newobj, constructorInfo2);
									int num7;
									while (true)
									{
										switch (Class48.smethod_0(91))
										{
										default:
											continue;
										case 0:
											iLGenerator2.Emit(OpCodes.Ret);
											num7 = 1;
											goto case 1;
										case 1:
											value = dynamicMethod.CreateDelegate(type2);
											num7 = 2;
											break;
										case 2:
											break;
										case 3:
											return;
										}
										break;
									}
									fieldInfo2.SetValue(null, value);
									num7 = 3;
									return;
								}
								}
								break;
								IL_02a4:
								i = num8;
								num5 = Class48.smethod_0(86);
							}
						}
					}
					goto case 6;
				}
				break;
				IL_000c:
				int_1--;
				num = Class48.smethod_0(84);
			}
		}
	}
}
