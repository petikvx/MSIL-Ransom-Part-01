using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal static class AuditLog
{
	public static void AuditCardWritten()
	{
		InfoCardTrace.Audit((EventCode)1074070016);
	}

	public static void AuditCardDeletion()
	{
		InfoCardTrace.Audit((EventCode)1074070017);
	}

	public static void AuditCardImport()
	{
		InfoCardTrace.Audit((EventCode)1074070018);
	}

	public static void AuditStoreImport()
	{
		InfoCardTrace.Audit((EventCode)1074070019);
	}

	public static void AuditStoreExport()
	{
		InfoCardTrace.Audit((EventCode)1074070020);
	}

	public static void AuditStoreDeletion()
	{
		InfoCardTrace.Audit((EventCode)1074070021);
	}
}
