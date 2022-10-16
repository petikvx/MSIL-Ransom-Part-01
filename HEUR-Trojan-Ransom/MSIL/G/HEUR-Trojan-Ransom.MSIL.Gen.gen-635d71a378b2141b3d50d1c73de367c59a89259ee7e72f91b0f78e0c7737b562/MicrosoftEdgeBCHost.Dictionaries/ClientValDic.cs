using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ClientValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClientValDic()
	{
		WriterPropertyProducer.ResolveStub();
		RevertLiteralReponse();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RevertLiteralReponse()
	{
	}
}
