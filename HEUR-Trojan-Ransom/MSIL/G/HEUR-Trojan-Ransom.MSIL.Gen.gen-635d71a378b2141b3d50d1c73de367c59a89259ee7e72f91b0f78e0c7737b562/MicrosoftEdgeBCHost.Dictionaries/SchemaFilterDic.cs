using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class SchemaFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SchemaFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		PostLiteralSetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PostLiteralSetter()
	{
	}
}
