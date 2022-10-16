using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ClassDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClassDic()
	{
		WriterPropertyProducer.ResolveStub();
		AwakeLiteralRequest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakeLiteralRequest()
	{
	}
}
