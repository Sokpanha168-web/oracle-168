using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace POS_204_oracle
{
    public static class UITheme
    {
        // ==========================================
        // MODERN WHITE & BLUE CORPORATE PALETTE
        // ==========================================
        public static readonly Color BgDark          = Color.FromArgb(240, 244, 249);   // #F0F4F9 (Crisp Soft White Canvas)
        public static readonly Color BgSidebar       = Color.FromArgb(30, 58, 138);     // #1E3A8A (Deep Royal Blue Sidebar)
        public static readonly Color BgHeader        = Color.FromArgb(29, 78, 216);     // #1D4ED8 (Vibrant Royal Blue Header)
        public static readonly Color CardBg          = Color.FromArgb(255, 255, 255);   // #FFFFFF (Pure White Surface)
        public static readonly Color CardBgAlt       = Color.FromArgb(239, 246, 255);   // #EFF6FF (Ice Blue Hover/Alt)
        public static readonly Color CardBorder      = Color.FromArgb(191, 219, 254);   // #BFDBFE (Soft Blue Border)

        // Accent Colors
        public static readonly Color Primary         = Color.FromArgb(37, 99, 235);     // #2563EB (Royal Blue)
        public static readonly Color PrimaryHover    = Color.FromArgb(29, 78, 216);     // #1D4ED8 (Deep Blue Hover)
        public static readonly Color Secondary       = Color.FromArgb(59, 130, 246);    // #3B82F6 (Sky Blue)
        public static readonly Color AccentViolet    = Color.FromArgb(99, 102, 241);    // #6366F1 (Indigo Blue)
        public static readonly Color Warning         = Color.FromArgb(217, 119, 6);     // #D97706 (Amber)
        public static readonly Color Danger          = Color.FromArgb(239, 68, 68);     // #EF4444 (Crimson)
        public static readonly Color DangerHover     = Color.FromArgb(220, 38, 38);

        // Typography Colors
        public static readonly Color TextWhite       = Color.FromArgb(15, 23, 42);      // #0F172A (Deep Slate for Light Bg)
        public static readonly Color TextMuted       = Color.FromArgb(71, 85, 105);     // #475569 (Slate Muted)
        public static readonly Color TextDim         = Color.FromArgb(100, 116, 139);   // #64748B (Dim Slate)

        // Form Inputs
        public static readonly Color InputBg         = Color.FromArgb(255, 255, 255);   // #FFFFFF
        public static readonly Color InputBorder     = Color.FromArgb(191, 219, 254);   // #BFDBFE
        public static readonly Color InputFocus      = Color.FromArgb(37, 99, 235);     // #2563EB

        // Grid
        public static readonly Color GridHeaderBg    = Color.FromArgb(239, 246, 255);   // #EFF6FF
        public static readonly Color GridHeaderFg    = Color.FromArgb(30, 58, 138);     // #1E3A8A
        public static readonly Color GridRowBg       = Color.FromArgb(255, 255, 255);   // #FFFFFF
        public static readonly Color GridRowAltBg    = Color.FromArgb(248, 250, 252);   // #F8FAFC
        public static readonly Color GridRowFg       = Color.FromArgb(15, 23, 42);      // #0F172A
        public static readonly Color GridSelectionBg = Color.FromArgb(219, 234, 254);   // #DBEAFE
        public static readonly Color GridSelectionFg = Color.FromArgb(30, 58, 138);     // #1E3A8A
        public static readonly Color GridLineColor   = Color.FromArgb(226, 232, 240);   // #E2E8F0

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
