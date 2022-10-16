using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class RegistryReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegistryReponse()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateLiteralWorker();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateLiteralWorker()
	{
	}
}
