// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Graph.RBAC.Fluent
{
    using Microsoft.Azure.Management.ResourceManager;
    using Microsoft.Azure.Management.ResourceManager.Fluent;
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class AuthorizationManagementClient : Management.ResourceManager.Fluent.Core.FluentServiceClientBase<AuthorizationManagementClient>, IAuthorizationManagementClient, IAzureClient
    {
        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        public JsonSerializerSettings SerializationSettings { get; private set; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        public JsonSerializerSettings DeserializationSettings { get; private set; }

        /// <summary>
        /// The ID of the target subscription.
        /// </summary>
        public string SubscriptionId { get; set; }

        /// <summary>
        /// The preferred language for the response.
        /// </summary>
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// The retry timeout in seconds for Long Running Operations. Default value is
        /// 30.
        /// </summary>
        public int? LongRunningOperationRetryTimeout { get; set; }

        /// <summary>
        /// Whether a unique x-ms-client-request-id should be generated. When set to
        /// true a unique x-ms-client-request-id value is generated and included in
        /// each request. Default is true.
        /// </summary>
        public bool? GenerateClientRequestId { get; set; }

        /// <summary>
        /// Gets the IClassicAdministratorsOperations.
        /// </summary>
        public virtual IClassicAdministratorsOperations ClassicAdministrators { get; private set; }

        /// <summary>
        /// Gets the IGlobalAdministratorOperations.
        /// </summary>
        public virtual IGlobalAdministratorOperations GlobalAdministrator { get; private set; }

        /// <summary>
        /// Gets the IProviderOperationsMetadataOperations.
        /// </summary>
        public virtual IProviderOperationsMetadataOperations ProviderOperationsMetadata { get; private set; }

        /// <summary>
        /// Gets the IRoleAssignmentsOperations.
        /// </summary>
        public virtual IRoleAssignmentsOperations RoleAssignments { get; private set; }

        /// <summary>
        /// Gets the IPermissionsOperations.
        /// </summary>
        public virtual IPermissionsOperations Permissions { get; private set; }

        /// <summary>
        /// Gets the IRoleDefinitionsOperations.
        /// </summary>
        public virtual IRoleDefinitionsOperations RoleDefinitions { get; private set; }

        /// <summary>
        /// Gets the IDenyAssignmentsOperations.
        /// </summary>
        public virtual IDenyAssignmentsOperations DenyAssignments { get; private set; }

        /// <summary>
        /// Initializes a new instance of the AuthorizationManagementClient class.
        /// </summary>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public AuthorizationManagementClient(RestClient restClient) : base(restClient)
        {
        }

        /// <summary>
        /// An optional partial-method to perform custom initialization.
        /// </summary>
        partial void CustomInitialize();
        /// <summary>
        /// Initializes client properties.
        /// </summary>
        protected override void Initialize()
        {
            ClassicAdministrators = new ClassicAdministratorsOperations(this);
            GlobalAdministrator = new GlobalAdministratorOperations(this);
            ProviderOperationsMetadata = new ProviderOperationsMetadataOperations(this);
            RoleAssignments = new RoleAssignmentsOperations(this);
            Permissions = new PermissionsOperations(this);
            RoleDefinitions = new RoleDefinitionsOperations(this);
            DenyAssignments = new DenyAssignmentsOperations(this);
            this.BaseUri = new System.Uri("https://management.azure.com");
            AcceptLanguage = "en-US";
            LongRunningOperationRetryTimeout = 30;
            GenerateClientRequestId = true;
            SerializationSettings = new JsonSerializerSettings
            {
                Formatting = Newtonsoft.Json.Formatting.Indented,
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            SerializationSettings.Converters.Add(new TransformationJsonConverter());
            DeserializationSettings = new JsonSerializerSettings
            {
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            CustomInitialize();
            DeserializationSettings.Converters.Add(new TransformationJsonConverter());
            DeserializationSettings.Converters.Add(new CloudErrorJsonConverter());
        }
    }
}
