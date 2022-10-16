using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class PageReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PageReponse()
	{
		WriterPropertyProducer.ResolveStub();
		NewLiteralInstance();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NewLiteralInstance()
	{
	}
}
