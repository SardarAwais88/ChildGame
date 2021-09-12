using ChildGame.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace ChildGame.ViewModels
{
  public  class AlphabetViewModels
    {
        public ObservableCollection <AlphabetItem> alphabetItems { get; set; }
        public AlphabetViewModels()
        {
            alphabetItems = new ObservableCollection<AlphabetItem>();
            alphabetItems.Add(new AlphabetItem(
                "A", "B", "C", "D", "E", "F", "G", "H", "I", "J",
 "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T",
 "U", "V", "W", "X", "Y", "Z"));
            alphabetItems.ToString();
        }
    }
}
