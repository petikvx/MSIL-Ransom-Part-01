using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class RefSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RefSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		InsertLiteralDic();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertLiteralDic()
	{
	}
}
