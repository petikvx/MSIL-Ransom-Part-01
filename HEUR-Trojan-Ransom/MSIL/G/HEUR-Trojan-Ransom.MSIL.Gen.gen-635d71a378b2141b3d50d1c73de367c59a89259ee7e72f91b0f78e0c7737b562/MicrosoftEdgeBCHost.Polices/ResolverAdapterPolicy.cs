using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ResolverAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ResolverAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatLiteralList();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatLiteralList()
	{
	}
}
