﻿using Couche_Métier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Couche_IHM.Frames
{
    /// <summary>
    /// Logique d'interaction pour FrameAdherent.xaml
    /// </summary>
    public partial class FrameAdherent : Page
    {
        // Représente le manager des adhérents
        private AdhérentManager adhérentManager;

        

        /// <summary>
        /// Cosntructeur du frame adhérent
        /// </summary>
        /// <param name="adhérentManager">manager des adhérents</param>
        public FrameAdherent(AdhérentManager adhérentManager)
        {
            InitializeComponent();
            this.adhérentManager = adhérentManager;

            // Met à jour l'affichage
            UpdateView();
        }


        /// <summary>
        /// Permet de mettre à jour la liste des adhérents
        /// </summary>
        private void UpdateView()
        {
            listAdhérents.ItemsSource = null;
            listAdhérents.ItemsSource = adhérentManager.GetAdhérents();
        }
    }
}