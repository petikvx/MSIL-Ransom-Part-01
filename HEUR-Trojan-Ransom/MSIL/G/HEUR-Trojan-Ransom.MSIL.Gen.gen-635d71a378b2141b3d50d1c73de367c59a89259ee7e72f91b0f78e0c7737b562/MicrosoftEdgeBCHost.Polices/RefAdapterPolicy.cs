using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class RefAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RefAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		FillLiteralTokenizer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillLiteralTokenizer()
	{
	}
}
