using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class InstanceWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InstanceWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeImporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeImporter()
	{
	}
}
