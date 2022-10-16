using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class AdvisorClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdvisorClass()
	{
		WriterPropertyProducer.ResolveStub();
		DisableInterfaceRegistry();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DisableInterfaceRegistry()
	{
	}
}
