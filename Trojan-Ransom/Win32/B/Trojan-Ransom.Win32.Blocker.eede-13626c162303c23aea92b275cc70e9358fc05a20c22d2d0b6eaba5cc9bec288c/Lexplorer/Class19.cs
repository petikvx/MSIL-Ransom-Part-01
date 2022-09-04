using System.Xml;

namespace Lexplorer;

internal class Class19 : Class13
{
	private int currentNode;

	private XmlNodeList body;

	public XmlNodeList Body
	{
		get
		{
			return body;
		}
		set
		{
			body = value;
		}
	}

	public int CurrentIndex
	{
		get
		{
			return currentNode;
		}
		set
		{
			currentNode = value;
		}
	}

	public bool WriteLog { get; set; }

	public bool AllowMonitorPower { get; set; }

	public Class19()
	{
		methodTable.Add("EXECUTE", RunScript);
	}

	private bool RunScript(Class10 pars, bool forced)
	{
		bool flag = true;
		int num = currentNode;
		int num2 = int.Parse(pars["V"]);
		int num3 = 0;
		while (true)
		{
			if (num3 < num2)
			{
				currentNode = num;
				while (currentNode < body.Count)
				{
					XmlNode node = body[currentNode];
					Class13 @class = Class13.ReadCommand(node);
					if (@class.GetType() == typeof(Class16))
					{
						break;
					}
					if (flag = @class.Execute(forced))
					{
						currentNode++;
						continue;
					}
					return false;
				}
				if (!flag)
				{
					break;
				}
				num3++;
				continue;
			}
			return flag;
		}
		return false;
	}

	public override string ToString()
	{
		return $"Command type: Loop, Method={base.ExecutionMethodName}";
	}
}
