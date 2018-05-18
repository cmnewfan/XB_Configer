﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;

namespace XB_Configer.ItemUI
{
    public partial class NormalItemUI : MetroFramework.Controls.MetroUserControl
    {
        private Image trueValueImage;
        private Image falseValueImage;

        public NormalItemUI()
        {
            InitializeComponent();
        }

        public NormalItemUI(Image trueImage, Image falseImage, String name)
        {
            InitializeComponent();
            this.trueValueImage = trueImage;
            this.falseValueImage = falseImage;
            this.label_ItemName.Text = name;
        }

        public abstract void update(Boolean value)
        {
            if (trueValueImage != null && falseValueImage != null && value!=null)
            {
                if (value)
                {
                    this.label_Value_Normal.Image = trueValueImage;
                }
                else
                {
                    this.label_Value_Normal.Image = falseValueImage;
                }
            }
        }
    }
}
