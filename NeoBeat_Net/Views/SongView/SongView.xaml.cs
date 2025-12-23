using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeoBeat_Net.Views.SongView;

public partial class SongView : ContentView
{
    public SongView()
    {
        InitializeComponent();
    }
    
    // Image
    public static readonly BindableProperty SongImageProperty = BindableProperty.Create(nameof(SongImage), typeof(string), typeof(SongView), string.Empty);

    public string SongImage
    {
        get => (string)GetValue(SongView.SongImageProperty);
        set => SetValue(SongView.SongImageProperty, value);
    }
    
    // Name
    public static readonly BindableProperty SongNameProperty = BindableProperty.Create(nameof(SongName), typeof(string), typeof(SongView), string.Empty);

    public string SongName
    {
        get =>  (string)GetValue(SongView.SongNameProperty);
        set => SetValue(SongView.SongNameProperty, value);
    }
    
    // Duration
    public static readonly BindableProperty SongDurationProperty = BindableProperty.Create(nameof(SongDuration), typeof(int), typeof(SongView), 0);

    public int SongDuration
    {
        get => (int)GetValue(SongView.SongDurationProperty);
        set => SetValue(SongView.SongDurationProperty, value);
    }
}