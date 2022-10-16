using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class SerializerValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SerializerValDic()
	{
		WriterPropertyProducer.ResolveStub();
		ComputeLiteralComposer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ComputeLiteralComposer()
	{
	}
}
