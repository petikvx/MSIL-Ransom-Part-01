using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class IssuerValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IssuerValDic()
	{
		WriterPropertyProducer.ResolveStub();
		PushLiteralCreator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushLiteralCreator()
	{
	}
}
