using System;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;

namespace NoteApp.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public ObservableCollection<string> Notes { get; set; }

    public MainWindowViewModel(ObservableCollection<string> notes)
    {
        Notes = notes;
    }
}