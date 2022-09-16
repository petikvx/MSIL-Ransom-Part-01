using System;
using System.IO;

namespace pal.EventLogAnalyzer.IO;

public abstract class CommandHandler : IDisposable
{
	protected Stream stream;

	private ProtocolRules _rules;

	protected object lockTarget = new object();

	public ProtocolRules Rules
	{
		get
		{
			return _rules;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			_rules = value;
		}
	}

	public CommandHandler(Stream readFrom, ProtocolRules rules)
	{
		stream = readFrom ?? throw new ArgumentNullException("readFrom");
		Rules = rules ?? throw new ArgumentNullException("rules");
	}

	public abstract void Dispose();

	private int nextNonSpecial(CommandModel model, int paramIndex)
	{
		bool flag = false;
		bool flag2 = false;
		int num = paramIndex;
		while (true)
		{
			if (num < model.Count)
			{
				if ((flag = !model[num].HasFlag(ParamType._SPECIAL)) && flag2)
				{
					break;
				}
				flag2 = flag;
				num++;
				continue;
			}
			return model.Count;
		}
		return num;
	}
}
