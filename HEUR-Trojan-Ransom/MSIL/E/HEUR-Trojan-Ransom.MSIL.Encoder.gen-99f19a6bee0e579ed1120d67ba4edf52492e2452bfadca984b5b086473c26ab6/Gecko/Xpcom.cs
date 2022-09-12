#define DEBUG
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Gecko.Interop;
using Gecko.Services;
using Gecko.WebIDL;
using Gecko.Windows;

namespace Gecko;

public static class Xpcom
{
	[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
	internal delegate IntPtr GetJSObjectFromHolderDelegate([MarshalAs(UnmanagedType.Interface)] nsIXPConnectJSObjectHolder @this);

	[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
	internal delegate IntPtr GetSafeJSContextDelegate([MarshalAs(UnmanagedType.Interface)] nsIXPConnect @this);

	[ComImport]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("033a1470-8b2a-11d3-af88-00a024ffc08c")]
	private interface QI_nsIInterfaceRequestor
	{
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		int GetInterface(ref Guid uuid, out IntPtr pUnk);
	}

	private class DirectoryServiceProvider : nsIDirectoryServiceProvider
	{
		public nsIFile GetFile(string prop, ref bool persistent)
		{
			switch (prop)
			{
			case "UMimTyp":
				return (nsIFile)NewNativeLocalFile(Path.Combine(ProfileDirectory ?? "", "mimeTypes.rdf"));
			case "UChrm":
				return (nsIFile)NewNativeLocalFile(Path.Combine(ProfileDirectory, "chrome"));
			case "TmpD":
				return (nsIFile)NewNativeLocalFile(Path.GetTempPath());
			default:
				Debug.WriteLine("Gecko.Xpcom.DirectoryServiceProvider.GetFile: not implemented: " + prop);
				return null;
			case "ProfLD":
			case "ProfD":
			case "ProfDS":
			case "ProfLDS":
				return (nsIFile)NewNativeLocalFile(ProfileDirectory ?? "");
			}
		}
	}

	public static class Time
	{
		private static readonly DateTime _utcLinuxStartEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

		public static DateTime EpochStart => _utcLinuxStartEpoch;

		public static DateTime FromSecondsSinceEpoch(uint time)
		{
			DateTime utcLinuxStartEpoch = _utcLinuxStartEpoch;
			return utcLinuxStartEpoch.AddSeconds(time);
		}

		public static uint ToSecondsSinceEpoch(DateTime time)
		{
			return (uint)(time.ToUniversalTime() - _utcLinuxStartEpoch).TotalSeconds;
		}
	}

	private static readonly bool _isMono;

	private static readonly bool _is64Bit;

	private static readonly bool _is32Bit;

	private static bool _IsInitialized;

	private static string _ProfileDirectory;

	private static int _XpcomThreadId;

	private static string _xulrunnerVersion;

	private static COMGC _comGC;

	private static ComPtr<nsIXPConnect> _xpconnectComPtr;

	public static nsIComponentManager ComponentManager;

	public static nsIComponentRegistrar ComponentRegistrar;

	public static nsIServiceManager ServiceManager;

	public static bool IsLinux => Environment.OSVersion.Platform == PlatformID.Unix;

	public static bool IsWindows => Environment.OSVersion.Platform != PlatformID.Unix;

	public static bool IsMono => _isMono;

	public static bool IsDotNet => !_isMono;

	public static bool Is32Bit => _is32Bit;

	public static bool Is64Bit => _is64Bit;

	public static bool IsInitialized => _IsInitialized;

	public static string XulRunnerVersion => _xulrunnerVersion;

	internal static ChromeContext ChromeContext { get; private set; }

	public static bool EnableProfileMonitoring { get; set; }

	public static bool InvokeRequired => Thread.CurrentThread.ManagedThreadId != _XpcomThreadId;

	public static string ProfileDirectory
	{
		get
		{
			if (_ProfileDirectory == null)
			{
				string text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), Path.Combine("Geckofx", "DefaultProfile"));
				if (!System.IO.Directory.Exists(text))
				{
					System.IO.Directory.CreateDirectory(text);
				}
				return text;
			}
			return _ProfileDirectory;
		}
		set
		{
			if (!string.IsNullOrEmpty(value) && !System.IO.Directory.Exists(value))
			{
				throw new DirectoryNotFoundException();
			}
			_ProfileDirectory = value;
		}
	}

	public static ComPtr<nsIXPConnect> XPConnect => _xpconnectComPtr ?? (_xpconnectComPtr = GetService<nsIXPConnect>("@mozilla.org/js/xpc/XPConnect;1").AsComPtr());

	public static event Action BeforeInitalization;

	public static event Action AfterInitalization;

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	private static extern int NS_InitXPCOM2([MarshalAs(UnmanagedType.Interface)] out nsIServiceManager serviceManager, [MarshalAs(UnmanagedType.IUnknown)] object binDirectory, nsIDirectoryServiceProvider appFileLocationProvider);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	private static extern int NS_ShutdownXPCOM([MarshalAs(UnmanagedType.Interface)] nsIServiceManager serviceManager);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	private static extern int NS_NewLocalFile([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAString path, bool followLinks, [MarshalAs(UnmanagedType.IUnknown)] out object result);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	private static extern int NS_GetComponentManager([MarshalAs(UnmanagedType.Interface)] out nsIComponentManager componentManager);

	[DllImport("xul", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	private static extern int NS_GetComponentRegistrar([MarshalAs(UnmanagedType.Interface)] out nsIComponentRegistrar componentRegistrar);

	[DllImport("mozglue", CallingConvention = CallingConvention.Cdecl)]
	public static extern IntPtr moz_xmalloc(IntPtr size);

	[DllImport("mozglue", CallingConvention = CallingConvention.Cdecl)]
	public static extern IntPtr moz_xrealloc(IntPtr ptr, IntPtr size);

	[DllImport("mozglue", CallingConvention = CallingConvention.Cdecl)]
	public static extern void free(IntPtr ptr);

	static Xpcom()
	{
		_isMono = Type.GetType("Mono.Runtime") != null;
		_is64Bit = IntPtr.Size == 8;
		_is32Bit = IntPtr.Size == 4;
		EnableProfileMonitoring = false;
	}

	public static void Initialize()
	{
		Initialize(null);
	}

	public static void Initialize(string binDirectory)
	{
		if (_IsInitialized)
		{
			return;
		}
		Debug.WriteLineIf(Thread.CurrentThread.GetApartmentState() != ApartmentState.STA, "Warning: Main Entry point missing [STAThread] attribute.");
		Debug.Assert(Thread.CurrentThread.GetApartmentState() == ApartmentState.STA, "Main Entry point missing [STAThread] attribute.");
		if (Xpcom.BeforeInitalization != null)
		{
			Xpcom.BeforeInitalization();
		}
		Interlocked.Exchange(ref _XpcomThreadId, Thread.CurrentThread.ManagedThreadId);
		if (IsWindows)
		{
			Kernel32.SetDllDirectory(binDirectory);
		}
		string text = binDirectory ?? Environment.CurrentDirectory;
		string xulDll = Path.Combine(text, IsLinux ? "libxul.so" : "xul.dll");
		try
		{
			ReadXulrunnerVersion(xulDll);
		}
		catch (Exception)
		{
		}
		if (binDirectory != null)
		{
			Environment.SetEnvironmentVariable("PATH", string.Format("{0}{1}{2}", Environment.GetEnvironmentVariable("PATH"), Path.PathSeparator, binDirectory), EnvironmentVariableTarget.Process);
		}
		object result = null;
		if (binDirectory != null)
		{
			using nsAString path = new nsAString(Path.GetFullPath(binDirectory));
			if (NS_NewLocalFile(path, followLinks: true, out result) != 0)
			{
				throw new Exception("Failed on NS_NewLocalFile");
			}
		}
		string currentDirectory = Environment.CurrentDirectory;
		Environment.CurrentDirectory = text;
		nsIServiceManager serviceManager;
		int num = NS_InitXPCOM2(out serviceManager, result, null);
		Environment.CurrentDirectory = currentDirectory;
		if (num != 0)
		{
			throw new Exception("Failed on NS_InitXPCOM2");
		}
		ServiceManager = serviceManager;
		NS_GetComponentManager(out ComponentManager);
		NS_GetComponentRegistrar(out ComponentRegistrar);
		if (IsMono)
		{
			_comGC = new COMGC();
		}
		GetService<nsIDirectoryService>("@mozilla.org/file/directory_service;1")?.RegisterProvider(new DirectoryServiceProvider());
		_IsInitialized = true;
		if (!IsLinux)
		{
			InitChromeContext();
		}
		XULAppInfoFactory.Init();
		OnProfileStartup();
		PromptFactoryFactory.Init();
		if (Xpcom.AfterInitalization != null)
		{
			Xpcom.AfterInitalization();
		}
		if (IsLinux)
		{
			GeckoPreferences.User["layers.offmainthreadcomposition.enabled"] = false;
		}
	}

	public static void InitChromeContext()
	{
		if (ChromeContext == null)
		{
			ChromeContext = new ChromeContext();
		}
	}

	private static void ReadXulrunnerVersion(string xulDll)
	{
		FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(xulDll);
		_xulrunnerVersion = versionInfo.FileVersion;
	}

	private static void OnProfileStartup()
	{
		if (EnableProfileMonitoring)
		{
			nsIObserver obj = null;
			nsIObserverService obj2 = GetService<nsIObserverService>("@mozilla.org/observer-service;1");
			obj2.NotifyObservers(null, "profile-do-change", "startup");
			try
			{
				obj = GetService<nsIObserver>("@mozilla.org/addons/integration;1");
				obj?.Observe(null, "addons-startup", null);
				obj2.NotifyObservers(null, "load-extension-defaults", null);
			}
			finally
			{
				FreeComObject(ref obj);
				obj2.NotifyObservers(null, "profile-after-change", "startup");
				NS_CreateServicesFromCategory("profile-after-change", null, "profile-after-change");
				obj2.NotifyObservers(null, "profile-initial-state", null);
				FreeComObject(ref obj2);
			}
		}
	}

	private static void NS_CreateServicesFromCategory(string category, nsISupports origin, string observerTopic)
	{
		nsICategoryManager obj = null;
		nsISimpleEnumerator obj2 = null;
		nsIUTF8StringEnumerator obj3 = null;
		try
		{
			obj = GetService<nsICategoryManager>("@mozilla.org/categorymanager;1");
			if (obj == null)
			{
				return;
			}
			obj2 = obj.EnumerateCategory(category);
			if (obj2 == null)
			{
				return;
			}
			obj3 = QueryInterface<nsIUTF8StringEnumerator>(obj2);
			if (obj3 == null)
			{
				return;
			}
			while (obj3.HasMore())
			{
				nsISupports obj4 = null;
				nsIObserver obj5 = null;
				try
				{
					string aEntry = nsString.Get(obj3.GetNext);
					string categoryEntry = obj.GetCategoryEntry(category, aEntry);
					obj4 = GetService<nsISupports>(categoryEntry);
					if (obj4 != null && observerTopic != null)
					{
						obj5 = QueryInterface<nsIObserver>(obj4);
						obj5?.Observe(origin, observerTopic, "");
					}
				}
				catch (NotImplementedException)
				{
				}
				catch (OutOfMemoryException)
				{
				}
				catch (COMException)
				{
				}
				finally
				{
					FreeComObject(ref obj4);
					FreeComObject(ref obj5);
				}
			}
		}
		finally
		{
			FreeComObject(ref obj);
			FreeComObject(ref obj2);
			FreeComObject(ref obj3);
		}
	}

	public static void Shutdown()
	{
		GeckoPreferences.Shutdown();
		WindowWatcher.Shutdown();
		WindowMediator.Shutdown();
		PromptFactoryFactory.Shutdown();
		DisposeObject(ref _comGC);
		if (ChromeContext != null)
		{
			ChromeContext.Dispose();
			ChromeContext = null;
		}
		if (ComponentRegistrar != null)
		{
			Marshal.ReleaseComObject(ComponentRegistrar);
		}
		if (ComponentManager != null)
		{
			Marshal.ReleaseComObject(ComponentManager);
		}
		if (ServiceManager != null)
		{
			nsIObserverService service = GetService<nsIObserverService>("@mozilla.org/observer-service;1");
			service.NotifyObservers(null, "profile-change-net-teardown", "shutdown-persist");
			service.NotifyObservers(null, "profile-change-teardown", "shutdown-persist");
			service.NotifyObservers(null, "profile-before-change", "shutdown-persist");
			service.NotifyObservers(null, "profile-before-change2", "shutdown-persist");
			Marshal.ReleaseComObject(service);
			Marshal.GetIUnknownForObject(ServiceManager);
			NS_ShutdownXPCOM(ServiceManager);
			Marshal.ReleaseComObject(ServiceManager);
		}
		_IsInitialized = false;
	}

	public static void AssertCorrectThread()
	{
		if (Thread.CurrentThread.ManagedThreadId != _XpcomThreadId)
		{
			throw new InvalidOperationException("GeckoFx can only be called from the same thread on which it was initialized (normally the UI thread).");
		}
	}

	public static object NewNativeLocalFile(string filename)
	{
		using (nsAString path = new nsAString(filename))
		{
			if (NS_NewLocalFile(path, followLinks: true, out var result) == 0)
			{
				return result;
			}
		}
		return null;
	}

	public static TInterfaceType CreateInstance<TInterfaceType>(string contractID)
	{
		Guid aIID = typeof(TInterfaceType).GUID;
		IntPtr intPtr = ComponentManager.CreateInstanceByContractID(contractID, null, ref aIID);
		TInterfaceType result = (TInterfaceType)GetObjectForIUnknown(intPtr);
		Marshal.Release(intPtr);
		return result;
	}

	public static ComPtr<TInterfaceType> CreateInstance2<TInterfaceType>(string contractID) where TInterfaceType : class
	{
		TInterfaceType instance = CreateInstance<TInterfaceType>(contractID);
		return new ComPtr<TInterfaceType>(instance);
	}

	public static TInterfaceType QueryInterface<TInterfaceType>(object obj)
	{
		return (TInterfaceType)QueryInterface(obj, typeof(TInterfaceType).GUID);
	}

	public static object QueryInterface(object obj, Guid iid)
	{
		AssertCorrectThread();
		if (obj == null)
		{
			return null;
		}
		IntPtr iUnknownForObject = Marshal.GetIUnknownForObject(obj);
		if (iUnknownForObject == IntPtr.Zero)
		{
			return null;
		}
		Marshal.QueryInterface(iUnknownForObject, ref iid, out var ppv);
		if (ppv == IntPtr.Zero)
		{
			Guid iid2 = typeof(nsIInterfaceRequestor).GUID;
			Marshal.QueryInterface(iUnknownForObject, ref iid2, out var ppv2);
			if (ppv2 != IntPtr.Zero)
			{
				QI_nsIInterfaceRequestor qI_nsIInterfaceRequestor = (QI_nsIInterfaceRequestor)GetObjectForIUnknown(ppv2);
				if (qI_nsIInterfaceRequestor != null)
				{
					try
					{
						qI_nsIInterfaceRequestor.GetInterface(ref iid, out ppv);
						Marshal.ReleaseComObject(qI_nsIInterfaceRequestor);
					}
					catch (NullReferenceException ex)
					{
						Debug.WriteLine("NullRefException from native code.\n" + ex.ToString());
					}
				}
				Marshal.Release(ppv2);
			}
		}
		object result = ((ppv != IntPtr.Zero) ? GetObjectForIUnknown(ppv) : null);
		Marshal.Release(iUnknownForObject);
		if (ppv != IntPtr.Zero)
		{
			Marshal.Release(ppv);
		}
		return result;
	}

	public static IntPtr GetService(Guid classIID)
	{
		AssertCorrectThread();
		Guid aIID = typeof(nsISupports).GUID;
		return ServiceManager.GetService(ref classIID, ref aIID);
	}

	public static TInterfaceType GetService<TInterfaceType>(string contractID)
	{
		AssertCorrectThread();
		Guid aIID = typeof(TInterfaceType).GUID;
		IntPtr serviceByContractID = ServiceManager.GetServiceByContractID(contractID, ref aIID);
		return (TInterfaceType)GetObjectForIUnknown(serviceByContractID);
	}

	public static ComPtr<T> GetService2<T>(string contractID) where T : class
	{
		if (!IsInitialized)
		{
			throw new GeckoException("Xpcom.Initialize must be called before using of any xulrunner/gecko-fx services");
		}
		T service = GetService<T>(contractID);
		return new ComPtr<T>(service);
	}

	public static void RegisterFactory(Guid classID, string className, string contractID, nsIFactory factory)
	{
		ComponentRegistrar.RegisterFactory(ref classID, className, contractID, factory);
	}

	public static TInterfaceType GetInterface<TInterfaceType>(this nsIInterfaceRequestor requestor)
	{
		return (TInterfaceType)GetInterface(requestor, typeof(TInterfaceType).GUID);
	}

	private static object GetInterface(nsIInterfaceRequestor requestor, Guid iid)
	{
		IntPtr intPtr = IntPtr.Zero;
		try
		{
			intPtr = requestor.GetInterface(ref iid);
		}
		catch (Exception ex)
		{
			Debug.WriteLine("Exception \n" + ex.ToString());
		}
		object result = ((intPtr != IntPtr.Zero) ? GetObjectForIUnknown(intPtr) : null);
		Marshal.Release(intPtr);
		return result;
	}

	internal static IntPtr QueryReferent(object obj, ref Guid uuid)
	{
		AssertCorrectThread();
		IntPtr iUnknownForObject = Marshal.GetIUnknownForObject(obj);
		Marshal.QueryInterface(iUnknownForObject, ref uuid, out var ppv);
		Marshal.Release(iUnknownForObject);
		return ppv;
	}

	public static object GetObjectForIUnknown(IntPtr ptr)
	{
		if (ptr == IntPtr.Zero)
		{
			return null;
		}
		return Marshal.GetObjectForIUnknown(ptr);
	}

	internal static void DisposeObject<T>(ref T obj) where T : class, IDisposable
	{
		Interlocked.Exchange(ref obj, null)?.Dispose();
	}

	public static void FreeComObject<T>(ref T obj) where T : class
	{
		T obj2 = Interlocked.Exchange(ref obj, null);
		if (obj2 == null || !Marshal.IsComObject(obj2))
		{
			return;
		}
		if (IsMono && InvokeRequired)
		{
			if (_comGC != null)
			{
				_comGC.Free(ref obj2);
			}
		}
		else
		{
			Marshal.ReleaseComObject(obj2);
		}
	}

	internal static void FreeComObjectDeterminate<T>(ref T obj) where T : class
	{
		T val = Interlocked.Exchange(ref obj, null);
		if (val != null)
		{
			Marshal.ReleaseComObject(val);
		}
	}

	internal static void FinalFreeComObject<T>(ref T obj) where T : class
	{
		T obj2 = Interlocked.Exchange(ref obj, null);
		if (obj2 == null || !Marshal.IsComObject(obj2))
		{
			return;
		}
		if (IsMono && InvokeRequired)
		{
			if (_comGC != null)
			{
				_comGC.FinalFree(ref obj2);
			}
		}
		else
		{
			Marshal.FinalReleaseComObject(obj2);
		}
	}

	public static IntPtr WebBrowserGetInterface<T>(T geckoWebBrowser, nsIWebBrowser instance, ref Guid uuid) where T : IGeckoWebBrowser
	{
		object o = geckoWebBrowser;
		if (instance != null)
		{
			if (uuid == typeof(nsIDOMWindow).GUID)
			{
				o = instance.GetContentDOMWindowAttribute();
			}
			else if (uuid == typeof(nsIDOMDocument).GUID)
			{
				o = new Window(instance.GetContentDOMWindowAttribute(), (nsISupports)instance.GetContentDOMWindowAttribute()).Document;
			}
		}
		IntPtr iUnknownForObject = Marshal.GetIUnknownForObject(o);
		Marshal.QueryInterface(iUnknownForObject, ref uuid, out var ppv);
		Marshal.Release(iUnknownForObject);
		return ppv;
	}

	public static Uri ToUri(this nsIURI value)
	{
		if (value == null)
		{
			return null;
		}
		string uriString = nsString.Get(value.GetSpecAttribute);
		Uri result;
		return Uri.TryCreate(uriString, UriKind.Absolute, out result) ? result : null;
	}

	public static int StrictHashcode<T>(T obj)
	{
		IntPtr iUnknownForObject = Marshal.GetIUnknownForObject(obj);
		int result = iUnknownForObject.ToInt32();
		Marshal.Release(iUnknownForObject);
		return result;
	}

	public static bool StrictEquals<T>(T obj1, T obj2)
	{
		IntPtr iUnknownForObject = Marshal.GetIUnknownForObject(obj1);
		IntPtr iUnknownForObject2 = Marshal.GetIUnknownForObject(obj2);
		bool result = iUnknownForObject == iUnknownForObject2;
		Marshal.Release(iUnknownForObject2);
		Marshal.Release(iUnknownForObject);
		return result;
	}

	public static Uri TranslateUriAttribute(Func<nsIURI> uriFunc)
	{
		Uri result = null;
		nsIURI nsIURI2 = uriFunc();
		if (nsIURI2 != null)
		{
			result = nsIURI2.ToUri();
			Marshal.ReleaseComObject(nsIURI2);
		}
		return result;
	}
}
