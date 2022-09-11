using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ns11;
using ns17;
using ns21;
using ns5;
using ns8;

namespace ns6;

[Designer("MySql.Data.MySqlClient.Design.MySqlDataAdapterDesigner,MySqlClient.Design")]
[DesignerCategory("Code")]
[ToolboxBitmap(typeof(Class149), "MySqlClient.resources.dataadapter.bmp")]
internal sealed class Class149 : DbDataAdapter, IDbDataAdapter, IDataAdapter
{
	private bool bool_0;

	private int int_0;

	private List<IDbCommand> list_0;

	[CompilerGenerated]
	private Delegate4 delegate4_0;

	[CompilerGenerated]
	private Delegate5 delegate5_0;

	[Description("Used during Update for deleted rows in Dataset.")]
	public new MySqlCommand DeleteCommand
	{
		get
		{
			return (MySqlCommand)base.DeleteCommand;
		}
		set
		{
			base.DeleteCommand = value;
		}
	}

	[Description("Used during Update for new rows in Dataset.")]
	public new MySqlCommand InsertCommand
	{
		get
		{
			return (MySqlCommand)base.InsertCommand;
		}
		set
		{
			base.InsertCommand = value;
		}
	}

	[Category("Fill")]
	[Description("Used during Fill/FillSchema")]
	public new MySqlCommand SelectCommand
	{
		get
		{
			return (MySqlCommand)base.SelectCommand;
		}
		set
		{
			base.SelectCommand = value;
		}
	}

	[Description("Used during Update for modified rows in Dataset.")]
	public new MySqlCommand UpdateCommand
	{
		get
		{
			return (MySqlCommand)base.UpdateCommand;
		}
		set
		{
			base.UpdateCommand = value;
		}
	}

	internal bool LoadDefaults
	{
		get
		{
			return bool_0;
		}
		set
		{
			bool_0 = value;
		}
	}

	int DbDataAdapter.UpdateBatchSize
	{
		get
		{
			return int_0;
		}
		set
		{
			int_0 = value;
		}
	}

	public event Delegate4 RowUpdating
	{
		[CompilerGenerated]
		add
		{
			Delegate4 @delegate = delegate4_0;
			Delegate4 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate4 value2 = (Delegate4)Delegate.Combine(delegate2, value);
				@delegate = Interlocked.CompareExchange(ref delegate4_0, value2, delegate2);
			}
			while ((object)@delegate != delegate2);
		}
		[CompilerGenerated]
		remove
		{
			Delegate4 @delegate = delegate4_0;
			Delegate4 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate4 value2 = (Delegate4)Delegate.Remove(delegate2, value);
				@delegate = Interlocked.CompareExchange(ref delegate4_0, value2, delegate2);
			}
			while ((object)@delegate != delegate2);
		}
	}

	public event Delegate5 RowUpdated
	{
		[CompilerGenerated]
		add
		{
			Delegate5 @delegate = delegate5_0;
			Delegate5 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate5 value2 = (Delegate5)Delegate.Combine(delegate2, value);
				@delegate = Interlocked.CompareExchange(ref delegate5_0, value2, delegate2);
			}
			while ((object)@delegate != delegate2);
		}
		[CompilerGenerated]
		remove
		{
			Delegate5 @delegate = delegate5_0;
			Delegate5 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate5 value2 = (Delegate5)Delegate.Remove(delegate2, value);
				@delegate = Interlocked.CompareExchange(ref delegate5_0, value2, delegate2);
			}
			while ((object)@delegate != delegate2);
		}
	}

	public Class149()
	{
		bool_0 = true;
		int_0 = 1;
	}

	public Class149(MySqlCommand mySqlCommand_0)
		: this()
	{
		SelectCommand = mySqlCommand_0;
	}

	public Class149(string string_0, Class139 class139_0)
		: this()
	{
		SelectCommand = new MySqlCommand(string_0, class139_0);
	}

	public Class149(string string_0, string string_1)
		: this()
	{
		SelectCommand = new MySqlCommand(string_0, new Class139(string_1));
	}

	private void method_0(DataRowState dataRowState_0, List<Class139> list_1)
	{
		MySqlCommand mySqlCommand = null;
		switch (dataRowState_0)
		{
		default:
			return;
		case DataRowState.Modified:
			mySqlCommand = UpdateCommand;
			break;
		case DataRowState.Deleted:
			mySqlCommand = DeleteCommand;
			break;
		case DataRowState.Added:
			mySqlCommand = InsertCommand;
			break;
		}
		if (mySqlCommand != null && mySqlCommand.Connection != null && mySqlCommand.Connection.connectionState_0 == ConnectionState.Closed)
		{
			mySqlCommand.Connection.Open();
			list_1.Add(mySqlCommand.Connection);
		}
	}

	int DbDataAdapter.Update(DataRow[] dataRows, DataTableMapping tableMapping)
	{
		List<Class139> list = new List<Class139>();
		try
		{
			foreach (DataRow dataRow in dataRows)
			{
				method_0(dataRow.RowState, list);
			}
			return base.Update(dataRows, tableMapping);
		}
		finally
		{
			foreach (Class139 item in list)
			{
				item.Close();
			}
		}
	}

	void DbDataAdapter.InitializeBatching()
	{
		list_0 = new List<IDbCommand>();
	}

	int DbDataAdapter.AddToBatch(IDbCommand command)
	{
		MySqlCommand mySqlCommand = (MySqlCommand)command;
		if (mySqlCommand.BatchableCommandText == null)
		{
			mySqlCommand.method_22();
		}
		IDbCommand item = (IDbCommand)((ICloneable)command).Clone();
		list_0.Add(item);
		return list_0.Count - 1;
	}

	int DbDataAdapter.ExecuteBatch()
	{
		int num = 0;
		int num2 = 0;
		while (num2 < list_0.Count)
		{
			MySqlCommand mySqlCommand = (MySqlCommand)list_0[num2++];
			int num3 = num2;
			while (num3 < list_0.Count)
			{
				MySqlCommand mySqlCommand2 = (MySqlCommand)list_0[num3];
				if (mySqlCommand2.BatchableCommandText == null || mySqlCommand2.CommandText != mySqlCommand.CommandText)
				{
					break;
				}
				mySqlCommand.method_21(mySqlCommand2);
				num3++;
				num2++;
			}
			num += mySqlCommand.ExecuteNonQuery();
		}
		return num;
	}

	void DbDataAdapter.ClearBatch()
	{
		if (list_0.Count > 0)
		{
			MySqlCommand mySqlCommand = (MySqlCommand)list_0[0];
			if (mySqlCommand.Batch != null)
			{
				mySqlCommand.Batch.Clear();
			}
		}
		list_0.Clear();
	}

	void DbDataAdapter.TerminateBatching()
	{
		ClearBatch();
		list_0 = null;
	}

	IDataParameter DbDataAdapter.GetBatchedParameter(int commandIdentifier, int parameterIndex)
	{
		return (IDataParameter)list_0[commandIdentifier].Parameters[parameterIndex];
	}

	RowUpdatedEventArgs DbDataAdapter.CreateRowUpdatedEvent(DataRow dataRow, IDbCommand command, StatementType statementType, DataTableMapping tableMapping)
	{
		return new EventArgs2(dataRow, command, statementType, tableMapping);
	}

	RowUpdatingEventArgs DbDataAdapter.CreateRowUpdatingEvent(DataRow dataRow, IDbCommand command, StatementType statementType, DataTableMapping tableMapping)
	{
		return new EventArgs1(dataRow, command, statementType, tableMapping);
	}

	void DbDataAdapter.OnRowUpdating(RowUpdatingEventArgs value)
	{
		if (delegate4_0 != null)
		{
			delegate4_0(this, value as EventArgs1);
		}
	}

	void DbDataAdapter.OnRowUpdated(RowUpdatedEventArgs value)
	{
		if (delegate5_0 != null)
		{
			delegate5_0(this, value as EventArgs2);
		}
	}

	public Task<int> method_1(DataSet dataSet_0)
	{
		return method_2(dataSet_0, CancellationToken.None);
	}

	public Task<int> method_2(DataSet dataSet_0, CancellationToken cancellationToken_0)
	{
		TaskCompletionSource<int> taskCompletionSource = new TaskCompletionSource<int>();
		if (!(cancellationToken_0 == CancellationToken.None) && cancellationToken_0.IsCancellationRequested)
		{
			taskCompletionSource.SetCanceled();
		}
		else
		{
			try
			{
				int result = Fill(dataSet_0);
				taskCompletionSource.SetResult(result);
			}
			catch (Exception exception)
			{
				taskCompletionSource.SetException(exception);
			}
		}
		return taskCompletionSource.Task;
	}

	public Task<int> method_3(DataTable dataTable_0)
	{
		return method_4(dataTable_0, CancellationToken.None);
	}

	public Task<int> method_4(DataTable dataTable_0, CancellationToken cancellationToken_0)
	{
		TaskCompletionSource<int> taskCompletionSource = new TaskCompletionSource<int>();
		if (!(cancellationToken_0 == CancellationToken.None) && cancellationToken_0.IsCancellationRequested)
		{
			taskCompletionSource.SetCanceled();
		}
		else
		{
			try
			{
				int result = Fill(dataTable_0);
				taskCompletionSource.SetResult(result);
			}
			catch (Exception exception)
			{
				taskCompletionSource.SetException(exception);
			}
		}
		return taskCompletionSource.Task;
	}

	public Task<int> method_5(DataSet dataSet_0, string string_0)
	{
		return method_6(dataSet_0, string_0, CancellationToken.None);
	}

	public Task<int> method_6(DataSet dataSet_0, string string_0, CancellationToken cancellationToken_0)
	{
		TaskCompletionSource<int> taskCompletionSource = new TaskCompletionSource<int>();
		if (!(cancellationToken_0 == CancellationToken.None) && cancellationToken_0.IsCancellationRequested)
		{
			taskCompletionSource.SetCanceled();
		}
		else
		{
			try
			{
				int result = Fill(dataSet_0, string_0);
				taskCompletionSource.SetResult(result);
			}
			catch (Exception exception)
			{
				taskCompletionSource.SetException(exception);
			}
		}
		return taskCompletionSource.Task;
	}

	public Task<int> method_7(DataTable dataTable_0, IDataReader idataReader_0)
	{
		return method_8(dataTable_0, idataReader_0, CancellationToken.None);
	}

	public Task<int> method_8(DataTable dataTable_0, IDataReader idataReader_0, CancellationToken cancellationToken_0)
	{
		TaskCompletionSource<int> taskCompletionSource = new TaskCompletionSource<int>();
		if (!(cancellationToken_0 == CancellationToken.None) && cancellationToken_0.IsCancellationRequested)
		{
			taskCompletionSource.SetCanceled();
		}
		else
		{
			try
			{
				int result = base.Fill(dataTable_0, idataReader_0);
				taskCompletionSource.SetResult(result);
			}
			catch (Exception exception)
			{
				taskCompletionSource.SetException(exception);
			}
		}
		return taskCompletionSource.Task;
	}

	public Task<int> method_9(DataTable dataTable_0, IDbCommand idbCommand_0, CommandBehavior commandBehavior_0)
	{
		return method_10(dataTable_0, idbCommand_0, commandBehavior_0, CancellationToken.None);
	}

	public Task<int> method_10(DataTable dataTable_0, IDbCommand idbCommand_0, CommandBehavior commandBehavior_0, CancellationToken cancellationToken_0)
	{
		TaskCompletionSource<int> taskCompletionSource = new TaskCompletionSource<int>();
		if (!(cancellationToken_0 == CancellationToken.None) && cancellationToken_0.IsCancellationRequested)
		{
			taskCompletionSource.SetCanceled();
		}
		else
		{
			try
			{
				int result = base.Fill(dataTable_0, idbCommand_0, commandBehavior_0);
				taskCompletionSource.SetResult(result);
			}
			catch (Exception exception)
			{
				taskCompletionSource.SetException(exception);
			}
		}
		return taskCompletionSource.Task;
	}

	public Task<int> method_11(int int_1, int int_2, params DataTable[] dataTable_0)
	{
		return method_12(int_1, int_2, CancellationToken.None, dataTable_0);
	}

	public Task<int> method_12(int int_1, int int_2, CancellationToken cancellationToken_0, params DataTable[] dataTable_0)
	{
		TaskCompletionSource<int> taskCompletionSource = new TaskCompletionSource<int>();
		if (!(cancellationToken_0 == CancellationToken.None) && cancellationToken_0.IsCancellationRequested)
		{
			taskCompletionSource.SetCanceled();
		}
		else
		{
			try
			{
				int result = Fill(int_1, int_2, dataTable_0);
				taskCompletionSource.SetResult(result);
			}
			catch (Exception exception)
			{
				taskCompletionSource.SetException(exception);
			}
		}
		return taskCompletionSource.Task;
	}

	public Task<int> method_13(DataSet dataSet_0, int int_1, int int_2, string string_0)
	{
		return method_14(dataSet_0, int_1, int_2, string_0, CancellationToken.None);
	}

	public Task<int> method_14(DataSet dataSet_0, int int_1, int int_2, string string_0, CancellationToken cancellationToken_0)
	{
		TaskCompletionSource<int> taskCompletionSource = new TaskCompletionSource<int>();
		if (!(cancellationToken_0 == CancellationToken.None) && cancellationToken_0.IsCancellationRequested)
		{
			taskCompletionSource.SetCanceled();
		}
		else
		{
			try
			{
				int result = Fill(dataSet_0, int_1, int_2, string_0);
				taskCompletionSource.SetResult(result);
			}
			catch (Exception exception)
			{
				taskCompletionSource.SetException(exception);
			}
		}
		return taskCompletionSource.Task;
	}

	public Task<int> method_15(DataSet dataSet_0, string string_0, IDataReader idataReader_0, int int_1, int int_2)
	{
		return method_16(dataSet_0, string_0, idataReader_0, int_1, int_2, CancellationToken.None);
	}

	public Task<int> method_16(DataSet dataSet_0, string string_0, IDataReader idataReader_0, int int_1, int int_2, CancellationToken cancellationToken_0)
	{
		TaskCompletionSource<int> taskCompletionSource = new TaskCompletionSource<int>();
		if (!(cancellationToken_0 == CancellationToken.None) && cancellationToken_0.IsCancellationRequested)
		{
			taskCompletionSource.SetCanceled();
		}
		else
		{
			try
			{
				int result = base.Fill(dataSet_0, string_0, idataReader_0, int_1, int_2);
				taskCompletionSource.SetResult(result);
			}
			catch (Exception exception)
			{
				taskCompletionSource.SetException(exception);
			}
		}
		return taskCompletionSource.Task;
	}

	public Task<int> method_17(DataTable[] dataTable_0, int int_1, int int_2, IDbCommand idbCommand_0, CommandBehavior commandBehavior_0)
	{
		return method_18(dataTable_0, int_1, int_2, idbCommand_0, commandBehavior_0, CancellationToken.None);
	}

	public Task<int> method_18(DataTable[] dataTable_0, int int_1, int int_2, IDbCommand idbCommand_0, CommandBehavior commandBehavior_0, CancellationToken cancellationToken_0)
	{
		TaskCompletionSource<int> taskCompletionSource = new TaskCompletionSource<int>();
		if (!(cancellationToken_0 == CancellationToken.None) && cancellationToken_0.IsCancellationRequested)
		{
			taskCompletionSource.SetCanceled();
		}
		else
		{
			try
			{
				int result = base.Fill(dataTable_0, int_1, int_2, idbCommand_0, commandBehavior_0);
				taskCompletionSource.SetResult(result);
			}
			catch (Exception exception)
			{
				taskCompletionSource.SetException(exception);
			}
		}
		return taskCompletionSource.Task;
	}

	public Task<int> method_19(DataSet dataSet_0, int int_1, int int_2, string string_0, IDbCommand idbCommand_0, CommandBehavior commandBehavior_0)
	{
		return method_20(dataSet_0, int_1, int_2, string_0, idbCommand_0, commandBehavior_0, CancellationToken.None);
	}

	public Task<int> method_20(DataSet dataSet_0, int int_1, int int_2, string string_0, IDbCommand idbCommand_0, CommandBehavior commandBehavior_0, CancellationToken cancellationToken_0)
	{
		TaskCompletionSource<int> taskCompletionSource = new TaskCompletionSource<int>();
		if (!(cancellationToken_0 == CancellationToken.None) && cancellationToken_0.IsCancellationRequested)
		{
			taskCompletionSource.SetCanceled();
		}
		else
		{
			try
			{
				int result = base.Fill(dataSet_0, int_1, int_2, string_0, idbCommand_0, commandBehavior_0);
				taskCompletionSource.SetResult(result);
			}
			catch (Exception exception)
			{
				taskCompletionSource.SetException(exception);
			}
		}
		return taskCompletionSource.Task;
	}

	public Task<DataTable[]> method_21(DataSet dataSet_0, SchemaType schemaType_0)
	{
		return method_22(dataSet_0, schemaType_0, CancellationToken.None);
	}

	public Task<DataTable[]> method_22(DataSet dataSet_0, SchemaType schemaType_0, CancellationToken cancellationToken_0)
	{
		TaskCompletionSource<DataTable[]> taskCompletionSource = new TaskCompletionSource<DataTable[]>();
		if (!(cancellationToken_0 == CancellationToken.None) && cancellationToken_0.IsCancellationRequested)
		{
			taskCompletionSource.SetCanceled();
		}
		else
		{
			try
			{
				DataTable[] result = FillSchema(dataSet_0, schemaType_0);
				taskCompletionSource.SetResult(result);
			}
			catch (Exception exception)
			{
				taskCompletionSource.SetException(exception);
			}
		}
		return taskCompletionSource.Task;
	}

	public Task<DataTable[]> method_23(DataSet dataSet_0, SchemaType schemaType_0, string string_0)
	{
		return method_24(dataSet_0, schemaType_0, string_0, CancellationToken.None);
	}

	public Task<DataTable[]> method_24(DataSet dataSet_0, SchemaType schemaType_0, string string_0, CancellationToken cancellationToken_0)
	{
		TaskCompletionSource<DataTable[]> taskCompletionSource = new TaskCompletionSource<DataTable[]>();
		if (!(cancellationToken_0 == CancellationToken.None) && cancellationToken_0.IsCancellationRequested)
		{
			taskCompletionSource.SetCanceled();
		}
		else
		{
			try
			{
				DataTable[] result = FillSchema(dataSet_0, schemaType_0, string_0);
				taskCompletionSource.SetResult(result);
			}
			catch (Exception exception)
			{
				taskCompletionSource.SetException(exception);
			}
		}
		return taskCompletionSource.Task;
	}

	public Task<DataTable[]> method_25(DataSet dataSet_0, SchemaType schemaType_0, string string_0, IDataReader idataReader_0)
	{
		return method_26(dataSet_0, schemaType_0, string_0, idataReader_0, CancellationToken.None);
	}

	public Task<DataTable[]> method_26(DataSet dataSet_0, SchemaType schemaType_0, string string_0, IDataReader idataReader_0, CancellationToken cancellationToken_0)
	{
		TaskCompletionSource<DataTable[]> taskCompletionSource = new TaskCompletionSource<DataTable[]>();
		if (!(cancellationToken_0 == CancellationToken.None) && cancellationToken_0.IsCancellationRequested)
		{
			taskCompletionSource.SetCanceled();
		}
		else
		{
			try
			{
				DataTable[] result = base.FillSchema(dataSet_0, schemaType_0, string_0, idataReader_0);
				taskCompletionSource.SetResult(result);
			}
			catch (Exception exception)
			{
				taskCompletionSource.SetException(exception);
			}
		}
		return taskCompletionSource.Task;
	}

	public Task<DataTable[]> method_27(DataSet dataSet_0, SchemaType schemaType_0, IDbCommand idbCommand_0, string string_0, CommandBehavior commandBehavior_0)
	{
		return method_28(dataSet_0, schemaType_0, idbCommand_0, string_0, commandBehavior_0, CancellationToken.None);
	}

	public Task<DataTable[]> method_28(DataSet dataSet_0, SchemaType schemaType_0, IDbCommand idbCommand_0, string string_0, CommandBehavior commandBehavior_0, CancellationToken cancellationToken_0)
	{
		TaskCompletionSource<DataTable[]> taskCompletionSource = new TaskCompletionSource<DataTable[]>();
		if (!(cancellationToken_0 == CancellationToken.None) && cancellationToken_0.IsCancellationRequested)
		{
			taskCompletionSource.SetCanceled();
		}
		else
		{
			try
			{
				DataTable[] result = base.FillSchema(dataSet_0, schemaType_0, idbCommand_0, string_0, commandBehavior_0);
				taskCompletionSource.SetResult(result);
			}
			catch (Exception exception)
			{
				taskCompletionSource.SetException(exception);
			}
		}
		return taskCompletionSource.Task;
	}

	public Task<DataTable> method_29(DataTable dataTable_0, SchemaType schemaType_0)
	{
		return method_30(dataTable_0, schemaType_0, CancellationToken.None);
	}

	public Task<DataTable> method_30(DataTable dataTable_0, SchemaType schemaType_0, CancellationToken cancellationToken_0)
	{
		TaskCompletionSource<DataTable> taskCompletionSource = new TaskCompletionSource<DataTable>();
		if (!(cancellationToken_0 == CancellationToken.None) && cancellationToken_0.IsCancellationRequested)
		{
			taskCompletionSource.SetCanceled();
		}
		else
		{
			try
			{
				DataTable result = FillSchema(dataTable_0, schemaType_0);
				taskCompletionSource.SetResult(result);
			}
			catch (Exception exception)
			{
				taskCompletionSource.SetException(exception);
			}
		}
		return taskCompletionSource.Task;
	}

	public Task<DataTable> method_31(DataTable dataTable_0, SchemaType schemaType_0, IDataReader idataReader_0)
	{
		return method_32(dataTable_0, schemaType_0, idataReader_0, CancellationToken.None);
	}

	public Task<DataTable> method_32(DataTable dataTable_0, SchemaType schemaType_0, IDataReader idataReader_0, CancellationToken cancellationToken_0)
	{
		TaskCompletionSource<DataTable> taskCompletionSource = new TaskCompletionSource<DataTable>();
		if (!(cancellationToken_0 == CancellationToken.None) && cancellationToken_0.IsCancellationRequested)
		{
			taskCompletionSource.SetCanceled();
		}
		else
		{
			try
			{
				DataTable result = base.FillSchema(dataTable_0, schemaType_0, idataReader_0);
				taskCompletionSource.SetResult(result);
			}
			catch (Exception exception)
			{
				taskCompletionSource.SetException(exception);
			}
		}
		return taskCompletionSource.Task;
	}

	public Task<DataTable> method_33(DataTable dataTable_0, SchemaType schemaType_0, IDbCommand idbCommand_0, CommandBehavior commandBehavior_0)
	{
		return method_34(dataTable_0, schemaType_0, idbCommand_0, commandBehavior_0, CancellationToken.None);
	}

	public Task<DataTable> method_34(DataTable dataTable_0, SchemaType schemaType_0, IDbCommand idbCommand_0, CommandBehavior commandBehavior_0, CancellationToken cancellationToken_0)
	{
		TaskCompletionSource<DataTable> taskCompletionSource = new TaskCompletionSource<DataTable>();
		if (!(cancellationToken_0 == CancellationToken.None) && cancellationToken_0.IsCancellationRequested)
		{
			taskCompletionSource.SetCanceled();
		}
		else
		{
			try
			{
				DataTable result = base.FillSchema(dataTable_0, schemaType_0, idbCommand_0, commandBehavior_0);
				taskCompletionSource.SetResult(result);
			}
			catch (Exception exception)
			{
				taskCompletionSource.SetException(exception);
			}
		}
		return taskCompletionSource.Task;
	}

	public Task<int> method_35(DataRow[] dataRow_0)
	{
		return method_36(dataRow_0, CancellationToken.None);
	}

	public Task<int> method_36(DataRow[] dataRow_0, CancellationToken cancellationToken_0)
	{
		TaskCompletionSource<int> taskCompletionSource = new TaskCompletionSource<int>();
		if (!(cancellationToken_0 == CancellationToken.None) && cancellationToken_0.IsCancellationRequested)
		{
			taskCompletionSource.SetCanceled();
		}
		else
		{
			try
			{
				int result = Update(dataRow_0);
				taskCompletionSource.SetResult(result);
			}
			catch (Exception exception)
			{
				taskCompletionSource.SetException(exception);
			}
		}
		return taskCompletionSource.Task;
	}

	public Task<int> method_37(DataSet dataSet_0)
	{
		return method_38(dataSet_0, CancellationToken.None);
	}

	public Task<int> method_38(DataSet dataSet_0, CancellationToken cancellationToken_0)
	{
		TaskCompletionSource<int> taskCompletionSource = new TaskCompletionSource<int>();
		if (!(cancellationToken_0 == CancellationToken.None) && cancellationToken_0.IsCancellationRequested)
		{
			taskCompletionSource.SetCanceled();
		}
		else
		{
			try
			{
				int result = Update(dataSet_0);
				taskCompletionSource.SetResult(result);
			}
			catch (Exception exception)
			{
				taskCompletionSource.SetException(exception);
			}
		}
		return taskCompletionSource.Task;
	}

	public Task<int> method_39(DataTable dataTable_0)
	{
		return method_40(dataTable_0, CancellationToken.None);
	}

	public Task<int> method_40(DataTable dataTable_0, CancellationToken cancellationToken_0)
	{
		TaskCompletionSource<int> taskCompletionSource = new TaskCompletionSource<int>();
		if (!(cancellationToken_0 == CancellationToken.None) && cancellationToken_0.IsCancellationRequested)
		{
			taskCompletionSource.SetCanceled();
		}
		else
		{
			try
			{
				int result = Update(dataTable_0);
				taskCompletionSource.SetResult(result);
			}
			catch (Exception exception)
			{
				taskCompletionSource.SetException(exception);
			}
		}
		return taskCompletionSource.Task;
	}

	public Task<int> method_41(DataRow[] dataRow_0, DataTableMapping dataTableMapping_0)
	{
		return method_42(dataRow_0, dataTableMapping_0, CancellationToken.None);
	}

	public Task<int> method_42(DataRow[] dataRow_0, DataTableMapping dataTableMapping_0, CancellationToken cancellationToken_0)
	{
		TaskCompletionSource<int> taskCompletionSource = new TaskCompletionSource<int>();
		if (!(cancellationToken_0 == CancellationToken.None) && cancellationToken_0.IsCancellationRequested)
		{
			taskCompletionSource.SetCanceled();
		}
		else
		{
			try
			{
				int result = base.Update(dataRow_0, dataTableMapping_0);
				taskCompletionSource.SetResult(result);
			}
			catch (Exception exception)
			{
				taskCompletionSource.SetException(exception);
			}
		}
		return taskCompletionSource.Task;
	}

	public Task<int> method_43(DataSet dataSet_0, string string_0)
	{
		return method_44(dataSet_0, string_0, CancellationToken.None);
	}

	public Task<int> method_44(DataSet dataSet_0, string string_0, CancellationToken cancellationToken_0)
	{
		TaskCompletionSource<int> taskCompletionSource = new TaskCompletionSource<int>();
		if (!(cancellationToken_0 == CancellationToken.None) && cancellationToken_0.IsCancellationRequested)
		{
			taskCompletionSource.SetCanceled();
		}
		else
		{
			try
			{
				int result = Update(dataSet_0, string_0);
				taskCompletionSource.SetResult(result);
			}
			catch (Exception exception)
			{
				taskCompletionSource.SetException(exception);
			}
		}
		return taskCompletionSource.Task;
	}
}
