using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ProccesorPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProccesorPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ValidateInterfaceAdvisor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidateInterfaceAdvisor()
	{
	}
}
