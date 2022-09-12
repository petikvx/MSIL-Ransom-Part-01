using System.Collections.Generic;
using Renci.SshNet.Common;

namespace Renci.SshNet.Messages.Connection;

internal class PseudoTerminalRequestInfo : RequestInfo
{
	public const string Name = "pty-req";

	public override string RequestName => "pty-req";

	public string EnvironmentVariable { get; set; }

	public uint Columns { get; set; }

	public uint Rows { get; set; }

	public uint PixelWidth { get; set; }

	public uint PixelHeight { get; set; }

	public IDictionary<TerminalModes, uint> TerminalModeValues { get; set; }

	protected override int BufferCapacity => -1;

	public PseudoTerminalRequestInfo()
	{
		base.WantReply = true;
	}

	public PseudoTerminalRequestInfo(string environmentVariable, uint columns, uint rows, uint width, uint height, IDictionary<TerminalModes, uint> terminalModeValues)
		: this()
	{
		EnvironmentVariable = environmentVariable;
		Columns = columns;
		Rows = rows;
		PixelWidth = width;
		PixelHeight = height;
		TerminalModeValues = terminalModeValues;
	}

	protected override void SaveData()
	{
		base.SaveData();
		Write(EnvironmentVariable);
		Write(Columns);
		Write(Rows);
		Write(PixelWidth);
		Write(PixelHeight);
		if (TerminalModeValues != null && TerminalModeValues.Count > 0)
		{
			Write((uint)(TerminalModeValues.Count * 5 + 1));
			foreach (KeyValuePair<TerminalModes, uint> terminalModeValue in TerminalModeValues)
			{
				Write((byte)terminalModeValue.Key);
				Write(terminalModeValue.Value);
			}
			Write(0);
		}
		else
		{
			Write(0u);
		}
	}
}
