using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class AuthenticationValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AuthenticationValDic()
	{
		WriterPropertyProducer.ResolveStub();
		CountLiteralConfig();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CountLiteralConfig()
	{
	}
}
