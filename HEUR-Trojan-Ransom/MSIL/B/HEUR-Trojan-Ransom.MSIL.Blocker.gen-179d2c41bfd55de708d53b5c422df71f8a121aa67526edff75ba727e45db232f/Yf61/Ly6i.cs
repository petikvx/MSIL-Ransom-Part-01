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
using Cw3s;
using Ki43;
using Microsoft.VisualBasic.CompilerServices;
using s2H;

namespace Yf61;

[DesignerCategory("code")]
[ToolboxItem(true)]
[HelpKeyword("vs.data.TableAdapterManager")]
[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
public class Ly6i : Component
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public enum Gf6q
	{
		InsertUpdateDelete,
		UpdateInsertDelete
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private sealed class Dn03 : IComparer<DataRow>
	{
		private DataRelation _relation;

		private int _childFirst;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal Dn03(DataRelation relation, bool childFirst)
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

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private DataRow Gg9q(DataRow i4BX, ref int Jd6r)
		{
			Debug.Assert(i4BX != null);
			DataRow result = i4BX;
			Jd6r = 0;
			IDictionary<DataRow, DataRow> dictionary = new Dictionary<DataRow, DataRow>();
			dictionary[i4BX] = i4BX;
			DataRow parentRow = i4BX.GetParentRow(_relation, DataRowVersion.Default);
			checked
			{
				while (parentRow != null && !dictionary.ContainsKey(parentRow))
				{
					Jd6r++;
					result = parentRow;
					dictionary[parentRow] = parentRow;
					parentRow = parentRow.GetParentRow(_relation, DataRowVersion.Default);
				}
				if (Jd6r == 0)
				{
					dictionary.Clear();
					dictionary[i4BX] = i4BX;
					parentRow = i4BX.GetParentRow(_relation, DataRowVersion.Original);
					while (parentRow != null && !dictionary.ContainsKey(parentRow))
					{
						Jd6r++;
						result = parentRow;
						dictionary[parentRow] = parentRow;
						parentRow = parentRow.GetParentRow(_relation, DataRowVersion.Original);
					}
				}
				return result;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int An0y(DataRow Pt4n, DataRow Mo8g)
		{
			if (object.ReferenceEquals(Pt4n, Mo8g))
			{
				return 0;
			}
			if (Pt4n == null)
			{
				return -1;
			}
			if (Mo8g == null)
			{
				return 1;
			}
			int Jd6r = 0;
			DataRow dataRow = Gg9q(Pt4n, ref Jd6r);
			int Jd6r2 = 0;
			DataRow dataRow2 = Gg9q(Mo8g, ref Jd6r2);
			if (object.ReferenceEquals(dataRow, dataRow2))
			{
				return checked(_childFirst * Jd6r.CompareTo(Jd6r2));
			}
			Debug.Assert(dataRow.Table != null && dataRow2.Table != null);
			if (dataRow.Table.Rows.IndexOf(dataRow) < dataRow2.Table.Rows.IndexOf(dataRow2))
			{
				return -1;
			}
			return 1;
		}

		int IComparer<DataRow>.Compare(DataRow Pt4n, DataRow Mo8g)
		{
			//ILSpy generated this explicit interface implementation from .override directive in An0y
			return this.An0y(Pt4n, Mo8g);
		}
	}

	private Gf6q _updateOrder;

	private Ro53 _loginTableAdapter;

	private bool _backupDataSetBeforeUpdate;

	internal Js7d b;

	internal IDbConnection A;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public Gf6q UpdateOrder
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

	[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public Js7d booksTableAdapter
	{
		get
		{
			return b;
		}
		set
		{
			Js7d js7d = (b = value);
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
	public Ro53 loginTableAdapter
	{
		get
		{
			return _loginTableAdapter;
		}
		set
		{
			_loginTableAdapter = value;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public IDbConnection Connection
	{
		get
		{
			if (A != null)
			{
				return A;
			}
			if (b != null && b.Connection != null)
			{
				return (IDbConnection)b.Connection;
			}
			if (_loginTableAdapter != null && _loginTableAdapter.Connection != null)
			{
				return (IDbConnection)_loginTableAdapter.Connection;
			}
			return null;
		}
		set
		{
			IDbConnection dbConnection = (A = value);
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[Browsable(false)]
	public int TableAdapterInstanceCount
	{
		get
		{
			int num = 0;
			checked
			{
				if (b != null)
				{
					num++;
				}
				if (_loginTableAdapter != null)
				{
					num++;
				}
				return num;
			}
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private int f0ZW(w8K r4BQ, List<DataRow> Sf03, List<DataRow> Ti4k)
	{
		int num = 0;
		checked
		{
			if (b != null)
			{
				DataRow[] d3GB = r4BQ.books.Select(null, null, DataViewRowState.ModifiedCurrent);
				d3GB = Db60(d3GB, Ti4k);
				if (d3GB != null && 0 < d3GB.Length)
				{
					num += b.k0J8(d3GB);
					Sf03.AddRange(d3GB);
				}
			}
			if (_loginTableAdapter != null)
			{
				DataRow[] d3GB2 = r4BQ.login.Select(null, null, DataViewRowState.ModifiedCurrent);
				d3GB2 = Db60(d3GB2, Ti4k);
				if (d3GB2 != null && 0 < d3GB2.Length)
				{
					num += _loginTableAdapter.Tj06(d3GB2);
					Sf03.AddRange(d3GB2);
				}
			}
			return num;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private int m0L2(w8K Nk7i, List<DataRow> r4QB)
	{
		int num = 0;
		checked
		{
			if (b != null)
			{
				DataRow[] array = Nk7i.books.Select(null, null, DataViewRowState.Added);
				if (array != null && 0 < array.Length)
				{
					num += b.k0J8(array);
					r4QB.AddRange(array);
				}
			}
			if (_loginTableAdapter != null)
			{
				DataRow[] array2 = Nk7i.login.Select(null, null, DataViewRowState.Added);
				if (array2 != null && 0 < array2.Length)
				{
					num += _loginTableAdapter.Tj06(array2);
					r4QB.AddRange(array2);
				}
			}
			return num;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private int Sq83(w8K Xr80, List<DataRow> Ji6o)
	{
		int num = 0;
		checked
		{
			if (_loginTableAdapter != null)
			{
				DataRow[] array = Xr80.login.Select(null, null, DataViewRowState.Deleted);
				if (array != null && 0 < array.Length)
				{
					num += _loginTableAdapter.Tj06(array);
					Ji6o.AddRange(array);
				}
			}
			if (b != null)
			{
				DataRow[] array2 = Xr80.books.Select(null, null, DataViewRowState.Deleted);
				if (array2 != null && 0 < array2.Length)
				{
					num += b.k0J8(array2);
					Ji6o.AddRange(array2);
				}
			}
			return num;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private DataRow[] Db60(DataRow[] d3GB, List<DataRow> c4BG)
	{
		if (d3GB == null || d3GB.Length < 1)
		{
			return d3GB;
		}
		if (c4BG == null || c4BG.Count < 1)
		{
			return d3GB;
		}
		List<DataRow> list = new List<DataRow>();
		foreach (DataRow item in d3GB)
		{
			if (!c4BG.Contains(item))
			{
				list.Add(item);
			}
		}
		return list.ToArray();
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int Fc56(w8K Zz91)
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
		if (Zz91 == null)
		{
			throw new ArgumentNullException("dataSet");
		}
		if (!Zz91.HasChanges())
		{
			return 0;
		}
		if (b != null && !Yo67((IDbConnection)b.Connection))
		{
			throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
		}
		if (_loginTableAdapter != null && !Yo67((IDbConnection)_loginTableAdapter.Connection))
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
			dataSet.Merge(Zz91);
		}
		checked
		{
			try
			{
				if (b != null)
				{
					dictionary.Add(b, (IDbConnection)b.Connection);
					b.Connection = (SqlConnection)connection;
					b.Transaction = (SqlTransaction)dbTransaction;
					if (((DataAdapter)(object)b.Adapter).AcceptChangesDuringUpdate)
					{
						((DataAdapter)(object)b.Adapter).AcceptChangesDuringUpdate = false;
						list3.Add((DataAdapter)(object)b.Adapter);
					}
				}
				if (_loginTableAdapter != null)
				{
					dictionary.Add(_loginTableAdapter, (IDbConnection)_loginTableAdapter.Connection);
					_loginTableAdapter.Connection = (SqlConnection)connection;
					_loginTableAdapter.Transaction = (SqlTransaction)dbTransaction;
					if (((DataAdapter)(object)_loginTableAdapter.Adapter).AcceptChangesDuringUpdate)
					{
						((DataAdapter)(object)_loginTableAdapter.Adapter).AcceptChangesDuringUpdate = false;
						list3.Add((DataAdapter)(object)_loginTableAdapter.Adapter);
					}
				}
				if (UpdateOrder == Gf6q.UpdateInsertDelete)
				{
					num += f0ZW(Zz91, list, list2);
					num += m0L2(Zz91, list2);
				}
				else
				{
					num += m0L2(Zz91, list2);
					num += f0ZW(Zz91, list, list2);
				}
				num += Sq83(Zz91, list);
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
					Zz91.Clear();
					Zz91.Merge(dataSet);
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
				if (b != null)
				{
					b.Connection = (SqlConnection)dictionary[b];
					b.Transaction = null;
				}
				if (_loginTableAdapter != null)
				{
					_loginTableAdapter.Connection = (SqlConnection)dictionary[_loginTableAdapter];
					_loginTableAdapter.Transaction = null;
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

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected virtual void g3P2(DataRow[] Sc6d, DataRelation Jk1r, bool Lf28)
	{
		Array.Sort(Sc6d, new Dn03(Jk1r, Lf28));
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected virtual bool Yo67(IDbConnection Gd02)
	{
		if (A != null)
		{
			return true;
		}
		if (Connection == null || Gd02 == null)
		{
			return true;
		}
		if (string.Equals(Connection.ConnectionString, Gd02.ConnectionString, StringComparison.Ordinal))
		{
			return true;
		}
		return false;
	}
}
