using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class MapExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapExpression()
	{
		WriterPropertyProducer.ResolveStub();
		InvokeLiteralRef();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InvokeLiteralRef()
	{
	}
}
