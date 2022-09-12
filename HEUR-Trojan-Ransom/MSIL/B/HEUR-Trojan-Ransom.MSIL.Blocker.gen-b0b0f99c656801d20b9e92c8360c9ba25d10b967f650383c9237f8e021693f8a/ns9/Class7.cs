using System;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using ns1;
using ns8;

namespace ns9;

internal sealed class Class7
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct Struct1
	{
		public byte[] x;
	}

	internal static Func<Type[], Type> smethod_0(TypeInfo typeInfo_0, out Delegate delegate_0, out Type type_0, out string string_0)
	{
		int num = ((typeInfo_0.GetMethod("r") == typeof(void)) ? 1 : 0);
		type_0 = typeof(Class6.Delegate0);
		string_0 = "r";
		Func<Type[], Type> result = ((num == 0) ? new Func<Type[], Type>(Expression.GetFuncType) : new Func<Type[], Type>(Expression.GetActionType));
		if (num != 0)
		{
			delegate_0 = Delegate.CreateDelegate(type_0, typeInfo_0, string_0);
		}
		delegate_0 = null;
		return result;
	}

	internal static void smethod_1(byte[] byte_0, ICryptoTransform icryptoTransform_0)
	{
		Struct1 struct1_ = default(Struct1);
		struct1_.x = byte_0;
		CryptoStream cryptoStream = Class0.smethod_0(icryptoTransform_0);
		smethod_2(cryptoStream, ref struct1_);
		cryptoStream.Close();
	}

	[CompilerGenerated]
	internal static void smethod_2(CryptoStream cryptoStream_0, ref Struct1 struct1_0)
	{
		cryptoStream_0.Write(struct1_0.x, 0, struct1_0.x.Length);
	}
}
