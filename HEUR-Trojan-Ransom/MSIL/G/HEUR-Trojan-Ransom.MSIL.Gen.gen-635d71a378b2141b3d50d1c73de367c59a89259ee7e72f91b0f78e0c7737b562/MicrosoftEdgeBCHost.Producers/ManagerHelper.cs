using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ManagerHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ManagerHelper()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateLiteralReponse();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateLiteralReponse()
	{
	}
}
