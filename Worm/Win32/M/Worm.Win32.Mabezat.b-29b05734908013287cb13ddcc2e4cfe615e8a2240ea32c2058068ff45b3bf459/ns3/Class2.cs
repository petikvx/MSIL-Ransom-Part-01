using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace ns3;

[Serializable]
internal class Class2
{
	private IntPtr intptr_0;

	private IntPtr intptr_1;

	private int int_0;

	private Assembly assembly_0;

	private unsafe Assembly method_0()
	{
		byte* ptr = (byte*)_003CModule_003E.smethod_155((byte*)intptr_0.ToPointer());
		if (ptr == null)
		{
			return null;
		}
		IntPtr ptr2 = (IntPtr)ptr;
		int num = Marshal.ReadInt32(ptr2);
		IntPtr source = (IntPtr)(ptr + 4);
		byte[] array = new byte[num];
		Marshal.Copy(source, array, 0, num);
		Assembly result = Assembly.Load(array);
		Marshal.FreeCoTaskMem(ptr2);
		return result;
	}

	private unsafe Assembly method_1()
	{
		byte* ptr = (byte*)_003CModule_003E.smethod_154((byte*)intptr_0.ToPointer());
		if (ptr == null)
		{
			return null;
		}
		IntPtr ptr2 = (IntPtr)ptr;
		string assemblyString = Marshal.PtrToStringAnsi(ptr2);
		Marshal.FreeCoTaskMem(ptr2);
		Assembly result = null;
		try
		{
			result = Assembly.Load(assemblyString);
			return result;
		}
		catch (Exception)
		{
			return result;
		}
	}

	public unsafe static int smethod_0(Assembly assembly_1, int int_1)
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected O, but got Unknown
		int num = (int)stackalloc byte[_003CModule_003E.smethod_158()];
		IntPtr hINSTANCE = Marshal.GetHINSTANCE(assembly_1.GetLoadedModules()[0]);
		int result = 0;
		Class2 @class = new Class2();
		@class.assembly_0 = assembly_1;
		@class.intptr_0 = hINSTANCE;
		@class.int_0 = int_1;
		IntPtr intPtr = (@class.intptr_1 = (IntPtr)(&result));
		AppDomain appDomain = AppDomain.CreateDomain(Guid.NewGuid().ToString());
		int id = appDomain.Id;
		appDomain.AssemblyResolve += smethod_1;
		CrossAppDomainDelegate val = new CrossAppDomainDelegate(@class.method_2);
		appDomain.DoCallBack(val);
		try
		{
			AppDomain.Unload(appDomain);
		}
		catch when (((Func<bool>)delegate
		{
			// Could not convert BlockContainer to single expression
			Marshal.GetExceptionCode();
			return (byte)_003CModule_003E.smethod_161((void*)Marshal.GetExceptionPointers(), null, 0, null) != 0;
		}).Invoke())
		{
			uint num2 = 0u;
			_003CModule_003E.smethod_160((void*)Marshal.GetExceptionPointers(), (void*)num);
			try
			{
				try
				{
					goto end_IL_00b8;
				}
				catch when (((Func<bool>)delegate
				{
					// Could not convert BlockContainer to single expression
					num2 = (uint)_003CModule_003E.smethod_159((void*)Marshal.GetExceptionPointers());
					return (byte)num2 != 0;
				}).Invoke())
				{
				}
				if (num2 != 0)
				{
					throw;
				}
				end_IL_00b8:;
			}
			finally
			{
				_003CModule_003E.smethod_157((void*)num, (int)num2);
			}
		}
		_003CModule_003E.smethod_153();
		_003CModule_003E.smethod_156(id);
		return result;
	}

	public unsafe void method_2()
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		FieldInfo fieldInfo = null;
		AppDomain appDomain = null;
		AppDomainManager val = null;
		int num = (int)stackalloc byte[_003CModule_003E.smethod_158()];
		Assembly entryAssembly = Assembly.GetEntryAssembly();
		if ((object)entryAssembly == null)
		{
			Class0.assembly_0 = assembly_0;
			try
			{
				fieldInfo = null;
				appDomain = AppDomain.CurrentDomain;
				val = appDomain.get_DomainManager();
				if (val == null)
				{
					val = new AppDomainManager();
					typeof(AppDomain).GetField("_domainManager", BindingFlags.Instance | BindingFlags.NonPublic)?.SetValue(appDomain, val);
				}
				typeof(AppDomainManager).GetField("m_entryAssembly", BindingFlags.Instance | BindingFlags.NonPublic)?.SetValue(val, entryAssembly);
			}
			catch when (((Func<bool>)delegate
			{
				// Could not convert BlockContainer to single expression
				Marshal.GetExceptionCode();
				return (byte)_003CModule_003E.smethod_161((void*)Marshal.GetExceptionPointers(), null, 0, null) != 0;
			}).Invoke())
			{
				uint num2 = 0u;
				_003CModule_003E.smethod_160((void*)Marshal.GetExceptionPointers(), (void*)num);
				try
				{
					try
					{
						goto end_IL_00b1;
					}
					catch when (((Func<bool>)delegate
					{
						// Could not convert BlockContainer to single expression
						num2 = (uint)_003CModule_003E.smethod_159((void*)Marshal.GetExceptionPointers());
						return (byte)num2 != 0;
					}).Invoke())
					{
					}
					if (num2 != 0)
					{
						throw;
					}
					end_IL_00b1:;
				}
				finally
				{
					_003CModule_003E.smethod_157((void*)num, (int)num2);
				}
			}
		}
		else
		{
			Class0.assembly_0 = entryAssembly;
		}
		Assembly assembly = null;
		switch (int_0 & 0x30000000)
		{
		case 805306368:
			assembly = method_0();
			break;
		case 536870912:
			assembly = method_1();
			break;
		}
		if ((object)assembly == null)
		{
			return;
		}
		MethodInfo entryPoint = assembly.EntryPoint;
		if ((object)entryPoint == null)
		{
			return;
		}
		object[] parameters = new object[0];
		if (entryPoint.GetParameters().Length != 0)
		{
			string[] commandLineArgs = Environment.GetCommandLineArgs();
			string[] array = new string[(nint)commandLineArgs.LongLength - 1];
			int num3 = array.Length;
			if (num3 != 0)
			{
				Array.Copy(commandLineArgs, 1, array, 0, num3);
			}
			parameters = new object[1] { array };
		}
		object obj3 = entryPoint.Invoke(null, parameters);
		if (obj3 == null)
		{
			return;
		}
		try
		{
			Marshal.WriteInt32(intptr_1, Convert.ToInt32(obj3));
		}
		catch when (((Func<bool>)delegate
		{
			// Could not convert BlockContainer to single expression
			Marshal.GetExceptionCode();
			return (byte)_003CModule_003E.smethod_161((void*)Marshal.GetExceptionPointers(), null, 0, null) != 0;
		}).Invoke())
		{
			uint num2 = 0u;
			_003CModule_003E.smethod_160((void*)Marshal.GetExceptionPointers(), (void*)num);
			try
			{
				try
				{
					return;
				}
				catch when (((Func<bool>)delegate
				{
					// Could not convert BlockContainer to single expression
					num2 = (uint)_003CModule_003E.smethod_159((void*)Marshal.GetExceptionPointers());
					return (byte)num2 != 0;
				}).Invoke())
				{
				}
				if (num2 != 0)
				{
					throw;
				}
			}
			finally
			{
				_003CModule_003E.smethod_157((void*)num, (int)num2);
			}
		}
	}

	public static Assembly smethod_1(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		return _003CModule_003E.smethod_72(resolveEventArgs_0.Name);
	}
}
