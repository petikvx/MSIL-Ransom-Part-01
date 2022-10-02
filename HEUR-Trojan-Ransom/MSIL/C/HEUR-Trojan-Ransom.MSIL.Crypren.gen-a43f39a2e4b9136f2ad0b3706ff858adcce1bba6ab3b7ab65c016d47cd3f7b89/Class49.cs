using System;
using System.Reflection;
using System.Reflection.Emit;

internal class Class49
{
	private static ModuleHandle moduleHandle_0;

	static Class49()
	{
		moduleHandle_0 = typeof(Class49).Assembly.ManifestModule.ModuleHandle;
	}

	public static void smethod_0(int int_0, int int_1, int int_2)
	{
		int_0--;
		int num2 = default(int);
		RuntimeTypeHandle handle = default(RuntimeTypeHandle);
		RuntimeMethodHandle handle2 = default(RuntimeMethodHandle);
		RuntimeFieldHandle handle3 = default(RuntimeFieldHandle);
		FieldInfo fieldFromHandle = default(FieldInfo);
		Type typeFromHandle = default(Type);
		MethodInfo methodInfo = default(MethodInfo);
		MethodInfo methodInfo2 = default(MethodInfo);
		Type type2 = default(Type);
		FieldInfo fieldInfo2 = default(FieldInfo);
		bool isStatic = default(bool);
		int num5 = default(int);
		ILGenerator iLGenerator2 = default(ILGenerator);
		int num7 = default(int);
		int num8 = default(int);
		ILGenerator iLGenerator = default(ILGenerator);
		int i = default(int);
		while (true)
		{
			int num = Class50.smethod_0(72);
			while (true)
			{
				switch (num)
				{
				case 8:
					int_1++;
					num = 2;
					goto IL_001e;
				case 2:
					goto IL_001e;
				case 15:
					num2 = int_2 & 0xFF;
					num = 0;
					goto case 0;
				case 0:
					int_2 ^= num2;
					num = 11;
					goto case 11;
				case 11:
					num2 += 15;
					num = 3;
					goto case 3;
				case 3:
					handle = moduleHandle_0.ResolveTypeHandle(int_0);
					num = 13;
					goto case 13;
				case 13:
					int_1 = (int_1 - 1) ^ num2 ^ 0x2F8A1E76 ^ num2;
					num = 7;
					goto case 7;
				case 7:
					handle2 = moduleHandle_0.ResolveMethodHandle(int_1);
					num = 9;
					goto case 9;
				case 9:
					int_2 = (int_2 | (num2 - 15)) ^ 0x311DDB02;
					num = 1;
					goto case 1;
				case 1:
					handle3 = moduleHandle_0.ResolveFieldHandle(int_2);
					num = 4;
					goto case 4;
				case 4:
					fieldFromHandle = FieldInfo.GetFieldFromHandle(handle3);
					num = 12;
					goto case 12;
				case 12:
					typeFromHandle = Type.GetTypeFromHandle(handle);
					num = 5;
					goto case 5;
				case 5:
					methodInfo = (MethodInfo)MethodBase.GetMethodFromHandle(handle2);
					num = 10;
					goto case 10;
				case 10:
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
						int num3 = parameters.Length + 1;
						Type[] array = new Type[num3];
						array[0] = ((methodInfo2.DeclaringType!.IsValueType ? true : false) ? methodInfo2.DeclaringType!.MakeByRefType() : typeof(object));
						while (true)
						{
							int num4 = Class50.smethod_0(74);
							while (true)
							{
								switch (num4)
								{
								case 0:
									goto IL_0256;
								case 2:
									if (num5 != 0)
									{
										goto IL_02a3;
									}
									num4 = 1;
									goto case 1;
								case 3:
									num5++;
									goto IL_02a3;
								case 1:
									{
										array[num5] = parameters[num5 - 1].ParameterType;
										num4 = 3;
										goto case 3;
									}
									IL_02a3:
									if (num5 >= num3 && 0 == 0)
									{
										DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, methodInfo2.ReturnType, array, type2, skipVisibility: true);
										while (true)
										{
											int num6 = Class50.smethod_0(75);
											while (true)
											{
												switch (num6)
												{
												case 3:
													goto IL_02f7;
												case 2:
													iLGenerator2 = dynamicMethod.GetILGenerator();
													num6 = 1;
													goto case 1;
												case 1:
													iLGenerator2.Emit(OpCodes.Ldarg_0);
													num6 = 0;
													goto case 0;
												case 0:
												{
													ILGenerator iLGenerator3 = iLGenerator2;
													num7 = num3;
													num8 = 1;
													iLGenerator = iLGenerator3;
													num6 = 3;
													goto IL_02f7;
												}
												case 4:
												{
													for (; i < num7; i++)
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
													iLGenerator2.Emit(OpCodes.Ret);
													Delegate value = dynamicMethod.CreateDelegate(type2);
													fieldInfo2.SetValue(null, value);
													return;
												}
												}
												break;
												IL_02f7:
												i = num8;
												num6 = Class50.smethod_0(69);
											}
										}
									}
									goto case 1;
								}
								break;
								IL_0256:
								num5 = 1;
								num4 = Class50.smethod_0(75);
							}
						}
					}
					goto case 16;
				case 16:
					fieldInfo2.SetValue(null, Delegate.CreateDelegate(fieldInfo2.FieldType, methodInfo2));
					return;
				}
				break;
				IL_001e:
				int_0 = (int_0 + 1) ^ 0x311DDB02 ^ 0x68163AE2 ^ 0x311DDB02;
				num = Class50.smethod_0(71);
			}
		}
	}

	public static void smethod_1(int int_0, int int_1, int int_2, int int_3)
	{
		int_0--;
		int num8 = default(int);
		RuntimeFieldHandle handle2 = default(RuntimeFieldHandle);
		FieldInfo fieldFromHandle = default(FieldInfo);
		RuntimeTypeHandle handle = default(RuntimeTypeHandle);
		MethodInfo methodInfo = default(MethodInfo);
		Type typeFromHandle = default(Type);
		MethodInfo methodInfo2 = default(MethodInfo);
		Type type2 = default(Type);
		FieldInfo fieldInfo2 = default(FieldInfo);
		bool isStatic = default(bool);
		int num4 = default(int);
		ILGenerator iLGenerator = default(ILGenerator);
		int num6 = default(int);
		int num7 = default(int);
		ILGenerator iLGenerator3 = default(ILGenerator);
		int i = default(int);
		while (true)
		{
			int num = Class50.smethod_0(76);
			while (true)
			{
				switch (num)
				{
				case 16:
					int_3 = (int_3 - 1) ^ num8 ^ 0x311DDB02 ^ num8;
					num = 15;
					goto case 15;
				case 15:
					int_1 = (int_1 | (num8 - 15)) ^ 0x2F8A1E76;
					num = 8;
					goto case 8;
				case 8:
					handle2 = moduleHandle_0.ResolveFieldHandle(int_3);
					num = 1;
					goto case 1;
				case 1:
					fieldFromHandle = FieldInfo.GetFieldFromHandle(handle2);
					num = 12;
					goto case 12;
				case 12:
					int_2 = (int_2 + 1) ^ 0x311DDB02 ^ 0x68163AE2 ^ 0x311DDB02;
					num = 2;
					goto IL_0095;
				case 2:
					goto IL_0095;
				case 13:
					int_2--;
					num = 11;
					goto case 11;
				case 11:
					int_0 = (int_0 + 1) ^ 0x2F8A1E76 ^ 0x68163AE2 ^ 0x2F8A1E76;
					num = 0;
					goto case 0;
				case 0:
					num8 = int_1 & 0xFF;
					num = 3;
					goto case 3;
				case 3:
					int_1 ^= num8;
					num = 10;
					goto case 10;
				case 10:
					num8 += 15;
					num = 6;
					goto case 6;
				case 6:
					handle = moduleHandle_0.ResolveTypeHandle(int_0);
					num = 16;
					goto case 16;
				case 5:
					int_3++;
					num = 13;
					goto case 13;
				case 14:
					methodInfo = (MethodInfo)MethodBase.GetMethodFromHandle(moduleHandle_0.ResolveMethodHandle(int_1), moduleHandle_0.ResolveTypeHandle(int_2));
					num = 4;
					goto case 4;
				case 4:
				{
					FieldInfo fieldInfo = fieldFromHandle;
					Type type = typeFromHandle;
					methodInfo2 = methodInfo;
					type2 = type;
					fieldInfo2 = fieldInfo;
					num = 9;
					goto case 9;
				}
				case 9:
					isStatic = methodInfo2.IsStatic;
					num = 7;
					goto case 7;
				case 7:
					if (isStatic)
					{
						num = 17;
					}
					else if (true)
					{
						ParameterInfo[] parameters = methodInfo2.GetParameters();
						int num2 = parameters.Length + 1;
						Type[] array = new Type[num2];
						array[0] = ((methodInfo2.DeclaringType!.IsValueType ? true : false) ? methodInfo2.DeclaringType!.MakeByRefType() : typeof(object));
						while (true)
						{
							int num3 = Class50.smethod_0(74);
							while (true)
							{
								switch (num3)
								{
								case 0:
									goto IL_029b;
								case 1:
									if (num4 != 0)
									{
										goto IL_02e8;
									}
									num3 = 2;
									goto case 2;
								case 3:
									num4++;
									goto IL_02e8;
								case 2:
									{
										array[num4] = parameters[num4 - 1].ParameterType;
										num3 = 3;
										goto case 3;
									}
									IL_02e8:
									if (num4 >= num2 && 0 == 0)
									{
										DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, methodInfo2.ReturnType, array, type2, skipVisibility: true);
										while (true)
										{
											switch (Class50.smethod_0(75))
											{
											default:
												continue;
											case 2:
											{
												iLGenerator = dynamicMethod.GetILGenerator();
												int num5 = 1;
												goto case 1;
											}
											case 1:
											{
												iLGenerator.Emit(OpCodes.Ldarg_0);
												int num5 = 0;
												goto case 0;
											}
											case 0:
											{
												ILGenerator iLGenerator2 = iLGenerator;
												num6 = num2;
												num7 = 1;
												iLGenerator3 = iLGenerator2;
												int num5 = 3;
												goto case 3;
											}
											case 3:
											{
												i = num7;
												int num5 = 4;
												break;
											}
											case 4:
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
										iLGenerator.Emit((fieldInfo2.IsAssembly ? true : false) ? OpCodes.Callvirt : OpCodes.Call, methodInfo2);
										iLGenerator.Emit(OpCodes.Ret);
										Delegate value = dynamicMethod.CreateDelegate(type2);
										fieldInfo2.SetValue(null, value);
										return;
									}
									goto case 2;
								}
								break;
								IL_029b:
								num4 = 1;
								num3 = Class50.smethod_0(68);
							}
						}
					}
					goto case 17;
				case 17:
					fieldInfo2.SetValue(null, Delegate.CreateDelegate(fieldInfo2.FieldType, methodInfo2));
					return;
				}
				break;
				IL_0095:
				typeFromHandle = Type.GetTypeFromHandle(handle);
				num = Class50.smethod_0(73);
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
		ILGenerator iLGenerator2 = default(ILGenerator);
		int num6 = default(int);
		int num8 = default(int);
		ILGenerator iLGenerator = default(ILGenerator);
		int i = default(int);
		while (true)
		{
			int num = Class50.smethod_0(71);
			while (true)
			{
				switch (num)
				{
				case 15:
					int_1--;
					num = 1;
					goto IL_001e;
				case 1:
					goto IL_001e;
				case 17:
					num2 = int_2 & 0xFF;
					num = 19;
					goto case 19;
				case 19:
					int_2 ^= num2;
					num = 12;
					goto case 12;
				case 12:
					num2 += 15;
					num = 11;
					goto case 11;
				case 11:
					handle = moduleHandle_0.ResolveTypeHandle(int_0);
					num = 2;
					goto case 2;
				case 2:
					int_1 = (int_1 + 1) ^ num2 ^ 0x4ED1F3C7 ^ num2;
					num = 18;
					goto case 18;
				case 18:
					handle2 = moduleHandle_0.ResolveMethodHandle(int_1);
					num = 0;
					goto case 0;
				case 0:
					int_2 = (int_2 | (num2 - 15)) ^ 0x311DDB02;
					num = 4;
					goto case 4;
				case 4:
					handle3 = moduleHandle_0.ResolveFieldHandle(int_2);
					num = 3;
					goto case 3;
				case 3:
					fieldFromHandle = FieldInfo.GetFieldFromHandle(handle3);
					num = 13;
					goto case 13;
				case 13:
					typeFromHandle = Type.GetTypeFromHandle(handle);
					num = 7;
					goto case 7;
				case 7:
					constructorInfo = (ConstructorInfo)MethodBase.GetMethodFromHandle(handle2);
					num = 6;
					goto case 6;
				case 6:
				{
					FieldInfo fieldInfo = fieldFromHandle;
					Type type = typeFromHandle;
					constructorInfo2 = constructorInfo;
					type2 = type;
					fieldInfo2 = fieldInfo;
					num = 14;
					goto case 14;
				}
				case 14:
					parameters = constructorInfo2.GetParameters();
					num = 8;
					goto case 8;
				case 8:
					num3 = parameters.Length;
					num = 10;
					goto case 10;
				case 10:
					array = new Type[num3];
					num = 9;
					goto case 9;
				case 9:
					num4 = 0;
					num = 5;
					goto case 5;
				case 5:
					if (num4 == 0)
					{
						goto IL_0218;
					}
					num = 16;
					goto case 16;
				case 20:
					num4++;
					goto IL_0218;
				case 16:
					{
						array[num4] = parameters[num4].ParameterType;
						num = 20;
						goto case 20;
					}
					IL_0218:
					if (num4 >= num3 && 0 == 0)
					{
						DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, constructorInfo2.DeclaringType, array, type2, skipVisibility: true);
						while (true)
						{
							int num5 = Class50.smethod_0(68);
							while (true)
							{
								switch (num5)
								{
								case 2:
								{
									ILGenerator iLGenerator3 = iLGenerator2;
									num6 = num3;
									num8 = 0;
									iLGenerator = iLGenerator3;
									num5 = 0;
									goto IL_0285;
								}
								case 0:
									goto IL_0285;
								case 1:
									iLGenerator2 = dynamicMethod.GetILGenerator();
									num5 = 2;
									goto case 2;
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
									while (true)
									{
										switch (Class50.smethod_0(68))
										{
										default:
											continue;
										case 1:
										{
											iLGenerator2.Emit(OpCodes.Newobj, constructorInfo2);
											int num7 = 0;
											goto case 0;
										}
										case 0:
										{
											iLGenerator2.Emit(OpCodes.Ret);
											int num7 = 2;
											break;
										}
										case 2:
											break;
										}
										break;
									}
									Delegate value = dynamicMethod.CreateDelegate(type2);
									fieldInfo2.SetValue(null, value);
									return;
								}
								}
								break;
								IL_0285:
								i = num8;
								num5 = Class50.smethod_0(67);
							}
						}
					}
					goto case 16;
				}
				break;
				IL_001e:
				int_0 = (int_0 - 1) ^ 0x311DDB02 ^ 0x68163AE2 ^ 0x311DDB02;
				num = Class50.smethod_0(70);
			}
		}
	}

	public static void smethod_3(int int_0, int int_1, int int_2, int int_3)
	{
		int_0++;
		int num4 = default(int);
		RuntimeTypeHandle handle2 = default(RuntimeTypeHandle);
		FieldInfo fieldFromHandle = default(FieldInfo);
		RuntimeFieldHandle handle = default(RuntimeFieldHandle);
		Type typeFromHandle = default(Type);
		ConstructorInfo constructorInfo = default(ConstructorInfo);
		ConstructorInfo constructorInfo2 = default(ConstructorInfo);
		Type type2 = default(Type);
		FieldInfo fieldInfo2 = default(FieldInfo);
		ParameterInfo[] parameters = default(ParameterInfo[]);
		int num2 = default(int);
		Type[] array = default(Type[]);
		int num3 = default(int);
		ILGenerator iLGenerator = default(ILGenerator);
		int num6 = default(int);
		int num7 = default(int);
		ILGenerator iLGenerator3 = default(ILGenerator);
		int i = default(int);
		while (true)
		{
			int num = Class50.smethod_0(77);
			while (true)
			{
				switch (num)
				{
				case 18:
					int_3 = (int_3 | (num4 - 15)) ^ 0x311DDB02;
					num = 17;
					goto IL_002b;
				case 17:
					goto IL_002b;
				case 16:
					int_1--;
					num = 4;
					goto case 4;
				case 4:
					int_2++;
					num = 10;
					goto case 10;
				case 10:
					int_0 = (int_0 - 1) ^ 0x2F8A1E76 ^ 0x68163AE2 ^ 0x2F8A1E76;
					num = 0;
					goto case 0;
				case 0:
					num4 = int_3 & 0xFF;
					num = 14;
					goto case 14;
				case 14:
					int_3 ^= num4;
					num = 2;
					goto case 2;
				case 2:
					num4 += 15;
					num = 12;
					goto case 12;
				case 12:
					handle2 = moduleHandle_0.ResolveTypeHandle(int_0);
					num = 3;
					goto case 3;
				case 3:
					int_1 = (int_1 + 1) ^ num4 ^ 0x4ED1F3C7 ^ num4;
					num = 18;
					goto case 18;
				case 8:
					fieldFromHandle = FieldInfo.GetFieldFromHandle(handle);
					num = 6;
					goto case 6;
				case 6:
					int_2 = (int_2 - 1) ^ 0x2F8A1E76 ^ 0x68163AE2 ^ 0x2F8A1E76;
					num = 19;
					goto case 19;
				case 19:
					typeFromHandle = Type.GetTypeFromHandle(handle2);
					num = 9;
					goto case 9;
				case 9:
					constructorInfo = (constructorInfo = (ConstructorInfo)MethodBase.GetMethodFromHandle(moduleHandle_0.ResolveMethodHandle(int_1), moduleHandle_0.ResolveTypeHandle(int_2)));
					num = 1;
					goto case 1;
				case 1:
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
					num = 20;
					goto case 20;
				case 20:
					num2 = parameters.Length;
					num = 11;
					goto case 11;
				case 11:
					array = new Type[num2];
					num = 7;
					goto case 7;
				case 7:
					num3 = 0;
					num = 5;
					goto case 5;
				case 5:
					if (num3 == 0)
					{
						goto IL_025e;
					}
					num = 15;
					goto case 15;
				case 21:
					num3++;
					goto IL_025e;
				case 15:
					{
						array[num3] = parameters[num3].ParameterType;
						num = 21;
						goto case 21;
					}
					IL_025e:
					if (num3 >= num2 && 0 == 0)
					{
						DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, constructorInfo2.DeclaringType, array, type2, skipVisibility: true);
						while (true)
						{
							int num5 = Class50.smethod_0(74);
							while (true)
							{
								switch (num5)
								{
								case 0:
									goto IL_02b1;
								case 2:
								{
									ILGenerator iLGenerator2 = iLGenerator;
									num6 = num2;
									num7 = 0;
									iLGenerator3 = iLGenerator2;
									num5 = 1;
									goto case 1;
								}
								case 1:
									i = num7;
									num5 = 3;
									goto case 3;
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
									while (true)
									{
										switch (Class50.smethod_0(74))
										{
										default:
											continue;
										case 0:
										{
											iLGenerator.Emit(OpCodes.Newobj, constructorInfo2);
											int num8 = 1;
											goto case 1;
										}
										case 1:
										{
											iLGenerator.Emit(OpCodes.Ret);
											int num8 = 2;
											break;
										}
										case 2:
											break;
										}
										break;
									}
									Delegate value = dynamicMethod.CreateDelegate(type2);
									fieldInfo2.SetValue(null, value);
									return;
								}
								}
								break;
								IL_02b1:
								iLGenerator = dynamicMethod.GetILGenerator();
								num5 = Class50.smethod_0(75);
							}
						}
					}
					goto case 15;
				}
				break;
				IL_002b:
				handle = moduleHandle_0.ResolveFieldHandle(int_3);
				num = Class50.smethod_0(72);
			}
		}
	}
}
