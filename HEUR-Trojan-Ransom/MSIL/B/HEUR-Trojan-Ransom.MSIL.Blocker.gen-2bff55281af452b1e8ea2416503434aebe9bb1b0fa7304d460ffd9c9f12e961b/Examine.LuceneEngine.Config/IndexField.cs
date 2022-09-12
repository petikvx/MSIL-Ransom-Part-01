using System.Configuration;

namespace Examine.LuceneEngine.Config;

public sealed class IndexField : ConfigurationElement, IIndexField
{
	[ConfigurationProperty("Name", IsRequired = true)]
	public string Name
	{
		get
		{
			return (string)((ConfigurationElement)this).get_Item("Name");
		}
		set
		{
			((ConfigurationElement)this).set_Item("Name", (object)value);
		}
	}

	[ConfigurationProperty("EnableSorting", IsRequired = false)]
	public bool EnableSorting
	{
		get
		{
			return (bool)((ConfigurationElement)this).get_Item("EnableSorting");
		}
		set
		{
			((ConfigurationElement)this).set_Item("EnableSorting", (object)value);
		}
	}

	[ConfigurationProperty("Type", IsRequired = false, DefaultValue = "String")]
	public string Type
	{
		get
		{
			return (string)((ConfigurationElement)this).get_Item("Type");
		}
		set
		{
			((ConfigurationElement)this).set_Item("Type", (object)value);
		}
	}

	public bool Equals(IndexField other)
	{
		if ((object)other == null)
		{
			return false;
		}
		if ((object)this == other)
		{
			return true;
		}
		return string.Equals(Name, other.Name);
	}

	public override bool Equals(object obj)
	{
		if (obj == null)
		{
			return false;
		}
		if (this == obj)
		{
			return true;
		}
		if (obj.GetType() != ((object)this).GetType())
		{
			return false;
		}
		return Equals((IndexField)obj);
	}

	public override int GetHashCode()
	{
		return Name.GetHashCode();
	}

	public static bool operator ==(IndexField left, IndexField right)
	{
		return object.Equals(left, right);
	}

	public static bool operator !=(IndexField left, IndexField right)
	{
		return !object.Equals(left, right);
	}
}
