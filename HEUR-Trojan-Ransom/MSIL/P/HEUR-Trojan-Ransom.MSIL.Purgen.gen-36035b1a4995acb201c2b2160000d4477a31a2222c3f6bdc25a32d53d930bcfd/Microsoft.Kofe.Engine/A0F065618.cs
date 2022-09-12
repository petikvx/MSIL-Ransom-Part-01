using Microsoft.VisualStudio.Debugger.Interop;

namespace Microsoft.Kofe.Engine;

internal sealed class A0F065618 : F2CBE9195, IDebugProgramDestroyEvent2
{
	public const string D4C1F01D6 = "E147E9E3-6440-4073-A7B7-A65592C714B5";

	private readonly uint B3A307B6B;

	public A0F065618(uint exitCode)
	{
		B3A307B6B = exitCode;
	}

	private int BF6CFE948(out uint B234F3994)
	{
		B234F3994 = B3A307B6B;
		return 0;
	}
}
