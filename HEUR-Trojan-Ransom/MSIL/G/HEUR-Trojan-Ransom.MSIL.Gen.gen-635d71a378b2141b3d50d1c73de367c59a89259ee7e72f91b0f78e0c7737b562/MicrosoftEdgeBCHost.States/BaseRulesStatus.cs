using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class BaseRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BaseRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		DestroyInterfaceRef();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DestroyInterfaceRef()
	{
	}
}
