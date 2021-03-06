﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gruppprojekt
{
    public partial class ShowMorePodcastInfo : Form
    {
        public ShowMorePodcastInfo(List<String> SelectedPodCastInfoList)
        {
            InitializeComponent();
            LoadPodcastInfo(SelectedPodCastInfoList);
           
        }

        private void LoadPodcastInfo(List<String> PodcastInfoList)
        {
            List<String> BoxLabels = new List<String>(new String[] { "Titel - ", "Release datum - ", "Uppspelningar - " });

            for (int i = 0; i < BoxLabels.Count; i++)
            {
                TextBoxShowMore.Text += BoxLabels[i] + PodcastInfoList[i] + Environment.NewLine;
            }

        }
    }
}
