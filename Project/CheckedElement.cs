using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace Project
{
    class CheckedElement 
    {
        public string Name { get; set; } 
    }

    class CheckedElementList : IEnumerable<CheckedElement>, INotifyCollectionChanged
    {
        private ObservableCollection<CheckedElement> _items = new ObservableCollection<CheckedElement>();

        public void Add(CheckedElement item)
        {
            _items.Add(item);
            CollectionChanged?.Invoke(this, new
    NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
        }

        public void Delete(CheckedElement item)
        {
            _items.Remove(item);
            CollectionChanged?.Invoke(this, new
    NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
        }

        public IEnumerator<CheckedElement> GetEnumerator()
        {
            return _items.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _items.GetEnumerator();
        }

        public event NotifyCollectionChangedEventHandler CollectionChanged;
    }
}
