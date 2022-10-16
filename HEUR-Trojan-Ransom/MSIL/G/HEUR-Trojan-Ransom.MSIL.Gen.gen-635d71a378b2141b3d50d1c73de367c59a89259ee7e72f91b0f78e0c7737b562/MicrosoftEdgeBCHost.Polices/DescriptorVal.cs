using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class DescriptorVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DescriptorVal()
	{
		WriterPropertyProducer.ResolveStub();
		CompareTask();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareTask()
	{
	}
}
