using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class IndexerObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IndexerObject()
	{
		WriterPropertyProducer.ResolveStub();
		SetupLiteralPage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetupLiteralPage()
	{
	}
}
