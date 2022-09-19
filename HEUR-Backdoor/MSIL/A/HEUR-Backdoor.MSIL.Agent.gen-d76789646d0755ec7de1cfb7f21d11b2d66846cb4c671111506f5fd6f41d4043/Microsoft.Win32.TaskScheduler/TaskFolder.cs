using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text.RegularExpressions;
using Microsoft.Win32.TaskScheduler.V1Interop;
using Microsoft.Win32.TaskScheduler.V2Interop;

namespace Microsoft.Win32.TaskScheduler;

[ComVisible(false)]
public sealed class TaskFolder : IDisposable
{
	private ITaskScheduler v1List;

	private ITaskFolder v2Folder;

	public string Name
	{
		get
		{
			if (v2Folder != null)
			{
				return v2Folder.Name;
			}
			return "\\";
		}
	}

	public string Path
	{
		get
		{
			if (v2Folder != null)
			{
				return v2Folder.Path;
			}
			return "\\";
		}
	}

	public GenericSecurityDescriptor SecurityDescriptor
	{
		get
		{
			return GetSecurityDescriptor(AccessControlSections.All);
		}
		set
		{
			SetSecurityDescriptor(value, AccessControlSections.All);
		}
	}

	public TaskFolderCollection SubFolders
	{
		get
		{
			if (v2Folder != null)
			{
				return new TaskFolderCollection(this, v2Folder.GetFolders(0));
			}
			return new TaskFolderCollection();
		}
	}

	public TaskCollection Tasks => GetTasks();

	public TaskService TaskService { get; private set; }

	internal TaskFolder(TaskService svc)
	{
		TaskService = svc;
		v1List = svc.v1TaskScheduler;
	}

	internal TaskFolder(TaskService svc, ITaskFolder iFldr)
	{
		TaskService = svc;
		v2Folder = iFldr;
	}

	public void Dispose()
	{
		if (v2Folder != null)
		{
			Marshal.ReleaseComObject(v2Folder);
		}
		v1List = null;
	}

	public TaskFolder CreateFolder(string subFolderName, GenericSecurityDescriptor sd)
	{
		return CreateFolder(subFolderName, sd.GetSddlForm(AccessControlSections.All));
	}

	public TaskFolder CreateFolder(string subFolderName, string sddlForm = null)
	{
		if (v2Folder == null)
		{
			throw new NotV1SupportedException();
		}
		return new TaskFolder(TaskService, v2Folder.CreateFolder(subFolderName, sddlForm));
	}

	public void DeleteFolder(string subFolderName)
	{
		if (v2Folder == null)
		{
			throw new NotV1SupportedException();
		}
		v2Folder.DeleteFolder(subFolderName, 0);
	}

	public void DeleteTask(string Name)
	{
		if (v2Folder != null)
		{
			v2Folder.DeleteTask(Name, 0);
			return;
		}
		if (!Name.EndsWith(".job", StringComparison.CurrentCultureIgnoreCase))
		{
			Name += ".job";
		}
		v1List.Delete(Name);
	}

	public GenericSecurityDescriptor GetSecurityDescriptor(AccessControlSections includeSections)
	{
		return new RawSecurityDescriptor(GetSecurityDescriptorSddlForm(includeSections));
	}

	public string GetSecurityDescriptorSddlForm(AccessControlSections includeSections)
	{
		if (v2Folder == null)
		{
			throw new NotV1SupportedException();
		}
		return v2Folder.GetSecurityDescriptor((int)includeSections);
	}

	public TaskCollection GetTasks(Regex filter = null)
	{
		if (v2Folder != null)
		{
			return new TaskCollection(this, v2Folder.GetTasks(1), filter);
		}
		return new TaskCollection(TaskService, filter);
	}

	public Task ImportTask(string Path, string xmlFile)
	{
		return RegisterTask(Path, File.ReadAllText(xmlFile));
	}

	public Task RegisterTask(string Path, string XmlText, TaskCreation createType = TaskCreation.CreateOrUpdate, string UserId = null, string password = null, TaskLogonType LogonType = TaskLogonType.S4U, string sddl = null)
	{
		if (v2Folder != null)
		{
			return new Task(TaskService, v2Folder.RegisterTask(Path, XmlText, (int)createType, UserId, password, LogonType, sddl));
		}
		try
		{
			TaskDefinition taskDefinition = TaskService.NewTask();
			XmlSerializationHelper.ReadObjectFromXmlText(XmlText, taskDefinition);
			return RegisterTaskDefinition(Path, taskDefinition, createType, (UserId == null) ? taskDefinition.Principal.ToString() : UserId, password, (LogonType == TaskLogonType.S4U) ? taskDefinition.Principal.LogonType : LogonType, sddl);
		}
		catch
		{
			throw;
		}
	}

	public Task RegisterTaskDefinition(string Path, TaskDefinition definition)
	{
		return RegisterTaskDefinition(Path, definition, TaskCreation.CreateOrUpdate, (definition.Principal.LogonType == TaskLogonType.Group) ? definition.Principal.GroupId : definition.Principal.UserId, null, definition.Principal.LogonType);
	}

	public Task RegisterTaskDefinition(string Path, TaskDefinition definition, TaskCreation createType, string UserId, string password = null, TaskLogonType LogonType = TaskLogonType.S4U, string sddl = null)
	{
		if (v2Folder != null)
		{
			return new Task(TaskService, v2Folder.RegisterTaskDefinition(Path, definition.v2Def, (int)createType, UserId, password, LogonType, sddl));
		}
		TaskFlags taskFlags = definition.v1Task.GetFlags();
		if (LogonType == TaskLogonType.InteractiveTokenOrPassword && string.IsNullOrEmpty(password))
		{
			LogonType = TaskLogonType.InteractiveToken;
		}
		if (string.IsNullOrEmpty(UserId))
		{
			UserId = WindowsIdentity.GetCurrent().Name;
		}
		switch (LogonType)
		{
		case TaskLogonType.Password:
		{
			using (CoTaskMemString coTaskMemString2 = new CoTaskMemString(password))
			{
				definition.v1Task.SetAccountInformation(UserId, coTaskMemString2.DangerousGetHandle());
			}
			break;
		}
		case TaskLogonType.InteractiveToken:
			taskFlags |= TaskFlags.Interactive | TaskFlags.RunOnlyIfLoggedOn;
			if (string.IsNullOrEmpty(UserId))
			{
				UserId = WindowsIdentity.GetCurrent().Name;
			}
			definition.v1Task.SetAccountInformation(UserId, IntPtr.Zero);
			break;
		case TaskLogonType.None:
		case TaskLogonType.S4U:
		case TaskLogonType.Group:
			throw new NotV1SupportedException("This LogonType is not supported on Task Scheduler 1.0.");
		case TaskLogonType.ServiceAccount:
			taskFlags &= ~(TaskFlags.Interactive | TaskFlags.RunOnlyIfLoggedOn);
			definition.v1Task.SetAccountInformation((string.IsNullOrEmpty(UserId) || UserId.Equals("SYSTEM", StringComparison.CurrentCultureIgnoreCase)) ? string.Empty : UserId, IntPtr.Zero);
			break;
		case TaskLogonType.InteractiveTokenOrPassword:
		{
			taskFlags |= TaskFlags.Interactive;
			using (CoTaskMemString coTaskMemString = new CoTaskMemString(password))
			{
				definition.v1Task.SetAccountInformation(UserId, coTaskMemString.DangerousGetHandle());
			}
			break;
		}
		}
		definition.v1Task.SetFlags(taskFlags);
		switch (createType)
		{
		case TaskCreation.IgnoreRegistrationTriggers:
			throw new NotV1SupportedException("Registration triggers are not available on Task Scheduler 1.0.");
		case TaskCreation.DontAddPrincipalAce:
			throw new NotV1SupportedException("Security settings are not available on Task Scheduler 1.0.");
		case TaskCreation.ValidateOnly:
			throw new NotV1SupportedException("Xml validation not available on Task Scheduler 1.0.");
		case TaskCreation.Create:
		case TaskCreation.Update:
		case TaskCreation.CreateOrUpdate:
		case TaskCreation.Disable:
			if (createType == TaskCreation.Disable)
			{
				definition.Settings.Enabled = false;
			}
			definition.V1Save(Path);
			break;
		}
		return new Task(TaskService, definition.v1Task);
	}

	public void SetSecurityDescriptor(GenericSecurityDescriptor sd, AccessControlSections includeSections)
	{
		SetSecurityDescriptorSddlForm(sd.GetSddlForm(includeSections), includeSections);
	}

	public void SetSecurityDescriptorSddlForm(string sddlForm, AccessControlSections includeSections)
	{
		if (v2Folder == null)
		{
			throw new NotV1SupportedException();
		}
		v2Folder.SetSecurityDescriptor(sddlForm, (int)includeSections);
	}

	public override string ToString()
	{
		return Path;
	}
}
