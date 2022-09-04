using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;
using System.Web;
using System.Xml.Linq;

namespace The_chViewer;

public class BbsThread
{
	public static string CacheDir;

	private Thread _workerThread;

	public string Name { get; set; }

	public long Epoch { get; set; }

	public int ResNum { get; set; }

	public double Speed => (double)ResNum / Age;

	public double Age
	{
		get
		{
			DateTime dateTime = new DateTime(1970, 1, 1).ToLocalTime().AddSeconds(Epoch);
			return (DateTime.Now - dateTime).TotalDays;
		}
	}

	public List<BbsResponse> Responses { get; set; }

	public event Action<object, DownloadCompletedEventArgs> DownladCompleted;

	public override string ToString()
	{
		return $"{Name}({ResNum}):{Epoch}";
	}

	public BbsThread()
	{
		Responses = new List<BbsResponse>();
	}

	public void Download(string hostName, string boardDir)
	{
		Responses.Clear();
		string text = "";
		string text2 = "";
		text2 = ((!GlobalConf.UseBg20 || !hostName.EndsWith(".2ch.net")) ? $"http://{hostName}/{boardDir}/dat/{Epoch}.dat" : $"http://bg20.2ch.net/test/r.so/{hostName}/{boardDir}/{Epoch}/");
		using (WebClient webClient = new WebClient())
		{
			webClient.Headers.Add(HttpRequestHeader.UserAgent, GlobalConf.UserAgent);
			text = webClient.DownloadString(text2);
		}
		string[] array = text.Split(new char[1] { '\n' });
		int num = 0;
		while (true)
		{
			if (num >= array.Length)
			{
				return;
			}
			string text3 = array[num];
			if (!(text3 == ""))
			{
				string[] array2 = text3.Split(new string[1] { "<>" }, StringSplitOptions.None);
				if (array2.Count() < 5)
				{
					break;
				}
				BbsResponse item = default(BbsResponse);
				item.Author = array2[0];
				item.Mail = array2[1];
				Match match = Regex.Match(array2[2], "(?<date>\\d\\d\\d\\d/\\d\\d/\\d\\d\\([月火水木金土日]\\)\\s\\d\\d:\\d\\d:\\d\\d(\\.\\d\\d)?)?(\\sID:(?<id>[a-zA-Z0-9+/]+))?(\\sBE:(?<beid>.+))?");
				DateTime.TryParse(match.Groups["date"].Value, out item.date);
				item.Id = match.Groups["id"].Value;
				item.BeId = match.Groups["beid"].Value;
				string input = array2[3];
				input = Regex.Replace(input, " <br> ", "\r\n");
				input = Regex.Replace(input, "<a.+?>(?<name>.+?)</a>", "${name}");
				input = (item.Body = HttpUtility.HtmlDecode(input));
				Responses.Add(item);
			}
			num++;
		}
		throw new Exception("dat file format error.");
	}

	public XDocument ToXml()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected O, but got Unknown
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected O, but got Unknown
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected O, but got Unknown
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected O, but got Unknown
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Expected O, but got Unknown
		//IL_0275: Expected O, but got Unknown
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Expected O, but got Unknown
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Expected O, but got Unknown
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Expected O, but got Unknown
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Expected O, but got Unknown
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Expected O, but got Unknown
		//IL_036d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0377: Expected O, but got Unknown
		XElement val = new XElement(XName.op_Implicit("dl"));
		val.SetAttributeValue(XName.op_Implicit("class"), (object)"thread");
		for (int i = 0; i < Responses.Count; i++)
		{
			XElement val2;
			if (Responses[i].Mail != "")
			{
				val2 = new XElement(XName.op_Implicit("a"));
				val2.SetAttributeValue(XName.op_Implicit("href"), (object)("mailto:" + Responses[i].Mail));
			}
			else
			{
				val2 = new XElement(XName.op_Implicit("font"));
				val2.SetAttributeValue(XName.op_Implicit("color"), (object)"green");
			}
			((XContainer)val2).Add((object)new XElement(XName.op_Implicit("b"), (object)Responses[i].Author));
			XElement val3 = new XElement(XName.op_Implicit("a"));
			val3.SetAttributeValue(XName.op_Implicit("name"), (object)(i + 1));
			((XContainer)val).Add((object)new XElement(XName.op_Implicit("dt"), new object[3]
			{
				val3,
				$"{i + 1} ：",
				val2
			}));
			((XContainer)val).Add(new object[2]
			{
				"：",
				Responses[i].date.ToString("yyyy/MM/dd(ddd) HH:mm:ss")
			});
			if (Responses[i].Id != "")
			{
				((XContainer)val).Add((object)(" ID:" + Responses[i].Id));
			}
			XElement val4 = new XElement(XName.op_Implicit("dd"));
			string[] array = Responses[i].Body.Split(new string[1] { "\r\n" }, StringSplitOptions.None);
			foreach (string text in array)
			{
				((XContainer)val4).Add((object)text);
				((XContainer)val4).Add((object)new XElement(XName.op_Implicit("br")));
			}
			((XContainer)val).Add((object)val4);
		}
		XDocument val5 = new XDocument(new XDeclaration("1.0", "Shift-JIS", "yes"), new object[1] { (object)new XComment("Generated by lib2ch") });
		XElement val6 = new XElement(XName.op_Implicit("h1"), (object)Name);
		val6.SetAttributeValue(XName.op_Implicit("style"), (object)"color:red;font-size:larger;font-weight:normal;margin:-.5em 0 0;");
		XElement val7 = new XElement(XName.op_Implicit("head"), (object)new XElement(XName.op_Implicit("title"), (object)Name));
		XElement val8 = new XElement(XName.op_Implicit("body"), new object[2] { val6, val });
		val8.SetAttributeValue(XName.op_Implicit("bgcolor"), (object)"#efefef");
		val8.SetAttributeValue(XName.op_Implicit("text"), (object)"black");
		val8.SetAttributeValue(XName.op_Implicit("link"), (object)"blue");
		val8.SetAttributeValue(XName.op_Implicit("alink"), (object)"red");
		val8.SetAttributeValue(XName.op_Implicit("vlink"), (object)"#660099");
		((XContainer)val5).Add((object)new XElement(XName.op_Implicit("html"), new object[2] { val7, val8 }));
		return val5;
	}

	public void DownloadAsync(string serverName, string boardDir)
	{
		_workerThread = new Thread((ThreadStart)delegate
		{
			Download(serverName, boardDir);
			this.DownladCompleted(this, new DownloadCompletedEventArgs());
		});
		_workerThread.Start();
	}

	public void DownloadCancel()
	{
		if (_workerThread != null && _workerThread.ThreadState == ThreadState.Running)
		{
			_workerThread.Abort();
		}
	}
}
