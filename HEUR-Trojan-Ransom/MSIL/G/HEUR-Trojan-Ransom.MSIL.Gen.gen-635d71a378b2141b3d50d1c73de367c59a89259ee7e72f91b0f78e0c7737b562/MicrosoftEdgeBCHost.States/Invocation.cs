using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class Invocation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static Invocation()
	{
		WriterPropertyProducer.ResolveStub();
		FindValue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FindValue()
	{
	}
}
