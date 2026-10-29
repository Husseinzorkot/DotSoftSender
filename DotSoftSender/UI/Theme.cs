using System.Drawing.Drawing2D;

namespace DotSoftSender.UI
{
    /// <summary>
    /// Central color, font and control styling for the application.
    /// </summary>
    public static class Theme
    {
        // Brand
        public static readonly Color Primary = Color.FromArgb(37, 99, 235);
        public static readonly Color PrimaryHover = Color.FromArgb(29, 78, 216);
        public static readonly Color PrimarySoft = Color.FromArgb(219, 234, 254);

        // Surfaces
        public static readonly Color Background = Color.FromArgb(248, 250, 252);
        public static readonly Color Surface = Color.White;
        public static readonly Color Border = Color.FromArgb(226, 232, 240);
        public static readonly Color SurfaceHover = Color.FromArgb(241, 245, 249);

        // Sidebar
        public static readonly Color Sidebar = Color.FromArgb(15, 23, 42);
        public static readonly Color SidebarHover = Color.FromArgb(30, 41, 59);
        public static readonly Color SidebarText = Color.FromArgb(148, 163, 184);
        public static readonly Color SidebarMuted = Color.FromArgb(100, 116, 139);

        // Text
        public static readonly Color TextPrimary = Color.FromArgb(15, 23, 42);
        public static readonly Color TextSecondary = Color.FromArgb(100, 116, 139);

        // Status
        public static readonly Color Success = Color.FromArgb(22, 163, 74);
        public static readonly Color SuccessSoft = Color.FromArgb(220, 252, 231);
        public static readonly Color Warning = Color.FromArgb(217, 119, 6);
        public static readonly Color WarningSoft = Color.FromArgb(254, 243, 199);
        public static readonly Color Danger = Color.FromArgb(220, 38, 38);
        public static readonly Color DangerSoft = Color.FromArgb(254, 226, 226);

        public const string FontFamily = "Segoe UI";
        public const string IconFontFamily = "Segoe MDL2 Assets";

        public static GraphicsPath RoundedRect(Rectangle bounds, int radius)
        {
            var path = new GraphicsPath();
            if (radius <= 0)
            {
                path.AddRectangle(bounds);
                return path;
            }

            int d = Math.Min(radius * 2, Math.Min(bounds.Width, bounds.Height));
            path.AddArc(bounds.X, bounds.Y, d, d, 180, 90);
            path.AddArc(bounds.Right - d, bounds.Y, d, d, 270, 90);
            path.AddArc(bounds.Right - d, bounds.Bottom - d, d, d, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }

        /// <summary>
        /// Applies a clean, flat table look to a DataGridView.
        /// </summary>
        public static void StyleGrid(DataGridView grid)
        {
            grid.BackgroundColor = Surface;
            grid.BorderStyle = BorderStyle.None;
            grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grid.GridColor = Border;
            grid.RowHeadersVisible = false;
            grid.AllowUserToAddRows = false;
            grid.AllowUserToResizeRows = false;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.MultiSelect = false;
            grid.EnableHeadersVisualStyles = false;

            grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            grid.ColumnHeadersHeight = 42;
            grid.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Background,
                ForeColor = TextSecondary,
                SelectionBackColor = Background,
                SelectionForeColor = TextSecondary,
                Font = new Font(FontFamily, 8.5F, FontStyle.Bold),
                Alignment = DataGridViewContentAlignment.MiddleLeft,
                Padding = new Padding(8, 0, 8, 0),
                WrapMode = DataGridViewTriState.False
            };

            grid.RowTemplate.Height = 40;
            grid.DefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Surface,
                ForeColor = TextPrimary,
                SelectionBackColor = SurfaceHover,
                SelectionForeColor = TextPrimary,
                Font = new Font(FontFamily, 9F),
                Padding = new Padding(8, 0, 8, 0),
                WrapMode = DataGridViewTriState.False
            };
            grid.AlternatingRowsDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(252, 253, 254)
            };

            foreach (DataGridViewColumn column in grid.Columns)
            {
                if (column is DataGridViewButtonColumn button)
                {
                    button.FlatStyle = FlatStyle.Flat;
                    button.DefaultCellStyle = new DataGridViewCellStyle
                    {
                        BackColor = PrimarySoft,
                        ForeColor = Primary,
                        SelectionBackColor = PrimarySoft,
                        SelectionForeColor = Primary,
                        Font = new Font(FontFamily, 8.5F, FontStyle.Bold),
                        Alignment = DataGridViewContentAlignment.MiddleCenter,
                        Padding = new Padding(10, 7, 10, 7)
                    };
                }
            }

            typeof(DataGridView)
                .GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)?
                .SetValue(grid, true);
        }
    }
}
