using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class EventRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static EventRules()
	{
		WriterPropertyProducer.ResolveStub();
		SetupParam();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetupParam()
	{
	}
}
