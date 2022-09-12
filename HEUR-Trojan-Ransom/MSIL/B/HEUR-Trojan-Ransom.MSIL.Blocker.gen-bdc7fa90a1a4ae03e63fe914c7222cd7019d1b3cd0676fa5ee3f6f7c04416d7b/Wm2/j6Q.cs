#define DEBUG
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Diagnostics;
using Microsoft.VisualBasic.CompilerServices;
using g7F;
using t2M;
using w8E;

namespace Wm2;

[DesignerCategory("code")]
[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[HelpKeyword("vs.data.TableAdapterManager")]
[ToolboxItem(true)]
public class j6Q : Component
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public enum Ep6
	{
		InsertUpdateDelete,
		UpdateInsertDelete
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private sealed class Tx1 : IComparer<DataRow>
	{
		private DataRelation _relation;

		private int _childFirst;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal Tx1(DataRelation relation, bool childFirst)
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
		private DataRow Wt3(DataRow Tq3, ref int o8Y)
		{
			Debug.Assert(Tq3 != null);
			DataRow result = Tq3;
			o8Y = 0;
			IDictionary<DataRow, DataRow> dictionary = new Dictionary<DataRow, DataRow>();
			dictionary[Tq3] = Tq3;
			DataRow parentRow = Tq3.GetParentRow(_relation, DataRowVersion.Default);
			checked
			{
				while (parentRow != null && !dictionary.ContainsKey(parentRow))
				{
					o8Y++;
					result = parentRow;
					dictionary[parentRow] = parentRow;
					parentRow = parentRow.GetParentRow(_relation, DataRowVersion.Default);
				}
				if (o8Y == 0)
				{
					dictionary.Clear();
					dictionary[Tq3] = Tq3;
					parentRow = Tq3.GetParentRow(_relation, DataRowVersion.Original);
					while (parentRow != null && !dictionary.ContainsKey(parentRow))
					{
						o8Y++;
						result = parentRow;
						dictionary[parentRow] = parentRow;
						parentRow = parentRow.GetParentRow(_relation, DataRowVersion.Original);
					}
				}
				return result;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public int p3X(DataRow Ha2, DataRow Ei7)
		{
			if (object.ReferenceEquals(Ha2, Ei7))
			{
				return 0;
			}
			if (Ha2 == null)
			{
				return -1;
			}
			if (Ei7 == null)
			{
				return 1;
			}
			int o8Y = 0;
			DataRow dataRow = Wt3(Ha2, ref o8Y);
			int o8Y2 = 0;
			DataRow dataRow2 = Wt3(Ei7, ref o8Y2);
			if (object.ReferenceEquals(dataRow, dataRow2))
			{
				return checked(_childFirst * o8Y.CompareTo(o8Y2));
			}
			Debug.Assert(dataRow.Table != null && dataRow2.Table != null);
			if (dataRow.Table.Rows.IndexOf(dataRow) < dataRow2.Table.Rows.IndexOf(dataRow2))
			{
				return -1;
			}
			return 1;
		}

		int IComparer<DataRow>.Compare(DataRow Ha2, DataRow Ei7)
		{
			//ILSpy generated this explicit interface implementation from .override directive in p3X
			return this.p3X(Ha2, Ei7);
		}
	}

	private Ep6 _updateOrder;

	private Md1 _requested_ItemsTableAdapter;

	internal x6H y;

	internal bool M;

	internal IDbConnection U;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public Ep6 UpdateOrder
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
	public x6H MenuTableAdapter
	{
		get
		{
			return y;
		}
		set
		{
			x6H x6H = (y = value);
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
	public Md1 Requested_ItemsTableAdapter
	{
		get
		{
			return _requested_ItemsTableAdapter;
		}
		set
		{
			_requested_ItemsTableAdapter = value;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public bool BackupDataSetBeforeUpdate
	{
		get
		{
			return M;
		}
		set
		{
			bool flag = (M = value);
		}
	}

	[Browsable(false)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public IDbConnection Connection
	{
		get
		{
			if (U != null)
			{
				return U;
			}
			if (y != null && y.Connection != null)
			{
				return (IDbConnection)y.Connection;
			}
			if (_requested_ItemsTableAdapter != null && _requested_ItemsTableAdapter.Connection != null)
			{
				return (IDbConnection)_requested_ItemsTableAdapter.Connection;
			}
			return null;
		}
		set
		{
			IDbConnection dbConnection = (U = value);
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
				if (y != null)
				{
					num++;
				}
				if (_requested_ItemsTableAdapter != null)
				{
					num++;
				}
				return num;
			}
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private int g9F(Si0 Ag1, List<DataRow> Ff1, List<DataRow> y9K)
	{
		int num = 0;
		checked
		{
			if (y != null)
			{
				DataRow[] qs = Ag1.Menu.Select(null, null, DataViewRowState.ModifiedCurrent);
				qs = b2M(qs, y9K);
				if (qs != null && 0 < qs.Length)
				{
					num += y.s0S(qs);
					Ff1.AddRange(qs);
				}
			}
			if (_requested_ItemsTableAdapter != null)
			{
				DataRow[] qs2 = Ag1.Requested_Items.Select(null, null, DataViewRowState.ModifiedCurrent);
				qs2 = b2M(qs2, y9K);
				if (qs2 != null && 0 < qs2.Length)
				{
					num += _requested_ItemsTableAdapter.n6M(qs2);
					Ff1.AddRange(qs2);
				}
			}
			return num;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private int Jt5(Si0 k8T, List<DataRow> Tg4)
	{
		int num = 0;
		checked
		{
			if (y != null)
			{
				DataRow[] array = k8T.Menu.Select(null, null, DataViewRowState.Added);
				if (array != null && 0 < array.Length)
				{
					num += y.s0S(array);
					Tg4.AddRange(array);
				}
			}
			if (_requested_ItemsTableAdapter != null)
			{
				DataRow[] array2 = k8T.Requested_Items.Select(null, null, DataViewRowState.Added);
				if (array2 != null && 0 < array2.Length)
				{
					num += _requested_ItemsTableAdapter.n6M(array2);
					Tg4.AddRange(array2);
				}
			}
			return num;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private int Wc9(Si0 Af1, List<DataRow> Kd3)
	{
		int num = 0;
		checked
		{
			if (_requested_ItemsTableAdapter != null)
			{
				DataRow[] array = Af1.Requested_Items.Select(null, null, DataViewRowState.Deleted);
				if (array != null && 0 < array.Length)
				{
					num += _requested_ItemsTableAdapter.n6M(array);
					Kd3.AddRange(array);
				}
			}
			if (y != null)
			{
				DataRow[] array2 = Af1.Menu.Select(null, null, DataViewRowState.Deleted);
				if (array2 != null && 0 < array2.Length)
				{
					num += y.s0S(array2);
					Kd3.AddRange(array2);
				}
			}
			return num;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private DataRow[] b2M(DataRow[] Qs2, List<DataRow> Yo1)
	{
		if (Qs2 == null || Qs2.Length < 1)
		{
			return Qs2;
		}
		if (Yo1 == null || Yo1.Count < 1)
		{
			return Qs2;
		}
		List<DataRow> list = new List<DataRow>();
		foreach (DataRow item in Qs2)
		{
			if (!Yo1.Contains(item))
			{
				list.Add(item);
			}
		}
		return list.ToArray();
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public virtual int Pf2(Si0 q2S)
	{
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected O, but got Unknown
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected O, but got Unknown
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected O, but got Unknown
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Expected O, but got Unknown
		//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b5: Expected O, but got Unknown
		//IL_03df: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e9: Expected O, but got Unknown
		if (q2S == null)
		{
			throw new ArgumentNullException("dataSet");
		}
		if (!q2S.HasChanges())
		{
			return 0;
		}
		if (y != null && !m8A((IDbConnection)y.Connection))
		{
			throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
		}
		if (_requested_ItemsTableAdapter != null && !m8A((IDbConnection)_requested_ItemsTableAdapter.Connection))
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
			dataSet.Merge(q2S);
		}
		checked
		{
			try
			{
				if (y != null)
				{
					dictionary.Add(y, (IDbConnection)y.Connection);
					y.Connection = (OleDbConnection)connection;
					y.Transaction = (OleDbTransaction)dbTransaction;
					if (((DataAdapter)(object)y.Adapter).AcceptChangesDuringUpdate)
					{
						((DataAdapter)(object)y.Adapter).AcceptChangesDuringUpdate = false;
						list3.Add((DataAdapter)(object)y.Adapter);
					}
				}
				if (_requested_ItemsTableAdapter != null)
				{
					dictionary.Add(_requested_ItemsTableAdapter, (IDbConnection)_requested_ItemsTableAdapter.Connection);
					_requested_ItemsTableAdapter.Connection = (OleDbConnection)connection;
					_requested_ItemsTableAdapter.Transaction = (OleDbTransaction)dbTransaction;
					if (((DataAdapter)(object)_requested_ItemsTableAdapter.Adapter).AcceptChangesDuringUpdate)
					{
						((DataAdapter)(object)_requested_ItemsTableAdapter.Adapter).AcceptChangesDuringUpdate = false;
						list3.Add((DataAdapter)(object)_requested_ItemsTableAdapter.Adapter);
					}
				}
				if (UpdateOrder == Ep6.UpdateInsertDelete)
				{
					num += g9F(q2S, list, list2);
					num += Jt5(q2S, list2);
				}
				else
				{
					num += Jt5(q2S, list2);
					num += g9F(q2S, list, list2);
				}
				num += Wc9(q2S, list);
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
					q2S.Clear();
					q2S.Merge(dataSet);
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
				if (y != null)
				{
					y.Connection = (OleDbConnection)dictionary[y];
					y.Transaction = null;
				}
				if (_requested_ItemsTableAdapter != null)
				{
					_requested_ItemsTableAdapter.Connection = (OleDbConnection)dictionary[_requested_ItemsTableAdapter];
					_requested_ItemsTableAdapter.Transaction = null;
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
	protected virtual void Qk9(DataRow[] e1F, DataRelation j0S, bool Xj4)
	{
		Array.Sort(e1F, new Tx1(j0S, Xj4));
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	protected virtual bool m8A(IDbConnection Bc9)
	{
		if (U != null)
		{
			return true;
		}
		if (Connection == null || Bc9 == null)
		{
			return true;
		}
		if (string.Equals(Connection.ConnectionString, Bc9.ConnectionString, StringComparison.Ordinal))
		{
			return true;
		}
		return false;
	}
}
