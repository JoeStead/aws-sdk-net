/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the redshift-data-2019-12-20.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.RedshiftDataAPIService.Model;

namespace Amazon.RedshiftDataAPIService
{
    /// <summary>
    /// Interface for accessing RedshiftDataAPIService
    ///
    /// You can use the Amazon Redshift Data API to run queries on Amazon Redshift tables.
    /// You can run individual SQL statements, which are committed if the statement succeeds.
    /// 
    /// 
    ///  
    /// <para>
    /// For more information about the Amazon Redshift Data API, see <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/data-api.html">Using
    /// the Amazon Redshift Data API</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
    /// 
    /// </para>
    /// </summary>
    public partial interface IAmazonRedshiftDataAPIService : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IRedshiftDataAPIServicePaginatorFactory Paginators { get; }
#endif


        
        #region  CancelStatement


        /// <summary>
        /// Cancels a running query. To be canceled, a query must be running.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelStatement service method.</param>
        /// 
        /// <returns>The response from the CancelStatement service method, as returned by RedshiftDataAPIService.</returns>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.InternalServerException">
        /// The Amazon Redshift Data API operation failed due to invalid input.
        /// </exception>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.ResourceNotFoundException">
        /// The Amazon Redshift Data API operation failed due to a missing resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-data-2019-12-20/CancelStatement">REST API Reference for CancelStatement Operation</seealso>
        CancelStatementResponse CancelStatement(CancelStatementRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CancelStatement operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelStatement operation on AmazonRedshiftDataAPIServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelStatement
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-data-2019-12-20/CancelStatement">REST API Reference for CancelStatement Operation</seealso>
        IAsyncResult BeginCancelStatement(CancelStatementRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CancelStatement operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelStatement.</param>
        /// 
        /// <returns>Returns a  CancelStatementResult from RedshiftDataAPIService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-data-2019-12-20/CancelStatement">REST API Reference for CancelStatement Operation</seealso>
        CancelStatementResponse EndCancelStatement(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeStatement


        /// <summary>
        /// Describes the details about a specific instance when a query was run by the Amazon
        /// Redshift Data API. The information includes when the query started, when it finished,
        /// the query status, the number of rows returned, and the SQL statement.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStatement service method.</param>
        /// 
        /// <returns>The response from the DescribeStatement service method, as returned by RedshiftDataAPIService.</returns>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.InternalServerException">
        /// The Amazon Redshift Data API operation failed due to invalid input.
        /// </exception>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.ResourceNotFoundException">
        /// The Amazon Redshift Data API operation failed due to a missing resource.
        /// </exception>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.ValidationException">
        /// The Amazon Redshift Data API operation failed due to invalid input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-data-2019-12-20/DescribeStatement">REST API Reference for DescribeStatement Operation</seealso>
        DescribeStatementResponse DescribeStatement(DescribeStatementRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStatement operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStatement operation on AmazonRedshiftDataAPIServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeStatement
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-data-2019-12-20/DescribeStatement">REST API Reference for DescribeStatement Operation</seealso>
        IAsyncResult BeginDescribeStatement(DescribeStatementRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeStatement operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeStatement.</param>
        /// 
        /// <returns>Returns a  DescribeStatementResult from RedshiftDataAPIService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-data-2019-12-20/DescribeStatement">REST API Reference for DescribeStatement Operation</seealso>
        DescribeStatementResponse EndDescribeStatement(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeTable


        /// <summary>
        /// Describes the detailed information about a table from metadata in the cluster. The
        /// information includes its columns. A token is returned to page through the column list.
        /// Depending on the authorization method, use one of the following combinations of request
        /// parameters: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// AWS Secrets Manager - specify the Amazon Resource Name (ARN) of the secret and the
        /// cluster identifier that matches the cluster in the secret. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Temporary credentials - specify the cluster identifier, the database name, and the
        /// database user name. Permission to call the <code>redshift:GetClusterCredentials</code>
        /// operation is required to use this method. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTable service method.</param>
        /// 
        /// <returns>The response from the DescribeTable service method, as returned by RedshiftDataAPIService.</returns>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.InternalServerException">
        /// The Amazon Redshift Data API operation failed due to invalid input.
        /// </exception>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.ValidationException">
        /// The Amazon Redshift Data API operation failed due to invalid input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-data-2019-12-20/DescribeTable">REST API Reference for DescribeTable Operation</seealso>
        DescribeTableResponse DescribeTable(DescribeTableRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTable operation on AmazonRedshiftDataAPIServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTable
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-data-2019-12-20/DescribeTable">REST API Reference for DescribeTable Operation</seealso>
        IAsyncResult BeginDescribeTable(DescribeTableRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTable operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTable.</param>
        /// 
        /// <returns>Returns a  DescribeTableResult from RedshiftDataAPIService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-data-2019-12-20/DescribeTable">REST API Reference for DescribeTable Operation</seealso>
        DescribeTableResponse EndDescribeTable(IAsyncResult asyncResult);

        #endregion
        
        #region  ExecuteStatement


        /// <summary>
        /// Runs an SQL statement, which can be data manipulation language (DML) or data definition
        /// language (DDL). This statement must be a single SQL statement. Depending on the authorization
        /// method, use one of the following combinations of request parameters: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// AWS Secrets Manager - specify the Amazon Resource Name (ARN) of the secret and the
        /// cluster identifier that matches the cluster in the secret. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Temporary credentials - specify the cluster identifier, the database name, and the
        /// database user name. Permission to call the <code>redshift:GetClusterCredentials</code>
        /// operation is required to use this method. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteStatement service method.</param>
        /// 
        /// <returns>The response from the ExecuteStatement service method, as returned by RedshiftDataAPIService.</returns>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.ActiveStatementsExceededException">
        /// The number of active statements exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.ExecuteStatementException">
        /// The SQL statement encountered an environmental error while running.
        /// </exception>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.ValidationException">
        /// The Amazon Redshift Data API operation failed due to invalid input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-data-2019-12-20/ExecuteStatement">REST API Reference for ExecuteStatement Operation</seealso>
        ExecuteStatementResponse ExecuteStatement(ExecuteStatementRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ExecuteStatement operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExecuteStatement operation on AmazonRedshiftDataAPIServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndExecuteStatement
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-data-2019-12-20/ExecuteStatement">REST API Reference for ExecuteStatement Operation</seealso>
        IAsyncResult BeginExecuteStatement(ExecuteStatementRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ExecuteStatement operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExecuteStatement.</param>
        /// 
        /// <returns>Returns a  ExecuteStatementResult from RedshiftDataAPIService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-data-2019-12-20/ExecuteStatement">REST API Reference for ExecuteStatement Operation</seealso>
        ExecuteStatementResponse EndExecuteStatement(IAsyncResult asyncResult);

        #endregion
        
        #region  GetStatementResult


        /// <summary>
        /// Fetches the temporarily cached result of an SQL statement. A token is returned to
        /// page through the statement results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStatementResult service method.</param>
        /// 
        /// <returns>The response from the GetStatementResult service method, as returned by RedshiftDataAPIService.</returns>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.InternalServerException">
        /// The Amazon Redshift Data API operation failed due to invalid input.
        /// </exception>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.ResourceNotFoundException">
        /// The Amazon Redshift Data API operation failed due to a missing resource.
        /// </exception>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.ValidationException">
        /// The Amazon Redshift Data API operation failed due to invalid input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-data-2019-12-20/GetStatementResult">REST API Reference for GetStatementResult Operation</seealso>
        GetStatementResultResponse GetStatementResult(GetStatementResultRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetStatementResult operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetStatementResult operation on AmazonRedshiftDataAPIServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetStatementResult
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-data-2019-12-20/GetStatementResult">REST API Reference for GetStatementResult Operation</seealso>
        IAsyncResult BeginGetStatementResult(GetStatementResultRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetStatementResult operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetStatementResult.</param>
        /// 
        /// <returns>Returns a  GetStatementResultResult from RedshiftDataAPIService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-data-2019-12-20/GetStatementResult">REST API Reference for GetStatementResult Operation</seealso>
        GetStatementResultResponse EndGetStatementResult(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDatabases


        /// <summary>
        /// List the databases in a cluster. A token is returned to page through the database
        /// list. Depending on the authorization method, use one of the following combinations
        /// of request parameters: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// AWS Secrets Manager - specify the Amazon Resource Name (ARN) of the secret and the
        /// cluster identifier that matches the cluster in the secret. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Temporary credentials - specify the cluster identifier, the database name, and the
        /// database user name. Permission to call the <code>redshift:GetClusterCredentials</code>
        /// operation is required to use this method. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDatabases service method.</param>
        /// 
        /// <returns>The response from the ListDatabases service method, as returned by RedshiftDataAPIService.</returns>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.InternalServerException">
        /// The Amazon Redshift Data API operation failed due to invalid input.
        /// </exception>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.ValidationException">
        /// The Amazon Redshift Data API operation failed due to invalid input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-data-2019-12-20/ListDatabases">REST API Reference for ListDatabases Operation</seealso>
        ListDatabasesResponse ListDatabases(ListDatabasesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDatabases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDatabases operation on AmazonRedshiftDataAPIServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDatabases
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-data-2019-12-20/ListDatabases">REST API Reference for ListDatabases Operation</seealso>
        IAsyncResult BeginListDatabases(ListDatabasesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDatabases operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDatabases.</param>
        /// 
        /// <returns>Returns a  ListDatabasesResult from RedshiftDataAPIService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-data-2019-12-20/ListDatabases">REST API Reference for ListDatabases Operation</seealso>
        ListDatabasesResponse EndListDatabases(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSchemas


        /// <summary>
        /// Lists the schemas in a database. A token is returned to page through the schema list.
        /// Depending on the authorization method, use one of the following combinations of request
        /// parameters: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// AWS Secrets Manager - specify the Amazon Resource Name (ARN) of the secret and the
        /// cluster identifier that matches the cluster in the secret. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Temporary credentials - specify the cluster identifier, the database name, and the
        /// database user name. Permission to call the <code>redshift:GetClusterCredentials</code>
        /// operation is required to use this method. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSchemas service method.</param>
        /// 
        /// <returns>The response from the ListSchemas service method, as returned by RedshiftDataAPIService.</returns>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.InternalServerException">
        /// The Amazon Redshift Data API operation failed due to invalid input.
        /// </exception>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.ValidationException">
        /// The Amazon Redshift Data API operation failed due to invalid input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-data-2019-12-20/ListSchemas">REST API Reference for ListSchemas Operation</seealso>
        ListSchemasResponse ListSchemas(ListSchemasRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSchemas operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSchemas operation on AmazonRedshiftDataAPIServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSchemas
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-data-2019-12-20/ListSchemas">REST API Reference for ListSchemas Operation</seealso>
        IAsyncResult BeginListSchemas(ListSchemasRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSchemas operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSchemas.</param>
        /// 
        /// <returns>Returns a  ListSchemasResult from RedshiftDataAPIService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-data-2019-12-20/ListSchemas">REST API Reference for ListSchemas Operation</seealso>
        ListSchemasResponse EndListSchemas(IAsyncResult asyncResult);

        #endregion
        
        #region  ListStatements


        /// <summary>
        /// List of SQL statements. By default, only finished statements are shown. A token is
        /// returned to page through the statement list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStatements service method.</param>
        /// 
        /// <returns>The response from the ListStatements service method, as returned by RedshiftDataAPIService.</returns>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.InternalServerException">
        /// The Amazon Redshift Data API operation failed due to invalid input.
        /// </exception>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.ValidationException">
        /// The Amazon Redshift Data API operation failed due to invalid input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-data-2019-12-20/ListStatements">REST API Reference for ListStatements Operation</seealso>
        ListStatementsResponse ListStatements(ListStatementsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListStatements operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStatements operation on AmazonRedshiftDataAPIServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListStatements
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-data-2019-12-20/ListStatements">REST API Reference for ListStatements Operation</seealso>
        IAsyncResult BeginListStatements(ListStatementsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListStatements operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListStatements.</param>
        /// 
        /// <returns>Returns a  ListStatementsResult from RedshiftDataAPIService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-data-2019-12-20/ListStatements">REST API Reference for ListStatements Operation</seealso>
        ListStatementsResponse EndListStatements(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTables


        /// <summary>
        /// List the tables in a database. If neither <code>SchemaPattern</code> nor <code>TablePattern</code>
        /// are specified, then all tables in the database are returned. A token is returned to
        /// page through the table list. Depending on the authorization method, use one of the
        /// following combinations of request parameters: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// AWS Secrets Manager - specify the Amazon Resource Name (ARN) of the secret and the
        /// cluster identifier that matches the cluster in the secret. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Temporary credentials - specify the cluster identifier, the database name, and the
        /// database user name. Permission to call the <code>redshift:GetClusterCredentials</code>
        /// operation is required to use this method. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTables service method.</param>
        /// 
        /// <returns>The response from the ListTables service method, as returned by RedshiftDataAPIService.</returns>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.InternalServerException">
        /// The Amazon Redshift Data API operation failed due to invalid input.
        /// </exception>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.ValidationException">
        /// The Amazon Redshift Data API operation failed due to invalid input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-data-2019-12-20/ListTables">REST API Reference for ListTables Operation</seealso>
        ListTablesResponse ListTables(ListTablesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTables operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTables operation on AmazonRedshiftDataAPIServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTables
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-data-2019-12-20/ListTables">REST API Reference for ListTables Operation</seealso>
        IAsyncResult BeginListTables(ListTablesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTables operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTables.</param>
        /// 
        /// <returns>Returns a  ListTablesResult from RedshiftDataAPIService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-data-2019-12-20/ListTables">REST API Reference for ListTables Operation</seealso>
        ListTablesResponse EndListTables(IAsyncResult asyncResult);

        #endregion
        
    }
}