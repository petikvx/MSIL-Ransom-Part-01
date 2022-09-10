using System;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal sealed class SecondaryIndexDefinition
{
	public const string GlobalIdIndex = "ix_globalid";

	public const string ObjectTypeIndex = "ix_objecttype";

	public const string NameIndex = "ix_name";

	public const string RecipientIdIndex = "ix_name";

	public const string ProductionServiceIndex = "ix_production_svc_uri";

	public const string ParentIdIndex = "ix_parentid";

	public const string MasterKeyIndex = "ix_masterkey";

	public const string SupportedClaimIndex = "ix_supportclaim";

	public const string SupportedAuthIndex = "ix_supportauth";

	private static readonly SecondaryIndexDefinition[] s_masterIndexes = new SecondaryIndexDefinition[8]
	{
		new SecondaryIndexDefinition("ix_globalid", 10, 20, SecondaryIndexSettings.Unique, Canonicalizers.Binary),
		new SecondaryIndexDefinition("ix_objecttype", 10, 20, SecondaryIndexSettings.None, Canonicalizers.Binary),
		new SecondaryIndexDefinition("ix_name", 10, 20, SecondaryIndexSettings.Nullable, Canonicalizers.CaseInsensitiveWithHashing),
		new SecondaryIndexDefinition("ix_production_svc_uri", 10, 20, SecondaryIndexSettings.Nullable, Canonicalizers.CaseInsensitiveWithHashing),
		new SecondaryIndexDefinition("ix_parentid", 10, 20, SecondaryIndexSettings.Nullable, Canonicalizers.Binary),
		new SecondaryIndexDefinition("ix_masterkey", 10, 20, SecondaryIndexSettings.Nullable | SecondaryIndexSettings.Unique, Canonicalizers.BinaryWithHashing),
		new SecondaryIndexDefinition("ix_supportclaim", 50, 20, SecondaryIndexSettings.Nullable, Canonicalizers.CaseSensitiveWithHashing),
		new SecondaryIndexDefinition("ix_supportauth", 10, 20, SecondaryIndexSettings.Nullable, Canonicalizers.Binary)
	};

	private int m_initialSize;

	private int m_growthFactor;

	private SecondaryIndexSettings m_settings;

	private string m_name;

	private ICanonicalizer m_canonicalizer;

	public static SecondaryIndexDefinition[] MasterIndexes => s_masterIndexes;

	public ICanonicalizer Canonicalizer => m_canonicalizer;

	public string Name => m_name;

	public int InitialSize => m_initialSize;

	public int GrowthFactor => m_growthFactor;

	public SecondaryIndexSettings Settings => m_settings;

	private SecondaryIndexDefinition(string name, int initialSize, int growthFactor, SecondaryIndexSettings settings, ICanonicalizer canonicalizer)
	{
		if (string.IsNullOrEmpty(name))
		{
			throw InfoCardTrace.ThrowHelperArgumentNull("name");
		}
		if (initialSize <= 0)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)new ArgumentOutOfRangeException("initialSize", initialSize, SR.GetString("StoreIndexInitialSizeInvalid")));
		}
		if (canonicalizer == null)
		{
			throw InfoCardTrace.ThrowHelperArgumentNull("canonicalizer");
		}
		if (growthFactor <= 0)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)new ArgumentOutOfRangeException("growthFactor", growthFactor, SR.GetString("StoreIndexGrowthFactorInvalid")));
		}
		m_initialSize = initialSize;
		m_growthFactor = growthFactor;
		m_settings = settings;
		m_name = name;
		m_canonicalizer = canonicalizer;
	}

	public static SecondaryIndexDefinition GetByName(string name)
	{
		int num = 0;
		while (true)
		{
			if (num < s_masterIndexes.Length)
			{
				if (s_masterIndexes[num].Name == name)
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		return s_masterIndexes[num];
	}
}
