﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            c.Size = new System.Drawing.Size((width-30), elementHeight);
            c.Location = new System.Drawing.Point(0, generateYPosition());
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
        private int generateYPosition()
        {
            return Controls.Count * elementHeight;
        }
    }
}