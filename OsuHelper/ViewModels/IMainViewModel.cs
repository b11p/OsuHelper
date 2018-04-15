﻿using System.Collections.Generic;
using GalaSoft.MvvmLight.CommandWpf;
using OsuHelper.Models;

namespace OsuHelper.ViewModels
{
    public interface IMainViewModel
    {
        bool IsBusy { get; }
        bool HasData { get; }

        double Progress { get; }

        IReadOnlyList<Recommendation> Recommendations { get; }
        Recommendation SelectedRecommendation { get; }

        RelayCommand ViewLoadedCommand { get; }
        RelayCommand ViewClosedCommand { get; }
        RelayCommand ShowAboutCommand { get; }
        RelayCommand ShowSettingsCommand { get; }
        RelayCommand ShowBeatmapDetailsCommand { get; }
        RelayCommand PopulateRecommendationsCommand { get; }
    }
}