using System;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using MySql.Data.Common;
using MySql.Data.Types;

namespace MySql.Data.MySqlClient;

internal class StoredProcedure : PreparableStatement
{
	private string _outSelect;

	internal const string ParameterPrefix = "_cnet_param_";

	private string resolvedCommandText;

	public bool ServerProvidingOutputParameters { get; private set; }

	public override string ResolvedCommandText => resolvedCommandText;

	public StoredProcedure(MySqlCommand cmd, string text)
		: base(cmd, text)
	{
	}

	private MySqlParameter GetReturnParameter()
	{
		return base.Parameters?.Cast<MySqlParameter>().FirstOrDefault((MySqlParameter p) => p.Direction == ParameterDirection.ReturnValue);
	}

	internal string GetCacheKey(string spName)
	{
		string text = string.Empty;
		StringBuilder stringBuilder = new StringBuilder(spName);
		stringBuilder.Append("(");
		string text2 = "";
		foreach (MySqlParameter parameter in command.Parameters)
		{
			if (parameter.Direction == ParameterDirection.ReturnValue)
			{
				text = "?=";
				continue;
			}
			stringBuilder.AppendFormat(CultureInfo.InvariantCulture, "{0}?", new object[1] { text2 });
			text2 = ",";
		}
		stringBuilder.Append(")");
		return text + stringBuilder.ToString();
	}

	private ProcedureCacheEntry GetParameters(string procName)
	{
		string cacheKey = GetCacheKey(procName);
		return base.Connection.ProcedureCache.GetProcedure(base.Connection, procName, cacheKey);
	}

	public static string GetFlags(string dtd)
	{
		int num = dtd.Length - 1;
		while (num > 0 && (char.IsLetterOrDigit(dtd[num]) || dtd[num] == ' '))
		{
			num--;
		}
		return StringUtility.ToUpperInvariant(dtd.Substring(num));
	}

	private string FixProcedureName(string name)
	{
		string[] array = name.Split(new char[1] { '.' });
		for (int i = 0; i < array.Length; i++)
		{
			if (!array[i].StartsWith("`", StringComparison.Ordinal))
			{
				array[i] = $"`{array[i]}`";
			}
		}
		if (array.Length == 1)
		{
			return array[0];
		}
		return $"{array[0]}.{array[1]}";
	}

	private MySqlParameter GetAndFixParameter(string spName, MySqlSchemaRow param, bool realAsFloat, MySqlParameter returnParameter)
	{
		_ = (string)param["PARAMETER_MODE"];
		string parameterName = (string)param["PARAMETER_NAME"];
		if (param["ORDINAL_POSITION"].Equals(0))
		{
			if (returnParameter == null)
			{
				throw new InvalidOperationException(string.Format(Resources.RoutineRequiresReturnParameter, spName));
			}
			parameterName = returnParameter.ParameterName;
		}
		MySqlParameter parameterFlexible = command.Parameters.GetParameterFlexible(parameterName, throwOnNotFound: true);
		if (!parameterFlexible.TypeHasBeenSet)
		{
			string typeName = (string)param["DATA_TYPE"];
			bool unsigned = GetFlags(param["DTD_IDENTIFIER"].ToString()).IndexOf("UNSIGNED") != -1;
			parameterFlexible.MySqlDbType = MetaData.NameToType(typeName, unsigned, realAsFloat, base.Connection);
		}
		return parameterFlexible;
	}

	private MySqlParameterCollection CheckParameters(string spName)
	{
		MySqlParameterCollection mySqlParameterCollection = new MySqlParameterCollection(command);
		MySqlParameter returnParameter = GetReturnParameter();
		ProcedureCacheEntry parameters = GetParameters(spName);
		if (parameters.procedure != null && parameters.procedure.Rows.Count != 0)
		{
			bool realAsFloat = parameters.procedure.Rows[0]["SQL_MODE"].ToString()!.IndexOf("REAL_AS_FLOAT") != -1;
			{
				foreach (MySqlSchemaRow row in parameters.parameters.Rows)
				{
					mySqlParameterCollection.Add(GetAndFixParameter(spName, row, realAsFloat, returnParameter));
				}
				return mySqlParameterCollection;
			}
		}
		throw new InvalidOperationException(string.Format(Resources.RoutineNotFound, spName));
	}

	public override void Resolve(bool preparing)
	{
		if (ResolvedCommandText == null)
		{
			ServerProvidingOutputParameters = base.Driver.SupportsOutputParameters && preparing;
			string text = commandText;
			if (text.IndexOf(".") == -1 && !string.IsNullOrEmpty(base.Connection.Database))
			{
				text = base.Connection.Database + "." + text;
			}
			text = FixProcedureName(text);
			MySqlParameter returnParameter = GetReturnParameter();
			MySqlParameterCollection parms = (command.Connection.Settings.CheckParameters ? CheckParameters(text) : base.Parameters);
			string arg = SetUserVariables(parms, preparing);
			string arg2 = CreateCallStatement(text, returnParameter, parms);
			string arg3 = CreateOutputSelect(parms, preparing);
			resolvedCommandText = $"{arg}{arg2}{arg3}";
		}
	}

	private string SetUserVariables(MySqlParameterCollection parms, bool preparing)
	{
		StringBuilder stringBuilder = new StringBuilder();
		if (ServerProvidingOutputParameters)
		{
			return stringBuilder.ToString();
		}
		string text = string.Empty;
		foreach (MySqlParameter parm in parms)
		{
			if (parm.Direction == ParameterDirection.InputOutput)
			{
				string arg = "@" + parm.BaseName;
				string arg2 = "@_cnet_param_" + parm.BaseName;
				string text2 = $"SET {arg2}={arg}";
				if (command.Connection.Settings.AllowBatch && !preparing)
				{
					stringBuilder.AppendFormat(CultureInfo.InvariantCulture, "{0}{1}", new object[2] { text, text2 });
					text = "; ";
				}
				else
				{
					MySqlCommand mySqlCommand = new MySqlCommand(text2, command.Connection);
					mySqlCommand.Parameters.Add(parm);
					mySqlCommand.ExecuteNonQuery();
				}
			}
		}
		if (stringBuilder.Length > 0)
		{
			stringBuilder.Append("; ");
		}
		return stringBuilder.ToString();
	}

	private string CreateCallStatement(string spName, MySqlParameter returnParameter, MySqlParameterCollection parms)
	{
		StringBuilder stringBuilder = new StringBuilder();
		string text = string.Empty;
		foreach (MySqlParameter parm in parms)
		{
			if (parm.Direction != ParameterDirection.ReturnValue)
			{
				string text2 = "@" + parm.BaseName;
				string text3 = "@_cnet_param_" + parm.BaseName;
				bool flag = parm.Direction == ParameterDirection.Input || ServerProvidingOutputParameters;
				stringBuilder.AppendFormat(CultureInfo.InvariantCulture, "{0}{1}", new object[2]
				{
					text,
					flag ? text2 : text3
				});
				text = ", ";
			}
		}
		if (returnParameter == null)
		{
			return $"CALL {spName}({stringBuilder.ToString()})";
		}
		return string.Format("SET @{0}{1}={2}({3})", "_cnet_param_", returnParameter.BaseName, spName, stringBuilder.ToString());
	}

	private string CreateOutputSelect(MySqlParameterCollection parms, bool preparing)
	{
		StringBuilder stringBuilder = new StringBuilder();
		string text = string.Empty;
		foreach (MySqlParameter parm in parms)
		{
			if (parm.Direction != ParameterDirection.Input && ((parm.Direction != ParameterDirection.InputOutput && parm.Direction != ParameterDirection.Output) || !ServerProvidingOutputParameters))
			{
				_ = "@" + parm.BaseName;
				string text2 = "@_cnet_param_" + parm.BaseName;
				stringBuilder.AppendFormat(CultureInfo.InvariantCulture, "{0}{1}", new object[2] { text, text2 });
				text = ", ";
			}
		}
		if (stringBuilder.Length == 0)
		{
			return string.Empty;
		}
		if (command.Connection.Settings.AllowBatch && !preparing)
		{
			return $";SELECT {stringBuilder.ToString()}";
		}
		_outSelect = $"SELECT {stringBuilder.ToString()}";
		return string.Empty;
	}

	internal void ProcessOutputParameters(MySqlDataReader reader)
	{
		AdjustOutputTypes(reader);
		if ((reader.CommandBehavior & CommandBehavior.SchemaOnly) != 0)
		{
			return;
		}
		reader.Read();
		string text = "@_cnet_param_";
		for (int i = 0; i < reader.FieldCount; i++)
		{
			string text2 = reader.GetName(i);
			if (text2.StartsWith(text, StringComparison.OrdinalIgnoreCase))
			{
				text2 = text2.Remove(0, text.Length);
			}
			command.Parameters.GetParameterFlexible(text2, throwOnNotFound: true).Value = reader.GetValue(i);
		}
	}

	private void AdjustOutputTypes(MySqlDataReader reader)
	{
		for (int i = 0; i < reader.FieldCount; i++)
		{
			string text = reader.GetName(i);
			if (text.IndexOf("_cnet_param_") != -1)
			{
				text = text.Remove(0, "_cnet_param_".Length + 1);
			}
			IMySqlValue iMySqlValue = MySqlField.GetIMySqlValue(command.Parameters.GetParameterFlexible(text, throwOnNotFound: true).MySqlDbType);
			if (iMySqlValue is MySqlBit mySqlBit)
			{
				mySqlBit.ReadAsString = true;
				reader.ResultSet.SetValueObject(i, mySqlBit);
			}
			else
			{
				reader.ResultSet.SetValueObject(i, iMySqlValue);
			}
		}
	}

	public override void Close(MySqlDataReader reader)
	{
		base.Close(reader);
		if (string.IsNullOrEmpty(_outSelect) || (reader.CommandBehavior & CommandBehavior.SchemaOnly) != 0)
		{
			return;
		}
		using MySqlDataReader reader2 = new MySqlCommand(_outSelect, command.Connection).ExecuteReader(reader.CommandBehavior);
		ProcessOutputParameters(reader2);
	}
}
