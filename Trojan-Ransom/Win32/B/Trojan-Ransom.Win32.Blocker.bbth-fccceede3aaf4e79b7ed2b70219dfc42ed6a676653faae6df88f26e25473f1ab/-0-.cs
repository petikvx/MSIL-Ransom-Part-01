using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Reflection.Emit;
using System.Security;
using System.Text;

internal sealed class _003F0_003F
{
	private static Dictionary<uint, object> 쯘祋拥륋菄䁷㪷m;

	private static Stream ᾐ_FB08죂䜨餴_2AA6ꆲ鰿;

	private static Assembly 뼳沌_24CB頎呛해柯럜;

	[SecuritySafeCritical]
	static _003F0_003F()
	{
		//Discarded unreachable code: IL_0095, IL_009b, IL_00b5, IL_00ba, IL_00c0, IL_00da, IL_00df, IL_00e4, IL_00e9, IL_00ef, IL_00f0
		//IL_00da: Incompatible stack heights: 0 vs 1
		AppDomain.CurrentDomain.ResourceResolve += _003F76_003F;
		쯘祋拥륋菄䁷㪷m = new Dictionary<uint, object>();
		ᾐ_FB08죂䜨餴_2AA6ꆲ鰿 = new MemoryStream();
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		DeflateStream deflateStream = new DeflateStream(executingAssembly.GetManifestResourceStream(Encoding.UTF8.GetString(BitConverter.GetBytes(824073401))), CompressionMode.Decompress);
		byte[] buffer = new byte[4096];
		int num = deflateStream.Read(buffer, 0, 4096);
		do
		{
			ᾐ_FB08죂䜨餴_2AA6ꆲ鰿.Write(buffer, 0, num);
			num = deflateStream.Read(buffer, 0, 4096);
		}
		while (num != 0);
		deflateStream.Dispose();
		_003F8_003F._003F85_003F();
		_003F2_003F._003F84_003F();
	}

	internal static void _003F74_003F(RuntimeFieldHandle _003F161_003F)
	{
		//IL_013e: Incompatible stack heights: 0 vs 1
		//IL_0159: Incompatible stack heights: 0 vs 1
		//IL_016f: Incompatible stack heights: 0 vs 1
		FieldInfo fieldFromHandle = FieldInfo.GetFieldFromHandle(_003F161_003F);
		char[] array = new char[fieldFromHandle.Name.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = (char)((byte)fieldFromHandle.Name[i] ^ i);
		}
		Convert.FromBase64String(new string(array));
		byte[] array2 = (byte[])/*Error near IL_0040: Stack underflow*/;
		ConstructorInfo constructorInfo = fieldFromHandle.Module.ResolveMethod((BitConverter.ToInt32(array2, 0) ^ 0x38D0F3F2) | (array2[4] << 24)) as ConstructorInfo;
		ParameterInfo[] parameters = constructorInfo.GetParameters();
		Type[] array3 = new Type[parameters.Length];
		for (int j = 0; j < parameters.Length; j++)
		{
			array3[j] = parameters[j].ParameterType;
		}
		_ = constructorInfo.DeclaringType!.IsInterface;
		DynamicMethod dynamicMethod;
		if ((int)/*Error near IL_0163: Stack underflow*/ == 0)
		{
			_ = constructorInfo.DeclaringType!.IsArray;
			if ((int)/*Error near IL_0179: Stack underflow*/ == 0)
			{
				dynamicMethod = new DynamicMethod(_003F176_003F._003F177_003F(""), constructorInfo.DeclaringType, array3, constructorInfo.DeclaringType, skipVisibility: true);
				goto IL_00f4;
			}
		}
		dynamicMethod = new DynamicMethod(_003F176_003F._003F177_003F(""), constructorInfo.DeclaringType, array3, fieldFromHandle.DeclaringType, skipVisibility: true);
		goto IL_00f4;
		IL_00f4:
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		for (int k = 0; k < array3.Length; k++)
		{
			iLGenerator.Emit(OpCodes.Ldarg_S, k);
		}
		iLGenerator.Emit(OpCodes.Newobj, constructorInfo);
		iLGenerator.Emit(OpCodes.Ret);
		fieldFromHandle.SetValue(null, dynamicMethod.CreateDelegate(fieldFromHandle.FieldType));
	}

	internal static void _003F75_003F(RuntimeFieldHandle _003F161_003F)
	{
		//IL_0191: Incompatible stack heights: 0 vs 1
		//IL_01aa: Incompatible stack heights: 0 vs 3
		//IL_01c5: Incompatible stack heights: 0 vs 1
		//IL_01d6: Incompatible stack heights: 0 vs 1
		//IL_01fd: Incompatible stack heights: 0 vs 3
		//IL_0212: Incompatible stack heights: 0 vs 2
		//IL_0221: Incompatible stack heights: 0 vs 1
		//IL_0226: Incompatible stack heights: 1 vs 0
		FieldInfo fieldFromHandle = FieldInfo.GetFieldFromHandle(_003F161_003F);
		char[] array = new char[fieldFromHandle.Name.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = (char)((byte)fieldFromHandle.Name[i] ^ i);
		}
		Convert.FromBase64String(new string(array));
		byte[] array2 = (byte[])/*Error near IL_0040: Stack underflow*/;
		MethodInfo methodInfo = fieldFromHandle.Module.ResolveMethod((BitConverter.ToInt32(array2, 1) ^ 0x7FBA16EF) | ((array2[0] & 0x7F) << 24)) as MethodInfo;
		if (methodInfo.IsStatic)
		{
			_ = null;
			Delegate.CreateDelegate(fieldFromHandle.FieldType, methodInfo);
			((FieldInfo)/*Error near IL_007a: Stack underflow*/).SetValue((object?)/*Error near IL_007a: Stack underflow*/, (object?)/*Error near IL_007a: Stack underflow*/);
			return;
		}
		ParameterInfo[] parameters = methodInfo.GetParameters();
		Type[] array3 = new Type[parameters.Length + 1];
		array3[0] = typeof(object);
		for (int j = 0; j < parameters.Length; j++)
		{
			array3[j + 1] = parameters[j].ParameterType;
		}
		_ = methodInfo.DeclaringType!.IsInterface;
		DynamicMethod dynamicMethod;
		if ((int)/*Error near IL_01cf: Stack underflow*/ == 0)
		{
			_ = methodInfo.DeclaringType;
			if (!((Type)/*Error near IL_00d3: Stack underflow*/).IsArray)
			{
				dynamicMethod = new DynamicMethod(_003F176_003F._003F177_003F(""), methodInfo.ReturnType, array3, methodInfo.DeclaringType, skipVisibility: true);
				goto IL_0120;
			}
		}
		dynamicMethod = new DynamicMethod(_003F176_003F._003F177_003F(""), methodInfo.ReturnType, array3, fieldFromHandle.DeclaringType, skipVisibility: true);
		goto IL_0120;
		IL_0120:
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		for (int k = 0; k < array3.Length; k++)
		{
			iLGenerator.Emit(OpCodes.Ldarg, k);
			if (k == 0)
			{
				_ = OpCodes.Castclass;
				Type? declaringType = ((MemberInfo)/*Error near IL_014b: Stack underflow*/).DeclaringType;
				((ILGenerator)/*Error near IL_0150: Stack underflow*/).Emit((OpCode)/*Error near IL_0150: Stack underflow*/, declaringType);
			}
		}
		_ = array2[0] & 0x80;
		OpCode callvirt;
		if ((int)/*Error near IL_021c: Stack underflow*/ != 0)
		{
			callvirt = OpCodes.Callvirt;
		}
		else
		{
			_ = OpCodes.Call;
		}
		((ILGenerator)/*Error near IL_0177: Stack underflow*/).Emit(callvirt, methodInfo);
		iLGenerator.Emit(OpCodes.Ret);
		fieldFromHandle.SetValue(null, dynamicMethod.CreateDelegate(fieldFromHandle.FieldType));
	}

	internal static Assembly _003F76_003F(object _003F162_003F, ResolveEventArgs _003F163_003F)
	{
		if ((object)뼳沌_24CB頎呛해柯럜 == null)
		{
			Stream manifestResourceStream = typeof(_003F0_003F).Assembly.GetManifestResourceStream(_003F176_003F._003F177_003F("2ﻲɆﳰг\ufaf6\u065fݍ\uf7f5\uf6fa\uf5fbଆ\uf3f9൞\uf1ff༬"));
			using BinaryReader binaryReader = new BinaryReader(new DeflateStream(manifestResourceStream, CompressionMode.Decompress));
			byte[] array = binaryReader.ReadBytes(binaryReader.ReadInt32());
			byte b = 93;
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = (byte)(array[i] ^ b);
				b = (byte)(b * 93 % 256);
			}
			뼳沌_24CB頎呛해柯럜 = Assembly.Load(array);
			Buffer.BlockCopy(new byte[array.Length], 0, array, 0, array.Length);
		}
		if (Array.IndexOf(뼳沌_24CB頎呛해柯럜.GetManifestResourceNames(), _003F163_003F.Name) == -1)
		{
			return null;
		}
		return 뼳沌_24CB頎呛해柯럜;
	}
}
