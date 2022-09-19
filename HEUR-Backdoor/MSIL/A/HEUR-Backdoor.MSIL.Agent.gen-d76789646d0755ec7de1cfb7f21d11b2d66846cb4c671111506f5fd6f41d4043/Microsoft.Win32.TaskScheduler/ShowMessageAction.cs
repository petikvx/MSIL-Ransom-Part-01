using System.Runtime.InteropServices;
using System.Xml.Serialization;
using Microsoft.Win32.TaskScheduler.Properties;
using Microsoft.Win32.TaskScheduler.V2Interop;

namespace Microsoft.Win32.TaskScheduler;

[XmlType(IncludeInSchema = false)]
[ComVisible(false)]
public sealed class ShowMessageAction : Action
{
	public string Title
	{
		get
		{
			if (iAction != null)
			{
				return ((IShowMessageAction)iAction).Title;
			}
			if (!unboundValues.ContainsKey("Title"))
			{
				return null;
			}
			return (string)unboundValues["Title"];
		}
		set
		{
			if (iAction == null)
			{
				unboundValues["Title"] = value;
			}
			else
			{
				((IShowMessageAction)iAction).Title = value;
			}
		}
	}

	[XmlElement("Body")]
	public string MessageBody
	{
		get
		{
			if (iAction != null)
			{
				return ((IShowMessageAction)iAction).MessageBody;
			}
			if (!unboundValues.ContainsKey("MessageBody"))
			{
				return null;
			}
			return (string)unboundValues["MessageBody"];
		}
		set
		{
			if (iAction == null)
			{
				unboundValues["MessageBody"] = value;
			}
			else
			{
				((IShowMessageAction)iAction).MessageBody = value;
			}
		}
	}

	public ShowMessageAction()
	{
	}

	public ShowMessageAction(string messageBody, string title)
	{
		MessageBody = messageBody;
		Title = title;
	}

	internal ShowMessageAction(IShowMessageAction action)
	{
		iAction = action;
	}

	protected override void CopyProperties(Action sourceAction)
	{
		if ((object)sourceAction.GetType() == GetType())
		{
			base.CopyProperties(sourceAction);
			Title = ((ShowMessageAction)sourceAction).Title;
			MessageBody = ((ShowMessageAction)sourceAction).MessageBody;
		}
	}

	public override string ToString()
	{
		return string.Format(Resources.ShowMessageAction, Title, MessageBody, Id);
	}
}
