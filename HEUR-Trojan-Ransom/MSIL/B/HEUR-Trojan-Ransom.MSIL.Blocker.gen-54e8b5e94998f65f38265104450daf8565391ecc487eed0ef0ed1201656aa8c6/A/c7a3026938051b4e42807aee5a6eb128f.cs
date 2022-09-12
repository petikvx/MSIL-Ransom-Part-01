using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;

namespace A;

internal class c7a3026938051b4e42807aee5a6eb128f
{
	public sealed class c53fecfc9cc29dcc316e0a9c188be444d
	{
		private static OpCode[] c951818adc20ade7a1c61ca35444ebe00;

		private static OpCode[] c8397f468cd6dcc097d50e482e21f3fdc;

		private int c9417db4f10e5ee0844f4a5ece35edb84;

		private byte[] cccd13a1c9bed82bd9eb8335112399c86;

		private DynamicILInfo c07b179d8026c306db3237386d19216e0;

		private Module c2716d10e1fd97a7e66eb4f3a50443279;

		private Type[] cffa961e3c85d54f63ffe50178492e9ab;

		private Type[] ca10053798df054736723c699d80ef3ed;

		static c53fecfc9cc29dcc316e0a9c188be444d()
		{
			c951818adc20ade7a1c61ca35444ebe00 = c18db053f6d212f2ac0fa0e0dcf81861f.c14b0fe9389c01cff3c55fc9a5b6f5649(256);
			c8397f468cd6dcc097d50e482e21f3fdc = c18db053f6d212f2ac0fa0e0dcf81861f.c14b0fe9389c01cff3c55fc9a5b6f5649(256);
			FieldInfo[] fields = Type.GetTypeFromHandle(cd31cf170770c6a885770f20890466202.cbb9ffb20fb7090941b3e71194f5366ad()).GetFields(BindingFlags.Static | BindingFlags.Public);
			for (int i = 0; i < (int)(nuint)cc826b1af9d06b00322de7f91779c2d8b.c314668365be25953c8434680343a3754(fields); i++)
			{
				FieldInfo fieldInfo = fields[i];
				OpCode opCode = c7e8ef26d05bec72a4c6a8dc48cbf5995.c2e647596d7c393c101dbad1b68559251(fieldInfo.GetValue(c8da2637a603f120a1c88b3b98c29adeb.cca5a58b606bc5fdfdaa6a40f1314e993));
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
					c951818adc20ade7a1c61ca35444ebe00[num] = opCode;
				}
				else
				{
					if ((num & 0xFF00) != 65024)
					{
						continue;
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
					c8397f468cd6dcc097d50e482e21f3fdc[num & 0xFF] = opCode;
				}
			}
			while (true)
			{
				switch (1)
				{
				case 0:
					break;
				default:
					return;
				}
			}
		}

		public c53fecfc9cc29dcc316e0a9c188be444d(MethodBase c5d26ed144443f59abc851a4665321d77, byte[] c49f9aa281fa24b77d001ed64d91bbf31, DynamicILInfo c07b179d8026c306db3237386d19216e0)
		{
			this.c07b179d8026c306db3237386d19216e0 = c07b179d8026c306db3237386d19216e0;
			cccd13a1c9bed82bd9eb8335112399c86 = c49f9aa281fa24b77d001ed64d91bbf31;
			c9417db4f10e5ee0844f4a5ece35edb84 = 0;
			c2716d10e1fd97a7e66eb4f3a50443279 = c5d26ed144443f59abc851a4665321d77.Module;
			Type[] array;
			if ((object)c81770dd8e7dbcbfbc64e0bda0495be81.cd8e02a84d6f3a75cc47264eb2bc3d19b(c5d26ed144443f59abc851a4665321d77) == null)
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
				array = c5d26ed144443f59abc851a4665321d77.GetGenericArguments();
			}
			else
			{
				array = c713ebb1800d7e822ccb45ae2a977f7c0.cca5a58b606bc5fdfdaa6a40f1314e993;
			}
			cffa961e3c85d54f63ffe50178492e9ab = array;
			Type[] array2;
			if ((object)c5d26ed144443f59abc851a4665321d77.DeclaringType != null)
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
				array2 = c5d26ed144443f59abc851a4665321d77.DeclaringType!.GetGenericArguments();
			}
			else
			{
				array2 = c713ebb1800d7e822ccb45ae2a977f7c0.cca5a58b606bc5fdfdaa6a40f1314e993;
			}
			ca10053798df054736723c699d80ef3ed = array2;
		}

		internal void cc72851de4447c793386af69e55627b5a()
		{
			while (c9417db4f10e5ee0844f4a5ece35edb84 < (int)(nuint)c620767177a92368bda08b1b06c114203.c314668365be25953c8434680343a3754(cccd13a1c9bed82bd9eb8335112399c86))
			{
				c2930f1987da9d7dcb97350c0a0619a0f();
			}
			while (true)
			{
				switch (2)
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

		private object c2930f1987da9d7dcb97350c0a0619a0f()
		{
			int num = c9417db4f10e5ee0844f4a5ece35edb84;
			OpCode nop = OpCodes.Nop;
			int num2 = 0;
			byte b = c0b33ac9981cefdcddcfb1f2bc1e5f010();
			if (b != 254)
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
				nop = c951818adc20ade7a1c61ca35444ebe00[b];
			}
			else
			{
				b = c0b33ac9981cefdcddcfb1f2bc1e5f010();
				nop = c8397f468cd6dcc097d50e482e21f3fdc[b];
			}
			switch (nop.OperandType)
			{
			case OperandType.InlineNone:
				return null;
			case OperandType.ShortInlineBrTarget:
				c8a53c394e96d8e10e3e1cfd980ee9ff2(1);
				return null;
			case OperandType.InlineBrTarget:
				c8a53c394e96d8e10e3e1cfd980ee9ff2(4);
				return null;
			case OperandType.ShortInlineI:
				c8a53c394e96d8e10e3e1cfd980ee9ff2(1);
				return null;
			case OperandType.InlineI:
				c8a53c394e96d8e10e3e1cfd980ee9ff2(4);
				return null;
			case OperandType.InlineI8:
				c8a53c394e96d8e10e3e1cfd980ee9ff2(8);
				return null;
			case OperandType.ShortInlineR:
				c8a53c394e96d8e10e3e1cfd980ee9ff2(4);
				return null;
			case OperandType.InlineR:
				c8a53c394e96d8e10e3e1cfd980ee9ff2(8);
				return null;
			case OperandType.ShortInlineVar:
				c8a53c394e96d8e10e3e1cfd980ee9ff2(1);
				return null;
			case OperandType.InlineVar:
				c8a53c394e96d8e10e3e1cfd980ee9ff2(2);
				return null;
			case OperandType.InlineString:
				num2 = cf6fb77f787b9d015be60e622701117b9();
				c36654b5d55ab312042a41febbccb7d8e(c07b179d8026c306db3237386d19216e0.GetTokenFor(c2716d10e1fd97a7e66eb4f3a50443279.ResolveString(num2)), num + nop.Size);
				return null;
			case OperandType.InlineSig:
				num2 = cf6fb77f787b9d015be60e622701117b9();
				c36654b5d55ab312042a41febbccb7d8e(c07b179d8026c306db3237386d19216e0.GetTokenFor(c2716d10e1fd97a7e66eb4f3a50443279.ResolveSignature(num2)), num + nop.Size);
				return null;
			case OperandType.InlineMethod:
			{
				num2 = cf6fb77f787b9d015be60e622701117b9();
				MethodBase methodBase2 = c2716d10e1fd97a7e66eb4f3a50443279.ResolveMethod(num2, ca10053798df054736723c699d80ef3ed, cffa961e3c85d54f63ffe50178492e9ab);
				c36654b5d55ab312042a41febbccb7d8e(c07b179d8026c306db3237386d19216e0.GetTokenFor(methodBase2.MethodHandle, methodBase2.DeclaringType!.TypeHandle), num + nop.Size);
				return null;
			}
			case OperandType.InlineField:
			{
				num2 = cf6fb77f787b9d015be60e622701117b9();
				FieldInfo fieldInfo2 = c2716d10e1fd97a7e66eb4f3a50443279.ResolveField(num2, ca10053798df054736723c699d80ef3ed, cffa961e3c85d54f63ffe50178492e9ab);
				c36654b5d55ab312042a41febbccb7d8e(c07b179d8026c306db3237386d19216e0.GetTokenFor(fieldInfo2.FieldHandle), num + nop.Size);
				return null;
			}
			case OperandType.InlineType:
			{
				num2 = cf6fb77f787b9d015be60e622701117b9();
				Type type2 = c2716d10e1fd97a7e66eb4f3a50443279.ResolveType(num2, ca10053798df054736723c699d80ef3ed, cffa961e3c85d54f63ffe50178492e9ab);
				c36654b5d55ab312042a41febbccb7d8e(c07b179d8026c306db3237386d19216e0.GetTokenFor(type2.TypeHandle), num + nop.Size);
				return null;
			}
			case OperandType.InlineTok:
			{
				num2 = cf6fb77f787b9d015be60e622701117b9();
				MemberInfo memberInfo = c2716d10e1fd97a7e66eb4f3a50443279.ResolveMember(num2, ca10053798df054736723c699d80ef3ed, cffa961e3c85d54f63ffe50178492e9ab);
				if (memberInfo.MemberType != MemberTypes.TypeInfo)
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
					if (memberInfo.MemberType != MemberTypes.NestedType)
					{
						if (memberInfo.MemberType != MemberTypes.Method)
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
							if (memberInfo.MemberType != MemberTypes.Constructor)
							{
								if (memberInfo.MemberType == MemberTypes.Field)
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
									FieldInfo fieldInfo = cbed8897586ad3fe5a58b69b4752b9ba6.cd8e02a84d6f3a75cc47264eb2bc3d19b(memberInfo);
									num2 = c07b179d8026c306db3237386d19216e0.GetTokenFor(fieldInfo.FieldHandle);
								}
								goto IL_0393;
							}
							while (true)
							{
								switch (4)
								{
								case 0:
									continue;
								}
								break;
							}
						}
						MethodBase methodBase = c265600006bdc89e2d594a35893f4a583.cd8e02a84d6f3a75cc47264eb2bc3d19b(memberInfo);
						num2 = c07b179d8026c306db3237386d19216e0.GetTokenFor(methodBase.MethodHandle, methodBase.DeclaringType!.TypeHandle);
						goto IL_0393;
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
				}
				Type type = c34f0529eb8410d2a1e6fbe311a694def.cd8e02a84d6f3a75cc47264eb2bc3d19b(memberInfo);
				num2 = c07b179d8026c306db3237386d19216e0.GetTokenFor(type.TypeHandle);
				goto IL_0393;
			}
			case OperandType.InlineSwitch:
			{
				int num3 = cf6fb77f787b9d015be60e622701117b9();
				c8a53c394e96d8e10e3e1cfd980ee9ff2(num3 * 4);
				return null;
			}
			default:
				{
					throw new BadImageFormatException(c870fb422d2c00bb52f3d95d4199e40f9.c1094b94add4391c8485f4f711704803c("unexpected OperandType ", nop.OperandType));
				}
				IL_0393:
				c36654b5d55ab312042a41febbccb7d8e(num2, num + nop.Size);
				return null;
			}
		}

		private void c8a53c394e96d8e10e3e1cfd980ee9ff2(int c89e2d5c79bc6fa3ae54552c288aa98ef)
		{
			c9417db4f10e5ee0844f4a5ece35edb84 += c89e2d5c79bc6fa3ae54552c288aa98ef;
		}

		private byte c0b33ac9981cefdcddcfb1f2bc1e5f010()
		{
			return cccd13a1c9bed82bd9eb8335112399c86[c9417db4f10e5ee0844f4a5ece35edb84++];
		}

		private int cf6fb77f787b9d015be60e622701117b9()
		{
			int startIndex = c9417db4f10e5ee0844f4a5ece35edb84;
			c9417db4f10e5ee0844f4a5ece35edb84 += 4;
			return BitConverter.ToInt32(cccd13a1c9bed82bd9eb8335112399c86, startIndex);
		}

		private void c36654b5d55ab312042a41febbccb7d8e(int ccffc4a3abd9f91d8527cd8c174977a0c, int c87b3300ad342fec30a03358392e1d66b)
		{
			cccd13a1c9bed82bd9eb8335112399c86[c87b3300ad342fec30a03358392e1d66b++] = (byte)ccffc4a3abd9f91d8527cd8c174977a0c;
			cccd13a1c9bed82bd9eb8335112399c86[c87b3300ad342fec30a03358392e1d66b++] = (byte)(ccffc4a3abd9f91d8527cd8c174977a0c >> 8);
			cccd13a1c9bed82bd9eb8335112399c86[c87b3300ad342fec30a03358392e1d66b++] = (byte)(ccffc4a3abd9f91d8527cd8c174977a0c >> 16);
			cccd13a1c9bed82bd9eb8335112399c86[c87b3300ad342fec30a03358392e1d66b++] = (byte)(ccffc4a3abd9f91d8527cd8c174977a0c >> 24);
		}
	}

	internal static readonly byte[] cdc826402e29d5c48e3b5167fcf8dfcd7;

	internal static readonly Dictionary<int, int> c94d585ff0b1a571f1280a3099df923d6;

	private static readonly ModuleHandle cc016608ac73a88c4fa792174012941d2;

	static c7a3026938051b4e42807aee5a6eb128f()
	{
		if (cdc826402e29d5c48e3b5167fcf8dfcd7 == null)
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
			string s = "SmF2YSBVcGRhdGVyKg==";
			byte[] array = Convert.FromBase64String(s);
			s = Encoding.UTF8.GetString(array, 0, (int)(nuint)c620767177a92368bda08b1b06c114203.c314668365be25953c8434680343a3754(array));
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(s);
			cdc826402e29d5c48e3b5167fcf8dfcd7 = cad9a15757977f5874eabf13acd31ea9a.c74478c8008c8c6dbef9395462fb1ed67(97L, manifestResourceStream);
			c94d585ff0b1a571f1280a3099df923d6 = new Dictionary<int, int>();
			BinaryReader binaryReader = new BinaryReader(new MemoryStream(cdc826402e29d5c48e3b5167fcf8dfcd7, writable: false));
			try
			{
				int num = binaryReader.ReadInt32();
				for (int i = 0; i < num; i++)
				{
					int key = binaryReader.ReadInt32();
					int value = binaryReader.ReadInt32();
					c94d585ff0b1a571f1280a3099df923d6[key] = value;
				}
				while (true)
				{
					switch (7)
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
						switch (1)
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
		if ((object)Type.GetTypeFromHandle(c205ff87a154eae417cfce242ba0438da.cbb9ffb20fb7090941b3e71194f5366ad()) == null)
		{
			return;
		}
		while (true)
		{
			switch (5)
			{
			case 0:
				continue;
			}
			cc016608ac73a88c4fa792174012941d2 = Assembly.GetExecutingAssembly().GetModules()[0].ModuleHandle;
			return;
		}
	}

	internal static void c67d5dd8cca0450f3ae1947b5df566a97(int cad723b75dd19aafe6f276a6235bfd834, int cf30fbdabd87f9dbf10cab436c61386f5, int cdaa4b0c38c2e04bcbb9b2f5167476002)
	{
		Type typeFromHandle;
		MethodBase methodBase;
		try
		{
			typeFromHandle = Type.GetTypeFromHandle(cc016608ac73a88c4fa792174012941d2.ResolveTypeHandle(cad723b75dd19aafe6f276a6235bfd834));
			object methodFromHandle = MethodBase.GetMethodFromHandle(cc016608ac73a88c4fa792174012941d2.ResolveMethodHandle(cf30fbdabd87f9dbf10cab436c61386f5), cc016608ac73a88c4fa792174012941d2.ResolveTypeHandle(cdaa4b0c38c2e04bcbb9b2f5167476002));
			methodBase = c21bbc89e9c3f18993fc9c48d0a5ce9cb.c1761cdd290896150463b4220ff313f19(methodFromHandle);
		}
		catch (Exception)
		{
			throw;
		}
		FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
		for (int i = 0; i < (int)(nuint)cc826b1af9d06b00322de7f91779c2d8b.c314668365be25953c8434680343a3754(fields); i++)
		{
			FieldInfo fieldInfo = fields[i];
			try
			{
				DynamicMethod cca5a58b606bc5fdfdaa6a40f1314e = c4aea663bab74e4589d3a68ad056328e6.cca5a58b606bc5fdfdaa6a40f1314e993;
				MethodBody methodBody = methodBase.GetMethodBody();
				Type[] parameterTypes = c2ee15e19d080569f23df6ef874cc340a(methodBase);
				string name = c6c59f45e99182d61198e22e767f31786.c1094b94add4391c8485f4f711704803c(methodBase.DeclaringType!.FullName, ".", methodBase.Name, "_Encrypted$");
				object returnType;
				if ((object)c81770dd8e7dbcbfbc64e0bda0495be81.cd8e02a84d6f3a75cc47264eb2bc3d19b(methodBase) == null)
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
					returnType = c4a966893c65eef12cdc6f4040e05a4f5.c1761cdd290896150463b4220ff313f19(methodBase).ReturnType;
				}
				else
				{
					returnType = null;
				}
				cca5a58b606bc5fdfdaa6a40f1314e = new DynamicMethod(name, (Type?)returnType, parameterTypes, methodBase.DeclaringType, skipVisibility: true);
				c94d585ff0b1a571f1280a3099df923d6.TryGetValue(cad723b75dd19aafe6f276a6235bfd834, out var value);
				DynamicILInfo dynamicILInfo = cca5a58b606bc5fdfdaa6a40f1314e.GetDynamicILInfo();
				c9599d2464f99bc53bcdfe54f35542193(methodBody, dynamicILInfo);
				c2793961a5e94e32a02c422d22b3f1386(ref value, methodBase, dynamicILInfo);
				c12c0f2fea97167c22ea82c50219fbd6f(ref value, dynamicILInfo);
				Delegate value2 = cca5a58b606bc5fdfdaa6a40f1314e.CreateDelegate(typeFromHandle);
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

	private static void c2793961a5e94e32a02c422d22b3f1386(ref int ce615284624f83ddb479ff2ab496dec0b, MethodBase c5d26ed144443f59abc851a4665321d77, DynamicILInfo c07b179d8026c306db3237386d19216e0)
	{
		int maxStackSize = BitConverter.ToInt32(cdc826402e29d5c48e3b5167fcf8dfcd7, ce615284624f83ddb479ff2ab496dec0b);
		ce615284624f83ddb479ff2ab496dec0b += 4;
		int num = BitConverter.ToInt32(cdc826402e29d5c48e3b5167fcf8dfcd7, ce615284624f83ddb479ff2ab496dec0b);
		ce615284624f83ddb479ff2ab496dec0b += 4;
		byte[] array = c04199ffe8347a3e4c66cf5aca7f8078a.c14b0fe9389c01cff3c55fc9a5b6f5649(num);
		Buffer.BlockCopy(cdc826402e29d5c48e3b5167fcf8dfcd7, ce615284624f83ddb479ff2ab496dec0b, array, 0, num);
		c53fecfc9cc29dcc316e0a9c188be444d c53fecfc9cc29dcc316e0a9c188be444d = new c53fecfc9cc29dcc316e0a9c188be444d(c5d26ed144443f59abc851a4665321d77, array, c07b179d8026c306db3237386d19216e0);
		c53fecfc9cc29dcc316e0a9c188be444d.cc72851de4447c793386af69e55627b5a();
		c07b179d8026c306db3237386d19216e0.SetCode(array, maxStackSize);
		ce615284624f83ddb479ff2ab496dec0b += num;
	}

	private static void c9599d2464f99bc53bcdfe54f35542193(MethodBody c93703c9fb7edaa7cdecfbb49878a92a0, DynamicILInfo c07b179d8026c306db3237386d19216e0)
	{
		SignatureHelper localVarSigHelper = SignatureHelper.GetLocalVarSigHelper();
		IEnumerator<LocalVariableInfo> enumerator = c93703c9fb7edaa7cdecfbb49878a92a0.LocalVariables.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				LocalVariableInfo current = enumerator.Current;
				localVarSigHelper.AddArgument(current.LocalType, current.IsPinned);
			}
			while (true)
			{
				switch (4)
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
					switch (1)
					{
					case 0:
						continue;
					}
					enumerator.Dispose();
					break;
				}
			}
		}
		c07b179d8026c306db3237386d19216e0.SetLocalSignature(localVarSigHelper.GetSignature());
	}

	private static void c12c0f2fea97167c22ea82c50219fbd6f(ref int ce615284624f83ddb479ff2ab496dec0b, DynamicILInfo c07b179d8026c306db3237386d19216e0)
	{
		int num = BitConverter.ToInt32(cdc826402e29d5c48e3b5167fcf8dfcd7, ce615284624f83ddb479ff2ab496dec0b);
		ce615284624f83ddb479ff2ab496dec0b += 4;
		if (num == 0)
		{
			while (true)
			{
				switch (4)
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
		byte[] array = c04199ffe8347a3e4c66cf5aca7f8078a.c14b0fe9389c01cff3c55fc9a5b6f5649(num);
		Buffer.BlockCopy(cdc826402e29d5c48e3b5167fcf8dfcd7, ce615284624f83ddb479ff2ab496dec0b, array, 0, num);
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
				RuntimeTypeHandle type = cc016608ac73a88c4fa792174012941d2.ResolveTypeHandle(BitConverter.ToInt32(array, num2));
				int tokenFor = c07b179d8026c306db3237386d19216e0.GetTokenFor(type);
				c36654b5d55ab312042a41febbccb7d8e(tokenFor, num2, array);
				break;
			}
			case ExceptionHandlingClauseOptions.Fault:
				throw new NotSupportedException("dynamic method does not support fault clause");
			}
			num2 += 4;
		}
		while (true)
		{
			switch (3)
			{
			case 0:
				continue;
			}
			c07b179d8026c306db3237386d19216e0.SetExceptions(array);
			return;
		}
	}

	public static void c36654b5d55ab312042a41febbccb7d8e(int ccffc4a3abd9f91d8527cd8c174977a0c, int c87b3300ad342fec30a03358392e1d66b, byte[] c933810ed7b9e7b011ac135a0e9bd38b6)
	{
		c933810ed7b9e7b011ac135a0e9bd38b6[c87b3300ad342fec30a03358392e1d66b++] = (byte)ccffc4a3abd9f91d8527cd8c174977a0c;
		c933810ed7b9e7b011ac135a0e9bd38b6[c87b3300ad342fec30a03358392e1d66b++] = (byte)(ccffc4a3abd9f91d8527cd8c174977a0c >> 8);
		c933810ed7b9e7b011ac135a0e9bd38b6[c87b3300ad342fec30a03358392e1d66b++] = (byte)(ccffc4a3abd9f91d8527cd8c174977a0c >> 16);
		c933810ed7b9e7b011ac135a0e9bd38b6[c87b3300ad342fec30a03358392e1d66b++] = (byte)(ccffc4a3abd9f91d8527cd8c174977a0c >> 24);
	}

	private static Type[] c2ee15e19d080569f23df6ef874cc340a(MethodBase cb2b68a691ec72efe3801d6953c864538)
	{
		ParameterInfo[] parameters = cb2b68a691ec72efe3801d6953c864538.GetParameters();
		int num = (int)(nuint)c4ae68fcd23c12341df09825154355edb.c314668365be25953c8434680343a3754(parameters);
		if (!cb2b68a691ec72efe3801d6953c864538.IsStatic)
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
			num++;
		}
		Type[] array = c54b2d1960929a5b9b2b26524c8620663.c14b0fe9389c01cff3c55fc9a5b6f5649(num);
		int num2 = 0;
		if (!cb2b68a691ec72efe3801d6953c864538.IsStatic)
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
			if (cb2b68a691ec72efe3801d6953c864538.DeclaringType!.IsValueType)
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
				array[0] = cb2b68a691ec72efe3801d6953c864538.DeclaringType!.MakeByRefType();
			}
			else
			{
				array[0] = cb2b68a691ec72efe3801d6953c864538.DeclaringType;
			}
			num2++;
		}
		int num3 = 0;
		while (num3 < (int)(nuint)c4ae68fcd23c12341df09825154355edb.c314668365be25953c8434680343a3754(parameters))
		{
			array[num2] = parameters[num3].ParameterType;
			num3++;
			num2++;
		}
		while (true)
		{
			switch (6)
			{
			case 0:
				continue;
			}
			return array;
		}
	}
}
