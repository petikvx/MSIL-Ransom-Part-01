using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class VisitorState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static VisitorState()
	{
		WriterPropertyProducer.ResolveStub();
		SearchInterfaceMessage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchInterfaceMessage()
	{
	}
}
