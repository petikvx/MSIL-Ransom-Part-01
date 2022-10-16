using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class IdentifierWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IdentifierWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ListInterfaceDefinition();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ListInterfaceDefinition()
	{
	}
}
