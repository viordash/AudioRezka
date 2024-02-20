using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioRezkaApp.Helpers {
    internal class FormsHelper {
        public static TForm OpenOrCreateNew<TForm>() where TForm : Form, new() {
            var form = Application.OpenForms.OfType<TForm>().FirstOrDefault();
            if(form == null) {
                form = new TForm();
            }
            return form;
        }

        public static void LoadLocation(Point point, Form form) {
            if(!point.IsEmpty
                && point.X + form.Width >= 0
                && point.Y + form.Height >= 0
                && Screen.AllScreens.Any(x => x.Bounds.Contains(point))) {
                form.Left = point.X;
                form.Top = point.Y;
            }
        }

        public static void LoadSize(Size size, Form form) {
            if(!size.IsEmpty
                && Screen.PrimaryScreen?.Bounds.Size.Width > size.Width
                && Screen.PrimaryScreen?.Bounds.Size.Height > size.Height) {
                form.Width = size.Width;
                form.Height = size.Height;
            }
        }
    }
}
