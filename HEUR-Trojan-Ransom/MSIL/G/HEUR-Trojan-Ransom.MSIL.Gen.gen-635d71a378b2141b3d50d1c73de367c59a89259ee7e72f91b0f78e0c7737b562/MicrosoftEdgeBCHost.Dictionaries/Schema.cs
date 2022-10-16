using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class Schema
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static Schema()
	{
		WriterPropertyProducer.ResolveStub();
		ReadGetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReadGetter()
	{
	}
}
