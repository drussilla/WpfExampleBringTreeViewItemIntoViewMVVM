using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace BringIntoViewMVVMExample
{
    public class MainWindowViewModel : ViewModel
    {
        public ObservableCollection<TreeViewItemViewModel> Items { get; }

        public MainWindowViewModel()
        {
            Items = new ObservableCollection<TreeViewItemViewModel>
            {
                new TreeViewItemViewModel("Item 1", true)
                {
                    new TreeViewItemViewModel("Sub Item 1"),
                    new TreeViewItemViewModel("Sub Item 2"),
                    new TreeViewItemViewModel("Sub Item 3")
                },
                new TreeViewItemViewModel("Item 2"),
                new TreeViewItemViewModel("Item 3")
                {
                    new TreeViewItemViewModel("Sub Item 1"),
                    new TreeViewItemViewModel("Sub Item 2"),
                    new TreeViewItemViewModel("Sub Item 3")
                },
                new TreeViewItemViewModel("Item 4"),
                new TreeViewItemViewModel("Item 5", true)
                {
                    new TreeViewItemViewModel("Sub Item 1"),
                    new TreeViewItemViewModel("Sub Item 2"),
                    new TreeViewItemViewModel("Sub Item 3"),
                },
                new TreeViewItemViewModel("Item 6"),
                new TreeViewItemViewModel("Item 7"),
                new TreeViewItemViewModel("Item 8"),
                new TreeViewItemViewModel("Item 9"),
                new TreeViewItemViewModel("Item 10"),
                new TreeViewItemViewModel("Item 11")
            };
        }

        public ICommand SelectLastCommand => new Command(() => Items.Last().IsSelected = true);
    }
}