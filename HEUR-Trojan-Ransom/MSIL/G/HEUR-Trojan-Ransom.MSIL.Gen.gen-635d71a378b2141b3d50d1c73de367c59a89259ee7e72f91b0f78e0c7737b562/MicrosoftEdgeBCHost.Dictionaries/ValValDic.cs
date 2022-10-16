using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ValValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValValDic()
	{
		WriterPropertyProducer.ResolveStub();
		LogoutLiteralListener();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutLiteralListener()
	{
	}
}
