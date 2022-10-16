using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ContainerExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContainerExpression()
	{
		WriterPropertyProducer.ResolveStub();
		NewLiteralPrototype();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NewLiteralPrototype()
	{
	}
}
