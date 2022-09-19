using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
using Microsoft.Win32.TaskScheduler.V1Interop;
using Microsoft.Win32.TaskScheduler.V2Interop;

namespace Microsoft.Win32.TaskScheduler;

[ComVisible(false)]
public abstract class Action : IDisposable, ICloneable
{
	internal IAction iAction;

	protected Dictionary<string, object> unboundValues = new Dictionary<string, object>();

	internal virtual bool Bound => iAction != null;

	[XmlIgnore]
	public TaskActionType ActionType
	{
		get
		{
			if (iAction != null)
			{
				return iAction.Type;
			}
			if (this is ComHandlerAction)
			{
				return TaskActionType.ComHandler;
			}
			if (this is ShowMessageAction)
			{
				return TaskActionType.ShowMessage;
			}
			if (this is EmailAction)
			{
				return TaskActionType.SendEmail;
			}
			return TaskActionType.Execute;
		}
	}

	[DefaultValue(null)]
	[XmlAttribute(AttributeName = "id", DataType = "ID")]
	public virtual string Id
	{
		get
		{
			if (iAction != null)
			{
				return iAction.Id;
			}
			if (!unboundValues.ContainsKey("Id"))
			{
				return null;
			}
			return (string)unboundValues["Id"];
		}
		set
		{
			if (iAction == null)
			{
				unboundValues["Id"] = value;
			}
			else
			{
				iAction.Id = value;
			}
		}
	}

	internal virtual void Bind(ITask iTask)
	{
	}

	internal virtual void Bind(ITaskDefinition iTaskDef)
	{
		IActionCollection actions = iTaskDef.Actions;
		switch (GetType().Name)
		{
		case "ShowMessageAction":
			iAction = actions.Create(TaskActionType.ShowMessage);
			goto IL_008a;
		case "EmailAction":
			iAction = actions.Create(TaskActionType.SendEmail);
			goto IL_008a;
		case "ExecAction":
			iAction = actions.Create(TaskActionType.Execute);
			goto IL_008a;
		case "ComHandlerAction":
			iAction = actions.Create(TaskActionType.ComHandler);
			goto IL_008a;
		default:
			{
				throw new ArgumentException();
			}
			IL_008a:
			Marshal.ReleaseComObject(actions);
			foreach (string key in unboundValues.Keys)
			{
				try
				{
					iAction.GetType().InvokeMember(key, BindingFlags.SetProperty, null, iAction, new object[1] { unboundValues[key] });
				}
				catch (TargetInvocationException ex)
				{
					throw ex.InnerException;
				}
				catch
				{
				}
			}
			unboundValues.Clear();
			break;
		}
	}

	public object Clone()
	{
		Action action = CreateAction(ActionType);
		action.CopyProperties(this);
		return action;
	}

	protected virtual void CopyProperties(Action sourceAction)
	{
		Id = sourceAction.Id;
	}

	public virtual void Dispose()
	{
		if (iAction != null)
		{
			Marshal.ReleaseComObject(iAction);
		}
	}

	public override string ToString()
	{
		return Id;
	}

	public virtual string ToString(CultureInfo culture)
	{
		using (new CultureSwitcher(culture))
		{
			return ToString();
		}
	}

	internal static Action CreateAction(IAction iAction)
	{
		return iAction.Type switch
		{
			TaskActionType.ComHandler => new ComHandlerAction((IComHandlerAction)iAction), 
			TaskActionType.SendEmail => new EmailAction((IEmailAction)iAction), 
			TaskActionType.ShowMessage => new ShowMessageAction((IShowMessageAction)iAction), 
			_ => new ExecAction((IExecAction)iAction), 
		};
	}

	public static Action CreateAction(TaskActionType actionType)
	{
		return actionType switch
		{
			TaskActionType.ComHandler => new ComHandlerAction(), 
			TaskActionType.SendEmail => new EmailAction(), 
			TaskActionType.ShowMessage => new ShowMessageAction(), 
			_ => new ExecAction(), 
		};
	}
}
