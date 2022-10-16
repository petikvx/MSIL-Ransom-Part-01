using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ComparatorHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComparatorHelper()
	{
		WriterPropertyProducer.ResolveStub();
		ReadLiteralHelper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReadLiteralHelper()
	{
	}
}
