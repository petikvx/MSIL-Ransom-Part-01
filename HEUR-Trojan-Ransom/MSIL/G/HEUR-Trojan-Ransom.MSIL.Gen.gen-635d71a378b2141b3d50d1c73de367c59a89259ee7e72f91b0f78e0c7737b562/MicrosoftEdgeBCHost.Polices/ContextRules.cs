using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ContextRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContextRules()
	{
		WriterPropertyProducer.ResolveStub();
		CheckConfiguration();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CheckConfiguration()
	{
	}
}
