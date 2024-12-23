using System;
using System.Windows.Forms;

namespace FullNameTP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Event handler for form load
        private void TPonSoftwareDesignMidterm_Load(object sender, EventArgs e)
        {
            // Optional: Initialize form-specific properties or data
        }

        // Event handler for the fullNameButton click
        private void fullNameButton_Click(object sender, EventArgs e)
        {
            outputName.Text = firstName.Text + " " + middleInitial.Text + " " + lastName.Text;
        }

        // Event handler for the clearButton click
        private void clearButton_Click(object sender, EventArgs e)
        {
            firstName.Text = "";
            middleInitial.Text = "";
            lastName.Text = "";
            outputName.Text = "";
        }

        // Event handler for the exitButton click
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Optional: Event handler for label click (if needed)
        private void label4_Click(object sender, EventArgs e)
        {
            // Action for label click (if any); can be removed if not used
        }

        // Optional: Event handler for text changes in firstName field
        private void firstName_TextChanged(object sender, EventArgs e)
        {
            // Logic for handling text changes, if needed
        }

        // Optional: Event handler for text changes in outputName field
        private void outputName_TextChanged(object sender, EventArgs e)
        {
            // Logic for handling text changes, if needed
        }
    }
}
