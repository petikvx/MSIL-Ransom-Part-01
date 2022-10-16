using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class CandidateUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CandidateUtils()
	{
		WriterPropertyProducer.ResolveStub();
		AwakeInterfaceTests();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakeInterfaceTests()
	{
	}
}
