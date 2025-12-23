using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NeoBeat_Net.Models.PlayList;

namespace NeoBeat_Net.Views.PlayListView;

public partial class PlayListView : ContentView
{
    public PlayListView()
    {
        InitializeComponent();
    }
    
    // Image
    public static readonly BindableProperty ImagePlayListProperty = BindableProperty.Create(nameof(ImagePlayList), typeof(string), typeof(PlayListView), string.Empty);
    public string ImagePlayList
    {
        get => (string)GetValue(PlayListView.ImagePlayListProperty);
        set => SetValue(PlayListView.ImagePlayListProperty, value);
    }
    
    // Nombre
    public static readonly BindableProperty NamePlayListProperty = BindableProperty.Create(nameof(NamePlayList), typeof(string), typeof(PlayListView), string.Empty);
    public string NamePlayList
    {
        get => (string)GetValue(PlayListView.NamePlayListProperty);
        set => SetValue(PlayListView.NamePlayListProperty, value);
    }
    
    // Tamaño
    public static readonly BindableProperty SizePlayListProperty = BindableProperty.Create(nameof(SizePlayList), typeof(string), typeof(PlayListView), string.Empty);
    public string SizePlayList
    {
        get => (string)GetValue(PlayListView.SizePlayListProperty);
        set => SetValue(PlayListView.SizePlayListProperty, value);
    }
    
}