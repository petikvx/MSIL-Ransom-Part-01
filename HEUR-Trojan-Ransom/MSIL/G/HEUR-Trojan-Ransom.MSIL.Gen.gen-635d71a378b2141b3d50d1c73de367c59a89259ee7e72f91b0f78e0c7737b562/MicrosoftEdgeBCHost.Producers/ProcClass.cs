using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ProcClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProcClass()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateInterfaceRule();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateInterfaceRule()
	{
	}
}
