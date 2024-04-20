using Library.Model;
using Library.ViewModel.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ViewModel
{
    internal class MainViewModel : BindingHelper
    {
        #region Команды

        public BindableCommand AddCommand { get; set; }
        public BindableCommand DeleteCommand { get; set; }

        #endregion

        #region Книги
        private Books selected = new Books();
        public Books Selected
        {
            get { return selected; }
            set
            {
                selected = value;
                OnPropertyChanged();
            }
        }
        private ObservableCollection<Books> books;
        public ObservableCollection<Books> Books
        {
            get { return books; }
            set
            {
                books = value;
                OnPropertyChanged();
            }
        }
        #endregion Книги

        public MainViewModel()
        {
            AddCommand = new BindableCommand(_ => AddI());
            DeleteCommand = new BindableCommand(_ => DeleteI());

            Books = new ObservableCollection<Books>()
            {
                new Books("Биба и Боба", "София Алексеевна Скорогудаева", "20.09.2006"),
                new Books("Смерть Годжо Сатору", "Татьяна Дмитриевна Артамонова", "27.05.2009"),
                new Books("Основы мироздания Баз Данных", "Елизавета Михайловна Парамонова", "11.06.2002"),
            };
        }

        public void AddI()
        {
            Books.Add(Selected);
        }
        public void DeleteI()
        {
            Books.Remove(Selected);
        } 

    }
}
