#define TRACE
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Xml;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace System.Data.SQLite;

[SuppressUnmanagedCodeSecurity]
internal static class UnsafeNativeMethods
{
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate SQLiteErrorCode xCreate(IntPtr pDb, IntPtr pAux, int argc, IntPtr argv, ref IntPtr pVtab, ref IntPtr pError);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate SQLiteErrorCode xConnect(IntPtr pDb, IntPtr pAux, int argc, IntPtr argv, ref IntPtr pVtab, ref IntPtr pError);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate SQLiteErrorCode xBestIndex(IntPtr pVtab, IntPtr pIndex);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate SQLiteErrorCode xDisconnect(IntPtr pVtab);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate SQLiteErrorCode xDestroy(IntPtr pVtab);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate SQLiteErrorCode xOpen(IntPtr pVtab, ref IntPtr pCursor);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate SQLiteErrorCode xClose(IntPtr pCursor);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate SQLiteErrorCode xFilter(IntPtr pCursor, int idxNum, IntPtr idxStr, int argc, IntPtr argv);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate SQLiteErrorCode xNext(IntPtr pCursor);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate int xEof(IntPtr pCursor);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate SQLiteErrorCode xColumn(IntPtr pCursor, IntPtr pContext, int index);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate SQLiteErrorCode xRowId(IntPtr pCursor, ref long rowId);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate SQLiteErrorCode xUpdate(IntPtr pVtab, int argc, IntPtr argv, ref long rowId);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate SQLiteErrorCode xBegin(IntPtr pVtab);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate SQLiteErrorCode xSync(IntPtr pVtab);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate SQLiteErrorCode xCommit(IntPtr pVtab);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate SQLiteErrorCode xRollback(IntPtr pVtab);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate int xFindFunction(IntPtr pVtab, int nArg, IntPtr zName, ref SQLiteCallback callback, ref IntPtr pUserData);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate SQLiteErrorCode xRename(IntPtr pVtab, IntPtr zNew);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate SQLiteErrorCode xSavepoint(IntPtr pVtab, int iSavepoint);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate SQLiteErrorCode xRelease(IntPtr pVtab, int iSavepoint);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate SQLiteErrorCode xRollbackTo(IntPtr pVtab, int iSavepoint);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void xDestroyModule(IntPtr pClientData);

	internal struct sqlite3_module
	{
		public int iVersion;

		public xCreate xCreate;

		public xConnect xConnect;

		public xBestIndex xBestIndex;

		public xDisconnect xDisconnect;

		public xDestroy xDestroy;

		public xOpen xOpen;

		public xClose xClose;

		public xFilter xFilter;

		public xNext xNext;

		public xEof xEof;

		public xColumn xColumn;

		public xRowId xRowId;

		public xUpdate xUpdate;

		public xBegin xBegin;

		public xSync xSync;

		public xCommit xCommit;

		public xRollback xRollback;

		public xFindFunction xFindFunction;

		public xRename xRename;

		public xSavepoint xSavepoint;

		public xRelease xRelease;

		public xRollbackTo xRollbackTo;
	}

	internal struct sqlite3_vtab
	{
		public IntPtr pModule;

		public int nRef;

		public IntPtr zErrMsg;
	}

	internal struct sqlite3_vtab_cursor
	{
		public IntPtr pVTab;
	}

	internal struct sqlite3_index_constraint
	{
		public int iColumn;

		public SQLiteIndexConstraintOp op;

		public byte usable;

		public int iTermOffset;

		public sqlite3_index_constraint(SQLiteIndexConstraint constraint)
		{
			this = default(sqlite3_index_constraint);
			if (constraint != null)
			{
				iColumn = constraint.iColumn;
				op = constraint.op;
				usable = constraint.usable;
				iTermOffset = constraint.iTermOffset;
			}
		}
	}

	internal struct sqlite3_index_orderby
	{
		public int iColumn;

		public byte desc;

		public sqlite3_index_orderby(SQLiteIndexOrderBy orderBy)
		{
			this = default(sqlite3_index_orderby);
			if (orderBy != null)
			{
				iColumn = orderBy.iColumn;
				desc = orderBy.desc;
			}
		}
	}

	internal struct sqlite3_index_constraint_usage
	{
		public int argvIndex;

		public byte omit;

		public sqlite3_index_constraint_usage(SQLiteIndexConstraintUsage constraintUsage)
		{
			this = default(sqlite3_index_constraint_usage);
			if (constraintUsage != null)
			{
				argvIndex = constraintUsage.argvIndex;
				omit = constraintUsage.omit;
			}
		}
	}

	internal struct sqlite3_index_info
	{
		public int nConstraint;

		public IntPtr aConstraint;

		public int nOrderBy;

		public IntPtr aOrderBy;

		public IntPtr aConstraintUsage;

		public int idxNum;

		public string idxStr;

		public int needToFreeIdxStr;

		public int orderByConsumed;

		public double estimatedCost;

		public long estimatedRows;

		public SQLiteIndexFlags idxFlags;

		public long colUsed;
	}

	internal const string SQLITE_DLL = "SQLite.Interop.dll";

	private static readonly string DllFileExtension;

	private static readonly string ConfigFileExtension;

	private static readonly string XmlConfigFileName;

	private static readonly string XmlConfigDirectoryToken;

	private static readonly string AssemblyDirectoryToken;

	private static readonly string TargetFrameworkToken;

	private static readonly object staticSyncRoot;

	private static Dictionary<string, string> processorArchitecturePlatforms;

	private static string cachedAssemblyDirectory;

	private static bool noAssemblyDirectory;

	private static string cachedXmlConfigFileName;

	private static bool noXmlConfigFileName;

	private static readonly string PROCESSOR_ARCHITECTURE;

	internal static string _SQLiteNativeModuleFileName;

	private static IntPtr _SQLiteNativeModuleHandle;

	[NonSerialized]
	internal static GetString _0094;

	static UnsafeNativeMethods()
	{
		Strings.CreateGetStringDelegate(typeof(UnsafeNativeMethods));
		DllFileExtension = _0094(107381326);
		ConfigFileExtension = _0094(107381317);
		XmlConfigFileName = typeof(UnsafeNativeMethods).Namespace + DllFileExtension + ConfigFileExtension;
		XmlConfigDirectoryToken = _0094(107381336);
		AssemblyDirectoryToken = _0094(107381255);
		TargetFrameworkToken = _0094(107381242);
		staticSyncRoot = new object();
		PROCESSOR_ARCHITECTURE = _0094(107381677);
		_SQLiteNativeModuleFileName = null;
		_SQLiteNativeModuleHandle = IntPtr.Zero;
		Initialize();
	}

	internal static void Initialize()
	{
		if (GetSettingValue(_0094(107381644), null) != null)
		{
			return;
		}
		lock (staticSyncRoot)
		{
			if (processorArchitecturePlatforms == null)
			{
				processorArchitecturePlatforms = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
				processorArchitecturePlatforms.Add(_0094(107381619), _0094(107381614));
				processorArchitecturePlatforms.Add(_0094(107381605), _0094(107381628));
				processorArchitecturePlatforms.Add(_0094(107381623), _0094(107381582));
				processorArchitecturePlatforms.Add(_0094(107381601), _0094(107381596));
			}
			if (_SQLiteNativeModuleHandle == IntPtr.Zero)
			{
				string baseDirectory = null;
				string processorArchitecture = null;
				SearchForDirectory(ref baseDirectory, ref processorArchitecture);
				PreLoadSQLiteDll(baseDirectory, processorArchitecture, ref _SQLiteNativeModuleFileName, ref _SQLiteNativeModuleHandle);
			}
		}
	}

	private static string MaybeCombinePath(string path1, string path2)
	{
		if (path1 != null)
		{
			if (path2 != null)
			{
				return Path.Combine(path1, path2);
			}
			return path1;
		}
		if (path2 != null)
		{
			return path2;
		}
		return null;
	}

	private static void ResetCachedXmlConfigFileName()
	{
		lock (staticSyncRoot)
		{
			cachedXmlConfigFileName = null;
			noXmlConfigFileName = false;
		}
	}

	private static string GetCachedXmlConfigFileName()
	{
		lock (staticSyncRoot)
		{
			if (cachedXmlConfigFileName != null)
			{
				return cachedXmlConfigFileName;
			}
			if (noXmlConfigFileName)
			{
				return null;
			}
		}
		return GetXmlConfigFileName();
	}

	private static string GetXmlConfigFileName()
	{
		string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
		string text = MaybeCombinePath(baseDirectory, XmlConfigFileName);
		if (File.Exists(text))
		{
			lock (staticSyncRoot)
			{
				cachedXmlConfigFileName = text;
				return text;
			}
		}
		baseDirectory = GetCachedAssemblyDirectory();
		text = MaybeCombinePath(baseDirectory, XmlConfigFileName);
		if (File.Exists(text))
		{
			lock (staticSyncRoot)
			{
				cachedXmlConfigFileName = text;
				return text;
			}
		}
		lock (staticSyncRoot)
		{
			noXmlConfigFileName = true;
		}
		return null;
	}

	private static string ReplaceXmlConfigFileTokens(string fileName, string value)
	{
		if (!string.IsNullOrEmpty(value) && !string.IsNullOrEmpty(fileName))
		{
			try
			{
				string directoryName = Path.GetDirectoryName(fileName);
				if (string.IsNullOrEmpty(directoryName))
				{
					return value;
				}
				value = value.Replace(XmlConfigDirectoryToken, directoryName);
				return value;
			}
			catch (Exception ex)
			{
				try
				{
					Trace.WriteLine(HelperMethods.StringFormat(CultureInfo.CurrentCulture, _0094(107381555), fileName, ex));
					return value;
				}
				catch
				{
					return value;
				}
			}
		}
		return value;
	}

	private static string GetSettingValueViaXmlConfigFile(string fileName, string name, string @default, bool expand)
	{
		try
		{
			if (fileName == null || name == null)
			{
				return @default;
			}
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.Load(fileName);
			if (xmlDocument.SelectSingleNode(HelperMethods.StringFormat(CultureInfo.InvariantCulture, _0094(107381474), name)) is XmlElement xmlElement)
			{
				string text = null;
				if (xmlElement.HasAttribute(_0094(107394498)))
				{
					text = xmlElement.GetAttribute(_0094(107394498));
				}
				if (!string.IsNullOrEmpty(text))
				{
					if (expand)
					{
						text = Environment.ExpandEnvironmentVariables(text);
					}
					text = ReplaceEnvironmentVariableTokens(text);
					text = ReplaceXmlConfigFileTokens(fileName, text);
				}
				if (text != null)
				{
					return text;
				}
				return @default;
			}
			return @default;
		}
		catch (Exception ex)
		{
			try
			{
				Trace.WriteLine(HelperMethods.StringFormat(CultureInfo.CurrentCulture, _0094(107380873), name, fileName, ex));
				return @default;
			}
			catch
			{
				return @default;
			}
		}
	}

	private static string GetAssemblyTargetFramework(Assembly assembly)
	{
		if ((object)assembly != null)
		{
			return _0094(107380771);
		}
		return null;
	}

	private static string AbbreviateTargetFramework(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return value;
		}
		value = value.Replace(_0094(107380734), _0094(107380701));
		value = value.Replace(_0094(107401464), string.Empty);
		int num = value.IndexOf(',');
		if (num != -1)
		{
			value = value.Substring(0, num);
		}
		return value;
	}

	private static string ReplaceEnvironmentVariableTokens(string value)
	{
		if (!string.IsNullOrEmpty(value))
		{
			string text = GetCachedAssemblyDirectory();
			if (!string.IsNullOrEmpty(text))
			{
				try
				{
					value = value.Replace(AssemblyDirectoryToken, text);
				}
				catch (Exception ex)
				{
					try
					{
						Trace.WriteLine(HelperMethods.StringFormat(CultureInfo.CurrentCulture, _0094(107380696), ex));
					}
					catch
					{
					}
				}
			}
			Assembly assembly = null;
			try
			{
				assembly = Assembly.GetExecutingAssembly();
			}
			catch (Exception ex2)
			{
				try
				{
					Trace.WriteLine(HelperMethods.StringFormat(CultureInfo.CurrentCulture, _0094(107381075), ex2));
				}
				catch
				{
				}
			}
			string text2 = AbbreviateTargetFramework(GetAssemblyTargetFramework(assembly));
			if (!string.IsNullOrEmpty(text2))
			{
				try
				{
					value = value.Replace(TargetFrameworkToken, text2);
					return value;
				}
				catch (Exception ex3)
				{
					try
					{
						Trace.WriteLine(HelperMethods.StringFormat(CultureInfo.CurrentCulture, _0094(107381018), ex3));
						return value;
					}
					catch
					{
						return value;
					}
				}
			}
		}
		return value;
	}

	internal static string GetSettingValue(string name, string @default)
	{
		if (Environment.GetEnvironmentVariable(_0094(107380409)) != null)
		{
			return @default;
		}
		if (name == null)
		{
			return @default;
		}
		bool flag = true;
		string text = null;
		if (Environment.GetEnvironmentVariable(_0094(107380376)) != null)
		{
			flag = false;
		}
		else if (Environment.GetEnvironmentVariable(HelperMethods.StringFormat(CultureInfo.InvariantCulture, _0094(107380331), name)) != null)
		{
			flag = false;
		}
		text = Environment.GetEnvironmentVariable(name);
		if (!string.IsNullOrEmpty(text))
		{
			if (flag)
			{
				text = Environment.ExpandEnvironmentVariables(text);
			}
			text = ReplaceEnvironmentVariableTokens(text);
		}
		if (text != null)
		{
			return text;
		}
		if (Environment.GetEnvironmentVariable(_0094(107380342)) != null)
		{
			return @default;
		}
		return GetSettingValueViaXmlConfigFile(GetCachedXmlConfigFileName(), name, @default, flag);
	}

	private static string ListToString(IList<string> list)
	{
		if (list == null)
		{
			return null;
		}
		StringBuilder stringBuilder = new StringBuilder();
		foreach (string item in list)
		{
			if (item != null)
			{
				if (stringBuilder.Length > 0)
				{
					stringBuilder.Append(' ');
				}
				stringBuilder.Append(item);
			}
		}
		return stringBuilder.ToString();
	}

	private static int CheckForArchitecturesAndPlatforms(string directory, ref List<string> matches)
	{
		int num = 0;
		if (matches == null)
		{
			matches = new List<string>();
		}
		lock (staticSyncRoot)
		{
			if (!string.IsNullOrEmpty(directory))
			{
				if (processorArchitecturePlatforms != null)
				{
					foreach (KeyValuePair<string, string> processorArchitecturePlatform in processorArchitecturePlatforms)
					{
						if (Directory.Exists(MaybeCombinePath(directory, processorArchitecturePlatform.Key)))
						{
							matches.Add(processorArchitecturePlatform.Key);
							num++;
						}
						string value = processorArchitecturePlatform.Value;
						if (value != null && Directory.Exists(MaybeCombinePath(directory, value)))
						{
							matches.Add(value);
							num++;
						}
					}
					return num;
				}
				return num;
			}
			return num;
		}
	}

	private static bool CheckAssemblyCodeBase(Assembly assembly, ref string fileName)
	{
		try
		{
			if ((object)assembly == null)
			{
				return false;
			}
			string codeBase = assembly.CodeBase;
			if (string.IsNullOrEmpty(codeBase))
			{
				return false;
			}
			Uri uri = new Uri(codeBase);
			string localPath = uri.LocalPath;
			if (!File.Exists(localPath))
			{
				return false;
			}
			string directoryName = Path.GetDirectoryName(localPath);
			string path = MaybeCombinePath(directoryName, XmlConfigFileName);
			if (File.Exists(path))
			{
				fileName = localPath;
				return true;
			}
			List<string> matches = null;
			if (CheckForArchitecturesAndPlatforms(directoryName, ref matches) > 0)
			{
				fileName = localPath;
				return true;
			}
			return false;
		}
		catch (Exception ex)
		{
			try
			{
				Trace.WriteLine(HelperMethods.StringFormat(CultureInfo.CurrentCulture, _0094(107380309), ex));
			}
			catch
			{
			}
		}
		return false;
	}

	private static void ResetCachedAssemblyDirectory()
	{
		lock (staticSyncRoot)
		{
			cachedAssemblyDirectory = null;
			noAssemblyDirectory = false;
		}
	}

	private static string GetCachedAssemblyDirectory()
	{
		lock (staticSyncRoot)
		{
			if (cachedAssemblyDirectory != null)
			{
				return cachedAssemblyDirectory;
			}
			if (noAssemblyDirectory)
			{
				return null;
			}
		}
		return GetAssemblyDirectory();
	}

	private static string GetAssemblyDirectory()
	{
		try
		{
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			if ((object)executingAssembly == null)
			{
				lock (staticSyncRoot)
				{
					noAssemblyDirectory = true;
				}
				return null;
			}
			string fileName = null;
			if (!CheckAssemblyCodeBase(executingAssembly, ref fileName))
			{
				fileName = executingAssembly.Location;
			}
			if (string.IsNullOrEmpty(fileName))
			{
				lock (staticSyncRoot)
				{
					noAssemblyDirectory = true;
				}
				return null;
			}
			string directoryName = Path.GetDirectoryName(fileName);
			if (string.IsNullOrEmpty(directoryName))
			{
				lock (staticSyncRoot)
				{
					noAssemblyDirectory = true;
				}
				return null;
			}
			lock (staticSyncRoot)
			{
				cachedAssemblyDirectory = directoryName;
			}
			return directoryName;
		}
		catch (Exception ex)
		{
			try
			{
				Trace.WriteLine(HelperMethods.StringFormat(CultureInfo.CurrentCulture, _0094(107380188), ex));
			}
			catch
			{
			}
		}
		lock (staticSyncRoot)
		{
			noAssemblyDirectory = true;
		}
		return null;
	}

	internal static string GetNativeLibraryFileNameOnly()
	{
		string settingValue = GetSettingValue(_0094(107380551), null);
		if (settingValue != null)
		{
			return settingValue;
		}
		return _0094(107380538);
	}

	private static bool SearchForDirectory(ref string baseDirectory, ref string processorArchitecture)
	{
		if (GetSettingValue(_0094(107380513), null) != null)
		{
			return false;
		}
		string nativeLibraryFileNameOnly = GetNativeLibraryFileNameOnly();
		if (nativeLibraryFileNameOnly == null)
		{
			return false;
		}
		string[] array = new string[2]
		{
			GetAssemblyDirectory(),
			AppDomain.CurrentDomain.BaseDirectory
		};
		string[] array2 = new string[2]
		{
			GetProcessorArchitecture(),
			GetPlatformName(null)
		};
		string[] array3 = array;
		foreach (string text in array3)
		{
			if (text == null)
			{
				continue;
			}
			string[] array4 = array2;
			foreach (string text2 in array4)
			{
				if (text2 != null)
				{
					string path = FixUpDllFileName(MaybeCombinePath(MaybeCombinePath(text, text2), nativeLibraryFileNameOnly));
					if (File.Exists(path))
					{
						baseDirectory = text;
						processorArchitecture = text2;
						return true;
					}
				}
			}
		}
		return false;
	}

	private static string GetBaseDirectory()
	{
		string settingValue = GetSettingValue(_0094(107380432), null);
		if (settingValue != null)
		{
			return settingValue;
		}
		if (GetSettingValue(_0094(107379883), null) != null)
		{
			settingValue = GetAssemblyDirectory();
			if (settingValue != null)
			{
				return settingValue;
			}
		}
		return AppDomain.CurrentDomain.BaseDirectory;
	}

	private static string FixUpDllFileName(string fileName)
	{
		if (!string.IsNullOrEmpty(fileName) && HelperMethods.IsWindows() && !fileName.EndsWith(DllFileExtension, StringComparison.OrdinalIgnoreCase))
		{
			return fileName + DllFileExtension;
		}
		return fileName;
	}

	private static string GetProcessorArchitecture()
	{
		string settingValue = GetSettingValue(_0094(107379866), null);
		if (settingValue != null)
		{
			return settingValue;
		}
		settingValue = GetSettingValue(PROCESSOR_ARCHITECTURE, null);
		if (IntPtr.Size == 4 && string.Equals(settingValue, _0094(107381605), StringComparison.OrdinalIgnoreCase))
		{
			settingValue = _0094(107381619);
		}
		return settingValue;
	}

	private static string GetPlatformName(string processorArchitecture)
	{
		if (processorArchitecture == null)
		{
			processorArchitecture = GetProcessorArchitecture();
		}
		if (string.IsNullOrEmpty(processorArchitecture))
		{
			return null;
		}
		lock (staticSyncRoot)
		{
			if (processorArchitecturePlatforms == null)
			{
				return null;
			}
			if (processorArchitecturePlatforms.TryGetValue(processorArchitecture, out var value))
			{
				return value;
			}
		}
		return null;
	}

	private static bool PreLoadSQLiteDll(string baseDirectory, string processorArchitecture, ref string nativeModuleFileName, ref IntPtr nativeModuleHandle)
	{
		if (baseDirectory == null)
		{
			baseDirectory = GetBaseDirectory();
		}
		if (baseDirectory == null)
		{
			return false;
		}
		string nativeLibraryFileNameOnly = GetNativeLibraryFileNameOnly();
		if (nativeLibraryFileNameOnly == null)
		{
			return false;
		}
		string path = FixUpDllFileName(MaybeCombinePath(baseDirectory, nativeLibraryFileNameOnly));
		if (File.Exists(path))
		{
			return false;
		}
		if (processorArchitecture == null)
		{
			processorArchitecture = GetProcessorArchitecture();
		}
		if (processorArchitecture == null)
		{
			return false;
		}
		path = FixUpDllFileName(MaybeCombinePath(MaybeCombinePath(baseDirectory, processorArchitecture), nativeLibraryFileNameOnly));
		if (!File.Exists(path))
		{
			string platformName = GetPlatformName(processorArchitecture);
			if (platformName == null)
			{
				return false;
			}
			path = FixUpDllFileName(MaybeCombinePath(MaybeCombinePath(baseDirectory, platformName), nativeLibraryFileNameOnly));
			if (!File.Exists(path))
			{
				return false;
			}
		}
		try
		{
			try
			{
				Trace.WriteLine(HelperMethods.StringFormat(CultureInfo.CurrentCulture, _0094(107379785), path));
			}
			catch
			{
			}
			nativeModuleFileName = path;
			nativeModuleHandle = NativeLibraryHelper.LoadLibrary(path);
			return nativeModuleHandle != IntPtr.Zero;
		}
		catch (Exception ex)
		{
			try
			{
				int lastWin32Error = Marshal.GetLastWin32Error();
				Trace.WriteLine(HelperMethods.StringFormat(CultureInfo.CurrentCulture, _0094(107379684), path, lastWin32Error, ex));
			}
			catch
			{
			}
		}
		return false;
	}

	[DllImport("SQLite.Interop.dll")]
	internal static extern IntPtr sqlite3_bind_parameter_name_interop(IntPtr stmt, int index, ref int len);

	[DllImport("SQLite.Interop.dll")]
	internal static extern IntPtr sqlite3_column_database_name_interop(IntPtr stmt, int index, ref int len);

	[DllImport("SQLite.Interop.dll")]
	internal static extern IntPtr sqlite3_column_database_name16_interop(IntPtr stmt, int index, ref int len);

	[DllImport("SQLite.Interop.dll")]
	internal static extern IntPtr sqlite3_column_decltype_interop(IntPtr stmt, int index, ref int len);

	[DllImport("SQLite.Interop.dll")]
	internal static extern IntPtr sqlite3_column_decltype16_interop(IntPtr stmt, int index, ref int len);

	[DllImport("SQLite.Interop.dll")]
	internal static extern IntPtr sqlite3_column_name_interop(IntPtr stmt, int index, ref int len);

	[DllImport("SQLite.Interop.dll")]
	internal static extern IntPtr sqlite3_column_name16_interop(IntPtr stmt, int index, ref int len);

	[DllImport("SQLite.Interop.dll")]
	internal static extern IntPtr sqlite3_column_origin_name_interop(IntPtr stmt, int index, ref int len);

	[DllImport("SQLite.Interop.dll")]
	internal static extern IntPtr sqlite3_column_origin_name16_interop(IntPtr stmt, int index, ref int len);

	[DllImport("SQLite.Interop.dll")]
	internal static extern IntPtr sqlite3_column_table_name_interop(IntPtr stmt, int index, ref int len);

	[DllImport("SQLite.Interop.dll")]
	internal static extern IntPtr sqlite3_column_table_name16_interop(IntPtr stmt, int index, ref int len);

	[DllImport("SQLite.Interop.dll")]
	internal static extern IntPtr sqlite3_column_text_interop(IntPtr stmt, int index, ref int len);

	[DllImport("SQLite.Interop.dll")]
	internal static extern IntPtr sqlite3_column_text16_interop(IntPtr stmt, int index, ref int len);

	[DllImport("SQLite.Interop.dll")]
	internal static extern IntPtr sqlite3_errmsg_interop(IntPtr db, ref int len);

	[DllImport("SQLite.Interop.dll")]
	internal static extern SQLiteErrorCode sqlite3_prepare_interop(IntPtr db, IntPtr pSql, int nBytes, ref IntPtr stmt, ref IntPtr ptrRemain, ref int nRemain);

	[DllImport("SQLite.Interop.dll")]
	internal static extern SQLiteErrorCode sqlite3_table_column_metadata_interop(IntPtr db, byte[] dbName, byte[] tblName, byte[] colName, ref IntPtr ptrDataType, ref IntPtr ptrCollSeq, ref int notNull, ref int primaryKey, ref int autoInc, ref int dtLen, ref int csLen);

	[DllImport("SQLite.Interop.dll")]
	internal static extern IntPtr sqlite3_value_text_interop(IntPtr p, ref int len);

	[DllImport("SQLite.Interop.dll")]
	internal static extern IntPtr sqlite3_value_text16_interop(IntPtr p, ref int len);

	[DllImport("SQLite.Interop.dll")]
	internal static extern int sqlite3_malloc_size_interop(IntPtr p);

	[DllImport("SQLite.Interop.dll")]
	internal static extern IntPtr interop_libversion();

	[DllImport("SQLite.Interop.dll")]
	internal static extern IntPtr interop_sourceid();

	[DllImport("SQLite.Interop.dll")]
	internal static extern int interop_compileoption_used(IntPtr zOptName);

	[DllImport("SQLite.Interop.dll")]
	internal static extern IntPtr interop_compileoption_get(int N);

	[DllImport("SQLite.Interop.dll")]
	internal static extern SQLiteErrorCode sqlite3_close_interop(IntPtr db);

	[DllImport("SQLite.Interop.dll")]
	internal static extern SQLiteErrorCode sqlite3_create_function_interop(IntPtr db, byte[] strName, int nArgs, int nType, IntPtr pvUser, SQLiteCallback func, SQLiteCallback fstep, SQLiteFinalCallback ffinal, int needCollSeq);

	[DllImport("SQLite.Interop.dll")]
	internal static extern SQLiteErrorCode sqlite3_finalize_interop(IntPtr stmt);

	[DllImport("SQLite.Interop.dll")]
	internal static extern SQLiteErrorCode sqlite3_backup_finish_interop(IntPtr backup);

	[DllImport("SQLite.Interop.dll")]
	internal static extern SQLiteErrorCode sqlite3_blob_close_interop(IntPtr blob);

	[DllImport("SQLite.Interop.dll")]
	internal static extern SQLiteErrorCode sqlite3_open_interop(byte[] utf8Filename, byte[] vfsName, SQLiteOpenFlagsEnum flags, int extFuncs, ref IntPtr db);

	[DllImport("SQLite.Interop.dll")]
	internal static extern SQLiteErrorCode sqlite3_open16_interop(byte[] utf8Filename, byte[] vfsName, SQLiteOpenFlagsEnum flags, int extFuncs, ref IntPtr db);

	[DllImport("SQLite.Interop.dll")]
	internal static extern SQLiteErrorCode sqlite3_reset_interop(IntPtr stmt);

	[DllImport("SQLite.Interop.dll")]
	internal static extern int sqlite3_changes_interop(IntPtr db);

	[DllImport("SQLite.Interop.dll")]
	internal static extern IntPtr sqlite3_context_collseq_interop(IntPtr context, ref int type, ref int enc, ref int len);

	[DllImport("SQLite.Interop.dll")]
	internal static extern int sqlite3_context_collcompare_interop(IntPtr context, byte[] p1, int p1len, byte[] p2, int p2len);

	[DllImport("SQLite.Interop.dll")]
	internal static extern SQLiteErrorCode sqlite3_cursor_rowid_interop(IntPtr stmt, int cursor, ref long rowid);

	[DllImport("SQLite.Interop.dll")]
	internal static extern SQLiteErrorCode sqlite3_index_column_info_interop(IntPtr db, byte[] catalog, byte[] IndexName, byte[] ColumnName, ref int sortOrder, ref int onError, ref IntPtr Collation, ref int colllen);

	[DllImport("SQLite.Interop.dll")]
	internal static extern int sqlite3_table_cursor_interop(IntPtr stmt, int db, int tableRootPage);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr sqlite3_libversion();

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int sqlite3_libversion_number();

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr sqlite3_sourceid();

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int sqlite3_compileoption_used(IntPtr zOptName);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr sqlite3_compileoption_get(int N);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern SQLiteErrorCode sqlite3_enable_shared_cache(int enable);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern SQLiteErrorCode sqlite3_enable_load_extension(IntPtr db, int enable);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern SQLiteErrorCode sqlite3_load_extension(IntPtr db, byte[] fileName, byte[] procName, ref IntPtr pError);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern SQLiteErrorCode sqlite3_overload_function(IntPtr db, IntPtr zName, int nArgs);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
	internal static extern SQLiteErrorCode sqlite3_win32_set_directory(uint type, string value);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern SQLiteErrorCode sqlite3_win32_reset_heap();

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern SQLiteErrorCode sqlite3_win32_compact_heap(ref uint largest);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr sqlite3_malloc(int n);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr sqlite3_realloc(IntPtr p, int n);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void sqlite3_free(IntPtr p);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern SQLiteErrorCode sqlite3_open_v2(byte[] utf8Filename, ref IntPtr db, SQLiteOpenFlagsEnum flags, byte[] vfsName);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
	internal static extern SQLiteErrorCode sqlite3_open16(string fileName, ref IntPtr db);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void sqlite3_interrupt(IntPtr db);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long sqlite3_last_insert_rowid(IntPtr db);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int sqlite3_changes(IntPtr db);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long sqlite3_memory_used();

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long sqlite3_memory_highwater(int resetFlag);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern SQLiteErrorCode sqlite3_shutdown();

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern SQLiteErrorCode sqlite3_busy_timeout(IntPtr db, int ms);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern SQLiteErrorCode sqlite3_clear_bindings(IntPtr stmt);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern SQLiteErrorCode sqlite3_bind_blob(IntPtr stmt, int index, byte[] value, int nSize, IntPtr nTransient);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern SQLiteErrorCode sqlite3_bind_double(IntPtr stmt, int index, double value);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern SQLiteErrorCode sqlite3_bind_int(IntPtr stmt, int index, int value);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "sqlite3_bind_int")]
	internal static extern SQLiteErrorCode sqlite3_bind_uint(IntPtr stmt, int index, uint value);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern SQLiteErrorCode sqlite3_bind_int64(IntPtr stmt, int index, long value);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "sqlite3_bind_int64")]
	internal static extern SQLiteErrorCode sqlite3_bind_uint64(IntPtr stmt, int index, ulong value);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern SQLiteErrorCode sqlite3_bind_null(IntPtr stmt, int index);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern SQLiteErrorCode sqlite3_bind_text(IntPtr stmt, int index, byte[] value, int nlen, IntPtr pvReserved);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int sqlite3_bind_parameter_count(IntPtr stmt);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int sqlite3_bind_parameter_index(IntPtr stmt, byte[] strName);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int sqlite3_column_count(IntPtr stmt);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern SQLiteErrorCode sqlite3_step(IntPtr stmt);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int sqlite3_stmt_readonly(IntPtr stmt);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double sqlite3_column_double(IntPtr stmt, int index);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int sqlite3_column_int(IntPtr stmt, int index);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long sqlite3_column_int64(IntPtr stmt, int index);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr sqlite3_column_blob(IntPtr stmt, int index);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int sqlite3_column_bytes(IntPtr stmt, int index);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int sqlite3_column_bytes16(IntPtr stmt, int index);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern TypeAffinity sqlite3_column_type(IntPtr stmt, int index);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern SQLiteErrorCode sqlite3_create_collation(IntPtr db, byte[] strName, int nType, IntPtr pvUser, SQLiteCollation func);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int sqlite3_aggregate_count(IntPtr context);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr sqlite3_value_blob(IntPtr p);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int sqlite3_value_bytes(IntPtr p);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int sqlite3_value_bytes16(IntPtr p);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double sqlite3_value_double(IntPtr p);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int sqlite3_value_int(IntPtr p);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long sqlite3_value_int64(IntPtr p);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern TypeAffinity sqlite3_value_type(IntPtr p);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void sqlite3_result_blob(IntPtr context, byte[] value, int nSize, IntPtr pvReserved);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void sqlite3_result_double(IntPtr context, double value);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void sqlite3_result_error(IntPtr context, byte[] strErr, int nLen);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void sqlite3_result_error_code(IntPtr context, SQLiteErrorCode value);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void sqlite3_result_error_toobig(IntPtr context);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void sqlite3_result_error_nomem(IntPtr context);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void sqlite3_result_value(IntPtr context, IntPtr value);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void sqlite3_result_zeroblob(IntPtr context, int nLen);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void sqlite3_result_int(IntPtr context, int value);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void sqlite3_result_int64(IntPtr context, long value);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void sqlite3_result_null(IntPtr context);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void sqlite3_result_text(IntPtr context, byte[] value, int nLen, IntPtr pvReserved);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr sqlite3_aggregate_context(IntPtr context, int nBytes);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
	internal static extern SQLiteErrorCode sqlite3_bind_text16(IntPtr stmt, int index, string value, int nlen, IntPtr pvReserved);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
	internal static extern void sqlite3_result_error16(IntPtr context, string strName, int nLen);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
	internal static extern void sqlite3_result_text16(IntPtr context, string strName, int nLen, IntPtr pvReserved);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern SQLiteErrorCode sqlite3_key(IntPtr db, byte[] key, int keylen);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern SQLiteErrorCode sqlite3_rekey(IntPtr db, byte[] key, int keylen);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void sqlite3_progress_handler(IntPtr db, int ops, SQLiteProgressCallback func, IntPtr pvUser);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr sqlite3_set_authorizer(IntPtr db, SQLiteAuthorizerCallback func, IntPtr pvUser);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr sqlite3_update_hook(IntPtr db, SQLiteUpdateCallback func, IntPtr pvUser);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr sqlite3_commit_hook(IntPtr db, SQLiteCommitCallback func, IntPtr pvUser);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr sqlite3_trace(IntPtr db, SQLiteTraceCallback func, IntPtr pvUser);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "sqlite3_config")]
	internal static extern SQLiteErrorCode sqlite3_config_none(SQLiteConfigOpsEnum op);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "sqlite3_config")]
	internal static extern SQLiteErrorCode sqlite3_config_int(SQLiteConfigOpsEnum op, int value);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "sqlite3_config")]
	internal static extern SQLiteErrorCode sqlite3_config_log(SQLiteConfigOpsEnum op, SQLiteLogCallback func, IntPtr pvUser);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "sqlite3_db_config")]
	internal static extern SQLiteErrorCode sqlite3_db_config_int_refint(IntPtr db, SQLiteConfigDbOpsEnum op, int value, ref int result);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr sqlite3_rollback_hook(IntPtr db, SQLiteRollbackCallback func, IntPtr pvUser);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr sqlite3_db_handle(IntPtr stmt);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern SQLiteErrorCode sqlite3_db_release_memory(IntPtr db);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr sqlite3_db_filename(IntPtr db, IntPtr dbName);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int sqlite3_db_readonly(IntPtr db, IntPtr dbName);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "sqlite3_db_filename")]
	internal static extern IntPtr sqlite3_db_filename_bytes(IntPtr db, byte[] dbName);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr sqlite3_next_stmt(IntPtr db, IntPtr stmt);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern SQLiteErrorCode sqlite3_exec(IntPtr db, byte[] strSql, IntPtr pvCallback, IntPtr pvParam, ref IntPtr errMsg);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int sqlite3_release_memory(int nBytes);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int sqlite3_get_autocommit(IntPtr db);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern SQLiteErrorCode sqlite3_extended_result_codes(IntPtr db, int onoff);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern SQLiteErrorCode sqlite3_errcode(IntPtr db);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern SQLiteErrorCode sqlite3_extended_errcode(IntPtr db);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr sqlite3_errstr(SQLiteErrorCode rc);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void sqlite3_log(SQLiteErrorCode iErrCode, byte[] zFormat);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern SQLiteErrorCode sqlite3_file_control(IntPtr db, byte[] zDbName, int op, IntPtr pArg);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr sqlite3_backup_init(IntPtr destDb, byte[] zDestName, IntPtr sourceDb, byte[] zSourceName);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern SQLiteErrorCode sqlite3_backup_step(IntPtr backup, int nPage);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int sqlite3_backup_remaining(IntPtr backup);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int sqlite3_backup_pagecount(IntPtr backup);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern SQLiteErrorCode sqlite3_blob_close(IntPtr blob);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int sqlite3_blob_bytes(IntPtr blob);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern SQLiteErrorCode sqlite3_blob_open(IntPtr db, byte[] dbName, byte[] tblName, byte[] colName, long rowId, int flags, ref IntPtr ptrBlob);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern SQLiteErrorCode sqlite3_blob_read(IntPtr blob, [MarshalAs(UnmanagedType.LPArray)] byte[] buffer, int count, int offset);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern SQLiteErrorCode sqlite3_blob_reopen(IntPtr blob, long rowId);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern SQLiteErrorCode sqlite3_blob_write(IntPtr blob, [MarshalAs(UnmanagedType.LPArray)] byte[] buffer, int count, int offset);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern SQLiteErrorCode sqlite3_declare_vtab(IntPtr db, IntPtr zSQL);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr sqlite3_mprintf(IntPtr format, __arglist);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr sqlite3_create_disposable_module(IntPtr db, IntPtr name, ref sqlite3_module module, IntPtr pClientData, xDestroyModule xDestroy);

	[DllImport("SQLite.Interop.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void sqlite3_dispose_module(IntPtr pModule);
}
