using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace WinFormsPaint
{
    public enum Mode
    {
        Draw,
        Select,
        Line
    };
    public partial class Form1 : Form
    {
        public static int defaultCounter = 1;
        private string setting = "config.ini";
        private Pen pen;
        private DirectBitmap bmp;
        private Bitmap sel;
        private Bitmap buff;
        private Point clickPos;
        private string FileName;
        private Mode mode = Mode.Draw;
        private Rectangle selectedRect;
        private float Zoom;
        private List<string> RecentFiles;
        private string? currName;
        private ToolStripMenuItem list;
        public Form1()
        {
            InitializeComponent();
            Initialize();
            
        }
        public void Initialize()
        {
            bmp = new DirectBitmap(Canvas.Width, Canvas.Height);
            sel = new Bitmap(Canvas.Width, Canvas.Height);
            pen = new Pen(Color.Black);
            this.Zoom = 1;
            Canvas.Image = bmp.Bitmap;
            pen.Color = Color.Black;
            this.FileName = $"New file{defaultCounter}";
            this.RecentFiles = new List<string>();
            SaveRecentFiles();
            foreach(string temp in File.ReadAllLines(setting))
            {
                RecentFiles.Add(temp);
            }
            CreateRecentFilesSubMenu();
            Draw();
        }
        private void SaveRecentFiles()
        {
            if (!File.Exists(this.setting))
            {
                File.Create(this.setting);
            }
            if(RecentFiles.Count > 0)
            {
                File.WriteAllLines(this.setting, this.RecentFiles);
            }
            

        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form prompt = new Form();
            prompt.Width = 400;
            prompt.Height = 300;
            prompt.Text = "Create new image";
            Label textLabel = new Label() { Left = 30, Top = 10, Text = "Size:" };
            NumericUpDown inputX = new NumericUpDown() { Left = 30, Top = 40, Width = 100 };
            NumericUpDown inputY = new NumericUpDown() { Left = 30, Top = 70, Width = 100 };
            Button confirmation = new Button() { Text = "Ok", Left = 100, Width = 30, Top = 100 };
            confirmation.Click += (sender, e) =>
            {
                int x = Convert.ToInt32(Math.Round(inputX.Value, 0));
                int y = Convert.ToInt32(Math.Round(inputY.Value, 0));
                if (x < 1 || y < 1 || x > 100000 || y > 100000)
                {
                    return;
                }
                prompt.Close();
            };
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(inputX);
            prompt.Controls.Add(inputY);
            prompt.ShowDialog();
        }
        private void CreateRecentFilesSubMenu()
        {
            list = new ToolStripMenuItem("Recently used Files");
            fileToolStripMenuItem.DropDownItems.Insert(4, list);
            UpdateRecentFilesMenu();
        }
        private void UpdateRecentFilesMenu()
        {
            list.DropDownItems.Clear();
            if (RecentFiles.Count == 0) return;
            foreach (var item in RecentFiles)
            {
                string filePath = item;
                ToolStripMenuItem RecentDropDownMenuItem = new ToolStripMenuItem($"{Path.GetFileName(filePath)}");
                RecentDropDownMenuItem.Text = $"{filePath}";
                RecentDropDownMenuItem.Tag = filePath;
                RecentDropDownMenuItem.Click += RecentFileItem_Click;
                list.DropDownItems.Add(RecentDropDownMenuItem);
            }
            ToolStripMenuItem CleanupRecentItem = new ToolStripMenuItem($"Clear recent files");
            CleanupRecentItem.Click += (sender, e) => { RecentFiles.Clear(); UpdateRecentFilesMenu(); };

            list.DropDownItems.Add(CleanupRecentItem);
        }

        private void RecentFileItem_Click(object? sender, EventArgs e)
        {
            ToolStripMenuItem tsmi = (ToolStripMenuItem)sender;
            File.Open(tsmi.Text, FileMode.Open);
        }

        public void Draw()
        {
            using (Graphics g = Graphics.FromImage(sel))
            {
                g.Clear(Color.Transparent);
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                clickPos = e.Location;
                if (mode == Mode.Draw)
                {
                    using (Graphics g = Graphics.FromImage(bmp.Bitmap))
                    {
                        g.DrawLine(pen, clickPos, e.Location);
                    }
                }
                else if (mode == Mode.Select)
                {
                    using (Graphics g = Graphics.FromImage(sel))
                    {
                        g.Clear(Color.Transparent);
                    }
                }
                else if (mode == Mode.Line)
                {
                    buff = new Bitmap(bmp.Bitmap);
                    clickPos = new Point(e.X, e.Y);
                }
                Canvas.Invalidate();
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (mode == Mode.Draw)
                {
                    using (Graphics g = Graphics.FromImage(bmp.Bitmap))
                    {
                        g.DrawLine(pen, clickPos, e.Location);
                        clickPos = e.Location;
                    }
                }
                else if (mode == Mode.Select)
                {
                    using (Graphics g = Graphics.FromImage(sel))
                    {
                        g.Clear(Color.Transparent);
                        g.DrawRectangle(pen, new Rectangle(Math.Min(e.Location.X, clickPos.X), Math.Min(e.Location.Y, clickPos.Y), Math.Abs(e.Location.X - clickPos.X), Math.Abs(e.Location.Y - clickPos.Y)));
                    }
                }
                using (Graphics g = Graphics.FromImage(Canvas.Image))
                {
                    //g.Clear(Color.White);
                    g.DrawImage(bmp.Bitmap, Point.Empty);
                    g.DrawImage(sel, Point.Empty);
                }
                Canvas.Refresh();
            }
            StatusBar.Text = $"{e.Location.X} px, {e.Location.Y} px";
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = $"Image(*.jpeg, *.png) | *.JPEG,*.PNG";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap temp = new Bitmap(openFileDialog.FileName);
                RecentFiles.Remove(openFileDialog.FileName);
                Canvas.Image = temp;
                Canvas.Size = new Size(bmp.Width, bmp.Height);
                RecentFiles.Add(openFileDialog.FileName);
                UpdateRecentFilesMenu();
                Canvas.Refresh();
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Image(*.png)| .PNG";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    bmp.Bitmap.Save(saveFileDialog.FileName);
                    currName = saveFileDialog.FileName;
                    RecentFiles.Remove(currName);
                    RecentFiles.Add(currName);

                    UpdateRecentFilesMenu();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Some error has occured during saving the image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void colorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                pen.Color = colorDialog.Color;
            }
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            mode = Mode.Select;
        }

        private void penButton_Click(object sender, EventArgs e)
        {
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            mode = Mode.Draw;
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                pen = new Pen(colorDialog.Color, 1);
            }
            button1.BackColor = pen.Color;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            mode = Mode.Line;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (mode == Mode.Line)
            {
                using (Graphics g = Graphics.FromImage(bmp.Bitmap))
                {
                    g.DrawLine(pen, clickPos, new Point(e.X, e.Y));
                    buff = new Bitmap(bmp.Bitmap);
                }
                Canvas.Refresh();
            }
        }

        private void invertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < bmp.Height; i++)
            {
                for (int j = 0; j < bmp.Width; j++)
                {
                    Color curr = bmp.GetPixel(j, i);
                    bmp.SetPixel(j, i, Color.FromArgb(255 - curr.R, 255 - curr.G, 255 - curr.B));
                }
            }
            Canvas.Refresh();
        }
        private void ZoomRefresh()
        {
            bmp.Zoom(this.Zoom);
            Canvas.Size = new Size(bmp.Width, bmp.Height);
            Canvas.Image = bmp.Bitmap;
        }

        private void zoomInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.Zoom > 0.1f)
            {
                this.Zoom = 1.1f;
                ZoomRefresh();
                pen.Width *= this.Zoom;
            }
        }

        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.Zoom < 4.0f)
            {
                this.Zoom = 0.9f;
                ZoomRefresh();
                pen.Width *= this.Zoom;
            }
        }

        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Zoom = 1 / this.Zoom;
            ZoomRefresh();
            this.pen.Width /= this.Zoom;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File.Delete(currName);
            try
            {
                bmp.Bitmap.Save(currName);
            }catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }


        }
    }
    public class DirectBitmap : IDisposable
    {
        public Bitmap Bitmap { get; private set; }
        public Int32[] Bits { get; private set; }
        public bool Disposed { get; private set; }
        public int Height { get; private set; }
        public int Width { get; private set; }

        protected GCHandle BitsHandle { get; private set; }

        public DirectBitmap(int width, int height)
        {
            Width = width;
            Height = height;
            Bits = new Int32[width * height];
            BitsHandle = GCHandle.Alloc(Bits, GCHandleType.Pinned);
            Bitmap = new Bitmap(width, height, width * 4, PixelFormat.Format32bppPArgb, BitsHandle.AddrOfPinnedObject());
        }
        public DirectBitmap(Bitmap bitmap)
        {
            if (bitmap == null)
                throw new ArgumentNullException(nameof(bitmap));

            Width = bitmap.Width;
            Height = bitmap.Height;
            Bits = new Int32[Width * Height];

            Rectangle rect = new Rectangle(0, 0, Width, Height);
            BitmapData bmpData = bitmap.LockBits(rect, ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

            try
            {
                Marshal.Copy(bmpData.Scan0, Bits, 0, Bits.Length);
            }
            finally
            {
                bitmap.UnlockBits(bmpData);
            }
            BitsHandle = GCHandle.Alloc(Bits, GCHandleType.Pinned);
            Bitmap = new Bitmap(Width, Height, Width * 4, PixelFormat.Format32bppArgb, BitsHandle.AddrOfPinnedObject());
        }
        public void SetPixel(int x, int y, Color colour)
        {
            int index = x + (y * Width);
            int col = colour.ToArgb();

            Bits[index] = col;
        }

        public Color GetPixel(int x, int y)
        {
            int index = x + (y * Width);
            int col = Bits[index];
            Color result = Color.FromArgb(col);

            return result;
        }
        public void Zoom(float zoomFactor)
        {
            int newWidth = (int)(Width * zoomFactor);
            int newHeight = (int)(Height * zoomFactor);

            Int32[] zoomedBits = new Int32[newWidth * newHeight];

            for (int y = 0; y < newHeight; y++)
            {
                for (int x = 0; x < newWidth; x++)
                {
                    int origX = (int)(x / zoomFactor);
                    int origY = (int)(y / zoomFactor);

                    origX = Math.Max(0, Math.Min(origX, Width - 1));
                    origY = Math.Max(0, Math.Min(origY, Height - 1));

                    Color color = GetPixel(origX, origY);

                    int index = x + (y * newWidth);
                    zoomedBits[index] = color.ToArgb();
                }
            }

            Dispose();

            Width = newWidth;
            Height = newHeight;
            Bits = zoomedBits;
            BitsHandle = GCHandle.Alloc(Bits, GCHandleType.Pinned);

            Bitmap = new Bitmap(newWidth, newHeight, newWidth * 4, PixelFormat.Format32bppArgb, BitsHandle.AddrOfPinnedObject());
        }

        public void Dispose()
        {
            if (Disposed) return;
            Disposed = true;
            Bitmap.Dispose();
            BitsHandle.Free();
        }
    }
}
