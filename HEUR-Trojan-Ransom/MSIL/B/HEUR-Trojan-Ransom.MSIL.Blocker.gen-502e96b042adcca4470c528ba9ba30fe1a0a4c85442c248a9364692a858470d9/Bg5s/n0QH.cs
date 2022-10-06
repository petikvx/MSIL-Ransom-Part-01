#define DEBUG
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using Microsoft.VisualBasic.CompilerServices;
using Ta4s;
using To59;
using Wp86;
using Xj5;
using g8B;
using t5L;
using z6N;

namespace Bg5s;

[HelpKeyword("vs.data.TableAdapterManager")]
[DesignerCategory("code")]
[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[ToolboxItem(true)]
public class n0QH : Component
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public enum y9Q
	{
		InsertUpdateDelete,
		UpdateInsertDelete
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private sealed class r9S : IComparer<DataRow>
	{
		private DataRelation _relation;

		private int _childFirst;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal r9S(DataRelation relation, bool childFirst)
		{
			_relation = relation;
			if (childFirst)
			{
				_childFirst = -1;
			}
			else
			{
				_childFirst = 1;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		private DataRow r3E(DataRow r7A, ref int Ao7)
		{
			Debug.Assert(r7A != null);
			DataRow result = r7A;
			Ao7 = 0;
			IDictionary<DataRow, DataRow> dictionary = new Dictionary<DataRow, DataRow>();
			dictionary[r7A] = r7A;
			DataRow parentRow = r7A.GetParentRow(_relation, DataRowVersion.Default);
			checked
			{
				while (parentRow != null && !dictionary.ContainsKey(parentRow))
				{
					Ao7++;
					result = parentRow;
					dictionary[parentRow] = parentRow;
					parentRow = parentRow.GetParentRow(_relation, DataRowVersion.Default);
				}
				if (Ao7 == 0)
				{
					dictionary.Clear();
					dictionary[r7A] = r7A;
					parentRow = r7A.GetParentRow(_relation, DataRowVersion.Original);
					while (parentRow != null && !dictionary.ContainsKey(parentRow))
					{
						Ao7++;
						result = parentRow;
						dictionary[parentRow] = parentRow;
						parentRow = parentRow.GetParentRow(_relation, DataRowVersion.Original);
					}
				}
				return result;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public int Dm3(DataRow a2C, DataRow Wk5)
		{
			if (object.ReferenceEquals(a2C, Wk5))
			{
				return 0;
			}
			if (a2C == null)
			{
				return -1;
			}
			if (Wk5 == null)
			{
				return 1;
			}
			int Ao = 0;
			DataRow dataRow = r3E(a2C, ref Ao);
			int Ao2 = 0;
			DataRow dataRow2 = r3E(Wk5, ref Ao2);
			if (object.ReferenceEquals(dataRow, dataRow2))
			{
				return checked(_childFirst * Ao.CompareTo(Ao2));
			}
			Debug.Assert(dataRow.Table != null && dataRow2.Table != null);
			if (dataRow.Table.Rows.IndexOf(dataRow) < dataRow2.Table.Rows.IndexOf(dataRow2))
			{
				return -1;
			}
			return 1;
		}

		int IComparer<DataRow>.Compare(DataRow a2C, DataRow Wk5)
		{
			//ILSpy generated this explicit interface implementation from .override directive in Dm3
			return this.Dm3(a2C, Wk5);
		}
	}

	private y9Q _updateOrder;

	private Kx4 _floginTableAdapter;

	private Cd8 _historyTableAdapter;

	private w1E _pendingTableAdapter;

	private w8K _scheduleTableAdapter;

	private x0TX _sloginTableAdapter;

	private f7GX _tableTableAdapter;

	internal bool C;

	internal IDbConnection N;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public y9Q UpdateOrder
	{
		get
		{
			return _updateOrder;
		}
		set
		{
			_updateOrder = value;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
	public Kx4 FloginTableAdapter
	{
		get
		{
			return _floginTableAdapter;
		}
		set
		{
			_floginTableAdapter = value;
		}
	}

	[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public Cd8 HistoryTableAdapter
	{
		get
		{
			return _historyTableAdapter;
		}
		set
		{
			_historyTableAdapter = value;
		}
	}

	[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public w1E PendingTableAdapter
	{
		get
		{
			return _pendingTableAdapter;
		}
		set
		{
			_pendingTableAdapter = value;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
	public w8K ScheduleTableAdapter
	{
		get
		{
			return _scheduleTableAdapter;
		}
		set
		{
			_scheduleTableAdapter = value;
		}
	}

	[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public x0TX SloginTableAdapter
	{
		get
		{
			return _sloginTableAdapter;
		}
		set
		{
			_sloginTableAdapter = value;
		}
	}

	[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public f7GX TableTableAdapter
	{
		get
		{
			return _tableTableAdapter;
		}
		set
		{
			_tableTableAdapter = value;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public bool BackupDataSetBeforeUpdate
	{
		get
		{
			return C;
		}
		set
		{
			bool flag = (C = value);
		}
	}

	[Browsable(false)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public IDbConnection Connection
	{
		get
		{
			if (N != null)
			{
				return N;
			}
			if (_floginTableAdapter != null && _floginTableAdapter.Connection != null)
			{
				return (IDbConnection)_floginTableAdapter.Connection;
			}
			if (_historyTableAdapter != null && _historyTableAdapter.Connection != null)
			{
				return (IDbConnection)_historyTableAdapter.Connection;
			}
			if (_pendingTableAdapter != null && _pendingTableAdapter.Connection != null)
			{
				return (IDbConnection)_pendingTableAdapter.Connection;
			}
			if (_scheduleTableAdapter != null && _scheduleTableAdapter.Connection != null)
			{
				return (IDbConnection)_scheduleTableAdapter.Connection;
			}
			if (_sloginTableAdapter != null && _sloginTableAdapter.Connection != null)
			{
				return (IDbConnection)_sloginTableAdapter.Connection;
			}
			if (_tableTableAdapter != null && _tableTableAdapter.Connection != null)
			{
				return (IDbConnection)_tableTableAdapter.Connection;
			}
			return null;
		}
		set
		{
			IDbConnection dbConnection = (N = value);
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[Browsable(false)]
	public int TableAdapterInstanceCount
	{
		get
		{
			int num = 0;
			checked
			{
				if (_floginTableAdapter != null)
				{
					num++;
				}
				if (_historyTableAdapter != null)
				{
					num++;
				}
				if (_pendingTableAdapter != null)
				{
					num++;
				}
				if (_scheduleTableAdapter != null)
				{
					num++;
				}
				if (_sloginTableAdapter != null)
				{
					num++;
				}
				if (_tableTableAdapter != null)
				{
					num++;
				}
				return num;
			}
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private int n0M9(Ck89 Bn12, List<DataRow> Cc8w, List<DataRow> Li15)
	{
		int num = 0;
		checked
		{
			if (_floginTableAdapter != null)
			{
				DataRow[] dd4w = Bn12.Flogin.Select(null, null, DataViewRowState.ModifiedCurrent);
				dd4w = Fc52(dd4w, Li15);
				if (dd4w != null && 0 < dd4w.Length)
				{
					num += _floginTableAdapter.d5A(dd4w);
					Cc8w.AddRange(dd4w);
				}
			}
			if (_historyTableAdapter != null)
			{
				DataRow[] dd4w2 = Bn12.History.Select(null, null, DataViewRowState.ModifiedCurrent);
				dd4w2 = Fc52(dd4w2, Li15);
				if (dd4w2 != null && 0 < dd4w2.Length)
				{
					num += _historyTableAdapter.e1D(dd4w2);
					Cc8w.AddRange(dd4w2);
				}
			}
			if (_pendingTableAdapter != null)
			{
				DataRow[] dd4w3 = Bn12.Pending.Select(null, null, DataViewRowState.ModifiedCurrent);
				dd4w3 = Fc52(dd4w3, Li15);
				if (dd4w3 != null && 0 < dd4w3.Length)
				{
					num += _pendingTableAdapter.Aw4(dd4w3);
					Cc8w.AddRange(dd4w3);
				}
			}
			if (_scheduleTableAdapter != null)
			{
				DataRow[] dd4w4 = Bn12.Schedule.Select(null, null, DataViewRowState.ModifiedCurrent);
				dd4w4 = Fc52(dd4w4, Li15);
				if (dd4w4 != null && 0 < dd4w4.Length)
				{
					num += _scheduleTableAdapter.Wy8g(dd4w4);
					Cc8w.AddRange(dd4w4);
				}
			}
			if (_sloginTableAdapter != null)
			{
				DataRow[] dd4w5 = Bn12.Slogin.Select(null, null, DataViewRowState.ModifiedCurrent);
				dd4w5 = Fc52(dd4w5, Li15);
				if (dd4w5 != null && 0 < dd4w5.Length)
				{
					num += _sloginTableAdapter.Pp8c(dd4w5);
					Cc8w.AddRange(dd4w5);
				}
			}
			if (_tableTableAdapter != null)
			{
				DataRow[] dd4w6 = Bn12.Table.Select(null, null, DataViewRowState.ModifiedCurrent);
				dd4w6 = Fc52(dd4w6, Li15);
				if (dd4w6 != null && 0 < dd4w6.Length)
				{
					num += _tableTableAdapter.Lb5s(dd4w6);
					Cc8w.AddRange(dd4w6);
				}
			}
			return num;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private int j6PE(Ck89 Ck49, List<DataRow> s7SM)
	{
		int num = 0;
		checked
		{
			if (_floginTableAdapter != null)
			{
				DataRow[] array = Ck49.Flogin.Select(null, null, DataViewRowState.Added);
				if (array != null && 0 < array.Length)
				{
					num += _floginTableAdapter.d5A(array);
					s7SM.AddRange(array);
				}
			}
			if (_historyTableAdapter != null)
			{
				DataRow[] array2 = Ck49.History.Select(null, null, DataViewRowState.Added);
				if (array2 != null && 0 < array2.Length)
				{
					num += _historyTableAdapter.e1D(array2);
					s7SM.AddRange(array2);
				}
			}
			if (_pendingTableAdapter != null)
			{
				DataRow[] array3 = Ck49.Pending.Select(null, null, DataViewRowState.Added);
				if (array3 != null && 0 < array3.Length)
				{
					num += _pendingTableAdapter.Aw4(array3);
					s7SM.AddRange(array3);
				}
			}
			if (_scheduleTableAdapter != null)
			{
				DataRow[] array4 = Ck49.Schedule.Select(null, null, DataViewRowState.Added);
				if (array4 != null && 0 < array4.Length)
				{
					num += _scheduleTableAdapter.Wy8g(array4);
					s7SM.AddRange(array4);
				}
			}
			if (_sloginTableAdapter != null)
			{
				DataRow[] array5 = Ck49.Slogin.Select(null, null, DataViewRowState.Added);
				if (array5 != null && 0 < array5.Length)
				{
					num += _sloginTableAdapter.Pp8c(array5);
					s7SM.AddRange(array5);
				}
			}
			if (_tableTableAdapter != null)
			{
				DataRow[] array6 = Ck49.Table.Select(null, null, DataViewRowState.Added);
				if (array6 != null && 0 < array6.Length)
				{
					num += _tableTableAdapter.Lb5s(array6);
					s7SM.AddRange(array6);
				}
			}
			return num;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private int Qw05(Ck89 r4TK, List<DataRow> p7Z2)
	{
		int num = 0;
		checked
		{
			if (_tableTableAdapter != null)
			{
				DataRow[] array = r4TK.Table.Select(null, null, DataViewRowState.Deleted);
				if (array != null && 0 < array.Length)
				{
					num += _tableTableAdapter.Lb5s(array);
					p7Z2.AddRange(array);
				}
			}
			if (_sloginTableAdapter != null)
			{
				DataRow[] array2 = r4TK.Slogin.Select(null, null, DataViewRowState.Deleted);
				if (array2 != null && 0 < array2.Length)
				{
					num += _sloginTableAdapter.Pp8c(array2);
					p7Z2.AddRange(array2);
				}
			}
			if (_scheduleTableAdapter != null)
			{
				DataRow[] array3 = r4TK.Schedule.Select(null, null, DataViewRowState.Deleted);
				if (array3 != null && 0 < array3.Length)
				{
					num += _scheduleTableAdapter.Wy8g(array3);
					p7Z2.AddRange(array3);
				}
			}
			if (_pendingTableAdapter != null)
			{
				DataRow[] array4 = r4TK.Pending.Select(null, null, DataViewRowState.Deleted);
				if (array4 != null && 0 < array4.Length)
				{
					num += _pendingTableAdapter.Aw4(array4);
					p7Z2.AddRange(array4);
				}
			}
			if (_historyTableAdapter != null)
			{
				DataRow[] array5 = r4TK.History.Select(null, null, DataViewRowState.Deleted);
				if (array5 != null && 0 < array5.Length)
				{
					num += _historyTableAdapter.e1D(array5);
					p7Z2.AddRange(array5);
				}
			}
			if (_floginTableAdapter != null)
			{
				DataRow[] array6 = r4TK.Flogin.Select(null, null, DataViewRowState.Deleted);
				if (array6 != null && 0 < array6.Length)
				{
					num += _floginTableAdapter.d5A(array6);
					p7Z2.AddRange(array6);
				}
			}
			return num;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private DataRow[] Fc52(DataRow[] Dd4w, List<DataRow> k7PF)
	{
		if (Dd4w == null || Dd4w.Length < 1)
		{
			return Dd4w;
		}
		if (k7PF == null || k7PF.Count < 1)
		{
			return Dd4w;
		}
		List<DataRow> list = new List<DataRow>();
		foreach (DataRow item in Dd4w)
		{
			if (!k7PF.Contains(item))
			{
				list.Add(item);
			}
		}
		return list.ToArray();
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public virtual int y9B(Ck89 Nc9)
	{
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected O, but got Unknown
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Expected O, but got Unknown
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Expected O, but got Unknown
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Expected O, but got Unknown
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Expected O, but got Unknown
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Expected O, but got Unknown
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		//IL_0363: Expected O, but got Unknown
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0374: Expected O, but got Unknown
		//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dd: Expected O, but got Unknown
		//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ee: Expected O, but got Unknown
		//IL_044d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0457: Expected O, but got Unknown
		//IL_045e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0468: Expected O, but got Unknown
		//IL_0643: Unknown result type (might be due to invalid IL or missing references)
		//IL_064d: Expected O, but got Unknown
		//IL_0677: Unknown result type (might be due to invalid IL or missing references)
		//IL_0681: Expected O, but got Unknown
		//IL_06ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b5: Expected O, but got Unknown
		//IL_06df: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e9: Expected O, but got Unknown
		//IL_0713: Unknown result type (might be due to invalid IL or missing references)
		//IL_071d: Expected O, but got Unknown
		//IL_0747: Unknown result type (might be due to invalid IL or missing references)
		//IL_0751: Expected O, but got Unknown
		if (Nc9 == null)
		{
			throw new ArgumentNullException("dataSet");
		}
		if (!Nc9.HasChanges())
		{
			return 0;
		}
		if (_floginTableAdapter != null && !e2X((IDbConnection)_floginTableAdapter.Connection))
		{
			throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
		}
		if (_historyTableAdapter != null && !e2X((IDbConnection)_historyTableAdapter.Connection))
		{
			throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
		}
		if (_pendingTableAdapter != null && !e2X((IDbConnection)_pendingTableAdapter.Connection))
		{
			throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
		}
		if (_scheduleTableAdapter != null && !e2X((IDbConnection)_scheduleTableAdapter.Connection))
		{
			throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
		}
		if (_sloginTableAdapter != null && !e2X((IDbConnection)_sloginTableAdapter.Connection))
		{
			throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
		}
		if (_tableTableAdapter != null && !e2X((IDbConnection)_tableTableAdapter.Connection))
		{
			throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
		}
		IDbConnection connection = Connection;
		if (connection == null)
		{
			throw new ApplicationException("TableAdapterManager contains no connection information. Set each TableAdapterManager TableAdapter property to a valid TableAdapter instance.");
		}
		bool flag = false;
		if ((connection.State & ConnectionState.Broken) == ConnectionState.Broken)
		{
			connection.Close();
		}
		if (connection.State == ConnectionState.Closed)
		{
			connection.Open();
			flag = true;
		}
		IDbTransaction dbTransaction = connection.BeginTransaction();
		if (dbTransaction == null)
		{
			throw new ApplicationException("The transaction cannot begin. The current data connection does not support transactions or the current state is not allowing the transaction to begin.");
		}
		List<DataRow> list = new List<DataRow>();
		List<DataRow> list2 = new List<DataRow>();
		List<DataAdapter> list3 = new List<DataAdapter>();
		Dictionary<object, IDbConnection> dictionary = new Dictionary<object, IDbConnection>();
		int num = 0;
		DataSet dataSet = null;
		if (BackupDataSetBeforeUpdate)
		{
			dataSet = new DataSet();
			dataSet.Merge(Nc9);
		}
		checked
		{
			try
			{
				if (_floginTableAdapter != null)
				{
					dictionary.Add(_floginTableAdapter, (IDbConnection)_floginTableAdapter.Connection);
					_floginTableAdapter.Connection = (SqlConnection)connection;
					_floginTableAdapter.Transaction = (SqlTransaction)dbTransaction;
					if (((DataAdapter)(object)_floginTableAdapter.Adapter).AcceptChangesDuringUpdate)
					{
						((DataAdapter)(object)_floginTableAdapter.Adapter).AcceptChangesDuringUpdate = false;
						list3.Add((DataAdapter)(object)_floginTableAdapter.Adapter);
					}
				}
				if (_historyTableAdapter != null)
				{
					dictionary.Add(_historyTableAdapter, (IDbConnection)_historyTableAdapter.Connection);
					_historyTableAdapter.Connection = (SqlConnection)connection;
					_historyTableAdapter.Transaction = (SqlTransaction)dbTransaction;
					if (((DataAdapter)(object)_historyTableAdapter.Adapter).AcceptChangesDuringUpdate)
					{
						((DataAdapter)(object)_historyTableAdapter.Adapter).AcceptChangesDuringUpdate = false;
						list3.Add((DataAdapter)(object)_historyTableAdapter.Adapter);
					}
				}
				if (_pendingTableAdapter != null)
				{
					dictionary.Add(_pendingTableAdapter, (IDbConnection)_pendingTableAdapter.Connection);
					_pendingTableAdapter.Connection = (SqlConnection)connection;
					_pendingTableAdapter.Transaction = (SqlTransaction)dbTransaction;
					if (((DataAdapter)(object)_pendingTableAdapter.Adapter).AcceptChangesDuringUpdate)
					{
						((DataAdapter)(object)_pendingTableAdapter.Adapter).AcceptChangesDuringUpdate = false;
						list3.Add((DataAdapter)(object)_pendingTableAdapter.Adapter);
					}
				}
				if (_scheduleTableAdapter != null)
				{
					dictionary.Add(_scheduleTableAdapter, (IDbConnection)_scheduleTableAdapter.Connection);
					_scheduleTableAdapter.Connection = (SqlConnection)connection;
					_scheduleTableAdapter.Transaction = (SqlTransaction)dbTransaction;
					if (((DataAdapter)(object)_scheduleTableAdapter.Adapter).AcceptChangesDuringUpdate)
					{
						((DataAdapter)(object)_scheduleTableAdapter.Adapter).AcceptChangesDuringUpdate = false;
						list3.Add((DataAdapter)(object)_scheduleTableAdapter.Adapter);
					}
				}
				if (_sloginTableAdapter != null)
				{
					dictionary.Add(_sloginTableAdapter, (IDbConnection)_sloginTableAdapter.Connection);
					_sloginTableAdapter.Connection = (SqlConnection)connection;
					_sloginTableAdapter.Transaction = (SqlTransaction)dbTransaction;
					if (((DataAdapter)(object)_sloginTableAdapter.Adapter).AcceptChangesDuringUpdate)
					{
						((DataAdapter)(object)_sloginTableAdapter.Adapter).AcceptChangesDuringUpdate = false;
						list3.Add((DataAdapter)(object)_sloginTableAdapter.Adapter);
					}
				}
				if (_tableTableAdapter != null)
				{
					dictionary.Add(_tableTableAdapter, (IDbConnection)_tableTableAdapter.Connection);
					_tableTableAdapter.Connection = (SqlConnection)connection;
					_tableTableAdapter.Transaction = (SqlTransaction)dbTransaction;
					if (((DataAdapter)(object)_tableTableAdapter.Adapter).AcceptChangesDuringUpdate)
					{
						((DataAdapter)(object)_tableTableAdapter.Adapter).AcceptChangesDuringUpdate = false;
						list3.Add((DataAdapter)(object)_tableTableAdapter.Adapter);
					}
				}
				if (UpdateOrder == y9Q.UpdateInsertDelete)
				{
					num += n0M9(Nc9, list, list2);
					num += j6PE(Nc9, list2);
				}
				else
				{
					num += j6PE(Nc9, list2);
					num += n0M9(Nc9, list, list2);
				}
				num += Qw05(Nc9, list);
				dbTransaction.Commit();
				if (0 < list2.Count)
				{
					DataRow[] array = new DataRow[list2.Count - 1 + 1];
					list2.CopyTo(array);
					foreach (DataRow dataRow in array)
					{
						dataRow.AcceptChanges();
					}
				}
				if (0 < list.Count)
				{
					DataRow[] array2 = new DataRow[list.Count - 1 + 1];
					list.CopyTo(array2);
					foreach (DataRow dataRow2 in array2)
					{
						dataRow2.AcceptChanges();
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				dbTransaction.Rollback();
				if (BackupDataSetBeforeUpdate)
				{
					Debug.Assert(dataSet != null);
					Nc9.Clear();
					Nc9.Merge(dataSet);
				}
				else if (0 < list2.Count)
				{
					DataRow[] array3 = new DataRow[list2.Count - 1 + 1];
					list2.CopyTo(array3);
					foreach (DataRow dataRow3 in array3)
					{
						dataRow3.AcceptChanges();
						dataRow3.SetAdded();
					}
				}
				throw ex2;
			}
			finally
			{
				if (flag)
				{
					connection.Close();
				}
				if (_floginTableAdapter != null)
				{
					_floginTableAdapter.Connection = (SqlConnection)dictionary[_floginTableAdapter];
					_floginTableAdapter.Transaction = null;
				}
				if (_historyTableAdapter != null)
				{
					_historyTableAdapter.Connection = (SqlConnection)dictionary[_historyTableAdapter];
					_historyTableAdapter.Transaction = null;
				}
				if (_pendingTableAdapter != null)
				{
					_pendingTableAdapter.Connection = (SqlConnection)dictionary[_pendingTableAdapter];
					_pendingTableAdapter.Transaction = null;
				}
				if (_scheduleTableAdapter != null)
				{
					_scheduleTableAdapter.Connection = (SqlConnection)dictionary[_scheduleTableAdapter];
					_scheduleTableAdapter.Transaction = null;
				}
				if (_sloginTableAdapter != null)
				{
					_sloginTableAdapter.Connection = (SqlConnection)dictionary[_sloginTableAdapter];
					_sloginTableAdapter.Transaction = null;
				}
				if (_tableTableAdapter != null)
				{
					_tableTableAdapter.Connection = (SqlConnection)dictionary[_tableTableAdapter];
					_tableTableAdapter.Transaction = null;
				}
				if (0 < list3.Count)
				{
					DataAdapter[] array4 = new DataAdapter[list3.Count - 1 + 1];
					list3.CopyTo(array4);
					foreach (DataAdapter dataAdapter in array4)
					{
						dataAdapter.AcceptChangesDuringUpdate = true;
					}
				}
			}
			return num;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	protected virtual void c8K(DataRow[] Dc8, DataRelation Pn8, bool Ez5)
	{
		Array.Sort(Dc8, new r9S(Pn8, Ez5));
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	protected virtual bool e2X(IDbConnection Bk5)
	{
		if (N != null)
		{
			return true;
		}
		if (Connection == null || Bk5 == null)
		{
			return true;
		}
		if (string.Equals(Connection.ConnectionString, Bk5.ConnectionString, StringComparison.Ordinal))
		{
			return true;
		}
		return false;
	}
}
