using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Microsoft.Win32.TaskScheduler.V1Interop;
using Microsoft.Win32.TaskScheduler.V2Interop;

namespace Microsoft.Win32.TaskScheduler;

[Description("Provides access to the Task Scheduler service.")]
[DefaultProperty("TargetServer")]
[ToolboxItem(true)]
[ComVisible(false)]
public sealed class TaskService : Component, IDisposable, ISupportInitialize
{
	private class VersionConverter : TypeConverter
	{
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			if ((object)sourceType == typeof(string))
			{
				return true;
			}
			return base.CanConvertFrom(context, sourceType);
		}

		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			if (value is string)
			{
				return new Version(value as string);
			}
			return base.ConvertFrom(context, culture, value);
		}
	}

	internal static readonly bool hasV2 = Environment.OSVersion.Version >= new Version(6, 0);

	internal static readonly Version v1Ver = new Version(1, 1);

	internal ITaskScheduler v1TaskScheduler;

	internal TaskSchedulerClass v2TaskService;

	private bool forceV1;

	private bool initializing;

	private Version maxVer;

	private bool maxVerSet;

	private string targetServer;

	private bool targetServerSet;

	private string userDomain;

	private bool userDomainSet;

	private string userName;

	private bool userNameSet;

	private string userPassword;

	private bool userPasswordSet;

	private WindowsImpersonatedIdentity v1Impersonation;

	[Browsable(false)]
	public bool Connected
	{
		get
		{
			if (v2TaskService != null && v2TaskService.Connected)
			{
				return true;
			}
			return v1TaskScheduler != null;
		}
	}

	[Browsable(false)]
	[DefaultValue(null)]
	[Obsolete("This property has been superceded by the UserAccountDomin property and may not be available in future releases.")]
	public string ConnectedDomain
	{
		get
		{
			if (v2TaskService != null)
			{
				return v2TaskService.ConnectedDomain;
			}
			string[] array = v1Impersonation.Name.Split(new char[1] { '\\' });
			if (array.Length == 2)
			{
				return array[0];
			}
			return string.Empty;
		}
	}

	[Browsable(false)]
	[Obsolete("This property has been superceded by the UserName property and may not be available in future releases.")]
	[DefaultValue(null)]
	public string ConnectedUser
	{
		get
		{
			if (v2TaskService != null)
			{
				return v2TaskService.ConnectedUser;
			}
			string[] array = v1Impersonation.Name.Split(new char[1] { '\\' });
			if (array.Length == 2)
			{
				return array[1];
			}
			return array[0];
		}
	}

	[Category("Data")]
	[Description("Highest version of library that should be used.")]
	[TypeConverter(typeof(VersionConverter))]
	public Version HighestSupportedVersion
	{
		get
		{
			return maxVer;
		}
		set
		{
			maxVer = value;
			maxVerSet = true;
			bool flag;
			if ((flag = value <= v1Ver) != forceV1)
			{
				forceV1 = flag;
				Connect();
			}
		}
	}

	[Browsable(false)]
	public TaskFolder RootFolder => GetFolder("\\");

	[Description("The name of the computer to connect to.")]
	[DefaultValue(null)]
	[Category("Data")]
	public string TargetServer
	{
		get
		{
			if (!ShouldSerializeTargetServer())
			{
				return null;
			}
			return targetServer;
		}
		set
		{
			if (value == null || value.Trim() == string.Empty)
			{
				value = null;
			}
			if (string.Compare(value, targetServer, ignoreCase: true) != 0)
			{
				targetServerSet = true;
				targetServer = value;
				Connect();
			}
		}
	}

	[Category("Data")]
	[Description("The user account domain to be used when connecting.")]
	[DefaultValue(null)]
	public string UserAccountDomain
	{
		get
		{
			if (!ShouldSerializeUserAccountDomain())
			{
				return null;
			}
			return userDomain;
		}
		set
		{
			if (value == null || value.Trim() == string.Empty)
			{
				value = null;
			}
			if (string.Compare(value, userDomain, ignoreCase: true) != 0)
			{
				userDomainSet = true;
				userDomain = value;
				Connect();
			}
		}
	}

	[DefaultValue(null)]
	[Category("Data")]
	[Description("The user name to be used when connecting.")]
	public string UserName
	{
		get
		{
			if (!ShouldSerializeUserName())
			{
				return null;
			}
			return userName;
		}
		set
		{
			if (value == null || value.Trim() == string.Empty)
			{
				value = null;
			}
			if (string.Compare(value, userName, ignoreCase: true) != 0)
			{
				userNameSet = true;
				userName = value;
				Connect();
			}
		}
	}

	[Category("Data")]
	[DefaultValue(null)]
	[Description("The user password to be used when connecting.")]
	public string UserPassword
	{
		get
		{
			return userPassword;
		}
		set
		{
			if (value == null || value.Trim() == string.Empty)
			{
				value = null;
			}
			if (string.Compare(value, userPassword, ignoreCase: true) != 0)
			{
				userPasswordSet = true;
				userPassword = value;
				Connect();
			}
		}
	}

	protected override bool CanRaiseEvents => false;

	public TaskService()
	{
		ResetHighestSupportedVersion();
		Connect();
	}

	public TaskService(string targetServer, string userName = null, string accountDomain = null, string password = null, bool forceV1 = false)
	{
		BeginInit();
		TargetServer = targetServer;
		UserName = userName;
		UserAccountDomain = accountDomain;
		UserPassword = password;
		this.forceV1 = forceV1;
		ResetHighestSupportedVersion();
		EndInit();
	}

	public Task AddTask(string path, Trigger trigger, Action action, string UserId = null, string Password = null, TaskLogonType LogonType = TaskLogonType.InteractiveToken)
	{
		TaskDefinition taskDefinition = NewTask();
		taskDefinition.Triggers.Add(trigger);
		taskDefinition.Actions.Add(action);
		return RootFolder.RegisterTaskDefinition(path, taskDefinition, TaskCreation.CreateOrUpdate, UserId, Password, LogonType);
	}

	public Task[] FindAllTasks(Regex name, bool searchAllFolders = true)
	{
		List<Task> results = new List<Task>();
		FindTaskInFolder(RootFolder, name, ref results, searchAllFolders);
		return results.ToArray();
	}

	public Task FindTask(string name, bool searchAllFolders = true)
	{
		Task[] array = FindAllTasks(new Wildcard(name), searchAllFolders);
		if (array.Length > 0)
		{
			return array[0];
		}
		return null;
	}

	public TaskFolder GetFolder(string folderName)
	{
		if (v2TaskService == null)
		{
			return new TaskFolder(this);
		}
		return new TaskFolder(this, v2TaskService.GetFolder(folderName));
	}

	public RunningTaskCollection GetRunningTasks(bool includeHidden = true)
	{
		if (v2TaskService == null)
		{
			return new RunningTaskCollection(this);
		}
		return new RunningTaskCollection(this, v2TaskService.GetRunningTasks(includeHidden ? 1 : 0));
	}

	public Task GetTask(string taskPath)
	{
		Task result = null;
		if (v2TaskService != null)
		{
			IRegisteredTask task = GetTask(v2TaskService, taskPath);
			if (task != null)
			{
				result = new Task(this, task);
			}
		}
		else
		{
			ITask task2 = GetTask(v1TaskScheduler, taskPath);
			if (task2 != null)
			{
				result = new Task(this, task2);
			}
		}
		return result;
	}

	public void BeginInit()
	{
		initializing = true;
	}

	public void EndInit()
	{
		initializing = false;
		Connect();
	}

	public TaskDefinition NewTask()
	{
		if (v2TaskService != null)
		{
			return new TaskDefinition(v2TaskService.NewTask(0u));
		}
		Guid riid = Marshal.GenerateGuidForType(typeof(ITask));
		Guid rclsid = Marshal.GenerateGuidForType(typeof(CTask));
		string text = "Temp" + Guid.NewGuid().ToString("B");
		return new TaskDefinition(v1TaskScheduler.NewWorkItem(text, ref rclsid, ref riid), text);
	}

	public TaskDefinition NewTaskFromFile(string xmlFile)
	{
		if (v2TaskService == null)
		{
			throw new NotV1SupportedException();
		}
		TaskDefinition taskDefinition = new TaskDefinition(v2TaskService.NewTask(0u));
		taskDefinition.XmlText = File.ReadAllText(xmlFile);
		return taskDefinition;
	}

	public void StartSystemTaskSchedulerManager()
	{
		if (Environment.UserInteractive)
		{
			Process.Start("control.exe", "schedtasks");
		}
	}

	internal static IRegisteredTask GetTask(ITaskService iSvc, string name)
	{
		ITaskFolder taskFolder = null;
		try
		{
			taskFolder = iSvc.GetFolder("\\");
			return taskFolder.GetTask(name);
		}
		catch
		{
			return null;
		}
		finally
		{
			if (taskFolder != null)
			{
				Marshal.ReleaseComObject(taskFolder);
			}
		}
	}

	internal static ITask GetTask(ITaskScheduler iSvc, string name)
	{
		Guid riid = Marshal.GenerateGuidForType(typeof(ITask));
		try
		{
			return iSvc.Activate(name, ref riid);
		}
		catch
		{
		}
		return null;
	}

	protected override void Dispose(bool disposing)
	{
		if (v2TaskService != null)
		{
			Marshal.ReleaseComObject(v2TaskService);
			v2TaskService = null;
		}
		if (v1TaskScheduler != null)
		{
			Marshal.ReleaseComObject(v1TaskScheduler);
			v1TaskScheduler = null;
		}
		if (v1Impersonation != null)
		{
			v1Impersonation.Dispose();
			v1Impersonation = null;
		}
		base.Dispose(disposing);
	}

	private void Connect()
	{
		ResetUnsetProperties();
		if (initializing || base.DesignMode)
		{
			return;
		}
		if ((!string.IsNullOrEmpty(userDomain) && !string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(userPassword)) || (string.IsNullOrEmpty(userDomain) && string.IsNullOrEmpty(userName) && string.IsNullOrEmpty(userPassword)))
		{
			if (v2TaskService != null || v1TaskScheduler != null)
			{
				Dispose(disposing: true);
			}
			if (hasV2 && !forceV1)
			{
				v2TaskService = new TaskSchedulerClass();
				if (!string.IsNullOrEmpty(targetServer))
				{
					if (targetServer.StartsWith("\\"))
					{
						targetServer = targetServer.TrimStart(new char[1] { '\\' });
					}
					if (targetServer.Equals(Environment.MachineName, StringComparison.CurrentCultureIgnoreCase))
					{
						targetServer = null;
					}
				}
				v2TaskService.Connect(targetServer, userName, userDomain, userPassword);
				targetServer = v2TaskService.TargetServer;
				userName = v2TaskService.ConnectedUser;
				userDomain = v2TaskService.ConnectedDomain;
				maxVer = GetV2Version();
				return;
			}
			v1Impersonation = new WindowsImpersonatedIdentity(userName, userDomain, userPassword);
			CTaskScheduler cTaskScheduler = new CTaskScheduler();
			v1TaskScheduler = (ITaskScheduler)cTaskScheduler;
			if (!string.IsNullOrEmpty(targetServer))
			{
				if (!targetServer.StartsWith("\\\\"))
				{
					targetServer = "\\\\" + targetServer;
				}
			}
			else
			{
				targetServer = null;
			}
			v1TaskScheduler.SetTargetComputer(targetServer);
			targetServer = v1TaskScheduler.GetTargetComputer();
			maxVer = v1Ver;
			return;
		}
		throw new ArgumentException("A username, password, and domain must be provided.");
	}

	private bool FindTaskInFolder(TaskFolder fld, Regex taskName, ref List<Task> results, bool recurse = true)
	{
		results.AddRange(fld.GetTasks(taskName));
		if (recurse)
		{
			foreach (TaskFolder subFolder in fld.SubFolders)
			{
				if (FindTaskInFolder(subFolder, taskName, ref results, recurse))
				{
					return true;
				}
			}
		}
		return false;
	}

	private Version GetV2Version()
	{
		uint highestVersion = v2TaskService.HighestVersion;
		return new Version((int)(highestVersion >> 16), (int)(highestVersion & 0xFFFF));
	}

	private void ResetUnsetProperties()
	{
		if (!maxVerSet)
		{
			ResetHighestSupportedVersion();
		}
		if (!targetServerSet)
		{
			targetServer = null;
		}
		if (!userDomainSet)
		{
			userDomain = null;
		}
		if (!userNameSet)
		{
			userName = null;
		}
		if (!userPasswordSet)
		{
			userPassword = null;
		}
	}

	private void ResetHighestSupportedVersion()
	{
		if (Connected)
		{
			maxVer = ((v2TaskService != null) ? GetV2Version() : v1Ver);
		}
		else
		{
			maxVer = ((!hasV2) ? v1Ver : ((Environment.OSVersion.Version.Minor > 0) ? new Version(1, 3) : new Version(1, 2)));
		}
	}

	private bool ShouldSerializeHighestSupportedVersion()
	{
		if (hasV2)
		{
			return maxVer <= v1Ver;
		}
		return false;
	}

	private bool ShouldSerializeTargetServer()
	{
		if (targetServer != null)
		{
			return !targetServer.Trim(new char[1] { '\\' }).Equals(Environment.MachineName.Trim(new char[1] { '\\' }), StringComparison.InvariantCultureIgnoreCase);
		}
		return false;
	}

	private bool ShouldSerializeUserAccountDomain()
	{
		if (userDomain != null)
		{
			return !userDomain.Equals(Environment.UserDomainName, StringComparison.InvariantCultureIgnoreCase);
		}
		return false;
	}

	private bool ShouldSerializeUserName()
	{
		if (userName != null)
		{
			return !userName.Equals(Environment.UserName, StringComparison.InvariantCultureIgnoreCase);
		}
		return false;
	}
}
