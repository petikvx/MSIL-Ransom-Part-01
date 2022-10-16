using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ContextPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContextPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CompareInterfaceInfo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareInterfaceInfo()
	{
	}
}
