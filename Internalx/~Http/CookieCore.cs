using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;

namespace SSL.Net.Http
{
    /// <summary>
    /// It represents a collection of HTTP-cookies.
    /// </summary>
    public class CookieCore
    {
        /// <summary>
        /// <see cref="CookieContainer"/> из .NET Framework.
        /// </summary>
        public CookieContainer Container { get; private set; }
        /// <summary>
        /// Get Count of CookieCore Cookies.
        /// </summary>
        public int Count => Container.Count;

        /// <summary>
        /// Gets or sets a value indicating whether cookies are closed for editing
        /// </summary>
        /// <value>default value — <see langword="false"/>.</value>
        public bool IsLocked { get; set; }

        /// <summary>
        /// Initializes a new instance of the class <see cref="CookieCore"/>.
        /// </summary>
        /// <param name="isLocked">It indicates whether cookies are closed for editing.</param>
        public CookieCore(bool isLocked = false,CookieContainer container=null):base()
        {
            IsLocked = isLocked;
            Container = container ?? new CookieContainer();

        }
        /// <summary>
        /// Add Cookie To CookieCore
        /// </summary>
        /// <param name="cookie">New Cookie you want to add it in CookieCore</param>
        public void Add(Cookie cookie)
        {
            Container.Add(cookie);
        }
        /// <summary>
        /// Add CookieCollection To CookieCore
        /// </summary>
        /// <param name="cookies">New CookieCollection you want to add it in CookieCore</param>
        public void Add(CookieCollection cookies)
        {
            Container.Add(cookies);
        }
        /// <summary>
        /// Add or Edit an Cookie in CookieCore
        /// </summary>
        /// <param name="cookie">New Cookie you want to set it in CookieCore</param>
        public void Set(Cookie cookie)
        {
            if (string.IsNullOrEmpty(cookie.Domain))
            {
                Add(cookie);
                return;
            }
                
            string domain = cookie.Domain[0] == '.' ? cookie.Domain.Substring(1) : cookie.Domain;
            Uri url = new Uri($"{(cookie.Secure ? "https://" : "http://")}{domain}");
            if (Container.GetCookies(url)[cookie.Name]!=null)
            {
                Container.GetCookies(url).Cast<Cookie>().ToList().ForEach(c => c=cookie);
            }
            else
            {
                Add(cookie);
            }
        }

        /// <summary>
        /// Add or Edit an CookieCollection in CookieCore
        /// </summary>
        /// <param name="cookies">New CookieCollection you want to set it in CookieCore</param>
        public void Set(CookieCollection cookies)
        {
            foreach(Cookie cookie in cookies)
            {
                Set(cookie);
            }
            
        }

        /// <inheritdoc cref="Set(Cookie)"/>
        /// <param name="name">Name of Cookie you want to set it in CookieCore</param>
        /// <param name="value">Value of Cookie you want to set it in CookieCore</param>
        /// <param name="domain">Domain of Cookie you want to set it in CookieCore</param>
        /// <param name="path">Path of Cookie you want to set it in CookieCore</param>
        public void Set(string name, string value, string domain, string path = "/")
        {
            var cookie = new Cookie(name, value, path, domain);
            Set(cookie);
        }

        /// <inheritdoc cref="Set(Cookie)"/>
        /// <param name="name">Name of Cookie you want to set it in CookieCore</param>
        /// <param name="value">Value of Cookie you want to set it in CookieCore</param>
        /// <param name="domain">Domain of Cookie (in Uri format) you want to set it in CookieCore</param>
        /// <param name="path">Path of Cookie you want to set it in CookieCore</param>
        public void Set(string name, string value, Uri domain, string path = "/")
        {
            var cookie = new Cookie(name, value, path, domain.Host);
            Set(cookie);
        }

        /// <summary>
        /// Remove Cookie of special Domain
        /// </summary>
        /// <param name="url">URL you want to remove Cookie of it</param>
        public void Remove(string url)
        {
            Remove(new Uri(url));
        }

        /// <inheritdoc cref="Remove(string)"/>
        /// <param name="uri">URL you want to remove Cookie of it</param>
        public void Remove(Uri uri)
        {
            var cookies = Container.GetCookies(uri);
            foreach (Cookie cookie in cookies)
                cookie.Expired = true;
        }

        /// <summary>
        /// Remove Cookie of special Domain with special name
        /// </summary>
        /// <param name="url">URL you want to remove Cookie of it</param>
        /// <param name="name">Cookie Name to remove it</param>
        public void Remove(string url, string name)
        {
            Remove(new Uri(url), name);
        }

        /// <inheritdoc cref="Remove(string, string)"/>
        /// <param name="url">URL you want to remove Cookie of it (in Uri format)</param>
        /// <param name="name">Cookie Name to remove it</param>
        public void Remove(Uri uri, string name)
        {
            var cookies = Container.GetCookies(uri);
            foreach (Cookie cookie in cookies)
            {
                if (cookie.Name == name)
                    cookie.Expired = true;
            }
        }

        /// <summary>
        /// Clear CookieCore Saved Cookie.
        /// </summary>
        public void Clear()
        {
            Container = new CookieContainer();
        }
        /// <summary>
        /// Clear Special Cookie Name from CookieCore.
        /// </summary>
        /// <param name="url">The url of the cookie.</param>
        /// <param name="name">The name of the cookie.</param>
        public void Clear(string url, string name)
        {
            Container.GetCookies(new Uri(url)).Cast<Cookie>().ToList().ForEach(c => c.Expired = true);
        }

        /// <inheritdoc cref="Clear(string, string)"/>
        /// <param name="url">The url of the cookie.</param>
        /// <param name="name">The name of the cookie.</param>
        public void Clear(Uri url,string name)
        {
            Container.GetCookies(url).Cast<Cookie>().ToList().ForEach(c => c.Expired = true);
        }

        /// <summary>
        /// Try to know a Cookie Exist in CookieCore or not.
        /// </summary>
        /// <param name="CookieName">Name of cookie you want to find it in CookieCore</param>
        ///  <returns>True means Yes cookie name exist, No means Cookie dosn'n Exits in CookieCore</returns>
        public bool Contains(string CookieName)
        {
            if (Container.Count <= 0) return false;
            return this.GetAllCookies()[CookieName] != null;
        }

        /// <inheritdoc cref="Contains(string)"/>
        /// <param name="url">The url of the cookie (in Uri format)</param>
        /// <param name="CookieName">Name of cookie you want to find it in CookieCore</param>
        ///  <returns>True means Yes cookie name exist, No means Cookie dosn'n Exits in CookieCore</returns>
        public bool Contains(Uri url, string CookieName)
        {
            if (Container.Count <= 0) return false;
            return Container.GetCookies(url)[CookieName] != null;
        }

        /// <inheritdoc cref="Contains(string)"/>
        /// <param name="url">The url of the cookie</param>
        /// <param name="CookieName">Name of cookie you want to find it in CookieCore</param>
        ///  <returns>True means Yes cookie name exist, No means Cookie dosn'n Exits in CookieCore</returns>
        public bool Contains(string url,string CookieName)
        {
            if(Container.Count<=0) return false;
            return Container.GetCookies(new Uri(url))[CookieName] != null;
        }

        /// <summary>
        /// Get All Cookie in CookieCore
        /// </summary>
        /// <returns>CookieCollection of All Cookie saved in CookieCore</returns>
        public CookieCollection GetAllCookies()
        {
            CookieCollection cookieCollection = new CookieCollection();

            Hashtable DomainTable = (Hashtable)Container.GetType().GetField("m_domainTable",BindingFlags.NonPublic |BindingFlags.GetField |BindingFlags.Instance).GetValue(Container);
            foreach (DictionaryEntry element in DomainTable)
            {
                SortedList DomainList = (SortedList)element.Value.GetType().GetField("m_list", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(element.Value);
                foreach (var e in DomainList)
                {
                    cookieCollection.Add((CookieCollection)((DictionaryEntry)e).Value);
                }
            }
            

            return cookieCollection;
        }

        /// <summary>
        /// Returns a string consisting of the names and cookie values.
        /// </summary>
        /// <returns>A string consisting of the names and values ​​of the cookies.</returns>
        override public string ToString()
        {
            var strBuilder = new StringBuilder();
            foreach (Cookie cookie in this.GetAllCookies())
            {
                strBuilder.AppendFormat("{0}={1}; ", cookie.Name, cookie.Value);
            }

            if (strBuilder.Length > 0)
            {
                strBuilder.Remove(strBuilder.Length - 2, 2);
            }

            return strBuilder.ToString();
        }
    }
}