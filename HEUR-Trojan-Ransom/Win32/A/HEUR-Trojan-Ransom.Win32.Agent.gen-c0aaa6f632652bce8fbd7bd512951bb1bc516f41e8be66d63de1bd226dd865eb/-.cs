using System;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Resources;
using System.Text;
using System.Windows.Forms;

internal sealed class _E002
{
	private delegate string _E002();

	private sealed class _E003
	{
		private static readonly _E002 m__E000;

		public static readonly _E003 _E001;

		private byte[] _E002;

		static _E003()
		{
			_E003.m__E000 = global::_E002._E001;
			_E001 = new _E003();
		}

		private _E003()
		{
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(_E003.m__E000());
			if (manifestResourceStream != null || 1 == 0)
			{
				_E002 = new byte[16];
				manifestResourceStream.Read(_E002, 0, _E002.Length);
			}
		}

		public string _E000(string _E000, int _E000)
		{
			int num = _E000.Length;
			char[] array = _E000.ToCharArray();
			while (--num >= 0)
			{
				array[num] = (char)(array[num] ^ (_E002[_E000 & 0xF] | _E000));
			}
			return string.Intern(new string(array));
		}
	}

	public static string _E000(string _E000, int _E000)
	{
		return string.Intern(_E003._E001._E000(_E000, _E000));
	}

	public static string _E001()
	{
		char[] array = "ÏÃúã×".ToCharArray();
		int num = array.Length;
		while (--num >= 0)
		{
			array[num] = (char)(array[num] ^ 0x8Du);
		}
		return new string(array);
	}

	static _E002()
	{
	}
}
internal class _E003
{
	private static ModuleHandle m__E000;

	static _E003()
	{
		global::_E003.m__E000 = Assembly.GetExecutingAssembly().ManifestModule.ModuleHandle;
	}

	public static void _E000(RuntimeTypeHandle _E000, int _E000, RuntimeFieldHandle _E000)
	{
		FieldInfo fieldFromHandle = FieldInfo.GetFieldFromHandle(_E000);
		Type typeFromHandle = default(Type);
		MethodInfo methodInfo = default(MethodInfo);
		while (true)
		{
			int num = -22;
			while (true)
			{
				switch (num ^ 0x53)
				{
				case -72:
					_E004(fieldFromHandle, typeFromHandle, methodInfo);
					num = -24;
					continue;
				case -71:
					typeFromHandle = Type.GetTypeFromHandle(_E000);
					num = -23;
					continue;
				case -70:
					methodInfo = (MethodInfo)MethodBase.GetMethodFromHandle(global::_E003.m__E000.ResolveMethodHandle(_E000 ^ 0x2B0EC766));
					num = -21;
					continue;
				case -69:
					return;
				}
				break;
			}
		}
	}

	public static void _E001(RuntimeTypeHandle _E000, int _E000, int _E000, RuntimeFieldHandle _E000)
	{
		FieldInfo fieldFromHandle = FieldInfo.GetFieldFromHandle(_E000);
		Type typeFromHandle = default(Type);
		MethodInfo methodInfo = default(MethodInfo);
		while (true)
		{
			int num = 4;
			while (true)
			{
				switch (num ^ 0x4A)
				{
				case 78:
					typeFromHandle = Type.GetTypeFromHandle(_E000);
					num = 5;
					continue;
				case 79:
					methodInfo = (MethodInfo)MethodBase.GetMethodFromHandle(global::_E003.m__E000.ResolveMethodHandle(_E000 ^ 0x2B0EC766), global::_E003.m__E000.ResolveTypeHandle(_E000 ^ 0x6A4AA430));
					num = 26;
					continue;
				case 80:
					_E004(fieldFromHandle, typeFromHandle, methodInfo);
					num = 27;
					continue;
				case 81:
					return;
				}
				break;
			}
		}
	}

	public static void _E002(RuntimeTypeHandle _E000, int _E000, RuntimeFieldHandle _E000)
	{
		FieldInfo fieldFromHandle = FieldInfo.GetFieldFromHandle(_E000);
		Type typeFromHandle = default(Type);
		ConstructorInfo constructorInfo = default(ConstructorInfo);
		while (true)
		{
			int num = -30;
			while (true)
			{
				switch (num ^ 0x52)
				{
				case -80:
					typeFromHandle = Type.GetTypeFromHandle(_E000);
					num = -32;
					continue;
				case -79:
					_E005(fieldFromHandle, typeFromHandle, constructorInfo);
					num = -31;
					continue;
				case -78:
					constructorInfo = (ConstructorInfo)MethodBase.GetMethodFromHandle(global::_E003.m__E000.ResolveMethodHandle(_E000 ^ 0x21FD536B));
					num = -29;
					continue;
				case -77:
					return;
				}
				break;
			}
		}
	}

	public static void _E003(RuntimeTypeHandle _E000, int _E000, int _E000, RuntimeFieldHandle _E000)
	{
		FieldInfo fieldFromHandle = FieldInfo.GetFieldFromHandle(_E000);
		Type typeFromHandle = default(Type);
		ConstructorInfo constructorInfo = default(ConstructorInfo);
		while (true)
		{
			int num = 7;
			while (true)
			{
				switch (num ^ 0x4F)
				{
				case 72:
					typeFromHandle = Type.GetTypeFromHandle(_E000);
					num = 5;
					continue;
				case 73:
					_E005(fieldFromHandle, typeFromHandle, constructorInfo);
					num = 4;
					continue;
				case 74:
					constructorInfo = (constructorInfo = (ConstructorInfo)MethodBase.GetMethodFromHandle(global::_E003.m__E000.ResolveMethodHandle(_E000 ^ 0x21FD536B), global::_E003.m__E000.ResolveTypeHandle(_E000 ^ 0x6A4AA430)));
					num = 6;
					continue;
				case 75:
					return;
				}
				break;
			}
		}
	}

	private static void _E004(FieldInfo _E000, Type _E000, MethodInfo _E000)
	{
		Delegate @delegate = null;
		if (_E000.IsStatic || 1 == 0)
		{
			@delegate = Delegate.CreateDelegate(_E000.FieldType, _E000);
		}
		else
		{
			ParameterInfo[] parameters = _E000.GetParameters();
			Type[] array = default(Type[]);
			int num3 = default(int);
			while (true)
			{
				int num = 4;
				int num2 = -6;
				while (true)
				{
					switch (num2 ^ 0x4A)
					{
					case -80:
						break;
					default:
						goto IL_0051;
					case -82:
						goto end_IL_003d;
					case -81:
						goto IL_0063;
					}
					goto IL_0034;
					IL_0063:
					switch (num)
					{
					case 72:
						goto IL_0075;
					case 73:
						goto IL_008a;
					case 74:
						goto IL_0099;
					case 75:
						goto IL_00b1;
					}
					num2 = -28;
					continue;
					IL_0099:
					array = new Type[num3];
					num = 5;
					goto IL_0034;
					IL_008a:
					num3 = parameters.Length + 1;
					num = 7;
					goto IL_0034;
					IL_0075:
					if (_E000.DeclaringType!.IsValueType)
					{
						num = 6;
						goto IL_0034;
					}
					if (1 == 0)
					{
						goto IL_00b1;
					}
					array[0] = typeof(object);
					goto IL_00d2;
					IL_00df:
					int num4;
					array[num4] = parameters[num4 - 1].ParameterType;
					num4++;
					goto IL_00f5;
					IL_0034:
					num ^= 0x4D;
					goto IL_0051;
					IL_00b1:
					array[0] = _E000.DeclaringType!.MakeByRefType();
					goto IL_00d2;
					IL_0051:
					num2 = -27;
					continue;
					IL_00d2:
					num4 = 1;
					if (num4 == 0)
					{
						goto IL_00df;
					}
					goto IL_00f5;
					IL_00f5:
					if (num4 >= num3)
					{
						goto end_IL_0057;
					}
					goto IL_00df;
					continue;
					end_IL_003d:
					break;
				}
				continue;
				end_IL_0057:
				break;
			}
			DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, _E000.ReturnType, array, _E000, skipVisibility: true);
			int num7 = default(int);
			ILGenerator iLGenerator = default(ILGenerator);
			int num6 = default(int);
			while (true)
			{
				int num5 = -5;
				while (true)
				{
					switch (num5 ^ 0x47)
					{
					case -73:
						switch (num7)
						{
						default:
							num5 = -6;
							continue;
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
						goto IL_0244;
					case -72:
						iLGenerator.Emit(OpCodes.Ldarg_0);
						num5 = -4;
						continue;
					case -71:
						num7 = num6;
						num5 = -16;
						continue;
					case -70:
						if (num6 != 0)
						{
							goto IL_0253;
						}
						num5 = -2;
						continue;
					case -69:
						num6 = 1;
						num5 = -3;
						continue;
					case -68:
						iLGenerator = dynamicMethod.GetILGenerator();
						num5 = -1;
						continue;
					case -67:
						{
							iLGenerator.Emit(OpCodes.Ldarg_S, num6);
							goto IL_0244;
						}
						IL_0244:
						num6++;
						goto IL_0253;
						IL_0253:
						if (num6 >= num3)
						{
							goto end_IL_0149;
						}
						goto case -71;
					}
					break;
				}
				continue;
				end_IL_0149:
				break;
			}
			iLGenerator.Emit((_E000.IsAssembly ? true : false) ? OpCodes.Callvirt : OpCodes.Call, _E000);
			iLGenerator.Emit(OpCodes.Ret);
			@delegate = dynamicMethod.CreateDelegate(_E000);
		}
		_E000.SetValue(null, @delegate);
	}

	private static void _E005(FieldInfo _E000, Type _E000, ConstructorInfo _E000)
	{
		ParameterInfo[] parameters = _E000.GetParameters();
		int num = parameters.Length;
		Type[] array = new Type[num];
		int num2 = 0;
		if (num2 != 0)
		{
			goto IL_002a;
		}
		goto IL_0041;
		IL_0041:
		if (num2 >= num)
		{
			DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, _E000.DeclaringType, array, _E000, skipVisibility: true);
			int num6 = default(int);
			int num5 = default(int);
			ILGenerator iLGenerator = default(ILGenerator);
			Delegate value = default(Delegate);
			while (true)
			{
				int num3 = -9;
				int num4 = -5;
				while (true)
				{
					switch (num4 ^ 0x48)
					{
					case -77:
						num3 ^= 0x4C;
						goto default;
					default:
						num4 = -6;
						continue;
					case -79:
						break;
					case -78:
						switch (num3)
						{
						default:
							num4 = -7;
							continue;
						case -73:
							num6 = num5;
							num3 = -10;
							break;
						case -72:
							if (num5 == 0)
							{
								goto IL_019c;
							}
							num3 = -5;
							break;
						case -71:
							num5 = 0;
							num3 = -12;
							break;
						case -70:
							switch (num6)
							{
							case 0:
								goto IL_013c;
							case 1:
								goto IL_014a;
							case 2:
								goto IL_0158;
							case 3:
								goto IL_0166;
							}
							num3 = -16;
							break;
						case -69:
							iLGenerator = dynamicMethod.GetILGenerator();
							num3 = -11;
							break;
						case -68:
							{
								iLGenerator.Emit(OpCodes.Ldarg_S, num5);
								goto IL_018e;
							}
							IL_0166:
							iLGenerator.Emit(OpCodes.Ldarg_3);
							goto IL_018e;
							IL_0158:
							iLGenerator.Emit(OpCodes.Ldarg_2);
							goto IL_018e;
							IL_014a:
							iLGenerator.Emit(OpCodes.Ldarg_1);
							goto IL_018e;
							IL_013c:
							iLGenerator.Emit(OpCodes.Ldarg_0);
							goto IL_018e;
							IL_018e:
							num5++;
							goto IL_019c;
							IL_019c:
							if (num5 < num)
							{
								goto case -73;
							}
							iLGenerator.Emit(OpCodes.Newobj, _E000);
							while (true)
							{
								int num7 = 25;
								while (true)
								{
									switch (num7 ^ 0x4A)
									{
									case 83:
										iLGenerator.Emit(OpCodes.Ret);
										num7 = 31;
										continue;
									case 84:
										_E000.SetValue(null, value);
										num7 = 28;
										continue;
									case 85:
										value = dynamicMethod.CreateDelegate(_E000);
										num7 = 30;
										continue;
									case 86:
										return;
									}
									break;
								}
							}
						}
						goto case -77;
					}
					break;
				}
			}
		}
		goto IL_002a;
		IL_002a:
		array[num2] = parameters[num2].ParameterType;
		num2++;
		goto IL_0041;
	}
}
internal delegate void _E004(object _E000, PaintEventArgs _E000);
internal delegate void _E005(object _E000);
internal delegate void _E006(object _E000, bool _E000);
internal delegate Container _E007();
internal delegate Type _E008(RuntimeTypeHandle _E000);
internal delegate MethodInfo _E009(object _E000, string _E000);
internal delegate Delegate _E00A(Type _E000, MethodInfo _E000);
internal delegate Delegate _E00B(Type _E000, Type _E000, string _E000);
internal delegate MethodInfo _E00C(object _E000, string _E000, Type[] _E000);
internal delegate int _E00D(object _E000, int _E000);
internal delegate AppDomain _E00E();
internal delegate Assembly _E00F(object _E000, byte[] _E000);
internal delegate Type _E010(object _E000, string _E000);
internal delegate Random _E011(int _E000);
internal delegate Encoding _E012();
internal delegate Delegate _E013(Type _E000, object _E000, MethodInfo _E000);
internal delegate bool _E014(object _E000, object _E000);
internal delegate Assembly _E015(object _E000);
internal delegate ResourceManager _E016(string _E000, Assembly _E000);
internal delegate object _E017(object _E000, string _E000, CultureInfo _E000);
