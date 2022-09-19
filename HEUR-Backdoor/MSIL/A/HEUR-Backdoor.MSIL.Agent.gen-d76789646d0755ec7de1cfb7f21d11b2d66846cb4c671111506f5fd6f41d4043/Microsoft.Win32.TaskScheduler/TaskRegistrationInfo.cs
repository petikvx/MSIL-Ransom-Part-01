using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.AccessControl;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using Microsoft.Win32.TaskScheduler.V1Interop;
using Microsoft.Win32.TaskScheduler.V2Interop;

namespace Microsoft.Win32.TaskScheduler;

[ComVisible(false)]
[XmlRoot("RegistrationInfo", Namespace = "http://schemas.microsoft.com/windows/2004/02/mit/task", IsNullable = true)]
public sealed class TaskRegistrationInfo : IDisposable, IXmlSerializable
{
	private ITask v1Task;

	private IRegistrationInfo v2RegInfo;

	[DefaultValue(null)]
	public string Author
	{
		get
		{
			if (v2RegInfo != null)
			{
				return v2RegInfo.Author;
			}
			return v1Task.GetCreator();
		}
		set
		{
			if (v2RegInfo != null)
			{
				v2RegInfo.Author = value;
			}
			else
			{
				v1Task.SetCreator(value);
			}
		}
	}

	[XmlIgnore]
	[DefaultValue(typeof(DateTime), "0001-01-01T00:00:00")]
	public DateTime Date
	{
		get
		{
			if (v2RegInfo != null)
			{
				string date = v2RegInfo.Date;
				if (!string.IsNullOrEmpty(date))
				{
					return DateTime.Parse(date, Trigger.DefaultDateCulture);
				}
				return DateTime.MinValue;
			}
			string v1Path = Task.GetV1Path(v1Task);
			if (!string.IsNullOrEmpty(v1Path) && File.Exists(v1Path))
			{
				return File.GetLastWriteTime(v1Path);
			}
			return DateTime.MinValue;
		}
		set
		{
			if (v2RegInfo != null)
			{
				v2RegInfo.Date = value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'FFFK", Trigger.DefaultDateCulture);
				return;
			}
			string v1Path = Task.GetV1Path(v1Task);
			if (string.IsNullOrEmpty(v1Path) || !File.Exists(v1Path))
			{
				throw new NotV1SupportedException("This property cannot be set on an unregistered task.");
			}
			File.SetLastWriteTime(v1Path, value);
		}
	}

	[DefaultValue(null)]
	public string Description
	{
		get
		{
			if (v2RegInfo != null)
			{
				return v2RegInfo.Description;
			}
			return v1Task.GetComment();
		}
		set
		{
			if (v2RegInfo != null)
			{
				v2RegInfo.Description = value;
			}
			else
			{
				v1Task.SetComment(value);
			}
		}
	}

	[DefaultValue(null)]
	public string Documentation
	{
		get
		{
			if (v2RegInfo != null)
			{
				return v2RegInfo.Documentation;
			}
			return GetTaskData(v1Task).ToString();
		}
		set
		{
			if (v2RegInfo != null)
			{
				v2RegInfo.Documentation = value;
			}
			else
			{
				SetTaskData(v1Task, value);
			}
		}
	}

	[XmlIgnore]
	public GenericSecurityDescriptor SecurityDescriptor
	{
		get
		{
			return new RawSecurityDescriptor(SecurityDescriptorSddlForm);
		}
		set
		{
			SecurityDescriptorSddlForm = value?.GetSddlForm(AccessControlSections.All);
		}
	}

	[DefaultValue(null)]
	[XmlIgnore]
	public string SecurityDescriptorSddlForm
	{
		get
		{
			object obj = null;
			if (v2RegInfo != null)
			{
				obj = v2RegInfo.SecurityDescriptor;
			}
			return obj?.ToString();
		}
		set
		{
			if (v2RegInfo == null)
			{
				throw new NotV1SupportedException();
			}
			v2RegInfo.SecurityDescriptor = value;
		}
	}

	[DefaultValue(null)]
	[XmlIgnore]
	public string Source
	{
		get
		{
			if (v2RegInfo != null)
			{
				return v2RegInfo.Source;
			}
			return null;
		}
		set
		{
			if (v2RegInfo == null)
			{
				throw new NotV1SupportedException();
			}
			v2RegInfo.Source = value;
		}
	}

	[DefaultValue(null)]
	[XmlIgnore]
	public Uri URI
	{
		get
		{
			string text = null;
			if (v2RegInfo != null)
			{
				text = v2RegInfo.URI;
			}
			if (string.IsNullOrEmpty(text))
			{
				return null;
			}
			return new Uri(text);
		}
		set
		{
			if (v2RegInfo == null)
			{
				throw new NotV1SupportedException();
			}
			v2RegInfo.URI = ((value == null) ? null : value.ToString());
		}
	}

	[DefaultValue(typeof(Version), "1.0")]
	[XmlIgnore]
	public Version Version
	{
		get
		{
			if (v2RegInfo != null && v2RegInfo.Version != null)
			{
				try
				{
					return new Version(v2RegInfo.Version);
				}
				catch
				{
				}
			}
			return new Version(1, 0);
		}
		set
		{
			if (v2RegInfo == null)
			{
				throw new NotV1SupportedException();
			}
			v2RegInfo.Version = ((value == null) ? null : value.ToString());
		}
	}

	[XmlIgnore]
	public string XmlText
	{
		get
		{
			if (v2RegInfo != null)
			{
				return v2RegInfo.XmlText;
			}
			return XmlSerializationHelper.WriteObjectToXmlText(this);
		}
		set
		{
			if (v2RegInfo != null)
			{
				v2RegInfo.XmlText = value;
			}
			else
			{
				XmlSerializationHelper.ReadObjectFromXmlText(value, this);
			}
		}
	}

	internal TaskRegistrationInfo(IRegistrationInfo iRegInfo)
	{
		v2RegInfo = iRegInfo;
	}

	internal TaskRegistrationInfo(ITask iTask)
	{
		v1Task = iTask;
	}

	public void Dispose()
	{
		v1Task = null;
		if (v2RegInfo != null)
		{
			Marshal.ReleaseComObject(v2RegInfo);
		}
	}

	internal static object GetTaskData(ITask v1Task)
	{
		try
		{
			v1Task.GetWorkItemData(out var DataLen, out var Data);
			byte[] array = new byte[DataLen];
			Marshal.Copy(Data, array, 0, DataLen);
			MemoryStream serializationStream = new MemoryStream(array, writable: false);
			BinaryFormatter binaryFormatter = new BinaryFormatter();
			return binaryFormatter.Deserialize(serializationStream);
		}
		catch
		{
		}
		return string.Empty;
	}

	internal static void SetTaskData(ITask v1Task, object value)
	{
		if (value == null)
		{
			v1Task.SetWorkItemData(0, null);
			return;
		}
		BinaryFormatter binaryFormatter = new BinaryFormatter();
		MemoryStream memoryStream = new MemoryStream();
		binaryFormatter.Serialize(memoryStream, value);
		v1Task.SetWorkItemData((ushort)memoryStream.Length, memoryStream.ToArray());
	}

	XmlSchema IXmlSerializable.GetSchema()
	{
		throw new NotImplementedException();
	}

	void IXmlSerializable.ReadXml(XmlReader reader)
	{
		if (!reader.IsEmptyElement)
		{
			reader.ReadStartElement("RegistrationInfo", "http://schemas.microsoft.com/windows/2004/02/mit/task");
			XmlSerializationHelper.ReadObjectProperties(reader, this);
			reader.ReadEndElement();
		}
		else
		{
			reader.Skip();
		}
	}

	void IXmlSerializable.WriteXml(XmlWriter writer)
	{
		XmlSerializationHelper.WriteObjectProperties(writer, this);
	}
}
