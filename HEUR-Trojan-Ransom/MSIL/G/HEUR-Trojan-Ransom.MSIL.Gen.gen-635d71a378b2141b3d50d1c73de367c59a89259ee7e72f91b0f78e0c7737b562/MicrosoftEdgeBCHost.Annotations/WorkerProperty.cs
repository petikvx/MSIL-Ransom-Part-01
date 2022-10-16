using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class WorkerProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WorkerProperty()
	{
		WriterPropertyProducer.ResolveStub();
		PushInterfaceProccesor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushInterfaceProccesor()
	{
	}
}
