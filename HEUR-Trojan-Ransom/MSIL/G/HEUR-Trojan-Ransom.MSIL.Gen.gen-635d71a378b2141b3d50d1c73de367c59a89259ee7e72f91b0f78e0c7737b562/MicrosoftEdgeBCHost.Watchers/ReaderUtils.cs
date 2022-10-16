using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ReaderUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReaderUtils()
	{
		WriterPropertyProducer.ResolveStub();
		CheckInterfaceAdapter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CheckInterfaceAdapter()
	{
	}
}
