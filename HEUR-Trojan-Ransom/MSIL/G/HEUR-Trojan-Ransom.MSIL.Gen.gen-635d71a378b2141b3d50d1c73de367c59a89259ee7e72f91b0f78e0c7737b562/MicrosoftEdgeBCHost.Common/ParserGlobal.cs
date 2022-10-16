using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ParserGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParserGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		RevertInterfaceCandidate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RevertInterfaceCandidate()
	{
	}
}
