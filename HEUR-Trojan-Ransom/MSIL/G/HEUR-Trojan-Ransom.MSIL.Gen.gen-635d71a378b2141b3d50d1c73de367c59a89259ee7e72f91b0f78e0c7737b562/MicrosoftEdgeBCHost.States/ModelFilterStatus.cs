using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ModelFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ModelFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateInterfaceFilter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateInterfaceFilter()
	{
	}
}
