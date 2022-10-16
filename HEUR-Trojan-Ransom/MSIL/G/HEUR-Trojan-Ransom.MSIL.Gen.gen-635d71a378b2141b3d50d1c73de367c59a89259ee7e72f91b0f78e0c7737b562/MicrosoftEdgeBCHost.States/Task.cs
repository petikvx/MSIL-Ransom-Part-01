using System;
using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class Task : System.Attribute, _003CModule_003E, Task
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static Task()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeInstance();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeInstance()
	{
	}
}
