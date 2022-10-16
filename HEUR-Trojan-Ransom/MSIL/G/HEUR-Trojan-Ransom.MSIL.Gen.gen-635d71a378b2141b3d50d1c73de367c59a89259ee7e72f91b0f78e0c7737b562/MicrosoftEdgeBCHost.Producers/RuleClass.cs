using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class RuleClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RuleClass()
	{
		WriterPropertyProducer.ResolveStub();
		ResetInterfaceClass();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResetInterfaceClass()
	{
	}
}
