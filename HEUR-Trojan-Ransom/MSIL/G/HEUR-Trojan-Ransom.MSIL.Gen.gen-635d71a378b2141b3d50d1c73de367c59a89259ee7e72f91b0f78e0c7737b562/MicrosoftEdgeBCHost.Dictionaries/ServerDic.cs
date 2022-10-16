using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ServerDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServerDic()
	{
		WriterPropertyProducer.ResolveStub();
		InsertLiteralSpecification();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertLiteralSpecification()
	{
	}
}
