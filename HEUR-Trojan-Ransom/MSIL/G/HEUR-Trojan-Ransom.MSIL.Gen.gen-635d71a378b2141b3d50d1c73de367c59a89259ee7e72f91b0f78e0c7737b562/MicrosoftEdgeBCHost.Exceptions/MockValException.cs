using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class MockValException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MockValException()
	{
		WriterPropertyProducer.ResolveStub();
		RunImporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RunImporter()
	{
	}
}
