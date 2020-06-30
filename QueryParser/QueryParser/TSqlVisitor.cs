using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace QueryParser
{
    class TSqlVisitor : ITSqlParserVisitor<bool>
    {
        public bool Visit(IParseTree tree)
        {
            Debug.WriteLine("");
            Debug.WriteLine(tree.ToStringTree());
            return true;
        }

        public bool VisitAGGREGATE_WINDOWED_FUNC([NotNull] TSqlParser.AGGREGATE_WINDOWED_FUNCContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitAggregate_windowed_function([NotNull] TSqlParser.Aggregate_windowed_functionContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitAlgorithm([NotNull] TSqlParser.AlgorithmContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitAll_distinct_expression([NotNull] TSqlParser.All_distinct_expressionContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitAlter_application_role([NotNull] TSqlParser.Alter_application_roleContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitAlter_assembly([NotNull] TSqlParser.Alter_assemblyContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitAlter_assembly_add_clause([NotNull] TSqlParser.Alter_assembly_add_clauseContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitAlter_assembly_as([NotNull] TSqlParser.Alter_assembly_asContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitAlter_assembly_clause([NotNull] TSqlParser.Alter_assembly_clauseContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitAlter_assembly_client_file_clause([NotNull] TSqlParser.Alter_assembly_client_file_clauseContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitAlter_assembly_drop([NotNull] TSqlParser.Alter_assembly_dropContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitAlter_assembly_drop_clause([NotNull] TSqlParser.Alter_assembly_drop_clauseContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitAlter_assembly_drop_multiple_files([NotNull] TSqlParser.Alter_assembly_drop_multiple_filesContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitAlter_assembly_file_bits([NotNull] TSqlParser.Alter_assembly_file_bitsContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitAlter_assembly_file_name([NotNull] TSqlParser.Alter_assembly_file_nameContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitAlter_assembly_from_clause([NotNull] TSqlParser.Alter_assembly_from_clauseContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitAlter_assembly_from_clause_start([NotNull] TSqlParser.Alter_assembly_from_clause_startContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitAlter_assembly_start([NotNull] TSqlParser.Alter_assembly_startContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitAlter_assembly_with([NotNull] TSqlParser.Alter_assembly_withContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitAlter_assembly_with_clause([NotNull] TSqlParser.Alter_assembly_with_clauseContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitAlter_asssembly_add_clause_start([NotNull] TSqlParser.Alter_asssembly_add_clause_startContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitAlter_asymmetric_key([NotNull] TSqlParser.Alter_asymmetric_keyContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitAlter_asymmetric_key_start([NotNull] TSqlParser.Alter_asymmetric_key_startContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitAlter_authorization([NotNull] TSqlParser.Alter_authorizationContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitAlter_authorization_for_azure_dw([NotNull] TSqlParser.Alter_authorization_for_azure_dwContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitAlter_authorization_for_parallel_dw([NotNull] TSqlParser.Alter_authorization_for_parallel_dwContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitAlter_authorization_for_sql_database([NotNull] TSqlParser.Alter_authorization_for_sql_databaseContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitAlter_authorization_start([NotNull] TSqlParser.Alter_authorization_startContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitAlter_availability_group([NotNull] TSqlParser.Alter_availability_groupContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitAlter_availability_group_options([NotNull] TSqlParser.Alter_availability_group_optionsContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitAlter_availability_group_start([NotNull] TSqlParser.Alter_availability_group_startContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitAlter_certificate([NotNull] TSqlParser.Alter_certificateContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitAlter_column_encryption_key([NotNull] TSqlParser.Alter_column_encryption_keyContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitAlter_credential([NotNull] TSqlParser.Alter_credentialContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitAlter_cryptographic_provider([NotNull] TSqlParser.Alter_cryptographic_providerContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitAlter_database([NotNull] TSqlParser.Alter_databaseContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitAlter_db_role([NotNull] TSqlParser.Alter_db_roleContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitAlter_endpoint([NotNull] TSqlParser.Alter_endpointContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitAlter_external_data_source([NotNull] TSqlParser.Alter_external_data_sourceContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitAlter_external_library([NotNull] TSqlParser.Alter_external_libraryContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitAlter_external_resource_pool([NotNull] TSqlParser.Alter_external_resource_poolContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitAlter_fulltext_catalog([NotNull] TSqlParser.Alter_fulltext_catalogContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitAlter_fulltext_stoplist([NotNull] TSqlParser.Alter_fulltext_stoplistContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitAlter_login_azure_sql([NotNull] TSqlParser.Alter_login_azure_sqlContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitAlter_login_azure_sql_dw_and_pdw([NotNull] TSqlParser.Alter_login_azure_sql_dw_and_pdwContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitAlter_login_sql_server([NotNull] TSqlParser.Alter_login_sql_serverContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitAlter_master_key_azure_sql([NotNull] TSqlParser.Alter_master_key_azure_sqlContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitAlter_master_key_sql_server([NotNull] TSqlParser.Alter_master_key_sql_serverContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitAlter_message_type([NotNull] TSqlParser.Alter_message_typeContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitAlter_partition_function([NotNull] TSqlParser.Alter_partition_functionContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitAlter_partition_scheme([NotNull] TSqlParser.Alter_partition_schemeContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitAlter_queue([NotNull] TSqlParser.Alter_queueContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitAlter_remote_service_binding([NotNull] TSqlParser.Alter_remote_service_bindingContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitAlter_resource_governor([NotNull] TSqlParser.Alter_resource_governorContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitAlter_schema_azure_sql_dw_and_pdw([NotNull] TSqlParser.Alter_schema_azure_sql_dw_and_pdwContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitAlter_schema_sql([NotNull] TSqlParser.Alter_schema_sqlContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitAlter_sequence([NotNull] TSqlParser.Alter_sequenceContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitAlter_server_audit([NotNull] TSqlParser.Alter_server_auditContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitAlter_server_audit_specification([NotNull] TSqlParser.Alter_server_audit_specificationContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitAlter_server_configuration([NotNull] TSqlParser.Alter_server_configurationContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitAlter_server_role([NotNull] TSqlParser.Alter_server_roleContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitAlter_server_role_pdw([NotNull] TSqlParser.Alter_server_role_pdwContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitAlter_service([NotNull] TSqlParser.Alter_serviceContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitAlter_service_master_key([NotNull] TSqlParser.Alter_service_master_keyContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitAlter_symmetric_key([NotNull] TSqlParser.Alter_symmetric_keyContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitAlter_table([NotNull] TSqlParser.Alter_tableContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitAlter_user([NotNull] TSqlParser.Alter_userContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitAlter_user_azure_sql([NotNull] TSqlParser.Alter_user_azure_sqlContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitAlter_workload_group([NotNull] TSqlParser.Alter_workload_groupContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitANALYTIC_WINDOWED_FUNC([NotNull] TSqlParser.ANALYTIC_WINDOWED_FUNCContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitAnalytic_windowed_function([NotNull] TSqlParser.Analytic_windowed_functionContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitAnother_statement([NotNull] TSqlParser.Another_statementContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitAssembly_option([NotNull] TSqlParser.Assembly_optionContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitAssignment_operator([NotNull] TSqlParser.Assignment_operatorContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitAsterisk([NotNull] TSqlParser.AsteriskContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitAsymmetric_key_option([NotNull] TSqlParser.Asymmetric_key_optionContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitAsymmetric_key_option_start([NotNull] TSqlParser.Asymmetric_key_option_startContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitAsymmetric_key_password_change_option([NotNull] TSqlParser.Asymmetric_key_password_change_optionContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitAs_column_alias([NotNull] TSqlParser.As_column_aliasContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitAs_table_alias([NotNull] TSqlParser.As_table_aliasContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitAuthorization_grantee([NotNull] TSqlParser.Authorization_granteeContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitAuto_option([NotNull] TSqlParser.Auto_optionContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitBackup_certificate([NotNull] TSqlParser.Backup_certificateContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitBackup_database([NotNull] TSqlParser.Backup_databaseContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitBackup_log([NotNull] TSqlParser.Backup_logContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitBackup_master_key([NotNull] TSqlParser.Backup_master_keyContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitBackup_service_master_key([NotNull] TSqlParser.Backup_service_master_keyContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitBackup_statement([NotNull] TSqlParser.Backup_statementContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitBatch([NotNull] TSqlParser.BatchContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitBegin_conversation_dialog([NotNull] TSqlParser.Begin_conversation_dialogContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitBegin_conversation_timer([NotNull] TSqlParser.Begin_conversation_timerContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitBINARY_CHECKSUM([NotNull] TSqlParser.BINARY_CHECKSUMContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitBlock_statement([NotNull] TSqlParser.Block_statementContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitBracket_expression([NotNull] TSqlParser.Bracket_expressionContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitBreak_statement([NotNull] TSqlParser.Break_statementContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitBulk_option([NotNull] TSqlParser.Bulk_optionContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitCase_expression([NotNull] TSqlParser.Case_expressionContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitCAST([NotNull] TSqlParser.CASTContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitCfl_statement([NotNull] TSqlParser.Cfl_statementContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitChange_table([NotNull] TSqlParser.Change_tableContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitChange_tracking_option([NotNull] TSqlParser.Change_tracking_optionContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitChange_tracking_option_list([NotNull] TSqlParser.Change_tracking_option_listContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitCHECKSUM([NotNull] TSqlParser.CHECKSUMContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitChildren(IRuleNode node)
        {
            throw new NotImplementedException();
        }

        public bool VisitClass_type([NotNull] TSqlParser.Class_typeContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitClass_type_for_azure_dw([NotNull] TSqlParser.Class_type_for_azure_dwContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitClass_type_for_parallel_dw([NotNull] TSqlParser.Class_type_for_parallel_dwContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitClass_type_for_sql_database([NotNull] TSqlParser.Class_type_for_sql_databaseContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitClient_assembly_specifier([NotNull] TSqlParser.Client_assembly_specifierContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitClose_key([NotNull] TSqlParser.Close_keyContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitClustered([NotNull] TSqlParser.ClusteredContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitCOALESCE([NotNull] TSqlParser.COALESCEContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitColon_colon([NotNull] TSqlParser.Colon_colonContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitColumn_alias([NotNull] TSqlParser.Column_aliasContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitColumn_alias_list([NotNull] TSqlParser.Column_alias_listContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitColumn_constraint([NotNull] TSqlParser.Column_constraintContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitColumn_declaration([NotNull] TSqlParser.Column_declarationContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitColumn_definition([NotNull] TSqlParser.Column_definitionContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitColumn_def_table_constraint([NotNull] TSqlParser.Column_def_table_constraintContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitColumn_def_table_constraints([NotNull] TSqlParser.Column_def_table_constraintsContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitColumn_elem([NotNull] TSqlParser.Column_elemContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitColumn_name_list([NotNull] TSqlParser.Column_name_listContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitColumn_name_list_with_order([NotNull] TSqlParser.Column_name_list_with_orderContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitCommon_table_expression([NotNull] TSqlParser.Common_table_expressionContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitComparison_operator([NotNull] TSqlParser.Comparison_operatorContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitConstant([NotNull] TSqlParser.ConstantContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitConstant_expression([NotNull] TSqlParser.Constant_expressionContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitConstant_LOCAL_ID([NotNull] TSqlParser.Constant_LOCAL_IDContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitContainment_option([NotNull] TSqlParser.Containment_optionContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitContinue_statement([NotNull] TSqlParser.Continue_statementContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitContract_name([NotNull] TSqlParser.Contract_nameContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitConversation_statement([NotNull] TSqlParser.Conversation_statementContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitCONVERT([NotNull] TSqlParser.CONVERTContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitCreate_application_role([NotNull] TSqlParser.Create_application_roleContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitCreate_assembly([NotNull] TSqlParser.Create_assemblyContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitCreate_asymmetric_key([NotNull] TSqlParser.Create_asymmetric_keyContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitCreate_certificate([NotNull] TSqlParser.Create_certificateContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitCreate_column_encryption_key([NotNull] TSqlParser.Create_column_encryption_keyContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitCreate_column_master_key([NotNull] TSqlParser.Create_column_master_keyContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitCreate_contract([NotNull] TSqlParser.Create_contractContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitCreate_credential([NotNull] TSqlParser.Create_credentialContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitCreate_cryptographic_provider([NotNull] TSqlParser.Create_cryptographic_providerContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitCreate_database([NotNull] TSqlParser.Create_databaseContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitCreate_database_option([NotNull] TSqlParser.Create_database_optionContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitCreate_db_role([NotNull] TSqlParser.Create_db_roleContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitCreate_event_notification([NotNull] TSqlParser.Create_event_notificationContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitCreate_external_library([NotNull] TSqlParser.Create_external_libraryContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitCreate_external_resource_pool([NotNull] TSqlParser.Create_external_resource_poolContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitCreate_fulltext_catalog([NotNull] TSqlParser.Create_fulltext_catalogContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitCreate_fulltext_stoplist([NotNull] TSqlParser.Create_fulltext_stoplistContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitCreate_index([NotNull] TSqlParser.Create_indexContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitCreate_key([NotNull] TSqlParser.Create_keyContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitCreate_login_azure_sql([NotNull] TSqlParser.Create_login_azure_sqlContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitCreate_login_pdw([NotNull] TSqlParser.Create_login_pdwContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitCreate_login_sql_server([NotNull] TSqlParser.Create_login_sql_serverContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitCreate_master_key_azure_sql([NotNull] TSqlParser.Create_master_key_azure_sqlContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitCreate_master_key_sql_server([NotNull] TSqlParser.Create_master_key_sql_serverContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitCreate_or_alter_broker_priority([NotNull] TSqlParser.Create_or_alter_broker_priorityContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitCreate_or_alter_ddl_trigger([NotNull] TSqlParser.Create_or_alter_ddl_triggerContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitCreate_or_alter_dml_trigger([NotNull] TSqlParser.Create_or_alter_dml_triggerContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitCreate_or_alter_event_session([NotNull] TSqlParser.Create_or_alter_event_sessionContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitCreate_or_alter_function([NotNull] TSqlParser.Create_or_alter_functionContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitCreate_or_alter_procedure([NotNull] TSqlParser.Create_or_alter_procedureContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitCreate_or_alter_trigger([NotNull] TSqlParser.Create_or_alter_triggerContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitCreate_queue([NotNull] TSqlParser.Create_queueContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitCreate_remote_service_binding([NotNull] TSqlParser.Create_remote_service_bindingContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitCreate_resource_pool([NotNull] TSqlParser.Create_resource_poolContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitCreate_route([NotNull] TSqlParser.Create_routeContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitCreate_rule([NotNull] TSqlParser.Create_ruleContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitCreate_schema([NotNull] TSqlParser.Create_schemaContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitCreate_schema_azure_sql_dw_and_pdw([NotNull] TSqlParser.Create_schema_azure_sql_dw_and_pdwContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitCreate_search_property_list([NotNull] TSqlParser.Create_search_property_listContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitCreate_security_policy([NotNull] TSqlParser.Create_security_policyContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitCreate_sequence([NotNull] TSqlParser.Create_sequenceContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitCreate_server_audit([NotNull] TSqlParser.Create_server_auditContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitCreate_server_audit_specification([NotNull] TSqlParser.Create_server_audit_specificationContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitCreate_server_role([NotNull] TSqlParser.Create_server_roleContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitCreate_service([NotNull] TSqlParser.Create_serviceContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitCreate_statistics([NotNull] TSqlParser.Create_statisticsContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitCreate_symmetric_key([NotNull] TSqlParser.Create_symmetric_keyContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitCreate_synonym([NotNull] TSqlParser.Create_synonymContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitCreate_table([NotNull] TSqlParser.Create_tableContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitCreate_type([NotNull] TSqlParser.Create_typeContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitCreate_user([NotNull] TSqlParser.Create_userContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitCreate_user_azure_sql_dw([NotNull] TSqlParser.Create_user_azure_sql_dwContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitCreate_view([NotNull] TSqlParser.Create_viewContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitCreate_workload_group([NotNull] TSqlParser.Create_workload_groupContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitCreate_xml_schema_collection([NotNull] TSqlParser.Create_xml_schema_collectionContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitCURRENT_TIMESTAMP([NotNull] TSqlParser.CURRENT_TIMESTAMPContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitCURRENT_USER([NotNull] TSqlParser.CURRENT_USERContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitCursor_name([NotNull] TSqlParser.Cursor_nameContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitCursor_option([NotNull] TSqlParser.Cursor_optionContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitCursor_statement([NotNull] TSqlParser.Cursor_statementContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDatabase_filestream_option([NotNull] TSqlParser.Database_filestream_optionContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDatabase_file_spec([NotNull] TSqlParser.Database_file_specContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDatabase_mirroring_option([NotNull] TSqlParser.Database_mirroring_optionContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDatabase_optionspec([NotNull] TSqlParser.Database_optionspecContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitData_type([NotNull] TSqlParser.Data_typeContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDATEADD([NotNull] TSqlParser.DATEADDContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDATEDIFF([NotNull] TSqlParser.DATEDIFFContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDATENAME([NotNull] TSqlParser.DATENAMEContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDATEPART([NotNull] TSqlParser.DATEPARTContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDate_correlation_optimization_option([NotNull] TSqlParser.Date_correlation_optimization_optionContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDate_options([NotNull] TSqlParser.Date_optionsContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDbcc_clause([NotNull] TSqlParser.Dbcc_clauseContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDbcc_options([NotNull] TSqlParser.Dbcc_optionsContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDb_encryption_option([NotNull] TSqlParser.Db_encryption_optionContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDb_state_option([NotNull] TSqlParser.Db_state_optionContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDb_update_option([NotNull] TSqlParser.Db_update_optionContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDb_user_access_option([NotNull] TSqlParser.Db_user_access_optionContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDdl_clause([NotNull] TSqlParser.Ddl_clauseContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDdl_object([NotNull] TSqlParser.Ddl_objectContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDdl_trigger_operation([NotNull] TSqlParser.Ddl_trigger_operationContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDeclare_cursor([NotNull] TSqlParser.Declare_cursorContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDeclare_local([NotNull] TSqlParser.Declare_localContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDeclare_set_cursor_common([NotNull] TSqlParser.Declare_set_cursor_commonContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDeclare_set_cursor_common_partial([NotNull] TSqlParser.Declare_set_cursor_common_partialContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDeclare_statement([NotNull] TSqlParser.Declare_statementContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDecryption_mechanism([NotNull] TSqlParser.Decryption_mechanismContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDefault_value([NotNull] TSqlParser.Default_valueContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDelayed_durability_option([NotNull] TSqlParser.Delayed_durability_optionContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDelete_statement([NotNull] TSqlParser.Delete_statementContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDelete_statement_from([NotNull] TSqlParser.Delete_statement_fromContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDerived_table([NotNull] TSqlParser.Derived_tableContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDisable_trigger([NotNull] TSqlParser.Disable_triggerContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDml_clause([NotNull] TSqlParser.Dml_clauseContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDml_trigger_operation([NotNull] TSqlParser.Dml_trigger_operationContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDml_trigger_option([NotNull] TSqlParser.Dml_trigger_optionContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDrop_aggregate([NotNull] TSqlParser.Drop_aggregateContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDrop_application_role([NotNull] TSqlParser.Drop_application_roleContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDrop_assembly([NotNull] TSqlParser.Drop_assemblyContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDrop_asymmetric_key([NotNull] TSqlParser.Drop_asymmetric_keyContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDrop_availability_group([NotNull] TSqlParser.Drop_availability_groupContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDrop_backward_compatible_index([NotNull] TSqlParser.Drop_backward_compatible_indexContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDrop_broker_priority([NotNull] TSqlParser.Drop_broker_priorityContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDrop_certificate([NotNull] TSqlParser.Drop_certificateContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDrop_column_encryption_key([NotNull] TSqlParser.Drop_column_encryption_keyContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDrop_column_master_key([NotNull] TSqlParser.Drop_column_master_keyContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDrop_contract([NotNull] TSqlParser.Drop_contractContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDrop_credential([NotNull] TSqlParser.Drop_credentialContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDrop_cryptograhic_provider([NotNull] TSqlParser.Drop_cryptograhic_providerContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDrop_database([NotNull] TSqlParser.Drop_databaseContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDrop_database_audit_specification([NotNull] TSqlParser.Drop_database_audit_specificationContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDrop_database_scoped_credential([NotNull] TSqlParser.Drop_database_scoped_credentialContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDrop_db_role([NotNull] TSqlParser.Drop_db_roleContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDrop_ddl_trigger([NotNull] TSqlParser.Drop_ddl_triggerContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDrop_default([NotNull] TSqlParser.Drop_defaultContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDrop_dml_trigger([NotNull] TSqlParser.Drop_dml_triggerContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDrop_endpoint([NotNull] TSqlParser.Drop_endpointContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDrop_event_notifications([NotNull] TSqlParser.Drop_event_notificationsContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDrop_event_session([NotNull] TSqlParser.Drop_event_sessionContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDrop_external_data_source([NotNull] TSqlParser.Drop_external_data_sourceContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDrop_external_file_format([NotNull] TSqlParser.Drop_external_file_formatContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDrop_external_library([NotNull] TSqlParser.Drop_external_libraryContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDrop_external_resource_pool([NotNull] TSqlParser.Drop_external_resource_poolContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDrop_external_table([NotNull] TSqlParser.Drop_external_tableContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDrop_fulltext_catalog([NotNull] TSqlParser.Drop_fulltext_catalogContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDrop_fulltext_index([NotNull] TSqlParser.Drop_fulltext_indexContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDrop_fulltext_stoplist([NotNull] TSqlParser.Drop_fulltext_stoplistContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDrop_function([NotNull] TSqlParser.Drop_functionContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDrop_index([NotNull] TSqlParser.Drop_indexContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDrop_login([NotNull] TSqlParser.Drop_loginContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDrop_master_key([NotNull] TSqlParser.Drop_master_keyContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDrop_message_type([NotNull] TSqlParser.Drop_message_typeContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDrop_partition_function([NotNull] TSqlParser.Drop_partition_functionContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDrop_partition_scheme([NotNull] TSqlParser.Drop_partition_schemeContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDrop_procedure([NotNull] TSqlParser.Drop_procedureContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDrop_queue([NotNull] TSqlParser.Drop_queueContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDrop_relational_or_xml_or_spatial_index([NotNull] TSqlParser.Drop_relational_or_xml_or_spatial_indexContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDrop_remote_service_binding([NotNull] TSqlParser.Drop_remote_service_bindingContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDrop_resource_pool([NotNull] TSqlParser.Drop_resource_poolContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDrop_route([NotNull] TSqlParser.Drop_routeContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDrop_rule([NotNull] TSqlParser.Drop_ruleContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDrop_schema([NotNull] TSqlParser.Drop_schemaContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDrop_search_property_list([NotNull] TSqlParser.Drop_search_property_listContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDrop_security_policy([NotNull] TSqlParser.Drop_security_policyContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDrop_sequence([NotNull] TSqlParser.Drop_sequenceContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDrop_server_audit([NotNull] TSqlParser.Drop_server_auditContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDrop_server_audit_specification([NotNull] TSqlParser.Drop_server_audit_specificationContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDrop_server_role([NotNull] TSqlParser.Drop_server_roleContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDrop_service([NotNull] TSqlParser.Drop_serviceContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDrop_signature([NotNull] TSqlParser.Drop_signatureContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDrop_statistics([NotNull] TSqlParser.Drop_statisticsContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDrop_statistics_name_azure_dw_and_pdw([NotNull] TSqlParser.Drop_statistics_name_azure_dw_and_pdwContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDrop_symmetric_key([NotNull] TSqlParser.Drop_symmetric_keyContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDrop_synonym([NotNull] TSqlParser.Drop_synonymContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDrop_table([NotNull] TSqlParser.Drop_tableContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDrop_trigger([NotNull] TSqlParser.Drop_triggerContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDrop_type([NotNull] TSqlParser.Drop_typeContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDrop_user([NotNull] TSqlParser.Drop_userContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDrop_view([NotNull] TSqlParser.Drop_viewContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDrop_workload_group([NotNull] TSqlParser.Drop_workload_groupContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitDrop_xml_schema_collection([NotNull] TSqlParser.Drop_xml_schema_collectionContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitEmpty_statement([NotNull] TSqlParser.Empty_statementContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitEnable_trigger([NotNull] TSqlParser.Enable_triggerContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitEncryption_mechanism([NotNull] TSqlParser.Encryption_mechanismContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitEnd_conversation([NotNull] TSqlParser.End_conversationContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitEntity_name([NotNull] TSqlParser.Entity_nameContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitEntity_name_for_azure_dw([NotNull] TSqlParser.Entity_name_for_azure_dwContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitEntity_name_for_parallel_dw([NotNull] TSqlParser.Entity_name_for_parallel_dwContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitEntity_to([NotNull] TSqlParser.Entity_toContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitErrorNode(IErrorNode node)
        {
            throw new NotImplementedException();
        }

        public bool VisitEvent_session_predicate_expression([NotNull] TSqlParser.Event_session_predicate_expressionContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitEvent_session_predicate_factor([NotNull] TSqlParser.Event_session_predicate_factorContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitEvent_session_predicate_leaf([NotNull] TSqlParser.Event_session_predicate_leafContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitExecute_body([NotNull] TSqlParser.Execute_bodyContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitExecute_clause([NotNull] TSqlParser.Execute_clauseContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitExecute_statement([NotNull] TSqlParser.Execute_statementContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitExecute_statement_arg([NotNull] TSqlParser.Execute_statement_argContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitExecute_var_string([NotNull] TSqlParser.Execute_var_stringContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitExisting_keys([NotNull] TSqlParser.Existing_keysContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitExist_method([NotNull] TSqlParser.Exist_methodContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitExpression([NotNull] TSqlParser.ExpressionContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitExpression_elem([NotNull] TSqlParser.Expression_elemContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitExpression_list([NotNull] TSqlParser.Expression_listContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitExternal_access_option([NotNull] TSqlParser.External_access_optionContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitFetch_cursor([NotNull] TSqlParser.Fetch_cursorContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitFile_directory_path_separator([NotNull] TSqlParser.File_directory_path_separatorContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitFile_group([NotNull] TSqlParser.File_groupContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitFile_path([NotNull] TSqlParser.File_pathContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitFile_size([NotNull] TSqlParser.File_sizeContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitFile_spec([NotNull] TSqlParser.File_specContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitFor_clause([NotNull] TSqlParser.For_clauseContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitFull_column_name([NotNull] TSqlParser.Full_column_nameContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitFull_column_name_list([NotNull] TSqlParser.Full_column_name_listContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitFull_table_name([NotNull] TSqlParser.Full_table_nameContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitFunction_option([NotNull] TSqlParser.Function_optionContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitFunc_body_returns_scalar([NotNull] TSqlParser.Func_body_returns_scalarContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitFunc_body_returns_select([NotNull] TSqlParser.Func_body_returns_selectContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitFunc_body_returns_table([NotNull] TSqlParser.Func_body_returns_tableContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitFunc_proc_name_database_schema([NotNull] TSqlParser.Func_proc_name_database_schemaContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitFunc_proc_name_schema([NotNull] TSqlParser.Func_proc_name_schemaContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitFunc_proc_name_server_database_schema([NotNull] TSqlParser.Func_proc_name_server_database_schemaContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitGenerate_new_keys([NotNull] TSqlParser.Generate_new_keysContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitGETDATE([NotNull] TSqlParser.GETDATEContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitGETUTCDATE([NotNull] TSqlParser.GETUTCDATEContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitGet_conversation([NotNull] TSqlParser.Get_conversationContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitGoto_statement([NotNull] TSqlParser.Goto_statementContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitGo_statement([NotNull] TSqlParser.Go_statementContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitGrant_permission([NotNull] TSqlParser.Grant_permissionContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitGroup_by_item([NotNull] TSqlParser.Group_by_itemContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitHadr_options([NotNull] TSqlParser.Hadr_optionsContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitHost([NotNull] TSqlParser.HostContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitId([NotNull] TSqlParser.IdContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitIDENTITY([NotNull] TSqlParser.IDENTITYContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitIFF([NotNull] TSqlParser.IFFContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitIf_statement([NotNull] TSqlParser.If_statementContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitIndex_option([NotNull] TSqlParser.Index_optionContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitIndex_options([NotNull] TSqlParser.Index_optionsContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitIndex_value([NotNull] TSqlParser.Index_valueContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitInsert_statement([NotNull] TSqlParser.Insert_statementContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitInsert_statement_value([NotNull] TSqlParser.Insert_statement_valueContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitInsert_with_table_hints([NotNull] TSqlParser.Insert_with_table_hintsContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitISNULL([NotNull] TSqlParser.ISNULLContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitJoin_part([NotNull] TSqlParser.Join_partContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitKey_options([NotNull] TSqlParser.Key_optionsContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitKill_process([NotNull] TSqlParser.Kill_processContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitKill_query_notification([NotNull] TSqlParser.Kill_query_notificationContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitKill_statement([NotNull] TSqlParser.Kill_statementContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitKill_stats_job([NotNull] TSqlParser.Kill_stats_jobContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitLocal_drive([NotNull] TSqlParser.Local_driveContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitLocal_file([NotNull] TSqlParser.Local_fileContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitLock_table([NotNull] TSqlParser.Lock_tableContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitMaterialized_column_definition([NotNull] TSqlParser.Materialized_column_definitionContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitMerge_matched([NotNull] TSqlParser.Merge_matchedContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitMerge_not_matched([NotNull] TSqlParser.Merge_not_matchedContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitMerge_statement([NotNull] TSqlParser.Merge_statementContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitMessage_statement([NotNull] TSqlParser.Message_statementContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitMIN_ACTIVE_ROWVERSION([NotNull] TSqlParser.MIN_ACTIVE_ROWVERSIONContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitMirroring_host_port_seperator([NotNull] TSqlParser.Mirroring_host_port_seperatorContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitMirroring_partner([NotNull] TSqlParser.Mirroring_partnerContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitMirroring_set_option([NotNull] TSqlParser.Mirroring_set_optionContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitMirroring_witness([NotNull] TSqlParser.Mirroring_witnessContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitMixed_page_allocation_option([NotNull] TSqlParser.Mixed_page_allocation_optionContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitModify_method([NotNull] TSqlParser.Modify_methodContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitMultiple_local_files([NotNull] TSqlParser.Multiple_local_filesContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitMultiple_local_file_start([NotNull] TSqlParser.Multiple_local_file_startContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitNetwork_computer([NotNull] TSqlParser.Network_computerContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitNetwork_file_share([NotNull] TSqlParser.Network_file_shareContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitNetwork_file_start([NotNull] TSqlParser.Network_file_startContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitNodes_method([NotNull] TSqlParser.Nodes_methodContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitNULLIF([NotNull] TSqlParser.NULLIFContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitNull_notnull([NotNull] TSqlParser.Null_notnullContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitNull_or_default([NotNull] TSqlParser.Null_or_defaultContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitOn_delete([NotNull] TSqlParser.On_deleteContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitOn_off([NotNull] TSqlParser.On_offContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitOn_update([NotNull] TSqlParser.On_updateContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitOpendatasource([NotNull] TSqlParser.OpendatasourceContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitOpenquery([NotNull] TSqlParser.OpenqueryContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitOpen_key([NotNull] TSqlParser.Open_keyContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitOpen_xml([NotNull] TSqlParser.Open_xmlContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitOptimize_for_arg([NotNull] TSqlParser.Optimize_for_argContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitOption([NotNull] TSqlParser.OptionContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitOption_clause([NotNull] TSqlParser.Option_clauseContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitOrder_by_clause([NotNull] TSqlParser.Order_by_clauseContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitOrder_by_expression([NotNull] TSqlParser.Order_by_expressionContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitOutput_clause([NotNull] TSqlParser.Output_clauseContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitOutput_column_name([NotNull] TSqlParser.Output_column_nameContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitOutput_dml_list_elem([NotNull] TSqlParser.Output_dml_list_elemContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitOver_clause([NotNull] TSqlParser.Over_clauseContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitParameterization_option([NotNull] TSqlParser.Parameterization_optionContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitPartner_option([NotNull] TSqlParser.Partner_optionContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitPartner_server([NotNull] TSqlParser.Partner_serverContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitPartner_server_tcp_prefix([NotNull] TSqlParser.Partner_server_tcp_prefixContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitPivot_clause([NotNull] TSqlParser.Pivot_clauseContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitPort_number([NotNull] TSqlParser.Port_numberContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitPredicate([NotNull] TSqlParser.PredicateContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitPrimitive_expression([NotNull] TSqlParser.Primitive_expressionContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitPrint_statement([NotNull] TSqlParser.Print_statementContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitPrivate_key_options([NotNull] TSqlParser.Private_key_optionsContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitProcedure_option([NotNull] TSqlParser.Procedure_optionContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitProcedure_param([NotNull] TSqlParser.Procedure_paramContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitQuery_expression([NotNull] TSqlParser.Query_expressionContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitQuery_method([NotNull] TSqlParser.Query_methodContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitQuery_specification([NotNull] TSqlParser.Query_specificationContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitQueue_action([NotNull] TSqlParser.Queue_actionContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitQueue_id([NotNull] TSqlParser.Queue_idContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitQueue_rebuild_options([NotNull] TSqlParser.Queue_rebuild_optionsContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitQueue_settings([NotNull] TSqlParser.Queue_settingsContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitRaiseerror_statement([NotNull] TSqlParser.Raiseerror_statementContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitRANKING_WINDOWED_FUNC([NotNull] TSqlParser.RANKING_WINDOWED_FUNCContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitRanking_windowed_function([NotNull] TSqlParser.Ranking_windowed_functionContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitReceive_statement([NotNull] TSqlParser.Receive_statementContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitReconfigure_statement([NotNull] TSqlParser.Reconfigure_statementContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitRecovery_option([NotNull] TSqlParser.Recovery_optionContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitReturn_statement([NotNull] TSqlParser.Return_statementContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitRowset_function([NotNull] TSqlParser.Rowset_functionContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitRowset_function_limited([NotNull] TSqlParser.Rowset_function_limitedContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitRow_or_range_clause([NotNull] TSqlParser.Row_or_range_clauseContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitSCALAR_FUNCTION([NotNull] TSqlParser.SCALAR_FUNCTIONContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitScalar_function_name([NotNull] TSqlParser.Scalar_function_nameContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitSchema_declaration([NotNull] TSqlParser.Schema_declarationContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitSearch_condition([NotNull] TSqlParser.Search_conditionContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitSearch_condition_and([NotNull] TSqlParser.Search_condition_andContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitSearch_condition_list([NotNull] TSqlParser.Search_condition_listContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitSearch_condition_not([NotNull] TSqlParser.Search_condition_notContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitSecurity_statement([NotNull] TSqlParser.Security_statementContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitSelect_list([NotNull] TSqlParser.Select_listContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitSelect_list_elem([NotNull] TSqlParser.Select_list_elemContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitSelect_statement([NotNull] TSqlParser.Select_statementContext context)
        {
            Debug.WriteLine("Select Statement");
            throw new NotImplementedException();
        }

        public bool VisitSend_conversation([NotNull] TSqlParser.Send_conversationContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitService_broker_option([NotNull] TSqlParser.Service_broker_optionContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitService_name([NotNull] TSqlParser.Service_nameContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitSESSION_USER([NotNull] TSqlParser.SESSION_USERContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitSetuser_statement([NotNull] TSqlParser.Setuser_statementContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitSet_special([NotNull] TSqlParser.Set_specialContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitSet_statement([NotNull] TSqlParser.Set_statementContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitShutdown_statement([NotNull] TSqlParser.Shutdown_statementContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitSign([NotNull] TSqlParser.SignContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitSimple_id([NotNull] TSqlParser.Simple_idContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitSimple_name([NotNull] TSqlParser.Simple_nameContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitSnapshot_option([NotNull] TSqlParser.Snapshot_optionContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitSql_clause([NotNull] TSqlParser.Sql_clauseContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitSql_clauses([NotNull] TSqlParser.Sql_clausesContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitSql_option([NotNull] TSqlParser.Sql_optionContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitSql_union([NotNull] TSqlParser.Sql_unionContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitSTRINGAGG([NotNull] TSqlParser.STRINGAGGContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitSTUFF([NotNull] TSqlParser.STUFFContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitSubquery([NotNull] TSqlParser.SubqueryContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitSwitch_search_condition_section([NotNull] TSqlParser.Switch_search_condition_sectionContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitSwitch_section([NotNull] TSqlParser.Switch_sectionContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitSYSTEM_USER([NotNull] TSqlParser.SYSTEM_USERContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitTable_alias([NotNull] TSqlParser.Table_aliasContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitTable_constraint([NotNull] TSqlParser.Table_constraintContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitTable_hint([NotNull] TSqlParser.Table_hintContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitTable_name([NotNull] TSqlParser.Table_nameContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitTable_name_with_hint([NotNull] TSqlParser.Table_name_with_hintContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitTable_options([NotNull] TSqlParser.Table_optionsContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitTable_source([NotNull] TSqlParser.Table_sourceContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitTable_sources([NotNull] TSqlParser.Table_sourcesContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitTable_source_item([NotNull] TSqlParser.Table_source_itemContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitTable_source_item_joined([NotNull] TSqlParser.Table_source_item_joinedContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitTable_type_definition([NotNull] TSqlParser.Table_type_definitionContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitTable_value_constructor([NotNull] TSqlParser.Table_value_constructorContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitTarget_recovery_time_option([NotNull] TSqlParser.Target_recovery_time_optionContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitTerminal(ITerminalNode node)
        {
            throw new NotImplementedException();
        }

        public bool VisitTermination([NotNull] TSqlParser.TerminationContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitThrow_error_number([NotNull] TSqlParser.Throw_error_numberContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitThrow_message([NotNull] TSqlParser.Throw_messageContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitThrow_state([NotNull] TSqlParser.Throw_stateContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitThrow_statement([NotNull] TSqlParser.Throw_statementContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitTime([NotNull] TSqlParser.TimeContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitTop_clause([NotNull] TSqlParser.Top_clauseContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitTop_count([NotNull] TSqlParser.Top_countContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitTop_percent([NotNull] TSqlParser.Top_percentContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitTransaction_statement([NotNull] TSqlParser.Transaction_statementContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitTruncate_table([NotNull] TSqlParser.Truncate_tableContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitTry_catch_statement([NotNull] TSqlParser.Try_catch_statementContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitTsql_file([NotNull] TSqlParser.Tsql_fileContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitUdt_elem([NotNull] TSqlParser.Udt_elemContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitUdt_method_arguments([NotNull] TSqlParser.Udt_method_argumentsContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitUnary_operator_expression([NotNull] TSqlParser.Unary_operator_expressionContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitUnpivot_clause([NotNull] TSqlParser.Unpivot_clauseContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitUpdate_elem([NotNull] TSqlParser.Update_elemContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitUpdate_statement([NotNull] TSqlParser.Update_statementContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitUpdate_statistics([NotNull] TSqlParser.Update_statisticsContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitUse_statement([NotNull] TSqlParser.Use_statementContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitValue_method([NotNull] TSqlParser.Value_methodContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitView_attribute([NotNull] TSqlParser.View_attributeContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitWaitfor_conversation([NotNull] TSqlParser.Waitfor_conversationContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitWaitfor_statement([NotNull] TSqlParser.Waitfor_statementContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitWhile_statement([NotNull] TSqlParser.While_statementContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitWindow_frame_bound([NotNull] TSqlParser.Window_frame_boundContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitWindow_frame_extent([NotNull] TSqlParser.Window_frame_extentContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitWindow_frame_following([NotNull] TSqlParser.Window_frame_followingContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitWindow_frame_preceding([NotNull] TSqlParser.Window_frame_precedingContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitWith_expression([NotNull] TSqlParser.With_expressionContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitWith_table_hints([NotNull] TSqlParser.With_table_hintsContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitWitness_option([NotNull] TSqlParser.Witness_optionContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitWitness_partner_equal([NotNull] TSqlParser.Witness_partner_equalContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitWitness_server([NotNull] TSqlParser.Witness_serverContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitXml_common_directives([NotNull] TSqlParser.Xml_common_directivesContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitXML_DATA_TYPE_FUNC([NotNull] TSqlParser.XML_DATA_TYPE_FUNCContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitXml_data_type_methods([NotNull] TSqlParser.Xml_data_type_methodsContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitXml_schema_collection([NotNull] TSqlParser.Xml_schema_collectionContext context)
        {
            throw new NotImplementedException();
        }

        public bool VisitXml_type_definition([NotNull] TSqlParser.Xml_type_definitionContext context)
        {
            throw new NotImplementedException();
        }
    }
}
