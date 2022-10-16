using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class SystemObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SystemObject()
	{
		WriterPropertyProducer.ResolveStub();
		ReadLiteralTemplate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReadLiteralTemplate()
	{
	}
}
