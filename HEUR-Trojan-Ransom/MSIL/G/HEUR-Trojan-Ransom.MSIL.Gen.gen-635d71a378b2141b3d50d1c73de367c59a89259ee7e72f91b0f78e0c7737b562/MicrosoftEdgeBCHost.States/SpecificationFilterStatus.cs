using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class SpecificationFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SpecificationFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		InitInterfaceCreator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InitInterfaceCreator()
	{
	}
}
