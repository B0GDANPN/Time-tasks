using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public class FileListBox : ListBox
    {
        public FileListBox()
        {
            DrawMode = DrawMode.OwnerDrawFixed;
            ItemHeight = 20;
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            const TextFormatFlags flags = TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.PathEllipsis;

            if (e.Index < 0) return;
            //если выделенный элемент
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e = new DrawItemEventArgs(
                        e.Graphics,
                        e.Font,
                        e.Bounds,
                        e.Index,
                        e.State ^ DrawItemState.Selected,
                        Color.Black,
                        Color.FromKnownColor(KnownColor.Info)
                    );

            e.DrawBackground();

            e.Graphics.DrawRectangle(Pens.Black, e.Bounds.X, e.Bounds.Y, e.Bounds.Width - 1, e.Bounds.Height - 1);

            if (DesignMode)
                TextRenderer.DrawText(e.Graphics, "lastFileListBox", e.Font, e.Bounds, e.ForeColor, flags);
            else
            {
                string file = Items[e.Index] as string;
                if (file == null) return;

                
                Rectangle rect = e.Bounds;
                rect.Height = e.Bounds.Height;
                string text = DesignMode ? "LastFileListBox" : file;
                Font f1 = new Font(e.Font, FontStyle.Bold);
                TextRenderer.DrawText(e.Graphics, text, f1, rect, e.ForeColor, flags);
                f1.Dispose();

                //rect.Y += half;
                //DateTime dt = file.DateChange;
                //text = $"{ dt.Day }.{ dt.Month }.{ dt.Year } { dt.Hour }:{ dt.Minute }";
                //TextRenderer.DrawText(e.Graphics, text, e.Font, rect, e.ForeColor, flags);

                
            }

            e.DrawFocusRectangle();
        }
    }

}