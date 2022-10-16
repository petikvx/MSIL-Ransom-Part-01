using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class PrototypeObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrototypeObject()
	{
		WriterPropertyProducer.ResolveStub();
		RestartLiteralPage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RestartLiteralPage()
	{
	}
}
