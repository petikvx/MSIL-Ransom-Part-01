using System;
using System.Collections.Generic;
using MySql.Data.Common;

namespace MySql.Data.MySqlClient;

internal abstract class Statement
{
	protected MySqlCommand command;

	private readonly List<MySqlPacket> _buffers;

	protected string commandText;

	public virtual string ResolvedCommandText => commandText;

	protected Driver Driver => command.Connection.driver;

	protected MySqlConnection Connection => command.Connection;

	protected MySqlParameterCollection Parameters => command.Parameters;

	private Statement(MySqlCommand cmd)
	{
		command = cmd;
		_buffers = new List<MySqlPacket>();
	}

	protected Statement(MySqlCommand cmd, string text)
		: this(cmd)
	{
		commandText = text;
	}

	public virtual void Close(MySqlDataReader reader)
	{
	}

	public virtual void Resolve(bool preparing)
	{
	}

	public virtual void Execute()
	{
		BindParameters();
		ExecuteNext();
	}

	public virtual bool ExecuteNext()
	{
		if (_buffers.Count == 0)
		{
			return false;
		}
		MySqlPacket p = _buffers[0];
		Driver.SendQuery(p);
		_buffers.RemoveAt(0);
		return true;
	}

	protected virtual void BindParameters()
	{
		MySqlParameterCollection parameters = command.Parameters;
		int num = 0;
		do
		{
			InternalBindParameters(ResolvedCommandText, parameters, null);
			if (command.Batch == null)
			{
				break;
			}
			while (num < command.Batch.Count)
			{
				MySqlCommand mySqlCommand = command.Batch[num++];
				MySqlPacket mySqlPacket = _buffers[_buffers.Count - 1];
				long num2 = mySqlCommand.EstimatedSize();
				if (mySqlPacket.Length - 4 + num2 <= Connection.driver.MaxPacketSize)
				{
					_buffers.RemoveAt(_buffers.Count - 1);
					string resolvedCommandText = ResolvedCommandText;
					if (resolvedCommandText.StartsWith("(", StringComparison.Ordinal))
					{
						mySqlPacket.WriteStringNoNull(", ");
					}
					else
					{
						mySqlPacket.WriteStringNoNull("; ");
					}
					InternalBindParameters(resolvedCommandText, mySqlCommand.Parameters, mySqlPacket);
					if (mySqlPacket.Length - 4 > Connection.driver.MaxPacketSize)
					{
						parameters = mySqlCommand.Parameters;
						break;
					}
					continue;
				}
				parameters = mySqlCommand.Parameters;
				break;
			}
		}
		while (num != command.Batch.Count);
	}

	private void InternalBindParameters(string sql, MySqlParameterCollection parameters, MySqlPacket packet)
	{
		bool sqlServerMode = command.Connection.Settings.SqlServerMode;
		if (packet == null)
		{
			packet = new MySqlPacket(Driver.Encoding)
			{
				Version = Driver.Version
			};
			packet.WriteByte(0);
		}
		MySqlTokenizer mySqlTokenizer = new MySqlTokenizer(sql)
		{
			ReturnComments = true,
			SqlServerMode = sqlServerMode
		};
		int num = 0;
		string text = mySqlTokenizer.NextToken();
		int num2 = 0;
		while (text != null)
		{
			packet.WriteStringNoNull(sql.Substring(num, mySqlTokenizer.StartIndex - num));
			num = mySqlTokenizer.StopIndex;
			if (MySqlTokenizer.IsParameter(text))
			{
				if ((!parameters.containsUnnamedParameters && text.Length == 1 && num2 > 0) || (parameters.containsUnnamedParameters && text.Length > 1))
				{
					throw new MySqlException(Resources.MixedParameterNamingNotAllowed);
				}
				parameters.containsUnnamedParameters = text.Length == 1;
				if (SerializeParameter(parameters, packet, text, num2))
				{
					text = null;
				}
				num2++;
			}
			if (text != null)
			{
				if (sqlServerMode && mySqlTokenizer.Quoted && text.StartsWith("[", StringComparison.Ordinal))
				{
					text = $"`{text.Substring(1, text.Length - 2)}`";
				}
				packet.WriteStringNoNull(text);
			}
			text = mySqlTokenizer.NextToken();
		}
		_buffers.Add(packet);
	}

	protected virtual bool ShouldIgnoreMissingParameter(string parameterName)
	{
		if (Connection.Settings.AllowUserVariables)
		{
			return true;
		}
		if (parameterName.StartsWith("@_cnet_param_", StringComparison.OrdinalIgnoreCase))
		{
			return true;
		}
		if (parameterName.Length > 1 && (parameterName[1] == '`' || parameterName[1] == '\''))
		{
			return true;
		}
		return false;
	}

	private bool SerializeParameter(MySqlParameterCollection parameters, MySqlPacket packet, string parmName, int parameterIndex)
	{
		MySqlParameter mySqlParameter = null;
		if (!parameters.containsUnnamedParameters)
		{
			mySqlParameter = parameters.GetParameterFlexible(parmName, throwOnNotFound: false);
		}
		else
		{
			if (parameterIndex > parameters.Count)
			{
				throw new MySqlException(Resources.ParameterIndexNotFound);
			}
			mySqlParameter = parameters[parameterIndex];
		}
		if (mySqlParameter == null)
		{
			if (parmName.StartsWith("@", StringComparison.Ordinal) && ShouldIgnoreMissingParameter(parmName))
			{
				return false;
			}
			throw new MySqlException(string.Format(Resources.ParameterMustBeDefined, parmName));
		}
		mySqlParameter.Serialize(packet, binary: false, Connection.Settings);
		return true;
	}
}
