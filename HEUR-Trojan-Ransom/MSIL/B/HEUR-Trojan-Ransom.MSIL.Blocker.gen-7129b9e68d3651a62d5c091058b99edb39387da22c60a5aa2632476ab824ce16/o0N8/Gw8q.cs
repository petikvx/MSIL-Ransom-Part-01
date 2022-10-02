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
using Hx37;
using Km43;
using Microsoft.VisualBasic.CompilerServices;
using Ne9m;
using Qz92;
using c2TP;
using t5MS;
using x4J2;

namespace o0N8;

[ToolboxItem(true)]
[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[DesignerCategory("code")]
[HelpKeyword("vs.data.TableAdapterManager")]
public class Gw8q : Component
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public enum w1F
	{
		InsertUpdateDelete,
		UpdateInsertDelete
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private sealed class Jf3 : IComparer<DataRow>
	{
		private DataRelation _relation;

		private int _childFirst;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal Jf3(DataRelation relation, bool childFirst)
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
		private DataRow Dm8(DataRow Hy5, ref int Lm1)
		{
			Debug.Assert(Hy5 != null);
			DataRow result = Hy5;
			Lm1 = 0;
			IDictionary<DataRow, DataRow> dictionary = new Dictionary<DataRow, DataRow>();
			dictionary[Hy5] = Hy5;
			DataRow parentRow = Hy5.GetParentRow(_relation, DataRowVersion.Default);
			checked
			{
				while (parentRow != null && !dictionary.ContainsKey(parentRow))
				{
					Lm1++;
					result = parentRow;
					dictionary[parentRow] = parentRow;
					parentRow = parentRow.GetParentRow(_relation, DataRowVersion.Default);
				}
				if (Lm1 == 0)
				{
					dictionary.Clear();
					dictionary[Hy5] = Hy5;
					parentRow = Hy5.GetParentRow(_relation, DataRowVersion.Original);
					while (parentRow != null && !dictionary.ContainsKey(parentRow))
					{
						Lm1++;
						result = parentRow;
						dictionary[parentRow] = parentRow;
						parentRow = parentRow.GetParentRow(_relation, DataRowVersion.Original);
					}
				}
				return result;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public int Yo2(DataRow Jq5, DataRow Qx5)
		{
			if (object.ReferenceEquals(Jq5, Qx5))
			{
				return 0;
			}
			if (Jq5 == null)
			{
				return -1;
			}
			if (Qx5 == null)
			{
				return 1;
			}
			int Lm = 0;
			DataRow dataRow = Dm8(Jq5, ref Lm);
			int Lm2 = 0;
			DataRow dataRow2 = Dm8(Qx5, ref Lm2);
			if (object.ReferenceEquals(dataRow, dataRow2))
			{
				return checked(_childFirst * Lm.CompareTo(Lm2));
			}
			Debug.Assert(dataRow.Table != null && dataRow2.Table != null);
			if (dataRow.Table.Rows.IndexOf(dataRow) < dataRow2.Table.Rows.IndexOf(dataRow2))
			{
				return -1;
			}
			return 1;
		}

		int IComparer<DataRow>.Compare(DataRow Jq5, DataRow Qx5)
		{
			//ILSpy generated this explicit interface implementation from .override directive in Yo2
			return this.Yo2(Jq5, Qx5);
		}
	}

	private w1F _updateOrder;

	private Wt2y _floginTableAdapter;

	private Ez42 _historyTableAdapter;

	private bool _backupDataSetBeforeUpdate;

	private IDbConnection _connection;

	internal Bf57 e;

	internal Qb24 U;

	internal z3T7 j;

	internal Ls91 F;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public w1F UpdateOrder
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
	public Wt2y FloginTableAdapter
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

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
	public Ez42 HistoryTableAdapter
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

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
	public Bf57 PendingTableAdapter
	{
		get
		{
			return e;
		}
		set
		{
			Bf57 bf = (e = value);
		}
	}

	[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public Qb24 ScheduleTableAdapter
	{
		get
		{
			return U;
		}
		set
		{
			Qb24 qb = (U = value);
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
	public z3T7 SloginTableAdapter
	{
		get
		{
			return j;
		}
		set
		{
			z3T7 z3T = (j = value);
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
	public Ls91 TableTableAdapter
	{
		get
		{
			return F;
		}
		set
		{
			Ls91 ls = (F = value);
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public bool BackupDataSetBeforeUpdate
	{
		get
		{
			return _backupDataSetBeforeUpdate;
		}
		set
		{
			_backupDataSetBeforeUpdate = value;
		}
	}

	[Browsable(false)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public IDbConnection Connection
	{
		get
		{
			if (_connection != null)
			{
				return _connection;
			}
			if (_floginTableAdapter != null && _floginTableAdapter.Connection != null)
			{
				return (IDbConnection)_floginTableAdapter.Connection;
			}
			if (_historyTableAdapter != null && _historyTableAdapter.Connection != null)
			{
				return (IDbConnection)_historyTableAdapter.Connection;
			}
			if (e != null && e.Connection != null)
			{
				return (IDbConnection)e.Connection;
			}
			if (U != null && U.Connection != null)
			{
				return (IDbConnection)U.Connection;
			}
			if (j != null && j.Connection != null)
			{
				return (IDbConnection)j.Connection;
			}
			if (F != null && F.Connection != null)
			{
				return (IDbConnection)F.Connection;
			}
			return null;
		}
		set
		{
			_connection = value;
		}
	}

	[Browsable(false)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
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
				if (e != null)
				{
					num++;
				}
				if (U != null)
				{
					num++;
				}
				if (j != null)
				{
					num++;
				}
				if (F != null)
				{
					num++;
				}
				return num;
			}
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private int e3B8(q6SX Yt6a, List<DataRow> Dj0b, List<DataRow> f3Z8)
	{
		int num = 0;
		checked
		{
			if (_floginTableAdapter != null)
			{
				DataRow[] p9KN = Yt6a.Flogin.Select(null, null, DataViewRowState.ModifiedCurrent);
				p9KN = x8JD(p9KN, f3Z8);
				if (p9KN != null && 0 < p9KN.Length)
				{
					num += _floginTableAdapter.Kg0b(p9KN);
					Dj0b.AddRange(p9KN);
				}
			}
			if (_historyTableAdapter != null)
			{
				DataRow[] p9KN2 = Yt6a.History.Select(null, null, DataViewRowState.ModifiedCurrent);
				p9KN2 = x8JD(p9KN2, f3Z8);
				if (p9KN2 != null && 0 < p9KN2.Length)
				{
					num += _historyTableAdapter.e4NB(p9KN2);
					Dj0b.AddRange(p9KN2);
				}
			}
			if (e != null)
			{
				DataRow[] p9KN3 = Yt6a.Pending.Select(null, null, DataViewRowState.ModifiedCurrent);
				p9KN3 = x8JD(p9KN3, f3Z8);
				if (p9KN3 != null && 0 < p9KN3.Length)
				{
					num += e.Yx8f(p9KN3);
					Dj0b.AddRange(p9KN3);
				}
			}
			if (U != null)
			{
				DataRow[] p9KN4 = Yt6a.Schedule.Select(null, null, DataViewRowState.ModifiedCurrent);
				p9KN4 = x8JD(p9KN4, f3Z8);
				if (p9KN4 != null && 0 < p9KN4.Length)
				{
					num += U.Me4z(p9KN4);
					Dj0b.AddRange(p9KN4);
				}
			}
			if (j != null)
			{
				DataRow[] p9KN5 = Yt6a.Slogin.Select(null, null, DataViewRowState.ModifiedCurrent);
				p9KN5 = x8JD(p9KN5, f3Z8);
				if (p9KN5 != null && 0 < p9KN5.Length)
				{
					num += j.q9Y3(p9KN5);
					Dj0b.AddRange(p9KN5);
				}
			}
			if (F != null)
			{
				DataRow[] p9KN6 = Yt6a.Table.Select(null, null, DataViewRowState.ModifiedCurrent);
				p9KN6 = x8JD(p9KN6, f3Z8);
				if (p9KN6 != null && 0 < p9KN6.Length)
				{
					num += F.q8X3(p9KN6);
					Dj0b.AddRange(p9KN6);
				}
			}
			return num;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private int Dm5w(q6SX Kd3o, List<DataRow> Ny47)
	{
		int num = 0;
		checked
		{
			if (_floginTableAdapter != null)
			{
				DataRow[] array = Kd3o.Flogin.Select(null, null, DataViewRowState.Added);
				if (array != null && 0 < array.Length)
				{
					num += _floginTableAdapter.Kg0b(array);
					Ny47.AddRange(array);
				}
			}
			if (_historyTableAdapter != null)
			{
				DataRow[] array2 = Kd3o.History.Select(null, null, DataViewRowState.Added);
				if (array2 != null && 0 < array2.Length)
				{
					num += _historyTableAdapter.e4NB(array2);
					Ny47.AddRange(array2);
				}
			}
			if (e != null)
			{
				DataRow[] array3 = Kd3o.Pending.Select(null, null, DataViewRowState.Added);
				if (array3 != null && 0 < array3.Length)
				{
					num += e.Yx8f(array3);
					Ny47.AddRange(array3);
				}
			}
			if (U != null)
			{
				DataRow[] array4 = Kd3o.Schedule.Select(null, null, DataViewRowState.Added);
				if (array4 != null && 0 < array4.Length)
				{
					num += U.Me4z(array4);
					Ny47.AddRange(array4);
				}
			}
			if (j != null)
			{
				DataRow[] array5 = Kd3o.Slogin.Select(null, null, DataViewRowState.Added);
				if (array5 != null && 0 < array5.Length)
				{
					num += j.q9Y3(array5);
					Ny47.AddRange(array5);
				}
			}
			if (F != null)
			{
				DataRow[] array6 = Kd3o.Table.Select(null, null, DataViewRowState.Added);
				if (array6 != null && 0 < array6.Length)
				{
					num += F.q8X3(array6);
					Ny47.AddRange(array6);
				}
			}
			return num;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private int o0QB(q6SX Hy3t, List<DataRow> Lc43)
	{
		int num = 0;
		checked
		{
			if (F != null)
			{
				DataRow[] array = Hy3t.Table.Select(null, null, DataViewRowState.Deleted);
				if (array != null && 0 < array.Length)
				{
					num += F.q8X3(array);
					Lc43.AddRange(array);
				}
			}
			if (j != null)
			{
				DataRow[] array2 = Hy3t.Slogin.Select(null, null, DataViewRowState.Deleted);
				if (array2 != null && 0 < array2.Length)
				{
					num += j.q9Y3(array2);
					Lc43.AddRange(array2);
				}
			}
			if (U != null)
			{
				DataRow[] array3 = Hy3t.Schedule.Select(null, null, DataViewRowState.Deleted);
				if (array3 != null && 0 < array3.Length)
				{
					num += U.Me4z(array3);
					Lc43.AddRange(array3);
				}
			}
			if (e != null)
			{
				DataRow[] array4 = Hy3t.Pending.Select(null, null, DataViewRowState.Deleted);
				if (array4 != null && 0 < array4.Length)
				{
					num += e.Yx8f(array4);
					Lc43.AddRange(array4);
				}
			}
			if (_historyTableAdapter != null)
			{
				DataRow[] array5 = Hy3t.History.Select(null, null, DataViewRowState.Deleted);
				if (array5 != null && 0 < array5.Length)
				{
					num += _historyTableAdapter.e4NB(array5);
					Lc43.AddRange(array5);
				}
			}
			if (_floginTableAdapter != null)
			{
				DataRow[] array6 = Hy3t.Flogin.Select(null, null, DataViewRowState.Deleted);
				if (array6 != null && 0 < array6.Length)
				{
					num += _floginTableAdapter.Kg0b(array6);
					Lc43.AddRange(array6);
				}
			}
			return num;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private DataRow[] x8JD(DataRow[] p9KN, List<DataRow> n0T1)
	{
		if (p9KN == null || p9KN.Length < 1)
		{
			return p9KN;
		}
		if (n0T1 == null || n0T1.Count < 1)
		{
			return p9KN;
		}
		List<DataRow> list = new List<DataRow>();
		foreach (DataRow item in p9KN)
		{
			if (!n0T1.Contains(item))
			{
				list.Add(item);
			}
		}
		return list.ToArray();
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public virtual int c4P1(q6SX i4Y5)
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
		if (i4Y5 == null)
		{
			throw new ArgumentNullException("dataSet");
		}
		if (!i4Y5.HasChanges())
		{
			return 0;
		}
		if (_floginTableAdapter != null && !Fc6k((IDbConnection)_floginTableAdapter.Connection))
		{
			throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
		}
		if (_historyTableAdapter != null && !Fc6k((IDbConnection)_historyTableAdapter.Connection))
		{
			throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
		}
		if (e != null && !Fc6k((IDbConnection)e.Connection))
		{
			throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
		}
		if (U != null && !Fc6k((IDbConnection)U.Connection))
		{
			throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
		}
		if (this.j != null && !Fc6k((IDbConnection)this.j.Connection))
		{
			throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
		}
		if (F != null && !Fc6k((IDbConnection)F.Connection))
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
			dataSet.Merge(i4Y5);
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
				if (e != null)
				{
					dictionary.Add(e, (IDbConnection)e.Connection);
					e.Connection = (SqlConnection)connection;
					e.Transaction = (SqlTransaction)dbTransaction;
					if (((DataAdapter)(object)e.Adapter).AcceptChangesDuringUpdate)
					{
						((DataAdapter)(object)e.Adapter).AcceptChangesDuringUpdate = false;
						list3.Add((DataAdapter)(object)e.Adapter);
					}
				}
				if (U != null)
				{
					dictionary.Add(U, (IDbConnection)U.Connection);
					U.Connection = (SqlConnection)connection;
					U.Transaction = (SqlTransaction)dbTransaction;
					if (((DataAdapter)(object)U.Adapter).AcceptChangesDuringUpdate)
					{
						((DataAdapter)(object)U.Adapter).AcceptChangesDuringUpdate = false;
						list3.Add((DataAdapter)(object)U.Adapter);
					}
				}
				if (this.j != null)
				{
					dictionary.Add(this.j, (IDbConnection)this.j.Connection);
					this.j.Connection = (SqlConnection)connection;
					this.j.Transaction = (SqlTransaction)dbTransaction;
					if (((DataAdapter)(object)this.j.Adapter).AcceptChangesDuringUpdate)
					{
						((DataAdapter)(object)this.j.Adapter).AcceptChangesDuringUpdate = false;
						list3.Add((DataAdapter)(object)this.j.Adapter);
					}
				}
				if (F != null)
				{
					dictionary.Add(F, (IDbConnection)F.Connection);
					F.Connection = (SqlConnection)connection;
					F.Transaction = (SqlTransaction)dbTransaction;
					if (((DataAdapter)(object)F.Adapter).AcceptChangesDuringUpdate)
					{
						((DataAdapter)(object)F.Adapter).AcceptChangesDuringUpdate = false;
						list3.Add((DataAdapter)(object)F.Adapter);
					}
				}
				if (UpdateOrder == w1F.UpdateInsertDelete)
				{
					num += e3B8(i4Y5, list, list2);
					num += Dm5w(i4Y5, list2);
				}
				else
				{
					num += Dm5w(i4Y5, list2);
					num += e3B8(i4Y5, list, list2);
				}
				num += o0QB(i4Y5, list);
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
					i4Y5.Clear();
					i4Y5.Merge(dataSet);
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
				if (e != null)
				{
					e.Connection = (SqlConnection)dictionary[e];
					e.Transaction = null;
				}
				if (U != null)
				{
					U.Connection = (SqlConnection)dictionary[U];
					U.Transaction = null;
				}
				if (this.j != null)
				{
					this.j.Connection = (SqlConnection)dictionary[this.j];
					this.j.Transaction = null;
				}
				if (F != null)
				{
					F.Connection = (SqlConnection)dictionary[F];
					F.Transaction = null;
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
	protected virtual void Be85(DataRow[] Fp1r, DataRelation n4BM, bool Mz8a)
	{
		Array.Sort(Fp1r, new Jf3(n4BM, Mz8a));
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	protected virtual bool Fc6k(IDbConnection w0DN)
	{
		if (_connection != null)
		{
			return true;
		}
		if (Connection == null || w0DN == null)
		{
			return true;
		}
		if (string.Equals(Connection.ConnectionString, w0DN.ConnectionString, StringComparison.Ordinal))
		{
			return true;
		}
		return false;
	}
}
