using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ReaderVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReaderVal()
	{
		WriterPropertyProducer.ResolveStub();
		PublishUtils();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PublishUtils()
	{
	}
}
