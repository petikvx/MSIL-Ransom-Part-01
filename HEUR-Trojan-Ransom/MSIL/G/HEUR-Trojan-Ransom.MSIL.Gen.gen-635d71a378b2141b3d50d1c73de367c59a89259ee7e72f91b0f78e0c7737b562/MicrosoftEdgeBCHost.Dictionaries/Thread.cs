using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class Thread
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static Thread()
	{
		WriterPropertyProducer.ResolveStub();
		VerifyValue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VerifyValue()
	{
	}
}
