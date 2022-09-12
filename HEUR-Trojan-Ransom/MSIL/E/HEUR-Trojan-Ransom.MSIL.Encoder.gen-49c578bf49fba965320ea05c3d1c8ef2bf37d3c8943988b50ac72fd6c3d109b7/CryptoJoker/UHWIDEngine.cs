using ns0;

namespace CryptoJoker;

public class UHWIDEngine
{
	private string string_0;

	private string string_1;

	private bool bool_0 = false;

	public string SimpleUID => string_0;

	public string AdvancedUID => string_1;

	public UHWIDEngine()
	{
		method_0();
	}

	private void method_0()
	{
		string text = Class2.smethod_0();
		string cpuID = CpuID.getCpuID();
		string text2 = Class3.smethod_0();
		string_0 = text + cpuID;
		string_1 = string_0 + text2;
	}
}
