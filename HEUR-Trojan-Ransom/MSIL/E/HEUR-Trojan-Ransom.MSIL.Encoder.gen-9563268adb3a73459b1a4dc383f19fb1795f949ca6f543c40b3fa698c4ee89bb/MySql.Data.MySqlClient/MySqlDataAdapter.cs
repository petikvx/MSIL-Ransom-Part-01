using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;

namespace MySql.Data.MySqlClient;

[Designer("MySql.Data.MySqlClient.Design.MySqlDataAdapterDesigner,MySqlClient.Design")]
[DesignerCategory("Code")]
[ToolboxBitmap(typeof(MySqlDataAdapter), "MySqlClient.resources.dataadapter.bmp")]
public sealed class MySqlDataAdapter : DbDataAdapter, IDbDataAdapter, IDataAdapter
{
	private bool loadingDefaults;

	private int updateBatchSize;

	private List<IDbCommand> commandBatch;

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

	[Description("Used during Fill/FillSchema")]
	[Category("Fill")]
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
			return loadingDefaults;
		}
		set
		{
			loadingDefaults = value;
		}
	}

	public override int UpdateBatchSize
	{
		get
		{
			return updateBatchSize;
		}
		set
		{
			updateBatchSize = value;
		}
	}

	public event MySqlRowUpdatingEventHandler RowUpdating;

	public event MySqlRowUpdatedEventHandler RowUpdated;

	public MySqlDataAdapter()
	{
		loadingDefaults = true;
		updateBatchSize = 1;
	}

	public MySqlDataAdapter(MySqlCommand selectCommand)
		: this()
	{
		SelectCommand = selectCommand;
	}

	public MySqlDataAdapter(string selectCommandText, MySqlConnection connection)
		: this()
	{
		SelectCommand = new MySqlCommand(selectCommandText, connection);
	}

	public MySqlDataAdapter(string selectCommandText, string selectConnString)
		: this()
	{
		SelectCommand = new MySqlCommand(selectCommandText, new MySqlConnection(selectConnString));
	}

	private void OpenConnectionIfClosed(DataRowState state, List<MySqlConnection> openedConnections)
	{
		MySqlCommand mySqlCommand = null;
		switch (state)
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
		if (mySqlCommand != null && mySqlCommand.Connection != null && mySqlCommand.Connection.connectionState == ConnectionState.Closed)
		{
			mySqlCommand.Connection.Open();
			openedConnections.Add(mySqlCommand.Connection);
		}
	}

	protected override int Update(DataRow[] dataRows, DataTableMapping tableMapping)
	{
		List<MySqlConnection> list = new List<MySqlConnection>();
		try
		{
			foreach (DataRow dataRow in dataRows)
			{
				OpenConnectionIfClosed(dataRow.RowState, list);
			}
			return base.Update(dataRows, tableMapping);
		}
		finally
		{
			foreach (MySqlConnection item in list)
			{
				item.Close();
			}
		}
	}

	protected override void InitializeBatching()
	{
		commandBatch = new List<IDbCommand>();
	}

	protected override int AddToBatch(IDbCommand command)
	{
		MySqlCommand mySqlCommand = (MySqlCommand)command;
		if (mySqlCommand.BatchableCommandText == null)
		{
			mySqlCommand.GetCommandTextForBatching();
		}
		IDbCommand item = (IDbCommand)((ICloneable)command).Clone();
		commandBatch.Add(item);
		return commandBatch.Count - 1;
	}

	protected override int ExecuteBatch()
	{
		int num = 0;
		int num2 = 0;
		while (num2 < commandBatch.Count)
		{
			MySqlCommand mySqlCommand = (MySqlCommand)commandBatch[num2++];
			int num3 = num2;
			while (num3 < commandBatch.Count)
			{
				MySqlCommand mySqlCommand2 = (MySqlCommand)commandBatch[num3];
				if (mySqlCommand2.BatchableCommandText == null || mySqlCommand2.CommandText != mySqlCommand.CommandText)
				{
					break;
				}
				mySqlCommand.AddToBatch(mySqlCommand2);
				num3++;
				num2++;
			}
			num += mySqlCommand.ExecuteNonQuery();
		}
		return num;
	}

	protected override void ClearBatch()
	{
		if (commandBatch.Count > 0)
		{
			MySqlCommand mySqlCommand = (MySqlCommand)commandBatch[0];
			if (mySqlCommand.Batch != null)
			{
				mySqlCommand.Batch.Clear();
			}
		}
		commandBatch.Clear();
	}

	protected override void TerminateBatching()
	{
		ClearBatch();
		commandBatch = null;
	}

	protected override IDataParameter GetBatchedParameter(int commandIdentifier, int parameterIndex)
	{
		return (IDataParameter)commandBatch[commandIdentifier].Parameters[parameterIndex];
	}

	protected override RowUpdatedEventArgs CreateRowUpdatedEvent(DataRow dataRow, IDbCommand command, StatementType statementType, DataTableMapping tableMapping)
	{
		return new MySqlRowUpdatedEventArgs(dataRow, command, statementType, tableMapping);
	}

	protected override RowUpdatingEventArgs CreateRowUpdatingEvent(DataRow dataRow, IDbCommand command, StatementType statementType, DataTableMapping tableMapping)
	{
		return new MySqlRowUpdatingEventArgs(dataRow, command, statementType, tableMapping);
	}

	protected override void OnRowUpdating(RowUpdatingEventArgs value)
	{
		if (this.RowUpdating != null)
		{
			this.RowUpdating(this, value as MySqlRowUpdatingEventArgs);
		}
	}

	protected override void OnRowUpdated(RowUpdatedEventArgs value)
	{
		if (this.RowUpdated != null)
		{
			this.RowUpdated(this, value as MySqlRowUpdatedEventArgs);
		}
	}

	public Task<int> FillAsync(DataSet dataSet)
	{
		return FillAsync(dataSet, CancellationToken.None);
	}

	public Task<int> FillAsync(DataSet dataSet, CancellationToken cancellationToken)
	{
		TaskCompletionSource<int> taskCompletionSource = new TaskCompletionSource<int>();
		if (!(cancellationToken == CancellationToken.None) && cancellationToken.IsCancellationRequested)
		{
			taskCompletionSource.SetCanceled();
		}
		else
		{
			try
			{
				int result = Fill(dataSet);
				taskCompletionSource.SetResult(result);
			}
			catch (Exception exception)
			{
				taskCompletionSource.SetException(exception);
			}
		}
		return taskCompletionSource.Task;
	}

	public Task<int> FillAsync(DataTable dataTable)
	{
		return FillAsync(dataTable, CancellationToken.None);
	}

	public Task<int> FillAsync(DataTable dataTable, CancellationToken cancellationToken)
	{
		TaskCompletionSource<int> taskCompletionSource = new TaskCompletionSource<int>();
		if (!(cancellationToken == CancellationToken.None) && cancellationToken.IsCancellationRequested)
		{
			taskCompletionSource.SetCanceled();
		}
		else
		{
			try
			{
				int result = Fill(dataTable);
				taskCompletionSource.SetResult(result);
			}
			catch (Exception exception)
			{
				taskCompletionSource.SetException(exception);
			}
		}
		return taskCompletionSource.Task;
	}

	public Task<int> FillAsync(DataSet dataSet, string srcTable)
	{
		return FillAsync(dataSet, srcTable, CancellationToken.None);
	}

	public Task<int> FillAsync(DataSet dataSet, string srcTable, CancellationToken cancellationToken)
	{
		TaskCompletionSource<int> taskCompletionSource = new TaskCompletionSource<int>();
		if (!(cancellationToken == CancellationToken.None) && cancellationToken.IsCancellationRequested)
		{
			taskCompletionSource.SetCanceled();
		}
		else
		{
			try
			{
				int result = Fill(dataSet, srcTable);
				taskCompletionSource.SetResult(result);
			}
			catch (Exception exception)
			{
				taskCompletionSource.SetException(exception);
			}
		}
		return taskCompletionSource.Task;
	}

	public Task<int> FillAsync(DataTable dataTable, IDataReader dataReader)
	{
		return FillAsync(dataTable, dataReader, CancellationToken.None);
	}

	public Task<int> FillAsync(DataTable dataTable, IDataReader dataReader, CancellationToken cancellationToken)
	{
		TaskCompletionSource<int> taskCompletionSource = new TaskCompletionSource<int>();
		if (!(cancellationToken == CancellationToken.None) && cancellationToken.IsCancellationRequested)
		{
			taskCompletionSource.SetCanceled();
		}
		else
		{
			try
			{
				int result = base.Fill(dataTable, dataReader);
				taskCompletionSource.SetResult(result);
			}
			catch (Exception exception)
			{
				taskCompletionSource.SetException(exception);
			}
		}
		return taskCompletionSource.Task;
	}

	public Task<int> FillAsync(DataTable dataTable, IDbCommand command, CommandBehavior behavior)
	{
		return FillAsync(dataTable, command, behavior, CancellationToken.None);
	}

	public Task<int> FillAsync(DataTable dataTable, IDbCommand command, CommandBehavior behavior, CancellationToken cancellationToken)
	{
		TaskCompletionSource<int> taskCompletionSource = new TaskCompletionSource<int>();
		if (!(cancellationToken == CancellationToken.None) && cancellationToken.IsCancellationRequested)
		{
			taskCompletionSource.SetCanceled();
		}
		else
		{
			try
			{
				int result = base.Fill(dataTable, command, behavior);
				taskCompletionSource.SetResult(result);
			}
			catch (Exception exception)
			{
				taskCompletionSource.SetException(exception);
			}
		}
		return taskCompletionSource.Task;
	}

	public Task<int> FillAsync(int startRecord, int maxRecords, params DataTable[] dataTables)
	{
		return FillAsync(startRecord, maxRecords, CancellationToken.None, dataTables);
	}

	public Task<int> FillAsync(int startRecord, int maxRecords, CancellationToken cancellationToken, params DataTable[] dataTables)
	{
		TaskCompletionSource<int> taskCompletionSource = new TaskCompletionSource<int>();
		if (!(cancellationToken == CancellationToken.None) && cancellationToken.IsCancellationRequested)
		{
			taskCompletionSource.SetCanceled();
		}
		else
		{
			try
			{
				int result = Fill(startRecord, maxRecords, dataTables);
				taskCompletionSource.SetResult(result);
			}
			catch (Exception exception)
			{
				taskCompletionSource.SetException(exception);
			}
		}
		return taskCompletionSource.Task;
	}

	public Task<int> FillAsync(DataSet dataSet, int startRecord, int maxRecords, string srcTable)
	{
		return FillAsync(dataSet, startRecord, maxRecords, srcTable, CancellationToken.None);
	}

	public Task<int> FillAsync(DataSet dataSet, int startRecord, int maxRecords, string srcTable, CancellationToken cancellationToken)
	{
		TaskCompletionSource<int> taskCompletionSource = new TaskCompletionSource<int>();
		if (!(cancellationToken == CancellationToken.None) && cancellationToken.IsCancellationRequested)
		{
			taskCompletionSource.SetCanceled();
		}
		else
		{
			try
			{
				int result = Fill(dataSet, startRecord, maxRecords, srcTable);
				taskCompletionSource.SetResult(result);
			}
			catch (Exception exception)
			{
				taskCompletionSource.SetException(exception);
			}
		}
		return taskCompletionSource.Task;
	}

	public Task<int> FillAsync(DataSet dataSet, string srcTable, IDataReader dataReader, int startRecord, int maxRecords)
	{
		return FillAsync(dataSet, srcTable, dataReader, startRecord, maxRecords, CancellationToken.None);
	}

	public Task<int> FillAsync(DataSet dataSet, string srcTable, IDataReader dataReader, int startRecord, int maxRecords, CancellationToken cancellationToken)
	{
		TaskCompletionSource<int> taskCompletionSource = new TaskCompletionSource<int>();
		if (!(cancellationToken == CancellationToken.None) && cancellationToken.IsCancellationRequested)
		{
			taskCompletionSource.SetCanceled();
		}
		else
		{
			try
			{
				int result = base.Fill(dataSet, srcTable, dataReader, startRecord, maxRecords);
				taskCompletionSource.SetResult(result);
			}
			catch (Exception exception)
			{
				taskCompletionSource.SetException(exception);
			}
		}
		return taskCompletionSource.Task;
	}

	public Task<int> FillAsync(DataTable[] dataTables, int startRecord, int maxRecords, IDbCommand command, CommandBehavior behavior)
	{
		return FillAsync(dataTables, startRecord, maxRecords, command, behavior, CancellationToken.None);
	}

	public Task<int> FillAsync(DataTable[] dataTables, int startRecord, int maxRecords, IDbCommand command, CommandBehavior behavior, CancellationToken cancellationToken)
	{
		TaskCompletionSource<int> taskCompletionSource = new TaskCompletionSource<int>();
		if (!(cancellationToken == CancellationToken.None) && cancellationToken.IsCancellationRequested)
		{
			taskCompletionSource.SetCanceled();
		}
		else
		{
			try
			{
				int result = base.Fill(dataTables, startRecord, maxRecords, command, behavior);
				taskCompletionSource.SetResult(result);
			}
			catch (Exception exception)
			{
				taskCompletionSource.SetException(exception);
			}
		}
		return taskCompletionSource.Task;
	}

	public Task<int> FillAsync(DataSet dataSet, int startRecord, int maxRecords, string srcTable, IDbCommand command, CommandBehavior behavior)
	{
		return FillAsync(dataSet, startRecord, maxRecords, srcTable, command, behavior, CancellationToken.None);
	}

	public Task<int> FillAsync(DataSet dataSet, int startRecord, int maxRecords, string srcTable, IDbCommand command, CommandBehavior behavior, CancellationToken cancellationToken)
	{
		TaskCompletionSource<int> taskCompletionSource = new TaskCompletionSource<int>();
		if (!(cancellationToken == CancellationToken.None) && cancellationToken.IsCancellationRequested)
		{
			taskCompletionSource.SetCanceled();
		}
		else
		{
			try
			{
				int result = base.Fill(dataSet, startRecord, maxRecords, srcTable, command, behavior);
				taskCompletionSource.SetResult(result);
			}
			catch (Exception exception)
			{
				taskCompletionSource.SetException(exception);
			}
		}
		return taskCompletionSource.Task;
	}

	public Task<DataTable[]> FillSchemaAsync(DataSet dataSet, SchemaType schemaType)
	{
		return FillSchemaAsync(dataSet, schemaType, CancellationToken.None);
	}

	public Task<DataTable[]> FillSchemaAsync(DataSet dataSet, SchemaType schemaType, CancellationToken cancellationToken)
	{
		TaskCompletionSource<DataTable[]> taskCompletionSource = new TaskCompletionSource<DataTable[]>();
		if (!(cancellationToken == CancellationToken.None) && cancellationToken.IsCancellationRequested)
		{
			taskCompletionSource.SetCanceled();
		}
		else
		{
			try
			{
				DataTable[] result = FillSchema(dataSet, schemaType);
				taskCompletionSource.SetResult(result);
			}
			catch (Exception exception)
			{
				taskCompletionSource.SetException(exception);
			}
		}
		return taskCompletionSource.Task;
	}

	public Task<DataTable[]> FillSchemaAsync(DataSet dataSet, SchemaType schemaType, string srcTable)
	{
		return FillSchemaAsync(dataSet, schemaType, srcTable, CancellationToken.None);
	}

	public Task<DataTable[]> FillSchemaAsync(DataSet dataSet, SchemaType schemaType, string srcTable, CancellationToken cancellationToken)
	{
		TaskCompletionSource<DataTable[]> taskCompletionSource = new TaskCompletionSource<DataTable[]>();
		if (!(cancellationToken == CancellationToken.None) && cancellationToken.IsCancellationRequested)
		{
			taskCompletionSource.SetCanceled();
		}
		else
		{
			try
			{
				DataTable[] result = FillSchema(dataSet, schemaType, srcTable);
				taskCompletionSource.SetResult(result);
			}
			catch (Exception exception)
			{
				taskCompletionSource.SetException(exception);
			}
		}
		return taskCompletionSource.Task;
	}

	public Task<DataTable[]> FillSchemaAsync(DataSet dataSet, SchemaType schemaType, string srcTable, IDataReader dataReader)
	{
		return FillSchemaAsync(dataSet, schemaType, srcTable, dataReader, CancellationToken.None);
	}

	public Task<DataTable[]> FillSchemaAsync(DataSet dataSet, SchemaType schemaType, string srcTable, IDataReader dataReader, CancellationToken cancellationToken)
	{
		TaskCompletionSource<DataTable[]> taskCompletionSource = new TaskCompletionSource<DataTable[]>();
		if (!(cancellationToken == CancellationToken.None) && cancellationToken.IsCancellationRequested)
		{
			taskCompletionSource.SetCanceled();
		}
		else
		{
			try
			{
				DataTable[] result = base.FillSchema(dataSet, schemaType, srcTable, dataReader);
				taskCompletionSource.SetResult(result);
			}
			catch (Exception exception)
			{
				taskCompletionSource.SetException(exception);
			}
		}
		return taskCompletionSource.Task;
	}

	public Task<DataTable[]> FillSchemaAsync(DataSet dataSet, SchemaType schemaType, IDbCommand command, string srcTable, CommandBehavior behavior)
	{
		return FillSchemaAsync(dataSet, schemaType, command, srcTable, behavior, CancellationToken.None);
	}

	public Task<DataTable[]> FillSchemaAsync(DataSet dataSet, SchemaType schemaType, IDbCommand command, string srcTable, CommandBehavior behavior, CancellationToken cancellationToken)
	{
		TaskCompletionSource<DataTable[]> taskCompletionSource = new TaskCompletionSource<DataTable[]>();
		if (!(cancellationToken == CancellationToken.None) && cancellationToken.IsCancellationRequested)
		{
			taskCompletionSource.SetCanceled();
		}
		else
		{
			try
			{
				DataTable[] result = base.FillSchema(dataSet, schemaType, command, srcTable, behavior);
				taskCompletionSource.SetResult(result);
			}
			catch (Exception exception)
			{
				taskCompletionSource.SetException(exception);
			}
		}
		return taskCompletionSource.Task;
	}

	public Task<DataTable> FillSchemaAsync(DataTable dataTable, SchemaType schemaType)
	{
		return FillSchemaAsync(dataTable, schemaType, CancellationToken.None);
	}

	public Task<DataTable> FillSchemaAsync(DataTable dataTable, SchemaType schemaType, CancellationToken cancellationToken)
	{
		TaskCompletionSource<DataTable> taskCompletionSource = new TaskCompletionSource<DataTable>();
		if (!(cancellationToken == CancellationToken.None) && cancellationToken.IsCancellationRequested)
		{
			taskCompletionSource.SetCanceled();
		}
		else
		{
			try
			{
				DataTable result = FillSchema(dataTable, schemaType);
				taskCompletionSource.SetResult(result);
			}
			catch (Exception exception)
			{
				taskCompletionSource.SetException(exception);
			}
		}
		return taskCompletionSource.Task;
	}

	public Task<DataTable> FillSchemaAsync(DataTable dataTable, SchemaType schemaType, IDataReader dataReader)
	{
		return FillSchemaAsync(dataTable, schemaType, dataReader, CancellationToken.None);
	}

	public Task<DataTable> FillSchemaAsync(DataTable dataTable, SchemaType schemaType, IDataReader dataReader, CancellationToken cancellationToken)
	{
		TaskCompletionSource<DataTable> taskCompletionSource = new TaskCompletionSource<DataTable>();
		if (!(cancellationToken == CancellationToken.None) && cancellationToken.IsCancellationRequested)
		{
			taskCompletionSource.SetCanceled();
		}
		else
		{
			try
			{
				DataTable result = base.FillSchema(dataTable, schemaType, dataReader);
				taskCompletionSource.SetResult(result);
			}
			catch (Exception exception)
			{
				taskCompletionSource.SetException(exception);
			}
		}
		return taskCompletionSource.Task;
	}

	public Task<DataTable> FillSchemaAsync(DataTable dataTable, SchemaType schemaType, IDbCommand command, CommandBehavior behavior)
	{
		return FillSchemaAsync(dataTable, schemaType, command, behavior, CancellationToken.None);
	}

	public Task<DataTable> FillSchemaAsync(DataTable dataTable, SchemaType schemaType, IDbCommand command, CommandBehavior behavior, CancellationToken cancellationToken)
	{
		TaskCompletionSource<DataTable> taskCompletionSource = new TaskCompletionSource<DataTable>();
		if (!(cancellationToken == CancellationToken.None) && cancellationToken.IsCancellationRequested)
		{
			taskCompletionSource.SetCanceled();
		}
		else
		{
			try
			{
				DataTable result = base.FillSchema(dataTable, schemaType, command, behavior);
				taskCompletionSource.SetResult(result);
			}
			catch (Exception exception)
			{
				taskCompletionSource.SetException(exception);
			}
		}
		return taskCompletionSource.Task;
	}

	public Task<int> UpdateAsync(DataRow[] dataRows)
	{
		return UpdateAsync(dataRows, CancellationToken.None);
	}

	public Task<int> UpdateAsync(DataRow[] dataRows, CancellationToken cancellationToken)
	{
		TaskCompletionSource<int> taskCompletionSource = new TaskCompletionSource<int>();
		if (!(cancellationToken == CancellationToken.None) && cancellationToken.IsCancellationRequested)
		{
			taskCompletionSource.SetCanceled();
		}
		else
		{
			try
			{
				int result = Update(dataRows);
				taskCompletionSource.SetResult(result);
			}
			catch (Exception exception)
			{
				taskCompletionSource.SetException(exception);
			}
		}
		return taskCompletionSource.Task;
	}

	public Task<int> UpdateAsync(DataSet dataSet)
	{
		return UpdateAsync(dataSet, CancellationToken.None);
	}

	public Task<int> UpdateAsync(DataSet dataSet, CancellationToken cancellationToken)
	{
		TaskCompletionSource<int> taskCompletionSource = new TaskCompletionSource<int>();
		if (!(cancellationToken == CancellationToken.None) && cancellationToken.IsCancellationRequested)
		{
			taskCompletionSource.SetCanceled();
		}
		else
		{
			try
			{
				int result = Update(dataSet);
				taskCompletionSource.SetResult(result);
			}
			catch (Exception exception)
			{
				taskCompletionSource.SetException(exception);
			}
		}
		return taskCompletionSource.Task;
	}

	public Task<int> UpdateAsync(DataTable dataTable)
	{
		return UpdateAsync(dataTable, CancellationToken.None);
	}

	public Task<int> UpdateAsync(DataTable dataTable, CancellationToken cancellationToken)
	{
		TaskCompletionSource<int> taskCompletionSource = new TaskCompletionSource<int>();
		if (!(cancellationToken == CancellationToken.None) && cancellationToken.IsCancellationRequested)
		{
			taskCompletionSource.SetCanceled();
		}
		else
		{
			try
			{
				int result = Update(dataTable);
				taskCompletionSource.SetResult(result);
			}
			catch (Exception exception)
			{
				taskCompletionSource.SetException(exception);
			}
		}
		return taskCompletionSource.Task;
	}

	public Task<int> UpdateAsync(DataRow[] dataRows, DataTableMapping tableMapping)
	{
		return UpdateAsync(dataRows, tableMapping, CancellationToken.None);
	}

	public Task<int> UpdateAsync(DataRow[] dataRows, DataTableMapping tableMapping, CancellationToken cancellationToken)
	{
		TaskCompletionSource<int> taskCompletionSource = new TaskCompletionSource<int>();
		if (!(cancellationToken == CancellationToken.None) && cancellationToken.IsCancellationRequested)
		{
			taskCompletionSource.SetCanceled();
		}
		else
		{
			try
			{
				int result = base.Update(dataRows, tableMapping);
				taskCompletionSource.SetResult(result);
			}
			catch (Exception exception)
			{
				taskCompletionSource.SetException(exception);
			}
		}
		return taskCompletionSource.Task;
	}

	public Task<int> UpdateAsync(DataSet dataSet, string srcTable)
	{
		return UpdateAsync(dataSet, srcTable, CancellationToken.None);
	}

	public Task<int> UpdateAsync(DataSet dataSet, string srcTable, CancellationToken cancellationToken)
	{
		TaskCompletionSource<int> taskCompletionSource = new TaskCompletionSource<int>();
		if (!(cancellationToken == CancellationToken.None) && cancellationToken.IsCancellationRequested)
		{
			taskCompletionSource.SetCanceled();
		}
		else
		{
			try
			{
				int result = Update(dataSet, srcTable);
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
