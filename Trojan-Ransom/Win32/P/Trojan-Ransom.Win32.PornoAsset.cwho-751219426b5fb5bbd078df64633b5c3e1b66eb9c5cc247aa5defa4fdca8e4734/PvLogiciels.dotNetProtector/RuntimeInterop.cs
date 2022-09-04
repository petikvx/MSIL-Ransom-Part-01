using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using ns1;
using ns3;

namespace PvLogiciels.dotNetProtector;

public class RuntimeInterop : IRuntime
{
	internal Assembly[] assembly_0;

	internal Assembly assembly_1;

	internal string string_0;

	private unsafe static byte* smethod_0(Assembly assembly_2)
	{
		return (byte*)Marshal.GetHINSTANCE(assembly_2.GetLoadedModules()[0]).ToPointer();
	}

	internal RuntimeInterop()
	{
		assembly_0 = new Assembly[0];
	}

	internal unsafe Assembly method_0(IntPtr intptr_0)
	{
		int id = AppDomain.CurrentDomain.Id;
		byte* ptr = (byte*)_003CModule_003E.smethod_152(intptr_0.ToPointer());
		if (ptr == null)
		{
			return null;
		}
		IntPtr intPtr = (IntPtr)ptr;
		intptr_0 = intPtr;
		int num = Marshal.ReadInt32(intPtr);
		int num2 = Marshal.ReadInt32(intptr_0, 4);
		int num3 = Marshal.ReadInt32(intptr_0, 8);
		IntPtr source = (IntPtr)(ptr + 12);
		IntPtr source2 = (IntPtr)(ptr + num2 + 12);
		byte[] array = new byte[num2];
		Marshal.Copy(source, array, 0, num2);
		Assembly assembly;
		if (num3 != 0)
		{
			byte[] rawSymbolStore = new byte[num3];
			Marshal.Copy(source2, array, 0, num3);
			assembly = Assembly.Load(array, rawSymbolStore);
		}
		else
		{
			assembly = Assembly.Load(array);
		}
		Marshal.FreeCoTaskMem(intptr_0);
		if ((object)assembly != null && num >= 0)
		{
			Type[] types = assembly.GetTypes();
			_003CModule_003E.smethod_151(pVoid_1: types[(nint)types.LongLength - 1].TypeHandle.Value.ToPointer(), pByte_0: (byte*)Marshal.GetHINSTANCE(assembly.GetLoadedModules()[0]).ToPointer(), int_9: num, int_10: id);
		}
		return assembly;
	}

	internal unsafe static void smethod_1(Assembly assembly_2)
	{
		string assemblyString = Runtime.GetAssemblyString(assembly_2);
		IntPtr intPtr = IntPtr.Zero;
		if (assemblyString != null)
		{
			intPtr = Marshal.StringToCoTaskMemAnsi(assemblyString);
		}
		_003CModule_003E.smethod_150((byte*)Marshal.GetHINSTANCE(assembly_2.GetLoadedModules()[0]).ToPointer(), null, null, (sbyte*)intPtr.ToPointer(), AppDomain.CurrentDomain.Id);
		if (intPtr != IntPtr.Zero)
		{
			Marshal.FreeCoTaskMem(intPtr);
		}
	}

	public virtual Assembly GetEntryAssembly()
	{
		if ((object)Class0.assembly_0 != null)
		{
			return Class0.assembly_0;
		}
		Assembly entryAssembly = Assembly.GetEntryAssembly();
		if ((object)entryAssembly != null)
		{
			Class0.assembly_0 = entryAssembly;
			return entryAssembly;
		}
		entryAssembly = Assembly.GetExecutingAssembly();
		if (!entryAssembly.FullName!.StartsWith("PvLogiciels.dotNetProtector.Runtime"))
		{
			Class0.assembly_0 = entryAssembly;
			return entryAssembly;
		}
		return null;
	}

	public static IRuntime InitRuntime()
	{
		RuntimeInterop result = new RuntimeInterop();
		if (AppDomain.CurrentDomain.IsDefaultAppDomain())
		{
			AppDomain.CurrentDomain.ProcessExit += AppDomain_ProcessExit;
		}
		else
		{
			Class1 @object = new Class1(AppDomain.CurrentDomain, AppDomain.CurrentDomain.Id);
			AppDomain.CurrentDomain.DomainUnload += @object.method_2;
		}
		return (IRuntime)(object)result;
	}

	public static void AppDomain_ProcessExit(object sender, EventArgs e)
	{
		GC.Collect();
		GC.WaitForPendingFinalizers();
		_003CModule_003E.smethod_149();
	}

	public virtual void NGenInitRuntime()
	{
	}

	public virtual ulong GetComputerHash()
	{
		return _003CModule_003E.smethod_148();
	}

	public virtual long GetMacAddress()
	{
		return _003CModule_003E.smethod_147();
	}

	public virtual ulong GetBiosHash()
	{
		return _003CModule_003E.smethod_146();
	}

	public virtual int UnloadDomain()
	{
		return _003CModule_003E.smethod_156(AppDomain.CurrentDomain.Id);
	}

	public unsafe virtual int InitModule(Type pReserved1, IntPtr pReserved2, string Reserved3)
	{
		IntPtr intPtr = IntPtr.Zero;
		if (Reserved3 != null)
		{
			intPtr = Marshal.StringToCoTaskMemAnsi(Reserved3);
		}
		int num = _003CModule_003E.smethod_150(pVoid_1: pReserved1.TypeHandle.Value.ToPointer(), pByte_0: (byte*)Marshal.GetHINSTANCE(pReserved1.Assembly.GetLoadedModules()[0]).ToPointer(), pInt_0: (int*)pReserved2.ToPointer(), pSbyte_0: (sbyte*)intPtr.ToPointer(), int_9: AppDomain.CurrentDomain.Id);
		if (intPtr != IntPtr.Zero)
		{
			Marshal.FreeCoTaskMem(intPtr);
		}
		if (num == 2)
		{
			assembly_1 = pReserved1.Assembly;
			string_0 = pReserved1.Assembly.GetName().Name;
			int num2 = _003CModule_003E.smethod_145();
			if (num2 != 0)
			{
				assembly_0 = new Assembly[num2];
				int num3 = 0;
				if (0 < num2)
				{
					do
					{
						assembly_0[num3] = null;
						num3++;
					}
					while (num3 < num2);
				}
			}
		}
		return num;
	}

	public unsafe virtual string DesignLicenseKey(Type pReserved1, string pReserved2)
	{
		IntPtr ptr = Marshal.AllocCoTaskMem(IntPtr.Size);
		IntPtr intPtr = Marshal.StringToCoTaskMemAnsi(pReserved2);
		_003CModule_003E.smethod_144((byte*)Marshal.GetHINSTANCE(pReserved1.Assembly.GetLoadedModules()[0]).ToPointer(), (sbyte*)intPtr.ToPointer(), (sbyte**)ptr.ToPointer());
		IntPtr intPtr2 = Marshal.ReadIntPtr(ptr);
		object result = null;
		if (intPtr2 != IntPtr.Zero)
		{
			result = Marshal.PtrToStringAnsi(intPtr2);
			Marshal.FreeHGlobal(intPtr2);
		}
		Marshal.FreeCoTaskMem(ptr);
		if (intPtr != IntPtr.Zero)
		{
			Marshal.FreeCoTaskMem(intPtr);
		}
		return (string)result;
	}

	[return: MarshalAs(UnmanagedType.U1)]
	public unsafe virtual bool SameSoftware(Assembly pReserved, IntPtr pSoft, ulong SwMajor)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out int num);
		if (_003CModule_003E.smethod_143((byte*)Marshal.GetHINSTANCE(pReserved.GetLoadedModules()[0]).ToPointer(), (sbyte*)pSoft.ToPointer(), SwMajor, &num) == 0)
		{
			throw new LicenseException(typeof(Runtime));
		}
		return (byte)((num != 0) ? 1u : 0u) != 0;
	}

	[return: MarshalAs(UnmanagedType.U1)]
	public unsafe virtual bool IsLicensed(Assembly pReserved, string licenseKey, [MarshalAs(UnmanagedType.U1)] bool usb)
	{
		IntPtr intPtr = Marshal.StringToCoTaskMemAnsi(licenseKey);
		int int_ = (usb ? 1 : 0);
		int num = _003CModule_003E.smethod_142((byte*)Marshal.GetHINSTANCE(pReserved.GetLoadedModules()[0]).ToPointer(), (sbyte*)intPtr.ToPointer(), int_);
		if (intPtr != IntPtr.Zero)
		{
			Marshal.FreeCoTaskMem(intPtr);
		}
		return (byte)((num != 0) ? 1u : 0u) != 0;
	}

	public unsafe virtual int HardwareScore(Assembly pReserved, ulong HwConfig1, ulong HwConfig2)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
		if (_003CModule_003E.smethod_141((byte*)Marshal.GetHINSTANCE(pReserved.GetLoadedModules()[0]).ToPointer(), HwConfig1, HwConfig2, &result) == 0)
		{
			throw new LicenseException(typeof(Runtime));
		}
		return result;
	}

	public unsafe virtual IntPtr GenProductKey(Assembly pReserved, IntPtr pKeys, uint LicenseID, ulong data)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out sbyte* ptr);
		if (_003CModule_003E.smethod_139((byte*)Marshal.GetHINSTANCE(pReserved.GetLoadedModules()[0]).ToPointer(), pKeys.ToPointer(), LicenseID, data, &ptr) == 0)
		{
			throw new LicenseException(typeof(Runtime));
		}
		return (IntPtr)ptr;
	}

	public unsafe virtual IntPtr GenProductKey(Assembly pReserved, IntPtr pKeys, uint LicenseID)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out sbyte* ptr);
		if (_003CModule_003E.smethod_140((byte*)Marshal.GetHINSTANCE(pReserved.GetLoadedModules()[0]).ToPointer(), pKeys.ToPointer(), LicenseID, &ptr) == 0)
		{
			throw new LicenseException(typeof(Runtime));
		}
		return (IntPtr)ptr;
	}

	public unsafe virtual uint GetLicenseId(Assembly pReserved, IntPtr pProductKey)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out uint result);
		if (_003CModule_003E.smethod_138((byte*)Marshal.GetHINSTANCE(pReserved.GetLoadedModules()[0]).ToPointer(), (sbyte*)pProductKey.ToPointer(), &result) == 0)
		{
			throw new LicenseException(typeof(Runtime));
		}
		return result;
	}

	public unsafe virtual ulong GetProductkeyData(Assembly pReserved, IntPtr pProductKey)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out uint num);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ulong result);
		if (_003CModule_003E.smethod_137((byte*)Marshal.GetHINSTANCE(pReserved.GetLoadedModules()[0]).ToPointer(), (sbyte*)pProductKey.ToPointer(), &num, &result) == 0)
		{
			throw new LicenseException(typeof(Runtime));
		}
		return result;
	}

	public unsafe virtual IntPtr DecodeActivationString(Assembly pReserved, IntPtr pKeys, IntPtr pActivationString)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte* ptr);
		if (_003CModule_003E.smethod_136((byte*)Marshal.GetHINSTANCE(pReserved.GetLoadedModules()[0]).ToPointer(), pKeys.ToPointer(), (sbyte*)pActivationString.ToPointer(), &ptr) == 0)
		{
			throw new LicenseException(typeof(Runtime));
		}
		return (IntPtr)ptr;
	}

	public unsafe virtual IntPtr EncodeActivationRequest(Assembly pReserved, IntPtr preq)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out sbyte* ptr);
		if (_003CModule_003E.smethod_135((byte*)Marshal.GetHINSTANCE(pReserved.GetLoadedModules()[0]).ToPointer(), preq.ToPointer(), &ptr) == 0)
		{
			throw new LicenseException(typeof(Runtime));
		}
		return (IntPtr)ptr;
	}

	public unsafe virtual IntPtr GetConfig(Assembly pReserved, uint LicenseID, ushort ActivationDuration)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out sbyte* ptr);
		if (_003CModule_003E.smethod_132((byte*)Marshal.GetHINSTANCE(pReserved.GetLoadedModules()[0]).ToPointer(), LicenseID, ActivationDuration, &ptr) == 0)
		{
			throw new LicenseException(typeof(Runtime));
		}
		return (IntPtr)ptr;
	}

	public unsafe virtual IntPtr GetConfig(Assembly pReserved, uint LicenseID, ushort ActivationDuration, IntPtr pAssemblyFile)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out sbyte* ptr);
		if (_003CModule_003E.smethod_133((byte*)Marshal.GetHINSTANCE(pReserved.GetLoadedModules()[0]).ToPointer(), LicenseID, ActivationDuration, (sbyte*)pAssemblyFile.ToPointer(), &ptr) == 0)
		{
			throw new LicenseException(typeof(Runtime));
		}
		return (IntPtr)ptr;
	}

	public unsafe virtual IntPtr GetConfig(Assembly pReserved, uint LicenseID, ushort ActivationDuration, AssemblyName Name)
	{
		_ = Name.Name;
		byte[] bytes = Encoding.UTF8.GetBytes(string.Concat((object?)"\0"));
		GCHandle gCHandle = GCHandle.Alloc(bytes, GCHandleType.Pinned);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out sbyte* ptr);
		int num = _003CModule_003E.smethod_134(pByte_1: (byte*)Marshal.UnsafeAddrOfPinnedArrayElement((Array)bytes, 0).ToPointer(), pByte_0: (byte*)Marshal.GetHINSTANCE(pReserved.GetLoadedModules()[0]).ToPointer(), uint_9: LicenseID, ushort_0: ActivationDuration, ushort_1: (ushort)Name.Version!.Major, ushort_2: (ushort)Name.Version!.Minor, ppSbyte_0: &ptr);
		gCHandle.Free();
		if (num == 0)
		{
			throw new LicenseException(typeof(Runtime));
		}
		return (IntPtr)ptr;
	}

	public unsafe virtual string GetThumbPrint(Assembly pReserved)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct40 @struct);
		if (_003CModule_003E.smethod_131((byte*)Marshal.GetHINSTANCE(pReserved.GetLoadedModules()[0]).ToPointer(), (byte*)(&@struct)) == 0)
		{
			throw new LicenseException(typeof(Runtime));
		}
		StringBuilder stringBuilder = new StringBuilder();
		int num = 0;
		do
		{
			stringBuilder.Append($"{*(byte*)((ref *(_003F*)num) + (ref *(_003F*)(&@struct))):x}".PadLeft(2, '0'));
			num++;
		}
		while (num < 20);
		return stringBuilder.ToString();
	}

	public unsafe virtual byte[] GetConfigForDemo(Assembly pReserved)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out uint num);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte* ptr);
		if (_003CModule_003E.smethod_130((byte*)Marshal.GetHINSTANCE(pReserved.GetLoadedModules()[0]).ToPointer(), &num, &ptr) == 0)
		{
			throw new LicenseException(typeof(Runtime));
		}
		byte[] array = new byte[num];
		IntPtr intPtr = (IntPtr)ptr;
		Marshal.Copy(intPtr, array, 0, (int)num);
		Marshal.FreeCoTaskMem(intPtr);
		return array;
	}

	public unsafe virtual IntPtr GetUsbConfig(Assembly pReserved, uint LicenseID, ushort ActivationDuration, ulong UsbHash, ulong UsbIdentity)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out sbyte* ptr);
		if (_003CModule_003E.smethod_127((byte*)Marshal.GetHINSTANCE(pReserved.GetLoadedModules()[0]).ToPointer(), LicenseID, ActivationDuration, UsbHash, UsbIdentity, &ptr) == 0)
		{
			throw new LicenseException(typeof(Runtime));
		}
		return (IntPtr)ptr;
	}

	public unsafe virtual IntPtr GetUsbConfig(Assembly pReserved, uint LicenseID, ushort ActivationDuration, ulong UsbHash, ulong UsbIdentity, IntPtr pAssemblyFile)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out sbyte* ptr);
		if (_003CModule_003E.smethod_128((byte*)Marshal.GetHINSTANCE(pReserved.GetLoadedModules()[0]).ToPointer(), LicenseID, ActivationDuration, UsbHash, UsbIdentity, (sbyte*)pAssemblyFile.ToPointer(), &ptr) == 0)
		{
			throw new LicenseException(typeof(Runtime));
		}
		return (IntPtr)ptr;
	}

	public unsafe virtual IntPtr GetUsbConfig(Assembly pReserved, uint LicenseID, ushort ActivationDuration, ulong UsbHash, ulong UsbIdentity, AssemblyName Name)
	{
		_ = Name.Name;
		byte[] bytes = Encoding.UTF8.GetBytes(string.Concat((object?)"\0"));
		GCHandle gCHandle = GCHandle.Alloc(bytes, GCHandleType.Pinned);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out sbyte* ptr);
		int num = _003CModule_003E.smethod_129(pByte_1: (byte*)Marshal.UnsafeAddrOfPinnedArrayElement((Array)bytes, 0).ToPointer(), pByte_0: (byte*)Marshal.GetHINSTANCE(pReserved.GetLoadedModules()[0]).ToPointer(), uint_9: LicenseID, ushort_0: ActivationDuration, ulong_0: UsbHash, ulong_1: UsbIdentity, ushort_1: (ushort)Name.Version!.Major, ushort_2: (ushort)Name.Version!.Minor, ppSbyte_0: &ptr);
		gCHandle.Free();
		if (num == 0)
		{
			throw new LicenseException(typeof(Runtime));
		}
		return (IntPtr)ptr;
	}

	public unsafe virtual IntPtr GenerateLicense(Assembly pReserved, IntPtr pKeys, IntPtr preq)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out sbyte* ptr);
		if (_003CModule_003E.smethod_125((byte*)Marshal.GetHINSTANCE(pReserved.GetLoadedModules()[0]).ToPointer(), pKeys.ToPointer(), preq.ToPointer(), &ptr) == 0)
		{
			throw new LicenseException(typeof(Runtime));
		}
		return (IntPtr)ptr;
	}

	public unsafe virtual IntPtr GenerateLicense(Assembly pReserved, IntPtr pKeys, IntPtr preq, int tolerance, [MarshalAs(UnmanagedType.U1)] bool ignoreMinor, long RuntimeLicensesLimit)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out sbyte* ptr);
		if (_003CModule_003E.smethod_126((byte*)Marshal.GetHINSTANCE(pReserved.GetLoadedModules()[0]).ToPointer(), pKeys.ToPointer(), preq.ToPointer(), tolerance, ignoreMinor ? 1 : 0, RuntimeLicensesLimit, &ptr) == 0)
		{
			throw new LicenseException(typeof(Runtime));
		}
		return (IntPtr)ptr;
	}

	public unsafe virtual IntPtr GenerateUsbLicense(Assembly pReserved, IntPtr pKeys, IntPtr preq)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out sbyte* ptr);
		if (_003CModule_003E.smethod_123((byte*)Marshal.GetHINSTANCE(pReserved.GetLoadedModules()[0]).ToPointer(), pKeys.ToPointer(), preq.ToPointer(), &ptr, 0) == 0)
		{
			throw new LicenseException(typeof(Runtime));
		}
		return (IntPtr)ptr;
	}

	public unsafe virtual IntPtr GenerateUsbLicense(Assembly pReserved, IntPtr pKeys, IntPtr preq, int tolerance, [MarshalAs(UnmanagedType.U1)] bool ignoreMinor, long RuntimeLicensesLimit)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out sbyte* ptr);
		if (_003CModule_003E.smethod_124((byte*)Marshal.GetHINSTANCE(pReserved.GetLoadedModules()[0]).ToPointer(), pKeys.ToPointer(), preq.ToPointer(), tolerance, ignoreMinor ? 1 : 0, RuntimeLicensesLimit, &ptr, 0) == 0)
		{
			throw new LicenseException(typeof(Runtime));
		}
		return (IntPtr)ptr;
	}

	public unsafe virtual Assembly ResolveAssembly(string Name)
	{
		int num = (int)stackalloc byte[_003CModule_003E.smethod_158()];
		try
		{
			new AssemblyName(Name);
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
					return null;
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
		byte[] bytes = Encoding.UTF8.GetBytes(Name);
		GCHandle gCHandle = GCHandle.Alloc(bytes, GCHandleType.Pinned);
		IntPtr intptr_ = Marshal.UnsafeAddrOfPinnedArrayElement((Array)bytes, 0);
		int num3 = _003CModule_003E.smethod_122(intptr_.ToPointer());
		if (num3 >= 0)
		{
			Assembly[] array = assembly_0;
			if (num3 < (nint)array.LongLength)
			{
				if ((object)array[num3] == null)
				{
					assembly_0[num3] = method_0(intptr_);
				}
				gCHandle.Free();
				return assembly_0[num3];
			}
		}
		gCHandle.Free();
		if (new AssemblyName(Name).Name == string_0)
		{
			return assembly_1;
		}
		return null;
	}

	public virtual int ExecuteEmbLockAssembly(Type pReserved1, int Reserved2)
	{
		return Class2.smethod_0(pReserved1.Assembly, Reserved2);
	}

	public unsafe virtual Assembly GetEmbLockAssembly(Type pReserved1)
	{
		byte* ptr = (byte*)_003CModule_003E.smethod_155((byte*)Marshal.GetHINSTANCE(pReserved1.Assembly.GetLoadedModules()[0]).ToPointer());
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

	public unsafe virtual Assembly GetEmbLockAssemblyName(Type pReserved1)
	{
		byte* ptr = (byte*)_003CModule_003E.smethod_154((byte*)Marshal.GetHINSTANCE(pReserved1.Assembly.GetLoadedModules()[0]).ToPointer());
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

	public unsafe virtual ArrayList GetEmbLockAssemblyServices(Type pReserved1)
	{
		byte* ptr = (byte*)_003CModule_003E.smethod_121((byte*)Marshal.GetHINSTANCE(pReserved1.Assembly.GetLoadedModules()[0]).ToPointer());
		if (ptr == null)
		{
			return null;
		}
		IntPtr ptr2 = (IntPtr)ptr;
		ArrayList arrayList = new ArrayList();
		if (*ptr != 0)
		{
			do
			{
				string text = Marshal.PtrToStringAnsi((IntPtr)ptr);
				arrayList.Add(text);
				ptr = text.Length + ptr + 1;
			}
			while (*ptr != 0);
		}
		Marshal.FreeCoTaskMem(ptr2);
		return arrayList;
	}

	[return: MarshalAs(UnmanagedType.U1)]
	public unsafe virtual bool ProductKeyChecksumIsOk(Assembly pReserved, IntPtr pString)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out int num);
		if (_003CModule_003E.smethod_120((byte*)Marshal.GetHINSTANCE(pReserved.GetLoadedModules()[0]).ToPointer(), (sbyte*)pString.ToPointer(), &num) == 0)
		{
			throw new LicenseException(typeof(Runtime));
		}
		return (byte)((num != 0) ? 1u : 0u) != 0;
	}

	[return: MarshalAs(UnmanagedType.U1)]
	public unsafe virtual bool ConfigStringChecksumIsOk(Assembly pReserved, IntPtr pString)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out int num);
		if (_003CModule_003E.smethod_119((byte*)Marshal.GetHINSTANCE(pReserved.GetLoadedModules()[0]).ToPointer(), (sbyte*)pString.ToPointer(), &num) == 0)
		{
			throw new LicenseException(typeof(Runtime));
		}
		return (byte)((num != 0) ? 1u : 0u) != 0;
	}

	[return: MarshalAs(UnmanagedType.U1)]
	public unsafe virtual bool LicenseKeyChecksumIsOk(Assembly pReserved, IntPtr pString)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out int num);
		if (_003CModule_003E.smethod_118((byte*)Marshal.GetHINSTANCE(pReserved.GetLoadedModules()[0]).ToPointer(), (sbyte*)pString.ToPointer(), &num) == 0)
		{
			throw new LicenseException(typeof(Runtime));
		}
		return (byte)((num != 0) ? 1u : 0u) != 0;
	}

	[return: MarshalAs(UnmanagedType.U1)]
	public unsafe virtual bool IsDemo(Assembly pReserved)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out int num);
		if (_003CModule_003E.smethod_117((byte*)Marshal.GetHINSTANCE(pReserved.GetLoadedModules()[0]).ToPointer(), &num) == 0)
		{
			throw new LicenseException(typeof(Runtime));
		}
		return (byte)((num != 0) ? 1u : 0u) != 0;
	}

	public unsafe virtual int DaysLeft(Assembly pReserved)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
		if (_003CModule_003E.smethod_116((byte*)Marshal.GetHINSTANCE(pReserved.GetLoadedModules()[0]).ToPointer(), &result) == 0)
		{
			throw new LicenseException(typeof(Runtime));
		}
		return result;
	}

	public unsafe virtual int MinutesLeft(Assembly pReserved)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
		if (_003CModule_003E.smethod_115((byte*)Marshal.GetHINSTANCE(pReserved.GetLoadedModules()[0]).ToPointer(), &result) == 0)
		{
			throw new LicenseException(typeof(Runtime));
		}
		return result;
	}

	public unsafe virtual uint GetProductID(Assembly pReserved)
	{
		return _003CModule_003E.smethod_114((byte*)Marshal.GetHINSTANCE(pReserved.GetLoadedModules()[0]).ToPointer());
	}

	public virtual void UnloadAppdomain(AppDomain domain)
	{
		int id = domain.Id;
		AppDomain.Unload(domain);
		_003CModule_003E.smethod_156(id);
	}

	public unsafe virtual IntPtr StartUsbDetect()
	{
		return (IntPtr)_003CModule_003E.smethod_113();
	}

	public unsafe virtual void EndUsbDetect(IntPtr handle)
	{
		_003CModule_003E.smethod_112(handle.ToPointer());
	}

	public unsafe virtual IntPtr LoadNativeLibrary(Assembly pReserved, IntPtr[] pointers)
	{
		GCHandle gCHandle = GCHandle.Alloc(pointers, GCHandleType.Pinned);
		IntPtr result = (IntPtr)_003CModule_003E.smethod_111(ppVoid_0: (void**)Marshal.UnsafeAddrOfPinnedArrayElement((Array)pointers, 0).ToPointer(), pByte_0: (byte*)Marshal.GetHINSTANCE(pReserved.GetLoadedModules()[0]).ToPointer());
		gCHandle.Free();
		return result;
	}

	public unsafe virtual void FreeNativeLibrary(IntPtr pLib)
	{
		_003CModule_003E.smethod_110(pLib.ToPointer());
	}

	public virtual StackFrame[] GetFrames(StackTrace trace)
	{
		if (trace == null)
		{
			return new StackFrame[0];
		}
		return trace.GetFrames();
	}

	public unsafe virtual void EncodeTrace(Guid[] Guids, long[] Indexes, IntPtr[] Handles)
	{
		GCHandle gCHandle = GCHandle.Alloc(Guids, GCHandleType.Pinned);
		GCHandle gCHandle2 = GCHandle.Alloc(Indexes, GCHandleType.Pinned);
		GCHandle gCHandle3 = GCHandle.Alloc(Handles, GCHandleType.Pinned);
		IntPtr intPtr = Marshal.UnsafeAddrOfPinnedArrayElement((Array)Guids, 0);
		IntPtr intPtr2 = Marshal.UnsafeAddrOfPinnedArrayElement((Array)Indexes, 0);
		_003CModule_003E.smethod_109(pVoid_1: Marshal.UnsafeAddrOfPinnedArrayElement((Array)Handles, 0).ToPointer(), int_9: Handles.Length, pVoid_2: intPtr2.ToPointer(), pVoid_3: intPtr.ToPointer());
		gCHandle.Free();
		gCHandle2.Free();
		gCHandle3.Free();
	}
}
