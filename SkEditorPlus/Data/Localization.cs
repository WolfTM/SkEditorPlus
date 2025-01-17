﻿using System.Windows;

namespace SkEditorPlus.Data
{
    // It is class that should override old one
    public class Localization : AvalonEditB.Search.Localization
    {
        public override string NoMatchesFoundText
        {
            get { return (string)Application.Current.FindResource("NoResults"); }
        }
        public override string OneMatchFoundText
        {
            get { return (string)Application.Current.FindResource("OneMatchFound"); }
        }

        public override string SearchTextEmptyText
        {
            get { return (string)Application.Current.FindResource("EmptySearchText"); }
        }
    }
}
