using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class SystemExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SystemExpression()
	{
		WriterPropertyProducer.ResolveStub();
		ReflectLiteralAdapter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReflectLiteralAdapter()
	{
	}
}
