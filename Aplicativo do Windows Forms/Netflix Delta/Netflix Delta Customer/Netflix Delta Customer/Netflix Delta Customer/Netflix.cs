using System;
using System.Windows.Forms;
using iMacros.Component;
using iMacros.Component.EventHelpers;
using System.Security.Permissions;
using System.Text;

namespace Netflix_Delta_Customer
{
    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
    public partial class Netflix : Form
    {
        public Netflix()
        {
            string licenseKey = @"CMPNTJJH3W";
            InitializeComponent();
            iim = iMacrosControl.Create(licenseKey);
            iim.Dock = DockStyle.Fill;
            iim.BrowserStatusUpdated += iim_BrowserStatusUpdated;
            browserPane.Controls.Add(iim);
        }

        private iMacrosControl iim;

        private void Netflix_Load(object sender, EventArgs e)
        {
            StringBuilder macro = new StringBuilder();
            macro.AppendLine(@"VERSION BUILD=8970419 RECORDER=FX");
            macro.AppendLine(@"SET !ERRORIGNORE YES");
            macro.AppendLine(@"TAB T=1");
            macro.AppendLine(@"URL GOTO=https://dvd.netflix.com/SignIn");
            macro.AppendLine(@"TAG POS=1 TYPE=INPUT:EMAIL FORM=ACTION:https://dvd.netflix.com/Login ATTR=ID:email CONTENT=jc_pexe_@hotmail.com");
            macro.AppendLine(@"SET !ENCRYPTION NO");
            macro.AppendLine(@"TAG POS=1 TYPE=INPUT:PASSWORD FORM=ACTION:https://dvd.netflix.com/Login ATTR=ID:password CONTENT=galaxy5");
            macro.AppendLine(@"TAG POS=1 TYPE=BUTTON FORM=ACTION:https://dvd.netflix.com/Login ATTR=TXT:Sign<SP>In");
            macro.AppendLine(@"TAG POS=1 TYPE=INPUT:SUBMIT FORM=ACTION:http://www.netflix.com ATTR=*");
            macro.AppendLine(@"URL GOTO=https://www.netflix.com/browse");

            string macroCode = "CODE:" + macro.ToString();
            PlayMacro(macroCode);
        }
        #region iMacros specific event handlers

        private void iim_MasterPasswordRequested(object sender, MasterPasswordEventArgs e)
        {
            e.MasterPassword = "other";
        }

        private void iim_BrowserStatusUpdated(object sender, EventArgs e)
        {
            
        }

        private void iim_PlayerStatusUpdated(object sender, EventArgs e)
        {
            
        }

        private void iim_iMacrosError(object sender, EventArgs e)
        {
          
        }

        private void iim_BrowserResize(object sender, BrowserResizeEventArgs e)
        {
            var oldSize = iim.Size;
            if (oldSize != e.Size)
            {
                Width += e.Size.Width - oldSize.Width;
                Height += e.Size.Height - oldSize.Height;
            }
            Application.DoEvents();
        }

        private void iim_Prompt(object sender, PromptEventArgs e)
        {
            if (!e.NeedsInput)
                MessageBox.Show(e.Message);
            else
            {
               var result = MessageBox.Show(e.Message, "TestComponent", MessageBoxButtons.YesNo);
                e.Value = result.ToString();
                e.Handled = true;
            }
        }

        #endregion

         #region Control iMacros

        private void PlayMacro(string macro)
        {

            if (iim == null)
                return;

            if (iim.PlayerMode != PlaybackModes.Idle)
                return;
           iim.PlayerStatusUpdated += iim_PlayerStatusUpdated;
            iim.MacroErrorOccurred += iim_iMacrosError;
            iim.MasterPasswordRequested += iim_MasterPasswordRequested;
            iim.Prompt += iim_Prompt;
            iim.BrowserResize += iim_BrowserResize;

           int res = iim.Play(macro);

           iim.PlayerStatusUpdated -= iim_PlayerStatusUpdated;
            iim.MacroErrorOccurred -= iim_iMacrosError;
            iim.MasterPasswordRequested -= iim_MasterPasswordRequested;
            iim.Prompt -= iim_Prompt;
            iim.BrowserResize -= iim_BrowserResize;

            if (res == -99) return; 

             string extract = iim.ExtractedValues.Count > 0 ?
                String.Join("[sep]", iim.ExtractedValues.ToArray()) :
                String.Empty;

            string label = null;
            TimeSpan elapsedTime = TimeSpan.Zero;
            iim.GetPerformanceData(0, out label, out elapsedTime);

        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
