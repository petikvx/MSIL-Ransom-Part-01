namespace MySqlX.Protocol.X;

internal static class XpluginStatementCommand
{
	public static readonly string XPLUGIN_STMT_CREATE_COLLECTION = "create_collection";

	public static readonly string XPLUGIN_STMT_CREATE_COLLECTION_INDEX = "create_collection_index";

	public static readonly string XPLUGIN_STMT_DROP_COLLECTION = "drop_collection";

	public static readonly string XPLUGIN_STMT_DROP_COLLECTION_INDEX = "drop_collection_index";

	public static readonly string XPLUGIN_STMT_PING = "ping";

	public static readonly string XPLUGIN_STMT_LIST_OBJECTS = "list_objects";

	public static readonly string XPLUGIN_STMT_ENABLE_NOTICES = "enable_notices";

	public static readonly string XPLUGIN_STMT_DISABLE_NOTICES = "disable_notices";

	public static readonly string XPLUGIN_STMT_LIST_NOTICES = "list_notices";
}
