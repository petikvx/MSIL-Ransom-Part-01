using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class StatusRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StatusRules()
	{
		WriterPropertyProducer.ResolveStub();
		CallProperty();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallProperty()
	{
	}
}
