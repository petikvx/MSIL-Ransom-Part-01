using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Media;
using Microsoft.Win32;

namespace com.poweriwb.PowerDesk;

internal class AppOutBlockList : INotifyPropertyChanged
{
	private static int grpGlobalIndex = 0;

	private static bool isApplyNoticeActive = false;

	public static Dictionary<string, AppOutBlockList> globalSection;

	private string mSection = null;

	private int midx;

	private string mKeyName = null;

	private string mKeyValue = null;

	private string mAppName = null;

	private string mAppPath = null;

	private string mAction = null;

	private string mAppGroupName;

	private bool? mIsAppFileExist = null;

	private string mCheckSum = null;

	private string mActive = null;

	private string mVState = "";

	private string mDesc = "";

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
			lock (this)
			{
				AppGroupName = "GrpAppOB" + $"{++grpGlobalIndex:D4}";
			}
			idx = grpGlobalIndex;
			KeyName = array[0];
			KeyValue = array[1];
			NotifyPropertyChanged("idx");
			NotifyPropertyChanged("AppName");
			NotifyPropertyChanged("AppPath");
			NotifyPropertyChanged("ActionAllow");
			NotifyPropertyChanged("ActionBlock");
			NotifyPropertyChanged("IsAppFileExist");
			NotifyPropertyChanged("Section");
			NotifyPropertyChanged("State");
		}
	}

	public int idx
	{
		get
		{
			return midx;
		}
		set
		{
			midx = value;
		}
	}

	public string KeyName
	{
		get
		{
			return mKeyName;
		}
		set
		{
			mKeyName = value;
			NotifyPropertyChanged("KeyName");
		}
	}

	public string KeyValue
	{
		get
		{
			return mKeyValue;
		}
		set
		{
			mKeyValue = value;
			NotifyPropertyChanged("KeyValue");
		}
	}

	public string AppName
	{
		get
		{
			if (mAppName == null)
			{
				mAppName = GetAppName();
			}
			return mAppName;
		}
	}

	public string AppPath
	{
		get
		{
			if (null == mAppPath)
			{
				mAppPath = GetPropertyName("App");
			}
			return mAppPath;
		}
	}

	public bool ActionAllow
	{
		get
		{
			if (null == mAction)
			{
				mAction = GetPropertyName("Action");
			}
			return mAction.Equals("Allow", StringComparison.CurrentCultureIgnoreCase);
		}
		set
		{
			string text = null;
			text = KeyValue;
			bool flag = false;
			if (value)
			{
				KeyValue = KeyValue.Replace("|Action=Block|", "|Action=Allow|");
				KeyValue = KeyValue.Replace("|Name=Deny ", "|Name=Not Deny ");
				flag = RegUpdate(text);
			}
			if (flag && value)
			{
				mAction = "Allow";
				NotifyPropertyChanged("ActionAllow");
				NotifyPropertyChanged("ActionBlock");
				NotifyPropertyChanged("State");
				NotifyPropertyChanged("AppName");
			}
		}
	}

	public bool ActionBlock
	{
		get
		{
			if (null == mAction)
			{
				mAction = GetPropertyName("Action");
			}
			return mAction.Equals("Block", StringComparison.CurrentCultureIgnoreCase);
		}
		set
		{
			string text = null;
			text = KeyValue;
			bool flag = false;
			if (value)
			{
				KeyValue = KeyValue.Replace("|Action=Allow|", "|Action=Block|");
				KeyValue = KeyValue.Replace("|Name=Not Deny ", "|Name=Deny ");
				flag = RegUpdate(text);
			}
			if (flag && value)
			{
				mAction = "Block";
				NotifyPropertyChanged("ActionAllow");
				NotifyPropertyChanged("ActionBlock");
				NotifyPropertyChanged("ActionBlockColor");
				NotifyPropertyChanged("State");
				NotifyPropertyChanged("AppName");
			}
		}
	}

	public string AppGroupName
	{
		get
		{
			return mAppGroupName;
		}
		set
		{
			mAppGroupName = value;
		}
	}

	public string State
	{
		get
		{
			string result = "State1";
			if (!IsAppFileExist || (ActionBlock && Active))
			{
				result = "State2";
			}
			return result;
		}
		set
		{
		}
	}

	public bool IsAppFileExist
	{
		get
		{
			bool value = false;
			if (!mIsAppFileExist.HasValue)
			{
				string appPath = AppPath;
				if (appPath.StartsWith("\""))
				{
					appPath = appPath[..appPath.IndexOf('"', 2)].Replace("\"", "");
					if (Utils.FileExists(appPath))
					{
						value = true;
					}
				}
				else if (Utils.FileExists(appPath))
				{
					value = true;
				}
				else if (2 < appPath.Length)
				{
					int num = appPath.IndexOf('.', 2);
					string text = "";
					try
					{
						for (int i = num + 1; i < appPath.Length; i++)
						{
							text = appPath.Substring(0, i);
							if (Utils.FileExists(text))
							{
								value = true;
								break;
							}
						}
					}
					catch (Exception ex)
					{
						Console.Error.WriteLine(ex.Message);
					}
				}
				mIsAppFileExist = value;
				if (mIsAppFileExist == false)
				{
					Desc = "파일이 없습니다. 정책을 삭제하세요.";
				}
			}
			return mIsAppFileExist == true;
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

	public bool Active
	{
		get
		{
			if (null == mActive)
			{
				mActive = GetPropertyName("Active");
			}
			return mActive.Equals("TRUE", StringComparison.CurrentCultureIgnoreCase);
		}
		set
		{
			string text = null;
			text = KeyValue;
			if (value)
			{
				KeyValue = KeyValue.Replace("|Active=FALSE|", "|Active=TRUE|");
			}
			else
			{
				KeyValue = KeyValue.Replace("|Active=TRUE|", "|Active=FALSE|");
			}
			if (RegUpdate(text))
			{
				if (value)
				{
					mActive = "TRUE";
				}
				else
				{
					mActive = "FALSE";
				}
				NotifyPropertyChanged("State");
				NotifyPropertyChanged("ActiveColor");
			}
		}
	}

	public SolidColorBrush ActiveColor
	{
		get
		{
			if (!Active && IsAppFileExist)
			{
				if (-1 < AppPath.IndexOf("WindowsApps", StringComparison.CurrentCultureIgnoreCase))
				{
					if (!isApplyNoticeActive)
					{
						isApplyNoticeActive = true;
						Desc = "비활성화 된 정책입니다.";
					}
					return Brushes.get_Red();
				}
				if (-1 < AppPath.IndexOf("Windows Defender"))
				{
					return Brushes.get_Yellow();
				}
				return Brushes.get_Orange();
			}
			return Brushes.get_White();
		}
	}

	public SolidColorBrush ActionBlockColor
	{
		get
		{
			if (Active && IsAppFileExist && ActionAllow)
			{
				if (-1 < AppPath.IndexOf("WindowsApps", StringComparison.CurrentCultureIgnoreCase))
				{
					return Brushes.get_Red();
				}
				if (-1 < AppPath.IndexOf("Windows Defender", StringComparison.CurrentCultureIgnoreCase))
				{
					return Brushes.get_White();
				}
				return Brushes.get_Orange();
			}
			return Brushes.get_White();
		}
	}

	public SolidColorBrush ActiveColorBeta
	{
		get
		{
			bool flag = false;
			if (!IsAppFileExist)
			{
				flag = true;
			}
			if (flag)
			{
				return Brushes.get_OrangeRed();
			}
			return Brushes.get_WhiteSmoke();
		}
	}

	public Visibility AppFileExistVisibility => (Visibility)0;

	public string VState
	{
		get
		{
			return mVState;
		}
		set
		{
			mVState = value;
			NotifyPropertyChanged("VState");
		}
	}

	public string Desc
	{
		get
		{
			return mDesc;
		}
		set
		{
			mDesc = value;
			NotifyPropertyChanged("Desc");
		}
	}

	public event PropertyChangedEventHandler PropertyChanged;

	public static void Clear()
	{
		grpGlobalIndex = 0;
		globalSection.Clear();
	}

	private void NotifyPropertyChanged(string info)
	{
		if (this.PropertyChanged != null)
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(info));
		}
	}

	private string GetAppName()
	{
		string result = "";
		string[] array = Section.Split(new char[1] { '|' });
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i].StartsWith("Name=", StringComparison.CurrentCultureIgnoreCase))
			{
				result = array[i].Substring(5);
				break;
			}
		}
		return result;
	}

	private string GetPropertyName(string propName)
	{
		string result = "";
		string[] array = Section.Split(new char[1] { '|' });
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i].StartsWith(propName + "=", StringComparison.CurrentCultureIgnoreCase))
			{
				result = array[i].Substring(propName.Length + 1);
				break;
			}
		}
		return result;
	}

	private AppOutBlockList(string p)
	{
		string[] array = p.Split(new char[1] { ',' });
		globalSection.Add(array[0], this);
		Section = p;
	}

	private AppOutBlockList()
	{
	}

	public static AppOutBlockList GetOrCreate(string p)
	{
		if (globalSection == null)
		{
			globalSection = new Dictionary<string, AppOutBlockList>();
		}
		if (globalSection.ContainsKey(p))
		{
			return globalSection[p];
		}
		return new AppOutBlockList(p);
	}

	private bool RegUpdate(string beforeValue)
	{
		bool flag = false;
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Services\\SharedAccess\\Parameters\\FirewallPolicy\\FirewallRules", RegistryKeyPermissionCheck.ReadWriteSubTree);
		if (registryKey != null)
		{
			try
			{
				registryKey.SetValue(KeyName, KeyValue);
				flag = true;
			}
			catch (UnauthorizedAccessException ex)
			{
				Desc = ex.Message;
			}
			finally
			{
				if (!flag)
				{
					KeyValue = beforeValue;
				}
			}
		}
		return flag;
	}
}
