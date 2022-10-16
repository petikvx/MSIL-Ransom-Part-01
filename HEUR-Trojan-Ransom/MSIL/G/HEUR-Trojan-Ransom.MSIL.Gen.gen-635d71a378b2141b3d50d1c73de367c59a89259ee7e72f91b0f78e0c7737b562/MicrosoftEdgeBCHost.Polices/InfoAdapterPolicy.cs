using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class InfoAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InfoAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		WriteLiteralVisitor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WriteLiteralVisitor()
	{
	}
}
