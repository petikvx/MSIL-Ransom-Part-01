using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ImporterRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ImporterRules()
	{
		WriterPropertyProducer.ResolveStub();
		ReflectContext();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReflectContext()
	{
	}
}
