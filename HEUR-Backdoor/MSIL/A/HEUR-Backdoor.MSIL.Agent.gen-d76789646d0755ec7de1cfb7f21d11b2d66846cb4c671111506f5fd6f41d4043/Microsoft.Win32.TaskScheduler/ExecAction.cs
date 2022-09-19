using System.ComponentModel;
using System.IO;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
using Microsoft.Win32.TaskScheduler.Properties;
using Microsoft.Win32.TaskScheduler.V1Interop;
using Microsoft.Win32.TaskScheduler.V2Interop;

namespace Microsoft.Win32.TaskScheduler;

[ComVisible(false)]
[XmlRoot("Exec", Namespace = "http://schemas.microsoft.com/windows/2004/02/mit/task", IsNullable = false)]
public sealed class ExecAction : Action
{
	private ITask v1Task;

	internal override bool Bound
	{
		get
		{
			if (v1Task != null)
			{
				return true;
			}
			return base.Bound;
		}
	}

	[XmlIgnore]
	[XmlAttribute(AttributeName = "id", DataType = "ID")]
	[DefaultValue(null)]
	public override string Id
	{
		get
		{
			if (v1Task != null)
			{
				return System.IO.Path.GetFileNameWithoutExtension(Task.GetV1Path(v1Task)) + "_Action";
			}
			return base.Id;
		}
		set
		{
			if (v1Task != null)
			{
				throw new NotV1SupportedException();
			}
			base.Id = value;
		}
	}

	[XmlElement("Command")]
	public string Path
	{
		get
		{
			if (v1Task != null)
			{
				return v1Task.GetApplicationName();
			}
			if (iAction != null)
			{
				return ((IExecAction)iAction).Path;
			}
			if (!unboundValues.ContainsKey("Path"))
			{
				return null;
			}
			return (string)unboundValues["Path"];
		}
		set
		{
			if (v1Task != null)
			{
				v1Task.SetApplicationName(value);
			}
			else if (iAction != null)
			{
				((IExecAction)iAction).Path = value;
			}
			else
			{
				unboundValues["Path"] = value;
			}
		}
	}

	[DefaultValue("")]
	public string Arguments
	{
		get
		{
			if (v1Task != null)
			{
				return v1Task.GetParameters();
			}
			if (iAction != null)
			{
				return ((IExecAction)iAction).Arguments;
			}
			if (!unboundValues.ContainsKey("Arguments"))
			{
				return null;
			}
			return (string)unboundValues["Arguments"];
		}
		set
		{
			if (v1Task != null)
			{
				v1Task.SetParameters(value);
			}
			else if (iAction != null)
			{
				((IExecAction)iAction).Arguments = value;
			}
			else
			{
				unboundValues["Arguments"] = value;
			}
		}
	}

	[DefaultValue("")]
	public string WorkingDirectory
	{
		get
		{
			if (v1Task != null)
			{
				return v1Task.GetWorkingDirectory();
			}
			if (iAction != null)
			{
				return ((IExecAction)iAction).WorkingDirectory;
			}
			if (!unboundValues.ContainsKey("WorkingDirectory"))
			{
				return null;
			}
			return (string)unboundValues["WorkingDirectory"];
		}
		set
		{
			if (v1Task != null)
			{
				v1Task.SetWorkingDirectory(value);
			}
			else if (iAction != null)
			{
				((IExecAction)iAction).WorkingDirectory = value;
			}
			else
			{
				unboundValues["WorkingDirectory"] = value;
			}
		}
	}

	public ExecAction()
	{
	}

	public ExecAction(string path, string arguments = null, string workingDirectory = null)
	{
		Path = path;
		Arguments = arguments;
		WorkingDirectory = workingDirectory;
	}

	internal ExecAction(ITask task)
	{
		v1Task = task;
	}

	internal ExecAction(IExecAction action)
	{
		iAction = action;
	}

	internal override void Bind(ITask v1Task)
	{
		object value = null;
		unboundValues.TryGetValue("Path", out value);
		v1Task.SetApplicationName((value == null) ? string.Empty : value.ToString());
		value = null;
		unboundValues.TryGetValue("Arguments", out value);
		v1Task.SetParameters((value == null) ? string.Empty : value.ToString());
		value = null;
		unboundValues.TryGetValue("WorkingDirectory", out value);
		v1Task.SetWorkingDirectory((value == null) ? string.Empty : value.ToString());
	}

	protected override void CopyProperties(Action sourceAction)
	{
		if ((object)sourceAction.GetType() == GetType())
		{
			base.CopyProperties(sourceAction);
			Path = ((ExecAction)sourceAction).Path;
			Arguments = ((ExecAction)sourceAction).Arguments;
			WorkingDirectory = ((ExecAction)sourceAction).WorkingDirectory;
		}
	}

	public override string ToString()
	{
		return string.Format(Resources.ExecAction, Path, Arguments, WorkingDirectory, Id);
	}
}
