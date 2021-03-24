using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Tweetinvi;
using Microsoft.VisualBasic;
using System.Resources;
using System.IO;
using Tweetinvi.Parameters;

namespace DashboardCTwitter
{
    public partial class TwitterDashboard : Form
    {
        public TwitterDashboard()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            tweetText.Visible = false;
            imagePreview.Visible = false;
        }

        private void Login_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {


            loginLogo.Enabled = false;
            loginLogo.Visible = false;
            this.BackgroundImage = Properties.Resources.tweetBackground;
            tweetText.Visible = true;
            imagePreview.Visible = true;
            charCount.Visible = true;
            imageSelect.Visible = true;
            tweetButton.Visible = true;

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        { 

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {
        
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void tweetText_TextChanged(object sender, EventArgs e)
        {
            charCount.Text = tweetText.Text.Length + "/280";
        }

       

        private void imageSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                imagePreview.Image = new Bitmap(open.FileName);
                imagePreview.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
    }
}


/* private async void button1_Click_1(object sender, EventArgs e)
        {
            var appClient = new TwitterClient("ECJ7OKhhbJPmqmJWuZP6yN9Z6", "b3BIoNe1cGYqXzxxpOIftI55cLqvAVK5E8GYDZ1D4uwltjxFHN");

            var authenticationRequest = await appClient.Auth.RequestAuthenticationUrlAsync();

            Process.Start(new ProcessStartInfo(authenticationRequest.AuthorizationURL)
            {
                UseShellExecute = true
            });

            Console.WriteLine("Please enter the code and press enter.");
            var pinCode = Interaction.InputBox("Please enter the PIN", "Pin Input");

            var userCredentials = await appClient.Auth.RequestCredentialsFromVerifierCodeAsync(pinCode, authenticationRequest);

            var userClient = new TwitterClient(userCredentials);
            var user = await userClient.Users.GetAuthenticatedUserAsync();

            if (tweetText.Text.Length > 280)
            {
                MessageBox.Show("Your tweet is too long!", "Too Long!");
            }
            else
            {
                var tweet = await userClient.Tweets.PublishTweetAsync(tweetText.Text);
            }
            Console.WriteLine("Congratulation you have authenticated the user: " + user);
        }*/