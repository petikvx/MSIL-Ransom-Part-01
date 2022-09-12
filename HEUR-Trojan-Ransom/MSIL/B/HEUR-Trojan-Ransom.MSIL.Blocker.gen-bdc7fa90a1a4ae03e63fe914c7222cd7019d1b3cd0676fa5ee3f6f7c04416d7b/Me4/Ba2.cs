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
using Qq2;
using t0G;
using t1F;

namespace Me4;

[DesignerCategory("code")]
[HelpKeyword("vs.data.TableAdapterManager")]
[ToolboxItem(true)]
[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
public class Ba2 : Component
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public enum Gm1
	{
		InsertUpdateDelete,
		UpdateInsertDelete
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private sealed class w0X : IComparer<DataRow>
	{
		private DataRelation _relation;

		private int _childFirst;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal w0X(DataRelation relation, bool childFirst)
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
		private DataRow z8G(DataRow Ad3, ref int c3X)
		{
			Debug.Assert(Ad3 != null);
			DataRow result = Ad3;
			c3X = 0;
			IDictionary<DataRow, DataRow> dictionary = new Dictionary<DataRow, DataRow>();
			dictionary[Ad3] = Ad3;
			DataRow parentRow = Ad3.GetParentRow(_relation, DataRowVersion.Default);
			checked
			{
				while (parentRow != null && !dictionary.ContainsKey(parentRow))
				{
					c3X++;
					result = parentRow;
					dictionary[parentRow] = parentRow;
					parentRow = parentRow.GetParentRow(_relation, DataRowVersion.Default);
				}
				if (c3X == 0)
				{
					dictionary.Clear();
					dictionary[Ad3] = Ad3;
					parentRow = Ad3.GetParentRow(_relation, DataRowVersion.Original);
					while (parentRow != null && !dictionary.ContainsKey(parentRow))
					{
						c3X++;
						result = parentRow;
						dictionary[parentRow] = parentRow;
						parentRow = parentRow.GetParentRow(_relation, DataRowVersion.Original);
					}
				}
				return result;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public int Lp3(DataRow o4C, DataRow Rb4)
		{
			if (object.ReferenceEquals(o4C, Rb4))
			{
				return 0;
			}
			if (o4C == null)
			{
				return -1;
			}
			if (Rb4 == null)
			{
				return 1;
			}
			int c3X = 0;
			DataRow dataRow = z8G(o4C, ref c3X);
			int c3X2 = 0;
			DataRow dataRow2 = z8G(Rb4, ref c3X2);
			if (object.ReferenceEquals(dataRow, dataRow2))
			{
				return checked(_childFirst * c3X.CompareTo(c3X2));
			}
			Debug.Assert(dataRow.Table != null && dataRow2.Table != null);
			if (dataRow.Table.Rows.IndexOf(dataRow) < dataRow2.Table.Rows.IndexOf(dataRow2))
			{
				return -1;
			}
			return 1;
		}

		int IComparer<DataRow>.Compare(DataRow o4C, DataRow Rb4)
		{
			//ILSpy generated this explicit interface implementation from .override directive in Lp3
			return this.Lp3(o4C, Rb4);
		}
	}

	private Gm1 _updateOrder;

	private c7Q _menuTableAdapter;

	internal k8Z I;

	internal bool a;

	internal IDbConnection j;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public Gm1 UpdateOrder
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
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public c7Q MenuTableAdapter
	{
		get
		{
			return _menuTableAdapter;
		}
		set
		{
			_menuTableAdapter = value;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
	public k8Z Requested_ItemsTableAdapter
	{
		get
		{
			return I;
		}
		set
		{
			k8Z k8Z = (I = value);
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public bool BackupDataSetBeforeUpdate
	{
		get
		{
			return a;
		}
		set
		{
			bool flag = (a = value);
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[Browsable(false)]
	public IDbConnection Connection
	{
		get
		{
			if (j != null)
			{
				return j;
			}
			if (_menuTableAdapter != null && _menuTableAdapter.Connection != null)
			{
				return (IDbConnection)_menuTableAdapter.Connection;
			}
			if (I != null && I.Connection != null)
			{
				return (IDbConnection)I.Connection;
			}
			return null;
		}
		set
		{
			IDbConnection dbConnection = (j = value);
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
				if (_menuTableAdapter != null)
				{
					num++;
				}
				if (I != null)
				{
					num++;
				}
				return num;
			}
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private int Gn5(t8Y f8D, List<DataRow> q3R, List<DataRow> Fk8)
	{
		int num = 0;
		checked
		{
			if (_menuTableAdapter != null)
			{
				DataRow[] s2E = f8D.Menu.Select(null, null, DataViewRowState.ModifiedCurrent);
				s2E = r7C(s2E, Fk8);
				if (s2E != null && 0 < s2E.Length)
				{
					num += _menuTableAdapter.Tb5(s2E);
					q3R.AddRange(s2E);
				}
			}
			if (I != null)
			{
				DataRow[] s2E2 = f8D.Requested_Items.Select(null, null, DataViewRowState.ModifiedCurrent);
				s2E2 = r7C(s2E2, Fk8);
				if (s2E2 != null && 0 < s2E2.Length)
				{
					num += I.Rp9(s2E2);
					q3R.AddRange(s2E2);
				}
			}
			return num;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private int Af8(t8Y j2W, List<DataRow> Pt6)
	{
		int num = 0;
		checked
		{
			if (_menuTableAdapter != null)
			{
				DataRow[] array = j2W.Menu.Select(null, null, DataViewRowState.Added);
				if (array != null && 0 < array.Length)
				{
					num += _menuTableAdapter.Tb5(array);
					Pt6.AddRange(array);
				}
			}
			if (I != null)
			{
				DataRow[] array2 = j2W.Requested_Items.Select(null, null, DataViewRowState.Added);
				if (array2 != null && 0 < array2.Length)
				{
					num += I.Rp9(array2);
					Pt6.AddRange(array2);
				}
			}
			return num;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private int t7W(t8Y Sd1, List<DataRow> z2R)
	{
		int num = 0;
		checked
		{
			if (I != null)
			{
				DataRow[] array = Sd1.Requested_Items.Select(null, null, DataViewRowState.Deleted);
				if (array != null && 0 < array.Length)
				{
					num += I.Rp9(array);
					z2R.AddRange(array);
				}
			}
			if (_menuTableAdapter != null)
			{
				DataRow[] array2 = Sd1.Menu.Select(null, null, DataViewRowState.Deleted);
				if (array2 != null && 0 < array2.Length)
				{
					num += _menuTableAdapter.Tb5(array2);
					z2R.AddRange(array2);
				}
			}
			return num;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private DataRow[] r7C(DataRow[] s2E, List<DataRow> Ts6)
	{
		if (s2E == null || s2E.Length < 1)
		{
			return s2E;
		}
		if (Ts6 == null || Ts6.Count < 1)
		{
			return s2E;
		}
		List<DataRow> list = new List<DataRow>();
		foreach (DataRow item in s2E)
		{
			if (!Ts6.Contains(item))
			{
				list.Add(item);
			}
		}
		return list.ToArray();
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public virtual int p1Z(t8Y z8D)
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
		if (z8D == null)
		{
			throw new ArgumentNullException("dataSet");
		}
		if (!z8D.HasChanges())
		{
			return 0;
		}
		if (_menuTableAdapter != null && !r4Q((IDbConnection)_menuTableAdapter.Connection))
		{
			throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
		}
		if (I != null && !r4Q((IDbConnection)I.Connection))
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
			dataSet.Merge(z8D);
		}
		checked
		{
			try
			{
				if (_menuTableAdapter != null)
				{
					dictionary.Add(_menuTableAdapter, (IDbConnection)_menuTableAdapter.Connection);
					_menuTableAdapter.Connection = (OleDbConnection)connection;
					_menuTableAdapter.Transaction = (OleDbTransaction)dbTransaction;
					if (((DataAdapter)(object)_menuTableAdapter.Adapter).AcceptChangesDuringUpdate)
					{
						((DataAdapter)(object)_menuTableAdapter.Adapter).AcceptChangesDuringUpdate = false;
						list3.Add((DataAdapter)(object)_menuTableAdapter.Adapter);
					}
				}
				if (I != null)
				{
					dictionary.Add(I, (IDbConnection)I.Connection);
					I.Connection = (OleDbConnection)connection;
					I.Transaction = (OleDbTransaction)dbTransaction;
					if (((DataAdapter)(object)I.Adapter).AcceptChangesDuringUpdate)
					{
						((DataAdapter)(object)I.Adapter).AcceptChangesDuringUpdate = false;
						list3.Add((DataAdapter)(object)I.Adapter);
					}
				}
				if (UpdateOrder == Gm1.UpdateInsertDelete)
				{
					num += Gn5(z8D, list, list2);
					num += Af8(z8D, list2);
				}
				else
				{
					num += Af8(z8D, list2);
					num += Gn5(z8D, list, list2);
				}
				num += t7W(z8D, list);
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
					z8D.Clear();
					z8D.Merge(dataSet);
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
				if (_menuTableAdapter != null)
				{
					_menuTableAdapter.Connection = (OleDbConnection)dictionary[_menuTableAdapter];
					_menuTableAdapter.Transaction = null;
				}
				if (I != null)
				{
					I.Connection = (OleDbConnection)dictionary[I];
					I.Transaction = null;
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
	protected virtual void z2W(DataRow[] r7A, DataRelation Lo0, bool y2Y)
	{
		Array.Sort(r7A, new w0X(Lo0, y2Y));
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	protected virtual bool r4Q(IDbConnection d9C)
	{
		if (j != null)
		{
			return true;
		}
		if (Connection == null || d9C == null)
		{
			return true;
		}
		if (string.Equals(Connection.ConnectionString, d9C.ConnectionString, StringComparison.Ordinal))
		{
			return true;
		}
		return false;
	}
}
