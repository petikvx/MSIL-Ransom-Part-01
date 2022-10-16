using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class Initializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static Initializer()
	{
		WriterPropertyProducer.ResolveStub();
		EnableValue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EnableValue()
	{
	}
}
