using System;
using System.Text;

namespace White.Core.UIItemEvents;

public abstract class EventWriter
{
	private string code;

	public virtual string Code => code;

	public virtual void Write(Type uiItemType, string actionName, string identification, object[] parameters)
	{
		StringBuilder stringBuilder = new StringBuilder(CodeForGettingUIItem(uiItemType, identification));
		stringBuilder.Append(".").Append(actionName);
		if (uiItemType.GetProperty(actionName) != null)
		{
			stringBuilder.Append(" = ");
			if (parameters[0] is bool)
			{
				stringBuilder.Append(((bool)parameters[0]) ? "true" : "false");
			}
			else
			{
				stringBuilder.Append(string.Concat("\"", parameters[0], "\""));
			}
		}
		else
		{
			stringBuilder.Append("(");
			for (int i = 0; i < parameters.Length; i++)
			{
				stringBuilder.Append("\"").Append(parameters[i]).Append("\"");
				if (i != parameters.Length - 1)
				{
					stringBuilder.Append(", ");
				}
			}
			stringBuilder.Append(")");
		}
		stringBuilder.Append(";");
		code = stringBuilder.ToString();
	}

	protected abstract string CodeForGettingUIItem(Type uiItemType, string identification);
}
