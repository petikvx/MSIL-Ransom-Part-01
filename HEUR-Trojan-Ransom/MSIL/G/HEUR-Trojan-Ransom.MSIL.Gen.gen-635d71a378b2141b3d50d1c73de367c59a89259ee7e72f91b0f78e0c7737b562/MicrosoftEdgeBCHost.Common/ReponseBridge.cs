using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ReponseBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReponseBridge()
	{
		WriterPropertyProducer.ResolveStub();
		VerifyExporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VerifyExporter()
	{
	}
}
