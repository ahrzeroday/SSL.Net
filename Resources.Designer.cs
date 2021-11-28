﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SSL.Net {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SSL.Net.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The stream does not support reading or move positions..
        /// </summary>
        internal static string ArgumentException_CanNotReadOrSeek {
            get {
                return ResourceManager.GetString("ArgumentException_CanNotReadOrSeek", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value can not be zero-length string..
        /// </summary>
        internal static string ArgumentException_EmptyString {
            get {
                return ResourceManager.GetString("ArgumentException_EmptyString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value of the header &apos;{0}&apos; can only be set with the help of special properties..
        /// </summary>
        internal static string ArgumentException_HttpRequest_SetNotAvailableHeader {
            get {
                return ResourceManager.GetString("ArgumentException_HttpRequest_SetNotAvailableHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The initial range of the index can not be greater than the end index..
        /// </summary>
        internal static string ArgumentException_MultiThreading_BegIndexRangeMoreEndIndex {
            get {
                return ResourceManager.GetString("ArgumentException_MultiThreading_BegIndexRangeMoreEndIndex", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Acceptable use only the absolute URI..
        /// </summary>
        internal static string ArgumentException_OnlyAbsoluteUri {
            get {
                return ResourceManager.GetString("ArgumentException_OnlyAbsoluteUri", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The path is an empty string, contains only white space, or contains invalid characters..
        /// </summary>
        internal static string ArgumentException_WrongPath {
            get {
                return ResourceManager.GetString("ArgumentException_WrongPath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value can not be more than {0}..
        /// </summary>
        internal static string ArgumentOutOfRangeException_CanNotBeGreater {
            get {
                return ResourceManager.GetString("ArgumentOutOfRangeException_CanNotBeGreater", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value can not be less than {0}..
        /// </summary>
        internal static string ArgumentOutOfRangeException_CanNotBeLess {
            get {
                return ResourceManager.GetString("ArgumentOutOfRangeException_CanNotBeLess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value can not be less than {0} or {1} longer..
        /// </summary>
        internal static string ArgumentOutOfRangeException_CanNotBeLessOrGreater {
            get {
                return ResourceManager.GetString("ArgumentOutOfRangeException_CanNotBeLessOrGreater", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The starting position can not be more than the length of the line..
        /// </summary>
        internal static string ArgumentOutOfRangeException_StringHelper_MoreLengthString {
            get {
                return ResourceManager.GetString("ArgumentOutOfRangeException_StringHelper_MoreLengthString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to line length must not be more than {0} characters..
        /// </summary>
        internal static string ArgumentOutOfRangeException_StringLengthCanNotBeMore {
            get {
                return ResourceManager.GetString("ArgumentOutOfRangeException_StringLengthCanNotBeMore", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The path points to a nonexistent directory {0}..
        /// </summary>
        internal static string DirectoryNotFoundException_DirectoryNotFound {
            get {
                return ResourceManager.GetString("DirectoryNotFoundException_DirectoryNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid port specified..
        /// </summary>
        internal static string FormatException_ProxyClient_WrongPort {
            get {
                return ResourceManager.GetString("FormatException_ProxyClient_WrongPort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The error on the client side. Status code: {0}.
        /// </summary>
        internal static string HttpException_ClientError {
            get {
                return ResourceManager.GetString("HttpException_ClientError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to It turned out wait for a connection to the HTTP-server &apos;{0}&apos;..
        /// </summary>
        internal static string HttpException_ConnectTimeout {
            get {
                return ResourceManager.GetString("HttpException_ConnectTimeout", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred while working with the HTTP-report..
        /// </summary>
        internal static string HttpException_Default {
            get {
                return ResourceManager.GetString("HttpException_Default", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to connect to the HTTP-server &apos;{0}&apos;..
        /// </summary>
        internal static string HttpException_FailedConnect {
            get {
                return ResourceManager.GetString("HttpException_FailedConnect", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to get the host IP-address &apos;{0}&apos;..
        /// </summary>
        internal static string HttpException_FailedGetHostAddresses {
            get {
                return ResourceManager.GetString("HttpException_FailedGetHostAddresses", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not load the message body of the response HTTP-server &apos;{0}&apos;..
        /// </summary>
        internal static string HttpException_FailedReceiveMessageBody {
            get {
                return ResourceManager.GetString("HttpException_FailedReceiveMessageBody", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to load the response from the HTTP-server &apos;{0}&apos;..
        /// </summary>
        internal static string HttpException_FailedReceiveResponse {
            get {
                return ResourceManager.GetString("HttpException_FailedReceiveResponse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to send HTTP-request to the server &apos;{0}&apos;..
        /// </summary>
        internal static string HttpException_FailedSendRequest {
            get {
                return ResourceManager.GetString("HttpException_FailedSendRequest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to establish SSL-connection with HTTP-server &apos;{0}&apos;..
        /// </summary>
        internal static string HttpException_FailedSslConnect {
            get {
                return ResourceManager.GetString("HttpException_FailedSslConnect", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Have exceeded the maximum number of consecutive redirects..
        /// </summary>
        internal static string HttpException_LimitRedirections {
            get {
                return ResourceManager.GetString("HttpException_LimitRedirections", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Received empty response from the HTTP-server &apos;{0}&apos;..
        /// </summary>
        internal static string HttpException_ReceivedEmptyResponse {
            get {
                return ResourceManager.GetString("HttpException_ReceivedEmptyResponse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Received an invalid response from the HTTP-server &apos;{0}&apos;..
        /// </summary>
        internal static string HttpException_ReceivedWrongResponse {
            get {
                return ResourceManager.GetString("HttpException_ReceivedWrongResponse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The error on the server side. Status code: {0}.
        /// </summary>
        internal static string HttpException_SeverError {
            get {
                return ResourceManager.GetString("HttpException_SeverError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to It turned out the wait time data from the HTTP-server &apos;{0}&apos;..
        /// </summary>
        internal static string HttpException_WaitDataTimeout {
            get {
                return ResourceManager.GetString("HttpException_WaitDataTimeout", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Received invalid data block size when using Chunked: {0}.
        /// </summary>
        internal static string HttpException_WrongChunkedBlockLength {
            get {
                return ResourceManager.GetString("HttpException_WrongChunkedBlockLength", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Received invalid cookies &apos;{0}&apos; from the HTTP-server &apos;{1}&apos;..
        /// </summary>
        internal static string HttpException_WrongCookie {
            get {
                return ResourceManager.GetString("HttpException_WrongCookie", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Received invalid header &quot;{0} &apos;from the HTTP-server&apos; {1} &apos;..
        /// </summary>
        internal static string HttpException_WrongHeader {
            get {
                return ResourceManager.GetString("HttpException_WrongHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do not set any proxy for the chain..
        /// </summary>
        internal static string InvalidOperationException_ChainProxyClient_NotProxies {
            get {
                return ResourceManager.GetString("InvalidOperationException_ChainProxyClient_NotProxies", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to perform the method, because an error occurred while receiving a response..
        /// </summary>
        internal static string InvalidOperationException_HttpResponse_HasError {
            get {
                return ResourceManager.GetString("InvalidOperationException_HttpResponse_HasError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Received an unsupported encoding format: {0}.
        /// </summary>
        internal static string InvalidOperationException_NotSupportedEncodingFormat {
            get {
                return ResourceManager.GetString("InvalidOperationException_NotSupportedEncodingFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The host may be uncertain or have zero length..
        /// </summary>
        internal static string InvalidOperationException_ProxyClient_WrongHost {
            get {
                return ResourceManager.GetString("InvalidOperationException_ProxyClient_WrongHost", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The password can not be more than 255 characters..
        /// </summary>
        internal static string InvalidOperationException_ProxyClient_WrongPassword {
            get {
                return ResourceManager.GetString("InvalidOperationException_ProxyClient_WrongPassword", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The password can not be more than 255 characters..
        /// </summary>
        internal static string InvalidOperationException_ProxyClient_WrongPort {
            get {
                return ResourceManager.GetString("InvalidOperationException_ProxyClient_WrongPort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User name can not be more than 255 characters..
        /// </summary>
        internal static string InvalidOperationException_ProxyClient_WrongUsername {
            get {
                return ResourceManager.GetString("InvalidOperationException_ProxyClient_WrongUsername", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred while working with the network..
        /// </summary>
        internal static string NetworkEx_Default {
            get {
                return ResourceManager.GetString("NetworkEx_Default", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} The proxy server &apos;{1}&apos;..
        /// </summary>
        internal static string ProxyException_CommandError {
            get {
                return ResourceManager.GetString("ProxyException_CommandError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to It turned out the wait time to connect to the proxy server &apos;{0}&apos;..
        /// </summary>
        internal static string ProxyException_ConnectTimeout {
            get {
                return ResourceManager.GetString("ProxyException_ConnectTimeout", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred while working with the proxy..
        /// </summary>
        internal static string ProxyException_Default {
            get {
                return ResourceManager.GetString("ProxyException_Default", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred while working with the proxy server &apos;{0}&apos;..
        /// </summary>
        internal static string ProxyException_Error {
            get {
                return ResourceManager.GetString("ProxyException_Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to connect to the proxy server &apos;{0}&apos;..
        /// </summary>
        internal static string ProxyException_FailedConnect {
            get {
                return ResourceManager.GetString("ProxyException_FailedConnect", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to get the host IP-address &apos;{0}&apos;..
        /// </summary>
        internal static string ProxyException_FailedGetHostAddresses {
            get {
                return ResourceManager.GetString("ProxyException_FailedGetHostAddresses", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The host &apos;{0}&apos; type &apos;{1}&apos; does not support the type Adresse. The following types: InterNetwork and InterNetworkV6. The proxy server &apos;{2}&apos;..
        /// </summary>
        internal static string ProxyException_NotSupportedAddressType {
            get {
                return ResourceManager.GetString("ProxyException_NotSupportedAddressType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Received empty response from the proxy server &apos;{0}&apos;..
        /// </summary>
        internal static string ProxyException_ReceivedEmptyResponse {
            get {
                return ResourceManager.GetString("ProxyException_ReceivedEmptyResponse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Received an invalid response from the proxy server &apos;{0}&apos;..
        /// </summary>
        internal static string ProxyException_ReceivedWrongResponse {
            get {
                return ResourceManager.GetString("ProxyException_ReceivedWrongResponse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Received invalid status code &apos;{0}&apos; on &apos;{1}&apos; proxy..
        /// </summary>
        internal static string ProxyException_ReceivedWrongStatusCode {
            get {
                return ResourceManager.GetString("ProxyException_ReceivedWrongStatusCode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to authenticate with the proxy server &apos;{0}&apos;..
        /// </summary>
        internal static string ProxyException_Socks5_FailedAuthOn {
            get {
                return ResourceManager.GetString("ProxyException_Socks5_FailedAuthOn", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to It turned out the wait time data from the proxy server &apos;{0}&apos;..
        /// </summary>
        internal static string ProxyException_WaitDataTimeout {
            get {
                return ResourceManager.GetString("ProxyException_WaitDataTimeout", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown error..
        /// </summary>
        internal static string Socks_UnknownError {
            get {
                return ResourceManager.GetString("Socks_UnknownError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The request failed, because things are not running identd (or not available from the server)..
        /// </summary>
        internal static string Socks4_CommandReplyRequestRejectedCannotConnectToIdentd {
            get {
                return ResourceManager.GetString("Socks4_CommandReplyRequestRejectedCannotConnectToIdentd", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The request failed because client&apos;s identd could not confirm the user ID in the query..
        /// </summary>
        internal static string Socks4_CommandReplyRequestRejectedDifferentIdentd {
            get {
                return ResourceManager.GetString("Socks4_CommandReplyRequestRejectedDifferentIdentd", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Query rejected or erroneous..
        /// </summary>
        internal static string Socks4_CommandReplyRequestRejectedOrFailed {
            get {
                return ResourceManager.GetString("Socks4_CommandReplyRequestRejectedOrFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The proposed authentication methods are supported..
        /// </summary>
        internal static string Socks5_AuthMethodReplyNoAcceptableMethods {
            get {
                return ResourceManager.GetString("Socks5_AuthMethodReplyNoAcceptableMethods", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Address type not supported..
        /// </summary>
        internal static string Socks5_CommandReplyAddressTypeNotSupported {
            get {
                return ResourceManager.GetString("Socks5_CommandReplyAddressTypeNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The command is not supported or protocol error..
        /// </summary>
        internal static string Socks5_CommandReplyCommandNotSupported {
            get {
                return ResourceManager.GetString("Socks5_CommandReplyCommandNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connecting a set of rules is prohibited..
        /// </summary>
        internal static string Socks5_CommandReplyConnectionNotAllowedByRuleset {
            get {
                return ResourceManager.GetString("Socks5_CommandReplyConnectionNotAllowedByRuleset", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connection refused..
        /// </summary>
        internal static string Socks5_CommandReplyConnectionRefused {
            get {
                return ResourceManager.GetString("Socks5_CommandReplyConnectionRefused", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error SOCKS-server..
        /// </summary>
        internal static string Socks5_CommandReplyGeneralSocksServerFailure {
            get {
                return ResourceManager.GetString("Socks5_CommandReplyGeneralSocksServerFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Host unreachable..
        /// </summary>
        internal static string Socks5_CommandReplyHostUnreachable {
            get {
                return ResourceManager.GetString("Socks5_CommandReplyHostUnreachable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The network is not available..
        /// </summary>
        internal static string Socks5_CommandReplyNetworkUnreachable {
            get {
                return ResourceManager.GetString("Socks5_CommandReplyNetworkUnreachable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expired TTL..
        /// </summary>
        internal static string Socks5_CommandReplyTTLExpired {
            get {
                return ResourceManager.GetString("Socks5_CommandReplyTTLExpired", resourceCulture);
            }
        }
    }
}
