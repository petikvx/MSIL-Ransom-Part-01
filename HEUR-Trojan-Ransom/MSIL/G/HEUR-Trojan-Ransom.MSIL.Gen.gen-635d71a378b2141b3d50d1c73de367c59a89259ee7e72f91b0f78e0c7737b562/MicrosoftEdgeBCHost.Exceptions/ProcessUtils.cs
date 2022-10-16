using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ProcessUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProcessUtils()
	{
		WriterPropertyProducer.ResolveStub();
		CompareInterfaceTests();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareInterfaceTests()
	{
	}
}
