using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class MethodHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MethodHelper()
	{
		WriterPropertyProducer.ResolveStub();
		RegisterLiteralReponse();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RegisterLiteralReponse()
	{
	}
}
