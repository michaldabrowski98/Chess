using System.Linq.Expressions;

namespace Chess
{
    public partial class Main : Form
    {
        private string mainText = "Szach";

        private int rookSize = 98;

        private Color firstBoardColor = Color.White;

        private Color secondBoardColor = Color.Black;

        public Main()
        {
            InitializeComponent();
            DrawChessBoard();
            timer.Interval = 2000;
            timer.Start();
        }

        private void DrawChessBoard()
        {
            Bitmap bm = new Bitmap(rookSize * 8, rookSize * 8 + menuStrip.Height);
            Graphics board = Graphics.FromImage(bm);
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if ((j % 2 == 0 && i % 2 == 0) || (j % 2 != 0 && i % 2 != 0))
                    {
                        board.FillRectangle(new SolidBrush(firstBoardColor), j * rookSize, menuStrip.Height + i * rookSize, rookSize, rookSize);

                    }
                    else if ((j % 2 == 0 && i % 2 != 0) || (j % 2 != 0 && i % 2 == 0))
                    {
                        board.FillRectangle(new SolidBrush(secondBoardColor), j * rookSize, menuStrip.Height + i * rookSize, rookSize, rookSize);
                    }
                }
            }
            BackgroundImage = bm;
        }

        private void polaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                firstBoardColor = colorDialog.Color;
                DrawChessBoard();
            }
        }

        private void pola2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                secondBoardColor = colorDialog.Color;
                DrawChessBoard();
            }
        }

        private void rook_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    MoveRookLeft();
                    break;
                case Keys.Right:
                    MoveRookRight();
                    break;
                case Keys.Up:
                    MoveRookUp();
                    break;
                case Keys.Down:
                    MoveRookDown();
                    break;
                case Keys.Escape:
                    if (escapeToLeaveToolStripMenuItem.Checked)
                    {
                        Close();
                    }
                    break;
            }
        }

        private void MoveRookLeft()
        {
            if (rook.Location.X > rookSize)
            {
                rook.Location = new Point(rook.Location.X - rookSize, rook.Location.Y);
            }
        }

        private void MoveRookRight()
        {
            if (rook.Location.X < (Width - 2 * rookSize))
            {
                rook.Location = new Point(rook.Location.X + rookSize, rook.Location.Y);
            }
        }

        private void MoveRookUp()
        {
            if (rook.Location.Y > (rookSize + menuStrip.Height))
            {
                rook.Location = new Point(rook.Location.X, rook.Location.Y - rookSize);
            }
        }

        private void MoveRookDown()
        {
            if (rook.Location.Y < (Height - 2 * rookSize))
            {
                rook.Location = new Point(rook.Location.X, rook.Location.Y + rookSize);
            }
        }

        private void menuStrip_MouseHover(object sender, EventArgs e)
        {
            if (!losowanieToolStripMenuItem.Checked) { return; }

            Random random = new Random();
            rook.Location = new Point(
                random.Next(0, 7) * rookSize,
                random.Next(0, 7) * rookSize + menuStrip.Height
            );
        }

        private void losowanieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            losowanieToolStripMenuItem.Checked = !losowanieToolStripMenuItem.Checked;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            var textsToShow = new List<string>
            {
                mainText,
                "Pozycja wie¿y x = " + rook.Location.X + ", y = " + rook.Location.Y,
                DateTime.Now.ToString()
            };
            Random rand = new Random();

            Text = textsToShow[rand.Next(textsToShow.Count)];
        }

        private void czarnaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rook.Image = Image.FromFile("blackRook.png");
        }

        private void bia³aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rook.Image = Image.FromFile("whiteRook.png");
        }
    }
}