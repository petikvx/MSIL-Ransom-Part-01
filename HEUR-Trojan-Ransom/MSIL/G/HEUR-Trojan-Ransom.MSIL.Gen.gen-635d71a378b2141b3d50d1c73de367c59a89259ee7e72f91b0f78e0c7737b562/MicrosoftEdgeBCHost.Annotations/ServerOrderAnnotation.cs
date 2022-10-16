using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ServerOrderAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServerOrderAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		SortLiteralTokenizer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortLiteralTokenizer()
	{
	}
}
