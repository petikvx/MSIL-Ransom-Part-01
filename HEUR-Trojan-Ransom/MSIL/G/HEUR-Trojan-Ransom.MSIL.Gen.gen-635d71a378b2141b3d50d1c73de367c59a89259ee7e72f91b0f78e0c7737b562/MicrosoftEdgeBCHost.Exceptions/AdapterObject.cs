using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class AdapterObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdapterObject()
	{
		WriterPropertyProducer.ResolveStub();
		InitLiteralModel();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InitLiteralModel()
	{
	}
}
