using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace WinFormsDragMove
{
    /// <summary>
    /// Provides extension methods for automatic dragging of Windows Forms controls
    /// </summary>
    public static partial class DragMoveExtensions
    {
        private static Dictionary<IntPtr, DraggedControl> draggedControls = new Dictionary<IntPtr, DraggedControl>();

        /// <summary>
        /// Temporarily enables the DragMove behavior for the specified control, until the mouse button is released.
        /// </summary>
        /// <param name="ctl">The control to drag</param>
#if FX_20
        public static void DragMove(Control ctl)
#else
        public static void DragMove(this Control ctl)
#endif
        {
            Point absolutePosition = Control.MousePosition;
            Point relativePosition = ctl.PointToClient(absolutePosition);
            new DraggedControl(ctl, relativePosition.X, relativePosition.Y);
        }

        /// <summary>
        /// Enables or disables the DragMove behavior for the specified control.
        /// </summary>
        /// <param name="ctl">The control for which the DragMove behavior must be enabled or disabled</param>
        /// <param name="value">A value indicating whether to enable or disable the DragMove behavior</param>
#if FX_20
        public static void EnableDragMove(Control ctl, bool value)
#else
        public static void EnableDragMove(this Control ctl, bool value)
#endif
        {
            if (value)
            {
                if (!draggedControls.ContainsKey(ctl.Handle))
                    draggedControls.Add(ctl.Handle, new DraggedControl(ctl));
            }
            else
            {
                if (draggedControls.ContainsKey(ctl.Handle))
                {
                    draggedControls[ctl.Handle].Dispose();
                    draggedControls.Remove(ctl.Handle);
                }
            }
        }

        /// <summary>
        /// Checks whether the DragMove behavior is enabled for the specified control
        /// </summary>
        /// <param name="ctl">The control to check</param>
        /// <returns>true if DragMove is enabled for this control; otherwise, false</returns>
#if FX_20
        public static bool IsDragMoveEnabled(Control ctl)
#else
        public static bool IsDragMoveEnabled(this Control ctl)
#endif
        {
            return draggedControls.ContainsKey(ctl.Handle);
        }

        private class DraggedControl : IDisposable
        {
            public Control Target { get; private set; }
            public int XStart { get; private set; }
            public int YStart { get; private set; }
            public bool IsMoving { get; private set; }
            public bool IsTemporary { get; set; }

            public DraggedControl(Control target)
            {
                Target = target;
                IsMoving = false;
                IsTemporary = false;
                Target.MouseDown += Target_MouseDown;
                Target.MouseMove += Target_MouseMove;
                Target.MouseUp += Target_MouseUp;
                Target.Disposed += Target_Disposed;
            }

            public DraggedControl(Control target, int xStart, int yStart)
                : this(target)
            {
                XStart = xStart;
                YStart = yStart;
                IsMoving = (Control.MouseButtons & MouseButtons.Left) == MouseButtons.Left;
                IsTemporary = true;
            }

            void Target_MouseDown(object sender, MouseEventArgs e)
            {
                if (e.Button == MouseButtons.Left)
                {
                    IsMoving = true;
                    XStart = e.X;
                    YStart = e.Y;
                }
            }

            void Target_MouseUp(object sender, MouseEventArgs e)
            {
                IsMoving = false;
                if (IsTemporary)
                {
                    Dispose();
                }
            }

            private void Target_MouseMove(object sender, MouseEventArgs e)
            {
                if (IsMoving)
                {
                    int x = Target.Location.X + e.X - XStart;
                    int y = Target.Location.Y + e.Y - YStart;
                    Target.Location = new Point(x, y);
                }
            }

            void Target_Disposed(object sender, EventArgs e)
            {
#if FX_20
                EnableDragMove(Target, false);
#else
                Target.EnableDragMove(false);
#endif
            }

            public void Dispose()
            {
                Target.MouseDown -= Target_MouseDown;
                Target.MouseMove -= Target_MouseMove;
                Target.MouseUp -= Target_MouseUp;
                Target.Disposed -= Target_Disposed;
                Target = null;
            }
        }

    }
}