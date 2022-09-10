using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal abstract class DataSource : IDisposable
{
	private string m_instanceId;

	private bool m_isLoaded;

	private ReaderWriterLock m_lock;

	private bool m_isDisposed;

	private string m_sourceId;

	private bool m_isCleared;

	public string SourceId
	{
		get
		{
			ThrowIfDisposed();
			return m_sourceId;
		}
	}

	public bool IsDisposed => m_isDisposed;

	public bool IsLoaded
	{
		get
		{
			ThrowIfDisposed();
			return m_isLoaded;
		}
	}

	public bool IsCleared
	{
		get
		{
			return m_isCleared;
		}
		set
		{
			m_isCleared = value;
		}
	}

	protected internal string InstanceId
	{
		get
		{
			ThrowIfDisposed();
			return m_instanceId;
		}
		set
		{
			ThrowIfDisposed();
			m_instanceId = value;
		}
	}

	protected DataSource(string instanceId, string sourceId)
	{
		m_instanceId = instanceId;
		m_sourceId = sourceId;
		m_lock = new ReaderWriterLock();
	}

	public bool IsProcessingTransaction()
	{
		ThrowIfDisposed();
		ThrowIfNotLoaded();
		return m_lock.IsWriterLockHeld;
	}

	public void BeginTransaction()
	{
		ThrowIfWriteLockHeld();
		ThrowIfDisposed();
		ThrowIfNotLoaded();
		m_lock.AcquireWriterLock(0);
		OnBeginTransaction();
	}

	public void CommitTransaction()
	{
		ThrowIfDisposed();
		ThrowIfNotLoaded();
		ThrowIfWriteLockNotHeld();
		OnCommitTransaction();
		m_lock.ReleaseWriterLock();
	}

	public void RollbackTransaction()
	{
		ThrowIfDisposed();
		ThrowIfNotLoaded();
		ThrowIfWriteLockNotHeld();
		OnRollbackTransaction();
		m_lock.ReleaseWriterLock();
	}

	public void Load()
	{
		ThrowIfDisposed();
		OnLoad();
		m_isLoaded = true;
	}

	public void Clear()
	{
		ThrowIfLoaded();
		ThrowIfDisposed();
		OnClear();
		m_isLoaded = false;
		m_isCleared = true;
	}

	public void Close()
	{
		if (m_isLoaded)
		{
			OnClose();
			m_isLoaded = false;
		}
	}

	public DataRow GetSingleRow(params QueryParameter[] objectQuery)
	{
		return GetSingleRow(QueryDetails.FullRow, objectQuery);
	}

	public DataRow GetSingleRow(QueryDetails details, params QueryParameter[] objectQuery)
	{
		IList<DataRow> list = Query(details, objectQuery);
		if (list != null && list.Count != 0)
		{
			if (list.Count > 1)
			{
				throw InfoCardTrace.ThrowHelperError((Exception)new InvalidOperationException(SR.GetString("StoreMoreThanOneRowReturnedInSingleMatchQuery")));
			}
			return list[0];
		}
		return null;
	}

	public IList<DataRow> Query(params QueryParameter[] objectQuery)
	{
		return Query(QueryDetails.FullRow, objectQuery);
	}

	public IList<DataRow> Query(QueryDetails details, params QueryParameter[] objectQuery)
	{
		ThrowIfDisposed();
		ThrowIfNotLoaded();
		if (objectQuery != null && objectQuery.Length != 0)
		{
			if (!IsValidQueryDetails(details))
			{
				throw InfoCardTrace.ThrowHelperError((Exception)new ArgumentException("details"));
			}
			if (details == QueryDetails.None)
			{
				return null;
			}
			List<DataRow> list = null;
			LocalIdCollection localIdCollection = null;
			LocalIdCollection localIdCollection2 = null;
			bool flag = false;
			try
			{
				try
				{
				}
				finally
				{
					m_lock.AcquireReaderLock(0);
					flag = true;
				}
				foreach (QueryParameter queryParameter in objectQuery)
				{
					localIdCollection2 = new LocalIdCollection();
					if ("localid" == queryParameter.IndexName.ToLower(CultureInfo.InvariantCulture))
					{
						for (int j = 0; j < queryParameter.Count; j++)
						{
							for (int k = 0; k < queryParameter[j].ObjectList.Length; k++)
							{
								int item = Convert.ToInt32(queryParameter[j].ObjectList[k], NumberFormatInfo.InvariantInfo);
								localIdCollection2.Add(item);
							}
						}
					}
					else if (!SingleMatch(queryParameter, localIdCollection2))
					{
						localIdCollection?.Clear();
						break;
					}
					if (localIdCollection == null)
					{
						localIdCollection = localIdCollection2;
					}
					else
					{
						localIdCollection.Filter(localIdCollection2);
					}
				}
			}
			finally
			{
				if (flag)
				{
					m_lock.ReleaseReaderLock();
				}
			}
			if (localIdCollection != null && localIdCollection.Count != 0)
			{
				list = new List<DataRow>(localIdCollection.Count);
				{
					foreach (int key in localIdCollection.Keys)
					{
						if (QueryDetails.Identifiers == details)
						{
							DataRow dataRow = new DataRow();
							dataRow.LocalId = key;
							dataRow.SourceId = SourceId;
							dataRow.InstanceId = InstanceId;
							list.Add(dataRow);
						}
						else
						{
							list.Add(ReadRow(key, details));
						}
					}
					return list;
				}
			}
			return null;
		}
		throw InfoCardTrace.ThrowHelperArgumentNull("query");
	}

	public void Save(DataRow row)
	{
		ThrowIfDisposed();
		ThrowIfNotLoaded();
		ThrowIfWriteLockNotHeld();
		if (row == null)
		{
			throw InfoCardTrace.ThrowHelperArgumentNull("row");
		}
		if ((!string.IsNullOrEmpty(row.InstanceId) || !string.IsNullOrEmpty(row.SourceId)) && (string.Compare(row.InstanceId, InstanceId, StringComparison.Ordinal) != 0 || string.Compare(row.SourceId, SourceId, StringComparison.Ordinal) != 0))
		{
			throw InfoCardTrace.ThrowHelperError((Exception)new InvalidOperationException(SR.GetString("StoreRowOwnedByOtherDataSource")));
		}
		row.LastChange = DateTime.Now.ToFileTimeUtc();
		WriteRow(row);
		row.InstanceId = InstanceId;
		row.SourceId = SourceId;
	}

	public void Delete(DataRow row)
	{
		ThrowIfDisposed();
		ThrowIfNotLoaded();
		ThrowIfWriteLockNotHeld();
		if (row == null)
		{
			throw InfoCardTrace.ThrowHelperArgumentNull("row");
		}
		if (row.InstanceId != null && row.SourceId != null)
		{
			if (string.Compare(row.InstanceId, InstanceId, StringComparison.Ordinal) != 0 || string.Compare(row.SourceId, SourceId, StringComparison.Ordinal) != 0)
			{
				throw InfoCardTrace.ThrowHelperError((Exception)new InvalidOperationException(SR.GetString("StoreRowOwnedByOtherDataSource")));
			}
			RemoveObject(row.LocalId);
			return;
		}
		throw InfoCardTrace.ThrowHelperError((Exception)new InvalidOperationException(SR.GetString("StoreDataSourceRowNotOwned")));
	}

	protected internal virtual bool IsValidQueryDetails(QueryDetails details)
	{
		if (QueryDetails.IndexData == (details & QueryDetails.IndexData))
		{
			return QueryDetails.FullRowAndIndexes == (details & QueryDetails.FullRowAndIndexes);
		}
		if (QueryDetails.DataBlob == (details & QueryDetails.DataBlob))
		{
			return QueryDetails.FullRow == (details & QueryDetails.FullRow);
		}
		if (QueryDetails.Header == (details & QueryDetails.Header))
		{
			return QueryDetails.FullHeader == (details & QueryDetails.FullHeader);
		}
		if (QueryDetails.Identifiers == (details & QueryDetails.Identifiers))
		{
			return QueryDetails.Identifiers == (details & QueryDetails.Identifiers);
		}
		return QueryDetails.None == details;
	}

	protected internal virtual void OnBeginTransaction()
	{
		ThrowIfDisposed();
	}

	protected internal virtual void OnCommitTransaction()
	{
		ThrowIfDisposed();
	}

	protected internal virtual void OnRollbackTransaction()
	{
		ThrowIfDisposed();
	}

	protected internal virtual void OnLoad()
	{
		ThrowIfDisposed();
	}

	protected internal virtual void OnClose()
	{
		ThrowIfDisposed();
	}

	protected internal virtual void OnClear()
	{
		ThrowIfDisposed();
	}

	protected internal virtual void OnDispose()
	{
	}

	protected internal abstract void WriteRow(DataRow row);

	protected internal abstract void RemoveObject(int id);

	protected internal abstract DataRow ReadRow(int localId, QueryDetails details);

	protected internal abstract bool SingleMatch(QueryParameter match, LocalIdCollection localIds);

	void IDisposable.Dispose()
	{
		OnDispose();
		m_isDisposed = true;
	}

	protected internal void ThrowIfWriteLockNotHeld()
	{
		if (!m_lock.IsWriterLockHeld)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)new InvalidOperationException(SR.GetString("StoreDataSourceWriteLockNotHeld")));
		}
	}

	protected internal void ThrowIfWriteLockHeld()
	{
		if (m_lock.IsWriterLockHeld)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)new InvalidOperationException(SR.GetString("StoreProcessingTransaction")));
		}
	}

	protected internal void ThrowIfNotLoaded()
	{
		if (!m_isLoaded)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)new ObjectDisposedException("DataSource"));
		}
	}

	protected internal void ThrowIfLoaded()
	{
		if (m_isLoaded)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)new InvalidOperationException(SR.GetString("StoreIsAlreadyLoaded")));
		}
	}

	protected internal void ThrowIfDisposed()
	{
		if (m_isDisposed)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)new ObjectDisposedException("DataSource"));
		}
	}

	public static QueryParameter CreateDeleteStoreTypeQuery()
	{
		QueryParameter queryParameter = new QueryParameter("ix_objecttype");
		Array values = Enum.GetValues(typeof(StorableObjectType));
		foreach (int item in values)
		{
			if (item != 0)
			{
				queryParameter.AddMatch(item);
			}
		}
		return queryParameter;
	}
}
