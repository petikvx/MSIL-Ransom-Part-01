using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class IssuerHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IssuerHelper()
	{
		WriterPropertyProducer.ResolveStub();
		PostLiteralFilter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PostLiteralFilter()
	{
	}
}
