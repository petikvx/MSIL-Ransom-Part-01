using System.Configuration;
using System.IO;
using System.Web;
using System.Web.Hosting;

namespace Examine.LuceneEngine.Config;

public sealed class IndexSet : ConfigurationElement
{
	private string m_IndexPath = "";

	[ConfigurationProperty("SetName", IsRequired = true, IsKey = true)]
	public string SetName => (string)((ConfigurationElement)this).get_Item("SetName");

	[ConfigurationProperty("IndexPath", IsRequired = true, IsKey = false)]
	public string IndexPath
	{
		get
		{
			if (string.IsNullOrEmpty(m_IndexPath))
			{
				m_IndexPath = (string)((ConfigurationElement)this).get_Item("IndexPath");
			}
			return m_IndexPath;
		}
		set
		{
			m_IndexPath = value;
		}
	}

	public DirectoryInfo IndexDirectory
	{
		get
		{
			if (HttpContext.get_Current() != null)
			{
				return new DirectoryInfo(HttpContext.get_Current().get_Server().MapPath(IndexPath));
			}
			if (HostingEnvironment.get_ApplicationID() != null)
			{
				return new DirectoryInfo(HostingEnvironment.MapPath(IndexPath));
			}
			return new DirectoryInfo(IndexPath);
		}
	}

	[ConfigurationProperty("IndexParentId", IsRequired = false, IsKey = false)]
	public int? IndexParentId
	{
		get
		{
			if (((ConfigurationElement)this).get_Item("IndexParentId") == null)
			{
				return null;
			}
			return (int)((ConfigurationElement)this).get_Item("IndexParentId");
		}
	}

	[ConfigurationCollection(typeof(IndexFieldCollection))]
	[ConfigurationProperty("IncludeNodeTypes", IsDefaultCollection = false, IsRequired = false)]
	public IndexFieldCollection IncludeNodeTypes => (IndexFieldCollection)((ConfigurationElement)this).get_Item("IncludeNodeTypes");

	[ConfigurationCollection(typeof(IndexFieldCollection))]
	[ConfigurationProperty("ExcludeNodeTypes", IsDefaultCollection = false, IsRequired = false)]
	public IndexFieldCollection ExcludeNodeTypes => (IndexFieldCollection)((ConfigurationElement)this).get_Item("ExcludeNodeTypes");

	[ConfigurationCollection(typeof(IndexFieldCollection))]
	[ConfigurationProperty("IndexUserFields", IsDefaultCollection = false, IsRequired = false)]
	public IndexFieldCollection IndexUserFields => (IndexFieldCollection)((ConfigurationElement)this).get_Item("IndexUserFields");

	[ConfigurationCollection(typeof(IndexFieldCollection))]
	[ConfigurationProperty("IndexAttributeFields", IsDefaultCollection = false, IsRequired = false)]
	public IndexFieldCollection IndexAttributeFields => (IndexFieldCollection)((ConfigurationElement)this).get_Item("IndexAttributeFields");
}
