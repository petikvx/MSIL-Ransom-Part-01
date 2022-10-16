using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class TaskOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TaskOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeLiteralIdentifier();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeLiteralIdentifier()
	{
	}
}
