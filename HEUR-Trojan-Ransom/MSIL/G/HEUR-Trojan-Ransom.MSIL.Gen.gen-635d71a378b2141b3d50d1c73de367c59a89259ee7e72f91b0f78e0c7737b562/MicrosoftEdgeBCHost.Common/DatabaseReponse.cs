using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class DatabaseReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DatabaseReponse()
	{
		WriterPropertyProducer.ResolveStub();
		CollectLiteralValue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CollectLiteralValue()
	{
	}
}
