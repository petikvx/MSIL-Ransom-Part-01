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
using Em26;
using Microsoft.VisualBasic.CompilerServices;
using Yx5n;
using a3B;
using a6T;
using j8W;

namespace f8X;

[DesignerCategory("code")]
[ToolboxItem(true)]
[HelpKeyword("vs.data.TableAdapterManager")]
[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
public class Mb7 : Component
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public enum y8Y
	{
		InsertUpdateDelete,
		UpdateInsertDelete
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private sealed class Rt9 : IComparer<DataRow>
	{
		private DataRelation _relation;

		private int _childFirst;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal Rt9(DataRelation relation, bool childFirst)
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
		private DataRow Xr8(DataRow Bx6, ref int c5A)
		{
			Debug.Assert(Bx6 != null);
			DataRow result = Bx6;
			c5A = 0;
			IDictionary<DataRow, DataRow> dictionary = new Dictionary<DataRow, DataRow>();
			dictionary[Bx6] = Bx6;
			DataRow parentRow = Bx6.GetParentRow(_relation, DataRowVersion.Default);
			checked
			{
				while (parentRow != null && !dictionary.ContainsKey(parentRow))
				{
					c5A++;
					result = parentRow;
					dictionary[parentRow] = parentRow;
					parentRow = parentRow.GetParentRow(_relation, DataRowVersion.Default);
				}
				if (c5A == 0)
				{
					dictionary.Clear();
					dictionary[Bx6] = Bx6;
					parentRow = Bx6.GetParentRow(_relation, DataRowVersion.Original);
					while (parentRow != null && !dictionary.ContainsKey(parentRow))
					{
						c5A++;
						result = parentRow;
						dictionary[parentRow] = parentRow;
						parentRow = parentRow.GetParentRow(_relation, DataRowVersion.Original);
					}
				}
				return result;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int Dk0(DataRow Qr8, DataRow Wb7)
		{
			if (object.ReferenceEquals(Qr8, Wb7))
			{
				return 0;
			}
			if (Qr8 == null)
			{
				return -1;
			}
			if (Wb7 == null)
			{
				return 1;
			}
			int c5A = 0;
			DataRow dataRow = Xr8(Qr8, ref c5A);
			int c5A2 = 0;
			DataRow dataRow2 = Xr8(Wb7, ref c5A2);
			if (object.ReferenceEquals(dataRow, dataRow2))
			{
				return checked(_childFirst * c5A.CompareTo(c5A2));
			}
			Debug.Assert(dataRow.Table != null && dataRow2.Table != null);
			if (dataRow.Table.Rows.IndexOf(dataRow) < dataRow2.Table.Rows.IndexOf(dataRow2))
			{
				return -1;
			}
			return 1;
		}

		int IComparer<DataRow>.Compare(DataRow Qr8, DataRow Wb7)
		{
			//ILSpy generated this explicit interface implementation from .override directive in Dk0
			return this.Dk0(Qr8, Wb7);
		}
	}

	private y8Y _updateOrder;

	private Zm0 _booksTableAdapter;

	private bool _backupDataSetBeforeUpdate;

	private IDbConnection _connection;

	internal g6Y7 L;

	internal Ge42 h;

	internal m6F f;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public y8Y UpdateOrder
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
	public Zm0 BooksTableAdapter
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
	public g6Y7 BorrowedTableAdapter
	{
		get
		{
			return L;
		}
		set
		{
			g6Y7 g6Y = (L = value);
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
	public Ge42 UsersTableAdapter
	{
		get
		{
			return h;
		}
		set
		{
			Ge42 ge = (h = value);
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
	public m6F RatingListTableAdapter
	{
		get
		{
			return f;
		}
		set
		{
			m6F m6F = (f = value);
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
			if (_connection != null)
			{
				return _connection;
			}
			if (_booksTableAdapter != null && _booksTableAdapter.Connection != null)
			{
				return (IDbConnection)_booksTableAdapter.Connection;
			}
			if (L != null && L.Connection != null)
			{
				return (IDbConnection)L.Connection;
			}
			if (h != null && h.Connection != null)
			{
				return (IDbConnection)h.Connection;
			}
			if (f != null && f.Connection != null)
			{
				return (IDbConnection)f.Connection;
			}
			return null;
		}
		set
		{
			_connection = value;
		}
	}

	[Browsable(false)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
				if (L != null)
				{
					num++;
				}
				if (h != null)
				{
					num++;
				}
				if (f != null)
				{
					num++;
				}
				return num;
			}
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private int g1P(Di1 w5K, List<DataRow> m8H, List<DataRow> o3W)
	{
		int num = 0;
		checked
		{
			if (_booksTableAdapter != null)
			{
				DataRow[] s8N = w5K.Books.Select(null, null, DataViewRowState.ModifiedCurrent);
				s8N = Ne1(s8N, o3W);
				if (s8N != null && 0 < s8N.Length)
				{
					num += _booksTableAdapter.Ww1(s8N);
					m8H.AddRange(s8N);
				}
			}
			if (L != null)
			{
				DataRow[] s8N2 = w5K.Borrowed.Select(null, null, DataViewRowState.ModifiedCurrent);
				s8N2 = Ne1(s8N2, o3W);
				if (s8N2 != null && 0 < s8N2.Length)
				{
					num += L.b6E2(s8N2);
					m8H.AddRange(s8N2);
				}
			}
			if (h != null)
			{
				DataRow[] s8N3 = w5K.Users.Select(null, null, DataViewRowState.ModifiedCurrent);
				s8N3 = Ne1(s8N3, o3W);
				if (s8N3 != null && 0 < s8N3.Length)
				{
					num += h.Co9a(s8N3);
					m8H.AddRange(s8N3);
				}
			}
			if (f != null)
			{
				DataRow[] s8N4 = w5K.RatingList.Select(null, null, DataViewRowState.ModifiedCurrent);
				s8N4 = Ne1(s8N4, o3W);
				if (s8N4 != null && 0 < s8N4.Length)
				{
					num += f.Bt6(s8N4);
					m8H.AddRange(s8N4);
				}
			}
			return num;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private int x2R(Di1 w4B, List<DataRow> Zt8)
	{
		int num = 0;
		checked
		{
			if (_booksTableAdapter != null)
			{
				DataRow[] array = w4B.Books.Select(null, null, DataViewRowState.Added);
				if (array != null && 0 < array.Length)
				{
					num += _booksTableAdapter.Ww1(array);
					Zt8.AddRange(array);
				}
			}
			if (L != null)
			{
				DataRow[] array2 = w4B.Borrowed.Select(null, null, DataViewRowState.Added);
				if (array2 != null && 0 < array2.Length)
				{
					num += L.b6E2(array2);
					Zt8.AddRange(array2);
				}
			}
			if (h != null)
			{
				DataRow[] array3 = w4B.Users.Select(null, null, DataViewRowState.Added);
				if (array3 != null && 0 < array3.Length)
				{
					num += h.Co9a(array3);
					Zt8.AddRange(array3);
				}
			}
			if (f != null)
			{
				DataRow[] array4 = w4B.RatingList.Select(null, null, DataViewRowState.Added);
				if (array4 != null && 0 < array4.Length)
				{
					num += f.Bt6(array4);
					Zt8.AddRange(array4);
				}
			}
			return num;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private int a4W(Di1 Do5, List<DataRow> Hy5)
	{
		int num = 0;
		checked
		{
			if (f != null)
			{
				DataRow[] array = Do5.RatingList.Select(null, null, DataViewRowState.Deleted);
				if (array != null && 0 < array.Length)
				{
					num += f.Bt6(array);
					Hy5.AddRange(array);
				}
			}
			if (h != null)
			{
				DataRow[] array2 = Do5.Users.Select(null, null, DataViewRowState.Deleted);
				if (array2 != null && 0 < array2.Length)
				{
					num += h.Co9a(array2);
					Hy5.AddRange(array2);
				}
			}
			if (L != null)
			{
				DataRow[] array3 = Do5.Borrowed.Select(null, null, DataViewRowState.Deleted);
				if (array3 != null && 0 < array3.Length)
				{
					num += L.b6E2(array3);
					Hy5.AddRange(array3);
				}
			}
			if (_booksTableAdapter != null)
			{
				DataRow[] array4 = Do5.Books.Select(null, null, DataViewRowState.Deleted);
				if (array4 != null && 0 < array4.Length)
				{
					num += _booksTableAdapter.Ww1(array4);
					Hy5.AddRange(array4);
				}
			}
			return num;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private DataRow[] Ne1(DataRow[] s8N, List<DataRow> a7J)
	{
		if (s8N == null || s8N.Length < 1)
		{
			return s8N;
		}
		if (a7J == null || a7J.Count < 1)
		{
			return s8N;
		}
		List<DataRow> list = new List<DataRow>();
		foreach (DataRow item in s8N)
		{
			if (!a7J.Contains(item))
			{
				list.Add(item);
			}
		}
		return list.ToArray();
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int n7G(Di1 i9Y)
	{
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected O, but got Unknown
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected O, but got Unknown
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Expected O, but got Unknown
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Expected O, but got Unknown
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Expected O, but got Unknown
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Expected O, but got Unknown
		//IL_0301: Unknown result type (might be due to invalid IL or missing references)
		//IL_030b: Expected O, but got Unknown
		//IL_0312: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Expected O, but got Unknown
		//IL_04f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0501: Expected O, but got Unknown
		//IL_052b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0535: Expected O, but got Unknown
		//IL_055f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0569: Expected O, but got Unknown
		//IL_0593: Unknown result type (might be due to invalid IL or missing references)
		//IL_059d: Expected O, but got Unknown
		if (i9Y == null)
		{
			throw new ArgumentNullException("dataSet");
		}
		if (!i9Y.HasChanges())
		{
			return 0;
		}
		if (_booksTableAdapter != null && !m8L((IDbConnection)_booksTableAdapter.Connection))
		{
			throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
		}
		if (L != null && !m8L((IDbConnection)L.Connection))
		{
			throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
		}
		if (h != null && !m8L((IDbConnection)h.Connection))
		{
			throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
		}
		if (f != null && !m8L((IDbConnection)f.Connection))
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
			dataSet.Merge(i9Y);
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
				if (L != null)
				{
					dictionary.Add(L, (IDbConnection)L.Connection);
					L.Connection = (OleDbConnection)connection;
					L.Transaction = (OleDbTransaction)dbTransaction;
					if (((DataAdapter)(object)L.Adapter).AcceptChangesDuringUpdate)
					{
						((DataAdapter)(object)L.Adapter).AcceptChangesDuringUpdate = false;
						list3.Add((DataAdapter)(object)L.Adapter);
					}
				}
				if (h != null)
				{
					dictionary.Add(h, (IDbConnection)h.Connection);
					h.Connection = (OleDbConnection)connection;
					h.Transaction = (OleDbTransaction)dbTransaction;
					if (((DataAdapter)(object)h.Adapter).AcceptChangesDuringUpdate)
					{
						((DataAdapter)(object)h.Adapter).AcceptChangesDuringUpdate = false;
						list3.Add((DataAdapter)(object)h.Adapter);
					}
				}
				if (f != null)
				{
					dictionary.Add(f, (IDbConnection)f.Connection);
					f.Connection = (OleDbConnection)connection;
					f.Transaction = (OleDbTransaction)dbTransaction;
					if (((DataAdapter)(object)f.Adapter).AcceptChangesDuringUpdate)
					{
						((DataAdapter)(object)f.Adapter).AcceptChangesDuringUpdate = false;
						list3.Add((DataAdapter)(object)f.Adapter);
					}
				}
				if (UpdateOrder == y8Y.UpdateInsertDelete)
				{
					num += g1P(i9Y, list, list2);
					num += x2R(i9Y, list2);
				}
				else
				{
					num += x2R(i9Y, list2);
					num += g1P(i9Y, list, list2);
				}
				num += a4W(i9Y, list);
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
					i9Y.Clear();
					i9Y.Merge(dataSet);
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
				if (L != null)
				{
					L.Connection = (OleDbConnection)dictionary[L];
					L.Transaction = null;
				}
				if (h != null)
				{
					h.Connection = (OleDbConnection)dictionary[h];
					h.Transaction = null;
				}
				if (f != null)
				{
					f.Connection = (OleDbConnection)dictionary[f];
					f.Transaction = null;
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
	protected virtual void Hp7(DataRow[] Si8, DataRelation w5J, bool Cr2)
	{
		Array.Sort(Si8, new Rt9(w5J, Cr2));
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected virtual bool m8L(IDbConnection q8G)
	{
		if (_connection != null)
		{
			return true;
		}
		if (Connection == null || q8G == null)
		{
			return true;
		}
		if (string.Equals(Connection.ConnectionString, q8G.ConnectionString, StringComparison.Ordinal))
		{
			return true;
		}
		return false;
	}
}
