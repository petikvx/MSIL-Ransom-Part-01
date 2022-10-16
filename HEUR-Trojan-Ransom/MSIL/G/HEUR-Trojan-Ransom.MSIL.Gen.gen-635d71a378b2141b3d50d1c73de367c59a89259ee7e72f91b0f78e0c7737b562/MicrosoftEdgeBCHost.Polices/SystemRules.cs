using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class SystemRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SystemRules()
	{
		WriterPropertyProducer.ResolveStub();
		DisableParam();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DisableParam()
	{
	}
}
