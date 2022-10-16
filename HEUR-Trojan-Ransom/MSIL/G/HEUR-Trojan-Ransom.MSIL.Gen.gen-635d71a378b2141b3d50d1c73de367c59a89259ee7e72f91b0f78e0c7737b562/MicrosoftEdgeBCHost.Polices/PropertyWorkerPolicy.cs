using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class PropertyWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PropertyWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		SetInterfaceRef();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetInterfaceRef()
	{
	}
}
