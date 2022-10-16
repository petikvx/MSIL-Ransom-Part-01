using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class Base
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static Base()
	{
		WriterPropertyProducer.ResolveStub();
		SetValue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetValue()
	{
	}
}
