using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class HelperWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static HelperWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		CallDecorator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallDecorator()
	{
	}
}
