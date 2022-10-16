using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ClientDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClientDic()
	{
		WriterPropertyProducer.ResolveStub();
		StartLiteralAccount();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StartLiteralAccount()
	{
	}
}
