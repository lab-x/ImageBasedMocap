﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MoCapStudio.Shared;

namespace MoCapStudio.Controls
{
    public partial class CameraListCtrl : ListBox
    {
        public CameraListCtrl()
        {
            InitializeComponent();
        }

        void SetCameras(List<IMocapRecorder> cameras)
        {

        }
    }
}
