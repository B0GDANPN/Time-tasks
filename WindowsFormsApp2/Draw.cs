using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public class CustomListBox : ListBox
    {
        public CustomListBox()
        {
            DrawMode = DrawMode.OwnerDrawFixed;
            ItemHeight = 100;
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
            
            CurrentTask task = Items[e.Index] as CurrentTask;
            if (task == null) return;
            Brush myBrush;
            if (task.status == 0)
            {
                myBrush = Brushes.White;
            }
            else if (task.status == 1)
            {
                myBrush = Brushes.Gold;
            }
            else if (task.status == 2)
            {
                myBrush = Brushes.Red;
            }
            else
            {
                myBrush = Brushes.Green;
            }
            e.Graphics.FillRectangle(myBrush, e.Bounds);
            e.Graphics.DrawRectangle(Pens.Black, e.Bounds.X, e.Bounds.Y, e.Bounds.Width - 1, e.Bounds.Height - 1);

            if (DesignMode)
                TextRenderer.DrawText(e.Graphics, "lastFileListBox", e.Font, e.Bounds, e.ForeColor, flags);
            else
            {
                task = Items[e.Index] as CurrentTask;
                if (task == null) return;

                int half = e.Bounds.Height / 5;

                Rectangle rect = e.Bounds;
                rect.Height = half;
                string text = DesignMode ? "LastFileListBox" : task.Name;
                Font f1 = new Font(e.Font, FontStyle.Bold);
                TextRenderer.DrawText(e.Graphics, text, f1, rect, e.ForeColor, flags);
                f1.Dispose();

                rect.Y += half;
                text = task.Description;
                TextRenderer.DrawText(e.Graphics, text, e.Font, rect, e.ForeColor, flags);

                rect.Y += half;
                DateTime dt = task.DateInit;
                text = $"{ dt.Day }.{ dt.Month }.{ dt.Year } { dt.Hour }:{ dt.Minute }";
                TextRenderer.DrawText(e.Graphics, text, e.Font, rect, e.ForeColor, flags);

                rect.Y += half;
                text = task.Durration.ToString();
                TextRenderer.DrawText(e.Graphics, text, e.Font, rect, e.ForeColor, flags);

                rect.Y += half;
                text = task.OcenTime.ToString();
                TextRenderer.DrawText(e.Graphics, text, e.Font, rect, e.ForeColor, flags);
            }

            e.DrawFocusRectangle();
        }
    }

}