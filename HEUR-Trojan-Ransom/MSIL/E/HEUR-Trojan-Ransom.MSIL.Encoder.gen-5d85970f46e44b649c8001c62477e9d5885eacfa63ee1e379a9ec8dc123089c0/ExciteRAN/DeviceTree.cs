using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;

namespace ExciteRAN;

internal sealed class DeviceTree
{
	public sealed class AssemblySerializer
	{
		private static OpCode[] lastHandler;

		private static OpCode[] urlHeader;

		private int logCollection;

		private byte[] handlerDisposed;

		private DynamicILInfo childLine;

		private Module colorAvailable;

		private Type[] managerHeader;

		private Type[] activeSyncObject;

		static AssemblySerializer()
		{
			lastHandler = MemoryType.ResolveFile(256);
			urlHeader = MemoryType.ResolveFile(256);
			FieldInfo[] fields = Type.GetTypeFromHandle(SymbolResolver.ResolveFile()).GetFields(BindingFlags.Static | BindingFlags.Public);
			for (int i = 0; i < (int)(nuint)CommandResolver.ResolveFile(fields); i++)
			{
				FieldInfo fieldInfo = fields[i];
				OpCode opCode = ActivatorConverter.ResolveFile(fieldInfo.GetValue(IconResolver.lastHandler));
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
					lastHandler[num] = opCode;
				}
				else
				{
					if ((num & 0xFF00) != 65024)
					{
						continue;
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
					urlHeader[num & 0xFF] = opCode;
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

		public AssemblySerializer(MethodBase P_0, byte[] P_1, DynamicILInfo P_2)
		{
			childLine = P_2;
			handlerDisposed = P_1;
			logCollection = 0;
			colorAvailable = P_0.Module;
			Type[] genericArguments;
			if ((object)ConnectionHelper.ResolveFile(P_0) == null)
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
				genericArguments = P_0.GetGenericArguments();
			}
			else
			{
				genericArguments = PartitionProvider.lastHandler;
			}
			managerHeader = genericArguments;
			Type[] genericArguments2;
			if ((object)P_0.DeclaringType != null)
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
				genericArguments2 = P_0.DeclaringType!.GetGenericArguments();
			}
			else
			{
				genericArguments2 = PartitionProvider.lastHandler;
			}
			activeSyncObject = genericArguments2;
		}

		internal void RegisterComponent()
		{
			while (logCollection < (int)(nuint)ReferenceSerializer.ResolveFile(handlerDisposed))
			{
				InsertProcess();
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

		private object InsertProcess()
		{
			int num = logCollection;
			OpCode nop = OpCodes.Nop;
			int num2 = 0;
			byte b = UnregisterDatabase();
			if (b != 254)
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
				nop = lastHandler[b];
			}
			else
			{
				b = UnregisterDatabase();
				nop = urlHeader[b];
			}
			switch (nop.OperandType)
			{
			case OperandType.InlineNone:
				return null;
			case OperandType.ShortInlineBrTarget:
				ReplaceResource(1);
				return null;
			case OperandType.InlineBrTarget:
				ReplaceResource(4);
				return null;
			case OperandType.ShortInlineI:
				ReplaceResource(1);
				return null;
			case OperandType.InlineI:
				ReplaceResource(4);
				return null;
			case OperandType.InlineI8:
				ReplaceResource(8);
				return null;
			case OperandType.ShortInlineR:
				ReplaceResource(4);
				return null;
			case OperandType.InlineR:
				ReplaceResource(8);
				return null;
			case OperandType.ShortInlineVar:
				ReplaceResource(1);
				return null;
			case OperandType.InlineVar:
				ReplaceResource(2);
				return null;
			case OperandType.InlineString:
				num2 = ReplaceNetwork();
				BatchBuildReference(childLine.GetTokenFor(colorAvailable.ResolveString(num2)), num + nop.Size);
				return null;
			case OperandType.InlineSig:
				num2 = ReplaceNetwork();
				BatchBuildReference(childLine.GetTokenFor(colorAvailable.ResolveSignature(num2)), num + nop.Size);
				return null;
			case OperandType.InlineMethod:
			{
				num2 = ReplaceNetwork();
				MethodBase methodBase2 = colorAvailable.ResolveMethod(num2, activeSyncObject, managerHeader);
				BatchBuildReference(childLine.GetTokenFor(methodBase2.MethodHandle, methodBase2.DeclaringType!.TypeHandle), num + nop.Size);
				return null;
			}
			case OperandType.InlineField:
			{
				num2 = ReplaceNetwork();
				FieldInfo fieldInfo2 = colorAvailable.ResolveField(num2, activeSyncObject, managerHeader);
				BatchBuildReference(childLine.GetTokenFor(fieldInfo2.FieldHandle), num + nop.Size);
				return null;
			}
			case OperandType.InlineType:
			{
				num2 = ReplaceNetwork();
				Type type2 = colorAvailable.ResolveType(num2, activeSyncObject, managerHeader);
				BatchBuildReference(childLine.GetTokenFor(type2.TypeHandle), num + nop.Size);
				return null;
			}
			case OperandType.InlineTok:
			{
				num2 = ReplaceNetwork();
				MemberInfo memberInfo = colorAvailable.ResolveMember(num2, activeSyncObject, managerHeader);
				if (memberInfo.MemberType != MemberTypes.TypeInfo)
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
					if (memberInfo.MemberType != MemberTypes.NestedType)
					{
						if (memberInfo.MemberType != MemberTypes.Method)
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
									FieldInfo fieldInfo = TemplateProvider.ResolveFile(memberInfo);
									num2 = childLine.GetTokenFor(fieldInfo.FieldHandle);
								}
								goto IL_0393;
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
						MethodBase methodBase = PcitureContext.ResolveFile(memberInfo);
						num2 = childLine.GetTokenFor(methodBase.MethodHandle, methodBase.DeclaringType!.TypeHandle);
						goto IL_0393;
					}
					while (true)
					{
						switch (3)
						{
						case 0:
							continue;
						}
						break;
					}
				}
				Type type = WindowToken.ResolveFile(memberInfo);
				num2 = childLine.GetTokenFor(type.TypeHandle);
				goto IL_0393;
			}
			case OperandType.InlineSwitch:
			{
				int num3 = ReplaceNetwork();
				ReplaceResource(num3 * 4);
				return null;
			}
			default:
				{
					throw new BadImageFormatException(ClientService.ResolveFile("unexpected OperandType ", nop.OperandType));
				}
				IL_0393:
				BatchBuildReference(num2, num + nop.Size);
				return null;
			}
		}

		private void ReplaceResource(int P_0)
		{
			logCollection += P_0;
		}

		private byte UnregisterDatabase()
		{
			return handlerDisposed[logCollection++];
		}

		private int ReplaceNetwork()
		{
			int startIndex = logCollection;
			logCollection += 4;
			return BitConverter.ToInt32(handlerDisposed, startIndex);
		}

		private void BatchBuildReference(int P_0, int P_1)
		{
			handlerDisposed[P_1++] = (byte)P_0;
			handlerDisposed[P_1++] = (byte)(P_0 >> 8);
			handlerDisposed[P_1++] = (byte)(P_0 >> 16);
			handlerDisposed[P_1++] = (byte)(P_0 >> 24);
		}
	}

	internal static readonly byte[] lastHandler;

	internal static readonly Dictionary<int, int> urlHeader;

	private static readonly ModuleHandle logCollection;

	static DeviceTree()
	{
		if (lastHandler == null)
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
			string s = "RXhjaXRlUkFOKg==";
			byte[] array = Convert.FromBase64String(s);
			s = Encoding.UTF8.GetString(array, 0, (int)(nuint)ReferenceSerializer.ResolveFile(array));
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(s);
			lastHandler = PcitureStack.InsertProcess(97L, manifestResourceStream);
			urlHeader = new Dictionary<int, int>();
			BinaryReader binaryReader = new BinaryReader(new MemoryStream(lastHandler, writable: false));
			try
			{
				int num = binaryReader.ReadInt32();
				for (int i = 0; i < num; i++)
				{
					int key = binaryReader.ReadInt32();
					int value = binaryReader.ReadInt32();
					urlHeader[key] = value;
				}
				while (true)
				{
					switch (2)
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
						switch (7)
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
		if ((object)Type.GetTypeFromHandle(NetworkAttribute.ResolveFile()) == null)
		{
			return;
		}
		while (true)
		{
			switch (3)
			{
			case 0:
				continue;
			}
			logCollection = Assembly.GetExecutingAssembly().GetModules()[0].ModuleHandle;
			return;
		}
	}

	internal static void ChangeEditor(int P_0, int P_1, int P_2)
	{
		Type typeFromHandle;
		MethodBase methodBase;
		try
		{
			typeFromHandle = Type.GetTypeFromHandle(logCollection.ResolveTypeHandle(P_0));
			object methodFromHandle = MethodBase.GetMethodFromHandle(logCollection.ResolveMethodHandle(P_1), logCollection.ResolveTypeHandle(P_2));
			methodBase = PathInvoker.ResolveFile(methodFromHandle);
		}
		catch (Exception)
		{
			throw;
		}
		FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
		for (int i = 0; i < (int)(nuint)CommandResolver.ResolveFile(fields); i++)
		{
			FieldInfo fieldInfo = fields[i];
			try
			{
				DynamicMethod dynamicMethod = SolutionSettings.lastHandler;
				MethodBody methodBody = methodBase.GetMethodBody();
				Type[] parameterTypes = RegisterComponent(methodBase);
				string name = ToolbarOptions.ResolveFile(methodBase.DeclaringType!.FullName, ".", methodBase.Name, "_Encrypted$");
				object returnType;
				if ((object)ConnectionHelper.ResolveFile(methodBase) == null)
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
					returnType = FunctionConverter.ResolveFile(methodBase).ReturnType;
				}
				else
				{
					returnType = null;
				}
				dynamicMethod = new DynamicMethod(name, (Type?)returnType, parameterTypes, methodBase.DeclaringType, skipVisibility: true);
				urlHeader.TryGetValue(P_0, out var value);
				DynamicILInfo dynamicILInfo = dynamicMethod.GetDynamicILInfo();
				CloneMethod(methodBody, dynamicILInfo);
				OrderPane(ref value, methodBase, dynamicILInfo);
				ReplaceDevice(ref value, dynamicILInfo);
				Delegate value2 = dynamicMethod.CreateDelegate(typeFromHandle);
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

	private static void OrderPane(ref int P_0, MethodBase P_1, DynamicILInfo P_2)
	{
		int maxStackSize = BitConverter.ToInt32(lastHandler, P_0);
		P_0 += 4;
		int num = BitConverter.ToInt32(lastHandler, P_0);
		P_0 += 4;
		byte[] array = MemoryHelper.ResolveFile(num);
		Buffer.BlockCopy(lastHandler, P_0, array, 0, num);
		AssemblySerializer assemblySerializer = new AssemblySerializer(P_1, array, P_2);
		assemblySerializer.RegisterComponent();
		P_2.SetCode(array, maxStackSize);
		P_0 += num;
	}

	private static void CloneMethod(MethodBody P_0, DynamicILInfo P_1)
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
					switch (4)
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

	private static void ReplaceDevice(ref int P_0, DynamicILInfo P_1)
	{
		int num = BitConverter.ToInt32(lastHandler, P_0);
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
		byte[] array = MemoryHelper.ResolveFile(num);
		Buffer.BlockCopy(lastHandler, P_0, array, 0, num);
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
				RuntimeTypeHandle type = logCollection.ResolveTypeHandle(BitConverter.ToInt32(array, num2));
				int tokenFor = P_1.GetTokenFor(type);
				FreeDatabase(tokenFor, num2, array);
				break;
			}
			case ExceptionHandlingClauseOptions.Fault:
				throw new NotSupportedException("dynamic method does not support fault clause");
			}
			num2 += 4;
		}
		while (true)
		{
			switch (6)
			{
			case 0:
				continue;
			}
			P_1.SetExceptions(array);
			return;
		}
	}

	public static void FreeDatabase(int P_0, int P_1, byte[] P_2)
	{
		P_2[P_1++] = (byte)P_0;
		P_2[P_1++] = (byte)(P_0 >> 8);
		P_2[P_1++] = (byte)(P_0 >> 16);
		P_2[P_1++] = (byte)(P_0 >> 24);
	}

	private static Type[] RegisterComponent(MethodBase P_0)
	{
		ParameterInfo[] parameters = P_0.GetParameters();
		int num = (int)(nuint)ComponentConverter.ResolveFile(parameters);
		if (!P_0.IsStatic)
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
		Type[] array = SymbolLayout.ResolveFile(num);
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
					switch (4)
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
		while (num3 < (int)(nuint)ComponentConverter.ResolveFile(parameters))
		{
			array[num2] = parameters[num3].ParameterType;
			num3++;
			num2++;
		}
		while (true)
		{
			switch (4)
			{
			case 0:
				continue;
			}
			return array;
		}
	}
}
