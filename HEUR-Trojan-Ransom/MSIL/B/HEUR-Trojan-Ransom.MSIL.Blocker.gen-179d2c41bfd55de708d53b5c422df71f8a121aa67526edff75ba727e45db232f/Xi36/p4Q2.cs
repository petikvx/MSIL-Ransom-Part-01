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
using Gi7;
using Kn6m;
using Microsoft.VisualBasic.CompilerServices;
using Qz8;
using e5AR;
using g4N1;
using p8S;

namespace Xi36;

[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[ToolboxItem(true)]
[HelpKeyword("vs.data.TableAdapterManager")]
[DesignerCategory("code")]
public class p4Q2 : Component
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public enum Xp8x
	{
		InsertUpdateDelete,
		UpdateInsertDelete
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private sealed class Xs58 : IComparer<DataRow>
	{
		private DataRelation _relation;

		private int _childFirst;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal Xs58(DataRelation relation, bool childFirst)
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
		private DataRow r4M3(DataRow Gc45, ref int g5JB)
		{
			Debug.Assert(Gc45 != null);
			DataRow result = Gc45;
			g5JB = 0;
			IDictionary<DataRow, DataRow> dictionary = new Dictionary<DataRow, DataRow>();
			dictionary[Gc45] = Gc45;
			DataRow parentRow = Gc45.GetParentRow(_relation, DataRowVersion.Default);
			checked
			{
				while (parentRow != null && !dictionary.ContainsKey(parentRow))
				{
					g5JB++;
					result = parentRow;
					dictionary[parentRow] = parentRow;
					parentRow = parentRow.GetParentRow(_relation, DataRowVersion.Default);
				}
				if (g5JB == 0)
				{
					dictionary.Clear();
					dictionary[Gc45] = Gc45;
					parentRow = Gc45.GetParentRow(_relation, DataRowVersion.Original);
					while (parentRow != null && !dictionary.ContainsKey(parentRow))
					{
						g5JB++;
						result = parentRow;
						dictionary[parentRow] = parentRow;
						parentRow = parentRow.GetParentRow(_relation, DataRowVersion.Original);
					}
				}
				return result;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int Ts94(DataRow Rm06, DataRow Rw1x)
		{
			if (object.ReferenceEquals(Rm06, Rw1x))
			{
				return 0;
			}
			if (Rm06 == null)
			{
				return -1;
			}
			if (Rw1x == null)
			{
				return 1;
			}
			int g5JB = 0;
			DataRow dataRow = r4M3(Rm06, ref g5JB);
			int g5JB2 = 0;
			DataRow dataRow2 = r4M3(Rw1x, ref g5JB2);
			if (object.ReferenceEquals(dataRow, dataRow2))
			{
				return checked(_childFirst * g5JB.CompareTo(g5JB2));
			}
			Debug.Assert(dataRow.Table != null && dataRow2.Table != null);
			if (dataRow.Table.Rows.IndexOf(dataRow) < dataRow2.Table.Rows.IndexOf(dataRow2))
			{
				return -1;
			}
			return 1;
		}

		int IComparer<DataRow>.Compare(DataRow Rm06, DataRow Rw1x)
		{
			//ILSpy generated this explicit interface implementation from .override directive in Ts94
			return this.Ts94(Rm06, Rw1x);
		}
	}

	private Xp8x _updateOrder;

	private r0C _booksTableAdapter;

	private Ys1 _borrowbookTableAdapter;

	private z1J6 _studentlibloginTableAdapter;

	private bool _backupDataSetBeforeUpdate;

	internal c7S R;

	internal Fi06 K;

	internal IDbConnection g;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public Xp8x UpdateOrder
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
	public r0C booksTableAdapter
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

	[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public Ys1 borrowbookTableAdapter
	{
		get
		{
			return _borrowbookTableAdapter;
		}
		set
		{
			_borrowbookTableAdapter = value;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
	public c7S leacturelibloginTableAdapter
	{
		get
		{
			return R;
		}
		set
		{
			c7S c7S = (R = value);
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
	public Fi06 loginTableAdapter
	{
		get
		{
			return K;
		}
		set
		{
			Fi06 fi = (K = value);
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
	public z1J6 studentlibloginTableAdapter
	{
		get
		{
			return _studentlibloginTableAdapter;
		}
		set
		{
			_studentlibloginTableAdapter = value;
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
			if (g != null)
			{
				return g;
			}
			if (_booksTableAdapter != null && _booksTableAdapter.Connection != null)
			{
				return (IDbConnection)_booksTableAdapter.Connection;
			}
			if (_borrowbookTableAdapter != null && _borrowbookTableAdapter.Connection != null)
			{
				return (IDbConnection)_borrowbookTableAdapter.Connection;
			}
			if (R != null && R.Connection != null)
			{
				return (IDbConnection)R.Connection;
			}
			if (K != null && K.Connection != null)
			{
				return (IDbConnection)K.Connection;
			}
			if (_studentlibloginTableAdapter != null && _studentlibloginTableAdapter.Connection != null)
			{
				return (IDbConnection)_studentlibloginTableAdapter.Connection;
			}
			return null;
		}
		set
		{
			IDbConnection dbConnection = (g = value);
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
				if (_borrowbookTableAdapter != null)
				{
					num++;
				}
				if (R != null)
				{
					num++;
				}
				if (K != null)
				{
					num++;
				}
				if (_studentlibloginTableAdapter != null)
				{
					num++;
				}
				return num;
			}
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private int c4S6(Ct6g r9Z7, List<DataRow> Jc2f, List<DataRow> Kf20)
	{
		int num = 0;
		checked
		{
			if (_booksTableAdapter != null)
			{
				DataRow[] n6Y = r9Z7.books.Select(null, null, DataViewRowState.ModifiedCurrent);
				n6Y = Ab1x(n6Y, Kf20);
				if (n6Y != null && 0 < n6Y.Length)
				{
					num += _booksTableAdapter.z5T(n6Y);
					Jc2f.AddRange(n6Y);
				}
			}
			if (_borrowbookTableAdapter != null)
			{
				DataRow[] n6Y2 = r9Z7.borrowbook.Select(null, null, DataViewRowState.ModifiedCurrent);
				n6Y2 = Ab1x(n6Y2, Kf20);
				if (n6Y2 != null && 0 < n6Y2.Length)
				{
					num += _borrowbookTableAdapter.Kz7(n6Y2);
					Jc2f.AddRange(n6Y2);
				}
			}
			if (R != null)
			{
				DataRow[] n6Y3 = r9Z7.leactureliblogin.Select(null, null, DataViewRowState.ModifiedCurrent);
				n6Y3 = Ab1x(n6Y3, Kf20);
				if (n6Y3 != null && 0 < n6Y3.Length)
				{
					num += R.Tp3(n6Y3);
					Jc2f.AddRange(n6Y3);
				}
			}
			if (K != null)
			{
				DataRow[] n6Y4 = r9Z7.login.Select(null, null, DataViewRowState.ModifiedCurrent);
				n6Y4 = Ab1x(n6Y4, Kf20);
				if (n6Y4 != null && 0 < n6Y4.Length)
				{
					num += K.c0S7(n6Y4);
					Jc2f.AddRange(n6Y4);
				}
			}
			if (_studentlibloginTableAdapter != null)
			{
				DataRow[] n6Y5 = r9Z7.studentliblogin.Select(null, null, DataViewRowState.ModifiedCurrent);
				n6Y5 = Ab1x(n6Y5, Kf20);
				if (n6Y5 != null && 0 < n6Y5.Length)
				{
					num += _studentlibloginTableAdapter.b1S7(n6Y5);
					Jc2f.AddRange(n6Y5);
				}
			}
			return num;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private int Ja54(Ct6g k0QC, List<DataRow> r5C0)
	{
		int num = 0;
		checked
		{
			if (_booksTableAdapter != null)
			{
				DataRow[] array = k0QC.books.Select(null, null, DataViewRowState.Added);
				if (array != null && 0 < array.Length)
				{
					num += _booksTableAdapter.z5T(array);
					r5C0.AddRange(array);
				}
			}
			if (_borrowbookTableAdapter != null)
			{
				DataRow[] array2 = k0QC.borrowbook.Select(null, null, DataViewRowState.Added);
				if (array2 != null && 0 < array2.Length)
				{
					num += _borrowbookTableAdapter.Kz7(array2);
					r5C0.AddRange(array2);
				}
			}
			if (R != null)
			{
				DataRow[] array3 = k0QC.leactureliblogin.Select(null, null, DataViewRowState.Added);
				if (array3 != null && 0 < array3.Length)
				{
					num += R.Tp3(array3);
					r5C0.AddRange(array3);
				}
			}
			if (K != null)
			{
				DataRow[] array4 = k0QC.login.Select(null, null, DataViewRowState.Added);
				if (array4 != null && 0 < array4.Length)
				{
					num += K.c0S7(array4);
					r5C0.AddRange(array4);
				}
			}
			if (_studentlibloginTableAdapter != null)
			{
				DataRow[] array5 = k0QC.studentliblogin.Select(null, null, DataViewRowState.Added);
				if (array5 != null && 0 < array5.Length)
				{
					num += _studentlibloginTableAdapter.b1S7(array5);
					r5C0.AddRange(array5);
				}
			}
			return num;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private int Nw64(Ct6g Zk57, List<DataRow> Cb5s)
	{
		int num = 0;
		checked
		{
			if (_studentlibloginTableAdapter != null)
			{
				DataRow[] array = Zk57.studentliblogin.Select(null, null, DataViewRowState.Deleted);
				if (array != null && 0 < array.Length)
				{
					num += _studentlibloginTableAdapter.b1S7(array);
					Cb5s.AddRange(array);
				}
			}
			if (K != null)
			{
				DataRow[] array2 = Zk57.login.Select(null, null, DataViewRowState.Deleted);
				if (array2 != null && 0 < array2.Length)
				{
					num += K.c0S7(array2);
					Cb5s.AddRange(array2);
				}
			}
			if (R != null)
			{
				DataRow[] array3 = Zk57.leactureliblogin.Select(null, null, DataViewRowState.Deleted);
				if (array3 != null && 0 < array3.Length)
				{
					num += R.Tp3(array3);
					Cb5s.AddRange(array3);
				}
			}
			if (_borrowbookTableAdapter != null)
			{
				DataRow[] array4 = Zk57.borrowbook.Select(null, null, DataViewRowState.Deleted);
				if (array4 != null && 0 < array4.Length)
				{
					num += _borrowbookTableAdapter.Kz7(array4);
					Cb5s.AddRange(array4);
				}
			}
			if (_booksTableAdapter != null)
			{
				DataRow[] array5 = Zk57.books.Select(null, null, DataViewRowState.Deleted);
				if (array5 != null && 0 < array5.Length)
				{
					num += _booksTableAdapter.z5T(array5);
					Cb5s.AddRange(array5);
				}
			}
			return num;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private DataRow[] Ab1x(DataRow[] n6Y1, List<DataRow> Qy5a)
	{
		if (n6Y1 == null || n6Y1.Length < 1)
		{
			return n6Y1;
		}
		if (Qy5a == null || Qy5a.Count < 1)
		{
			return n6Y1;
		}
		List<DataRow> list = new List<DataRow>();
		foreach (DataRow item in n6Y1)
		{
			if (!Qy5a.Contains(item))
			{
				list.Add(item);
			}
		}
		return list.ToArray();
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int Jw6n(Ct6g r8DY)
	{
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Expected O, but got Unknown
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Expected O, but got Unknown
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected O, but got Unknown
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Expected O, but got Unknown
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Expected O, but got Unknown
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Expected O, but got Unknown
		//IL_032d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0337: Expected O, but got Unknown
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0348: Expected O, but got Unknown
		//IL_03a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b1: Expected O, but got Unknown
		//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c2: Expected O, but got Unknown
		//IL_059d: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a7: Expected O, but got Unknown
		//IL_05d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05db: Expected O, but got Unknown
		//IL_0605: Unknown result type (might be due to invalid IL or missing references)
		//IL_060f: Expected O, but got Unknown
		//IL_0639: Unknown result type (might be due to invalid IL or missing references)
		//IL_0643: Expected O, but got Unknown
		//IL_066d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0677: Expected O, but got Unknown
		if (r8DY == null)
		{
			throw new ArgumentNullException("dataSet");
		}
		if (!r8DY.HasChanges())
		{
			return 0;
		}
		if (_booksTableAdapter != null && !Ls36((IDbConnection)_booksTableAdapter.Connection))
		{
			throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
		}
		if (_borrowbookTableAdapter != null && !Ls36((IDbConnection)_borrowbookTableAdapter.Connection))
		{
			throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
		}
		if (R != null && !Ls36((IDbConnection)R.Connection))
		{
			throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
		}
		if (K != null && !Ls36((IDbConnection)K.Connection))
		{
			throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
		}
		if (_studentlibloginTableAdapter != null && !Ls36((IDbConnection)_studentlibloginTableAdapter.Connection))
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
			dataSet.Merge(r8DY);
		}
		checked
		{
			try
			{
				if (_booksTableAdapter != null)
				{
					dictionary.Add(_booksTableAdapter, (IDbConnection)_booksTableAdapter.Connection);
					_booksTableAdapter.Connection = (SqlConnection)connection;
					_booksTableAdapter.Transaction = (SqlTransaction)dbTransaction;
					if (((DataAdapter)(object)_booksTableAdapter.Adapter).AcceptChangesDuringUpdate)
					{
						((DataAdapter)(object)_booksTableAdapter.Adapter).AcceptChangesDuringUpdate = false;
						list3.Add((DataAdapter)(object)_booksTableAdapter.Adapter);
					}
				}
				if (_borrowbookTableAdapter != null)
				{
					dictionary.Add(_borrowbookTableAdapter, (IDbConnection)_borrowbookTableAdapter.Connection);
					_borrowbookTableAdapter.Connection = (SqlConnection)connection;
					_borrowbookTableAdapter.Transaction = (SqlTransaction)dbTransaction;
					if (((DataAdapter)(object)_borrowbookTableAdapter.Adapter).AcceptChangesDuringUpdate)
					{
						((DataAdapter)(object)_borrowbookTableAdapter.Adapter).AcceptChangesDuringUpdate = false;
						list3.Add((DataAdapter)(object)_borrowbookTableAdapter.Adapter);
					}
				}
				if (R != null)
				{
					dictionary.Add(R, (IDbConnection)R.Connection);
					R.Connection = (SqlConnection)connection;
					R.Transaction = (SqlTransaction)dbTransaction;
					if (((DataAdapter)(object)R.Adapter).AcceptChangesDuringUpdate)
					{
						((DataAdapter)(object)R.Adapter).AcceptChangesDuringUpdate = false;
						list3.Add((DataAdapter)(object)R.Adapter);
					}
				}
				if (K != null)
				{
					dictionary.Add(K, (IDbConnection)K.Connection);
					K.Connection = (SqlConnection)connection;
					K.Transaction = (SqlTransaction)dbTransaction;
					if (((DataAdapter)(object)K.Adapter).AcceptChangesDuringUpdate)
					{
						((DataAdapter)(object)K.Adapter).AcceptChangesDuringUpdate = false;
						list3.Add((DataAdapter)(object)K.Adapter);
					}
				}
				if (_studentlibloginTableAdapter != null)
				{
					dictionary.Add(_studentlibloginTableAdapter, (IDbConnection)_studentlibloginTableAdapter.Connection);
					_studentlibloginTableAdapter.Connection = (SqlConnection)connection;
					_studentlibloginTableAdapter.Transaction = (SqlTransaction)dbTransaction;
					if (((DataAdapter)(object)_studentlibloginTableAdapter.Adapter).AcceptChangesDuringUpdate)
					{
						((DataAdapter)(object)_studentlibloginTableAdapter.Adapter).AcceptChangesDuringUpdate = false;
						list3.Add((DataAdapter)(object)_studentlibloginTableAdapter.Adapter);
					}
				}
				if (UpdateOrder == Xp8x.UpdateInsertDelete)
				{
					num += c4S6(r8DY, list, list2);
					num += Ja54(r8DY, list2);
				}
				else
				{
					num += Ja54(r8DY, list2);
					num += c4S6(r8DY, list, list2);
				}
				num += Nw64(r8DY, list);
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
					r8DY.Clear();
					r8DY.Merge(dataSet);
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
					_booksTableAdapter.Connection = (SqlConnection)dictionary[_booksTableAdapter];
					_booksTableAdapter.Transaction = null;
				}
				if (_borrowbookTableAdapter != null)
				{
					_borrowbookTableAdapter.Connection = (SqlConnection)dictionary[_borrowbookTableAdapter];
					_borrowbookTableAdapter.Transaction = null;
				}
				if (R != null)
				{
					R.Connection = (SqlConnection)dictionary[R];
					R.Transaction = null;
				}
				if (K != null)
				{
					K.Connection = (SqlConnection)dictionary[K];
					K.Transaction = null;
				}
				if (_studentlibloginTableAdapter != null)
				{
					_studentlibloginTableAdapter.Connection = (SqlConnection)dictionary[_studentlibloginTableAdapter];
					_studentlibloginTableAdapter.Transaction = null;
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
	protected virtual void Ei90(DataRow[] Gw86, DataRelation k6Q9, bool Sk45)
	{
		Array.Sort(Gw86, new Xs58(k6Q9, Sk45));
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected virtual bool Ls36(IDbConnection t5M1)
	{
		if (g != null)
		{
			return true;
		}
		if (Connection == null || t5M1 == null)
		{
			return true;
		}
		if (string.Equals(Connection.ConnectionString, t5M1.ConnectionString, StringComparison.Ordinal))
		{
			return true;
		}
		return false;
	}
}
