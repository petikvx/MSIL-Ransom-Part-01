using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class EventAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static EventAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		InvokeLiteralVisitor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InvokeLiteralVisitor()
	{
	}
}
