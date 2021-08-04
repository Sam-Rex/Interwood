using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace EOM_stores.Ul
{
    class previewImagecs
    {
        public Panel _prIContainer;
        public PictureBox _prDViewer;



        public Panel prIContainer { get; set; }
        public PictureBox prDViewer{get;set;}


        public void defineContainer()
        {
            _prDViewer = prDViewer;
            _prIContainer = prIContainer;
        }


        public void setViews(int Location1 , int Location2 , Image backgImg )
        {
            _prIContainer.Size = new Size(Location1, Location2);
            _prIContainer.Visible = false;
            _prIContainer.Location = new Point(0, 0);
            _prIContainer.BorderStyle = BorderStyle.FixedSingle;
            _prIContainer.BackColor = Color.White;
            _prIContainer.Padding = new Padding(4,4,4,4);
            _prIContainer.Controls.Add(prDViewer);

            _prDViewer.BackColor = Color.Transparent;
            _prDViewer.BorderStyle = BorderStyle.FixedSingle;
            _prDViewer.BackgroundImage = backgImg;
        }
    }
}
