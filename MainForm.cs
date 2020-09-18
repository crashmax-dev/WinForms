using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private async void LoadApp(object sender, EventArgs e)
        {
            for (Opacity = 0; Opacity < 0.95; Opacity += 0.05)
            {
                await Task.Delay(10);
            }
        }

        string WinLocation()
        {
            string x = Location.X.ToString();
            string y = Location.Y.ToString();

            return $"{x}, {y}";
        }

        private void FormMove(object sender, MouseEventArgs e)
        {
            CustomPanel.Capture = false;
            Message m = Message.Create(Handle, 161, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
            WinLocation();
        }

        private void CloseApp(object sender, EventArgs e)
        {
            Close();
        }

        private void MinApp(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ToggleMaximize(object sender, EventArgs e)
        {
            WindowState = WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
        }

        private void CloseButtonHover(object sender, MouseEventArgs e)
        {
            CloseButton.BackColor = Color.FromArgb(233, 37, 57);
            CloseButton.Image = Properties.Resources.close_white;
        }

        private void CloseButtonLeave(object sender, EventArgs e)
        {
            CloseButton.BackColor = SystemColors.Control;
            CloseButton.Image = Properties.Resources.close_gray;
        }

        /* resize window */

        private bool resizing = false;
        private Point last = new Point(0, 0);

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!resizing)
            {
                bool resize_x = e.X > (Width - 8);
                bool resize_y = e.Y > (Height - 8);

                if (resize_x && resize_y)
                    Cursor = Cursors.SizeNWSE;
                else if (resize_x)
                    Cursor = Cursors.SizeWE;
                else if (resize_y)
                    Cursor = Cursors.SizeNS;
                else Cursor = Cursors.Default;
            }
            else
            {
                int w = Size.Width;
                int h = Size.Height;

                if (Cursor.Equals(Cursors.SizeNWSE))
                {
                    Size = new Size(w + (e.Location.X - last.X), h + (e.Location.Y - last.Y));
                    ResizePanel(e);
                }
                else if (Cursor.Equals(Cursors.SizeWE))
                {
                    Size = new Size(w + (e.Location.X - last.X), h);
                    ResizePanel(e);
                }
                else if (Cursor.Equals(Cursors.SizeNS))
                {
                    Size = new Size(w, h + (e.Location.Y - last.Y));
                }

                last = e.Location;
            }
        }

        private void ResizePanel(MouseEventArgs e)
        {
            CloseButton.Location = new Point(CloseButton.Location.X + (e.Location.X - last.X), 0);
            MaxMinButton.Location = new Point(MaxMinButton.Location.X + (e.Location.X - last.X), 0);
            MinButton.Location = new Point(MinButton.Location.X + (e.Location.X - last.X), 0);
            CustomPanel.Size = new Size(e.Location.X, 21);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            resizing = true;
            last = e.Location;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            resizing = false;
        }

        /* resize window */
    }
}