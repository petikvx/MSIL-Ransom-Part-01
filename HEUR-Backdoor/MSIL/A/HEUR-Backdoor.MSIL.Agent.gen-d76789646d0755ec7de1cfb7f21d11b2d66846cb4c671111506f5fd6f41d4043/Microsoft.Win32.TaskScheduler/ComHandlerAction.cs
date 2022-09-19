using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
using Microsoft.Win32.TaskScheduler.Properties;
using Microsoft.Win32.TaskScheduler.V2Interop;

namespace Microsoft.Win32.TaskScheduler;

[ComVisible(false)]
[XmlType(IncludeInSchema = false)]
public sealed class ComHandlerAction : Action
{
	public Guid ClassId
	{
		get
		{
			if (iAction != null)
			{
				return new Guid(((IComHandlerAction)iAction).ClassId);
			}
			if (!unboundValues.ContainsKey("ClassId"))
			{
				return Guid.Empty;
			}
			return (Guid)unboundValues["ClassId"];
		}
		set
		{
			if (iAction == null)
			{
				unboundValues["ClassId"] = value.ToString();
			}
			else
			{
				((IComHandlerAction)iAction).ClassId = value.ToString();
			}
		}
	}

	[DefaultValue(null)]
	public string Data
	{
		get
		{
			if (iAction != null)
			{
				return ((IComHandlerAction)iAction).Data;
			}
			if (!unboundValues.ContainsKey("Data"))
			{
				return null;
			}
			return (string)unboundValues["Data"];
		}
		set
		{
			if (iAction == null)
			{
				unboundValues["Data"] = value;
			}
			else
			{
				((IComHandlerAction)iAction).Data = value;
			}
		}
	}

	public ComHandlerAction()
	{
	}

	public ComHandlerAction(Guid classId, string data)
	{
		ClassId = classId;
		Data = data;
	}

	internal ComHandlerAction(IComHandlerAction action)
	{
		iAction = action;
	}

	protected override void CopyProperties(Action sourceAction)
	{
		if ((object)sourceAction.GetType() == GetType())
		{
			base.CopyProperties(sourceAction);
			ClassId = ((ComHandlerAction)sourceAction).ClassId;
			Data = ((ComHandlerAction)sourceAction).Data;
		}
	}

	public override string ToString()
	{
		return string.Format(Resources.ComHandlerAction, ClassId, Data, Id);
	}
}
