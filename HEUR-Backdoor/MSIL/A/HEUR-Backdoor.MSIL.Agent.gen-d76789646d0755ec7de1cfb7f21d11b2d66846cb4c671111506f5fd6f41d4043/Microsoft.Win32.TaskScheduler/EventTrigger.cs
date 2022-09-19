using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Serialization;
using Microsoft.Win32.TaskScheduler.Properties;
using Microsoft.Win32.TaskScheduler.V2Interop;

namespace Microsoft.Win32.TaskScheduler;

[ComVisible(false)]
[XmlType(IncludeInSchema = false)]
public sealed class EventTrigger : Trigger, ITriggerDelay
{
	private NamedValueCollection nvc;

	[DefaultValue(typeof(TimeSpan), "00:00:00")]
	public TimeSpan Delay
	{
		get
		{
			if (v2Trigger != null)
			{
				return Task.StringToTimeSpan(((IEventTrigger)v2Trigger).Delay);
			}
			if (!unboundValues.ContainsKey("Delay"))
			{
				return TimeSpan.Zero;
			}
			return (TimeSpan)unboundValues["Delay"];
		}
		set
		{
			if (v2Trigger != null)
			{
				((IEventTrigger)v2Trigger).Delay = Task.TimeSpanToString(value);
			}
			else
			{
				unboundValues["Delay"] = value;
			}
		}
	}

	[DefaultValue(null)]
	public string Subscription
	{
		get
		{
			if (v2Trigger != null)
			{
				return ((IEventTrigger)v2Trigger).Subscription;
			}
			if (!unboundValues.ContainsKey("Subscription"))
			{
				return null;
			}
			return (string)unboundValues["Subscription"];
		}
		set
		{
			if (v2Trigger != null)
			{
				((IEventTrigger)v2Trigger).Subscription = value;
			}
			else
			{
				unboundValues["Subscription"] = value;
			}
		}
	}

	public NamedValueCollection ValueQueries
	{
		get
		{
			if (nvc == null)
			{
				if (v2Trigger == null)
				{
					nvc = new NamedValueCollection();
				}
				else
				{
					nvc = new NamedValueCollection(((IEventTrigger)v2Trigger).ValueQueries);
				}
			}
			return nvc;
		}
	}

	public EventTrigger()
		: base(TaskTriggerType.Event)
	{
	}

	public EventTrigger(string log, string source, int? eventId)
		: this()
	{
		SetBasic(log, source, eventId);
	}

	internal EventTrigger(ITrigger iTrigger)
		: base(iTrigger)
	{
	}

	public override void CopyProperties(Trigger sourceTrigger)
	{
		base.CopyProperties(sourceTrigger);
		if ((object)sourceTrigger.GetType() == GetType())
		{
			Subscription = ((EventTrigger)sourceTrigger).Subscription;
			((EventTrigger)sourceTrigger).ValueQueries.CopyTo(ValueQueries);
		}
	}

	public bool GetBasic(out string log, out string source, out int? eventId)
	{
		log = (source = null);
		eventId = null;
		if (!string.IsNullOrEmpty(Subscription))
		{
			using MemoryStream input = new MemoryStream(Encoding.UTF8.GetBytes(Subscription));
			using XmlTextReader xmlTextReader = new XmlTextReader(input);
			try
			{
				xmlTextReader.MoveToContent();
				xmlTextReader.ReadStartElement("QueryList");
				if (xmlTextReader.Name == "Query" && xmlTextReader.MoveToAttribute("Path"))
				{
					string value = xmlTextReader.Value;
					if (xmlTextReader.MoveToElement() && xmlTextReader.ReadToDescendant("Select") && value.Equals(xmlTextReader["Path"], StringComparison.InvariantCultureIgnoreCase))
					{
						string input2 = xmlTextReader.ReadString();
						Match match = Regex.Match(input2, "\\*(?:\\[System\\[(?:Provider\\[\\@Name='(?<s>[^']+)'\\])?(?:\\s+and\\s+)?(?:EventID=(?<e>\\d+))?\\]\\])", RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.Singleline | RegexOptions.IgnorePatternWhitespace);
						if (match.Success)
						{
							log = value;
							if (match.Groups["s"].Success)
							{
								source = match.Groups["s"].Value;
							}
							if (match.Groups["e"].Success)
							{
								eventId = Convert.ToInt32(match.Groups["e"].Value);
							}
							return true;
						}
					}
				}
			}
			catch
			{
			}
		}
		return false;
	}

	public void SetBasic(string log, string source, int? eventId)
	{
		StringBuilder stringBuilder = new StringBuilder();
		if (string.IsNullOrEmpty(log))
		{
			throw new ArgumentNullException("log");
		}
		stringBuilder.AppendFormat("<QueryList><Query Id=\"0\" Path=\"{0}\"><Select Path=\"{0}\">*", log);
		bool flag = !string.IsNullOrEmpty(source);
		bool hasValue = eventId.HasValue;
		if (flag || hasValue)
		{
			stringBuilder.Append("[System[");
			if (flag)
			{
				stringBuilder.AppendFormat("Provider[@Name='{0}']", source);
			}
			if (flag && hasValue)
			{
				stringBuilder.Append(" and ");
			}
			if (hasValue)
			{
				stringBuilder.AppendFormat("EventID={0}", eventId.Value);
			}
			stringBuilder.Append("]]");
		}
		stringBuilder.Append("</Select></Query></QueryList>");
		ValueQueries.Clear();
		Subscription = stringBuilder.ToString();
	}

	internal override void Bind(ITaskDefinition iTaskDef)
	{
		base.Bind(iTaskDef);
		if (nvc != null)
		{
			nvc.Bind(((IEventTrigger)v2Trigger).ValueQueries);
		}
	}

	protected override string V2GetTriggerString()
	{
		if (GetBasic(out var log, out var source, out var eventId))
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat(Resources.TriggerEventBasic1, log);
			if (!string.IsNullOrEmpty(source))
			{
				stringBuilder.AppendFormat(Resources.TriggerEventBasic2, source);
			}
			if (eventId.HasValue)
			{
				stringBuilder.AppendFormat(Resources.TriggerEventBasic3, eventId.Value);
			}
			return stringBuilder.ToString();
		}
		return Resources.TriggerEvent1;
	}
}
