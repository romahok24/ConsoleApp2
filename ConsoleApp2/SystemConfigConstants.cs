namespace ConsoleApp2;

public static class SystemConfigConstants
{
    public static class SystemConfigTableNames
    {
        public const string SYSTEM_OBJECT = "system.objects";
        public const string SYSTEM_OBJECT_TYPE = "system.object.types";
        public const string OBJECT_PROCEDURE = "object.procedures";
        public const string LOGIC_BLOCK = "logic.blocks";
        public const string LOGIC_BLOCK_CONFIGURATION = "logic.block.configurations";
        public const string CHARACTERISTIC = "characteristics";
        public const string CHARACTERISTIC_CONFIGURATION = "characteristic.configurations";
        public const string DATA_TYPE = "data.types";
        public const string RELATION_TYPE = "relation.types";
        public const string OBJECT_RELATION = "object.relations";
        public const string SYSTEM_MESSAGE = "system.messages";
        public const string NEWS = "news";
        public const string VALIDATIONS = "validations";
        public const string CHARACTERISTIC_CONFIGURATION_VALIDATIONS = "characteristic.configuration.validations";
        public const string EVENT = "event";
        internal static string LOGIC_BLOCK_CONFIGURATION_EVENT;
        internal static string LOGIC_BLOCK_ATTRIBUTE_TYPE;
        internal static string CHARACTERISTIC_ATTRIBUTE_TYPE;
        internal static string LOGIC_BLOCK_ATTRIBUTE;
        internal static string BOOLEAN_LOGIC_BLOCK_ATTRIBUTE;
        internal static string DATE_RANGE_LOGIC_BLOCK_ATTRIBUTE;
        internal static string TIME_RANGE_LOGIC_BLOCK_ATTRIBUTE;
        internal static string STRING_LOGIC_BLOCK_ATTRIBUTE;
        internal static string CHARACTERISTIC_ATTRIBUTE;
        internal static string CHARACTERISTIC_ATTRIBUTE_BOOLEAN;
        internal static string CHARACTERISTIC_ATTRIBUTE_INT;
        internal static string CHARACTERISTIC_ATTRIBUTE_KEY_RANGE;
        internal static string CHARACTERISTIC_ATTRIBUTE_NUMERIC_RANGE;
        public const string CUSTOM_LOGIC_BLOCK_ATTRIBUTE = "";

        public static string LOGIC_BLOCK_ATTRIBUTE_CHARACTERISTIC_CONFIGURATION { get; internal set; }
        public static string IF_TRUE_THEN_EMPTY_LOGIC_BLOCK_ATTRIBUTE { get; internal set; }
    }

    public static class SystemConfigColumnNames
    {
        public const string CHARACTERISTIC_ID = "characteristic_id";
        public const string LOGIC_BLOCK_ID = "logic_block_id";
        public const string LOGIC_BLOCK_CONFIGURATION_ID = "logic_block_configuration_id";
        public const string RELATION_TYPE_ID = "relation_type_id";
        public const string OBJECT_RELATION_ID = "object_relation_id";
        public const string SOURCE_OBJECT_ID = "source_object_id";
        public const string TARGET_OBJECT_ID = "target_object_id";
        public const string TARGET_CHARACTERISTIC_CONFIGURATION_ID = "target_characteristic_configuration_id";
        public const string DATA_TYPE_ID = "data_type_id";
        public const string SYSTEM_OBJECT_ID = "system_object_id";
        public const string SYSTEM_OBJECT_TYPE_ID = "system_object_type_id";

        public const string LOGIC_BLOCK_POSITION = "logic_block_position";
        public const string CHARACTERISTIC_POSITION = "characteristic_position";
        public const string DEFAULT_VALUE = "default_value";
        public const string INFO = "info";
        public const string IS_REQUIRED = "is_required";
        public const string IS_DISPLAYED = "is_displayed";
        public const string POSTGRESQL_TYPE = "postgresql_type";
        public const string INPUT_TYPE = "input_type";

        public const string USER_ROLE_ID = "user_role_id";
        public const string ROLE_ID = "role_id";
        public const string OBJECT_CONFIGURATION_TYPE_ID = "object_configuration_type_id";
        public const string ACCESS_TYPE_ID = "access_type_id";

        public const string TYPE = "type";
        public const string VALIDATION_ID = "validation_id";
        public const string CHARACTERISTIC_CONFIGURATION_ID = "characteristic_configuration_id";
        public const string VALUE = "value";
    }

    public static class SystemConfigConstraints
    {
        public const int CODE_MAX_LENGTH = 5;
        public const int VERSION_MAX_LENGTH = 10;
        public const int NAME_MAX_LENGTH = 50;
        public const int PROCEDURE_NAME_MAX_LENGTH = 250;
        public const int DESCRIPTION_MAX_LENGTH = 500;
        public const int TABLE_NAME_MAX_LENGTH = 50;
        public const int DATA_TYPE_MAX_LENGTH = 50;
        public const int DEFAULT_VALUE_MAX_LENGTH = 250;
        internal static int INPUT_TYPE_MAX_LENGTH;
        internal static int POSGRES_TYPE_MAX_LENGTH;
    }

    public static class SystemConfigDbFunctionNames
    {
    }

    public static class SystemConfigDtoDisplayNames
    {
        public const string DATA_TYPE = "Тип данных";
        public const string LOGIC_BLOCK_POSITION = "Порядковый номер блока";
        public const string CHARACTERISTIC_POSITION = "Порядковый номер характеристики";
        public const string INFO = "Информационное поле";
        public const string DEFAULT_VALUE = "Значение по умолчанию";
        public const string IS_REQUIRED = "Обязательное поле";
        public const string OBJECT_TYPE = "Тип объекта";
        public const string OBJECT = "Объект";
        public const string SOURCE_OBJECT = "Исходный объект";
        public const string TARGET_OBJECT = "Целевой объект";
        public const string LOGIC_BLOCK = "Логический блок";
        public const string CHARACTERISTIC = "Характеристика";
        public const string CHARACTERISTIC_CONFIGURATION = "Целевая характеристика";
        public const string IS_DISPLAYED = "Отображаемое в UI таблице";
        public const string RELATION_TYPE = "Тип связи";
        public const string LOGIC_BLOCK_CONFIGURATION = "Конфигурация логического блока";
        public const string OBJECT_RELATION = "Отношение объекта";
        public const string POSTGRE_SQL_TYPE = "Тип данных бд";
        public const string INPUT_TYPE = "Тип данных input";
    }
}
