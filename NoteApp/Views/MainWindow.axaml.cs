using System.Collections.ObjectModel;
using Avalonia.Controls;
using Avalonia.Interactivity;
using NoteApp.ViewModels;

namespace NoteApp.Views;

public partial class MainWindow : Window
{
    // Коллекция заметок
    //public ObservableCollection<string> Notes { get; set; }
    
    public MainWindow()
    {
        InitializeComponent();
        // Установка DataContext для привязки
        DataContext = new MainWindowViewModel(new ObservableCollection<string>());
        
    }

    // Добавление новой заметки
    private void OnAddNoteClick(object sender, RoutedEventArgs e)
    {
        var viewModel = DataContext as MainWindowViewModel;
        if (viewModel != null && !string.IsNullOrWhiteSpace(NoteInput.Text))
        {
            viewModel.Notes.Add(NoteInput.Text);
            NoteInput.Text = string.Empty;
        }
    }

    // Удаление заметки
    private void OnDeleteNoteClick(object sender, RoutedEventArgs e)
    {
        var viewModel = DataContext as MainWindowViewModel;
        Button button = sender as Button;
        if (button != null && button.DataContext is string note)
        {
            viewModel.Notes.Remove(note); // Удаление выбранной заметки
        }
    }
}