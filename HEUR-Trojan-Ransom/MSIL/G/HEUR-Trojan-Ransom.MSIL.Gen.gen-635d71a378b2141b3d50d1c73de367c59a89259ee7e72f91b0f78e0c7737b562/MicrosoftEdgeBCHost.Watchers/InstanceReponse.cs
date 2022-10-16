using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class InstanceReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InstanceReponse()
	{
		WriterPropertyProducer.ResolveStub();
		RemoveLiteralMethod();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RemoveLiteralMethod()
	{
	}
}
