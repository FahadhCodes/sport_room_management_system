
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Project_Sport_Room.Theme
{

    public enum ActionButtonVariant
    {
        Primary,
        Secondary,
        Danger,
        Success
    }

    public static class ThemeManager
    {
        private static readonly HashSet<Control> RoundedControls = new();
        private static readonly HashSet<Control> ShadowedControls = new();

        // Fonts
        public static readonly Font HeaderTitleFont =
            new Font("Segoe UI", 21F, FontStyle.Bold);

        public static readonly Font SubtitleFont =
            new Font("Segoe UI", 10F, FontStyle.Bold);

        public static readonly Font SectionTitleFont =
            new Font("Segoe UI", 17F, FontStyle.Bold);

        public static readonly Font NavigationFont =
            new Font("Segoe UI", 10.5F, FontStyle.Bold);


        //Normal button
        public static void StyleActionButton(
            Button button,
            ActionButtonVariant variant = ActionButtonVariant.Primary,
            int radius = 10)
        {

            button.AutoSize = false;

            button.TextAlign = ContentAlignment.MiddleCenter;

            button.UseCompatibleTextRendering = true;

            button.Font = new Font(
                "Segoe UI",
                9.5F,
                FontStyle.Bold
            );
            Color normalColor;
            Color hoverColor;
            Color pressedColor;
            Color textColor = Color.White;

            switch (variant)
            {
                case ActionButtonVariant.Primary:
                    normalColor = ThemeColors.PrimaryRed;
                    hoverColor = ThemeColors.LightRed;
                    pressedColor = ThemeColors.DarkRed;
                    break;

                case ActionButtonVariant.Secondary:
                    normalColor = Color.FromArgb(232, 235, 240);
                    hoverColor = Color.FromArgb(215, 220, 228);
                    pressedColor = Color.FromArgb(195, 202, 212);
                    textColor = Color.FromArgb(45, 48, 55);
                    break;

                case ActionButtonVariant.Danger:
                    normalColor = ThemeColors.Danger;
                    hoverColor = Color.FromArgb(220, 70, 70);
                    pressedColor = Color.FromArgb(160, 35, 35);
                    break;

                case ActionButtonVariant.Success:
                    normalColor = ThemeColors.Success;
                    hoverColor = Color.FromArgb(45, 160, 110);
                    pressedColor = Color.FromArgb(25, 105, 70);
                    break;

                default:
                    normalColor = ThemeColors.PrimaryRed;
                    hoverColor = ThemeColors.LightRed;
                    pressedColor = ThemeColors.DarkRed;
                    break;
            }

            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;

            button.UseVisualStyleBackColor = false;

            button.BackColor = normalColor;
            button.ForeColor = textColor;

            button.Font = new Font(
                "Segoe UI",
                9.5F,
                FontStyle.Bold
            );

            button.Cursor = Cursors.Hand;

            button.TextAlign = ContentAlignment.MiddleCenter;

            button.FlatAppearance.MouseOverBackColor = hoverColor;
            button.FlatAppearance.MouseDownBackColor = pressedColor;

            button.Padding = new Padding(8, 0, 8, 0);

            // Rounded corners and floating shadow
            ApplyRoundedCorners(button, radius);
        }



        // ==========================================
        // NAVIGATION BUTTON STYLING
        // ==========================================

        public static void StyleNavigationButton(
            Button button,
            bool isActive = false)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;

            button.UseVisualStyleBackColor = false;

            button.BackColor = isActive
                ? ThemeColors.SidebarActive
                : ThemeColors.SidebarButton;

            button.ForeColor = Color.White;
            button.Font = NavigationFont;

            button.Cursor = Cursors.Hand;
            button.TextAlign = ContentAlignment.MiddleCenter;

            button.FlatAppearance.MouseOverBackColor =
                ThemeColors.SidebarHover;

            button.FlatAppearance.MouseDownBackColor =
                ThemeColors.DarkRed;

            ApplyRoundedCorners(button, 14);
        }


        // ==========================================
        // ROUNDED BUTTON
        // ==========================================

        public static void ApplyRoundedCorners(
            Button button,
            int radius = 14)
        {
            ApplyRoundedRegion(button, radius);
            ApplyShadowBehindControl(button, radius);
        }


        // ==========================================
        // ROUNDED PANEL
        // ==========================================

        public static void ApplyRoundedPanel(Control control, int radius = 16)
        {
            if (control is Panel panel)
                panel.BorderStyle = BorderStyle.None;

            ApplyRoundedRegion(control, radius);
            ApplyShadowBehindControl(control, radius);
        }


        // ==========================================
        // APPLY ROUNDED REGION
        // ==========================================

        private static void ApplyRoundedRegion(
            Control control,
            int radius)
        {
            if (RoundedControls.Add(control))
            {
                control.Resize += (sender, e) =>
                {
                    UpdateRoundedRegion(control, radius);
                };
            }

            UpdateRoundedRegion(control, radius);
        }


        private static void UpdateRoundedRegion(
            Control control,
            int radius)
        {
            if (control.IsDisposed ||
                control.Width <= 0 ||
                control.Height <= 0)
                return;

            Rectangle bounds = control.ClientRectangle;

            bounds.Width -= 1;
            bounds.Height -= 1;

            int actualRadius = Math.Max(
                1,
                Math.Min(
                    radius,
                    Math.Min(bounds.Width, bounds.Height) / 2
                )
            );

            using (GraphicsPath path =
                CreateRoundedPath(bounds, actualRadius))
            {
                Region oldRegion = control.Region;

                control.Region = new Region(path);

                oldRegion?.Dispose();
            }
        }


        // ==========================================
        // SOFT DROP SHADOW
        // ==========================================


        private static void ApplyShadowBehindControl(
            Control control,
            int radius)
        {
            Control parent = control.Parent;

            if (parent == null ||
                !ShadowedControls.Add(control))
                return;

            PaintEventHandler paintHandler = (sender, e) =>
            {
                if (control.IsDisposed || !control.Visible)
                    return;

                Graphics graphics = e.Graphics;

                SmoothingMode previousMode = graphics.SmoothingMode;
                graphics.SmoothingMode = SmoothingMode.AntiAlias;

                for (int layer = 5; layer >= 1; layer--)
                {
                    Rectangle shadowBounds = control.Bounds;

                    shadowBounds.Offset(0, layer);
                    shadowBounds.Inflate(1, 1);

                    int alpha = 4 + (6 - layer) * 3;

                    using (GraphicsPath path =
                        CreateRoundedPath(shadowBounds, radius + 1))
                    using (SolidBrush brush =
                        new SolidBrush(Color.FromArgb(alpha, 0, 0, 0)))
                    {
                        graphics.FillPath(brush, path);
                    }
                }

                graphics.SmoothingMode = previousMode;
            };

            parent.Paint += paintHandler;

            control.LocationChanged += (sender, e) => parent.Invalidate();
            control.SizeChanged += (sender, e) => parent.Invalidate();
            control.VisibleChanged += (sender, e) => parent.Invalidate();

            parent.Invalidate();
        }



        // ==========================================
        // ROUNDED RECTANGLE GRAPHICS PATH
        // ==========================================

        private static GraphicsPath CreateRoundedPath(
            Rectangle bounds,
            int radius)
        {
            GraphicsPath path = new GraphicsPath();

            if (bounds.Width <= 0 || bounds.Height <= 0)
                return path;

            int diameter = Math.Min(
                radius * 2,
                Math.Min(bounds.Width, bounds.Height)
            );

            if (diameter <= 1)
            {
                path.AddRectangle(bounds);
                return path;
            }

            path.AddArc(
                bounds.Left,
                bounds.Top,
                diameter,
                diameter,
                180,
                90);

            path.AddArc(
                bounds.Right - diameter,
                bounds.Top,
                diameter,
                diameter,
                270,
                90);

            path.AddArc(
                bounds.Right - diameter,
                bounds.Bottom - diameter,
                diameter,
                diameter,
                0,
                90);

            path.AddArc(
                bounds.Left,
                bounds.Bottom - diameter,
                diameter,
                diameter,
                90,
                90);

            path.CloseFigure();

            return path;
        }
    }
}
