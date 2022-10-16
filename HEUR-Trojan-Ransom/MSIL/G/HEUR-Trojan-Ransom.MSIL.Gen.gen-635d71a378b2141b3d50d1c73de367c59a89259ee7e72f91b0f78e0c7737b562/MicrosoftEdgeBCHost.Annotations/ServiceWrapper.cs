using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ServiceWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServiceWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		ResetTest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResetTest()
	{
	}
}
