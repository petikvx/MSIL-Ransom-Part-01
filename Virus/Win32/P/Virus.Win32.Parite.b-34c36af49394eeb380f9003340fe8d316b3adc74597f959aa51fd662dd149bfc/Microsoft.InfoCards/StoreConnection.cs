using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Security.Principal;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class StoreConnection : IDisposable
{
	public const string DEFAULTFILENAME = "CardSpace.db";

	public const string STOREFILENAMEV2 = "CardSpaceSP2.db";

	public const string STORAGEPATH = "Microsoft\\CardSpace\\";

	private static Hashtable s_instanceCache = CollectionsUtil.CreateCaseInsensitiveHashtable();

	private string m_path;

	private int m_refCount;

	private Hashtable m_sources;

	private string m_instanceId;

	private string m_activeSource;

	private string m_localSource;

	private bool m_isLoaded;

	private WindowsIdentity m_identity;

	private bool m_disposed;

	private object m_sync;

	public Hashtable DataSources => m_sources;

	public string ActiveDataSource => m_activeSource;

	public string LocalDataSource => m_localSource;

	public string InstanceId => m_instanceId;

	public WindowsIdentity Identity => m_identity;

	protected int ReferenceCount
	{
		get
		{
			return m_refCount;
		}
		set
		{
			m_refCount = value;
		}
	}

	protected StoreConnection(WindowsIdentity identity)
	{
		m_identity = new WindowsIdentity(identity.Token);
		m_instanceId = m_identity.User!.Value;
		m_sync = new object();
		m_disposed = false;
		m_path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Microsoft\\CardSpace\\");
		m_localSource = m_path + "CardSpaceSP2.db";
		m_activeSource = m_localSource;
		m_sources = CollectionsUtil.CreateCaseInsensitiveHashtable();
	}

	public static StoreConnection CreateConnection()
	{
		WindowsIdentity current = WindowsIdentity.GetCurrent();
		InfoCardTrace.Assert(!current.IsSystem, "Identity should not be LSA", new object[0]);
		return GetConnection(current, allowCreate: true);
	}

	public static StoreConnection GetConnection()
	{
		WindowsIdentity current = WindowsIdentity.GetCurrent();
		InfoCardTrace.Assert(!current.IsSystem, "Identity should not be LSA", new object[0]);
		return GetConnection(current);
	}

	public static StoreConnection GetConnection(WindowsIdentity identity)
	{
		return GetConnection(identity, allowCreate: false);
	}

	private static StoreConnection GetConnection(WindowsIdentity identity, bool allowCreate)
	{
		StoreConnection storeConnection = null;
		lock (s_instanceCache.SyncRoot)
		{
			storeConnection = (StoreConnection)s_instanceCache[identity.User!.Value];
			if (storeConnection == null)
			{
				if (!allowCreate)
				{
					throw InfoCardTrace.ThrowHelperError((Exception)(object)new DataAccessException(SR.GetString("StoreFailedToOpenStore")));
				}
				storeConnection = new StoreConnection(identity);
				storeConnection.Load();
				s_instanceCache[identity.User!.Value] = storeConnection;
			}
			else if (!storeConnection.m_isLoaded)
			{
				storeConnection.Load();
			}
			storeConnection.ReferenceCount++;
			return storeConnection;
		}
	}

	public void SetActiveDataSource(string id)
	{
		ThrowIfNotLoaded();
		if (!m_sources.ContainsKey(id))
		{
			throw InfoCardTrace.ThrowHelperError((Exception)new ArgumentOutOfRangeException("id", id, SR.GetString("StoreSourceIdOutOfRange")));
		}
		if (((DataSource)m_sources[m_activeSource]).IsProcessingTransaction())
		{
			throw InfoCardTrace.ThrowHelperError((Exception)new InvalidOperationException(SR.GetString("StoreProcessingTransaction")));
		}
		m_activeSource = id;
	}

	public void Close()
	{
		ThrowIfNotLoaded();
		lock (s_instanceCache.SyncRoot)
		{
			ReferenceCount--;
			if (ReferenceCount != 0)
			{
				return;
			}
			s_instanceCache.Remove(m_identity.User!.Value);
			m_isLoaded = false;
			foreach (string key in m_sources.Keys)
			{
				((DataSource)m_sources[key]).Close();
			}
			m_sources.Clear();
		}
	}

	void IDisposable.Dispose()
	{
		lock (m_sync)
		{
			if (!m_disposed)
			{
				m_disposed = true;
				if (m_identity != null)
				{
					((IDisposable)m_identity).Dispose();
					m_identity = null;
				}
			}
		}
	}

	public bool IsDataSourceCleared(string sourceId)
	{
		if (!m_sources.ContainsKey(sourceId))
		{
			throw InfoCardTrace.ThrowHelperError((Exception)new ArgumentOutOfRangeException("sourceId", sourceId, SR.GetString("StoreSourceIdOutOfRange")));
		}
		DataSource dataSource = (DataSource)m_sources[sourceId];
		return dataSource.IsCleared;
	}

	public void ResetDataSourceClearedFlag(string sourceId)
	{
		if (!m_sources.ContainsKey(sourceId))
		{
			throw InfoCardTrace.ThrowHelperError((Exception)new ArgumentOutOfRangeException("sourceId", sourceId, SR.GetString("StoreSourceIdOutOfRange")));
		}
		DataSource dataSource = (DataSource)m_sources[sourceId];
		dataSource.IsCleared = false;
	}

	public DataRow GetSingleRow(QueryDetails details, params QueryParameter[] objectQuery)
	{
		return GetSingleRow(details, m_activeSource, objectQuery);
	}

	public DataRow GetSingleRow(params QueryParameter[] objectQuery)
	{
		return GetSingleRow(m_activeSource, objectQuery);
	}

	public DataRow GetSingleRow(string sourceId, params QueryParameter[] objectQuery)
	{
		return GetSingleRow(QueryDetails.FullRow, sourceId, objectQuery);
	}

	public DataRow GetSingleRow(QueryDetails details, string sourceId, params QueryParameter[] objectQuery)
	{
		ThrowIfNotLoaded();
		if (objectQuery != null && objectQuery.Length != 0)
		{
			if (!m_sources.ContainsKey(sourceId))
			{
				throw InfoCardTrace.ThrowHelperError((Exception)new ArgumentOutOfRangeException("sourceId", sourceId, SR.GetString("StoreSourceIdOutOfRange")));
			}
			DataSource dataSource = (DataSource)m_sources[sourceId];
			return dataSource.GetSingleRow(details, objectQuery);
		}
		throw InfoCardTrace.ThrowHelperArgumentNull("objectQuery");
	}

	public ICollection<DataRow> Query(QueryDetails details, params QueryParameter[] query)
	{
		return Query(details, m_activeSource, query);
	}

	public ICollection<DataRow> Query(params QueryParameter[] query)
	{
		return Query(m_activeSource, query);
	}

	public ICollection<DataRow> Query(string sourceId, params QueryParameter[] query)
	{
		return Query(QueryDetails.FullRow, sourceId, query);
	}

	public ICollection<DataRow> Query(QueryDetails details, string sourceId, params QueryParameter[] query)
	{
		ThrowIfNotLoaded();
		if (query != null && query.Length != 0)
		{
			if (!m_sources.ContainsKey(sourceId))
			{
				throw InfoCardTrace.ThrowHelperError((Exception)new ArgumentOutOfRangeException("sourceId", sourceId, SR.GetString("StoreSourceIdOutOfRange")));
			}
			DataSource dataSource = (DataSource)m_sources[sourceId];
			return dataSource.Query(details, query);
		}
		throw InfoCardTrace.ThrowHelperArgumentNull("query");
	}

	public void Save(string sourceId, DataRow row)
	{
		ThrowIfNotLoaded();
		if (row == null)
		{
			throw InfoCardTrace.ThrowHelperArgumentNull("row");
		}
		if (!m_sources.ContainsKey(sourceId))
		{
			throw InfoCardTrace.ThrowHelperError((Exception)new ArgumentOutOfRangeException("sourceId", sourceId, SR.GetString("StoreSourceIdOutOfRange")));
		}
		DataSource dataSource = (DataSource)m_sources[sourceId];
		dataSource.Save(row);
	}

	public void Save(DataRow row)
	{
		ThrowIfNotLoaded();
		if (row == null)
		{
			throw InfoCardTrace.ThrowHelperArgumentNull("row");
		}
		if (!string.IsNullOrEmpty(row.SourceId))
		{
			Save(row.SourceId, row);
		}
		else
		{
			Save(m_activeSource, row);
		}
	}

	public void Delete(string sourceId, DataRow row)
	{
		ThrowIfNotLoaded();
		if (row.InstanceId != m_instanceId)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)new InvalidOperationException(SR.GetString("StoreRowOwnedByOtherDataSource")));
		}
		if (!m_sources.ContainsKey(sourceId))
		{
			throw InfoCardTrace.ThrowHelperError((Exception)new ArgumentOutOfRangeException("sourceId", sourceId, SR.GetString("StoreSourceIdOutOfRange")));
		}
		DataSource dataSource = (DataSource)m_sources[sourceId];
		dataSource.Delete(row);
	}

	public void Delete(DataRow row)
	{
		Delete(row.SourceId, row);
	}

	public void BeginTransaction()
	{
		BeginTransaction(m_activeSource);
	}

	public void BeginTransaction(string sourceId)
	{
		if (!m_sources.ContainsKey(sourceId))
		{
			throw InfoCardTrace.ThrowHelperError((Exception)new ArgumentOutOfRangeException(" sourceId ", sourceId, SR.GetString("StoreSourceIdOutOfRange")));
		}
		DataSource dataSource = (DataSource)m_sources[sourceId];
		dataSource.BeginTransaction();
	}

	public void CommitTransaction()
	{
		CommitTransaction(m_activeSource);
	}

	public void CommitTransaction(string sourceId)
	{
		if (!m_sources.ContainsKey(sourceId))
		{
			throw InfoCardTrace.ThrowHelperError((Exception)new ArgumentOutOfRangeException(" sourceId ", sourceId, SR.GetString("StoreSourceIdOutOfRange")));
		}
		DataSource dataSource = (DataSource)m_sources[sourceId];
		dataSource.CommitTransaction();
	}

	public void RollbackTransaction()
	{
		RollbackTransaction(m_activeSource);
	}

	public void RollbackTransaction(string sourceId)
	{
		if (!m_sources.ContainsKey(sourceId))
		{
			throw InfoCardTrace.ThrowHelperError((Exception)new ArgumentOutOfRangeException(" sourceId ", sourceId, SR.GetString("StoreSourceIdOutOfRange")));
		}
		DataSource dataSource = (DataSource)m_sources[sourceId];
		dataSource.RollbackTransaction();
	}

	protected virtual void CreateDefaultDataSources(Hashtable list)
	{
		string text = m_path + "CardSpace.db";
		using (new SystemIdentity(throwIfAlreadySystem: true))
		{
			if (File.Exists(m_localSource))
			{
				if (File.Exists(text) && DateTime.Compare(File.GetLastWriteTime(text), File.GetLastWriteTime(m_localSource)) > 0)
				{
					File.Delete(m_localSource);
					if (File.Exists(m_localSource + ".shadow"))
					{
						File.Delete(m_localSource + ".shadow");
					}
					AtomicFileCopy(text, m_localSource);
				}
			}
			else if (!File.Exists(m_localSource) && File.Exists(m_localSource + ".shadow"))
			{
				FileInfo fileInfo = new FileInfo(m_localSource + ".shadow");
				if (0L == fileInfo.Length)
				{
					fileInfo.Delete();
				}
			}
			else if (File.Exists(text))
			{
				AtomicFileCopy(text, m_localSource);
			}
			else if (File.Exists(text + ".shadow"))
			{
				FileInfo fileInfo2 = new FileInfo(text + ".shadow");
				if (0L == fileInfo2.Length)
				{
					fileInfo2.Delete();
				}
				else
				{
					AtomicFileCopy(text + ".shadow", m_localSource);
				}
			}
		}
		list.Add(m_localSource, new FileDataSource(m_identity, m_localSource, m_instanceId, SecondaryIndexDefinition.MasterIndexes));
	}

	protected void AtomicFileCopy(string source, string destination)
	{
		if (File.Exists(source))
		{
			File.Copy(source, source + ".atomic", overwrite: true);
			FileInfo fileInfo = new FileInfo(source + ".atomic");
			if (fileInfo.Length != 0L)
			{
				fileInfo.MoveTo(destination);
			}
		}
	}

	protected void Load()
	{
		InfoCardTrace.Assert(!m_isLoaded, "Store is already loaded", new object[0]);
		CreateDefaultDataSources(m_sources);
		foreach (string key in m_sources.Keys)
		{
			if (!((DataSource)m_sources[key]).IsLoaded)
			{
				bool flag = false;
				try
				{
					((DataSource)m_sources[key]).Load();
					flag = true;
				}
				catch (CorruptStoreException)
				{
					((DataSource)m_sources[key]).Clear();
				}
				catch (InvalidStoreProtectionKeyException)
				{
					((DataSource)m_sources[key]).Clear();
				}
				if (!flag)
				{
					((DataSource)m_sources[key]).Load();
				}
			}
		}
		m_isLoaded = true;
	}

	protected void ThrowIfNotLoaded()
	{
		InfoCardTrace.Assert(m_isLoaded, "store is not loaded", new object[0]);
	}
}
