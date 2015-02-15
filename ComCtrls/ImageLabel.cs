﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing.Imaging;

namespace ComCtrls
{
    public partial class ImageLabel : UserControl
    {
        public class SimpleImagesContaner : Component
        {

            public SimpleImagesContaner()
            {
                ownerlst = new List<Control>();
            }

            private List<Control> ownerlst = null;

            public void AddOwner(Control Owner)
            {
                ownerlst.Add(Owner);
            }

            public void RemoveOwner(Control Owner)
            {
                ownerlst.Remove(Owner);
            }

            public void DoRefresh()
            {
                foreach (Control c in ownerlst)
                {
                    c.Invalidate();
                }
            }

            private Image backimg = null;
            public Image BackImg
            {
                get
                {
                    return backimg;
                }
                set
                {
                    backimg = value;
                    this.DoRefresh();
                }
            }

            private Image imgdisable = null;
            public Image ImgDisable
            {
                get
                {
                    return imgdisable;
                }
                set
                {
                    imgdisable = value;
                    this.DoRefresh();
                }
            }

            private Image icon = null;
            public Image Icon
            {
                get
                {
                    return icon;
                }
                set
                {
                    icon = value;
                    this.DoRefresh();
                }
            }
        }



        public ImageLabel()
        {
            InitializeComponent();
            this.Size = new Size(21, 8);
        }

        private Bitmap m_bmpOffscreen;

        protected override void OnResize(EventArgs e)
        {
            if (m_bmpOffscreen == null) //Bitmap for doublebuffering
            {
                m_bmpOffscreen = new Bitmap(ClientSize.Width, ClientSize.Height);
            }
            else
            {
                m_bmpOffscreen.Dispose();

                m_bmpOffscreen = new Bitmap(ClientSize.Width, ClientSize.Height);
            }

            base.OnResize(e);
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            //Do nothing
        }

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            Graphics gxOff; //Offscreen graphics
            Rectangle imgRect; //image rectangle
            Brush backBrush; //brush for filling a backcolor
            Pen framepen;//pen for draw frame

            if (m_bmpOffscreen == null) //Bitmap for doublebuffering
            {
                m_bmpOffscreen = new Bitmap(ClientSize.Width, ClientSize.Height);
            }

            gxOff = Graphics.FromImage(m_bmpOffscreen);

            gxOff.Clear(this.BackColor);

            //添加了ImageButton 的自绘背景及图标的功能，并通过聚合SimpleImagesContaner以优化资源分配 by cs at 2009-1-20  {295CEBAC-5099-403c-90BF-DD86BC58264D} 
            //if (bgimage != null)
            if ((IMGContainer != null) &&
                (IMGContainer.BackImg != null) &&
                (IMGContainer.ImgDisable != null)
                )
            {
                Image bgimage;

                if (!Enabled)
                    bgimage = IMGContainer.ImgDisable;
                else
                    bgimage = IMGContainer.BackImg;

                //Center the image relativelly to the control
                int imageLeft = (this.Width - bgimage.Width) / 2;
                int imageTop = (this.Height - bgimage.Height) / 2;

                imgRect = new Rectangle(imageLeft, imageTop, bgimage.Width, bgimage.Height);

                if (this.TransParent)
                {
                    //Set transparent key
                    ImageAttributes imageAttr = new ImageAttributes();
                    imageAttr.SetColorKey(BackgroundImageColor(bgimage), BackgroundImageColor(bgimage));

                    //Draw image
                    gxOff.DrawImage(bgimage, imgRect, 0, 0, bgimage.Width, bgimage.Height, GraphicsUnit.Pixel, imageAttr);
                }
                else
                {
                    gxOff.DrawImage(bgimage, imgRect, new Rectangle(0, 0, bgimage.Width, bgimage.Height), GraphicsUnit.Pixel);

                }
            }
            else //draw frame
            {
                {
                    //gray
                    framepen = new Pen(Color.Gray, 1);
                    gxOff.DrawRectangle(framepen, 0, 0, ClientSize.Width - 2, ClientSize.Height - 2);


                    //white
                    framepen = new Pen(System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(127)))), ((int)(((byte)(181))))), 1);
                    gxOff.DrawLine(framepen, 1, 1, ClientSize.Width - 3, 1);
                    gxOff.DrawLine(framepen, 1, 1, 1, ClientSize.Height - 3);

                    //black
                    framepen = new Pen(Color.Black, 1);
                    gxOff.DrawLine(framepen, ClientSize.Width - 1, ClientSize.Height - 1, 0, ClientSize.Height - 1);
                    gxOff.DrawLine(framepen, ClientSize.Width - 1, ClientSize.Height - 1, ClientSize.Width - 1, 0);

                }
            }


            //todo: icon
            //添加了ImageButton 的自绘背景及图标的功能，并通过聚合SimpleImagesContaner以优化资源分配 by cs at 2009-1-20  {295CEBAC-5099-403c-90BF-DD86BC58264D} 
            //if (Icon != null)
            if ((IMGContainer != null) &&
                (IMGContainer.Icon != null))
            {

                //Layout

                //Center the image relativelly to the control
                int imageLeft = (this.Width - IMGContainer.Icon.Width) / 2;
                int imageTop = (this.Height - IMGContainer.Icon.Height) / 2;

                imgRect = new Rectangle(imageLeft, imageTop, IMGContainer.Icon.Width, IMGContainer.Icon.Height);

                if (this.TransParent)
                {
                    //Set transparent key
                    ImageAttributes imageAttr = new ImageAttributes();
                    imageAttr.SetColorKey(BackgroundImageColor(IMGContainer.Icon), BackgroundImageColor(IMGContainer.Icon));

                    //Draw image
                    gxOff.DrawImage(IMGContainer.Icon, imgRect, 0, 0, IMGContainer.Icon.Width, IMGContainer.Icon.Height, GraphicsUnit.Pixel, imageAttr);
                }
                else
                {
                    gxOff.DrawImage(IMGContainer.Icon, imgRect, new Rectangle(0, 0, IMGContainer.Icon.Width, IMGContainer.Icon.Height), GraphicsUnit.Pixel);

                }
            }
            else
            {
                if (Text != string.Empty)//todo:text no icon
                {
                    if (this.Enabled)
                    {
                        backBrush = new SolidBrush(this.ForeColor);
                    }
                    else
                    {
                        backBrush = new SolidBrush(Color.Gray);
                    }

                    gxOff.DrawString(this.Text, this.Font, backBrush,
                        (this.ClientSize.Width - gxOff.MeasureString(this.Text, this.Font).Width) / 2,
                        (this.ClientSize.Height - gxOff.MeasureString(this.Text, this.Font).Height) / 2);
                }
            }

            e.Graphics.DrawImage(m_bmpOffscreen, 0, 0);

            //base.OnPaint(e);
        }

        #region Property
        public new bool Enabled
        {
            get
            {
                return base.Enabled;
            }
            set
            {
                base.Enabled = value;
                this.Refresh();
            }
        }



        private bool transparent;
        [DefaultValue(false)]
        public bool TransParent
        {
            get
            {
                return transparent;
            }
            set
            {
                transparent = value;
                this.Invalidate();
            }
        }

        private SimpleImagesContaner imglst = null;
        public SimpleImagesContaner IMGContainer
        {
            get
            {
                return imglst;
            }
            set
            {
                if (imglst != value)
                {
                    if (imglst != null)
                        imglst.RemoveOwner(this);

                    imglst = value;

                    if (value != null)
                        value.AddOwner(this);

                    this.Invalidate();
                }
            }
        }

        public override string Text
        {
            get
            {
                return base.Text;
            }
            set
            {
                base.Text = value;

                this.Invalidate();
            }
        }

        private KTLayout layout;
        [DefaultValue(KTLayout.GlyphTop)]
        public KTLayout Layout
        {
            get
            {
                return layout;
            }
            set
            {
                if (layout != value)
                {
                    layout = value;
                    this.Invalidate();
                }
            }
        }



        #endregion

        private Color BackgroundImageColor(Image image)
        {
            Bitmap bmp = new Bitmap(image);
            return bmp.GetPixel(0, 0);
        }


    }
}
