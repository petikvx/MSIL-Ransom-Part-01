using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class TestsAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestsAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeLiteralImporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeLiteralImporter()
	{
	}
}
