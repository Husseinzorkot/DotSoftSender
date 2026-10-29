using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace DotSoftSender.UI
{
    /// <summary>
    /// Rounded "card" container. BackColor is the card fill; the corners take the parent's color.
    /// </summary>
    public class CardPanel : Panel
    {
        [DefaultValue(10)]
        public int BorderRadius { get; set; } = 10;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color BorderColor { get; set; } = Theme.Border;

        public CardPanel()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw | ControlStyles.UserPaint, true);
            BackColor = Theme.Surface;
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            e.Graphics.Clear(Parent?.BackColor ?? Theme.Background);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            var rect = new Rectangle(0, 0, Width - 1, Height - 1);
            using var path = Theme.RoundedRect(rect, BorderRadius);
            using var fill = new SolidBrush(BackColor);
            using var pen = new Pen(BorderColor);
            e.Graphics.FillPath(fill, path);
            e.Graphics.DrawPath(pen, path);
        }
    }

    public enum ButtonVariant
    {
        Primary,
        Secondary
    }

    /// <summary>
    /// Flat rounded button with hover and pressed states.
    /// </summary>
    public class ModernButton : Button
    {
        private bool _hover;
        private bool _pressed;

        [DefaultValue(ButtonVariant.Primary)]
        public ButtonVariant Variant { get; set; } = ButtonVariant.Primary;

        [DefaultValue(8)]
        public int BorderRadius { get; set; } = 8;

        /// <summary>Optional Segoe MDL2 Assets glyph drawn before the text.</summary>
        [DefaultValue("")]
        public string Icon { get; set; } = "";

        public ModernButton()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw | ControlStyles.UserPaint, true);
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            Cursor = Cursors.Hand;
            Font = new Font(Theme.FontFamily, 9F, FontStyle.Bold);
            Size = new Size(120, 40);
        }

        protected override bool ShowFocusCues => false;

        protected override void OnMouseEnter(EventArgs e) { _hover = true; Invalidate(); base.OnMouseEnter(e); }
        protected override void OnMouseLeave(EventArgs e) { _hover = false; _pressed = false; Invalidate(); base.OnMouseLeave(e); }
        protected override void OnMouseDown(MouseEventArgs e) { _pressed = true; Invalidate(); base.OnMouseDown(e); }
        protected override void OnMouseUp(MouseEventArgs e) { _pressed = false; Invalidate(); base.OnMouseUp(e); }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            g.Clear(Parent?.BackColor ?? Theme.Background);
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Color fill, text, border;
            if (Variant == ButtonVariant.Primary)
            {
                fill = _hover || _pressed ? Theme.PrimaryHover : Theme.Primary;
                text = Color.White;
                border = fill;
            }
            else
            {
                fill = _hover || _pressed ? Theme.SurfaceHover : Theme.Surface;
                text = Theme.TextPrimary;
                border = Theme.Border;
            }

            if (!Enabled)
            {
                fill = Theme.SurfaceHover;
                text = Theme.TextSecondary;
                border = Theme.Border;
            }

            var rect = new Rectangle(0, 0, Width - 1, Height - 1);
            if (_pressed) rect.Inflate(-1, -1);

            using (var path = Theme.RoundedRect(rect, BorderRadius))
            using (var brush = new SolidBrush(fill))
            using (var pen = new Pen(border))
            {
                g.FillPath(brush, path);
                g.DrawPath(pen, path);
            }

            var flags = TextFormatFlags.VerticalCenter | TextFormatFlags.SingleLine | TextFormatFlags.NoPadding;
            if (string.IsNullOrEmpty(Icon))
            {
                TextRenderer.DrawText(g, Text, Font, ClientRectangle, text, flags | TextFormatFlags.HorizontalCenter);
                return;
            }

            using var iconFont = new Font(Theme.IconFontFamily, Font.Size);
            var iconSize = TextRenderer.MeasureText(g, Icon, iconFont, Size.Empty, flags);
            var textSize = TextRenderer.MeasureText(g, Text, Font, Size.Empty, flags);
            const int gap = 8;
            int x = (Width - (iconSize.Width + gap + textSize.Width)) / 2;
            TextRenderer.DrawText(g, Icon, iconFont, new Rectangle(x, 0, iconSize.Width, Height), text, flags);
            TextRenderer.DrawText(g, Text, Font, new Rectangle(x + iconSize.Width + gap, 0, textSize.Width + 2, Height), text, flags);
        }
    }

    /// <summary>
    /// Sidebar navigation item with an icon and an accent bar when active.
    /// </summary>
    public class NavButton : Button
    {
        private bool _hover;
        private bool _active;

        [DefaultValue(false)]
        public bool Active
        {
            get => _active;
            set { _active = value; Invalidate(); }
        }

        /// <summary>Segoe MDL2 Assets glyph shown before the text.</summary>
        [DefaultValue("")]
        public string Icon { get; set; } = "";

        public NavButton()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw | ControlStyles.UserPaint, true);
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            Cursor = Cursors.Hand;
            Font = new Font(Theme.FontFamily, 9.75F);
            Size = new Size(224, 44);
        }

        protected override bool ShowFocusCues => false;

        protected override void OnMouseEnter(EventArgs e) { _hover = true; Invalidate(); base.OnMouseEnter(e); }
        protected override void OnMouseLeave(EventArgs e) { _hover = false; Invalidate(); base.OnMouseLeave(e); }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            g.Clear(Parent?.BackColor ?? Theme.Sidebar);
            g.SmoothingMode = SmoothingMode.AntiAlias;

            if (_active || _hover)
            {
                using var path = Theme.RoundedRect(new Rectangle(0, 0, Width - 1, Height - 1), 8);
                using var brush = new SolidBrush(Theme.SidebarHover);
                g.FillPath(brush, path);
            }

            if (_active)
            {
                using var path = Theme.RoundedRect(new Rectangle(0, 10, 4, Height - 20), 2);
                using var brush = new SolidBrush(Theme.Primary);
                g.FillPath(brush, path);
            }

            var color = _active || _hover ? Color.White : Theme.SidebarText;
            var flags = TextFormatFlags.VerticalCenter | TextFormatFlags.SingleLine | TextFormatFlags.NoPadding;

            if (!string.IsNullOrEmpty(Icon))
            {
                using var iconFont = new Font(Theme.IconFontFamily, 11F);
                TextRenderer.DrawText(g, Icon, iconFont, new Rectangle(18, 0, 24, Height), _active ? Theme.Primary : color, flags);
            }

            using var font = new Font(Font, _active ? FontStyle.Bold : FontStyle.Regular);
            TextRenderer.DrawText(g, Text, font, new Rectangle(52, 0, Width - 60, Height), color, flags);
        }
    }

    /// <summary>
    /// Small rounded tile showing an icon glyph (or letter) on a tinted background.
    /// </summary>
    public class IconBadge : Control
    {
        [DefaultValue(10)]
        public int BorderRadius { get; set; } = 10;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color BadgeColor { get; set; } = Theme.PrimarySoft;

        public IconBadge()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw | ControlStyles.UserPaint | ControlStyles.SupportsTransparentBackColor, true);
            Size = new Size(40, 40);
            ForeColor = Theme.Primary;
            Font = new Font(Theme.IconFontFamily, 13F);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            g.Clear(Parent?.BackColor ?? Theme.Surface);
            g.SmoothingMode = SmoothingMode.AntiAlias;

            using (var path = Theme.RoundedRect(new Rectangle(0, 0, Width - 1, Height - 1), BorderRadius))
            using (var brush = new SolidBrush(BadgeColor))
            {
                g.FillPath(brush, path);
            }

            TextRenderer.DrawText(g, Text, Font, ClientRectangle, ForeColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.SingleLine | TextFormatFlags.NoPadding);
        }
    }
}
