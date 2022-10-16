using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class MappingRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MappingRules()
	{
		WriterPropertyProducer.ResolveStub();
		EnableListener();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EnableListener()
	{
	}
}
