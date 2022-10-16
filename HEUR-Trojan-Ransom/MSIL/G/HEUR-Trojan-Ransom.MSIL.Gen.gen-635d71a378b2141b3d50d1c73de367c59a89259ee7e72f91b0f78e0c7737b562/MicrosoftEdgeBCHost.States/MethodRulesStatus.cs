using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class MethodRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MethodRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		FindInterfaceParam();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FindInterfaceParam()
	{
	}
}
