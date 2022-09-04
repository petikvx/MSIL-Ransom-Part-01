using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;

namespace _003F1_003F;

internal class _003F28_003F
{
	public sealed class _003F29_003F
	{
		private static OpCode[] _003F296_003F;

		private static OpCode[] _003F297_003F;

		private int _003F298_003F;

		private byte[] _003F299_003F;

		private DynamicILInfo _003F210_003F;

		private Module _003F300_003F;

		private Type[] _003F301_003F;

		private Type[] _003F302_003F;

		static _003F29_003F()
		{
			_003F296_003F = new OpCode[256];
			_003F297_003F = new OpCode[256];
			FieldInfo[] fields = typeof(OpCodes).GetFields(BindingFlags.Static | BindingFlags.Public);
			foreach (FieldInfo fieldInfo in fields)
			{
				OpCode opCode = (OpCode)fieldInfo.GetValue(null);
				ushort num = (ushort)opCode.Value;
				if (num < 256)
				{
					while (true)
					{
						switch (1)
						{
						case 0:
							continue;
						}
						break;
					}
					if (1 == 0)
					{
						/*OpCode not supported: LdMemberToken*/;
					}
					_003F296_003F[num] = opCode;
				}
				else
				{
					if ((num & 0xFF00) != 65024)
					{
						continue;
					}
					while (true)
					{
						switch (6)
						{
						case 0:
							continue;
						}
						break;
					}
					_003F297_003F[num & 0xFF] = opCode;
				}
			}
			while (true)
			{
				switch (3)
				{
				case 0:
					break;
				default:
					return;
				}
			}
		}

		public _003F29_003F(MethodBase _003F209_003F, byte[] _003F216_003F, DynamicILInfo _003F210_003F)
		{
			//IL_008b: Incompatible stack heights: 0 vs 1
			//IL_00aa: Incompatible stack heights: 0 vs 1
			this._003F210_003F = _003F210_003F;
			_003F299_003F = _003F216_003F;
			_003F298_003F = 0;
			_003F300_003F = _003F209_003F.Module;
			object obj;
			if (!(_003F209_003F is ConstructorInfo))
			{
				while (true)
				{
					switch (6)
					{
					case 0:
						continue;
					}
					break;
				}
				if (1 == 0)
				{
					/*OpCode not supported: LdMemberToken*/;
				}
				obj = _003F209_003F.GetGenericArguments();
			}
			else
			{
				obj = null;
			}
			((_003F29_003F)/*Error near IL_0058: Stack underflow*/)._003F301_003F = (Type[])obj;
			object obj2;
			if ((object)_003F209_003F.DeclaringType != null)
			{
				while (true)
				{
					switch (5)
					{
					case 0:
						continue;
					}
					break;
				}
				obj2 = _003F209_003F.DeclaringType!.GetGenericArguments();
			}
			else
			{
				obj2 = null;
			}
			((_003F29_003F)/*Error near IL_008a: Stack underflow*/)._003F302_003F = (Type[])obj2;
		}

		internal void _003F152_003F()
		{
			while (_003F298_003F < _003F299_003F.Length)
			{
				_003F153_003F();
			}
			while (true)
			{
				switch (5)
				{
				case 0:
					continue;
				}
				if (1 == 0)
				{
					/*OpCode not supported: LdMemberToken*/;
				}
				return;
			}
		}

		private object _003F153_003F()
		{
			int num = _003F298_003F;
			OpCode nop = OpCodes.Nop;
			int num2 = 0;
			byte b = _003F155_003F();
			if (b != 254)
			{
				while (true)
				{
					switch (3)
					{
					case 0:
						continue;
					}
					break;
				}
				if (1 == 0)
				{
					/*OpCode not supported: LdMemberToken*/;
				}
				nop = _003F296_003F[b];
			}
			else
			{
				b = _003F155_003F();
				nop = _003F297_003F[b];
			}
			switch (nop.OperandType)
			{
			case OperandType.InlineNone:
				return null;
			case OperandType.ShortInlineBrTarget:
				_003F154_003F(1);
				return null;
			case OperandType.InlineBrTarget:
				_003F154_003F(4);
				return null;
			case OperandType.ShortInlineI:
				_003F154_003F(1);
				return null;
			case OperandType.InlineI:
				_003F154_003F(4);
				return null;
			case OperandType.InlineI8:
				_003F154_003F(8);
				return null;
			case OperandType.ShortInlineR:
				_003F154_003F(4);
				return null;
			case OperandType.InlineR:
				_003F154_003F(8);
				return null;
			case OperandType.ShortInlineVar:
				_003F154_003F(1);
				return null;
			case OperandType.InlineVar:
				_003F154_003F(2);
				return null;
			case OperandType.InlineString:
				num2 = _003F156_003F();
				_003F150_003F(_003F210_003F.GetTokenFor(_003F300_003F.ResolveString(num2)), num + nop.Size);
				return null;
			case OperandType.InlineSig:
				num2 = _003F156_003F();
				_003F150_003F(_003F210_003F.GetTokenFor(_003F300_003F.ResolveSignature(num2)), num + nop.Size);
				return null;
			case OperandType.InlineMethod:
			{
				num2 = _003F156_003F();
				MethodBase methodBase2 = _003F300_003F.ResolveMethod(num2, _003F302_003F, _003F301_003F);
				_003F150_003F(_003F210_003F.GetTokenFor(methodBase2.MethodHandle, methodBase2.DeclaringType!.TypeHandle), num + nop.Size);
				return null;
			}
			case OperandType.InlineField:
			{
				num2 = _003F156_003F();
				FieldInfo fieldInfo2 = _003F300_003F.ResolveField(num2, _003F302_003F, _003F301_003F);
				_003F150_003F(_003F210_003F.GetTokenFor(fieldInfo2.FieldHandle), num + nop.Size);
				return null;
			}
			case OperandType.InlineType:
			{
				num2 = _003F156_003F();
				Type type2 = _003F300_003F.ResolveType(num2, _003F302_003F, _003F301_003F);
				_003F150_003F(_003F210_003F.GetTokenFor(type2.TypeHandle), num + nop.Size);
				return null;
			}
			case OperandType.InlineTok:
			{
				num2 = _003F156_003F();
				MemberInfo memberInfo = _003F300_003F.ResolveMember(num2, _003F302_003F, _003F301_003F);
				if (memberInfo.MemberType != MemberTypes.TypeInfo)
				{
					while (true)
					{
						switch (7)
						{
						case 0:
							continue;
						}
						break;
					}
					if (memberInfo.MemberType != MemberTypes.NestedType)
					{
						if (memberInfo.MemberType != MemberTypes.Method)
						{
							while (true)
							{
								switch (5)
								{
								case 0:
									continue;
								}
								break;
							}
							if (memberInfo.MemberType != MemberTypes.Constructor)
							{
								if (memberInfo.MemberType == MemberTypes.Field)
								{
									while (true)
									{
										switch (5)
										{
										case 0:
											continue;
										}
										break;
									}
									FieldInfo fieldInfo = memberInfo as FieldInfo;
									num2 = _003F210_003F.GetTokenFor(fieldInfo.FieldHandle);
								}
								goto IL_0407;
							}
							while (true)
							{
								switch (6)
								{
								case 0:
									continue;
								}
								break;
							}
						}
						MethodBase methodBase = memberInfo as MethodBase;
						num2 = _003F210_003F.GetTokenFor(methodBase.MethodHandle, methodBase.DeclaringType!.TypeHandle);
						goto IL_0407;
					}
					while (true)
					{
						switch (1)
						{
						case 0:
							continue;
						}
						break;
					}
				}
				Type type = memberInfo as Type;
				num2 = _003F210_003F.GetTokenFor(type.TypeHandle);
				goto IL_0407;
			}
			case OperandType.InlineSwitch:
			{
				int num3 = _003F156_003F();
				_003F154_003F(num3 * 4);
				return null;
			}
			default:
				{
					throw new BadImageFormatException(_003F305_003F._003F306_003F("bŸɰ\u036cѣշٲݤࡪ४ਭ\u0b43౻൯\u0e7bཀྵ\u1069ᅢቑ\u137dᑳᕧᘡ") + nop.OperandType);
				}
				IL_0407:
				_003F150_003F(num2, num + nop.Size);
				return null;
			}
		}

		private void _003F154_003F(int _003F217_003F)
		{
			_003F298_003F += _003F217_003F;
		}

		private byte _003F155_003F()
		{
			return _003F299_003F[_003F298_003F++];
		}

		private int _003F156_003F()
		{
			int startIndex = _003F298_003F;
			_003F298_003F += 4;
			return BitConverter.ToInt32(_003F299_003F, startIndex);
		}

		private void _003F150_003F(int _003F212_003F, int _003F213_003F)
		{
			_003F299_003F[_003F213_003F++] = (byte)_003F212_003F;
			_003F299_003F[_003F213_003F++] = (byte)(_003F212_003F >> 8);
			_003F299_003F[_003F213_003F++] = (byte)(_003F212_003F >> 16);
			_003F299_003F[_003F213_003F++] = (byte)(_003F212_003F >> 24);
		}
	}

	internal static readonly byte[] _003F269_003F;

	internal static readonly Dictionary<int, int> _003F295_003F;

	private static readonly ModuleHandle _003F294_003F;

	static _003F28_003F()
	{
		if (_003F269_003F == null)
		{
			while (true)
			{
				switch (2)
				{
				case 0:
					continue;
				}
				break;
			}
			if (1 == 0)
			{
				/*OpCode not supported: LdMemberToken*/;
			}
			string s = _003F305_003F._003F306_003F("]ŀɀ\u0335ѝԱ٥ݰ");
			byte[] array = Convert.FromBase64String(s);
			s = Encoding.UTF8.GetString(array, 0, array.Length);
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(s);
			_003F269_003F = _003F15_003F._003F127_003F(0, manifestResourceStream);
			_003F295_003F = new Dictionary<int, int>();
			BinaryReader binaryReader = new BinaryReader(new MemoryStream(_003F269_003F, writable: false));
			try
			{
				int num = binaryReader.ReadInt32();
				for (int i = 0; i < num; i++)
				{
					int key = binaryReader.ReadInt32();
					int value = binaryReader.ReadInt32();
					_003F295_003F[key] = value;
				}
				while (true)
				{
					switch (4)
					{
					case 0:
						break;
					default:
						goto end_IL_00ec;
					}
					continue;
					end_IL_00ec:
					break;
				}
			}
			finally
			{
				if (binaryReader != null)
				{
					while (true)
					{
						switch (5)
						{
						case 0:
							continue;
						}
						((IDisposable)binaryReader).Dispose();
						break;
					}
				}
			}
		}
		if ((object)typeof(MulticastDelegate) == null)
		{
			return;
		}
		while (true)
		{
			switch (2)
			{
			case 0:
				continue;
			}
			_003F294_003F = Assembly.GetExecutingAssembly().GetModules()[0].ModuleHandle;
			return;
		}
	}

	internal static void _003F146_003F(int _003F205_003F, int _003F206_003F, int _003F207_003F)
	{
		//IL_00d2: Incompatible stack heights: 0 vs 1
		//IL_010e: Incompatible stack heights: 0 vs 1
		//IL_0113: Incompatible stack heights: 0 vs 1
		Type typeFromHandle;
		MethodBase methodBase;
		try
		{
			typeFromHandle = Type.GetTypeFromHandle(_003F294_003F.ResolveTypeHandle(_003F205_003F));
			object methodFromHandle = MethodBase.GetMethodFromHandle(_003F294_003F.ResolveMethodHandle(_003F206_003F), _003F294_003F.ResolveTypeHandle(_003F207_003F));
			methodBase = (MethodBase)methodFromHandle;
		}
		catch (Exception)
		{
			throw;
		}
		FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
		foreach (FieldInfo fieldInfo in fields)
		{
			try
			{
				DynamicMethod dynamicMethod = null;
				MethodBody methodBody = methodBase.GetMethodBody();
				Type[] array = _003F151_003F(methodBase);
				_ = methodBase.DeclaringType!.FullName + _003F305_003F._003F306_003F("/") + methodBase.Name + _003F305_003F._003F306_003F("Tŏɧ\u036bѵտٵݰࡦ०ਥ");
				if (!(methodBase is ConstructorInfo))
				{
					while (true)
					{
						switch (5)
						{
						case 0:
							continue;
						}
						break;
					}
					if (1 == 0)
					{
						/*OpCode not supported: LdMemberToken*/;
					}
					_ = ((MethodInfo)methodBase).ReturnType;
				}
				else
				{
					_ = null;
				}
				dynamicMethod = new DynamicMethod(parameterTypes: array, owner: methodBase.DeclaringType, name: (string)/*Error near IL_0124: Stack underflow*/, returnType: (Type?)/*Error near IL_0124: Stack underflow*/, skipVisibility: true);
				_003F295_003F.TryGetValue(_003F205_003F, out var value);
				DynamicILInfo dynamicILInfo = dynamicMethod.GetDynamicILInfo();
				_003F148_003F(methodBody, dynamicILInfo);
				_003F147_003F(ref value, methodBase, dynamicILInfo);
				_003F149_003F(ref value, dynamicILInfo);
				Delegate value2 = dynamicMethod.CreateDelegate(typeFromHandle);
				fieldInfo.SetValue(null, value2);
			}
			catch (Exception)
			{
			}
		}
		while (true)
		{
			switch (5)
			{
			case 0:
				break;
			default:
				return;
			}
		}
	}

	private static void _003F147_003F(ref int _003F208_003F, MethodBase _003F209_003F, DynamicILInfo _003F210_003F)
	{
		int maxStackSize = BitConverter.ToInt32(_003F269_003F, _003F208_003F);
		_003F208_003F += 4;
		int num = BitConverter.ToInt32(_003F269_003F, _003F208_003F);
		_003F208_003F += 4;
		byte[] array = new byte[num];
		Buffer.BlockCopy(_003F269_003F, _003F208_003F, array, 0, num);
		_003F29_003F _003F29_003F = new _003F29_003F(_003F209_003F, array, _003F210_003F);
		_003F29_003F._003F152_003F();
		_003F210_003F.SetCode(array, maxStackSize);
		_003F208_003F += num;
	}

	private static void _003F148_003F(MethodBody _003F211_003F, DynamicILInfo _003F210_003F)
	{
		SignatureHelper localVarSigHelper = SignatureHelper.GetLocalVarSigHelper();
		IEnumerator<LocalVariableInfo> enumerator = _003F211_003F.LocalVariables.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				LocalVariableInfo current = enumerator.Current;
				localVarSigHelper.AddArgument(current.LocalType, current.IsPinned);
			}
			while (true)
			{
				switch (1)
				{
				case 0:
					continue;
				}
				if (1 == 0)
				{
					/*OpCode not supported: LdMemberToken*/;
				}
				break;
			}
		}
		finally
		{
			if (enumerator != null)
			{
				while (true)
				{
					switch (5)
					{
					case 0:
						continue;
					}
					enumerator.Dispose();
					break;
				}
			}
		}
		_003F210_003F.SetLocalSignature(localVarSigHelper.GetSignature());
	}

	private static void _003F149_003F(ref int _003F208_003F, DynamicILInfo _003F210_003F)
	{
		int num = BitConverter.ToInt32(_003F269_003F, _003F208_003F);
		_003F208_003F += 4;
		if (num == 0)
		{
			while (true)
			{
				switch (7)
				{
				case 0:
					break;
				default:
					if (1 == 0)
					{
						/*OpCode not supported: LdMemberToken*/;
					}
					return;
				}
			}
		}
		byte[] array = new byte[num];
		Buffer.BlockCopy(_003F269_003F, _003F208_003F, array, 0, num);
		int num2 = 4;
		int num3 = (num - 4) / 24;
		for (int i = 0; i < num3; i++)
		{
			ExceptionHandlingClauseOptions exceptionHandlingClauseOptions = (ExceptionHandlingClauseOptions)BitConverter.ToInt32(array, num2);
			num2 += 20;
			switch (exceptionHandlingClauseOptions)
			{
			case ExceptionHandlingClauseOptions.Clause:
			{
				RuntimeTypeHandle type = _003F294_003F.ResolveTypeHandle(BitConverter.ToInt32(array, num2));
				int tokenFor = _003F210_003F.GetTokenFor(type);
				_003F150_003F(tokenFor, num2, array);
				break;
			}
			case ExceptionHandlingClauseOptions.Fault:
				throw new NotSupportedException(_003F305_003F._003F306_003F("HŒɄ\u0348хՎم܅ࡉ\u0946\u0a56\u0b49\u0c4fൻ\u0e3e\u0f79\u1073ᅾቩጹᑶᕸᙢ᜵ᡧᥦ\u1a62᭡᱿ᵽṺἭ\u206aⅪ≿⍥⑼┧♥❩⡥⥶⩱⭤"));
			}
			num2 += 4;
		}
		while (true)
		{
			switch (2)
			{
			case 0:
				continue;
			}
			_003F210_003F.SetExceptions(array);
			return;
		}
	}

	public static void _003F150_003F(int _003F212_003F, int _003F213_003F, byte[] _003F214_003F)
	{
		_003F214_003F[_003F213_003F++] = (byte)_003F212_003F;
		_003F214_003F[_003F213_003F++] = (byte)(_003F212_003F >> 8);
		_003F214_003F[_003F213_003F++] = (byte)(_003F212_003F >> 16);
		_003F214_003F[_003F213_003F++] = (byte)(_003F212_003F >> 24);
	}

	private static Type[] _003F151_003F(MethodBase _003F215_003F)
	{
		ParameterInfo[] parameters = _003F215_003F.GetParameters();
		int num = parameters.Length;
		if (!_003F215_003F.IsStatic)
		{
			while (true)
			{
				switch (2)
				{
				case 0:
					continue;
				}
				break;
			}
			if (1 == 0)
			{
				/*OpCode not supported: LdMemberToken*/;
			}
			num++;
		}
		Type[] array = new Type[num];
		int num2 = 0;
		if (!_003F215_003F.IsStatic)
		{
			while (true)
			{
				switch (2)
				{
				case 0:
					continue;
				}
				break;
			}
			if (_003F215_003F.DeclaringType!.IsValueType)
			{
				while (true)
				{
					switch (3)
					{
					case 0:
						continue;
					}
					break;
				}
				array[0] = _003F215_003F.DeclaringType!.MakeByRefType();
			}
			else
			{
				array[0] = _003F215_003F.DeclaringType;
			}
			num2++;
		}
		int num3 = 0;
		while (num3 < parameters.Length)
		{
			array[num2] = parameters[num3].ParameterType;
			num3++;
			num2++;
		}
		while (true)
		{
			switch (5)
			{
			case 0:
				continue;
			}
			return array;
		}
	}
}
