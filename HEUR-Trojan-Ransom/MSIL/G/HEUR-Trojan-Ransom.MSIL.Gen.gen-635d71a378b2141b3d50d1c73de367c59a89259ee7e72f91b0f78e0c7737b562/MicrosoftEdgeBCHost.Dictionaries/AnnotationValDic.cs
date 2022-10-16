using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class AnnotationValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AnnotationValDic()
	{
		WriterPropertyProducer.ResolveStub();
		LogoutLiteralPublisher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutLiteralPublisher()
	{
	}
}
