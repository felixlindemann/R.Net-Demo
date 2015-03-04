using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using org.lime.tree.controls.helper;

namespace RHelper
{
    public partial class ucRConsole : UserControl
    {

        #region Variables

        private RHelper rengine;

        #endregion

        #region Properties

        public RHelper rEngine
        {
            get { return rengine; }
            set
            {
                rengine = value;

                if (rengine != null)
                {
                    rEngine.rExec += new RepertoryGrid.BaseClasses.RExececutedEventHandler(rEngine_rExec);
                }
            }
        }

        #endregion

        #region Constructor

        public ucRConsole()
        {
            InitializeComponent();
        }

        #endregion

        #region event Handler

        private void buttonClearConsole_Click(object sender, EventArgs e)
        {
            this.richTextBoxRScript.ResetText();
        }

        private void buttonExecManualRCode_Click(object sender, EventArgs e)
        {
            executeManualRCode();
        }

        private void buttonLoadRScript_Click(object sender, EventArgs e)
        {
            LoadRScript();
        }

        void rEngine_rExec(RepertoryGrid.BaseClasses.RExececutedEventArgs e)
        {
            try
            {
                if (e.RCmd.Length > 0)
                    RichtTextboxHelper.AddText(richTextBoxRScript, "> " + e.RCmd, Color.Red);

                if (e.Output.Length > 0)
                    RichtTextboxHelper.AddText(richTextBoxRScript, e.Output, Color.Blue);

                this.textBoxManualRcode.Focus();
                // if (e.RExececutedException != null) throw e.RExececutedException;
            }
            catch (Exception )
            {
                //  Debug.Print(ex.StackTrace);
            }
        }

        #endregion

        #region Methods

        private void executeManualRCode()
        {
            try
            {
                this.rEngine.Evaluate(textBoxManualRcode.Text, checkBoxExecuteLinewise.Checked);
                textBoxManualRcode.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Execute Manual R Code: An Error occured.");
            }
        }

        private void LoadRScript()
        {
            try
            {
                OpenFileDialog opf = new OpenFileDialog();
                opf.Title = "Choose R-Skript";
                opf.Multiselect = false;
                if (opf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                    textBoxManualRcode.Text = "";
                    FileInfo fs = new FileInfo(opf.FileName);
                    this.rEngine.Evaluate(fs);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Open R cript: An Error occured.");
            }
        }

        public void ResetConsole()
        {
            this.richTextBoxRScript.ResetText();
        }

        #endregion

    }
}
