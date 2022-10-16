using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class PolicyContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PolicyContext()
	{
		WriterPropertyProducer.ResolveStub();
		NewInterfaceRules();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NewInterfaceRules()
	{
	}
}
