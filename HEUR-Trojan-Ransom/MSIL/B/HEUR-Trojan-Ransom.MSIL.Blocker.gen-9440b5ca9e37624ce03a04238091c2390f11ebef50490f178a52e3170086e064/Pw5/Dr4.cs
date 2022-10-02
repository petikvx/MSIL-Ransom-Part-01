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
using Ci7c;
using Ht4;
using Microsoft.VisualBasic.CompilerServices;
using Mt5x;
using b4LF;
using b8D;
using j7P;
using k0ZX;

namespace Pw5;

[ToolboxItem(true)]
[HelpKeyword("vs.data.TableAdapterManager")]
[DesignerCategory("code")]
[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
public class Dr4 : Component
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public enum Dx1
	{
		InsertUpdateDelete,
		UpdateInsertDelete
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private sealed class Am9 : IComparer<DataRow>
	{
		private DataRelation _relation;

		private int _childFirst;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal Am9(DataRelation relation, bool childFirst)
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
		private DataRow Tt5(DataRow My8, ref int a6T)
		{
			Debug.Assert(My8 != null);
			DataRow result = My8;
			a6T = 0;
			IDictionary<DataRow, DataRow> dictionary = new Dictionary<DataRow, DataRow>();
			dictionary[My8] = My8;
			DataRow parentRow = My8.GetParentRow(_relation, DataRowVersion.Default);
			checked
			{
				while (parentRow != null && !dictionary.ContainsKey(parentRow))
				{
					a6T++;
					result = parentRow;
					dictionary[parentRow] = parentRow;
					parentRow = parentRow.GetParentRow(_relation, DataRowVersion.Default);
				}
				if (a6T == 0)
				{
					dictionary.Clear();
					dictionary[My8] = My8;
					parentRow = My8.GetParentRow(_relation, DataRowVersion.Original);
					while (parentRow != null && !dictionary.ContainsKey(parentRow))
					{
						a6T++;
						result = parentRow;
						dictionary[parentRow] = parentRow;
						parentRow = parentRow.GetParentRow(_relation, DataRowVersion.Original);
					}
				}
				return result;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public int o8B(DataRow i1Y, DataRow Rx9)
		{
			if (object.ReferenceEquals(i1Y, Rx9))
			{
				return 0;
			}
			if (i1Y == null)
			{
				return -1;
			}
			if (Rx9 == null)
			{
				return 1;
			}
			int a6T = 0;
			DataRow dataRow = Tt5(i1Y, ref a6T);
			int a6T2 = 0;
			DataRow dataRow2 = Tt5(Rx9, ref a6T2);
			if (object.ReferenceEquals(dataRow, dataRow2))
			{
				return checked(_childFirst * a6T.CompareTo(a6T2));
			}
			Debug.Assert(dataRow.Table != null && dataRow2.Table != null);
			if (dataRow.Table.Rows.IndexOf(dataRow) < dataRow2.Table.Rows.IndexOf(dataRow2))
			{
				return -1;
			}
			return 1;
		}

		int IComparer<DataRow>.Compare(DataRow i1Y, DataRow Rx9)
		{
			//ILSpy generated this explicit interface implementation from .override directive in o8B
			return this.o8B(i1Y, Rx9);
		}
	}

	private Dx1 _updateOrder;

	private Yq4 _historyTableAdapter;

	private w5BF _pendingTableAdapter;

	internal Kb3 k;

	internal Mk2d A;

	internal c2X9 D;

	internal o5B2 r;

	internal bool B;

	internal IDbConnection e;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public Dx1 UpdateOrder
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
	public Kb3 FloginTableAdapter
	{
		get
		{
			return k;
		}
		set
		{
			Kb3 kb = (k = value);
		}
	}

	[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public Yq4 HistoryTableAdapter
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
	public w5BF PendingTableAdapter
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

	[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public Mk2d ScheduleTableAdapter
	{
		get
		{
			return A;
		}
		set
		{
			Mk2d mk2d = (A = value);
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
	public c2X9 SloginTableAdapter
	{
		get
		{
			return D;
		}
		set
		{
			c2X9 c2X = (D = value);
		}
	}

	[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public o5B2 TableTableAdapter
	{
		get
		{
			return r;
		}
		set
		{
			o5B2 o5B = (r = value);
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public bool BackupDataSetBeforeUpdate
	{
		get
		{
			return B;
		}
		set
		{
			bool flag = (B = value);
		}
	}

	[Browsable(false)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public IDbConnection Connection
	{
		get
		{
			if (e != null)
			{
				return e;
			}
			if (k != null && k.Connection != null)
			{
				return (IDbConnection)k.Connection;
			}
			if (_historyTableAdapter != null && _historyTableAdapter.Connection != null)
			{
				return (IDbConnection)_historyTableAdapter.Connection;
			}
			if (_pendingTableAdapter != null && _pendingTableAdapter.Connection != null)
			{
				return (IDbConnection)_pendingTableAdapter.Connection;
			}
			if (A != null && A.Connection != null)
			{
				return (IDbConnection)A.Connection;
			}
			if (D != null && D.Connection != null)
			{
				return (IDbConnection)D.Connection;
			}
			if (r != null && r.Connection != null)
			{
				return (IDbConnection)r.Connection;
			}
			return null;
		}
		set
		{
			IDbConnection dbConnection = (e = value);
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
				if (k != null)
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
				if (A != null)
				{
					num++;
				}
				if (D != null)
				{
					num++;
				}
				if (r != null)
				{
					num++;
				}
				return num;
			}
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private int j6B(s1D k2C, List<DataRow> Ae8, List<DataRow> d8X)
	{
		int num = 0;
		checked
		{
			if (k != null)
			{
				DataRow[] z9X = k2C.Flogin.Select(null, null, DataViewRowState.ModifiedCurrent);
				z9X = c3G(z9X, d8X);
				if (z9X != null && 0 < z9X.Length)
				{
					num += k.Mj2(z9X);
					Ae8.AddRange(z9X);
				}
			}
			if (_historyTableAdapter != null)
			{
				DataRow[] z9X2 = k2C.History.Select(null, null, DataViewRowState.ModifiedCurrent);
				z9X2 = c3G(z9X2, d8X);
				if (z9X2 != null && 0 < z9X2.Length)
				{
					num += _historyTableAdapter.w8C(z9X2);
					Ae8.AddRange(z9X2);
				}
			}
			if (_pendingTableAdapter != null)
			{
				DataRow[] z9X3 = k2C.Pending.Select(null, null, DataViewRowState.ModifiedCurrent);
				z9X3 = c3G(z9X3, d8X);
				if (z9X3 != null && 0 < z9X3.Length)
				{
					num += _pendingTableAdapter.n8YE(z9X3);
					Ae8.AddRange(z9X3);
				}
			}
			if (A != null)
			{
				DataRow[] z9X4 = k2C.Schedule.Select(null, null, DataViewRowState.ModifiedCurrent);
				z9X4 = c3G(z9X4, d8X);
				if (z9X4 != null && 0 < z9X4.Length)
				{
					num += A.i2DM(z9X4);
					Ae8.AddRange(z9X4);
				}
			}
			if (D != null)
			{
				DataRow[] z9X5 = k2C.Slogin.Select(null, null, DataViewRowState.ModifiedCurrent);
				z9X5 = c3G(z9X5, d8X);
				if (z9X5 != null && 0 < z9X5.Length)
				{
					num += D.Lw50(z9X5);
					Ae8.AddRange(z9X5);
				}
			}
			if (r != null)
			{
				DataRow[] z9X6 = k2C.Table.Select(null, null, DataViewRowState.ModifiedCurrent);
				z9X6 = c3G(z9X6, d8X);
				if (z9X6 != null && 0 < z9X6.Length)
				{
					num += r.Ji4e(z9X6);
					Ae8.AddRange(z9X6);
				}
			}
			return num;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private int g2A(s1D Td2, List<DataRow> Tn8)
	{
		int num = 0;
		checked
		{
			if (k != null)
			{
				DataRow[] array = Td2.Flogin.Select(null, null, DataViewRowState.Added);
				if (array != null && 0 < array.Length)
				{
					num += k.Mj2(array);
					Tn8.AddRange(array);
				}
			}
			if (_historyTableAdapter != null)
			{
				DataRow[] array2 = Td2.History.Select(null, null, DataViewRowState.Added);
				if (array2 != null && 0 < array2.Length)
				{
					num += _historyTableAdapter.w8C(array2);
					Tn8.AddRange(array2);
				}
			}
			if (_pendingTableAdapter != null)
			{
				DataRow[] array3 = Td2.Pending.Select(null, null, DataViewRowState.Added);
				if (array3 != null && 0 < array3.Length)
				{
					num += _pendingTableAdapter.n8YE(array3);
					Tn8.AddRange(array3);
				}
			}
			if (A != null)
			{
				DataRow[] array4 = Td2.Schedule.Select(null, null, DataViewRowState.Added);
				if (array4 != null && 0 < array4.Length)
				{
					num += A.i2DM(array4);
					Tn8.AddRange(array4);
				}
			}
			if (D != null)
			{
				DataRow[] array5 = Td2.Slogin.Select(null, null, DataViewRowState.Added);
				if (array5 != null && 0 < array5.Length)
				{
					num += D.Lw50(array5);
					Tn8.AddRange(array5);
				}
			}
			if (r != null)
			{
				DataRow[] array6 = Td2.Table.Select(null, null, DataViewRowState.Added);
				if (array6 != null && 0 < array6.Length)
				{
					num += r.Ji4e(array6);
					Tn8.AddRange(array6);
				}
			}
			return num;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private int p7R(s1D e6N, List<DataRow> x1C)
	{
		int num = 0;
		checked
		{
			if (r != null)
			{
				DataRow[] array = e6N.Table.Select(null, null, DataViewRowState.Deleted);
				if (array != null && 0 < array.Length)
				{
					num += r.Ji4e(array);
					x1C.AddRange(array);
				}
			}
			if (D != null)
			{
				DataRow[] array2 = e6N.Slogin.Select(null, null, DataViewRowState.Deleted);
				if (array2 != null && 0 < array2.Length)
				{
					num += D.Lw50(array2);
					x1C.AddRange(array2);
				}
			}
			if (A != null)
			{
				DataRow[] array3 = e6N.Schedule.Select(null, null, DataViewRowState.Deleted);
				if (array3 != null && 0 < array3.Length)
				{
					num += A.i2DM(array3);
					x1C.AddRange(array3);
				}
			}
			if (_pendingTableAdapter != null)
			{
				DataRow[] array4 = e6N.Pending.Select(null, null, DataViewRowState.Deleted);
				if (array4 != null && 0 < array4.Length)
				{
					num += _pendingTableAdapter.n8YE(array4);
					x1C.AddRange(array4);
				}
			}
			if (_historyTableAdapter != null)
			{
				DataRow[] array5 = e6N.History.Select(null, null, DataViewRowState.Deleted);
				if (array5 != null && 0 < array5.Length)
				{
					num += _historyTableAdapter.w8C(array5);
					x1C.AddRange(array5);
				}
			}
			if (k != null)
			{
				DataRow[] array6 = e6N.Flogin.Select(null, null, DataViewRowState.Deleted);
				if (array6 != null && 0 < array6.Length)
				{
					num += k.Mj2(array6);
					x1C.AddRange(array6);
				}
			}
			return num;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private DataRow[] c3G(DataRow[] z9X, List<DataRow> z7F)
	{
		if (z9X == null || z9X.Length < 1)
		{
			return z9X;
		}
		if (z7F == null || z7F.Count < 1)
		{
			return z9X;
		}
		List<DataRow> list = new List<DataRow>();
		foreach (DataRow item in z9X)
		{
			if (!z7F.Contains(item))
			{
				list.Add(item);
			}
		}
		return list.ToArray();
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public virtual int t8F(s1D Ea9)
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
		if (Ea9 == null)
		{
			throw new ArgumentNullException("dataSet");
		}
		if (!Ea9.HasChanges())
		{
			return 0;
		}
		if (this.k != null && !De0((IDbConnection)this.k.Connection))
		{
			throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
		}
		if (_historyTableAdapter != null && !De0((IDbConnection)_historyTableAdapter.Connection))
		{
			throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
		}
		if (_pendingTableAdapter != null && !De0((IDbConnection)_pendingTableAdapter.Connection))
		{
			throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
		}
		if (A != null && !De0((IDbConnection)A.Connection))
		{
			throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
		}
		if (D != null && !De0((IDbConnection)D.Connection))
		{
			throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
		}
		if (r != null && !De0((IDbConnection)r.Connection))
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
			dataSet.Merge(Ea9);
		}
		checked
		{
			try
			{
				if (this.k != null)
				{
					dictionary.Add(this.k, (IDbConnection)this.k.Connection);
					this.k.Connection = (SqlConnection)connection;
					this.k.Transaction = (SqlTransaction)dbTransaction;
					if (((DataAdapter)(object)this.k.Adapter).AcceptChangesDuringUpdate)
					{
						((DataAdapter)(object)this.k.Adapter).AcceptChangesDuringUpdate = false;
						list3.Add((DataAdapter)(object)this.k.Adapter);
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
				if (A != null)
				{
					dictionary.Add(A, (IDbConnection)A.Connection);
					A.Connection = (SqlConnection)connection;
					A.Transaction = (SqlTransaction)dbTransaction;
					if (((DataAdapter)(object)A.Adapter).AcceptChangesDuringUpdate)
					{
						((DataAdapter)(object)A.Adapter).AcceptChangesDuringUpdate = false;
						list3.Add((DataAdapter)(object)A.Adapter);
					}
				}
				if (D != null)
				{
					dictionary.Add(D, (IDbConnection)D.Connection);
					D.Connection = (SqlConnection)connection;
					D.Transaction = (SqlTransaction)dbTransaction;
					if (((DataAdapter)(object)D.Adapter).AcceptChangesDuringUpdate)
					{
						((DataAdapter)(object)D.Adapter).AcceptChangesDuringUpdate = false;
						list3.Add((DataAdapter)(object)D.Adapter);
					}
				}
				if (r != null)
				{
					dictionary.Add(r, (IDbConnection)r.Connection);
					r.Connection = (SqlConnection)connection;
					r.Transaction = (SqlTransaction)dbTransaction;
					if (((DataAdapter)(object)r.Adapter).AcceptChangesDuringUpdate)
					{
						((DataAdapter)(object)r.Adapter).AcceptChangesDuringUpdate = false;
						list3.Add((DataAdapter)(object)r.Adapter);
					}
				}
				if (UpdateOrder == Dx1.UpdateInsertDelete)
				{
					num += j6B(Ea9, list, list2);
					num += g2A(Ea9, list2);
				}
				else
				{
					num += g2A(Ea9, list2);
					num += j6B(Ea9, list, list2);
				}
				num += p7R(Ea9, list);
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
					Ea9.Clear();
					Ea9.Merge(dataSet);
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
				if (this.k != null)
				{
					this.k.Connection = (SqlConnection)dictionary[this.k];
					this.k.Transaction = null;
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
				if (A != null)
				{
					A.Connection = (SqlConnection)dictionary[A];
					A.Transaction = null;
				}
				if (D != null)
				{
					D.Connection = (SqlConnection)dictionary[D];
					D.Transaction = null;
				}
				if (r != null)
				{
					r.Connection = (SqlConnection)dictionary[r];
					r.Transaction = null;
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
	protected virtual void Ps0(DataRow[] Mz4, DataRelation r9Z, bool Dc8)
	{
		Array.Sort(Mz4, new Am9(r9Z, Dc8));
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	protected virtual bool De0(IDbConnection c2Z)
	{
		if (e != null)
		{
			return true;
		}
		if (Connection == null || c2Z == null)
		{
			return true;
		}
		if (string.Equals(Connection.ConnectionString, c2Z.ConnectionString, StringComparison.Ordinal))
		{
			return true;
		}
		return false;
	}
}
