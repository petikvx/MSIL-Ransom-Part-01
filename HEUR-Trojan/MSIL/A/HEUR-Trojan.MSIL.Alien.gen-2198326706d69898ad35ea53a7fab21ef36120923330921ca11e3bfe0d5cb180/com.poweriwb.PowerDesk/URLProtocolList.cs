using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security;
using System.Text;
using System.Windows;
using System.Windows.Media;
using Microsoft.Win32;

namespace com.poweriwb.PowerDesk;

internal class URLProtocolList : INotifyPropertyChanged
{
	public static Dictionary<string, URLProtocolList> globalSection;

	private string mSection;

	private string mProtocolName;

	private string mPath;

	private string mType;

	private string mCheckSum = null;

	private bool mAllowY = false;

	private bool mAllowN = false;

	private string mGroupName;

	private static int grpGlobalIndex = 0;

	public string Section
	{
		get
		{
			return mSection;
		}
		set
		{
			mSection = value;
			string[] array = mSection.Split(new char[1] { ',' });
			Type = array[0];
			ProtocolName = array[1];
			lock (this)
			{
				GroupName = "GrpURLP" + $"{++grpGlobalIndex:D4}";
			}
			NotifyPropertyChanged("StrCommand");
			NotifyPropertyChanged("AllowYN");
			NotifyPropertyChanged("AllowY");
			NotifyPropertyChanged("AllowN");
			NotifyPropertyChanged("IsFileExist");
			NotifyPropertyChanged("Section");
			NotifyPropertyChanged("State");
		}
	}

	public string ProtocolName
	{
		get
		{
			return mProtocolName;
		}
		set
		{
			mProtocolName = value;
			NotifyPropertyChanged("ProtocolName");
		}
	}

	public string StrCommand
	{
		get
		{
			string result = "";
			RegistryKey registryKey = null;
			if (Type == "UUP")
			{
				if (Utils.Is64OS())
				{
					RegistryKey registryKey2 = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
					registryKey = registryKey2.OpenSubKey("Software\\Classes\\" + ProtocolName);
				}
				else
				{
					registryKey = Registry.CurrentUser.OpenSubKey("Software\\Classes\\" + ProtocolName);
				}
			}
			else if (Type == "AUP")
			{
				if (Utils.Is64OS())
				{
					RegistryKey registryKey2 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
					registryKey = registryKey2.OpenSubKey("Software\\Classes\\" + ProtocolName);
				}
				else
				{
					registryKey = Registry.LocalMachine.OpenSubKey("Software\\Classes\\" + ProtocolName);
				}
			}
			if (registryKey != null)
			{
				string text = "";
				try
				{
					text = registryKey.OpenSubKey("shell")!.OpenSubKey("open")!.OpenSubKey("command", RegistryKeyPermissionCheck.ReadWriteSubTree)!.GetValue("")!.ToString();
				}
				catch (Exception)
				{
				}
				result = text;
			}
			return result;
		}
	}

	public string Path
	{
		get
		{
			return mPath;
		}
		set
		{
			mPath = value;
			NotifyPropertyChanged("Path");
		}
	}

	public string Type
	{
		get
		{
			return mType;
		}
		set
		{
			mType = value;
			NotifyPropertyChanged("Type");
		}
	}

	public string State
	{
		get
		{
			string result = "State1";
			if (!IsFileExist || AllowN)
			{
				result = "State2";
			}
			return result;
		}
		set
		{
		}
	}

	public SolidColorBrush AllowYNColor
	{
		get
		{
			if (!AllowN)
			{
				return Brushes.get_White();
			}
			return Brushes.get_Blue();
		}
		set
		{
		}
	}

	public bool IsFileExist
	{
		get
		{
			bool result = false;
			string text = StrCommand.Trim();
			if (text.StartsWith("\""))
			{
				text = text[..text.IndexOf('"', 2)].Replace("\"", "");
				if (Utils.FileExists(text))
				{
					result = true;
				}
			}
			else if (text.IndexOf(" ") == -1 && Utils.FileExists(text))
			{
				result = true;
			}
			else if (2 < text.Length)
			{
				int num = text.IndexOf('.', 2);
				string text2 = "";
				try
				{
					for (int i = num + 1; i < text.Length; i++)
					{
						text2 = text.Substring(0, i);
						string value = text.Substring(i - 1, 1);
						if (".".Equals(value))
						{
							num = text.IndexOf(" ", i);
							if (i < num)
							{
								i = num;
								text2 = text.Substring(0, i);
							}
							else
							{
								text2 = text;
							}
						}
						if (Utils.FileExists(text2))
						{
							result = true;
							return result;
						}
					}
					return result;
				}
				catch (Exception)
				{
					return result;
				}
			}
			return result;
		}
	}

	public string CheckSum
	{
		get
		{
			return mCheckSum;
		}
		set
		{
			mCheckSum = value;
			NotifyPropertyChanged("CheckSum");
		}
	}

	public bool AllowY
	{
		get
		{
			return mAllowY;
		}
		set
		{
			mAllowY = value;
			mAllowN = !value;
			NotifyPropertyChanged("AllowY");
			NotifyPropertyChanged("AllowYNColor");
			NotifyPropertyChanged("State");
		}
	}

	public bool AllowN
	{
		get
		{
			return mAllowN;
		}
		set
		{
			mAllowN = value;
			mAllowY = !value;
			NotifyPropertyChanged("AllowN");
			NotifyPropertyChanged("AllowYNColor");
			NotifyPropertyChanged("State");
		}
	}

	public string AllowYN
	{
		get
		{
			RegistryKey registryKey = null;
			if (Type == "UUP")
			{
				if (Utils.Is64OS())
				{
					RegistryKey registryKey2 = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
					registryKey = registryKey2.OpenSubKey("Software\\Classes\\" + ProtocolName);
				}
				else
				{
					registryKey = Registry.CurrentUser.OpenSubKey("Software\\Classes\\" + ProtocolName);
				}
			}
			else if (Type == "AUP")
			{
				if (Utils.Is64OS())
				{
					RegistryKey registryKey2 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
					registryKey = registryKey2.OpenSubKey("Software\\Classes\\" + ProtocolName);
				}
				else
				{
					registryKey = Registry.LocalMachine.OpenSubKey("Software\\Classes\\" + ProtocolName);
				}
			}
			if (registryKey != null)
			{
				if (registryKey.GetValue("URL Protocol") != null)
				{
					AllowY = true;
				}
				else if (registryKey.GetValue("URL Protocol_GoldStar") != null)
				{
					AllowN = true;
				}
				else
				{
					AllowY = false;
					AllowN = false;
				}
				registryKey.Close();
				registryKey.Dispose();
				registryKey = null;
			}
			return AllowY ? "Y" : "N";
		}
		set
		{
			RegistryKey registryKey = null;
			if (Type == "UUP")
			{
				try
				{
					if (Utils.Is64OS())
					{
						RegistryKey registryKey2 = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
						registryKey = registryKey2.OpenSubKey("Software\\Classes\\" + ProtocolName, RegistryKeyPermissionCheck.ReadWriteSubTree);
					}
					else
					{
						registryKey = Registry.CurrentUser.OpenSubKey("Software\\Classes\\" + ProtocolName, RegistryKeyPermissionCheck.ReadWriteSubTree);
					}
				}
				catch (SecurityException ex)
				{
					Utils.alert(ex.Message, Application.get_Current().get_MainWindow().get_Title());
				}
			}
			else if (Type == "AUP")
			{
				try
				{
					if (Utils.Is64OS())
					{
						RegistryKey registryKey2 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
						registryKey = registryKey2.OpenSubKey("Software\\Classes\\" + ProtocolName, RegistryKeyPermissionCheck.ReadWriteSubTree);
					}
					else
					{
						registryKey = Registry.LocalMachine.OpenSubKey("Software\\Classes\\" + ProtocolName, RegistryKeyPermissionCheck.ReadWriteSubTree);
					}
				}
				catch (SecurityException ex)
				{
					Utils.alert(ex.Message, Application.get_Current().get_MainWindow().get_Title());
				}
			}
			if (registryKey != null)
			{
				string value2 = "";
				if (registryKey.GetValue("URL Protocol") != null)
				{
					value2 = registryKey.GetValue("URL Protocol")!.ToString();
					registryKey.DeleteValue("URL Protocol");
				}
				if (registryKey.GetValue("URL Protocol_GoldStar") != null)
				{
					value2 = registryKey.GetValue("URL Protocol_GoldStar")!.ToString();
					registryKey.DeleteValue("URL Protocol_GoldStar");
				}
				if (value == "Y")
				{
					AllowY = true;
					registryKey.SetValue("URL Protocol", value2, RegistryValueKind.String);
				}
				else if (value == "N")
				{
					AllowN = true;
					registryKey.SetValue("URL Protocol_GoldStar", value2, RegistryValueKind.String);
				}
				registryKey.Close();
				registryKey.Dispose();
				registryKey = null;
			}
			NotifyPropertyChanged("AllowYN");
			NotifyPropertyChanged("State");
			NotifyPropertyChanged("AllowYNColor");
		}
	}

	public string GroupName
	{
		get
		{
			return mGroupName;
		}
		set
		{
			mGroupName = value;
		}
	}

	public event PropertyChangedEventHandler PropertyChanged;

	private URLProtocolList(string p)
	{
		globalSection.Add(p, this);
		Section = p;
	}

	private URLProtocolList()
	{
	}

	public static URLProtocolList GetOrCreate(string p)
	{
		if (globalSection == null)
		{
			globalSection = new Dictionary<string, URLProtocolList>();
		}
		if (globalSection.ContainsKey(p))
		{
			return globalSection[p];
		}
		return new URLProtocolList(p);
	}

	private void NotifyPropertyChanged(string info)
	{
		if (this.PropertyChanged != null)
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(info));
		}
	}

	internal static URLProtocolList getItemByGroupName(string strGroupname)
	{
		URLProtocolList result = null;
		string[] array = globalSection.Keys.ToArray();
		for (int i = 0; i < array.Length; i++)
		{
			if (globalSection[array[i]].GroupName == strGroupname)
			{
				result = globalSection[array[i]];
				break;
			}
		}
		return result;
	}

	internal StringBuilder ToString2()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(Section);
		return stringBuilder;
	}
}
