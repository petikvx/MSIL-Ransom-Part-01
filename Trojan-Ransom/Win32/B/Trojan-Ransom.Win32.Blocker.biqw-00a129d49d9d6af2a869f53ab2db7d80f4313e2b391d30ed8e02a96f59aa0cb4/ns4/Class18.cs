using System;
using System.Reflection;
using System.Security.Cryptography;

namespace ns4;

internal sealed class Class18 : IDisposable
{
	private readonly Type type_0;

	private readonly object object_0;

	public Class18()
	{
		Assembly assembly = Assembly.Load(GClass4.smethod_0("eŴɥ\u036aѶկ٫ݣ"));
		type_0 = assembly.GetType(GClass4.smethod_0("fōɀ\u0346є՝\u0601ݽࡈ\u094fਫ਼\u0b58\u0c40൜\u0e5e༈ၦᅖቚፒᑕᕏᙸᝬ\u187cᥬ\u1a73᭣\u1c37ᵜṒὅ⁖Ⅶ≪⍢⑥╿♜❫⡿⥺⩢⭩ⱬⵘ\u2e75⽩びㅭ㉧㍧㑳"));
		object_0 = Activator.CreateInstance(type_0);
	}

	public ICryptoTransform method_0(byte[] byte_0, byte[] byte_1, bool bool_0)
	{
		type_0.GetProperty(GClass4.smethod_0("Hŧɸ"))!.GetSetMethod()!.Invoke(object_0, new object[1] { byte_0 });
		type_0.GetProperty(GClass4.smethod_0("Kŗ"))!.GetSetMethod()!.Invoke(object_0, new object[1] { byte_1 });
		MethodInfo method = type_0.GetMethod(bool_0 ? GClass4.smethod_0("Lżɨ\u036dѿկ\u064dݭࡤॴ\u0a7c୴౷൭\u0e73") : GClass4.smethod_0("Lżɨ\u036dѿկ\u064cݦࡤॴ\u0a7c୴౷൭\u0e73"), new Type[0]);
		return (ICryptoTransform)method.Invoke(object_0, new object[0]);
	}

	public void method_1()
	{
		type_0.GetMethod(GClass4.smethod_0("FŨɦ\u0363ѳ"))!.Invoke(object_0, new object[0]);
	}

	public void Dispose()
	{
		method_1();
	}
}
