using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class MappingExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MappingExpression()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectLiteralPrototype();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectLiteralPrototype()
	{
	}
}
