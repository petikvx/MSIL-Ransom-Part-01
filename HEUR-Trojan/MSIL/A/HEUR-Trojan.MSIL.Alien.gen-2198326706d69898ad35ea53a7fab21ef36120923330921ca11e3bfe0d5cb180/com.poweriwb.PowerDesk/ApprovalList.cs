using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;

namespace com.poweriwb.PowerDesk;

internal class ApprovalList : INotifyPropertyChanged
{
	public static Dictionary<string, ApprovalList> globalSection;

	private string mSection;

	private string mPath;

	private string mDanger;

	private string mType;

	private bool mIsY = false;

	private bool mIsN = false;

	private string mCheckSum = null;

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
			string text = mSection;
			char directorySeparatorChar = System.IO.Path.DirectorySeparatorChar;
			string[] array = text.Replace(directorySeparatorChar.ToString(), "|").Split(new char[1] { ',' });
			Type = ToTypeName(array[0]);
			Path = array[1].Replace("|", "/");
			CheckSum = array[2];
			lock (this)
			{
				GroupName = "Grp" + $"{++grpGlobalIndex:D4}";
			}
			NotifyPropertyChanged("Section");
			NotifyPropertyChanged("IsYN");
			NotifyPropertyChanged("Danger");
			NotifyPropertyChanged("Date");
			string isYN = IsYN;
			if (isYN != "" && !IsY && !IsN)
			{
				if (isYN == "Y")
				{
					IsY = true;
				}
				else
				{
					IsN = true;
				}
			}
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

	public string Danger
	{
		get
		{
			return App.iniApprovalList.ReadValue_Reg(Section, "DG", "");
		}
		set
		{
			mDanger = value;
			App.iniApprovalList.WriteValue_Reg(Section, "DG", value);
			NotifyPropertyChanged("Danger");
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

	public bool IsY
	{
		get
		{
			return mIsY;
		}
		set
		{
			mIsY = value;
			if (value)
			{
				mIsN = false;
				Date = DateTime.Now.ToString("yyyy-MM-dd");
				if (IsYN != "Y")
				{
					IsYN = "Y";
				}
			}
			NotifyPropertyChanged("IsY");
		}
	}

	public bool IsN
	{
		get
		{
			return mIsN;
		}
		set
		{
			mIsN = value;
			if (value)
			{
				mIsY = false;
				Date = DateTime.Now.ToString("yyyy-MM-dd");
				if (IsYN != "N")
				{
					IsYN = "N";
				}
			}
			NotifyPropertyChanged("IsN");
		}
	}

	public string Date
	{
		get
		{
			return App.iniApprovalList.ReadValue_Reg(Section, "Date", "");
		}
		set
		{
			if (App.iniApprovalList.ReadValue_Reg(Section, "Date", "") == "")
			{
				App.iniApprovalList.WriteValue_Reg(Section, "Date", value);
			}
			NotifyPropertyChanged("Date");
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

	public string IsYN
	{
		get
		{
			return App.iniApprovalList.ReadValue_Reg(Section, "YN", "");
		}
		set
		{
			if (App.iniApprovalList.ReadValue_Reg(Section, "YN", "") != value && value != "")
			{
				App.iniApprovalList.WriteValue_Reg(Section, "YN", value);
				if (value == "Y")
				{
					IsY = true;
				}
				else if (value == "N")
				{
					IsN = true;
				}
				NotifyPropertyChanged("IsYN");
			}
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

	private string ToTypeName(string p)
	{
		string text = "";
		return p switch
		{
			"P" => "Process", 
			"SU" => "Startuser", 
			"SC" => "StartCommon", 
			"T" => "Task", 
			"S" => "Service", 
			"RU" => "UserRun", 
			"RA" => "AllRun", 
			"BU" => "UserBHO", 
			"BA" => "AllBHO", 
			"ARO" => "AllRunOnce", 
			"URO" => "UserRunOnce", 
			_ => p, 
		};
	}

	private ApprovalList(string p)
	{
		globalSection.Add(p, this);
		Section = p;
		if (App.iniApprovalList.ReadValue_Reg(p, "Date", "") == "")
		{
			App.iniApprovalList.WriteValue_Reg(p, "YN", "");
		}
	}

	private ApprovalList()
	{
	}

	public static ApprovalList GetOrCreate(string p)
	{
		if (globalSection == null)
		{
			globalSection = new Dictionary<string, ApprovalList>();
		}
		if (globalSection.ContainsKey(p))
		{
			return globalSection[p];
		}
		return new ApprovalList(p);
	}

	private void NotifyPropertyChanged(string info)
	{
		if (this.PropertyChanged != null)
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(info));
		}
	}

	internal static ApprovalList getItemByGroupName(string strGroupname)
	{
		ApprovalList result = null;
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
		string section = Section;
		char directorySeparatorChar = System.IO.Path.DirectorySeparatorChar;
		stringBuilder.Append(section.Replace("|", directorySeparatorChar.ToString()));
		return stringBuilder;
	}
}
