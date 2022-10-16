using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ObserverOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ObserverOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatLiteralAttribute();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatLiteralAttribute()
	{
	}
}
