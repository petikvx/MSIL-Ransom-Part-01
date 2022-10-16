using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ParserFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParserFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		LoginLiteralParser();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LoginLiteralParser()
	{
	}
}
