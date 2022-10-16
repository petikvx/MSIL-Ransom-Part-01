using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ObjectState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ObjectState()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectInterfaceRecord();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectInterfaceRecord()
	{
	}
}
