using System;
using System.Collections.Generic;
using System.Windows.Forms;

/// <summary>
/// Parsing Application
/// -- Keep the first and last letter as is; count the number of distinct letters betwwen first and last letters;
/// -- keep the special chars as is
/// </summary>
namespace ParsingApp
{
    /// <summary>
    /// frmParserMain
    /// This is an application that parses a sentence and rewrites
    /// </summary>
    public partial class frmParserMain : Form
    {
        /// <summary>
        /// frmParserMain
        /// </summary>
        public frmParserMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// btnParse_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnParse_Click(object sender, EventArgs e)
        {
            try
            {
                string wholeSentence = string.Empty;
                wholeSentence = txtInput.Text.Trim();
                txtOutput.Text = WordParser.start_Processing(wholeSentence);
            }
            catch (Exception ex) { txtOutput.Text = ex.Message; }
        }
    }
}