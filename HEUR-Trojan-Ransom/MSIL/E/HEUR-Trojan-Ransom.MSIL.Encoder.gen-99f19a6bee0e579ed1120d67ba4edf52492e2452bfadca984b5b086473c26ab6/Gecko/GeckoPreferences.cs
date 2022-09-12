using System;
using System.IO;
using System.Runtime.InteropServices;
using Gecko.Interop;

namespace Gecko;

public class GeckoPreferences : IDisposable
{
	private const int PREF_INVALID = 0;

	private const int PREF_STRING = 32;

	private const int PREF_INT = 64;

	private const int PREF_BOOL = 128;

	private static ComPtr<nsIPrefService> _prefService;

	private static GeckoPreferences _default;

	private static GeckoPreferences _user;

	private ComPtr<nsIPrefBranch> _branch;

	private readonly bool _isDefaultBranch;

	public static GeckoPreferences User => _user ?? (_user = new GeckoPreferences(defaultBranch: false));

	public static GeckoPreferences Default => _default ?? (_default = new GeckoPreferences(defaultBranch: true));

	public object this[string prefName]
	{
		get
		{
			return _branch.Instance.GetPrefType(prefName) switch
			{
				32 => GetUnicodePref(_branch.Instance, prefName), 
				0 => null, 
				128 => _branch.Instance.GetBoolPref(prefName), 
				64 => _branch.Instance.GetIntPref(prefName), 
				_ => throw new ArgumentException("prefName"), 
			};
		}
		set
		{
			if (string.IsNullOrEmpty(prefName))
			{
				throw new ArgumentException("prefName");
			}
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			int prefType = _branch.Instance.GetPrefType(prefName);
			int valueType = GetValueType(value);
			if (prefType != 0 && prefType != valueType)
			{
				throw new InvalidCastException("A " + value.GetType().Name + " value may not be assigned to '" + prefName + "' because it is already defined as " + GetPreferenceType(prefName).Name + ".");
			}
			if (value is string)
			{
				SetUnicodePref(_branch.Instance, prefName, (string)value);
				return;
			}
			if (value is int)
			{
				_branch.Instance.SetIntPref(prefName, (int)value);
				return;
			}
			if (value is bool)
			{
				_branch.Instance.SetBoolPref(prefName, (bool)value);
			}
			if (value is float)
			{
				SetUnicodePref(_branch.Instance, prefName, ((float)value).ToString());
			}
		}
	}

	public string Root => _branch.Instance.GetRootAttribute();

	static GeckoPreferences()
	{
		Xpcom.Initialize();
		_prefService = Xpcom.GetService2<nsIPrefService>("@mozilla.org/preferences-service;1");
	}

	public static void Shutdown()
	{
		if (_prefService != null)
		{
			_prefService.Dispose();
		}
		if (_user != null)
		{
			_user.Dispose();
		}
		if (_default != null)
		{
			_default.Dispose();
		}
		_prefService = null;
		_user = null;
		_default = null;
	}

	private static string GetUnicodePref(nsIPrefBranch branch, string name)
	{
		Guid aType = typeof(nsISupportsString).GUID;
		IntPtr complexValue = branch.GetComplexValue(name, ref aType);
		if (complexValue == IntPtr.Zero)
		{
			return null;
		}
		nsISupportsString nsISupportsString2 = (nsISupportsString)Xpcom.GetObjectForIUnknown(complexValue);
		Marshal.Release(complexValue);
		return nsString.Get(nsISupportsString2.GetDataAttribute);
	}

	private static void SetUnicodePref(nsIPrefBranch branch, string name, string value)
	{
		Guid aType = typeof(nsISupportsString).GUID;
		nsISupportsString nsISupportsString2 = Xpcom.CreateInstance<nsISupportsString>("@mozilla.org/supports-string;1");
		nsString.Set(nsISupportsString2.SetDataAttribute, value);
		branch.SetComplexValue(name, ref aType, Xpcom.QueryInterface<nsISupports>(nsISupportsString2));
	}

	public static void Load(string filename)
	{
		if (string.IsNullOrEmpty(filename))
		{
			throw new ArgumentNullException("filename");
		}
		if (!File.Exists(filename))
		{
			throw new FileNotFoundException();
		}
		_prefService.Instance.ReadUserPrefs((nsIFile)Xpcom.NewNativeLocalFile(filename));
	}

	public static void Save(string filename)
	{
		if (string.IsNullOrEmpty(filename))
		{
			throw new ArgumentNullException("filename");
		}
		_prefService.Instance.SavePrefFile((nsIFile)Xpcom.NewNativeLocalFile(filename));
	}

	private static int GetValueType(object value)
	{
		if (value is int)
		{
			return 64;
		}
		if (value is string)
		{
			return 32;
		}
		if (value is bool)
		{
			return 128;
		}
		if (value is float)
		{
			return 32;
		}
		throw new ArgumentException("Gecko preferences must be either a String, Int32, or Boolean value.", "prefName");
	}

	private GeckoPreferences(bool defaultBranch)
	{
		_isDefaultBranch = defaultBranch;
		if (defaultBranch)
		{
			_branch = new ComPtr<nsIPrefBranch>(_prefService.Instance.GetDefaultBranch(""));
		}
		else
		{
			_branch = new ComPtr<nsIPrefBranch>(_prefService.Instance.GetBranch(""));
		}
	}

	public void Dispose()
	{
		if (_branch != null)
		{
			_branch.Dispose();
		}
		_branch = null;
		GC.SuppressFinalize(this);
	}

	public void Reset()
	{
		if (_isDefaultBranch)
		{
			_prefService.Instance.ResetPrefs();
		}
		else
		{
			_prefService.Instance.ResetUserPrefs();
		}
	}

	public bool GetIntPref(string prefName, out int? value)
	{
		if (string.IsNullOrEmpty(prefName))
		{
			throw new ArgumentException("prefName");
		}
		switch (_branch.Instance.GetPrefType(prefName))
		{
		default:
			value = null;
			return false;
		case 64:
			value = _branch.Instance.GetIntPref(prefName);
			return true;
		case 0:
			value = null;
			return true;
		}
	}

	public bool SetIntPref(string prefName, int? value)
	{
		if (string.IsNullOrEmpty(prefName))
		{
			throw new ArgumentException("prefName");
		}
		switch (_branch.Instance.GetPrefType(prefName))
		{
		default:
			return false;
		case 64:
			if (value.HasValue)
			{
				_branch.Instance.SetIntPref(prefName, value.Value);
			}
			else
			{
				_branch.Instance.ClearUserPref(prefName);
			}
			return true;
		case 0:
			if (value.HasValue)
			{
				_branch.Instance.SetIntPref(prefName, value.Value);
			}
			return true;
		}
	}

	public bool GetBoolPref(string prefName, out bool? value)
	{
		if (string.IsNullOrEmpty(prefName))
		{
			throw new ArgumentException("prefName");
		}
		switch (_branch.Instance.GetPrefType(prefName))
		{
		default:
			value = null;
			return false;
		case 128:
			value = _branch.Instance.GetBoolPref(prefName);
			return true;
		case 0:
			value = null;
			return true;
		}
	}

	public bool SetBoolPref(string prefName, bool? value)
	{
		if (string.IsNullOrEmpty(prefName))
		{
			throw new ArgumentException("prefName");
		}
		switch (_branch.Instance.GetPrefType(prefName))
		{
		default:
			return false;
		case 128:
			if (value.HasValue)
			{
				_branch.Instance.SetBoolPref(prefName, value.Value);
			}
			else
			{
				_branch.Instance.ClearUserPref(prefName);
			}
			return true;
		case 0:
			if (value.HasValue)
			{
				_branch.Instance.SetBoolPref(prefName, value.Value);
			}
			return true;
		}
	}

	public bool GetCharPref(string prefName, out string value)
	{
		if (string.IsNullOrEmpty(prefName))
		{
			throw new ArgumentException("prefName");
		}
		switch (_branch.Instance.GetPrefType(prefName))
		{
		default:
			value = null;
			return false;
		case 32:
			value = GetUnicodePref(_branch.Instance, prefName);
			return true;
		case 0:
			value = null;
			return true;
		}
	}

	public bool SetCharPref(string prefName, string value)
	{
		if (string.IsNullOrEmpty(prefName))
		{
			throw new ArgumentException("prefName");
		}
		switch (_branch.Instance.GetPrefType(prefName))
		{
		default:
			return false;
		case 32:
			if (value != null)
			{
				SetUnicodePref(_branch.Instance, prefName, value);
			}
			else
			{
				_branch.Instance.ClearUserPref(prefName);
			}
			return true;
		case 0:
			if (value != null)
			{
				SetUnicodePref(_branch.Instance, prefName, value);
			}
			return true;
		}
	}

	public bool GetFloatPref(string prefName, float? value)
	{
		if (string.IsNullOrEmpty(prefName))
		{
			throw new ArgumentException("prefName");
		}
		switch (_branch.Instance.GetPrefType(prefName))
		{
		default:
			value = null;
			return false;
		case 32:
			value = _branch.Instance.GetFloatPref(prefName);
			return true;
		case 0:
			value = null;
			return true;
		}
	}

	public bool SetFloatPref(string prefName, float? value)
	{
		if (string.IsNullOrEmpty(prefName))
		{
			throw new ArgumentException("prefName");
		}
		switch (_branch.Instance.GetPrefType(prefName))
		{
		default:
			return false;
		case 32:
			if (value.HasValue)
			{
				SetUnicodePref(_branch.Instance, prefName, value.Value.ToString());
			}
			else
			{
				_branch.Instance.ClearUserPref(prefName);
			}
			return true;
		case 0:
			if (value.HasValue)
			{
				SetUnicodePref(_branch.Instance, prefName, value.Value.ToString());
			}
			return true;
		}
	}

	public Type GetPreferenceType(string name)
	{
		if (string.IsNullOrEmpty(name))
		{
			throw new ArgumentException("name");
		}
		return _branch.Instance.GetPrefType(name) switch
		{
			128 => typeof(bool), 
			64 => typeof(int), 
			32 => typeof(string), 
			_ => null, 
		};
	}

	public void SetLocked(string name, bool locked)
	{
		if (string.IsNullOrEmpty(name))
		{
			throw new ArgumentException("name");
		}
		if (locked)
		{
			_branch.Instance.LockPref(name);
		}
		else
		{
			_branch.Instance.UnlockPref(name);
		}
	}

	public bool GetLocked(string name)
	{
		if (string.IsNullOrEmpty(name))
		{
			throw new ArgumentException("name");
		}
		return _branch.Instance.PrefIsLocked(name);
	}

	public void Clear(string name)
	{
		if (string.IsNullOrEmpty(name))
		{
			throw new ArgumentException("name");
		}
		_branch.Instance.ClearUserPref(name);
	}
}
