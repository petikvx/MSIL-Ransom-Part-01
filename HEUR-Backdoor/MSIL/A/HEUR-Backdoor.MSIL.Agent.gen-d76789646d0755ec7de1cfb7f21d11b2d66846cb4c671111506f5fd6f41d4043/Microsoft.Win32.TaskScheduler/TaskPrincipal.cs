using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using Microsoft.Win32.TaskScheduler.Properties;
using Microsoft.Win32.TaskScheduler.V1Interop;
using Microsoft.Win32.TaskScheduler.V2Interop;

namespace Microsoft.Win32.TaskScheduler;

[ComVisible(false)]
[XmlRoot("Principals", Namespace = "http://schemas.microsoft.com/windows/2004/02/mit/task", IsNullable = true)]
public sealed class TaskPrincipal : IDisposable, IXmlSerializable
{
	private const string localSystemAcct = "SYSTEM";

	private ITask v1Task;

	private IPrincipal v2Principal;

	private IPrincipal2 v2Principal2;

	private TaskPrincipalPrivileges reqPriv;

	[DefaultValue(null)]
	[XmlIgnore]
	public string DisplayName
	{
		get
		{
			if (v2Principal != null)
			{
				return v2Principal.DisplayName;
			}
			return null;
		}
		set
		{
			if (v2Principal == null)
			{
				throw new NotV1SupportedException();
			}
			v2Principal.DisplayName = value;
		}
	}

	[DefaultValue(null)]
	[XmlIgnore]
	public string GroupId
	{
		get
		{
			if (v2Principal != null)
			{
				return v2Principal.GroupId;
			}
			return null;
		}
		set
		{
			if (v2Principal != null)
			{
				if (string.IsNullOrEmpty(value))
				{
					value = null;
				}
				else
				{
					v2Principal.UserId = null;
					v2Principal.LogonType = TaskLogonType.Group;
				}
				v2Principal.GroupId = value;
				return;
			}
			throw new NotV1SupportedException();
		}
	}

	[XmlIgnore]
	[XmlAttribute(AttributeName = "id", DataType = "ID")]
	[DefaultValue(null)]
	public string Id
	{
		get
		{
			if (v2Principal != null)
			{
				return v2Principal.Id;
			}
			return Resources.TaskDefaultPrincipal;
		}
		set
		{
			if (v2Principal == null)
			{
				throw new NotV1SupportedException();
			}
			v2Principal.Id = value;
		}
	}

	[DefaultValue(typeof(TaskLogonType), "None")]
	public TaskLogonType LogonType
	{
		get
		{
			if (v2Principal != null)
			{
				return v2Principal.LogonType;
			}
			if (UserId == "SYSTEM")
			{
				return TaskLogonType.ServiceAccount;
			}
			if ((v1Task.GetFlags() & TaskFlags.RunOnlyIfLoggedOn) == TaskFlags.RunOnlyIfLoggedOn)
			{
				return TaskLogonType.InteractiveToken;
			}
			return TaskLogonType.InteractiveTokenOrPassword;
		}
		set
		{
			if (v2Principal != null)
			{
				v2Principal.LogonType = value;
				return;
			}
			if (value != TaskLogonType.Group && value != 0 && value != TaskLogonType.S4U)
			{
				TaskFlags flags = v1Task.GetFlags();
				flags = ((value != TaskLogonType.InteractiveToken) ? (flags & ~TaskFlags.RunOnlyIfLoggedOn) : (flags | TaskFlags.RunOnlyIfLoggedOn));
				v1Task.SetFlags(flags);
				return;
			}
			throw new NotV1SupportedException();
		}
	}

	[XmlIgnore]
	[DefaultValue(typeof(TaskProcessTokenSidType), "Default")]
	public TaskProcessTokenSidType ProcessTokenSidType
	{
		get
		{
			if (v2Principal2 != null)
			{
				return v2Principal2.ProcessTokenSidType;
			}
			return TaskProcessTokenSidType.Default;
		}
		set
		{
			if (v2Principal2 == null)
			{
				throw new NotSupportedPriorToException(TaskCompatibility.V2_1);
			}
			v2Principal2.ProcessTokenSidType = value;
		}
	}

	[XmlIgnore]
	public TaskPrincipalPrivileges RequiredPrivileges
	{
		get
		{
			if (reqPriv == null)
			{
				reqPriv = new TaskPrincipalPrivileges(v2Principal2);
			}
			return reqPriv;
		}
	}

	[DefaultValue(typeof(TaskRunLevel), "LUA")]
	[XmlIgnore]
	public TaskRunLevel RunLevel
	{
		get
		{
			if (v2Principal != null)
			{
				return v2Principal.RunLevel;
			}
			return TaskRunLevel.Highest;
		}
		set
		{
			if (v2Principal == null)
			{
				throw new NotV1SupportedException();
			}
			v2Principal.RunLevel = value;
		}
	}

	[DefaultValue("")]
	public string UserId
	{
		get
		{
			if (v2Principal != null)
			{
				return v2Principal.UserId;
			}
			try
			{
				string text = v1Task.GetAccountInformation();
				return string.IsNullOrEmpty(text) ? "SYSTEM" : text;
			}
			catch
			{
				return null;
			}
		}
		set
		{
			if (v2Principal != null)
			{
				if (string.IsNullOrEmpty(value))
				{
					value = null;
				}
				else
				{
					v2Principal.GroupId = null;
				}
				v2Principal.UserId = value;
			}
			else
			{
				if (value.Equals("SYSTEM", StringComparison.CurrentCultureIgnoreCase))
				{
					value = "";
				}
				v1Task.SetAccountInformation(value, IntPtr.Zero);
			}
		}
	}

	internal TaskPrincipal(IPrincipal iPrincipal)
	{
		v2Principal = iPrincipal;
		try
		{
			v2Principal2 = (IPrincipal2)v2Principal;
		}
		catch
		{
		}
	}

	internal TaskPrincipal(ITask iTask)
	{
		v1Task = iTask;
	}

	public void Dispose()
	{
		if (v2Principal != null)
		{
			Marshal.ReleaseComObject(v2Principal);
		}
		v1Task = null;
	}

	public override string ToString()
	{
		if (LogonType != TaskLogonType.Group)
		{
			return UserId;
		}
		return GroupId;
	}

	public static bool ValidateAccountForSidType(string acct, TaskProcessTokenSidType sidType)
	{
		string[] array = new string[4] { "NETWORK SERVICE", "LOCAL SERVICE", "S-1-5-19", "S-1-5-20" };
		if (sidType != TaskProcessTokenSidType.Default && Array.Find(array, (string id) => id.Equals(acct, StringComparison.InvariantCultureIgnoreCase)) == null)
		{
			return false;
		}
		return true;
	}

	XmlSchema IXmlSerializable.GetSchema()
	{
		throw new NotImplementedException();
	}

	void IXmlSerializable.ReadXml(XmlReader reader)
	{
		reader.ReadStartElement("Principals", "http://schemas.microsoft.com/windows/2004/02/mit/task");
		reader.Read();
		while (reader.MoveToContent() == XmlNodeType.Element)
		{
			string localName;
			if ((localName = reader.LocalName) != null && localName == "Principal")
			{
				reader.Read();
				XmlSerializationHelper.ReadObjectProperties(reader, this);
				reader.ReadEndElement();
			}
			else
			{
				reader.Skip();
			}
		}
		reader.ReadEndElement();
	}

	void IXmlSerializable.WriteXml(XmlWriter writer)
	{
		if (!string.IsNullOrEmpty(ToString()) || LogonType != 0)
		{
			writer.WriteStartElement("Principal");
			XmlSerializationHelper.WriteObjectProperties(writer, this);
			writer.WriteEndElement();
		}
	}
}
