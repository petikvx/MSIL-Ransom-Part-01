using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;

namespace ExciteRAN;

internal class VectorAttribute
{
	public sealed class MenuStack
	{
		private static OpCode[] windowPosition;

		private static OpCode[] parentLog;

		private int containerToken;

		private byte[] lineHandle;

		private DynamicILInfo currentContainer;

		private Module parentOptions;

		private Type[] captionCollection;

		private Type[] nextSyncObject;

		static MenuStack()
		{
			windowPosition = ActivatorFactory.CleanAssistant(256);
			parentLog = ActivatorFactory.CleanAssistant(256);
			FieldInfo[] fields = Type.GetTypeFromHandle(CommandResolver.CleanAssistant()).GetFields(BindingFlags.Static | BindingFlags.Public);
			for (int i = 0; i < (int)(nuint)FileScope.CleanAssistant(fields); i++)
			{
				FieldInfo fieldInfo = fields[i];
				OpCode opCode = LineEditor.CleanAssistant(fieldInfo.GetValue(ConditionContext.windowPosition));
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
					windowPosition[num] = opCode;
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
					parentLog[num & 0xFF] = opCode;
				}
			}
			while (true)
			{
				switch (6)
				{
				case 0:
					break;
				default:
					return;
				}
			}
		}

		public MenuStack(MethodBase windowPosition, byte[] parentLog, DynamicILInfo containerToken)
		{
			currentContainer = containerToken;
			lineHandle = parentLog;
			this.containerToken = 0;
			parentOptions = windowPosition.Module;
			Type[] genericArguments;
			if ((object)AssistantToken.CleanAssistant(windowPosition) == null)
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
				genericArguments = windowPosition.GetGenericArguments();
			}
			else
			{
				genericArguments = DialogTree.windowPosition;
			}
			captionCollection = genericArguments;
			Type[] genericArguments2;
			if ((object)windowPosition.DeclaringType != null)
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
				genericArguments2 = windowPosition.DeclaringType!.GetGenericArguments();
			}
			else
			{
				genericArguments2 = DialogTree.windowPosition;
			}
			nextSyncObject = genericArguments2;
		}

		internal void ConnectNetwork()
		{
			while (containerToken < (int)(nuint)RegistryLayout.CleanAssistant(lineHandle))
			{
				SaveFile();
			}
			while (true)
			{
				switch (3)
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

		private object SaveFile()
		{
			int num = containerToken;
			OpCode nop = OpCodes.Nop;
			int num2 = 0;
			byte b = RebuildWindow();
			if (b != 254)
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
				nop = windowPosition[b];
			}
			else
			{
				b = RebuildWindow();
				nop = parentLog[b];
			}
			switch (nop.OperandType)
			{
			case OperandType.InlineNone:
				return null;
			case OperandType.ShortInlineBrTarget:
				EditDialog(1);
				return null;
			case OperandType.InlineBrTarget:
				EditDialog(4);
				return null;
			case OperandType.ShortInlineI:
				EditDialog(1);
				return null;
			case OperandType.InlineI:
				EditDialog(4);
				return null;
			case OperandType.InlineI8:
				EditDialog(8);
				return null;
			case OperandType.ShortInlineR:
				EditDialog(4);
				return null;
			case OperandType.InlineR:
				EditDialog(8);
				return null;
			case OperandType.ShortInlineVar:
				EditDialog(1);
				return null;
			case OperandType.InlineVar:
				EditDialog(2);
				return null;
			case OperandType.InlineString:
				num2 = TestOptions();
				DisconnectDeployment(currentContainer.GetTokenFor(parentOptions.ResolveString(num2)), num + nop.Size);
				return null;
			case OperandType.InlineSig:
				num2 = TestOptions();
				DisconnectDeployment(currentContainer.GetTokenFor(parentOptions.ResolveSignature(num2)), num + nop.Size);
				return null;
			case OperandType.InlineMethod:
			{
				num2 = TestOptions();
				MethodBase methodBase2 = parentOptions.ResolveMethod(num2, nextSyncObject, captionCollection);
				DisconnectDeployment(currentContainer.GetTokenFor(methodBase2.MethodHandle, methodBase2.DeclaringType!.TypeHandle), num + nop.Size);
				return null;
			}
			case OperandType.InlineField:
			{
				num2 = TestOptions();
				FieldInfo fieldInfo2 = parentOptions.ResolveField(num2, nextSyncObject, captionCollection);
				DisconnectDeployment(currentContainer.GetTokenFor(fieldInfo2.FieldHandle), num + nop.Size);
				return null;
			}
			case OperandType.InlineType:
			{
				num2 = TestOptions();
				Type type2 = parentOptions.ResolveType(num2, nextSyncObject, captionCollection);
				DisconnectDeployment(currentContainer.GetTokenFor(type2.TypeHandle), num + nop.Size);
				return null;
			}
			case OperandType.InlineTok:
			{
				num2 = TestOptions();
				MemberInfo memberInfo = parentOptions.ResolveMember(num2, nextSyncObject, captionCollection);
				if (memberInfo.MemberType != MemberTypes.TypeInfo)
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
					if (memberInfo.MemberType != MemberTypes.NestedType)
					{
						if (memberInfo.MemberType != MemberTypes.Method)
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
							if (memberInfo.MemberType != MemberTypes.Constructor)
							{
								if (memberInfo.MemberType == MemberTypes.Field)
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
									FieldInfo fieldInfo = BookmarkQueue.CleanAssistant(memberInfo);
									num2 = currentContainer.GetTokenFor(fieldInfo.FieldHandle);
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
						MethodBase methodBase = EmulatorTree.CleanAssistant(memberInfo);
						num2 = currentContainer.GetTokenFor(methodBase.MethodHandle, methodBase.DeclaringType!.TypeHandle);
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
				Type type = PackageService.CleanAssistant(memberInfo);
				num2 = currentContainer.GetTokenFor(type.TypeHandle);
				goto IL_0393;
			}
			case OperandType.InlineSwitch:
			{
				int num3 = TestOptions();
				EditDialog(num3 * 4);
				return null;
			}
			default:
				{
					throw new BadImageFormatException(SymbolHelper.CleanAssistant("unexpected OperandType ", nop.OperandType));
				}
				IL_0393:
				DisconnectDeployment(num2, num + nop.Size);
				return null;
			}
		}

		private void EditDialog(int windowPosition)
		{
			containerToken += windowPosition;
		}

		private byte RebuildWindow()
		{
			return lineHandle[containerToken++];
		}

		private int TestOptions()
		{
			int startIndex = containerToken;
			containerToken += 4;
			return BitConverter.ToInt32(lineHandle, startIndex);
		}

		private void DisconnectDeployment(int windowPosition, int parentLog)
		{
			lineHandle[parentLog++] = (byte)windowPosition;
			lineHandle[parentLog++] = (byte)(windowPosition >> 8);
			lineHandle[parentLog++] = (byte)(windowPosition >> 16);
			lineHandle[parentLog++] = (byte)(windowPosition >> 24);
		}
	}

	internal static readonly byte[] windowPosition;

	internal static readonly Dictionary<int, int> parentLog;

	private static readonly ModuleHandle containerToken;

	static VectorAttribute()
	{
		if (windowPosition == null)
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
			string s = "RXhjaXRlUkFOKg==";
			byte[] bytes = Convert.FromBase64String(s);
			s = Encoding.UTF8.GetString(bytes, 0, (int)(nuint)RegistryLayout.CleanAssistant(bytes));
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(s);
			windowPosition = StreamTree.SaveFile(97L, manifestResourceStream);
			parentLog = new Dictionary<int, int>();
			BinaryReader binaryReader = new BinaryReader(new MemoryStream(windowPosition, writable: false));
			try
			{
				int num = binaryReader.ReadInt32();
				for (int i = 0; i < num; i++)
				{
					int key = binaryReader.ReadInt32();
					int value = binaryReader.ReadInt32();
					parentLog[key] = value;
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
						switch (6)
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
		if ((object)Type.GetTypeFromHandle(BitmapInvoker.CleanAssistant()) == null)
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
			containerToken = Assembly.GetExecutingAssembly().GetModules()[0].ModuleHandle;
			return;
		}
	}

	internal static void SortCommand(int windowPosition, int parentLog, int containerToken)
	{
		Type typeFromHandle;
		MethodBase methodBase;
		try
		{
			typeFromHandle = Type.GetTypeFromHandle(VectorAttribute.containerToken.ResolveTypeHandle(windowPosition));
			object methodFromHandle = MethodBase.GetMethodFromHandle(VectorAttribute.containerToken.ResolveMethodHandle(parentLog), VectorAttribute.containerToken.ResolveTypeHandle(containerToken));
			methodBase = QueueSite.CleanAssistant(methodFromHandle);
		}
		catch (Exception)
		{
			throw;
		}
		FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
		for (int i = 0; i < (int)(nuint)FileScope.CleanAssistant(fields); i++)
		{
			FieldInfo fieldInfo = fields[i];
			try
			{
				DynamicMethod dynamicMethod = LineSerializer.windowPosition;
				MethodBody methodBody = methodBase.GetMethodBody();
				Type[] parameterTypes = ConnectNetwork(methodBase);
				string name = MenuSite.CleanAssistant(methodBase.DeclaringType!.FullName, ".", methodBase.Name, "_Encrypted$");
				object returnType;
				if ((object)AssistantToken.CleanAssistant(methodBase) == null)
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
					returnType = DriveHelper.CleanAssistant(methodBase).ReturnType;
				}
				else
				{
					returnType = null;
				}
				dynamicMethod = new DynamicMethod(name, (Type?)returnType, parameterTypes, methodBase.DeclaringType, skipVisibility: true);
				VectorAttribute.parentLog.TryGetValue(windowPosition, out var value);
				DynamicILInfo dynamicILInfo = dynamicMethod.GetDynamicILInfo();
				ProcessTemplate(methodBody, dynamicILInfo);
				EnableForm(ref value, methodBase, dynamicILInfo);
				JoinServer(ref value, dynamicILInfo);
				Delegate value2 = dynamicMethod.CreateDelegate(typeFromHandle);
				fieldInfo.SetValue(null, value2);
			}
			catch (Exception)
			{
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

	private static void EnableForm(ref int windowPosition, MethodBase parentLog, DynamicILInfo containerToken)
	{
		int maxStackSize = BitConverter.ToInt32(VectorAttribute.windowPosition, windowPosition);
		windowPosition += 4;
		int num = BitConverter.ToInt32(VectorAttribute.windowPosition, windowPosition);
		windowPosition += 4;
		byte[] array = AssistantResolver.CleanAssistant(num);
		Buffer.BlockCopy(VectorAttribute.windowPosition, windowPosition, array, 0, num);
		MenuStack menuStack = new MenuStack(parentLog, array, containerToken);
		menuStack.ConnectNetwork();
		containerToken.SetCode(array, maxStackSize);
		windowPosition += num;
	}

	private static void ProcessTemplate(MethodBody windowPosition, DynamicILInfo parentLog)
	{
		SignatureHelper localVarSigHelper = SignatureHelper.GetLocalVarSigHelper();
		IEnumerator<LocalVariableInfo> enumerator = windowPosition.LocalVariables.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				LocalVariableInfo current = enumerator.Current;
				localVarSigHelper.AddArgument(current.LocalType, current.IsPinned);
			}
			while (true)
			{
				switch (3)
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
		parentLog.SetLocalSignature(localVarSigHelper.GetSignature());
	}

	private static void JoinServer(ref int windowPosition, DynamicILInfo parentLog)
	{
		int num = BitConverter.ToInt32(VectorAttribute.windowPosition, windowPosition);
		windowPosition += 4;
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
		byte[] array = AssistantResolver.CleanAssistant(num);
		Buffer.BlockCopy(VectorAttribute.windowPosition, windowPosition, array, 0, num);
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
				RuntimeTypeHandle type = containerToken.ResolveTypeHandle(BitConverter.ToInt32(array, num2));
				int tokenFor = parentLog.GetTokenFor(type);
				OpenOutline(tokenFor, num2, array);
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
			parentLog.SetExceptions(array);
			return;
		}
	}

	public static void OpenOutline(int windowPosition, int parentLog, byte[] containerToken)
	{
		containerToken[parentLog++] = (byte)windowPosition;
		containerToken[parentLog++] = (byte)(windowPosition >> 8);
		containerToken[parentLog++] = (byte)(windowPosition >> 16);
		containerToken[parentLog++] = (byte)(windowPosition >> 24);
	}

	private static Type[] ConnectNetwork(MethodBase windowPosition)
	{
		ParameterInfo[] parameters = windowPosition.GetParameters();
		int num = (int)(nuint)PathSerializer.CleanAssistant(parameters);
		if (!windowPosition.IsStatic)
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
			num++;
		}
		Type[] array = DomainStack.CleanAssistant(num);
		int num2 = 0;
		if (!windowPosition.IsStatic)
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
			if (windowPosition.DeclaringType!.IsValueType)
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
				array[0] = windowPosition.DeclaringType!.MakeByRefType();
			}
			else
			{
				array[0] = windowPosition.DeclaringType;
			}
			num2++;
		}
		int num3 = 0;
		while (num3 < (int)(nuint)PathSerializer.CleanAssistant(parameters))
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
