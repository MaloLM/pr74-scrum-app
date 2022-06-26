using System.Collections.Generic;
using System.Windows.Forms;

namespace pr74_scrum_app.View
{
    class ListPanel : Panel
    {
        private int elementHeight;
        private List<Control> listControls;  
        public ListPanel() : base()
        {
            listControls = new List<Control>();
            elementHeight = 70;
        }
        public void Add(Control c)
        {
            Format(c);
            listControls.Insert(0,c);
            RefreshControls();
        }
        public void Remove(Control c)
        {
            Controls.Remove(c);
            listControls.Remove(c);
        }
        public void AddTop(Control control)
        {
            ControlCollection cc = Controls;
            Controls.Clear();
            Controls.Add(control);
            foreach (Control c in cc){
                Controls.Add(c);
            }
        }
        public void Format(Control c)
        {
            int width = Size.Width;
            c.Size = new System.Drawing.Size((width-14), elementHeight);
            c.Location = new System.Drawing.Point(7, generateYPosition()+10);
        }
        public void RefreshControls()
        {
            Controls.Clear();
            foreach (Control c in listControls)
            {
                Format(c);
                Controls.Add(c);
            }
        }
        public int Count()
        {
            return listControls.Count;
        }
        public void Clear()
        {
            Controls.Clear();
            listControls.Clear();
        }
        private int generateYPosition()
        {
            return Controls.Count * elementHeight;
        }
    }
}
