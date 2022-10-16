using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class IssuerFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IssuerFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		IncludeInterfacePolicy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IncludeInterfacePolicy()
	{
	}
}
