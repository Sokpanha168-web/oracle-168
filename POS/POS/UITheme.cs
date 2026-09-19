using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace POS_204_oracle
{
    public static class UITheme
    {
        // ==========================================
        // NEXT-GEN OBSIDIAN EMERALD PALETTE
        // ==========================================
        public static readonly Color BgDark          = Color.FromArgb(10, 14, 23);      // #0A0E17 (Deep Void)
        public static readonly Color BgSidebar       = Color.FromArgb(13, 18, 30);      // #0D121E (Sidebar)
        public static readonly Color BgHeader        = Color.FromArgb(15, 22, 36);      // #0F1624 (Top Header)
        public static readonly Color CardBg          = Color.FromArgb(20, 28, 45);      // #141C2D (Card Surface)
        public static readonly Color CardBgAlt       = Color.FromArgb(24, 34, 54);      // #182236 (Hover / Elevated)
        public static readonly Color CardBorder      = Color.FromArgb(38, 52, 80);      // #263450 (Border Outline)

        // Accent Colors
        public static readonly Color Primary         = Color.FromArgb(16, 185, 129);    // #10B981 (Emerald Green)
        public static readonly Color PrimaryHover    = Color.FromArgb(52, 211, 153);    // #34D399 (Mint Glow)
        public static readonly Color Secondary       = Color.FromArgb(6, 182, 212);     // #06B6D4 (Cyber Cyan)
        public static readonly Color AccentViolet    = Color.FromArgb(139, 92, 246);    // #8B5CF6 (Neon Violet)
        public static readonly Color Warning         = Color.FromArgb(245, 158, 11);    // #F59E0B (Amber Gold)
        public static readonly Color Danger          = Color.FromArgb(239, 68, 68);     // #EF4444 (Crimson Red)
        public static readonly Color DangerHover     = Color.FromArgb(220, 38, 38);

        // Typography Colors
        public static readonly Color TextWhite       = Color.FromArgb(248, 250, 252);   // #F8FAFC (Ultra White)
        public static readonly Color TextMuted       = Color.FromArgb(148, 163, 184);   // #94A3B8 (Cool Slate)
        public static readonly Color TextDim         = Color.FromArgb(100, 116, 139);   // #64748B (Dim Slate)

        // Form Inputs
        public static readonly Color InputBg         = Color.FromArgb(15, 22, 35);      // #0F1623
        public static readonly Color InputBorder     = Color.FromArgb(45, 60, 90);
        public static readonly Color InputFocus      = Color.FromArgb(16, 185, 129);

        // Grid
        public static readonly Color GridHeaderBg    = Color.FromArgb(15, 22, 36);
        public static readonly Color GridHeaderFg    = Color.FromArgb(248, 250, 252);
        public static readonly Color GridRowBg       = Color.FromArgb(20, 28, 45);
        public static readonly Color GridRowAltBg    = Color.FromArgb(16, 23, 38);
        public static readonly Color GridRowFg       = Color.FromArgb(226, 232, 240);
        public static readonly Color GridSelectionBg = Color.FromArgb(16, 185, 129);
        public static readonly Color GridSelectionFg = Color.White;
        public static readonly Color GridLineColor   = Color.FromArgb(30, 42, 65);

        // Standard Fonts
        public static readonly Font FontTitleLarge   = new Font("Segoe UI", 16F, FontStyle.Bold);
        public static readonly Font FontTitle        = new Font("Segoe UI", 12F, FontStyle.Bold);
        public static readonly Font FontSubtitle     = new Font("Segoe UI", 10F, FontStyle.Bold);
        public static readonly Font FontBody         = new Font("Segoe UI", 9F, FontStyle.Regular);
        public static readonly Font FontBodyBold     = new Font("Segoe UI", 9F, FontStyle.Bold);
        public static readonly Font FontSmall        = new Font("Segoe UI", 8F, FontStyle.Regular);
        public static readonly Font FontSmallBold    = new Font("Segoe UI", 8F, FontStyle.Bold);

        // ==========================================
        // CONTROLS STYLING HELPERS
        // ==========================================

        public static void ApplyFormTheme(Form form)
        {
            form.BackColor = BgDark;
            form.ForeColor = TextWhite;
            form.Font = FontBody;
        }

        public static void ApplyGridTheme(DataGridView dg)
        {
            if (dg == null) return;

            dg.BorderStyle = BorderStyle.None;
            dg.BackgroundColor = BgDark;
            dg.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dg.GridColor = GridLineColor;
            dg.EnableHeadersVisualStyles = false;
            dg.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dg.ColumnHeadersDefaultCellStyle.BackColor = GridHeaderBg;
            dg.ColumnHeadersDefaultCellStyle.ForeColor = GridHeaderFg;
            dg.ColumnHeadersDefaultCellStyle.Font = FontSubtitle;
            dg.ColumnHeadersDefaultCellStyle.SelectionBackColor = GridHeaderBg;
            dg.ColumnHeadersDefaultCellStyle.SelectionForeColor = GridHeaderFg;
            dg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dg.ColumnHeadersHeight = 38;

            dg.RowTemplate.Height = 36;
            dg.DefaultCellStyle.BackColor = GridRowBg;
            dg.DefaultCellStyle.ForeColor = GridRowFg;
            dg.DefaultCellStyle.Font = FontBody;
            dg.DefaultCellStyle.SelectionBackColor = GridSelectionBg;
            dg.DefaultCellStyle.SelectionForeColor = GridSelectionFg;

            dg.AlternatingRowsDefaultCellStyle.BackColor = GridRowAltBg;
            dg.AlternatingRowsDefaultCellStyle.ForeColor = GridRowFg;
            dg.AlternatingRowsDefaultCellStyle.SelectionBackColor = GridSelectionBg;
            dg.AlternatingRowsDefaultCellStyle.SelectionForeColor = GridSelectionFg;

            dg.RowHeadersVisible = false;
            dg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg.MultiSelect = false;
            dg.ReadOnly = true;
            dg.AllowUserToAddRows = false;
            dg.AllowUserToResizeRows = false;
        }

        public static void StylePrimaryButton(Button btn)
        {
            if (btn == null) return;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = Primary;
            btn.ForeColor = Color.White;
            btn.Font = FontSubtitle;
            btn.Cursor = Cursors.Hand;
            btn.FlatAppearance.MouseOverBackColor = PrimaryHover;
        }

        public static void StyleSecondaryButton(Button btn)
        {
            if (btn == null) return;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 1;
            btn.FlatAppearance.BorderColor = CardBorder;
            btn.BackColor = CardBg;
            btn.ForeColor = TextWhite;
            btn.Font = FontBodyBold;
            btn.Cursor = Cursors.Hand;
            btn.FlatAppearance.MouseOverBackColor = CardBgAlt;
        }

        public static void StyleDangerButton(Button btn)
        {
            if (btn == null) return;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = Danger;
            btn.ForeColor = Color.White;
            btn.Font = FontSubtitle;
            btn.Cursor = Cursors.Hand;
            btn.FlatAppearance.MouseOverBackColor = DangerHover;
        }

        public static void StyleCyanButton(Button btn)
        {
            if (btn == null) return;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = Secondary;
            btn.ForeColor = Color.White;
            btn.Font = FontSubtitle;
            btn.Cursor = Cursors.Hand;
        }

        public static void StyleCard(Panel pnl)
        {
            if (pnl == null) return;
            pnl.BackColor = CardBg;
            pnl.BorderStyle = BorderStyle.None;
        }

        public static void StyleInput(TextBox txt)
        {
            if (txt == null) return;
            txt.BackColor = InputBg;
            txt.ForeColor = TextWhite;
            txt.BorderStyle = BorderStyle.FixedSingle;
            txt.Font = FontBody;
        }

        public static void StyleComboBox(ComboBox cbo)
        {
            if (cbo == null) return;
            cbo.BackColor = InputBg;
            cbo.ForeColor = TextWhite;
            cbo.FlatStyle = FlatStyle.Flat;
            cbo.Font = FontBody;
        }

        public static void StyleNumeric(NumericUpDown nud)
        {
            if (nud == null) return;
            nud.BackColor = InputBg;
            nud.ForeColor = TextWhite;
            nud.BorderStyle = BorderStyle.FixedSingle;
            nud.Font = FontBody;
        }
    }
}
