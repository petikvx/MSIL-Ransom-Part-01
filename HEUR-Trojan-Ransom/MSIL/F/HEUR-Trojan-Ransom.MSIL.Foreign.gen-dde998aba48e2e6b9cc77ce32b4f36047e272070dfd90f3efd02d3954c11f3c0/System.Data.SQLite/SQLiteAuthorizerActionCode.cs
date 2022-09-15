namespace System.Data.SQLite;

public enum SQLiteAuthorizerActionCode
{
	None = -1,
	Copy,
	CreateIndex,
	CreateTable,
	CreateTempIndex,
	CreateTempTable,
	CreateTempTrigger,
	CreateTempView,
	CreateTrigger,
	CreateView,
	Delete,
	DropIndex,
	DropTable,
	DropTempIndex,
	DropTempTable,
	DropTempTrigger,
	DropTempView,
	DropTrigger,
	DropView,
	Insert,
	Pragma,
	Read,
	Select,
	Transaction,
	Update,
	Attach,
	Detach,
	AlterTable,
	Reindex,
	Analyze,
	CreateVtable,
	DropVtable,
	Function,
	Savepoint,
	Recursive
}