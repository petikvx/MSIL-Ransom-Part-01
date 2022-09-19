using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using Microsoft.Win32.TaskScheduler.V1Interop;
using Microsoft.Win32.TaskScheduler.V2Interop;

namespace Microsoft.Win32.TaskScheduler;

[ComVisible(false)]
[XmlSchemaProvider("GetV1SchemaFile")]
[XmlRoot("Task", Namespace = "http://schemas.microsoft.com/windows/2004/02/mit/task", IsNullable = false)]
public sealed class TaskDefinition : IDisposable, IXmlSerializable
{
	internal const string tns = "http://schemas.microsoft.com/windows/2004/02/mit/task";

	internal string v1Name = string.Empty;

	internal ITask v1Task;

	internal ITaskDefinition v2Def;

	private ActionCollection actions;

	private TaskPrincipal principal;

	private TaskRegistrationInfo regInfo;

	private TaskSettings settings;

	private TriggerCollection triggers;

	[XmlArray]
	[XmlArrayItem(ElementName = "Exec", IsNullable = true, Type = typeof(ExecAction))]
	public ActionCollection Actions
	{
		get
		{
			if (actions == null)
			{
				if (v2Def != null)
				{
					actions = new ActionCollection(v2Def);
				}
				else
				{
					actions = new ActionCollection(v1Task);
				}
			}
			return actions;
		}
	}

	public string Data
	{
		get
		{
			if (v2Def != null)
			{
				return v2Def.Data;
			}
			return TaskRegistrationInfo.GetTaskData(v1Task).ToString();
		}
		set
		{
			if (v2Def != null)
			{
				v2Def.Data = value;
			}
			else
			{
				TaskRegistrationInfo.SetTaskData(v1Task, value);
			}
		}
	}

	[XmlIgnore]
	public TaskCompatibility LowestSupportedVersion
	{
		get
		{
			if (!Settings.MaintenanceSettings.IsSet() && !Settings.Volatile)
			{
				if (Principal.ProcessTokenSidType == TaskProcessTokenSidType.Default && Principal.RequiredPrivileges.Count <= 0 && !Settings.DisallowStartOnRemoteAppSession && !Settings.UseUnifiedSchedulingEngine)
				{
					if (Principal.DisplayName == null && Principal.GroupId == null && Principal.LogonType != TaskLogonType.Group && Principal.LogonType != 0 && Principal.LogonType != TaskLogonType.S4U && Principal.RunLevel != TaskRunLevel.Highest && RegistrationInfo.SecurityDescriptorSddlForm == null && RegistrationInfo.Source == null && !(RegistrationInfo.URI != null) && !(RegistrationInfo.Version != new Version(1, 0)) && Settings.AllowDemandStart && Settings.AllowHardTerminate && Settings.MultipleInstances == TaskInstancesPolicy.IgnoreNew && !Settings.NetworkSettings.IsSet() && Settings.RestartCount == 0 && !(Settings.RestartInterval != TimeSpan.Zero) && !Settings.StartWhenAvailable && !Actions.ContainsType(typeof(EmailAction)) && !Actions.ContainsType(typeof(ShowMessageAction)) && !Actions.ContainsType(typeof(ComHandlerAction)) && !Triggers.ContainsType(typeof(EventTrigger)) && !Triggers.ContainsType(typeof(SessionStateChangeTrigger)) && !Triggers.ContainsType(typeof(RegistrationTrigger)))
					{
						return TaskCompatibility.V1;
					}
					return TaskCompatibility.V2;
				}
				return TaskCompatibility.V2_1;
			}
			return TaskCompatibility.V2_2;
		}
	}

	public TaskPrincipal Principal
	{
		get
		{
			if (principal == null)
			{
				if (v2Def != null)
				{
					principal = new TaskPrincipal(v2Def.Principal);
				}
				else
				{
					principal = new TaskPrincipal(v1Task);
				}
			}
			return principal;
		}
	}

	public TaskRegistrationInfo RegistrationInfo
	{
		get
		{
			if (regInfo == null)
			{
				if (v2Def != null)
				{
					regInfo = new TaskRegistrationInfo(v2Def.RegistrationInfo);
				}
				else
				{
					regInfo = new TaskRegistrationInfo(v1Task);
				}
			}
			return regInfo;
		}
	}

	public TaskSettings Settings
	{
		get
		{
			if (settings == null)
			{
				if (v2Def != null)
				{
					settings = new TaskSettings(v2Def.Settings);
				}
				else
				{
					settings = new TaskSettings(v1Task);
				}
			}
			return settings;
		}
	}

	[XmlArrayItem(ElementName = "CalendarTrigger", IsNullable = true, Type = typeof(CalendarTrigger))]
	[XmlArrayItem(ElementName = "IdleTrigger", IsNullable = true, Type = typeof(IdleTrigger))]
	[XmlArray]
	[XmlArrayItem(ElementName = "TimeTrigger", IsNullable = true, Type = typeof(TimeTrigger))]
	[XmlArrayItem(ElementName = "LogonTrigger", IsNullable = true, Type = typeof(LogonTrigger))]
	[XmlArrayItem(ElementName = "BootTrigger", IsNullable = true, Type = typeof(BootTrigger))]
	public TriggerCollection Triggers
	{
		get
		{
			if (triggers == null)
			{
				if (v2Def != null)
				{
					triggers = new TriggerCollection(v2Def);
				}
				else
				{
					triggers = new TriggerCollection(v1Task);
				}
			}
			return triggers;
		}
	}

	[XmlIgnore]
	public string XmlText
	{
		get
		{
			if (v2Def != null)
			{
				return v2Def.XmlText;
			}
			return XmlSerializationHelper.WriteObjectToXmlText(this);
		}
		set
		{
			if (v2Def != null)
			{
				v2Def.XmlText = value;
			}
			else
			{
				XmlSerializationHelper.ReadObjectFromXmlText(value, this);
			}
		}
	}

	internal TaskDefinition(ITask iTask, string name)
	{
		v1Task = iTask;
		v1Name = name;
	}

	internal TaskDefinition(ITaskDefinition iDef)
	{
		v2Def = iDef;
	}

	public bool CanUseUnifiedSchedulingEngine(bool throwExceptionWithDetails = false)
	{
		InvalidOperationException ex = new InvalidOperationException();
		ex.HelpLink = "http://msdn.microsoft.com/en-us/library/windows/desktop/aa384138(v=vs.85).aspx";
		InvalidOperationException ex2 = ex;
		bool flag = false;
		if (Principal.LogonType == TaskLogonType.InteractiveTokenOrPassword)
		{
			flag = true;
			if (!throwExceptionWithDetails)
			{
				return false;
			}
			ex2.Data.Add("Principal.LogonType", "== TaskLogonType.InteractiveTokenOrPassword");
		}
		if (Settings.MultipleInstances == TaskInstancesPolicy.StopExisting)
		{
			flag = true;
			if (!throwExceptionWithDetails)
			{
				return false;
			}
			ex2.Data.Add("Settings.MultipleInstances", "== TaskInstancesPolicy.StopExisting");
		}
		if (Settings.NetworkSettings.Id != Guid.Empty)
		{
			flag = true;
			if (!throwExceptionWithDetails)
			{
				return false;
			}
			ex2.Data.Add("Settings.NetworkSettings.Id", "!= Guid.Empty");
		}
		if (!Settings.AllowHardTerminate)
		{
			flag = true;
			if (!throwExceptionWithDetails)
			{
				return false;
			}
			ex2.Data.Add("Settings.AllowHardTerminate", "== false");
		}
		int num = 0;
		while (true)
		{
			if (num < Actions.Count)
			{
				Action action = Actions[num];
				if (action is EmailAction)
				{
					flag = true;
					if (!throwExceptionWithDetails)
					{
						return false;
					}
					ex2.Data.Add($"Actions[{num}]", "== typeof(EmailAction)");
				}
				else if (action is ShowMessageAction)
				{
					flag = true;
					if (!throwExceptionWithDetails)
					{
						break;
					}
					ex2.Data.Add($"Actions[{num}]", "== typeof(ShowMessageAction)");
				}
				num++;
				continue;
			}
			int num2 = 0;
			while (true)
			{
				if (num2 < Triggers.Count)
				{
					Trigger trigger = Triggers[num2];
					if (trigger is MonthlyTrigger)
					{
						flag = true;
						if (!throwExceptionWithDetails)
						{
							return false;
						}
						ex2.Data.Add($"Triggers[{num2}]", "== typeof(MonthlyTrigger)");
					}
					if (trigger is MonthlyDOWTrigger)
					{
						flag = true;
						if (!throwExceptionWithDetails)
						{
							return false;
						}
						ex2.Data.Add($"Triggers[{num2}]", "== typeof(MonthlyDOWTrigger)");
					}
					if (trigger.ExecutionTimeLimit != TimeSpan.Zero)
					{
						flag = true;
						if (!throwExceptionWithDetails)
						{
							return false;
						}
						ex2.Data.Add($"Triggers[{num2}].ExecutionTimeLimit", "!= TimeSpan.Zero");
					}
					if (trigger is ICalendarTrigger && trigger.Repetition.IsSet())
					{
						flag = true;
						if (!throwExceptionWithDetails)
						{
							return false;
						}
						ex2.Data.Add($"Triggers[{num2}].Repetition", "");
					}
					if (trigger is EventTrigger && ((EventTrigger)trigger).ValueQueries.Count > 0)
					{
						flag = true;
						if (!throwExceptionWithDetails)
						{
							break;
						}
						ex2.Data.Add($"Triggers[{num2}].ValueQueries.Count", "!= 0");
					}
					num2++;
					continue;
				}
				if (throwExceptionWithDetails)
				{
					throw ex2;
				}
				return !flag;
			}
			return false;
		}
		return false;
	}

	public void Dispose()
	{
		regInfo = null;
		triggers = null;
		settings = null;
		principal = null;
		actions = null;
		if (v2Def != null)
		{
			Marshal.ReleaseComObject(v2Def);
		}
		v1Task = null;
	}

	public static XmlSchemaComplexType GetV1SchemaFile(XmlSchemaSet xs)
	{
		XmlSchema xmlSchema = null;
		using (Stream input = Assembly.GetAssembly(typeof(TaskDefinition))!.GetManifestResourceStream("Microsoft.Win32.TaskScheduler.V1.TaskSchedulerV1Schema.xsd"))
		{
			XmlSerializer xmlSerializer = new XmlSerializer(typeof(XmlSchema));
			xmlSchema = (XmlSchema)xmlSerializer.Deserialize(XmlReader.Create(input));
			xs.Add(xmlSchema);
		}
		XmlQualifiedName name = new XmlQualifiedName("taskType", "http://schemas.microsoft.com/windows/2004/02/mit/task");
		return (XmlSchemaComplexType)xmlSchema.SchemaTypes[name];
	}

	public bool Validate(bool throwException = false)
	{
		InvalidOperationException ex = new InvalidOperationException();
		if (Settings.UseUnifiedSchedulingEngine)
		{
			try
			{
				CanUseUnifiedSchedulingEngine(throwException);
			}
			catch (InvalidOperationException ex2)
			{
				ex = ex2;
			}
		}
		if (LowestSupportedVersion > Settings.Compatibility)
		{
			ex.Data.Add("Settings.Compatibility", "is lower than what is required for the currently set properties.");
		}
		if (Settings.StartWhenAvailable)
		{
			foreach (Trigger trigger in Triggers)
			{
				if (!(trigger is ICalendarTrigger))
				{
					ex.Data.Add("Settings.StartWhenAvailable", "== true requires time-based triggers.");
				}
				else if (trigger.Repetition.Duration != TimeSpan.Zero && trigger.EndBoundary == DateTime.MaxValue)
				{
					ex.Data.Add("Settings.StartWhenAvailable", "== true requires time-based tasks with an end boundary or time-based tasks that are set to repeat infinitely.");
				}
			}
		}
		if (Settings.Compatibility < TaskCompatibility.V2)
		{
			foreach (Trigger trigger2 in Triggers)
			{
				if (trigger2.Repetition.Interval != TimeSpan.Zero && trigger2.Repetition.Interval >= trigger2.Repetition.Duration)
				{
					ex.Data.Add("Trigger.Repetition.Interval", ">= Trigger.Repetition.Duration under Task Scheduler 1.0.");
				}
			}
		}
		if (throwException)
		{
			throw ex;
		}
		return ex.Data.Count == 0;
	}

	internal void V1Save(string newName)
	{
		if (v1Task == null)
		{
			return;
		}
		Triggers.Bind();
		IPersistFile persistFile = (IPersistFile)v1Task;
		if (string.IsNullOrEmpty(newName) || newName == v1Name)
		{
			try
			{
				persistFile.Save(null, fRemember: false);
				persistFile = null;
				return;
			}
			catch
			{
			}
		}
		persistFile.GetCurFile(out var ppszFileName);
		File.Delete(ppszFileName);
		ppszFileName = Path.GetDirectoryName(ppszFileName) + Path.DirectorySeparatorChar + newName + Path.GetExtension(ppszFileName);
		File.Delete(ppszFileName);
		persistFile.Save(ppszFileName, fRemember: true);
		persistFile = null;
	}

	XmlSchema IXmlSerializable.GetSchema()
	{
		throw new NotImplementedException();
	}

	void IXmlSerializable.ReadXml(XmlReader reader)
	{
		reader.ReadStartElement("Task", "http://schemas.microsoft.com/windows/2004/02/mit/task");
		XmlSerializationHelper.ReadObjectProperties(reader, this);
		reader.ReadEndElement();
		if (Triggers.Count == 0 || Actions.Count != 1)
		{
			throw new XmlException("Invalid XML stream. Task element must include a Triggers and an Actions element to form a valid task.");
		}
	}

	void IXmlSerializable.WriteXml(XmlWriter writer)
	{
		XmlSerializationHelper.WriteObjectProperties(writer, this);
	}
}
