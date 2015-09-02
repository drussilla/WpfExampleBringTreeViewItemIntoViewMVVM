using System.Collections;
using System.Collections.ObjectModel;

namespace BringIntoViewMVVMExample
{
    public class TreeViewItemViewModel : ViewModel, IEnumerable
    {
        private bool isSelected;
        private bool isExpanded;
        private string name;

        public TreeViewItemViewModel(string name, bool isExpaded = false)
        {
            Name = name;
            Items = new ObservableCollection<TreeViewItemViewModel>();
            IsExpanded = isExpaded;
        }

        public void Add(TreeViewItemViewModel item)
        {
            Items.Add(item);
        }

        public ObservableCollection<TreeViewItemViewModel> Items { get; private set; } 

        public string Name
        {
            get { return name; }
            set
            {
                if (name != value)
                {
                    name = value;
                    OnPropertyChanged();
                }
            }
        }

        public bool IsSelected
        {
            get { return isSelected; }
            set
            {
                if (isSelected != value)
                {
                    isSelected = value;
                    OnPropertyChanged();
                }
            }
        }

        public bool IsExpanded
        {
            get { return isExpanded; }
            set
            {
                if (isExpanded != value)
                {
                    isExpanded = value;
                    OnPropertyChanged();
                }
            }
        }

        public IEnumerator GetEnumerator()
        {
            return Items.GetEnumerator();
        }
    }
}
