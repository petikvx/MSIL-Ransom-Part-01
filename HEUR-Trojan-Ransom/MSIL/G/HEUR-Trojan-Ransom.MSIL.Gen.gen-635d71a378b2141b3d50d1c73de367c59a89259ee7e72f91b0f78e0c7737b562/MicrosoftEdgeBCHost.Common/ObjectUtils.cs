using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ObjectUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ObjectUtils()
	{
		WriterPropertyProducer.ResolveStub();
		CountInterfaceParser();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CountInterfaceParser()
	{
	}
}
