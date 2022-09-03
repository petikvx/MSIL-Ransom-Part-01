using System;
using System.Management;
using Microsoft.Win32;

namespace ns0;

internal class Class6
{
	public string method_0()
	{
		return method_2() + GClass0.smethod_0("!") + method_3();
	}

	public string method_1()
	{
		string string_ = (method_4() + method_6() + method_5()).ToString();
		return Class2.FunctionClass.method_2(string_);
	}

	private string method_2()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher(GClass0.smethod_0("xŦɧͳњՆ\u064dݎࡔळ"), GClass0.smethod_0("\u0004Űɧ\u036dѥ՜ي\u073d࠶\u093bੜ\u0b4b\u0c57൚\u0e36རၽᅽሡጣᑏᕠᙾᝨ\u187eᥪ\u1a7e᭠ᱦᵠṵὼ⁷ⅷ≧⍬"));
		string text = string.Empty;
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				text = Convert.ToString(((ManagementBaseObject)val2).get_Item(GClass0.smethod_0("JŢɯ\u0364")));
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		try
		{
			text = text.Split(new char[1] { '|' })[0];
			int length = text.Split(new char[1] { ' ' })[0].Length;
			return text.Substring(length).TrimStart(new char[0]).TrimEnd(new char[0]);
		}
		catch
		{
			return GClass0.smethod_0("[ţɧ\u0365ѥվ٦ܧࡕॼ\u0a77୷౧൬");
		}
	}

	private string method_3()
	{
		if (Registry.LocalMachine.OpenSubKey(GClass0.smethod_0("fŌɞ\u034fѝՈ\u065a\u0742\u087aॡ\u0a41\u0b50\u0c41\u0d53\u0e49\u0f6f\u106aᅴታ፵ᑆᕊᙡᝤᡢᥰ\u1a79\u1b4f᱑ᵴṾύ⁼Ⅼ≠⍛⑸╦♫❢⡵⥶⩫⭱ⱞⴱ"))!.GetValue(GClass0.smethod_0("Cŭɭ\u0369Ѳլ٢ݪࡧॳ"))!.ToString()!.Contains(GClass0.smethod_0("{ĺȷ")))
		{
			return GClass0.smethod_0(" Ĵȴ\u0325цժٶܨ");
		}
		return GClass0.smethod_0(" ıȲ\u0325цժٶܨ");
	}

	private string method_4()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher(GClass0.smethod_0("xŦɧͳњՆ\u064dݎࡔळ"), GClass0.smethod_0("fűɿͷѲդ؏܄ࠍ४\u0a79\u0b65\u0c64ഈ\u0e70ཏ။ᄗሑ\u137dᑱᕒᙰ\u177dᡸ\u196f\u1a68᭵ᱫᴸṀ\u1f5e⁐ⅆ≖⌲\u2455╵♹❧⡮⥩⩂⭎Ⱙⴵ⸧⼡うㅔ㉖㌲㐦"));
		string result = string.Empty;
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				result = Convert.ToString(((ManagementBaseObject)val2).get_Item(GClass0.smethod_0("[Ÿɦ\u036bѢյٶݫ\u0871\u094b\u0a65")));
			}
			return result;
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	private string method_5()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher(GClass0.smethod_0("xŦɧͳњՆ\u064dݎࡔळ"), GClass0.smethod_0("Nřɗ\u035fњՌط\u073c࠵\u0952\u0a41ଢ଼\u0c5cര๘ཧ\u1063ᄿሹፕᑋᕩᙴᝣᡇᥫ\u1a62\u1b70ᱥ"));
		string result = string.Empty;
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				result = Convert.ToString(((ManagementBaseObject)val2).get_Item(GClass0.smethod_0("_Ůɸ\u0360ѩիوݰࡩॡ੧୳")));
			}
			return result;
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	public string method_6()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher(GClass0.smethod_0("xŦɧͳњՆ\u064dݎࡔळ"), GClass0.smethod_0("pŧɭ\u0365ќՊؽ\u0736࠻ड़\u0a4b\u0b57ౚശโ\u0f7dၽᄡሣፏᑙᕧᙩᝩᡤ᥉\u1a66᭦ᱳᵴṪὨ\u206fⅧ≳"));
		string result = string.Empty;
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				result = Convert.ToString(((ManagementBaseObject)val2).get_Item(GClass0.smethod_0("Oůɺ\u036bѵկٵݰࡪ७੯")));
			}
			return result;
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}
}
