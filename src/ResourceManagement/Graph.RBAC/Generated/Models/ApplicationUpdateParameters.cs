// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Graph.RBAC.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Request parameters for updating a new application.
    /// </summary>
    public partial class ApplicationUpdateParameters : ApplicationBase
    {
        /// <summary>
        /// Initializes a new instance of the ApplicationUpdateParameters
        /// class.
        /// </summary>
        public ApplicationUpdateParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApplicationUpdateParameters
        /// class.
        /// </summary>
        /// <param name="allowGuestsSignIn">A property on the application to
        /// indicate if the application accepts other IDPs or not or partially
        /// accepts.</param>
        /// <param name="allowPassthroughUsers">Indicates that the application
        /// supports pass through users who have no presence in the resource
        /// tenant.</param>
        /// <param name="appLogoUrl">The url for the application logo image
        /// stored in a CDN.</param>
        /// <param name="appRoles">The collection of application roles that an
        /// application may declare. These roles can be assigned to users,
        /// groups or service principals.</param>
        /// <param name="appPermissions">The application permissions.</param>
        /// <param name="availableToOtherTenants">Whether the application is
        /// available to other tenants.</param>
        /// <param name="errorUrl">A URL provided by the author of the
        /// application to report errors when using the application.</param>
        /// <param name="groupMembershipClaims">Configures the groups claim
        /// issued in a user or OAuth 2.0 access token that the app
        /// expects.</param>
        /// <param name="homepage">The home page of the application.</param>
        /// <param name="informationalUrls">URLs with more information about
        /// the application.</param>
        /// <param name="isDeviceOnlyAuthSupported">Specifies whether this
        /// application supports device authentication without a user. The
        /// default is false.</param>
        /// <param name="keyCredentials">A collection of KeyCredential
        /// objects.</param>
        /// <param name="knownClientApplications">Client applications that are
        /// tied to this resource application. Consent to any of the known
        /// client applications will result in implicit consent to the resource
        /// application through a combined consent dialog (showing the OAuth
        /// permission scopes required by the client and the resource).</param>
        /// <param name="logoutUrl">the url of the logout page</param>
        /// <param name="oauth2AllowImplicitFlow">Whether to allow implicit
        /// grant flow for OAuth2</param>
        /// <param name="oauth2AllowUrlPathMatching">Specifies whether during a
        /// token Request Azure AD will allow path matching of the redirect URI
        /// against the applications collection of replyURLs. The default is
        /// false.</param>
        /// <param name="oauth2Permissions">The collection of OAuth 2.0
        /// permission scopes that the web API (resource) application exposes
        /// to client applications. These permission scopes may be granted to
        /// client applications during consent.</param>
        /// <param name="oauth2RequirePostResponse">Specifies whether, as part
        /// of OAuth 2.0 token requests, Azure AD will allow POST requests, as
        /// opposed to GET requests. The default is false, which specifies that
        /// only GET requests will be allowed.</param>
        /// <param name="orgRestrictions">A list of tenants allowed to access
        /// application.</param>
        /// <param name="passwordCredentials">A collection of
        /// PasswordCredential objects</param>
        /// <param name="preAuthorizedApplications">list of pre-authorized
        /// applications.</param>
        /// <param name="publicClient">Specifies whether this application is a
        /// public client (such as an installed application running on a mobile
        /// device). Default is false.</param>
        /// <param name="publisherDomain">Reliable domain which can be used to
        /// identify an application.</param>
        /// <param name="replyUrls">A collection of reply URLs for the
        /// application.</param>
        /// <param name="requiredResourceAccess">Specifies resources that this
        /// application requires access to and the set of OAuth permission
        /// scopes and application roles that it needs under each of those
        /// resources. This pre-configuration of required resource access
        /// drives the consent experience.</param>
        /// <param name="samlMetadataUrl">The URL to the SAML metadata for the
        /// application.</param>
        /// <param name="signInAudience">Audience for signing in to the
        /// application (AzureADMyOrganization, AzureADAllOrganizations,
        /// AzureADAndMicrosoftAccounts).</param>
        /// <param name="wwwHomepage">The primary Web page.</param>
        /// <param name="displayName">The display name of the
        /// application.</param>
        /// <param name="identifierUris">A collection of URIs for the
        /// application.</param>
        public ApplicationUpdateParameters(bool? allowGuestsSignIn = default(bool?), bool? allowPassthroughUsers = default(bool?), string appLogoUrl = default(string), IList<AppRole> appRoles = default(IList<AppRole>), IList<string> appPermissions = default(IList<string>), bool? availableToOtherTenants = default(bool?), string errorUrl = default(string), object groupMembershipClaims = default(object), string homepage = default(string), InformationalUrl informationalUrls = default(InformationalUrl), bool? isDeviceOnlyAuthSupported = default(bool?), IList<KeyCredential> keyCredentials = default(IList<KeyCredential>), IList<string> knownClientApplications = default(IList<string>), string logoutUrl = default(string), bool? oauth2AllowImplicitFlow = default(bool?), bool? oauth2AllowUrlPathMatching = default(bool?), IList<OAuth2Permission> oauth2Permissions = default(IList<OAuth2Permission>), bool? oauth2RequirePostResponse = default(bool?), IList<string> orgRestrictions = default(IList<string>), OptionalClaims optionalClaims = default(OptionalClaims), IList<PasswordCredential> passwordCredentials = default(IList<PasswordCredential>), IList<PreAuthorizedApplication> preAuthorizedApplications = default(IList<PreAuthorizedApplication>), bool? publicClient = default(bool?), string publisherDomain = default(string), IList<string> replyUrls = default(IList<string>), IList<RequiredResourceAccess> requiredResourceAccess = default(IList<RequiredResourceAccess>), string samlMetadataUrl = default(string), string signInAudience = default(string), string wwwHomepage = default(string), string displayName = default(string), IList<string> identifierUris = default(IList<string>))
            : base(allowGuestsSignIn, allowPassthroughUsers, appLogoUrl, appRoles, appPermissions, availableToOtherTenants, errorUrl, groupMembershipClaims, homepage, informationalUrls, isDeviceOnlyAuthSupported, keyCredentials, knownClientApplications, logoutUrl, oauth2AllowImplicitFlow, oauth2AllowUrlPathMatching, oauth2Permissions, oauth2RequirePostResponse, orgRestrictions, optionalClaims, passwordCredentials, preAuthorizedApplications, publicClient, publisherDomain, replyUrls, requiredResourceAccess, samlMetadataUrl, signInAudience, wwwHomepage)
        {
            DisplayName = displayName;
            IdentifierUris = identifierUris;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the display name of the application.
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets a collection of URIs for the application.
        /// </summary>
        [JsonProperty(PropertyName = "identifierUris")]
        public IList<string> IdentifierUris { get; set; }

    }
}
