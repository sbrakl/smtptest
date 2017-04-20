using System;
using System.Configuration;
using System.Drawing;
using System.Net.Configuration;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmtpTester
{
	public partial class SmtpTester : Form
	{
		SmtpTesterClient smtpClient = new SmtpTesterClient();
		bool IsErrorCondition { get; set; }

        //Timer stuff
        private Timer _timer;
        private DateTime _startTime = new DateTime();
        private TimeSpan _elapsedTime = new TimeSpan();

        public SmtpTester()
		{
			InitializeComponent();

			smtpClient.LogOutput += AppendOutput;
			smtpClient.ResponseReceived += SetErrorDisplay;
		}

		protected void SmtpTester_Load(object sender, EventArgs e)
		{
            _timer = new Timer();
            _timer.Interval = 100;
            _timer.Tick += new EventHandler(_timer_Tick);

            //Comment, as we are not using Configuration setting. We are getting at runtime
            //using (var client = new SmtpClient())
            //using (var msg = new MailMessage())
            //{
            //	var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //	var mailSettings = config.GetSectionGroup("system.net/mailSettings") as MailSettingsSectionGroup;

            //	txtServer.Text = client.Host;
            //	txtPort.Text = client.Port.ToString();
            //	chkEnableTLS.Checked = client.EnableSsl;
            //	txtUsername.Text = (mailSettings != null) ? mailSettings.Smtp.Network.UserName : String.Empty;
            //	txtPassword.Text = (mailSettings != null) ? mailSettings.Smtp.Network.Password : String.Empty;
            //	chkDefaultCredentials.Checked = client.UseDefaultCredentials;
            //	txtFrom.Text = (msg.From != null) ? msg.From.Address : String.Empty;
            //}
        }

		protected async void btnTestConnection_Click(object sender, EventArgs e)
		{
			try
			{
				var server = txtServer.Text;
				var port = Convert.ToInt32(txtPort.Text);

				AppendOutput("\nInitiating connection...");
				ClearErrorDisplay();
				ShowLoading(true);

				await smtpClient.TestConnection(server, port, chkEnableTLS.Checked);
			}
			catch (Exception ex)
			{
				AppendOutput(GetErrorString(ex));
				SetErrorDisplay(true);
			}
			finally
			{
				ShowLoading(false);
			}
		}

		protected async void btnTestEmail_Click(object sender, EventArgs e)
		{
			try
			{
				ClearErrorDisplay();
				ShowLoading(true);

                StmpMessageDTO msgParams = new StmpMessageDTO();
                msgParams.to = txtTo.Text.Trim();
                msgParams.cc = txtCC.Text.Trim();
                msgParams.bcc = txtBCC.Text.Trim();
                msgParams.subject = txtSubject.Text.Trim();
                msgParams.body = txtBody.Text.Trim();
                msgParams.FromEmail = txtFrom.Text.Trim();

                StmpSettingDTO smtpSetting = new StmpSettingDTO();                
                smtpSetting.SMTPHost = txtServer.Text.Trim();
                smtpSetting.SMTPPort = Convert.ToInt32(txtPort.Text.Trim());
                smtpSetting.username = txtUsername.Text.Trim();
                smtpSetting.password = txtPassword.Text.Trim();
                smtpSetting.IsAuthRequired = chkUserAuthentication.Checked;
                smtpSetting.enableSSL = chkEnableSSL.Checked;
                smtpSetting.Timeout = Convert.ToInt32(txtTimer.Text) * 1000;

                await Task.Factory.StartNew( () => smtpClient.TestEmail(msgParams, smtpSetting), TaskCreationOptions.LongRunning);

				AppendOutput(String.Format("Message sent to {0} {1} {2}.", msgParams.to, msgParams.cc, msgParams.bcc));
				SetErrorDisplay(false);
			}
			catch (Exception ex)
			{
				AppendOutput(GetErrorString(ex));
				SetErrorDisplay(true);
			}
			finally
			{
				ShowLoading(false);
			}
		}

		#region Utility Methods

		protected string GetErrorString(Exception ex)
		{
			StringBuilder sbErrorString = new StringBuilder();

			sbErrorString.AppendLine(ex.Message);
			
			if (ex.InnerException != null)
			{
				sbErrorString.AppendLine(GetErrorString(ex.InnerException));
			}

			return sbErrorString.ToString();
		}

		#endregion Utility Methods

		#region UI Methods

		protected delegate void AppendOutputDelegate(string text);
		protected void AppendOutput(string text)
		{
			if (txtOutput.InvokeRequired)
			{
				txtOutput.Invoke(new AppendOutputDelegate(AppendOutput), text);
				return;
			}

			txtOutput.AppendText(String.Concat(text, System.Environment.NewLine));
		}

		protected delegate void SetErrorDisplayDelegate(bool isError);
		protected void SetErrorDisplay(bool isError)
		{
			if (txtOutput.InvokeRequired)
			{
				txtOutput.Invoke(new SetErrorDisplayDelegate(SetErrorDisplay), isError);
				return;
			}

            _timer.Stop();
			IsErrorCondition |= isError;
			txtOutput.BackColor = IsErrorCondition ? Color.Pink : Color.LightGreen;
		}

		protected void ClearErrorDisplay()
		{
			if (txtOutput.InvokeRequired)
			{
				txtOutput.Invoke(new MethodInvoker(ClearErrorDisplay));
				return;
			}

			IsErrorCondition = false;
			txtOutput.BackColor = System.Drawing.SystemColors.Window;
		}

		protected delegate void ShowLoadingDelegate(bool show);
		protected void ShowLoading(bool show)
		{
			if (InvokeRequired)
			{
				Invoke(new ShowLoadingDelegate(ShowLoading), show);
				return;
			}

            if (show)
            {
                //Show the time and start
                _startTime = DateTime.Now;
                _timer.Start();
            }
            else
            {
                _timer.Stop();
            }

            pbLoading.Visible = show;

			foreach (Control ctrl in Controls)
			{
				if (ctrl is Button)
				{
					ctrl.Enabled = !show;
				}
			}
		}

        private void btn_ClearLogs_Click(object sender, EventArgs e)
        {
            ClearErrorDisplay();
            txtOutput.Clear();
        }
        #endregion UI Methods

        #region Timer Region
        void _timer_Tick(object sender, EventArgs e)
        {
            _elapsedTime = DateTime.Now - _startTime;
            lblTimer.Text = _elapsedTime.ToString(@"hh\:mm\:ss\.fff");
        }
        #endregion

        private void txtSubject_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtBody_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSubject_Click(object sender, EventArgs e)
        {

        }

        private void lblBody_Click(object sender, EventArgs e)
        {

        }

        private void txtBCC_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblBCC_Click(object sender, EventArgs e)
        {

        }

        private void txtCC_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCC_Click(object sender, EventArgs e)
        {

        }

        private void txtTo_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTo_Click(object sender, EventArgs e)
        {

        }

        private void txtFrom_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblFrom_Click(object sender, EventArgs e)
        {

        }

        private void cmb_preconfig_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_preconfig.Text == "localhost")
            {
                txtServer.Text = "localhost";
                txtPort.Text = "25";
                txtUsername.Text = "";
                txtPassword.Text = "";
                chkUserAuthentication.Checked = false;
            }
            else if (cmb_preconfig.Text == "sendpulse")
            {
                txtServer.Text = "smtp-pulse.com";
                txtPort.Text = "2525";
                txtUsername.Text = "sbrakl@gmail.com";
                txtPassword.Text = "";
                chkUserAuthentication.Checked = true;
            }
            else if (cmb_preconfig.Text == "smtp2go")
            {
                txtServer.Text = "mail.smtp2go.com";
                txtPort.Text = "587";
                txtUsername.Text = "sbrakl@gmail.com";
                txtPassword.Text = "";
                chkUserAuthentication.Checked = true;
            }
        }
    }
}
