using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Security;
using System.Security.AccessControl;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Microsoft.Win32.TaskScheduler.V1Interop;
using Microsoft.Win32.TaskScheduler.V2Interop;

namespace Microsoft.Win32.TaskScheduler;

[ComVisible(false)]
[XmlType(IncludeInSchema = false)]
public class Task : IDisposable
{
	internal ITask v1Task;

	private static readonly DateTime v2InvalidDate = new DateTime(1899, 12, 30);

	private IRegisteredTask v2Task;

	private TaskDefinition myTD;

	public TaskDefinition Definition
	{
		get
		{
			if (myTD == null)
			{
				if (v2Task != null)
				{
					myTD = new TaskDefinition(v2Task.Definition);
				}
				else
				{
					myTD = new TaskDefinition(v1Task, Name);
				}
			}
			return myTD;
		}
	}

	public bool Enabled
	{
		get
		{
			if (v2Task != null)
			{
				return v2Task.Enabled;
			}
			return (v1Task.GetFlags() & TaskFlags.Disabled) != TaskFlags.Disabled;
		}
		set
		{
			if (v2Task != null)
			{
				v2Task.Enabled = value;
				return;
			}
			TaskFlags flags = v1Task.GetFlags();
			if (!value)
			{
				v1Task.SetFlags(flags |= TaskFlags.Disabled);
			}
			else
			{
				v1Task.SetFlags(flags &= ~TaskFlags.Disabled);
			}
			Definition.V1Save(null);
		}
	}

	public bool IsActive
	{
		get
		{
			DateTime now = DateTime.Now;
			if (Definition.Settings.Enabled)
			{
				int count = Definition.Triggers.Count;
				for (int i = 0; i < count; i++)
				{
					Trigger trigger = Definition.Triggers[i];
					if (trigger.Enabled && now >= trigger.StartBoundary && now < trigger.EndBoundary)
					{
						if (!(trigger is ICalendarTrigger))
						{
							return true;
						}
						if (DateTime.MinValue != NextRunTime)
						{
							return true;
						}
					}
				}
			}
			return false;
		}
	}

	public DateTime LastRunTime
	{
		get
		{
			if (v2Task != null)
			{
				DateTime lastRunTime = v2Task.LastRunTime;
				if (!(lastRunTime == v2InvalidDate))
				{
					return lastRunTime;
				}
				return DateTime.MinValue;
			}
			return v1Task.GetMostRecentRunTime();
		}
	}

	public int LastTaskResult
	{
		get
		{
			if (v2Task != null)
			{
				return v2Task.LastTaskResult;
			}
			return (int)v1Task.GetExitCode();
		}
	}

	public string Name
	{
		get
		{
			if (v2Task != null)
			{
				return v2Task.Name;
			}
			return System.IO.Path.GetFileNameWithoutExtension(GetV1Path(v1Task));
		}
	}

	public DateTime NextRunTime
	{
		get
		{
			if (v2Task != null)
			{
				DateTime dateTime = v2Task.NextRunTime;
				if (dateTime == DateTime.MinValue || dateTime == v2InvalidDate)
				{
					DateTime[] runTimes = GetRunTimes(DateTime.Now, DateTime.MaxValue, 1u);
					dateTime = ((runTimes.Length > 0) ? runTimes[0] : DateTime.MinValue);
				}
				if (!(dateTime == v2InvalidDate))
				{
					return dateTime;
				}
				return DateTime.MinValue;
			}
			return v1Task.GetNextRunTime();
		}
	}

	public int NumberOfMissedRuns
	{
		get
		{
			if (v2Task == null)
			{
				throw new NotV1SupportedException();
			}
			return v2Task.NumberOfMissedRuns;
		}
	}

	public string Path
	{
		get
		{
			if (v2Task != null)
			{
				return v2Task.Path;
			}
			return GetV1Path(v1Task);
		}
	}

	public GenericSecurityDescriptor SecurityDescriptor
	{
		get
		{
			string securityDescriptorSddlForm = GetSecurityDescriptorSddlForm(AccessControlSections.All);
			return new RawSecurityDescriptor(securityDescriptorSddlForm);
		}
		set
		{
			SetSecurityDescriptorSddlForm(value.GetSddlForm(AccessControlSections.All), AccessControlSections.All);
		}
	}

	public virtual TaskState State
	{
		get
		{
			if (v2Task != null)
			{
				return v2Task.State;
			}
			V1Reactivate();
			switch (v1Task.GetStatus())
			{
			case TaskStatus.Running:
				return TaskState.Running;
			case TaskStatus.Disabled:
				return TaskState.Disabled;
			case TaskStatus.Ready:
			case TaskStatus.NeverRun:
			case TaskStatus.NoMoreRuns:
			case TaskStatus.Terminated:
				return TaskState.Ready;
			default:
				return TaskState.Unknown;
			}
		}
	}

	public TaskService TaskService { get; private set; }

	public string Xml
	{
		get
		{
			if (v2Task != null)
			{
				return v2Task.Xml;
			}
			return Definition.XmlText;
		}
	}

	internal Task(TaskService svc, ITask iTask)
	{
		TaskService = svc;
		v1Task = iTask;
	}

	internal Task(TaskService svc, IRegisteredTask iTask)
	{
		TaskService = svc;
		v2Task = iTask;
	}

	public void Dispose()
	{
		if (v2Task != null)
		{
			Marshal.ReleaseComObject(v2Task);
		}
		v1Task = null;
	}

	public void Export(string outputFileName)
	{
		File.WriteAllText(outputFileName, Xml, Encoding.Unicode);
	}

	public RunningTaskCollection GetInstances()
	{
		if (v2Task == null)
		{
			throw new NotV1SupportedException();
		}
		return new RunningTaskCollection(TaskService, v2Task.GetInstances(0));
	}

	public DateTime[] GetRunTimes(DateTime start, DateTime end, uint count = 0u)
	{
		SystemTime pstStart = new SystemTime(start);
		SystemTime pstEnd = new SystemTime(end);
		IntPtr pRunTimes = IntPtr.Zero;
		if (v2Task != null)
		{
			v2Task.GetRunTimes(ref pstStart, ref pstEnd, ref count, ref pRunTimes);
		}
		else
		{
			ushort Count = (ushort)((count == 0 || count > 1440) ? 1440 : ((ushort)count));
			v1Task.GetRunTimes(ref pstStart, ref pstEnd, ref Count, ref pRunTimes);
			count = Count;
		}
		DateTime[] array = new DateTime[count];
		int num = Marshal.SizeOf(typeof(SystemTime));
		for (int i = 0; i < count; i++)
		{
			IntPtr ptr = new IntPtr(pRunTimes.ToInt64() + i * num);
			ref DateTime reference = ref array[i];
			reference = (SystemTime)Marshal.PtrToStructure(ptr, typeof(SystemTime));
		}
		Marshal.FreeCoTaskMem(pRunTimes);
		return array;
	}

	public string GetSecurityDescriptorSddlForm(AccessControlSections includeSections)
	{
		if (v2Task == null)
		{
			throw new NotV1SupportedException();
		}
		return v2Task.GetSecurityDescriptor((int)includeSections);
	}

	public void RegisterChanges()
	{
		if (Definition.Principal.LogonType == TaskLogonType.InteractiveTokenOrPassword || Definition.Principal.LogonType == TaskLogonType.Password)
		{
			throw new SecurityException("Tasks which have been registered previously with stored passwords must use the TaskFolder.RegisterTaskDefinition method for updates.");
		}
		TaskService.GetFolder(System.IO.Path.GetDirectoryName(Path)).RegisterTaskDefinition(Name, Definition);
	}

	public RunningTask Run(params string[] parameters)
	{
		if (v2Task != null)
		{
			if (parameters != null && parameters.Length > 32)
			{
				throw new ArgumentOutOfRangeException("parameters", "A maximum of 32 values is allowed.");
			}
			return new RunningTask(TaskService, v2Task, v2Task.Run(parameters));
		}
		v1Task.Run();
		return new RunningTask(TaskService, v1Task);
	}

	public RunningTask RunEx(TaskRunFlags flags, int sessionID, string user, params string[] parameters)
	{
		if (v2Task == null)
		{
			throw new NotV1SupportedException();
		}
		return new RunningTask(TaskService, v2Task, v2Task.RunEx(parameters, (int)flags, sessionID, user));
	}

	public void SetSecurityDescriptorSddlForm(string sddlForm, AccessControlSections includeSections)
	{
		if (v2Task != null)
		{
			v2Task.SetSecurityDescriptor(sddlForm, (int)includeSections);
		}
		throw new NotV1SupportedException();
	}

	public bool ShowEditor()
	{
		try
		{
			Assembly assembly = Assembly.LoadFrom("Microsoft.Win32.TaskSchedulerEditor.dll");
			if ((object)assembly != null)
			{
				Type type = assembly.GetType("Microsoft.Win32.TaskScheduler.TaskEditDialog", throwOnError: false, ignoreCase: false);
				if ((object)type != null)
				{
					object obj = Activator.CreateInstance(type, this, true, true);
					if (obj != null)
					{
						MethodInfo method = type.GetMethod("ShowDialog", Type.EmptyTypes);
						if ((object)method != null)
						{
							object value = method.Invoke(obj, null);
							int num = Convert.ToInt32(value);
							return num == 1;
						}
					}
				}
			}
		}
		catch
		{
		}
		return false;
	}

	public void ShowPropertyPage()
	{
		if (v1Task == null)
		{
			throw new NotV2SupportedException();
		}
		v1Task.EditWorkItem(IntPtr.Zero, 0u);
	}

	public void Stop()
	{
		if (v2Task != null)
		{
			v2Task.Stop(0);
		}
		else
		{
			v1Task.Terminate();
		}
	}

	public override string ToString()
	{
		return Name;
	}

	internal void V1Reactivate()
	{
		ITask task = TaskService.GetTask(TaskService.v1TaskScheduler, GetV1Path(v1Task));
		if (task != null)
		{
			v1Task = task;
		}
	}

	internal static string GetV1Path(ITask v1Task)
	{
		string ppszFileName = string.Empty;
		try
		{
			IPersistFile persistFile = (IPersistFile)v1Task;
			persistFile.GetCurFile(out ppszFileName);
			return ppszFileName;
		}
		catch (Exception ex)
		{
			throw ex;
		}
	}

	internal static TimeSpan StringToTimeSpan(string input)
	{
		if (!string.IsNullOrEmpty(input))
		{
			try
			{
				return XmlConvert.ToTimeSpan(input);
			}
			catch
			{
			}
		}
		return TimeSpan.Zero;
	}

	internal static string TimeSpanToString(TimeSpan span)
	{
		if (span != TimeSpan.Zero)
		{
			try
			{
				return XmlConvert.ToString(span);
			}
			catch
			{
			}
		}
		return null;
	}
}
