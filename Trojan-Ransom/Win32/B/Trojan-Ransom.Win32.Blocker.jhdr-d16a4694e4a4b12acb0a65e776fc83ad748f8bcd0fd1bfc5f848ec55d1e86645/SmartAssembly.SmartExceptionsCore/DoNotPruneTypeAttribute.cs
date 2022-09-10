using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace SmartAssembly.SmartExceptionsCore;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface)]
public sealed class DoNotPruneTypeAttribute : Attribute
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 128)]
	private struct Struct14
	{
	}

	private static readonly Array array_0;

	private static readonly Array array_1 = new char[64];

	private static readonly object object_0;

	internal static byte byte_0/* Not supported: data(00) */;

	static DoNotPruneTypeAttribute()
	{
		byte[] publicKeyToken;
		int num = (publicKeyToken = Assembly.GetExecutingAssembly().GetName().GetPublicKeyToken()).Length;
		char[] array = new char[num];
		for (int i = 0; i < num; i++)
		{
			int num2 = i;
			int num3 = publicKeyToken[i] & 0xFF;
			array[num2] = (char)(num3 ^ (num3 << 5));
		}
		array_0 = array;
		object_0 = new string[3];
	}
}
