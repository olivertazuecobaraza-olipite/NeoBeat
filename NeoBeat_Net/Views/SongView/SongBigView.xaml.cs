using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeoBeat_Net.Views.SongView;

public partial class SongBigView : ContentView
{
    public SongBigView()
    {
        InitializeComponent();
    }
    
    // Image
    public static readonly BindableProperty SongImageProperty = BindableProperty.Create(nameof(SongImage), typeof(string), typeof(SongBigView), string.Empty);

    public string SongImage
    {
        get => (string)GetValue(SongBigView.SongImageProperty);
        set => SetValue(SongBigView.SongImageProperty, value);
    }
    
    // Name 
    public static readonly BindableProperty SongNameProperty = BindableProperty.Create(nameof(SongName), typeof(string), typeof(SongBigView), string.Empty);

    public string SongName
    {
        get => (string)GetValue(SongBigView.SongNameProperty);
        set => SetValue(SongBigView.SongNameProperty, value);
    }
    
    // Artistic Name
    public static readonly BindableProperty SongArtisticNameProperty = BindableProperty.Create(nameof(SongArtisticName), typeof(string), typeof(SongBigView), string.Empty);

    public string SongArtisticName
    {
        get => (string)GetValue(SongBigView.SongArtisticNameProperty);
        set => SetValue(SongBigView.SongArtisticNameProperty, value);
    }
}