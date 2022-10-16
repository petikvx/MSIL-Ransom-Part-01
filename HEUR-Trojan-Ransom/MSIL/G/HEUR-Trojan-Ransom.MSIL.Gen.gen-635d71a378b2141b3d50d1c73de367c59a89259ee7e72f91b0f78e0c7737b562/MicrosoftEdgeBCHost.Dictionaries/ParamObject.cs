using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ParamObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamObject()
	{
		WriterPropertyProducer.ResolveStub();
		InitLiteralSchema();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InitLiteralSchema()
	{
	}
}
