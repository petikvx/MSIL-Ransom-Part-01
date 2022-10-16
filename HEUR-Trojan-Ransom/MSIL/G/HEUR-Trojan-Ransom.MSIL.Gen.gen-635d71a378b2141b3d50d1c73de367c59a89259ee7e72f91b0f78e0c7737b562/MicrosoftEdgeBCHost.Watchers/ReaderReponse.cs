using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ReaderReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReaderReponse()
	{
		WriterPropertyProducer.ResolveStub();
		CheckInterfaceProc();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CheckInterfaceProc()
	{
	}
}
