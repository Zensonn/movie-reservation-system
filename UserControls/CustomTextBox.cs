using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace movie_reservation_system.UserControls
{
    public partial class CustomTextBox : UserControl
    {
        private Color _borderColor = Color.Black;
        private Color _borderFocusedColor = Color.MediumOrchid;
        private int _borderWidth;
        private bool _isFocused;
        private bool _isUnderlined;

        public CustomTextBox()
        {
            InitializeComponent();
        }

        public Color BorderColor
        {
            get => _borderColor;
            set
            {
                _borderColor = value;
                Invalidate();
            }
        }

        public Color BorderFocusedColor
        {
            get => _borderFocusedColor;
            set
            {
                _borderFocusedColor = value;
                Invalidate();
            }
        }

        public int BorderWidth
        {
            get => _borderWidth;
            set
            {
                _borderWidth = value;
                Invalidate();
            }
        }

        public string CustomText
        {
            get => txt.Text;
            set => txt.Text = value;
        }

        public bool IsFocused
        {
            get => _isFocused;
            set
            {
                _isFocused = value;
                Invalidate();
            }
        }

        public bool Multiline
        {
            get => txt.Multiline;
            set => txt.Multiline = value;
        }

        public bool PasswordChar
        {
            get => txt.UseSystemPasswordChar;
            set => txt.UseSystemPasswordChar = value;
        }

        public bool Underline
        {
            get => _isUnderlined;
            set
            {
                _isUnderlined = value;
                Invalidate();
            }
        }

        public override Color BackColor
        {
            get => base.BackColor;
            set
            {
                base.BackColor = value;
                txt.BackColor = value;
            }
        }

        public override Font Font
        {
            get => base.Font;
            set
            {
                base.Font = value;
                txt.Font = value;
                if (DesignMode)
                    UpdateControlHeight();
            }
        }

        public override Color ForeColor
        {
            get => base.ForeColor;
            set
            {
                base.ForeColor = value;
                txt.ForeColor = value;
            }
        }

        public event EventHandler CustomTextChanged;

        private void txt_Click(object sender, EventArgs e)
        {
            OnClick(e);
        }

        private void txt_Enter(object sender, EventArgs e)
        {
            _isFocused = true;
            Invalidate();
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnKeyPress(e);
        }

        private void txt_Leave(object sender, EventArgs e)
        {
            _isFocused = false;
            Invalidate();
        }

        private void txt_MouseEnter(object sender, EventArgs e)
        {
            OnMouseEnter(e);
        }

        private void txt_MouseLeave(object sender, EventArgs e)
        {
            OnMouseLeave(e);
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            CustomTextChanged?.Invoke(sender, e);
        }

        private void UpdateControlHeight()
        {
            if (txt.Multiline)
                return;
            var height = TextRenderer.MeasureText("Text", Font).Height + 1;
            txt.Multiline = true;
            txt.MinimumSize = new Size(0, height);
            txt.Multiline = false;
            Height = txt.Height + Padding.Top + Padding.Bottom;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (var g = e.Graphics)
            {
                using (var pen = new Pen(_borderColor, _borderWidth))
                {
                    pen.Alignment = PenAlignment.Inset;
                    if (_isFocused)
                        pen.Color = _borderFocusedColor;
                    if (_isUnderlined)
                        g.DrawLine(pen, 0, Height - 1, Width, Height - 1);
                    else g.DrawRectangle(pen, 0, 0, Width - 0.5F, Height - 0.5F);
                }
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (DesignMode)
                UpdateControlHeight();
        }
    }
}