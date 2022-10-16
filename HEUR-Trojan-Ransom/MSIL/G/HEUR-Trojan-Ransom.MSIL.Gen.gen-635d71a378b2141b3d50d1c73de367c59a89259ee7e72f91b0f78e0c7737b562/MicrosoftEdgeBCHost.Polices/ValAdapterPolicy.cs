using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ValAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		InitLiteralConfiguration();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InitLiteralConfiguration()
	{
	}
}
