// <auto-generated />

using System.Resources;
using Microsoft.EntityFrameworkCore.Internal;
using Npgsql.EntityFrameworkCore.PostgreSQL.Diagnostics.Internal;

#nullable enable

namespace Npgsql.EntityFrameworkCore.PostgreSQL.Internal
{
    /// <summary>
    ///     This is an internal API that supports the Entity Framework Core infrastructure and not subject to
    ///     the same compatibility standards as public APIs. It may be changed or removed without notice in
    ///     any release. You should only use it directly in your code with extreme caution and knowing that
    ///     doing so can result in application failures when updating to a new Entity Framework Core release.
    /// </summary>
    public static class NpgsqlStrings
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("Npgsql.EntityFrameworkCore.PostgreSQL.Properties.NpgsqlStrings", typeof(NpgsqlStrings).Assembly);

        /// <summary>
        ///     '{entityType1}.{property1}' and '{entityType2}.{property2}' are both mapped to column '{columnName}' in '{table}', but are configured with different compression methods.
        /// </summary>
        public static string DuplicateColumnCompressionMethodMismatch(object? entityType1, object? property1, object? entityType2, object? property2, object? columnName, object? table)
            => string.Format(
                GetString("DuplicateColumnCompressionMethodMismatch", nameof(entityType1), nameof(property1), nameof(entityType2), nameof(property2), nameof(columnName), nameof(table)),
                entityType1, property1, entityType2, property2, columnName, table);

        /// <summary>
        ///     '{entityType1}.{property1}' and '{entityType2}.{property2}' are both mapped to column '{columnName}' in '{table}' but are configured with different value generation strategies.
        /// </summary>
        public static string DuplicateColumnNameValueGenerationStrategyMismatch(object? entityType1, object? property1, object? entityType2, object? property2, object? columnName, object? table)
            => string.Format(
                GetString("DuplicateColumnNameValueGenerationStrategyMismatch", nameof(entityType1), nameof(property1), nameof(entityType2), nameof(property2), nameof(columnName), nameof(table)),
                entityType1, property1, entityType2, property2, columnName, table);

        /// <summary>
        ///     The indexes {index1} on '{entityType1}' and {index2} on '{entityType2}' are both mapped to '{table}.{indexName}', but have different collation configurations.
        /// </summary>
        public static string DuplicateIndexCollationMismatch(object? index1, object? entityType1, object? index2, object? entityType2, object? table, object? indexName)
            => string.Format(
                GetString("DuplicateIndexCollationMismatch", nameof(index1), nameof(entityType1), nameof(index2), nameof(entityType2), nameof(table), nameof(indexName)),
                index1, entityType1, index2, entityType2, table, indexName);

        /// <summary>
        ///     The indexes {index1} on '{entityType1}' and {index2} on '{entityType2}' are both mapped to '{table}.{indexName}', but have different concurrent creation configurations.
        /// </summary>
        public static string DuplicateIndexConcurrentCreationMismatch(object? index1, object? entityType1, object? index2, object? entityType2, object? table, object? indexName)
            => string.Format(
                GetString("DuplicateIndexConcurrentCreationMismatch", nameof(index1), nameof(entityType1), nameof(index2), nameof(entityType2), nameof(table), nameof(indexName)),
                index1, entityType1, index2, entityType2, table, indexName);

        /// <summary>
        ///     The indexes {index1} on '{entityType1}' and {index2} on '{entityType2}' are both mapped to '{table}.{indexName}', but have different included columns: {includedColumns1} and {includedColumns2}.
        /// </summary>
        public static string DuplicateIndexIncludedMismatch(object? index1, object? entityType1, object? index2, object? entityType2, object? table, object? indexName, object? includedColumns1, object? includedColumns2)
            => string.Format(
                GetString("DuplicateIndexIncludedMismatch", nameof(index1), nameof(entityType1), nameof(index2), nameof(entityType2), nameof(table), nameof(indexName), nameof(includedColumns1), nameof(includedColumns2)),
                index1, entityType1, index2, entityType2, table, indexName, includedColumns1, includedColumns2);

        /// <summary>
        ///     The 'FreeText' method is not supported because the query has switched to client-evaluation. Inspect the log to determine which query expressions are triggering client-evaluation.
        /// </summary>
        public static string FreeTextFunctionOnClient
            => GetString("FreeTextFunctionOnClient");

        /// <summary>
        ///     Include property '{entityType}.{property}' cannot be defined multiple times
        /// </summary>
        public static string IncludePropertyDuplicated(object? entityType, object? property)
            => string.Format(
                GetString("IncludePropertyDuplicated", nameof(entityType), nameof(property)),
                entityType, property);

        /// <summary>
        ///     Include property '{entityType}.{property}' is already included in the index
        /// </summary>
        public static string IncludePropertyInIndex(object? entityType, object? property)
            => string.Format(
                GetString("IncludePropertyInIndex", nameof(entityType), nameof(property)),
                entityType, property);

        /// <summary>
        ///     Include property '{entityType}.{property}' not found
        /// </summary>
        public static string IncludePropertyNotFound(object? entityType, object? property)
            => string.Format(
                GetString("IncludePropertyNotFound", nameof(entityType), nameof(property)),
                entityType, property);

        /// <summary>
        ///     The specified table '{table}' is not valid. Specify tables using the format '[schema].[table]'.
        /// </summary>
        public static string InvalidTableToIncludeInScaffolding(object? table)
            => string.Format(
                GetString("InvalidTableToIncludeInScaffolding", nameof(table)),
                table);

        /// <summary>
        ///     The property '{property}' on entity type '{entityType}' is configured to use 'SequenceHiLo' value generator, which is only intended for keys. If this was intentional configure an alternate key on the property, otherwise call 'ValueGeneratedNever' or configure store generation for this property.
        /// </summary>
        public static string NonKeyValueGeneration(object? property, object? entityType)
            => string.Format(
                GetString("NonKeyValueGeneration", nameof(property), nameof(entityType)),
                property, entityType);

        /// <summary>
        ///     PostgreSQL sequences cannot be used to generate values for the property '{property}' on entity type '{entityType}' because the property type is '{propertyType}'. Sequences can only be used with integer properties.
        /// </summary>
        public static string SequenceBadType(object? property, object? entityType, object? propertyType)
            => string.Format(
                GetString("SequenceBadType", nameof(property), nameof(entityType), nameof(propertyType)),
                property, entityType, propertyType);

        /// <summary>
        ///     An exception has been raised that is likely due to a transient failure. Consider enabling transient error resiliency by adding 'EnableRetryOnFailure()' to the 'UseSqlServer' call.
        /// </summary>
        public static string TransientExceptionDetected
            => GetString("TransientExceptionDetected");

        private static string GetString(string name, params string[] formatterNames)
        {
            var value = _resourceManager.GetString(name)!;
            for (var i = 0; i < formatterNames.Length; i++)
            {
                value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
            }

            return value;
        }
    }
}

namespace Npgsql.EntityFrameworkCore.PostgreSQL.Internal
{
    /// <summary>
    ///     This is an internal API that supports the Entity Framework Core infrastructure and not subject to
    ///     the same compatibility standards as public APIs. It may be changed or removed without notice in
    ///     any release. You should only use it directly in your code with extreme caution and knowing that
    ///     doing so can result in application failures when updating to a new Entity Framework Core release.
    /// </summary>
    public static class NpgsqlResources
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("Npgsql.EntityFrameworkCore.PostgreSQL.Properties.NpgsqlStrings", typeof(NpgsqlResources).Assembly);

        /// <summary>
        ///     Enum column '{name}' cannot be scaffolded, define a CLR enum type and add the property manually.
        /// </summary>
        public static EventDefinition<string> LogEnumColumnSkipped(IDiagnosticsLogger logger)
        {
            var definition = ((NpgsqlLoggingDefinitions)logger.Definitions).LogEnumColumnSkipped;
            if (definition is null)
            {
                definition = NonCapturingLazyInitializer.EnsureInitialized(
                    ref ((NpgsqlLoggingDefinitions)logger.Definitions).LogEnumColumnSkipped,
                    logger,
                    static logger => new EventDefinition<string>(
                        logger.Options,
                        NpgsqlEventId.EnumColumnSkippedWarning,
                        LogLevel.Warning,
                        "NpgsqlEventId.EnumColumnSkippedWarning",
                        level => LoggerMessage.Define<string>(
                            level,
                            NpgsqlEventId.EnumColumnSkippedWarning,
                            _resourceManager.GetString("LogEnumColumnSkipped")!)));
            }

            return (EventDefinition<string>)definition;
        }

        /// <summary>
        ///     Expression index '{name}' on table {tableName} cannot be scaffolded, expression indices aren't supported and must be added via raw SQL in migrations.
        /// </summary>
        public static EventDefinition<string, string> LogExpressionIndexSkipped(IDiagnosticsLogger logger)
        {
            var definition = ((NpgsqlLoggingDefinitions)logger.Definitions).LogExpressionIndexSkipped;
            if (definition is null)
            {
                definition = NonCapturingLazyInitializer.EnsureInitialized(
                    ref ((NpgsqlLoggingDefinitions)logger.Definitions).LogExpressionIndexSkipped,
                    logger,
                    static logger => new EventDefinition<string, string>(
                        logger.Options,
                        NpgsqlEventId.ExpressionIndexSkippedWarning,
                        LogLevel.Warning,
                        "NpgsqlEventId.ExpressionIndexSkippedWarning",
                        level => LoggerMessage.Define<string, string>(
                            level,
                            NpgsqlEventId.ExpressionIndexSkippedWarning,
                            _resourceManager.GetString("LogExpressionIndexSkipped")!)));
            }

            return (EventDefinition<string, string>)definition;
        }

        /// <summary>
        ///     Found collation with name: {collationName}, schema: {schema}, LC_COLLATE: {lcCollate}, LC_CTYPE: {lcCtype}, provider: {provider}, deterministic: {isDeterministic}
        /// </summary>
        public static EventDefinition<string, string, string, string, string?, bool> LogFoundCollation(IDiagnosticsLogger logger)
        {
            var definition = ((NpgsqlLoggingDefinitions)logger.Definitions).LogFoundCollation;
            if (definition is null)
            {
                definition = NonCapturingLazyInitializer.EnsureInitialized(
                    ref ((NpgsqlLoggingDefinitions)logger.Definitions).LogFoundCollation,
                    logger,
                    static logger => new EventDefinition<string, string, string, string, string?, bool>(
                        logger.Options,
                        NpgsqlEventId.CollationFound,
                        LogLevel.Debug,
                        "NpgsqlEventId.CollationFound",
                        level => LoggerMessage.Define<string, string, string, string, string?, bool>(
                            level,
                            NpgsqlEventId.CollationFound,
                            _resourceManager.GetString("LogFoundCollation")!)));
            }

            return (EventDefinition<string, string, string, string, string?, bool>)definition;
        }

        /// <summary>
        ///     Found column with table: {tableName}, column name: {columnName}, data type: {dataType}, nullable: {isNullable}, identity: {isIdentity}, default value: {defaultValue}, computed value: {computedValue}
        /// </summary>
        public static FallbackEventDefinition LogFoundColumn(IDiagnosticsLogger logger)
        {
            var definition = ((NpgsqlLoggingDefinitions)logger.Definitions).LogFoundColumn;
            if (definition is null)
            {
                definition = NonCapturingLazyInitializer.EnsureInitialized(
                    ref ((NpgsqlLoggingDefinitions)logger.Definitions).LogFoundColumn,
                    logger,
                    static logger => new FallbackEventDefinition(
                        logger.Options,
                        NpgsqlEventId.ColumnFound,
                        LogLevel.Debug,
                        "NpgsqlEventId.ColumnFound",
                        _resourceManager.GetString("LogFoundColumn")!));
            }

            return (FallbackEventDefinition)definition;
        }

        /// <summary>
        ///     Found foreign key on table: {tableName}, name: {foreignKeyName}, principal table: {principalTableName}, delete action: {deleteAction}.
        /// </summary>
        public static EventDefinition<string, string, string, string> LogFoundForeignKey(IDiagnosticsLogger logger)
        {
            var definition = ((NpgsqlLoggingDefinitions)logger.Definitions).LogFoundForeignKey;
            if (definition is null)
            {
                definition = NonCapturingLazyInitializer.EnsureInitialized(
                    ref ((NpgsqlLoggingDefinitions)logger.Definitions).LogFoundForeignKey,
                    logger,
                    static logger => new EventDefinition<string, string, string, string>(
                        logger.Options,
                        NpgsqlEventId.ForeignKeyFound,
                        LogLevel.Debug,
                        "NpgsqlEventId.ForeignKeyFound",
                        level => LoggerMessage.Define<string, string, string, string>(
                            level,
                            NpgsqlEventId.ForeignKeyFound,
                            _resourceManager.GetString("LogFoundForeignKey")!)));
            }

            return (EventDefinition<string, string, string, string>)definition;
        }

        /// <summary>
        ///     Found index with name: {indexName}, table: {tableName}, is unique: {isUnique}.
        /// </summary>
        public static EventDefinition<string, string, bool> LogFoundIndex(IDiagnosticsLogger logger)
        {
            var definition = ((NpgsqlLoggingDefinitions)logger.Definitions).LogFoundIndex;
            if (definition is null)
            {
                definition = NonCapturingLazyInitializer.EnsureInitialized(
                    ref ((NpgsqlLoggingDefinitions)logger.Definitions).LogFoundIndex,
                    logger,
                    static logger => new EventDefinition<string, string, bool>(
                        logger.Options,
                        NpgsqlEventId.IndexFound,
                        LogLevel.Debug,
                        "NpgsqlEventId.IndexFound",
                        level => LoggerMessage.Define<string, string, bool>(
                            level,
                            NpgsqlEventId.IndexFound,
                            _resourceManager.GetString("LogFoundIndex")!)));
            }

            return (EventDefinition<string, string, bool>)definition;
        }

        /// <summary>
        ///     Found primary key with name: {primaryKeyName}, table: {tableName}.
        /// </summary>
        public static EventDefinition<string, string> LogFoundPrimaryKey(IDiagnosticsLogger logger)
        {
            var definition = ((NpgsqlLoggingDefinitions)logger.Definitions).LogFoundPrimaryKey;
            if (definition is null)
            {
                definition = NonCapturingLazyInitializer.EnsureInitialized(
                    ref ((NpgsqlLoggingDefinitions)logger.Definitions).LogFoundPrimaryKey,
                    logger,
                    static logger => new EventDefinition<string, string>(
                        logger.Options,
                        NpgsqlEventId.PrimaryKeyFound,
                        LogLevel.Debug,
                        "NpgsqlEventId.PrimaryKeyFound",
                        level => LoggerMessage.Define<string, string>(
                            level,
                            NpgsqlEventId.PrimaryKeyFound,
                            _resourceManager.GetString("LogFoundPrimaryKey")!)));
            }

            return (EventDefinition<string, string>)definition;
        }

        /// <summary>
        ///     Found sequence name: {name}, data type: {dataType}, cyclic: {isCyclic}, increment: {increment}, start: {start}, minimum: {min}, maximum: {max}.
        /// </summary>
        public static FallbackEventDefinition LogFoundSequence(IDiagnosticsLogger logger)
        {
            var definition = ((NpgsqlLoggingDefinitions)logger.Definitions).LogFoundSequence;
            if (definition is null)
            {
                definition = NonCapturingLazyInitializer.EnsureInitialized(
                    ref ((NpgsqlLoggingDefinitions)logger.Definitions).LogFoundSequence,
                    logger,
                    static logger => new FallbackEventDefinition(
                        logger.Options,
                        NpgsqlEventId.SequenceFound,
                        LogLevel.Debug,
                        "NpgsqlEventId.SequenceFound",
                        _resourceManager.GetString("LogFoundSequence")!));
            }

            return (FallbackEventDefinition)definition;
        }

        /// <summary>
        ///     Found table with name: {name}.
        /// </summary>
        public static EventDefinition<string> LogFoundTable(IDiagnosticsLogger logger)
        {
            var definition = ((NpgsqlLoggingDefinitions)logger.Definitions).LogFoundTable;
            if (definition is null)
            {
                definition = NonCapturingLazyInitializer.EnsureInitialized(
                    ref ((NpgsqlLoggingDefinitions)logger.Definitions).LogFoundTable,
                    logger,
                    static logger => new EventDefinition<string>(
                        logger.Options,
                        NpgsqlEventId.TableFound,
                        LogLevel.Debug,
                        "NpgsqlEventId.TableFound",
                        level => LoggerMessage.Define<string>(
                            level,
                            NpgsqlEventId.TableFound,
                            _resourceManager.GetString("LogFoundTable")!)));
            }

            return (EventDefinition<string>)definition;
        }

        /// <summary>
        ///     Found unique constraint with name: {uniqueConstraintName}, table: {tableName}.
        /// </summary>
        public static EventDefinition<string?, string> LogFoundUniqueConstraint(IDiagnosticsLogger logger)
        {
            var definition = ((NpgsqlLoggingDefinitions)logger.Definitions).LogFoundUniqueConstraint;
            if (definition is null)
            {
                definition = NonCapturingLazyInitializer.EnsureInitialized(
                    ref ((NpgsqlLoggingDefinitions)logger.Definitions).LogFoundUniqueConstraint,
                    logger,
                    static logger => new EventDefinition<string?, string>(
                        logger.Options,
                        NpgsqlEventId.UniqueConstraintFound,
                        LogLevel.Debug,
                        "NpgsqlEventId.UniqueConstraintFound",
                        level => LoggerMessage.Define<string?, string>(
                            level,
                            NpgsqlEventId.UniqueConstraintFound,
                            _resourceManager.GetString("LogFoundUniqueConstraint")!)));
            }

            return (EventDefinition<string?, string>)definition;
        }

        /// <summary>
        ///     Unable to find a schema in the database matching the selected schema {schema}.
        /// </summary>
        public static EventDefinition<string?> LogMissingSchema(IDiagnosticsLogger logger)
        {
            var definition = ((NpgsqlLoggingDefinitions)logger.Definitions).LogMissingSchema;
            if (definition is null)
            {
                definition = NonCapturingLazyInitializer.EnsureInitialized(
                    ref ((NpgsqlLoggingDefinitions)logger.Definitions).LogMissingSchema,
                    logger,
                    static logger => new EventDefinition<string?>(
                        logger.Options,
                        NpgsqlEventId.MissingSchemaWarning,
                        LogLevel.Warning,
                        "NpgsqlEventId.MissingSchemaWarning",
                        level => LoggerMessage.Define<string?>(
                            level,
                            NpgsqlEventId.MissingSchemaWarning,
                            _resourceManager.GetString("LogMissingSchema")!)));
            }

            return (EventDefinition<string?>)definition;
        }

        /// <summary>
        ///     Unable to find a table in the database matching the selected table {table}.
        /// </summary>
        public static EventDefinition<string?> LogMissingTable(IDiagnosticsLogger logger)
        {
            var definition = ((NpgsqlLoggingDefinitions)logger.Definitions).LogMissingTable;
            if (definition is null)
            {
                definition = NonCapturingLazyInitializer.EnsureInitialized(
                    ref ((NpgsqlLoggingDefinitions)logger.Definitions).LogMissingTable,
                    logger,
                    static logger => new EventDefinition<string?>(
                        logger.Options,
                        NpgsqlEventId.MissingTableWarning,
                        LogLevel.Warning,
                        "NpgsqlEventId.MissingTableWarning",
                        level => LoggerMessage.Define<string?>(
                            level,
                            NpgsqlEventId.MissingTableWarning,
                            _resourceManager.GetString("LogMissingTable")!)));
            }

            return (EventDefinition<string?>)definition;
        }

        /// <summary>
        ///     For foreign key {foreignKeyName} on table {tableName}, unable to find the column called {principalColumnName} on the foreign key's principal table, {principaltableName}. Skipping foreign key.
        /// </summary>
        public static EventDefinition<string, string, string, string> LogPrincipalColumnNotFound(IDiagnosticsLogger logger)
        {
            var definition = ((NpgsqlLoggingDefinitions)logger.Definitions).LogPrincipalColumnNotFound;
            if (definition is null)
            {
                definition = NonCapturingLazyInitializer.EnsureInitialized(
                    ref ((NpgsqlLoggingDefinitions)logger.Definitions).LogPrincipalColumnNotFound,
                    logger,
                    static logger => new EventDefinition<string, string, string, string>(
                        logger.Options,
                        NpgsqlEventId.ForeignKeyPrincipalColumnMissingWarning,
                        LogLevel.Warning,
                        "NpgsqlEventId.ForeignKeyPrincipalColumnMissingWarning",
                        level => LoggerMessage.Define<string, string, string, string>(
                            level,
                            NpgsqlEventId.ForeignKeyPrincipalColumnMissingWarning,
                            _resourceManager.GetString("LogPrincipalColumnNotFound")!)));
            }

            return (EventDefinition<string, string, string, string>)definition;
        }

        /// <summary>
        ///     For foreign key {fkName} on table {tableName}, unable to model the end of the foreign key on principal table {principaltableName}. This is usually because the principal table was not included in the selection set.
        /// </summary>
        public static EventDefinition<string?, string?, string?> LogPrincipalTableNotInSelectionSet(IDiagnosticsLogger logger)
        {
            var definition = ((NpgsqlLoggingDefinitions)logger.Definitions).LogPrincipalTableNotInSelectionSet;
            if (definition is null)
            {
                definition = NonCapturingLazyInitializer.EnsureInitialized(
                    ref ((NpgsqlLoggingDefinitions)logger.Definitions).LogPrincipalTableNotInSelectionSet,
                    logger,
                    static logger => new EventDefinition<string?, string?, string?>(
                        logger.Options,
                        NpgsqlEventId.ForeignKeyReferencesMissingPrincipalTableWarning,
                        LogLevel.Warning,
                        "NpgsqlEventId.ForeignKeyReferencesMissingPrincipalTableWarning",
                        level => LoggerMessage.Define<string?, string?, string?>(
                            level,
                            NpgsqlEventId.ForeignKeyReferencesMissingPrincipalTableWarning,
                            _resourceManager.GetString("LogPrincipalTableNotInSelectionSet")!)));
            }

            return (EventDefinition<string?, string?, string?>)definition;
        }

        /// <summary>
        ///     Constraint '{name}' on table {tableName} cannot be scaffolded because it includes a column that cannot be scaffolded (e.g. enum).
        /// </summary>
        public static EventDefinition<string?, string> LogUnsupportedColumnConstraintSkipped(IDiagnosticsLogger logger)
        {
            var definition = ((NpgsqlLoggingDefinitions)logger.Definitions).LogUnsupportedColumnConstraintSkipped;
            if (definition is null)
            {
                definition = NonCapturingLazyInitializer.EnsureInitialized(
                    ref ((NpgsqlLoggingDefinitions)logger.Definitions).LogUnsupportedColumnConstraintSkipped,
                    logger,
                    static logger => new EventDefinition<string?, string>(
                        logger.Options,
                        NpgsqlEventId.UnsupportedColumnConstraintSkippedWarning,
                        LogLevel.Warning,
                        "NpgsqlEventId.UnsupportedColumnConstraintSkippedWarning",
                        level => LoggerMessage.Define<string?, string>(
                            level,
                            NpgsqlEventId.UnsupportedColumnConstraintSkippedWarning,
                            _resourceManager.GetString("LogUnsupportedColumnConstraintSkipped")!)));
            }

            return (EventDefinition<string?, string>)definition;
        }

        /// <summary>
        ///     Index '{name}' on table {tableName} cannot be scaffolded because it includes a column that cannot be scaffolded (e.g. enum).
        /// </summary>
        public static EventDefinition<string, string> LogUnsupportedColumnIndexSkipped(IDiagnosticsLogger logger)
        {
            var definition = ((NpgsqlLoggingDefinitions)logger.Definitions).LogUnsupportedColumnIndexSkipped;
            if (definition is null)
            {
                definition = NonCapturingLazyInitializer.EnsureInitialized(
                    ref ((NpgsqlLoggingDefinitions)logger.Definitions).LogUnsupportedColumnIndexSkipped,
                    logger,
                    static logger => new EventDefinition<string, string>(
                        logger.Options,
                        NpgsqlEventId.UnsupportedColumnIndexSkippedWarning,
                        LogLevel.Warning,
                        "NpgsqlEventId.UnsupportedColumnIndexSkippedWarning",
                        level => LoggerMessage.Define<string, string>(
                            level,
                            NpgsqlEventId.UnsupportedColumnIndexSkippedWarning,
                            _resourceManager.GetString("LogUnsupportedColumnIndexSkipped")!)));
            }

            return (EventDefinition<string, string>)definition;
        }
    }
}

