using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class FieldWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FieldWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		PushInterfaceMock();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushInterfaceMock()
	{
	}
}
