using System;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;

namespace ns4;

internal sealed class Class17 : IDisposable
{
	private readonly Type type_0;

	private readonly object object_0;

	public Class17()
	{
		try
		{
			Assembly assembly = Assembly.Load(GClass4.smethod_0("\u001dĴȿ\u033fЯԤ٦܄\u0829षਡ୯\u0c62ഗลཌྷ၍ᅔቓፕᐇᔋᘖᜇ᠘ᤀ\u1a1a\u1b03ᰞᴑṳ\u1f5a⁂⅙≙⍙\u244f└♆❂⡓⥑⩖⭂ⱎⴍ⸀⽏にㅿ㉰㍲㑹㕒㙽㝮㡂㥺㩿㭶㱼㴬㸧㽬䁫䅮䈴䌾䑮䔾䙪䝢䡧䤲䨳䬺䰺䵤"));
			type_0 = assembly.GetType(GClass4.smethod_0("tşɖ\u0350цՏ؏ݳ\u087aॽ੨୮\u0c72൮\u0e60༶ၔᅤቬ፤ᑧᕽᙶᝢᡮ\u197e\u1a65᭵\u1c25ᵋṬύ⁊Ⅷ≫⍥⑤╧♥"));
		}
		catch (FileNotFoundException)
		{
			Assembly assembly = Assembly.Load(GClass4.smethod_0("eŴɥ\u036aѶկ٫ݣ"));
			type_0 = assembly.GetType(GClass4.smethod_0("\u007fŒə\u035dэՊ؈ݶࡁ\u0940\u0a57\u0b53\u0c49൫\u0e67༳\u105fᅩባ፩ᑬᕸᙱᝧᡵᥣ\u1a7a᭨᰾ᵝṧὧ\u2062Ⅿ≫⍬⑤╊♧❫⡥⥤⩧⭥"));
		}
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
