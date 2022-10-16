using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ConfigReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigReponse()
	{
		WriterPropertyProducer.ResolveStub();
		FillLiteralWorker();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillLiteralWorker()
	{
	}
}
