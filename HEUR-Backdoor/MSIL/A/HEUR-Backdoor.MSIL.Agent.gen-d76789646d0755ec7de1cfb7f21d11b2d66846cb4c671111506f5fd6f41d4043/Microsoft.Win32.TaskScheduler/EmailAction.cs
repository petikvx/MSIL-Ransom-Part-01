using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
using Microsoft.Win32.TaskScheduler.Properties;
using Microsoft.Win32.TaskScheduler.V2Interop;

namespace Microsoft.Win32.TaskScheduler;

[ComVisible(false)]
[XmlType(IncludeInSchema = false)]
public sealed class EmailAction : Action
{
	private NamedValueCollection nvc;

	public string Server
	{
		get
		{
			if (iAction != null)
			{
				return ((IEmailAction)iAction).Server;
			}
			if (!unboundValues.ContainsKey("Server"))
			{
				return null;
			}
			return (string)unboundValues["Server"];
		}
		set
		{
			if (iAction == null)
			{
				unboundValues["Server"] = value;
			}
			else
			{
				((IEmailAction)iAction).Server = value;
			}
		}
	}

	[DefaultValue(null)]
	public string Subject
	{
		get
		{
			if (iAction != null)
			{
				return ((IEmailAction)iAction).Subject;
			}
			if (!unboundValues.ContainsKey("Subject"))
			{
				return null;
			}
			return (string)unboundValues["Subject"];
		}
		set
		{
			if (iAction == null)
			{
				unboundValues["Subject"] = value;
			}
			else
			{
				((IEmailAction)iAction).Subject = value;
			}
		}
	}

	[DefaultValue(null)]
	public string To
	{
		get
		{
			if (iAction != null)
			{
				return ((IEmailAction)iAction).To;
			}
			if (!unboundValues.ContainsKey("To"))
			{
				return null;
			}
			return (string)unboundValues["To"];
		}
		set
		{
			if (iAction == null)
			{
				unboundValues["To"] = value;
			}
			else
			{
				((IEmailAction)iAction).To = value;
			}
		}
	}

	[DefaultValue(null)]
	public string Cc
	{
		get
		{
			if (iAction != null)
			{
				return ((IEmailAction)iAction).Cc;
			}
			if (!unboundValues.ContainsKey("Cc"))
			{
				return null;
			}
			return (string)unboundValues["Cc"];
		}
		set
		{
			if (iAction == null)
			{
				unboundValues["Cc"] = value;
			}
			else
			{
				((IEmailAction)iAction).Cc = value;
			}
		}
	}

	[DefaultValue(null)]
	public string Bcc
	{
		get
		{
			if (iAction != null)
			{
				return ((IEmailAction)iAction).Bcc;
			}
			if (!unboundValues.ContainsKey("Bcc"))
			{
				return null;
			}
			return (string)unboundValues["Bcc"];
		}
		set
		{
			if (iAction == null)
			{
				unboundValues["Bcc"] = value;
			}
			else
			{
				((IEmailAction)iAction).Bcc = value;
			}
		}
	}

	[DefaultValue(null)]
	public string ReplyTo
	{
		get
		{
			if (iAction != null)
			{
				return ((IEmailAction)iAction).ReplyTo;
			}
			if (!unboundValues.ContainsKey("ReplyTo"))
			{
				return null;
			}
			return (string)unboundValues["ReplyTo"];
		}
		set
		{
			if (iAction == null)
			{
				unboundValues["ReplyTo"] = value;
			}
			else
			{
				((IEmailAction)iAction).ReplyTo = value;
			}
		}
	}

	[DefaultValue(null)]
	public string From
	{
		get
		{
			if (iAction != null)
			{
				return ((IEmailAction)iAction).From;
			}
			if (!unboundValues.ContainsKey("From"))
			{
				return null;
			}
			return (string)unboundValues["From"];
		}
		set
		{
			if (iAction == null)
			{
				unboundValues["From"] = value;
			}
			else
			{
				((IEmailAction)iAction).From = value;
			}
		}
	}

	public NamedValueCollection HeaderFields
	{
		get
		{
			if (nvc == null)
			{
				if (iAction != null)
				{
					nvc = new NamedValueCollection(((IEmailAction)iAction).HeaderFields);
				}
				else
				{
					nvc = new NamedValueCollection();
				}
			}
			return nvc;
		}
	}

	[DefaultValue(null)]
	public string Body
	{
		get
		{
			if (iAction != null)
			{
				return ((IEmailAction)iAction).Body;
			}
			if (!unboundValues.ContainsKey("Body"))
			{
				return null;
			}
			return (string)unboundValues["Body"];
		}
		set
		{
			if (iAction == null)
			{
				unboundValues["Body"] = value;
			}
			else
			{
				((IEmailAction)iAction).Body = value;
			}
		}
	}

	public object[] Attachments
	{
		get
		{
			if (iAction != null)
			{
				return ((IEmailAction)iAction).Attachments;
			}
			if (!unboundValues.ContainsKey("Attachments"))
			{
				return null;
			}
			return (object[])unboundValues["Attachments"];
		}
		set
		{
			if (iAction == null)
			{
				unboundValues["Attachments"] = value;
			}
			else
			{
				((IEmailAction)iAction).Attachments = value;
			}
		}
	}

	public EmailAction()
	{
	}

	public EmailAction(string subject, string from, string to, string body, string mailServer)
	{
		Subject = subject;
		From = from;
		To = to;
		Body = body;
		Server = mailServer;
	}

	internal EmailAction(IEmailAction action)
	{
		iAction = action;
	}

	internal override void Bind(ITaskDefinition iTaskDef)
	{
		base.Bind(iTaskDef);
		if (nvc != null)
		{
			nvc.Bind(((IEmailAction)iAction).HeaderFields);
		}
	}

	protected override void CopyProperties(Action sourceAction)
	{
		if ((object)sourceAction.GetType() == GetType())
		{
			base.CopyProperties(sourceAction);
			if (((EmailAction)sourceAction).Attachments != null)
			{
				Attachments = (object[])((EmailAction)sourceAction).Attachments.Clone();
			}
			Bcc = ((EmailAction)sourceAction).Bcc;
			Body = ((EmailAction)sourceAction).Body;
			Cc = ((EmailAction)sourceAction).Cc;
			From = ((EmailAction)sourceAction).From;
			if (((EmailAction)sourceAction).nvc != null)
			{
				((EmailAction)sourceAction).HeaderFields.CopyTo(HeaderFields);
			}
			ReplyTo = ((EmailAction)sourceAction).ReplyTo;
			Server = ((EmailAction)sourceAction).Server;
			Subject = ((EmailAction)sourceAction).Subject;
			To = ((EmailAction)sourceAction).To;
		}
	}

	public override string ToString()
	{
		return string.Format(Resources.EmailAction, Subject, To, Cc, Bcc, From, ReplyTo, Body, Server, Id);
	}
}
