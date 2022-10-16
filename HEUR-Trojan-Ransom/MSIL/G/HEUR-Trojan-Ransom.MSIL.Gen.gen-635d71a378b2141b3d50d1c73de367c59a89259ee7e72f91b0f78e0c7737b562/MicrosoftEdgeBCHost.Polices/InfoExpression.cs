using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class InfoExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InfoExpression()
	{
		WriterPropertyProducer.ResolveStub();
		NewLiteralAdapter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NewLiteralAdapter()
	{
	}
}
