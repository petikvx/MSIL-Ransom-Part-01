using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class FieldWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FieldWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		InitDic();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InitDic()
	{
	}
}
