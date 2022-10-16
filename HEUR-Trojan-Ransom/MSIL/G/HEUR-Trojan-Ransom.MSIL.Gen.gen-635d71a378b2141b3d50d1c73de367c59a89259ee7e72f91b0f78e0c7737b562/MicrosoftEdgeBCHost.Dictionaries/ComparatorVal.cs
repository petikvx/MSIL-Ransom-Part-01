using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ComparatorVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComparatorVal()
	{
		WriterPropertyProducer.ResolveStub();
		FillUtils();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillUtils()
	{
	}
}
