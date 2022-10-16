using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ParamsVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamsVal()
	{
		WriterPropertyProducer.ResolveStub();
		ResetWrapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResetWrapper()
	{
	}
}
