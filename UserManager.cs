using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Tweetinvi;
using Microsoft.VisualBasic;
using System.Resources;
using Tweetinvi.Models;

namespace DashboardCTwitter
{
    class UserManager
    {
        private static TwitterClient appClient = null;
        private static IAuthenticationRequest authenticationRequest = null;
        private static String pinCode = null;
        private static ITwitterCredentials userCredentials = null;
        private static TwitterClient userClient = null;
        private static IAuthenticatedUser user = null;

        public void setAppClient()
        {
            appClient = new TwitterClient("ECJ7OKhhbJPmqmJWuZP6yN9Z6", "b3BIoNe1cGYqXzxxpOIftI55cLqvAVK5E8GYDZ1D4uwltjxFHN");
        }

        public async void setAuthenticationRequest()
        {
            authenticationRequest = await appClient.Auth.RequestAuthenticationUrlAsync();
            Process.Start(new ProcessStartInfo(authenticationRequest.AuthorizationURL)
            {
                UseShellExecute = true
            });
        }

        public void setPinCode()
        {
            pinCode = Interaction.InputBox("Please enter the PIN", "Pin Input"); 
        }

        public async void setUserCredentials()
        {
            userCredentials = await appClient.Auth.RequestCredentialsFromVerifierCodeAsync(getPinCode(), getAuthenticationRequest());
        }
        public void setUserClient()
        {
            userClient = new TwitterClient(userCredentials);
        }

        public async void setUser()
        {
           user = await userClient.Users.GetAuthenticatedUserAsync();
        }

        public TwitterClient getAppClient()
        {
            return appClient;
        }

        public IAuthenticationRequest getAuthenticationRequest()
        {
            return authenticationRequest;
        }

        public String getPinCode()
        {
            return pinCode;
        }
        public ITwitterCredentials getUserCredentials()
        {
            return userCredentials;
        }

        public TwitterClient getUserClient()
        {
            return userClient;
        }

        public IAuthenticatedUser getUser()
        {
            return user;
        }

    }
}

