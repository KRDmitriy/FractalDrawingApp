using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;
using System.IO;

namespace Kara_79
{
    public partial class MainForm : Form
    {
        #region fields
        private int fractalNumber;
        private Color startColor = Color.Black;
        private Color endColor = Color.Black;
        private int depth = 20;
        private const int maxDepth = 19;
        private double coef;
        private double CornerL;
        private double CornerR;
        private int distance;
        private int scale = 1;
        private TreeFractal treeFractal;
        private Cantor cantor;
        private Levi levi;
        private List<Fractal.Line> lines;
        private List<Fractal.Rectangle> rectangles;
        private Graphics graphics;
        private Pen pen;
        private SolidBrush solidBrush;
        private Bitmap bitmap;
        private FormWindowState state = FormWindowState.Minimized;
        #endregion

        public MainForm()
        {
            try
            {
                Assembly.LoadFrom("FractalLib.dll");
            }
            catch(FileNotFoundException)
            {
                MessageBox.Show("Excuse me 'FractalLib.exe' not found.\nDonde esta la biblioteca?");
                Environment.Exit(-1);
            }
            InitializeComponent();
            SetButtons();
        }

        /// <summary>
        /// Verifies the data entered and call Draw()
        /// </summary>
        private void CheckParams()
        {
            depth = EntryDepth.Value;
            startColor = EntryStartColor.BackColor;
            endColor = EntryEndColor.BackColor;

            #region Check Params for fractalNumber TreeFractal
            if (fractalNumber == 1)
            {
                try
                {
                    coef = double.Parse(EntryCoef.Text);
                    if (coef < 0.4 || coef > 0.7)
                    {
                        throw new System.Exception();
                    }

                    EntryCoef.BackColor = Color.White;
                }
                catch
                {
                    MessageBox.Show("Некорректный коэффициент\n" +
                        "Допустимый коэффициент от 0.4 до 0.7");
                    EntryCoef.BackColor = Color.Red;
                    return;
                }

                try
                {
                    CornerR = uint.Parse(EntryCornerR.Text);
                    if (CornerR < 0 || CornerR > 90)
                    {
                        throw new System.Exception();
                    }

                    EntryCornerR.BackColor = Color.White;
                }
                catch
                {
                    MessageBox.Show("Некорректный угол\n" +
                        "Допустимый угол от 0 до 90");
                    EntryCornerR.BackColor = Color.Red;
                    return;
                }

                try
                {
                    CornerL = uint.Parse(EntryCornerL.Text);
                    if (CornerL < 0 || CornerL > 90)
                    {
                        throw new System.Exception();
                    }

                    EntryCornerL.BackColor = Color.White;
                }
                catch
                {
                    MessageBox.Show("Некорректный угол\n" +
                        "Допустимый угол от 0 до 90");
                    EntryCornerL.BackColor = Color.Red;
                    return;
                }
            }
            #endregion

            #region Check Params for Cantor 
            if (fractalNumber == 2)
            {
                try
                {
                    distance = int.Parse(EntryDistance.Text);
                    if (distance > 50 || distance <= 0)
                    {
                        throw new Exception();
                    }

                    EntryDistance.BackColor = Color.White;
                }
                catch
                {
                    MessageBox.Show("Некорректное расстояние\nДопустимое расстояние от 1 до 50");
                    EntryDistance.BackColor = Color.Red;
                    return;
                }
            }
            #endregion

            CornerL *= Math.PI / 180;
            CornerR *= Math.PI / 180;

            Draw();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SetSizes();
            Size = new Size(960, 600);
            MainPic.Size = PicLayout.Size;
            SaveButton.Visible = false;
            ZoomBar.Enabled = false;
            EntryDepth.Enabled = false;
        }

        private void SetButtons()
        {
            ShowPic1.Image = new Bitmap(40, 40);
            ShowPic2.Image = new Bitmap(40, 38);
            ShowPic3.Image = new Bitmap(52, 52);

            //Draw Fractal TreeFractal icon
            treeFractal = new TreeFractal(40, 40, startColor, endColor, 10, 0.7, Math.PI / 4, Math.PI / 4);
            treeFractal.Draw();
            lines = treeFractal.GetLines;
            graphics = Graphics.FromImage(ShowPic1.Image);
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen = new Pen(Color.Black);

            foreach (Fractal.Line Line in lines)
            {
                pen.Color = Line.Color;
                graphics.DrawLine(pen, Line.OldX, Line.OldY, Line.X, Line.Y);
            }
            ShowPic1.Update();

            //Draw Cantor icon
            cantor = new Cantor(40, 50, startColor, endColor, 10, 10);
            cantor.Draw();
            rectangles = cantor.GetRectangles;
            graphics = Graphics.FromImage(ShowPic2.Image);
            solidBrush = new SolidBrush(startColor);

            foreach (Fractal.Rectangle rect in rectangles)
            {
                pen.Color = rect.Color;
                solidBrush.Color = rect.Color;

                graphics.DrawRectangle(pen, rect.X, rect.Y, rect.Width, rect.Heigth);
                graphics.FillRectangle(solidBrush, rect.X, rect.Y, rect.Width, rect.Heigth);
            }
            ShowPic1.Update();

            //Draw Levi icon
            levi = new Levi(52, 50, startColor, endColor, 10);
            levi.Draw();
            lines = levi.GetLines;
            graphics = Graphics.FromImage(ShowPic3.Image);

            foreach (Fractal.Line Line in lines)
            {
                pen.Color = Line.Color;
                graphics.DrawLine(pen, Line.OldX, Line.OldY, Line.X, Line.Y);
            }
            ShowPic3.Update();
        }

        /// <summary>
        /// Main Draw func
        /// </summary>
        public void Draw()
        {
            MainPic.Height = PicLayout.Height * scale;
            MainPic.Width = PicLayout.Width * scale;

            bitmap = new Bitmap(MainPic.Width, MainPic.Height);
            MainPic.Image = bitmap;
            graphics = Graphics.FromImage(MainPic.Image);

            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            switch (fractalNumber)
            {
                case 1:
                    treeFractal = new TreeFractal(MainPic.Width, MainPic.Height,
                                        startColor, endColor, depth, coef, CornerL, CornerR);
                    treeFractal.Draw();
                    lines = treeFractal.GetLines;

                    foreach (Fractal.Line Line in lines)
                    {
                        pen.Color = Line.Color;
                        graphics.DrawLine(pen, Line.OldX, Line.OldY, Line.X, Line.Y);
                    }

                    break;

                case 2:
                    cantor = new Cantor(MainPic.Width, MainPic.Height,
                                        startColor, endColor, depth, distance);
                    cantor.Draw();
                    rectangles = cantor.GetRectangles;

                    foreach (Fractal.Rectangle rect in rectangles)
                    {
                        pen.Color = rect.Color;
                        solidBrush.Color = rect.Color;

                        graphics.DrawRectangle(pen, rect.X, rect.Y, rect.Width, rect.Heigth);
                        graphics.FillRectangle(solidBrush, rect.X, rect.Y, rect.Width, rect.Heigth);
                    }

                    break;

                case 3:
                    levi = new Levi(MainPic.Width, MainPic.Height,
                                    startColor, endColor, depth);
                    levi.Draw();
                    lines = levi.GetLines;

                    foreach (Fractal.Line Line in lines)
                    {
                        pen.Color = Line.Color;
                        graphics.DrawLine(pen, Line.OldX, Line.OldY, Line.X, Line.Y);
                    }
                    break;

                default:
                    break;
            }

            MainPic.Image = bitmap;

            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        /// <summary>
        /// Set every size and font
        /// </summary>
        private void SetSizes()
        {
            //int fontSize = Width / 130 + 3;
            //string font = "Times New Roman";

            //HelloLabel.Font = new Font(font, fontSize);
            //HelloLabel2.Font = new Font(font, fontSize);

            //LabelDepth.Font = new Font(font, fontSize);
            //LabelStartColor.Font = new Font(font, fontSize);
            //LabelEndColor.Font = new Font(font, fontSize);
            //LabelCoef.Font = new Font(font, fontSize);
            //LabelCornerL.Font = new Font(font, fontSize);
            //LabelCornerR.Font = new Font(font, fontSize);

            //EntryEndColor.Font = new Font(font, fontSize);
            //EntryCornerL.Font = new Font(font, fontSize);
            //EntryStartColor.Font = new Font(font, fontSize);
            //EntryCoef.Font = new Font(font, fontSize);
            //EntryCornerR.Font = new Font(font, fontSize);

            //PifagorLabel.Font = new Font(font, fontSize);
            //CantorLabel.Font = new Font(font, fontSize);
            //LabelDistance.Font = new Font(font, fontSize);
            //EntryDistance.Font = new Font(font, fontSize);

            //LabelZoom.Font = new Font(font, fontSize);

            if (TreeFractalLayout.Visible)
            {
                MinimumSize = new Size(960, 700);
            }
            else if (CantorLayout.Visible)
            {
                MinimumSize = new Size(960, 640);
            }
            else
            {
                MinimumSize = new Size(960, 600);
            }
        }

        private void EntryCoef_TextChanged(object sender, EventArgs e)
        {
            CheckParams();
        }

        private void ShowPic_Click(object sender, EventArgs e)
        {
            EntryDepth.Enabled = false;
            fractalNumber = 1;
            EntryDepth.Maximum = maxDepth;
            TreeFractalLayout.Visible = true;
            CantorLayout.Visible = false;
            CheckParams();
            SaveButton.Visible = true;
            ZoomBar.Enabled = true;
            EntryDepth.Enabled = true;
            EntryDepth.Enabled = true;
        }

        private void ShowPic2_Click(object sender, EventArgs e)
        {
            EntryDepth.Enabled = false;
            fractalNumber = 2;
            EntryDepth.Maximum = 10;
            if (EntryDepth.Value > EntryDepth.Maximum)
            {
                EntryDepth.Value = EntryDepth.Maximum;
            }
            LabelDepth.Text = $"Глубина рекурсии: {EntryDepth.Value}";
            TreeFractalLayout.Visible = false;
            CantorLayout.Visible = true;
            CheckParams();
            SaveButton.Visible = true;
            ZoomBar.Enabled = true;
            EntryDepth.Enabled = true;
            EntryDepth.Enabled = true;
        }

        private void ShowPic3_Click(object sender, EventArgs e)
        {
            EntryDepth.Enabled = false;
            fractalNumber = 3;
            EntryDepth.Maximum = maxDepth;
            TreeFractalLayout.Visible = false;
            CantorLayout.Visible = false;
            CheckParams();
            SaveButton.Visible = true;
            ZoomBar.Enabled = true;
            EntryDepth.Enabled = true;
            EntryDepth.Enabled = true;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (MainPic.Image != null)
            {
                SaveFileDialog save = new SaveFileDialog
                {
                    OverwritePrompt = true,
                    CheckPathExists = true,
                    Filter = "(*.JPG)|*.jpeg |(*.PNG)|*.png |(*.BMP) |*.bmp",
                    ShowHelp = true
                };

                if (save.ShowDialog() == DialogResult.OK)
                {
                    MainPic.Image.Save(save.FileName);
                }
            }
        }

        private void EntryStartcolor_Click(object sender, EventArgs e)
        {
            if (ChooseColor.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            EntryStartColor.BackColor = ChooseColor.Color;
        }

        private void EntryEndColor_Click(object sender, EventArgs e)
        {
            if (ChooseColor.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            EntryEndColor.BackColor = ChooseColor.Color;
        }

        private void MainForm_ResizeEnd(object sender, EventArgs e)
        {
            SetSizes();
            Draw();
        }

        private void EntryDepth_ValueChanged(object sender, EventArgs e)
        {
            LabelDepth.Text = $"Глубина рекурсии: {EntryDepth.Value}";
            CheckParams();
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            if (WindowState != state)
            {
                SetSizes();
                Draw();
                state = WindowState;
            }
        }

        private void ZoomBar_ValueChanged(object sender, EventArgs e)
        {
            switch (ZoomBar.Value)
            {
                case 1: { scale = 1; break; }
                case 2: { scale = 2; break; }
                case 3: { scale = 3; break; }
                case 4: { scale = 4; break; }
                case 5: { scale = 5; break; }
                case 6: { scale = 6; break; }
                case 7: { scale = 7; break; }
            }
            LabelZoom.Text = $"Zoom: {scale}";
            ZoomBar.Enabled = false;
            Draw();
            ZoomBar.Enabled = true;
        }
    }
}
