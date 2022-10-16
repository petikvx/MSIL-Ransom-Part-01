using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ObserverObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ObserverObject()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatLiteralAuthentication();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatLiteralAuthentication()
	{
	}
}
