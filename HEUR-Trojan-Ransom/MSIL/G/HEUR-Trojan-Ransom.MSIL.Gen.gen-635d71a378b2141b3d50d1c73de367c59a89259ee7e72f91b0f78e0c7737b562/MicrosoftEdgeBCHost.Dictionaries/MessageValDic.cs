using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class MessageValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MessageValDic()
	{
		WriterPropertyProducer.ResolveStub();
		AddLiteralMock();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AddLiteralMock()
	{
	}
}
