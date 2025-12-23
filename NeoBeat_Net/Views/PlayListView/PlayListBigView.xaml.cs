using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeoBeat_Net.Views.PlayListView;

public partial class PlayListBigView : ContentView
{
    public PlayListBigView()
    {
        InitializeComponent();
    }
    
    // Image
    public static readonly BindableProperty ImagePlayListProperty = BindableProperty.Create(nameof(ImagePlayList), typeof(string), typeof(PlayListBigView), string.Empty);
    public string ImagePlayList
    {
        get => (string)GetValue(PlayListBigView.ImagePlayListProperty);
        set => SetValue(PlayListBigView.ImagePlayListProperty, value);
    }
}