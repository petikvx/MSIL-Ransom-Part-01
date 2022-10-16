using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ServerValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServerValDic()
	{
		WriterPropertyProducer.ResolveStub();
		EnableLiteralAuthentication();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EnableLiteralAuthentication()
	{
	}
}
