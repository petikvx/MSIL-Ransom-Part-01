using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ParamsObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamsObject()
	{
		WriterPropertyProducer.ResolveStub();
		RestartLiteralParameter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RestartLiteralParameter()
	{
	}
}
