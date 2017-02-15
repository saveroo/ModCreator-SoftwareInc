namespace SoftwareIncModMaker
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    internal class ActionMemo
    {
        public static RichTextBox Component;

        public static void AddLines(string s)
        {
            if (Component.Lines.Length > 0) Component.AppendText(string.Format("{1}: {0}{2}", s, DateTime.Now, Environment.NewLine));
            else Component.Text = string.Format("{1}: {0}{2}", s, DateTime.Now, Environment.NewLine);
        }

        public static void AddLines(string s, bool dataToCheck)
        {
            if (dataToCheck) AddLines(s);
        }

        public static void AddLines(string s, bool? dataToCheck, Color col)
        {
            if (dataToCheck == true)
            {
                Component.SelectionColor = col;
                AddLines(s);
            }
        }

        // {
        // public static void addLines(Object s1, Object s2, Object s3)
        // {

        // if (Component.Lines.Length > 0)
        // Component.AppendText(String.Format("{0}: {1}{2}", s1, s2, s3));
        // }
        // else
        // {
        // Component.Text = s1.ToString();
        // }
        // }
    }
}