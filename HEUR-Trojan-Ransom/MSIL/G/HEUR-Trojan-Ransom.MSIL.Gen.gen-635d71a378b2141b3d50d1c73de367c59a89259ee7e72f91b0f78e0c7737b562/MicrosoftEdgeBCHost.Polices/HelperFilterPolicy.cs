using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class HelperFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static HelperFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		AwakeDecorator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakeDecorator()
	{
	}
}
