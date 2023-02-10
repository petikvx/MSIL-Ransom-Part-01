using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;

namespace A;

internal sealed class W
{
	public sealed class K
	{
		private static OpCode[] m_D;

		private static OpCode[] m_Y;

		private int m_D;

		private byte[] m_D;

		private DynamicILInfo m_D;

		private Module m_D;

		private Type[] m_D;

		private Type[] m_Y;

		static K()
		{
			K.m_D = FY.D(256);
			K.m_Y = FY.D(256);
			FieldInfo[] fields = Type.GetTypeFromHandle(PY.D()).GetFields(BindingFlags.Static | BindingFlags.Public);
			for (int i = 0; i < (int)(nuint)OY.D(fields); i++)
			{
				FieldInfo fieldInfo = fields[i];
				OpCode opCode = CY.D(fieldInfo.GetValue(ZY.D));
				ushort num = (ushort)opCode.Value;
				if (num < 256)
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
					if (1 == 0)
					{
						/*OpCode not supported: LdMemberToken*/;
					}
					K.m_D[num] = opCode;
				}
				else
				{
					if ((num & 0xFF00) != 65024)
					{
						continue;
					}
					while (true)
					{
						switch (7)
						{
						case 0:
							continue;
						}
						break;
					}
					K.m_Y[num & 0xFF] = opCode;
				}
			}
			while (true)
			{
				switch (4)
				{
				case 0:
					break;
				default:
					return;
				}
			}
		}

		public K(MethodBase P_0, byte[] P_1, DynamicILInfo P_2)
		{
			this.m_D = P_2;
			this.m_D = P_1;
			this.m_D = 0;
			this.m_D = P_0.Module;
			Type[] d;
			if ((object)KY.D(P_0) == null)
			{
				while (true)
				{
					switch (4)
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
				d = P_0.GetGenericArguments();
			}
			else
			{
				d = NY.D;
			}
			this.m_D = d;
			Type[] y;
			if ((object)P_0.DeclaringType != null)
			{
				while (true)
				{
					switch (4)
					{
					case 0:
						continue;
					}
					break;
				}
				y = P_0.DeclaringType!.GetGenericArguments();
			}
			else
			{
				y = NY.D;
			}
			this.m_Y = y;
		}

		internal void D()
		{
			while (this.m_D < (int)(nuint)E.D(this.m_D))
			{
				this.D();
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
				return;
			}
		}

		private object D()
		{
			int d = this.m_D;
			OpCode nop = OpCodes.Nop;
			int num = 0;
			byte b = this.D();
			if (b != 254)
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
				nop = K.m_D[b];
			}
			else
			{
				b = this.D();
				nop = K.m_Y[b];
			}
			switch (nop.OperandType)
			{
			case OperandType.InlineNone:
				return null;
			case OperandType.ShortInlineBrTarget:
				D(1);
				return null;
			case OperandType.InlineBrTarget:
				D(4);
				return null;
			case OperandType.ShortInlineI:
				D(1);
				return null;
			case OperandType.InlineI:
				D(4);
				return null;
			case OperandType.InlineI8:
				D(8);
				return null;
			case OperandType.ShortInlineR:
				D(4);
				return null;
			case OperandType.InlineR:
				D(8);
				return null;
			case OperandType.ShortInlineVar:
				D(1);
				return null;
			case OperandType.InlineVar:
				D(2);
				return null;
			case OperandType.InlineString:
				num = this.D();
				Y(this.m_D.GetTokenFor(this.m_D.ResolveString(num)), d + nop.Size);
				return null;
			case OperandType.InlineSig:
				num = this.D();
				Y(this.m_D.GetTokenFor(this.m_D.ResolveSignature(num)), d + nop.Size);
				return null;
			case OperandType.InlineMethod:
			{
				num = this.D();
				MethodBase methodBase2 = this.m_D.ResolveMethod(num, this.m_Y, this.m_D);
				Y(this.m_D.GetTokenFor(methodBase2.MethodHandle, methodBase2.DeclaringType!.TypeHandle), d + nop.Size);
				return null;
			}
			case OperandType.InlineField:
			{
				num = this.D();
				FieldInfo fieldInfo2 = this.m_D.ResolveField(num, this.m_Y, this.m_D);
				Y(this.m_D.GetTokenFor(fieldInfo2.FieldHandle), d + nop.Size);
				return null;
			}
			case OperandType.InlineType:
			{
				num = this.D();
				Type type2 = this.m_D.ResolveType(num, this.m_Y, this.m_D);
				Y(this.m_D.GetTokenFor(type2.TypeHandle), d + nop.Size);
				return null;
			}
			case OperandType.InlineTok:
			{
				num = this.D();
				MemberInfo memberInfo = this.m_D.ResolveMember(num, this.m_Y, this.m_D);
				if (memberInfo.MemberType != MemberTypes.TypeInfo)
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
					if (memberInfo.MemberType != MemberTypes.NestedType)
					{
						if (memberInfo.MemberType != MemberTypes.Method)
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
									FieldInfo fieldInfo = IY.D(memberInfo);
									num = this.m_D.GetTokenFor(fieldInfo.FieldHandle);
								}
								goto IL_0393;
							}
							while (true)
							{
								switch (5)
								{
								case 0:
									continue;
								}
								break;
							}
						}
						MethodBase methodBase = VY.D(memberInfo);
						num = this.m_D.GetTokenFor(methodBase.MethodHandle, methodBase.DeclaringType!.TypeHandle);
						goto IL_0393;
					}
					while (true)
					{
						switch (2)
						{
						case 0:
							continue;
						}
						break;
					}
				}
				Type type = UY.D(memberInfo);
				num = this.m_D.GetTokenFor(type.TypeHandle);
				goto IL_0393;
			}
			case OperandType.InlineSwitch:
			{
				int num2 = this.D();
				D(num2 * 4);
				return null;
			}
			default:
				{
					throw new BadImageFormatException(BY.D("unexpected OperandType ", nop.OperandType));
				}
				IL_0393:
				Y(num, d + nop.Size);
				return null;
			}
		}

		private void D(int P_0)
		{
			this.m_D += P_0;
		}

		private byte D()
		{
			return this.m_D[this.m_D++];
		}

		private int D()
		{
			int d = this.m_D;
			this.m_D += 4;
			return BitConverter.ToInt32(this.m_D, d);
		}

		private void Y(int P_0, int P_1)
		{
			this.m_D[P_1++] = (byte)P_0;
			this.m_D[P_1++] = (byte)(P_0 >> 8);
			this.m_D[P_1++] = (byte)(P_0 >> 16);
			this.m_D[P_1++] = (byte)(P_0 >> 24);
		}
	}

	internal static readonly byte[] D;

	internal static readonly Dictionary<int, int> D;

	private static readonly ModuleHandle m_D;

	static W()
	{
		if (W.D == null)
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
			string s = "S2FzcGVyc2t5Kg==";
			byte[] array = Convert.FromBase64String(s);
			s = Encoding.UTF8.GetString(array, 0, (int)(nuint)E.D(array));
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(s);
			W.D = A.D(97L, manifestResourceStream);
			W.D = new Dictionary<int, int>();
			BinaryReader binaryReader = new BinaryReader(new MemoryStream(W.D, writable: false));
			try
			{
				int num = binaryReader.ReadInt32();
				for (int i = 0; i < num; i++)
				{
					int key = binaryReader.ReadInt32();
					int value = binaryReader.ReadInt32();
					W.D[key] = value;
				}
				while (true)
				{
					switch (3)
					{
					case 0:
						break;
					default:
						goto end_IL_00be;
					}
					continue;
					end_IL_00be:
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
		if ((object)Type.GetTypeFromHandle(MY.D()) == null)
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
			W.m_D = Assembly.GetExecutingAssembly().GetModules()[0].ModuleHandle;
			return;
		}
	}

	internal static void D(int P_0, int P_1, int P_2)
	{
		Type typeFromHandle;
		MethodBase methodBase;
		try
		{
			typeFromHandle = Type.GetTypeFromHandle(W.m_D.ResolveTypeHandle(P_0));
			object methodFromHandle = MethodBase.GetMethodFromHandle(W.m_D.ResolveMethodHandle(P_1), W.m_D.ResolveTypeHandle(P_2));
			methodBase = RY.D(methodFromHandle);
		}
		catch (Exception)
		{
			throw;
		}
		FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
		for (int i = 0; i < (int)(nuint)OY.D(fields); i++)
		{
			FieldInfo fieldInfo = fields[i];
			try
			{
				DynamicMethod d = TY.D;
				MethodBody methodBody = methodBase.GetMethodBody();
				Type[] parameterTypes = D(methodBase);
				string name = QY.D(methodBase.DeclaringType!.FullName, ".", methodBase.Name, "_Encrypted$");
				object returnType;
				if ((object)KY.D(methodBase) == null)
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
					returnType = WY.D(methodBase).ReturnType;
				}
				else
				{
					returnType = null;
				}
				d = new DynamicMethod(name, (Type?)returnType, parameterTypes, methodBase.DeclaringType, skipVisibility: true);
				W.D.TryGetValue(P_0, out var value);
				DynamicILInfo dynamicILInfo = d.GetDynamicILInfo();
				D(methodBody, dynamicILInfo);
				D(ref value, methodBase, dynamicILInfo);
				D(ref value, dynamicILInfo);
				Delegate value2 = d.CreateDelegate(typeFromHandle);
				fieldInfo.SetValue(null, value2);
			}
			catch (Exception)
			{
			}
		}
		while (true)
		{
			switch (7)
			{
			case 0:
				break;
			default:
				return;
			}
		}
	}

	private static void D(ref int P_0, MethodBase P_1, DynamicILInfo P_2)
	{
		int maxStackSize = BitConverter.ToInt32(W.D, P_0);
		P_0 += 4;
		int num = BitConverter.ToInt32(W.D, P_0);
		P_0 += 4;
		byte[] array = J.D(num);
		Buffer.BlockCopy(W.D, P_0, array, 0, num);
		K k = new K(P_1, array, P_2);
		k.D();
		P_2.SetCode(array, maxStackSize);
		P_0 += num;
	}

	private static void D(MethodBody P_0, DynamicILInfo P_1)
	{
		SignatureHelper localVarSigHelper = SignatureHelper.GetLocalVarSigHelper();
		IEnumerator<LocalVariableInfo> enumerator = P_0.LocalVariables.GetEnumerator();
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
					switch (6)
					{
					case 0:
						continue;
					}
					enumerator.Dispose();
					break;
				}
			}
		}
		P_1.SetLocalSignature(localVarSigHelper.GetSignature());
	}

	private static void D(ref int P_0, DynamicILInfo P_1)
	{
		int num = BitConverter.ToInt32(W.D, P_0);
		P_0 += 4;
		if (num == 0)
		{
			while (true)
			{
				switch (5)
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
		byte[] array = J.D(num);
		Buffer.BlockCopy(W.D, P_0, array, 0, num);
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
				RuntimeTypeHandle type = W.m_D.ResolveTypeHandle(BitConverter.ToInt32(array, num2));
				int tokenFor = P_1.GetTokenFor(type);
				D(tokenFor, num2, array);
				break;
			}
			case ExceptionHandlingClauseOptions.Fault:
				throw new NotSupportedException("dynamic method does not support fault clause");
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
			P_1.SetExceptions(array);
			return;
		}
	}

	public static void D(int P_0, int P_1, byte[] P_2)
	{
		P_2[P_1++] = (byte)P_0;
		P_2[P_1++] = (byte)(P_0 >> 8);
		P_2[P_1++] = (byte)(P_0 >> 16);
		P_2[P_1++] = (byte)(P_0 >> 24);
	}

	private static Type[] D(MethodBase P_0)
	{
		ParameterInfo[] parameters = P_0.GetParameters();
		int num = (int)(nuint)XY.D(parameters);
		if (!P_0.IsStatic)
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
		Type[] array = AY.D(num);
		int num2 = 0;
		if (!P_0.IsStatic)
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
			if (P_0.DeclaringType!.IsValueType)
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
				array[0] = P_0.DeclaringType!.MakeByRefType();
			}
			else
			{
				array[0] = P_0.DeclaringType;
			}
			num2++;
		}
		int num3 = 0;
		while (num3 < (int)(nuint)XY.D(parameters))
		{
			array[num2] = parameters[num3].ParameterType;
			num3++;
			num2++;
		}
		while (true)
		{
			switch (7)
			{
			case 0:
				continue;
			}
			return array;
		}
	}
}
