using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;

internal class _003F0_003F
{
	private static Dictionary<uint, object> 㩢焦捴䒺牏Ẕ螁_07B4;

	private static Stream 풊_F522_E249땤锖蓌靏㚽;

	private static Assembly Მ녏_2630_F720髢贿_229E垭;

	static _003F0_003F()
	{
		AppDomain.CurrentDomain.ResourceResolve += _003F31_003F;
		㩢焦捴䒺牏Ẕ螁_07B4 = new Dictionary<uint, object>();
		풊_F522_E249땤锖蓌靏㚽 = new MemoryStream();
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		DeflateStream deflateStream = new DeflateStream(executingAssembly.GetManifestResourceStream(Encoding.UTF8.GetString(BitConverter.GetBytes(1574119582))), CompressionMode.Decompress);
		byte[] buffer = new byte[4096];
		int num = deflateStream.Read(buffer, 0, 4096);
		do
		{
			풊_F522_E249땤锖蓌靏㚽.Write(buffer, 0, num);
			num = deflateStream.Read(buffer, 0, 4096);
		}
		while (num != 0);
		deflateStream.Dispose();
		_003F27_003F._003F71_003F();
	}

	internal static void _003F29_003F(RuntimeFieldHandle _003F73_003F)
	{
		//IL_013e: Incompatible stack heights: 0 vs 1
		//IL_0159: Incompatible stack heights: 0 vs 1
		//IL_016f: Incompatible stack heights: 0 vs 1
		//IL_0196: Incompatible stack heights: 0 vs 3
		FieldInfo fieldFromHandle = FieldInfo.GetFieldFromHandle(_003F73_003F);
		char[] array = new char[fieldFromHandle.Name.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = (char)((byte)fieldFromHandle.Name[i] ^ i);
		}
		Convert.FromBase64String(new string(array));
		byte[] array2 = (byte[])/*Error near IL_0040: Stack underflow*/;
		ConstructorInfo constructorInfo = fieldFromHandle.Module.ResolveMethod((BitConverter.ToInt32(array2, 0) ^ 0x7F31B5FC) | (array2[4] << 24)) as ConstructorInfo;
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
				dynamicMethod = new DynamicMethod(_003F90_003F._003F91_003F(""), constructorInfo.DeclaringType, array3, constructorInfo.DeclaringType, skipVisibility: true);
				goto IL_00f4;
			}
		}
		dynamicMethod = new DynamicMethod(_003F90_003F._003F91_003F(""), constructorInfo.DeclaringType, array3, fieldFromHandle.DeclaringType, skipVisibility: true);
		goto IL_00f4;
		IL_00f4:
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		for (int k = 0; k < array3.Length; k++)
		{
			iLGenerator.Emit(OpCodes.Ldarg_S, k);
		}
		_ = OpCodes.Newobj;
		((ILGenerator)/*Error near IL_01a0: Stack underflow*/).Emit((OpCode)/*Error near IL_01a0: Stack underflow*/, (ConstructorInfo)/*Error near IL_01a0: Stack underflow*/);
		iLGenerator.Emit(OpCodes.Ret);
		fieldFromHandle.SetValue(null, dynamicMethod.CreateDelegate(fieldFromHandle.FieldType));
	}

	internal static void _003F30_003F(RuntimeFieldHandle _003F73_003F)
	{
		//IL_0192: Incompatible stack heights: 0 vs 1
		//IL_01a6: Incompatible stack heights: 0 vs 4
		//IL_01c1: Incompatible stack heights: 0 vs 1
		//IL_01d7: Incompatible stack heights: 0 vs 1
		//IL_01fe: Incompatible stack heights: 0 vs 3
		//IL_020b: Incompatible stack heights: 0 vs 2
		//IL_021a: Incompatible stack heights: 0 vs 1
		//IL_021f: Incompatible stack heights: 1 vs 0
		FieldInfo fieldFromHandle = FieldInfo.GetFieldFromHandle(_003F73_003F);
		char[] array = new char[fieldFromHandle.Name.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = (char)((byte)fieldFromHandle.Name[i] ^ i);
		}
		Convert.FromBase64String(new string(array));
		byte[] array2 = (byte[])/*Error near IL_0040: Stack underflow*/;
		MethodInfo methodInfo = fieldFromHandle.Module.ResolveMethod((BitConverter.ToInt32(array2, 1) ^ 0x5B0C5B6D) | ((array2[0] & 0x7F) << 24)) as MethodInfo;
		if (methodInfo.IsStatic)
		{
			_ = null;
			_ = fieldFromHandle.FieldType;
			Delegate value = Delegate.CreateDelegate((Type)/*Error near IL_007a: Stack underflow*/, (MethodInfo)/*Error near IL_007a: Stack underflow*/);
			((FieldInfo)/*Error near IL_007f: Stack underflow*/).SetValue((object?)/*Error near IL_007f: Stack underflow*/, (object?)value);
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
		if ((int)/*Error near IL_01cb: Stack underflow*/ == 0)
		{
			_ = methodInfo.DeclaringType!.IsArray;
			if ((int)/*Error near IL_01e1: Stack underflow*/ == 0)
			{
				dynamicMethod = new DynamicMethod(_003F90_003F._003F91_003F(""), methodInfo.ReturnType, array3, methodInfo.DeclaringType, skipVisibility: true);
				goto IL_0120;
			}
		}
		dynamicMethod = new DynamicMethod(_003F90_003F._003F91_003F(""), methodInfo.ReturnType, array3, fieldFromHandle.DeclaringType, skipVisibility: true);
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
		OpCode callvirt;
		if ((((byte[])/*Error near IL_0163: Stack underflow*/)[0] & 0x80u) != 0)
		{
			callvirt = OpCodes.Callvirt;
		}
		else
		{
			_ = OpCodes.Call;
		}
		((ILGenerator)/*Error near IL_022b: Stack underflow*/).Emit(callvirt, methodInfo);
		iLGenerator.Emit(OpCodes.Ret);
		fieldFromHandle.SetValue(null, dynamicMethod.CreateDelegate(fieldFromHandle.FieldType));
	}

	internal static Assembly _003F31_003F(object _003F74_003F, ResolveEventArgs _003F75_003F)
	{
		if ((object)Მ녏_2630_F720髢贿_229E垭 == null)
		{
			Stream manifestResourceStream = typeof(_003F0_003F).Assembly.GetManifestResourceStream(_003F90_003F._003F91_003F("\u001e\ud80c\udf09\u0316лՁ笠\uf8f9\uf7fe\uf4e7\uf5fc"));
			using BinaryReader binaryReader = new BinaryReader(new DeflateStream(manifestResourceStream, CompressionMode.Decompress));
			byte[] array = binaryReader.ReadBytes(binaryReader.ReadInt32());
			byte b = 96;
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = (byte)(array[i] ^ b);
				b = (byte)(b * 96 % 256);
			}
			Მ녏_2630_F720髢贿_229E垭 = Assembly.Load(array);
			Buffer.BlockCopy(new byte[array.Length], 0, array, 0, array.Length);
		}
		if (Array.IndexOf(Მ녏_2630_F720髢贿_229E垭.GetManifestResourceNames(), _003F75_003F.Name) == -1)
		{
			return null;
		}
		return Მ녏_2630_F720髢贿_229E垭;
	}
}
