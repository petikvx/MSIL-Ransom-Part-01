using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class DecoratorAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DecoratorAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		WriteLiteralTokenizer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WriteLiteralTokenizer()
	{
	}
}
