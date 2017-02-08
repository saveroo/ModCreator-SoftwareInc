using ScintillaNET;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareIncModMaker
{
    public static class ScintillaStyling
    {
        private static int maxLineNumberCharLength;

        public static void ScintillaLineNumber(ref Scintilla textEditor)
        {
            // Did the number of characters in the line number display change?
            // i.e. nnn VS nn, or nnnn VS nn, etc...
            var maxLineNumberCharLength = textEditor.Lines.Count.ToString().Length;
            if (maxLineNumberCharLength == ScintillaStyling.maxLineNumberCharLength)
                return;

            // Calculate the width required to display the last line number
            // and include some padding for good measure.
            const int padding = 2;
            textEditor.Margins[0].Width = textEditor.TextWidth(Style.LineNumber, new string('9', maxLineNumberCharLength + 1)) + padding;
            ScintillaStyling.maxLineNumberCharLength = maxLineNumberCharLength;
        }
        public static Scintilla ScintillaStyleApply(ref Scintilla textEditor)
        {
            textEditor.Lexer = Lexer.Xml;
            textEditor.WrapMode = WrapMode.Word;
            textEditor.Styles[Style.Xml.SingleString].Font = "consolas";
            textEditor.Styles[Style.Xml.SingleString].Size = 12;
            textEditor.Styles[Style.Xml.Tag].ForeColor = Color.FromKnownColor(KnownColor.Green);
            textEditor.Styles[Style.Xml.Value].ForeColor = Color.FromKnownColor(KnownColor.IndianRed);
            textEditor.Styles[Style.Xml.Number].ForeColor = Color.FromKnownColor(KnownColor.Red);

            textEditor.Margins[2].Type = MarginType.Symbol;
            textEditor.Margins[2].Mask = Marker.MaskFolders;
            textEditor.Margins[2].Sensitive = true;
            textEditor.Margins[2].Width = 20;

            for (int i = 25; i <= 31; i++)
            {
                textEditor.Markers[i].SetForeColor(SystemColors.ControlLightLight);
                textEditor.Markers[i].SetBackColor(SystemColors.ControlDark);
            }
            textEditor.Markers[Marker.Folder].Symbol = MarkerSymbol.BoxPlus;
            textEditor.Markers[Marker.FolderOpen].Symbol = MarkerSymbol.BoxMinus;
            textEditor.Markers[Marker.FolderEnd].Symbol = MarkerSymbol.BoxPlusConnected;
            textEditor.Markers[Marker.FolderMidTail].Symbol = MarkerSymbol.TCorner;
            textEditor.Markers[Marker.FolderOpenMid].Symbol = MarkerSymbol.BoxMinusConnected;
            textEditor.Markers[Marker.FolderSub].Symbol = MarkerSymbol.VLine;
            textEditor.Markers[Marker.FolderTail].Symbol = MarkerSymbol.LCorner;

            textEditor.SetProperty("fold", "1");
            textEditor.SetProperty("fold.compact", "1");
            textEditor.SetProperty("fold.html", "1");
            textEditor.AutomaticFold = (AutomaticFold.Show | AutomaticFold.Click | AutomaticFold.Change);
            return textEditor;
        }
    }
}
