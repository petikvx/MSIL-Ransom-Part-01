using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class DescriptorBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DescriptorBridge()
	{
		WriterPropertyProducer.ResolveStub();
		CollectRecord();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CollectRecord()
	{
	}
}
