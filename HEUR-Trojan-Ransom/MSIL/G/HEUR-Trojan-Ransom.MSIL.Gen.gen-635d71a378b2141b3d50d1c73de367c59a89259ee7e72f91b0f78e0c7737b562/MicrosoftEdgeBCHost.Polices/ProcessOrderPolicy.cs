using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ProcessOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProcessOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		DeleteLiteralGlobal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DeleteLiteralGlobal()
	{
	}
}
