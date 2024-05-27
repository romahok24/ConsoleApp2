namespace ConsoleApp2;

public static class Constants
{
    public static class SchemaNames
    {
        public const string APP_SETTING_DB_CONTEXT = "appsettings";
        public const string LOGGING_DB_CONTEXT = "logging";
        public const string SYSTEM_CONFIG_DB_CONTEXT = "systemconfig";
        public const string DATA = "data";
        public const string LOG = "logs";
    }

    public static class ColumnNames
    {
        public const string ID = "id";
        public const string NAME = "name";
        public const string DESCRIPTION = "description";
        public const string CODE = "code";
        public const string TABLE = "table_name";
        public const string CREATED_AT = "created_at";
        public const string VERSION = "version";
        public const string IS_DISPLAY = "is_display";
        public const string TYPE = "type";
        public const string PARENT_ID = "parent_id";
        public const string LOGIC_BLOCK_ID = "logic_block_id";
        public const string SYSTEM_OBJECT_ID = "system_object_id";
        internal static string? ORDER;
        internal static string? EVENT_ID;
        internal static string? LOGIC_BLOCK_CONFIGURATION_ID;
        internal static string? INPUT_TYPE;
        internal static string? POSGRES_TYPE;
        internal static string? DATA_TYPE_ID;
        internal static string? CHARACTERISTIC_ID;
        internal static string? LOGIC_BLOCK_ATTRIBUTE_TYPE_ID;
        internal static string? VALUE;
        internal static string? PROCEDURE_SIGNATURE;
        internal static string? PROCEDURE_SQL_CODE;
        internal static string? START_DATE_CHARACTERISTIC_ID;
        internal static string? END_DATE_CHARACTERISTIC_ID;
        internal static string? START_TIME_CHARACTERISTIC_ID;
        internal static string? END_TIME_CHARACTERISTIC_ID;
        internal static string? LOGIC_BLOCK_ATTRIBUTE_ID;
        internal static string? CHARACTERISTIC_CONFIGURATION_ID;
        internal static string? FLAG_CHARACTERISTIC_CONFIGURATION_ID;
        internal static string? CHARACTERISTIC_ATTRIBUTE_TYPE_ID;
        internal static string? FROM;
        internal static string? TO;
        internal static string? PRECISION;
        internal static string? SCALE;
    }

    public static class DtoDisplayNames
    {
        public const string ID = "Идентификатор";
        public const string CODE = "Код";
        public const string NAME = "Наименование";
        public const string TITLE = "Наименование";
        public const string DESCRIPTION = "Описание";
        public const string TABLE_NAME = "Наименование таблицы";
        public const string CREATED_AT = "Дата";
        public const string VERSION = "Версия";
        public const string IS_DISPLAY = "Показать";
    }

    public static class ConstantValues
    {
        public const int HOUR_IN_MINUTES = 60;
    }
}
