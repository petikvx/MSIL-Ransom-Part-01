using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class SerializerFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SerializerFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		PublishInterfaceCandidate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PublishInterfaceCandidate()
	{
	}
}
