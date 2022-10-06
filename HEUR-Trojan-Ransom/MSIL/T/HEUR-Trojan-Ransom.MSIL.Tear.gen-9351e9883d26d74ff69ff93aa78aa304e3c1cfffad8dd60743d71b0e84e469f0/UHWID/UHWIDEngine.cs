using System.Runtime.CompilerServices;

namespace UHWID;

public class UHWIDEngine
{
	[CompilerGenerated]
	private string string_0;

	[CompilerGenerated]
	private string string_1;

	public string SimpleUid
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
		[CompilerGenerated]
		private set
		{
			string_0 = value;
		}
	}

	public string AdvancedUid
	{
		[CompilerGenerated]
		get
		{
			return string_1;
		}
		[CompilerGenerated]
		private set
		{
			string_1 = value;
		}
	}

	public void UhwidEngine()
	{
		method_0();
	}

	private void method_0()
	{
		string text = Class5.smethod_0();
		string cpuID = CpuID.getCpuID();
		string text2 = Class6.smethod_0();
		SimpleUid = text + cpuID;
		AdvancedUid = SimpleUid + text2;
	}

	public UHWIDEngine()
	{
		Class9.T7DkdFQzGSTU8();
		base._002Ector();
	}
}
