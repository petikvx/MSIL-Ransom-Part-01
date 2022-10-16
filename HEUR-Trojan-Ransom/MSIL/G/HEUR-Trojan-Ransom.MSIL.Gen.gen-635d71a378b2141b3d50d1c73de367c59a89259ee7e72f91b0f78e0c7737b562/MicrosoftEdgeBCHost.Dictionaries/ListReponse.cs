using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ListReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ListReponse()
	{
		WriterPropertyProducer.ResolveStub();
		LogoutLiteralObject();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutLiteralObject()
	{
	}
}
