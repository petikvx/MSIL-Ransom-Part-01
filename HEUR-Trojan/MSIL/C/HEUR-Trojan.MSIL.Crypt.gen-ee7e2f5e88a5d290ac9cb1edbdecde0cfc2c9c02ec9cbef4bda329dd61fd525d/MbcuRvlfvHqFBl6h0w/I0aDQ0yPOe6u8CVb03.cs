using System;
using System.Reflection;

namespace MbcuRvlfvHqFBl6h0w;

internal class I0aDQ0yPOe6u8CVb03
{
	internal static ModuleHandle r7H7NaOKuH = YmxPpUpbi662cUX90Tg(((object[])KRJseJ5zu7Sff9WQNy2(typeof(I0aDQ0yPOe6u8CVb03).Assembly))[0]);

	internal static object wBPlPt5xKUGjnphmxIw;

	internal static RuntimeTypeHandle DcNea4qG506wf(int token)
	{
		return r7H7NaOKuH.GetRuntimeTypeHandleFromMetadataToken(token);
	}

	internal static RuntimeFieldHandle dIyea4qAaatbc(int token)
	{
		return r7H7NaOKuH.GetRuntimeFieldHandleFromMetadataToken(token);
	}

	internal static bool DNZCCW5eHeXCKnRKB2F()
	{
		return wBPlPt5xKUGjnphmxIw == null;
	}

	internal static I0aDQ0yPOe6u8CVb03 uA0XDD5aKlT0QUicKmm()
	{
		return (I0aDQ0yPOe6u8CVb03)wBPlPt5xKUGjnphmxIw;
	}

	internal static object KRJseJ5zu7Sff9WQNy2(object object_0)
	{
		return ((Assembly)object_0).GetModules();
	}

	internal static ModuleHandle YmxPpUpbi662cUX90Tg(object object_0)
	{
		return ((Module)object_0).ModuleHandle;
	}
}
