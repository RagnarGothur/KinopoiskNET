using RestSharp;
using RestSharp.Authenticators;

using System;

namespace KinopoiskNET.ApiClient
{
    internal class TokenBasedAuthenticator : IAuthenticator
    {
        private string _token;

        internal TokenBasedAuthenticator(string token)
        {
            _token = token ?? throw new ArgumentNullException(nameof(token));
        }

        public void Authenticate(IRestClient client, IRestRequest request)
        {
            request.Resource += $"/token/{_token}";
        }
    }
}
