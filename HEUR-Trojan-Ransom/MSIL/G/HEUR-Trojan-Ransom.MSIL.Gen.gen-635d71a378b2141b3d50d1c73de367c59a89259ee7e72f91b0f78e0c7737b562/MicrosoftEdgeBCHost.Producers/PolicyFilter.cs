using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class PolicyFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PolicyFilter()
	{
		WriterPropertyProducer.ResolveStub();
		IncludeTemplate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IncludeTemplate()
	{
	}
}
