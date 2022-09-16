using System;
using Geologe8s;
using ns6;
using ns8;

namespace ns4;

public interface ILogMessage
{
	Te3timonie3 Level { get; set; }

	Az0ths WarningLevel { get; set; }

	Thermogr5phers Code { get; set; }

	string Message { get; set; }

	string ProjectPath { get; set; }

	DateTimeOffset Time { get; set; }
}
