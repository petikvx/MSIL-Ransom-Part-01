using System;
using System.Collections;

namespace Sage.Peachtree.OnlineUpdate;

internal class UpdateProgramInfo : IComparable
{
	private class UpdateProgramInfoComparer : IComparer
	{
		public int Compare(object x, object y)
		{
			if (!(x is UpdateProgramInfo))
			{
				throw new ArgumentException("x parameter is not an UpdateProgramInfo object");
			}
			if (!(y is UpdateProgramInfo))
			{
				throw new ArgumentException("y parameter is not an UpdateProgramInfo object");
			}
			UpdateProgramInfo updateProgramInfo = (UpdateProgramInfo)x;
			UpdateProgramInfo obj = (UpdateProgramInfo)y;
			return updateProgramInfo.CompareTo(obj);
		}
	}

	private string m_Section;

	private string m_Version;

	private int m_Importance;

	private string m_ShortDescription;

	private string m_LongDescription;

	private string m_DescriptionURL;

	private string m_Dependency;

	private string m_URL;

	private bool m_RequiresDBConversion;

	private bool m_RequiresAdminRights;

	private bool m_IsTaxUpdate;

	private bool m_IsServerPatch;

	private static UpdateProgramInfoComparer updateProgramInfoComparer;

	public string Section => m_Section;

	public string Version => m_Version;

	public int Importance => m_Importance;

	public string ShortDescription => m_ShortDescription;

	public string LongDescription => m_LongDescription;

	public string DescriptionURL => m_DescriptionURL;

	public string Dependency => m_Dependency;

	public string URL => m_URL;

	public bool RequiresDBConversion => m_RequiresDBConversion;

	public bool RequiresAdminRights => m_RequiresAdminRights;

	public bool IsTaxUpdate => m_IsTaxUpdate;

	public bool IsServerPatch => m_IsServerPatch;

	public static IComparer UpdateProgramInfoCompare
	{
		get
		{
			if (updateProgramInfoComparer == null)
			{
				updateProgramInfoComparer = new UpdateProgramInfoComparer();
			}
			return updateProgramInfoComparer;
		}
	}

	public UpdateProgramInfo(string section, string version, int importance, string shortDescription, string longDescription, string descriptionURL, string dependency, string url, bool requiresDBConversion, bool requiresAdminRights, bool isTaxUpdate, bool isServerPatch)
	{
		m_Section = section;
		m_Version = version;
		m_Importance = importance;
		m_ShortDescription = shortDescription;
		m_LongDescription = longDescription;
		m_DescriptionURL = descriptionURL;
		m_Dependency = dependency;
		m_URL = url;
		m_RequiresDBConversion = requiresDBConversion;
		m_RequiresAdminRights = requiresAdminRights;
		m_IsTaxUpdate = isTaxUpdate;
		m_IsServerPatch = isServerPatch;
	}

	public int CompareTo(object obj)
	{
		if (obj is UpdateProgramInfo)
		{
			UpdateProgramInfo updateProgramInfo = (UpdateProgramInfo)obj;
			if (m_RequiresAdminRights != updateProgramInfo.m_RequiresAdminRights)
			{
				if (!m_RequiresAdminRights)
				{
					return -1;
				}
				return 1;
			}
			if (m_RequiresDBConversion != updateProgramInfo.m_RequiresDBConversion)
			{
				if (!m_RequiresDBConversion)
				{
					return -1;
				}
				return 1;
			}
			return m_ShortDescription.CompareTo(updateProgramInfo.m_ShortDescription);
		}
		throw new ArgumentException("object is not a UpdateProgramInfo");
	}
}
