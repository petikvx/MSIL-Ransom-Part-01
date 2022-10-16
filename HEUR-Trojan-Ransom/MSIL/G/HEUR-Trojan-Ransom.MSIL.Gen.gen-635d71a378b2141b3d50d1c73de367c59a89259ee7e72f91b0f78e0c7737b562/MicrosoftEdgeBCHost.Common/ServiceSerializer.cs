using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ServiceSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServiceSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		TestLiteralImporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TestLiteralImporter()
	{
	}
}
