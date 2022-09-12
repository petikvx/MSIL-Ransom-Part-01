using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MySql.Data.Common;

namespace MySql.Data.MySqlClient;

internal class PreparableStatement : Statement
{
	private BitArray _nullMap;

	private readonly List<MySqlParameter> _parametersToSend = new List<MySqlParameter>();

	private MySqlPacket _packet;

	private int _dataPosition;

	private int _nullMapPosition;

	public int ExecutionCount { get; set; }

	public bool IsPrepared => StatementId > 0;

	public int StatementId { get; private set; }

	public PreparableStatement(MySqlCommand command, string text)
		: base(command, text)
	{
	}

	public virtual void Prepare()
	{
		string stripped_sql;
		List<string> list = PrepareCommandText(out stripped_sql);
		MySqlField[] parameters = null;
		StatementId = base.Driver.PrepareStatement(stripped_sql, ref parameters);
		int num = 0;
		while (true)
		{
			if (num < list.Count)
			{
				string text = list[num];
				MySqlParameter parameterFlexible = base.Parameters.GetParameterFlexible(text, throwOnNotFound: false);
				if (parameterFlexible != null)
				{
					parameterFlexible.Encoding = parameters[num].Encoding;
					_parametersToSend.Add(parameterFlexible);
					num++;
					continue;
				}
				throw new InvalidOperationException(string.Format(Resources.ParameterNotFoundDuringPrepare, text));
			}
			int num2 = 0;
			if (parameters != null && parameters.Length != 0)
			{
				_nullMap = new BitArray(parameters.Length);
				num2 = (_nullMap.Length + 7) / 8;
			}
			_packet = new MySqlPacket(base.Driver.Encoding);
			_packet.WriteByte(0);
			_packet.WriteInteger(StatementId, 4);
			_packet.WriteByte(0);
			_packet.WriteInteger(1L, 4);
			_nullMapPosition = _packet.Position;
			_packet.Position += num2;
			_packet.WriteByte(1);
			foreach (MySqlParameter item in _parametersToSend)
			{
				_packet.WriteInteger(item.GetPSType(), 2);
			}
			break;
		}
		_dataPosition = _packet.Position;
	}

	public override void Execute()
	{
		if (!IsPrepared)
		{
			base.Execute();
			return;
		}
		_packet.Position = _dataPosition;
		for (int i = 0; i < _parametersToSend.Count; i++)
		{
			MySqlParameter mySqlParameter = _parametersToSend[i];
			_nullMap[i] = mySqlParameter.Value == DBNull.Value || mySqlParameter.Value == null || mySqlParameter.Direction == ParameterDirection.Output;
			if (!_nullMap[i])
			{
				_packet.Encoding = mySqlParameter.Encoding;
				mySqlParameter.Serialize(_packet, binary: true, base.Connection.Settings);
			}
		}
		_nullMap?.CopyTo(_packet.Buffer, _nullMapPosition);
		ExecutionCount++;
		base.Driver.ExecuteStatement(_packet);
	}

	public override bool ExecuteNext()
	{
		if (!IsPrepared)
		{
			return base.ExecuteNext();
		}
		return false;
	}

	private List<string> PrepareCommandText(out string stripped_sql)
	{
		StringBuilder stringBuilder = new StringBuilder();
		List<string> list = new List<string>();
		int num = 0;
		string resolvedCommandText = ResolvedCommandText;
		MySqlTokenizer mySqlTokenizer = new MySqlTokenizer(resolvedCommandText);
		for (string text = mySqlTokenizer.NextParameter(); text != null; text = mySqlTokenizer.NextParameter())
		{
			if (text.IndexOf("_cnet_param_") == -1)
			{
				stringBuilder.Append(resolvedCommandText.Substring(num, mySqlTokenizer.StartIndex - num));
				stringBuilder.Append("?");
				list.Add(text);
				num = mySqlTokenizer.StopIndex;
			}
		}
		stringBuilder.Append(resolvedCommandText.Substring(num));
		stripped_sql = stringBuilder.ToString();
		return list;
	}

	public virtual void CloseStatement()
	{
		if (IsPrepared)
		{
			base.Driver.CloseStatement(StatementId);
			StatementId = 0;
		}
	}
}
