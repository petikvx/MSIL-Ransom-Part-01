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
using Jj7;
using Microsoft.VisualBasic.CompilerServices;
using Ng9;
using d3J;
using z8K5;

namespace y4Z;

[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[ToolboxItem(true)]
[DesignerCategory("code")]
[HelpKeyword("vs.data.TableAdapterManager")]
public class a1X : Component
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public enum Hb3
	{
		InsertUpdateDelete,
		UpdateInsertDelete
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private sealed class t7M : IComparer<DataRow>
	{
		private DataRelation _relation;

		private int _childFirst;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal t7M(DataRelation relation, bool childFirst)
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
		private DataRow n7D(DataRow q4P, ref int o6E)
		{
			Debug.Assert(q4P != null);
			DataRow result = q4P;
			o6E = 0;
			IDictionary<DataRow, DataRow> dictionary = new Dictionary<DataRow, DataRow>();
			dictionary[q4P] = q4P;
			DataRow parentRow = q4P.GetParentRow(_relation, DataRowVersion.Default);
			checked
			{
				while (parentRow != null && !dictionary.ContainsKey(parentRow))
				{
					o6E++;
					result = parentRow;
					dictionary[parentRow] = parentRow;
					parentRow = parentRow.GetParentRow(_relation, DataRowVersion.Default);
				}
				if (o6E == 0)
				{
					dictionary.Clear();
					dictionary[q4P] = q4P;
					parentRow = q4P.GetParentRow(_relation, DataRowVersion.Original);
					while (parentRow != null && !dictionary.ContainsKey(parentRow))
					{
						o6E++;
						result = parentRow;
						dictionary[parentRow] = parentRow;
						parentRow = parentRow.GetParentRow(_relation, DataRowVersion.Original);
					}
				}
				return result;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int o6K(DataRow p0M, DataRow Cf7)
		{
			if (object.ReferenceEquals(p0M, Cf7))
			{
				return 0;
			}
			if (p0M == null)
			{
				return -1;
			}
			if (Cf7 == null)
			{
				return 1;
			}
			int o6E = 0;
			DataRow dataRow = n7D(p0M, ref o6E);
			int o6E2 = 0;
			DataRow dataRow2 = n7D(Cf7, ref o6E2);
			if (object.ReferenceEquals(dataRow, dataRow2))
			{
				return checked(_childFirst * o6E.CompareTo(o6E2));
			}
			Debug.Assert(dataRow.Table != null && dataRow2.Table != null);
			if (dataRow.Table.Rows.IndexOf(dataRow) < dataRow2.Table.Rows.IndexOf(dataRow2))
			{
				return -1;
			}
			return 1;
		}

		int IComparer<DataRow>.Compare(DataRow p0M, DataRow Cf7)
		{
			//ILSpy generated this explicit interface implementation from .override directive in o6K
			return this.o6K(p0M, Cf7);
		}
	}

	private Hb3 _updateOrder;

	private i1XD _booksTableAdapter;

	private y0E _borrowedTableAdapter;

	private bool _backupDataSetBeforeUpdate;

	private IDbConnection _connection;

	internal Ba8 O;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public Hb3 UpdateOrder
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

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
	public i1XD BooksTableAdapter
	{
		get
		{
			return _booksTableAdapter;
		}
		set
		{
			_booksTableAdapter = value;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
	public y0E BorrowedTableAdapter
	{
		get
		{
			return _borrowedTableAdapter;
		}
		set
		{
			_borrowedTableAdapter = value;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
	public Ba8 UserTableAdapter
	{
		get
		{
			return O;
		}
		set
		{
			Ba8 ba = (O = value);
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

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[Browsable(false)]
	public IDbConnection Connection
	{
		get
		{
			if (_connection != null)
			{
				return _connection;
			}
			if (_booksTableAdapter != null && _booksTableAdapter.Connection != null)
			{
				return (IDbConnection)_booksTableAdapter.Connection;
			}
			if (_borrowedTableAdapter != null && _borrowedTableAdapter.Connection != null)
			{
				return (IDbConnection)_borrowedTableAdapter.Connection;
			}
			if (O != null && O.Connection != null)
			{
				return (IDbConnection)O.Connection;
			}
			return null;
		}
		set
		{
			_connection = value;
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
				if (_booksTableAdapter != null)
				{
					num++;
				}
				if (_borrowedTableAdapter != null)
				{
					num++;
				}
				if (O != null)
				{
					num++;
				}
				return num;
			}
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private int s5P(Pt8 m9E, List<DataRow> t0F, List<DataRow> a2B)
	{
		int num = 0;
		checked
		{
			if (O != null)
			{
				DataRow[] nk = m9E.User.Select(null, null, DataViewRowState.ModifiedCurrent);
				nk = c0X(nk, a2B);
				if (nk != null && 0 < nk.Length)
				{
					num += O.Pp6(nk);
					t0F.AddRange(nk);
				}
			}
			if (_borrowedTableAdapter != null)
			{
				DataRow[] nk2 = m9E.Borrowed.Select(null, null, DataViewRowState.ModifiedCurrent);
				nk2 = c0X(nk2, a2B);
				if (nk2 != null && 0 < nk2.Length)
				{
					num += _borrowedTableAdapter.Rc7(nk2);
					t0F.AddRange(nk2);
				}
			}
			if (_booksTableAdapter != null)
			{
				DataRow[] nk3 = m9E.Books.Select(null, null, DataViewRowState.ModifiedCurrent);
				nk3 = c0X(nk3, a2B);
				if (nk3 != null && 0 < nk3.Length)
				{
					num += _booksTableAdapter.z2HG(nk3);
					t0F.AddRange(nk3);
				}
			}
			return num;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private int Sq3(Pt8 Rj4, List<DataRow> Kp5)
	{
		int num = 0;
		checked
		{
			if (O != null)
			{
				DataRow[] array = Rj4.User.Select(null, null, DataViewRowState.Added);
				if (array != null && 0 < array.Length)
				{
					num += O.Pp6(array);
					Kp5.AddRange(array);
				}
			}
			if (_borrowedTableAdapter != null)
			{
				DataRow[] array2 = Rj4.Borrowed.Select(null, null, DataViewRowState.Added);
				if (array2 != null && 0 < array2.Length)
				{
					num += _borrowedTableAdapter.Rc7(array2);
					Kp5.AddRange(array2);
				}
			}
			if (_booksTableAdapter != null)
			{
				DataRow[] array3 = Rj4.Books.Select(null, null, DataViewRowState.Added);
				if (array3 != null && 0 < array3.Length)
				{
					num += _booksTableAdapter.z2HG(array3);
					Kp5.AddRange(array3);
				}
			}
			return num;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private int b0L(Pt8 e0X, List<DataRow> f1S)
	{
		int num = 0;
		checked
		{
			if (_booksTableAdapter != null)
			{
				DataRow[] array = e0X.Books.Select(null, null, DataViewRowState.Deleted);
				if (array != null && 0 < array.Length)
				{
					num += _booksTableAdapter.z2HG(array);
					f1S.AddRange(array);
				}
			}
			if (_borrowedTableAdapter != null)
			{
				DataRow[] array2 = e0X.Borrowed.Select(null, null, DataViewRowState.Deleted);
				if (array2 != null && 0 < array2.Length)
				{
					num += _borrowedTableAdapter.Rc7(array2);
					f1S.AddRange(array2);
				}
			}
			if (O != null)
			{
				DataRow[] array3 = e0X.User.Select(null, null, DataViewRowState.Deleted);
				if (array3 != null && 0 < array3.Length)
				{
					num += O.Pp6(array3);
					f1S.AddRange(array3);
				}
			}
			return num;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private DataRow[] c0X(DataRow[] Nk0, List<DataRow> Gq2)
	{
		if (Nk0 == null || Nk0.Length < 1)
		{
			return Nk0;
		}
		if (Gq2 == null || Gq2.Count < 1)
		{
			return Nk0;
		}
		List<DataRow> list = new List<DataRow>();
		foreach (DataRow item in Nk0)
		{
			if (!Gq2.Contains(item))
			{
				list.Add(item);
			}
		}
		return list.ToArray();
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int g4B(Pt8 f3F)
	{
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected O, but got Unknown
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected O, but got Unknown
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Expected O, but got Unknown
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Expected O, but got Unknown
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Expected O, but got Unknown
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Expected O, but got Unknown
		//IL_0451: Unknown result type (might be due to invalid IL or missing references)
		//IL_045b: Expected O, but got Unknown
		//IL_0485: Unknown result type (might be due to invalid IL or missing references)
		//IL_048f: Expected O, but got Unknown
		//IL_04b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c3: Expected O, but got Unknown
		if (f3F == null)
		{
			throw new ArgumentNullException("dataSet");
		}
		if (!f3F.HasChanges())
		{
			return 0;
		}
		if (_booksTableAdapter != null && !Qi9((IDbConnection)_booksTableAdapter.Connection))
		{
			throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
		}
		if (_borrowedTableAdapter != null && !Qi9((IDbConnection)_borrowedTableAdapter.Connection))
		{
			throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
		}
		if (O != null && !Qi9((IDbConnection)O.Connection))
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
			dataSet.Merge(f3F);
		}
		checked
		{
			try
			{
				if (_booksTableAdapter != null)
				{
					dictionary.Add(_booksTableAdapter, (IDbConnection)_booksTableAdapter.Connection);
					_booksTableAdapter.Connection = (OleDbConnection)connection;
					_booksTableAdapter.Transaction = (OleDbTransaction)dbTransaction;
					if (((DataAdapter)(object)_booksTableAdapter.Adapter).AcceptChangesDuringUpdate)
					{
						((DataAdapter)(object)_booksTableAdapter.Adapter).AcceptChangesDuringUpdate = false;
						list3.Add((DataAdapter)(object)_booksTableAdapter.Adapter);
					}
				}
				if (_borrowedTableAdapter != null)
				{
					dictionary.Add(_borrowedTableAdapter, (IDbConnection)_borrowedTableAdapter.Connection);
					_borrowedTableAdapter.Connection = (OleDbConnection)connection;
					_borrowedTableAdapter.Transaction = (OleDbTransaction)dbTransaction;
					if (((DataAdapter)(object)_borrowedTableAdapter.Adapter).AcceptChangesDuringUpdate)
					{
						((DataAdapter)(object)_borrowedTableAdapter.Adapter).AcceptChangesDuringUpdate = false;
						list3.Add((DataAdapter)(object)_borrowedTableAdapter.Adapter);
					}
				}
				if (O != null)
				{
					dictionary.Add(O, (IDbConnection)O.Connection);
					O.Connection = (OleDbConnection)connection;
					O.Transaction = (OleDbTransaction)dbTransaction;
					if (((DataAdapter)(object)O.Adapter).AcceptChangesDuringUpdate)
					{
						((DataAdapter)(object)O.Adapter).AcceptChangesDuringUpdate = false;
						list3.Add((DataAdapter)(object)O.Adapter);
					}
				}
				if (UpdateOrder == Hb3.UpdateInsertDelete)
				{
					num += s5P(f3F, list, list2);
					num += Sq3(f3F, list2);
				}
				else
				{
					num += Sq3(f3F, list2);
					num += s5P(f3F, list, list2);
				}
				num += b0L(f3F, list);
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
					f3F.Clear();
					f3F.Merge(dataSet);
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
				if (_booksTableAdapter != null)
				{
					_booksTableAdapter.Connection = (OleDbConnection)dictionary[_booksTableAdapter];
					_booksTableAdapter.Transaction = null;
				}
				if (_borrowedTableAdapter != null)
				{
					_borrowedTableAdapter.Connection = (OleDbConnection)dictionary[_borrowedTableAdapter];
					_borrowedTableAdapter.Transaction = null;
				}
				if (O != null)
				{
					O.Connection = (OleDbConnection)dictionary[O];
					O.Transaction = null;
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
	protected virtual void x8M(DataRow[] Fo8, DataRelation Cw9, bool Yf4)
	{
		Array.Sort(Fo8, new t7M(Cw9, Yf4));
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected virtual bool Qi9(IDbConnection m0J)
	{
		if (_connection != null)
		{
			return true;
		}
		if (Connection == null || m0J == null)
		{
			return true;
		}
		if (string.Equals(Connection.ConnectionString, m0J.ConnectionString, StringComparison.Ordinal))
		{
			return true;
		}
		return false;
	}
}
